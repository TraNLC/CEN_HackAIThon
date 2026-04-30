# VLTK1 Item Mapping Protocol

## Tổng quan

Hệ thống item trong VLTK1 Mobile sử dụng cấu trúc **Genre → Detail → Particular → Level** để định danh mỗi vật phẩm. Trong giao thức mạng (protobuf), thông tin này được mã hóa qua 2 field chính:

### Protocol Fields

| Field | Ý nghĩa | Công thức |
|-------|---------|-----------|
| `n3`  | **Detail** (loại trang bị) | `detail = n3 // 10000` |
| `n4`  | **Template ID** (particular + level) | `n4 = particular * 10000 + level` |

### Các field phụ

| Field | Ý nghĩa |
|-------|---------|
| `n1`  | Vị trí slot (slot × 10000) |
| `n2`  | Instance ID (không unique giữa các file) |
| `n5`  | Quality / Phẩm chất (10000-10004 = 0-4 sao) |
| `n6`  | Giá trị / Durability |
| `n7`  | Timestamp (Unix) |
| `n9_s`| Tên thợ rèn (string) |
| `n11_h`| Magic attributes (binary, encoded as varints) |

---

## Detail Mapping (n3)

| n3 | Detail | Loại trang bị | File dữ liệu | Số particular |
|----|--------|--------------|---------------|---------------|
| 0 | 0 | Vũ khí cận chiến | `meleeweapon.txt` | 6 (kiếm/đao/bổng/kích/chùy/trãm) |
| 10000 | 1 | Ám khí (tầm xa) | `rangeweapon.txt` | 3 (tiêu/phi đao/tên) |
| 20000 | 2 | Áo / Giáp | `armor.txt` | 29 |
| 30000 | 3 | Nhẫn | `ring.txt` | 1 |
| 40000 | 4 | Dây chuyền | `amulet.txt` | 2 |
| 50000 | 5 | Giày | `boot.txt` | 4 |
| 60000 | 6 | Thắt lưng | `belt.txt` | 2 |
| 70000 | 7 | Mũ / Nón | `helm.txt` | 14 |
| 80000 | 8 | Bao tay | `cuff.txt` | 2 |
| 90000 | 9 | Ngọc bội | `pendant.txt` | 2 |

> [!NOTE]
> Vũ khí (detail=0) có `n3=0` (hoặc absent). Khi `n3` không có trong packet, mặc định `detail=0`.

---

## Template ID (n4)

```
n4 = particular * 10000 + level
```

- **particular**: Mã phân loại con (column 3 trong file data)
- **level**: Cấp vật phẩm (1-10)

### Ví dụ melee weapon (detail=0):

| Particular | Loại vũ khí | n4 range | Ví dụ |
|-----------|------------|----------|-------|
| 0 | Kiếm | 1-10 | Huyền Thiết Kiếm (n4=10) |
| 1 | Đao | 10001-10010 | Đại Phong Đao (n4=10010) |
| 2 | Bổng | 20001-20010 | Kim Cô Bổng (n4=20010) |
| 3 | Kích/Thương | 30001-30010 | Phá Thiên Kích (n4=30010) |
| 4 | Chùy | 40001-40010 | Phá Thiên chùy (n4=40010) |
| 5 | Trãm/Song đao | 50001-50010 | Thôn Nhật Trãm (n4=50010) |

---

## Item Lookup

```python
from core.item_lookup import ItemLookup

items = ItemLookup('data/game_raw/settings/item')
name = items.get_name(n3=70000, n4=10)   # → "Tỳ Lô mão"
name = items.get_name(n3=0, n4=20010)    # → "Kim Cô Bổng"
```

> [!IMPORTANT]
> `n4` trùng lặp giữa các file! `n4=10` tồn tại trong TẤT CẢ 10 file.
> **Phải dùng `n3` (detail)** để phân biệt chính xác.

---

