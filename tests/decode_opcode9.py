"""
Decode opcode 9 (eStringData) - đây có thể là container cho entity data.
Dump raw hex để reverse engineer format.
"""
import sys, time, struct, subprocess
from pathlib import Path
from collections import Counter

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.stdout.reconfigure(encoding='utf-8')

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
PCAP_DEV  = '/data/local/tmp/decode9.pcap'
PCAP_LOC  = str(ROOT_DIR / 'data' / 'decode9.pcap')


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


def run():
    print("=" * 62)
    print("  DECODE OPCODE 9 (eStringData)")
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

    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 2000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(5)  # Just passively capture

    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    packets = parse_pcap_recv(PCAP_LOC, port)
    print(f"[+] {len(packets)} packets")

    # Group opcode 9 packets by size
    op9_by_size = Counter()
    op9_samples = {}  # size -> [bodies]
    for opcode, body in packets:
        if opcode != 9: continue
        sz = len(body)
        op9_by_size[sz] += 1
        if sz not in op9_samples:
            op9_samples[sz] = []
        if len(op9_samples[sz]) < 3:
            op9_samples[sz].append(body)

    print(f"\n  eStringData size distribution:")
    for sz, count in op9_by_size.most_common(15):
        print(f"    {sz:>4} bytes | x{count}")

    # Dump raw hex for each size
    print(f"\n  {'='*58}")
    print(f"  RAW HEX SAMPLES by size:")
    print(f"  {'='*58}")

    for sz in sorted(op9_samples.keys()):
        samples = op9_samples[sz]
        print(f"\n  ── Size {sz} bytes (x{op9_by_size[sz]}) ──")
        for idx, body in enumerate(samples[:2]):
            hex_str = body.hex()
            # Also try to print as mixed ASCII/hex
            ascii_str = ''
            for b in body:
                if 32 <= b < 127:
                    ascii_str += chr(b)
                else:
                    ascii_str += f'\\x{b:02x}'
            print(f"    [{idx}] hex: {hex_str[:100]}")
            print(f"    [{idx}] asc: {ascii_str[:100]}")

    # Try different parse strategies on opcode 9
    print(f"\n  {'='*58}")
    print(f"  PARSE ATTEMPTS:")
    print(f"  {'='*58}")

    for opcode, body in packets:
        if opcode != 9: continue
        if len(body) < 3: continue

        # Strategy 1: Plain protobuf
        # Strategy 2: first byte = type, rest = data
        # Strategy 3: raw binary with positions

        # Just look at first bytes pattern
        first3 = body[:3].hex()
        # Check if body starts with a protobuf field tag
        tag = body[0]
        field_num = tag >> 3
        wire_type = tag & 7

        if wire_type == 2 and field_num > 0 and field_num < 20:
            # Length-delimited field - likely protobuf
            try:
                ln = body[1]
                if ln < 128 and 2 + ln <= len(body):
                    inner = body[2:2+ln]
                    try:
                        text = inner.decode('utf-8')
                        if len(text) > 3 and text.isprintable():
                            print(f"  f{field_num} str[{ln}]: {text[:80]}")
                    except:
                        pass
            except:
                pass
        elif wire_type == 0 and field_num > 0 and field_num < 20:
            # Varint
            pass

    # Look for player names in ALL opcode 9 data concatenated
    print(f"\n  {'='*58}")
    print(f"  Searching for known player names in eStringData stream...")
    print(f"  {'='*58}")

    all_op9 = b''
    for opcode, body in packets:
        if opcode == 9:
            all_op9 += body

    # Search for known names from screenshot
    test_names = ['Daxton', 'VuiKhoeCoIch', 'BanhBeo', 'munPTL', 
                  'TVB', 'Phi Le', 'DLong', 'ThichPha', 'KimDai',
                  'dataure', 'Oxxxxxx', 'dt4w4']
    for name in test_names:
        # UTF-8 search
        if name.encode('utf-8') in all_op9:
            pos = all_op9.index(name.encode('utf-8'))
            context = all_op9[max(0,pos-10):pos+len(name)+20]
            hex_ctx = context.hex()
            print(f"  ✓ '{name}' found at offset {pos}!")
            print(f"    context: {hex_ctx}")
        else:
            print(f"  ✗ '{name}' not found")


if __name__ == '__main__':
    run()
