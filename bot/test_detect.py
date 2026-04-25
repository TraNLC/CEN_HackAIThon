"""
test_detect.py - Detect game state via tcpdump + Frida packet injection.
1. Start tcpdump capture
2. Inject eCharacterRequest packet via Frida to trigger server response  
3. Parse captured data to show character info, items, etc.
"""
import sys, struct, time, subprocess, frida
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent.parent / 'proto'))
from vltk1_protocol import decode_message_fields, GS_OPCODES, MESSAGES

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'

DECODE_MAP = {
    4:  'Character',
    6:  'Item',
    7:  'EnterMap',
    12: 'Character',        # eCharacterResponse -> same proto as op=4
    16: 'Item',             # eSyncPlayerItem
    33: 'NpcDialogue',
    54: 'AddMapObject',
    58: 'SetRiding',
    72: 'MapDialogNpcListResponse',
    133: 'ChatMessage',
}

# ── Helpers ──────────────────────────────────────────────────────────────
def get_pid():
    out = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'], timeout=5).decode().strip()
    return int(out.split()[0]) if out else None

def find_game_fd(pid):
    tcp = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'cat /proc/{pid}/net/tcp'], timeout=5).decode()
    inodes, port_found = {}, None
    for line in tcp.split('\n')[1:]:
        p = line.split()
        if len(p) >= 10 and p[3] == '01':
            port = int(p[2].split(':')[1], 16)
            if port > 1000 and port not in (5555, 5037, 27042, 27183):
                inodes[p[9]] = port
                port_found = port
    fd = -1
    if inodes:
        fds_out = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'su -c "ls -la /proc/{pid}/fd"'], timeout=5).decode()
        for line in fds_out.split('\n'):
            if 'socket:[' not in line: continue
            inode = line.split('socket:[')[1].split(']')[0]
            if inode in inodes:
                parts = line.split()
                for j, p in enumerate(parts):
                    if p == '->' and j > 0:
                        fd = int(parts[j-1]); break
                if fd > 0: break
    return fd, port_found

def build_packet(opcode, proto=b''):
    return struct.pack('<IH', len(proto), opcode) + proto

# ── StringData decoder ───────────────────────────────────────────────────
STRING_DATA_TYPES = {
    4: 'NpcInfo',
    5: 'Timer/Cooldown',
    18: 'SyncPlayerData',
    20: 'SyncPlayerMove',
    23: 'SyncDamage',
    24: 'SyncStats',
}

def decode_string_data(body):
    """Decode eStringData pipe-separated format."""
    try:
        text = body.decode('utf-8', errors='replace')
        parts = text.split('|')
        sub_type = int(parts[0]) if parts else -1
        type_name = STRING_DATA_TYPES.get(sub_type, f'type_{sub_type}')
        return sub_type, type_name, parts
    except:
        return -1, 'error', []

# ── Packet parser ────────────────────────────────────────────────────────
char_info = {}
items = []
pkt_count = 0

SECT_NAMES = {1:'Thiếu Lâm',2:'Thiên Vương',3:'Đường Môn',4:'Ngũ Độc',5:'Nga Mi',6:'Côn Lôn',7:'Thiên Nhẫn',8:'Cái Bang',9:'Tiêu Dao'}

def format_char():
    if not char_info: return "  (no data yet)"
    lines = []
    try:
        sect = SECT_NAMES.get(char_info.get('sect',0), f"sect_{char_info.get('sect','?')}")
        lines.append(f"  Name : {char_info.get('name','???')}  ({char_info.get('account','')})")
        lines.append(f"  CID  : {char_info.get('cid','?')}  Sect: {sect}")
        lines.append(f"  Level: {char_info.get('level','?')}  EXP: {char_info.get('exp','?'):,}")
        lines.append(f"  HP   : {char_info.get('curLife','?')} / {char_info.get('maxLife','?')}")
        lines.append(f"  MP   : {char_info.get('curInner','?')} / {char_info.get('maxInner','?')}")
        lines.append(f"  STA  : {char_info.get('curStamina','?')} / {char_info.get('maxStamina','?')}")
        lines.append(f"  Map  : {char_info.get('mapId','?')}  Pos: ({char_info.get('mapX','?')}, {char_info.get('mapY','?')})")
        lines.append(f"  Money: {char_info.get('bagarateMoney','?'):,}  Speed: {char_info.get('runSpeed','?')}")
        lines.append(f"  Stats: SM={char_info.get('power','?')} NN={char_info.get('agility','?')} SK={char_info.get('outer','?')} NC={char_info.get('inside','?')}")
    except: pass
    return '\n'.join(lines)

