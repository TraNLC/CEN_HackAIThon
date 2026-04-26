"""
test_datau_coords.py - Đọc tất cả file map_X.json đã có sẵn,
tìm "Dã Tẩu" (và các biến thể) và xuất bảng tọa độ hoàn chỉnh.

Sau đó tự động chạy export_map.py cho các map chưa có dữ liệu
nếu đang đứng trong map đó.

Chạy:
    python tests/test_datau_coords.py
"""
import sys
import json
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = Path(__file__).parent.parent
MAP_DIR  = ROOT_DIR / 'data' / 'output' / 'maps'
FALLBACK = ROOT_DIR / 'data' / 'maps'  # export_map.py cũ lưu ở đây

# ── Tên NPC cần tìm (khớp substring, không phân biệt hoa thường) ──
TARGET_NPCS = ["Dã Tẩu", "Da Tau", "Dã Tẩu"]

# ── Tên map fallback theo ID (bổ sung dần khi đi) ──
MAP_ID_NAMES = {
    1:   "Tương Dương",
    2:   "Biện Kinh",
    3:   "Thành Đô",
    4:   "Ba Lăng Huyện",
    5:   "Lạc Dương",
    6:   "Giang Lăng",
    7:   "Thái Nguyên",
    8:   "Bảo Kê",
    9:   "Tây An",
    10:  "Ô Xương",
    11:  "Đại Đô",
    12:  "Linh Châu",
    162: "Ải Nam Quan",
}


def scan_dir(directory: Path) -> list:
    """Scan all map_X.json files in a directory, return list of results."""
    results = []
    if not directory.exists():
        return results

    for f in sorted(directory.glob('map_*.json')):
        try:
            with open(f, 'r', encoding='utf-8') as fp:
                data = json.load(fp)
        except Exception as e:
            print(f"  [!] Lỗi đọc {f.name}: {e}")
            continue

        map_id   = data.get('map_id', f.stem.replace('map_', ''))
        map_name = data.get('map_name') or MAP_ID_NAMES.get(int(map_id), f"Map_{map_id}")
        npcs     = data.get('npcs', [])

        found = []
        for npc in npcs:
            name = npc.get('name', '')
            for target in TARGET_NPCS:
                if target.lower() in name.lower():
                    found.append({
                        'name': name,
                        'game_x': npc.get('x', npc.get('mapX', 0)),
                        'game_y': npc.get('y', npc.get('mapY', 0)),
                    })
                    break  # tránh duplicate

        results.append({
            'file':     f.name,
            'map_id':   map_id,
            'map_name': map_name,
            'total_npc': len(npcs),
            'found':    found,
        })

    return results


def main():
    print("\n" + "="*60)
    print("  DA TAU COORDINATE SCANNER")
    print("="*60)

    # Gom kết quả từ cả 2 thư mục
    all_results = scan_dir(MAP_DIR) + scan_dir(FALLBACK)

    # Loại trùng map_id
    seen_ids = set()
    unique = []
    for r in all_results:
        key = str(r['map_id'])
        if key not in seen_ids:
            seen_ids.add(key)
            unique.append(r)
    all_results = sorted(unique, key=lambda x: int(str(x['map_id'])) if str(x['map_id']).isdigit() else 9999)

    if not all_results:
        print(f"\n[-] Không tìm thấy file map_X.json nào trong:")
        print(f"    {MAP_DIR}")
        print(f"    {FALLBACK}")
        print("\n[!] Chạy tools/export_map.py để xuất dữ liệu map trước!")
        return

    print(f"\n[+] Đọc {len(all_results)} file map\n")

    # ── Bảng tổng hợp Dã Tẩu ──
    datau_table = []

    for r in all_results:
        status = f"[{r['total_npc']} NPCs]"
        if r['found']:
            for npc in r['found']:
                print(f"  ✓ Map {r['map_id']:>4} | {r['map_name']:<20} | {npc['name']:<15} | Game({npc['game_x']}, {npc['game_y']})")
                datau_table.append({
                    'map_id':   r['map_id'],
                    'map_name': r['map_name'],
                    'npc_name': npc['name'],
                    'game_x':   npc['game_x'],
                    'game_y':   npc['game_y'],
                })
        else:
            print(f"  - Map {r['map_id']:>4} | {r['map_name']:<20} | (không có Dã Tẩu) {status}")

    # ── In code Python sẵn dùng cho game_bot.py ──
    if datau_table:
        print("\n" + "="*60)
        print("  COPY PASTE vào NPC_MAP_COORDS trong game_bot.py:")
        print("="*60)
        print("\n    NPC_MAP_COORDS = {")
        
        # Group by map_name
        from collections import defaultdict
        groups = defaultdict(list)
        for row in datau_table:
            groups[row['map_name']].append(row)
        
        for map_name, rows in groups.items():
            print(f'        "{map_name}": {{')
            for row in rows:
                print(f'            "Da Tau": ({row["game_x"]}, {row["game_y"]}),  # game coords (map_id={row["map_id"]})')
            print(f'        }},')
        print("    }\n")

    # ── Thông báo map chưa export ──
    missing = []
    known_ids = {str(r['map_id']) for r in all_results}
    for mid, mname in MAP_ID_NAMES.items():
        if str(mid) not in known_ids:
            missing.append((mid, mname))

    if missing:
        print("\n[!] Các map CHƯA có dữ liệu (cần đứng trong map rồi chạy export):")
        for mid, mname in missing:
            print(f"    Map {mid:>4} | {mname}")
        print("\n    => Chạy: python tools/export_map.py")


if __name__ == '__main__':
    main()
