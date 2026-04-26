"""
test_pathfinding.py
Script mô phỏng luồng Pathfinding (Tìm đường liên map) cho tính năng Dã Tẩu.
"""
import time
import heapq

# =================================================================
# 1. DATABASE MÔ PHỎNG (Sẽ lấy từ vltk1.db trong thực tế)
# =================================================================

# Đồ thị liên kết các Map (Từ Map A có thể đi qua Map B)
# Cấu trúc: MAP_LINKS[Map_Nguồn] = [(Map_Đích, Tọa_Độ_Cổng_X, Tọa_Độ_Cổng_Y)]
MAP_LINKS = {
    "Tương Dương": [("Ba Lăng Huyện", 150, 200), ("Kiếm Các", 180, 210)],
    "Ba Lăng Huyện": [("Tương Dương", 200, 180), ("Vũ Lăng Sơn", 220, 220)],
    "Kiếm Các": [("Tương Dương", 160, 190)],
    "Vũ Lăng Sơn": [("Ba Lăng Huyện", 190, 190)]
}

# Tọa độ của các NPC quan trọng trên từng Map
NPC_LOCATIONS = {
    "Dã Tẩu_Tương Dương": (195, 200),
    "Dã Tẩu_Ba Lăng Huyện": (205, 198),
    "Dã Tẩu_Biện Kinh": (214, 195),  # Thêm Dã tẩu ở Biện Kinh
    "Tạp Hóa_Tương Dương": (180, 190)
}

# =================================================================
# 2. GLOBAL PATHFINDING (Tìm đường đi qua nhiều Map - Dùng BFS/Dijkstra)
# =================================================================
def find_nearest_npc_route(start_map, target_npc_name):
    """
    Thuật toán BFS tìm đường ngắn nhất tới 1 NPC bất kỳ có tên target_npc_name.
    Nếu NPC nằm ngay trong Map hiện tại -> Trả về mảng 1 phần tử [start_map].
    """
    print(f"[Global] Đang quét hệ thống để tìm NPC '{target_npc_name}' gần nhất...")
    
    queue = [[start_map]]
    visited = set()
    
    while queue:
        path = queue.pop(0)
        curr_map = path[-1]
        
        # Check xem Map hiện tại có NPC này không?
        npc_key = f"{target_npc_name}_{curr_map}"
        if npc_key in NPC_LOCATIONS:
            print(f"[Global] Đã phát hiện {target_npc_name} tại {curr_map} (Cách {len(path)-1} cổng)")
            return path
            
        if curr_map not in visited:
            visited.add(curr_map)
            for neighbor, _, _ in MAP_LINKS.get(curr_map, []):
                new_path = list(path)
                new_path.append(neighbor)
                queue.append(new_path)
    return None

# =================================================================
# 3. LOCAL PATHFINDING (Tìm đường trong 1 Map - Dùng A*)
# =================================================================
def local_astar(start_pos, target_pos):
    """Thuật toán A* rút gọn để tính từng bước di chuyển nội bộ."""
    print(f"  [Local A*] Tính đường nội bộ từ {start_pos} đến {target_pos}...")
    route = [start_pos, (start_pos[0]+10, start_pos[1]+5), target_pos]
    return route

def send_move_packet(x, y):
    """Hàm giả lập bắn Packet di chuyển vào Memory (Dùng IPC / Frida)"""
    print(f"    -> [Memory Hook] Đã check SyncPosition, tiếp tục chạy tới ({x}, {y})")
    time.sleep(0.3)

def send_npc_click_packet(npc_name):
    print(f"    -> [Memory Hook] Bắn Packet Click vào NPC [{npc_name}]")

# =================================================================
# 4. BOT ENGINE (Thực thi chuỗi hành động)
# =================================================================
def navigate_to_nearest_npc(current_map, current_pos, target_npc):
    print(f"\n{'='*50}\nBẮT ĐẦU AUTO TÌM ĐƯỜNG: {target_npc}\n{'='*50}")
    
    # Bước 1: Tìm lộ trình tới NPC gần nhất
    route = find_nearest_npc_route(current_map, target_npc)
    if not route:
        print("Không tìm thấy NPC này ở bất kỳ đâu trên giang hồ!")
        return False
    
    print(f"[Bot] Lộ trình Maps: {' -> '.join(route)}")
    
    # Bước 2: Đi qua từng cổng (Nếu NPC ở Map khác)
    curr_pos = current_pos
    for i in range(len(route) - 1):
        map_a = route[i]
        map_b = route[i+1]
        
        # Tìm tọa độ cổng để nhảy sang Map B
        portal_pos = next((m, x, y) for m, x, y in MAP_LINKS[map_a] if m == map_b)
        portal_pos = (portal_pos[1], portal_pos[2])
        
        print(f"\n[Bot] Đang ở {map_a}, cần di chuyển tới cổng {map_b} {portal_pos}")
        waypoints = local_astar(curr_pos, portal_pos)
        
        for wp in waypoints:
            send_move_packet(wp[0], wp[1])
        
        print(f"[Bot] Đã tới cổng. Đợi gói tin đổi map (eEnterMap) -> {map_b}")
        time.sleep(1)
        curr_pos = (10, 10) 

    # Bước 3: Đã đến Map chứa NPC, bắt đầu đi bộ lại gần NPC
    final_map = route[-1]
    npc_pos = NPC_LOCATIONS[f"{target_npc}_{final_map}"]
    print(f"\n[Bot] Đã có mặt tại {final_map}. Bắt đầu đi bộ tới {target_npc} tại {npc_pos}")
    
    waypoints = local_astar(curr_pos, npc_pos)
    for wp in waypoints:
        send_move_packet(wp[0], wp[1])
        
    print("[Bot] Đã đến sát NPC!")
    send_npc_click_packet(target_npc)
    return True

# =================================================================
# 5. TEST RUNNER
# =================================================================
if __name__ == "__main__":
    # Test Case 1: Đang ở Biện Kinh -> Tự biết tìm Dã Tẩu Biện Kinh (Không cần qua map)
    MAP_LINKS["Biện Kinh"] = [("Ba Lăng Huyện", 100, 100)] # Thêm liên kết mô phỏng
    
    print("\n>>> TEST CASE 1: Đang ở Thành (Biện Kinh) có sẵn Dã Tẩu")
    navigate_to_nearest_npc(current_map="Biện Kinh", current_pos=(150, 150), target_npc="Dã Tẩu")
    
    # Test Case 2: Đang ở Bãi Train (Vũ Lăng Sơn) -> Tự biết tìm Dã Tẩu gần nhất ở Ba Lăng Huyện
    print("\n\n>>> TEST CASE 2: Đang ở Bãi Farm (Vũ Lăng Sơn) không có Dã Tẩu")
    navigate_to_nearest_npc(current_map="Vũ Lăng Sơn", current_pos=(100, 100), target_npc="Dã Tẩu")
