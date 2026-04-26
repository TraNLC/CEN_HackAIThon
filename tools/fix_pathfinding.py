import re

with open('e:/tool/sample-test/vltk1-re/tests/test_real_pathfinding.py', 'r', encoding='utf-8') as f:
    content = f.read()

new_logic = '''    # 2. SỬ DỤNG ADB CHẠM MẶT ĐẤT HOẶC MỞ BẢN ĐỒ LỚN (GIẢI PHÁP TỐI ƯU NHẤT)
    print("\\n[Bot] Kích hoạt chế độ tự chạy bằng cách Click Map (Chính xác & Không Crash).")
    
    bot.go_to_datau_via_ui()
    
    walk_timeout = 0
    while walk_timeout < 15:
        bot.poll_recv()
        time.sleep(1)
        walk_timeout += 1
        print(f"  ... Đang chờ nhân vật chạy đến Dã Tẩu (Wait {walk_timeout}s)")
        # TODO: Cần kiểm tra xem UI Dã Tẩu đã mở lên chưa thông qua nhận diện UI hoặc packet
'''

content = re.sub(r'    # 2\. SỬ DỤNG HÀM NATIVE.*?print\(f"  \.\.\. Đang chờ game chạy \(Wait \{walk_timeout\}s\)"\)', new_logic, content, flags=re.DOTALL)

with open('e:/tool/sample-test/vltk1-re/tests/test_real_pathfinding.py', 'w', encoding='utf-8') as f:
    f.write(content)
