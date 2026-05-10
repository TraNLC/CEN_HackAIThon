import frida
import time
import os

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
ROOT_DIR = os.path.dirname(SCRIPT_DIR)
FRIDA_SCRIPT_PATH = os.path.join(ROOT_DIR, "features", "bot", "frida_bot.js")
DEVICE = "emulator-5554"

def on_message(message, data):
    pass

def main():
    print("[*] Connecting...")
    device = frida.get_device_manager().get_device(DEVICE)
    session = device.attach("VLTieuNgao")
    
    with open(FRIDA_SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script = session.create_script(f.read())
        
    script.on('message', on_message)
    script.load()
    time.sleep(1)
    
    script.exports.get_send_packets()
    script.exports.get_recv_packets()
    
    print("[*] Please walk around in the game continuously...")
    print("[*] Recording movement packets (15s)...\n")
    
    opcodes_sent = set()
    for _ in range(15):
        time.sleep(1)
        pkts = script.exports.get_send_packets()
        for p in pkts:
            opcodes_sent.add(p['opcode'])
            if p['opcode'] in [20, 248, 117, 75]:
                print(f"  [+] Caught outgoing packet: {p['name']} (Opcode {p['opcode']}) len {p['size']}")
                
    print(f"\n[*] Opcodes sent in 15s: {opcodes_sent}")
    session.detach()

if __name__ == '__main__':
    main()
