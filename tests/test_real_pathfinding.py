import sys
import time
from pathlib import Path

# Thêm đường dẫn tới thư mục features/bot để import game_bot
ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))

from features.bot.game_bot import VLTK1Bot

# =================================================================
# GLOBAL STATE (Lưu trạng thái nội bộ của nhân vật lấy từ Packet)
# =================================================================
class CharState:
    def __init__(self):
        self.map_id = -1
        self.x = 0
        self.y = 0
        self.is_moving = False
        self.in_combat = False

char_state = CharState()

# =================================================================
# HANDLERS (Bắt Packet từ Server trả về qua Frida recv hook)
# =================================================================
def on_sync_position(payload):
    """
    Khi Server trả về gói tin xác nhận Tọa độ (eSyncPlayerMove / eEntitySync).
    Lưu ý: Bạn phải map đúng Opcode trong frida_bot.js
    """
    # Cấu trúc payload cần được Decode (RE) để lấy X, Y thật
    # Tạm thời giả lập chúng ta decode được:
    # char_state.x = payload['x']
    # char_state.y = payload['y']
    char_state.is_moving = True
    print(f"[RECV] Server Sync Position -> X: {char_state.x}, Y: {char_state.y}")

def on_enter_map(payload):
    """Khi Server xác nhận đổi Map thành công (eEnterMap)"""
    print(f"[RECV] Server xác nhận đã đổi sang MapID: {payload.get('map_id', 'Unknown')}")
    char_state.map_id = payload.get('map_id', -1)
    char_state.is_moving = False

# =================================================================
# LOGIC AUTO TÌM ĐƯỜNG (CÓ FEEDBACK LOOP)
# =================================================================
def real_navigate_to_datau(bot: VLTK1Bot):
    print("\n" + "="*50)
    print(" BẮT ĐẦU AUTO RUN ĐẾN DÃ TẨU (REAL MEMORY HOOK)")
    print("="*50)

    # Đăng ký hàm bắt Packet từ Server
    bot.on_recv('eSyncPlayerMove', on_sync_position)
    bot.on_recv('eEnterMap', on_enter_map)

    # 1. THỬ SỬ DỤNG TÍNH NĂNG NATIVE CỦA GAME TRƯỚC
    # Hầu hết game VLTK Mobile có tích hợp sẵn AutoPath nội bộ (eGotoNpc)
    print("\n[Bot] Gửi lệnh eGotoNpc('Dã Tẩu') vào Memory...")
    bot.goto_npc("Dã Tẩu")

    # Vòng lặp Feedback Loop (Watchdog chống kẹt)
    timeout = 0
    while timeout < 10:
        # Lấy Packet từ Frida Buffer
        packets = bot.poll_recv()
        for pkt in packets:
            if pkt['type'] == 'recv' and pkt['name'] == 'eNpcDialogue':
                print("[Bot] Đã mở được bảng Đối thoại của Dã Tẩu thành công!")
                return True
        
        # Kiểm tra xem tọa độ có bị kẹt không (Nếu đang dùng eGotoPosition)
        # if not char_state.is_moving and timeout > 3:
        #     print("[Bot] Đang bị kẹt, kích hoạt Local A* né vật cản...")
        #     bot.move_to(char_state.x + 5, char_state.y + 5) # Lách ra một chút
            
        time.sleep(0.5)
        timeout += 0.5
        print(f"  ... Đang chờ Server phản hồi (Timeout: {timeout}s)")

    print("[-] Không thấy Dã Tẩu mở bảng thoại. Có thể eGotoNpc thất bại do khác Map.")
    
    # 2. SỬ DỤNG ADB CHẠM MẶT ĐẤT HOẶC MỞ BẢN ĐỒ LỚN (GIẢI PHÁP TỐI ƯU NHẤT)
    print("
[Bot] Kích hoạt chế độ tự chạy bằng cách Click Map (Chính xác & Không Crash).")
    
    bot.go_to_npc_via_map("Dã Tẩu", "Tương Dương")
    
    walk_timeout = 0
    while walk_timeout < 15:
        bot.poll_recv()
        time.sleep(1)
        walk_timeout += 1
        print(f"  ... Đang chờ nhân vật chạy đến Dã Tẩu (Wait {walk_timeout}s)")
        # TODO: Cần kiểm tra xem UI Dã Tẩu đã mở lên chưa thông qua nhận diện UI hoặc packet


# =================================================================
# MAIN
# =================================================================
if __name__ == '__main__':
    # Khởi tạo Bot và kết nối Frida
    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Không thể kết nối tới Game. Hãy mở LDPlayer và chạy VLTK1 Mobile trước.")
        sys.exit(1)

    # Bật KeepAlive để chống Disconnect
    bot.auto_keepalive(interval=15)
    
    time.sleep(2) # Đợi các Hook ổn định

    # Chạy lệnh
    real_navigate_to_datau(bot)

    # Đóng kết nối
    bot.close()
