"""
VLTK1 Shop Scanner Module

Continuously captures and parses shop data from game network traffic.

Usage:
    from core.shop_scanner import ShopScanner
    
    scanner = ShopScanner(
        item_dir='data/game_raw/settings/item',
        magic_path='data/game_raw/settings/magicdesc.txt'
    )
    
    # Callback receives parsed shop data
    def on_shop(shop_data):
        print(f"Shop: {shop_data['owner']} ({len(shop_data['items'])} items)")
        for item in shop_data['items']:
            print(f"  {item['name']} | {item['price']} | {item['type']}")
    
    scanner.run(callback=on_shop)
"""

import os
import sys
import time
import subprocess

# Add parent to path for imports
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
from tests.test_open_shop import parse_pcap_recv, parse_shop_items, read_varint
from core.item_lookup import ItemLookup
from core.magic_lookup import MagicLookup

ADB = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE = 'vn.perfingame.jx1mobile'
PCAP_DEV = '/data/local/tmp/shop_live.pcap'
PCAP_LOC_DEFAULT = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
                                'data', 'output', 'shop_live.pcap')


class ShopScanner:
    """
    Continuous shop packet scanner.
    
    Captures network traffic via tcpdump on Android,
    parses shop packets (opcode 205), and resolves item names.
    """
    
    def __init__(self, item_dir: str, magic_path: str, 
                 adb: str = ADB, device_id: str = DEVICE_ID,
                 pcap_local: str = PCAP_LOC_DEFAULT):
        """
        Args:
            item_dir: Path to item data directory
            magic_path: Path to magicdesc.txt
            adb: Path to adb binary
            device_id: Android device/emulator ID
            pcap_local: Local path for downloaded pcap file
        """
        self.items = ItemLookup(item_dir)
        self.magic = MagicLookup(magic_path)
        self.adb = adb
        self.device_id = device_id
        self.pcap_local = pcap_local
        self.port = None
        self._proc = None
    
    def _adb(self, *args, **kwargs):
        """Run adb command."""
        return subprocess.run(
            [self.adb, '-s', self.device_id] + list(args),
            capture_output=True, **kwargs
        )
    
    def _get_game_port(self) -> int:
        """Detect game server port from netstat."""
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
        """Start tcpdump on Android device."""
        self._adb('shell', 'su -c "killall tcpdump 2>/dev/null"')
        self._adb('shell', f'su -c "rm {PCAP_DEV} 2>/dev/null"')
        cmd = [self.adb, '-s', self.device_id, 'shell',
               f'su -c "tcpdump -i any -U -w {PCAP_DEV} port {self.port} 2>/dev/null"']
        self._proc = subprocess.Popen(cmd, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    
    def _stop_tcpdump(self):
        """Stop tcpdump on Android device."""
        self._adb('shell', 'su -c "killall tcpdump 2>/dev/null"')
        if self._proc:
            try:
                self._proc.terminate()
            except Exception:
                pass
    
    def _pull_pcap(self) -> bool:
        """Pull pcap file from device. Returns True if valid file exists."""
        self._adb('pull', PCAP_DEV, self.pcap_local)
        return os.path.exists(self.pcap_local) and os.path.getsize(self.pcap_local) >= 50
    
    def _parse_shop(self, raw_shop: dict) -> dict:
        """Parse raw shop data into clean format."""
        shop_items = raw_shop.get('items', [])
        owner = raw_shop.get('owner_id', '?')
        
        parsed_items = []
        for it in shop_items:
            slot = it.get('slot', 0)
            inner = it.get('inner', {})
            f1_p = inner.get('f1_proto', {})
            
            n3 = f1_p.get('n3', 0)
            n4 = f1_p.get('n4', 0)
            n5 = f1_p.get('n5', 0)
            n11_h = f1_p.get('n11_h')
            
            name = self.items.get_name(n3, n4)
            detail = n3 // 10000 if n3 else 0
            detail_name = self.items.get_detail_name(n3)
            attrs = self.magic.parse_attrs(n11_h) if n11_h else []
            
            # Price
            price_van = inner.get('f2')
            price_knb = inner.get('f3')
            if price_knb and isinstance(price_knb, int) and price_knb > 0:
                price_str = f"{price_knb} KNB"
                price_value = price_knb
                price_unit = 'KNB'
            elif price_van and isinstance(price_van, int):
                if price_van >= 10000:
                    price_str = f"{price_van // 10000} Vạn"
                else:
                    price_str = str(price_van)
                price_value = price_van
                price_unit = 'Vạn'
            else:
                price_str = '?'
                price_value = 0
                price_unit = '?'
            
            parsed_items.append({
                'slot': slot,
                'name': name,
                'type': detail_name,
                'detail': detail,
                'n3': n3,
                'n4': n4,
                'n5': n5,
                'price': price_str,
                'price_value': price_value,
                'price_unit': price_unit,
                'attrs': attrs,
                'attrs_str': ', '.join(f'{n} +{v}' for n, v in attrs),
            })
        
        return {
            'owner': owner,
            'count': len(parsed_items),
            'items': parsed_items,
        }
    
    def scan_once(self) -> dict | None:
        """
        Pull and parse one shop from current pcap.
        Returns parsed shop dict or None.
        """
        if not self._pull_pcap():
            return None
        
        try:
            packets = []
            for try_port in [self.port, 443, 80, 8080]:
                packets = parse_pcap_recv(self.pcap_local, try_port)
                if packets:
                    break
            
            if not packets:
                new_port = self._get_game_port()
                if new_port != self.port:
                    self.port = new_port
                return None
            
            last_shop = None
            for opcode, body in packets:
                if opcode == 205:
                    last_shop = parse_shop_items(body)
            
            if not last_shop:
                return None
            
            # Clean up
            try:
                os.remove(self.pcap_local)
            except Exception:
                pass
            
            return self._parse_shop(last_shop)
        except Exception:
            return None
    
    def run(self, callback=None, interval: float = 1.5, debug: bool = False):
        """
        Run continuous shop scanner.
        
        Args:
            callback: Function called with parsed shop data dict.
                      If None, prints to stdout.
            interval: Seconds between scan attempts
            debug: Print debug messages
        """
        self.port = self._get_game_port()
        self._start_tcpdump()
        
        if not callback:
            callback = self._default_print
        
        scan_count = 0
        try:
            while True:
                time.sleep(interval)
                scan_count += 1
                
                shop = self.scan_once()
                if shop:
                    callback(shop)
                    # Restart tcpdump for clean capture
                    self._start_tcpdump()
                    if debug:
                        print("[*] tcpdump restarted")
                elif debug and scan_count % 10 == 0:
                    print(f"[DEBUG] Scan #{scan_count}: waiting...")
                    
        except KeyboardInterrupt:
            print("\n[*] Scanner stopped.")
        finally:
            self._stop_tcpdump()
    
    @staticmethod
    def _default_print(shop: dict):
        """Default callback: print shop to stdout."""
        print("\n" + "=" * 70)
        print(f"[+] SHOP CỦA {shop['owner'].upper()} ({shop['count']} VẬT PHẨM):")
        print(f"{'#':<4}| {'Tên Vật Phẩm':<28} | {'Giá':<10} | {'Loại'}")
        print("-" * 60)
        
        for idx, item in enumerate(shop['items'], 1):
            print(f"{idx:<4}| {item['name']:<28} | {item['price']:<10} | {item['type']}")
            if item['attrs_str']:
                print(f"      -> {item['attrs_str']}")
        
        print("=" * 70)
