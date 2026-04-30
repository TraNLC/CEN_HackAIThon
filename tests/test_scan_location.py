"""
test_scan_location.py - Quét vị trí nhân vật + NPC map hiện tại

Kết hợp:
  1. Probe map ID qua opcode 71/72 (NpcListRequest/Response)
  2. Bắt tọa độ nhân vật qua opcode 9 (entity sync) 
  3. Load NPC từ data/maps/map_*.json đã quét sẵn
  4. Tìm NPC gần nhân vật nhất

100% network protocol via tcpdump. Cần Frida cho probe map.

Chạy: python tests/test_scan_location.py
"""
import sys
import os
import time
import json
import struct
import subprocess
import math
import re
from pathlib import Path
from collections import defaultdict

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))
sys.stdout.reconfigure(encoding='utf-8')

from features.bot.game_bot import VLTK1Bot
from vltk1_protocol import encode_message_fields

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE = 'vn.perfingame.jx1mobile'
PCAP_DEV = '/data/local/tmp/loc.pcap'
PCAP_LOC = str(ROOT_DIR / 'data' / 'output' / 'loc.pcap')
MAP_DIR = ROOT_DIR / 'data' / 'maps'

ALL_MAP_IDS = [1, 11, 20, 37, 53, 54, 78, 80, 99, 100, 101, 121, 153, 162, 174, 176]
MAP_NAMES = {
    1: "Phượng Tường", 11: "Thành Đô", 20: "Giang Tân Thôn",
    37: "Biện Kinh", 53: "Ba Lăng Huyện", 54: "Nam Nhạc Trấn",
    78: "Tương Dương", 80: "Dương Châu", 99: "Vĩnh Lạc trấn",
    100: "Chu Tiên trấn", 101: "Đạo Hương Thôn", 121: "Long Môn trấn",
    153: "Thạch Cổ trấn", 162: "Đại Lý phủ", 174: "Long Tuyền thôn",
    176: "Lâm An",
}

# NPC categories
SHOP_KW = ["dược điếm", "tạp hóa", "cầm đồ", "tiệm trà", "tửu lầu",
            "lữ quán", "tiêu cục", "tiền trang", "thợ rèn", "bán ngựa",
            "đồ cổ", "sòng bạc", "hàng rong"]
QUEST_KW = ["dã tẩu", "lễ quan", "dịch quan", "võ lâm truyền nhân"]
TRANS_KW = ["xa phu", "thuyền"]


def categorize_npc(name):
    nl = name.lower()
    for kw in QUEST_KW:
        if kw in nl: return "⭐"
    for kw in SHOP_KW:
        if kw in nl: return "🛒"
    for kw in TRANS_KW:
        if kw in nl: return "🚗"
    return "👤"


def read_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80): break
    return result, pos


def parse_npc_list_response(body):
    """Parse opcode 72 response → (map_id, [npc...])"""
    map_id, npcs = None, []
    pos = 0
    while pos < len(body):
        tag, pos = read_varint(body, pos)
        if pos > len(body): break
        field, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(body, pos)
            if field == 1: map_id = val
        elif wtype == 2:
            ln, pos = read_varint(body, pos)
            raw = body[pos:pos+ln]; pos += ln
            if field == 2:
                npc = {"name": "", "x": 0, "y": 0}
                p2 = 0
                while p2 < len(raw):
                    t2, p2 = read_varint(raw, p2)
                    f2, w2 = t2 >> 3, t2 & 0x7
                    if w2 == 0:
                        v2, p2 = read_varint(raw, p2)
                        if f2 == 2: npc["x"] = v2
                        elif f2 == 3: npc["y"] = v2
                    elif w2 == 2:
                        l2, p2 = read_varint(raw, p2)
                        if f2 == 1: npc["name"] = raw[p2:p2+l2].decode('utf-8', errors='replace')
                        p2 += l2
                    else: break
                if npc["name"]: npcs.append(npc)
        else: break
    return map_id, npcs


def build_map_request(map_id):
    if map_id < 128:
        return struct.pack('<BB', 0x08, map_id)
    else:
        return struct.pack('<BBB', 0x08, (map_id & 0x7F) | 0x80, map_id >> 7)


def get_server_port(pid):
    try:
        out = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'cat /proc/{pid}/net/tcp'],
            timeout=5).decode('utf-8', errors='ignore')
        for line in out.splitlines()[1:]:
            parts = line.strip().split()
            if len(parts) >= 4 and parts[3] == '01':
                p = int(parts[2].split(':')[1], 16)
                if p > 1000 and p not in (5555, 5037, 27042, 27183):
                    return p
    except: pass
    return 443


