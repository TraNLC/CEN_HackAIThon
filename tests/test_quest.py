"""
test_quest.py - Test đọc nhiệm vụ Dã Tẩu

Usage:
    python tests/test_quest.py                 # Parse from latest quest.pcap
    python tests/test_quest.py --capture       # Capture mới + parse
    python tests/test_quest.py --npc 440 70    # Tap NPC tại vị trí rồi parse
"""
import sys
import os
from pathlib import Path

ROOT_DIR = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT_DIR))
sys.path.insert(0, str(ROOT_DIR / "tests"))
sys.stdout.reconfigure(encoding='utf-8')

from core.quest import QuestReader, parse_opcode34
from test_open_shop import parse_pcap_recv


def parse_existing_pcap():
    """Parse quest from existing pcap file."""
    pcap_path = ROOT_DIR / "data" / "output" / "quest.pcap"
    if not pcap_path.exists():
        print("[-] No quest.pcap found. Run with --capture first.")
        return
    
    packets = parse_pcap_recv(str(pcap_path), 45676)
    print(f"[+] Loaded {len(packets)} packets from {pcap_path.name}")
    
    found = False
    for op, body in packets:
        if op == 34 and len(body) > 10:
            quest = parse_opcode34(body)
            if quest:
                found = True
                print(f"\n{'─'*60}")
                if quest.is_valid:
                    print(f"  ✅ NHIỆM VỤ #{quest.quest_number}")
                    print(f"  📦 Tìm: {quest.item_count}x {quest.item_name}")
                    print(f"  🔮 Hệ:  {quest.element}")
                    print(f"  📋 Còn: {quest.remaining} nhiệm vụ")
                else:
                    print(f"  NPC Dialog (non-quest)")
                print(f"  📝 Text: {quest.clean_text}")
                if quest.buttons:
                    print(f"  🔘 Buttons: {quest.buttons}")
                print(f"{'─'*60}")
    
    if not found:
        print("[-] No opcode 34 found in pcap.")
        # Show what opcodes ARE present
        opcodes = {}
        for op, body in packets:
            if op not in opcodes: opcodes[op] = 0
            opcodes[op] += 1
        print(f"  Opcodes found: {dict(sorted(opcodes.items()))}")


def run():
    print()
    print("=" * 60)
    print("  VLTK1 - ĐỌC NHIỆM VỤ DÃ TẨU (Protocol)")
    print("=" * 60)
    
    args = sys.argv[1:]
    
    if "--capture" in args:
        print("\n[*] Capturing packets...")
        reader = QuestReader()
        quest = reader.read_current_quest()
        if quest and quest.is_valid:
            print(f"\n  ✅ {quest}")
        elif quest:
            print(f"\n  NPC Dialog: {quest.clean_text[:100]}")
        else:
            print("\n  [-] No quest found")
    
    elif "--npc" in args:
        idx = args.index("--npc")
        x = int(args[idx + 1])
        y = int(args[idx + 2])
        print(f"\n[*] Tapping NPC at ({x}, {y})...")
        reader = QuestReader()
        quest = reader.read_current_quest(npc_tap=(x, y))
        if quest and quest.is_valid:
            print(f"\n  ✅ {quest}")
        elif quest:
            print(f"\n  NPC Dialog: {quest.clean_text[:100]}")
        else:
            print("\n  [-] No quest found")
    
    else:
        parse_existing_pcap()


if __name__ == '__main__':
    run()
