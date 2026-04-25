import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabToDoi:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Tổ đội ", bg=BG)
        f1.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        left1 = tk.Frame(f1, bg=BG)
        left1.pack(side=tk.LEFT, fill=tk.Y, padx=5)
        
        tk.Label(left1, text="Tổ đội", bg=BG).pack(anchor='w', pady=2)
        ttk.Combobox(left1, width=15).pack(anchor='w', pady=2)
        
        f_dt = tk.Frame(left1, bg=BG)
        f_dt.pack(anchor='w', pady=2)
        tk.Checkbutton(f_dt, text="Đội trưởng", bg=BG).pack(side=tk.LEFT)
        tk.Entry(f_dt, width=6).pack(side=tk.LEFT, padx=5)
        
        tk.Checkbutton(left1, text="Vào tổ đội", bg=BG).pack(anchor='w', pady=2)
        tk.Checkbutton(left1, text="Tổ đội tất cả", bg=BG).pack(anchor='w', pady=2)
        
        right1 = tk.Frame(f1, bg=BG)
        right1.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=5)
        tk.Label(right1, text="Danh sách tổ đội", bg=BG).pack(anchor='w')
        lst1 = tk.Listbox(right1, height=6)
        lst1.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        btn_f1 = tk.Frame(right1, bg=BG)
        btn_f1.pack(side=tk.RIGHT, fill=tk.Y, padx=2)
        tk.Button(btn_f1, text="➕", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f1, text="➖", width=2, fg="red").pack(pady=1)
        tk.Button(btn_f1, text="⬆", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f1, text="⬇", width=2, fg="blue").pack(pady=1)

        f2 = tk.LabelFrame(parent, text=" Theo sau ", bg=BG)
        f2.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        left2 = tk.Frame(f2, bg=BG)
        left2.pack(side=tk.LEFT, fill=tk.Y, padx=5)
        
        tk.Label(left2, text="Theo sau", bg=BG).pack(anchor='w', pady=2)
        ttk.Combobox(left2, width=15).pack(anchor='w', pady=2)
        
        tk.Checkbutton(left2, text="Theo đ. trưởng", bg=BG).pack(anchor='w', pady=2)
        
        f_ngua = tk.Frame(left2, bg=BG)
        f_ngua.pack(anchor='w', pady=2)
        tk.Checkbutton(f_ngua, text="Lên ngựa", bg=BG).pack(side=tk.LEFT)
        tk.Entry(f_ngua, width=6).pack(side=tk.LEFT, padx=5)
        
        tk.Label(left2, text="K. cách theo sau", bg=BG).pack(anchor='w', pady=(5,0))
        f_kc = tk.Frame(left2, bg=BG)
        f_kc.pack(anchor='w')
        tk.Entry(f_kc, width=6).pack(side=tk.LEFT, padx=(0,5))
        tk.Entry(f_kc, width=6).pack(side=tk.LEFT)

        right2 = tk.Frame(f2, bg=BG)
        right2.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=5)
        tk.Label(right2, text="Danh sách theo sau", bg=BG).pack(anchor='w')
        lst2 = tk.Listbox(right2, height=6)
        lst2.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        btn_f2 = tk.Frame(right2, bg=BG)
        btn_f2.pack(side=tk.RIGHT, fill=tk.Y, padx=2)
        tk.Button(btn_f2, text="➕", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f2, text="➖", width=2, fg="red").pack(pady=1)
        tk.Button(btn_f2, text="⬆", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f2, text="⬇", width=2, fg="blue").pack(pady=1)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
