import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabTienIch:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.Frame(parent, bg=BG)
        f1.pack(fill=tk.X, padx=10, pady=10)
        
        tk.Checkbutton(f1, text="N. thưởng thẻ tháng", bg=BG).grid(row=0, column=0, sticky='w', pady=5)
        tk.Checkbutton(f1, text="Điểm danh ngày", bg=BG).grid(row=0, column=1, sticky='w', padx=20, pady=5)
        
        f_csvp = tk.Frame(f1, bg=BG)
        f_csvp.grid(row=2, column=0, sticky='w', pady=5)
        tk.Checkbutton(f_csvp, text="Chia sẻ v. phẩm", bg=BG).pack(side=tk.LEFT)
        tk.Button(f_csvp, text="📄", width=2).pack(side=tk.LEFT, padx=5)
        
        f2 = tk.Frame(parent, bg=BG)
        f2.pack(fill=tk.X, padx=10, pady=5)
        
        r1 = tk.Frame(f2, bg=BG)
        r1.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r1, text="Mở túi thuốc", bg=BG).pack(side=tk.LEFT, padx=5)
        tk.Entry(r1, width=8).pack(side=tk.LEFT, padx=5)
        tk.Entry(r1, width=8).pack(side=tk.LEFT, padx=5)
        
        f3 = tk.Frame(parent, bg=BG)
        f3.pack(fill=tk.X, padx=10, pady=10)
        
        ttk.Scale(f3, orient=tk.VERTICAL, length=100).pack(side=tk.RIGHT, padx=20)
        ttk.Scale(f3, orient=tk.VERTICAL, length=100).pack(side=tk.RIGHT, padx=20)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
