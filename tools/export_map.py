"""
Auto Export All - Tool tự động 1 lệnh duy nhất!
Chỉ cần đứng trong thành bất kỳ → chạy file này → tự động:
  1. Detect Map ID đang đứng (inject eCharacterRequest)
  2. Lấy toàn bộ NPC + tọa độ (inject eMapDialogNpcListRequest)
  3. Nhận diện tên thành / thôn trang
  4. Xuất ra file JSON

Cách dùng:
    python bot/auto_export_all.py              (tự detect map)
    python bot/auto_export_all.py 176          (chỉ định map ID)
"""
import sys, time, subprocess, json, os, struct, frida
from pathlib import Path
import sys

# Thêm đường dẫn gốc để import thư viện
ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))

from core.protocol import decode_message_fields
import blackboxprotobuf
from database.db_manager import db
from core.injector import get_pid, find_game_fd, ADB, DEVICE_ID, JS_WRITE

PCAP = '/data/local/tmp/auto_all.pcap'
LOCAL_PCAP = 'data/auto_all.pcap'



def safe_print(text):
    try:
        print(text)
    except UnicodeEncodeError:
        sys.stdout.buffer.write((str(text) + '\n').encode('utf-8'))

def get_remote_port(pid):
    """Lấy port kết nối tới game server."""
    out = subprocess.check_output(
        [ADB, '-s', DEVICE_ID, 'shell', f'su -c "cat /proc/{pid}/net/tcp"']
    ).decode('utf-8', 'ignore')
    for line in out.splitlines()[1:]:
        parts = line.strip().split()
        if len(parts) >= 3 and parts[3] == '01':
            try:
                return int(parts[2].split(':')[1], 16)
            except:
                pass
    return 45677

def parse_pcap_stream(filepath, server_port):
    """Parse pcap file và trả về (recv_buffer, send_buffer)."""
    if not os.path.exists(filepath):
        return b'', b''
    with open(filepath, 'rb') as f:
        data = f.read()
    if len(data) < 24:
        return b'', b''

    magic = struct.unpack_from('<I', data, 0)[0]
    endian = '<' if magic == 0xa1b2c3d4 else '>'
    link_type = struct.unpack_from(f'{endian}I', data, 20)[0]

    offset = 24
    recv_buf = b''
    send_buf = b''

    while offset + 16 <= len(data):
        ts_sec, ts_usec, incl_len, orig_len = struct.unpack_from(f'{endian}IIII', data, offset)
        offset += 16
        if offset + incl_len > len(data):
            break
        pkt_data = data[offset:offset + incl_len]
        offset += incl_len

        if link_type == 113 and len(pkt_data) >= 16:
            ip_data = pkt_data[16:]
        elif link_type == 1 and len(pkt_data) >= 14:
            ip_data = pkt_data[14:]
        else:
            continue

        if len(ip_data) < 20 or ip_data[9] != 6:
            continue
        ihl = (ip_data[0] & 0x0F) * 4
        tcp = ip_data[ihl:]
        if len(tcp) < 20:
            continue

        src_port = struct.unpack('>H', tcp[0:2])[0]
        dst_port = struct.unpack('>H', tcp[2:4])[0]
        tcp_hlen = ((tcp[12] >> 4) & 0xF) * 4
        payload = tcp[tcp_hlen:]
        if not payload:
            continue

        if src_port == server_port:
            recv_buf += payload
        elif dst_port == server_port:
            send_buf += payload

    return recv_buf, send_buf

def extract_packets(tcp_buffer, target_opcode=None):
    """Trích xuất tất cả game packets từ TCP buffer. 
    Nếu target_opcode != None, chỉ trả về packets có opcode đó."""
    results = []
    p_off = 0
    while p_off + 6 <= len(tcp_buffer):
        proto_len = struct.unpack_from('<I', tcp_buffer, p_off)[0]
        if proto_len > 500000:  # Sanity check
            break
        opcode = struct.unpack_from('<H', tcp_buffer, p_off + 4)[0]
        if p_off + 6 + proto_len > len(tcp_buffer):
            break
        body = tcp_buffer[p_off + 6: p_off + 6 + proto_len]
        p_off += 6 + proto_len

        if target_opcode is None or opcode == target_opcode:
            results.append((opcode, body))
    return results

