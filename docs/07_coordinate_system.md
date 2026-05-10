# Hệ Tọa Độ VLTK1 — Knowhow

## Tổng quan

Game VLTK1 Mobile sử dụng **2 hệ tọa độ** khác nhau:

| Hệ tọa độ | Tên gọi | Số chữ số | Ví dụ | Nơi sử dụng |
|---|---|---|---|---|
| **World coords** | Tọa độ thế giới | 5 số | `(54182, 50049)` | Network protocol, opcode 9 entity sync |
| **Game/Map coords** | Tọa độ bản đồ | 3 số | `(211, 195)` | Minimap trong game, dialog tọa độ |

## Công thức quy đổi

```
Divisor = 256 (= 2^8)

game_x = world_x // 256
game_y = world_y // 256

world_x = game_x * 256          # (góc ô grid)
world_x = game_x * 256 + 128    # (tâm ô grid, chính xác hơn)
```

### Ví dụ cụ thể

| World (5 số) | Tính toán | Game (3 số) | Minimap hiện |
|---|---|---|---|
| `54182` | `54182 // 256` | `211` | `211` ✅ |
| `50049` | `50049 // 256` | `195` | `195` ✅ |

### Chiều ngược (3 số → 5 số)

```python
# Đi đến tọa độ game (211, 195)
world_x = 211 * 256 + 128  # = 54144 + 128 = 54272
world_y = 195 * 256 + 128  # = 49920 + 128 = 50048
```

> [!NOTE]
> `+128` để lấy tâm ô grid (256/2 = 128). Nếu không cộng, nhân vật sẽ đứng ở góc trên-trái của ô.

## Cách detect tọa độ nhân vật

### Phương pháp: Tap Trigger + tcpdump

```mermaid
flowchart LR
    A[ADB tap center screen] --> B[Client gửi request]
    B --> C[Server phản hồi opcode 9]
    C --> D[tcpdump bắt packet]
    D --> E[Parse world coords]
    E --> F[Chia 256 → game coords]
```

1. **Start tcpdump** trên device: `tcpdump -i any -U -w /tmp/pos.pcap port {game_port}`
2. **ADB tap** center screen `(480, 300)` → server phản hồi opcode 9
3. **Pull pcap** + parse opcode 9 → world coords `(54182, 50049)`
4. **Convert**: `game_x = 54182 // 256 = 211`

### Game port detection

```bash
# Tự động detect port qua netstat
adb shell su -c "netstat -tnp 2>/dev/null" | grep jx1mobile
# → tcp 10.0.2.15:54321  103.xx.xx.xx:45676  ESTABLISHED
# → game_port = 45676
```

### Opcode 9 (Entity Sync)

Server gửi opcode 9 mỗi khi có entity di chuyển. Protobuf fields:

```
etype|entity_id|x|y|...
```

- `etype = 1, 2`: Player entity → `x, y` = world coords
- `etype = 33`: Stall info
- `etype = 34`: Stall position

### Entity detection

Ở khu đông người, opcode 9 chứa nhiều entity. Hệ thống ưu tiên:

| Ưu tiên | Tiêu chí |
|---|---|
| 1 | Entity gần `last_known_pos` nhất |
| 2 | Entity có `world_x > 10000` (lọc entity giả) |
| 3 | Entity cuối cùng parse được |

> [!WARNING]
> Server **CHỈ GỬI** opcode 9 khi có entity **DI CHUYỂN**. Đứng yên = không có gói tin.
> **Giải pháp:** ADB tap nhẹ lên screen trước khi capture (tap trigger).

## Di chuyển nhân vật

### Numpad Navigation (phương pháp chính)

Nhập tọa độ vào dialog minimap qua ADB:

```
1. ADB tap (700, 335)     → đóng keyboard cũ
2. ADB tap (890, 120)     → mở numpad dialog
3. ADB tap xóa text cũ    → 6x tap (630, 351)
4. ADB tap từng số tọa độ → numpad buttons
5. ADB tap (265, 333)     → xác nhận
6. Chờ pathfinding         → distance_tiles × 1s
```

> [!IMPORTANT]
> **Server-side pathfinding**: Client chỉ gửi request "đi đến (x,y)", server tính đường.
> Nếu tọa độ unreachable, game hiện "Không tìm được đường đi" và không di chuyển.

### eGotoPosition (Opcode 248) — KHÔNG DÙNG

Ban đầu thử gửi packet trực tiếp:
```python
proto = encode_message_fields("GotoPosition", mapx=54272, mapy=50048)
pkt = struct.pack('<IH', len(proto), 248) + proto
```

> [!WARNING]
> Phương pháp này **không ổn định** — SSL encryption + server validation. Dùng numpad thay thế.

## Code tham khảo

```python
from core.position import (
    world_to_game,        # (54182, 50049) → (211, 195)
    game_to_world,        # (211, 195) → (54016, 49920)
    game_to_world_center, # (211, 195) → (54144, 50048)
    detect_player_position,
    detect_stalls,
    format_position,
)
```

## Phát hiện

| Ngày | Nội dung |
|---|---|
| 27/04 | Xác nhận divisor **256** bằng so sánh protocol vs minimap |
| 29/04 | Chuyển từ Frida hooks sang tcpdump cho position detection |
| 29/04 | Thêm proximity-based entity selection (khu đông) |
| 30/04 | Game port auto-detect qua `netstat -tnp` |
