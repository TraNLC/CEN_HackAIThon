import os
import sys
import time
import json
import subprocess
from test_open_shop import parse_pcap_recv, parse_shop_items, read_varint

# Fix encoding for Windows Terminal
sys.stdout.reconfigure(encoding='utf-8')

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE = 'vn.perfingame.jx1mobile'
PCAP_DEV = '/data/local/tmp/shop_live.pcap'
PCAP_LOC = r'e:\tool\sample-test\vltk1-re\data\output\shop_live.pcap'

import codecs
import re

# Auto-build MAGIC_MAP from magicdesc.txt
MAGIC_MAP = {}
try:
    _lines = codecs.open(r'e:\tool\sample-test\vltk1-re\data\game_raw\settings\magicdesc.txt', 'r', 'utf-16le').read().splitlines()
    for _i, _line in enumerate(_lines):
        if _i == 0: continue
        _parts = _line.split('\t')
        if len(_parts) >= 3:
            _prop = _parts[0].strip()
            _desc = _parts[2].strip()
            # Clean HTML tags from description
            _desc = re.sub(r'<[^>]+>', '', _desc)
            # Extract readable name (before the colon)
            _name = _desc.split(':')[0].strip() if ':' in _desc else _desc
            if not _name: _name = _prop
            # Offset: rows 1-10 = metadata (skip), rows 11-65 = +15, rows >= 66 = +22
            if _i <= 10:
                continue  # metadata, not item stats
            elif _i <= 65:
                _game_id = _i + 15
            else:
                _game_id = _i + 22
            MAGIC_MAP[_game_id] = _name
except Exception as e:
    print(f"[!] Lỗi load magicdesc: {e}")

# Build ITEM lookup: (detail, n4) -> item_name
# n3 = detail * 10000 (0=melee,1=range,2=armor,3=ring,4=amulet,5=boot,6=belt,7=helm,8=cuff,9=pendant)
# n4 = particular * 10000 + level (1-10 within each particular group)
ITEM_DIR = r'e:\tool\sample-test\vltk1-re\data\game_raw\settings\item'
ITEM_LOOKUP = {}  # (detail, n4) -> item_name

try:
    def _load_file(fname, detail):
        lines = codecs.open(ITEM_DIR + '\\' + fname + '.txt', 'r', 'utf-16le').read().splitlines()
        count = 0
        for i in range(1, len(lines)):
            cols = lines[i].split('\t')
            name = cols[0].strip()
            particular = int(cols[3])
            level = ((i - 1) % 10) + 1
            n4 = particular * 10000 + level
            ITEM_LOOKUP[(detail, n4)] = name
            count += 1
        return count
    
    total = 0
    total += _load_file('meleeweapon', 0)
    total += _load_file('rangeweapon', 1)
    total += _load_file('armor', 2)
    total += _load_file('ring', 3)
    total += _load_file('amulet', 4)
    total += _load_file('boot', 5)
    total += _load_file('belt', 6)
    total += _load_file('helm', 7)
    total += _load_file('cuff', 8)
    total += _load_file('pendant', 9)
    
    print(f'[*] Loaded {total} items')
except Exception as e:
    print(f'[!] Lỗi load item data: {e}')

def get_item_name(n3, n4):
    """Lookup item name using detail (from n3) and template (n4)"""
    detail = n3 // 10000 if n3 else 0
    return ITEM_LOOKUP.get((detail, n4), f'#{detail}:{n4}')



def get_game_port():
    try:
        out = subprocess.check_output(
            [ADB, '-s', DEVICE_ID, 'shell', 'su -c "netstat -tnp 2>/dev/null"']).decode()
        for line in out.splitlines():
            if 'jx1mobile' in line and 'ESTABLISHED' in line:
                parts = line.split()
                # parts[4] = remote_addr:port (server side)
                remote_port = int(parts[4].split(':')[-1])
                if remote_port > 1024:
                    return remote_port
    except:
        pass
    return 45676

