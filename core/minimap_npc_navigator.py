"""Client-side minimap NPC list navigator.

This module drives the Unity UI with ADB taps/swipes:
open the minimap popup, scroll the NPC ScrollView, and tap the row for a
target NPC name. It intentionally uses the server-exported map NPC order as
the source of truth because Unity UI hierarchy/OCR is not available here.
"""
from __future__ import annotations

import json
import math
import subprocess
import time
import unicodedata
from dataclasses import dataclass
from pathlib import Path
from typing import Iterable


ROOT_DIR = Path(__file__).resolve().parent.parent
ADB = r"D:\UnityProjects\ADB\platform-tools\adb.exe"
DEVICE_ID = "emulator-5554"


@dataclass
class MinimapNpcListLayout:
    """ADB coordinates for the minimap NPC ScrollView on 1600x900 LDPlayer."""

    open_map_x: int = 1380
    open_map_y: int = 105
    list_x: int = 370
    first_row_y: int = 178
    row_h: int = 46
    visible_rows: int = 12
    smooth_rows_per_swipe: int = 3
    template_rows_per_swipe: int = 1
    template_estimated_rows_per_swipe: int = 2
    swipe_x: int = 370
    swipe_top_y: int = 180
    swipe_bottom_y: int = 690
    swipe_ms: int = 360
    open_wait: float = 0.8
    scroll_wait: float = 0.2
    tap_wait: float = 1.0
    close_panel_x: int = 1215
    close_panel_y: int = 820
    close_panel_wait: float = 0.25
    coord_display_x: int = 650
    coord_display_y: int = 777
    coord_key_wait: float = 0.12
    coord_confirm_x: int = 840
    coord_confirm_y: int = 682
    center_tap_x: int = 800
    center_tap_y: int = 450
    button_left_x: int = 267
    button_match_top_y: int = 130
    button_match_bottom_y: int = 720
    template_threshold: float = 75.0


def normalize_name(value: str) -> str:
    """Normalize Vietnamese names for forgiving matching."""
    normalized = unicodedata.normalize("NFC", repair_mojibake(value or ""))
    normalized = " ".join(normalized.casefold().split())
    return normalized


def repair_mojibake(value: str) -> str:
    """Repair common UTF-8 text that was decoded as latin-1/cp1252."""
    text = value or ""
    if "Ã" not in text and "Ä" not in text and "Æ" not in text and "Å" not in text:
        return text
    try:
        return text.encode("latin1").decode("utf-8")
    except UnicodeError:
        return text


def template_slug(value: str) -> str:
    """Build a stable ASCII filename slug for NPC button templates."""
    normalized = unicodedata.normalize("NFD", repair_mojibake(value or ""))
    ascii_name = "".join(ch for ch in normalized if unicodedata.category(ch) != "Mn")
    return "_".join(ascii_name.casefold().split())


