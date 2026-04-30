"""
test_dump_opcodes.py - Dump tất cả opcodes từ server để tìm ra
opcode nào chứa mapId / position.
"""
import sys
import time
import struct
import subprocess
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

# Opcode names from vltk1_protocol.py
GS_OPCODES = {
    0: "eUnidentified", 1: "ePlayerLoginRequest", 2: "ePlayerLoginResponse",
    3: "eEnterWorldSuccess", 4: "eCharacterDetailResponse", 5: "eSkillResponse",
    6: "eItemResponse", 7: "eEnterMap", 8: "eEnterGameServer", 9: "eStringData",
    10: "eDelivered", 11: "eCharacterRequest", 12: "eCharacterResponse",
    13: "eJumToMap", 16: "eSyncPlayerItem", 17: "eSyncPlayerSkill",
    18: "eSyncPlayerData", 19: "eSyncPlayerFriend", 20: "eSyncPlayerMove",
    23: "eSyncDamage", 33: "eNpcDialogue", 51: "eOpenShop",
    54: "eAddMapObject", 69: "ePing", 70: "ePong",
    71: "eMapDialogNpcListRequest", 72: "eMapDialogNpcListResponse",
    133: "eSyncNpcMove", 251: "eHeartbeat",
}


def read_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80):
            break
    return result, pos


def dump_protobuf(body: bytes, max_fields=20):
    """Simple protobuf field dump."""
    fields = []
    pos = 0
    count = 0
    while pos < len(body) and count < max_fields:
        try:
            tag, pos = read_varint(body, pos)
        except:
            break
        field, wtype = tag >> 3, tag & 0x7
        if wtype == 0:  # varint
            val, pos = read_varint(body, pos)
            fields.append(f"  f{field}(varint)={val}")
        elif wtype == 2:  # length-delimited
            ln, pos = read_varint(body, pos)
            raw = body[pos:pos+ln]; pos += ln
            try:
                text = raw.decode('utf-8')
                fields.append(f"  f{field}(str)=\"{text[:60]}\"")
            except:
                fields.append(f"  f{field}(bytes[{ln}])={raw[:30].hex()}")
        elif wtype == 5:  # 32-bit
            if pos + 4 <= len(body):
                val = struct.unpack_from('<I', body, pos)[0]
                fields.append(f"  f{field}(fixed32)={val}")
            pos += 4
        elif wtype == 1:  # 64-bit
            if pos + 8 <= len(body):
                val = struct.unpack_from('<Q', body, pos)[0]
                fields.append(f"  f{field}(fixed64)={val}")
            pos += 8
        else:
            break
        count += 1
    return fields


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


def run():
    print("\n" + "="*62)
    print("  VLTK1 - OPCODE DUMPER")
    print("="*62)

    try:
        pid = int(subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'],
            timeout=5).decode().strip().split()[0])
    except Exception as e:
        print(f"[-] PID: {e}"); return

    port = get_server_port(pid)
    print(f"[+] PID: {pid} | Port: {port}")

    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.5)

    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 1000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(2)

    bot = VLTK1Bot()
    if not bot.connect():
        tcpdump.terminate(); return

    # Send eCharacterRequest AND eSyncPlayerData request
    print("[*] Sending eCharacterRequest (11)...")
    bot.send_gs('eCharacterRequest')
    time.sleep(1)
    
    # Also request character detail
    print("[*] Sending eCharacterDetailResponse request...")
    # Try opcode 4 request (some servers use 3/4 for char info)
    pkt = struct.pack('<IH', 0, 3)  # eEnterWorldSuccess as request
    bot.send_raw(pkt)
    time.sleep(1)
    
    # Try eSyncPlayerData
    pkt = struct.pack('<IH', 0, 18)  # eSyncPlayerData
    bot.send_raw(pkt)

    print("[*] Waiting 5s...")
    time.sleep(5)

    bot.close()
    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    packets = parse_pcap_recv(PCAP_LOC, port)
    print(f"\n[+] Total recv packets: {len(packets)}")

    # Count opcodes
    counter = Counter()
    for opcode, body in packets:
        counter[opcode] += 1

    print(f"\n{'─'*62}")
    print(f"  {'Opcode':>6}  {'Name':<35} {'Count':>5}  {'AvgSize':>8}")
    print(f"{'─'*62}")

    for opcode, count in counter.most_common(30):
        name = GS_OPCODES.get(opcode, f"Unknown_{opcode}")
        sizes = [len(b) for o, b in packets if o == opcode]
        avg = sum(sizes) / len(sizes) if sizes else 0
        print(f"  {opcode:>6}  {name:<35} {count:>5}  {avg:>8.0f}")

    # Dump interesting opcodes (not opcode 9 which is just string data)
    print(f"\n{'='*62}")
    print("  DETAILED DUMP (non-StringData packets):")
    print(f"{'='*62}")

    for opcode, body in packets:
        if opcode == 9: continue  # skip string data spam
        if opcode == 70: continue  # skip pong
        name = GS_OPCODES.get(opcode, f"Unknown_{opcode}")
        print(f"\n  Opcode {opcode} ({name}) | {len(body)} bytes")
        if len(body) > 0:
            fields = dump_protobuf(body)
            for f in fields[:10]:
                print(f"    {f}")
            if len(body) <= 50:
                print(f"    RAW: {body.hex()}")


if __name__ == '__main__':
    run()
