"""
core/position.py - Detect tọa độ nhân vật & quy đổi hệ tọa độ

Hệ tọa độ VLTK1:
  - World coords (5 số): Dùng trong network protocol (opcode 9 entity sync)
  - Game/Map coords (3 số): Hiển thị trên minimap trong game

Công thức:
  game_x = world_x // 256
  game_y = world_y // 256
  world_x = game_x * 256
  world_y = game_y * 256

Divisor = 256 = 2^8 (bit shift right 8)
"""

# ── Hằng số ──────────────────────────────────────────────────
COORD_DIVISOR = 256  # 2^8


# ── Quy đổi tọa độ ──────────────────────────────────────────

def world_to_game(world_x: int, world_y: int) -> tuple[int, int]:
    """Chuyển tọa độ 5 số (protocol) → 3 số (game minimap)."""
    return world_x // COORD_DIVISOR, world_y // COORD_DIVISOR


def game_to_world(game_x: int, game_y: int) -> tuple[int, int]:
    """Chuyển tọa độ 3 số (game minimap) → 5 số (protocol).
    
    Lưu ý: Kết quả là góc trên-trái của ô grid.
    Để lấy tâm ô, dùng game_to_world_center().
    """
    return game_x * COORD_DIVISOR, game_y * COORD_DIVISOR


def game_to_world_center(game_x: int, game_y: int) -> tuple[int, int]:
    """Chuyển tọa độ 3 số → 5 số (tâm ô grid, chính xác hơn)."""
    return game_x * COORD_DIVISOR + COORD_DIVISOR // 2, \
           game_y * COORD_DIVISOR + COORD_DIVISOR // 2


# ── Detect vị trí nhân vật từ packets ────────────────────────

def detect_player_position(packets: list, last_known_pos: tuple = None) -> tuple[int, int, str]:
    """Phân tích opcode 9 entity sync packets để tìm vị trí nhân vật.
    
    Args:
        packets: List of (opcode, body) tuples from pcap parser
        last_known_pos: (world_x, world_y) — nếu có, ưu tiên entity gần vị trí này
        
    Returns:
        (world_x, world_y, entity_id) — tọa độ 5 số + ID nhân vật.
        Trả (0, 0, "") nếu không tìm thấy.
    """
    ent_positions = {}  # eid -> set of (x, y) unique positions
    ent_last_pos = {}   # eid -> last known (x, y)
    
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
        
        eid = parts[1]
        
        try:
            px, py = int(parts[2]), int(parts[3])
            # Filter: coords must be in reasonable range (game coords > 10)
            gx, gy = px // COORD_DIVISOR, py // COORD_DIVISOR
            if gx < 10 or gy < 10:
                continue
            
            if eid not in ent_positions:
                ent_positions[eid] = set()
            ent_positions[eid].add((px, py))
            ent_last_pos[eid] = (px, py)
        except (ValueError, IndexError):
            pass
    
    if not ent_positions:
        return 0, 0, ""
    
    # If we have last known position, pick entity closest to it
    if last_known_pos and last_known_pos[0] > 0:
        lx, ly = last_known_pos
        best_eid = None
        best_dist = float('inf')
        for eid, pos in ent_last_pos.items():
            d = ((pos[0] - lx) ** 2 + (pos[1] - ly) ** 2) ** 0.5
            if d < best_dist:
                best_dist = d
                best_eid = eid
        if best_eid and best_dist < 30000:  # ~120 tiles max
            wx, wy = ent_last_pos[best_eid]
            return wx, wy, best_eid
    
    # Fallback: Entity có nhiều vị trí khác nhau nhất = đang di chuyển = mình
    my_id = max(ent_positions, key=lambda eid: len(ent_positions[eid]))
    wx, wy = ent_last_pos[my_id]
    return wx, wy, my_id


def detect_stalls(packets: list) -> dict:
    """Phân tích opcode 9 entity sync packets để tìm sạp hàng.
    
    Args:
        packets: List of (opcode, body) tuples
        
    Returns:
        Dict {entity_id: {name, desc, x, y, player_id, updates}}
    """
    import re
    SALESMAN_RE = re.compile(r'^salesman\.(\d+)\.\d+$')
    
    stalls = {}
    for opcode, body in packets:
        if opcode != 9 or len(body) < 10:
            continue
        try:
            text = body.decode('utf-8', errors='replace')
        except:
            continue
        
        parts = text.split('|')
        if len(parts) < 2:
            continue
        
        try:
            etype = int(parts[0])
        except ValueError:
            continue
        
        entity_id = parts[1]
        is_stall = (etype in (33, 34)) or SALESMAN_RE.match(entity_id)
        
        if not is_stall:
            continue
        
        if entity_id not in stalls:
            stalls[entity_id] = {
                "id": entity_id, "name": "", "desc": "",
                "x": 0, "y": 0, "player_id": "", "updates": 0
            }
        stall = stalls[entity_id]
        m = SALESMAN_RE.match(entity_id)
        stall["player_id"] = m.group(1) if m else entity_id
        stall["updates"] += 1
        
        # Type 33: stall info (name + desc + pos)
        if etype == 33 and len(parts) >= 4:
            stall["name"] = parts[2]
            stall["desc"] = parts[3] if len(parts) > 3 else ""
            if len(parts) >= 10:
                try:
                    stall["x"], stall["y"] = int(parts[8]), int(parts[9])
                except (ValueError, IndexError):
                    pass
        
        # Type 34: stall position update
        if etype == 34 and len(parts) >= 4:
            try:
                stall["x"], stall["y"] = int(parts[2]), int(parts[3])
            except (ValueError, IndexError):
                pass
    
    return stalls


def format_position(world_x: int, world_y: int) -> str:
    """Format vị trí cho display: cả 5 số và 3 số."""
    gx, gy = world_to_game(world_x, world_y)
    return f"({world_x}, {world_y}) [map: {gx}, {gy}]"
