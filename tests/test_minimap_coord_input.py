"""Move by typing coordinates into the minimap numpad popup.

Example:
    python tests/test_minimap_coord_input.py --target 210,200 --monitor 5 --debug-shot coord_210_200
    python tests/test_minimap_coord_input.py --map-id 53 --npc "Dã Tẩu" --monitor 18 --interact
    python tests\test_minimap_coord_input.py --map-id 53 --npc "Dã Tẩu" --monitor 18 --near-radius 2 --interact --debug-shot datau_interact
"""
from __future__ import annotations

import argparse
import sys
import time
from pathlib import Path

ROOT_DIR = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(ROOT_DIR))
if hasattr(sys.stdout, "reconfigure"):
    sys.stdout.reconfigure(encoding="utf-8")

from core.minimap_npc_navigator import MinimapNpcListLayout, MinimapNpcNavigator
from core.movement import MovementController
from core.position import world_to_game
from features.bot.game_bot import VLTK1Bot


def parse_target(value: str) -> tuple[int, int]:
    text = value.replace(";", ",").replace(" ", ",")
    parts = [part for part in text.split(",") if part]
    if len(parts) != 2:
        raise argparse.ArgumentTypeError("target must look like 210,200")
    return int(parts[0]), int(parts[1])


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Move via minimap coordinate numpad")
    parser.add_argument("--target", type=parse_target, default=(210, 200), help="Target game coords, e.g. 210,200")
    parser.add_argument("--map-id", type=int, default=0, help="Use data/maps/map_<id>.json for NPC lookup")
    parser.add_argument("--npc", default="", help="NPC name; when set, target is loaded from map data")
    parser.add_argument("--near-radius", type=float, default=2.0, help="NPC proximity radius in minimap tiles")
    parser.add_argument("--interact", action="store_true", help="After arrival check, tap near screen center to interact")
    parser.add_argument("--position-optional", action="store_true", help="Continue UI movement if Frida position attach fails")
    parser.add_argument(
        "--allow-unverified-interact",
        action="store_true",
        help="Allow center taps even when real player position could not be verified",
    )
    parser.add_argument("--skip-open", action="store_true", help="Assume minimap popup is already open")
    parser.add_argument("--keep-popup", action="store_true", help="Do not close minimap popup after confirm")
    parser.add_argument("--no-position", action="store_true", help="Do not connect Frida/read position; only drive minimap UI")
    parser.add_argument("--monitor", type=float, default=5.0, help="Seconds to wait after confirm before reading position")
    parser.add_argument("--debug-shot", default="minimap_coord", help="Screenshot filename prefix in data/output")
    return parser.parse_args()


def read_position(label: str, mover: MovementController):
    wx, wy, eid = mover.ensure_position_data()
    gx, gy = world_to_game(wx, wy) if wx > 0 else (0, 0)
    print(f"[{label}] pos=({gx}, {gy}) world=({wx}, {wy}) eid={eid}")
    return wx, wy, eid


def main() -> int:
    args = parse_args()
    nav = MinimapNpcNavigator(layout=MinimapNpcListLayout())
    target_npc = None
    if args.npc:
        if not args.map_id:
            print("[-] --map-id is required when using --npc")
            return 2
        _, target_npc = nav.find_npc_index(args.map_id, args.npc)
        target_gx, target_gy = nav.npc_game_coords(target_npc)
    else:
        target_gx, target_gy = args.target

    print("=" * 72)
    print("  VLTK1 - MINIMAP COORD INPUT")
    print("=" * 72)
    print(f"Target : ({target_gx}, {target_gy})")
    if target_npc:
        raw_x = target_npc.get("x", target_npc.get("mapX", 0))
        raw_y = target_npc.get("y", target_npc.get("mapY", 0))
        print(f"NPC    : {nav.npc_display_name(target_npc)} map={args.map_id} raw=({raw_x}, {raw_y})")

    bot = None
    mover = None
    after_gx, after_gy = 0, 0
    position_verified = False
    position_available = not args.no_position
    if position_available:
        bot = VLTK1Bot()
        if not bot.connect():
            if not args.position_optional:
                print("[-] Cannot connect to game")
                return 1
            print("[!] Cannot connect to game position hooks; continuing with UI-only movement")
            bot = None
            mover = None
            position_available = False
            args.no_position = True
        else:
            mover = MovementController(bot, config={"max_steps": 2, "timeout": 45})
            read_position("before", mover)

    result = nav.goto_coord_via_minimap(
        target_gx,
        target_gy,
        open_map=not args.skip_open,
        close_after_confirm=not args.keep_popup,
        screenshot_prefix=args.debug_shot,
    )
    print(f"[coord] {result}")

    print(f"[*] Waiting {args.monitor:.1f}s for client pathfinding...")
    time.sleep(max(0, args.monitor))
    if mover:
        after_wx, after_wy, _ = read_position("after", mover)
        if after_wx > 0:
            after_gx, after_gy = world_to_game(after_wx, after_wy)
            position_verified = True
    else:
        after_gx, after_gy = target_gx, target_gy

    if args.map_id:
        nearby = nav.nearby_npcs(
            args.map_id,
            after_gx or target_gx,
            after_gy or target_gy,
            radius=args.near_radius,
            npc_name=args.npc or None,
        )
        print(f"[nearby] radius={args.near_radius} pos=({after_gx or target_gx}, {after_gy or target_gy}) -> {nearby}")
        if args.npc and not nearby:
            print(f"[-] Target NPC not found within radius: {args.npc}")
            if bot:
                bot.close()
            return 3
        if args.interact and not position_verified and not args.allow_unverified_interact:
            print("[interact] skipped because real arrival was not verified; add --allow-unverified-interact to tap anyway")
        elif args.interact and nearby:
            interact = nav.tap_near_center_to_interact()
            print(f"[interact] {interact}")
            if args.debug_shot:
                nav.screenshot(ROOT_DIR / "data" / "output" / f"{args.debug_shot}_after_interact.png")

    if bot:
        bot.close()
    print("[*] Done")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
