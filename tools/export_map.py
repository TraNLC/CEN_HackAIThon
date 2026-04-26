"""
export_map.py - VLTK1 Map NPC Exporter v3
Uses tcpdump to capture server response + lightweight protobuf parser.
No external dependencies required.

Usage:
    python tools/export_map.py          (map_id=1 default)
    python tools/export_map.py 78       (force map_id=78)
"""
import sys
import time
import json
import struct
import subprocess
from pathlib import Path

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))
sys.stdout.reconfigure(encoding='utf-8')

from features.bot.game_bot import VLTK1Bot

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
PCAP_DEV  = '/data/local/tmp/npc_export.pcap'
PCAP_LOC  = str(ROOT_DIR / 'data' / 'npc_export.pcap')
OUTPUT_DIR = ROOT_DIR / 'data' / 'output' / 'maps'

MAP_NAMES = {
    1:   "Phượng Tường",
    11:  "Thành Đô",
    37:  "Biện Kinh",
    53:  "Ba Lăng Huyện",
    78:  "Tương Dương",
    80:  "Dương Châu",
    99:  "Vĩnh Lạc trấn",
    100: "Chu Tiên trấn",
    121: "Long Môn trấn",
    153: "Thạch Cổ trấn",
    162: "Đại Lý phủ",
    174: "Long Tuyền thôn",
    176: "Lâm An",
}


# ── Lightweight protobuf parser ───────────────────────────────────────────────

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
    """Parse MapDialogNpc {1:name(str), 2:mapX(int), 3:mapY(int)}."""
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
        else:
            break
    return npc


def parse_npc_list_response(body: bytes):
    """Parse eMapDialogNpcListResponse {1:mapId, 2:repeated MapDialogNpc}."""
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
                if npc["name"]:
                    npcs.append(npc)
        else:
            break
    return map_id, npcs


# ── PCAP parsing ──────────────────────────────────────────────────────────────

def parse_pcap_for_opcode(filepath: str, target_opcode: int):
    """Extract packet body for a specific opcode from a pcap file."""
    try:
        with open(filepath, 'rb') as f:
            data = f.read()
    except FileNotFoundError:
        return None

    if len(data) < 24:
        return None

    magic = struct.unpack_from('<I', data, 0)[0]
    endian = '<' if magic == 0xa1b2c3d4 else '>'
    link_type = struct.unpack_from(f'{endian}I', data, 20)[0]

    offset = 24
    while offset + 16 <= len(data):
        _, _, incl_len, _ = struct.unpack_from(f'{endian}IIII', data, offset)
        offset += 16
        if offset + incl_len > len(data):
            break
        pkt = data[offset:offset + incl_len]
        offset += incl_len

        # Strip link layer
        if link_type == 113:    # LINUX_SLL
            ip_data = pkt[16:]
        elif link_type == 1:    # Ethernet
            ip_data = pkt[14:]
        else:
            continue

        if len(ip_data) < 20 or ip_data[9] != 6:  # must be TCP
            continue

        ihl = (ip_data[0] & 0xF) * 4
        tcp = ip_data[ihl:]
        if len(tcp) < 20:
            continue

        tcp_hlen = ((tcp[12] >> 4) & 0xF) * 4
        payload = tcp[tcp_hlen:]

        # Scan payload for our target opcode
        p = 0
        while p + 6 <= len(payload):
            pkt_len = struct.unpack_from('<I', payload, p)[0]
            opcode  = struct.unpack_from('<H', payload, p + 4)[0]
            if pkt_len > 100000:
                break
            if opcode == target_opcode:
                body = payload[p + 6: p + 6 + pkt_len]
                return body
            p += 6 + pkt_len

    return None


def get_server_port(pid: int) -> int:
    """Get game server port from /proc/net/tcp."""
    try:
        out = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'cat /proc/{pid}/net/tcp'],
            timeout=5
        ).decode('utf-8', errors='ignore')
        for line in out.splitlines()[1:]:
            parts = line.strip().split()
            if len(parts) >= 4 and parts[3] == '01':
                return int(parts[2].split(':')[1], 16)
    except Exception:
        pass
    return 45677


# ── Main ─────────────────────────────────────────────────────────────────────

def run(map_id=1):
    map_name = MAP_NAMES.get(map_id, f"Map_{map_id}")

    print()
    print("=" * 58)
    print("  VLTK1 Map NPC Exporter v3 (tcpdump)")
    print("=" * 58)
    print(f"  Target: Map {map_id} - {map_name}")
    print()

    # ── Get PID & port ──
    try:
        pid_str = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'], timeout=5
        ).decode().strip()
        pid = int(pid_str.split()[0])
        print(f"[+] PID: {pid}")
    except Exception as e:
        print(f"[-] Cannot get PID: {e}")
        return

    port = get_server_port(pid)
    print(f"[+] Server port: {port}")

    # ── Kill old tcpdump ──
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.5)

    # ── Start tcpdump ──
    print(f"[*] Starting tcpdump (port {port})...")
    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 500"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
    )
    time.sleep(2)

    # ── Send eMapDialogNpcListRequest via VLTK1Bot ──
    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Cannot connect to game!")
        tcpdump.terminate()
        return

    print(f"[*] Sending eMapDialogNpcListRequest (mapId={map_id})...")
    ok = bot.send_gs('eMapDialogNpcListRequest', mapId=map_id)
    print(f"[+] Sent: {ok}")

    print("[*] Waiting 5s for server response...")
    time.sleep(5)

    bot.close()
    tcpdump.terminate()

    # ── Stop tcpdump & pull pcap ──
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(1)

    print(f"[*] Pulling pcap...")
    r = subprocess.run(
        [ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
        capture_output=True, text=True
    )
    print(f"    {r.stdout.strip() or r.stderr.strip()}")

    # ── Parse ──
    print("[*] Parsing opcode 72 (eMapDialogNpcListResponse)...")
    body = parse_pcap_for_opcode(PCAP_LOC, 72)

    if body is None:
        print("[-] opcode 72 not found in capture!")
        print("[!] Make sure you are standing IN this map.")
        return

    actual_map_id, npcs = parse_npc_list_response(body)
    actual_id   = actual_map_id or map_id
    actual_name = MAP_NAMES.get(actual_id, f"Map_{actual_id}")

    print(f"\n[+] Map ID : {actual_id} ({actual_name})")
    print(f"[+] NPCs   : {len(npcs)}\n")

    for npc in npcs:
        flag = " <-- DA TAU!" if "tẩu" in npc["name"].lower() else ""
        print(f"  {npc['name']:<35} ({npc['x']}, {npc['y']}){flag}")

    # ── Save ──
    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    out_file = OUTPUT_DIR / f"map_{actual_id}.json"
    result = {
        "map_id":    actual_id,
        "map_name":  actual_name,
        "npc_count": len(npcs),
        "npcs":      npcs,
    }
    with open(out_file, "w", encoding="utf-8") as f:
        json.dump(result, f, ensure_ascii=False, indent=4)

    print(f"\n[+] Saved: {out_file}")
    print("[+] Run: python tests/test_datau_coords.py")


if __name__ == "__main__":
    mid = int(sys.argv[1]) if len(sys.argv) == 2 and sys.argv[1].isdigit() else 1
    run(mid)
