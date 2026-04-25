import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabTuVe:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Tự vệ ", bg=BG)
        f1.pack(fill=tk.X, padx=5, pady=5)
        
        r1 = tk.Frame(f1, bg=BG)
        r1.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r1, text="Tự vệ", bg=BG).pack(side=tk.LEFT)
        ttk.Combobox(r1, values=["Thổ địa phù"], width=15).pack(side=tk.LEFT, padx=5)
        tk.Entry(r1, width=6).pack(side=tk.LEFT, padx=2)
        tk.Entry(r1, width=6).pack(side=tk.LEFT, padx=2)
        
        r2 = tk.Frame(f1, bg=BG)
        r2.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r2, text="Nghỉ", bg=BG).pack(side=tk.LEFT)
        tk.Entry(r2, width=5).pack(side=tk.LEFT, padx=2)
        tk.Label(r2, text="khi về thành", bg=BG).pack(side=tk.LEFT, padx=2)
        tk.Entry(r2, width=6).pack(side=tk.LEFT, padx=2)
        
        r5 = tk.Frame(f1, bg=BG)
        r5.pack(fill=tk.X, pady=5)
        
        f_cs = tk.Frame(r5, bg=BG)
        f_cs.grid(row=0, column=0, sticky='w')
        tk.Checkbutton(f_cs, text="Tự cừu sát", bg=BG).pack(side=tk.LEFT)
        tk.Button(f_cs, text="📄", width=2).pack(side=tk.LEFT, padx=2)
        
        f_bvcs = tk.Frame(r5, bg=BG)
        f_bvcs.grid(row=0, column=1, sticky='w', padx=15)
        tk.Checkbutton(f_bvcs, text="Bảo vệ cừu sát", bg=BG).pack(side=tk.LEFT)
        tk.Button(f_bvcs, text="📄", width=2).pack(side=tk.LEFT, padx=2)
        
        f2 = tk.LabelFrame(parent, text=" PK ", bg=BG)
        f2.pack(fill=tk.X, padx=5, pady=5)
        
        r6 = tk.Frame(f2, bg=BG)
        r6.pack(fill=tk.X, pady=5)
        
        f_mt = tk.Frame(r6, bg=BG)
        f_mt.grid(row=0, column=0, sticky='w')
        tk.Checkbutton(f_mt, text="Mua thuốc", bg=BG).pack(side=tk.LEFT)
        tk.Button(f_mt, text="📄", width=2).pack(side=tk.LEFT, padx=2)
        
        tk.Checkbutton(r6, text="Nhận thuốc m. phí", bg=BG).grid(row=0, column=1, sticky='w', padx=25)
        tk.Checkbutton(r6, text="Sửa trang bị", bg=BG).grid(row=1, column=0, sticky='w', pady=5)
        tk.Checkbutton(r6, text="PK theo đ. trưởng", bg=BG).grid(row=2, column=0, columnspan=2, sticky='w', pady=5)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
