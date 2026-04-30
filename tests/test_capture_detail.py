"""Capture va so sanh SEND packets khi tap di chuyen nhieu huong"""
import sys, os, time, struct, subprocess
from pathlib import Path

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / 'proto'))
sys.path.insert(0, str(ROOT_DIR / 'tests'))

from features.bot.game_bot import VLTK1Bot
from test_open_shop import parse_pcap_recv
from test_capture_move import parse_pcap_send
from vltk1_protocol import GS_OPCODES

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PCAP_DEV = '/data/local/tmp/mc.pcap'
PCAP_LOC = str(ROOT_DIR / 'data' / 'output' / 'mc.pcap')


def capture_and_tap(tap_x, tap_y, label=""):
    """Capture traffic during a tap"""
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    time.sleep(0.3)
    proc = subprocess.Popen(
        [ADB, '-s', DEVICE_ID, 'shell', f'su -c "tcpdump -i any -U -w {PCAP_DEV} -c 5000"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    time.sleep(0.5)
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', f'input tap {tap_x} {tap_y}'], capture_output=True)
    time.sleep(4)
    subprocess.run([ADB, '-s', DEVICE_ID, 'shell', 'su -c "killall tcpdump 2>/dev/null"'], capture_output=True)
    proc.terminate()
    time.sleep(0.5)
    subprocess.run([ADB, '-s', DEVICE_ID, 'pull', PCAP_DEV, PCAP_LOC], capture_output=True)
    
    for port in [45676, 443, 80, 60739]:
        send_pkts = parse_pcap_send(PCAP_LOC, port)
        recv_pkts = parse_pcap_recv(PCAP_LOC, port)
        if send_pkts or recv_pkts:
            print(f"\n  [{label}] Port={port}")
            
            print(f"  SEND ({len(send_pkts)}):")
            for op, body in send_pkts:
                name = GS_OPCODES.get(op, f'UNK_{op}')
                try:
                    text = body.decode('utf-8', errors='replace')
                except:
                    text = ''
                print(f"    [{op:3d}] {name:25s} hex={body.hex()[:60]}  ascii={text[:60]}")
            
            print(f"  RECV opcode 9 ({sum(1 for o,_ in recv_pkts if o==9)}):")
            for op, body in recv_pkts:
                if op != 9: continue
                try:
                    text = body.decode('utf-8', errors='replace')
                except:
                    text = ''
                parts = text.split('|')
                if len(parts) >= 4 and parts[0] in ('1', '2'):
                    print(f"    etype={parts[0]} eid={parts[1][:15]:15s} x={parts[2]:6s} y={parts[3]:6s} rest={'|'.join(parts[4:])[:40]}")
            return send_pkts, recv_pkts
    
    print(f"\n  [{label}] No traffic found!")
    return [], []


def main():
    print("=" * 60)
    print("  CAPTURE CHI TIET PACKET DI CHUYEN")
    print("=" * 60)

    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Connect failed!"); return
    time.sleep(1)

    # Tap 3 huong khac nhau
    print("\n[1] Tap PHAI (840, 360)...")
    s1, r1 = capture_and_tap(840, 360, "PHAI")
    time.sleep(1)
    
    print("\n[2] Tap TRAI (440, 360)...")
    s2, r2 = capture_and_tap(440, 360, "TRAI")
    time.sleep(1)
    
    print("\n[3] Tap LEN (640, 200)...")
    s3, r3 = capture_and_tap(640, 200, "LEN")

    bot.close()
    print("\n[*] Done")


if __name__ == '__main__':
    main()
