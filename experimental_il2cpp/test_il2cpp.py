"""
experimental_il2cpp/test_il2cpp.py

Script Python để test giải pháp Memory Hooking bằng Frida.
Nó sẽ nạp il2cpp_bot.js vào game và thử quét bộ nhớ.
"""

import frida
import time
import sys
import os

sys.stdout.reconfigure(encoding='utf-8')
ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)
DEVICE_ID = "emulator-5554"
PACKAGE = "VLTieuNgao" # Tên process của game

def on_message(message, data):
    if message['type'] == 'send':
        payload = message['payload']
        msg_type = payload.get('type', 'info')
        msg = payload.get('msg', payload)
        
        if msg_type == 'error':
            print(f"[❌ ERROR] {msg}")
        elif msg_type == 'success':
            print(f"[✅ SUCCESS] {msg}")
        else:
            print(f"[ℹ️ INFO] {msg}")
    elif message['type'] == 'error':
        print(f"[🔥 FRIDA ERROR] {message['stack']}")

def main():
    print("="*50)
    print("  TEST IL2CPP MEMORY HOOKING POC")
    print("="*50)
    
    try:
        from core.adb_helper import ADBHelper
        print(f"Connecting via ADBHelper to {DEVICE_ID}...")
        adb = ADBHelper(DEVICE_ID)
        adb.init_frida()
        
        if not adb.frida_session:
            print("[!] Không thể attach Frida qua ADBHelper.")
            return
            
        session = adb.frida_session
        print(f"Attached successfully to pid={session._impl.pid}")
        
        script_path = os.path.join(os.path.dirname(__file__), "il2cpp_bot.js")
        with open(script_path, 'r', encoding='utf-8') as f:
            js_code = f.read()
            
        print("Loading JS Script...")
        script = session.create_script(js_code)
        script.on('message', on_message)
        script.load()
        
        time.sleep(1)
        print("\n--- Bắt đầu Hook vào Memory ---")
        success = script.exports_sync.test_memory_hook()
        
        if success:
            print("\n>> Bạn đã sẵn sàng để gọi thẳng các hàm của game (VD: Npc.ShowDialog)!")
            print(">> Trạng thái: " + script.exports_sync.scan_classes("Player"))
        else:
            print("\n>> Hook thất bại. Cần kiểm tra lại cấu trúc libil2cpp trên thiết bị này.")
            
        time.sleep(2)
        session.detach()
        
    except frida.ProcessNotFoundError:
        print(f"[!] Game chưa được mở. Vui lòng mở game {PACKAGE} trên giả lập.")
    except Exception as e:
        print(f"[!] Lỗi không xác định: {e}")

if __name__ == "__main__":
    main()
