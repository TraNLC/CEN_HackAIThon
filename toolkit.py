"""
toolkit.py — VLTK1 Bot Toolkit
Chạy: python toolkit.py
"""

import os
import subprocess
import sys
import time
from pathlib import Path

ROOT = Path(__file__).parent

# ============================================================
# Console helpers
# ============================================================

def clear():
    os.system('cls' if os.name == 'nt' else 'clear')

def c(text, color):
    codes = {
        'red': '\033[91m', 'green': '\033[92m', 'yellow': '\033[93m',
        'blue': '\033[94m', 'purple': '\033[95m', 'cyan': '\033[96m',
        'white': '\033[97m', 'gray': '\033[90m', 'reset': '\033[0m',
        'bold': '\033[1m',
    }
    return f"{codes.get(color,'')}{text}{codes['reset']}"

def header(title):
    clear()
    width = 56
    print(c("═" * width, 'cyan'))
    print(c(f"  ⚔  VLTK1 Bot Toolkit", 'yellow') + c(f"  —  {title}", 'gray'))
    print(c("═" * width, 'cyan'))
    print()

def ok(msg):   print(c(f"  ✓  {msg}", 'green'))
def err(msg):  print(c(f"  ✗  {msg}", 'red'))
def info(msg): print(c(f"  ·  {msg}", 'gray'))
def warn(msg): print(c(f"  !  {msg}", 'yellow'))
def step(n, msg): print(c(f"  [{n}]", 'cyan') + f"  {msg}")

def ask(prompt, default=None):
    hint = f" [{default}]" if default else ""
    val = input(c(f"\n  → {prompt}{hint}: ", 'white')).strip()
    return val if val else default

def confirm(prompt):
    val = input(c(f"\n  → {prompt} (y/n): ", 'white')).strip().lower()
    return val in ('y', 'yes', '')

def pause():
    input(c("\n  Nhấn Enter để tiếp tục...", 'gray'))

def run(cmd, cwd=None):
    return subprocess.run(cmd, shell=True, cwd=cwd or ROOT)

def run_capture(cmd):
    """Run và return output."""
    r = subprocess.run(cmd, shell=True, capture_output=True, text=True, cwd=ROOT)
    return r.returncode, r.stdout + r.stderr

# ============================================================
# Checks
# ============================================================

def check_adb():
    code, out = run_capture("adb version")
    return code == 0

def check_frida():
    code, _ = run_capture("python -c \"import frida\"")
    return code == 0

def check_flask():
    code, _ = run_capture("python -c \"import flask\"")
    return code == 0

def find_emulator():
    """Thử kết nối emulator, trả về serial hoặc None."""
    ports = [5555, 5554, 5556, 5558, 21503, 62001]
    for port in ports:
        run_capture(f"adb connect 127.0.0.1:{port}")
    code, out = run_capture("adb devices")
    for line in out.splitlines():
        if '\tdevice' in line:
            return line.split('\t')[0].strip()
    return None

def get_arch(serial):
    _, out = run_capture(f"adb -s {serial} shell getprop ro.product.cpu.abi")
    return out.strip()

def frida_server_running(serial):
    _, out = run_capture(f"adb -s {serial} shell ps 2>/dev/null | grep frida")
    return 'frida' in out

def get_vltk_package(serial):
    """Tìm package name VLTK1."""
    _, out = run_capture(f"adb -s {serial} shell pm list packages")
    candidates = []
    for line in out.splitlines():
        pkg = line.replace('package:', '').strip()
        if any(k in pkg.lower() for k in ['vltk', 'vinagame', 'snail', 'vng']):
            candidates.append(pkg)
    return candidates

# ============================================================
# Menu screens
# ============================================================

def screen_main():
    while True:
        header("Menu chính")
        print(c("  PHASE 1 — Chuẩn bị\n", 'yellow'))
        step(1, "Kiểm tra & cài đặt dependencies")
        step(2, "Kết nối emulator (LDPlayer)")
        step(3, "Setup Frida trên emulator")
        print()
        print(c("  PHASE 2 — Phân tích game\n", 'yellow'))
        step(4, "Detect engine/ngôn ngữ game  " + c("← làm đầu tiên!", 'green'))
        step(5, "Capture network traffic (bắt packets)")
        step(6, "Phân tích packets")
        print()
        print(c("  PHASE 3 — Bot\n", 'yellow'))
        step(7, "Mở Web UI (Dashboard)")
        step(8, "Chạy bot 1 account (test)")
        print()
        step(0, c("Thoát", 'gray'))
        print()

        choice = ask("Chọn")
        if   choice == '1': screen_check_deps()
        elif choice == '2': screen_connect_emulator()
        elif choice == '3': screen_setup_frida()
        elif choice == '4': screen_detect_engine()
        elif choice == '5': screen_capture()
        elif choice == '6': screen_analyze()
        elif choice == '7': screen_webui()
        elif choice == '8': screen_test_bot()
        elif choice == '0': sys.exit(0)


