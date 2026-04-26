# VLTK1 Mobile Auto Bot (GSTAuto)

Dự án phát triển Auto Bot cho game Võ Lâm Truyền Kỳ 1 Mobile (Tên thương hiệu Giao diện: **GSTAuto**).
Kiến trúc bot sử dụng **Frida Injector** để giao tiếp trực tiếp với bộ nhớ game và **Protobuf** để đọc/gửi gói tin (packets). Giao diện người dùng được thiết kế chuẩn mực bằng **Tkinter** theo phong cách 9C Helper.

## 📂 Cấu Trúc Thư Mục

```text
vltk1-re/
├── assets/             # Chứa hình ảnh, template nhận diện màn hình (nếu có)
├── config/             # Chứa các file cấu hình cài đặt Bot (config.yaml)
├── core/               # Thư viện lõi (Network, Memory, Injector)
│   ├── injector.py     # Gửi packet vào socket game qua Frida
│   ├── pcap.py         # Bắt và đọc gói tin TCPDump
│   └── protocol.py     # Giải mã dữ liệu game
├── data/               # Lưu trữ toàn bộ dữ liệu Game
│   ├── game_raw/       # File dữ liệu cấu hình thô kéo từ Android về
│   └── output/         # JSON database tĩnh & Map tọa độ đã quét
├── database/           # Lớp kết nối Database
│   └── db_manager.py   # Load JSON và cung cấp API (Lấy thông tin Map, NPC, Skill)
├── docs/               # Tài liệu hướng dẫn phát triển
├── features/           # Các chức năng chính của Bot (Đánh quái, Làm nhiệm vụ...)
├── gui/                # Module Giao diện UI (Tkinter)
│   ├── app.py          # Khung chính của UI và thanh công cụ
│   └── tab_*.py        # 10 file chứa nội dung chi tiết của từng Tab
├── proto/              # KHIẾM KHUYẾT QUAN TRỌNG: Chứa khuôn mẫu Protobuf để dịch gói tin
├── tests/              # Các script test chức năng đơn lẻ
├── tools/              # Các công cụ hỗ trợ
│   ├── parse_data.py   # Tool chuyển file raw của game thành JSON
│   └── export_map.py   # Tool tự động lấy tọa độ NPC trên map
├── utils/              # Các hàm tiện ích dùng chung
├── PLAN.md             # Kế hoạch phát triển dự án chi tiết
└── main.py             # File chạy chính của chương trình (Khởi chạy UI)
```

## 🚀 Cách Khởi Chạy Bot

**1. Khởi chạy Giao diện GSTAuto:**
```bash
python main.py
```

**2. Parse toàn bộ dữ liệu tĩnh của Game (Skill, Item, Map):**
```bash
python tools/parse_data.py
```
*(Kết quả sẽ được xuất ra thư mục `data/output/json/`)*

**3. Quét thông tin NPC và Tọa độ của Map hiện tại:**
- Mở game VLTK1 Mobile, đưa nhân vật đứng yên trong map cần quét.
- Mở terminal chạy lệnh:
```bash
python tools/export_map.py
```
*(Hoặc có thể ép buộc quét theo ID Map bằng cách: `python tools/export_map.py 162`)*

## 🛠️ Nguyên lý hoạt động (Core)
- **Injection:** Không dùng Xposed, tool inject JS trực tiếp vào bộ nhớ game qua **Frida** để gọi hàm C# (gửi gói tin).
- **Sniffing:** Dùng `tcpdump` trên thiết bị Android để bắt các gói tin trả về từ Server.
- **Decoding:** Áp dụng `blackboxprotobuf` và schema trong `proto/` để giải mã dữ liệu nhị phân thành text đọc hiểu được.
- **Database:** Tất cả tên map, NPC, skill được dịch ngược từ file config của game để đảm bảo độ chuẩn xác 100%.
- **GUI:** Quản lý cấu hình bằng UI, xuất ra config, điều hướng thread Worker để chạy Auto độc lập với UI.

Các Tân Thủ Thôn (Thôn trang cơ bản):
Map 20: Giang Tân Thôn
Map 53: Ba Lăng Huyện
Map 101: Đạo Hương Thôn
Map 174: Long Tuyền Thôn
Map 153: Thạch Cổ Trấn
Map 121: Long Môn Trấn
Map 100: Chu Tiên Trấn
Map 99: Vĩnh Lạc Trấn
Các Map Phụ Cận/Khu Vực Riêng có tính chất thôn/trấn:
Map 11: Thành Đô (được game xếp cả vào cụm từ "Thành/Trấn")
Map 21: Thanh Thành Sơn
Map 23: Thần Tiên Động
Map 43: Kiếm Các Trung Nguyên
Map 51: Thánh Động tầng 1
Map 52: Thánh Động tầng 2
Map 54: Nam Nhạc Trấn
Map 68: Thanh Loa Đảo
Map 69: Thanh Loa Đảo sơn động
Map 97: Giang Tân thôn-Vô Danh Động
Map 98: Ba Lăng huyện-Thanh Khê Động
Map 102: Thánh Động tầng 2 (bản đồ phụ)
Map 114: 108 La Hán trận
Map 132: Băng Huyết Động
Map 175: Tây Sơn thôn
Map 187: Thanh Ngưu trại
Map 198: Thanh khê động
Map 205: Dương Trung động
Map 520 -> 526: Minh Nguyệt trấn (các nhánh từ các thành)
Map 905: Trường Ca Sơn Trang
Map 926: Chiến trường Thành Đô

python tools/export_map.py 176 //176 = ID map