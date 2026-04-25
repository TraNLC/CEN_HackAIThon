# Bước 2 — Hook và Capture Packets

## Tổng quan 4 hook scripts

| File | Layer | Khi nào dùng |
|------|-------|-------------|
| `hook_socket.js` | libc C | **Bắt đầu ở đây** — bắt raw bytes mọi trường hợp |
| `hook_java.js` | Java IO | Game Java thuần, không có .so |
| `hook_crypto.js` | Crypto | Khi raw bytes trông mã hóa, cần tìm key |
| `hook_opcodes.js` | Memory scan | Muốn dump opcode table trực tiếp từ bộ nhớ |

---

## hook_socket.js — Hook libc send/recv

File: `frida/hook_socket.js`

**Chức năng:**
- Hook `connect()` → phát hiện game đang kết nối đến IP:port nào
- Hook `send()` + `write()` → dump bytes game gửi đi
- Hook `recv()` + `read()` → dump bytes game nhận về
- Tự nhận dạng game port dựa trên range 6000–30000
- Lọc theo `FILTER_PORT` và `FILTER_IP` nếu đã biết

**Mode Discovery (chưa biết port):**
```bash
# Không lọc — hiển thị tất cả connections
# Trong hook_socket.js: FILTER_PORT = 0, FILTER_IP = ""
python frida/capture.py --package vn.vinagame.vltk1
# → Xem log để thấy game connect đến IP:port nào
```

**Mode Focused (đã biết port):**
```bash
python frida/capture.py --package vn.vinagame.vltk1 --port 10001 --ip 103.x.x.x
# → Chỉ capture traffic đến server game
```

**Output:**
- `captures/send_YYYYMMDD_HHMMSS.bin` — raw bytes game gửi
- `captures/recv_YYYYMMDD_HHMMSS.bin` — raw bytes game nhận
- `captures/capture_YYYYMMDD_HHMMSS.log` — text log với hex dump

---

## hook_crypto.js — Detect Encryption

File: `frida/hook_crypto.js`

**Khi nào cần:** Nếu bytes trong capture trông ngẫu nhiên (không thấy opcode pattern), game đang dùng encryption.

**Chức năng:**

**Layer 1 — Java Cipher:**
- Hook `Cipher.init(mode, key)` → in ra algorithm + key bytes
- Hook `Cipher.init(mode, key, params)` → in ra key + IV
- Output: `CIPHER_INIT: algorithm=AES/CBC key=AABBCCDD... iv=001122...`

**Layer 2 — SecretKeySpec:**
- Hook constructor `SecretKeySpec(byte[], algorithm)`
- Bắt ngay lúc key được tạo, trước khi dùng
- Output: `SECRET_KEY: algorithm=AES key=AABBCC... len=128 bits`

**Layer 3 — Detect XOR:**
- So sánh các write liên tiếp vào ByteArrayOutputStream
- Nếu 2 writes có cùng length và XOR nhau là hằng số → đó là XOR key
- Output: `XOR_DETECTED: key=0x5A`

**Layer 4 — Native OpenSSL:**
- Hook `EVP_CipherInit_ex` (OpenSSL) → key + IV
- Hook `RC4_set_key` (OpenSSL RC4) → key
- Output: `OPENSSL_EVP: key=... iv=...`

**Chạy:**
```bash
frida -U -f vn.vinagame.vltk1 -l frida/hook_crypto.js --no-pause
# Quan sát output trong terminal
# Nếu thấy key → hook ở layer cao hơn (sau decrypt)
```

---

## hook_opcodes.js — Dump Opcode Table

File: `frida/hook_opcodes.js`

**Khi nào dùng:** Khi muốn lấy danh sách opcode → tên action trực tiếp từ bộ nhớ game, không cần RE tay.

**4 chiến lược:**

**Strategy 1 — HashMap.put():**
- Game thường init: `map.put("MOVE_TO", 0x0100)`
- Bắt khi điền vào bảng opcode
- Output: `OPCODE_MAP: MOVE_TO = 0x0100`

**Strategy 2 — SparseIntArray.put():**
- Biến thể Android-specific
- Một số game dùng thay HashMap

**Strategy 3 — Static field scan:**
- Scan tất cả class tên `*opcode*`, `*packet*`, `*cmd*`, `*proto*`
- Tìm `public static final int MOVE_TO = 0x0100`
- Chạy sau 3 giây để đợi game load xong
- Output: `CONST_SCAN: {class, field, value, hex}`

**Strategy 4 — Handler signature scan:**
- Tìm method có signature `(int, byte[])` hoặc `(short, byte[])`
- Đây là dấu hiệu packet handler
- Output: `CANDIDATE_HANDLER: cls=..., method=handlePacket`

```bash
frida -U -f vn.vinagame.vltk1 -l frida/hook_opcodes.js --no-pause
# Chờ 3-5 giây để static scan hoàn thành
# Copy kết quả vào analysis/opcode_map.yaml
```

---

## hook_java.js — Java Layer Hook

File: `frida/hook_java.js`

**Khi nào dùng:**
- Game Java thuần (không có .so hoặc .so không dùng cho networking)
- Muốn bắt plaintext sau khi Java code decrypt

**Chức năng:**
- Hook `ByteArrayOutputStream.write()` — bắt bytes trước khi gửi
- Hook `DataInputStream.read()` — bắt bytes sau khi nhận
- Section placeholder để hook class cụ thể sau khi jadx-gui tìm được

---

## Workflow thực tế

```
1. Mở LDPlayer, start frida-server
2. python frida/capture.py --package <package> (mode discovery)
3. Trong game: login, di chuyển, nói chuyện NPC, nhận nhiệm vụ
4. Ctrl+C để dừng → xem log, tìm game IP:port
5. Chạy lại với --port và --ip đã biết
6. Làm đầy đủ 1 vòng dã tẩu
7. → Files: captures/send_xxx.bin, captures/recv_xxx.bin
8. Tiếp tục: docs/03_analysis.md
```

---

## Dấu hiệu capture thành công

- File `.bin` có data (không phải 0 bytes)
- Log có dòng `SEND` và `RECV` xen kẽ
- Có thể thấy printable ASCII trong payload (username, map name...)
- Size packets thay đổi theo action (login packet lớn hơn heartbeat)

## Dấu hiệu game dùng encryption

- Bytes trông hoàn toàn ngẫu nhiên
- Không thấy pattern lặp lại
- Không thấy ASCII trong payload
- → Chạy `hook_crypto.js` để tìm key