# ============================================================
# Screen 1: Check dependencies
# ============================================================

def screen_check_deps():
    header("Kiểm tra dependencies")

    checks = [
        ("Python 3.10+",  lambda: sys.version_info >= (3, 10)),
        ("ADB",           check_adb),
        ("frida",         check_frida),
        ("flask",         check_flask),
    ]

    all_ok = True
    for name, fn in checks:
        try:
            result = fn()
        except Exception:
            result = False
        if result:
            ok(name)
        else:
            err(name + " — chưa cài")
            all_ok = False

    if not all_ok:
        print()
        warn("Cài missing packages:")
        info("pip install frida frida-tools flask pyyaml")
        print()
        if confirm("Cài ngay bây giờ?"):
            run("pip install frida frida-tools flask pyyaml")
            ok("Cài xong!")

    pause()


# ============================================================
# Screen 2: Connect emulator
# ============================================================

def screen_connect_emulator():
    header("Kết nối emulator")

    info("Đang tìm emulator...")
    serial = find_emulator()

    if serial:
        ok(f"Tìm thấy: {serial}")
        arch = get_arch(serial)
        ok(f"CPU arch: {arch}")

        pkgs = get_vltk_package(serial)
        if pkgs:
            ok(f"VLTK package: {pkgs[0]}")
            # Save to config
            _save_setting('emulator_serial', serial)
            _save_setting('emulator_arch', arch)
            _save_setting('vltk_package', pkgs[0])
        else:
            warn("Chưa thấy package VLTK1 — game chưa cài?")
            pkg = ask("Nhập package name thủ công (hoặc Enter bỏ qua)")
            if pkg:
                _save_setting('vltk_package', pkg)
    else:
        err("Không tìm thấy emulator!")
        print()
        info("Kiểm tra:")
        info("1. LDPlayer đang mở")
        info("2. LDPlayer Settings → Other → Enable ADB debugging → ON")
        info("3. Thử thủ công: adb connect 127.0.0.1:5555")
        print()
        port = ask("Nhập port ADB thủ công", "5555")
        if port:
            run(f"adb connect 127.0.0.1:{port}")
            serial = find_emulator()
            if serial:
                ok(f"Kết nối OK: {serial}")
                _save_setting('emulator_serial', serial)
            else:
                err("Vẫn không kết nối được")

    pause()


# ============================================================
# Screen 3: Setup Frida
# ============================================================

# ============================================================
# Screen 4: Detect engine
# ============================================================

def screen_detect_engine():
    header("Detect engine / ngôn ngữ game")

    serial  = _load_setting('emulator_serial')
    package = _load_setting('vltk_package')

    print()
    info("Tool này phân tích APK để xác định:")
    info("  · Engine: Unity / Cocos2d / Custom C++ / Java")
    info("  · Network layer: Java socket / C++ native / Protobuf")
    info("  · Hook approach phù hợp nhất")
    print()

    print(c("  Chọn nguồn APK:\n", 'yellow'))
    step(1, "Tự pull APK từ emulator  (cần emulator đang kết nối)")
    step(2, "Chỉ định file APK có sẵn trên máy")
    print()

    mode = ask("Chọn", "1")

    apk_path = None

    if mode == '1':
        if not serial or not package:
            err("Chưa kết nối emulator — chạy bước 2 trước")
            pause()
            return
        info(f"Pulling APK của {package} ...")
        run(f'python analysis/detect_engine.py --serial {serial} --package {package}')
        pause()
        return

    elif mode == '2':
        path_str = ask("Nhập đường dẫn file APK")
        if not path_str:
            pause()
            return
        apk_path = Path(path_str.strip('"').strip("'"))
        if not apk_path.exists():
            err(f"File không tồn tại: {apk_path}")
            pause()
            return

    if apk_path:
        run(f'python analysis/detect_engine.py --apk "{apk_path}"')

    print()
    info("Sau khi biết engine → quay lại bước 5 chọn capture mode phù hợp:")
    info("  Java/Kotlin  → Java hook (capture_java.py)")
    info("  Unity Mono   → Java hook")
    info("  Unity IL2CPP → Frida native hook (libil2cpp.so)")
    info("  Cocos2d C++  → Frida libc hook (hook_socket.js)")
    info("  Custom C++   → Frida libc hook (hook_socket.js)")
    pause()



