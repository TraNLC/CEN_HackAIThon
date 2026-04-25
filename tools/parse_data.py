"""
parse_settings.py — Parse toàn bộ game settings → JSON

Đọc các file trong data/settings/ và xuất ra data/json/
Hỗ trợ 2 encoding:
  - UTF-16LE (BOM \xff\xfe) → hầu hết file .txt  
  - TCVN3 → maplist.ini

Chạy: python bot/parse_settings.py
"""
import sys, os, json, csv, io, re
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

SETTINGS_DIR = Path('data/game_raw/settings')
OUTPUT_DIR = Path('data/output/json')

# ==================== TCVN3 Decoder ====================
# Bảng mapping verified từ known map names trong game
TCVN3_MAP = {
    # Lowercase dấu
    0xB5: 'à', 0xB6: 'ả', 0xB7: 'ã', 0xB8: 'á', 0xB9: 'ạ',
    0xBA: 'ă', 0xBB: 'ằ', 0xBC: 'ẳ', 0xBD: 'ẵ', 0xBE: 'ắ', 0xBF: 'ặ',
    0xA9: 'â', 0xC1: 'ầ', 0xC2: 'ẩ', 0xC3: 'ẫ', 0xC4: 'ấ', 0xC5: 'ậ',
    0xC6: 'é', 0xC7: 'è', 0xC8: 'ẻ', 0xC9: 'ẽ', 0xCA: 'ẹ',
    0xAA: 'ê', 0xCB: 'ề', 0xCC: 'ế', 0xCD: 'ể', 0xCE: 'ễ', 0xCF: 'ệ',
    0xD0: 'í', 0xD1: 'ì', 0xD2: 'ỉ', 0xD3: 'ĩ', 0xD4: 'ị',
    0xD9: 'ó', 0xD5: 'ò', 0xD7: 'ỏ', 0xD8: 'õ', 0xDA: 'ọ',
    0xAB: 'ô', 0xDB: 'ồ', 0xDC: 'ổ', 0xDD: 'ỗ', 0xDE: 'ố', 0xDF: 'ộ',
    0xAC: 'ơ', 0xE0: 'ờ', 0xE1: 'ở', 0xE2: 'ỡ', 0xE3: 'ớ', 0xE4: 'ợ',
    0xE5: 'ú', 0xE6: 'ù', 0xE7: 'ủ', 0xE8: 'ũ', 0xE9: 'ụ',
    0xAD: 'ư', 0xAE: 'ừ', 0xAF: 'ử', 0xB0: 'ữ', 0xB1: 'ứ', 0xB2: 'ự',
    0xEF: 'ỳ', 0xF0: 'ỷ', 0xF1: 'ỹ', 0xF2: 'ý', 0xF3: 'ỵ',
    0xB4: 'đ',
    # Verified overrides from game data analysis:
    # Map 1 'Phượng Tường': 0xEE=ợ (ư+ợ+ng), 0xEA=ờ (ư+ờ+ng)  
    0xEE: 'ợ', 0xEA: 'ờ',
    # Map 11 'Thành Đô': 0xA7=Đ
    0xA7: 'Đ',
    # Map 44 'Chiến trường': 0xD5=ế -> conflict with ò, game uses ế  
    # Map 37 'Biện Kinh': 0xD6=ệ -> confirmed
    0xD6: 'ệ',
    # Map 162 'Đại Lý phủ': 0xFD=ý, 0xF1=ủ -> conflict with ỹ
    0xFD: 'ý', 0xF1: 'ủ',
    # Map 45 'Thiên Nhẫn': 0xC9=ẫ -> conflict with ẽ
    # Uppercase
    0x80: 'À', 0x81: 'Ả', 0x82: 'Ã', 0x83: 'Á', 0x84: 'Ạ',
    0x85: 'Ắ', 0x86: 'Ẳ', 0x87: 'Ẵ', 0x88: 'Ặ', 0x89: 'Đ',
    0x8A: 'É', 0x8B: 'È', 0x8C: 'Ẻ', 0x8D: 'Ẽ', 0x8E: 'Ê',
    0x8F: 'Ề', 0x90: 'Ể', 0x91: 'Ễ', 0x92: 'Ế', 0x93: 'Ệ',
    0x94: 'Í', 0x95: 'Ì', 0x96: 'Ỉ', 0x97: 'Ĩ', 0x98: 'Ị',
    0x99: 'Ó', 0x9A: 'Ò', 0x9B: 'Ỏ', 0x9C: 'Õ', 0x9D: 'Ô',
    0x9E: 'Ồ', 0x9F: 'Ổ', 0xA0: 'Ỗ', 0xA1: 'Ố', 0xA2: 'Ộ',
    0xA3: 'Ơ', 0xA4: 'Ờ', 0xA5: 'Ở', 0xA6: 'Ỡ', 0xA8: 'Ớ',
    0xB3: 'Ú', 0xEB: 'Ừ', 0xEC: 'Ử', 0xED: 'Ữ',
    0xFA: 'Ư', 0xFB: 'Ứ', 0xFC: 'Ự', 0xFE: 'Ỵ',
    0xF4: 'Ỳ', 0xF5: 'Ỷ', 0xF6: 'Ỹ', 0xF7: 'Ý', 0xF8: 'Đ', 0xF9: 'đ',
}

