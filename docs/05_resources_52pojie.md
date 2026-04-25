# Tài Nguyên — Cộng Đồng RE Trung Quốc

## 52pojie (吾爱破解) — www.52pojie.cn

### Tổng quan

- **Miễn phí hoàn toàn** — đăng ký tài khoản, đọc và tải resource không mất phí
- **Ngôn ngữ:** Tiếng Trung 100%. Không có bản dịch chính thức
- **Giải quyết rào cản ngôn ngữ:**
  - Google Translate hoặc DeepL dịch tốt (giao diện forum chuẩn)
  - Nhiều bài có ảnh chụp màn hình + code → hiểu được dù dịch không hoàn hảo
  - Tìm keyword tiếng Anh cũng ra kết quả (vd: `frida android hook`)

### Sections hữu ích nhất

| Section | Tiếng Trung | Nội dung |
|---------|-------------|---------|
| 软件分析 | Software Analysis | RE writeups, packet analysis, game protocol |
| 安卓逆向 | Android Reverse | Frida, APK, Smali, DEX hooks |
| 工具分析 | Tool Analysis | Public tools kèm source code |
| 病毒分析 | Malware Analysis | (không liên quan nhưng có kỹ thuật RE hay) |

---

## Tìm kiếm VLTK / Snail Engine trên 52pojie

### Keywords tiếng Trung cho game VLTK

**VLTK = Võ Lâm Truyền Kỳ = 武林传奇 (Wǔlín Chuánqí)**

Nhưng ở Trung Quốc, game cùng Snail engine phổ biến hơn là:

```
大唐无双    Đại Đường Vô Song (Da Tang Wu Shuang)
天龙八部    Thiên Long Bát Bộ (Tian Long Ba Bu)
武林传奇    Võ Lâm Truyền Kỳ
征途       Chinh Đồ
```

Search các từ này trên 52pojie sẽ ra nhiều kết quả RE chi tiết hơn search tiếng Anh vì đây là game gốc TQ.

### Keyword tìm kiếm hiệu quả

```
# Tìm opcode RE writeup
大唐无双 封包分析
大唐无双 opcode
天龙八部 协议分析
天龙八部 抓包

# Tìm Frida hook game
安卓游戏 frida hook 封包
游戏封包 frida interceptor

# Tìm session replay / bot
游戏封包 自动化
封包 重放攻击
```

### Thuật ngữ kỹ thuật hay gặp

| Tiếng Trung | Pinyin | Nghĩa |
|-------------|--------|-------|
| 封包 | fēng bāo | Packet |
| 抓包 | zhuā bāo | Capture packet |
| 协议分析 | xiéyì fēnxī | Protocol analysis |
| 逆向 | nì xiàng | Reverse engineering |
| 脱壳 | tuō ké | Unpack / remove packer |
| 加密 | jiā mì | Encryption |
| 解密 | jiě mì | Decryption |
| 注入 | zhù rù | Injection |
| Hook | (same) | Hook |
| 外挂 | wài guà | Cheat / bot |
| 自动化 | zì dòng huà | Automation |
| 模拟器 | mónǐqì | Emulator |

---

## 看雪安全论坛 (Kanxue) — bbs.kanxue.com

- Tương tự 52pojie nhưng **focus bảo mật hơn**
- Nhiều bài RE chuyên sâu về mobile game
- Sections hay: `Android安全`, `软件逆向`
- Cũng miễn phí, cũng tiếng Trung

---

## Tài nguyên tiếng Anh

### GameGuardian Forum — gameguardian.net/forum

- **Tiếng Anh**, focus mobile game hacking
- Memory patching + packet hook
- Nhiều tutorial Android game cụ thể

### UnknownCheats — unknowncheats.me

- **Tiếng Anh**, lớn nhất cho PC game cheats
- Section `Mobile Game Hacking` ngày càng lớn
- Search `MMORPG packet hook android` sẽ ra kết quả

### GitHub keywords

```
frida android mmorpg packet
android game packet hook python
snail engine opcode
cocos2dx packet hook
```

---

## Tools Trung Quốc phổ biến (public/free)

### Jadx-GUI
- Decompile APK → Java source
- Download: `github.com/skylot/jadx`
- Dùng để tìm: NetworkManager, PacketHandler, SocketClient class names

### GDA (GJoy Dex Analyzer)
- Decompiler thay thế jadx, một số trường hợp decode tốt hơn
- `github.com/charles2gan/GDA-android-reversing-Tool`

### unidbg
- Emulate Android .so trên PC (không cần thiết bị)
- Dùng khi cần gọi hàm encrypt/decrypt mà không có key rõ
- `github.com/zhkl0228/unidbg`
- **Nhiều writeup TQ** về dùng unidbg để bypass game crypto

### MT Manager (Android)
- File manager + APK editor trên Android
- Chỉnh sửa .smali trực tiếp trên thiết bị
- Tải từ store TQ hoặc 52pojie

### Il2CppDumper
- Dump C# class/method names từ Unity IL2CPP binary
- `github.com/Perfare/Il2CppDumper`
- Output: `script.py` dùng được với Frida

---

## Workflow research khi bí

```
1. Biết game dùng engine gì (detect_engine.py)
2. Search 52pojie: "<tên game TQ tương đương> 封包分析"
3. Nếu không ra: search "<engine name> android hook frida"
4. Tìm trên kanxue.com với keywords tương tự
5. GitHub search: "frida <engine> packet"
6. UnknownCheats / GameGuardian forum (tiếng Anh)
```

---

## Lưu ý pháp lý

RE packet để build bot vi phạm Terms of Service của game.  
Toolkit này mục đích học tập kỹ thuật (Frida instrumentation, binary protocol RE).  
Sử dụng trên tài khoản cá nhân với trách nhiệm của người dùng.
