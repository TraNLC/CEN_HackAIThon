"""
correlate.py — So sánh nhiều capture session để lọc fake packets và tìm opcodes thật

Cách dùng:
    # Capture 3 session, mỗi session làm đúng 1 action:
    python analysis/correlate.py \\
        --sessions captures/send_s1.bin captures/send_s2.bin captures/send_s3.bin \\
        --action "ACCEPT_QUEST"

    # So sánh session có action vs không có action:
    python analysis/correlate.py \\
        --baseline captures/send_baseline.bin \\
        --action-file captures/send_with_quest.bin
"""

import argparse
import struct
from collections import Counter, defaultdict
from pathlib import Path


HEADER_SIZE = 4  # [2B length][2B opcode]


def parse_packets(data: bytes) -> list[dict]:
    packets = []
    pos = 0
    while pos <= len(data) - HEADER_SIZE:
        try:
            length = struct.unpack_from('>H', data, pos)[0]
            if length < HEADER_SIZE or length > 65536:
                pos += 1
                continue
            if pos + length > len(data):
                break
            opcode  = struct.unpack_from('>H', data, pos + 2)[0]
            payload = data[pos + HEADER_SIZE: pos + length]
            packets.append({'opcode': opcode, 'length': length, 'payload': payload})
            pos += length
        except Exception:
            pos += 1
    return packets


def correlate_sessions(session_files: list[Path]) -> dict:
    """
    Tìm opcodes xuất hiện trong TẤT CẢ session → likely thật.
    Opcodes chỉ xuất hiện 1 session → likely fake/noise.
    """
    session_opcodes = []
    for f in session_files:
        pkts = parse_packets(f.read_bytes())
        opcodes = set(p['opcode'] for p in pkts)
        session_opcodes.append(opcodes)
        print(f"  {f.name}: {len(pkts)} packets, {len(opcodes)} unique opcodes")

    # Opcodes xuất hiện trong tất cả sessions
    common = session_opcodes[0]
    for s in session_opcodes[1:]:
        common = common & s

    # Opcodes chỉ xuất hiện trong 1 session (candidate fake)
    all_ops  = set()
    for s in session_opcodes: all_ops |= s
    unique_to_one = set()
    for op in all_ops:
        count = sum(1 for s in session_opcodes if op in s)
        if count == 1:
            unique_to_one.add(op)

    return {
        'common':       sorted(common),
        'unique_to_one': sorted(unique_to_one),
        'all':          sorted(all_ops),
    }


def baseline_diff(baseline_file: Path, action_file: Path) -> dict:
    """
    baseline = session không có action đặc biệt (chỉ login, đứng yên)
    action   = session có làm 1 action cụ thể

    Packets xuất hiện trong action nhưng không có trong baseline
    → Likely là packets của action đó
    """
    baseline_pkts = parse_packets(baseline_file.read_bytes())
    action_pkts   = parse_packets(action_file.read_bytes())

    baseline_ops = Counter(p['opcode'] for p in baseline_pkts)
    action_ops   = Counter(p['opcode'] for p in action_pkts)

    # Opcodes mới xuất hiện trong action session
    new_opcodes = {}
    for op, cnt in action_ops.items():
        baseline_cnt = baseline_ops.get(op, 0)
        if cnt > baseline_cnt:
            new_opcodes[op] = {
                'in_baseline': baseline_cnt,
                'in_action':   cnt,
                'delta':       cnt - baseline_cnt,
            }

    return {'new_opcodes': new_opcodes, 'baseline_ops': baseline_ops, 'action_ops': action_ops}


def print_hex(n: int) -> str:
    return f"0x{n:04X}"


def main():
    parser = argparse.ArgumentParser(description='Correlate capture sessions')
    group = parser.add_mutually_exclusive_group(required=True)
    group.add_argument('--sessions', nargs='+', metavar='FILE',
                       help='2+ session files để so sánh chéo')
    group.add_argument('--baseline', metavar='FILE',
                       help='Session baseline (không có action)')

    parser.add_argument('--action-file', metavar='FILE',
                       help='Session có action (dùng với --baseline)')
    parser.add_argument('--action', default='',
                       help='Tên action đang phân tích (để label kết quả)')
    args = parser.parse_args()

    w = 60
    print('═' * w)
    print(f"  Correlation Analysis  {f'— {args.action}' if args.action else ''}")
    print('═' * w)

    if args.sessions:
        files = [Path(f) for f in args.sessions]
        missing = [f for f in files if not f.exists()]
        if missing:
            for f in missing: print(f"  File không tồn tại: {f}")
            return

        print(f"\nSo sánh {len(files)} sessions:\n")
        result = correlate_sessions(files)

        print(f"\n{'─'*w}")
        print(f"  Opcodes xuất hiện trong TẤT CẢ sessions ({len(result['common'])}):")
        print(f"  → Đây là opcodes thật, không phải fake\n")
        for op in result['common']:
            print(f"    {print_hex(op):8}  ({op})")

        print(f"\n{'─'*w}")
        print(f"  Opcodes chỉ xuất hiện trong 1 session ({len(result['unique_to_one'])}):")
        print(f"  → Candidate fake/garbage packets\n")
        for op in result['unique_to_one']:
            print(f"    {print_hex(op):8}  ({op})")

    elif args.baseline:
        if not args.action_file:
            print("Cần --action-file khi dùng --baseline")
            return
        bf = Path(args.baseline)
        af = Path(args.action_file)
        if not bf.exists() or not af.exists():
            print("File không tồn tại")
            return

        print(f"\nBaseline:    {bf.name}")
        print(f"Action file: {af.name}\n")
        result = baseline_diff(bf, af)

        new = result['new_opcodes']
        print(f"{'─'*w}")
        print(f"  Opcodes mới xuất hiện khi làm action '{args.action}':")
        print(f"  → Đây là packets của action đó\n")
        print(f"  {'Opcode':<10} {'Hex':<8} {'Baseline':>10} {'Action':>8} {'Delta':>6}")
        print(f"  {'─'*48}")
        for op, info in sorted(new.items(), key=lambda x: -x[1]['delta']):
            print(f"  {op:<10} {print_hex(op):<8} "
                  f"{info['in_baseline']:>10} {info['in_action']:>8} {info['delta']:>6}  ← NEW")

        if not new:
            print("  (không tìm thấy opcode mới — có thể action không tạo packet mới)")

    print(f"\n{'═'*w}")
    print("  Bước tiếp theo:")
    print("  1. Ghi opcodes tìm được vào analysis/opcode_map.yaml")
    print("  2. Điền vào bot/packet_builder.py")
    print('═' * w)


if __name__ == '__main__':
    main()
