# Bước 3 — Phân Tích Tìm Opcodes

## Tools phân tích

| Tool | File | Mục đích |
|------|------|---------|
| `packet_parser.py` | `analysis/` | Parse binary → bảng opcode |
| `correlate.py` | `analysis/` | Lọc fake packets, tìm opcode thật |
| `detect_engine.py` | `analysis/` | Phân tích APK trước khi hook |
| `opcode_db.yaml` | `data/` | Database tham khảo cross-game |

---

## detect_engine.py — Phân Tích APK

**Chạy trước tiên** để biết dùng hook script nào.

```bash
# Pull APK từ emulator và phân tích
python analysis/detect_engine.py --serial 127.0.0.1:5555 --package vn.vinagame.vltk1

# Hoặc nếu đã có APK file
python analysis/detect_engine.py --apk base.apk
```

**Output mẫu:**
```
══════════════════════════════════════════════
  APK: base.apk
══════════════════════════════════════════════
  Engine:        Custom C++ Engine
  Language:      C++

  .so files tìm thấy:
    libgame.so
    libcrypto.so

  Hook approach khuyến nghị:
    ✓ Frida hook libc send/recv (layer thấp nhất)
    ✓ IDA Pro / Ghidra để RE native functions
    ⚠ unidbg nếu cần gọi hàm encrypt từ PC
══════════════════════════════════════════════
```

**Engines và cách hook tương ứng:**

| Engine | Detect dấu hiệu | Hook approach |
|--------|-----------------|---------------|
| Unity Mono | `libmono.so` | Frida Java.perform() |
| Unity IL2CPP | `libil2cpp.so` | Il2CppDumper + Frida native |
| Cocos2d-x | `libcocos2dcpp.so` | Frida hook native .so |
| Custom C++ | 1 .so lớn, tên custom | hook_socket.js (libc) |
| Java only | Không có .so | hook_java.js + jadx |

---

## packet_parser.py — Parse Binary Captures

### Auto-detect format

```bash
# Không biết format → thử tự động
python analysis/packet_parser.py captures/send_xxx.bin --detect-format
```

Output:
```
Detecting packet format...
  Format A:    24 packets, coverage=98.2%, score=23.6
  Format B:    19 packets, coverage=78.1%, score=14.8
  Format A_LE:  3 packets, coverage=12.0%, score=0.4

Best format: A
```

### Xem danh sách opcodes (summary)

```bash
# Tự động cross-reference với opcode_db.yaml
python analysis/packet_parser.py captures/send_xxx.bin --summary

# Chỉ định DB file rõ ràng
python analysis/packet_parser.py captures/send_xxx.bin --summary --db data/opcode_db.yaml
```

Output:
```
Loading opcode DB: data/opcode_db.yaml
  47 opcodes loaded from DB

Parsed 68 packets with format A

Opcode       Hex      Count   AvgPld  Suggested Name
────────────────────────────────────────────────────────────
1            0x0001       1     42.0  LOGIN_REQUEST
5            0x0005      12      4.0  HEARTBEAT
257          0x0101       8      4.0  ~MOVE_DIR?
513          0x0201       1      4.0  TALK_NPC
```

- **Tên không có ~** = exact match (opcode số khớp với DB)
- **Tên có ~?** = fuzzy match (cùng category, gần nhau về số)

### Xem từng packet

```bash
# In tất cả packets
python analysis/packet_parser.py captures/send_xxx.bin --direction SEND

# Lọc 1 opcode cụ thể + xem payload hex dump
python analysis/packet_parser.py captures/send_xxx.bin --opcode 0x0201 --payload
```

### 6 Format header hỗ trợ

| Format | Header | Endian | Ghi chú |
|--------|--------|--------|---------|
| A | `[2B len][2B op]` len=total | Big | **Snail engine (VLTK)** |
| B | `[2B len][2B op]` len=payload | Big | Biến thể |
| C | `[4B len][2B op]` len=total | Big | Game dùng 4B length |
| D | `[2B op][2B len]` | Big | Opcode trước length |
| A_LE | `[2B len][2B op]` | Little | Cocos2d-x thường dùng |
| B_LE | `[2B len][2B op]` | Little | Biến thể little-endian |

---

## correlate.py — Lọc Fake Packets

Game cố ý inject packet giả để gây khó RE. Tool này so sánh nhiều sessions để tìm opcode thật.

### Method 1: So sánh nhiều sessions

Capture 3+ sessions, mỗi session làm **cùng 1 hành động**:

```bash
python analysis/correlate.py \
  --sessions captures/send_s1.bin captures/send_s2.bin captures/send_s3.bin \
  --action "LOGIN"
```

