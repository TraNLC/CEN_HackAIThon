import sys
from test_open_shop import parse_pcap_recv, parse_shop_items

def run():
    PCAP_LOC = r'e:\tool\sample-test\vltk1-re\data\output\open_shop.pcap'
    port = 443
    print("\n[*] Parsing existing PCAP only...")
    try:
        packets = parse_pcap_recv(PCAP_LOC, port)
    except Exception as e:
        print(f"Error parsing PCAP: {e}")
        return

    shop_count = 0
    for opcode, body in packets:
        if opcode != 205: continue
        shop_count += 1
        shop = parse_shop_items(body)
        shop_items = shop.get('items', [])

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
            price = it.get('f3_u32') or it.get('f3') or '?'
            
            inner = it.get('inner', {})
            f1_p = inner.get('f1_proto', {})
            
            item_id = f1_p.get('n2', 'Unknown')
            amount = f1_p.get('n3', 1)
            if amount >= 10000:
                amount = 1
                
            tpl_id = f1_p.get('n4', '?')
            name = ITEM_NAMES.get(item_id, f"Vật phẩm {item_id}")
            
            if isinstance(price, int):
                if price >= 10000: price_str = f"{price//10000} vạn"
                else: price_str = str(price)
            else: price_str = str(price)

            print(f"{slot:<6} | {name:<30} | {item_id:<10} | {tpl_id:<10} | {price_str:<15} | {amount:<6}")
        print("-" * 85)

    print(f"\n{'─'*62}")
    print(f"  Parsed {shop_count} shops")
    print(f"{'─'*62}")

if __name__ == '__main__':
    run()
