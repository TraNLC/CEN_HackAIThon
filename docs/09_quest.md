# Đọc Nhiệm Vụ Dã Tẩu — Knowhow

## Tổng quan

Đọc nội dung nhiệm vụ Dã Tẩu **100% protocol**, không dùng OCR.
Server gửi quest data qua 2 opcode:

| Opcode | Khi nào gửi | Nội dung |
|---|---|---|
| **34** | Tap NPC Dã Tẩu | Text quest đầy đủ + nút dialog |
| **54** | Nhận NV mới / quest tracker | Item name, quest ID, NPC coords |

## Opcode 34 — NPC Dialog

Gửi khi player tap vào NPC Dã Tẩu. Protobuf structure:

```
field 1 (string): Dialog text (có color tags)
field 2 (repeated string): Button labels
```

### Ví dụ

```
f1_s = "Nhiệm vụ thứ 179. Hãy đi tìm cho ta <color=#ffff00>1</color> 
        cái <color=#ffff00>Dây Chuyền</color> hệ <color=#03A9F4>Thủy</color>. 
        Hôm nay còn 30 nhiệm vụ để hoàn thành."

f2_s = "Đã hoàn thành nv"
f2_s = "Ta muốn hủy nv"
f2_s = "Biết rồi!"
```

### Parse result

```
Quest #179
Item: 1x Dây Chuyền
Element: Thủy
Remaining: 30
Buttons: ['Đã hoàn thành nv', 'Ta muốn hủy nv', 'Biết rồi!']
```

## Opcode 54 — Quest Tracker

Gửi khi nhận nhiệm vụ mới hoặc khi login. Protobuf structure:

```
field 1 (string):  Quest ID (e.g. "188251")
field 2 (varint):  Quest number (thứ X)
field 4 (varint):  NPC world X coord
field 5 (varint):  NPC world Y coord
field 7 (string):  Item name (e.g. "Cửu Tiết Xương Vĩ Ngoa")
field 8 (varint):  Item count
field 9 (varint):  Unknown
field 10 (varint): Unknown
field 11 (varint): Element code (mapping chưa hoàn thiện)
```

### Ví dụ

```
Quest #26: 1x Cửu Tiết Xương Vĩ Ngoa @ (215, 194)
  quest_id = 188251
  npc_world = (55106, 49726) → game = (215, 194)
  element_code = 7
```

> [!NOTE]
> Opcode 54 chứa **tọa độ NPC** (world coords) — dùng để navigate đến NPC.
> Element mapping chưa đầy đủ, cần capture nhiều quest để xác nhận.

## Vị trí NPC Dã Tẩu

NPC Dã Tẩu ở **Biện Kinh**, screen position khoảng `(430, 75)` khi nhân vật đứng gần.

> [!IMPORTANT]
> Phải đứng gần NPC mới thấy tên "Dã Tẩu" trên screen. Tap vào text tên NPC để mở dialog.

## Dữ liệu Game Raw

Tìm trong `data/game_raw/settings/`:

| File | Nội dung Dã Tẩu |
|---|---|
| `item/magicscript.txt` | **ID=33** Dã Tẩu Hoàn Thành Lệnh, **ID=79** Dã Tẩu Tủy Kinh, **ID=80** Dã Tẩu Mật Tịch |
| `skills.txt` | Boss skills: ID=753 choáng, ID=754 giật lùi, ID=755 làm chậm |
| `item/amulet.txt` | Dây chuyền (quest item) |
| `item/boot.txt` | Giày (quest item, e.g. Cửu Tiết Xương Vĩ Ngoa) |

> [!NOTE]
> **Quest logic hoàn toàn server-side.** Client không có bảng nhiệm vụ — chỉ nhận qua opcode 34/54.
> NPC giao nhiệm vụ cũng không có trong `npcs.txt` — được spawn dynamically.

## Module

```
core/quest.py
├── QuestInfo              # Dataclass chứa quest data
├── parse_opcode34()       # Parse NPC dialog
├── parse_opcode54()       # Parse quest tracker
├── strip_color_tags()     # Remove <color> tags
└── QuestReader            # High-level reader class
    ├── read_current_quest()   # Capture + parse
    └── dismiss_dialog()       # Đóng dialog NPC
```

## Sử dụng

### CLI Test
```bash
# Parse từ pcap đã capture
python tests/test_quest.py

# Capture mới (passive)
python tests/test_quest.py --capture

# Tap NPC rồi đọc quest
python tests/test_quest.py --npc 430 75
```

### Trong code
```python
from core.quest import QuestReader

reader = QuestReader()
quest = reader.read_current_quest(npc_tap=(430, 75))

if quest and quest.is_valid:
    print(f"Tìm {quest.item_count}x {quest.item_name} hệ {quest.element}")
    print(f"Quest #{quest.quest_number}, còn {quest.remaining} NV")
    # NPC coords (nếu từ opcode 54)
    if quest.npc_world_x > 0:
        gx, gy = quest.npc_game_coords
        print(f"NPC tại ({gx}, {gy})")
```

## Lịch sử

| Ngày | Thay đổi |
|---|---|
| 30/04 | Phát hiện opcode 34 (NPC dialog) chứa quest text |
| 30/04 | Phát hiện opcode 54 (quest tracker) chứa item name + NPC coords |
| 30/04 | Tạo module `core/quest.py` với parser cho cả 2 opcode |
| 30/04 | Scan `data/game_raw` — tìm items Dã Tẩu, confirm quest logic server-side |
