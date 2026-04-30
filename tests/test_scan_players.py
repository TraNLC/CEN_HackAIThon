"""
test_scan_players.py - Quét nhân vật người chơi + sạp hàng xung quanh
100% network protocol (opcode 9 = entity sync), không OCR.

Format opcode 9: type|entityID|data...
  Salesman: entityID = salesman.{playerID}.0
    type 33: stall info (tên + mô tả sạp)
    type 34: stall items/position

  Player: entityID = {playerID}
    type 1: di chuyển (x, y)
    type 2: hành động (x, y, hướng)

Chạy: python tests/test_scan_players.py
"""
import sys
import time
import struct
import subprocess
import re
from pathlib import Path
from collections import defaultdict

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.stdout.reconfigure(encoding='utf-8')

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
PCAP_DEV  = '/data/local/tmp/players.pcap'
PCAP_LOC  = str(ROOT_DIR / 'data' / 'players.pcap')


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
        opcode  = struct.unpack_from('<H', recv_buf, p + 4)[0]
        if pkt_len > 500000: break
        if p + 6 + pkt_len > len(recv_buf): break
        body = recv_buf[p + 6: p + 6 + pkt_len]
        results.append((opcode, body))
        p += 6 + pkt_len
    return results


SALESMAN_RE = re.compile(r'^salesman\.(\d+)\.\d+$')


def run():
    print()
    print("=" * 62)
    print("  VLTK1 - SCAN NEARBY PLAYERS + STALLS")
    print("  (opcode 9 entity sync, 100% protocol)")
    print("=" * 62)

    try:
        pid = int(subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'],
            timeout=5).decode().strip().split()[0])
    except Exception as e:
        print(f"[-] PID error: {e}"); return

    port = get_server_port(pid)
    print(f"[+] PID: {pid} | Port: {port}")

    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.5)

    print(f"[*] Capturing 15 seconds...")
    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 5000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)

    time.sleep(15)

    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    packets = parse_pcap_recv(PCAP_LOC, port)
    print(f"[+] {len(packets)} packets")

    # ── Parse opcode 9 (entity sync) ──
    players = defaultdict(lambda: {
        "x": 0, "y": 0, "updates": 0, "types": set()
    })

    # Salesman stalls: salesman.{pid}.0
    stalls = defaultdict(lambda: {
        "player_id": "", "x": 0, "y": 0, "raw": [],
        "updates": 0, "types": set()
    })

    for opcode, body in packets:
        if opcode != 9: continue
        if len(body) < 5: continue

        try:
            text = body.decode('utf-8', errors='replace')
        except: continue

        parts = text.split('|')
        if len(parts) < 2: continue

        try:
            etype = int(parts[0])
        except ValueError:
            continue

        entity_id = parts[1]

        # Check if salesman
        m = SALESMAN_RE.match(entity_id)
        if m:
            player_id = m.group(1)
            stall = stalls[entity_id]
            stall["player_id"] = player_id
            stall["types"].add(etype)
            stall["updates"] += 1
            if len(stall["raw"]) < 5:
                stall["raw"].append(text)
        else:
            player = players[entity_id]
            player["types"].add(etype)
            player["updates"] += 1

            # Type 1: Move → 1|id|x|y
            if etype == 1 and len(parts) >= 4:
                try:
                    player["x"] = int(parts[2])
                    player["y"] = int(parts[3])
                except: pass

            # Type 2: Action → 2|id|x|y|dir
            elif etype == 2 and len(parts) >= 4:
                try:
                    player["x"] = int(parts[2])
                    player["y"] = int(parts[3])
                except: pass

    # ── Display ──
    positioned = {pid: p for pid, p in players.items() if p["x"] > 0}
    no_pos = {pid: p for pid, p in players.items() if p["x"] == 0}

    print(f"\n╔{'═'*60}╗")
    print(f"║  👥 PLAYERS: {len(players)} | 🏪 STALLS: {len(stalls)}")
    print(f"║  📍 Players with position: {len(positioned)}")
    print(f"╚{'═'*60}╝")

    # ── Salesman Stalls ──
    if stalls:
        print(f"\n  🏪 STALLS ({len(stalls)}):")
        for sid, s in sorted(stalls.items(), key=lambda x: -x[1]["updates"]):
            types_str = ','.join(str(t) for t in sorted(s["types"]))
            print(f"    {sid} | [{types_str}]")
            for raw in s["raw"]:
                print(f"      → {raw[:100]}")

    # ── Players with position ──
    if positioned:
        print(f"\n  📍 PLAYERS ({len(positioned)}):")
        for pid, p in sorted(positioned.items(), key=lambda x: -x[1]["updates"]):
            types_str = ','.join(str(t) for t in sorted(p["types"]))
            print(f"    ID {pid:>8} | ({p['x']:>5}, {p['y']:>5}) | {p['updates']:>3} upd | [{types_str}]")

    # ── Stats only ──
    if no_pos:
        print(f"\n  📊 NEARBY ({len(no_pos)}):")
        for pid, p in sorted(no_pos.items(), key=lambda x: -x[1]["updates"]):
            types_str = ','.join(str(t) for t in sorted(p["types"]))
            print(f"    ID {pid:>8} | {p['updates']:>3} upd | [{types_str}]")

    print(f"\n{'─'*62}")
    print(f"  {len(players)} players + {len(stalls)} stalls in 15s")
    print(f"{'─'*62}")


if __name__ == '__main__':
    run()

