import re

with open('e:/tool/sample-test/vltk1-re/features/bot/game_bot.py', 'r', encoding='utf-8') as f:
    content = f.read()

new_func = '''def go_to_datau_via_ui(self):
        """Tự động Mở Bản Đồ lớn và click chính xác vị trí Dã Tẩu trên ảnh Bản đồ"""
        import time
        print("[+] Thực hiện chuỗi lệnh UI: Mở Map -> Click tọa độ Dã Tẩu -> Đóng Map")
        self.adb_tap(900, 50)  # Mở bản đồ (Minimap góc phải trên)
        time.sleep(2.0)
        self.adb_tap(206, 201) # Click đúng pixel Dã Tẩu trên hình bản đồ lớn
        time.sleep(1.0)
        self.adb_tap(900, 50)  # Đóng bản đồ
        print("[+] Đã click chọn Dã Tẩu trên Map, nhân vật đang tự động chạy!")'''

content = re.sub(r'def go_to_datau_via_ui\(self\):.*?print\(\"\[\+\] Đã click chọn Dã Tẩu.*?\)', new_func, content, flags=re.DOTALL)

with open('e:/tool/sample-test/vltk1-re/features/bot/game_bot.py', 'w', encoding='utf-8') as f:
    f.write(content)