def screen_setup_frida():
    header("Setup Frida trên emulator")

    serial = _load_setting('emulator_serial')
    arch   = _load_setting('emulator_arch')

    if not serial:
        err("Chưa kết nối emulator — chạy bước 2 trước")
        pause()
        return

    ok(f"Emulator: {serial}  arch: {arch}")

    # Check frida-server đã chạy chưa
    if frida_server_running(serial):
        ok("frida-server đã đang chạy!")
        pause()
        return

    # Tìm frida-server binary
    frida_dir = ROOT / "frida"
    candidates = list(frida_dir.glob("frida-server*"))
    local_bin = candidates[0] if candidates else None

    if not local_bin:
        print()
        warn("Chưa có frida-server binary!")
        print()
        info("Tải tại: https://github.com/frida/frida/releases")
        info(f"Tìm file: frida-server-*-android-{arch or 'x86_64'}.xz")
        info(f"Giải nén → đặt vào: {frida_dir}")
        print()
        if confirm("Đã tải xong, tiếp tục?"):
            candidates = list(frida_dir.glob("frida-server*"))
            local_bin = candidates[0] if candidates else None

    if not local_bin:
        err("Không tìm thấy frida-server")
        pause()
        return

    info(f"Dùng: {local_bin.name}")

    # Push
    info("Đang push lên emulator...")
    run(f'adb -s {serial} push "{local_bin}" /data/local/tmp/frida-server')
    run(f"adb -s {serial} shell chmod 755 /data/local/tmp/frida-server")

    # Start
    info("Khởi động frida-server...")
    run(f"adb -s {serial} shell su -c '/data/local/tmp/frida-server &'")
    time.sleep(2)

    if frida_server_running(serial):
        ok("frida-server đang chạy!")
    else:
        err("Không start được — thử thủ công:")
        info(f"adb -s {serial} shell")
        info("su")
        info("/data/local/tmp/frida-server &")

    pause()


# ============================================================
# Screen 4: Capture
# ============================================================

def screen_capture():
    header("Capture network traffic")

    serial  = _load_setting('emulator_serial')
    package = _load_setting('vltk_package')

    if not serial or not package:
        err("Chưa setup emulator — chạy bước 2 & 3 trước")
        pause()
        return

    if not frida_server_running(serial):
        err("frida-server chưa chạy — chạy bước 3 trước")
        pause()
        return

    print()
    info(f"Package: {package}")
    print()
    print(c("  Chọn loại capture:\n", 'yellow'))
    step(1, "Socket hook  (bắt raw bytes — kiểm tra encryption)")
    step(2, "Java hook    (bắt plaintext — dùng khi bị encrypted)")
    print()

    mode = ask("Chọn", "1")

    script = "frida/capture.py" if mode == '1' else "frida/capture_java.py"

    print()
    ok("Bắt đầu capture...")
    warn("Hướng dẫn:")
    info("1. Chờ 5 giây cho Frida attach")
    info("2. Trong LDPlayer: mở game → login")
    info("3. Làm 1 lần nhiệm vụ dã tẩu hoàn chỉnh")
    info("4. Nhấn Ctrl+C để dừng capture")
    print()
    pause()

    run(f"python {script} --attach {package}")

    print()
    ok("Capture xong! File lưu trong captures/")
    info("Tiếp theo: chọn bước 5 để phân tích")
    pause()


# ============================================================
# Screen 5: Analyze
# ============================================================

