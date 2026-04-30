import codecs
import sys
sys.stdout.reconfigure(encoding='utf-8')

def test_magic():
    # Load magicdesc.txt - this has clean ID -> description mapping
    lines = codecs.open(r'e:\tool\sample-test\vltk1-re\data\game_raw\settings\magicdesc.txt', 'r', 'utf-16le').read().splitlines()
    
    magicdesc = {}
    for i, line in enumerate(lines):
        if i == 0: continue  # header
        parts = line.split('\t')
        if len(parts) >= 3:
            prop_kind = parts[0].strip()
            desc = parts[2].strip() if parts[2].strip() else prop_kind
            magicdesc[i] = (prop_kind, desc)
    
    # Known confirmed mappings (game_id -> magicdesc_id):
    # Ring confirmed: 63->48, 65->50, 70->55, 79->64, 88->66
    # Slot 11 confirmed: 75->60, 78->63, 89->67
    confirmed = {
        63: 48,  # nội_lực_tối_đa
        65: 50,  # thể_lực_tối_đa
        70: 55,  # phục_hồi_thể_lực
        75: 60,  # chuyển_hóa_sát_thương
        78: 63,  # kháng_băng
        79: 64,  # kháng_hỏa
        88: 66,  # thời_gian_choáng
        89: 67,  # thời_gian_trúng_độc
    }
    
    print("=== CONFIRMED OFFSETS ===")
    for game_id, desc_id in sorted(confirmed.items()):
        offset = game_id - desc_id
        print(f"Game {game_id} -> Desc {desc_id} (offset +{offset}): {magicdesc.get(desc_id, ('?','?'))[0]}")
    
    # Build full map using offset +15 for desc IDs <= 65, +22 for desc IDs >= 66
    print("\n=== FULL PROPOSED MAP (offset +15 for <=65, +22 for >=66) ===")
    full_map = {}
    for desc_id, (prop, desc) in sorted(magicdesc.items()):
        if desc_id <= 65:
            game_id = desc_id + 15
        else:
            game_id = desc_id + 22
        full_map[game_id] = desc
        print(f"Game ID {game_id:3d} = {prop} => {desc}")
    
    print(f"\nTotal entries: {len(full_map)}")

if __name__ == '__main__':
    test_magic()
