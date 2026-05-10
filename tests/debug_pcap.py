"""Debug: test pcap capture directly."""
import os, sys, subprocess, time

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT)
sys.path.insert(0, os.path.join(ROOT, "tests"))

ADB = r"C:\platform-tools\adb.exe"
DEVICE = "emulator-5554"

def adb(cmd):
    r = subprocess.run([ADB, "-s", DEVICE, "shell", cmd], capture_output=True, timeout=5)
    return r.stdout.decode(errors='ignore')

# 1. Kill old
adb('su -c "killall tcpdump"')
adb('su -c "rm /data/local/tmp/mv2.pcap"')
time.sleep(0.3)

# 2. Detect port
out = adb('su -c "netstat -tnp"')
port = 0
for line in out.splitlines():
    if 'jx1mobile' in line and 'ESTABLISHED' in line:
        port = int(line.split()[4].split(':')[-1])
        break
print(f"Port: {port}")

# 3. Start tcpdump
proc = subprocess.Popen(
    [ADB, "-s", DEVICE, "shell", f'su -c "tcpdump -i any -U -w /data/local/tmp/mv2.pcap -c 500 port {port}"'],
    stdout=subprocess.PIPE, stderr=subprocess.PIPE)
time.sleep(0.5)

# 4. Tap center
print("Tapping (480, 300)...")
subprocess.run([ADB, "-s", DEVICE, "shell", "input tap 480 300"], capture_output=True)
time.sleep(3)

# 5. Stop
adb('su -c "killall tcpdump"')
proc.terminate()
time.sleep(0.5)

# 6. Pull
pcap_local = os.path.join(ROOT, "data", "output", "mv2_debug.pcap")
os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
r = subprocess.run([ADB, "-s", DEVICE, "pull", "/data/local/tmp/mv2.pcap", pcap_local], capture_output=True)
print(f"Pull: rc={r.returncode}, stderr={r.stderr.decode().strip()}")

if os.path.exists(pcap_local):
    sz = os.path.getsize(pcap_local)
    print(f"Pcap size: {sz} bytes")
    
    from test_open_shop import parse_pcap_recv
    packets = parse_pcap_recv(pcap_local, port)
    print(f"Packets parsed: {len(packets)}")
    
    opcodes = {}
    for op, body in packets:
        opcodes[op] = opcodes.get(op, 0) + 1
    print(f"Opcode distribution: {opcodes}")
    
    # Show opcode 9 specifically
    op9_count = 0
    for op, body in packets:
        if op == 9:
            op9_count += 1
            try:
                text = body.decode('utf-8', errors='replace')
                parts = text.split('|')
                if len(parts) >= 4:
                    etype, eid, px, py = parts[0], parts[1], parts[2], parts[3]
                    gx, gy = int(px) // 256, int(py) // 256
                    print(f"  op9: etype={etype} eid={eid} game=({gx},{gy})")
            except:
                pass
    print(f"Opcode 9 count: {op9_count}")
else:
    print("NO PCAP FILE FOUND!")
