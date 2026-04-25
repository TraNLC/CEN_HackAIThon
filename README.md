# VLTK1 Bot Toolkit

## Cài đặt (1 lần duy nhất)

```
pip install frida frida-tools flask pyyaml
```

---

## Chạy app

```
cd C:\Rakuten\vltk1-re
python ui/app.py
```

Mở trình duyệt: **http://localhost:5000**

---

## Thứ tự sử dụng trong app

```
1. Cài đặt & Kết nối  →  kết nối LDPlayer, setup Frida
2. Detect Engine       →  xác định game dùng engine gì
3. Capture Packets     →  bắt traffic game (chơi 1 lần dã tẩu)
4. Phân tích Packets   →  tìm opcodes
5. Cấu hình Bot        →  điền opcodes + server IP + accounts
6. Dashboard           →  nhấn Start, theo dõi bot chạy
```

> Xem hướng dẫn chi tiết: [HUONG_DAN.md](HUONG_DAN.md)
