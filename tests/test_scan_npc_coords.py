"""
test_scan_npc_coords.py - Auto-scan NPC coordinates via eMapDialogNpcListRequest

HOW IT WORKS:
  1. Connect to game via Frida
  2. Listen for eEnterMap (opcode 7) to detect current mapId
  3. Send eMapDialogNpcListRequest to Server -> Server responds with full NPC list of that map
  4. Parse eMapDialogNpcListResponse (opcode 72): each NPC has name, mapX, mapY
  5. Filter "Da Tau" and save to npc_coords.json

RUN:
  python tests/test_scan_npc_coords.py

Then CHANGE MAP in game and run again to build the full DB.
"""
import sys
import time
import json
import struct
from pathlib import Path

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))
sys.stdout.reconfigure(encoding='utf-8')

from features.bot.game_bot import VLTK1Bot

NPC_DB_FILE = ROOT_DIR / 'data' / 'npc_coords.json'

# ── MapId -> Tên thành thị (cần bổ sung dần khi đi từng map) ──────────────────
# Format: mapId (int) -> tên thành thị tiếng Việt
# Sẽ tự cập nhật khi bot phát hiện EnterMap mới
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
}

# ── Protobuf parser nhẹ cho MapDialogNpcListResponse ─────────────────────────
def parse_varint(data, pos):
    """Parse protobuf varint."""
    result = 0
    shift = 0
    while pos < len(data):
        b = data[pos]
        pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80):
            break
    return result, pos

def parse_npc_list_response(raw_body: bytes) -> dict:
    """
    Parse eMapDialogNpcListResponse body.
    Fields:
      field 1 (varint) = mapId
      field 2 (len-delimited, repeated) = MapDialogNpc {
          field 1 (string) = name
          field 2 (varint) = mapX
          field 3 (varint) = mapY
      }
    """
    result = {"mapId": None, "npcs": []}
    pos = 0
    data = raw_body

    while pos < len(data):
        if pos >= len(data):
            break
        tag_varint, pos = parse_varint(data, pos)
        field_num = tag_varint >> 3
        wire_type = tag_varint & 0x7

        if wire_type == 0:  # varint
            val, pos = parse_varint(data, pos)
            if field_num == 1:
                result["mapId"] = val
        elif wire_type == 2:  # length-delimited
            length, pos = parse_varint(data, pos)
            raw = data[pos:pos+length]
            pos += length
            if field_num == 2:
                # Parse inner MapDialogNpc
                npc = _parse_map_dialog_npc(raw)
                if npc:
                    result["npcs"].append(npc)
        else:
            break  # Unknown wire type, stop parsing

    return result

def _parse_map_dialog_npc(raw: bytes) -> dict:
    """Parse a single MapDialogNpc message."""
    npc = {"name": "", "mapX": 0, "mapY": 0}
    pos = 0

    while pos < len(raw):
        if pos >= len(raw):
            break
        tag_varint, pos = parse_varint(raw, pos)
        field_num = tag_varint >> 3
        wire_type = tag_varint & 0x7

        if wire_type == 0:  # varint
            val, pos = parse_varint(raw, pos)
            if field_num == 2:
                npc["mapX"] = val
            elif field_num == 3:
                npc["mapY"] = val
        elif wire_type == 2:  # string
            length, pos = parse_varint(raw, pos)
            val = raw[pos:pos+length].decode('utf-8', errors='replace')
            pos += length
            if field_num == 1:
                npc["name"] = val
        else:
            break

    return npc if npc["name"] else None

# ── Load / Save NPC DB ─────────────────────────────────────────────────────────
def load_db() -> dict:
    if NPC_DB_FILE.exists():
        with open(NPC_DB_FILE, 'r', encoding='utf-8') as f:
            return json.load(f)
    return {}

def save_db(db: dict):
    NPC_DB_FILE.parent.mkdir(parents=True, exist_ok=True)
    with open(NPC_DB_FILE, 'w', encoding='utf-8') as f:
        json.dump(db, f, ensure_ascii=False, indent=2)
    print(f"\n[+] Saved NPC DB to {NPC_DB_FILE}")

