"""
test_open_shop.py - Tự động mở sạp hàng + đọc items

Protocol:
  Gửi opcode 204: f1(str) = "salesman.{playerID}.0"
  Nhận opcode 205: f1(str) = playerID, f3(bytes) = items (repeated)

100% protocol, không OCR.
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

from features.bot.game_bot import VLTK1Bot

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
PCAP_DEV  = '/data/local/tmp/shop.pcap'
PCAP_LOC  = str(ROOT_DIR / 'data' / 'shop.pcap')

SALESMAN_RE = re.compile(r'^salesman\.(\d+)\.\d+$')


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


def read_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80): break
    return result, pos


def encode_varint(val):
    result = []
    while val > 0x7F:
        result.append((val & 0x7F) | 0x80)
        val >>= 7
    result.append(val)
    return bytes(result)


def build_open_shop_pkt(salesman_id):
    """Build opcode 204 packet: f1(str) = salesman_id"""
    # Protobuf: field 1, wire type 2 (length-delimited)
    name = salesman_id.encode('utf-8')
    proto = b'\x0a' + encode_varint(len(name)) + name
    return struct.pack('<IH', len(proto), 204) + proto


def parse_shop_items(body):
    """Parse opcode 205 response - shop items"""
    result = {"owner_id": "", "items": []}
    pos = 0
    while pos < len(body):
        tag, pos = read_varint(body, pos)
        if pos > len(body): break
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(body, pos)
        elif wtype == 2:
            ln, pos = read_varint(body, pos)
            if pos + ln > len(body): break
            raw = body[pos:pos+ln]; pos += ln
            if fnum == 1:
                try: result["owner_id"] = raw.decode('utf-8')
                except: pass
            elif fnum == 3:
                # Each f3 is a shop item (nested protobuf)
                item = parse_shop_item(raw)
                result["items"].append(item)
        elif wtype == 5:
            pos += 4
        elif wtype == 1:
            pos += 8
        else: break
    return result


def parse_shop_item(raw):
    """Parse a single shop item from opcode 205 field 3"""
    item = {"slot": 0, "inner": {}}
    pos = 0
    while pos < len(raw):
        tag, pos = read_varint(raw, pos)
        if pos > len(raw): break
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(raw, pos)
            item[f"f{fnum}"] = val
            if fnum == 1: item["slot"] = val
        elif wtype == 2:
            ln, pos = read_varint(raw, pos)
            if pos + ln > len(raw): break
            inner_raw = raw[pos:pos+ln]; pos += ln
            if fnum == 2:
                # Inner item data
                item["inner"] = parse_item_data(inner_raw)
            else:
                try: item[f"f{fnum}_s"] = inner_raw.decode('utf-8')
                except: item[f"f{fnum}_h"] = inner_raw.hex()[:40]
        elif wtype == 5:
            if pos + 4 > len(raw): break
            val = struct.unpack_from('<I', raw, pos)[0]
            item[f"f{fnum}_u32"] = val
            pos += 4
        else: break
    return item


def parse_item_data(raw):
    """Parse inner item data, including deeply nested item info"""
    data = {}
    pos = 0
    while pos < len(raw):
        tag, pos = read_varint(raw, pos)
        if pos > len(raw): break
        fnum, wtype = tag >> 3, tag & 0x7
        if wtype == 0:
            val, pos = read_varint(raw, pos)
            data[f"f{fnum}"] = val
        elif wtype == 2:
            ln, pos = read_varint(raw, pos)
            if pos + ln > len(raw): break
            val = raw[pos:pos+ln]; pos += ln
            
            # Try to decode as string
            try:
                text = val.decode('utf-8')
                if text.isprintable() and len(text) > 1:
                    data[f"f{fnum}_s"] = text
                    continue
            except: pass
            
            # Try to decode as nested protobuf
            nested_data = {}
            n_pos = 0
            is_proto = False
            while n_pos < len(val):
                try: n_tag, n_pos = read_varint(val, n_pos)
                except: break
                if n_pos > len(val): break
                n_fnum, n_wtype = n_tag >> 3, n_tag & 0x7
                if n_fnum == 0 or n_fnum > 100: break # Invalid proto
                
                if n_wtype == 0:
                    n_val, n_pos = read_varint(val, n_pos)
                    nested_data[f"n{n_fnum}"] = n_val
                    is_proto = True
                elif n_wtype == 2:
                    n_ln, n_pos = read_varint(val, n_pos)
                    if n_pos + n_ln > len(val): break
                    n_val2 = val[n_pos:n_pos+n_ln]; n_pos += n_ln
                    try:
                        n_text = n_val2.decode('utf-8')
                        if n_text.isprintable():
                            nested_data[f"n{n_fnum}_s"] = n_text
                    except:
                        nested_data[f"n{n_fnum}_h"] = n_val2.hex()
                    is_proto = True
                elif n_wtype == 5:
                    n_pos += 4
                elif n_wtype == 1:
                    n_pos += 8
                else: break
                
            if is_proto and nested_data:
                data[f"f{fnum}_proto"] = nested_data
            else:
                data[f"f{fnum}_h"] = val.hex()[:40]
                
        elif wtype == 5:
            if pos + 4 > len(raw): break
            val = struct.unpack_from('<I', raw, pos)[0]
            data[f"f{fnum}_u32"] = val
            pos += 4
        else: break
    return data


def run():
    print()
    print("=" * 62)
    print("  VLTK1 - AUTO OPEN SHOP + READ ITEMS")
    print("=" * 62)

    try:
        game_pid = int(subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', 'pidof', 'vn.perfingame.jx1mobile']).strip())
        port = get_game_port(game_pid)
    except:
        port = 443

    if len(sys.argv) > 1 and sys.argv[1] == '--parse-only':
        print("\n[*] Parsing existing PCAP only...")
        packets = parse_pcap_recv(PCAP_LOC, port)
        shop_count = 0
        goto_phase3(packets, shop_count)
        return

    # ── Phase 1: Passive scan to find salesmen ──
    print(f"\n[*] Phase 1: Scanning for salesmen (10s)...")

    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.5)

    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 3000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(10)
    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    packets = parse_pcap_recv(PCAP_LOC, port)

    # Find salesman IDs from opcode 9 AND opcode 133
    salesmen = {}
    
    # 1. Check opcode 133 for stall broadcasts
    for opcode, body in packets:
        if opcode != 133: continue
        if len(body) < 10: continue
        pos = 0
        is_stall = False
        pid_str = ""
        while pos < len(body):
            tag, pos = read_varint(body, pos)
            if pos > len(body): break
            field, wtype = tag >> 3, tag & 0x7
            if wtype == 0:
                val, pos = read_varint(body, pos)
                if field == 1 and val == 5: is_stall = True
            elif wtype == 2:
                ln, pos = read_varint(body, pos)
                if pos + ln > len(body): break
                raw = body[pos:pos+ln]; pos += ln
                if field == 2:
                    try: pid_str = raw.decode('utf-8')
                    except: pass
            else: break
        
        if is_stall and pid_str:
            sid = f"salesman.{pid_str}.0"
            if sid not in salesmen:
                salesmen[sid] = {"player_id": pid_str, "raw": ["found via broadcast"]}

    # 2. Check opcode 9
    for opcode, body in packets:
        if opcode != 9: continue
        try: text = body.decode('utf-8', errors='replace')
        except: continue
        parts = text.split('|')
        if len(parts) < 2: continue
        m = SALESMAN_RE.match(parts[1])
        if m:
            sid = parts[1]
            pid = m.group(1)
            if sid not in salesmen:
                salesmen[sid] = {"player_id": pid, "raw": []}
            if len(salesmen[sid]["raw"]) < 3:
                salesmen[sid]["raw"].append(text)

    print(f"[+] Found {len(salesmen)} salesmen")
    if not salesmen:
        print("[-] No salesmen found. Make sure you're near stalls.")
        return

    for sid, info in salesmen.items():
        print(f"    {sid}")
        for r in info["raw"]:
            print(f"      {r[:80]}")

    # ── Phase 2: Open each shop via protocol ──
    print(f"\n[*] Phase 2: Opening shops via opcode 204...")

    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Failed to connect bot"); return

    # Start capture for responses
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.5)
    tcpdump = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell',
         f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} -c 5000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(1)

    # Open each shop
    for sid, info in list(salesmen.items())[:5]:  # Max 5 shops
        print(f"\n  📤 Opening: {sid}")
        pkt = build_open_shop_pkt(sid)
        bot.send_raw(pkt)
        time.sleep(2)  # Wait for response

    time.sleep(3)
    bot.close()

    tcpdump.terminate()
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell',
                    'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(1)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC],
                   capture_output=True)

    # ── Phase 3: Parse shop responses (opcode 205) ──
    print(f"\n[*] Phase 3: Parsing shop responses...")

    packets = parse_pcap_recv(PCAP_LOC, port)
    shop_count = 0

    for opcode, body in packets:
        if opcode != 205: continue
        shop_count += 1
        shop = parse_shop_items(body)
        shop_items = shop.get('items', [])

        # Process shop items
        ITEM_NAMES = {
            100001: "Mũ (Helm)",
            200001: "Áo (Armor)",
            300001: "Nhẫn (Ring)",
            400001: "Dây Chuyền (Necklace)",
            500001: "Ngọc Bội/Phù (Amulet)",
            600001: "Giày (Boots)",
            700001: "Thắt Lưng (Belt)",
            80001: "Hộ Uyển (Cuff)",
            1450002: "An Bang Bảo Rương (Tiểu)",
            1460002: "An Bang Bảo Rương",
            1470002: "Rương Hoàng Kim An Bang",
            2500001: "Bí Kíp Võ Công",
            2490001: "Đồ Phổ Hoàng Kim",
            1290001: "Huyền Tinh / Khoáng",
            390001: "Nguyên Liệu",
        }
        
        print(f"\n[+] Phát hiện SHOP chứa {len(shop_items)} vật phẩm!")
        print(f"{'Slot':<6} | {'Item Name (Type)':<30} | {'Raw ID':<10} | {'Level/Tpl':<10} | {'Price (Vạn/KNB)':<15} | {'Amount':<6}")
        print("-" * 85)
        for it in shop_items:
            slot = it.get('slot', '?')
            # DEBUG: find the price field!
            if 'f3' not in it and 'f3_u32' not in it:
                print("DEBUG ITEM KEYS:", it.keys(), "RAW:", {k:v for k,v in it.items() if k != 'inner'})
            price = it.get('f3_u32') or it.get('f3') or it.get('f4') or it.get('f5') or '?'
            
            inner = it.get('inner', {})
            f1_p = inner.get('f1_proto', {})
            
            item_id = f1_p.get('n2', 'Unknown')
            amount = f1_p.get('n3', 1)
            if amount >= 10000:
                amount = 1 # Often durability or other stat if it's huge
                
            tpl_id = f1_p.get('n4', '?')
            
            name = ITEM_NAMES.get(item_id, f"Vật phẩm {item_id}")
            
            # Try to infer price unit (if huge, maybe xu, if normal, maybe KNB/vạn)
            if isinstance(price, int):
                if price >= 10000:
                    price_str = f"{price//10000} vạn"
                else:
                    price_str = str(price)
            else:
                price_str = str(price)

            print(f"{slot:<6} | {name:<30} | {item_id:<10} | {tpl_id:<10} | {price_str:<15} | {amount:<6}")
        
        print("-" * 85)

    if shop_count == 0:
        print("  [-] No opcode 205 responses received")
        # Check if there are any other interesting opcodes
        for opcode, body in packets:
            if opcode in {9, 251, 69, 70, 133}: continue
            if len(body) > 10:
                print(f"  [?] Opcode {opcode} ({len(body)} bytes)")

    print(f"\n{'─'*62}")
    print(f"  Opened {shop_count} shops")
    print(f"{'─'*62}")


if __name__ == '__main__':
    run()
