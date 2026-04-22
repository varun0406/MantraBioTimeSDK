#!/usr/bin/env python3
"""
Mantra BioTime Attendance Log Puller for Ubuntu/Linux.

Uses pyzk library to communicate with Mantra Bio-Face / BioTime devices
via the ZKTeco TCP protocol (same protocol the Windows SDK wraps).

Device Config:
    Device Name : JAY COPPER
    Device Type : Bio-Face (DeviceType=2)
    Device IP   : 192.168.0.250
    Device Port : 8080
    Password    : None

Usage:
    python3 pull_attendance.py                         # Pull all logs
    python3 pull_attendance.py --from 2026-04-01       # From date
    python3 pull_attendance.py --from 2026-04-01 --to 2026-04-16  # Date range
    python3 pull_attendance.py --backend dll            # Use Mantra DLL backend
    python3 pull_attendance.py --backend pyzk           # Use pyzk backend
    python3 pull_attendance.py --export csv             # Export to CSV
    python3 pull_attendance.py --export json            # Export to JSON
    python3 pull_attendance.py --users                  # List all users
    python3 pull_attendance.py --device-info             # Show device info
"""

import argparse
import csv
import json
import os
import platform
import sys
from datetime import datetime

# ─── Device Configuration ──────────────────────────────────────────────
DEVICE_IP   = "192.168.0.250"
DEVICE_PORT = 8080
DEVICE_PASS = 0        # 0 = no password
TIMEOUT     = 10
DEVICE_ID   = 1
DEVICE_TYPE = 2
DEFAULT_BACKEND = "dll" if platform.system().lower().startswith("win") else "pyzk"

# ─── Verify Mode Mapping (from SDK docs, DeviceType=2) ─────────────────
VERIFY_TYPE_MAP = {
    1: "FP",
    2: "PASSWORD",
    3: "CARD",
    4: "FP+CARD",
    5: "FP+PASSWORD",
    6: "CARD+PASSWORD",
    7: "FP+CARD+PASSWORD",
    10: "HAND LOCK",
    11: "PROG LOCK",
    12: "PROG OPEN",
    13: "PROG CLOSE",
    14: "AUTO RECOVER",
    20: "LOCK OVER",
    21: "ILLEGAL OPEN",
    22: "DURESS ALARM",
    23: "TAMPER DETECT",
    30: "FACE",
    31: "FACE+CARD",
    32: "FACE+PASSWORD",
    33: "FACE+CARD+PASSWORD",
    34: "FACE+FP",
}

VERIFY_MODE_MAP = {
    0: "DUTY ON (Check-In)",
    1: "DUTY OFF (Check-Out)",
    2: "OVERTIME ON",
    3: "OVERTIME OFF",
    4: "GO IN / RETURN",
    5: "GO OUT",
}

# ─── SDK Error Codes (from documentation) ──────────────────────────────
ERROR_CODES = {
    0:     "SUCCESS",
    -1:    "FAIL",
    -2:    "INVALID_DATATYPE",
    -1002: "INVALID_PARAM",
    -1003: "INVALID_PASSWORD",
    -1004: "NOT_SUPPORTED",
    -1005: "FUNCTION_NOT_SUPPORTED",
    -1006: "NUMBER_ONLY",
    -1007: "USER_NOT_FOUND",
    -1008: "PHOTO_NOT_FOUND",
    -1009: "INVALID_FINGER",
    -1010: "ENROLLDATA_NOT_FOUND",
    -2000: "ATTNDATA_NOT_FOUND",
    -2001: "UNHANDLED_EXCEPTION",
}


def connect_device(backend="dll", force_udp=False):
    """Connect to the Bio-Face device (equivalent to MantraBioTime.ConnectTCP)."""
    print(f"[*] Connecting to {DEVICE_IP}:{DEVICE_PORT} ...")
    if backend == "dll":
        from mantra_dll_backend import DllConnection

        conn = DllConnection(
            ip=DEVICE_IP,
            port=DEVICE_PORT,
            password=DEVICE_PASS,
            device_id=DEVICE_ID,
            device_type=DEVICE_TYPE,
        ).connect()
    else:
        from zk import ZK

        zk = ZK(DEVICE_IP, port=DEVICE_PORT, timeout=TIMEOUT, password=DEVICE_PASS, force_udp=force_udp)
        conn = zk.connect()
    print("[✓] Connected successfully!")
    return conn