# Conflict resolution: game data shows 0xD5=ế (not ò), 0xC9=ẫ (not ẽ), 
# 0xE8=ố (not ũ), 0xF1=ủ (not ỹ), 0xEE=ợ, 0xEA=ờ
# These override standard TCVN3 where there are discrepancies
TCVN3_MAP[0xD5] = 'ế'
TCVN3_MAP[0xC9] = 'ẫ'
TCVN3_MAP[0xE8] = 'ố'


def tcvn3_decode(raw_bytes):
    """Decode TCVN3 bytes → Unicode string."""
    result = []
    for b in raw_bytes:
        if b < 0x80:
            result.append(chr(b))
        elif b in TCVN3_MAP:
            result.append(TCVN3_MAP[b])
        else:
            result.append(f'\ufffd')  # replacement char
    return ''.join(result)


def read_file(filepath):
    """Đọc file, tự detect encoding (UTF-16LE hoặc TCVN3)."""
    raw = open(filepath, 'rb').read()
    if raw[:2] == b'\xff\xfe':
        return raw.decode('utf-16-le', errors='replace')
    else:
        return tcvn3_decode(raw)


# ==================== Parsers ====================

def parse_maplist(filepath):
    """Parse maplist.ini → dict of maps."""
    raw = open(filepath, 'rb').read()
    maps = {}
    
    for line in raw.split(b'\n'):
        line = line.strip().replace(b'\r', b'')
        if not line or line.startswith(b'['):
            continue
        
        try:
            key, val = line.split(b'=', 1)
            key_str = key.decode('ascii', errors='ignore')
        except:
            continue
        
        # Parse theo loại key
        if '_name=' in line.decode('ascii', errors='ignore'):
            map_id = key_str.replace('_name', '')
            try:
                mid = int(map_id)
                name = tcvn3_decode(val).strip()
                if mid not in maps:
                    maps[mid] = {}
                maps[mid]['name'] = name
            except ValueError:
                pass
        elif '_MapPos=' in line.decode('ascii', errors='ignore'):
            map_id = key_str.replace('_MapPos', '')
            try:
                mid = int(map_id)
                pos = val.decode('ascii', errors='ignore')
                if mid not in maps:
                    maps[mid] = {}
                maps[mid]['pos'] = pos
            except ValueError:
                pass
        elif '_NewWorldParam=' in line.decode('ascii', errors='ignore'):
            map_id = key_str.replace('_NewWorldParam', '')
            try:
                mid = int(map_id)
                params = val.decode('ascii', errors='ignore')
                if mid not in maps:
                    maps[mid] = {}
                maps[mid]['params'] = params.split('|')
            except ValueError:
                pass
        elif '_NewWorldScript=' in line.decode('ascii', errors='ignore'):
            map_id = key_str.replace('_NewWorldScript', '')
            try:
                mid = int(map_id)
                script = val.decode('ascii', errors='ignore')
                if mid not in maps:
                    maps[mid] = {}
                maps[mid]['script'] = script
            except ValueError:
                pass
        elif key_str.isdigit():
            mid = int(key_str)
            path = tcvn3_decode(val)
            if mid not in maps:
                maps[mid] = {}
            maps[mid]['path'] = path
            maps[mid]['id'] = mid
    
    # Ensure all have id
    for mid in maps:
        maps[mid]['id'] = mid
    
    return [maps[k] for k in sorted(maps.keys())]


def parse_tsv(filepath):
    """Parse tab-separated file (UTF-16LE) → list of dicts."""
    text = read_file(filepath)
    lines = text.strip().split('\n')
    if not lines:
        return []
    
    # Header
    headers = [h.strip() for h in lines[0].split('\t')]
    rows = []
    
    for line in lines[1:]:
        line = line.strip()
        if not line:
            continue
        cols = line.split('\t')
        row = {}
        for i, h in enumerate(headers):
            if h and i < len(cols):
                val = cols[i].strip()
                # Try to convert numbers
                try:
                    if '.' in val:
                        val = float(val)
                    else:
                        val = int(val)
                except ValueError:
                    pass
                row[h] = val
        if row:
            rows.append(row)
    
    return rows


