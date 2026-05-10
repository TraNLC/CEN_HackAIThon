import sys
import os
import time

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from core.adb_helper import ADBHelper
from core.navigator import Navigator
import logging

logging.basicConfig(level=logging.INFO, format='%(message)s')

def main():
    print("=" * 50)
    print("  TEST AUTO MOVE TO NPC FROM JSON MAP DATA")
    print("=" * 50)

    adb = ADBHelper()
    adb.init_frida()
    
    if not adb.frida_session:
        print("[!] Không kết nối được Frida. Hãy chắc chắn game đang bật.")
        return
        
    nav = Navigator(adb)
    
    npc_target = "Chủ tiệm tạp hóa"
    map_target = "Ba Lăng Huyện"
    
    print(f"\n[+] Ra lệnh di chuyển tới: {npc_target} tại {map_target}")
    
    # Hàm này sẽ tự động tìm trong map_53.json (Ba Lăng Huyện) 
    # lấy ra tọa độ của Tạp hóa, chia 256 và chạy tới!
    success = nav.move_to_npc(npc_target, map_target, wait_seconds=12, tolerance=1)
    
    if success:
        print(f"\n[SUCCESS] Đã tới chỗ {npc_target}!")
    else:
        print(f"\n[FAILED] Không tới được {npc_target}.")

if __name__ == "__main__":
    main()
