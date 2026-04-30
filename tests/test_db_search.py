import sqlite3

def search_db():
    db_path = r'e:\tool\sample-test\vltk1-re\data\output\vltk1.db'
    conn = sqlite3.connect(db_path)
    cursor = conn.cursor()
    
    cursor.execute("SELECT name FROM sqlite_master WHERE type='table';")
    tables = [t[0] for t in cursor.fetchall()]
    
    search_vals = ['100001', '1450002', '400001']
    
    for table in tables:
        cursor.execute(f"PRAGMA table_info('{table}')")
        cols = [c[1] for c in cursor.fetchall()]
        
        for val in search_vals:
            # Construct a query to search all columns
            where_clause = " OR ".join([f"\"{c}\" = ?" for c in cols])
            query = f"SELECT * FROM \"{table}\" WHERE {where_clause} LIMIT 1"
            
            try:
                cursor.execute(query, [val] * len(cols))
                row = cursor.fetchone()
                if row:
                    print(f"Found {val} in table {table}!")
                    for i, col in enumerate(cols):
                        if str(row[i]) == val:
                            print(f"  -> Column: {col} = {val}")
            except Exception as e:
                pass
                
if __name__ == '__main__':
    search_db()
