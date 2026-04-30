"""
test_movement.py - Di chuyển nhân vật (Big Map + tcpdump)

Cách hoạt động:
  1. Đọc tọa độ hiện tại bằng tcpdump (tap nhẹ trigger opcode 9)
  2. Mở bản đồ lớn → click vào vị trí đích → đóng map
  3. Nhân vật tự pathfind, tracking bằng tcpdump
  4. Không OCR, không inject packet

Usage:
    python tests/test_movement.py                    # Mặc định: đi đến Dã Tẩu
    python tests/test_movement.py --target 240,175   # Game coords (3 số)
    python tests/test_movement.py --target da_tau
"""
import sys
import os
import time
import logging

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)
sys.path.insert(0, os.path.join(ROOT_DIR, 'proto'))

from features.bot.game_bot import VLTK1Bot
from core.position import world_to_game, game_to_world_center, COORD_DIVISOR
from core.movement import MovementController, MoveResult

logging.basicConfig(
    level=logging.INFO,
    format='%(asctime)s [%(name)s] %(message)s',
    datefmt='%H:%M:%S'
)
logger = logging.getLogger('test_movement')

LOCATIONS = {
    "da_tau":     (240, 175, "Dã Tẩu"),
    "bien_kinh":  (210, 195, "Biện Kinh"),
    "pho_nam":    (212, 197, "Phố Nam Bang"),
    "cong_bac":   (210, 185, "Cổng Bắc"),
    "cong_nam":   (215, 205, "Cổng Nam"),
}


def on_step(step, gx, gy, dist):
    tiles = dist / COORD_DIVISOR
    print(f"  [Step {step:2d}] ({gx}, {gy})  dist: {dist:.0f} (~{tiles:.1f} tiles)")


def print_result(result: MoveResult, label: str = ""):
    sg = result.start_game
    eg = result.end_game
    tg = result.target_game
    
    print(f"\n{'='*60}")
    if label:
        print(f"  {label}")
    print(f"  Start:    ({sg[0]}, {sg[1]})")
    print(f"  End:      ({eg[0]}, {eg[1]})")
    print(f"  Target:   ({tg[0]}, {tg[1]})")
    print(f"  Distance: {result.remaining_distance:.0f} ({result.remaining_distance/COORD_DIVISOR:.1f} tiles)")
    print(f"  Steps:    {result.steps}")
    print(f"  Time:     {result.elapsed:.1f}s")
    status = "OK" if result.success else f"FAIL ({result.reason})"
    print(f"  >>> {status}")
    print(f"{'='*60}")


def main():
    import argparse
    parser = argparse.ArgumentParser(description='VLTK1 - Movement Test')
    parser.add_argument('--target', '-t', default='da_tau',
                        help=f'Target: {", ".join(LOCATIONS.keys())} or "X,Y"')
    parser.add_argument('--steps', '-s', type=int, default=30,
                        help='Max steps (default: 30)')
    parser.add_argument('--debug', action='store_true', default=False)
    args = parser.parse_args()
    
    if args.debug:
        logging.getLogger().setLevel(logging.DEBUG)
    
    # Parse target
    if args.target in LOCATIONS:
        target_gx, target_gy, target_name = LOCATIONS[args.target]
    elif ',' in args.target:
        parts = args.target.split(',')
        target_gx, target_gy = int(parts[0]), int(parts[1])
        target_name = f"({target_gx}, {target_gy})"
    else:
        print(f"[-] Unknown target: {args.target}")
        print(f"    Available: {', '.join(LOCATIONS.keys())}")
        return
    
    print("=" * 60)
    print(f"  VLTK1 - MOVE TO {target_name}")
    print("=" * 60)
    
    # Connect
    bot = VLTK1Bot()
    if not bot.connect():
        print("[-] Connect failed!")
        return
    time.sleep(1)
    
    # Init movement controller
    mover = MovementController(bot, config={
        "max_steps": args.steps,
        "timeout": 120,
        "arrival_threshold_game": 5,
        "stuck_threshold": 3,
    })
    
    # Move
    result = mover.move(target_gx, target_gy, method='minimap', on_step=on_step)
    print_result(result, f"Move to {target_name}")
    
    bot.close()


if __name__ == '__main__':
    main()
