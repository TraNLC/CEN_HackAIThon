"""
tests/test_detect_map.py — Detect map + NPC list từ server protocol

Chức năng:
  1. Kết nối game qua Frida (VLTK1Bot)
  2. Lấy mapId hiện tại + tọa độ nhân vật
  3. Gửi eMapDialogNpcListRequest → nhận danh sách NPC thật từ server
  4. Click NPC qua protocol (eNpcDialogue) — KHÔNG cần tap giả lập
  5. Scan NPC entities từ opcode 9 sub_type 4

Chạy trực tiếp:
    python tests/test_detect_map.py
"""
import os
import sys
import time
import struct
import subprocess
import logging

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)
sys.path.insert(0, os.path.join(ROOT_DIR, "tests"))
sys.path.insert(0, os.path.join(ROOT_DIR, "proto"))

logging.basicConfig(level=logging.INFO, format="%(asctime)s [%(name)s] %(message)s",
                    datefmt="%H:%M:%S")
logger = logging.getLogger("detect_map")

ADB = r"C:\platform-tools\adb.exe"
DEVICE = "emulator-5554"


# ─── Map ID → Tên map ────────────────────────────────────
MAP_NAMES = {
    1: "Tương Dương",
    2: "Biện Kinh",
    3: "Thành Đô",
    4: "Ba Lăng Huyện",
    5: "Lạc Dương",
    6: "Giang Lăng",
    7: "Thái Nguyên",
    8: "Bảo Kê",
    9: "Tây An",
    10: "Ô Xương",
    11: "Đại Đô",
    12: "Hà Nội",
    13: "Linh Châu",
    20: "Map_20",
    37: "Biện Kinh (37)",
    53: "Ba Lăng Huyện (53)",
    80: "Dương Châu",
    99: "Vĩnh Lạc trấn",
    100: "Chu Tiên trấn",
    101: "Map_101",
    121: "Long Môn trấn",
    153: "Thạch Cổ trấn",
    162: "Đại Lý phủ",
    174: "Long Tuyền thôn",
    176: "Lâm An",
}


# ─── Protobuf helpers ────────────────────────────────────

def parse_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80):
            break
    return result, pos


def parse_npc_list_response(raw_body: bytes) -> dict:
    """Parse eMapDialogNpcListResponse (opcode 72).
    
    Fields:
      field 1 (varint) = mapId
      field 2 (repeated len-delimited) = MapDialogNpc { name, mapX, mapY }
    """
    result = {"mapId": None, "npcs": []}
    pos = 0
    while pos < len(raw_body):
        tag, pos = parse_varint(raw_body, pos)
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = parse_varint(raw_body, pos)
            if fnum == 1:
                result["mapId"] = val
        elif wtype == 2:
            ln, pos = parse_varint(raw_body, pos)
            raw = raw_body[pos:pos+ln]; pos += ln
            if fnum == 2:
                npc = _parse_npc_entry(raw)
                if npc:
                    result["npcs"].append(npc)
        else:
            break
    return result


def _parse_npc_entry(raw: bytes) -> dict:
    """Parse a single MapDialogNpc { name=1, mapX=2, mapY=3 }."""
    npc = {"name": "", "mapX": 0, "mapY": 0}
    pos = 0
    while pos < len(raw):
        tag, pos = parse_varint(raw, pos)
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = parse_varint(raw, pos)
            if fnum == 2: npc["mapX"] = val
            elif fnum == 3: npc["mapY"] = val
        elif wtype == 2:
            ln, pos = parse_varint(raw, pos)
            val = raw[pos:pos+ln].decode('utf-8', errors='replace')
            pos += ln
            if fnum == 1: npc["name"] = val
        else:
            break
    return npc if npc["name"] else None