def parse_pcap_recv(filepath, server_port):
    results = []
    try:
        with open(filepath, 'rb') as f: data = f.read()
    except: return results
    if len(data) < 24: return results
    magic = struct.unpack_from('<I', data, 0)[0]
    endian = '<' if magic == 0xa1b2c3d4 else '>'
    link_type = struct.unpack_from(f'{endian}I', data, 20)[0]
    recv_buf = b''
    offset = 24
    while offset + 16 <= len(data):
        _, _, incl_len, _ = struct.unpack_from(f'{endian}IIII', data, offset)
        offset += 16
        if offset + incl_len > len(data): break
        pkt = data[offset:offset + incl_len]; offset += incl_len
        if link_type == 113: ip_data = pkt[16:]
        elif link_type == 1: ip_data = pkt[14:]
        else: continue
        if len(ip_data) < 20 or ip_data[9] != 6: continue
        ihl = (ip_data[0] & 0xF) * 4
        tcp = ip_data[ihl:]
        if len(tcp) < 20: continue
        src_port = struct.unpack('>H', tcp[0:2])[0]
        tcp_hlen = ((tcp[12] >> 4) & 0xF) * 4
        payload = tcp[tcp_hlen:]
        if src_port == server_port and payload:
            recv_buf += payload
    p = 0
    while p + 6 <= len(recv_buf):
        pkt_len = struct.unpack_from('<I', recv_buf, p)[0]
        opcode = struct.unpack_from('<H', recv_buf, p + 4)[0]
        if pkt_len > 500000: break
        if p + 6 + pkt_len > len(recv_buf): break
        body = recv_buf[p + 6: p + 6 + pkt_len]
        results.append((opcode, body))
        p += 6 + pkt_len
    return results


def load_map_npcs(map_id):
    """Load NPC data from pre-scanned map JSON files."""
    fpath = MAP_DIR / f'map_{map_id}.json'
    if not fpath.exists():
        return []
    with open(fpath, 'r', encoding='utf-8') as f:
        data = json.load(f)
    return data.get('npcs', [])


def distance(x1, y1, x2, y2):
    return math.sqrt((x1 - x2) ** 2 + (y1 - y2) ** 2)


SALESMAN_RE = re.compile(r'^salesman\.\d+\.\d+$')