def screen_analyze():
    header("Phân tích packets")

    captures_dir = ROOT / "captures"
    bins = sorted(captures_dir.glob("*.bin")) if captures_dir.exists() else []

    if not bins:
        err("Chưa có file capture — chạy bước 4 trước")
        pause()
        return

    print(c("  Files capture:\n", 'yellow'))
    for i, f in enumerate(bins, 1):
        size = f.stat().st_size
        print(f"  [{i}]  {f.name}  {c(f'({size:,} bytes)', 'gray')}")

    print()
    choice = ask("Chọn file để phân tích", "1")
    try:
        chosen = bins[int(choice) - 1]
    except (ValueError, IndexError):
        err("Lựa chọn không hợp lệ")
        pause()
        return

    print()
    print(c("  Chọn thao tác:\n", 'yellow'))
    step(1, "Auto-detect format + tổng kết opcodes  (khuyến nghị)")
    step(2, "Xem hex dump")
    step(3, "Tìm opcode cụ thể")
    print()

    action = ask("Chọn", "1")

    if action == '1':
        print()
        info("Detecting packet format...")
        run(f'python analysis/packet_parser.py "{chosen}" --detect-format')
        print()
        run(f'python analysis/packet_parser.py "{chosen}" --summary')

    elif action == '2':
        offset = ask("Bắt đầu từ byte thứ mấy", "0")
        limit  = ask("Xem bao nhiêu bytes", "256")
        run(f'python analysis/hexdump.py "{chosen}" --offset {offset} --limit {limit}')

    elif action == '3':
        opcode = ask("Nhập opcode (hex, vd: 0x0210)")
        if opcode:
            run(f'python analysis/packet_parser.py "{chosen}" --opcode {opcode} --payload')

    print()
    info("Ghi chú opcodes tìm được vào: analysis/opcode_map.yaml")
    pause()


# ============================================================
# Screen 6: Web UI
# ============================================================

def screen_webui():
    header("Web Dashboard")

    if not check_flask():
        err("Flask chưa cài: pip install flask")
        pause()
        return

    # Check accounts.csv
    acc_file = ROOT / "accounts.csv"
    if not acc_file.exists() or acc_file.stat().st_size < 30:
        warn("accounts.csv chưa có dữ liệu!")
        info(f"Thêm accounts vào: {acc_file}")
        info("Format: username,password,server")
        if confirm("Mở file accounts.csv ngay?"):
            run(f'notepad "{acc_file}"' if os.name == 'nt' else f'open "{acc_file}"')
        print()

    ok("Khởi động Web UI tại http://localhost:5000")
    info("Nhấn Ctrl+C để dừng server")
    print()

    try:
        run("python ui/app.py")
    except KeyboardInterrupt:
        pass

    pause()


# ============================================================
# Screen 7: Test bot 1 account
# ============================================================

def screen_test_bot():
    header("Test bot — 1 account")

    acc_file = ROOT / "accounts.csv"

    print()
    warn("QUAN TRỌNG: Trước khi chạy bot, phải:")
    info("1. Đã capture và phân tích packets (bước 4 & 5)")
    info("2. Đã điền opcodes thật vào bot/packet_builder.py")
    info("3. Đã điền NPC ID, Quest ID vào bot/state_machine.py")
    print()

    if not confirm("Đã hoàn thành các bước trên?"):
        info("Quay lại làm bước 4 và 5 trước nhé")
        pause()
        return

    # Kiểm tra accounts.csv
    if not acc_file.exists():
        err(f"Không tìm thấy {acc_file}")
        pause()
        return

    # Check config.yaml có server IP chưa
    config_file = ROOT / "config.yaml"
    config_text = config_file.read_text(encoding='utf-8') if config_file.exists() else ""
    if "0.0.0.0" in config_text:
        warn("config.yaml chưa điền server IP/port!")
        ip   = ask("Server IP game")
        port = ask("Server port game")
        if ip and port:
            updated = config_text.replace('"0.0.0.0"', f'"{ip}"').replace('port: 0', f'port: {port}')
            config_file.write_text(updated, encoding='utf-8')
            ok("Đã cập nhật config.yaml")

    print()
    ok("Chạy test 1 account...")
    run("python bot/main.py --test 1 --log-level DEBUG")
    pause()


# ============================================================
# Simple key-value settings store
# ============================================================

_SETTINGS_FILE = ROOT / ".toolkit_settings"

def _save_setting(key, value):
    settings = _read_all_settings()
    settings[key] = value
    with open(_SETTINGS_FILE, 'w') as f:
        for k, v in settings.items():
            f.write(f"{k}={v}\n")

def _load_setting(key):
    return _read_all_settings().get(key)

def _read_all_settings():
    if not _SETTINGS_FILE.exists():
        return {}
    settings = {}
    for line in _SETTINGS_FILE.read_text().splitlines():
        if '=' in line:
            k, v = line.split('=', 1)
            settings[k.strip()] = v.strip()
    return settings


# ============================================================
# Entry point
# ============================================================

if __name__ == '__main__':
    # Enable ANSI colors trên Windows
    if os.name == 'nt':
        os.system('color')
    try:
        screen_main()
    except KeyboardInterrupt:
        print(c("\n\n  Tạm biệt!\n", 'gray'))
        sys.exit(0)
