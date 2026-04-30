"""
VLTK1 Item Lookup Module

Resolves item names from protocol fields using the (detail, n4) key system.

Protocol mapping:
    n3 = detail * 10000 (0=melee, 1=range, 2=armor, 3=ring, 4=amulet,
                          5=boot, 6=belt, 7=helm, 8=cuff, 9=pendant)
    n4 = particular * 10000 + level (1-10)
    
Usage:
    from core.item_lookup import ItemLookup
    
    lookup = ItemLookup('data/game_raw/settings/item')
    name = lookup.get_name(n3=70000, n4=10)  # → "Tỳ Lô mão"
    detail = lookup.get_detail(n3=70000)       # → 7
    dtype = lookup.get_detail_name(n3=70000)   # → "Mũ"
"""

import codecs
import os

# Detail value → equipment type name
DETAIL_NAMES = {
    0: 'Vũ khí',
    1: 'Ám khí',
    2: 'Áo',
    3: 'Nhẫn',
    4: 'Dây chuyền',
    5: 'Giày',
    6: 'Thắt lưng',
    7: 'Mũ',
    8: 'Bao tay',
    9: 'Ngọc bội',
}

# Detail value → data file name
DETAIL_FILES = {
    0: 'meleeweapon',
    1: 'rangeweapon',
    2: 'armor',
    3: 'ring',
    4: 'amulet',
    5: 'boot',
    6: 'belt',
    7: 'helm',
    8: 'cuff',
    9: 'pendant',
}


class ItemLookup:
    """
    Item name resolver using (detail, n4) protocol key.
    
    Attributes:
        lookup: dict mapping (detail, n4) → item_name
        total: total number of items loaded
    """
    
    def __init__(self, item_dir: str):
        """
        Load all item data files and build the lookup table.
        
        Args:
            item_dir: Path to the directory containing item .txt files
                      (e.g. 'data/game_raw/settings/item')
        """
        self.lookup = {}
        self.total = 0
        self._item_dir = item_dir
        
        for detail, fname in DETAIL_FILES.items():
            self.total += self._load_file(fname, detail)
    
    def _load_file(self, fname: str, detail: int) -> int:
        """Load a single item data file into the lookup table."""
        filepath = os.path.join(self._item_dir, fname + '.txt')
        lines = codecs.open(filepath, 'r', 'utf-16le').read().splitlines()
        count = 0
        for i in range(1, len(lines)):
            cols = lines[i].split('\t')
            if len(cols) < 4:
                continue
            name = cols[0].strip()
            particular = int(cols[3])
            level = ((i - 1) % 10) + 1
            n4 = particular * 10000 + level
            self.lookup[(detail, n4)] = name
            count += 1
        return count
    
    def get_name(self, n3: int, n4: int) -> str:
        """
        Resolve item name from protocol fields.
        
        Args:
            n3: Detail field from protocol (detail * 10000). 
                Weapons have n3=0 or absent.
            n4: Template ID (particular * 10000 + level)
            
        Returns:
            Item name string, or '#detail:n4' if not found.
        """
        detail = n3 // 10000 if n3 else 0
        return self.lookup.get((detail, n4), f'#{detail}:{n4}')
    
    @staticmethod
    def get_detail(n3: int) -> int:
        """Extract detail value from n3 field."""
        return n3 // 10000 if n3 else 0
    
    @staticmethod
    def get_detail_name(n3: int) -> str:
        """Get human-readable equipment type name from n3 field."""
        detail = n3 // 10000 if n3 else 0
        return DETAIL_NAMES.get(detail, f'Unknown({detail})')
    
    @staticmethod
    def parse_n4(n4: int) -> tuple:
        """
        Parse n4 into (particular, level).
        
        Returns:
            (particular, level) tuple
        """
        return n4 // 10000, n4 % 10000
    
    def get_all_by_detail(self, detail: int) -> list:
        """Get all items for a given detail type, sorted by n4."""
        items = [(n4, name) for (d, n4), name in self.lookup.items() if d == detail]
        return sorted(items, key=lambda x: x[0])
