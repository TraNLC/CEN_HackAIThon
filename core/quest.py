"""
core/quest.py - Đọc nhiệm vụ Dã Tẩu từ network protocol

Opcodes:
  34 = NPC Dialog (quest text + buttons) — gửi khi tap NPC
  54 = Quest tracker (active quest data) — gửi khi nhận NV mới

Opcode 54 structure:
  f1 (string): Quest/task ID
  f2 (varint):  Quest number (thứ X)
  f4 (varint):  NPC world X coord
  f5 (varint):  NPC world Y coord
  f7 (string):  Item name (e.g. "Cửu Tiết Xương Vĩ Ngoa")
  f8 (varint):  Item count
  f9 (varint):  Unknown
  f10 (varint): Unknown (1080 = NPC ID?)
  f11 (varint): Element type code

100% protocol, không OCR.
"""
import re
import struct
import time
import os
import sys
import subprocess
import logging
from typing import Optional, Tuple, List
from dataclasses import dataclass, field

logger = logging.getLogger("core.quest")

COORD_DIVISOR = 256

# ── Quest data structures ──

@dataclass
class QuestInfo:
    """Parsed quest information from Dã Tẩu."""
    quest_id: str = ""          # Quest/task ID
    quest_number: int = 0       # "Nhiệm vụ thứ X"
    item_name: str = ""         # e.g. "Dây Chuyền", "Cửu Tiết Xương Vĩ Ngoa"
    item_count: int = 1         # e.g. 1
    element: str = ""           # e.g. "Thủy", "Hỏa", "Thổ", "Kim", "Mộc"
    element_code: int = 0       # Raw element code
    remaining: int = 0          # "còn X nhiệm vụ để hoàn thành"
    npc_world_x: int = 0       # NPC world X coordinate
    npc_world_y: int = 0       # NPC world Y coordinate
    raw_text: str = ""          # Full raw text (from opcode 34)
    clean_text: str = ""        # Text with color tags removed
    buttons: list = field(default_factory=list)
    opcode: int = 0             # Source opcode (34 or 54)
    
    @property
    def is_valid(self) -> bool:
        return self.item_name != ""
    
    @property
    def npc_game_coords(self) -> Tuple[int, int]:
        """NPC position in game tile coordinates."""
        if self.npc_world_x > 0:
            return self.npc_world_x // COORD_DIVISOR, self.npc_world_y // COORD_DIVISOR
        return 0, 0
    
    def __repr__(self):
        coords = self.npc_game_coords
        parts = [f"Quest #{self.quest_number}: {self.item_count}x {self.item_name}"]
        if self.element:
            parts.append(f"hệ {self.element}")
        if coords[0] > 0:
            parts.append(f"@ ({coords[0]}, {coords[1]})")
        if self.remaining > 0:
            parts.append(f"| Còn {self.remaining} NV")
        return " ".join(parts)


# ── Element mapping ──
# TODO: Xác nhận mapping chính xác bằng cách capture nhiều quest
ELEMENT_MAP = {
    1: "Kim",
    2: "Mộc", 
    3: "Thủy",
    4: "Hỏa",
    5: "Thổ",
}

# ── Color tag patterns ──
COLOR_TAG_RE = re.compile(r'</?color[^>]*>')
QUEST_NUM_RE = re.compile(r'Nhiệm vụ thứ (\d+)')
ITEM_RE = re.compile(r'cho ta\s+(\d+)\s*(?:cái|chiếc|thanh|cây|bộ|viên)?\s*(.+?)\s*hệ\s*(Thủy|Hỏa|Thổ|Kim|Mộc)', re.IGNORECASE)
REMAINING_RE = re.compile(r'còn\s*(\d+)\s*nhiệm vụ')


def strip_color_tags(text: str) -> str:
    """Remove Unity/game color tags from text."""
    return COLOR_TAG_RE.sub('', text)


def _read_varint(data, pos):
    """Read protobuf varint."""
    result = 0
    shift = 0
    while pos < len(data):
        b = data[pos]
        pos += 1
        result |= (b & 0x7F) << shift
        if not (b & 0x80):
            break
        shift += 7
    return result, pos