def parse_character_response(raw_body: bytes) -> dict:
    """Parse eCharacterResponse (opcode 12) — lấy mapId, mapX, mapY, name..."""
    result = {}
    pos = 0
    while pos < len(raw_body):
        if pos >= len(raw_body):
            break
        tag, pos = parse_varint(raw_body, pos)
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = parse_varint(raw_body, pos)
            # Character proto: mapId=22, mapX=23, mapY=24, level=8, sex=4, sect=5
            if fnum == 22: result["mapId"] = val
            elif fnum == 23: result["mapX"] = val
            elif fnum == 24: result["mapY"] = val
            elif fnum == 8: result["level"] = val
            elif fnum == 4: result["sex"] = val
            elif fnum == 5: result["sect"] = val
        elif wtype == 2:
            ln, pos = parse_varint(raw_body, pos)
            if pos + ln > len(raw_body): break
            val = raw_body[pos:pos+ln]; pos += ln
            try:
                text = val.decode('utf-8')
                if fnum == 3: result["name"] = text
                elif fnum == 2: result["account"] = text
                elif fnum == 1: result["cid"] = text
            except:
                pass
        elif wtype == 5:
            pos += 4
        elif wtype == 1:
            pos += 8
        else:
            break
    return result


# ─── Scan NPC entities từ opcode 9 (live) ─────────────────

def scan_npc_entities_from_packets(packets: list) -> list:
    """Tìm NPC entities từ opcode 9 sub_type 4.
    
    Format: 4|npc_id|etype_sub|npc_type|NPC_NAME|world_x|world_y|direction
    
    Returns:
        List of {npc_id, name, world_x, world_y, game_x, game_y}
    """
    npcs = {}
    for opcode, body in packets:
        if opcode != 9 or len(body) < 10:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        parts = text.split('|')
        if len(parts) < 5:
            continue
        try:
            etype = int(parts[0])
        except (ValueError, IndexError):
            continue
        
        # etype 4 = NPC info (tên + tọa độ)
        if etype == 4 and len(parts) >= 7:
            npc_id = parts[1]
            name = parts[4]
            try:
                wx, wy = int(parts[5]), int(parts[6])
                gx, gy = wx // 256, wy // 256
                if gx < 1 or gy < 1:
                    continue
                npcs[npc_id] = {
                    "npc_id": npc_id,
                    "name": name,
                    "world_x": wx, "world_y": wy,
                    "game_x": gx, "game_y": gy,
                }
            except (ValueError, IndexError):
                pass
        
        # etype 6 = NPC position update (thường không có tên)
        elif etype == 6 and len(parts) >= 4:
            npc_id = parts[1]
            try:
                wx, wy = int(parts[2]), int(parts[3])
                gx, gy = wx // 256, wy // 256
                if gx < 1 or gy < 1:
                    continue
                if npc_id not in npcs:
                    npcs[npc_id] = {
                        "npc_id": npc_id,
                        "name": f"(entity {npc_id})",
                        "world_x": wx, "world_y": wy,
                        "game_x": gx, "game_y": gy,
                    }
                else:
                    npcs[npc_id]["world_x"] = wx
                    npcs[npc_id]["world_y"] = wy
                    npcs[npc_id]["game_x"] = gx
                    npcs[npc_id]["game_y"] = gy
            except (ValueError, IndexError):
                pass
    
    return sorted(npcs.values(), key=lambda n: n["name"])


# ─── ADB / tcpdump helpers ───────────────────────────────

def adb(cmd: str, timeout=5) -> str:
    result = subprocess.run(
        [ADB, "-s", DEVICE, "shell", cmd],
        capture_output=True, timeout=timeout)
    return result.stdout.decode(errors='ignore')

def adb_tap(x: int, y: int):
    subprocess.run([ADB, "-s", DEVICE, "shell", f"input tap {x} {y}"],
                   capture_output=True, timeout=5)

def adb_swipe(x1, y1, x2, y2, duration_ms=300):
    subprocess.run([ADB, "-s", DEVICE, "shell",
                    f"input swipe {x1} {y1} {x2} {y2} {duration_ms}"],
                   capture_output=True, timeout=10)

