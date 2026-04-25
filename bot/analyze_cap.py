"""
analyze_cap.py - Parse cap.pcap, find TCP packets sent to game server,
extract and display raw bytes around the mount/dismount action.

Usage:
    python bot\analyze_cap.py
"""
import struct, socket

PCAP_PATH = 'data/cap.pcap'

# ── pcap parser (no scapy needed) ─────────────────────────────────────────
def parse_pcap(path):
    """Yield (ts_sec, ts_usec, raw_data) for each packet."""
    with open(path, 'rb') as f:
        magic, ver_maj, ver_min, tz, sig, snaplen, link = struct.unpack('<IHHiIII', f.read(24))
        assert magic in (0xA1B2C3D4, 0xD4C3B2A1), "Not a valid pcap"
        big = (magic == 0xD4C3B2A1)
        endian = '>' if big else '<'
        while True:
            hdr = f.read(16)
            if len(hdr) < 16: break
            ts_sec, ts_usec, incl_len, orig_len = struct.unpack(endian+'IIII', hdr)
            data = f.read(incl_len)
            yield ts_sec, ts_usec, data

# ── Ethernet → IP → TCP extractor ─────────────────────────────────────────
def extract_tcp(raw):
    """Return (src_ip, dst_ip, src_port, dst_port, tcp_payload) or None."""
    if len(raw) < 14: return None
    eth_type = struct.unpack_from('>H', raw, 12)[0]

    # Handle Linux cooked (SLL) if link type=113
    offset = 14
    if eth_type == 0x0800:  # IPv4
        pass
    elif eth_type == 0x0000:  # SLL header (16 bytes)
        if len(raw) < 16: return None
        eth_type = struct.unpack_from('>H', raw, 14)[0]
        offset = 16
        if eth_type != 0x0800: return None
    else:
        return None

    if len(raw) < offset + 20: return None
    ip_hdr = raw[offset:]
    ihl = (ip_hdr[0] & 0x0F) * 4
    proto = ip_hdr[9]
    if proto != 6: return None  # TCP only
    src_ip = socket.inet_ntoa(ip_hdr[12:16])
    dst_ip = socket.inet_ntoa(ip_hdr[16:20])

    tcp_hdr = ip_hdr[ihl:]
    if len(tcp_hdr) < 20: return None
    src_port, dst_port = struct.unpack_from('>HH', tcp_hdr)
    data_offset = ((tcp_hdr[12] >> 4) & 0xF) * 4
    payload = tcp_hdr[data_offset:]
    return src_ip, dst_ip, src_port, dst_port, payload

# ── Detect game server IP ──────────────────────────────────────────────────
# The game server will be a remote host receiving data. We collect candidate IPs.
print(f"[*] Parsing {PCAP_PATH} ...")
server_candidates = {}
all_tcp = []

try:
    packets = list(parse_pcap(PCAP_PATH))
except Exception as e:
    # Try SLL (Linux cooked capture) link type
    print(f"[!] Parse error: {e}")
    packets = []

for ts_sec, ts_usec, raw in packets:
    result = extract_tcp(raw)
    if result is None:
        # Try SLL: 16-byte header
        sll = raw
        if len(sll) >= 16:
            proto = struct.unpack_from('>H', sll, 14)[0]
            if proto == 0x0800:
                result = extract_tcp(b'\x00'*12 + sll[12:])  # fake eth header trick
    if result is None: continue
    src_ip, dst_ip, src_port, dst_port, payload = result
    if payload:
        key = (src_ip, dst_ip, src_port, dst_port)
        server_candidates[dst_ip] = server_candidates.get(dst_ip, 0) + len(payload)
        all_tcp.append((ts_sec, ts_usec, src_ip, dst_ip, src_port, dst_port, payload))

print(f"[*] Total TCP frames with payload: {len(all_tcp)}")
print(f"[*] Destination IPs (likely server):")
for ip, size in sorted(server_candidates.items(), key=lambda x: -x[1]):
    print(f"    {ip}  ({size} bytes total)")

# Ask user or auto-pick the biggest
if not server_candidates:
    print("[!] No TCP payloads found. Check pcap file.")
    exit(1)

server_ip = max(server_candidates, key=server_candidates.get)
print(f"\n[*] Assuming game server IP = {server_ip}")

# ── Print C→S packets to game server ──────────────────────────────────────
print(f"\n{'='*60}")
print(f"Client → Server packets (dst={server_ip})")
print(f"{'='*60}")

shown = 0
for ts_sec, ts_usec, src_ip, dst_ip, src_port, dst_port, payload in all_tcp:
    if dst_ip != server_ip: continue
    hex_str = ' '.join(f'{b:02X}' for b in payload[:64])
    ascii_str = ''.join(chr(b) if 32 <= b < 127 else '.' for b in payload[:64])
    print(f"\n  [{ts_sec}.{ts_usec:06d}] {src_ip}:{src_port} → {dst_ip}:{dst_port}  len={len(payload)}")
    print(f"  HEX : {hex_str}")
    print(f"  ASCII: {ascii_str}")
    shown += 1
    if shown > 50:
        print(f"\n  ... (truncated, {len(all_tcp)} total frames)")
        break

print(f"\n[*] Tip: Look for packet with '3A 00' or '58 00' = opcode 58 (eSetRiding)")
print(f"[*] Mount payload should end with '08 01', dismount with '08 00'")
