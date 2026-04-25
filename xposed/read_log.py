"""
read_log.py — Đọc log từ Xposed module trên device về PC

Usage:
    # Pull log file về và hiển thị
    python xposed/read_log.py

    # Watch realtime (tail -f qua ADB)
    python xposed/read_log.py --watch

    # Parse packets từ log và export binary
    python xposed/read_log.py --parse
"""

import argparse
import re
import subprocess
import sys
import time
from pathlib import Path

LOG_REMOTE = "/sdcard/vltk_packets.log"
LOG_LOCAL  = Path(__file__).parent.parent / "captures" / "xposed_packets.log"
CAPTURES   = Path(__file__).parent.parent / "captures"


def adb(cmd: str) -> str:
    r = subprocess.run(f"adb {cmd}", shell=True, capture_output=True, text=True)
    return r.stdout + r.stderr


def pull_log():
    CAPTURES.mkdir(exist_ok=True)
    out = adb(f"pull {LOG_REMOTE} \"{LOG_LOCAL}\"")
    print(out.strip())
    return LOG_LOCAL


def watch_log():
    """Realtime tail qua logcat (Xposed log → Android logcat)."""
    print("Watching logcat for VLTKHook... (Ctrl+C để dừng)\n")
    proc = subprocess.Popen(
        "adb logcat -s VLTKHook:D XposedBridge:D",
        shell=True, stdout=subprocess.PIPE, text=True
    )
    try:
        for line in proc.stdout:
            print(line, end='')
    except KeyboardInterrupt:
        proc.terminate()


def parse_log(log_path: Path):
    """Parse log file thành binary captures để dùng với packet_parser.py."""
    if not log_path.exists():
        print(f"Log không tìm thấy: {log_path}")
        return

    text = log_path.read_text(encoding='utf-8', errors='replace')

    # Pattern: SEND [len]\n hex dump lines
    send_data = bytearray()
    recv_data = bytearray()

    lines = text.splitlines()
    i = 0
    send_count = recv_count = 0

    while i < len(lines):
        line = lines[i].strip()
        # Match: [HH:MM:SS.mmm] SEND [32]  hoặc NET_SEND [32]
        m = re.match(r'\[[\d:\.]+\] ((?:NET_)?(?:SEND|RECV)) \[(\d+)\]', line)
        if m:
            direction = m.group(1)
            length = int(m.group(2))
            # Đọc hex dump lines tiếp theo
            raw = bytearray()
            i += 1
            while i < len(lines):
                dump_line = lines[i].strip()
                # hex dump line: "0000  aa bb cc ..."
                if re.match(r'^[0-9a-f]{4}\s+', dump_line):
                    parts = dump_line.split('  ')
                    if len(parts) >= 2:
                        hex_part = parts[1].strip()
                        for h in hex_part.split():
                            try:
                                raw.append(int(h, 16))
                            except ValueError:
                                pass
                    i += 1
                else:
                    break

            if 'SEND' in direction:
                send_data.extend(raw)
                send_count += 1
            else:
                recv_data.extend(raw)
                recv_count += 1
        else:
            i += 1

    # Save binary
    if send_data:
        out = CAPTURES / "xposed_send.bin"
        out.write_bytes(send_data)
        print(f"Saved {send_count} SEND packets → {out}")

    if recv_data:
        out = CAPTURES / "xposed_recv.bin"
        out.write_bytes(recv_data)
        print(f"Saved {recv_count} RECV packets → {out}")

    if send_data or recv_data:
        print(f"\nTiếp theo:")
        print(f"  python analysis/packet_parser.py captures/xposed_send.bin --detect-format")
        print(f"  python analysis/packet_parser.py captures/xposed_send.bin --summary")
    else:
        print("Không parse được packet nào — kiểm tra format log")


def main():
    parser = argparse.ArgumentParser(description='Xposed log reader')
    parser.add_argument('--watch',  action='store_true', help='Realtime logcat watch')
    parser.add_argument('--parse',  action='store_true', help='Parse log → binary')
    parser.add_argument('--clear',  action='store_true', help='Xóa log trên device')
    args = parser.parse_args()

    if args.clear:
        adb(f"shell rm -f {LOG_REMOTE}")
        print("Log cleared")
        return

    if args.watch:
        watch_log()
        return

    # Default: pull + parse
    log_path = pull_log()
    if args.parse or True:  # always parse after pull
        parse_log(log_path)


if __name__ == '__main__':
    main()
