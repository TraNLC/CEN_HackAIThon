"""
il2cpp_dump.py — Parse global-metadata.dat to extract method/class names
Focus on finding network-related functions for packet hooking
"""

import struct
import sys
from pathlib import Path

def read_cstr(data, offset):
    """Read null-terminated string from data"""
    end = data.index(b'\x00', offset)
    return data[offset:end].decode('utf-8', errors='replace')

def parse_metadata(metadata_path):
    """Parse global-metadata.dat and extract string literals + method names"""
    data = Path(metadata_path).read_bytes()
    
    # Check magic
    magic = struct.unpack_from('<I', data, 0)[0]
    if magic != 0xFAB11BAF:
        print(f"[!] Invalid magic: {hex(magic)}, expected 0xFAB11BAF")
        return None
    
    version = struct.unpack_from('<i', data, 4)[0]
    print(f"[*] Metadata version: {version}")
    
    # Header offsets (version >= 24)
    # stringLiteralOffset, stringLiteralSize
    str_lit_offset = struct.unpack_from('<i', data, 8)[0]
    str_lit_size   = struct.unpack_from('<i', data, 12)[0]
    # stringLiteralDataOffset, stringLiteralDataSize
    str_lit_data_offset = struct.unpack_from('<i', data, 16)[0]
    str_lit_data_size   = struct.unpack_from('<i', data, 20)[0]
    # stringOffset, stringSize (for identifiers like class/method names)
    str_offset = struct.unpack_from('<i', data, 24)[0]
    str_size   = struct.unpack_from('<i', data, 28)[0]
    
    print(f"[*] String literals: offset={str_lit_offset}, size={str_lit_size}")
    print(f"[*] String literal data: offset={str_lit_data_offset}, size={str_lit_data_size}")
    print(f"[*] Identifier strings: offset={str_offset}, size={str_size}")
    
    # Extract all identifier strings (class names, method names, etc.)
    identifiers = []
    pos = str_offset
    end = str_offset + str_size
    while pos < end:
        try:
            s = read_cstr(data, pos)
            if s:
                identifiers.append((pos - str_offset, s))
            pos += len(s.encode('utf-8', errors='replace')) + 1
        except (ValueError, IndexError):
            break
    
    print(f"[*] Total identifier strings: {len(identifiers)}")
    
    # Keywords related to networking
    net_keywords = [
        'socket', 'send', 'recv', 'packet', 'connect', 'tcp', 'udp',
        'network', 'netclient', 'netmanager', 'message', 'protocol',
        'serialize', 'deserialize', 'dispatch', 'handler', 'opcode',
        'login', 'auth', 'session', 'encrypt', 'decrypt', 'cipher',
        'kcp', 'websocket', 'http', 'request', 'response',
        'onreceive', 'onsend', 'onconnect', 'ondisconnect',
        'buffer', 'stream', 'write', 'read', 'byte', 'encode', 'decode',
        'msgid', 'cmdid', 'proto', 'protobuf', 'flatbuf', 'msgpack',
        'gameserver', 'gateserver', 'loginserver',
    ]
    
    # Search for network-related identifiers
    network_hits = []
    for offset, s in identifiers:
        lower = s.lower()
        for kw in net_keywords:
            if kw in lower and len(s) > 2:
                network_hits.append((offset, s, kw))
                break
    
    print(f"\n{'='*80}")
    print(f"  NETWORK-RELATED IDENTIFIERS ({len(network_hits)} found)")
    print(f"{'='*80}\n")
    
    # Group by keyword
    from collections import defaultdict
    groups = defaultdict(list)
    for offset, name, kw in network_hits:
        groups[kw].append(name)
    
    for kw in sorted(groups.keys()):
        names = sorted(set(groups[kw]))
        print(f"\n--- [{kw.upper()}] ({len(names)} items) ---")
        for n in names[:50]:  # limit output
            print(f"  {n}")
    
    # Also extract string literals (in-code strings) 
    print(f"\n{'='*80}")
    print(f"  SEARCHING STRING LITERALS FOR NETWORK CLUES")
    print(f"{'='*80}\n")
    
    # Parse string literal entries
    entry_size = 8  # length + dataIndex (2 x int32)
    num_literals = str_lit_size // entry_size
    
    net_lit_keywords = ['socket', 'connect', 'send', 'recv', 'packet', 'tcp', 'login',
                        'server', 'port', 'kcp', 'encrypt', 'decrypt', 'proto', 'network',
                        'ws://', 'wss://', 'http']
    
    net_literals = []
    for i in range(num_literals):
        base = str_lit_offset + i * entry_size
        length = struct.unpack_from('<I', data, base)[0]
        data_idx = struct.unpack_from('<I', data, base + 4)[0]
        
        if length > 0 and length < 1000:
            try:
                lit = data[str_lit_data_offset + data_idx:str_lit_data_offset + data_idx + length]
                text = lit.decode('utf-8', errors='replace')
                lower = text.lower()
                for kw in net_lit_keywords:
                    if kw in lower:
                        net_literals.append(text)
                        break
            except:
                pass
    
    if net_literals:
        print(f"Found {len(net_literals)} network-related string literals:")
        for lit in sorted(set(net_literals))[:100]:
            print(f"  \"{lit}\"")
    else:
        print("No network string literals found.")
    
    return {
        'version': version,
        'identifiers': identifiers,
        'network_hits': network_hits,
        'net_literals': net_literals,
    }

if __name__ == '__main__':
    meta_path = sys.argv[1] if len(sys.argv) > 1 else \
        str(Path(__file__).parent.parent / 'data' / 'apk_extracted' / 'assets' / 'bin' / 'Data' / 'Managed' / 'Metadata' / 'global-metadata.dat')
    
    print(f"[*] Parsing: {meta_path}")
    result = parse_metadata(meta_path)
    
    if result:
        print(f"\n{'='*80}")
        print(f"  SUMMARY")
        print(f"{'='*80}")
        print(f"  Metadata version: {result['version']}")
        print(f"  Total identifiers: {len(result['identifiers'])}")
        print(f"  Network-related: {len(result['network_hits'])}")
        print(f"  Network literals: {len(result['net_literals'])}")
