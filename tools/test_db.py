import sqlite3

conn = sqlite3.connect('e:/tool/sample-test/vltk1-re/data/output/vltk1.db')
cursor = conn.cursor()

print("--- MAPS ---")
cursor.execute("SELECT id, name FROM maplist LIMIT 10")
for row in cursor.fetchall():
    print(row)

print("\n--- NPCs ---")
cursor.execute("SELECT Name, Kind FROM npcs LIMIT 10")
for row in cursor.fetchall():
    print(row)

conn.close()
