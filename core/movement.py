"""
core/movement.py — Module di chuyển nhân vật hoàn chỉnh

Hỗ trợ 3 phương thức di chuyển:
  1. eGotoPosition (opcode 248) — Gửi packet trực tiếp qua socket
  2. GotoFindingPath — Gọi hàm native IL2CPP (client tự tìm đường)
  3. ADB Tap — Tap màn hình giả lập (fallback)

Tính năng:
  - Feedback loop: poll vị trí từ Frida recv hook (không cần tcpdump)
  - Stuck detection: phát hiện kẹt và tự gỡ
  - Hỗ trợ cả tọa độ 3 số (game) và 5 số (world)
  - Callback khi đến nơi / bị kẹt / timeout

Kiến thức đã xác nhận:
  - Divisor = 256 (game_x = world_x // 256)
  - eGotoPosition fields: mapx, mapy (world coords)
  - opcode 9 entity sync: etype 1/2, parts[2]=X, parts[3]=Y
"""

import os
import sys
import time
import math
import logging
from typing import Optional, Callable, Tuple

from core.position import (
    world_to_game,
    game_to_world_center,
    COORD_DIVISOR,
)

logger = logging.getLogger(__name__)


# ── Cấu hình mặc định ──────────────────────────────────────

DEFAULT_CONFIG = {
    "arrival_threshold_world": 500,     # ~2 tiles, coi như đã đến
    "arrival_threshold_game": 2,        # 2 ô grid
    "stuck_threshold": 3,              # Số lần liên tiếp vị trí không đổi → stuck
    "max_steps": 30,                   # Số bước tối đa
    "position_poll_interval": 0.5,     # Giây giữa mỗi lần poll position
    "wait_after_move": 3.0,            # Giây chờ sau mỗi lệnh move
    "stuck_recovery_wait": 2.0,        # Giây chờ sau khi gỡ kẹt
    "timeout": 120,                    # Timeout tổng (giây)
}


class MoveResult:
    """Kết quả di chuyển."""
    
    def __init__(self, success: bool, start_pos: tuple, end_pos: tuple,
                 target_pos: tuple, steps: int, elapsed: float, reason: str = ""):
        self.success = success
        self.start_pos = start_pos      # (world_x, world_y)
        self.end_pos = end_pos          # (world_x, world_y)
        self.target_pos = target_pos    # (world_x, world_y)
        self.steps = steps
        self.elapsed = elapsed
        self.reason = reason
    
    @property
    def remaining_distance(self) -> float:
        if self.end_pos[0] == 0:
            return float('inf')
        return math.hypot(
            self.end_pos[0] - self.target_pos[0],
            self.end_pos[1] - self.target_pos[1]
        )
    
    @property
    def start_game(self) -> tuple:
        return world_to_game(*self.start_pos)
    
    @property
    def end_game(self) -> tuple:
        return world_to_game(*self.end_pos) if self.end_pos[0] > 0 else (0, 0)
    
    @property
    def target_game(self) -> tuple:
        return world_to_game(*self.target_pos)
    
    def __repr__(self):
        sg = self.start_game
        eg = self.end_game
        tg = self.target_game
        return (f"MoveResult(success={self.success}, "
                f"start=({sg[0]},{sg[1]}), end=({eg[0]},{eg[1]}), "
                f"target=({tg[0]},{tg[1]}), "
                f"steps={self.steps}, elapsed={self.elapsed:.1f}s, "
                f"dist={self.remaining_distance:.0f}, reason='{self.reason}')")


