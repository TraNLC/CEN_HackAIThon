import sys, os, json, csv, io, re, sqlite3
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

SETTINGS_DIR = Path('data/game_raw/settings')
OUTPUT_DB = Path('data/output/vltk1.db')

TCVN3_MAP = {
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
    0xEE: 'ợ', 0xEA: 'ờ', 0xA7: 'Đ', 0xD6: 'ệ', 0xFD: 'ý', 0xF1: 'ủ',
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
    0xD5: 'ế', 0xC9: 'ẫ', 0xE8: 'ố',
}

def tcvn3_decode(raw_bytes):
    result = []
    for b in raw_bytes:
        if b < 0x80:
            result.append(chr(b))
        elif b in TCVN3_MAP:
            result.append(TCVN3_MAP[b])
        else:
            result.append(f'\ufffd')
    return ''.join(result)

def read_file(filepath):
    raw = open(filepath, 'rb').read()
    if raw[:2] == b'\xff\xfe':
        return raw.decode('utf-16-le', errors='replace')
    else:
        return tcvn3_decode(raw)

def parse_maplist(filepath):
    raw = open(filepath, 'rb').read()
    maps = {}
    for line in raw.split(b'\n'):
        line = line.strip().replace(b'\r', b'')
        if not line or line.startswith(b'['): continue
        try:
            key, val = line.split(b'=', 1)
            key_str = key.decode('ascii', errors='ignore')
        except: continue
        
        if '_name=' in line.decode('ascii', errors='ignore'):
            map_id = key_str.replace('_name', '')
            try:
                mid = int(map_id)
                name = tcvn3_decode(val).strip()
                if mid not in maps: maps[mid] = {}
                maps[mid]['name'] = name
            except ValueError: pass
        elif key_str.isdigit():
            mid = int(key_str)
            path = tcvn3_decode(val)
            if mid not in maps: maps[mid] = {}
            maps[mid]['path'] = path
            maps[mid]['id'] = mid
    for mid in maps: maps[mid]['id'] = mid
    return [maps[k] for k in sorted(maps.keys())]

def parse_tsv(filepath):
    text = read_file(filepath)
    lines = text.strip().split('\n')
    if not lines: return []
    headers = [h.strip() for h in lines[0].split('\t')]
    rows = []
    for line in lines[1:]:
        line = line.strip()
        if not line: continue
        cols = line.split('\t')
        row = {}
        for i, h in enumerate(headers):
            if h and i < len(cols):
                val = cols[i].strip()
                try:
                    if '.' in val: val = float(val)
                    else: val = int(val)
                except ValueError: pass
                row[h] = val
        if row: rows.append(row)
    return rows

def save_sqlite(db_conn, table_name, data):
    if not data: return
    cursor = db_conn.cursor()
    columns = list(data[0].keys())
    clean_cols = [re.sub(r'[^a-zA-Z0-9_]', '_', c) for c in columns]
    col_defs = [f'"{c}" TEXT' for c in clean_cols]
    
    cursor.execute(f'DROP TABLE IF EXISTS "{table_name}"')
    cursor.execute(f'CREATE TABLE "{table_name}" ({", ".join(col_defs)})')
    
    placeholders = ', '.join(['?'] * len(clean_cols))
    cols_joined = ", ".join(['"' + c + '"' for c in clean_cols])
    insert_sql = f'INSERT INTO "{table_name}" ({cols_joined}) VALUES ({placeholders})'
    
    insert_data = []
    for row in data:
        insert_data.append(tuple(str(row.get(c, '')) for c in columns))
        
    cursor.executemany(insert_sql, insert_data)
    db_conn.commit()
    print(f"  ✓ {table_name}: {len(data)} rows")

def main():
    os.makedirs(OUTPUT_DB.parent, exist_ok=True)
    if OUTPUT_DB.exists():
        OUTPUT_DB.unlink()
        
    conn = sqlite3.connect(OUTPUT_DB)
    print("Parsing to SQLite:", OUTPUT_DB)
    
    f = SETTINGS_DIR / 'maplist.ini'
    if f.exists():
        data = parse_maplist(f)
        save_sqlite(conn, 'maplist', data)
        
    for txt_file in ['npcs.txt', 'skills.txt', 'objdata.txt', 'state.txt', 'magicdesc.txt', 'missles.txt']:
        f = SETTINGS_DIR / txt_file
        if f.exists():
            data = parse_tsv(f)
            save_sqlite(conn, txt_file.replace('.txt', ''), data)
            
    item_dir = SETTINGS_DIR / 'item'
    if item_dir.exists():
        for item_file in sorted(item_dir.glob('*.txt')):
            data = parse_tsv(item_file)
            save_sqlite(conn, f"item_{item_file.stem}", data)
            
    conn.close()
    print("HOÀN TẤT SQLite DB!")

if __name__ == '__main__':
    main()
