import sys
from pathlib import Path
import time
import subprocess

ROOT_DIR = Path('e:/tool/sample-test/vltk1-re')
sys.path.insert(0, str(ROOT_DIR))

from features.bot.game_bot import VLTK1Bot

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'

def test_auto_via_packet():
    print("\n==============================================")
    print(" CÁCH 1: BẬT AUTO BẰNG PACKET (GỬI LÊN SERVER)")
    print("==============================================")
    bot = VLTK1Bot()
    if bot.connect():
        print("[Bot] Gửi lệnh eApplyAutoplayProfile(startAuto=True)...")
        # Tham số profile là chuỗi setting, nếu để trống server có thể dùng setting mặc định
        res = bot.send_gs('eApplyAutoplayProfile', startAuto=True, profile="")
        print(f"[>] Kết quả: {res}")
        
        print(">>> HÃY KIỂM TRA XEM NHÂN VẬT CÓ TỰ ĐÁNH HAY KHÔNG (CHỜ 5 GIÂY) <<<")
        time.sleep(5)
        
        print("[Bot] Gửi lệnh tắt Auto...")
        bot.send_gs('eApplyAutoplayProfile', startAuto=False, profile="")
        bot.close()

def test_auto_via_ui():
    print("\n==============================================")
    print(" CÁCH 2: BẬT AUTO BẰNG UI (CLICK NÚT TRÊN MÀN)")
    print("==============================================")
    print("[Bot] Giả lập click vào nút Tự Động/Auto trên màn hình...")
    # TODO: Thay đổi tọa độ X, Y này thành đúng tọa độ của nút Auto (A hoặc Cặp Kiếm) trên giả lập
    AUTO_BTN_X = 850
    AUTO_BTN_Y = 400 
    
    subprocess.run(f'{ADB} -s {DEVICE_ID} shell input tap {AUTO_BTN_X} {AUTO_BTN_Y}', shell=True)
    print(f"[+] Đã Click vào tọa độ ({AUTO_BTN_X}, {AUTO_BTN_Y})")
    print(">>> HÃY KIỂM TRA XEM NÚT AUTO CÓ ĐƯỢC BẬT CHƯA <<<")

if __name__ == "__main__":
    import os
    os.system('chcp 65001 > nul') # Fix lỗi hiển thị tiếng Việt trên Terminal
    
    print("KIỂM THỬ TÍNH NĂNG AUTO ĐÁNH QUÁI (AUTOPLAY)")
    test_auto_via_packet()
    time.sleep(2)
    test_auto_via_ui()
    
    print("\n[*] Hoàn thành test!")
