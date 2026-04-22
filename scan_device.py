#!/usr/bin/env python3
"""
Scan all possible connection methods for the Bio-Face device.
Tries TCP, UDP, and different ports to find what works.
"""
import argparse
import platform
import subprocess
import socket

DEVICE_IP = "192.168.0.250"
DEVICE_ID = 1
DEVICE_TYPE = 2
DEFAULT_BACKEND = "dll" if platform.system().lower().startswith("win") else "pyzk"

def ping_check(device_ip):
    """Check basic network connectivity."""
    print(f"[1/5] Pinging {device_ip} ...")
    result = subprocess.run(
        ["ping", "-c", "2", "-W", "2", device_ip],
        capture_output=True, text=True
    )
    if result.returncode == 0:
        print(f"  [✓] Ping successful")
        return True
    else:
        print(f"  [✗] Ping failed — device not reachable on network")
        return False

def port_check(device_ip, port):
    """Check if a TCP port is open."""
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.settimeout(3)
    try:
        result = sock.connect_ex((device_ip, port))
        if result == 0:
            print(f"  [✓] TCP port {port} is OPEN")
            return True
        else:
            print(f"  [–] TCP port {port} is closed/filtered")
            return False
    except Exception as e:
        print(f"  [–] TCP port {port}: {e}")
        return False
    finally:
        sock.close()

def try_pyzk_connect(device_ip, port, force_udp, password=0):
    """Attempt ZK protocol connection via pyzk."""
    from zk import ZK

    mode = "UDP" if force_udp else "TCP"
    print(f"  → Trying {mode} on port {port} (password={password}) ...", end=" ", flush=True)
    try:
        zk = ZK(device_ip, port=port, timeout=5, password=password, force_udp=force_udp)
        conn = zk.connect()
        fw = conn.get_firmware_version()
        sn = conn.get_serialnumber()
        conn.disconnect()
        print(f"[✓] CONNECTED! FW={fw}, SN={sn}")
        return True
    except Exception as e:
        print(f"[✗] {e}")
        return False

def try_dll_connect(device_ip, port, password=0):
    """Attempt official Mantra .NET SDK connection."""
    print(f"  → Trying DLL SDK on port {port} (password={password}) ...", end=" ", flush=True)
    try:
        from mantra_dll_backend import DllConnection

        conn = DllConnection(
            ip=device_ip,
            port=port,
            password=password,
            device_id=DEVICE_ID,
            device_type=DEVICE_TYPE,
        ).connect()
        fw = conn.get_firmware_version()
        sn = conn.get_serialnumber()
        conn.disconnect()
        print(f"[✓] CONNECTED! FW={fw}, SN={sn}")
        return True
    except Exception as e:
        print(f"[✗] {e}")
        return False


def main():
    parser = argparse.ArgumentParser(description="Scan connection methods for Mantra BioTime device")
    parser.add_argument("--ip", default=DEVICE_IP, help=f"Device IP (default: {DEVICE_IP})")
    parser.add_argument(
        "--backend",
        choices=["dll", "pyzk"],
        default=DEFAULT_BACKEND,
        help=f"Scan backend (default: {DEFAULT_BACKEND})",
    )
    args = parser.parse_args()
    device_ip = args.ip

    print("=" * 55)
    print(f"  Scanning Mantra Bio-Face at {device_ip} using backend={args.backend}")
    print("=" * 55 + "\n")
    
    # Step 1: Ping
    if not ping_check(device_ip):
        print("\n[!] Cannot reach device. Check:")
        print("    - Is the device powered on?")
        print("    - Is your Ubuntu on the same subnet (192.168.0.x)?")
        print("    - Any firewall blocking?")
        return
    
    # Step 2: Port scan
    ports = [8080, 4370, 5005, 80, 443]
    print(f"\n[2/5] Scanning common ports ...")
    open_ports = []
    for p in ports:
        if port_check(device_ip, p):
            open_ports.append(p)
    
    # Step 3: Try ZK protocol on all known ports
    print(f"\n[3/5] Trying ZK protocol connections ...")
    
    # Try the confirmed port first, then others
    test_ports = [8080, 4370, 5005]
    found = False
    
    for port in test_ports:
        for pwd in [0]:
            if args.backend == "dll":
                ok = try_dll_connect(device_ip, port, pwd)
                mode = "TCP (DLL)"
            else:
                ok = False
                mode = "UNKNOWN"
                for udp in [False, True]:
                    if try_pyzk_connect(device_ip, port, udp, pwd):
                        ok = True
                        mode = "UDP" if udp else "TCP"
                        break

            if ok:
                    found = True
                    print(f"\n{'='*55}")
                    print(f"  ✅ WORKING CONFIG FOUND!")
                    print(f"     IP={device_ip}, Port={port}, Mode={mode}, Password={pwd}")
                    print(f"{'='*55}")
                    print(f"\n  Use this in your scripts:")
                    if args.backend == "dll":
                        print("    from mantra_dll_backend import DllConnection")
                        print(f'    conn = DllConnection(ip="{device_ip}", port={port}, password={pwd}, device_id=1, device_type=2).connect()')
                    else:
                        print(f'    zk = ZK("{device_ip}", port={port}, timeout=5, password={pwd}, force_udp=False)')
                    return
    
    if not found:
        print(f"\n[4/5] Trying with different passwords on port 8080 ...")
        for pwd in [1, 123, 1234, 12345]:
            if args.backend == "dll":
                ok = try_dll_connect(device_ip, 8080, pwd)
                mode = "TCP (DLL)"
            else:
                ok = False
                mode = "UNKNOWN"
                for udp in [False, True]:
                    if try_pyzk_connect(device_ip, 8080, udp, pwd):
                        ok = True
                        mode = "UDP" if udp else "TCP"
                        break
            if ok:
                    print(f"\n  ✅ FOUND: Port=8080, Mode={mode}, Password={pwd}")
                    return
    
    if not found:
        print(f"\n[5/5] No ZK protocol connection worked.")
        print(f"\n  The device may use a different protocol. Possible reasons:")
        print(f"    - Port 8080 might be the device's HTTP API port (try http://{device_ip}:8080 in browser)")
        print(f"    - ZKTeco protocol may be on a different port")
        print(f"    - Device firmware may not support the standard ZK protocol")
        if open_ports:
            print(f"\n  Open TCP ports found: {open_ports}")

if __name__ == "__main__":
    main()
