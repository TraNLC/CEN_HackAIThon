import sqlite3
import sys

sys.stdout.reconfigure(encoding='utf-8')
conn = sqlite3.connect('e:/tool/sample-test/vltk1-re/data/output/vltk1.db')
cursor = conn.cursor()

# Map fixes
fixes = {
    'Kim Quang ừụng': 'Kim Quang động',
    'Kinh Hoàng ừụng': 'Kinh Hoàng động',
    'Tởa Vân ừụng': 'Tỏa Vân động',
    'Tèn LỚng': 'Tần Lăng',
    'LỚng Tèn Thủy Hoàng': 'Lăng Tần Thủy Hoàng',
    'Trường Giang Nguyên Đèu': 'Trường Giang Nguyên Đầu',
    'Nhạn Thạch ừụng': 'Nhạn Thạch động',
    'Thanh Loa ừảo': 'Thanh Loa đảo'
}

for bad, good in fixes.items():
    cursor.execute("UPDATE maplist SET name=? WHERE name=?", (good, bad))

conn.commit()
print("Fixed maplist in sqlite db.")

cursor.execute("SELECT id, name FROM maplist LIMIT 10")
for row in cursor.fetchall():
    print(row[0], "-", row[1])

conn.close()
