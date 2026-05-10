"""
tests/test_move_v2.py — Di chuyển + Dã Tẩu automation

Hỗ trợ 3 phương pháp di chuyển:
  1. minimap_click — Tap trực tiếp lên minimap
  2. screen_tap   — Tap hướng isometric trên game screen
  3. numpad       — Mở numpad dialog, gõ tọa độ, xác nhận

Các chế độ chạy:
  --target X,Y          Di chuyển đến tọa độ (hoặc tên: da_tau, bien_kinh...)
  --pos                 Đọc vị trí hiện tại (không di chuyển)
  --datau               Chạy vòng lặp Dã Tẩu (move → NPC → quest → dismiss)
  --waypoints a,b,c     Di chuyển qua nhiều điểm liên tiếp

Usage:
    python tests/test_move_v2.py --target 220,190
    python tests/test_move_v2.py --target da_tau --method numpad
    python tests/test_move_v2.py --pos
    python tests/test_move_v2.py --datau --rounds 10 --method numpad
    python tests/test_move_v2.py --waypoints "da_tau,bien_kinh,cong_bac"
"""
import os
import sys
import time
import math
import struct
import logging
import argparse
import subprocess
import threading

try:
    import frida
except ImportError:
    frida = None
sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)
sys.path.insert(0, os.path.join(ROOT_DIR, "tests"))

from core.position import world_to_game, game_to_world_center, COORD_DIVISOR

logging.basicConfig(level=logging.INFO, format="%(asctime)s [%(name)s] %(message)s",
                    datefmt="%H:%M:%S")
logger = logging.getLogger("move_v2")

ADB = r"C:\platform-tools\adb.exe"
DEVICE = "emulator-5554"
GAME_PORT = 0

# Frida Globals
FRIDA_SESSION = None
FRIDA_SCRIPT = None

def init_frida():
    global FRIDA_SESSION, FRIDA_SCRIPT
    if not frida:
        logger.warning("Frida module not installed. Run `pip install frida-tools`.")
        return False
        
    try:
        device = frida.get_device_manager().get_device(DEVICE)
        FRIDA_SESSION = device.attach("VLTieuNgao")
        
        script_path = os.path.join(ROOT_DIR, "features", "bot", "frida_bot.js")
        with open(script_path, 'r', encoding='utf-8') as f:
            FRIDA_SCRIPT = FRIDA_SESSION.create_script(f.read())
            
        def on_message(message, data):
            pass
            
        FRIDA_SCRIPT.on('message', on_message)
        FRIDA_SCRIPT.load()
        logger.info("✅ Frida attached successfully. Movement will be blazing fast!")
        return True
    except Exception as e:
        logger.warning(f"⚠️ Could not attach Frida: {e}. Falling back to tcpdump.")
        FRIDA_SESSION = None
        FRIDA_SCRIPT = None
        return False
# ─── ADB helpers ───────────────────────────────────────────

def adb(cmd: str, timeout=5) -> str:
    result = subprocess.run(
        [ADB, "-s", DEVICE, "shell", cmd],
        capture_output=True, timeout=timeout)
    return result.stdout.decode(errors='ignore')


def adb_tap(x: int, y: int):
    subprocess.run([ADB, "-s", DEVICE, "shell", f"input tap {x} {y}"],
                   capture_output=True, timeout=5)


def adb_swipe(x1, y1, x2, y2, duration_ms=300):
    subprocess.run([ADB, "-s", DEVICE, "shell",
                    f"input swipe {x1} {y1} {x2} {y2} {duration_ms}"],
                   capture_output=True, timeout=10)


def adb_keyevent(key: int):
    """Send Android keyevent (e.g. 111=KEYCODE_ESCAPE, 4=BACK)."""
    subprocess.run([ADB, "-s", DEVICE, "shell", f"input keyevent {key}"],
                   capture_output=True, timeout=5)


def close_all_ui():
    """Đóng tất cả dialog/map/UI đang mở.
    
    Nhấn ESC 2 lần + tap các nút đóng phổ biến.
    Gọi trước mọi thao tác để đảm bảo game ở trạng thái sạch.
    """
    # ESC key đóng hầu hết dialog trong game
    adb_keyevent(111)  # KEYCODE_ESCAPE
    time.sleep(0.3)
    adb_keyevent(111)
    time.sleep(0.3)
    # Tap nút "Đóng" của big map (bottom-right)
    adb_tap(770, 497)
    time.sleep(0.3)
    # Tap close generic dialog
    adb_tap(700, 335)
    time.sleep(0.3)


def detect_port() -> int:
    global GAME_PORT
    if GAME_PORT:
        return GAME_PORT
    out = adb('su -c "netstat -tnp 2>/dev/null"')
    for line in out.splitlines():
        if 'jx1mobile' in line and 'ESTABLISHED' in line:
            port = int(line.split()[4].split(':')[-1])
            if port > 1024:
                GAME_PORT = port
                return port
    return 45676


# Global entity tracking
TRACKED_EID = ""


