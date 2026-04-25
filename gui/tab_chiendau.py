import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabChienDau:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Kỹ năng chiến đấu ", bg=BG)
        f1.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        top_f1 = tk.Frame(f1, bg=BG)
        top_f1.pack(fill=tk.X, pady=2)
        tk.Label(top_f1, text="⚔", bg=BG).pack(side=tk.LEFT, padx=2)
        ttk.Combobox(top_f1).pack(side=tk.LEFT, fill=tk.X, expand=True)
        tk.Button(top_f1, text="➕", width=2, fg="blue").pack(side=tk.LEFT, padx=2)
        
        listbox3 = tk.Listbox(f1)
        listbox3.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        btn_frame3 = tk.Frame(f1, bg=BG)
        btn_frame3.pack(side=tk.RIGHT, fill=tk.Y, padx=2, pady=5)
        tk.Button(btn_frame3, text="➖", width=2, fg="red").pack(pady=2)
        tk.Button(btn_frame3, text="📄", width=2).pack(pady=2)
        tk.Button(btn_frame3, text="⬆", width=2, fg="blue").pack(pady=2)
        tk.Button(btn_frame3, text="⬇", width=2, fg="blue").pack(pady=2)
        
        f2 = tk.Frame(parent, bg=BG)
        f2.pack(fill=tk.X, padx=5, pady=10)
        
        tk.Label(f2, text="Phím đánh", bg=BG).grid(row=0, column=0)
        tk.Label(f2, text="Kỹ năng", bg=BG).grid(row=0, column=1)
        tk.Label(f2, text="Tầm đánh", bg=BG).grid(row=0, column=2)
        
        for i in range(3):
            ttk.Combobox(f2, width=8).grid(row=i+1, column=0, padx=5, pady=2)
            ttk.Combobox(f2, width=15).grid(row=i+1, column=1, padx=5, pady=2)
            tk.Entry(f2, width=6).grid(row=i+1, column=2, padx=5, pady=2)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
