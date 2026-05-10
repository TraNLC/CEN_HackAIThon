import sys
import os
import time

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from core.adb_helper import ADBHelper
from core.position import detect_player_position, COORD_DIVISOR

def calibrate():
    print("="*50)
    print("  TÌM KIẾM ENTITY ID CHÍNH XÁC CỦA NHÂN VẬT")
    print("="*50)
    print("[1] Vui lòng KHÔNG THAO TÁC trên giả lập.")
    print("[2] Script sẽ tự động click màn hình để nhân vật di chuyển 1 chút.")
    print("[3] Tool sẽ phân tích packet để khóa mục tiêu chính xác.\n")
    
    adb = ADBHelper()
    
    # Xóa EID cũ
    if os.path.exists(adb.eid_file):
        os.remove(adb.eid_file)
    adb._tracked_eid = ""
    
    adb.init_frida()
    if not adb.frida_script:
        print("[!] Lỗi: Không thể attach Frida.")
        return
        
    print("Đang thu thập dữ liệu (3 giây)...")
    adb.flush_recv()
    
    # Bấm vài phát ra góc màn hình để nhân vật chắc chắn phải đi bộ
    # Không bấm ở giữa để tránh click trúng NPC/Người khác
    # Dùng tcpdump để bắt gói tin vì nó stream-safe
    wx, wy = adb._get_position_tcpdump(trigger_tap=True)
    eid = adb._tracked_eid
    
    if eid and wx > 0:
        print(f"\n[SUCCESS] Đã khóa thành công Entity ID của bạn: {eid}")
        print(f"Tọa độ hiện tại: {wx}, {wy}")
        adb._save_eid(eid)
        print("Đã lưu vào data/tracked_eid.txt! Các tool di chuyển giờ sẽ chạy chuẩn 100%.")
    else:
        print("\n[FAILED] Không nhận diện được nhân vật. Hãy ra chỗ vắng người hơn và chạy lại script này.")

if __name__ == "__main__":
    calibrate()