def run():
    print()
    print("=" * 62)
    print("  VLTK1 - SCAN LOCATION + MAP + NPCs")
    print("  (Detect map, player coords, NPC positions)")
    print("=" * 62)

    # Get PID + port
    try:
        pid = int(subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'],
            timeout=5).decode().strip().split()[0])
    except Exception as e:
        print(f"[-] PID error: {e}"); return

    port = get_server_port(pid)
    print(f"[+] PID: {pid} | Port: {port}")

    # Kill old tcpdump
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.3)

    # Start tcpdump
    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} -c 5000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(1)

    # Connect Frida bot to probe map
    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Frida connect failed!")
        tcpdump.terminate()
        return

    # Probe all map IDs (opcode 71)
    print(f"[*] Probing {len(ALL_MAP_IDS)} map IDs...")
    for mid in ALL_MAP_IDS:
        proto = build_map_request(mid)
        pkt = struct.pack('<IH', len(proto), 71) + proto
        bot.send_raw(pkt)
        time.sleep(0.03)

    # Auto-move: chạy ra xa rồi chạy về để ép Server gửi lại toàn bộ entity
    # Bước 1: Tap nhẹ để có sync packet, rồi bắt vị trí
    print("[*] Đang xác định vị trí nhân vật...")
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'input tap 400 300'], capture_output=True)
    time.sleep(3)
    
    # Pull pcap sớm để xác định vị trí hiện tại
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC], capture_output=True)
    early_packets = []
    for try_port in [port, 443, 80, 8080]:
        early_packets = parse_pcap_recv(PCAP_LOC, try_port)
        if early_packets: break
    
    cur_x, cur_y = 0, 0
    ent_counts = {}
    ent_pos = {}
    for opcode, body in early_packets:
        if opcode != 9 or len(body) < 10: continue
        try: text = body.decode('utf-8', errors='replace')
        except: continue
        parts = text.split('|')
        if len(parts) < 4: continue
        try: etype = int(parts[0])
        except: continue
        eid = parts[1]
        if etype in (1, 2) and len(parts) >= 4:
            try:
                x, y = int(parts[2]), int(parts[3])
                if x > 0:
                    ent_counts[eid] = ent_counts.get(eid, 0) + 1
                    ent_pos[eid] = (x, y)
            except: pass
    if ent_counts:
        my_id = max(ent_counts, key=ent_counts.get)
        cur_x, cur_y = ent_pos[my_id]
    
    if cur_x > 0:
        print(f"[+] Vị trí hiện tại: ({cur_x}, {cur_y})")
        # Bước 2: Chạy ra xa 3000 đơn vị (dùng đúng field mapx/mapy)
        far_x, far_y = cur_x - 3000, cur_y - 3000
        print(f"[*] Auto-move: Chạy ra xa → ({far_x}, {far_y})...")
        proto = encode_message_fields("GotoPosition", mapx=far_x, mapy=far_y)
        bot.send_raw(struct.pack('<IH', len(proto), 248) + proto)
        time.sleep(4)
        
        # Bước 3: Chạy về vị trí cũ → AOI refresh
        print(f"[*] Auto-move: Chạy về → ({cur_x}, {cur_y})...")
        proto = encode_message_fields("GotoPosition", mapx=cur_x, mapy=cur_y)
        bot.send_raw(struct.pack('<IH', len(proto), 248) + proto)
        time.sleep(8)
    else:
        print("[!] Chưa xác định được vị trí, chờ 10 giây...")
        time.sleep(10)

    bot.close()
    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.5)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC], capture_output=True)

    packets = []
    for try_port in [port, 443, 80, 8080, 60739, 45676]:
        packets = parse_pcap_recv(PCAP_LOC, try_port)
        if packets: break
    print(f"[+] {len(packets)} packets captured")

    # ── 1. Detect map (opcode 72) ──
    detected_map_id = None
    for opcode, body in packets:
        if opcode == 72 and len(body) > 5:
            mid, npcs = parse_npc_list_response(body)
            if mid and npcs:
                detected_map_id = mid
                break

    map_name = MAP_NAMES.get(detected_map_id, f"Map_{detected_map_id}") if detected_map_id else "???"

    # ── 2. Extract player + stall positions from opcode 9 ──
    entities = defaultdict(lambda: {"x": 0, "y": 0, "updates": 0})
    stalls = defaultdict(lambda: {"player_id": "", "x": 0, "y": 0, "name": "", "desc": "", "updates": 0})
    
    SALESMAN_RE2 = re.compile(r'^salesman\.(\d+)\.\d+$')
    
    for opcode, body in packets:
        if opcode != 9 or len(body) < 5:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        parts = text.split('|')
        if len(parts) < 2:
            continue
        try:
            etype = int(parts[0])
        except ValueError:
            continue
        
        entity_id = parts[1]
        
        # Check if it's a stall explicitly by type 33/34 OR salesman regex
        is_stall = (etype in (33, 34)) or SALESMAN_RE2.match(entity_id)
        
        if is_stall:
            stall = stalls[entity_id]
            m = SALESMAN_RE2.match(entity_id)
            stall["player_id"] = m.group(1) if m else entity_id
            stall["updates"] += 1

            
            # Type 33: stall info (name + desc + pos)
            if etype == 33 and len(parts) >= 4:
                stall["name"] = parts[2] if len(parts) > 2 else ""
                stall["desc"] = parts[3] if len(parts) > 3 else ""
                if len(parts) >= 10:
                    try:
                        stall["x"] = int(parts[8])
                        stall["y"] = int(parts[9])
                    except: pass
                    
            # Type 34: stall position
            if etype == 34 and len(parts) >= 4:
                try:
                    stall["x"] = int(parts[2])
                    stall["y"] = int(parts[3])
                except: pass
            
            # Try to get position from type 1/2 as fallback
            if etype in (1, 2) and len(parts) >= 4:
                try:
                    stall["x"] = int(parts[2])
                    stall["y"] = int(parts[3])
                except: pass
        else:
            ent = entities[entity_id]
            ent["updates"] += 1
            if etype in (1, 2) and len(parts) >= 4:
                try:
                    ent["x"] = int(parts[2])
                    ent["y"] = int(parts[3])
                except: pass

    # ── 2b. Player shop broadcasts (opcode 133) ──
    # Đã chuyển sang core/broadcast_scanner.py theo yêu cầu

    # My character = entity with most updates AND has position
    my_x, my_y, my_id = 0, 0, "?"
    positioned = [(eid, e) for eid, e in entities.items() if e["x"] > 0]
    if positioned:
        positioned.sort(key=lambda x: -x[1]["updates"])
        my_id = positioned[0][0]
        my_x = positioned[0][1]["x"]
        my_y = positioned[0][1]["y"]

    # ── 3. Load NPC from map JSON ──
    map_npcs = load_map_npcs(detected_map_id) if detected_map_id else []

    # ── DISPLAY ──
    pos_note = f"({my_x}, {my_y})" if my_x > 0 else "(đứng im - chưa bắt được)"
    print(f"\n╔{'═'*62}╗")
    print(f"║  🗺️  MAP: {map_name} (ID: {detected_map_id or '???'})")
    print(f"║  📍 VỊ TRÍ: {pos_note}")
    print(f"║  👥 Players: {len(entities)} | 🏪 Sạp hàng: {len(stalls)} | 📋 NPCs: {len(map_npcs)}")
    print(f"╚{'═'*62}╝")

    # ── PLAYER SHOPS (Sạp thực tế) ──
    if stalls:
        print(f"\n  🏪 SẠP HÀNG XUNG QUANH ({len(stalls)} sạp):")
        
        # Stalls from entity sync
        for sid, s in sorted(stalls.items(), key=lambda x: -x[1]["updates"]):
            pos_str = f"({s['x']}, {s['y']})" if s['x'] > 0 else "(chưa rõ)"
            d_str = ""
            if my_x > 0 and s['x'] > 0:
                d = distance(my_x, my_y, s['x'], s['y'])
                d_str = f" 📏 {d:.0f}"
            name = s['name'] or f"Player #{s['player_id']}"
            print(f"     🏪 {name:<25} {pos_str}{d_str}")
            if s['desc']:
                print(f"        📝 {s['desc'][:70]}")
    else:
        print(f"\n  🏪 Không có sạp hàng nào mở xung quanh")

    # NPC list with distance from player
    if map_npcs:
        categories = {"⭐": [], "🛒": [], "🚗": [], "👤": []}
        for npc in map_npcs:
            cat = categorize_npc(npc['name'])
            d = distance(my_x, my_y, npc['x'], npc['y']) if my_x > 0 else 0
            categories[cat].append({**npc, "dist": d})

        for cat in categories:
            categories[cat].sort(key=lambda n: n['dist'] if n['dist'] > 0 else 99999)

        if categories["⭐"]:
            print(f"\n  ⭐ QUEST NPCs ({len(categories['⭐'])}):")
            for n in categories["⭐"]:
                d_str = f"📏 {n['dist']:.0f}" if n['dist'] > 0 else ""
                print(f"     {n['name']:<30} ({n['x']:>5}, {n['y']:>5})  {d_str}")

        if categories["🛒"]:
            print(f"\n  🛒 SHOP NPCs ({len(categories['🛒'])}):")
            for n in categories["🛒"]:
                d_str = f"📏 {n['dist']:.0f}" if n['dist'] > 0 else ""
                print(f"     {n['name']:<30} ({n['x']:>5}, {n['y']:>5})  {d_str}")

        if categories["🚗"]:
            print(f"\n  🚗 TRANSPORT ({len(categories['🚗'])}):")
            for n in categories["🚗"]:
                d_str = f"📏 {n['dist']:.0f}" if n['dist'] > 0 else ""
                print(f"     {n['name']:<30} ({n['x']:>5}, {n['y']:>5})  {d_str}")

    # Other players nearby
    other_players = [(eid, e) for eid, e in entities.items() if e["x"] > 0 and eid != my_id]
    if other_players:
        other_players.sort(key=lambda x: -x[1]["updates"])
        print(f"\n  👥 PLAYERS ({len(other_players)}):")
        for eid, e in other_players[:15]:
            d = distance(my_x, my_y, e['x'], e['y']) if my_x > 0 else 0
            d_str = f"📏 {d:.0f}" if d > 0 else ""
            print(f"     ID {eid:>8} | ({e['x']:>5}, {e['y']:>5}) {d_str}")

    # Summary
    print(f"\n{'─'*62}")
    print(f"  Map: {map_name} | Tọa độ: {pos_note}")
    print(f"  Players: {len(entities)} | Shops: {len(stalls)} | NPCs: {len(map_npcs)}")
    print(f"{'─'*62}")



if __name__ == '__main__':
    run()

