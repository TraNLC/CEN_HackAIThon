# Bước 1 — Setup Frida + LDPlayer

## Cài đặt Python packages

```bash
pip install frida-tools frida pyyaml flask
```

## Xác định architecture của LDPlayer

```bash
adb shell getprop ro.product.cpu.abi
# Kết quả thường là: x86_64 hoặc x86
```

## Cài frida-server vào emulator

```bash
# 1. Download frida-server đúng arch từ https://github.com/frida/frida/releases
#    Tên file: frida-server-XX.X.X-android-x86_64.xz (hoặc x86)

# 2. Giải nén
#    Windows: dùng 7-Zip hoặc: python -c "import lzma,sys; open('frida-server','wb').write(lzma.open(sys.argv[1]).read())" frida-server-XX.X.X-android-x86_64.xz

# 3. Push vào emulator
adb push frida-server /data/local/tmp/frida-server
adb shell chmod 755 /data/local/tmp/frida-server

# 4. Chạy frida-server (cần root)
adb shell su -c "/data/local/tmp/frida-server &"

# 5. Verify
frida-ps -U
# Phải thấy danh sách processes, bao gồm process VLTK1
```

## Tìm package name của VLTK1

```bash
# Liệt kê tất cả packages đang cài
adb shell pm list packages | findstr vltk
adb shell pm list packages | findstr vinagame
adb shell pm list packages | findstr snail

# Hoặc dùng toolkit
python toolkit.py
# → Chọn "2. Find game package"
```

## Chạy qua toolkit.py (khuyến nghị)

```bash
cd C:\Rakuten\vltk1-re
python toolkit.py
```

Toolkit sẽ hướng dẫn từng bước qua menu.

## Chạy qua Web UI

```bash
python ui/app.py
# Mở browser: http://localhost:5000
# Vào tab "Setup" → làm theo wizard
```

## Troubleshooting

| Lỗi | Nguyên nhân | Fix |
|-----|-------------|-----|
| `frida-ps: no device` | ADB không thấy emulator | Chạy `adb devices`, bật USB debugging trong LDPlayer |
| `frida-server: permission denied` | Không có root | LDPlayer: Settings → Enable root access |
| `frida-server: already running` | Đã chạy rồi | `adb shell pkill frida-server` rồi chạy lại |
| `arch mismatch` | Sai architecture | Download đúng file x86 hoặc x86_64 |
| Game crash sau khi inject | Frida detection | Dùng Xposed thay thế (xem `xposed/`) |

## Port ADB của LDPlayer

LDPlayer thường dùng port ADB:
- LDPlayer 1: `127.0.0.1:5555`
- LDPlayer 2: `127.0.0.1:5556`
- ...

```bash
adb connect 127.0.0.1:5555
adb devices
```
