"""
capture.py — Capture traffic VLTK1

BƯỚC 1 (Discovery): Chạy không có --port để thấy game connect đến IP:port nào
BƯỚC 2 (Focused):   Chạy với --port <port_game> để chỉ log game socket

Usage:
    python frida/capture.py --attach vn.vinagame.vltk1
    python frida/capture.py --attach vn.vinagame.vltk1 --port 10001
"""

import argparse
import frida
import sys
from datetime import datetime
from pathlib import Path

CAPTURES_DIR = Path(__file__).parent.parent / "captures"
HOOK_JS      = Path(__file__).parent / "hook_socket.js"


def hexdump(data: bytes, width=16) -> str:
    lines = []
    for i in range(0, len(data), width):
        chunk = data[i:i+width]
        h = ' '.join(f'{b:02x}' for b in chunk)
        a = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
        lines.append(f"  {i:04x}  {h:<{width*3}}  {a}")
    return '\n'.join(lines)


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--attach', metavar='PKG', required=True, help='Package name game')
    parser.add_argument('--port',   type=int, default=0,  help='Chỉ log port này (0 = tất cả)')
    parser.add_argument('--ip',     default='',           help='Chỉ log IP này')
    parser.add_argument('--no-dump', action='store_true', help='Không in hex dump (chỉ in header)')
    args = parser.parse_args()

    CAPTURES_DIR.mkdir(exist_ok=True)
    ts = datetime.now().strftime("%Y%m%d_%H%M%S")
    f_send = open(CAPTURES_DIR / f"send_{ts}.bin", 'wb')
    f_recv = open(CAPTURES_DIR / f"recv_{ts}.bin", 'wb')
    f_log  = open(CAPTURES_DIR / f"session_{ts}.log", 'w', encoding='utf-8')

    stats = {'send': 0, 'recv': 0, 'connections': {}}

    # Patch filter vào JS
    js = HOOK_JS.read_text(encoding='utf-8')
    js = js.replace('var FILTER_PORT = 0;', f'var FILTER_PORT = {args.port};')
    js = js.replace('var FILTER_IP = "";', f'var FILTER_IP = "{args.ip}";')

    def on_message(msg, data):
        if msg['type'] != 'send':
            if msg['type'] == 'error':
                print(f"\033[91m[ERR] {msg['description']}\033[0m")
            return

        p   = msg['payload']
        typ = p.get('type', '')
        now = datetime.now().strftime("%H:%M:%S.%f")[:-3]

        # ── CONNECT event ──────────────────────────────────
        if typ == 'CONNECT':
            ip, port, fd = p['ip'], p['port'], p['fd']
            note = p.get('note', '')
            color = '\033[93m' if note else '\033[90m'
            print(f"{color}[{now}] CONNECT  fd={fd}  {ip}:{port}  {note}\033[0m")
            f_log.write(f"[{now}] CONNECT fd={fd} {ip}:{port} {note}\n")
            stats['connections'][fd] = f"{ip}:{port}"

            if note:
                print(f"\033[93m          → Nếu đây là game server, chạy lại với: --port {port}\033[0m")
            return

        if typ == 'CLOSE':
            print(f"\033[90m[{now}] CLOSE    fd={p['fd']}  {p.get('remote','')}\033[0m")
            return

        if typ == 'READY':
            print(f"\033[95m[{now}] {p['msg']}\033[0m")
            if args.port:
                print(f"\033[95m          Filter: port={args.port}\033[0m")
            else:
                print(f"\033[93m          Mode: DISCOVERY — sẽ thấy tất cả connections\033[0m")
                print(f"\033[93m          Xem connect log → tìm IP:port game → chạy lại với --port\033[0m\n")
            return

        # ── SEND / RECV / READ / WRITE ─────────────────────
        raw    = bytes(p.get('data', []))
        length = p.get('len', 0)
        remote = p.get('remote', '?')

        is_send = typ in ('SEND', 'WRITE')
        color   = '\033[92m' if is_send else '\033[94m'

        print(f"{color}[{now}] {typ:<6}  fd={p['fd']}  {remote}  len={length}\033[0m")
        if not args.no_dump:
            print(hexdump(raw))
            print()

        # Ghi binary
        if is_send:
            f_send.write(raw); f_send.flush()
            stats['send'] += 1
        else:
            f_recv.write(raw); f_recv.flush()
            stats['recv'] += 1

        # Ghi log text
        f_log.write(f"[{now}] {typ} fd={p['fd']} {remote} len={length}\n")
        f_log.write(hexdump(raw) + "\n\n")
        f_log.flush()

    try:
        device  = frida.get_usb_device()
        session = device.attach(args.attach)
        script  = session.create_script(js)
        script.on('message', on_message)
        script.load()

        print(f"Attached: {args.attach}")
        print("Ctrl+C để dừng\n")
        sys.stdin.read()

    except frida.ProcessNotFoundError:
        print(f"Process '{args.attach}' không tìm thấy")
        print("Chạy: frida-ps -U  để xem danh sách")
    except KeyboardInterrupt:
        pass
    finally:
        f_send.close(); f_recv.close(); f_log.close()
        print(f"\n── Kết quả ──────────────────────")
        print(f"  SEND: {stats['send']} packets → captures/send_{ts}.bin")
        print(f"  RECV: {stats['recv']} packets → captures/recv_{ts}.bin")
        print(f"  Log:  captures/session_{ts}.log")
        print(f"\n── Connections phát hiện ────────")
        for fd, addr in stats['connections'].items():
            print(f"  fd={fd}  {addr}")
        print()
        if stats['send'] > 0 or stats['recv'] > 0:
            print("Bước tiếp theo:")
            print(f"  python analysis/packet_parser.py captures/send_{ts}.bin --detect-format")


if __name__ == '__main__':
    main()
