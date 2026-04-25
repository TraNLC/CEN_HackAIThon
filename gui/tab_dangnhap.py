import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabDangNhap:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        f1 = tk.LabelFrame(parent, text=" Thông tin đăng nhập ", bg=BG)
        f1.pack(fill=tk.X, padx=5, pady=5)
        
        labels = ["Phân vùng", "Máy chủ", "Tài khoản", "Mật khẩu"]
        for i, text in enumerate(labels):
            tk.Label(f1, text=text, bg=BG).grid(row=i, column=0, sticky='w', padx=10, pady=5)
            if i < 2:
                ttk.Combobox(f1, width=25).grid(row=i, column=1, padx=10, pady=5)
            else:
                tk.Entry(f1, width=28, show="*" if text == "Mật khẩu" else "").grid(row=i, column=1, padx=10, pady=5)
                
        f2 = tk.LabelFrame(parent, text=" Hệ thống ", bg=BG)
        f2.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        tk.Label(f2, text="TG đăng nhập tối đa", bg=BG).grid(row=0, column=0, sticky='w', padx=5, pady=5)
        tk.Entry(f2, width=8).grid(row=0, column=1, padx=5)
        tk.Label(f2, text="s", bg=BG).grid(row=0, column=2, sticky='w')
        
        tk.Label(f2, text="TG chờ đăng nhập lại", bg=BG).grid(row=1, column=0, sticky='w', padx=5, pady=5)
        tk.Entry(f2, width=8).grid(row=1, column=1, padx=5)
        tk.Label(f2, text="s", bg=BG).grid(row=1, column=2, sticky='w')
        
        tk.Checkbutton(f2, text="Tự động đăng nhập", bg=BG).grid(row=2, column=0, sticky='w', padx=5, pady=5)
        tk.Checkbutton(f2, text="Tự ẩn game", bg=BG).grid(row=2, column=1, columnspan=2, sticky='w', padx=5, pady=5)
        
        tk.Checkbutton(f2, text="Sử dụng Sandboxie", bg=BG).grid(row=3, column=0, sticky='w', padx=5, pady=5)
        tk.Entry(f2, width=15).grid(row=3, column=1, columnspan=2, sticky='w', padx=5)
        
        f_group = tk.Frame(f2, bg=BG)
        f_group.grid(row=5, column=0, columnspan=3, pady=10, sticky='w')
        tk.Label(f_group, text="Thuộc nhóm", bg=BG).pack(side=tk.LEFT, padx=5)
        tk.Entry(f_group, width=8).pack(side=tk.LEFT, padx=5)
        tk.Checkbutton(f_group, text="Trưởng nhóm", bg=BG).pack(side=tk.LEFT, padx=20)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
