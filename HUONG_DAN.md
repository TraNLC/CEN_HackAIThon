# Hướng dẫn sử dụng VLTK1 Bot Toolkit

## Yêu cầu trước khi bắt đầu
- Python 3.10+ đã cài
- LDPlayer đã cài VLTK1
- Máy tính Windows

---

## BƯỚC 1 — Cài đặt (chỉ làm 1 lần)

Mở CMD, chạy:
```
pip install frida frida-tools flask pyyaml
```

---

## BƯỚC 2 — Mở Toolkit

```
cd C:\Rakuten\vltk1-re
python ui/app.py
```

Mở trình duyệt vào: **http://localhost:5000**

---

## BƯỚC 3 — Kết nối LDPlayer

1. Mở LDPlayer, vào **Settings → Other → Enable ADB debugging → ON**
2. Trong Toolkit, vào **Cài đặt & Kết nối**
3. Nhấn **Kết nối** → nhấn **Tìm package VLTK**
4. Thấy chữ xanh "✓ OK" là xong

---

## BƯỚC 4 — Setup Frida (chỉ làm 1 lần)

1. Tải file **frida-server** tại:
   ```
   https://github.com/frida/frida/releases
   ```
   Tìm file: `frida-server-XX.X.X-android-x86_64.xz`

2. Giải nén → đặt file vào thư mục:
   ```
   C:\Rakuten\vltk1-re\frida\
   ```
   (đổi tên file thành `frida-server` cho gọn)

3. Trong Toolkit nhấn **Push & Start frida-server**
4. Thấy "✓ frida-server đang chạy" là xong

---

## BƯỚC 5 — Detect Engine game

1. Vào tab **Detect Engine**
2. Nhấn **Detect Engine**
3. Đọc kết quả — toolkit sẽ tự gợi ý cách hook phù hợp
4. Ghi nhớ phần **Hook approach khuyến nghị**

---

## BƯỚC 6 — Capture packets

1. Vào tab **Capture Packets**
2. Chọn loại capture:
   - **Socket Hook** — thử trước, nếu thấy bytes đọc được thì dùng cái này
   - **Java Hook** — dùng nếu Socket Hook cho bytes ngẫu nhiên (encrypted)
3. Nhấn **Start Capture**
4. Trong LDPlayer: **login game → nhận nhiệm vụ dã tẩu → làm xong → nộp**
5. Nhấn **Stop** để lưu

---

## BƯỚC 7 — Phân tích packets

1. Vào tab **Phân tích Packets**
2. Chọn file vừa capture → nhấn **Phân tích**
3. Bảng hiện ra danh sách opcodes
4. **Ghi chú từng opcode** ở cột cuối (click để sửa):
   - Làm lại từng action trong game (login, nói chuyện NPC, nhận NV...)
   - So sánh thời điểm làm action với packet nào xuất hiện
   - Điền tên vào cột ghi chú, ví dụ: `LOGIN`, `TALK_NPC`, `ACCEPT_QUEST`...

---

## BƯỚC 8 — Cấu hình bot

1. Vào tab **Cấu hình Bot**
2. Điền **Server IP + Port** (xem trong Wireshark khi game connect)
3. Điền các **opcodes** đã tìm được ở bước 7
4. Điền **NPC ID + Quest ID** của dã tẩu (tìm trong captures)
5. Dán danh sách 100 accounts vào ô **Accounts**:
   ```
   acc001,pass001,S1
   acc002,pass002,S1
   ...
   ```
6. Nhấn **Lưu cấu hình**

---

## BƯỚC 9 — Chạy bot

1. Vào tab **Dashboard**
2. Nhấn **Start All**
3. Theo dõi bảng — mỗi account hiện state, số loops, lỗi (nếu có)
4. Nhấn **Stop** để dừng tất cả

---

## Khi gặp sự cố

| Vấn đề | Cách xử lý |
|--------|------------|
| Không kết nối được emulator | Bật ADB trong LDPlayer Settings |
| frida-server không start | Vào LDPlayer shell: `su && /data/local/tmp/frida-server &` |
| Capture chỉ thấy bytes ngẫu nhiên | Chuyển sang Java Hook |
| Packet parser không tìm thấy format | Data có thể dùng custom header — cần RE thêm |
| Bot không login được | Kiểm tra lại opcode LOGIN và format payload |
| Bot stuck không chạy | Kiểm tra server IP/port trong config |

---

## Thứ tự tóm tắt

```
Cài pip  →  Mở toolkit  →  Kết nối LDPlayer  →  Setup Frida
→  Detect engine  →  Capture  →  Phân tích opcodes
→  Điền config  →  Chạy bot  →  Xem dashboard
```
