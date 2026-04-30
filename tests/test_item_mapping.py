import json
import os
import sys
sys.stdout.reconfigure(encoding='utf-8')

def build_db():
    json_dir = r'e:\tool\sample-test\vltk1-re\data\output\json'
    items = []
    
    for filename in os.listdir(json_dir):
        if filename.startswith('item_') and filename.endswith('.json'):
            path = os.path.join(json_dir, filename)
            try:
                with open(path, 'r', encoding='utf-8') as f:
                    data = json.load(f)
                    for idx, row in enumerate(data):
                        if isinstance(row, dict):
                            keys = list(row.keys())
                            if not keys: continue
                            
                            # MagicScript has genre/detail/particular differently?
                            if 'item_magicscript' in filename:
                                name = row.get('﻿name') or row.get('name') or row.get('_name')
                                part = row.get('particular')
                                if name and part is not None:
                                    items.append((name, filename, -1, -1, int(part), idx))
                                continue
                            
                            # Standard item format
                            name = str(row.get(keys[0]))
                            
                            genre = None
                            for k in ['genre', '_1', '1']:
                                if k in row: genre = row[k]
                            
                            detail = None
                            for k in ['detail', '_2', '2']:
                                if k in row: detail = row[k]
                                
                            part = None
                            for k in ['particular', '_3', '3']:
                                if k in row: part = row[k]
                            
                            if name and genre is not None and detail is not None and part is not None:
                                try:
                                    items.append((str(name), filename, int(genre), int(detail), int(part), idx))
                                except: pass
                    print(f"Loaded {len(items) - len([x for x in items if x[1] != filename])} from {filename} (Total rows: {len(data)})")
            except Exception as e:
                print(f"Error {filename}: {e}")
    return items

import sys

def read_varint(data, pos):
    result, shift = 0, 0
    while pos < len(data):
        b = data[pos]; pos += 1
        result |= (b & 0x7F) << shift
        shift += 7
        if not (b & 0x80): break
    return result, pos

def decode_hex(h):
    data = bytes.fromhex(h)
    pos = 0
    res = []
    while pos < len(data):
        val, pos = read_varint(data, pos)
        res.append(val)
    return res

if __name__ == '__main__':
    hex_strs = [
        '999c0998b902cdbc06c97da7f605d727', # n2: 100001
        'fb17849501e9b107c87d95a5068ceb01', # n2: 2500001
        '89cb098b3ffb178ceb018d8105e475', # n2: 80001
        '888d01f44697b902fc9c01e5a80a', # n2: 2490001
        'e31fa737e1810a98b902b5c705', # n2: 500001
        'cfbf05e175fb1788eb018fb4018f3f', # n2: 200001
        '8fb102ddfb0b', # n2: 1450002
    ]
    for h in hex_strs:
        print(f"{h}: {decode_hex(h)}")

