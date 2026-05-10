"""Debug Step 3: tap NPC area, capture tcpdump, dump all opcodes found."""
import os, sys, time, subprocess
sys.stdout.reconfigure(encoding='utf-8')
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT)
sys.path.insert(0, os.path.join(ROOT, "tests"))

ADB = r"C:\platform-tools\adb.exe"
DEV = "emulator-5554"

def adb(cmd): subprocess.run([ADB, "-s", DEV, "shell", cmd], capture_output=True, timeout=5)
def tap(x, y): subprocess.run([ADB, "-s", DEV, "shell", f"input tap {x} {y}"], capture_output=True, timeout=5)

# Detect port
out = subprocess.run([ADB, "-s", DEV, "shell", 'su -c "netstat -tnp 2>/dev/null"'], capture_output=True, timeout=5)
port = 45676
for line in out.stdout.decode().splitlines():
    if 'jx1mobile' in line and 'ESTABLISHED' in line:
        p = int(line.split()[4].split(':')[-1])
        if p > 1024:
            port = p
            break
print(f"Game port: {port}")

pcap_dev = "/data/local/tmp/npc_debug.pcap"
pcap_local = os.path.join(ROOT, "data", "output", "npc_debug.pcap")
os.makedirs(os.path.dirname(pcap_local), exist_ok=True)

# Start tcpdump
adb('su -c "killall tcpdump 2>/dev/null"')
adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
time.sleep(0.3)

proc = subprocess.Popen(
    [ADB, "-s", DEV, "shell", f'su -c "tcpdump -i any -U -w {pcap_dev} -c 500 port {port}"'],
    stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
)
time.sleep(1)

# Tap NPC area (multiple locations)
print("Tapping NPC area...")
tap(430, 150)  # NPC_TAP_AREA
time.sleep(1.5)

# Tap popup lines
for i in range(8):
    y = 90 + i * 25
    print(f"  Tap popup line {i}: (170, {y})")
    tap(170, y)
    time.sleep(0.5)

time.sleep(2)

# Stop capture
adb('su -c "killall tcpdump 2>/dev/null"')
proc.terminate()
time.sleep(0.5)

# Pull
subprocess.run([ADB, "-s", DEV, "pull", pcap_dev, pcap_local], capture_output=True, timeout=10)

# Parse
if os.path.exists(pcap_local):
    from test_open_shop import parse_pcap_recv
    packets = parse_pcap_recv(pcap_local, port)
    print(f"\nPackets captured: {len(packets)}")
    
    from collections import Counter
    opcodes = Counter()
    for pkt in packets:
        if len(pkt) >= 6:
            op = pkt[4] | (pkt[5] << 8)
            opcodes[op] += 1
    
    print(f"Opcode distribution:")
    for op, cnt in opcodes.most_common(20):
        name = {9:'eStringData', 33:'eNpcDialogue', 34:'eNpcQuest', 
                35:'eNpcSelect', 71:'eMapDialogNpcListRequest',
                72:'eMapDialogNpcListResponse', 166:'eContextDescription',
                69:'ePing', 70:'ePong', 248:'eGotoPosition'}.get(op, f'UNK_{op}')
        print(f"  {op:>4} ({name:>30}): {cnt}x")
    
    # Show any opcode 166
    for pkt in packets:
        if len(pkt) >= 6:
            op = pkt[4] | (pkt[5] << 8)
            if op == 166:
                print(f"\n!!! FOUND opcode 166! body ({len(pkt)-6} bytes):")
                print(f"  hex: {pkt[6:100].hex()}")
                try:
                    print(f"  text: {bytes(pkt[6:]).decode('utf-8', errors='replace')}")
                except:
                    pass
else:
    print("No pcap file found!")
