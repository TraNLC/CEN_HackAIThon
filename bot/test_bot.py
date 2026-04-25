"""
test_bot.py — Test bot: mount/dismount via Il2cpp hook verification
"""
import time
from game_bot import VLTK1Bot

print('Testing VLTK1 Bot - Mount/Dismount...')
bot = VLTK1Bot()

if bot.connect():
    time.sleep(2)

    print('\n[*] Sending set_riding(True) - watch for Il2cpp events above...')
    bot.set_riding(True)
    time.sleep(3)

    print('\n[*] Sending set_riding(False)...')
    bot.set_riding(False)
    time.sleep(3)

    pkts = bot.poll_recv()
    print(f'\n[*] Recv packets: {len(pkts)}')
    for p in pkts[:5]:
        print(f'  << {p}')

    bot.close()
    print('[*] Done.')