def parse_ini_file(filepath):
    """Parse generic INI file → dict."""
    text = read_file(filepath)
    result = {}
    current_section = '_default'
    
    for line in text.splitlines():
        line = line.strip()
        if not line or line.startswith(';') or line.startswith('#'):
            continue
        if line.startswith('[') and line.endswith(']'):
            current_section = line[1:-1]
            if current_section not in result:
                result[current_section] = {}
            continue
        if '=' in line:
            key, val = line.split('=', 1)
            key = key.strip()
            val = val.strip()
            try:
                if '.' in val:
                    val = float(val)
                else:
                    val = int(val)
            except ValueError:
                pass
            if current_section not in result:
                result[current_section] = {}
            result[current_section][key] = val
    
    return result


def save_json(data, output_path):
    """Save data as JSON."""
    os.makedirs(os.path.dirname(output_path), exist_ok=True)
    with open(output_path, 'w', encoding='utf-8') as f:
        json.dump(data, f, ensure_ascii=False, indent=2)
    print(f"  ✓ {output_path} ({len(str(data))//1024}KB)")


# ==================== Main ====================

def main():
    print("=" * 50)
    print("  VLTK1 Settings → JSON Converter")
    print("=" * 50)
    
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    
    # 1. maplist.ini (TCVN3)
    f = SETTINGS_DIR / 'maplist.ini'
    if f.exists():
        print(f"\n[1] Parsing maplist.ini...")
        data = parse_maplist(f)
        save_json(data, OUTPUT_DIR / 'maplist.json')
        # Quick verify
        for m in data:
            if m.get('id') in [1, 11, 37, 162, 176]:
                print(f"      Map {m['id']:>4}: {m.get('name','?')}")
    
    # 2. npcs.txt (TSV, UTF-16LE)
    f = SETTINGS_DIR / 'npcs.txt'
    if f.exists():
        print(f"\n[2] Parsing npcs.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'npcs.json')
        print(f"      {len(data)} NPCs")
    
    # 3. skills.txt
    f = SETTINGS_DIR / 'skills.txt'
    if f.exists():
        print(f"\n[3] Parsing skills.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'skills.json')
        print(f"      {len(data)} skills")
    
    # 4. objdata.txt
    f = SETTINGS_DIR / 'objdata.txt'
    if f.exists():
        print(f"\n[4] Parsing objdata.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'objdata.json')
        print(f"      {len(data)} objects")
    
    # 5. state.txt
    f = SETTINGS_DIR / 'state.txt'
    if f.exists():
        print(f"\n[5] Parsing state.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'states.json')
        print(f"      {len(data)} states")
    
    # 6. magicdesc.txt
    f = SETTINGS_DIR / 'magicdesc.txt'
    if f.exists():
        print(f"\n[6] Parsing magicdesc.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'magicdesc.json')
        print(f"      {len(data)} magic descriptions")
    
    # 7. missles.txt
    f = SETTINGS_DIR / 'missles.txt'
    if f.exists():
        print(f"\n[7] Parsing missles.txt...")
        data = parse_tsv(f)
        save_json(data, OUTPUT_DIR / 'missles.json')
        print(f"      {len(data)} missiles")
    
    # 8. item/*.txt (all item files)
    item_dir = SETTINGS_DIR / 'item'
    if item_dir.exists():
        print(f"\n[8] Parsing item/*.txt...")
        for item_file in sorted(item_dir.glob('*.txt')):
            data = parse_tsv(item_file)
            out_name = f"item_{item_file.stem}.json"
            save_json(data, OUTPUT_DIR / out_name)
            print(f"      {item_file.name}: {len(data)} items")
    
    # 9. client/*.txt and client/*.ini
    client_dir = SETTINGS_DIR / 'client'
    if client_dir.exists():
        print(f"\n[9] Parsing client/*...")
        for cf in sorted(client_dir.iterdir()):
            if cf.suffix in ['.txt', '.ini']:
                try:
                    if cf.suffix == '.ini':
                        data = parse_ini_file(cf)
                    else:
                        data = parse_tsv(cf)
                    out_name = f"client_{cf.stem}.json"
                    save_json(data, OUTPUT_DIR / out_name)
                except Exception as e:
                    print(f"      ✗ {cf.name}: {e}")
    
    # 10. player/*.txt
    player_dir = SETTINGS_DIR / 'player'
    if player_dir.exists():
        print(f"\n[10] Parsing player/*...")
        for pf in sorted(player_dir.iterdir()):
            if pf.suffix == '.txt':
                try:
                    data = parse_tsv(pf)
                    out_name = f"player_{pf.stem}.json"
                    save_json(data, OUTPUT_DIR / out_name)
                except Exception as e:
                    print(f"      ✗ {pf.name}: {e}")
    
    print(f"\n{'=' * 50}")
    print(f"  HOÀN TẤT! Output: {OUTPUT_DIR}/")
    print(f"{'=' * 50}")


if __name__ == '__main__':
    main()