def process_stream(data, direction='RECV'):
    global pkt_count, char_info
    buf = data
    while len(buf) >= 6:
        proto_len = struct.unpack_from('<I', buf, 0)[0]
        if proto_len > 100000:
            buf = b''; break
        full = 6 + proto_len
        if len(buf) < full: break
        
        opcode = struct.unpack_from('<H', buf, 4)[0]
        body = buf[6:full]
        buf = buf[full:]
        pkt_count += 1
        
        opcode_name = GS_OPCODES.get(opcode, f'UNK_{opcode}')
        tag = 'RECV' if direction == 'RECV' else 'SEND'
        
        # Decode
        decoded = None
        proto_name = DECODE_MAP.get(opcode)
        if proto_name and proto_name in MESSAGES and body:
            try: decoded = decode_message_fields(proto_name, body)
            except: pass
        
        # ── Display ──
        if opcode in (4, 12) and decoded:  # Character or CharacterResponse
            char_info.update(decoded)
            print(f"\n{'='*55}")
            print(f"[CHAR] Character Data (op={opcode})")
            print(format_char())
            print(f"{'='*55}")
        elif opcode in (6, 16) and decoded:  # Item or SyncPlayerItem
            items.append(decoded)
            print(f"[ITEM] id={decoded.get('identify','?')} detail={decoded.get('detailAndGenre','?')} stack={decoded.get('stackAndSeries','?')}")
        elif opcode == 7 and decoded:
            print(f"[MAP] Enter map={decoded.get('mapId','?')} ({decoded.get('mapX','?')},{decoded.get('mapY','?')})")
        elif opcode == 9 and body:  # StringData
            sub, tname, parts = decode_string_data(body)
            if sub == 4:  # NPC info: 4|npcId|resId|type|name|x|y|dir
                try: print(f"[NPC] {parts[4]} id={parts[1]} at ({parts[5]},{parts[6]})")
                except: pass
            elif sub == 18:
                print(f"[SYNC] PlayerData: {' | '.join(parts[1:6])}")
            elif sub == 23:
                pass  # Damage sync - too spammy
            elif sub in (20, 5):
                pass  # Move/timer - too spammy
            else:
                print(f"[STR] {tname}: {' | '.join(parts[:8])}")
        elif opcode == 133 and decoded:
            pass  # Chat filtered out (too noisy)
        elif opcode == 54 and decoded:
            try: print(f"[OBJ] {decoded.get('name','?')} type={decoded.get('type','?')} ({decoded.get('mapX','?')},{decoded.get('mapY','?')})")
            except: pass
        elif opcode == 72 and decoded:
            npc_list = decoded.get('list', [])
            print(f"[NPC LIST] mapId={decoded.get('mapId','?')}, {len(npc_list)} NPCs")
            for npc in npc_list[:10]:
                print(f"  - {npc.get('name','?')} ({npc.get('mapX','?')},{npc.get('mapY','?')})")
        elif opcode in (69, 70, 251):
            pass  # ping/pong/live - silent
        elif direction == 'SEND':
            print(f"[{tag}] {opcode_name} (op={opcode}) len={proto_len}")
        else:
            preview = body.hex()[:60] + ('...' if len(body.hex()) > 60 else '')
            print(f"[{pkt_count:04d}] {opcode_name} (op={opcode}) len={proto_len}  {preview}")

# ── pcap parser ──────────────────────────────────────────────────────────
def parse_pcap(filepath, server_port):
    with open(filepath, 'rb') as f:
        data = f.read()
    if len(data) < 24: print('[-] Empty pcap'); return
    
    magic = struct.unpack_from('<I', data, 0)[0]
    endian = '<' if magic == 0xa1b2c3d4 else '>'
    link_type = struct.unpack_from(f'{endian}I', data, 20)[0]
    
    offset = 24
    recv_data, send_data = b'', b''
    pkt_n = 0
    
    while offset + 16 <= len(data):
        ts_sec, ts_usec, incl_len, orig_len = struct.unpack_from(f'{endian}IIII', data, offset)
        offset += 16
        if offset + incl_len > len(data): break
        pkt_data = data[offset:offset+incl_len]
        offset += incl_len
        pkt_n += 1
        
        if link_type == 113:
            if len(pkt_data) < 16: continue
            ip_data = pkt_data[16:]
            proto = struct.unpack('>H', pkt_data[14:16])[0]
        elif link_type == 1:
            if len(pkt_data) < 14: continue
            proto = struct.unpack('>H', pkt_data[12:14])[0]
            ip_data = pkt_data[14:]
        else: continue
        
        if proto != 0x0800 or len(ip_data) < 20: continue
        ihl = (ip_data[0] & 0x0F) * 4
        if ip_data[9] != 6: continue
        
        tcp = ip_data[ihl:]
        if len(tcp) < 20: continue
        src_port = struct.unpack('>H', tcp[0:2])[0]
        dst_port = struct.unpack('>H', tcp[2:4])[0]
        tcp_hlen = ((tcp[12] >> 4) & 0xF) * 4
        payload = tcp[tcp_hlen:]
        if not payload: continue
        
        if src_port == server_port:
            recv_data += payload
        elif dst_port == server_port:
            send_data += payload
    
    print(f'[*] Parsed {pkt_n} raw packets | Recv: {len(recv_data)}B  Send: {len(send_data)}B\n')
    
    if send_data:
        print('--- SENT (Client -> Server) ---')
        process_stream(send_data, 'SEND')
    if recv_data:
        print('\n--- RECEIVED (Server -> Client) ---')
        process_stream(recv_data, 'RECV')

