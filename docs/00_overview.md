# VLTK1 Bot Toolkit — Tổng Quan

## Mục tiêu

Build bot tự động làm nhiệm vụ **Dã Tẩu** cho VLTK1 Android (bản convert từ PC).  
Không dùng OCR — giao tiếp qua **ADB tap** + **passive network sniffing** (tcpdump).

## Kiến trúc tổng thể

```
LDPlayer (emulator)
  └── VLTK1 process
        ├── Game UI  ← ADB tap (numpad, NPC, buttons)
        └── TCP socket ← tcpdump bắt packets (passive)
                │
        [opcode 9: position]
        [opcode 34: NPC dialog / quest]
        [opcode 54: quest tracker]
                │
        Python bot
        ├── core/movement.py    ← di chuyển (numpad)
        ├── core/position.py    ← đọc vị trí (tcpdump)
        ├── core/quest.py       ← đọc nhiệm vụ (protocol)
        └── features/bot/       ← logic bot chính
```

## Tài liệu

```
Bước 1  → docs/01_setup_frida.md        Setup Frida + LDPlayer
Bước 2  → docs/02_capture.md            Hook và capture packets
Bước 3  → docs/03_analysis.md           Phân tích tìm opcodes
Bước 4  → docs/04_bot.md                Bot framework
Bước 5  → docs/05_resources_52pojie.md   Tài nguyên cộng đồng
Bước 6  → docs/06_item_mapping.md       Item database
Bước 7  → docs/07_coordinate_system.md  Hệ tọa độ & position detection
Bước 8  → docs/08_movement.md           Di chuyển (numpad navigation)
Bước 9  → docs/09_quest.md              Đọc nhiệm vụ Dã Tẩu
```

## Opcodes đã RE

| Opcode | Direction | Tên | Mô tả |
|--------|-----------|-----|-------|
| 9 | S→C | Entity Sync | Vị trí entities (world coords) |
| 34 | S→C | NPC Dialog | Text dialog NPC + buttons |
| 54 | S→C | Quest Tracker | Quest data (item, coords, number) |
| 133 | S→C | Chat Message | Chat kênh công cộng |
| 170 | S→C | Player List | Danh sách player gần |
| 205 | S→C | Shop Data | Thông tin cửa hàng |
| 248 | C→S | GotoPosition | Request di chuyển (mapx, mapy) |
| 251 | S→C | Ping/Heartbeat | Keep-alive |

## Cấu trúc thư mục

```
vltk1-re/
├── core/                    # Module lõi
│   ├── movement.py          # Di chuyển (numpad + tcpdump)
│   ├── position.py          # Đọc vị trí (opcode 9)
│   └── quest.py             # Đọc quest (opcode 34/54)
│
├── features/bot/
│   └── game_bot.py          # Bot framework (Frida + ADB)
│
├── frida/
│   ├── hook_socket.js       # Hook libc send/recv
│   └── capture.py           # Frida capture controller
│
├── analysis/
│   ├── packet_parser.py     # Parse binary packets
│   └── correlate.py         # So sánh sessions
│
├── data/
│   ├── game_raw/            # APK extracted + game settings
│   │   ├── settings/        # Item, NPC, skill data
│   │   │   ├── item/        # Equipment databases
│   │   │   ├── npcs.txt     # NPC definitions
│   │   │   └── skills.txt   # Skill definitions
│   │   └── scripts/         # Lua scripts
│   └── output/              # Captured pcap files
│
├── tests/
│   ├── test_movement.py     # Test di chuyển
│   ├── test_quest.py        # Test đọc quest
│   └── test_open_shop.py    # pcap parser + shop
│
└── docs/                    # Tài liệu này
```

## Công nghệ sử dụng

| Layer | Công cụ | Mục đích |
|-------|---------|----------|
| Position detection | tcpdump + pcap parse | Bắt opcode 9, đọc world coords |
| Movement | ADB tap (numpad) | Nhập tọa độ qua minimap dialog |
| Quest reading | tcpdump + protobuf parse | Bắt opcode 34/54, đọc quest |
| Emulator control | ADB shell | Tap, screencap, netstat |
| Instrumentation | Frida (backup) | Hook socket cho realtime data |
| Emulator | LDPlayer | Android emulator + root |

## Nguyên tắc thiết kế

| Nguyên tắc | Lý do |
|---|---|
| **Không OCR** | Không phụ thuộc giao diện, ổn định lâu dài |
| **Passive sniffing** | tcpdump ở kernel, không xâm lấn game process |
| **ADB tap** | Dùng flow client hợp lệ, server validate |
| **Server-side aware** | Pathfinding + quest logic ở server, không decode trực tiếp |
| **Multi-instance ready** | Mỗi instance dùng device_id riêng |
