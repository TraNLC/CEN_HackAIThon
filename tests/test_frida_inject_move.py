import frida
import time
import os
import struct
import subprocess

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
ROOT_DIR = os.path.dirname(SCRIPT_DIR)
FRIDA_SCRIPT_PATH = os.path.join(ROOT_DIR, "features", "bot", "frida_bot.js")
ADB = r"C:\platform-tools\adb.exe"
DEVICE = "emulator-5554"

def adb_tap(x, y):
    subprocess.run([ADB, "-s", DEVICE, "shell", f"input tap {x} {y}"], capture_output=True)

def on_message(message, data):
    if message['type'] == 'send':
        payload = message['payload']
        if payload.get('type') in ['info', 'error']:
            print(f"[Frida] {payload}")

def main():
    print("[*] Connecting to emulator-5554...")
    try:
        device = frida.get_device_manager().get_device(DEVICE)
    except Exception as e:
        print(f"Error connecting: {e}")
        return
        
    print("[*] Attaching to VLTieuNgao...")
    try:
        session = device.attach("VLTieuNgao")
    except Exception as e:
        print(f"Error attaching: {e}")
        return
        
    print("[*] Loading frida_bot.js...")
    with open(FRIDA_SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()
        
    script = session.create_script(script_code)
    script.on('message', on_message)
    script.load()
    
    time.sleep(1)
    
    # Xóa buffer cũ
    script.exports.get_send_packets()
    script.exports.get_recv_packets()
    
    # 1. Read current position from Opcode 9
    print("\n[*] Listening for position from network (wait 2s)...")
    time.sleep(2)
    pos = script.exports.read_position()
    print(f"[*] Caught position: {pos}")
    
    # 2. Wait for user to move
    print("\n[*] Please tap the screen in-game to start running...")
    
    # 3. Get sent packets
    move_pkt = None
    for _ in range(15): # Wait up to 15 seconds
        send_pkts = script.exports.get_send_packets()
        for pkt in send_pkts:
            if pkt.get('opcode') in [20, 248, 117]:
                move_pkt = pkt
                break
        if move_pkt:
            break
        time.sleep(1)
    
    for pkt in send_pkts:
        if pkt.get('opcode') in [20, 248, 117]:
            move_pkt = pkt
            break
            
    if not move_pkt:
        print("[-] No move packet caught (Opcode 20/248).")
    else:
        print(f"[+] Caught move packet: {move_pkt['name']} (Opcode {move_pkt['opcode']})")
        print(f"    Raw Hex: {move_pkt['hex']}")
        
        # 4. Inject!
        print("\n[*] INJECTION: Shooting packet back into socket...")
        for i in range(3):
            res = script.exports.ssl_send(move_pkt['hex'])
            print(f"    -> Shot {i+1}: {res}")
            time.sleep(0.5)
            
    print("\n[*] Done!")
    session.detach()

if __name__ == '__main__':
    main()
