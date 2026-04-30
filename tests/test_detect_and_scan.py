"""
test_detect_and_scan.py - Tự động detect map + tọa độ nhân vật,
sau đó quét toàn bộ NPC/Shop xung quanh.

Flow:
  1. Gửi eMapDialogNpcListRequest cho TẤT CẢ City map IDs
  2. Server chỉ trả lời cho map mà nhân vật đang đứng
  3. Từ response → biết mapId + load NPC data đã collect
  4. Đồng thời parse opcode 133 để lấy danh sách Player Shop xung quanh

Chạy:
    python tests/test_detect_and_scan.py
"""
import sys
import time
import json
import struct
import subprocess
import math
from pathlib import Path
from collections import Counter

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.stdout.reconfigure(encoding='utf-8')

from features.bot.game_bot import VLTK1Bot

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
PCAP_DEV  = '/data/local/tmp/detect.pcap'
PCAP_LOC  = str(ROOT_DIR / 'data' / 'detect.pcap')
MAP_DIR   = ROOT_DIR / 'data' / 'output' / 'maps'

# Tất cả map IDs có thể có NPC Dialog (City + Town)
ALL_MAP_IDS = [1, 11, 20, 37, 53, 54, 78, 80, 99, 100, 101, 121, 153, 162, 174, 176]

MAP_NAMES = {
    1: "Phượng Tường", 11: "Thành Đô", 20: "Giang Tân Thôn",
    37: "Biện Kinh", 53: "Ba Lăng Huyện", 54: "Nam Nhạc Trấn",
    78: "Tương Dương", 80: "Dương Châu", 99: "Vĩnh Lạc trấn",
    100: "Chu Tiên trấn", 101: "Đạo Hương Thôn", 121: "Long Môn trấn",
    153: "Thạch Cổ trấn", 162: "Đại Lý phủ", 174: "Long Tuyền thôn",
    176: "Lâm An",
}


# ── Protobuf helpers ──────────────────────────────────────────────────────────

def read_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80):
            break
    return result, pos


def parse_npc_entry(raw: bytes) -> dict:
    npc = {"name": "", "x": 0, "y": 0}
    pos = 0
    while pos < len(raw):
        tag, pos = read_varint(raw, pos)
        if pos > len(raw): break
        field, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(raw, pos)
            if field == 2: npc["x"] = val
            elif field == 3: npc["y"] = val
        elif wtype == 2:
            ln, pos = read_varint(raw, pos)
            val = raw[pos:pos+ln]; pos += ln
            if field == 1:
                npc["name"] = val.decode("utf-8", errors="replace")
        else: break
    return npc


def parse_npc_list_response(body: bytes):
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
                npc = parse_npc_entry(raw)
                if npc["name"]: npcs.append(npc)
        else: break
    return map_id, npcs


def parse_player_shop(body: bytes) -> dict:
    """Parse opcode 133 - Player Shop/Stall around"""
    shop = {"type": 0, "id": "", "name": "", "desc": "", "items": ""}
    pos = 0
    while pos < len(body):
        tag, pos = read_varint(body, pos)
        if pos > len(body): break
        field, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(body, pos)
            if field == 1: shop["type"] = val
        elif wtype == 2:
            ln, pos = read_varint(body, pos)
            val = body[pos:pos+ln]; pos += ln
            text = val.decode("utf-8", errors="replace")
            if field == 2: shop["id"] = text
            elif field == 3: shop["name"] = text
            elif field == 4: shop["desc"] = text[:80]
            elif field == 5: shop["items"] = text[:60]
        else: break
    return shop


def build_map_request(map_id):
    if map_id < 128:
        return struct.pack('<BB', 0x08, map_id)
    else:
        b1 = (map_id & 0x7F) | 0x80
        b2 = map_id >> 7
        return struct.pack('<BBB', 0x08, b1, b2)


# ── PCAP parsing ──────────────────────────────────────────────────────────────

def get_server_port(pid):
    try:
        out = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'cat /proc/{pid}/net/tcp'],
            timeout=5).decode('utf-8', errors='ignore')
        for line in out.splitlines()[1:]:
            parts = line.strip().split()
            if len(parts) >= 4 and parts[3] == '01':
                return int(parts[2].split(':')[1], 16)
    except: pass
    return 45677


def parse_pcap_recv(filepath, server_port):
    results = []
    try:
        with open(filepath, 'rb') as f:
            data = f.read()
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
        opcode  = struct.unpack_from('<H', recv_buf, p + 4)[0]
        if pkt_len > 500000: break
        if p + 6 + pkt_len > len(recv_buf): break
        body = recv_buf[p + 6: p + 6 + pkt_len]
        results.append((opcode, body))
        p += 6 + pkt_len
    return results


def load_map_data(map_id):
    f = MAP_DIR / f'map_{map_id}.json'
    if f.exists():
        with open(f, 'r', encoding='utf-8') as fp:
            return json.load(fp)
    return None


# ── NPC categorization ────────────────────────────────────────────────────────

SHOP_KEYWORDS = [
    "dược điếm", "tạp hóa", "Tạp Hóa", "tiệm cầm đồ", "tiệm trà",
    "tửu điếm", "tửu lầu", "lữ quán", "Tiêu cục", "Tiền trang",
    "thợ rèn", "Thợ rèn", "bán ngựa", "Bán ngựa", "đồ cổ",
    "sòng bạc", "vật nuôi", "hàng rong", "Hàng rong", "thu tiền",
]
QUEST_KEYWORDS = [
    "Dã Tẩu", "Tẩu", "Lễ Quan", "Dịch quan", "Long Ngũ",
    "Võ Lâm truyền nhân", "Công thành quan",
]
TRANSPORT_KEYWORDS = ["Xa phu", "Thuyền", "thuyền"]


