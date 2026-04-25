"""VLTK1 Helper — Beautiful UI inspired by 9C Helper."""
import tkinter as tk
from tkinter import ttk

from gui.tab_coban import TabCoBan
from gui.tab_phuchoi import TabPhucHoi
from gui.tab_htrang import TabHTrang
from gui.tab_chiendau import TabChienDau
from gui.tab_dangnhap import TabDangNhap
from gui.tab_todoi import TabToDoi
from gui.tab_lcong import TabLcong
from gui.tab_datau import TabDaTau
from gui.tab_tuve import TabTuVe
from gui.tab_tich import TabTienIch


FN = ("Tahoma", 9)
BG = "#ffffff"
TAB_ACT_BG = "#4a6fa5"
TAB_ACT_FG = "#ffffff"
TAB_NOR_BG = "#e8e8e8"
TAB_NOR_FG = "#000000"

# ─── Tooltip helper ───
class ToolTip:
    def __init__(self, widget, text):
        self.widget = widget
        self.text = text
        self.tip = None
        widget.bind("<Enter>", self.show)
        widget.bind("<Leave>", self.hide)

    def show(self, e=None):
        x = self.widget.winfo_rootx() + 20
        y = self.widget.winfo_rooty() + self.widget.winfo_height() + 2
        self.tip = tk.Toplevel(self.widget)
        self.tip.wm_overrideredirect(True)
        self.tip.wm_geometry(f"+{x}+{y}")
        lbl = tk.Label(self.tip, text=self.text, font=("Tahoma", 8),
                       bg="#ffffdd", fg="#000", bd=1, relief="solid", padx=4, pady=2)
        lbl.pack()

    def hide(self, e=None):
        if self.tip:
            self.tip.destroy()
            self.tip = None

# ─── Hover helper ───
def add_hover(btn, normal_bg, hover_bg):
    btn.bind("<Enter>", lambda e: btn.config(bg=hover_bg))
    btn.bind("<Leave>", lambda e: btn.config(bg=normal_bg))

