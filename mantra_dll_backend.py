#!/usr/bin/env python3
"""
Python bridge for MantraBioTimeDLL (.NET assembly) using pythonnet.

This adapter exposes a pyzk-like interface for the project scripts.
"""

from __future__ import annotations

import os
import platform
import sys
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path
from typing import Any, List, Optional, Tuple


@dataclass
class AttendanceRecord:
    user_id: str
    timestamp: datetime
    status: int
    punch: int


@dataclass
class UserRecord:
    uid: int
    user_id: str
    name: str
    privilege: int
    card: str


class MantraDLLException(Exception):
    pass


class DllConnection:
    """
    ZK-compatible connection wrapper backed by MantraBioTimeDLL.
    """

    def __init__(
        self,
        ip: str,
        port: int = 8080,
        password: int = 0,
        device_id: int = 1,
        device_type: int = 2,
        library_root: Optional[str] = None,
        arch: Optional[str] = None,
    ) -> None:
        self.ip = ip
        self.port = int(port)
        self.password = int(password)
        self.device_id = int(device_id)
        self.device_type = int(device_type)
        self.library_root = Path(library_root) if library_root else Path(__file__).resolve().parent / "Library"
        self.arch = arch or ("x64" if "64" in platform.architecture()[0] else "x86")
        self.connected = False

        self._load_sdk()

    def _load_sdk(self) -> None:
        try:
            import clr  # type: ignore
        except Exception as exc:
            msg = str(exc)
            if "Could not find libmono" in msg or "default .NET runtime" in msg:
                raise MantraDLLException(
                    "pythonnet is installed but no compatible .NET runtime was found.\n"
                    "On Linux for this SDK, install Mono runtime (libmono):\n"
                    "  sudo apt update && sudo apt install -y mono-complete libmono-2.0-1\n"
                    f"Original error: {msg}"
                ) from exc
            raise MantraDLLException(
                "Failed to import pythonnet runtime bridge.\n"
                "Install pythonnet in the same interpreter: pip install pythonnet\n"
                f"Original error: {msg}"
            ) from exc

        lib_dir = self.library_root / self.arch
        dll_path = lib_dir / "MantraBioTimeDLL.dll"
        if not dll_path.exists():
            raise MantraDLLException(f"MantraBioTimeDLL.dll not found at: {dll_path}")

        os.environ["PATH"] = str(lib_dir) + os.pathsep + os.environ.get("PATH", "")
        if str(lib_dir) not in sys.path:
            sys.path.insert(0, str(lib_dir))

        try:
            clr.AddReference(str(dll_path))
            clr.AddReference("System.Data")
        except Exception as exc:
            msg = str(exc)
            if "invalid ELF header" in msg or "DllNotFoundException" in msg:
                raise MantraDLLException(
                    "Mantra DLL backend relies on Windows native DLL dependencies "
                    "(e.g. SBXPCDLL*.dll), which are not Linux ELF binaries.\n"
                    "Use --backend pyzk on Linux, or run DLL mode on Windows."
                ) from exc
            raise MantraDLLException(f"Failed to load .NET DLLs from {lib_dir}: {msg}") from exc

        try:
            from MantraBioTimeDLL import (  # type: ignore
                DemographicsList,
                MantraBT_CapacityInfo,
                MantraBT_DeviceInfo,
                MantraBioTime,
                MantraBioTimeException,
            )
            from System import String  # type: ignore
            from System.Collections.Generic import List as DotNetList  # type: ignore
            from System.Data import DataTable  # type: ignore
        except Exception as exc:
            raise MantraDLLException(f"Failed importing SDK symbols: {exc}") from exc

        self._clr = clr
        self._MantraBioTime = MantraBioTime
        self._MantraBioTimeException = MantraBioTimeException
        self._MantraBT_DeviceInfo = MantraBT_DeviceInfo
        self._MantraBT_CapacityInfo = MantraBT_CapacityInfo
        self._DemographicsList = DemographicsList
        self._DotNetList = DotNetList
        self._DataTable = DataTable
        self._String = String

    def _msg(self, code: int) -> str:
        try:
            return str(self._MantraBioTimeException.MsgCode(int(code)))
        except Exception:
            return f"SDK error code: {code}"

    def _call_with_out(self, method: Any, out_ctor: Any, *args: Any) -> Tuple[int, Any]:
        # Attempt 1: direct mutable/out object passing
        try:
            out_obj = out_ctor()
            ret = method(*args, out_obj)
            return int(ret), out_obj
        except Exception:
            pass

        # Attempt 2: explicit clr.Reference[T]
        try:
            out_obj = out_ctor()
            ref_obj = self._clr.Reference[type(out_obj)](out_obj)
            ret = method(*args, ref_obj)
            return int(ret), ref_obj.Value
        except Exception as exc:
            raise MantraDLLException(f"Failed calling SDK method '{method.__name__}' with out/ref arg: {exc}") from exc

    def connect(self) -> "DllConnection":
        code = int(
            self._MantraBioTime.ConnectTCP(
                self.device_id, self.ip, self.port, self.password, self.device_type
            )
        )
        if code != 0:
            raise MantraDLLException(self._msg(code))
        self.connected = True
        return self

    def disconnect(self) -> None:
        if not self.connected:
            return
        self._MantraBioTime.DisConnectTCP(self.device_id, self.device_type)
        self.connected = False

    def _refresh_device_info(self) -> None:
        code = int(self._MantraBioTime.DeviceInfo(self.device_type))
        if code != 0:
            raise MantraDLLException(self._msg(code))

    def _refresh_capacity_info(self) -> None:
        code = int(self._MantraBioTime.CapacityInfo(self.device_type))
        if code != 0:
            raise MantraDLLException(self._msg(code))

    def get_firmware_version(self) -> str:
        self._refresh_device_info()
        return str(self._MantraBT_DeviceInfo.FirmwareVersion)

    def get_serialnumber(self) -> str:
        self._refresh_device_info()
        return str(self._MantraBT_DeviceInfo.SerialNumber)

    def get_platform(self) -> str:
        self._refresh_device_info()
        return str(self._MantraBT_DeviceInfo.PlatForm)

    def get_device_name(self) -> str:
        self._refresh_device_info()
        return str(self._MantraBT_DeviceInfo.DeviceName)

    def get_mac(self) -> str:
        self._refresh_device_info()
        return str(self._MantraBT_DeviceInfo.Mac)

    def get_time(self) -> str:
        code, out_time = self._call_with_out(self._MantraBioTime.GetDeviceTime, self._String, self.device_type)
        if code != 0:
            raise MantraDLLException(self._msg(code))
        return str(out_time)

    def get_users(self) -> List[UserRecord]:
        dotnet_users = self._DotNetList[self._DemographicsList]()
        try:
            code = int(self._MantraBioTime.GetUserInfo(self.device_type, "", dotnet_users))
        except Exception:
            code, dotnet_users = self._call_with_out(
                self._MantraBioTime.GetUserInfo,
                lambda: self._DotNetList[self._DemographicsList](),
                self.device_type,
                "",
            )
        if code != 0:
            raise MantraDLLException(self._msg(code))

        users: List[UserRecord] = []
        idx = 1
        for u in dotnet_users:
            users.append(
                UserRecord(
                    uid=idx,
                    user_id=str(getattr(u, "UserId", "")),
                    name=str(getattr(u, "UserName", "")),
                    privilege=int(getattr(u, "Privilege", 0)),
                    card=str(getattr(u, "Card", "")),
                )
            )
            idx += 1
        return users

    def _datatable_rows_to_attendance(self, dt: Any) -> List[AttendanceRecord]:
        records: List[AttendanceRecord] = []
        for row in dt.Rows:
            raw_dt = str(row["VDateTime"])
            try:
                ts = datetime.strptime(raw_dt, "%Y-%m-%d %H:%M:%S")
            except ValueError:
                ts = datetime.fromisoformat(raw_dt.replace(" ", "T"))

            records.append(
                AttendanceRecord(
                    user_id=str(row["UserId"]),
                    timestamp=ts,
                    status=int(row["VerifyType"]),
                    punch=int(row["VerifyMode"]),
                )
            )
        return records

    def get_attendance(self) -> List[AttendanceRecord]:
        code, dt = self._call_with_out(self._MantraBioTime.ReadAllLogData, self._DataTable, self.device_type)
        if code != 0:
            if code == -2000:
                return []
            raise MantraDLLException(self._msg(code))
        return self._datatable_rows_to_attendance(dt)

    def get_attendance_between(self, from_date: str, to_date: str) -> List[AttendanceRecord]:
        code, dt = self._call_with_out(
            self._MantraBioTime.TimePeriodLogData,
            self._DataTable,
            self.device_type,
            from_date,
            to_date,
        )
        if code != 0:
            if code == -2000:
                return []
            raise MantraDLLException(self._msg(code))
        return self._datatable_rows_to_attendance(dt)

    def get_capacity(self) -> dict:
        self._refresh_capacity_info()
        return {
            "admin_count": int(self._MantraBT_CapacityInfo.AdminCnt),
            "user_count": int(self._MantraBT_CapacityInfo.UserCount),
            "fp_count": int(self._MantraBT_CapacityInfo.FpCnt),
            "record_count": int(self._MantraBT_CapacityInfo.recordCnt),
            "pwd_count": int(self._MantraBT_CapacityInfo.PwdCnt),
            "card_count": int(self._MantraBT_CapacityInfo.CardCnt),
            "oplog_count": int(self._MantraBT_CapacityInfo.OpLogCnt),
            "face_count": int(self._MantraBT_CapacityInfo.FaceCnt),
        }
