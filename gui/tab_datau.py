import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabDaTau:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):
        f1 = tk.LabelFrame(parent, text=" Cài đặt Auto Dã Tẩu ", bg=BG)
        f1.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        top1 = tk.Frame(f1, bg=BG)
        top1.pack(fill=tk.X, padx=5, pady=10)
        tk.Checkbutton(top1, text="Kích hoạt Chuỗi Auto Dã Tẩu", bg=BG, font=("Tahoma", 9, "bold"), fg="blue").pack(side=tk.LEFT)
        
        mid1 = tk.Frame(f1, bg=BG)
        mid1.pack(fill=tk.X, pady=5, padx=5)
        
        tk.Checkbutton(mid1, text="Tự động mua vật phẩm từ Tạp hóa / Dược điếm", bg=BG).grid(row=0, column=0, sticky='w', pady=2)
        tk.Checkbutton(mid1, text="Tự động dùng Thổ địa phù khi làm xong", bg=BG).grid(row=1, column=0, sticky='w', pady=2)
        tk.Checkbutton(mid1, text="Hủy nhiệm vụ nếu yêu cầu nộp Trang Bị (Hiếm/Hoàng Kim)", bg=BG).grid(row=2, column=0, sticky='w', pady=2)
        
        f_huy = tk.Frame(mid1, bg=BG)
        f_huy.grid(row=3, column=0, sticky='w', pady=2)
        tk.Checkbutton(f_huy, text="Hủy nhiệm vụ nếu chi phí mua sắm vượt quá", bg=BG).pack(side=tk.LEFT)
        tk.Entry(f_huy, width=6).pack(side=tk.LEFT, padx=5)
        tk.Label(f_huy, text="Vạn (bạc)", bg=BG).pack(side=tk.LEFT)

        bot1 = tk.LabelFrame(f1, text=" Ưu tiên chọn phần thưởng ", bg=BG)
        bot1.pack(fill=tk.X, padx=5, pady=15)
        
        options = ["Vật phẩm quý", "Kinh Nghiệm", "Bạc (Tiền)", "Phúc Duyên"]
        
        for i, lbl in enumerate(["Ưu tiên 1:", "Ưu tiên 2:", "Ưu tiên 3:"]):
            f_pri = tk.Frame(bot1, bg=BG)
            f_pri.pack(fill=tk.X, padx=10, pady=5)
            tk.Label(f_pri, text=lbl, bg=BG, width=10, anchor="w").pack(side=tk.LEFT)
            cb = ttk.Combobox(f_pri, values=options, width=25, state="readonly")
            cb.pack(side=tk.LEFT, padx=5)
            # Mặc định gán các ưu tiên khác nhau
            if i < len(options):
                cb.current(i)

    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
