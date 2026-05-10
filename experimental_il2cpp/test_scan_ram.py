import frida
import time
import sys
import os

sys.stdout.reconfigure(encoding='utf-8')
ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from core.adb_helper import ADBHelper

JS_CODE = """
function scanMemoryForQuest() {
    send({type: "info", msg: "Đang quét RAM tìm nội dung nhiệm vụ..."});
    
    // Tìm các chuỗi UTF-16 đặc trưng của nhiệm vụ Dã Tẩu
    // Chữ "Nhiệm vụ thứ" trong UTF-16 LE: 4E 00 68 00 69 00 E7 1EC7 00 6D 00 20 00 76 00 E5 1EE5 00
    // Hoặc quét chuỗi ASCII "Nhi" rồi lọc
    
    // Tìm các vùng nhớ Read/Write
    var ranges = Process.enumerateRanges('rw-');
    var foundTexts = [];
    var searchCount = 0;
    
    for (var i = 0; i < ranges.length; i++) {
        var range = ranges[i];
        // Bỏ qua các vùng nhớ quá nhỏ hoặc quá lớn để tăng tốc
        if (range.size < 4096 || range.size > 1024 * 1024 * 10) continue;
        
        try {
            // Quét chuỗi "Nhi" trong UTF-16LE (4E 00 68 00 69 00)
            Memory.scanSync(range.base, range.size, "4E 00 68 00 69 00").forEach(function(match) {
                try {
                    // Đọc lùi lại 4 byte để xem có phải C# string length không
                    // Đọc nội dung string UTF-16
                    var str = match.address.readUtf16String(300); 
                    if (str && str.indexOf("Nhiệm vụ") !== -1 && 
                       (str.indexOf("tìm cho ta") !== -1 || str.indexOf("hoàn thành") !== -1 || str.indexOf("đánh bại") !== -1)) {
                        foundTexts.push(str);
                    }
                } catch(e) {}
            });
            searchCount++;
            if (searchCount > 100 && foundTexts.length > 0) break; // Dừng sớm nếu đã tìm thấy
        } catch (e) {}
    }
    
    if (foundTexts.length > 0) {
        // Lọc các chuỗi trùng lặp
        var uniqueTexts = [];
        for (var i=0; i<foundTexts.length; i++) {
            if (uniqueTexts.indexOf(foundTexts[i]) === -1) uniqueTexts.push(foundTexts[i]);
        }
        send({type: "success", msg: "TÌM THẤY TRONG RAM!", data: uniqueTexts});
    } else {
        send({type: "error", msg: "Không tìm thấy chuỗi nhiệm vụ trong RAM."});
    }
}

rpc.exports = {
    scanQuest: scanMemoryForQuest
};
"""

def on_message(message, data):
    if message['type'] == 'send':
        payload = message['payload']
        msg_type = payload.get('type', 'info')
        if msg_type == 'success':
            print(f"\n[✅ SUCCESS] {payload['msg']}")
            for t in payload['data']:
                print(f"  -> {t}")
        elif msg_type == 'error':
            print(f"\n[❌ ERROR] {payload['msg']}")
        else:
            print(f"[*] {payload.get('msg', payload)}")
    elif message['type'] == 'error':
        print(f"[!] FRIDA ERROR: {message['stack']}")

def main():
    print("="*50)
    print("  TEST SCAN RAM TÌM NHIỆM VỤ DÃ TẨU")
    print("="*50)
    
    adb = ADBHelper("emulator-5554")
    adb.init_frida()
    
    if not adb.frida_session:
        print("[!] Không kết nối được Frida.")
        return
        
    print(f"Đã attach vào game (PID: {adb.frida_session._impl.pid})")
    
    script = adb.frida_session.create_script(JS_CODE)
    script.on('message', on_message)
    script.load()
    
    print("\nĐang ra lệnh quét RAM... (có thể mất 2-5 giây)")
    script.exports_sync.scan_quest()
    
    time.sleep(1)
    adb.frida_session.detach()

if __name__ == "__main__":
    main()
