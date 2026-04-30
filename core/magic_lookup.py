"""
VLTK1 Magic Attribute Lookup Module

Resolves magic attribute names from magicdesc.txt.

Magic attributes in n11_h are encoded as varints:
    value = m_val * 1000 + m_id
    m_val = value // 1000   (attribute value, e.g. +20)
    m_id  = value % 1000    (attribute ID, maps to magicdesc row)

Usage:
    from core.magic_lookup import MagicLookup
    
    magic = MagicLookup('data/game_raw/settings/magicdesc.txt')
    attrs = magic.parse_attrs(n11_h_hex)
    # → [('Sinh lực tối đa', 109), ('Kháng hỏa', 10), ...]
"""

import codecs
import re
import os


class MagicLookup:
    """
    Magic attribute name resolver from magicdesc.txt.
    
    The game encodes magic IDs using the row index in magicdesc.txt directly.
    Rows 0-10 are metadata/headers and skipped.
    """
    
    def __init__(self, magicdesc_path: str):
        """
        Load magicdesc.txt and build ID → name mapping.
        
        Args:
            magicdesc_path: Path to magicdesc.txt file
        """
        self.names = {}
        self._load(magicdesc_path)
    
    def _load(self, path: str):
        """Load magicdesc.txt with offset-based ID mapping.
        
        Offset rules:
          - Rows 0-10: metadata, skipped
          - Rows 11-65: game_id = row + 15
          - Rows 66+: game_id = row + 22
        """
        lines = codecs.open(path, 'r', 'utf-16le').read().splitlines()
        for i, line in enumerate(lines):
            if i <= 10:
                continue  # Skip header/metadata rows
            parts = line.split('\t')
            if len(parts) < 3:
                continue
            desc = re.sub(r'<[^>]+>', '', parts[2].strip())
            name = desc.split(':')[0].strip() if ':' in desc else desc
            if not name:
                name = parts[0].strip()
            game_id = i + 15 if i <= 65 else i + 22
            self.names[game_id] = name
    
    def get_name(self, magic_id: int) -> str:
        """Get attribute name from magic ID."""
        return self.names.get(magic_id, f'ID {magic_id}')
    
    def parse_attrs(self, n11_h: str) -> list:
        """
        Parse n11_h hex string into list of (name, value) tuples.
        
        Args:
            n11_h: Hex string of magic attribute data
            
        Returns:
            List of (attribute_name, attribute_value) tuples
        """
        if not n11_h:
            return []
        try:
            data = bytes.fromhex(n11_h)
            result = []
            pos = 0
            while pos < len(data):
                val, pos = self._read_varint(data, pos)
                m_val = val // 1000
                m_id = val % 1000
                name = self.get_name(m_id)
                result.append((name, m_val))
            return result
        except Exception:
            return []
    
    def format_attrs(self, n11_h: str) -> str:
        """Format magic attributes as readable string."""
        attrs = self.parse_attrs(n11_h)
        if not attrs:
            return ''
        return ', '.join(f'{name} +{val}' for name, val in attrs)
    
    @staticmethod
    def _read_varint(data: bytes, pos: int) -> tuple:
        """Read a varint from bytes at position."""
        result = 0
        shift = 0
        while pos < len(data):
            b = data[pos]
            pos += 1
            result |= (b & 0x7F) << shift
            shift += 7
            if not (b & 0x80):
                break
        return result, pos
