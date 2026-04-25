"""
packet_parser.py — Phân tích binary capture, tìm packet boundaries và opcodes

Usage:
    # Parse file capture và in tất cả packets:
    python packet_parser.py captures/send_20240101_120000.bin --direction SEND

    # Tìm opcode cụ thể:
    python packet_parser.py captures/recv_20240101_120000.bin --opcode 0x0310

    # Export danh sách opcodes đã thấy (có cross-reference với opcode_db.yaml):
    python packet_parser.py captures/send_20240101_120000.bin --summary

    # Tìm packet header format tự động:
    python packet_parser.py captures/send_20240101_120000.bin --detect-format

    # Match với database để gợi ý tên opcode:
    python packet_parser.py captures/send_20240101_120000.bin --summary --db ../data/opcode_db.yaml
"""

import argparse
import struct
import sys
from dataclasses import dataclass, field
from pathlib import Path
from typing import Optional
from collections import Counter


@dataclass
class Packet:
    offset: int
    length: int
    opcode: int
    payload: bytes
    direction: str = 'UNKNOWN'

    def hex_summary(self, payload_preview: int = 16) -> str:
        preview = self.payload[:payload_preview].hex(' ')
        truncated = '...' if len(self.payload) > payload_preview else ''
        return (f"[0x{self.offset:06x}] {self.direction} "
                f"opcode=0x{self.opcode:04x}({self.opcode}) "
                f"len={self.length} "
                f"payload: {preview}{truncated}")


class PacketParser:
    """
    Thử nhiều format header khác nhau để tìm cái đúng.

    Format phổ biến trong MMORPG Trung Quốc cũ:
      Format A: [2B length][2B opcode][payload]  — length = total packet size
      Format B: [2B length][2B opcode][payload]  — length = payload size only
      Format C: [4B length][2B opcode][payload]
      Format D: [2B opcode][2B length][payload]
    """

    FORMATS = {
        'A': {'header_size': 4, 'len_offset': 0, 'len_size': 2, 'op_offset': 2, 'op_size': 2,
              'len_includes_header': True,  'endian': '>'},
        'B': {'header_size': 4, 'len_offset': 0, 'len_size': 2, 'op_offset': 2, 'op_size': 2,
              'len_includes_header': False, 'endian': '>'},
        'C': {'header_size': 6, 'len_offset': 0, 'len_size': 4, 'op_offset': 4, 'op_size': 2,
              'len_includes_header': True,  'endian': '>'},
        'D': {'header_size': 4, 'len_offset': 2, 'len_size': 2, 'op_offset': 0, 'op_size': 2,
              'len_includes_header': False, 'endian': '>'},
        'A_LE': {'header_size': 4, 'len_offset': 0, 'len_size': 2, 'op_offset': 2, 'op_size': 2,
                 'len_includes_header': True,  'endian': '<'},
        'B_LE': {'header_size': 4, 'len_offset': 0, 'len_size': 2, 'op_offset': 2, 'op_size': 2,
                 'len_includes_header': False, 'endian': '<'},
    }

    def __init__(self, fmt: str = 'A'):
        self.fmt = self.FORMATS[fmt]

    def parse(self, data: bytes, direction: str = 'UNKNOWN') -> list[Packet]:
        packets = []
        pos = 0
        f = self.fmt
        endian = f['endian']
        header_size = f['header_size']

        while pos <= len(data) - header_size:
            # Đọc length
            len_fmt = '>H' if f['len_size'] == 2 else '>I'
            if f['endian'] == '<':
                len_fmt = '<H' if f['len_size'] == 2 else '<I'
            raw_len = struct.unpack_from(len_fmt, data, pos + f['len_offset'])[0]

            # Đọc opcode
            op_fmt = '>H' if f['op_size'] == 2 else '>I'
            if f['endian'] == '<':
                op_fmt = '<H' if f['op_size'] == 2 else '<I'
            opcode = struct.unpack_from(op_fmt, data, pos + f['op_offset'])[0]

            # Tính actual packet size
            if f['len_includes_header']:
                packet_size = raw_len
                payload_size = raw_len - header_size
            else:
                payload_size = raw_len
                packet_size = header_size + raw_len

            # Validation
            if packet_size < header_size or packet_size > 65536:
                pos += 1
                continue
            if pos + packet_size > len(data):
                break

            payload = data[pos + header_size: pos + header_size + payload_size]
            packets.append(Packet(
                offset=pos,
                length=packet_size,
                opcode=opcode,
                payload=payload,
                direction=direction
            ))
            pos += packet_size

        return packets

    @classmethod
    def detect_format(cls, data: bytes) -> Optional[str]:
        """
        Thử tất cả format, chọn cái nào parse được nhiều packets nhất
        và có tỷ lệ coverage cao nhất (ít byte waste).
        """
        best_fmt = None
        best_score = 0

        for fmt_name, _ in cls.FORMATS.items():
            parser = cls(fmt_name)
            packets = parser.parse(data)
            if not packets:
                continue
            covered = sum(p.length for p in packets)
            coverage = covered / len(data)
            # Score: số packets × coverage
            score = len(packets) * coverage
            print(f"  Format {fmt_name}: {len(packets)} packets, coverage={coverage:.1%}, score={score:.1f}")
            if score > best_score:
                best_score = score
                best_fmt = fmt_name

        return best_fmt


