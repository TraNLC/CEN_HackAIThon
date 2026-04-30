"""Verify correct offset: rows 11-17 should use +15 to fill the gap"""
import codecs, sys, re
sys.stdout.reconfigure(encoding='utf-8')

lines = codecs.open(r'e:\tool\sample-test\vltk1-re\data\game_raw\settings\magicdesc.txt', 'r', 'utf-16le').read().splitlines()
row_names = {}
for i, line in enumerate(lines):
    parts = line.split('\t')
    if len(parts) >= 3:
        desc = re.sub(r'<[^>]+>', '', parts[2].strip())
        name = desc.split(':')[0].strip() if ':' in desc else desc
        if not name: name = parts[0].strip()
        row_names[i] = name

# NEW theory: ALL rows 11-65 use SAME offset +15
# rows >= 66 use offset +22
# Gap between ID 80 and 88 = IDs 81-87 (7 IDs reserved)
print("=== NEW OFFSET: rows 11-65 all +15, rows 66+ +22 ===")
magic_map = {}
for row in range(11, min(75, len(lines))):
    if row <= 65:
        gid = row + 15
    else:
        gid = row + 22
    name = row_names.get(row, '?')
    magic_map[gid] = name
    print(f"  row {row:>3} → ID {gid:>3}: {name[:45]}")

# Verify known IDs:
print("\n=== VERIFY ===")
checks = {29: 'Sát thương vật lý - nội công', 31: 'Sát thương vật lý - ngoại công',
           61: 'Sinh lực tối đa', 63: 'Nội lực tối đa', 80: 'Kháng lôi',
           88: 'Thời gian choáng', 91: 'Thời gian làm chậm'}
for gid, expected in checks.items():
    actual = magic_map.get(gid, 'UNMAPPED')
    ok = '✓' if expected in actual else '✗'
    print(f"  ID {gid:>3}: {ok} expected='{expected}', got='{actual}'")
