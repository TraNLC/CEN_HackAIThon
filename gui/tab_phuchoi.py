import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabPhucHoi:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Phục hồi ", bg=BG)
        f1.pack(fill=tk.X, padx=5, pady=5)
        
        tk.Label(f1, text="Lv1", bg=BG).grid(row=0, column=1)
        tk.Label(f1, text="Lv2", bg=BG).grid(row=0, column=2)
        tk.Label(f1, text="Lv3", bg=BG).grid(row=0, column=3)
        tk.Label(f1, text="ms", bg=BG).grid(row=0, column=4)
        
        for i, text in enumerate(["HP", "HP %", "MP %", "HP PK"]):
            tk.Checkbutton(f1, text=text, bg=BG).grid(row=i+1, column=0, sticky='w')
            for j in range(1, 5):
                tk.Entry(f1, width=7).grid(row=i+1, column=j, padx=2, pady=1)
                
        f_tdp = tk.Frame(f1, bg=BG)
        f_tdp.grid(row=5, column=0, columnspan=5, pady=5, sticky='w')
        tk.Label(f_tdp, text="TĐP khi", bg=BG).pack(side=tk.LEFT, padx=2)
        tk.Checkbutton(f_tdp, text="HP <", bg=BG).pack(side=tk.LEFT)
        tk.Entry(f_tdp, width=5).pack(side=tk.LEFT, padx=2)
        tk.Checkbutton(f_tdp, text="MP <", bg=BG).pack(side=tk.LEFT, padx=(10,0))
        tk.Entry(f_tdp, width=5).pack(side=tk.LEFT, padx=2)
        
        f2 = tk.LabelFrame(parent, text=" Kỹ năng hỗ trợ ", bg=BG)
        f2.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        top_f2 = tk.Frame(f2, bg=BG)
        top_f2.pack(fill=tk.X, pady=2)
        tk.Button(top_f2, text="➕", width=2, fg="blue").pack(side=tk.LEFT, padx=5)
        ttk.Combobox(top_f2).pack(side=tk.LEFT, fill=tk.X, expand=True)
        tk.Button(top_f2, text="➖", width=2, fg="red").pack(side=tk.LEFT, padx=5)
        
        listbox2 = tk.Listbox(f2)
        listbox2.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        btn_frame2 = tk.Frame(f2, bg=BG)
        btn_frame2.pack(side=tk.RIGHT, fill=tk.Y, padx=2, pady=5)
        tk.Button(btn_frame2, text="📄", width=2).pack(pady=2)
        tk.Button(btn_frame2, text="⬆", width=2, fg="blue").pack(pady=2)
        tk.Button(btn_frame2, text="⬇", width=2, fg="blue").pack(pady=2)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
