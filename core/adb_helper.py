"""
core/adb_helper.py — ADB utilities + Frida position wrapper

Cung cấp các hàm cơ bản để tương tác với giả lập Android:
  - tap, swipe, keyevent
  - Frida init + position reading
  - Screenshot capture

Usage:
    from core.adb_helper import ADBHelper
    adb = ADBHelper()
    adb.tap(480, 300)
    pos = adb.get_position()  # (gx, gy)
"""
import os
import sys
import time
import logging
import subprocess

logger = logging.getLogger("adb")

# ── Config ────────────────────────────────────────────────────
ADB_PATH = r"C:\platform-tools\adb.exe"
DEVICE_ID = "emulator-5554"
PACKAGE = "vn.perfingame.jx1mobile"
ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))


class ADBHelper:
    """ADB + Frida wrapper cho VLTK1 automation."""

    def __init__(self, device_id=DEVICE_ID):
        self.device_id = device_id
        self.frida_session = None
        self.frida_script = None
        self._tracked_eid = ""
        self.eid_file = os.path.join(ROOT_DIR, "data", "tracked_eid.txt")
        self._load_eid()

    def _load_eid(self):
        try:
            if os.path.exists(self.eid_file):
                with open(self.eid_file, 'r') as f:
                    self._tracked_eid = f.read().strip()
                if self._tracked_eid:
                    logger.info(f"Loaded tracked_eid: {self._tracked_eid}")
        except:
            pass

    def _save_eid(self, eid: str):
        self._tracked_eid = eid
        try:
            os.makedirs(os.path.dirname(self.eid_file), exist_ok=True)
            with open(self.eid_file, 'w') as f:
                f.write(eid)
        except:
            pass

    # ── ADB Commands ──────────────────────────────────────────

    def shell(self, cmd: str, timeout=5) -> str:
        """Run ADB shell command, return stdout."""
        result = subprocess.run(
            [ADB_PATH, "-s", self.device_id, "shell", cmd],
            capture_output=True, timeout=timeout
        )
        return result.stdout.decode(errors='ignore')

    def tap(self, x: int, y: int):
        """Tap tại tọa độ (x, y) trên màn hình."""
        subprocess.run(
            [ADB_PATH, "-s", self.device_id, "shell", f"input tap {x} {y}"],
            capture_output=True, timeout=5
        )

    def swipe(self, x1, y1, x2, y2, duration_ms=300):
        """Swipe từ (x1,y1) đến (x2,y2)."""
        subprocess.run(
            [ADB_PATH, "-s", self.device_id, "shell",
             f"input swipe {x1} {y1} {x2} {y2} {duration_ms}"],
            capture_output=True, timeout=10
        )

    def keyevent(self, key: int):
        """Gửi keyevent (111=ESC, 4=BACK, 66=ENTER)."""
        subprocess.run(
            [ADB_PATH, "-s", self.device_id, "shell", f"input keyevent {key}"],
            capture_output=True, timeout=5
        )

    def close_all_ui(self):
        """Đóng tất cả dialog/map/UI đang mở bằng tap close buttons."""
        self.tap(770, 497)  # Nút đóng big map
        time.sleep(0.3)
        self.tap(700, 335)  # Nút đóng generic dialog
        time.sleep(0.3)

    # ── Frida ─────────────────────────────────────────────────

    def init_frida(self) -> bool:
        """Attach Frida vào game process, load frida_bot.js."""
        try:
            import frida
        except ImportError:
            logger.warning("Frida not installed. Run: pip install frida-tools")
            return False

        try:
            device = frida.get_device_manager().get_device(self.device_id)
            self.frida_session = device.attach("VLTieuNgao")

            script_path = os.path.join(ROOT_DIR, "features", "bot", "frida_bot.js")
            with open(script_path, 'r', encoding='utf-8') as f:
                self.frida_script = self.frida_session.create_script(f.read())

            self.frida_script.on('message', lambda msg, data: None)
            self.frida_script.load()

            # Wait for hooks to settle + trigger game socket detection
            time.sleep(2)
            self.tap(480, 300)  # Tap center to trigger opcode 9
            time.sleep(1)

            logger.info("Frida attached OK")
            return True
        except Exception as e:
            logger.warning(f"Frida attach failed: {e}")
            self.frida_session = None
            self.frida_script = None
            return False

    @property
    def rpc(self):
        """Shortcut to Frida RPC exports."""
        if self.frida_script:
            return self.frida_script.exports_sync
        return None

    # ── Position ──────────────────────────────────────────────

    def get_position(self, trigger_tap=True) -> tuple:
        """Đọc vị trí hiện tại.

        Thử Frida trước (nhanh 0.2s), fallback sang tcpdump (~4s).

        Returns:
            (game_x, game_y) hoặc (0, 0) nếu thất bại
        """
        if self.frida_script:
            try:
                # Trigger a tap to generate a position packet
                if trigger_tap:
                    self.tap(480, 300)
                    time.sleep(0.5)

                packets_info = self.rpc.get_recv_packets()
                if packets_info:
                    # Convert JS packet format to (opcode, bytes) for Python
                    packets_list = [(p['opcode'], bytes.fromhex(p['hex'])) for p in packets_info if 'opcode' in p and 'hex' in p]
                    
                    sys.path.insert(0, os.path.join(ROOT_DIR, "tests"))
                    from core.position import detect_player_position, COORD_DIVISOR
                    
                    wx, wy, eid = detect_player_position(packets_list, tracked_eid=self._tracked_eid or None)
                    if wx > 0:
                        gx, gy = wx // COORD_DIVISOR, wy // COORD_DIVISOR
                        if eid and not self._tracked_eid:
                            self._save_eid(eid)
                            logger.info(f"Locked entity: {eid}")
                        return gx, gy
            except Exception as e:
                logger.warning(f"Frida read_position error: {e}")
                self.frida_script = None

        # Fallback: tcpdump
        return self._get_position_tcpdump(trigger_tap)

    def _detect_port(self) -> int:
        """Detect game server port."""
        out = self.shell('su -c "netstat -tnp 2>/dev/null"')
        for line in out.splitlines():
            if 'jx1mobile' in line and 'ESTABLISHED' in line:
                port = int(line.split()[4].split(':')[-1])
                if port > 1024:
                    return port
        return 45676

    def _get_position_tcpdump(self, trigger_tap=True) -> tuple:
        """Đọc vị trí bằng tcpdump (fallback khi Frida SSL fails).

        Returns:
            (game_x, game_y) hoặc (0, 0)
        """
        port = self._detect_port()
        pcap_dev = "/data/local/tmp/pos.pcap"
        pcap_local = os.path.join(ROOT_DIR, "data", "output", "pos.pcap")
        os.makedirs(os.path.dirname(pcap_local), exist_ok=True)

        self.shell('su -c "killall tcpdump 2>/dev/null"')
        self.shell(f'su -c "rm {pcap_dev} 2>/dev/null"')
        time.sleep(0.2)

        # Start capture
        proc = subprocess.Popen(
            [ADB_PATH, "-s", self.device_id, "shell",
             f'su -c "tcpdump -i any -U -w {pcap_dev} -c 300 port {port}"'],
            stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
        )
        time.sleep(0.5)

        if trigger_tap:
            self.tap(480, 300)
            time.sleep(1)
            self.tap(480, 300)  # Tap 2 lần cho chắc
        time.sleep(3)

        self.shell('su -c "killall tcpdump 2>/dev/null"')
        proc.terminate()
        time.sleep(0.5)

        # Pull pcap
        subprocess.run(
            [ADB_PATH, "-s", self.device_id, "pull", pcap_dev, pcap_local],
            capture_output=True, timeout=10
        )

        if not os.path.exists(pcap_local):
            return 0, 0

        # Parse
        try:
            sys.path.insert(0, os.path.join(ROOT_DIR, "tests"))
            from test_open_shop import parse_pcap_recv
            from core.position import detect_player_position, COORD_DIVISOR

            packets = parse_pcap_recv(pcap_local, port)
            wx, wy, eid = detect_player_position(packets, tracked_eid=self._tracked_eid or None)

            if wx > 0:
                gx, gy = wx // COORD_DIVISOR, wy // COORD_DIVISOR
                if eid and not self._tracked_eid:
                    self._save_eid(eid)
                    logger.info(f"Locked entity: {eid}")
                return gx, gy
        except Exception as e:
            logger.warning(f"tcpdump parse error: {e}")

        return 0, 0

    def get_position_world(self, trigger_tap=True) -> tuple:
        """Đọc vị trí hiện tại (world coords 5 số).

        Returns:
            (world_x, world_y) hoặc (0, 0)
        """
        if not self.frida_script:
            return 0, 0

        if trigger_tap:
            self.tap(480, 300)

        for _ in range(15):
            time.sleep(0.2)
            pos = self.rpc.read_position()
            if pos and pos.get('x', 0) > 0:
                return pos['x'], pos['y']

        return 0, 0

    def get_recv_packets(self) -> list:
        """Lấy tất cả packets nhận được từ Frida buffer."""
        if not self.rpc:
            return []
        return self.rpc.get_recv_packets()

    def flush_recv(self):
        """Xóa buffer packets cũ."""
        if self.rpc:
            self.rpc.get_recv_packets()

    def close(self):
        """Disconnect Frida."""
        if self.frida_script:
            try:
                self.frida_script.unload()
            except:
                pass
        if self.frida_session:
            try:
                self.frida_session.detach()
            except:
                pass
        logger.info("Disconnected")