**Logic:** Opcode xuất hiện trong **tất cả** sessions → thật.  
Opcode chỉ xuất hiện 1 session → candidate fake.

### Method 2: Baseline diff

```bash
# Session baseline: chỉ login, đứng yên không làm gì
# Session action: login + làm đúng 1 hành động (vd: nhận nhiệm vụ)

python analysis/correlate.py \
  --baseline captures/send_baseline.bin \
  --action-file captures/send_with_quest.bin \
  --action "ACCEPT_QUEST"
```

**Logic:** Opcodes có trong action nhưng không có (hoặc ít hơn) trong baseline  
→ Đây là packet của action đó.

**Output:**
```
  Opcodes mới xuất hiện khi làm action 'ACCEPT_QUEST':

  Opcode     Hex      Baseline   Action  Delta
  ────────────────────────────────────────────────
  513        0x0201          0        1      1  ← NEW
  514        0x0202          0        1      1  ← NEW
```

---

## opcode_db.yaml — Database Tham Khảo

File: `data/opcode_db.yaml`

Database tổng hợp opcodes từ các game cùng Snail engine (VLTK, Thiên Long Bát Bộ, Đại Đường Vô Song).

**Cách dùng:**
- `packet_parser.py` tự động load khi chạy (không cần flag)
- Nếu opcode của game match → gợi ý tên ngay trong output
- Dùng làm reference khi RE tay

**Snail engine C2S opcodes đã biết:**

| Range | Category |
|-------|---------|
| 0x0001–0x0005 | Auth (Login, Select Char, Enter World, Logout, Heartbeat) |
| 0x0101–0x0105 | Movement (Move To, Move Dir, Auto Path, Stop) |
| 0x0201–0x0206 | NPC / Quest (Talk, Dialog, Accept, Submit, Abandon) |
| 0x0301–0x0305 | Combat (Attack, Use Skill, Stop Attack, Pick Item, Auto Fight) |
| 0x0401–0x0403 | Inventory (Use, Drop, Equip) |

**Snail engine S2C opcodes đã biết:**

| Range | Category |
|-------|---------|
| 0x1001–0x1005 | Auth responses (Login OK, Char List, Enter World OK) |
| 0x1101–0x1104 | World (Player Move, Spawn, Despawn, Position Sync) |
| 0x1201–0x1206 | Quest events (Dialog Open, Accept OK, Progress, Complete) |
| 0x1301–0x1305 | Combat events (Result, Entity Dead, Item Drop, HP Update) |
| 0x1401–0x1403 | System (Server Message, Error, Kick) |

---

## opcode_map.yaml — Ghi Chú Thủ Công

File: `analysis/opcode_map.yaml`

Sau khi RE xong, ghi kết quả vào đây:

```yaml
# Opcodes đã xác nhận cho VLTK1 VN server
c2s:
  0x0001: { name: LOGIN_REQUEST, payload: "str8 username, str8 password" }
  0x0101: { name: MOVE_TO, payload: "uint16 x, uint16 y" }
  # ... thêm khi biết thêm

s2c:
  0x1001: { name: LOGIN_OK, payload: "uint8 result, uint32 session" }
  # ...
```

---

## Workflow tổng hợp

```
1. detect_engine.py → biết engine (Unity IL2CPP), chọn hook script
2. tcpdump capture → bắt packets passive
3. Parse pcap → tìm opcodes + protobuf fields
4. Xác nhận opcode bằng cách trigger action + so sánh
5. Viết parser cho từng opcode (core/position.py, core/quest.py)
6. Tích hợp vào bot (ADB tap + tcpdump verify)
```

## Opcodes đã xác nhận (VLTK1 VN)

| Opcode | Dir | Tên | Fields chính | Ghi chú |
|--------|-----|-----|-------------|---------|
| **9** | S→C | Entity Sync | `etype\|eid\|x\|y` | Vị trí entities |
| **34** | S→C | NPC Dialog | `f1=text, f2=buttons` | Quest text Dã Tẩu |
| **54** | S→C | Quest Tracker | `f1=id, f2=num, f7=item, f4/f5=coords` | Active quest |
| **133** | S→C | Chat | `f3=name, f4=message` | Chat công cộng |
| **170** | S→C | Player List | `f2=entries` | Player gần |
| **205** | S→C | Shop Data | `f1=id, f3=entries` | Cửa hàng |
| **248** | C→S | GotoPosition | `mapx, mapy` | Di chuyển |
| **251** | S→C | Heartbeat | (empty) | Keep-alive |

