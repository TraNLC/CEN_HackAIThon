import frida
import time
import os

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
ROOT_DIR = os.path.dirname(SCRIPT_DIR)
FRIDA_SCRIPT_PATH = os.path.join(ROOT_DIR, "features", "bot", "frida_bot.js")

def on_message(message, data):
    if message['type'] == 'send':
        payload = message['payload']
        if payload.get('type') in ['info', 'error']:
            print(f"[Frida] {payload}")

def main():
    print("[*] Connecting to emulator-5554...")
    device = frida.get_device_manager().get_device('emulator-5554')
    
    print("[*] Attaching to VLTieuNgao...")
    session = device.attach("VLTieuNgao")
    
    print("[*] Loading frida_bot.js...")
    with open(FRIDA_SCRIPT_PATH, 'r', encoding='utf-8') as f:
        script_code = f.read()
        
    script = session.create_script(script_code)
    script.on('message', on_message)
    script.load()
    
    time.sleep(2) # Wait for IL2CPP initialization
    
    # Test reading position
    print("\n[*] Reading position from memory...")
    pos = script.exports.read_position_from_memory()
    print(f"Result: {pos}")
    
    if pos.get('ok'):
        cur_x, cur_y = pos['x'], pos['y']
        print(f"[*] Current Position: ({cur_x}, {cur_y})")
        
        # Test movement
        target_x = cur_x + 20
        target_y = cur_y + 20
        print(f"\n[*] Calling gotopath({target_x}, {target_y})...")
        res = script.exports.gotopath(target_x, target_y)
        print(f"Result: {res}")
        
        print("[*] Waiting 5 seconds to observe movement...")
        for i in range(5):
            time.sleep(1)
            new_pos = script.exports.read_position_from_memory()
            if new_pos.get('ok'):
                print(f"  Pos: ({new_pos['x']}, {new_pos['y']})")
    
    session.detach()

if __name__ == '__main__':
    main()
