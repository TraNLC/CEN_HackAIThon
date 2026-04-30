"""
VLTK1 Broadcast Scanner Module

Captures and parses player shop broadcasts (opcode 133, rao bán Kênh Thế Giới / Xung Quanh)
100% network protocol via tcpdump.

Usage:
    from core.broadcast_scanner import BroadcastScanner
    
    scanner = BroadcastScanner()
    
    def on_broadcast(shop):
        print(f"[{shop['name']}] rao: {shop['desc']}")
        if shop['items']:
            print(f" -> Items: {shop['items']}")
            
    scanner.run(callback=on_broadcast)
"""
import os
import sys
import time
import struct
import subprocess
from pathlib import Path

# Add parent to path for imports
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from tests.test_open_shop import parse_pcap_recv, read_varint

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE = 'vn.perfingame.jx1mobile'
PCAP_DEV = '/data/local/tmp/broadcast.pcap'
PCAP_LOC_DEFAULT = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
                                'data', 'output', 'broadcast.pcap')

class BroadcastScanner:
    """
    Continuous broadcast packet scanner.
    Captures network traffic via tcpdump, parses opcode 133 (Player Shop Broadcasts).
    """
    def __init__(self, adb: str = ADB, device_id: str = DEVICE_ID,
                 pcap_local: str = PCAP_LOC_DEFAULT):
        self.adb = adb
        self.device_id = device_id
        self.pcap_local = pcap_local
        self.port = None
        self._proc = None
        self.seen_shop_ids = set()
        
        # Ensure output dir exists
        os.makedirs(os.path.dirname(self.pcap_local), exist_ok=True)
    
    def _adb(self, *args, **kwargs):
        return subprocess.run(
            [self.adb, '-s', self.device_id] + list(args),
            capture_output=True, **kwargs
        )
    
    def _get_game_port(self) -> int:
        try:
            out = self._adb('shell', 'su -c "netstat -tnp 2>/dev/null"').stdout.decode()
            for line in out.splitlines():
                if PACKAGE in line and 'ESTABLISHED' in line:
                    parts = line.split()
                    for p in parts:
                        if ':' in p and '.' in p:
                            port = int(p.split(':')[-1])
                            if port > 1000 and port not in (5555, 5037, 27042, 27183):
                                return port
        except Exception:
            pass
        return 443
    
    def _start_tcpdump(self):
        self._adb('shell', 'su -c "killall tcpdump 2>/dev/null"')
        self._adb('shell', f'su -c "rm {PCAP_DEV} 2>/dev/null"')
        cmd = [self.adb, '-s', self.device_id, 'shell',
               f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {self.port} 2>/dev/null"']
        self._proc = subprocess.Popen(cmd, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    
    def _stop_tcpdump(self):
        self._adb('shell', 'su -c "killall tcpdump 2>/dev/null"')
        if self._proc:
            try:
                self._proc.terminate()
            except Exception:
                pass
                
    def _pull_pcap(self) -> bool:
        self._adb('pull', PCAP_DEV, self.pcap_local)
        return os.path.exists(self.pcap_local) and os.path.getsize(self.pcap_local) >= 50
        
    def _parse_broadcast(self, body: bytes) -> dict:
        pos = 0
        shop = {"id": "", "name": "", "desc": "", "items": ""}
        while pos < len(body):
            tag, pos = read_varint(body, pos)
            if pos > len(body): break
            field, wtype = tag >> 3, tag & 0x7
            if wtype == 0:
                _, pos = read_varint(body, pos)
            elif wtype == 2:
                ln, pos = read_varint(body, pos)
                val = body[pos:pos+ln].decode('utf-8', errors='replace')
                pos += ln
                if field == 2: shop["id"] = val
                elif field == 3: shop["name"] = val
                elif field == 4: shop["desc"] = val
                elif field == 5: shop["items"] = val
            else: break
        return shop

    def scan_once(self) -> list:
        if not self._pull_pcap():
            return []
            
        packets = []
        for try_port in [self.port, 443, 80, 8080]:
            packets = parse_pcap_recv(self.pcap_local, try_port)
            if packets:
                break
                
        if not packets:
            new_port = self._get_game_port()
            if new_port != self.port:
                self.port = new_port
            return []
            
        new_broadcasts = []
        for opcode, body in packets:
            if opcode == 133 and len(body) >= 10:
                shop = self._parse_broadcast(body)
                if shop["name"] and shop["id"] not in self.seen_shop_ids:
                    self.seen_shop_ids.add(shop["id"])
                    new_broadcasts.append(shop)
                    
        try: os.remove(self.pcap_local)
        except: pass
        
        return new_broadcasts

    def run(self, callback=None, interval: float = 3.0, debug: bool = False):
        self.port = self._get_game_port()
        self._start_tcpdump()
        
        if not callback:
            callback = self._default_print
            
        print("=" * 60)
        print("  VLTK1 - LIVE BROADCAST SCANNER (OPCODE 133)")
        print("=" * 60)
        print(f"[*] Port: {self.port} | Listening...")
        
        try:
            while True:
                time.sleep(interval)
                broadcasts = self.scan_once()
                if broadcasts:
                    for b in broadcasts:
                        callback(b)
                    self._start_tcpdump() # Restart tcpdump for clean capture
        except KeyboardInterrupt:
            print("\n[*] Scanner stopped.")
        finally:
            self._stop_tcpdump()
            
    @staticmethod
    def _default_print(shop: dict):
        has_item = " 📦" if shop['items'] else ""
        print(f"\n📢 [{shop['name']}]{has_item}")
        if shop['desc']:
            print(f"   📝 {shop['desc'][:80]}")
        if shop['items']:
            print(f"   🛒 {shop['items'][:80]}")

if __name__ == '__main__':
    scanner = BroadcastScanner()
    scanner.run()
