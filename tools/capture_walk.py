import subprocess
import time
import os

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'

print("[*] Đang dọn dẹp file cũ...")
subprocess.run(f'{ADB} -s {DEVICE_ID} shell "rm /sdcard/walk.pcap"', shell=True, stderr=subprocess.DEVNULL)

print("[*] Bắt đầu bắt gói tin mạng...")
print(">>> XIN MỜI ANH DÙNG CHUỘT KÉO CHO NHÂN VẬT CHẠY VÀI BƯỚC TRONG GAME! <<<")
print("[*] Vui lòng chạy khoảng 5-10 giây rồi quay lại đây nhấn Ctrl+C để kết thúc.")

try:
    subprocess.run(f'{ADB} -s {DEVICE_ID} shell "su -c \\"tcpdump -i any -w /sdcard/walk.pcap tcp\\""', shell=True)
except KeyboardInterrupt:
    pass

print("\n[*] Đang dừng tcpdump...")
subprocess.run(f'{ADB} -s {DEVICE_ID} shell "su -c \\"pkill tcpdump\\""', shell=True)

print("[*] Đang copy file về máy tính...")
subprocess.run(f'{ADB} -s {DEVICE_ID} pull /sdcard/walk.pcap e:/tool/sample-test/vltk1-re/tools/walk.pcap', shell=True)

print("\n[*] Đang phân tích gói tin...")
try:
    import dpkt
    import struct
    with open('e:/tool/sample-test/vltk1-re/tools/walk.pcap', 'rb') as f:
        pcap = dpkt.pcap.Reader(f)
        found = False
        for timestamp, buf in pcap:
            try:
                sll = dpkt.sll.SLL(buf)
                ip = sll.data
                if not isinstance(ip, dpkt.ip.IP): continue
                tcp = ip.data
                if not isinstance(tcp, dpkt.tcp.TCP): continue
                if len(tcp.data) == 0: continue
                
                payload = tcp.data
                if len(payload) >= 6:
                    pkt_len, opcode = struct.unpack('<IH', payload[:6])
                    if opcode == 20:
                        print(f"\n[!!! BẮT ĐƯỢC GÓI TIN ĐI BỘ (Opcode 20) !!!]")
                        print(f"HEX: {payload[:pkt_len+4].hex(' ')}")
                        found = True
                        break
            except Exception:
                pass
        
        if not found:
            print("[-] Không tìm thấy gói tin Opcode 20. Vui lòng thử lại!")
except ImportError:
    print("[-] Thiếu thư viện dpkt. Hãy gửi file walk.pcap cho em phân tích!")
except Exception as e:
    print(f"[-] Lỗi phân tích: {e}")
