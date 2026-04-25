"""
main.py - Entry Point của VLTK1 Mobile Auto Bot
Khởi chạy Giao diện (UI) của Bot.
"""
import sys
import tkinter as tk
from pathlib import Path

# Thêm đường dẫn gốc vào Python path
ROOT_DIR = Path(__file__).parent
sys.path.insert(0, str(ROOT_DIR))

from gui.app import Application

def main():
    root = tk.Tk()
    # Nếu muốn dùng icon cho ứng dụng, bạn có thể thêm:
    # root.iconbitmap('assets/icon.ico')
    
    app = Application(root)
    root.mainloop()

if __name__ == '__main__':
    main()
