"""
query_script_json.py — Query script.json for method offsets
"""
import json

print("Loading script.json...")
with open('Il2CppDumper-net7-win-v6.7.46/script.json', 'r', encoding='utf-8') as f:
    data = json.load(f)

methods = data.get('ScriptMethod', [])
print(f"Total methods: {len(methods)}")

keywords = [
    'SwitchHorse', 'SetRiding', 'SendGSMessage', 'PlayerSit',
    'GotoPosition', 'ChatSend$$WriteTo', 'SendMSMessage',
    'Talk$$', 'GotoNpc$$'
]

print("\n=== MATCHING METHODS ===")
for entry in methods:
    name = entry.get('Name', '')
    for kw in keywords:
        if kw.lower() in name.lower():
            addr = entry.get('Address', 0)
            print(f"  0x{addr:010X}  {name}")
            break