def parse_opcode54(body: bytes) -> Optional[QuestInfo]:
    """Parse opcode 54 (quest tracker) packet body.
    
    Protobuf structure:
      f1 (string): Quest ID
      f2 (varint): Quest number
      f4 (varint): NPC world X
      f5 (varint): NPC world Y
      f7 (string): Item name
      f8 (varint): Item count
      f11 (varint): Element code
    """
    info = QuestInfo(opcode=54)
    pos = 0
    
    while pos < len(body):
        try:
            tag, pos = _read_varint(body, pos)
        except:
            break
        if pos > len(body):
            break
        
        fnum = tag >> 3
        wtype = tag & 0x7
        
        if wtype == 0:
            val, pos = _read_varint(body, pos)
            if fnum == 2:
                info.quest_number = val
            elif fnum == 4:
                info.npc_world_x = val
            elif fnum == 5:
                info.npc_world_y = val
            elif fnum == 8:
                info.item_count = val
            elif fnum == 11:
                info.element_code = val
                info.element = ELEMENT_MAP.get(val, f"?({val})")
        elif wtype == 2:
            ln, pos = _read_varint(body, pos)
            if pos + ln > len(body):
                break
            raw = body[pos:pos+ln]
            pos += ln
            try:
                decoded = raw.decode('utf-8')
                if fnum == 1:
                    info.quest_id = decoded
                elif fnum == 7:
                    info.item_name = decoded
            except:
                pass
        elif wtype == 5:
            pos += 4
        elif wtype == 1:
            pos += 8
        else:
            break
    
    return info if info.is_valid else None


def parse_opcode34(body: bytes) -> Optional[QuestInfo]:
    """Parse opcode 34 (NPC dialog) packet body.
    
    Protobuf structure:
      field 1 (string): Dialog text (quest description with color tags)
      field 2 (repeated string): Button labels
    """
    text = ""
    buttons = []
    pos = 0
    
    while pos < len(body):
        try:
            tag, pos = _read_varint(body, pos)
        except:
            break
        if pos > len(body):
            break
        
        fnum = tag >> 3
        wtype = tag & 0x7
        
        if wtype == 0:
            val, pos = _read_varint(body, pos)
        elif wtype == 2:
            ln, pos = _read_varint(body, pos)
            if pos + ln > len(body):
                break
            raw = body[pos:pos+ln]
            pos += ln
            try:
                decoded = raw.decode('utf-8')
                if fnum == 1:
                    text = decoded
                elif fnum == 2:
                    buttons.append(decoded)
            except:
                pass
        elif wtype == 5:
            pos += 4
        elif wtype == 1:
            pos += 8
        else:
            break
    
    if not text:
        return None
    
    # Parse quest text
    info = QuestInfo(opcode=34)
    info.raw_text = text
    info.clean_text = strip_color_tags(text)
    info.buttons = buttons
    
    # Extract quest number
    m = QUEST_NUM_RE.search(info.clean_text)
    if m:
        info.quest_number = int(m.group(1))
    
    # Extract item + element
    m = ITEM_RE.search(info.clean_text)
    if m:
        info.item_count = int(m.group(1))
        info.item_name = m.group(2).strip()
        info.element = m.group(3)
    
    # Extract remaining
    m = REMAINING_RE.search(info.clean_text)
    if m:
        info.remaining = int(m.group(1))
    
    return info if info.is_valid else None


