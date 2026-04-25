"""
db_manager.py - Thư viện lõi truy xuất dữ liệu tĩnh của VLTK1 Mobile
Load toàn bộ file JSON từ data/output/json và cung cấp API dễ dùng cho Bot.
"""
import json
import sys
from pathlib import Path

# Fix console print encoding on Windows
try:
    sys.stdout.reconfigure(encoding='utf-8')
except:
    pass

# Thư mục chứa JSON data
JSON_DIR = Path(__file__).parent.parent / 'data' / 'output' / 'json'

class DatabaseManager:
    def __init__(self):
        self.maps = {}
        self.npcs = {}
        self.skills = {}
        self.items = {}
        
        self.load_all()

    def _load_json(self, filename):
        path = JSON_DIR / filename
        if path.exists():
            try:
                with open(path, 'r', encoding='utf-8') as f:
                    return json.load(f)
            except Exception as e:
                print(f"[!] Lỗi load {filename}: {e}")
        return None

    def load_all(self):
        """Tải toàn bộ dữ liệu vào memory lúc khởi động Bot"""
        # 1. Load Maps
        map_list = self._load_json('maplist.json') or []
        for m in map_list:
            if 'id' in m:
                self.maps[m['id']] = m

        # 2. Load NPCs (quái, npc giao tiếp)
        npc_list = self._load_json('npcs.json') or []
        for i, npc in enumerate(npc_list):
            # ID của NPC chính là dòng thứ tự trong file npcs.txt
            # Xóa BOM \ufeff ở key đầu tiên nếu có
            clean_npc = {}
            for k, v in npc.items():
                clean_npc[k.replace('\ufeff', '')] = v
                
            self.npcs[i] = clean_npc

        # 3. Load Skills
        skill_list = self._load_json('skills.json') or []
        for i, sk in enumerate(skill_list):
            # skills.txt có 'SkillId' nhưng nhiều khi sai, ID gốc là index
            s_id = sk.get('SkillId', i)
            
            clean_sk = {}
            for k, v in sk.items():
                clean_sk[k.replace('\ufeff', '')] = v
                
            self.skills[int(s_id)] = clean_sk
                
        # 4. Load Items
        armor_list = self._load_json('item_armor.json') or []
        for i, item in enumerate(armor_list):
            clean_item = {k.replace('\ufeff', ''): v for k, v in item.items()}
            # ID của Item = Class + DetailType
            i_class = clean_item.get('Class', 0)
            i_detail = clean_item.get('DetailType', i)
            self.items[f"armor_{i_class}_{i_detail}"] = clean_item

    # =======================================================
    # API Cho Bot
    # =======================================================
    def get_map(self, map_id):
        """Lấy thông tin Map bằng ID"""
        m = self.maps.get(int(map_id), {})
        if not m:
            return {"id": map_id, "name": f"Map_{map_id}", "type": "Chưa rõ"}
        
        name = m.get('name', f"Map_{map_id}")
        m_type = "Thành thị / Thôn trang" if "Thành" in name or "Kinh" in name or "Tường" in name or "phủ" in name or "Lâm An" in name else "Dã ngoại / Phó bản"
        m['type'] = m_type
        return m

    def get_map_name(self, map_id):
        return self.get_map(map_id).get('name')

    def get_npc(self, npc_id):
        """Lấy thông số NPC (Máu, Level, Hệ,...)"""
        return self.npcs.get(int(npc_id), {})

    def get_skill(self, skill_id):
        """Lấy thông tin Kỹ năng"""
        return self.skills.get(int(skill_id), {})


# Khởi tạo Singleton Database để import dùng ở mọi nơi
db = DatabaseManager()

if __name__ == '__main__':
    # Test thử
    print("--- TEST DATABASE ---")
    print("Tổng số Map:", len(db.maps))
    print("Tổng số NPC:", len(db.npcs))
    print("Tổng số Skill:", len(db.skills))
    
    print("\n[Tra cứu thử]:")
    print("Map 162:", db.get_map(162))
    
    # Tìm skill Võ Đang
    print("\n[Tìm skill có chữ 'Võ Đang']:")
    for sid, sk in db.skills.items():
        if 'Võ Đang' in str(sk.get('SkillName', '')):
            print(f"  - [{sid}] {sk.get('SkillName')}")
            break