class MinimapNpcNavigator:
    def __init__(
        self,
        adb: str = ADB,
        device_id: str = DEVICE_ID,
        layout: MinimapNpcListLayout | None = None,
        map_dir: Path | None = None,
    ):
        self.adb = adb
        self.device_id = device_id
        self.layout = layout or MinimapNpcListLayout()
        self.map_dir = map_dir or (ROOT_DIR / "data" / "maps")
        self.first_visible_index: int | None = None

    def adb_run(self, *args, timeout: int = 10):
        return subprocess.run(
            [self.adb, "-s", self.device_id, *map(str, args)],
            capture_output=True,
            text=True,
            timeout=timeout,
        )

    def tap(self, x: int, y: int, wait: float = 0.15) -> None:
        self.adb_run("shell", "input", "tap", x, y)
        time.sleep(wait)

    def swipe(self, x1: int, y1: int, x2: int, y2: int, ms: int | None = None) -> None:
        duration = ms if ms is not None else self.layout.swipe_ms
        self.adb_run("shell", "input", "swipe", x1, y1, x2, y2, duration)
        time.sleep(self.layout.scroll_wait)

    def smooth_scroll_rows(self, rows: int) -> None:
        """Scroll the NPC list by a small row count.

        Positive rows move the list down to later NPC entries. Negative rows
        move back up to earlier entries.
        """
        if rows == 0:
            return
        distance = max(self.layout.row_h, min(190, abs(rows) * self.layout.row_h))
        center_y = (self.layout.swipe_top_y + self.layout.swipe_bottom_y) // 2
        if rows > 0:
            y1, y2 = center_y + distance // 2, center_y - distance // 2
        else:
            y1, y2 = center_y - distance // 2, center_y + distance // 2
        self.swipe(self.layout.swipe_x, y1, self.layout.swipe_x, y2, self.layout.swipe_ms)

    def screenshot(self, local_path: Path) -> None:
        local_path.parent.mkdir(parents=True, exist_ok=True)
        remote = "/sdcard/vltk_minimap_npc.png"
        self.adb_run("shell", "screencap", "-p", remote, timeout=15)
        self.adb_run("pull", remote, str(local_path), timeout=15)

    def find_button_template(self, screenshot_path: Path, template_path: Path) -> tuple[int, int, float] | None:
        """Find a button template in the left NPC list.

        This is intentionally a vertical scan at the known button x-coordinate;
        it is fast enough with Pillow and avoids OCR dependencies.
        """
        try:
            from PIL import Image, ImageChops, ImageStat
        except Exception:
            return None
        if not screenshot_path.exists() or not template_path.exists():
            return None

        image = Image.open(screenshot_path).convert("RGB")
        template = Image.open(template_path).convert("RGB")
        tw, th = template.size
        template_pixels = list(template.getdata())
        text_mask = [index for index, pixel in enumerate(template_pixels) if max(pixel) > 95]
        if not text_mask:
            return None

        x = self.layout.button_left_x
        y_min = self.layout.button_match_top_y
        y_max = min(self.layout.button_match_bottom_y, image.height - th)

        best: tuple[int, int, float] | None = None
        for y in range(y_min, y_max + 1, 2):
            crop = image.crop((x, y, x + tw, y + th))
            button_diff = ImageChops.difference(crop.convert("L"), template.convert("L"))
            button_score = sum(ImageStat.Stat(button_diff).mean) / len(ImageStat.Stat(button_diff).mean)
            if button_score > 34.0:
                continue

            crop_pixels = list(crop.getdata())
            total = 0
            for index in text_mask:
                source = crop_pixels[index]
                target = template_pixels[index]
                total += (
                    abs(source[0] - target[0])
                    + abs(source[1] - target[1])
                    + abs(source[2] - target[2])
                )
            score = total / (len(text_mask) * 3)
            if best is None or score < best[2]:
                best = (x + tw // 2, y + th // 2, score)

        if best and best[2] <= self.layout.template_threshold:
            return best
        return None

    def open_minimap(self) -> None:
        self.tap(self.layout.close_panel_x, self.layout.close_panel_y, wait=self.layout.close_panel_wait)
        self.tap(self.layout.open_map_x, self.layout.open_map_y, wait=self.layout.open_wait)

    def close_minimap(self) -> None:
        self.tap(self.layout.close_panel_x, self.layout.close_panel_y, wait=self.layout.close_panel_wait)

    COORD_NUMPAD = {
        "7": (865, 305),
        "8": (960, 305),
        "9": (1055, 305),
        "4": (865, 400),
        "5": (960, 400),
        "6": (1055, 400),
        "1": (865, 500),
        "2": (960, 500),
        "3": (1055, 500),
        "0": (865, 596),
        " ": (960, 596),
        "x": (1055, 596),
    }

    def open_coord_numpad(self) -> None:
        self.tap(self.layout.coord_display_x, self.layout.coord_display_y, wait=self.layout.open_wait)

    def clear_coord_input(self) -> None:
        x, y = self.COORD_NUMPAD["x"]
        for _ in range(7):
            self.tap(x, y, wait=self.layout.coord_key_wait)

    def type_coord_text(self, text: str) -> None:
        for ch in text:
            if ch not in self.COORD_NUMPAD:
                raise ValueError(f"Unsupported numpad char: {ch!r}")
            x, y = self.COORD_NUMPAD[ch]
            self.tap(x, y, wait=self.layout.coord_key_wait)

    def goto_coord_via_minimap(
        self,
        gx: int,
        gy: int,
        *,
        open_map: bool = True,
        close_after_confirm: bool = True,
        screenshot_prefix: str | None = None,
    ) -> dict:
        if open_map:
            self.open_minimap()
        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_opened.png")

        self.open_coord_numpad()
        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_numpad_opened.png")

        self.clear_coord_input()
        coord_text = f"{gx:03d} {gy:03d}"
        self.type_coord_text(coord_text)
        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_typed.png")

        self.tap(self.layout.coord_confirm_x, self.layout.coord_confirm_y, wait=self.layout.tap_wait)
        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_after_confirm.png")

        if close_after_confirm:
            self.close_minimap()
            if screenshot_prefix:
                self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_closed.png")

        return {
            "ok": True,
            "target_gx": gx,
            "target_gy": gy,
            "coord_text": coord_text,
            "confirm_x": self.layout.coord_confirm_x,
            "confirm_y": self.layout.coord_confirm_y,
            "closed": close_after_confirm,
        }

    def reset_scroll_to_top(self, swipes: int = 5) -> None:
        """Swipe down repeatedly so the first NPC rows are visible."""
        for _ in range(swipes):
            self.swipe(
                self.layout.swipe_x,
                self.layout.swipe_top_y,
                self.layout.swipe_x,
                self.layout.swipe_bottom_y,
            )
        self.first_visible_index = 0

    def scroll_pages_down(self, pages: int) -> None:
        """Swipe up by page count; one page is roughly visible_rows rows."""
        for _ in range(max(0, pages)):
            self.swipe(
                self.layout.swipe_x,
                self.layout.swipe_bottom_y,
                self.layout.swipe_x,
                self.layout.swipe_top_y,
            )
            if self.first_visible_index is not None:
                self.first_visible_index += self.layout.visible_rows

    def load_npcs(self, map_id: int) -> list[dict]:
        path = self.map_dir / f"map_{map_id}.json"
        with path.open("r", encoding="utf-8") as fp:
            data = json.load(fp)
        return data.get("npcs", [])

    def npc_display_name(self, npc: dict) -> str:
        return repair_mojibake(npc.get("name", ""))

    def npc_game_coords(self, npc: dict) -> tuple[int, int]:
        """Return NPC map/minimap coords from raw 5-digit or 3-digit data."""
        x = int(npc.get("x", npc.get("mapX", 0)) or 0)
        y = int(npc.get("y", npc.get("mapY", 0)) or 0)
        if x >= 1000 or y >= 1000:
            return x // 256, y // 256
        return x, y

    def nearby_npcs(
        self,
        map_id: int,
        gx: int,
        gy: int,
        *,
        radius: float = 2.0,
        npc_name: str | None = None,
    ) -> list[dict]:
        """Find NPC rows whose known map coords are close to a position."""
        wanted = normalize_name(npc_name or "")
        matches = []
        for index, npc in enumerate(self.load_npcs(map_id)):
            name = self.npc_display_name(npc)
            if wanted and wanted not in normalize_name(name):
                continue
            nx, ny = self.npc_game_coords(npc)
            dist = math.hypot(nx - gx, ny - gy)
            if dist <= radius:
                matches.append(
                    {
                        "index": index,
                        "name": name,
                        "game_x": nx,
                        "game_y": ny,
                        "raw_x": int(npc.get("x", npc.get("mapX", 0)) or 0),
                        "raw_y": int(npc.get("y", npc.get("mapY", 0)) or 0),
                        "distance": dist,
                    }
                )
        return sorted(matches, key=lambda item: (item["distance"], item["index"]))

    def tap_near_center_to_interact(self) -> dict:
        """Try a few center taps to hit an NPC standing near the character."""
        points = [
            (self.layout.center_tap_x, self.layout.center_tap_y),
            (self.layout.center_tap_x, self.layout.center_tap_y - 70),
            (self.layout.center_tap_x - 70, self.layout.center_tap_y - 35),
            (self.layout.center_tap_x + 70, self.layout.center_tap_y - 35),
        ]
        for x, y in points:
            self.tap(x, y, wait=0.35)
        return {"ok": True, "tap_points": points}

    def find_npc_index(self, map_id: int, npc_name: str) -> tuple[int, dict]:
        wanted = normalize_name(npc_name)
        npcs = self.load_npcs(map_id)
        for index, npc in enumerate(npcs):
            if normalize_name(self.npc_display_name(npc)) == wanted:
                return index, npc
        for index, npc in enumerate(npcs):
            if wanted in normalize_name(self.npc_display_name(npc)):
                return index, npc
        raise ValueError(f"NPC {npc_name!r} not found in map_{map_id}.json")

    def row_tap_position(self, npc_index: int) -> tuple[int, int, int, int]:
        page = npc_index // self.layout.visible_rows
        row = npc_index - page * self.layout.visible_rows
        y = self.layout.first_row_y + row * self.layout.row_h
        return page, row, self.layout.list_x, y

    def visible_range(self, total_npcs: int) -> tuple[int, int]:
        max_first = max(0, total_npcs - self.layout.visible_rows)
        first = 0 if self.first_visible_index is None else self.first_visible_index
        first = max(0, min(max_first, first))
        self.first_visible_index = first
        return first, min(total_npcs, first + self.layout.visible_rows)

    def target_visible(self, npc_index: int, total_npcs: int) -> bool:
        first, end = self.visible_range(total_npcs)
        return first <= npc_index < end

    def estimate_first_visible_index(self, total_npcs: int, position_hint: str) -> int:
        max_first = max(0, total_npcs - self.layout.visible_rows)
        if self.first_visible_index is not None:
            return max(0, min(max_first, self.first_visible_index))
        if position_hint == "top":
            return 0
        if position_hint == "bottom":
            return max_first
        return max_first // 2

    def move_until_target_visible(
        self,
        npc_index: int,
        total_npcs: int,
        *,
        position_hint: str = "middle",
        max_swipes: int = 16,
    ) -> dict:
        """Scroll smoothly until the target index is inside the visible range."""
        max_first = max(0, total_npcs - self.layout.visible_rows)
        self.first_visible_index = self.estimate_first_visible_index(total_npcs, position_hint)
        history = []

        for _ in range(max_swipes + 1):
            first, end = self.visible_range(total_npcs)
            history.append((first, end))
            if first <= npc_index < end:
                return {"ok": True, "first": first, "end": end, "history": history}

            if npc_index >= end:
                step = min(self.layout.smooth_rows_per_swipe, npc_index - end + 1)
            else:
                step = -min(self.layout.smooth_rows_per_swipe, first - npc_index)

            if step == 0:
                break

            self.smooth_scroll_rows(step)
            self.first_visible_index = max(0, min(max_first, first + step))

        first, end = self.visible_range(total_npcs)
        return {"ok": first <= npc_index < end, "first": first, "end": end, "history": history}

    def template_search_and_tap(
        self,
        template_path: Path,
        *,
        npc_index: int | None = None,
        total_npcs: int | None = None,
        position_hint: str = "middle",
        screenshot_prefix: str | None = None,
        max_swipes: int = 18,
    ) -> dict:
        """Search for a visible NPC button by screenshot template, then tap it."""
        if position_hint == "bottom":
            directions: Iterable[int] = (-1, 1)
        else:
            directions = (1, -1)

        shot = ROOT_DIR / "data" / "output" / f"{screenshot_prefix or 'minimap_npc'}_template_scan.png"
        history = []
        max_first = max(0, (total_npcs or 0) - self.layout.visible_rows)

        def estimate_start() -> int | None:
            if npc_index is None or total_npcs is None:
                return None
            return self.estimate_first_visible_index(total_npcs, position_hint)

        estimated_first = estimate_start()

        def expected_visible() -> bool:
            if estimated_first is None or npc_index is None:
                return True
            return estimated_first <= npc_index < estimated_first + self.layout.visible_rows

        for direction in directions:
            if estimated_first is None:
                estimated_first = estimate_start()
            for attempt in range(max_swipes + 1):
                self.screenshot(shot)
                found = self.find_button_template(shot, template_path)
                visible_by_index = expected_visible()
                accepted = bool(found) and visible_by_index
                history.append(
                    {
                        "direction": direction,
                        "attempt": attempt,
                        "estimated_first": estimated_first,
                        "visible_by_index": visible_by_index,
                        "found": bool(found),
                        "accepted": accepted,
                    }
                )
                if found and accepted:
                    x, y, score = found
                    if y > self.layout.swipe_bottom_y:
                        y -= self.layout.row_h
                    self.tap(x, y, wait=self.layout.tap_wait)
                    return {
                        "ok": True,
                        "tap_x": x,
                        "tap_y": y,
                        "score": score,
                        "history": history,
                    }
                if attempt < max_swipes:
                    self.smooth_scroll_rows(direction * self.layout.template_rows_per_swipe)
                    if estimated_first is not None:
                        estimated_first = max(
                            0,
                            min(
                                max_first,
                                estimated_first + direction * self.layout.template_estimated_rows_per_swipe,
                            ),
                        )

        return {"ok": False, "history": history}

    def click_npc_by_name(
        self,
        map_id: int,
        npc_name: str,
        *,
        open_map: bool = True,
        reset_scroll: bool = True,
        position_hint: str = "middle",
        template_path: Path | None = None,
        screenshot_prefix: str | None = None,
        allow_index_fallback: bool = False,
    ) -> dict:
        index, npc = self.find_npc_index(map_id, npc_name)
        total_npcs = len(self.load_npcs(map_id))

        if open_map:
            self.open_minimap()
            self.first_visible_index = 0
            position_hint = "top"
        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_opened.png")

        if reset_scroll:
            self.reset_scroll_to_top()
            position_hint = "top"
            if screenshot_prefix:
                self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_reset_top.png")

        used_template = template_path is not None
        if template_path is None:
            default_template = ROOT_DIR / "data" / "output" / "templates" / f"{template_slug(npc_name)}_button.png"
            if default_template.exists():
                template_path = default_template
                used_template = True

        if template_path:
            template_result = self.template_search_and_tap(
                template_path,
                npc_index=index,
                total_npcs=total_npcs,
                position_hint=position_hint,
                screenshot_prefix=screenshot_prefix,
            )
            if template_result.get("ok"):
                if screenshot_prefix:
                    self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_after_tap.png")
                return {
                    "map_id": map_id,
                    "npc_name": npc.get("name", npc_name),
                    "npc_x": npc.get("x", 0),
                    "npc_y": npc.get("y", 0),
                    "index": index,
                    "template": str(template_path),
                    **template_result,
                }
            if used_template:
                if screenshot_prefix:
                    self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_template_failed.png")
                return {
                    "map_id": map_id,
                    "npc_name": npc.get("name", npc_name),
                    "npc_x": npc.get("x", 0),
                    "npc_y": npc.get("y", 0),
                    "index": index,
                    "template": str(template_path),
                    **template_result,
                }

        if not allow_index_fallback:
            return {
                "ok": False,
                "map_id": map_id,
                "npc_name": npc.get("name", npc_name),
                "npc_x": npc.get("x", 0),
                "npc_y": npc.get("y", 0),
                "index": index,
                "error": "template_not_found_or_not_matched",
                "template": str(template_path) if template_path else "",
                "template_expected": str(
                    ROOT_DIR / "data" / "output" / "templates" / f"{template_slug(npc_name)}_button.png"
                ),
            }

        scroll_result = self.move_until_target_visible(
            index,
            total_npcs,
            position_hint=position_hint,
        )
        first = int(scroll_result["first"])
        row = index - first
        x = self.layout.list_x
        y = self.layout.first_row_y + row * self.layout.row_h

        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_target_page.png")

        self.tap(x, y, wait=self.layout.tap_wait)

        if screenshot_prefix:
            self.screenshot(ROOT_DIR / "data" / "output" / f"{screenshot_prefix}_after_tap.png")

        return {
            "map_id": map_id,
            "npc_name": npc.get("name", npc_name),
            "npc_x": npc.get("x", 0),
            "npc_y": npc.get("y", 0),
            "index": index,
            "first_visible_index": first,
            "visible_end": int(scroll_result["end"]),
            "row": row,
            "tap_x": x,
            "tap_y": y,
            "scroll_history": scroll_result["history"],
        }