def get_position(trigger_tap=True, last_pos=None, gentle=False, use_first_pos=False) -> tuple:
    """Get current position via tcpdump.
    
    Uses entity_id tracking to avoid noise from other players.
    
    Args:
        trigger_tap: True = tap screen để trigger opcode 9
        last_pos: (world_x, world_y) — ưu tiên entity gần đây
        gentle: (unused, kept for compatibility)
        use_first_pos: True = lấy vị trí ĐẦU TIÊN trong packets
                       (chính xác hơn khi đứng yên vì chưa di chuyển)
    
    Returns: (game_x, game_y, world_x, world_y, entity_id) or (0,0,0,0,"")
    """
    global TRACKED_EID
    
    if FRIDA_SCRIPT:
        # Use Frida network sniffer instead of tcpdump!
        if trigger_tap:
            adb_tap(480, 300)
            
        # Poll Frida for up to 3 seconds to get the position packet
        pos = None
        for _ in range(15):
            time.sleep(0.2)
            pos = FRIDA_SCRIPT.exports_sync.read_position()
            if pos and pos.get('x', 0) > 0:
                break
                
        if pos and pos.get('x', 0) > 0:
            px, py = pos['x'], pos['y']
            gy, gx = px // 256, py // 256
            if not TRACKED_EID:
                TRACKED_EID = str(pos.get('eid', ''))
                logger.info(f"[Frida] Locked entity ID: {TRACKED_EID}")
            return gx, gy, px, py, str(pos.get('eid', ''))
        
        # If Frida failed or returned 0, fallback to tcpdump just in case
        logger.warning("[Frida] No position returned, falling back to tcpdump")
        
    port = detect_port()
    pcap_dev = "/data/local/tmp/mv2.pcap"
    pcap_local = os.path.join(ROOT_DIR, "data", "output", "mv2.pcap")
    os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
    
    # Kill old tcpdump
    adb('su -c "killall tcpdump 2>/dev/null"')
    adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
    time.sleep(0.2)
    
    # Start capture (tăng limit lên 500 packets)
    proc = subprocess.Popen(
        [ADB, "-s", DEVICE, "shell",
         f'su -c "tcpdump -i any -U -w {pcap_dev} -c 500 port {port}"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    
    time.sleep(0.5)
    
    # Trigger opcode 9 — tap center screen
    if trigger_tap:
        adb_tap(480, 300)
    
    time.sleep(3)
    
    # Stop
    adb('su -c "killall tcpdump 2>/dev/null"')
    proc.terminate()
    time.sleep(0.5)
    
    # Pull + parse
    subprocess.run([ADB, "-s", DEVICE, "pull", pcap_dev, pcap_local],
                   capture_output=True, timeout=10)
    
    if not os.path.exists(pcap_local):
        return 0, 0, 0, 0, ""
    
    from test_open_shop import parse_pcap_recv
    from core.position import detect_player_position, COORD_DIVISOR
    
    packets = parse_pcap_recv(pcap_local, port)
    
    if use_first_pos:
        wx, wy, eid = _detect_first_position(packets)
    else:
        wx, wy, eid = detect_player_position(
            packets,
            last_known_pos=last_pos,
            tracked_eid=TRACKED_EID if TRACKED_EID else None
        )
    
    # Fallback: nếu không tìm thấy player (etype 1/2),
    # scan ALL entities (kể cả NPC etype=6) để ước lượng vị trí.
    # Khi đứng yên gần NPC, chỉ có NPC entities xuất hiện.
    if wx == 0:
        wx, wy, eid = _detect_any_entity(packets)
        if wx > 0:
            logger.info(f"Fallback: used nearby entity for position estimate")
    
    if wx > 0:
        gy, gx = world_to_game(wx, wy)
        if eid and not TRACKED_EID:
            TRACKED_EID = eid
            logger.info(f"Locked entity ID: {eid}")
        return gx, gy, wx, wy, eid
    
    return 0, 0, 0, 0, ""


def _detect_first_position(packets: list) -> tuple:
    """Lấy vị trí ĐẦU TIÊN từ opcode 9 (trước khi nhân vật bắt đầu di chuyển).
    
    Khi tap screen, server gửi opcode 9 với vị trí hiện tại TRƯỚC,
    rồi mới gửi vị trí mới sau khi di chuyển.
    Lấy packet đầu tiên = vị trí đứng yên ban đầu.
    """
    global TRACKED_EID
    
    for opcode, body in packets:
        if opcode != 9 or len(body) < 10:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        parts = text.split('|')
        if len(parts) < 4:
            continue
        try:
            etype = int(parts[0])
        except (ValueError, IndexError):
            continue
        if etype not in (1, 2):
            continue
        
        eid = parts[1]
        
        # Nếu đã lock entity, chỉ lấy entity đó
        if TRACKED_EID and eid != TRACKED_EID:
            continue
        
        try:
            py, px = int(parts[2]), int(parts[3])
            gx, gy = px // 256, py // 256
            if gx < 10 or gy < 10:
                continue
            return px, py, eid
        except (ValueError, IndexError):
            continue
    
    return 0, 0, ""


def _detect_any_entity(packets: list) -> tuple:
    """Fallback: lấy vị trí từ BẤT KỲ entity nào trong opcode 9.
    
    Khi nhân vật đứng yên, server chỉ gửi NPC/monster entities (etype 6+)
    xung quanh. Dùng vị trí trung bình của các entity gần nhất
    để ước lượng vị trí nhân vật.
    """
    positions = []
    
    for opcode, body in packets:
        if opcode != 9 or len(body) < 10:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        parts = text.split('|')
        if len(parts) < 4:
            continue
        try:
            py, px = int(parts[2]), int(parts[3])
            gx, gy = px // 256, py // 256
            if gx < 10 or gy < 10:
                continue
            positions.append((px, py))
        except (ValueError, IndexError):
            continue
    
    if not positions:
        return 0, 0, ""
    
    # Lấy median position (robust hơn mean)
    positions.sort(key=lambda p: p[0])
    mid = len(positions) // 2
    wx = positions[mid][0]
    positions.sort(key=lambda p: p[1])
    wy = positions[mid][1]
    
    return wx, wy, "nearby"


# ─── Method 1: Minimap Click ──────────────────────────────

# Minimap parameters (need calibration)
MINIMAP_CENTER_X = 893    # Screen X of minimap center (player pos)
MINIMAP_CENTER_Y = 65     # Screen Y of minimap center
MINIMAP_RADIUS = 55       # Radius of clickable minimap area
MINIMAP_SCALE = 3.0       # Pixels per game tile (approximate, needs calibration)


def move_minimap_click(target_gx: int, target_gy: int, max_attempts=5):
    """Move by clicking directly on the minimap.
    
    Minimap shows a small area around the player.
    Click on the minimap in the direction of target.
    If target is within minimap view, click exact position.
    If target is far, click minimap edge in that direction.
    """
    logger.info(f"=== Minimap Click Move → ({target_gx}, {target_gy}) ===")
    
    last_pos = None
    
    for attempt in range(1, max_attempts + 1):
        # Get current position
        gx, gy, wx, wy, eid = get_position(trigger_tap=True, last_pos=last_pos)
        if gx == 0:
            logger.warning(f"[{attempt}] Cannot detect position")
            continue
        
        last_pos = (wx, wy)
        
        dx = target_gx - gx
        dy = target_gy - gy
        dist = math.hypot(dx, dy)
        
        logger.info(f"[{attempt}] Pos: ({gx}, {gy}) → Target: ({target_gx}, {target_gy}) | Dist: {dist:.1f} tiles")
        
        if dist < 3:
            logger.info(f"✅ Arrived at ({gx}, {gy})!")
            return True, gx, gy
        
        # Calculate minimap click position
        # Minimap uses isometric projection similar to game view
        # In minimap: right = +X, down = +Y (roughly)
        # But minimap is top-down, so:
        #   minimap_dx = (target_gx - gx) * scale
        #   minimap_dy = (target_gy - gy) * scale
        
        mm_dx = dx * MINIMAP_SCALE
        mm_dy = dy * MINIMAP_SCALE
        
        # Clamp to minimap radius
        mm_dist = math.hypot(mm_dx, mm_dy)
        if mm_dist > MINIMAP_RADIUS:
            mm_dx = mm_dx / mm_dist * MINIMAP_RADIUS
            mm_dy = mm_dy / mm_dist * MINIMAP_RADIUS
        
        tap_x = int(MINIMAP_CENTER_X + mm_dx)
        tap_y = int(MINIMAP_CENTER_Y + mm_dy)
        
        # Clamp to screen
        tap_x = max(830, min(955, tap_x))
        tap_y = max(20, min(140, tap_y))
        
        logger.info(f"[{attempt}] Minimap tap: ({tap_x}, {tap_y}) [offset: {mm_dx:.0f}, {mm_dy:.0f}]")
        
        adb_tap(tap_x, tap_y)
        
        # Wait for pathfinding (proportional to distance)
        wait = max(3, min(20, int(dist * 0.8)))
        logger.info(f"[{attempt}] Waiting {wait}s for pathfinding...")
        time.sleep(wait)
    
    # Final check
    gx, gy, wx, wy, eid = get_position(trigger_tap=True, last_pos=last_pos)
    dist = math.hypot(gx - target_gx, gy - target_gy) if gx > 0 else 999
    
    if dist < 3:
        logger.info(f"✅ Arrived at ({gx}, {gy})!")
        return True, gx, gy
    
    logger.warning(f"❌ Not arrived. Final pos: ({gx}, {gy}), dist: {dist:.1f}")
    return False, gx, gy


# ─── Method 2: Screen Tap (directional) ───────────────────

def move_screen_tap(target_gx: int, target_gy: int, max_steps=15):
    """Move by tapping on the game screen in the direction of target.
    
    Uses isometric projection to calculate tap position.
    Taps repeatedly, checking position each time.
    """
    logger.info(f"=== Screen Tap Move → ({target_gx}, {target_gy}) ===")
    
    target_wx, target_wy = game_to_world_center(target_gx, target_gy)
    last_pos = None
    stuck_count = 0
    last_gx, last_gy = 0, 0
    
    for step in range(1, max_steps + 1):
        gx, gy, wx, wy, eid = get_position(trigger_tap=True, last_pos=last_pos)
        if gx == 0:
            logger.warning(f"[{step}] Cannot detect position")
            continue
        
        last_pos = (wx, wy)
        
        dx = target_gx - gx
        dy = target_gy - gy
        dist = math.hypot(dx, dy)
        
        logger.info(f"[{step}] ({gx}, {gy}) → ({target_gx}, {target_gy}) | {dist:.1f} tiles")
        
        if dist < 3:
            logger.info(f"✅ Arrived!")
            return True, gx, gy
        
        # Stuck detection
        if gx == last_gx and gy == last_gy:
            stuck_count += 1
            if stuck_count >= 3:
                logger.warning("Stuck! Trying perpendicular movement...")
                # Tap perpendicular direction
                perp_x = int(480 + dy * 30)
                perp_y = int(270 - dx * 15)
                perp_x = max(100, min(850, perp_x))
                perp_y = max(80, min(470, perp_y))
                adb_tap(perp_x, perp_y)
                time.sleep(2)
                stuck_count = 0
                continue
        else:
            stuck_count = 0
        last_gx, last_gy = gx, gy
        
        # Isometric screen tap calculation
        # Game uses isometric projection: screen_x ∝ (world_x - world_y), screen_y ∝ (world_x + world_y)
        dwx = target_wx - wx
        dwy = target_wy - wy
        
        sx = (dwx - dwy) * 0.06
        sy = (dwx + dwy) * 0.03
        
        # Normalize to fixed distance from center
        sdist = math.hypot(sx, sy)
        if sdist > 0:
            tap_dist = min(250, max(150, dist * 15))  # Farther target = farther tap
            sx = sx / sdist * tap_dist
            sy = sy / sdist * tap_dist
        
        tap_x = int(480 + sx)
        tap_y = int(270 + sy)
        tap_x = max(100, min(850, tap_x))
        tap_y = max(80, min(470, tap_y))
        
        logger.info(f"[{step}] Screen tap: ({tap_x}, {tap_y})")
        adb_tap(tap_x, tap_y)
        
        # Wait for movement
        wait = min(5, max(2, int(dist * 0.5)))
        time.sleep(wait)
    
    gx, gy, wx, wy, eid = get_position(trigger_tap=True, last_pos=last_pos)
    dist = math.hypot(gx - target_gx, gy - target_gy) if gx > 0 else 999
    
    if dist < 3:
        logger.info(f"✅ Arrived at ({gx}, {gy})!")
        return True, gx, gy
    
    logger.warning(f"❌ Final: ({gx}, {gy}), dist: {dist:.1f}")
    return False, gx, gy


# ─── Method 3: Numpad (existing, for comparison) ──────────

NUMPAD = {
    '0': (500, 351), '1': (500, 296), '2': (570, 296), '3': (630, 296),
    '4': (500, 241), '5': (570, 241), '6': (630, 241),
    '7': (500, 186), '8': (570, 186), '9': (630, 186),
    ' ': (570, 351), 'x': (630, 351),
}


def move_numpad(target_gx: int, target_gy: int, max_attempts=2):
    """Move using numpad dialog — gõ tọa độ 1 lần, chờ pathfinding, verify.
    
    Flow:
      1. Reset entity tracking (tránh lock sai từ lần trước)
      2. Mở numpad dialog (tap minimap coords area)
      3. Clear + gõ tọa độ đích
      4. Nhấn Xác nhận
      5. Chờ pathfinding (ước tính từ khoảng cách)
      6. Verify vị trí cuối cùng
    """
    global TRACKED_EID
    TRACKED_EID = ""  # Reset — tránh lock entity sai từ lần chạy trước
    
    logger.info(f"=== Numpad Move → ({target_gx}, {target_gy}) ===")
    
    # Đóng mọi UI (big map, dialog...) trước khi bắt đầu
    close_all_ui()
    time.sleep(0.5)
    
    for attempt in range(1, max_attempts + 1):
        logger.info(f"[Attempt {attempt}/{max_attempts}]")
        
        # ── Step 1: Mở numpad dialog ──
        # Đóng dialog/UI đang mở (nếu có)
        adb_tap(700, 335)
        time.sleep(0.5)
        
        # Tap vào tọa độ dưới minimap để mở numpad
        adb_tap(890, 120)
        time.sleep(1.5)
        
        # ── Step 2: Clear cũ + gõ tọa độ mới ──
        # Nhấn X (xóa) 6 lần để clear
        for _ in range(6):
            adb_tap(630, 351)  # nút X
            time.sleep(0.15)
        time.sleep(0.3)
        
        # Gõ tọa độ: "XXX YYY" (space phân cách X và Y)
        coord_str = f"{target_gx} {target_gy}"
        logger.info(f"  Typing: '{coord_str}'")
        for ch in coord_str:
            if ch in NUMPAD:
                adb_tap(*NUMPAD[ch])
                time.sleep(0.2)
        
        # ── Step 3: Xác nhận ──
        time.sleep(0.3)
        adb_tap(265, 333)  # nút Xác nhận
        logger.info(f"  Confirmed! Waiting for pathfinding...")
        time.sleep(1)
        
        # ── Step 4: Chờ pathfinding ──
        # Game auto-pathfind: ~2-3 tiles/giây khi cưỡi ngựa
        # Ước tính tối đa 50 tiles ÷ 2 tiles/s = 25s + buffer
        wait = 30  # Chờ cố định 30s cho pathfinding hoàn tất
        logger.info(f"  Waiting {wait}s for character to arrive...")
        time.sleep(wait)
        
        # ── Step 5: Verify vị trí ──
        # Đóng UI trước (numpad có thể vẫn mở sau confirm)
        adb_tap(700, 335)   # close numpad/dialog
        time.sleep(0.5)
        adb_tap(700, 335)   # double tap cho chắc
        time.sleep(0.5)
        
        logger.info(f"  Checking final position...")
        gx, gy = 0, 0
        for retry in range(3):
            gx, gy, wx, wy, eid = get_position(trigger_tap=True)
            if gx > 0:
                break
            logger.warning(f"  Position detect attempt {retry+1}/3 failed, retrying...")
            time.sleep(2)
        
        if gx > 0:
            dist = math.hypot(gx - target_gx, gy - target_gy)
            logger.info(f"  Position: ({gx}, {gy}) | Target: ({target_gx}, {target_gy}) | Dist: {dist:.1f}")
            
            if dist < 5:  # Cho phép sai số 5 tiles
                logger.info(f"✅ Arrived at ({gx}, {gy})!")
                return True, gx, gy
            else:
                logger.warning(f"  Not at target yet (dist={dist:.1f}). {'Retrying...' if attempt < max_attempts else 'Giving up.'}")
        else:
            logger.warning(f"  Position detection failed. {'Retrying...' if attempt < max_attempts else 'Giving up.'}")
    
    # Final result
    if gx > 0:
        logger.warning(f"❌ Final: ({gx}, {gy}), dist: {dist:.1f}")
        return False, gx, gy
    else:
        logger.warning(f"❌ Cannot verify final position")
        return False, 0, 0


# ─── Named Locations ───────────────────────────────────────

LOCATIONS = {
    "da_tau":     (240, 175, "NPC Dã Tẩu"),
    "bien_kinh":  (210, 195, "Biện Kinh center"),
    "pho_nam":    (212, 197, "Phố Nam Bang"),
    "cong_bac":   (210, 185, "Cổng Bắc"),
    "cong_nam":   (215, 205, "Cổng Nam"),
    "tap_hoa":    (205, 190, "Tiệm Tạp Hóa"),
}

# NPC Dã Tẩu tap position (screen coords khi đứng gần NPC)
NPC_DA_TAU_TAP = (430, 75)


# ─── Position check ────────────────────────────────────────

def get_all_entities(gentle=True) -> list:
    """Capture packets and return ALL player entities (for debug).
    
    Returns list of dicts: {eid, etype, gx, gy, wx, wy, updates}
    """
    port = detect_port()
    pcap_dev = "/data/local/tmp/mv2.pcap"
    pcap_local = os.path.join(ROOT_DIR, "data", "output", "mv2.pcap")
    os.makedirs(os.path.dirname(pcap_local), exist_ok=True)
    
    adb('su -c "killall tcpdump 2>/dev/null"')
    adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
    time.sleep(0.2)
    
    proc = subprocess.Popen(
        [ADB, "-s", DEVICE, "shell",
         f'su -c "tcpdump -i any -U -w {pcap_dev} -c 200 port {port}"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    
    time.sleep(0.5)
    if gentle:
        adb_tap(890, 120)
        time.sleep(0.8)
        adb_tap(700, 335)
    else:
        adb_tap(480, 300)
    
    time.sleep(2.5)
    adb('su -c "killall tcpdump 2>/dev/null"')
    proc.terminate()
    time.sleep(0.5)
    
    subprocess.run([ADB, "-s", DEVICE, "pull", pcap_dev, pcap_local],
                   capture_output=True, timeout=10)
    
    if not os.path.exists(pcap_local):
        return []
    
    from test_open_shop import parse_pcap_recv
    packets = parse_pcap_recv(pcap_local, port)
    
    entities = {}  # eid -> {etype_set, positions, last_pos}
    for opcode, body in packets:
        if opcode != 9 or len(body) < 10:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        parts = text.split('|')
        if len(parts) < 4:
            continue
        try:
            etype = int(parts[0])
        except (ValueError, IndexError):
            continue
        if etype not in (1, 2):
            continue
        eid = parts[1]
        try:
            px, py = int(parts[2]), int(parts[3])
            gx, gy = px // 256, py // 256
            if gx < 10 or gy < 10:
                continue
            if eid not in entities:
                entities[eid] = {"eid": eid, "etypes": set(), "positions": [], "last_pos": (0, 0)}
            entities[eid]["etypes"].add(etype)
            entities[eid]["positions"].append((px, py))
            entities[eid]["last_pos"] = (px, py)
        except (ValueError, IndexError):
            pass
    
    result = []
    for eid, data in entities.items():
        wx, wy = data["last_pos"]
        result.append({
            "eid": eid,
            "etypes": sorted(data["etypes"]),
            "gx": wx // 256, "gy": wy // 256,
            "wx": wx, "wy": wy,
            "updates": len(data["positions"]),
        })
    # Sort: most updates first
    result.sort(key=lambda x: x["updates"], reverse=True)
    return result


def cmd_pos(debug=False):
    """Đọc vị trí hiện tại, không di chuyển.
    
    --debug: hiện tất cả entities để xác minh detection.
    """
    # Đóng mọi UI trước
    close_all_ui()
    time.sleep(0.5)
    
    if debug:
        print("\n[*] DEBUG: Dumping all entities from opcode 9...")
        entities = get_all_entities(gentle=True)
        if not entities:
            print("[-] No entities found. Trying center tap...")
            entities = get_all_entities(gentle=False)
        
        if entities:
            print(f"\n  Found {len(entities)} player entities:")
            print(f"  {'EID':>10}  {'Type':>6}  {'Game':>10}  {'World':>14}  {'Updates':>7}")
            print(f"  {'─'*55}")
            for e in entities:
                etypes = ",".join(str(t) for t in e["etypes"])
                print(f"  {e['eid']:>10}  {etypes:>6}  ({e['gx']:>3},{e['gy']:>3})  ({e['wx']:>5},{e['wy']:>5})  {e['updates']:>7}")
            print(f"\n  [TIP] Entity với nhiều updates nhất thường là bạn.")
            print(f"  [TIP] etype 1 = position update, etype 2 = appearance update")
        else:
            print("[-] No entities detected.")
        return
    
    # Normal mode
    print("\n[*] Detecting current position...")
    gx, gy, wx, wy, eid = get_position(trigger_tap=True, use_first_pos=True)
    
    if gx == 0:
        # Fallback: center tap
        print("[-] Gentle read failed. Trying center tap...")
        gx, gy, wx, wy, eid = get_position(trigger_tap=True, gentle=False)
    
    if gx > 0:
        print(f"\n  ✅ Position: ({gx}, {gy})")
        print(f"     World:    ({wx}, {wy})")
        print(f"     Entity:   {eid}")
    else:
        print("[-] Failed to detect position.")



# ─── Waypoint navigation ──────────────────────────────────

def move_waypoints(waypoints: list, method_fn, method_name: str = "numpad"):
    """Di chuyển qua nhiều điểm liên tiếp.

    Args:
        waypoints: list of (gx, gy, label)
        method_fn: function(gx, gy) -> (ok, fx, fy)
        method_name: tên method để hiển thị
    """
    logger.info(f"=== Waypoint navigation ({len(waypoints)} points, method={method_name}) ===")
    total_t0 = time.time()
    results = []

    for i, (gx, gy, label) in enumerate(waypoints, 1):
        print(f"\n{'─'*60}")
        print(f"  [{i}/{len(waypoints)}] → {label} ({gx}, {gy})")
        print(f"{'─'*60}")

        t0 = time.time()
        ok, fx, fy = method_fn(gx, gy)
        elapsed = time.time() - t0
        results.append({"label": label, "target": (gx, gy), "ok": ok, "pos": (fx, fy), "time": elapsed})

        status = "✅" if ok else "❌"
        print(f"  {status} ({fx}, {fy}) in {elapsed:.1f}s")

        if not ok:
            logger.warning(f"Waypoint '{label}' failed, stopping.")
            break

        # Nghỉ ngắn giữa các waypoint
        if i < len(waypoints):
            time.sleep(1)

    total_elapsed = time.time() - total_t0

    print(f"\n{'='*60}")
    print(f"  WAYPOINT SUMMARY ({total_elapsed:.1f}s total)")
    print(f"{'='*60}")
    for r in results:
        s = "✅" if r["ok"] else "❌"
        print(f"  {s} {r['label']:20s} → ({r['pos'][0]}, {r['pos'][1]})  {r['time']:.1f}s")

    ok_count = sum(1 for r in results if r["ok"])
    print(f"\n  {ok_count}/{len(waypoints)} waypoints reached")
    return results


# ─── NPC Interaction ───────────────────────────────────────

def tap_npc_datau():
    """Tap NPC Dã Tẩu và đọc quest info."""
    logger.info(f"Tapping NPC Dã Tẩu at {NPC_DA_TAU_TAP}...")
    adb_tap(*NPC_DA_TAU_TAP)
    time.sleep(2)

    # Capture packets để đọc quest
    port = detect_port()
    pcap_dev = "/data/local/tmp/quest_v2.pcap"
    pcap_local = os.path.join(ROOT_DIR, "data", "output", "quest_v2.pcap")
    os.makedirs(os.path.dirname(pcap_local), exist_ok=True)

    adb('su -c "killall tcpdump 2>/dev/null"')
    adb(f'su -c "rm {pcap_dev} 2>/dev/null"')
    time.sleep(0.2)

    proc = subprocess.Popen(
        [ADB, "-s", DEVICE, "shell",
         f'su -c "tcpdump -i any -U -w {pcap_dev} -c 500 port {port}"'],
        stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)

    time.sleep(0.5)
    # Tap NPC lần nữa để chắc chắn
    adb_tap(*NPC_DA_TAU_TAP)
    time.sleep(3)

    adb('su -c "killall tcpdump 2>/dev/null"')
    proc.terminate()
    time.sleep(0.5)

    subprocess.run([ADB, "-s", DEVICE, "pull", pcap_dev, pcap_local],
                   capture_output=True, timeout=10)

    if not os.path.exists(pcap_local):
        logger.warning("No pcap captured for quest")
        return None

    from test_open_shop import parse_pcap_recv
    packets = parse_pcap_recv(pcap_local, port)

    # Tìm opcode 34 (dialog) hoặc 54 (quest tracker)
    quest = None
    try:
        from core.quest import parse_opcode34, parse_opcode54
        for opcode, body in packets:
            if opcode == 54 and len(body) > 10:
                q = parse_opcode54(body)
                if q and q.is_valid:
                    quest = q
                    break
            if opcode == 34 and len(body) > 10:
                q = parse_opcode34(body)
                if q and q.is_valid:
                    quest = q
    except ImportError:
        logger.warning("core.quest not available, cannot parse quest")

    return quest


def dismiss_dialog(button_idx=-1):
    """Đóng dialog NPC.

    button_idx:
        -1 = nút cuối ("Biết rồi!")
         0 = nút đầu ("Đã hoàn thành nv")
    """
    buttons = [
        (600, 348),  # Đã hoàn thành nv
        (680, 378),  # Ta muốn hủy nv
        (720, 418),  # Biết rồi!
    ]
    idx = button_idx if button_idx >= 0 else len(buttons) - 1
    if idx < len(buttons):
        logger.info(f"Dismiss dialog button [{idx}] at {buttons[idx]}")
        adb_tap(*buttons[idx])
        time.sleep(0.5)


# ─── Dã Tẩu Loop ──────────────────────────────────────────

def cmd_datau_loop(method: str = "numpad", max_rounds: int = 5):
    """Chạy vòng lặp Dã Tẩu:
    1. Di chuyển đến NPC
    2. Tap NPC → đọc quest
    3. Dismiss dialog
    4. (TODO) Lấy item
    5. Quay lại NPC → hoàn thành

    Hiện tại: chỉ loop bước 1-3 (move + read quest + dismiss).
    """
    method_fn = {"minimap_click": move_minimap_click,
                 "screen_tap": move_screen_tap,
                 "numpad": move_numpad}.get(method, move_numpad)

    da_tau_gx, da_tau_gy, da_tau_label = LOCATIONS["da_tau"]

    print()
    print("=" * 60)
    print(f"  DÃ TẨU LOOP — max {max_rounds} rounds")
    print(f"  NPC: {da_tau_label} ({da_tau_gx}, {da_tau_gy})")
    print(f"  Method: {method}")
    print("=" * 60)

    for rnd in range(1, max_rounds + 1):
        print(f"\n{'━'*60}")
        print(f"  ROUND {rnd}/{max_rounds}")
        print(f"{'━'*60}")

        # Step 1: Di chuyển đến NPC
        print(f"\n  [1] Di chuyển đến NPC Dã Tẩu...")
        t0 = time.time()
        ok, fx, fy = method_fn(da_tau_gx, da_tau_gy)
        move_time = time.time() - t0

        if not ok:
            dist = math.hypot(fx - da_tau_gx, fy - da_tau_gy)
            if dist > 10:
                logger.warning(f"Round {rnd}: Không đến được NPC (dist={dist:.0f}). Thử lại...")
                ok, fx, fy = method_fn(da_tau_gx, da_tau_gy)
                if not ok:
                    print(f"  ❌ Không thể đến NPC sau 2 lần thử. Dừng.")
                    break
        print(f"  ✅ Đến NPC ({fx}, {fy}) in {move_time:.1f}s")

        # Step 2: Tap NPC → đọc quest
        print(f"\n  [2] Tap NPC Dã Tẩu...")
        time.sleep(1)
        quest = tap_npc_datau()

        if quest and quest.is_valid:
            print(f"  📜 Quest #{quest.quest_number}: {quest.item_count}x {quest.item_name}")
            if quest.element:
                print(f"     Hệ: {quest.element}")
            if quest.npc_game_coords[0] > 0:
                print(f"     NPC: {quest.npc_game_coords}")
        else:
            print(f"  ⚠️ Không đọc được quest (dialog trống hoặc parse fail)")

        # Step 3: Dismiss dialog
        print(f"\n  [3] Đóng dialog...")
        dismiss_dialog(-1)  # Nhấn "Biết rồi!"
        time.sleep(1)

        # Step 4: TODO — Kiểm tra inventory + lấy item
        print(f"\n  [4] ⏳ Lấy item (chưa implement — cần capture inventory opcode)")

        # Step 5: TODO — Quay lại NPC + hoàn thành
        print(f"\n  [5] ⏳ Hoàn thành NV (chưa implement)")

        print(f"\n  ── Round {rnd} done ──")

        if rnd < max_rounds:
            print(f"  Chờ 3s trước round tiếp...")
            time.sleep(3)

    print(f"\n{'='*60}")
    print(f"  DÃ TẨU LOOP FINISHED — {max_rounds} rounds")
    print(f"{'='*60}")


# ─── Single move test ─────────────────────────────────────

def cmd_move(tx: int, ty: int, method: str = "all"):
    """Test di chuyển đến 1 điểm."""
    print()
    print("=" * 60)
    print(f"  VLTK1 — Move V2 Test")
    print(f"  Target: ({tx}, {ty})")
    print(f"  Method: {method}")
    print("=" * 60)

    methods = {
        "minimap_click": ("MINIMAP CLICK", move_minimap_click),
        "screen_tap":    ("SCREEN TAP",    move_screen_tap),
        "numpad":        ("NUMPAD",        move_numpad),
    }

    run_list = list(methods.keys()) if method == "all" else [method]
    results = {}

    for m in run_list:
        label, fn = methods[m]
        print(f"\n{'─'*60}")
        print(f"  Method: {label}")
        print(f"{'─'*60}")
        t0 = time.time()
        ok, fx, fy = fn(tx, ty)
        elapsed = time.time() - t0
        results[m] = {"ok": ok, "pos": (fx, fy), "time": elapsed}
        print(f"  Result: {'✅' if ok else '❌'} ({fx}, {fy}) in {elapsed:.1f}s")

        if method == "all" and m != run_list[-1]:
            time.sleep(2)

    if len(results) > 1:
        print(f"\n{'='*60}")
        print("  SUMMARY")
        print(f"{'='*60}")
        for m, r in results.items():
            status = "✅" if r["ok"] else "❌"
            print(f"  {m:20s} {status}  ({r['pos'][0]}, {r['pos'][1]})  {r['time']:.1f}s")


# ─── Main ──────────────────────────────────────────────────

def main():
    parser = argparse.ArgumentParser(
        description="VLTK1 Move V2 — Di chuyển + Dã Tẩu automation",
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  python tests/test_move_v2.py --target 220,190
  python tests/test_move_v2.py --target da_tau --method numpad
  python tests/test_move_v2.py --pos
  python tests/test_move_v2.py --datau --rounds 10
  python tests/test_move_v2.py --waypoints "da_tau,bien_kinh,cong_bac"

Named locations: """ + ", ".join(LOCATIONS.keys())
    )

    # Mode selection (không bắt buộc — mặc định --pos)
    group = parser.add_mutually_exclusive_group(required=False)
    group.add_argument("--target", "-t",
                       help="Move to target: X,Y or named location")
    group.add_argument("--pos", "-p", action="store_true", default=True,
                       help="Check current position only (default)")
    group.add_argument("--datau", "-d", action="store_true",
                       help="Run Dã Tẩu quest loop")
    group.add_argument("--waypoints", "-w",
                       help="Comma-separated list of named locations or X:Y coords")

    # Options
    parser.add_argument("--method", "-m", default="numpad",
                        choices=["minimap_click", "screen_tap", "numpad", "all"],
                        help="Movement method (default: numpad)")
    parser.add_argument("--rounds", "-r", type=int, default=5,
                        help="Max rounds for Dã Tẩu loop (default: 5)")
    parser.add_argument("--debug", action="store_true",
                        help="Debug mode: show all entities (with --pos)")

    args = parser.parse_args()
    
    # Init Frida
    init_frida()

    # ── Position check (default) ──
    if not args.target and not args.datau and not args.waypoints:
        cmd_pos(debug=args.debug)
        return


    # ── Dã Tẩu loop ──
    if args.datau:
        cmd_datau_loop(method=args.method, max_rounds=args.rounds)
        return

    # ── Waypoints ──
    if args.waypoints:
        wp_list = []
        for wp in args.waypoints.split(","):
            wp = wp.strip()
            if wp in LOCATIONS:
                gx, gy, label = LOCATIONS[wp]
                wp_list.append((gx, gy, label))
            elif ":" in wp:
                parts = wp.split(":")
                wp_list.append((int(parts[0]), int(parts[1]), f"({parts[0]},{parts[1]})"))
            else:
                print(f"[-] Unknown waypoint: {wp}")
                print(f"    Available: {', '.join(LOCATIONS.keys())}")
                return

        method_fn = {"minimap_click": move_minimap_click,
                     "screen_tap": move_screen_tap,
                     "numpad": move_numpad}.get(args.method, move_numpad)
        move_waypoints(wp_list, method_fn, args.method)
        return

    # ── Single target ──
    target = args.target
    if target in LOCATIONS:
        tx, ty = LOCATIONS[target][0], LOCATIONS[target][1]
        print(f"  Location: {LOCATIONS[target][2]}")
    elif "," in target:
        tx, ty = [int(x) for x in target.split(",")]
    else:
        print(f"[-] Unknown target: {target}")
        print(f"    Available: {', '.join(LOCATIONS.keys())} or X,Y")
        return

    cmd_move(tx, ty, method=args.method)


if __name__ == "__main__":
    main()

