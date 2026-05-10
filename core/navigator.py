"""
core/navigator.py — Di chuyển nhân vật bằng Numpad

Flow:
  1. Mở numpad dialog (tap vào tọa độ trên minimap)
  2. Gõ tọa độ đích "XXX YYY"
  3. Bấm Xác nhận
  4. Chờ nhân vật tự chạy (pathfinding)
  5. Verify vị trí bằng Frida

Usage:
    from core.adb_helper import ADBHelper
    from core.navigator import Navigator

    adb = ADBHelper()
    adb.init_frida()
    nav = Navigator(adb)
    nav.move_to(203, 198)  # Di chuyển tới Dã Tẩu
"""
import time
import math
import logging

logger = logging.getLogger("navigator")

# ── Numpad pixel coordinates (960x540 screen) ────────────────
NUMPAD_KEYS = {
    '0': (500, 351), '1': (500, 296), '2': (570, 296), '3': (630, 296),
    '4': (500, 241), '5': (570, 241), '6': (630, 241),
    '7': (500, 186), '8': (570, 186), '9': (630, 186),
    ' ': (570, 351),  # Space (giữa 0 và X)
}
NUMPAD_X_CLEAR = (630, 351)       # Nút X (xóa ký tự)
NUMPAD_OPEN = (890, 120)          # Tap minimap coords → mở numpad
NUMPAD_CONFIRM = (265, 333)       # Nút "Xác nhận" dialog bên trái
NUMPAD_CLOSE = (700, 335)         # Nút đóng dialog


class Navigator:
    """Di chuyển nhân vật bằng Numpad ingame."""

    def __init__(self, adb_helper):
        """
        Args:
            adb_helper: ADBHelper instance (đã init_frida)
        """
        self.adb = adb_helper

    def open_numpad(self):
        """Mở dialog nhập tọa độ bằng cách tap vào minimap."""
        # Đóng dialog cũ nếu có
        self.adb.tap(*NUMPAD_CLOSE)
        time.sleep(0.3)

        # Tap vào khu vực tọa độ trên minimap
        self.adb.tap(*NUMPAD_OPEN)
        time.sleep(1.0)

    def type_coords(self, gx: int, gy: int):
        """Gõ tọa độ "XXX YYY" trên numpad.

        Không cần clear trước — gõ trực tiếp.
        """
        coord_str = f"{gx} {gy}"
        logger.info(f"  Typing: '{coord_str}'")

        for ch in coord_str:
            if ch in NUMPAD_KEYS:
                self.adb.tap(*NUMPAD_KEYS[ch])
                time.sleep(0.15)

    def confirm(self):
        """Bấm nút Xác nhận để nhân vật bắt đầu chạy."""
        time.sleep(0.2)
        self.adb.tap(*NUMPAD_CONFIRM)
        logger.info("  Confirmed!")
        time.sleep(0.5)

        # Đóng numpad/dialog sau khi confirm
        self.adb.tap(*NUMPAD_CLOSE)
        time.sleep(0.3)
        self.adb.keyevent(111)  # ESC đóng nốt
        time.sleep(0.3)

    def move_to(self, target_gx: int, target_gy: int,
                wait_seconds=10, tolerance=5) -> bool:
        """Di chuyển nhân vật tới tọa độ game (3 số).

        Flow: Numpad gõ tọa độ → chờ pathfinding → verify 1 lần.

        Args:
            target_gx, target_gy: Tọa độ đích (game coords, 3 số)
            wait_seconds: Thời gian chờ pathfinding (giây)
            tolerance: Sai số cho phép (tiles)

        Returns:
            True nếu đã tới nơi, False nếu timeout
        """
        logger.info(f"=== Move to ({target_gx}, {target_gy}) ===")

        # Đóng UI sạch trước
        self.adb.close_all_ui()
        time.sleep(0.3)

        # Đọc vị trí ban đầu
        cur_gx, cur_gy = self.adb.get_position()
        if cur_gx > 0:
            dist = math.hypot(cur_gx - target_gx, cur_gy - target_gy)
            logger.info(f"  Current: ({cur_gx}, {cur_gy}) | Dist: {dist:.0f} tiles")
            if dist < tolerance:
                logger.info(f"  Already at target!")
                return True

        # Mở numpad + gõ tọa độ + xác nhận
        self.open_numpad()
        self.type_coords(target_gx, target_gy)
        self.confirm()

        # Chờ pathfinding hoàn tất
        logger.info(f"  Waiting {wait_seconds}s for pathfinding...")
        time.sleep(wait_seconds)

        # Verify 1 lần
        gx, gy = self.adb.get_position()
        if gx > 0:
            dist = math.hypot(gx - target_gx, gy - target_gy)
            logger.info(f"  Final: ({gx}, {gy}) | Dist: {dist:.0f}")
            if dist < tolerance:
                logger.info(f"  Arrived!")
                return True
            else:
                logger.warning(f"  Not at target (dist={dist:.0f})")
                return False
        else:
            logger.warning(f"  Cannot verify position")
            return False

    def move_to_npc(self, npc_name: str, map_name: str = None, wait_seconds=10, tolerance=2) -> bool:
        """Di chuyển đến chính xác tọa độ của NPC dựa trên dữ liệu JSON.
        
        Args:
            npc_name: Tên NPC (VD: "Dã Tẩu", "Tạp hóa")
            map_name: Tên bản đồ (VD: "Ba Lăng Huyện"). Nếu None, sẽ tìm trên mọi map.
            
        Returns:
            True nếu tới thành công.
        """
        from core.map_manager import MapManager
        if not hasattr(self, "map_mgr"):
            self.map_mgr = MapManager()
            
        coords = self.map_mgr.get_npc_coords(npc_name, map_name)
        if not coords:
            logger.error(f"  Không thể tìm thấy tọa độ NPC: {npc_name} tại {map_name}")
            return False
            
        gx, gy = coords
        logger.info(f"  -> Tọa độ NPC '{npc_name}' là: {gx}, {gy}")
        
        return self.move_to(gx, gy, wait_seconds=wait_seconds, tolerance=tolerance)
