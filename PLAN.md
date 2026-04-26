# Kế Hoạch Phát Triển Chi Tiết GSTAuto (VLTK1 Mobile)

Dưới đây là kế hoạch phát triển cực kỳ chi tiết, đi từ những viên gạch nền tảng (Decode/Reverse Engineering) cho đến khi hoàn thiện hệ thống Auto thông minh.

---

### Giai Đoạn 1: Kiến Trúc Dự Án & Bóc Tách Dữ Liệu Tĩnh
**Trạng thái: ✅ Đã hoàn thành bộ khung**
- [x] Quy hoạch lại toàn bộ cấu trúc dự án (`core`, `gui`, `data`, `features`, `tools`).
- [x] Phát triển công cụ `parse_data.py` để dịch ngược file raw của game thành Database JSON dễ đọc (Danh sách Item, Map, NPC, Skill).
- [x] Khởi tạo `db_manager.py` (Singleton) để load dữ liệu tĩnh vào bộ nhớ, phục vụ cho quá trình dò đường và định danh vật phẩm.

---

### Giai Đoạn 2: Dịch Ngược Protocol & Nhận Diện Gói Tin (Decoding)
**Trạng thái: 🔄 Đang trọng tâm xử lý (Tools/Analysis)**
*Đây là trái tim của hệ thống Bot - Giúp Bot "hiểu" được Game đang nói gì.*
- [ ] **Extract Schema:** Sử dụng các script trong `tools/analysis/` (như `extract_proto.py`, `il2cpp_dump.py`) để cào toàn bộ định nghĩa Protobuf (`.proto`) từ bộ nhớ Game.
- [ ] **Map Opcode:** Phân tích và khớp mã lệnh Packet (Opcode) với Tên Message tương ứng, lưu thành file cấu hình chuẩn `opcode_map.yaml`.
- [ ] **Xây dựng Protocol Decoder:** Hoàn thiện `core/protocol.py` kết hợp `blackboxprotobuf` để có thể Giải mã (Deserialize) chính xác 100% các file `.pcap` hoặc luồng dữ liệu sống.
- [ ] **Phân tích hành vi:** Đọc hiểu các gói tin quan trọng: Đi lại (Move), Cập nhật máu/MP (SyncAttribute), Đánh quái (UseSkill), Rớt đồ (DropItem), Báo cáo xung quanh (EntitySync).

---

### Giai Đoạn 3: Giao Diện Người Dùng (GUI) & Quản Lý Cấu Hình
**Trạng thái: 🔶 Đã lên khung UI / Đang chờ nối Logic**
- [x] Dựng hoàn chỉnh bộ Giao diện Tkinter (10 Tab chuẩn 9C Helper) với trải nghiệm mượt mà.
- [ ] **Config Binding:** Viết logic kết nối các Checkbox, Textbox trên UI với cấu trúc dữ liệu Python.
- [ ] **Load/Save Profiles:** Tự động lưu cấu hình xuống `config/config.yaml` và hỗ trợ nhiều Profile cho nhiều nhân vật khác nhau.
- [ ] **Real-time UI Update:** Đẩy log từ tiến trình Bot hiển thị lên khung Textbox Nhật ký trên UI.

---

### Giai Đoạn 4: Kiến Trúc Đa Tiến Trình (Scale 100 Acc) & State Machine
**Trạng thái: ⏳ Chờ xử lý**
Để Tool chạy mượt mà **100 Accounts (Acc) cùng lúc** mà không treo máy, kiến trúc bắt buộc phải phân mảnh:
- [ ] **Kiến trúc Multi-Processing:** Tách biệt hoàn toàn Giao diện (UI Process) và Tiến trình chạy Auto (Worker Processes). Mỗi Acc chạy trên một Process độc lập hoặc Asynchronous Task (asyncio).
- [ ] **Frida Multi-Device:** Sử dụng `adbutils` để dò tìm toàn bộ Emulator (Nox, LDPlayer) đang bật. Bơm Script Frida (`frida_bot.js`) vào độc lập từng giả lập.
- [ ] **IPC Bridge (ZeroMQ/Sockets):** Dùng ZeroMQ để truyền Packet từ C# Game Memory lên Python với độ trễ < 5ms, đảm bảo 100 Acc không bị nghẽn cổ chai.
- [ ] **Xây dựng State Machine độc lập:** Mỗi Acc sẽ có một não bộ riêng (State Machine) được cập nhật Real-time từ các luồng gói tin trả về (recv).
  - Tọa độ hiện tại (`SyncPosition`)
  - Lượng HP/MP hiện tại (`SyncAttribute`)
  - Danh sách Quái vật/Người chơi quanh mình (`EntitySync`)