def encode_varint_field(field_num, value):
    """Encode protobuf varint field."""
    tag = (field_num << 3) | 0  # wire type 0 = varint
    result = bytes([tag])
    while value > 0x7F:
        result += bytes([(value & 0x7F) | 0x80])
        value >>= 7
    result += bytes([value & 0x7F])
    return result

def build_map_request(map_id):
    """Tạo protobuf body cho eMapDialogNpcListRequest (field 1 = mapId)."""
    if map_id < 128:
        return struct.pack('<BB', 0x08, map_id)
    else:
        b1 = (map_id & 0x7F) | 0x80
        b2 = map_id >> 7
        return struct.pack('<BBB', 0x08, b1, b2)

# ==================== MAIN FLOW ====================

def run(forced_map_id=None):
    safe_print("")
    safe_print("╔══════════════════════════════════════════════════╗")
    safe_print("║   VLTK1 Mobile - Auto Export Tool (All-in-One)  ║")
    safe_print("║   Tự động detect map + lấy NPC + tọa độ        ║")
    safe_print("╚══════════════════════════════════════════════════╝")
    safe_print("")

    # ── Bước 0: Kiểm tra game ──
    pid = get_pid()
    if not pid:
        safe_print("[-] Game chưa mở! Hãy mở VLTK1 Mobile trước.")
        return
    fd = find_game_fd(pid)
    if fd <= 0:
        safe_print("[-] Không tìm thấy Socket FD!")
        return

    port = get_remote_port(pid)
    safe_print(f"[+] Game PID: {pid} | FD: {fd} | Server Port: {port}")
    os.makedirs('data/maps', exist_ok=True)

    # ── Kết nối Frida 1 lần duy nhất ──
    try:
        device = next(d for d in frida.enumerate_devices() if DEVICE_ID in d.id)
        session = device.attach(pid)
        script = session.create_script(JS_WRITE)
        script.load()
        rpc = script.exports_sync
    except Exception as e:
        safe_print(f"[-] Lỗi Frida: {e}")
        return

    def inject(opcode, body):
        pkt = struct.pack('<IH', len(body), opcode) + body
        return rpc.send_raw(fd, pkt.hex())

    # ── Tìm base address của libil2cpp.so qua /proc/maps ──
    il2cpp_base = None
    try:
        maps_out = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', f'su -c "cat /proc/{pid}/maps"'],
            timeout=5
        ).decode('utf-8', 'ignore')
        for line in maps_out.splitlines():
            if 'libil2cpp.so' in line and 'r-xp' in line:
                il2cpp_base = '0x' + line.split('-')[0].strip()
                break
        # Nếu không tìm thấy r-xp, lấy vùng đầu tiên
        if not il2cpp_base:
            for line in maps_out.splitlines():
                if 'libil2cpp.so' in line:
                    il2cpp_base = '0x' + line.split('-')[0].strip()
                    break
    except:
        pass
    
    if il2cpp_base:
        safe_print(f"[+] libil2cpp.so base: {il2cpp_base}")
    
    def get_map_name_from_game(map_id_val):
        # Đã loại bỏ do dễ crash và đã có dict JSON chuẩn
        return None

    # ── Kill tcpdump cũ ──
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.5)

    # ═══════════════════════════════════════════════════
    #   PHASE 1: Detect Map ID (nếu chưa chỉ định)
    # ═══════════════════════════════════════════════════
    map_id = forced_map_id
    char_name = None
    char_level = None
    char_pos = None

    if map_id is None:
        safe_print("\n[*] PHASE 1: Đang detect Map ID hiện tại...")

        # Bật tcpdump
        tcpdump = subprocess.Popen(
            [ADB, '-s', DEVICE_ID, 'shell',
             f'su -c "tcpdump -i any -U -w {PCAP} port {port} -c 200"'],
            stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
        )
        time.sleep(2)

        # Inject eCharacterRequest (opcode 11) → server trả về opcode 12
        safe_print("[*] Gửi eCharacterRequest...")
        inject(11, b'')
        time.sleep(3)

        # Dừng capture và pull
        tcpdump.terminate()
        subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                       capture_output=True)
        time.sleep(1)
        subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP, LOCAL_PCAP], capture_output=True)

        # Parse opcode 12 (eCharacterResponse)
        recv_buf, _ = parse_pcap_stream(LOCAL_PCAP, port)
        packets = extract_packets(recv_buf, target_opcode=12)

        for opcode, body in packets:
            try:
                decoded = decode_message_fields('Character', body)
                if decoded and 'mapId' in decoded:
                    map_id = decoded['mapId']
                    char_name = decoded.get('name', '?')
                    char_level = decoded.get('level', '?')
                    char_pos = (decoded.get('mapX', '?'), decoded.get('mapY', '?'))
                    break
            except:
                pass

        # Fallback: thử opcode 4 (eCharacterDetailResponse)
        if map_id is None:
            packets = extract_packets(recv_buf, target_opcode=4)
            for opcode, body in packets:
                try:
                    decoded = decode_message_fields('Character', body)
                    if decoded and 'mapId' in decoded:
                        map_id = decoded['mapId']
                        char_name = decoded.get('name', '?')
                        char_level = decoded.get('level', '?')
                        char_pos = (decoded.get('mapX', '?'), decoded.get('mapY', '?'))
                        break
                except:
                    pass

        if map_id is None:
            safe_print("[-] Không detect được Map ID!")
            safe_print("[!] Hãy thử:")
            safe_print("    - Đảm bảo nhân vật đang online trong game")
            safe_print("    - Hoặc chỉ định map ID: python bot/auto_export_all.py 176")
            session.detach()
            return


        safe_print(f"[+] DETECT THÀNH CÔNG!")
        if char_name:
            safe_print(f"    Nhân vật: {char_name} (Lv.{char_level})")
        if char_pos:
            safe_print(f"    Vị trí  : ({char_pos[0]}, {char_pos[1]})")
        safe_print(f"    Map ID  : {map_id}")
        map_info = db.get_map(map_id)
        safe_print(f"    Tên Map : {map_info['name']} (từ Settings)")

        # Lưu map ID cho các script khác
        os.makedirs('data', exist_ok=True)
        with open('data/current_map.txt', 'w') as f:
            f.write(str(map_id))

    else:
        safe_print(f"\n[*] Sử dụng Map ID được chỉ định: {map_id}")
        map_info = db.get_map(map_id)
        safe_print(f"    Tên Map : {map_info['name']} (từ Settings)")

    # ═══════════════════════════════════════════════════
    #   PHASE 2: Lấy danh sách NPC + Tọa độ
    # ═══════════════════════════════════════════════════
    safe_print(f"\n[*] PHASE 2: Đang lấy danh sách NPC trên Map {map_id}...")

    # Kill tcpdump cũ, bật mới
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(0.5)

    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP} port {port} -c 200"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
    )
    time.sleep(2)

    # Inject eMapDialogNpcListRequest (opcode 71, body = mapId)
    proto_body = build_map_request(map_id)
    safe_print(f"[*] Gửi eMapDialogNpcListRequest (map={map_id})...")
    inject(71, proto_body)
    time.sleep(3)

    # Dừng capture
    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'],
                   capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP, LOCAL_PCAP], capture_output=True)

    # Ngắt Frida (đã xong hết)
    session.detach()

    # ── Parse opcode 72 (eMapDialogNpcListResponse) ──
    recv_buf, _ = parse_pcap_stream(LOCAL_PCAP, port)
    packets = extract_packets(recv_buf, target_opcode=72)

    npc_list_raw = None
    for opcode, body in packets:
        try:
            decoded = decode_message_fields('MapDialogNpcListResponse', body)
            if decoded and 'list' in decoded:
                npc_list_raw = decoded['list']
                break
        except:
            pass

    if not npc_list_raw:
        safe_print("[-] Không nhận được danh sách NPC từ server!")
        safe_print("[!] Có thể bạn không đứng trong map này, hoặc server chưa phản hồi.")
        safe_print("[!] Hãy thử chạy lại.")
        return

    # ── Giải mã NPC ──
    npc_schema = {
        '1': {'type': 'bytes', 'name': 'name'},
        '2': {'type': 'int', 'name': 'mapX'},
        '3': {'type': 'int', 'name': 'mapY'}
    }

    parsed_npcs = []
    npc_names = []

    for npc in npc_list_raw:
        if isinstance(npc, bytes):
            try:
                n_msg, _ = blackboxprotobuf.decode_message(npc, npc_schema)
                name = n_msg.get('name', b'').decode('utf-8', 'ignore')
                x = n_msg.get('mapX', 0)
                y = n_msg.get('mapY', 0)
                parsed_npcs.append({'name': name, 'x': x, 'y': y})
                npc_names.append(name)
            except:
                pass
        else:
            name = npc.get('name', '?')
            x = npc.get('mapX', 0)
            y = npc.get('mapY', 0)
            parsed_npcs.append({'name': name, 'x': x, 'y': y})
            npc_names.append(name)

    # ═══════════════════════════════════════════════════
    #   PHASE 3: Nhận diện thành / xuất kết quả
    # ═══════════════════════════════════════════════════
    
    # Ưu tiên 1: Lấy từ file settings JSON gốc (chuẩn xác nhất)
    map_info = db.get_map(map_id)
    final_map_name = map_info['name']
    final_map_type = map_info['type']

    safe_print("")
    safe_print("╔══════════════════════════════════════════════════╗")
    safe_print("║              KẾT QUẢ DETECT                     ║")
    safe_print("╠══════════════════════════════════════════════════╣")
    safe_print(f"║  Tên Map : {final_map_name:<37} ║")
    safe_print(f"║  Map ID  : {str(map_id):<37} ║")
    safe_print(f"║  Loại    : {final_map_type:<37} ║")
    safe_print(f"║  Số NPC  : {str(len(parsed_npcs)):<37} ║")
    safe_print("╚══════════════════════════════════════════════════╝")

    # In danh sách NPC
    safe_print(f"\n--- DANH SÁCH NPC ({len(parsed_npcs)}) ---")
    for i, npc in enumerate(parsed_npcs, 1):
        safe_print(f"  {i:>3}. {npc['name']:<35} ({npc['x']}, {npc['y']})")

    # ── Lưu file JSON ──
    save_path = f"data/maps/map_{map_id}.json"
    result = {
        'map_id': map_id,
        'map_name': final_map_name,
        'map_type': final_map_type,
        'npc_count': len(parsed_npcs),
        'npcs': parsed_npcs
    }

    # Thêm thông tin nhân vật nếu có
    if char_name:
        result['detected_by'] = {
            'char_name': char_name,
            'char_level': char_level,
            'char_pos': list(char_pos) if char_pos else None
        }

    with open(save_path, 'w', encoding='utf-8') as f:
        json.dump(result, f, ensure_ascii=False, indent=4)

    safe_print(f"\n[+] ĐÃ LƯU: {save_path}")
    safe_print(f"[+] HOÀN TẤT!")

if __name__ == '__main__':
    if len(sys.argv) == 2 and sys.argv[1].isdigit():
        run(int(sys.argv[1]))
    else:
        run()