class Application:
    APP_NAME = "GSTAuto 1.0.0"

    def __init__(self, root):
        self.root = root
        self.root.title(f"{self.APP_NAME} <Còn ...")
        self.root.geometry("380x820")
        self.root.minsize(380, 820)
        self.root.resizable(False, False)
        self.root.configure(bg=BG)
        
        self.root.option_add("*Font", FN)
        self.root.option_add("*Background", BG)
        self.root.option_add("*Foreground", "#000")
        
        self._theme()
        self._build()

    def _theme(self):
        s = ttk.Style()
        if 'clam' in s.theme_names():
            s.theme_use("clam")
        s.configure(".", font=FN, background=BG, foreground="#000")
        s.configure("G.Treeview", rowheight=24, font=FN,
                    background=BG, fieldbackground=BG, foreground="#000")
        s.configure("G.Treeview.Heading", font=("Tahoma", 9, "bold"),
                    background="#e8edf2", foreground="#000",
                    relief="solid", borderwidth=1)
        s.map("G.Treeview",
              background=[("selected", "#cce0ff")],
              foreground=[("selected", "#000")])
        s.configure("TLabelframe", background=BG)
        s.configure("TLabelframe.Label", font=FN, background=BG, foreground="#000")
        s.configure("TCheckbutton", background=BG)
        s.configure("TFrame", background=BG)

    def _build(self):
        # 1. Bảng nhân vật (Treeview)
        self._build_char_list()
        
        # 2. Hai hàng Tab Custom
        self._build_custom_tabs()
        
        # 3. Thanh công cụ và trạng thái ở dưới cùng
        self._build_bottom_bar()
        
    def _build_char_list(self):
        tbl_frame = tk.Frame(self.root, bg=BG)
        tbl_frame.pack(fill="x", padx=4, pady=4)
        
        cols = ("name", "map", "money")
        self.tree = ttk.Treeview(tbl_frame, columns=cols, show="headings", height=8, style="G.Treeview")
        self.tree.heading("name", text="Tên nhân vật")
        self.tree.heading("map", text="Bản đồ")
        self.tree.heading("money", text="Ngân lượng")
        
        self.tree.column("name", width=180)
        self.tree.column("map", width=60, anchor='center')
        self.tree.column("money", width=100, anchor='e')
        
        self.tree.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        
        scrollbar = ttk.Scrollbar(tbl_frame, orient="vertical", command=self.tree.yview)
        scrollbar.pack(side=tk.RIGHT, fill=tk.Y)
        self.tree.configure(yscrollcommand=scrollbar.set)
        
        # Tag màu
        self.tree.tag_configure("char", foreground="#cc00cc") # Tím cho tên
        self.tree.tag_configure("money", foreground="#cc00cc") 
        self.tree.tag_configure("r0", background="#ffffff")
        self.tree.tag_configure("r1", background="#f4f6f8")
        
        mock_data = [
            ("☐ [0]TrầnBìnhAn", "-", "21.8 vạn"),
            ("☐ [0]GSTCamBo", "-", "42.3 vạn"),
            ("☐ [0]NhấtTrụKìnhThiên", "-", "643.0 vạn"),
            ("☐ [0]GSTTony", "-", "1411.2 vạn"),
            ("☐ [0]Hoắc-ThủyTiên", "-", "5.8 vạn"),
            ("☐ [0]GSTNhanNhan", "-", "127.9 vạn"),
            ("☐ [0]Nicorobin", "-", "98.4 vạn"),
            ("☐ [0]GSTConDiecTrang", "-", "342.1 vạn"),
        ]
        for i, item in enumerate(mock_data):
            self.tree.insert("", tk.END, values=item, tags=(f"r{i%2}", "char"))

    def _build_custom_tabs(self):
        tab_bar = tk.Frame(self.root, bg="#dcdcdc", bd=1, relief="solid")
        tab_bar.pack(fill="x", padx=4, pady=(4, 0))
        
        row1 = tk.Frame(tab_bar, bg="#dcdcdc")
        row1.pack(fill="x")
        row2 = tk.Frame(tab_bar, bg="#dcdcdc")
        row2.pack(fill="x", pady=(1, 0))

        self.tab_container = tk.Frame(self.root, bg=BG, bd=1, relief="groove")
        self.tab_container.pack(fill="both", expand=True, padx=4, pady=(0, 4))

        self.tabs = {}
        self.tab_buttons = {}
        
        tab_defs = [
            ("todoi",   "Tổ đội",    row1),
            ("lcong",   "L. công",   row1),
            ("datau",   "Dã tẩu",    row1),
            ("tuve",    "Tự vệ/PK",  row1),
            ("tich",    "T. ích",    row1),
            
            ("coban",   "Cơ bản",    row2),
            ("phuchoi", "Phục hồi",  row2),
            ("htrang",  "H. trang",  row2),
            ("chiendau","Chiến đấu", row2),
            ("dangnhap","Đ. nhập",   row2),
        ]

        for key, label, row in tab_defs:
            btn = tk.Button(row, text=label, font=FN,
                           bd=1, relief="raised",
                           bg=TAB_NOR_BG, fg=TAB_NOR_FG,
                           padx=2, pady=3, cursor="hand2",
                           command=lambda k=key: self._show_tab(k))
            btn.pack(side="left", fill="x", expand=True, padx=1)
            self.tab_buttons[key] = btn

        # Xây dựng nội dung cho từng tab từ các class
        self.t_todoi = TabToDoi(self.tab_container, self); self.tabs["todoi"] = self.t_todoi.frame
        self.t_lcong = TabLcong(self.tab_container, self); self.tabs["lcong"] = self.t_lcong.frame
        self.t_datau = TabDaTau(self.tab_container, self); self.tabs["datau"] = self.t_datau.frame
        self.t_tuve = TabTuVe(self.tab_container, self); self.tabs["tuve"] = self.t_tuve.frame
        self.t_tich = TabTienIch(self.tab_container, self); self.tabs["tich"] = self.t_tich.frame
        
        self.t_coban = TabCoBan(self.tab_container, self); self.tabs["coban"] = self.t_coban.frame
        self.t_phuchoi = TabPhucHoi(self.tab_container, self); self.tabs["phuchoi"] = self.t_phuchoi.frame
        self.t_htrang = TabHTrang(self.tab_container, self); self.tabs["htrang"] = self.t_htrang.frame
        self.t_chiendau = TabChienDau(self.tab_container, self); self.tabs["chiendau"] = self.t_chiendau.frame
        self.t_dangnhap = TabDangNhap(self.tab_container, self); self.tabs["dangnhap"] = self.t_dangnhap.frame

        self._show_tab("coban")

    def _show_tab(self, key):
        for frame in self.tabs.values():
            frame.pack_forget()
        self.tabs[key].pack(fill="both", expand=True, padx=2, pady=2)
        
        for k, btn in self.tab_buttons.items():
            if k == key:
                btn.config(bg=BG, fg="#000", bd=0, relief="flat", font=("Tahoma", 9, "bold"))
            else:
                btn.config(bg=TAB_NOR_BG, fg=TAB_NOR_FG, bd=1, relief="raised", font=FN)

    def _build_bottom_bar(self):
        footer = tk.Frame(self.root, bg="#f5f5f5", bd=1, relief="raised")
        footer.pack(side=tk.BOTTOM, fill=tk.X)
        
        link = tk.Label(footer, text="GST Auto - Hỗ trợ Võ Lâm 1 Mobile", foreground="blue", bg="#f5f5f5", cursor="hand2")
        link.pack(side=tk.BOTTOM, pady=(0,5))
        
        btn_frame = tk.Frame(footer, bg="#f5f5f5")
        btn_frame.pack(side=tk.BOTTOM, fill=tk.X, padx=4, pady=4)
        
        btns_left = ["⚙", "🔑", "📄", "⬇"]
        for txt in btns_left:
            b = tk.Button(btn_frame, text=txt, width=3, relief="raised", bg="#e0e0e0")
            b.pack(side=tk.LEFT, padx=2)
            add_hover(b, "#e0e0e0", "#d0d0d0")
            
        b_apply = tk.Button(btn_frame, text="✔ Áp dụng", font=("Tahoma", 9, "bold"), fg="green", bg="#e8f5e9", padx=8)
        b_apply.pack(side=tk.RIGHT, padx=4)
        add_hover(b_apply, "#e8f5e9", "#c8e6c9")
        
        b_exit = tk.Button(btn_frame, text="🚪 Thoát", font=FN, fg="red", bg="#ffebee", padx=8, command=self.root.quit)
        b_exit.pack(side=tk.RIGHT, padx=4)
        add_hover(b_exit, "#ffebee", "#ffcdd2")
