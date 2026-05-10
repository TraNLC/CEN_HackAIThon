"""
test_scan_ui.py — Scan IL2CPP classes để tìm Map Dialog / ScrollRect / NPC List
Dùng Frida RPC scanClasses + dumpClass để khám phá cấu trúc UI
"""
import os, sys, time
sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from features.bot.game_bot import VLTK1Bot

def main():
    print("=" * 60)
    print("  VLTK1 — IL2CPP UI Class Scanner")
    print("=" * 60)
    
    bot = VLTK1Bot()
    bot.connect()
    time.sleep(1)
    
    # Step 1: Scan for Map/Dialog related classes
    keywords = ["MapDialog", "BigMap", "MapUI", "NpcList", "NpcButton", "MapNpc"]
    
    all_results = []
    for kw in keywords:
        print(f"\n🔍 Scanning classes with keyword '{kw}'...")
        result = bot.script.exports_sync.scanclasses(kw)
        if result['ok']:
            print(f"   Found {result['count']} classes:")
            for cls in result['classes']:
                print(f"   - {cls['namespace']}.{cls['name']}  ({cls['ptr']})")
                all_results.append(cls)
        else:
            print(f"   ❌ Error: {result['error']}")
    
    # Step 2: Broader scan
    broad_keywords = ["Map", "Scroll", "Dialog"]
    for kw in broad_keywords:
        print(f"\n🔍 Scanning classes with keyword '{kw}'...")
        result = bot.script.exports_sync.scanclasses(kw)
        if result['ok']:
            print(f"   Found {result['count']} classes:")
            for cls in result['classes'][:30]:  # Limit output
                print(f"   - {cls['namespace']}.{cls['name']}")
            if result['count'] > 30:
                print(f"   ... and {result['count'] - 30} more")
    
    # Step 3: Dump specific interesting classes
    print("\n" + "=" * 60)
    print("  DUMP CLASS DETAILS")
    print("=" * 60)
    
    # Try common game UI class names
    class_names_to_try = [
        ("MapDialog", ""),
        ("BigMapDialog", ""),
        ("MapUI", ""),
        ("UIMapDialog", ""),
        ("MapPanel", ""),
        ("WorldMapUI", ""),
        ("MapDlg", ""),
    ]
    
    for cls_name, ns in class_names_to_try:
        result = bot.script.exports_sync.dumpclass(cls_name, ns)
        if result['ok']:
            print(f"\n✅ Found class: {cls_name}")
            print(f"   Fields ({len(result['fields'])}):")
            for f in result['fields']:
                print(f"     [{f['offset']:3d}] {f['name']}")
            print(f"   Methods ({len(result['methods'])}):")
            for m in result['methods'][:20]:
                print(f"     {m['name']}  ({m['ptr']})")
            if len(result['methods']) > 20:
                print(f"     ... and {len(result['methods']) - 20} more")
    
    bot.close()

if __name__ == "__main__":
    main()