- [ ] **Packet Forging & Feedback Loop (Cơ chế chống kẹt):**
  - Viết các hàm gửi gói tin (Move, Loot, UseSkill, NpcClick) thông qua Frida Hook `write()`.
  - **TUYỆT ĐỐI KHÔNG GỬI MÙ (Blind Send):** Sau khi bắn lệnh Move, Bot không `time.sleep()` mà phải check vòng lặp chờ Server trả về gói tin xác nhận (`SyncPosition`). Nếu sau 1s tọa độ không đổi -> KẾT LUẬN KẸT MAP -> Kích hoạt thuật toán gỡ kẹt.

---

### Giai Đoạn 5: Hoàn Thiện Tính Năng Tự Động (Theo 10 Tab Cấu Hình)
**Trạng thái: ⏳ Chờ xử lý**
Khi State Machine đã vững, đây là lúc map trực tiếp các lệnh logic vào tính năng. **ƯU TIÊN CAO NHẤT: AUTO DÃ TẨU**.

- [ ] **⭐ ƯU TIÊN SỐ 1: Chuỗi Nhiệm vụ Dã Tẩu (Logic Cốt Lõi):**
  **Điều kiện cần & đủ để làm Dã tẩu:**
  1. Phải hoàn thiện *Hệ thống Pathfinding liên map* (Đi từ bãi cày -> Về thành -> Đến gặp Dã Tẩu -> Đến NPC Tạp hóa).
  2. Phải có *Database chuẩn* (`npc.json`, `item.json`, `map.json`) để tra cứu.
  3. Phải bắt được *Gói tin Hội thoại (Dialog Packet)* của NPC.

  **Luồng Logic (Flow):**
  - **Nhận Task:** Chạy đến Dã Tẩu -> Bắt Packet Text hội thoại -> Dùng Biểu thức chính quy (Regex) quét Text để nhận diện:
    * *Trường hợp 1 (Nộp đồ):* Quét trong rương có chưa? -> Chưa có thì Pathfinding ra Tạp Hóa mua -> Mua xong quay lại nộp. Nếu đồ yêu cầu là đồ Hoàng Kim hoặc đắt hơn setting -> Gửi Packet Hủy nhiệm vụ.
    * *Trường hợp 2 (Đánh quái/Lấy đồ):* Tra cứu ID Quái -> Pathfinding ra bãi -> Bật Module Auto Farm -> Đánh đến khi nhận Packet báo xong nhiệm vụ -> Dùng TĐP bay về trả.
    * *Trường hợp 3 (EXP/Phúc Duyên):* Chạy ra bãi chỉ định cắm chuột hoặc mua đồ uống.
  - **Nhận Thưởng:** Phân tích Packet 3 lựa chọn trả về -> So khớp với độ ưu tiên cài ở UI -> Gửi Packet chọn phần thưởng.
- [ ] **Tab Cơ bản & Luyện công (Auto Farm):**
  - Tự đánh, đánh lẻ, đánh quanh tọa độ điểm lưu (Bán kính quy định).
  - Tự động nhặt đồ, bỏ quái thường.
  - Logic tự Về thành an toàn khi đầy hành trang, hết độ bền.

- [ ] **Tab Hành trang & Phục hồi:**
  - Tự động tìm NPC Tạp Hóa / Dược điếm: Mua thuốc, Sửa trang bị, Bán đồ rác.
  - Xử lý bơm Máu/Mana theo 3 mức độ, tự động TĐP khi sắp chết.
  - Tương tác Rương chứa đồ: Gửi/Rút tiền, Cất vật phẩm quý.

- [ ] **Các Tính Năng Chờ Xử Lý Sau (Low Priority):**
  - Tổ đội (Đội trưởng, Theo sau).
  - Chiến đấu (Ưu tiên skill, combo).
  - Đối thủ (Bộ lọc mục tiêu, Blacklist).
  - PK / Tự vệ (Phản đòn cừu sát, bảo vệ đồng đội).
  - Đăng nhập (Auto login).


