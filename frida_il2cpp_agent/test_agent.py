import frida
import time
import sys
import os

sys.stdout.reconfigure(encoding='utf-8')
ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from core.adb_helper import ADBHelper

def on_message(message, data):
    if message['type'] == 'send':
        print(f"[*] {message['payload']}")
    elif message['type'] == 'error':
        print(f"[!] LỖI TỪ FRIDA:\n{message['stack']}")
    else:
        print(f"[?] {message}")

def main():
    print("="*50)
    print("  TEST TRUE MEMORY BOT (IL2CPP BRIDGE)")
    print("="*50)
    
    adb = ADBHelper("emulator-5554")
    adb.init_frida()
    
    if not adb.frida_session:
        print("[!] Không kết nối được Frida.")
        return
        
    print(f"Đã attach vào game (PID: {adb.frida_session._impl.pid})")
    
    print("Thử Re-attach với Realm=Emulated để xuyên qua Houdini...")
    device = frida.get_usb_device()
    session = device.attach("vn.perfingame.jx1mobile", realm="emulated")
    
    script_path = os.path.join(os.path.dirname(__file__), "bundled.js")
    with open(script_path, 'r', encoding='utf-8') as f:
        js_code = f.read()
        
    script = session.create_script(js_code)
    script.on('message', on_message)
    
    print("Đang Load Agent IL2CPP Bridge vào bộ nhớ Game...")
    script.load()
    
    print("\n--- HƯỚNG DẪN TEST ---")
    print("1. Hãy click Dã Tẩu 1 lần trong game để Tool bắt được địa chỉ (Instance).")
    print("2. Sau đó, chạy lại file này hoặc ra lệnh RPC để mở bảng Dã Tẩu từ xa!")
    
    # Giữ script chạy để lắng nghe console.log từ Frida
    try:
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        script.unload()
        print("Exiting...")

if __name__ == "__main__":
    main()
