import os
import json
import logging
import difflib

logger = logging.getLogger("map_manager")
ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
MAPS_DIR = os.path.join(ROOT_DIR, "data", "output", "maps")

class MapManager:
    """Quản lý dữ liệu bản đồ và tọa độ NPC từ các file JSON."""
    
    def __init__(self):
        self.maps = {}        # map_name -> map_data
        self.map_ids = {}     # map_id -> map_name
        self._load_all_maps()
        
    def _load_all_maps(self):
        if not os.path.exists(MAPS_DIR):
            logger.warning(f"Không tìm thấy thư mục map: {MAPS_DIR}")
            return
            
        for file in os.listdir(MAPS_DIR):
            if file.endswith('.json'):
                path = os.path.join(MAPS_DIR, file)
                try:
                    with open(path, 'r', encoding='utf-8') as f:
                        data = json.load(f)
                        
                    map_id = data.get('map_id')
                    map_name = data.get('map_name')
                    
                    if map_id is not None and map_name:
                        self.maps[map_name.lower()] = data
                        self.map_ids[map_id] = map_name
                except Exception as e:
                    logger.error(f"Lỗi đọc map {file}: {e}")
                    
        logger.info(f"Đã load {len(self.maps)} maps.")

    def get_npc_coords(self, npc_name: str, map_name: str = None) -> tuple:
        """Tìm tọa độ (gx, gy) của NPC trong một map.
        
        Nếu map_name=None, sẽ tìm trên tất cả các map (không khuyến khích nếu bị trùng tên).
        """
        target_maps = []
        if map_name:
            # Fuzzy match map name
            match = difflib.get_close_matches(map_name.lower(), self.maps.keys(), n=1, cutoff=0.6)
            if not match:
                logger.warning(f"Không tìm thấy map nào tên: {map_name}")
                return None
            target_maps = [self.maps[match[0]]]
        else:
            target_maps = list(self.maps.values())

        best_match = None
        best_score = 0
        target_gx, target_gy = None, None
        
        # Fuzzy match NPC name (để hỗ trợ gõ thiếu chữ)
        npc_query = npc_name.lower()

        for m in target_maps:
            for npc in m.get('npcs', []):
                n_name = npc['name'].lower()
                
                # Trực tiếp chứa chữ (ưu tiên số 1)
                if npc_query in n_name or n_name in npc_query:
                    # Convert X, Y thực tế sang tọa độ game (chia 256)
                    return (npc['x'] // 256, npc['y'] // 256)
                    
                # Hoặc dùng difflib
                score = difflib.SequenceMatcher(None, npc_query, n_name).ratio()
                if score > best_score and score > 0.7:
                    best_score = score
                    best_match = npc
                    
        if best_match:
            logger.info(f"  Fuzzy found NPC: '{best_match['name']}' (score {best_score:.2f})")
            return (best_match['x'] // 256, best_match['y'] // 256)
            
        logger.warning(f"Không tìm thấy NPC: {npc_name}")
        return None
