# MantraBioTimeSDK Run Commands

## Windows (DLL Backend - Recommended)

### 1) Open terminal in project folder
```bat
cd C:\path\to\MantraBioTimeSDK
```

### 2) Create and activate virtual environment
```bat
py -m venv venv
venv\Scripts\activate
```

### 3) Install dependencies
```bat
pip install --upgrade pip
pip install pythonnet pyzk
```

### 4) Test device connection (DLL)
```bat
python test_connection.py --backend dll --ip 192.168.0.250 --port 8080
```

### 5) Scan working connection (DLL)
```bat
python scan_device.py --backend dll --ip 192.168.0.250
```

### 6) Pull all attendance logs (DLL)
```bat
python pull_attendance.py --backend dll --ip 192.168.0.250 --port 8080
```

### 7) Pull attendance logs for date range (DLL)
```bat
python pull_attendance.py --backend dll --ip 192.168.0.250 --port 8080 --from 2026-04-01 --to 2026-04-16
```

### 8) Export attendance (DLL)
```bat
python pull_attendance.py --backend dll --export csv
python pull_attendance.py --backend dll --export json
```

### 9) Device info / users (DLL)
```bat
python pull_attendance.py --backend dll --device-info
python pull_attendance.py --backend dll --users
```

---

## Linux (Fallback via pyzk)

```bash
python3 test_connection.py --backend pyzk --ip 192.168.0.250 --port 8080
python3 scan_device.py --backend pyzk --ip 192.168.0.250
python3 pull_attendance.py --backend pyzk --ip 192.168.0.250 --port 8080
```

---

## Notes

- On Windows, DLL mode is the target backend for this project.
- If DLL mode fails on Windows, check Python bitness and use matching DLL architecture:
  - 64-bit Python -> `Library/x64`
  - 32-bit Python -> `Library/x86`