def show_device_info(conn):
    """Show device info (equivalent to MantraBioTime.DeviceInfo + CapacityInfo)."""
    print("\n" + "=" * 50)
    print("  DEVICE INFORMATION")
    print("=" * 50)
    
    try:
        print(f"  Firmware Version : {conn.get_firmware_version()}")
    except Exception:
        print(f"  Firmware Version : (not available)")
    
    try:
        print(f"  Serial Number    : {conn.get_serialnumber()}")
    except Exception:
        print(f"  Serial Number    : (not available)")
    
    try:
        print(f"  Platform         : {conn.get_platform()}")
    except Exception:
        print(f"  Platform         : (not available)")
    
    try:
        print(f"  Device Name      : {conn.get_device_name()}")
    except Exception:
        print(f"  Device Name      : (not available)")
    
    try:
        print(f"  MAC Address      : {conn.get_mac()}")
    except Exception:
        print(f"  MAC Address      : (not available)")
    
    try:
        print(f"  Device Time      : {conn.get_time()}")
    except Exception:
        print(f"  Device Time      : (not available)")
    
    # Capacity
    print("\n  --- Capacity ---")
    try:
        users = conn.get_users()
        print(f"  Total Users      : {len(users)}")
    except Exception:
        print(f"  Total Users      : (not available)")
    
    try:
        attendance = conn.get_attendance()
        print(f"  Total Records    : {len(attendance)}")
    except Exception:
        print(f"  Total Records    : (not available)")
    
    print("=" * 50)


def list_users(conn):
    """List all users (equivalent to MantraBioTime.GetUserInfo)."""
    users = conn.get_users()
    
    if not users:
        print("[!] No users found on device.")
        return []
    
    print(f"\n[✓] Found {len(users)} users:\n")
    print(f"  {'UID':<8} {'User ID':<15} {'Name':<25} {'Privilege':<12} {'Card':<15}")
    print(f"  {'─'*8} {'─'*15} {'─'*25} {'─'*12} {'─'*15}")
    
    priv_map = {0: "User", 14: "Admin"}
    
    for user in users:
        priv = priv_map.get(user.privilege, str(user.privilege))
        card = user.card if hasattr(user, 'card') and user.card else ""
        print(f"  {user.uid:<8} {str(user.user_id):<15} {user.name:<25} {priv:<12} {card:<15}")
    
    return users


def pull_attendance(conn, from_date=None, to_date=None):
    """
    Pull attendance logs (equivalent to MantraBioTime.ReadAllLogData / TimePeriodLogData).
    
    Returns list of dicts with: user_id, timestamp, verify_type, verify_mode
    """
    print("\n[*] Reading attendance logs from device ...")
    if hasattr(conn, "get_attendance_between") and from_date and to_date:
        raw_attendance = conn.get_attendance_between(
            from_date.strftime("%Y-%m-%d"),
            to_date.strftime("%Y-%m-%d"),
        )
    else:
        raw_attendance = conn.get_attendance()
    
    if not raw_attendance:
        print("[!] No attendance records found.")
        return []
    
    # Build user lookup
    try:
        users = conn.get_users()
        user_map = {str(u.user_id): u.name for u in users}
    except Exception:
        user_map = {}
    
    records = []
    for att in raw_attendance:
        ts = att.timestamp
        
        # Date range filter (equivalent to TimePeriodLogData)
        if from_date and ts.date() < from_date:
            continue
        if to_date and ts.date() > to_date:
            continue
        
        uid = str(att.user_id)
        records.append({
            "user_id": uid,
            "user_name": user_map.get(uid, "Unknown"),
            "timestamp": ts.strftime("%Y-%m-%d %H:%M:%S"),
            "date": ts.strftime("%Y-%m-%d"),
            "time": ts.strftime("%H:%M:%S"),
            "punch": att.punch if hasattr(att, 'punch') else 0,
            "status": att.status if hasattr(att, 'status') else 0,
            "verify_type": VERIFY_TYPE_MAP.get(
                att.status if hasattr(att, 'status') else 0, 
                str(att.status if hasattr(att, 'status') else 0)
            ),
            "verify_mode": VERIFY_MODE_MAP.get(
                att.punch if hasattr(att, 'punch') else 0,
                str(att.punch if hasattr(att, 'punch') else 0)
            ),
        })
    
    # Sort by timestamp
    records.sort(key=lambda r: r["timestamp"])
    
    return records


def display_attendance(records):
    """Display attendance records in a formatted table."""
    if not records:
        return
    
    print(f"\n[✓] Found {len(records)} attendance records:\n")
    print(f"  {'User ID':<10} {'Name':<20} {'Date':<12} {'Time':<10} {'Type':<18} {'Mode':<20}")
    print(f"  {'─'*10} {'─'*20} {'─'*12} {'─'*10} {'─'*18} {'─'*20}")
    
    for r in records:
        print(f"  {r['user_id']:<10} {r['user_name']:<20} {r['date']:<12} {r['time']:<10} {r['verify_type']:<18} {r['verify_mode']:<20}")
    
    print(f"\n  Total: {len(records)} records")


def export_csv(records, filename=None):
    """Export attendance to CSV."""
    if not filename:
        filename = f"attendance_{datetime.now().strftime('%Y%m%d_%H%M%S')}.csv"
    
    filepath = os.path.join(os.path.dirname(os.path.abspath(__file__)), filename)
    
    with open(filepath, 'w', newline='') as f:
        writer = csv.DictWriter(f, fieldnames=[
            "user_id", "user_name", "timestamp", "date", "time",
            "punch", "status", "verify_type", "verify_mode"
        ])
        writer.writeheader()
        writer.writerows(records)
    
    print(f"[✓] Exported {len(records)} records to: {filepath}")
    return filepath


