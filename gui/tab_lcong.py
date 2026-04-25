import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabLcong:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Luyện công ", bg=BG)
        f1.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        top1 = tk.Frame(f1, bg=BG)
        top1.pack(fill=tk.X, padx=5, pady=2)
        tk.Checkbutton(top1, text="Tự đánh", bg=BG).pack(side=tk.LEFT)
        tk.Entry(top1, width=8).pack(side=tk.LEFT, padx=5)
        tk.Checkbutton(top1, text="Đánh lẻ", bg=BG).pack(side=tk.LEFT, padx=10)
        
        mid1 = tk.Frame(f1, bg=BG)
        mid1.pack(fill=tk.BOTH, expand=True, padx=5)
        
        left_list = tk.Frame(mid1, bg=BG)
        left_list.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        head_f = tk.Frame(left_list, bg=BG)
        head_f.pack(fill=tk.X)
        tk.Entry(head_f, width=10).pack(side=tk.LEFT, padx=2)
        tk.Entry(head_f, width=10).pack(side=tk.LEFT, padx=2)
        tk.Entry(head_f, width=10).pack(side=tk.LEFT, padx=2)
        
        list_lc = tk.Listbox(left_list, height=5)
        list_lc.pack(fill=tk.BOTH, expand=True, pady=2)
        
        btn_f1 = tk.Frame(mid1, bg=BG)
        btn_f1.pack(side=tk.RIGHT, fill=tk.Y, padx=2)
        tk.Button(btn_f1, text="➕", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f1, text="➖", width=2, fg="red").pack(pady=1)
        tk.Button(btn_f1, text="📄", width=2).pack(pady=1)
        tk.Button(btn_f1, text="⬆", width=2, fg="blue").pack(pady=1)
        tk.Button(btn_f1, text="⬇", width=2, fg="blue").pack(pady=1)

        bot1 = tk.Frame(f1, bg=BG)
        bot1.pack(fill=tk.X, padx=5, pady=5)
        tk.Checkbutton(bot1, text="Quanh quái", bg=BG).pack(side=tk.LEFT)
        tk.Entry(bot1, width=6).pack(side=tk.LEFT, padx=5)
        tk.Label(bot1, text="Bán kính", bg=BG).pack(side=tk.LEFT, padx=5)
        tk.Entry(bot1, width=6).pack(side=tk.LEFT)

        f2 = tk.LabelFrame(parent, text=" Về thành khi ", bg=BG)
        f2.pack(fill=tk.X, padx=5, pady=5)
        
        r1 = tk.Frame(f2, bg=BG)
        r1.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r1, text="Đầy h. trang", bg=BG).pack(side=tk.LEFT, padx=5)
        ttk.Combobox(r1, values=["2x1"], width=6).pack(side=tk.LEFT, padx=5)
        tk.Checkbutton(r1, text="Hết bình máu", bg=BG).pack(side=tk.LEFT, padx=20)
        
        r2 = tk.Frame(f2, bg=BG)
        r2.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r2, text="Độ bền <=", bg=BG).pack(side=tk.LEFT, padx=5)
        tk.Entry(r2, width=8).pack(side=tk.LEFT, padx=5)
        tk.Checkbutton(r2, text="Hết bình mana", bg=BG).pack(side=tk.LEFT, padx=28)
        
        r3 = tk.Frame(f2, bg=BG)
        r3.pack(fill=tk.X, pady=2)
        tk.Checkbutton(r3, text="Tiền >=", bg=BG).pack(side=tk.LEFT, padx=5)
        tk.Entry(r3, width=8).pack(side=tk.LEFT, padx=17)
        tk.Checkbutton(r3, text="Hết Ngọc Lộ Hoàn", bg=BG).pack(side=tk.LEFT, padx=18)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
