import sys, time
sys.path.insert(0, 'e:/tool/sample-test/vltk1-re')
sys.path.insert(0, 'e:/tool/sample-test/vltk1-re/proto')
from features.bot.game_bot import VLTK1Bot

bot = VLTK1Bot()
if bot.connect():
    print('[+] Connected. Sending eMapDialogNpcListRequest mapId=1')
    bot.send_gs('eMapDialogNpcListRequest', mapId=1)
    
    received = []
    
    for i in range(12):
        pkts = bot.poll_recv()
        if isinstance(pkts, list):
            for pkt in pkts:
                name = pkt.get('name', '')
                raw = pkt.get('raw', '')[:60]
                print(f'[PKT] {name} | raw={raw}')
                if name == 'eMapDialogNpcListResponse':
                    received.append(pkt)
        if received:
            break
        time.sleep(0.5)
    
    if received:
        print('[+] Got NpcListResponse!')
        print(received[0])
    else:
        print('[-] No response after 6s')
    bot.close()