def categorize_npc(name):
    nl = name.lower()
    for kw in SHOP_KEYWORDS:
        if kw.lower() in nl: return "🛒 SHOP"
    for kw in QUEST_KEYWORDS:
        if kw.lower() in nl: return "📜 QUEST"
    for kw in TRANSPORT_KEYWORDS:
        if kw.lower() in nl: return "🚗 TRANSPORT"
    return "👤 NPC"


# ── Main ─────────────────────────────────────────────────────────────────────

def run():
    print()
    print("=" * 62)
    print("  VLTK1 - AUTO DETECT MAP + SCAN NPC/SHOP")
    print("=" * 62)

    # Get PID & port
    try:
        pid = int(subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'],
            timeout=5).decode().strip().split()[0])
    except Exception as e:
        print(f"[-] Cannot get PID: {e}"); return

    port = get_server_port(pid)
    print(f"[+] PID: {pid} | Port: {port}")

    # Kill old tcpdump & start new
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.5)

    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 2000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(2)

    # Connect bot
    bot = VLTK1Bot()
    if not bot.connect():
        tcpdump.terminate(); return

    # Strategy: send eMapDialogNpcListRequest for CURRENT map
    # Server only responds for the map we're standing on
    # We send for ALL known city/town map IDs, only 1 will respond
    print(f"[*] Probing {len(ALL_MAP_IDS)} map IDs to detect current map...")
    for mid in ALL_MAP_IDS:
        proto = build_map_request(mid)
        pkt = struct.pack('<IH', len(proto), 71) + proto
        bot.send_raw(pkt)
        time.sleep(0.1)

    print("[*] Waiting 5s for server responses...")
    time.sleep(5)

    bot.close()
    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    # Parse
    packets = parse_pcap_recv(PCAP_LOC, port)
    print(f"[+] Captured {len(packets)} packets")

    # Find eMapDialogNpcListResponse (opcode 72)
    detected_map_id = None
    detected_npcs = []
    for opcode, body in packets:
        if opcode == 72 and len(body) > 5:
            mid, npcs = parse_npc_list_response(body)
            if mid and npcs:
                detected_map_id = mid
                detected_npcs = npcs
                break

    # Find player shops (opcode 133)
    player_shops = []
    seen_shop_ids = set()
    for opcode, body in packets:
        if opcode == 133 and len(body) > 10:
            shop = parse_player_shop(body)
            if shop["name"] and shop["id"] not in seen_shop_ids:
                seen_shop_ids.add(shop["id"])
                player_shops.append(shop)

    # ── Display Results ──
    if detected_map_id:
        map_name = MAP_NAMES.get(detected_map_id, f"Map_{detected_map_id}")
        print()
        print("╔" + "═"*60 + "╗")
        print(f"║  🗺️  DETECTED MAP: {map_name} (ID: {detected_map_id})")
        print("╚" + "═"*60 + "╝")

        # Show NPC list from server response
        print(f"\n  📍 NPCs trong map ({len(detected_npcs)}):")
        shops_list = []
        quest_list = []
        for npc in detected_npcs:
            cat = categorize_npc(npc['name'])
            if "SHOP" in cat: shops_list.append(npc)
            elif "QUEST" in cat: quest_list.append(npc)

        if quest_list:
            print(f"\n  📜 QUEST NPCs ({len(quest_list)}):")
            for npc in quest_list:
                flag = " ⭐" if "tẩu" in npc['name'].lower() else ""
                print(f"     {npc['name']:<30} ({npc['x']}, {npc['y']}){flag}")

        if shops_list:
            print(f"\n  🛒 SHOP NPCs ({len(shops_list)}):")
            for npc in shops_list:
                print(f"     {npc['name']:<30} ({npc['x']}, {npc['y']})")

        # Transport
        trans = [n for n in detected_npcs if categorize_npc(n['name']) == "🚗 TRANSPORT"]
        if trans:
            print(f"\n  🚗 TRANSPORT ({len(trans)}):")
            for npc in trans:
                print(f"     {npc['name']:<30} ({npc['x']}, {npc['y']})")

        # Other NPCs
        others = [n for n in detected_npcs
                  if categorize_npc(n['name']) == "👤 NPC"]
        print(f"\n  👤 OTHER NPCs ({len(others)}):")
        for npc in others:
            print(f"     {npc['name']:<30} ({npc['x']}, {npc['y']})")

    else:
        print("\n[-] Không detect được map! Nhân vật có thể đang ở map dã ngoại.")

    # ── Player Shops (sạp hàng) ──
    if player_shops:
        print(f"\n{'='*62}")
        print(f"  🏪 PLAYER SHOPS GẦN ĐÂY ({len(player_shops)} sạp):")
        print(f"{'='*62}")
        for i, s in enumerate(player_shops, 1):
            print(f"  {i:>3}. [{s['name']}]")
            print(f"       {s['desc']}")
            if s['items']:
                print(f"       Items: {s['items']}")

    # Summary
    print(f"\n{'='*62}")
    print(f"  📊 TỔNG KẾT:")
    if detected_map_id:
        print(f"  🗺️  Map         : {MAP_NAMES.get(detected_map_id, '?')} (ID: {detected_map_id})")
        print(f"  📍 NPC tổng     : {len(detected_npcs)}")
        print(f"  🛒 NPC Shop     : {len(shops_list)}")
        print(f"  📜 Quest NPC    : {len(quest_list)}")
    print(f"  🏪 Player Shop  : {len(player_shops)}")
    print(f"{'='*62}")


if __name__ == '__main__':
    run()
