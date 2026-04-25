"""
setup.py — Tự động setup frida-server trên LDPlayer

Chạy 1 lần trước khi dùng capture.py:
    python frida/setup.py

Làm gì:
  1. Kiểm tra ADB kết nối được emulator
  2. Phát hiện CPU arch
  3. Kiểm tra frida-server đã có chưa, nếu chưa → hướng dẫn download
  4. Push frida-server vào emulator
  5. Khởi động frida-server
  6. Verify bằng frida-ps
"""

import subprocess
import sys
import time
from pathlib import Path

FRIDA_SERVER_LOCAL = Path(__file__).parent / "frida-server"
FRIDA_SERVER_REMOTE = "/data/local/tmp/frida-server"
ADB_PORTS = [5555, 5554, 5556, 21503, 62001]  # LDPlayer, BlueStacks, MEmu


def run(cmd: str, capture=True) -> tuple[int, str]:
    result = subprocess.run(cmd, shell=True,
                            capture_output=capture,
                            text=True)
    return result.returncode, (result.stdout + result.stderr).strip()


def adb(cmd: str, capture=True) -> tuple[int, str]:
    return run(f"adb {cmd}", capture)


def adb_serial(serial: str, cmd: str, capture=True) -> tuple[int, str]:
    return run(f"adb -s {serial} {cmd}", capture)


# ----------------------------------------------------------
# Step 1: Tìm emulator đang chạy
# ----------------------------------------------------------

def find_emulator() -> str | None:
    print("[ ] Tìm emulator đang kết nối ADB...")

    # Thử kết nối các port phổ biến
    for port in ADB_PORTS:
        run(f"adb connect 127.0.0.1:{port}")

    code, out = adb("devices")
    lines = [l for l in out.splitlines() if "\tdevice" in l]

    if not lines:
        print("[!] Không tìm thấy emulator.")
        print("    Kiểm tra:")
        print("    1. LDPlayer đang mở")
        print("    2. Settings → Other → Enable ADB debugging → ON")
        print("    3. Thử: adb connect 127.0.0.1:5555")
        return None

    serial = lines[0].split("\t")[0].strip()
    print(f"[+] Tìm thấy: {serial}")
    return serial


# ----------------------------------------------------------
# Step 2: Xác định CPU arch
# ----------------------------------------------------------

def get_arch(serial: str) -> str:
    _, arch = adb_serial(serial, "shell getprop ro.product.cpu.abi")
    arch = arch.strip()
    print(f"[+] CPU arch: {arch}")
    return arch


# ----------------------------------------------------------
# Step 3: Kiểm tra frida-server local
# ----------------------------------------------------------

def check_local_frida_server(arch: str) -> Path | None:
    # Tìm file frida-server trong cùng thư mục script
    candidates = list(Path(__file__).parent.glob("frida-server*"))
    if candidates:
        print(f"[+] Tìm thấy frida-server: {candidates[0]}")
        return candidates[0]

    print(f"[!] Chưa có frida-server.")
    print(f"\n    Tải về tại: https://github.com/frida/frida/releases")
    print(f"    Tìm file:   frida-server-*-android-{arch}.xz")
    print(f"    Giải nén và đặt vào: {Path(__file__).parent}")
    print(f"    Tên file sau khi giải nén: frida-server (hoặc bất kỳ tên gì)")
    return None


# ----------------------------------------------------------
# Step 4: Push frida-server lên emulator
# ----------------------------------------------------------

def push_frida_server(serial: str, local_path: Path) -> bool:
    print(f"[ ] Push {local_path.name} → {FRIDA_SERVER_REMOTE} ...")
    code, out = adb_serial(serial, f"push \"{local_path}\" {FRIDA_SERVER_REMOTE}")
    if code != 0:
        print(f"[!] Push thất bại: {out}")
        return False

    adb_serial(serial, f"shell chmod 755 {FRIDA_SERVER_REMOTE}")
    print(f"[+] Push thành công")
    return True


# ----------------------------------------------------------
# Step 5: Khởi động frida-server
# ----------------------------------------------------------

def start_frida_server(serial: str) -> bool:
    print("[ ] Khởi động frida-server...")

    # Kill process cũ nếu có
    adb_serial(serial, "shell su -c 'pkill -f frida-server'")
    time.sleep(1)

    # Start mới
    code, out = adb_serial(serial,
        f"shell su -c '{FRIDA_SERVER_REMOTE} &'")

    time.sleep(2)  # chờ start

    # Kiểm tra đang chạy
    _, ps_out = adb_serial(serial, "shell ps | grep frida")
    if "frida-server" in ps_out:
        print("[+] frida-server đang chạy")
        return True

    # Thử không có su (một số emulator không cần)
    adb_serial(serial, f"shell '{FRIDA_SERVER_REMOTE} &'")
    time.sleep(2)
    _, ps_out = adb_serial(serial, "shell ps | grep frida")
    if "frida-server" in ps_out:
        print("[+] frida-server đang chạy (non-root)")
        return True

    print("[!] Không thể start frida-server")
    print(f"    Thử thủ công: adb -s {serial} shell")
    print(f"    Rồi: su && {FRIDA_SERVER_REMOTE} &")
    return False


# ----------------------------------------------------------
# Step 6: Verify qua frida-ps
# ----------------------------------------------------------

def verify_frida(serial: str) -> bool:
    print("[ ] Verify frida kết nối...")
    try:
        import frida
        device = frida.get_usb_device(timeout=5)
        processes = device.enumerate_processes()
        print(f"[+] Frida OK — thấy {len(processes)} processes")

        # Tìm VLTK1
        vltk = [p for p in processes if 'vltk' in p.name.lower()]
        if vltk:
            for p in vltk:
                print(f"[+] VLTK1 process: {p.name} (pid={p.pid})")
        else:
            print("[~] Chưa thấy VLTK1 — mở game rồi chạy lại verify")

        return True
    except Exception as e:
        print(f"[!] Frida verify thất bại: {e}")
        print("    Kiểm tra: pip install frida-tools")
        return False


# ----------------------------------------------------------
# Main
# ----------------------------------------------------------

def main():
    print("=" * 50)
    print("  VLTK1 Frida Setup")
    print("=" * 50)

    serial = find_emulator()
    if not serial:
        sys.exit(1)

    arch = get_arch(serial)
    local_frida = check_local_frida_server(arch)
    if not local_frida:
        sys.exit(1)

    if not push_frida_server(serial, local_frida):
        sys.exit(1)

    if not start_frida_server(serial):
        sys.exit(1)

    verify_frida(serial)

    print("\n" + "=" * 50)
    print("  Setup xong! Chạy tiếp:")
    print(f"  python frida/capture.py --attach <package_name>")
    print("=" * 50)


if __name__ == '__main__':
    main()