def print_packets(packets: list[Packet], show_payload: bool = False,
                  opcode_names: dict = None):
    for p in packets:
        line = p.hex_summary()
        if opcode_names and p.opcode in opcode_names:
            name, confidence = opcode_names[p.opcode]
            tag = f"  ← {name}" if confidence == 'exact' else f"  ← ~{name}?"
            line += tag
        print(line)
        if show_payload and p.payload:
            _hexdump(p.payload, indent='    ')
            print()


def _hexdump(data: bytes, indent: str = ''):
    width = 16
    for i in range(0, len(data), width):
        chunk = data[i:i+width]
        hex_part = ' '.join(f'{b:02x}' for b in chunk)
        asc_part = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        print(f'{indent}{i:04x}  {hex_part:<{width*3}}  {asc_part}')


# ─────────────────────────────────────────────────────────────
# Opcode DB matching — cross-reference với data/opcode_db.yaml
# ─────────────────────────────────────────────────────────────

def load_opcode_db(db_path: Path) -> dict:
    """
    Load opcode_db.yaml → flat dict {opcode_int: (name, source_engine)}.
    Returns empty dict nếu yaml không có hoặc file không tìm thấy.
    """
    try:
        import yaml
    except ImportError:
        print("  [!] pip install pyyaml để dùng --db matching")
        return {}

    if not db_path.exists():
        print(f"  [!] DB file không tìm thấy: {db_path}")
        return {}

    data = yaml.safe_load(db_path.read_text(encoding='utf-8'))
    db = {}

    def _extract(section: dict, engine: str, direction: str):
        if not isinstance(section, dict):
            return
        for key, info in section.items():
            try:
                # key có thể là int (YAML auto-parse hex) hoặc string "0x0101"
                opcode = int(str(key), 16) if isinstance(key, str) else int(key)
                name = info.get('name', '') if isinstance(info, dict) else str(info)
                if name:
                    db[opcode] = (name, engine, direction)
            except (ValueError, TypeError):
                pass

    for engine_name, engine_data in data.items():
        if not isinstance(engine_data, dict):
            continue
        # Top-level c2s/s2c
        _extract(engine_data.get('c2s', {}), engine_name, 'C2S')
        _extract(engine_data.get('s2c', {}), engine_name, 'S2C')
        # Nested (vd: common_patterns)
        for sub_key, sub_val in engine_data.items():
            if isinstance(sub_val, dict):
                _extract(sub_val.get('c2s', {}), engine_name, 'C2S')
                _extract(sub_val.get('s2c', {}), engine_name, 'S2C')

    return db


def match_opcodes(packets: list[Packet], db: dict,
                  direction: str = 'SEND') -> dict:
    """
    So sánh opcodes trong capture với DB.

    Trả về dict {opcode: (name, confidence)}
      confidence = 'exact'  → opcode khớp trực tiếp
      confidence = 'fuzzy'  → dựa trên payload size + frequency pattern
    """
    if not db:
        return {}

    result = {}
    opcode_counts  = Counter(p.opcode for p in packets)
    avg_payloads   = {}
    for op, cnt in opcode_counts.items():
        sizes = [len(p.payload) for p in packets if p.opcode == op]
        avg_payloads[op] = sum(sizes) / len(sizes)

    db_dir = 'C2S' if direction == 'SEND' else 'S2C'

    for op in opcode_counts:
        # Exact match
        if op in db:
            name, engine, db_direction = db[op]
            result[op] = (name, 'exact')
            continue

        # Fuzzy: tìm DB entry cùng direction có payload size gần giống
        best_name = None
        best_dist = 999
        avg_sz = avg_payloads[op]
        for db_op, (name, engine, db_dir_e) in db.items():
            if db_dir_e != db_dir:
                continue
            # Tính khoảng cách dựa trên opcode range (cùng category)
            op_hi   = op >> 8
            db_hi   = db_op >> 8
            if op_hi == db_hi:  # cùng category byte
                dist = abs(op - db_op)
                if dist < best_dist:
                    best_dist = dist
                    best_name = name

        if best_name and best_dist <= 16:
            result[op] = (best_name, 'fuzzy')

    return result


