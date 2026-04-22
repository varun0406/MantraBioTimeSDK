# Windows Full Summary - Mantra BioTime SDK Integration

## 1) Goal

We are building Python scripts to communicate with a Mantra Bio-Face/BioTime attendance device, with primary support for:

- Official Mantra Windows SDK (`MantraBioTimeDLL.dll`)
- Attendance log pull, filtering, display, and export
- Device info and user listing
- Connection scan and diagnostics

The target production environment for the SDK DLL backend is **Windows**.

---

## 2) Why Windows Is Required for DLL Mode

The Mantra SDK package includes:

- `MantraBioTimeDLL.dll` (.NET assembly)
- Multiple native dependency DLLs (`SBXPCDLL64.dll`, `tcpcomm.dll`, etc.)

These dependencies are Windows PE binaries and require Windows runtime behavior.
On Linux, even with `pythonnet` + Mono, native dependency loading fails (`invalid ELF header`), so DLL mode is not reliable there.

Therefore:

- **Windows PC** -> Use `--backend dll` (main path)
- **Linux** -> Use `--backend pyzk` (fallback path)

---

## 3) What Has Been Implemented

### A) New DLL backend bridge

Added file:

- `mantra_dll_backend.py`

What it does:

- Loads `MantraBioTimeDLL.dll` via `pythonnet` (`clr`)
- Selects architecture folder (`Library/x64` or `Library/x86`)
- Wraps SDK methods into a Python-friendly connection object:
  - `ConnectTCP` / `DisConnectTCP`
  - `DeviceInfo` / `CapacityInfo`
  - `GetDeviceTime`
  - `GetUserInfo`
  - `ReadAllLogData`
  - `TimePeriodLogData`
- Converts SDK output (DataTable/list types) into Python objects used by scripts

### B) `test_connection.py` updated

- Added CLI arguments:
  - `--ip`
  - `--port`
  - `--password`
  - `--backend {dll,pyzk}`
- Backend defaults by OS:
  - Windows default: `dll`
  - Linux default: `pyzk`

### C) `pull_attendance.py` updated

- Added backend switch:
  - `--backend {dll,pyzk}`
- Backend defaults by OS:
  - Windows default: `dll`
  - Linux default: `pyzk`
- Uses SDK date-range API when possible (`TimePeriodLogData`)
- Keeps CSV/JSON export features
- Keeps user list and device info features

### D) `scan_device.py` updated

- Added backend switch:
  - `--backend {dll,pyzk}`
- Backend defaults by OS:
  - Windows default: `dll`
  - Linux default: `pyzk`
- Can scan and test connection through DLL mode on Windows

### E) Default device IP consistency

All scripts aligned to default:

- `192.168.0.250`

---

## 4) Files You Should Use on Windows

Core scripts:

- `test_connection.py`
- `scan_device.py`
- `pull_attendance.py`
- `mantra_dll_backend.py`

SDK dependency folders:

- `Library/x64/` (for 64-bit Python)
- `Library/x86/` (for 32-bit Python)

Command docs:

- `RUN_COMMANDS.md`

---

## 5) Windows Setup Steps

Open terminal in project directory:

```bat
cd C:\path\to\MantraBioTimeSDK
```

Create and activate venv:

```bat
py -m venv venv
venv\Scripts\activate
```

Install dependencies:

```bat
pip install --upgrade pip
pip install pythonnet pyzk
```

---

## 6) Recommended Windows Test Flow

### Step 1: Basic connection test (DLL)

```bat
python test_connection.py --backend dll --ip 192.168.0.250 --port 8080
```

Expected:

- Connected
- Device firmware/serial/platform/name/MAC
- User and attendance counts (if available)

### Step 2: Scan common ports/configs (DLL)

```bat
python scan_device.py --backend dll --ip 192.168.0.250
```

Expected:

- Ping check
- Open ports list
- Working SDK connect combo (if found)

### Step 3: Pull attendance (DLL)

All logs:

```bat
python pull_attendance.py --backend dll --ip 192.168.0.250 --port 8080
```

Date range:

```bat
python pull_attendance.py --backend dll --ip 192.168.0.250 --port 8080 --from 2026-04-01 --to 2026-04-16
```

Export:

```bat
python pull_attendance.py --backend dll --export csv
python pull_attendance.py --backend dll --export json
```

Device info / user list:

```bat
python pull_attendance.py --backend dll --device-info
python pull_attendance.py --backend dll --users
```

---

## 7) Architecture / Bitness Rule (Important)

Python architecture must match SDK native dependency architecture.

- If Python is 64-bit -> use DLLs from `Library/x64`
- If Python is 32-bit -> use DLLs from `Library/x86`

Check Python bitness:

```bat
python -c "import platform; print(platform.architecture())"
```

---

## 8) Known Error Patterns and Fixes (Windows)

### Error: module `zk` not found

Fix:

```bat
pip install pyzk
```

### Error related to `pythonnet` / `clr`

Fix:

```bat
pip install pythonnet
```

Make sure command is run inside the same activated venv.

### Error: connection timeout

Checks:

- Device reachable on network (`ping 192.168.0.250`)
- Correct port (`8080` or `4370`)
- Correct communication password
- PC and device on same subnet

### Error: SDK returns `Exception Unhandle` (-2001)

Possible causes:

- Wrong port/password
- Device-side protocol mismatch
- Native dependency issue due to bitness mismatch

Actions:

- Re-check architecture alignment
- Try `scan_device.py --backend dll`
- Try alternate port (`4370`)

---

## 9) Current Project Status

- DLL backend integration completed in Python.
- CLI backend selection is implemented across scripts.
- OS-aware backend defaults are in place.
- Syntax checks passed for updated Python scripts.
- Linux DLL mode investigation completed (platform limitation identified).
- Windows is the intended environment for full SDK DLL behavior.

---

## 10) Quick Operational Recommendation

For the Windows PC run:

1. `test_connection.py` (DLL)
2. `scan_device.py` (DLL)
3. `pull_attendance.py` (DLL)

If all three pass, you can treat the Windows setup as ready for regular attendance pulls and export automation.
