"""Quick test: check SSL hooks + recv"""
import sys, os, time, subprocess
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from features.bot.game_bot import VLTK1Bot

ADB = r'C:\platform-tools\adb.exe'

# Custom message handler to see ALL messages
def on_msg(message, data):
    if message['type'] == 'send':
        p = message['payload']
        t = p.get('type', '')
        if t in ('ssl_hooks', 'ready', 'recv', 'send_out', 'game_fd', 'il2cpp_ready'):
            print(f"  [{t}] {p}")

bot = VLTK1Bot()
if not bot.connect():
    print("FAIL"); exit()

# Add extra message listener
bot.script.on('message', on_msg)
time.sleep(2)

print("\n--- Tap to trigger game packets ---")
subprocess.run([ADB, '-s', 'emulator-5554', 'shell', 'input', 'tap', '700', '335'], capture_output=True)
time.sleep(0.5)
subprocess.run([ADB, '-s', 'emulator-5554', 'shell', 'input', 'tap', '400', '300'], capture_output=True)
print("Waiting 5s for packets...")
time.sleep(5)

print("\n--- Check buffers ---")
print("readPosition:", bot.rpc.read_position())
pkts = bot.rpc.get_recv_packets()
print(f"recv packets: {len(pkts)}")
for p in pkts[:10]:
    print(f"  {p}")

spkts = bot.rpc.get_send_packets()
print(f"send packets: {len(spkts)}")
for p in spkts[:10]:
    print(f"  {p}")

bot.close()