def run():
    print("=" * 70)
    print("  VLTK1 - LIVE SHOP SCANNER (LIÊN TỤC)")
    print("=" * 70)
    
    port = get_game_port()
    print(f"[*] Port server: {port}")
    
    # Kill old tcpdump
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', f'su -c "rm {PCAP_DEV} 2>/dev/null"'], capture_output=True)
    
    # Start tcpdump in background - filter by game port only
    cmd = [ADB, '-s', DEVICE_ID, 'shell', f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} 2>/dev/null"']
    proc = subprocess.Popen(cmd, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    
    print("[!] ĐANG LẮNG NGHE... HÃY BẤM MỞ SHOP CỦA NGƯỜI CHƠI TRONG GAME NGAY BÂY GIỜ!")
    print("[!] GHI CHÚ: Nếu bị lẫn shop của người khác (VD: KimĐạiTướng), hãy xem kỹ tên Chủ Shop ở kết quả.")
    
    try:
        scan_count = 0
        while True:
            time.sleep(1.5)
            subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC], stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
            
            if not os.path.exists(PCAP_LOC):
                scan_count += 1
                if scan_count % 10 == 0:
                    print(f"[DEBUG] Scan #{scan_count}: pcap file chưa có")
                continue
            
            fsize = os.path.getsize(PCAP_LOC)
            if fsize < 50:
                scan_count += 1
                if scan_count % 10 == 0:
                    print(f"[DEBUG] Scan #{scan_count}: pcap quá nhỏ ({fsize} bytes)")
                continue
            
            scan_count += 1
            print(f"[DEBUG] Scan #{scan_count}: pcap={fsize} bytes, parsing...")
                
            try:
                last_shop = None
                packets = []
                for try_port in [port, 443, 80, 8080]:
                    packets = parse_pcap_recv(PCAP_LOC, try_port)
                    if packets:
                        print(f"[DEBUG] Found {len(packets)} packets on port {try_port}")
                        break
                
                if not packets:
                    print(f"[DEBUG] Không tìm thấy packets! Thử re-detect port...")
                    new_port = get_game_port()
                    if new_port != port:
                        print(f"[DEBUG] Port đổi: {port} → {new_port}")
                        port = new_port
                    continue
                
                shop_count = 0
                for opcode, body in packets:
                    if opcode == 205:
                        shop = parse_shop_items(body)
                        last_shop = shop
                        shop_count += 1
                print(f"[DEBUG] Tìm thấy {shop_count} shop packets (opcode 205)")
                
                if not last_shop:
                    continue
                    
                # Delete local pcap and reset remote
                try: os.remove(PCAP_LOC)
                except: pass
                subprocess.run([ADB, '-s', DEVICE_ID, 'shell', f'su -c "> {PCAP_DEV}"'],
                               capture_output=True)
                
                shop_items = last_shop.get('items', [])
                
                # owner from shop packet field 1
                owner = last_shop.get('owner_id', '?')
                    
                print("\n" + "="*80)
                print(f"[+] SHOP CỦA {owner.upper()} ({len(shop_items)} VẬT PHẨM):")
                print(f"{'#':<4}| {'Tên Vật Phẩm':<28} | {'Giá':<10} | {'Loại'}")
                print("-" * 60)
                
                for idx, it in enumerate(shop_items, 1):
                    slot = it.get('slot', 0)
                    inner = it.get('inner', {})
                    f1_p = inner.get('f1_proto', {})
                    
                    item_id = f1_p.get('n2', 'Unknown')
                    tpl_id = f1_p.get('n4', '?')
                    
                    # Price: f2 = Vạn (silver), f3 = KNB (gold)
                    price_van = inner.get('f2')
                    price_knb = inner.get('f3')
                    if price_knb and isinstance(price_knb, int) and price_knb > 0:
                        price_str = f"{price_knb} KNB"
                    elif price_van and isinstance(price_van, int):
                        if price_van >= 10000: price_str = f"{price_van//10000} Vạn"
                        else: price_str = f"{price_van}"
                    else: price_str = '?'
                    
                    n3 = f1_p.get('n3', 0)
                    n11_h = f1_p.get('n11_h')
                    name = get_item_name(n3, tpl_id)

                    # Detail type label
                    DETAIL_NAMES = {0:'Vũ khí',1:'Ám khí',2:'Áo',3:'Nhẫn',4:'Dây chuyền',
                                    5:'Giày',6:'Thắt lưng',7:'Mũ',8:'Bao tay',9:'Ngọc bội'}
                    detail = n3 // 10000 if n3 else 0
                    dtype = DETAIL_NAMES.get(detail, '?')

                    print(f"{idx:<4}| {name:<28} | {price_str:<10} | {dtype}")
                    
                    if n11_h:
                        try:
                            data_bytes = bytes.fromhex(n11_h)
                            p = 0
                            magic_list = []
                            while p < len(data_bytes):
                                val, p = read_varint(data_bytes, p)
                                m_val = val // 1000
                                m_id = val % 1000
                                
                                name_str = MAGIC_MAP.get(m_id, f"ID {m_id}")
                                magic_list.append(f"{name_str} +{m_val}")
                            if magic_list: print(f"      -> {', '.join(magic_list)}")
                        except:
                            pass
                
                print("=" * 80)
                
                # Restart tcpdump for clean capture (truncate can corrupt pcap header)
                subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
                subprocess.run([ADB, '-s', DEVICE_ID, 'shell', f'su -c "rm {PCAP_DEV} 2>/dev/null"'], capture_output=True)
                cmd = [ADB, '-s', DEVICE_ID, 'shell', f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {port} 2>/dev/null"']
                proc = subprocess.Popen(cmd, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
                print("[*] tcpdump restarted. Mở shop tiếp theo...")
                
            except Exception as e:
                print(f"[DEBUG] Error: {e}")
    except KeyboardInterrupt:
        print("\n[*] Đã đóng Scanner.")
    finally:
        subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)

if __name__ == '__main__':
    run()
