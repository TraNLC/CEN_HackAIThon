"""
test_capture_all.py - Capture TAT CA opcodes khi tap di chuyen (khong chi opcode 9)
Tim packet nao thuc su trigger di chuyen
"""
import sys, os, time, struct, subprocess
from pathlib import Path

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))
sys.path.insert(0, str(ROOT_DIR / 'tests'))

from features.bot.game_bot import VLTK1Bot
from test_capture_move import parse_pcap_send
from test_open_shop import parse_pcap_recv
from vltk1_protocol import GS_OPCODES

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PCAP_DEV = '/data/local/tmp/cap.pcap'
PCAP_LOC = str(ROOT_DIR / 'data' / 'output' / 'cap.pcap')


def capture_tap(tap_x, tap_y, label):
    """Dong NPC dialog truoc, roi tap de di chuyen"""
    # Dong dialog neu co (tap vao X)
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'input tap 461 72'], capture_output=True)
    time.sleep(1)
    
    # Start capture
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.3)
    proc = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell', f'su -c "tcpdump -i any -U -w {PCAP_DEV} -c 5000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(0.5)
    
    # Tap
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', f'input tap {tap_x} {tap_y}'], capture_output=True)
    time.sleep(4)
    
    # Stop
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    proc.terminate()
    time.sleep(0.5)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC], capture_output=True)
    
    for port in [45676, 443, 80, 60739]:
        send_pkts = parse_pcap_send(PCAP_LOC, port)
        recv_pkts = parse_pcap_recv(PCAP_LOC, port)
        if send_pkts or recv_pkts:
            print(f"\n[{label}] Port={port}")
            print(f"  SEND ({len(send_pkts)}):")
            for op, body in send_pkts:
                name = GS_OPCODES.get(op, f'UNK_{op}')
                try: text = body.decode('utf-8', errors='replace')
                except: text = body.hex()[:40]
                print(f"    [{op:3d}] {name:30s} len={len(body):3d} body={text[:60]}")
                if op != 9:
                    print(f"           hex={body.hex()[:80]}")
            
            # Group recv by opcode
            recv_ops = {}
            for op, body in recv_pkts:
                recv_ops[op] = recv_ops.get(op, 0) + 1
            print(f"  RECV ({len(recv_pkts)}):")
            for op, cnt in sorted(recv_ops.items()):
                name = GS_OPCODES.get(op, f'UNK_{op}')
                print(f"    [{op:3d}] {name:30s} x{cnt}")
            return send_pkts, recv_pkts
    
    print(f"\n[{label}] No traffic!")
    return [], []


def main():
    print("=" * 60)
    print("  CAPTURE ALL OPCODES KHI TAP")
    print("=" * 60)

    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Connect failed!"); return
    time.sleep(1)

    # Test 1: Idle baseline (sau khi dong dialog)
    print("\n--- BASELINE (dong dialog + idle) ---")
    capture_tap(461, 72, "IDLE")
    
    # Test 2: Tap xa sang PHAI
    print("\n--- TAP PHAI (xa) ---")
    capture_tap(840, 360, "PHAI")
    
    # Test 3: Tap LEN
    print("\n--- TAP LEN ---")
    capture_tap(640, 200, "LEN")
    
    # Test 4: Tap XUONG
    print("\n--- TAP XUONG ---")
    capture_tap(640, 500, "XUONG")

    bot.close()
    print("\n[*] Done")


if __name__ == '__main__':
    main()
