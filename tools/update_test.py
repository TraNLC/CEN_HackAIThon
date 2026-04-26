import re

with open('e:/tool/sample-test/vltk1-re/tests/test_real_pathfinding.py', 'r', encoding='utf-8') as f:
    content = f.read()

content = content.replace('bot.go_to_datau_via_ui()', 'bot.go_to_npc_via_map("Dã Tẩu", "Tương Dương")')

with open('e:/tool/sample-test/vltk1-re/tests/test_real_pathfinding.py', 'w', encoding='utf-8') as f:
    f.write(content)
