"""
tests/test_da_tau_flow.py — Test từng bước của Dã Tẩu automation

Chạy lần lượt:
  Step 1: Đọc vị trí hiện tại
  Step 2: Di chuyển tới NPC Dã Tẩu bằng Numpad
  Step 3: Click mở dialog NPC Dã Tẩu
  Step 4: Đọc nội dung nhiệm vụ

Usage:
    python tests/test_da_tau_flow.py              # Chạy tất cả steps
    python tests/test_da_tau_flow.py --step 1     # Chỉ chạy step 1
    python tests/test_da_tau_flow.py --step 2     # Chỉ chạy step 2
    python tests/test_da_tau_flow.py --step 3     # Chỉ chạy step 3+4
"""
import os
import sys
import time
import logging
import argparse

sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

logging.basicConfig(
    level=logging.INFO,
    format="%(asctime)s [%(name)s] %(message)s",
    datefmt="%H:%M:%S"
)
logger = logging.getLogger("da_tau_test")

from core.adb_helper import ADBHelper
from core.navigator import Navigator, NPC_COORDS
from core.npc_interact import NPCInteract


def step1_detect_position(adb: ADBHelper):
    """Step 1: Xác định tọa độ hiện tại."""
    print("\n" + "=" * 50)
    print("  STEP 1: Detect Position")
    print("=" * 50)

    gx, gy = adb.get_position(trigger_tap=True)
    if gx > 0:
        print(f"\n  Position: ({gx}, {gy})")
        return gx, gy
    else:
        print("\n  FAILED: Cannot detect position")
        return 0, 0


def step2_move_to_npc(adb: ADBHelper, nav: Navigator):
    """Step 2: Di chuyển tới NPC Dã Tẩu."""
    print("\n" + "=" * 50)
    print("  STEP 2: Move to NPC Da Tau")
    print("=" * 50)

    target = NPC_COORDS["da_tau"]
    print(f"\n  Target: ({target[0]}, {target[1]})")

    ok = nav.move_to(target[0], target[1], wait_seconds=15)
    if ok:
        print(f"\n  ARRIVED at Da Tau!")
    else:
        print(f"\n  WARNING: May not have arrived yet")
    return ok


def step3_click_npc(adb: ADBHelper, npc: NPCInteract):
    """Step 3+4: Click NPC Dã Tẩu + Đọc quest."""
    print("\n" + "=" * 50)
    print("  STEP 3+4: Click NPC + Read Quest")
    print("=" * 50)

    # Click NPC
    npc.click_npc_datau()
    
    # Đọc quest từ RAM
    quest = npc.read_quest_dialog()
    if quest:
        print(f"\n  Title:   {quest.get('title', 'N/A')}")
        print(f"  Quest:   {quest.get('full_text', 'N/A')}")
        print(f"  Type:    {quest.get('quest_type', 'N/A')}")
        print(f"  Options: {quest.get('selections', [])}")
    else:
        print("\n  FAILED: Không thể đọc được nhiệm vụ từ RAM.")
        print("  TIP: Đảm bảo Dã Tẩu đang hiển thị khung chat trên màn hình.")

    return quest


def main():
    parser = argparse.ArgumentParser(description="Test Da Tau Flow")
    parser.add_argument("--step", type=int, choices=[1, 2, 3],
                        help="Run specific step only (1=pos, 2=move, 3=click+read)")
    args = parser.parse_args()

    print("=" * 50)
    print("  VLTK1 — Da Tau Flow Test")
    print("=" * 50)

    # Init
    adb = ADBHelper()
    if not adb.init_frida():
        print("FATAL: Cannot attach Frida. Make sure game is running.")
        return

    time.sleep(1)

    nav = Navigator(adb)
    npc = NPCInteract(adb)

    try:
        if args.step is None or args.step == 1:
            gx, gy = step1_detect_position(adb)

        if args.step is None or args.step == 2:
            step2_move_to_npc(adb, nav)

        if args.step is None or args.step == 3:
            step3_click_npc(adb, npc)

        print("\n" + "=" * 50)
        print("  DONE!")
        print("=" * 50)

    finally:
        adb.close()


if __name__ == "__main__":
    main()