# ── Main ─────────────────────────────────────────────────────────────────
pid = get_pid()
if not pid: print('[-] Game not running!'); exit(1)

game_fd, server_port = find_game_fd(pid)
if not server_port: print('[-] Cannot find server port!'); exit(1)
print(f'[+] PID={pid}  FD={game_fd}  Port={server_port}')

# ── Step 1: Start tcpdump ────────────────────────────────────────────────
PCAP = '/data/local/tmp/game_cap.pcap'
subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True, timeout=5)
time.sleep(0.5)
subprocess.Popen([ADB, '-s', DEVICE_ID, 'shell', f'su -c "tcpdump -i any -w {PCAP} port {server_port} -c 1000 2>/dev/null &"'])
time.sleep(1)
print('[*] tcpdump started')

# ── Step 2: Inject packets to trigger data ───────────────────────────────
JS_WRITE = """
var nativeWrite = null;
Process.enumerateModules().forEach(function(m) {
    if (nativeWrite) return;
    try {
        var exp = m.findExportByName('write');
        if (!exp) return;
        var range = Process.findRangeByAddress(exp);
        if (range && range.protection.indexOf('x') !== -1) {
            nativeWrite = new NativeFunction(exp, 'int', ['int', 'pointer', 'int']);
        }
    } catch(e) {}
});
rpc.exports = {
    sendRaw: function(fd, hexStr) {
        if (!nativeWrite) return { ok: false };
        var n = hexStr.length / 2;
        var buf = Memory.alloc(n > 0 ? n : 1);
        for (var i = 0; i < n; i++)
            buf.add(i).writeU8(parseInt(hexStr.substr(i*2, 2), 16));
        return { ok: nativeWrite(fd, buf, n) === n };
    }
};
"""

device = next(d for d in frida.enumerate_devices() if DEVICE_ID in d.id)
session = device.attach(pid)
script = session.create_script(JS_WRITE)
script.load()
rpc = script.exports_sync
time.sleep(0.5)

# Send packets to trigger server responses
print('[*] Injecting trigger packets...')

# ePing (69) - keep alive
pkt = build_packet(69)
rpc.send_raw(game_fd, pkt.hex())
print('  -> ePing')

# eCharacterRequest (11) with empty body - request char info
pkt = build_packet(11)
rpc.send_raw(game_fd, pkt.hex())
print('  -> eCharacterRequest')

# eMapDialogNpcListRequest (71) with mapId=1
proto = b'\x08\x01'  # field 1 = int32(1)
pkt = build_packet(71, proto)
rpc.send_raw(game_fd, pkt.hex())
print('  -> eMapDialogNpcListRequest (mapId=1)')

# eAllMagicAttribRequest (65) - get character attributes
pkt = build_packet(65)
rpc.send_raw(game_fd, pkt.hex())
print('  -> eAllMagicAttribRequest')

# ePropertiesFieldRequest (179)
pkt = build_packet(179)
rpc.send_raw(game_fd, pkt.hex())
print('  -> ePropertiesFieldRequest')

session.detach()
print('[*] Packets injected. Waiting 5 seconds for responses...\n')
time.sleep(5)

# ── Step 3: Stop tcpdump and parse ───────────────────────────────────────
subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump"'], capture_output=True, timeout=5)
time.sleep(1)

local_pcap = 'data/game_cap.pcap'
subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP, local_pcap], capture_output=True, timeout=10)

parse_pcap(local_pcap, server_port)

print(f'\n{"="*55}')
print(f'Total decoded: {pkt_count} packets')
if char_info:
    print('\n--- CHARACTER STATE ---')
    print(format_char())
if items:
    print(f'\n--- ITEMS ({len(items)}) ---')
    for it in items[:15]:
        print(f'  {it}')
print(f'{"="*55}')
