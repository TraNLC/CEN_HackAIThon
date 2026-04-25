# VLTK1 Bot Toolkit — Tổng Quan

## Mục tiêu

Build bot tự động làm nhiệm vụ **Dã Tẩu** cho VLTK1 Android (bản convert từ PC).  
Không dùng image recognition — giao tiếp trực tiếp qua **binary TCP packet** như game client thật.

## Kiến trúc tổng thể

```
LDPlayer (emulator)
  └── VLTK1 process
        └── libc send/recv  ← Frida hook ở đây
                │
        [binary packets]
                │
        Python capture.py   ← ghi ra .bin files
                │
   ┌────────────┼────────────┐
   │            │            │
packet_parser  correlate  detect_engine
   │
opcode_db.yaml  ← cross-reference gợi ý tên
   │
packet_builder.py
   │
state_machine.py  ← logic dã tẩu
   │
vltk_client.py  ← TCP socket, không cần emulator
```

## Thứ tự thực hiện

```
Bước 1  → docs/01_setup_frida.md        Setup Frida + LDPlayer
Bước 2  → docs/02_capture.md            Hook và capture packets
Bước 3  → docs/03_analysis.md           Phân tích tìm opcodes
Bước 4  → docs/04_bot.md                Điền opcodes vào bot, chạy
Bước 5  → docs/05_resources_52pojie.md  Tìm thêm thông tin từ cộng đồng TQ
```

## Cấu trúc thư mục

```
vltk1-re/
├── frida/
│   ├── hook_socket.js      Hook libc send/recv — bắt raw bytes
│   ├── hook_java.js        Hook Java IO layer — backup/alternative
│   ├── hook_crypto.js      Detect encryption key/IV tự động
│   ├── hook_opcodes.js     Dump opcode table từ bộ nhớ game
│   ├── capture.py          Python controller — nhận data từ Frida
│   └── capture_java.py     Java-layer capture controller
│
├── analysis/
│   ├── packet_parser.py    Parse binary → packet list + opcode summary
│   ├── correlate.py        So sánh nhiều sessions → lọc fake packets
│   ├── detect_engine.py    Phân tích APK → biết engine + hook approach
│   ├── hexdump.py          Hex dump utility
│   └── opcode_map.yaml     File ghi chú opcodes đã RE (tự điền)
│
├── bot/
│   ├── vltk_client.py      TCP socket client (không cần emulator)
│   ├── packet_builder.py   Build packets từ opcodes đã biết
│   ├── state_machine.py    Logic dã tẩu (state machine event-driven)
│   ├── session_replay.py   Record 1 lần → replay cho nhiều account
│   └── main.py             Entry point chạy bot
│
├── data/
│   └── opcode_db.yaml      Cross-game opcode reference (Snail engine)
│
├── ui/
│   ├── app.py              Flask web UI + bot orchestration
│   └── templates/
│       └── index.html      Dashboard SPA
│
├── xposed/                 Alternative: Xposed module (persistent hook)
├── docs/                   Tài liệu này
├── captures/               Binary captures (tự tạo khi chạy)
├── recordings/             Session recordings (session_replay.py)
├── toolkit.py              CLI launcher menu
└── config.yaml             Server IP/port + opcodes
```

## Công nghệ sử dụng

| Layer | Công cụ | Mục đích |
|-------|---------|---------|
| Instrumentation | Frida | Inject vào process, hook functions |
| Emulator | LDPlayer | Chạy game Android, có ADB + root |
| APK analysis | jadx-gui, detect_engine.py | Đọc source Java, biết engine |
| Decompiler | IDA Pro / Ghidra | RE native .so (nếu cần) |
| Bot runtime | Python socket | Kết nối thẳng server, không cần emulator |
| Web UI | Flask + JS | Dashboard monitor nhiều account |