class MovementController:
    """
    Điều khiển di chuyển nhân vật với feedback loop.
    
    Sử dụng Frida recv hook (readPosition) để lấy vị trí real-time,
    không cần tcpdump.
    
    Usage:
        bot = VLTK1Bot()
        bot.connect()
        
        mover = MovementController(bot)
        
        # Di chuyển đến tọa độ 3 số
        result = mover.move_to_game(240, 175)
        
        # Di chuyển đến tọa độ 5 số
        result = mover.move_to_world(54272, 50048)
        
        # Kiểm tra kết quả
        if result.success:
            print(f"Đã đến! {result.end_game}")
        else:
            print(f"Thất bại: {result.reason}")
    """
    
    def __init__(self, bot, config: dict = None):
        self.bot = bot
        self.config = {**DEFAULT_CONFIG, **(config or {})}
        self._last_position = (0, 0)
        self._entity_id = ""
        self._game_port = 0
    
    # ── Đọc vị trí từ Frida hook ─────────────────────────────
    
    def read_position(self) -> Tuple[int, int, str]:
        """Đọc vị trí hiện tại từ Frida recv hook.
        
        Returns:
            (world_x, world_y, entity_id)
            Trả (0, 0, "") nếu chưa có data.
        """
        try:
            pos = self.bot.rpc.read_position()
            x = pos.get('x', 0)
            y = pos.get('y', 0)
            eid = pos.get('eid', '')
            ts = pos.get('ts', 0)
            
            # Kiểm tra timestamp — nếu quá cũ (>30s) thì coi như stale
            if ts > 0 and (time.time() * 1000 - ts) > 30000:
                logger.debug(f"Position data stale (ts={ts})")
                return 0, 0, ""
            
            if x > 0 and y > 0:
                self._last_position = (x, y)
                if eid:
                    self._entity_id = eid
                return x, y, eid
        except Exception as e:
            logger.warning(f"read_position error: {e}")
        
        return 0, 0, ""
    
    def read_position_game(self) -> Tuple[int, int]:
        """Đọc vị trí hiện tại (tọa độ 3 số)."""
        wx, wy, _ = self.read_position()
        if wx > 0:
            return world_to_game(wx, wy)
        return 0, 0
    
    def read_position_trigger(self) -> Tuple[int, int, str]:
        """Read position by triggering a small ADB tap + tcpdump.
        
        When the character is standing still, server doesn't send opcode 9.
        This method taps a safe spot on screen to trigger a tiny movement,
        forcing the server to send entity sync packets with coordinates.
        
        Returns: (world_x, world_y, entity_id) or (0, 0, "")
        """
        # Tap safe spot (near screen center, away from UI)
        tap_positions = [
            (480, 300),   # Center
            (150, 450),   # Bottom-left edge
            (800, 150),   # Top-right edge
        ]
        
        for tap_pos in tap_positions:
            logger.info(f"Trigger tap ({tap_pos[0]}, {tap_pos[1]}) + tcpdump...")
            self.bot.adb_tap(tap_pos[0], tap_pos[1])
            time.sleep(1.5)
            
            wx, wy, eid = self.read_position_tcpdump(duration=3.0)
            if wx > 0:
                logger.info(f"Position from trigger: ({wx}, {wy}) eid={eid}")
                return wx, wy, eid
        
        logger.warning("read_position_trigger: all tap attempts failed")
        return 0, 0, ""
    
    # Numpad layout (ADB tap coords)
    NUMPAD = {
        '0': (500, 351), '1': (500, 296), '2': (570, 296), '3': (630, 296),
        '4': (500, 241), '5': (570, 241), '6': (630, 241),
        '7': (500, 186), '8': (570, 186), '9': (630, 186),
        ' ': (570, 351), 'x': (630, 351),
    }
    
    def _numpad_type_coords(self, gx: int, gy: int):
        """Type coordinates into the minimap numpad dialog."""
        # Clear existing text
        for _ in range(6):
            self.bot.adb_tap(630, 351)
            time.sleep(0.15)
        time.sleep(0.3)
        
        coord_str = f"{gx} {gy}"
        logger.info(f"Numpad typing: '{coord_str}'")
        for ch in coord_str:
            if ch in self.NUMPAD:
                x, y = self.NUMPAD[ch]
                self.bot.adb_tap(x, y)
                time.sleep(0.2)
    
    def _send_numpad_goto(self, target_gx: int, target_gy: int):
        """Open minimap numpad, type coords, confirm. Character starts pathfinding."""
        # Close any open dialog
        self.bot.adb_tap(700, 335)
        time.sleep(0.3)
        
        # Open numpad: tap coords area on minimap
        logger.info("Opening minimap numpad...")
        self.bot.adb_tap(890, 120)
        time.sleep(1.5)
        
        # Type target coords
        self._numpad_type_coords(target_gx, target_gy)
        time.sleep(0.3)
        
        # Confirm (coord dialog "Xác nhận" button)
        logger.info("Pressing Confirm...")
        self.bot.adb_tap(265, 333)
        time.sleep(1.0)

    def move_via_minimap(self, target_gx: int, target_gy: int,
                          on_step: Callable = None) -> MoveResult:
        """Move to target via minimap numpad coordinate input.
        
        Strategy:
        1. Detect start position (tap trigger)
        2. Open numpad, type coords, confirm
        3. Wait proportional to distance (game auto-pathfinds)
        4. Verify arrival (tap trigger)
        5. If not arrived, retry
        
        Fully automated: ADB tap numpad + tcpdump tracking. No OCR.
        """
        cfg = self.config
        target_wx, target_wy = game_to_world_center(target_gx, target_gy)
        
        logger.info(f"Move via numpad to ({target_gx}, {target_gy})")
        
        # Get start position
        start_wx, start_wy, eid = self.read_position_trigger()
        if start_wx == 0:
            start_wx, start_wy, eid = self.read_position_tcpdump(duration=3.0)
        if start_wx == 0:
            logger.warning("Cannot detect start position")
            return MoveResult(False, (0,0), (0,0), (target_wx, target_wy), 0, 0, "cannot_detect_position")
        
        start_gx, start_gy = world_to_game(start_wx, start_wy)
        logger.info(f"Start: ({start_gx}, {start_gy})")
        
        dist = math.hypot(start_gx - target_gx, start_gy - target_gy)
        if dist < cfg["arrival_threshold_game"]:
            return MoveResult(True, (start_wx, start_wy), (start_wx, start_wy),
                              (target_wx, target_wy), 0, 0, "already_at_target")
        
        t0 = time.time()
        cur_wx, cur_wy = start_wx, start_wy
        cur_gx, cur_gy = start_gx, start_gy
        
        for attempt in range(cfg["max_steps"]):
            elapsed = time.time() - t0
            if elapsed > cfg["timeout"]:
                return MoveResult(False, (start_wx, start_wy), (cur_wx, cur_wy),
                                  (target_wx, target_wy), attempt, elapsed, "timeout")
            
            # Send numpad goto
            self._send_numpad_goto(target_gx, target_gy)
            
            # Wait proportional to distance (~1 tile per second, min 8s, max 30s)
            wait_time = max(8, min(30, int(dist * 1.0)))
            logger.info(f"[Attempt {attempt+1}] Waiting {wait_time}s for pathfinding...")
            time.sleep(wait_time)
            
            # Verify position with tap trigger (most reliable)
            wx, wy, _ = self.read_position_trigger()
            if wx > 0:
                cur_wx, cur_wy = wx, wy
                cur_gx, cur_gy = world_to_game(wx, wy)
                self._last_position = (cur_wx, cur_wy)
            
            dist = math.hypot(cur_gx - target_gx, cur_gy - target_gy)
            logger.info(f"[Attempt {attempt+1}] Position: ({cur_gx}, {cur_gy}) | Dist: {dist:.0f} tiles")
            
            if on_step:
                try: on_step(attempt+1, cur_gx, cur_gy, dist * COORD_DIVISOR)
                except: pass
            
            if dist < cfg["arrival_threshold_game"]:
                elapsed = time.time() - t0
                logger.info(f"Arrived! ({cur_gx}, {cur_gy}) in {elapsed:.1f}s")
                return MoveResult(True, (start_wx, start_wy), (cur_wx, cur_wy),
                                  (target_wx, target_wy), attempt+1, elapsed, "arrived")
            
            # Update distance for next wait calculation
            logger.info(f"Not yet arrived. Remaining: {dist:.0f} tiles")
        
        elapsed = time.time() - t0
        return MoveResult(False, (start_wx, start_wy), (cur_wx, cur_wy),
                          (target_wx, target_wy), cfg["max_steps"], elapsed, "max_attempts_reached")
    
    def _detect_game_port(self) -> int:
        """Auto-detect game server port from netstat."""
        import subprocess
        adb = self.config.get("adb_path", r"C:\platform-tools\adb.exe")
        device_id = self.config.get("device_id", "emulator-5554")
        
        if self._game_port:
            return self._game_port
        
        try:
            out = subprocess.check_output(
                [adb, "-s", device_id, "shell", 'su -c "netstat -tnp 2>/dev/null"'],
                timeout=5).decode()
            for line in out.splitlines():
                if 'jx1mobile' in line and 'ESTABLISHED' in line:
                    remote = line.split()[4]
                    port = int(remote.split(':')[-1])
                    if port > 1024:
                        self._game_port = port
                        logger.info(f"Auto-detected game port: {port}")
                        return port
        except Exception:
            pass
        return 45676  # fallback
    
    def _capture_pcap(self, duration: float = 3.0) -> list:
        """Run tcpdump capture filtered by game port.
        
        Returns: List of (opcode, body_bytes) tuples, or empty list.
        """
        import subprocess
        
        adb = self.config.get("adb_path", r"C:\platform-tools\adb.exe")
        device_id = self.config.get("device_id", "emulator-5554")
        pcap_dev = "/data/local/tmp/pos.pcap"
        pcap_local = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
                                   "data", "output", "pos.pcap")
        
        os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
        
        port = self._detect_game_port()
        
        # Kill existing tcpdump
        subprocess.run([adb, "-s", device_id, "shell", 'su -c "killall tcpdump 2>/dev/null"'],
                       capture_output=True, timeout=5)
        # Remove old pcap
        subprocess.run([adb, "-s", device_id, "shell", f'su -c "rm {pcap_dev} 2>/dev/null"'],
                       capture_output=True, timeout=5)
        time.sleep(0.2)
        
        # Start capture with port filter
        proc = subprocess.Popen(
            [adb, "-s", device_id, "shell",
             f'su -c "tcpdump -i any -U -w {pcap_dev} -c 200 port {port}"'],
            stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL
        )
        
        time.sleep(duration)
        
        # Stop capture
        subprocess.run([adb, "-s", device_id, "shell", 'su -c "killall tcpdump 2>/dev/null"'],
                       capture_output=True, timeout=5)
        proc.terminate()
        time.sleep(0.5)
        
        # Pull pcap
        result = subprocess.run([adb, "-s", device_id, "pull", pcap_dev, pcap_local],
                       capture_output=True, timeout=10)
        
        if not os.path.exists(pcap_local):
            return []
        
        try:
            sys.path.insert(0, os.path.join(
                os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "tests"))
            from test_open_shop import parse_pcap_recv
            
            packets = parse_pcap_recv(pcap_local, port)
            if packets:
                return packets
        except Exception as e:
            logger.warning(f"pcap parse error: {e}")
        
        return []
    
    def _find_entity_position(self, packets: list) -> Tuple[int, int, str]:
        """Find player position from opcode 9 packets.
        
        Uses entity_id tracking + proximity-based detection.
        
        Returns: (world_x, world_y, entity_id) or (0, 0, "")
        """
        from core.position import detect_player_position
        return detect_player_position(
            packets,
            last_known_pos=self._last_position,
            tracked_eid=self._entity_id if self._entity_id else None
        )
    
    def read_position_tcpdump(self, duration: float = 3.0) -> Tuple[int, int, str]:
        """Read position by passive tcpdump capture (kernel level).
        
        Returns: (world_x, world_y, entity_id) or (0, 0, "")
        """
        packets = self._capture_pcap(duration=duration)
        
        if not packets:
            logger.warning("tcpdump: no game packets found")
            return 0, 0, ""
        
        wx, wy, eid = self._find_entity_position(packets)
        
        if wx > 0:
            self._last_position = (wx, wy)
            gx, gy = world_to_game(wx, wy)
            logger.info(f"Position from tcpdump: ({gx}, {gy}) [world: {wx}, {wy}] eid={eid}")
            return wx, wy, eid
        
        logger.warning("tcpdump: no position in packets")
        return 0, 0, ""
    
    def ensure_position_data(self, max_retries: int = 3) -> Tuple[int, int, str]:
        """Get current position.
        
        Priority:
        1. Frida recv hooks (readPosition) — instant if data available
        2. tcpdump passive capture — works when character is moving
        3. ADB tap + tcpdump — trigger movement to get opcode 9
        
        Note: When character is standing still, server doesn't send opcode 9.
        A small ADB tap at screen edge triggers client movement, causing server
        to send entity sync packets that reveal position.
        """
        # Method 1: Check recv hooks (fast, may not work on Houdini)
        wx, wy, eid = self.read_position()
        if wx > 0:
            logger.info(f"Position from hooks: ({wx}, {wy})")
            return wx, wy, eid
        
        # Method 2: Passive tcpdump (works if character is already moving)
        logger.info("Hooks empty, trying passive tcpdump...")
        wx, wy, eid = self.read_position_tcpdump(duration=3.0)
        if wx > 0:
            return wx, wy, eid
        
        # Method 3: Tap trigger + tcpdump
        logger.info("Passive empty, using tap trigger...")
        wx, wy, eid = self.read_position_trigger()
        if wx > 0:
            return wx, wy, eid
        
        return 0, 0, ""
    
    # ── Di chuyển ─────────────────────────────────────────────
    
    def _poll_position(self, duration: float = 3.0) -> Tuple[int, int, str]:
        """Poll position: try hooks first, then tcpdump.
        
        Returns: (world_x, world_y, entity_id) or (0, 0, "")
        """
        # Fast path: Frida hooks
        wx, wy, eid = self.read_position()
        if wx > 0:
            return wx, wy, eid
        
        # Slow path: tcpdump
        return self.read_position_tcpdump(duration=duration)
    
    def _close_dialog(self):
        """Close NPC dialog if open (tap 'End dialog' button area)."""
        self.bot.adb_tap(700, 335)
        time.sleep(0.3)
        self.bot.adb_tap(700, 335)
        time.sleep(0.3)
    
    def _calc_tap_position(self, cur_wx: int, cur_wy: int,
                           target_wx: int, target_wy: int) -> Tuple[int, int]:
        """Calculate screen tap position for isometric movement.
        
        Always normalizes to tap at fixed distance from screen center,
        in the direction of the target. This makes the character run
        towards the target with max speed.
        
        Returns (screen_x, screen_y)
        """
        dwx = target_wx - cur_wx
        dwy = target_wy - cur_wy
        
        # Isometric projection (2:1 ratio)
        sx = (dwx - dwy) * 0.06
        sy = (dwx + dwy) * 0.03
        
        # Always normalize to fixed distance (250px from center)
        dist = math.sqrt(sx*sx + sy*sy)
        if dist > 0:
            target_dist = 250  # Tap 250px from center for max speed
            sx = sx / dist * target_dist
            sy = sy / dist * target_dist
        
        screen_w = self.config.get("screen_w", 960)
        screen_h = self.config.get("screen_h", 540)
        cx, cy = screen_w // 2, screen_h // 2
        
        tap_x = int(cx + sx)
        tap_y = int(cy + sy)
        
        # Clamp to safe area (avoid UI elements)
        tap_x = max(100, min(850, tap_x))
        tap_y = max(80, min(470, tap_y))
        
        return tap_x, tap_y
    
    def move(self, target_gx: int, target_gy: int,
             method: str = 'minimap',
             start_pos: tuple = None,
             on_step: Callable = None) -> MoveResult:
        """Unified movement function that routes to the appropriate method.
        
        Args:
            target_gx, target_gy: Target game coords (3-digit)
            method: Movement strategy ('minimap', 'packet', 'native')
            start_pos: Optional (world_x, world_y) if already known
            on_step: Callback(step, cur_gx, cur_gy, dist) called each step
            
        Returns:
            MoveResult
        """
        logger.info(f"Move unified: target ({target_gx}, {target_gy}) via {method}")
        
        if method == 'minimap':
            return self.move_via_minimap(target_gx, target_gy, on_step=on_step)
        elif method == 'native':
            target_wx, target_wy = game_to_world_center(target_gx, target_gy)
            return self.move_to_native(target_wx, target_wy, start_pos=start_pos, on_step=on_step)
        else:
            # fallback to 'packet' / world pathfinding
            return self.move_to_game(target_gx, target_gy, start_pos=start_pos, on_step=on_step)

    def move_to_game(self, game_x: int, game_y: int,
                     start_pos: tuple = None,
                     on_step: Callable = None) -> MoveResult:
        """Move to game coords (3-digit minimap coords).
        
        Args:
            game_x, game_y: Target coords (3-digit, displayed on minimap)
            start_pos: Optional (world_x, world_y) if already known
            on_step: Callback(step, cur_gx, cur_gy, dist) called each step
            
        Returns:
            MoveResult
        """
        wx, wy = game_to_world_center(game_x, game_y)
        return self.move_to_world(wx, wy, start_pos=start_pos, on_step=on_step)
    
    def move_to_world(self, target_wx: int, target_wy: int,
                      start_pos: tuple = None,
                      on_step: Callable = None) -> MoveResult:
        """Move to world coords using ADB tap + tcpdump feedback loop.
        
        On Houdini x86: packet move (eGotoPosition) doesn't work.
        ADB tap is the only way to trigger client pathfinder.
        tcpdump (kernel level) is used to detect position.
        
        Args:
            target_wx, target_wy: Target world coords (5-digit)
            start_pos: Optional (world_x, world_y) if already known
            on_step: Callback(step, cur_gx, cur_gy, dist) called each step
            
        Returns:
            MoveResult
        """
        cfg = self.config
        target_gx, target_gy = world_to_game(target_wx, target_wy)
        
        logger.info(f"Move to ({target_gx}, {target_gy}) [world: {target_wx}, {target_wy}]")
        
        # Get start position
        if start_pos and start_pos[0] > 0:
            start_wx, start_wy = start_pos[0], start_pos[1]
        else:
            start_wx, start_wy, _ = self.ensure_position_data()
        
        if start_wx == 0:
            return MoveResult(
                False, (0, 0), (0, 0), (target_wx, target_wy),
                0, 0, "cannot_detect_position"
            )
        
        start_gx, start_gy = world_to_game(start_wx, start_wy)
        logger.info(f"Current: ({start_gx}, {start_gy})")
        
        # Already at target?
        dist = math.hypot(start_wx - target_wx, start_wy - target_wy)
        if dist < cfg["arrival_threshold_world"]:
            logger.info("Already at target!")
            return MoveResult(
                True, (start_wx, start_wy), (start_wx, start_wy),
                (target_wx, target_wy), 0, 0, "already_at_target"
            )
        
        t0 = time.time()
        last_gx, last_gy = start_gx, start_gy
        stuck_count = 0
        step = 0
        cur_wx, cur_wy = start_wx, start_wy
        
        while step < cfg["max_steps"]:
            # Timeout check
            elapsed = time.time() - t0
            if elapsed > cfg["timeout"]:
                logger.warning(f"Timeout ({cfg['timeout']}s)")
                return MoveResult(
                    False, (start_wx, start_wy), (cur_wx, cur_wy),
                    (target_wx, target_wy), step, elapsed, "timeout"
                )
            
            step += 1
            
            # Close any NPC dialog first
            self._close_dialog()
            
            # Calculate tap position
            tap_x, tap_y = self._calc_tap_position(cur_wx, cur_wy, target_wx, target_wy)
            
            # Tap to trigger movement
            logger.info(f"Tap ({tap_x}, {tap_y})")
            self.bot.adb_tap(tap_x, tap_y)
            
            # Wait for character to start moving
            time.sleep(cfg["wait_after_move"])
            
            # Poll position (tcpdump captures while character is moving)
            wx, wy, eid = self._poll_position(duration=3.0)
            if wx > 0:
                cur_wx, cur_wy = wx, wy
                if eid:
                    self._entity_id = eid
            
            cur_gx, cur_gy = world_to_game(cur_wx, cur_wy)
            dist = math.hypot(cur_wx - target_wx, cur_wy - target_wy)
            
            logger.info(
                f"[Step {step}] ({cur_gx}, {cur_gy}) "
                f"| Dist: {dist:.0f} (~{dist/COORD_DIVISOR:.0f} tiles)"
            )
            
            # Callback
            if on_step:
                try:
                    on_step(step, cur_gx, cur_gy, dist)
                except Exception:
                    pass
            
            # Arrived?
            if dist < cfg["arrival_threshold_world"]:
                elapsed = time.time() - t0
                logger.info(f"Arrived! ({cur_gx}, {cur_gy}) in {elapsed:.1f}s")
                return MoveResult(
                    True, (start_wx, start_wy), (cur_wx, cur_wy),
                    (target_wx, target_wy), step, elapsed, "arrived"
                )
            
            # Stuck detection
            if cur_gx == last_gx and cur_gy == last_gy:
                stuck_count += 1
                if stuck_count >= cfg["stuck_threshold"]:
                    logger.warning(
                        f"Stuck at ({cur_gx}, {cur_gy})! "
                        f"Trying unstuck..."
                    )
                    self._unstuck(cur_wx, cur_wy, target_wx, target_wy)
                    stuck_count = 0
            else:
                stuck_count = 0
            
            last_gx, last_gy = cur_gx, cur_gy
        
        # Max steps reached
        elapsed = time.time() - t0
        return MoveResult(
            False, (start_wx, start_wy), (cur_wx, cur_wy),
            (target_wx, target_wy), step, elapsed, "max_steps_reached"
        )
    
    def move_to_native(self, target_wx: int, target_wy: int,
                       on_step: Callable = None) -> MoveResult:
        """Di chuyển bằng GotoFindingPath native (IL2CPP).
        
        Client tự tính đường đi, ổn hơn eGotoPosition.
        Yêu cầu: PlayerMain instance đã được capture.
        
        Args:
            target_wx, target_wy: Tọa độ đích (5 số)
            on_step: Callback
            
        Returns:
            MoveResult
        """
        cfg = self.config
        target_gx, target_gy = world_to_game(target_wx, target_wy)
        
        logger.info(f"Native move to ({target_gx}, {target_gy}) [world: {target_wx}, {target_wy}]")
        
        # Lấy vị trí xuất phát
        start_wx, start_wy, _ = self.ensure_position_data()
        if start_wx == 0:
            return MoveResult(
                False, (0, 0), (0, 0), (target_wx, target_wy),
                0, 0, "cannot_detect_position"
            )
        
        t0 = time.time()
        last_gx, last_gy = world_to_game(start_wx, start_wy)
        stuck_count = 0
        cur_wx, cur_wy = start_wx, start_wy
        
        # Gửi lệnh native 1 lần (client sẽ tự pathfind)
        ok = self.bot.goto_path_native(target_wx, target_wy)
        if not ok:
            logger.warning("GotoFindingPath failed, fallback to packet move")
            return self.move_to_world(target_wx, target_wy, on_step)
        
        # Monitor cho đến khi đến hoặc timeout
        step = 0
        while step < cfg["max_steps"]:
            elapsed = time.time() - t0
            if elapsed > cfg["timeout"]:
                return MoveResult(
                    False, (start_wx, start_wy), (cur_wx, cur_wy),
                    (target_wx, target_wy), step, elapsed, "timeout"
                )
            
            step += 1
            time.sleep(cfg["position_poll_interval"] * 2)
            
            wx, wy, _ = self.read_position()
            if wx > 0:
                cur_wx, cur_wy = wx, wy
            
            cur_gx, cur_gy = world_to_game(cur_wx, cur_wy)
            dist = math.hypot(cur_wx - target_wx, cur_wy - target_wy)
            
            if on_step:
                try:
                    on_step(step, cur_gx, cur_gy, dist)
                except Exception:
                    pass
            
            if dist < cfg["arrival_threshold_world"]:
                elapsed = time.time() - t0
                return MoveResult(
                    True, (start_wx, start_wy), (cur_wx, cur_wy),
                    (target_wx, target_wy), step, elapsed, "arrived"
                )
            
            # Stuck detection
            if cur_gx == last_gx and cur_gy == last_gy:
                stuck_count += 1
                if stuck_count >= cfg["stuck_threshold"] * 2:  # Native cần chờ lâu hơn
                    logger.warning("Stuck trong native pathfinding, retry...")
                    self.bot.goto_path_native(target_wx, target_wy)
                    stuck_count = 0
            else:
                stuck_count = 0
            last_gx, last_gy = cur_gx, cur_gy
        
        elapsed = time.time() - t0
        return MoveResult(
            False, (start_wx, start_wy), (cur_wx, cur_wy),
            (target_wx, target_wy), step, elapsed, "max_steps_reached"
        )
    
    # ── Gỡ kẹt ───────────────────────────────────────────────
    
    def _unstuck(self, cur_wx: int, cur_wy: int,
                 target_wx: int, target_wy: int):
        """Thử gỡ kẹt bằng nhiều cách."""
        cfg = self.config
        
        # Cách 1: Tap ADB theo hướng ngược lại để lách ra
        dx = target_wx - cur_wx
        dy = target_wy - cur_wy
        
        # Isometric projection
        sx = (dx - dy) * 0.06
        sy = (dx + dy) * 0.03
        
        dist = math.sqrt(sx*sx + sy*sy)
        if dist > 0:
            # Tap perpendicular (vuông góc) để lách
            perp_x = int(480 - sy / dist * 200)
            perp_y = int(270 + sx / dist * 200)
            perp_x = max(100, min(850, perp_x))
            perp_y = max(80, min(470, perp_y))
            
            logger.info(f"Unstuck: tap ({perp_x}, {perp_y})")
            self.bot.adb_tap(perp_x, perp_y)
            time.sleep(cfg["stuck_recovery_wait"])
        
        # Cách 2: Di chuyển offset nhỏ bằng packet
        offset_wx = cur_wx + (COORD_DIVISOR * 2 if dx >= 0 else -COORD_DIVISOR * 2)
        offset_wy = cur_wy + (COORD_DIVISOR * 2 if dy >= 0 else -COORD_DIVISOR * 2)
        self.bot.move_to(offset_wx, offset_wy)
        time.sleep(cfg["stuck_recovery_wait"])


# ── Tiện ích ──────────────────────────────────────────────────

def calculate_distance_game(gx1: int, gy1: int, gx2: int, gy2: int) -> float:
    """Khoảng cách giữa 2 điểm (tọa độ 3 số), đơn vị: ô grid."""
    return math.hypot(gx2 - gx1, gy2 - gy1)


def calculate_distance_world(wx1: int, wy1: int, wx2: int, wy2: int) -> float:
    """Khoảng cách giữa 2 điểm (tọa độ 5 số)."""
    return math.hypot(wx2 - wx1, wy2 - wy1)


def estimate_travel_time(gx1: int, gy1: int, gx2: int, gy2: int,
                         speed_tiles_per_sec: float = 3.0) -> float:
    """Ước tính thời gian di chuyển (giây).
    
    Args:
        speed_tiles_per_sec: Tốc độ ước tính (~3 ô/giây khi cưỡi ngựa)
    """
    dist = calculate_distance_game(gx1, gy1, gx2, gy2)
    return dist / speed_tiles_per_sec if speed_tiles_per_sec > 0 else float('inf')
