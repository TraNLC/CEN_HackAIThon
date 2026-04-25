"""
analyze_capture.py — Quick analysis of captured packets
"""
import json
from pathlib import Path
from collections import Counter, defaultdict

ROOT = Path(__file__).parent.parent
CAPTURE_DIR = ROOT / "captures"

# Find the latest capture file
jsonl_files = sorted(CAPTURE_DIR.glob("il2cpp_capture_*.jsonl"), key=lambda f: f.stat().st_mtime)
if not jsonl_files:
    print("No capture files found!")
    exit()

latest = jsonl_files[-1]
print(f"Analyzing: {latest.name}")
print(f"File size: {latest.stat().st_size / 1024:.1f} KB")
print("=" * 70)

# Parse all packets
packets = []
with open(latest, 'r', encoding='utf-8') as f:
    for line in f:
        try:
            packets.append(json.loads(line.strip()))
        except:
            pass

print(f"Total messages: {len(packets)}")

# Count by type
type_counts = Counter(p.get('type') for p in packets)
print(f"\nMessage types:")
for t, c in type_counts.most_common():
    print(f"  {t}: {c}")

# Analyze CONNECT events
connects = [p for p in packets if p.get('type') == 'CONNECT']
if connects:
    print(f"\n{'='*70}")
    print("CONNECTIONS (Game Server IPs):")
    for c in connects:
        print(f"  -> {c.get('ip')}:{c.get('port')} (fd={c.get('fd')})")

# Analyze SEND packets
sends = [p for p in packets if p.get('type') in ('SEND', 'SENDTO')]
recvs = [p for p in packets if p.get('type') in ('RECV', 'RECVFROM')]

print(f"\n{'='*70}")
print(f"SEND packets: {len(sends)}")
print(f"RECV packets: {len(recvs)}")

# Group by fd (file descriptor = connection)
send_fds = Counter(p.get('fd') for p in sends)
recv_fds = Counter(p.get('fd') for p in recvs)

print(f"\nSEND by connection (fd):")
for fd, cnt in send_fds.most_common():
    sizes = [p.get('size', 0) for p in sends if p.get('fd') == fd]
    print(f"  fd={fd}: {cnt} packets, total {sum(sizes)} bytes, avg {sum(sizes)//max(cnt,1)} bytes")

print(f"\nRECV by connection (fd):")
for fd, cnt in recv_fds.most_common():
    sizes = [p.get('size', 0) for p in recvs if p.get('fd') == fd]
    print(f"  fd={fd}: {cnt} packets, total {sum(sizes)} bytes, avg {sum(sizes)//max(cnt,1)} bytes")

# Analyze packet headers (first 4-8 bytes patterns)
print(f"\n{'='*70}")
print("PACKET HEADER ANALYSIS:")

def get_header(hex_str, n=8):
    """Get first N bytes as header"""
    parts = hex_str.split(' ')
    return ' '.join(parts[:n]) if len(parts) >= n else hex_str

# Find the main game connection (most packets)
main_send_fd = send_fds.most_common(1)[0][0] if send_fds else None
main_recv_fd = recv_fds.most_common(1)[0][0] if recv_fds else None

if main_recv_fd:
    print(f"\nMain RECV connection fd={main_recv_fd}:")
    main_recvs = [p for p in recvs if p.get('fd') == main_recv_fd]
    
    # Analyze header patterns
    headers = Counter()
    for p in main_recvs:
        h = p.get('hex', '')
        if h:
            header = get_header(h, 4)
            headers[header] += 1
    
    print(f"  Unique 4-byte headers: {len(headers)}")
    print(f"  Top headers:")
    for h, c in headers.most_common(20):
        print(f"    [{h}] x{c}")

    # Show first 10 RECV packets for inspection
    print(f"\n  First 10 RECV packets:")
    for i, p in enumerate(main_recvs[:10]):
        print(f"    #{i+1} size={p.get('size')} hex={p.get('hex','')[:80]}...")

if main_send_fd:
    print(f"\nMain SEND connection fd={main_send_fd}:")
    main_sends = [p for p in sends if p.get('fd') == main_send_fd]
    
    # Show size distribution
    sizes = Counter(p.get('size') for p in main_sends)
    print(f"  Size distribution:")
    for s, c in sorted(sizes.items()):
        print(f"    size={s}: x{c}")
    
    # Show first 10 SEND packets
    print(f"\n  First 10 SEND packets:")
    for i, p in enumerate(main_sends[:10]):
        print(f"    #{i+1} size={p.get('size')} hex={p.get('hex','')[:80]}...")

# Try to identify protocol
print(f"\n{'='*70}")
print("PROTOCOL IDENTIFICATION:")

if main_recvs:
    first_hex = main_recvs[0].get('hex', '')
    first_bytes = first_hex.split(' ')[:4]
    
    # Check common patterns
    if first_bytes and first_bytes[0:2] == ['6e', '79']:
        print("  Header starts with 0x6E79 ('ny') - possible custom protocol")
    
    # Check if protobuf-like (varint encoding)
    if first_bytes and int(first_bytes[0], 16) < 0x20:
        print("  First byte is small - could be protobuf field tag")
    
    # Check for length-prefixed protocol
    print(f"  First 4 bytes of most common recv: {' '.join(first_bytes)}")
    if len(first_bytes) >= 4:
        # Try big-endian length
        be_len = int(''.join(first_bytes[:4]), 16)
        le_len = int(''.join(reversed(first_bytes[:4])), 16)
        print(f"    As BE uint32: {be_len}")
        print(f"    As LE uint32: {le_len}")

print(f"\n{'='*70}")
print("DONE! Files saved in: captures/")