def adb_tap(x: int, y: int):
    subprocess.run([ADB, "-s", DEVICE, "shell", f"input tap {x} {y}"],
                   capture_output=True, timeout=5)

def sendevent_swipe(x1, y1, x2, y2, duration_ms=600, steps=20):
    """Vuốt bằng sendevent (raw kernel touch events).
    
    Unity ScrollRect thường bỏ qua 'input swipe' của Android,
    nhưng LUÔN phản hồi với raw touch events từ kernel.
    
    Device: /dev/input/event3 (ABS_MT max 959x539 = screen pixels)
    """
    dev = "/dev/input/event3"
    step_delay_ms = max(1, duration_ms // steps)
    
    # Xây dựng chuỗi lệnh sendevent chạy 1 lần trên device
    cmds = []
    
    # Touch DOWN
    cmds.append(f"sendevent {dev} 3 57 0")     # ABS_MT_TRACKING_ID = 0
    cmds.append(f"sendevent {dev} 3 53 {x1}")  # ABS_MT_POSITION_X
    cmds.append(f"sendevent {dev} 3 54 {y1}")  # ABS_MT_POSITION_Y
    cmds.append(f"sendevent {dev} 1 330 1")    # BTN_TOUCH DOWN
    cmds.append(f"sendevent {dev} 0 0 0")      # SYN_REPORT
    
    # MOVE steps (chia nhỏ quãng đường)
    for i in range(1, steps + 1):
        cx = x1 + (x2 - x1) * i // steps
        cy = y1 + (y2 - y1) * i // steps
        cmds.append(f"sleep 0.{step_delay_ms:03d}")
        cmds.append(f"sendevent {dev} 3 53 {cx}")
        cmds.append(f"sendevent {dev} 3 54 {cy}")
        cmds.append(f"sendevent {dev} 0 0 0")
    
    # Touch UP
    cmds.append(f"sendevent {dev} 3 57 4294967295")  # TRACKING_ID = -1
    cmds.append(f"sendevent {dev} 1 330 0")          # BTN_TOUCH UP
    cmds.append(f"sendevent {dev} 0 0 0")            # SYN_REPORT
    
    # Chạy toàn bộ chuỗi lệnh 1 shot trên device
    script = " && ".join(cmds)
    subprocess.run([ADB, "-s", DEVICE, "shell", script],
                   capture_output=True, timeout=30)


def detect_port() -> int:
    out = adb('su -c "netstat -tnp 2>/dev/null"')
    for line in out.splitlines():
        if 'jx1mobile' in line and 'ESTABLISHED' in line:
            port = int(line.split()[4].split(':')[-1])
            if port > 1024:
                return port
    return 45676


def capture_packets(duration=4, tap=True) -> list:
    """Capture packets qua tcpdump.
    
    Returns:
        List of (opcode, body) tuples
    """
    port = detect_port()
    pcap_dev = "/data/local/tmp/map_detect.pcap"
    pcap_local = os.path.join(ROOT_DIR, "data", "output", "map_detect.pcap")
    os.makedirs(os.path.dirname(pcap_local), exist_ok=True)

    adb('su -c "killall tcpdump 2>/dev/null"')
    adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
    time.sleep(0.2)

    proc = subprocess.Popen(
        [ADB, "-s", DEVICE, "shell",
         f'su -c "tcpdump -i any -U -w {pcap_dev} -c 500 port {port}"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)

    time.sleep(0.5)
    if tap:
        subprocess.run([ADB, "-s", DEVICE, "shell", "input tap 480 300"],
                       capture_output=True, timeout=5)
    time.sleep(duration)

    adb('su -c "killall tcpdump 2>/dev/null"')
    proc.terminate()
    time.sleep(0.5)

    subprocess.run([ADB, "-s", DEVICE, "pull", pcap_dev, pcap_local],
                   capture_output=True, timeout=10)

    if not os.path.exists(pcap_local):
        return []

    from test_open_shop import parse_pcap_recv
    return parse_pcap_recv(pcap_local, port)


# ─── Main ─────────────────────────────────────────────────

def run():
    print()
    print("=" * 60)
    print("  VLTK1 — Detect Map + NPC List (Protocol)")
    print("=" * 60)

    # ─── Phase 1: Kết nối Frida bot ───
    print("\n[1] Kết nối Frida bot...")
    from features.bot.game_bot import VLTK1Bot
    
    bot = VLTK1Bot()
    if not bot.connect():
        print("  ❌ Không kết nối được Frida. Game đang chạy không?")
        return

    # ─── Phase 2: Lấy character info (mapId, position) ───
    print("\n[2] Lấy thông tin nhân vật + mapId...")
    
    # Start tcpdump trước khi gửi request
    port = detect_port()
    pcap_dev = "/data/local/tmp/map_detect.pcap"
    pcap_local = os.path.join(ROOT_DIR, "data", "output", "map_detect.pcap")
    os.makedirs(os.path.dirname(pcap_local), exist_ok=True)

    adb('su -c "killall tcpdump 2>/dev/null"')
    adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
    time.sleep(0.3)

    tcpdump = subprocess.Popen(
        [ADB, "-s", DEVICE, "shell",
         f'su -c "tcpdump -i any -U -w {pcap_dev} -c 2000 port {port}"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(0.5)

    # Gửi eCharacterRequest → server trả eCharacterResponse chứa mapId
    print("  Gửi eCharacterRequest...")
    bot.send_gs('eCharacterRequest')
    time.sleep(2)

    # ─── Phase 3: Request NPC list ───
    # Thử tất cả mapId phổ biến, server chỉ trả NPC cho map hiện tại
    print("\n[3] Gửi eMapDialogNpcListRequest...")
    
    # Gửi request cho nhiều mapId — server sẽ trả về cho map mình đang đứng
    for map_id in sorted(MAP_NAMES.keys()):
        bot.send_gs('eMapDialogNpcListRequest', mapId=map_id)
        time.sleep(0.1)
    
    print("  Chờ server phản hồi...")
    time.sleep(3)

    # Stop tcpdump
    adb('su -c "killall tcpdump 2>/dev/null"')
    tcpdump.terminate()
    time.sleep(0.5)

    subprocess.run([ADB, "-s", DEVICE, "pull", pcap_dev, pcap_local],
                   capture_output=True, timeout=10)

    if not os.path.exists(pcap_local):
        print("  ❌ Không capture được packets")
        bot.close()
        return

    # Parse packets
    from test_open_shop import parse_pcap_recv
    packets = parse_pcap_recv(pcap_local, port)
    print(f"  Captured {len(packets)} packets")

    # ─── Parse character info ───
    char_info = {}
    for opcode, body in packets:
        if opcode == 12 and len(body) > 20:  # eCharacterResponse
            char_info = parse_character_response(body)
            break

    char_name = char_info.get("name", "?")

    # ─── Parse NPC list responses (opcode 72) ───
    npc_lists = []
    for opcode, body in packets:
        if opcode == 72 and len(body) > 5:  # eMapDialogNpcListResponse
            parsed = parse_npc_list_response(body)
            if parsed["npcs"]:
                npc_lists.append(parsed)

    # ─── Scan NPC entities live (opcode 9 sub_type 4/6) ───
    npc_entities = scan_npc_entities_from_packets(packets)

    # ─── Xác định map hiện tại bằng cross-reference ───
    # So sánh tọa độ NPC entities (live) với NPC list (server)
    # Map nào có NPC khớp tọa độ nhiều nhất = map hiện tại
    current_map_id = 0
    current_map_name = "Unknown"
    current_npc_list = None
    
    if npc_entities and npc_lists:
        best_match = 0
        for npc_list in npc_lists:
            matches = 0
            for entity in npc_entities:
                for server_npc in npc_list["npcs"]:
                    # So sánh world coords (cho phép sai số nhỏ)
                    dx = abs(entity["world_x"] - server_npc["mapX"])
                    dy = abs(entity["world_y"] - server_npc["mapY"])
                    if dx < 50 and dy < 50:
                        matches += 1
                        break
            if matches > best_match:
                best_match = matches
                current_map_id = npc_list["mapId"]
                current_map_name = MAP_NAMES.get(current_map_id, f"Map_{current_map_id}")
                current_npc_list = npc_list
    elif npc_lists:
        # Fallback: lấy map đầu tiên (server thường trả map hiện tại trước)
        current_map_id = npc_lists[0]["mapId"]
        current_map_name = MAP_NAMES.get(current_map_id, f"Map_{current_map_id}")
        current_npc_list = npc_lists[0]

    # Lấy tọa độ nhân vật từ entities (entity gần trung tâm nhất)
    gx, gy = 0, 0
    if npc_entities:
        # Dùng trung bình tọa độ entities làm ước lượng vị trí
        avg_gx = sum(n["game_x"] for n in npc_entities) // len(npc_entities)
        avg_gy = sum(n["game_y"] for n in npc_entities) // len(npc_entities)
        gx, gy = avg_gx, avg_gy

    print(f"\n  📍 Nhân vật: {char_name}")
    print(f"     Map:      {current_map_name} (ID={current_map_id})")
    if gx > 0:
        print(f"     Tọa độ:   ~({gx}, {gy}) (ước lượng từ entities)")

    # ─── Hiển thị NPC list của MAP HIỆN TẠI ───
    print(f"\n[4] Danh sách NPC trên {current_map_name} (từ server):")
    
    if current_npc_list:
        npcs = current_npc_list["npcs"]
        print(f"  {len(npcs)} NPCs:")
        print(f"  {'#':>3}  {'Tên NPC':<30} {'Tọa độ':>12}")
        print(f"  {'─'*50}")
        for i, npc in enumerate(npcs, 1):
            print(f"  {i:3d}  {npc['name']:<30} ({npc['mapX']:>3}, {npc['mapY']:>3})")
    elif npc_lists:
        print(f"  Server trả NPC cho {len(npc_lists)} maps (không xác định được map hiện tại):")
        for npc_list in npc_lists:
            mid = npc_list["mapId"]
            mname = MAP_NAMES.get(mid, f"Map_{mid}")
            print(f"    - {mname} (ID={mid}): {len(npc_list['npcs'])} NPCs")
    else:
        print("  ⚠️  Không nhận được NPC list từ server (opcode 72)")

    # ─── NPC entities live ───
    print(f"\n[5] NPC entities gần bạn (live scan từ opcode 9):")
    
    if npc_entities:
        print(f"  Tìm thấy {len(npc_entities)} NPC entities:")
        print(f"  {'ID':>8}  {'Tên NPC':<25} {'Game':>10}  {'World':>14}")
        print(f"  {'─'*62}")
        for npc in npc_entities:
            print(f"  {npc['npc_id']:>8}  {npc['name']:<25} ({npc['game_x']:>3},{npc['game_y']:>3})  ({npc['world_x']:>5},{npc['world_y']:>5})")
    else:
        print("  Không tìm thấy NPC entities trong packets")

    # ─── Mở Bản đồ & Click NPC trên UI ───
    print(f"\n[6] Tự động Bật Bản Đồ và Click 'Lễ Quan':")
    print(f"  🗺️ Bấm vào Minimap (góc trên phải) để mở bảng...")
    adb_tap(880, 80)
    time.sleep(1.0)  # Chờ animation mở bảng Map
    
    click_npc_ui_list(current_npc_list, "Lễ Quan")

    # ─── Summary ───
    npc_total = len(current_npc_list["npcs"]) if current_npc_list else 0
    entity_total = len(npc_entities)
    
    print(f"\n{'─' * 60}")
    print(f"  KẾT QUẢ:")
    print(f"    Nhân vật: {char_name}")
    print(f"    Map:      {current_map_name} (ID={current_map_id})")
    if gx > 0:
        print(f"    Tọa độ:   ~({gx}, {gy})")
    print(f"    NPC (server):   {npc_total}")
    print(f"    NPC (entities): {entity_total}")
    print(f"{'─' * 60}")

    bot.close()




def click_npc_ui_list(npc_list: dict, npc_name: str):
    """
    Click NPC trong danh sách UI của Big Map dựa vào index từ packet server.
    Không cần OCR, không cần Native Hook (tránh crash Houdini).
    """
    if not npc_list or not npc_list.get("npcs"):
        print("  ❌ Không có danh sách NPC")
        return False
        
    target_idx = -1
    target = None
    
    for i, npc in enumerate(npc_list["npcs"]):
        if npc_name.lower() in npc["name"].lower():
            target_idx = i + 1  # 1-based index
            target = npc
            break
            
    if target_idx == -1:
        print(f"  ❌ Không tìm thấy '{npc_name}' trong NPC list")
        return False
        
    print(f"  🎯 {target['name']} (Index: {target_idx})")
    
    # Tọa độ X của nút trong list (cột bên trái)
    base_x = 100
    # Tọa độ Y của nút đầu tiên (Index 1)
    base_y = 167
    # Khoảng cách giữa các nút
    step_y = 29
    
    # Số item hiển thị cùng lúc trên list
    visible_items = 13
    
    if target_idx <= visible_items:
        # NPC nằm trong vùng nhìn thấy → tap thẳng
        tap_y = base_y + (target_idx - 1) * step_y
        print(f"  👆 NPC ở vị trí {target_idx} (visible) → Tap ({base_x}, {tap_y})")
        adb_tap(base_x, tap_y)
    else:
        # NPC nằm ngoài vùng nhìn thấy → cần cuộn
        # Dùng trackball roll để cuộn (Unity ScrollRect chấp nhận trackball events)
        items_to_scroll = target_idx - visible_items  # Số items cần cuộn thêm
        # Mỗi lệnh roll 0 3 cuộn ~1 item (29px). Gửi nhiều lần.
        # Roll tổng cộng items_to_scroll lần, mỗi lần roll 1 đơn vị
        total_rolls = items_to_scroll
        
        print(f"  🔄 Cần cuộn {total_rolls} items (trackball roll)...")
        
        # Trước khi roll, tap vào giữa list để focus
        adb_tap(base_x, base_y + 6 * step_y)  # Tap giữa list
        time.sleep(0.3)
        
        # Cuộn từng bước nhỏ, mỗi bước roll 3 đơn vị ≈ 1 item
        batch_size = 5  # Roll 5 items mỗi lệnh
        for i in range(0, total_rolls, batch_size):
            n = min(batch_size, total_rolls - i)
            subprocess.run([ADB, "-s", DEVICE, "shell", 
                          f"input trackball roll 0 {n * 3}"],
                         capture_output=True, timeout=5)
            time.sleep(0.2)
        
        time.sleep(0.3)
        
        # Sau khi cuộn, NPC mục tiêu giờ ở cuối list (vị trí cuối cùng nhìn thấy)
        tap_y = base_y + (visible_items - 1) * step_y  # Tap ở item cuối cùng
        print(f"  👆 Sau khi cuộn → Tap ({base_x}, {tap_y})")
        adb_tap(base_x, tap_y)
    
    print(f"  ✅ Đã bấm chọn {target['name']}! Nhân vật sẽ bắt đầu chạy.")
    return True

if __name__ == "__main__":
    run()
