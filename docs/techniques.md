# VLTK1 Mobile — Kỹ thuật Reverse Engineering & Bot

> Tài liệu lưu lại các kỹ thuật đã nghiên cứu và hoạt động thành công.

---

## 1. Môi trường

| Thành phần | Chi tiết |
|---|---|
| Emulator | Android x86 với Houdini ARM translation |
| Device ID | `emulator-5554` |
| Package | `vn.perfingame.jx1mobile` |
| Game Engine | Unity + il2cpp (ARM) |
| Protocol | TCP socket, Protobuf + pipe-separated strings |

---

## 2. Packet Format

```
[4 bytes LE: proto_len] [2 bytes LE: opcode] [proto_len bytes: protobuf body]
```

- `proto_len` = kích thước phần protobuf body (KHÔNG tính 4+2 header)
- `opcode` = mã lệnh (xem `proto/vltk1_protocol.py`)
- Ví dụ mount ngựa: `00 00 00 00 3a 00` (proto_len=0, opcode=58)

---

## 3. Gửi Packet (Client → Server) — Frida write()

### Vấn đề Houdini
- Game dùng ARM `libc.so` → Frida x86 KHÔNG thể gọi ARM `write()`
- **Giải pháp**: Tìm `write()` từ module x86 native (`app_process32`)

### Code pattern
```javascript
// Tìm write() executable từ x86 module
var nativeWrite = null;
Process.enumerateModules().forEach(function(m) {
    if (nativeWrite) return;
    try {
        var exp = m.findExportByName('write');
        if (!exp) return;
        var range = Process.findRangeByAddress(exp);
        if (range && range.protection.indexOf('x') !== -1) {
            nativeWrite = new NativeFunction(exp, 'int', ['int', 'pointer', 'int']);
        }
    } catch(e) {}
});
```

### Tìm Game Socket FD
```python
# Đọc /proc/{pid}/net/tcp → tìm ESTABLISHED connections
# Lọc port > 1000, loại trừ 5555, 5037, 27042
# Map inode → fd qua /proc/{pid}/fd symlinks
```

### Đã hoạt động
- `eSetRiding` (58) — cưỡi/xuống ngựa ✅
- `eCharacterRequest` (11) — yêu cầu server gửi character data ✅
- `eMapDialogNpcListRequest` (71) — yêu cầu danh sách NPC ✅
- `eAllMagicAttribRequest` (65) — yêu cầu thuộc tính ✅
- `ePing` (69) — keep alive ✅

---

## 4. Nhận Packet (Server → Client) — tcpdump

### Vấn đề
- Frida x86 KHÔNG hook được ARM `recv()`/`read()` (Houdini)
- `Interceptor.attach` trên ARM code trong `libil2cpp.so` cũng KHÔNG hoạt động
- `libil2cpp.so` không xuất hiện trong `Process.enumerateModules()` (ARM lib invisible)
- Tìm được base address qua `/proc/self/maps`: `0x06000000`

### Giải pháp: tcpdump ở kernel level
```python
# 1. Tìm game server port từ /proc/{pid}/net/tcp
# 2. Chạy tcpdump trên emulator
adb shell su -c "tcpdump -i any -w /data/local/tmp/cap.pcap port {port} -c 1000 &"

# 3. Pull pcap file về PC
adb pull /data/local/tmp/cap.pcap data/game_cap.pcap

# 4. Parse pcap → extract TCP payload → decode protobuf
```

### Kết hợp: Inject + Capture
1. Start tcpdump
2. Dùng Frida gửi request packets (eCharacterRequest, etc.)
3. Server buộc phải trả về data
4. Stop tcpdump, parse pcap, decode protobuf

---

## 5. Decoded Packets

### Server → Client (quan trọng)

| Opcode | Tên | Proto | Mô tả |
|--------|------|-------|--------|
| 12 | eCharacterResponse | Character | Toàn bộ thông tin nhân vật |
| 16 | eSyncPlayerItem | Item | Từng item trong hành trang |
| 17 | eSyncPlayerSkill | ? | Kỹ năng (cần decode thêm) |
| 66 | eAllMagicAttribResponse | ? | Thuộc tính chiến đấu |
| 133 | eChatMessage | ChatMessage | Chat server |
| 9 | eStringData | pipe-separated | Sync data đa dạng |
| 251 | eLiveMessage | - | Heartbeat |
| 215 | eHotkeySkillList | - | Hotkey skills |
| 227 | eHotkeyItemList | - | Hotkey items |

### eStringData Sub-types (opcode 9)
Format: `sub_type|field1|field2|...`

| Sub | Tên | Ví dụ |
|-----|------|-------|
| 4 | NPC Info | `4|3641|205|3|Ông chủ dược điếm|53937|53089|1` |
| 5 | Timer | `5|3706` |
| 23 | Damage Sync | `23|437|1562|0|0|0|0` |
| 24 | Stats Sync | `24|1228|23|-12|25|11|11|0` |

### Character Proto Fields
```
cid, account, name, sex, sect, bagarateMoney, series,
level, exp, power(SM), agility(NN), outer(SK), inside(NC),
maxLife, maxStamina, maxInner, leftProp,
armorRes, weaponRes, helmRes, horseRes,
camp, mapId, mapX, mapY,
curLife, curInner, curStamina,
storageCellMaximum, bagarateCellMaximum,
pkvalue, revivalMapId/X/Y, runSpeed, direction, ...
```

### Sect Mapping
| ID | Tên |
|----|------|
| 1 | Thiếu Lâm |
| 2 | Thiên Vương |
| 3 | Đường Môn |
| 4 | Ngũ Độc |
| 5 | Nga Mi |
| 6 | Côn Lôn |
| 7 | Thiên Nhẫn |
| 8 | Cái Bang |
| 9 | Tiêu Dao |

---

## 6. Phát hiện về Movement

> **Quan trọng**: Di chuyển tới NPC là 100% client-side!

- `eGotoNpc` (231) là **server→client** (GsMessageHandler) — KHÔNG phải client gửi
- Khi click NPC trên map: `GotoNpc()` → `GotoFindingPath()` → A* pathfinding **local**
- `ProtocolGotoPosition()` cũng gọi `GotoFindingPath()` — không gọi `SendGSMessage`
- `eSyncPlayerMove` (20) — proto chưa xác định, không có GsMessageHandler → có thể là client→server nhưng chưa decode được

---

## 7. File Structure

```
bot/
  test_detect.py    — Script chính: capture + decode game state
  test_riding.py    — Test cưỡi ngựa (hoạt động)
  frida_bot.js      — Frida injection core
  game_bot.py       — Bot controller
  state_machine.py  — State machine

proto/
  vltk1_protocol.py — Protobuf definitions + opcodes

data/
  libil2cpp.so      — Game binary (static analysis)
  game_cap.pcap     — Latest captured traffic
```
