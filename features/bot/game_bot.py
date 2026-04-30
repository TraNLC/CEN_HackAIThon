"""
game_bot.py 鈥?VLTK1 Bot Controller
Connect Frida to game, inject hooks, call RPC to control character.

Usage:
    python bot/game_bot.py        (interactive shell)
    python bot/test_bot.py        (test run)
"""
import sys
import time
import struct
import subprocess
import threading
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent.parent.parent / 'proto'))
from vltk1_protocol import encode_message_fields, GS_OPCODES_REV, MESSAGES

import frida

PACKAGE     = 'vn.perfingame.jx1mobile'
ADB         = r'C:\platform-tools\adb.exe'
DEVICE_ID   = 'emulator-5554'
SCRIPT_PATH = Path(__file__).parent / 'frida_bot.js'


class VLTK1Bot:
    """VLTK1 Game Bot 鈥?Frida socket injection."""

    def __init__(self):
        self.session  = None
        self.script   = None
        self.rpc      = None
        self.game_fd  = -1
        self.running  = False
        self._recv_handlers = {}

    # ==================== CONNECTION ====================

    def connect(self) -> bool:
        """Attach Frida to the game process."""
        print('[*] Connecting...')

        # Find device
        device = None
        for d in frida.enumerate_devices():
            if DEVICE_ID in d.id or d.type == 'usb':
                device = d
                break
        if not device:
            print('[-] Device not found')
            return False
        print(f'[+] Device: {device.name} ({device.id})')

        # Find PID via ADB (more reliable on emulator than frida enumerate)
        try:
            out = subprocess.check_output(
                f'{ADB} -s {DEVICE_ID} shell "pidof {PACKAGE}"',
                shell=True, timeout=5
            ).decode().strip()
            if not out:
                print(f'[-] Game not running. Start {PACKAGE} first.')
                return False
            pid = int(out.split()[0])
            print(f'[+] PID: {pid}')
        except Exception as e:
            print(f'[-] Could not get PID: {e}')
            return False

        # Attach
        try:
            self.session = device.attach(pid)
        except Exception as e:
            print(f'[-] Attach failed: {e}')
            return False

        # Load script
        js = SCRIPT_PATH.read_text(encoding='utf-8')
        self.script = self.session.create_script(js)
        self.script.on('message', self._on_message)
        self.script.load()
        self.rpc = self.script.exports_sync
        print('[+] Script loaded.')

        # Give hooks time to settle, then detect game fd
        time.sleep(2)
        status = self.rpc.ping()
        self.game_fd = status.get('gameFd', -1)

        if self.game_fd < 0:
            fd = self._auto_detect_fd()
            if fd > 0:
                print(f'[*] Auto-detected game fd: {fd}')
                self.set_game_fd(fd)
            else:
                print('[!] Game fd not detected. Play the game to trigger connection.')
        else:
            print(f'[+] Game fd: {self.game_fd}')

        self.running = True
        return True

    def _auto_detect_fd(self) -> int:
        """Detect game server socket fd via /proc/net/tcp."""
        try:
            pid_out = subprocess.check_output(
                f'{ADB} -s {DEVICE_ID} shell "pidof {PACKAGE}"',
                shell=True, timeout=5
            ).decode().strip()
            pid = int(pid_out.split()[0])

            tcp = subprocess.check_output(
                f'{ADB} -s {DEVICE_ID} shell "cat /proc/{pid}/net/tcp"',
                shell=True, timeout=5
            ).decode()

            # Find established connections and their inodes
            inodes = {}
            for line in tcp.split('\n')[1:]:
                parts = line.split()
                if len(parts) >= 10 and parts[3] == '01':  # ESTABLISHED
                    inodes[parts[9]] = parts[2]  # inode -> remote hex

            fds = subprocess.check_output(
                f'{ADB} -s {DEVICE_ID} shell "ls -l /proc/{pid}/fd"',
                shell=True, timeout=5
            ).decode()

            for line in fds.split('\n'):
                if 'socket:[' not in line:
                    continue
                inode = line.split('socket:[')[1].split(']')[0]
                if inode not in inodes:
                    continue
                port = int(inodes[inode].split(':')[1], 16)
                if port > 1000 and port not in (5555, 5037, 27042):
                    # Extract fd number
                    parts = line.split()
                    for j, p in enumerate(parts):
                        if p == '->' and j > 0:
                            return int(parts[j - 1])
        except Exception as e:
            print(f'[!] Auto-detect fd failed: {e}')
        return -1

    def set_game_fd(self, fd: int):
        """Set the game socket fd."""
        self.rpc.set_game_fd(fd)
        self.game_fd = fd
        print(f'[+] Game fd set to {fd}')

    def _on_message(self, message, data):
        """Handle messages from Frida script."""
        if message['type'] != 'send':
            return
        p = message['payload']
        t = p.get('type', '')

        if t == 'ready':
            hooks = p.get('hooks', {})
            ok = sum(1 for v in hooks.values() if v)
            print(f'[+] Socket hooks: {ok}/{len(hooks)}')

        elif t == 'il2cpp_ready':
            lib = p.get('lib')
            if lib:
                print(f'[+] Il2cpp hooks: {lib} @ {p.get("base")}')
            else:
                print(f'[!] Il2cpp: {p.get("msg", "not found")}')

        elif t == 'il2cpp_event':
            print(f'[IL2CPP] {p.get("event")} {p}')

        elif t == 'il2cpp_send':
            print(f'[IL2CPP SEND] id={p.get("id")} name={p.get("name")}')

        elif t == 'game_fd':
            self.game_fd = p['fd']
            print(f'[+] Game server: {p["ip"]}:{p["port"]} fd={self.game_fd}')

        elif t == 'recv':
            name = p.get('name', '')
            if name in self._recv_handlers:
                self._recv_handlers[name](p)

        elif t == 'send':
            print(f'[RAW SEND] fd={p.get("fd")} size={p.get("size")} | {p.get("hex")}')
        elif t == 'send_log':
            print(f'[OUT -> Server] Opcode: {p.get("opcode")} | Hex: {p.get("hex")}')

        elif t == 'error':
            print(f'[-] Script error: {p.get("msg")}')

        elif t == 'il2cpp_error':
            print(f'[-] Il2cpp error: {p.get("msg")}')

        elif t == 'info':
            print(f'[i] {p.get("msg")}')

    # ==================== SEND ====================

    def send_raw(self, data: bytes) -> bool:
        result = self.rpc.send_raw(data.hex())
        return result.get('ok', False)

    def send_gs(self, opcode_name: str, **kwargs) -> bool:
        """Build and send a game server packet.

        Packet format (confirmed via disassembly of SendGSMessage):
          [uint32 LE proto_len] [uint16 LE opcode] [proto body]
        """
        oid = GS_OPCODES_REV.get(opcode_name)
        if oid is None:
            print(f'[-] Unknown opcode: {opcode_name}')
            return False

        msg_class = opcode_name[1:] if opcode_name.startswith('e') else opcode_name
        proto = encode_message_fields(msg_class, **kwargs) if (msg_class in MESSAGES and kwargs) else b''

        # Header: uint32 proto_len + uint16 opcode
        packet = struct.pack('<IH', len(proto), oid) + proto
        return self.send_raw(packet)

    # ==================== RECEIVE ====================

    def on_recv(self, opcode_name: str, handler):
        """Register handler for incoming packet type."""
        self._recv_handlers[opcode_name] = handler

    def poll_recv(self):
        """Poll buffered received packets from Frida."""
        return self.rpc.get_recv_packets()

    # ==================== GAME ACTIONS ====================

    def ping(self):
        return self.send_gs('ePing')

    def chat(self, message: str, channel: int = 1):
        print(f'[>] Chat [{channel}]: {message}')
        return self.send_gs('eChatSend', channel=channel, message=message)

    def move_to(self, x: int, y: int):
        """Di chuyển đến tọa độ 5 số (world coords).
        
        Dùng eGotoPosition (opcode 248) với fields mapx, mapy.
        Lưu ý: x, y là tọa độ WORLD (5 số), không phải game (3 số).
        Để di chuyển bằng tọa độ 3 số, dùng move_to_game().
        """
        print(f'[>] Move to world ({x}, {y})')
        return self.send_gs('eGotoPosition', mapx=x, mapy=y)

    def move_to_game(self, game_x: int, game_y: int):
        """Di chuyển đến tọa độ 3 số (game/minimap coords).
        
        Tự động quy đổi sang world coords (5 số) rồi gửi.
        """
        from core.position import game_to_world_center
        wx, wy = game_to_world_center(game_x, game_y)
        print(f'[>] Move to game ({game_x}, {game_y}) [world: {wx}, {wy}]')
        return self.send_gs('eGotoPosition', mapx=wx, mapy=wy)

    def goto_path_native(self, x: int, y: int):
        print(f'[>] Native GotoFindingPath to ({x}, {y})')
        result = self.rpc.gotopath(x, y)
        print(f'    {result}')
        return result.get('ok', False)

    def set_riding(self, ride: bool):
        """Mount/dismount horse. Confirmed working via disassembly."""
        print(f'[>] set_riding({ride})')
        # Direct packet build (proven working in test_riding.py)
        proto = b'\x08\x01' if ride else b''
        packet = struct.pack('<IH', len(proto), 58) + proto
        return self.send_raw(packet)

    def adb_tap(self, x: int, y: int):
        """M么 ph峄弉g thao t谩c ch岷 m脿n h矛nh qua ADB"""
        try:
            import subprocess
            adb_cmd = ['C:\\platform-tools\\adb.exe', '-s', DEVICE_ID, 'shell', 'input', 'tap', str(x), str(y)]
            subprocess.run(adb_cmd, check=True)
            print(f'[+] ADB Tap at ({x}, {y})')
            return True
        except Exception as e:
            print(f'[-] ADB Tap Error: {e}')
            return False

    NPC_MAP_COORDS = {
        "Phượng Tường": {
            "Da Tau": (51836, 49441),  # game coords (map_id=1)
        },
        "Thành Đô": {
            "Da Tau": (100922, 81048),  # game coords (map_id=11)
        },
        "Map_20": {
            "Da Tau": (113218, 99704),  # game coords (map_id=20)
        },
        "Biện Kinh": {
            "Da Tau": (55537, 49611),  # game coords (map_id=37)
        },
        "Ba Lăng Huyện": {
            "Da Tau": (52033, 50761),  # game coords (map_id=53)
        },
        "Dương Châu": {
            "Da Tau": (55812, 47465),  # game coords (map_id=80)
        },
        "Vĩnh Lạc trấn": {
            "Da Tau": (52690, 51080),  # game coords (map_id=99)
        },
        "Chu Tiên trấn": {
            "Da Tau": (51709, 51190),  # game coords (map_id=100)
        },
        "Map_101": {
            "Da Tau": (53697, 50303),  # game coords (map_id=101)
        },
        "Long Môn trấn": {
            "Da Tau": (62705, 72005),  # game coords (map_id=121)
        },
        "Thạch Cổ trấn": {
            "Da Tau": (52580, 51769),  # game coords (map_id=153)
        },
        "Đại Lý phủ": {
            "Da Tau": (52832, 51609),  # game coords (map_id=162)
        },
        "Long Tuyền thôn": {
            "Da Tau": (51464, 51204),  # game coords (map_id=174)
        },
        "Lâm An": {
            "Da Tau": (50006, 47670),  # game coords (map_id=176)
        },
    }

    def go_to_npc_via_map(self, map_name: str, npc_name: str):
        """Navigate to an NPC based on predefined coordinates via GotoFindingPath"""
        coords = self.NPC_MAP_COORDS.get(map_name, {}).get(npc_name)
        if not coords:
            print(f"[-] Không tìm thấy tọa độ {npc_name} tại {map_name} trong NPC_MAP_COORDS!")
            return False
            
        tar_x, tar_y = coords
        print(f"[+] Tìm thấy {npc_name} tại {map_name}: ({tar_x}, {tar_y})")
        return self.goto_path_native(tar_x, tar_y)


    def tap_joystick(self, cur_x: int, cur_y: int, tar_x: int, tar_y: int):
        """T铆nh to谩n h瓢峄沶g 膽i v脿 Click m岷穞 膽岷 (Tap and Hold) 膽峄?nh芒n v岷璽 di chuy峄僴 1 b瓢峄沜"""
        import math
        import subprocess
        # Quy 膽峄昳 vector l瓢峄沬 ra vector m脿n h矛nh (G贸c nh矛n Isometric)
        dx_grid = tar_x - cur_x
        dy_grid = tar_y - cur_y
        
        # VLTK1 Isometric:
        screen_dx = dx_grid - dy_grid
        screen_dy = dx_grid + dy_grid
        
        # Chu岷﹏ h贸a vector
        length = math.sqrt(screen_dx**2 + screen_dy**2)
        if length == 0: return False
        
        # Click m岷穞 膽岷 c谩ch nh芒n v岷璽 (480, 270) m峄檛 kho岷g 80 pixel 膽峄?tr谩nh UI (Chatbox, Skill)
        click_x = 480 + int((screen_dx / length) * 80)
        click_y = 270 + int((screen_dy / length) * 80)
        
        print(f"[Walk] H瓢峄沶g t峄沬 ({tar_x}, {tar_y}) -> Click m岷穞 膽岷 ({click_x}, {click_y})")
        try:
            # D霉ng swipe t岷 ch峄?150ms 膽峄?m么 ph峄弉g ng贸n tay ch岷 th岷璽 (tr谩nh game coi l脿 auto-click r谩c)
            adb_cmd = ['C:\\platform-tools\\adb.exe', '-s', DEVICE_ID, 'shell', 'input', 'swipe', 
                       str(click_x), str(click_y), str(click_x), str(click_y), '150']
            subprocess.run(adb_cmd, check=True)
            return True
        except Exception as e:
            print(f'[-] ADB Tap Ground Error: {e}')
            return False

    def goto_npc(self, npc_name: str):
        print(f'[>] goto_npc: {npc_name}')
        return self.send_gs('eGotoNpc', npcName=[npc_name], data=0)

    def talk_npc(self, npc_id: str):
        return self.send_gs('eNpcDialogue', npcId=npc_id)

    def select_option(self, index: int):
        return self.send_gs('eNpcSelect', selectIndex=index)

    def use_skill_npc(self, skill_id: int, nid: str):
        return self.send_gs('eDoSkillTargetNpc', skillid=skill_id, nid=nid)

    def use_skill_pos(self, skill_id: int, x: int, y: int):
        return self.send_gs('eDoSkillTargetPosition', skillid=skill_id, positionX=x, positionY=y)

    def pickup(self, object_id: str):
        return self.send_gs('eObjectPickup', objectId=object_id)

    def use_item(self, item_index: int):
        return self.send_gs('ePlayerUserItem', itemindex=item_index)

    # ==================== BOT UTILS ====================

    def auto_keepalive(self, interval=30):
        """Background ping thread."""
        def _loop():
            while self.running:
                self.ping()
                time.sleep(interval)
        t = threading.Thread(target=_loop, daemon=True)
        t.start()
        print(f'[+] Keepalive started (every {interval}s)')

    def close(self):
        self.running = False
        if self.script:
            try: self.script.unload()
            except: pass
        if self.session:
            try: self.session.detach()
            except: pass
        print('[*] Disconnected')


# ==================== INTERACTIVE CLI ====================

def main():
    print('=' * 50)
    print('  VLTK1 Bot Controller')
    print(f'  Package: {PACKAGE}')
    print('=' * 50)

    bot = VLTK1Bot()
    if not bot.connect():
        return

    bot.auto_keepalive()

    print('\n[*] Bot ready. Use bot.xxx() commands.')
    print('    bot.chat("msg")           - send chat')
    print('    bot.move_to(wx, wy)       - move (world coords 5 số)')
    print('    bot.move_to_game(gx, gy)  - move (game coords 3 số)')
    print('    bot.set_riding(True)      - mount horse')
    print('    bot.goto_npc("name")      - go to NPC')
    print('    bot.poll_recv()           - read packets')
    print('    bot.close()               - disconnect\n')

    import code
    code.interact(banner='', local={'bot': bot, 'VLTK1Bot': VLTK1Bot})
    bot.close()


if __name__ == '__main__':
    main()

