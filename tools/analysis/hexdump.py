"""
hexdump.py — Visual hex dump + binary file viewer

Usage:
    python hexdump.py captures/send_20240101_120000.bin
    python hexdump.py captures/send_20240101_120000.bin --width 32
    python hexdump.py captures/send_20240101_120000.bin --offset 64 --limit 128
"""

import argparse
import sys
from pathlib import Path


def hexdump(data: bytes, width: int = 16, offset: int = 0, limit: int = None) -> str:
    if limit:
        data = data[offset:offset + limit]
    else:
        data = data[offset:]

    lines = []
    for i in range(0, len(data), width):
        chunk = data[i:i + width]
        hex_part = ' '.join(f'{b:02x}' for b in chunk)
        asc_part = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        addr = offset + i
        lines.append(f'{addr:08x}  {hex_part:<{width * 3}}  |{asc_part}|')
    return '\n'.join(lines)


def diff_hex(data_a: bytes, data_b: bytes, width: int = 16) -> str:
    """So sánh 2 binary file, highlight byte khác nhau."""
    max_len = max(len(data_a), len(data_b))
    lines = []
    for i in range(0, max_len, width):
        chunk_a = data_a[i:i + width]
        chunk_b = data_b[i:i + width]
        diff_marks = []
        for j in range(width):
            ba = chunk_a[j] if j < len(chunk_a) else None
            bb = chunk_b[j] if j < len(chunk_b) else None
            diff_marks.append('^' if ba != bb else ' ')
        hex_a = ' '.join(f'{b:02x}' if j < len(chunk_a) else '  '
                         for j, b in enumerate(chunk_a.ljust(width, b'\x00')))
        hex_b = ' '.join(f'{b:02x}' if j < len(chunk_b) else '  '
                         for j, b in enumerate(chunk_b.ljust(width, b'\x00')))
        mark = ' '.join(diff_marks[:width])
        lines.append(f'{i:08x}  A: {hex_a}')
        lines.append(f'          B: {hex_b}')
        lines.append(f'             {mark}')
        lines.append('')
    return '\n'.join(lines)


def find_pattern(data: bytes, pattern: bytes) -> list:
    """Tìm tất cả vị trí xuất hiện của pattern trong data."""
    positions = []
    start = 0
    while True:
        pos = data.find(pattern, start)
        if pos == -1:
            break
        positions.append(pos)
        start = pos + 1
    return positions


def main():
    parser = argparse.ArgumentParser(description='Binary hex dump tool')
    parser.add_argument('file', help='File binary cần xem')
    parser.add_argument('--width', type=int, default=16, help='Bytes per row (default: 16)')
    parser.add_argument('--offset', type=int, default=0, help='Bắt đầu từ byte thứ N')
    parser.add_argument('--limit', type=int, default=None, help='Chỉ xem N bytes')
    parser.add_argument('--find', type=str, default=None,
                        help='Tìm pattern dạng hex, vd: "03 e8" hoặc "login"')
    parser.add_argument('--diff', type=str, default=None,
                        help='So sánh với file khác')
    args = parser.parse_args()

    data = Path(args.file).read_bytes()
    print(f"File: {args.file} ({len(data)} bytes)\n")

    if args.find:
        # Parse pattern: hex string hoặc ASCII
        try:
            pattern = bytes.fromhex(args.find.replace(' ', ''))
        except ValueError:
            pattern = args.find.encode()
        positions = find_pattern(data, pattern)
        if positions:
            print(f"Pattern {args.find!r} found at {len(positions)} location(s):")
            for pos in positions:
                print(f"  offset 0x{pos:08x} ({pos})")
                # Show context
                ctx_start = max(0, pos - 8)
                ctx_end = min(len(data), pos + len(pattern) + 8)
                print(hexdump(data, width=args.width, offset=ctx_start,
                              limit=ctx_end - ctx_start))
                print()
        else:
            print(f"Pattern {args.find!r} not found")
        return

    if args.diff:
        data_b = Path(args.diff).read_bytes()
        print(diff_hex(data, data_b, width=args.width))
        return

    print(hexdump(data, width=args.width, offset=args.offset, limit=args.limit))


if __name__ == '__main__':
    main()