# ── Main ───────────────────────────────────────────────────────────────────────
def main():
    db = load_db()
    
    current_map_id = None
    current_map_name = "Unknown"
    npc_response_received = False
    all_npcs_found = []

    bot = VLTK1Bot()

    def on_enter_map(payload):
        nonlocal current_map_id, current_map_name, npc_response_received, all_npcs_found
        raw = bytes.fromhex(payload.get('raw', ''))
        if len(raw) >= 6:
            body = raw[6:]  # Skip 4-byte len + 2-byte opcode
            # Parse EnterMap: field 1 = mapId
            if body:
                val, _ = parse_varint(body[1:], 0)  # skip field tag byte
                current_map_id = val
                current_map_name = MAP_NAMES.get(current_map_id, f"Map_{current_map_id}")
                print(f"\n[MAP] Entered Map ID={current_map_id} ({current_map_name})")

                # Auto-request NPC list for this map
                npc_response_received = False
                all_npcs_found = []
                print(f"[Bot] Requesting NPC list for map {current_map_id}...")
                bot.send_gs('eMapDialogNpcListRequest', mapId=current_map_id)

    def on_npc_list_response(payload):
        nonlocal npc_response_received, all_npcs_found, current_map_name
        npc_response_received = True
        raw = bytes.fromhex(payload.get('raw', ''))
        if len(raw) < 6:
            return
        body = raw[6:]  # Skip header
        parsed = parse_npc_list_response(body)

        map_id = parsed.get("mapId", current_map_id)
        map_name = MAP_NAMES.get(map_id, f"Map_{map_id}")
        npcs = parsed.get("npcs", [])
        all_npcs_found = npcs

        print(f"\n[NPC LIST] Map: {map_name} (ID={map_id}) -> {len(npcs)} NPCs found")

        da_tau_found = False
        for npc in npcs:
            name = npc["name"]
            x, y = npc["mapX"], npc["mapY"]
            print(f"  - {name:30s} | X={x:5d}, Y={y:5d}")
            if "Dã Tẩu" in name or "Da Tau" in name.lower():
                da_tau_found = True
                print(f"\n  [***] DA TAU FOUND at Map={map_name}, Game Coords: ({x}, {y})")
                if map_name not in db:
                    db[map_name] = {}
                db[map_name]["Da Tau"] = {"game_x": x, "game_y": y, "map_id": map_id}
                save_db(db)

        if not da_tau_found:
            print(f"\n  [-] 'Da Tau' not in NPC list for {map_name}")

        print(f"\n[DB Current State]")
        for m, npcs_in_map in db.items():
            for n, coords in npcs_in_map.items():
                print(f"  {m:20s} -> {n}: Game({coords['game_x']}, {coords['game_y']})")

    # Register packet handlers
    bot.on_recv('eEnterMap', on_enter_map)
    bot.on_recv('eMapDialogNpcListResponse', on_npc_list_response)

    if not bot.connect():
        print("[-] Failed to connect!")
        return

    # Check if we need to also handle raw recv (some bots buffer differently)
    print("\n[*] Bot connected! Listening for map/NPC packets...")
    print("[*] Change map in game to auto-scan NPCs, or press ENTER to manually request NPC list for current map")
    print("[*] Press Ctrl+C to stop.\n")

    # Manually trigger NPC list request right away for current map
    # (If already in a map, won't get EnterMap event)
    print("[Bot] Sending eMapDialogNpcListRequest for map ID 1 (Tuong Duong - default)...")
    bot.send_gs('eMapDialogNpcListRequest', mapId=1)
    
    try:
        timeout = 60 * 10  # 10 minutes max
        t = 0
        while t < timeout:
            pkts = bot.poll_recv()
            if isinstance(pkts, list):
                for pkt in pkts:
                    name = pkt.get('name', '')
                    if name == 'eEnterMap':
                        on_enter_map(pkt)
                    elif name == 'eMapDialogNpcListResponse':
                        on_npc_list_response(pkt)
            time.sleep(0.5)
            t += 0.5

    except KeyboardInterrupt:
        print("\n[*] Stopped by user.")

    bot.close()
    print(f"\n[*] Final NPC DB saved at: {NPC_DB_FILE}")

if __name__ == '__main__':
    main()
