"""Debug: dump recv packets from Frida to see what's in the buffer."""
import sys, time, frida, subprocess
sys.stdout.reconfigure(encoding='utf-8')

dev = frida.get_device_manager().get_device('emulator-5554')
s = dev.attach('VLTieuNgao')
js = open('features/bot/frida_bot.js', 'r', encoding='utf-8').read()
sc = s.create_script(js)
sc.on('message', lambda m, d: None)
sc.load()
time.sleep(3)

subprocess.run([r'C:\platform-tools\adb.exe', '-s', 'emulator-5554', 'shell', 'input tap 480 300'], capture_output=True)
time.sleep(2)

pkts = sc.exports_sync.get_recv_packets()
pos = sc.exports_sync.read_position()
ping = sc.exports_sync.ping()

print(f"Position: {pos}")
print(f"Ping: {ping}")
print(f"Total packets in buffer: {len(pkts)}")
print()

# Show first 20 packets
for i, p in enumerate(pkts[:20]):
    print(f"  [{i:>3}] opcode={p['opcode']:>4}  name={p['name'][:30]:30}  size={p['size']}")

# Count opcodes
from collections import Counter
opcodes = Counter(p['opcode'] for p in pkts)
print(f"\nOpcode distribution:")
for op, cnt in opcodes.most_common(15):
    print(f"  opcode {op:>4}: {cnt:>3}x")

s.detach()
