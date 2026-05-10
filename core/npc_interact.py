"""
core/npc_interact.py — Tương tác NPC + Đọc nhiệm vụ

Step 3: Click NPC Dã Tẩu
  - Khi đứng gần NPC, tap vào vùng NPC trên màn hình
  - Game hiện popup danh sách entities → click "Dã Tẩu"
  - Server gửi lại eContextDescription (opcode 166) chứa quest text

Step 4: Parse nội dung nhiệm vụ
  - Đọc packet opcode 166 từ Frida buffer
  - Parse protobuf → lấy contentPage (quest text) + selections (lựa chọn)
  - Phân loại quest: mua đồ / đánh quái / đi tới NPC

Usage:
    from core.adb_helper import ADBHelper
    from core.npc_interact import NPCInteract

    adb = ADBHelper()
    adb.init_frida()
    npc = NPCInteract(adb)
    npc.click_npc_datau()
    quest = npc.read_quest_dialog()
    print(quest)
"""
import os
import sys
import time
import struct
import logging

logger = logging.getLogger("npc")

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
ADB_PATH = r"C:\platform-tools\adb.exe"


def _read_varint(data: bytes, pos: int) -> tuple:
    """Đọc protobuf varint từ data[pos:]."""
    result = 0
    shift = 0
    while pos < len(data):
        b = data[pos]
        pos += 1
        result |= (b & 0x7F) << shift
        if (b & 0x80) == 0:
            break
        shift += 7
    return result, pos


def _decode_zigzag(n: int) -> int:
    """Decode ZigZag encoding (signed int)."""
    return (n >> 1) ^ -(n & 1)


def parse_context_description(body: bytes) -> dict:
    """Parse protobuf body của eContextDescription (opcode 166).

    Message ContextDescription:
        repeated string contentPage = 1;  // Quest text
        repeated string selections = 2;   // Lựa chọn (Nhận NV, Hủy NV...)
        int32 widthPercent = 3;
        int32 heightPercent = 4;
        int32 backgroundPadding = 5;
        int32 fadeSeconds = 6;
        string title = 7;
        int32 backgroundAlphaPercent = 8;

    Returns:
        {
            "content": ["dòng 1", "dòng 2", ...],
            "selections": ["Nhận nhiệm vụ", "Hủy nhiệm vụ", ...],
            "title": "Dã Tẩu",
            "raw": bytes
        }
    """
    result = {
        "content": [],
        "selections": [],
        "title": "",
        "raw": body,
    }
    pos = 0
    while pos < len(body):
        tag, pos = _read_varint(body, pos)
        if pos > len(body):
            break
        fnum = tag >> 3
        wtype = tag & 0x7

        if wtype == 0:  # varint
            val, pos = _read_varint(body, pos)
        elif wtype == 2:  # length-delimited
            ln, pos = _read_varint(body, pos)
            if pos + ln > len(body):
                break
            raw = body[pos:pos + ln]
            pos += ln

            if fnum == 1:  # contentPage
                try:
                    result["content"].append(raw.decode('utf-8'))
                except:
                    result["content"].append(raw.hex())
            elif fnum == 2:  # selections
                try:
                    result["selections"].append(raw.decode('utf-8'))
                except:
                    result["selections"].append(raw.hex())
            elif fnum == 7:  # title
                try:
                    result["title"] = raw.decode('utf-8')
                except:
                    pass
        elif wtype == 5:  # fixed32
            pos += 4
        elif wtype == 1:  # fixed64
            pos += 8
        else:
            break

    return result


def classify_quest(text: str) -> str:
    """Phân loại nhiệm vụ Dã Tẩu dựa vào nội dung.

    Returns:
        "buy_item"    — Mua đồ tại NPC shop
        "kill_mob"    — Đánh quái / tiêu diệt
        "goto_npc"    — Đi tới NPC khác
        "collect"     — Thu thập item drop
        "unknown"     — Không xác định
    """
    text_lower = text.lower()

    # Mua đồ
    if any(kw in text_lower for kw in ["tìm cho ta", "mua cho ta", "tìm mua",
                                        "tạp hóa", "chỗ bán", "mua đồ"]):
        return "buy_item"

    # Đánh quái
    if any(kw in text_lower for kw in ["tiêu diệt", "giết", "đánh bại",
                                        "hạ gục", "quái vật", "con quái"]):
        return "kill_mob"

    # Đi tới NPC
    if any(kw in text_lower for kw in ["đến chỗ", "tới gặp", "ghé thăm",
                                        "tìm đến", "đến gặp"]):
        return "goto_npc"

    # Thu thập
    if any(kw in text_lower for kw in ["nhặt", "thu thập", "lượm"]):
        return "collect"

    return "unknown"


