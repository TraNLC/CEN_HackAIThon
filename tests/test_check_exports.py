"""Check which il2cpp APIs were cached at init time."""
import os, sys, time, json
sys.stdout.reconfigure(encoding='utf-8')

ROOT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
sys.path.insert(0, ROOT_DIR)

from features.bot.game_bot import VLTK1Bot

bot = VLTK1Bot()
bot.connect()
time.sleep(1)

print("\n📋 Cached IL2CPP APIs (from checkexports):")
print("=" * 55)
r = bot.script.exports_sync.checkexports()
for name, status in sorted(r.items()):
    print(f"  ✅ {name}: {status}")
if not r:
    print("  ❌ No APIs cached! _il2cpp is empty.")
    print("\n  Trying scanclasses as diagnostic...")
    r2 = bot.script.exports_sync.scanclasses("PlayerMain")
    print(f"  scanclasses result: {json.dumps(r2, indent=2)}")

# If APIs are cached, try scanning for Map-related classes
if r:
    print(f"\n🔍 Scanning for Map-related classes...")
    for kw in ["Map", "Scroll", "Dialog", "Npc"]:
        result = bot.script.exports_sync.scanclasses(kw)
        if result.get('ok') and result.get('count', 0) > 0:
            print(f"\n  '{kw}' => {result['count']} classes:")
            for cls in result['classes'][:20]:
                print(f"    - {cls['namespace']}.{cls['name']}")
        elif result.get('ok'):
            print(f"\n  '{kw}' => 0 classes")
        else:
            print(f"\n  '{kw}' => Error: {result.get('error')}")

bot.close()