def export_json(records, filename=None, device_ip=DEVICE_IP, device_port=DEVICE_PORT):
    """Export attendance to JSON."""
    if not filename:
        filename = f"attendance_{datetime.now().strftime('%Y%m%d_%H%M%S')}.json"
    
    filepath = os.path.join(os.path.dirname(os.path.abspath(__file__)), filename)
    
    with open(filepath, 'w') as f:
        json.dump({
            "device": {
                "ip": device_ip,
                "port": device_port,
                "name": "JAY COPPER",
                "type": "Bio-Face",
            },
            "exported_at": datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
            "total_records": len(records),
            "records": records,
        }, f, indent=2)
    
    print(f"[✓] Exported {len(records)} records to: {filepath}")
    return filepath


def parse_date(date_str):
    """Parse date string in YYYY-MM-DD format."""
    try:
        return datetime.strptime(date_str, "%Y-%m-%d").date()
    except ValueError:
        print(f"[✗] Invalid date format: {date_str}. Use YYYY-MM-DD.")
        sys.exit(1)


def main():
    parser = argparse.ArgumentParser(
        description="Mantra BioTime Attendance Puller for Ubuntu/Linux",
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  %(prog)s                              Pull all attendance logs
  %(prog)s --from 2026-04-01            Pull logs from April 1st
  %(prog)s --from 2026-04-01 --to 2026-04-16  Pull logs for date range
  %(prog)s --export csv                 Export to CSV file
  %(prog)s --export json                Export to JSON file
  %(prog)s --users                      List all enrolled users
  %(prog)s --device-info                Show device information
  %(prog)s --ip 192.168.1.100 --port 4370  Override device IP/port
        """
    )
    
    parser.add_argument("--ip", default=DEVICE_IP, help=f"Device IP (default: {DEVICE_IP})")
    parser.add_argument("--port", type=int, default=DEVICE_PORT, help=f"Device port (default: {DEVICE_PORT})")
    parser.add_argument("--password", type=int, default=DEVICE_PASS, help="Device communication password (default: 0 = none)")
    parser.add_argument("--from", dest="from_date", help="Start date filter (YYYY-MM-DD)")
    parser.add_argument("--to", dest="to_date", help="End date filter (YYYY-MM-DD)")
    parser.add_argument("--export", choices=["csv", "json"], help="Export format")
    parser.add_argument("--output", "-o", help="Output filename for export")
    parser.add_argument("--users", action="store_true", help="List all enrolled users")
    parser.add_argument("--device-info", action="store_true", help="Show device information")
    parser.add_argument("--udp", action="store_true", help="Force UDP connection mode")
    parser.add_argument(
        "--backend",
        choices=["dll", "pyzk"],
        default=DEFAULT_BACKEND,
        help=f"SDK backend (default: {DEFAULT_BACKEND})",
    )
    
    args = parser.parse_args()
    
    device_ip = args.ip
    device_port = args.port
    device_pass = args.password
    
    conn = None
    try:
        # Connect
        print(f"[*] Connecting to {device_ip}:{device_port} using backend={args.backend} ...")
        if args.backend == "dll":
            from mantra_dll_backend import DllConnection

            conn = DllConnection(
                ip=device_ip,
                port=device_port,
                password=device_pass,
                device_id=DEVICE_ID,
                device_type=DEVICE_TYPE,
            ).connect()
        else:
            from zk import ZK

            zk = ZK(device_ip, port=device_port, timeout=TIMEOUT,
                    password=device_pass, force_udp=args.udp)
            conn = zk.connect()
        print("[✓] Connected!\n")
        
        # Device Info
        if args.device_info:
            show_device_info(conn)
            return
        
        # List Users
        if args.users:
            list_users(conn)
            return
        
        # Pull Attendance
        from_date = parse_date(args.from_date) if args.from_date else None
        to_date = parse_date(args.to_date) if args.to_date else None
        
        records = pull_attendance(conn, from_date, to_date)
        
        if not records:
            return
        
        # Display
        display_attendance(records)
        
        # Export
        if args.export == "csv":
            export_csv(records, args.output)
        elif args.export == "json":
            export_json(records, args.output, device_ip=device_ip, device_port=device_port)
        
    except Exception as e:
        print(f"\n[✗] Error: {e}")
        print("\n[?] Troubleshooting:")
        print(f"    1. Verify: ping {device_ip}")
        print(f"    2. Try different port: --port 4370")
        print(f"    3. Try UDP mode (for pyzk backend): --udp")
        print(f"    4. On Linux, prefer --backend pyzk (DLL backend is Windows-oriented)")
        print(f"    5. For Windows DLL backend, install pythonnet: pip install pythonnet")
        print(f"    6. Check device password: --password <key>")
        sys.exit(1)
    finally:
        if conn:
            conn.disconnect()
            print("\n[*] Disconnected.")


if __name__ == "__main__":
    main()
