# Bước 4 — Điền Opcodes và Chạy Bot

## Các file bot

| File | Vai trò |
|------|---------|
| `vltk_client.py` | TCP socket, recv loop, heartbeat |
| `packet_builder.py` | Build binary packets từ opcodes |
| `state_machine.py` | Logic dã tẩu (event-driven FSM) |
| `session_replay.py` | Record + replay thay vì hardcode |
| `main.py` | Entry point, chạy nhiều account |

---

## vltk_client.py — TCP Client

**Không cần emulator.** Kết nối thẳng đến server VLTK1 như game client thật.

```python
from vltk_client import VLTKClient

client = VLTKClient(host='103.x.x.x', port=10001, account_id='acc1')
client.connect()

# Gửi packet thủ công
client.send(raw_bytes)

# Đăng ký callback khi nhận opcode
client.on(0x1001, lambda pkt: print("Login OK!"))

# Block chờ opcode cụ thể
pkt = client.wait_for(opcode=0x1001, timeout=10.0)
```

**Tính năng tự động:**
- Heartbeat thread: gửi heartbeat mỗi 30 giây
- Buffer parser: tự ghép TCP fragments thành full packets
- Timeout detection: nếu 60s không nhận gì → báo mất kết nối

---

## packet_builder.py — Điền Opcodes Thật

**Quan trọng:** Tất cả opcode hiện tại là `0xFFFF` (placeholder).  
**Phải thay** bằng giá trị thật sau khi RE.

### Cách điền

Mở file `bot/packet_builder.py`, tìm phần:

```python
OP_LOGIN         = 0xFFFF  # TODO: thay opcode thật
OP_SELECT_CHAR   = 0xFFFF  # TODO
OP_MOVE_TO       = 0xFFFF  # TODO
OP_TALK_NPC      = 0xFFFF  # TODO
OP_ACCEPT_QUEST  = 0xFFFF  # TODO
OP_SUBMIT_QUEST  = 0xFFFF  # TODO
OP_ATTACK        = 0xFFFF  # TODO
OP_PICK_ITEM     = 0xFFFF  # TODO
OP_HEARTBEAT     = 0xFFFF  # TODO
```

Thay bằng giá trị tìm được từ bước 3. Ví dụ (nếu Snail engine chuẩn):

```python
OP_LOGIN         = 0x0001
OP_SELECT_CHAR   = 0x0002
OP_MOVE_TO       = 0x0101
OP_TALK_NPC      = 0x0201
OP_ACCEPT_QUEST  = 0x0203
OP_SUBMIT_QUEST  = 0x0204
OP_ATTACK        = 0x0301
OP_PICK_ITEM     = 0x0304
OP_HEARTBEAT     = 0x0005
```

### Kiểm tra payload format

Sau khi biết opcode, xem payload structure:

```bash
# Xem payload của LOGIN packet
python analysis/packet_parser.py captures/send_xxx.bin --opcode 0x0001 --payload

# Output:
# [000000] SEND opcode=0x0001(1) len=20 payload: 05 61 64 6d 69 6e 05 61 64...
# 0000  05 61 64 6d 69 6e 05 61  64 6d 69 6e 00 00       .admin.admin..
#
# → Đây là: [1B len=5][admin][1B len=5][admin]
# → PacketBuilder.login() đã đúng format
```

Nếu format khác, sửa trong `packet_builder.py`:

```python
@staticmethod
def login(username: str, password: str) -> bytes:
    u = username.encode('utf-8')
    p = password.encode('utf-8')
    # Sửa theo format thật, ví dụ null-terminated:
    payload = u + b'\x00' + p + b'\x00'
    return PacketBuilder.build(PacketBuilder.OP_LOGIN, payload)
```

---

## state_machine.py — Điền NPC/Quest IDs

Ngoài opcodes, cần điền IDs:

```python
class Config:
    DA_TAU_NPC_ID   = 0       # TODO: NPC nhận/nộp nhiệm vụ
    DA_TAU_QUEST_ID = 0       # TODO: Quest ID
    CHAR_INDEX      = 0       # Nhân vật đầu tiên
    NPC_COORDS      = (0, 0)  # TODO: vị trí NPC trên map
    MOB_AREA_COORDS = (0, 0)  # TODO: vùng spawn mob
```

