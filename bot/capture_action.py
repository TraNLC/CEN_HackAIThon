"""
capture_action.py - Capture real game packets during manual user actions.
"""
import time
import sys
from game_bot import VLTK1Bot

print("=" * 55)
print("  CAPTURE MODE - Press mount/dismount in game now!")
print("=" * 55)

bot = VLTK1Bot()
if not bot.connect():
    sys.exit(1)

raw_sends = []

def capture_on_msg(message, data):
    if message['type'] == 'send':
        p = message['payload']
        if p.get('type') == 'send':
            hex_str = p.get('hex', '')
            fd = p.get('fd')
            size = p.get('size')
            print(f"[GAME->SV] fd={fd} size={size}")
            raw = bytes.fromhex(hex_str) if hex_str else b''
            for i in range(0, len(raw), 16):
                chunk = raw[i:i+16]
                print("  " + " ".join(f"{b:02x}" for b in chunk))
            raw_sends.append(hex_str)
        elif p.get('type') == 'raw_recv':
            hex_str = p.get('hex', '')
            size = p.get('size')
            print(f"[SV->GAME] size={size} | {hex_str}")

# Replace message handler
bot.script.off('message', bot._on_message)
bot.script.on('message', capture_on_msg)

print("\n[*] Hook active! Press MOUNT/DISMOUNT in game now...")
print("[*] Capturing 30 seconds...\n", flush=True)
time.sleep(30)

bot.close()
print(f"\n[*] Done. Captured {len(raw_sends)} send packets.")
if raw_sends:
    print("\n=== ALL SENT PACKETS ===")
    for i, h in enumerate(raw_sends):
        print(f"  [{i}] {h}")