def summarize(packets: list[Packet], db: dict = None):
    opcode_counts = Counter(p.opcode for p in packets)
    direction = packets[0].direction if packets else 'SEND'
    matches = match_opcodes(packets, db or {}, direction) if db else {}

    print(f"\nTotal packets: {len(packets)}")
    print(f"Unique opcodes: {len(opcode_counts)}\n")
    print(f"{'Opcode':<10} {'Hex':<8} {'Count':<8} {'AvgPld':>7}  {'Suggested Name'}")
    print('─' * 60)
    for opcode, count in sorted(opcode_counts.items()):
        payloads = [p for p in packets if p.opcode == opcode]
        avg_payload = sum(len(p.payload) for p in payloads) / count
        name_col = ''
        if opcode in matches:
            name, conf = matches[opcode]
            name_col = name if conf == 'exact' else f'~{name}?'
        print(f"{opcode:<10} 0x{opcode:04x}   {count:<8} {avg_payload:>7.1f}  {name_col}")

    # Báo cáo bổ sung: DB entries không thấy trong capture
    if db and matches:
        seen_names = {v[0] for v in matches.values()}
        missed = []
        db_dir = 'C2S' if direction == 'SEND' else 'S2C'
        for op, (name, engine, db_direction) in db.items():
            if db_direction == db_dir and name not in seen_names:
                missed.append(name)
        if missed:
            print(f"\n  DB entries not seen in this capture ({db_dir}):")
            for m in missed[:15]:
                print(f"    {m}")
            if len(missed) > 15:
                print(f"    ... and {len(missed)-15} more")


def main():
    parser = argparse.ArgumentParser(description='VLTK1 packet parser')
    parser.add_argument('file', help='Binary capture file')
    parser.add_argument('--direction', default='SEND', choices=['SEND', 'RECV'],
                        help='Hướng packet (để label, không ảnh hưởng parse)')
    parser.add_argument('--format', default='A', choices=list(PacketParser.FORMATS.keys()),
                        help='Packet header format (default: A)')
    parser.add_argument('--detect-format', action='store_true',
                        help='Tự động detect header format')
    parser.add_argument('--opcode', type=lambda x: int(x, 0), default=None,
                        help='Lọc theo opcode, vd: 0x0210 hoặc 528')
    parser.add_argument('--summary', action='store_true',
                        help='Chỉ in thống kê opcodes')
    parser.add_argument('--payload', action='store_true',
                        help='Hiển thị full payload hex dump')
    parser.add_argument('--db', default='', metavar='YAML',
                        help='Đường dẫn opcode_db.yaml để cross-reference '
                             '(default: auto-detect ../data/opcode_db.yaml)')
    args = parser.parse_args()

    # Auto-locate DB nếu không chỉ định
    db_path = None
    if args.db:
        db_path = Path(args.db)
    else:
        auto = Path(__file__).parent.parent / 'data' / 'opcode_db.yaml'
        if auto.exists():
            db_path = auto

    db = {}
    if db_path:
        print(f"Loading opcode DB: {db_path}")
        db = load_opcode_db(db_path)
        print(f"  {len(db)} opcodes loaded from DB\n")

    data = Path(args.file).read_bytes()
    print(f"File: {args.file} ({len(data)} bytes)")

    if args.detect_format:
        print("\nDetecting packet format...")
        fmt = PacketParser.detect_format(data)
        print(f"\nBest format: {fmt}")
        if fmt:
            args.format = fmt
        else:
            print("Không detect được format — data có thể encrypted")
            return

    parser_obj = PacketParser(args.format)
    packets = parser_obj.parse(data, direction=args.direction)
    print(f"Parsed {len(packets)} packets with format {args.format}\n")

    if args.opcode is not None:
        packets = [p for p in packets if p.opcode == args.opcode]
        print(f"Filtered to opcode 0x{args.opcode:04x}: {len(packets)} packets\n")

    if args.summary:
        summarize(packets, db=db if db else None)
    else:
        opcode_names = match_opcodes(packets, db, args.direction) if db else None
        print_packets(packets, show_payload=args.payload, opcode_names=opcode_names)


if __name__ == '__main__':
    main()
