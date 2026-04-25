import tkinter as tk
from tkinter import ttk

BG = "#ffffff"

def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class TabCoBan:
    def __init__(self, parent, app):
        self.app = app
        self.frame = tk.Frame(parent, bg=BG)
        self._build(self.frame)

    def _build(self, parent):

        lbl_info = tk.Label(parent, text="THÔNG TIN NHIỆM VỤ", font=("Arial", 9, "bold"), bg=BG)
        lbl_info.pack(pady=10)
        
        bot_frame = tk.Frame(parent, bg=BG)
        bot_frame.pack(side=tk.BOTTOM, fill=tk.BOTH, expand=True, padx=5, pady=5)
        
        pk_frame = tk.LabelFrame(bot_frame, text=" Auto PK ", bg=BG)
        pk_frame.pack(side=tk.LEFT, fill=tk.Y)
        
        tk.Checkbutton(pk_frame, text="Auto PK", bg=BG).grid(row=0, column=0, sticky='w')
        
        f_td = tk.Frame(pk_frame, bg=BG)
        f_td.grid(row=1, column=0, sticky='w')
        tk.Checkbutton(f_td, text="Tự đánh", bg=BG).pack(side=tk.LEFT)
        tk.Entry(f_td, width=6).pack(side=tk.LEFT, padx=5)
        
        tk.Checkbutton(pk_frame, text="Không đuổi theo", bg=BG).grid(row=2, column=0, sticky='w')
        tk.Checkbutton(pk_frame, text="Bỏ quái thường", bg=BG).grid(row=3, column=0, sticky='w')
        tk.Checkbutton(pk_frame, text="Tự động tổ đội", bg=BG).grid(row=4, column=0, sticky='w')
        
        ttk.Separator(pk_frame, orient='horizontal').grid(row=5, column=0, sticky='ew', pady=5)
        
        f_nhat = tk.Frame(pk_frame, bg=BG)
        f_nhat.grid(row=6, column=0, sticky='w')
        tk.Checkbutton(f_nhat, text="Nhặt v. phẩm", bg=BG).pack(side=tk.LEFT)
        btn_doc = tk.Button(f_nhat, text="📄", width=2, relief="groove")
        btn_doc.pack(side=tk.LEFT, padx=5)
        add_hover(btn_doc, "#f0f0f0", "#e0e0e0")
        
        tk.Checkbutton(pk_frame, text="Tự theo sau", bg=BG).grid(row=7, column=0, sticky='w')
        
        list_frame = tk.Frame(bot_frame, bg=BG)
        list_frame.pack(side=tk.LEFT, fill=tk.BOTH, expand=True, padx=5)
        
        listbox = tk.Listbox(list_frame, height=10)
        listbox.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        btn_frame = tk.Frame(list_frame, bg=BG)
        btn_frame.pack(side=tk.RIGHT, fill=tk.Y, padx=2)
        tk.Button(btn_frame, text="⬆", width=2, relief="groove").pack(pady=2)
        tk.Button(btn_frame, text="⬇", width=2, relief="groove").pack(pady=2)



    def save_config(self, config_dict):
        """Lưu cấu hình UI vào file YAML"""
        pass

    def load_config(self, config_dict):
        """Load cấu hình từ file YAML lên UI"""
        pass