class QuestReader:
    """Read Dã Tẩu quest info from game via tcpdump capture.
    
    Supports:
      - Opcode 54: Quest tracker (sent when accepting quest)
      - Opcode 34: NPC dialog (sent when tapping NPC)
    
    Usage:
        reader = QuestReader()
        quest = reader.read_current_quest(npc_tap=(440, 70))
        if quest and quest.is_valid:
            print(f"Find {quest.item_count}x {quest.item_name}")
    """
    
    def __init__(self, config: dict = None):
        self.config = config or {}
        self.adb = self.config.get("adb_path", r"C:\platform-tools\adb.exe")
        self.device_id = self.config.get("device_id", "emulator-5554")
        self._game_port = 0
    
    def _detect_port(self) -> int:
        if self._game_port:
            return self._game_port
        try:
            out = subprocess.check_output(
                [self.adb, "-s", self.device_id, "shell",
                 'su -c "netstat -tnp 2>/dev/null"'],
                timeout=5).decode()
            for line in out.splitlines():
                if 'jx1mobile' in line and 'ESTABLISHED' in line:
                    port = int(line.split()[4].split(':')[-1])
                    if port > 1024:
                        self._game_port = port
                        return port
        except:
            pass
        return 45676
    
    def _capture_packets(self, duration: float = 5.0) -> list:
        """Capture game packets via tcpdump."""
        port = self._detect_port()
        pcap_dev = "/data/local/tmp/quest.pcap"
        pcap_local = os.path.join(
            os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
            "data", "output", "quest.pcap")
        
        os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
        
        subprocess.run([self.adb, "-s", self.device_id, "shell",
                        'su -c "killall tcpdump 2>/dev/null"'],
                       capture_output=True, timeout=5)
        subprocess.run([self.adb, "-s", self.device_id, "shell",
                        f'su -c "rm {pcap_dev} 2>/dev/null"'],
                       capture_output=True, timeout=5)
        time.sleep(0.2)
        
        proc = subprocess.Popen(
            [self.adb, "-s", self.device_id, "shell",
             f'su -c "tcpdump -i any -U -w {pcap_dev} -c 3000 port {port}"'],
            stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
        
        time.sleep(duration)
        
        subprocess.run([self.adb, "-s", self.device_id, "shell",
                        'su -c "killall tcpdump 2>/dev/null"'],
                       capture_output=True, timeout=5)
        proc.terminate()
        time.sleep(0.5)
        
        subprocess.run([self.adb, "-s", self.device_id, "pull", pcap_dev, pcap_local],
                       capture_output=True, timeout=10)
        
        if not os.path.exists(pcap_local):
            return []
        
        sys.path.insert(0, os.path.join(
            os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "tests"))
        from test_open_shop import parse_pcap_recv
        
        return parse_pcap_recv(pcap_local, port)
    
    def _adb_tap(self, x: int, y: int):
        subprocess.run(
            [self.adb, "-s", self.device_id, "shell", f"input tap {x} {y}"],
            capture_output=True, timeout=5)
    
    def read_current_quest(self, npc_tap: Tuple[int, int] = None) -> Optional[QuestInfo]:
        """Read quest by capturing packets.
        
        Args:
            npc_tap: (x, y) coordinates to tap NPC Dã Tẩu.
                     If None, captures passively.
        
        Returns:
            QuestInfo if found, None otherwise.
        
        Searches for both opcode 34 (NPC dialog) and opcode 54 (quest tracker).
        """
        if npc_tap:
            port = self._detect_port()
            pcap_dev = "/data/local/tmp/quest.pcap"
            pcap_local = os.path.join(
                os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
                "data", "output", "quest.pcap")
            
            os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
            
            subprocess.run([self.adb, "-s", self.device_id, "shell",
                            'su -c "killall tcpdump 2>/dev/null"'],
                           capture_output=True, timeout=5)
            subprocess.run([self.adb, "-s", self.device_id, "shell",
                            f'su -c "rm {pcap_dev} 2>/dev/null"'],
                           capture_output=True, timeout=5)
            time.sleep(0.2)
            
            proc = subprocess.Popen(
                [self.adb, "-s", self.device_id, "shell",
                 f'su -c "tcpdump -i any -U -w {pcap_dev} -c 3000 port {port}"'],
                stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
            
            time.sleep(0.5)
            
            logger.info(f"Tapping NPC at ({npc_tap[0]}, {npc_tap[1]})")
            self._adb_tap(npc_tap[0], npc_tap[1])
            time.sleep(4)
            
            subprocess.run([self.adb, "-s", self.device_id, "shell",
                            'su -c "killall tcpdump 2>/dev/null"'],
                           capture_output=True, timeout=5)
            proc.terminate()
            time.sleep(0.5)
            
            subprocess.run([self.adb, "-s", self.device_id, "pull", pcap_dev, pcap_local],
                           capture_output=True, timeout=10)
            
            if not os.path.exists(pcap_local):
                logger.warning("Failed to capture packets")
                return None
            
            sys.path.insert(0, os.path.join(
                os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "tests"))
            from test_open_shop import parse_pcap_recv
            packets = parse_pcap_recv(pcap_local, port)
        else:
            packets = self._capture_packets(duration=3)
        
        # Search for quest opcodes (34 and 54)
        for opcode, body in packets:
            if opcode == 34 and len(body) > 10:
                quest = parse_opcode34(body)
                if quest and quest.is_valid:
                    logger.info(f"Quest from NPC dialog: {quest}")
                    return quest
            
            if opcode == 54 and len(body) > 10:
                quest = parse_opcode54(body)
                if quest and quest.is_valid:
                    logger.info(f"Quest from tracker: {quest}")
                    return quest
        
        logger.warning("No quest data found (opcode 34/54)")
        return None
    
    def dismiss_dialog(self, button_index: int = -1):
        """Dismiss current NPC dialog by tapping a button.
        
        button_index: 
            -1 = last button (usually "Biết rồi!")
             0 = first button ("Đã hoàn thành nv")
             1 = second button ("Ta muốn hủy nv")
        """
        button_positions = [
            (600, 348),  # Đã hoàn thành nv
            (680, 378),  # Ta muốn hủy nv
            (720, 418),  # Biết rồi!
        ]
        
        idx = button_index if button_index >= 0 else len(button_positions) - 1
        if idx < len(button_positions):
            x, y = button_positions[idx]
            self._adb_tap(x, y)
            time.sleep(0.5)
