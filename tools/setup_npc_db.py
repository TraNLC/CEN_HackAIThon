import re

with open('e:/tool/sample-test/vltk1-re/features/bot/game_bot.py', 'r', encoding='utf-8') as f:
    content = f.read()

new_logic = '''
    # Tọa độ Map Ảnh của các NPC quan trọng (Pixel X, Pixel Y)
    NPC_MAP_COORDS = {
        "Tương Dương": {
            "Dã Tẩu": (206, 201),
            "Chủ Tiền Trang": (150, 150), # Tọa độ ảo, cần update sau
            "Dược Điếm": (100, 100)      # Tọa độ ảo, cần update sau
        },
        "Biện Kinh": {
            "Dã Tẩu": (200, 200)         # Tọa độ ảo, cần update sau
        }
    }

    def go_to_npc_via_map(self, npc_name: str, map_name: str = "Tương Dương"):
        \"\"\"Mở bản đồ lớn và click vào NPC dựa trên thư viện tọa độ\"\"\"
        if map_name not in self.NPC_MAP_COORDS or npc_name not in self.NPC_MAP_COORDS[map_name]:
            print(f"[-] Chưa có dữ liệu tọa độ bản đồ cho {npc_name} tại {map_name}!")
            return False
            
        x, y = self.NPC_MAP_COORDS[map_name][npc_name]
        
        import time
        print(f"[+] Điều hướng đến {npc_name} tại {map_name} (Map Pixel: {x}, {y})")
        self.adb_tap(900, 50)  # Mở bản đồ
        time.sleep(2.0)
        self.adb_tap(x, y)     # Click tọa độ NPC
        time.sleep(1.0)
        self.adb_tap(900, 50)  # Đóng bản đồ
        print(f"[+] Đã click chọn {npc_name} trên Map, nhân vật đang tự động chạy!")
        return True
'''

content = re.sub(r'    def go_to_datau_via_ui\(self\):.*?print\("\[\+\] Đã click chọn Dã Tẩu trên Map, nhân vật đang tự động chạy!"\)', new_logic, content, flags=re.DOTALL)

with open('e:/tool/sample-test/vltk1-re/features/bot/game_bot.py', 'w', encoding='utf-8') as f:
    f.write(content)
