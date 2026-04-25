import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabHTrang:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Vật phẩm ", bg=BG)
        f1.pack(fill=tk.X, padx=5, pady=5)
        
        tk.Checkbutton(f1, text="Mua thuốc", bg=BG).grid(row=0, column=0, sticky='w')
        tk.Checkbutton(f1, text="Tự sử dụng", bg=BG).grid(row=1, column=0, sticky='w')
        tk.Checkbutton(f1, text="Mua tạp hóa", bg=BG).grid(row=0, column=1, sticky='w', padx=20)
        tk.Checkbutton(f1, text="Bán trang bị", bg=BG).grid(row=1, column=1, sticky='w', padx=20)
        
        f2 = tk.LabelFrame(parent, text=" Hành trang ", bg=BG)
        f2.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        tk.Checkbutton(f2, text="Mở rương", bg=BG).grid(row=0, column=0, sticky='w')
        tk.Entry(f2, width=8).grid(row=0, column=1, padx=2)
        tk.Checkbutton(f2, text="Sửa trang bị", bg=BG).grid(row=1, column=0, sticky='w')
        tk.Checkbutton(f2, text="Sửa t. bị Hoàng Kim", bg=BG).grid(row=2, column=0, columnspan=2, sticky='w')
        tk.Checkbutton(f2, text="Sắp xếp h. trang", bg=BG).grid(row=3, column=0, columnspan=2, sticky='w')
        
        f_ren = tk.Frame(f2, bg=BG)
        f_ren.grid(row=4, column=0, columnspan=2, sticky='w')
        tk.Checkbutton(f_ren, text="Rèn", bg=BG).pack(side=tk.LEFT)
        ttk.Combobox(f_ren, values=["V. khí cận chiến"], width=12).pack(side=tk.LEFT)
        
        tk.Checkbutton(f2, text="Ghép số tay rèn", bg=BG).grid(row=5, column=0, columnspan=2, sticky='w')
        tk.Checkbutton(f2, text="Gửi tiền", bg=BG).grid(row=6, column=0, sticky='w')
        tk.Entry(f2, width=8).grid(row=6, column=1, padx=2)
        
        tk.Checkbutton(f2, text="Rút tiền", bg=BG).grid(row=0, column=2, sticky='w', padx=5)
        tk.Entry(f2, width=8).grid(row=0, column=3, padx=2)
        tk.Checkbutton(f2, text="Sửa trên bãi", bg=BG).grid(row=1, column=2, sticky='w', padx=5)
        tk.Entry(f2, width=8).grid(row=1, column=3, padx=2)
        tk.Checkbutton(f2, text="Khóa trang bị", bg=BG).grid(row=2, column=2, columnspan=2, sticky='w', padx=5)
        tk.Checkbutton(f2, text="Cất vật phẩm", bg=BG).grid(row=3, column=2, sticky='w', padx=5)
        tk.Checkbutton(f2, text="Rèn t. bị khóa", bg=BG).grid(row=4, column=2, columnspan=2, sticky='w', padx=5)
        tk.Checkbutton(f2, text="Ghép q. t. bí", bg=BG).grid(row=5, column=2, sticky='w', padx=5)
        tk.Entry(f2, width=8).grid(row=5, column=3, padx=2)
        tk.Checkbutton(f2, text="Ghép h. tinh", bg=BG).grid(row=6, column=2, sticky='w', padx=5)
        tk.Entry(f2, width=8).grid(row=6, column=3, padx=2)
        
        f3 = tk.Frame(parent, bg=BG)
        f3.pack(fill=tk.X, padx=5, pady=5)
        tk.Label(f3, text="Bản đồ mua thuốc", bg=BG).pack(side=tk.LEFT)
        ttk.Combobox(f3, width=20).pack(side=tk.LEFT, padx=5)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