**Cách tìm NPC ID:**
```bash
# Xem payload của TALK_NPC packet
python analysis/packet_parser.py captures/send_xxx.bin --opcode 0x0201 --payload
# → Bytes đầu payload = NPC ID (uint32 big-endian)

import struct
npc_id = struct.unpack('>I', bytes.fromhex('00 00 03 E8'.replace(' ','')))[0]
# → 1000
```

**Cách tìm Quest ID:**
```bash
python analysis/packet_parser.py captures/send_xxx.bin --opcode 0x0203 --payload
# → Bytes đầu payload = Quest ID
```

**Cách tìm coords:**
- Dùng minimap game hoặc xem MOVE_TO packets khi di chuyển đến NPC
- Hoặc xem payload ENTER_WORLD_OK (S2C) — thường chứa spawn coords

---

## session_replay.py — Alternative Không Cần RE

**Concept:** Thay vì RE từng opcode, chỉ cần chơi tay 1 lần → record → replay.

### Record session

```bash
# Sau khi có capture files từ bước 2:
python bot/session_replay.py record \
  --name da_tau_s1 \
  --send captures/send_xxx.bin \
  --recv captures/recv_xxx.bin \
  --account acc001
```

Tạo file: `recordings/da_tau_s1.json`

### Xem thông tin recording

```bash
python bot/session_replay.py info recordings/da_tau_s1.json
```

Output:
```
Session: da_tau_s1
  Recorded: 2024-01-15 10:30:00
  Account:  acc001
  Packets:  42 SEND, 87 RECV

  SEND packets:
    t=  0.0s  opcode=0x0001  payload=20B  [LOGIN]
    t=  0.5s  opcode=0x0002  payload=4B
    t=  1.2s  opcode=0x0101  payload=4B   *variable*
    ...
```

### Replay cho account khác

```python
from bot.session_replay import Replayer
from bot.vltk_client import VLTKClient
import socket

replayer = Replayer(Path('recordings/da_tau_s1.json'))

sock = socket.socket()
sock.connect(('103.x.x.x', 10001))

replayer.replay(sock, overrides={
    'quest_id': 5001,   # thay quest ID khác nếu cần
}, speed=1.0)
```

### Detect variable fields

Khi capture 2 account khác nhau làm cùng flow:

```python
from bot.session_replay import Recorder

recorder1 = Recorder('da_tau_acc1', 'acc001')
recorder1.from_capture_files(Path('captures/send_acc1.bin'), Path('captures/recv_acc1.bin'))

session2 = Session.from_dict(json.loads(Path('recordings/da_tau_acc2.json').read_text()))
variables = recorder1.detect_variables(session2)
# variables: {'0x0203': [{'offset': 0, 'length': 4}]}  ← quest_id ở offset 0
```

---

## Chạy bot

### 1 account (test)

```bash
cd C:\Rakuten\vltk1-re\bot
python main.py --account accounts.csv --index 0 --loops 10
```

### Nhiều account qua Web UI

```bash
python ui/app.py
# Mở http://localhost:5000
# → Tab Config: điền server IP/port + opcodes
# → Tab Dashboard: Start/Stop từng account
```

### Logs

```bash
# Bot logs mặc định ra console
# Để ghi file:
python main.py 2>&1 | tee bot_log.txt

# Xem state transitions
grep "→" bot_log.txt
```

---

## Checklist trước khi chạy

- [ ] Server IP và port đã điền trong `config.yaml`
- [ ] Tất cả opcodes trong `packet_builder.py` đã thay `0xFFFF`
- [ ] Tất cả opcodes trong `state_machine.py` class `S2C` đã thay `0xFFFF`
- [ ] `Config.DA_TAU_NPC_ID` đã điền
- [ ] `Config.DA_TAU_QUEST_ID` đã điền
- [ ] `Config.NPC_COORDS` đã điền
- [ ] `accounts.csv` có ít nhất 1 dòng `username,password`
- [ ] Test thủ công 1 account trước khi scale