## Magic Attributes (n11_h)

Thuộc tính ẩn được mã hóa dưới dạng chuỗi varint trong `n11_h`:

```python
# Mỗi varint value: 
m_val = value // 1000   # Giá trị thuộc tính  
m_id  = value % 1000    # ID thuộc tính (tra bảng magicdesc.txt)
```

### Magic ID Offset (magicdesc.txt)

| Row range | Offset | Game ID range |
|-----------|--------|---------------|
| 1-10 | skip | metadata |
| 11-65 | +15 | 26-80 |
| 66+ | +22 | 88+ |

> [!WARNING]
> IDs 81-87 là reserved/gap, không có trong magicdesc.txt.

```python
from core.magic_lookup import MagicLookup

magic = MagicLookup('data/game_raw/settings/magicdesc.txt')
attrs = magic.parse_attrs(n11_h_hex)
# → [('Sinh lực tối đa', 109), ('Kháng hỏa', 10), ...]
```

---

## Shop Packet (Opcode 205)

```
Opcode 205 Response:
├── field 1 (string): owner_id
└── field 3 (repeated): shop_item
    ├── field 1 (varint): slot
    └── field 2 (bytes): inner_item_data
        ├── f1_proto: item info
        │   ├── n1: slot position
        │   ├── n2: instance ID
        │   ├── n3: detail × 10000          ← KEY
        │   ├── n4: particular × 10000 + level  ← KEY
        │   ├── n5: quality (10000-10004)
        │   ├── n6: value/durability
        │   ├── n7: timestamp
        │   ├── n9_s: crafter name
        │   └── n11_h: magic attributes (hex)
        ├── f2: price_silver (Vạn)
        └── f3: price_gold (KNB)
```

---

## Data Files

Tất cả nằm trong `data/game_raw/settings/item/`:

| File | Encoding | Format |
|------|----------|--------|
| `*.txt` | UTF-16LE | Tab-separated, 46+ columns |

| Column | Nội dung |
|--------|---------|
| 0 | Tên vật phẩm |
| 1 | Genre (luôn = 0 cho equipment) |
| 2 | Detail (0-9) |
| 3 | Particular (sub-type) |

Mỗi particular chứa đúng **10 items** (level 1-10).

---

## Shop Scanner (Continuous)

```python
from core.shop_scanner import ShopScanner

scanner = ShopScanner(
    item_dir='data/game_raw/settings/item',
    magic_path='data/game_raw/settings/magicdesc.txt'
)

# Option 1: Default print to stdout
scanner.run(debug=True)

# Option 2: Custom callback
def on_shop(shop):
    for item in shop['items']:
        if item['price_unit'] == 'KNB' and item['price_value'] <= 50:
            print(f"DEAL: {item['name']} - {item['price']} ({item['type']})")

scanner.run(callback=on_shop)
```

### Shop data format (callback argument):

```python
{
    'owner': 'player_name',
    'count': 15,
    'items': [
        {
            'slot': 1,
            'name': 'Kim Cô Bổng',
            'type': 'Vũ khí',
            'detail': 0,
            'n3': 0, 'n4': 20010, 'n5': 10002,
            'price': '100 KNB',
            'price_value': 100,
            'price_unit': 'KNB',
            'attrs': [('Né tránh', 10), ('Băng sát - ngoại công', 65)],
            'attrs_str': 'Né tránh +10, Băng sát - ngoại công +65',
        },
        ...
    ]
}
```

---

## Core Modules

| Module | Class | Mô tả |
|--------|-------|-------|
| `core/item_lookup.py` | `ItemLookup` | Tra tên item từ (n3, n4) |
| `core/magic_lookup.py` | `MagicLookup` | Tra tên thuộc tính magic |
| `core/shop_scanner.py` | `ShopScanner` | Quét shop liên tục qua tcpdump |
| `core/injector.py` | - | Inject packet qua Frida |
