#!/usr/bin/env python3
"""
Quick test to verify connection to Mantra Bio-Face device.
Default Device Config: IP=192.168.0.250, Port=8080, No Password
"""

import argparse
import platform

DEVICE_IP = "192.168.0.250"
DEVICE_PORT = 8080
DEVICE_PASS = 0
DEVICE_ID = 1
DEVICE_TYPE = 2
DEFAULT_BACKEND = "dll" if platform.system().lower().startswith("win") else "pyzk"


def test_connection(ip, port, password, backend):
    print(f"[*] Connecting to {ip}:{port} using backend={backend} ...")

    conn = None
    try:
        if backend == "dll":
            from mantra_dll_backend import DllConnection

            conn = DllConnection(
                ip=ip,
                port=port,
                password=password,
                device_id=DEVICE_ID,
                device_type=DEVICE_TYPE,
            ).connect()
        else:
            from zk import ZK

            conn = ZK(ip, port=port, timeout=5, password=password, force_udp=False).connect()

        print("[✓] Connected successfully!\n")

        print("=== Device Info ===")
        print(f"  Firmware     : {conn.get_firmware_version()}")
        print(f"  Serial No    : {conn.get_serialnumber()}")
        print(f"  Platform     : {conn.get_platform()}")
        print(f"  Device Name  : {conn.get_device_name()}")
        print(f"  MAC Address  : {conn.get_mac()}")

        print("\n=== Capacity Info ===")
        try:
            users = conn.get_users()
            print(f"  User Count   : {len(users)}")
        except Exception:
            print("  User Count   : (not available)")

        try:
            attendance = conn.get_attendance()
            print(f"  Record Count : {len(attendance)}")
        except Exception:
            print("  Record Count : (not available)")

        print("\n=== Device Time ===")
        print(f"  Device Time  : {conn.get_time()}")

        print("\n[✓] All checks passed! Device is accessible.")

    except Exception as e:
        print(f"[✗] Connection failed: {e}")
        print("\n[?] Troubleshooting tips:")
        print(f"    1. Verify device IP: ping {ip}")
        print("    2. Try port 4370 instead of 8080")
        print("    3. For Linux, prefer --backend pyzk (Windows DLL deps are not ELF)")
        print("    4. For Windows DLL mode, install pythonnet: pip install pythonnet")
        print("    5. Check if device has a communication password set")
    finally:
        if conn:
            conn.disconnect()
            print("[*] Disconnected.")


def main():
    parser = argparse.ArgumentParser(description="Test Mantra BioTime device connectivity")
    parser.add_argument("--ip", default=DEVICE_IP, help=f"Device IP (default: {DEVICE_IP})")
    parser.add_argument("--port", type=int, default=DEVICE_PORT, help=f"Device port (default: {DEVICE_PORT})")
    parser.add_argument("--password", type=int, default=DEVICE_PASS, help="Device communication password")
    parser.add_argument(
        "--backend",
        choices=["dll", "pyzk"],
        default=DEFAULT_BACKEND,
        help=f"Connection backend (default: {DEFAULT_BACKEND})",
    )
    args = parser.parse_args()
    test_connection(args.ip, args.port, args.password, args.backend)

if __name__ == "__main__":
    main()
