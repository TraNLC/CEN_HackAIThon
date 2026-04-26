import subprocess
import time

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'

print("[Bot] Mở bản đồ lớn...")
subprocess.run(f'{ADB} -s {DEVICE_ID} shell input tap 900 50', shell=True)
time.sleep(2)

print("[Bot] Click vào tọa độ của Dã Tẩu trên bản đồ (Cần thay đổi X, Y cho đúng)...")
# Giả sử Dã Tẩu nằm ở pixel 450, 320 trên ảnh bản đồ lớn
subprocess.run(f'{ADB} -s {DEVICE_ID} shell input tap 206 201', shell=True)
time.sleep(1)

print("[Bot] Đóng bản đồ để nhân vật tự chạy...")
subprocess.run(f'{ADB} -s {DEVICE_ID} shell input tap 900 50', shell=True)
