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

### Nguồn dữ liệu: Opcode 9 (Entity Sync)

Server gửi opcode 9 mỗi khi có entity di chuyển. Format:

```
etype|entity_id|x|y|...
```

- `etype = 1, 2`: Player entity → `parts[2]` = X, `parts[3]` = Y (world coords, 5 số)
- `etype = 33`: Stall info → `parts[8]` = X, `parts[9]` = Y
- `etype = 34`: Stall position → `parts[2]` = X, `parts[3]` = Y

### Logic xác định "nhân vật của mình"

Entity type 1/2 có **nhiều update nhất** trong 1 phiên capture = nhân vật của mình. Vì server luôn gửi vị trí của chính mình nhiều hơn các player khác.

### Điều kiện bắt buộc

> [!IMPORTANT]
> Server **CHỈ GỬI** opcode 9 khi có entity **DI CHUYỂN**. Nếu đứng yên hoàn toàn, sẽ không có gói tin nào → không detect được vị trí.
> 
> **Giải pháp:** Tap nhẹ lên màn hình (ADB `input tap`) để tạo 1 bước di chuyển nhỏ trước khi capture.

## Di chuyển nhân vật

### eGotoPosition (Opcode 248)

Gửi lệnh di chuyển đến tọa độ chỉ định. Dùng **tọa độ 5 số (world coords)**.

```python
# Protocol: GotoPosition { mapx: int32, mapy: int32 }
proto = encode_message_fields("GotoPosition", mapx=54272, mapy=50048)
pkt = struct.pack('<IH', len(proto), 248) + proto
bot.send_raw(pkt)
```

> [!WARNING]
> Field name là `mapx`, `mapy` (KHÔNG phải `targetPositionX`, `targetPositionY` — đó là của CastSkill).

### ADB Input Tap

Tap trực tiếp lên màn hình giả lập:

```bash
adb -s emulator-5554 shell input tap 480 280
```

Cả 2 cách đều hoạt động. `eGotoPosition` cho phép chỉ định tọa độ chính xác, còn ADB tap phụ thuộc vào góc nhìn camera.

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

## Phát hiện (Ngày 27/04/2026)

- Thử nghiệm tất cả divisor từ 248 đến 269
- Divisor **256** cho kết quả khớp 100% với minimap game
- Xác nhận bằng cách so sánh vị trí protocol `(54182, 50049)` với minimap `(211, 195)`
- `54182 // 256 = 211` ✅, `50049 // 256 = 195` ✅