class NPCInteract:
    """Tương tác với NPC trong game."""

    # Tọa độ tap vùng NPC trên màn hình (khi đã đứng gần)
    # Dựa trên ảnh screenshot, khi đứng ở 203 198, Dã Tẩu nằm ở bên phải nhân vật
    NPC_TAP_AREA = (490, 260)

    # Tọa độ các dòng trong popup danh sách entity
    # Popup hiển thị từ trên xuống, mỗi dòng cách ~25px
    POPUP_LINE_Y_START = 90
    POPUP_LINE_HEIGHT = 25
    POPUP_X = 170

    def __init__(self, adb_helper):
        self.adb = adb_helper

    def click_npc_datau(self, max_retry=3) -> bool:
        """Click vào NPC Dã Tẩu.

        Flow:
        1. Tap vào vùng NPC trên màn hình
        2. Chờ 1 chút để dialog mở ra

        Returns:
            True luôn vì ta sẽ dùng Memory Scan để verify dialog ở hàm read_quest_dialog.
        """
        logger.info("Clicking NPC Da Tau...")

        # Tap vào vùng NPC
        self.adb.tap(*self.NPC_TAP_AREA)
        time.sleep(1.0)
        
        return True

    def _parse_npc_dialog_from_pcap(self, pcap_path: str, port: int) -> dict:
        """(Deprecated) Bỏ qua việc đọc pcap do game đã mã hóa SSL."""
        return None

    def read_quest_dialog(self, timeout=5) -> dict:
        """Đọc nội dung quest từ NPC dialog bằng cách quét RAM (Frida Memory Hooking).

        Gọi SAU KHI đã click NPC thành công và dialog mở trên màn hình.

        Returns:
            {
                "content": ["quest text..."],
                "selections": [],
                "title": "Dã Tẩu",
                "quest_type": "buy_item" | "kill_mob" | "goto_npc" | "unknown",
                "full_text": "combined quest text"
            }
            Hoặc None nếu thất bại.
        """
        logger.info("Reading quest dialog from Memory (RAM Scan)...")

        js_code = """
        function scanMemoryForQuest() {
            var ranges = Process.enumerateRanges('rw-');
            var foundTexts = [];
            var searchCount = 0;
            
            for (var i = 0; i < ranges.length; i++) {
                var range = ranges[i];
                if (range.size < 4096 || range.size > 1024 * 1024 * 10) continue;
                
                try {
                    // Quét chuỗi "Nhi" trong UTF-16LE
                    Memory.scanSync(range.base, range.size, "4E 00 68 00 69 00").forEach(function(match) {
                        try {
                            var str = match.address.readUtf16String(300); 
                            if (str && str.indexOf("Nhiệm vụ") !== -1 && 
                               (str.indexOf("tìm cho ta") !== -1 || str.indexOf("hoàn thành") !== -1 || str.indexOf("đánh bại") !== -1)) {
                                foundTexts.push(str);
                            }
                        } catch(e) {}
                    });
                    searchCount++;
                    if (searchCount > 100 && foundTexts.length > 0) break;
                } catch (e) {}
            }
            
            if (foundTexts.length > 0) {
                var uniqueTexts = [];
                for (var i=0; i<foundTexts.length; i++) {
                    if (uniqueTexts.indexOf(foundTexts[i]) === -1) uniqueTexts.push(foundTexts[i]);
                }
                send({type: "success", data: uniqueTexts});
            } else {
                send({type: "error"});
            }
        }
        rpc.exports = { scanQuest: scanMemoryForQuest };
        """

        if not self.adb.frida_session:
            logger.error("No Frida session available for RAM scan.")
            return None

        result_data = []
        def on_message(message, data):
            if message['type'] == 'send':
                if message['payload']['type'] == 'success':
                    result_data.extend(message['payload']['data'])

        script = self.adb.frida_session.create_script(js_code)
        script.on('message', on_message)
        script.load()

        start = time.time()
        while time.time() - start < timeout:
            script.exports_sync.scan_quest()
            if result_data:
                # Đã tìm thấy chuỗi trong RAM
                full_text = result_data[0]
                # Cleanup color tags (e.g. <color=#ffff00>)
                import re
                clean_text = re.sub(r'<[^>]+>', '', full_text)
                
                dialog = {
                    "title": "Dã Tẩu",
                    "content": [clean_text],
                    "full_text": clean_text,
                    "quest_type": classify_quest(clean_text),
                    "selections": ["Nhận nhiệm vụ", "Hủy nhiệm vụ"]
                }
                
                logger.info(f"  Quest: {clean_text[:80]}...")
                logger.info(f"  Type: {dialog['quest_type']}")
                
                script.unload()
                return dialog
                
            time.sleep(1)

        logger.warning("No quest dialog found in RAM")
        script.unload()
        return None

    def accept_quest(self):
        """Nhận nhiệm vụ (click lựa chọn đầu tiên trong dialog)."""
        self.adb.tap(400, 400)
        time.sleep(0.5)
        logger.info("Quest accepted")

    def dismiss_dialog(self):
        """Đóng dialog NPC."""
        self.adb.keyevent(111)  # ESC
        time.sleep(0.3)
        logger.info("Dialog dismissed")
