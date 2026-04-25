import sys, struct, subprocess, time, frida

if sys.stdout.encoding.lower() != 'utf-8':
    try: sys.stdout.reconfigure(encoding='utf-8')
    except: pass

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'

JS_WRITE = """
var nativeWrite = null;
Process.enumerateModules().forEach(function(m) {
    if (nativeWrite) return;
    try {
        var exp = m.findExportByName('write');
        if (!exp) return;
        var range = Process.findRangeByAddress(exp);
        if (range && range.protection.indexOf('x') !== -1) {
            nativeWrite = new NativeFunction(exp, 'int', ['int', 'pointer', 'int']);
        }
    } catch(e) {}
});
rpc.exports = {
    sendRaw: function(fd, hexStr) {
        if (!nativeWrite) return { ok: false };
        var n = hexStr.length / 2;
        var buf = Memory.alloc(n > 0 ? n : 1);
        for (var i = 0; i < n; i++)
            buf.add(i).writeU8(parseInt(hexStr.substr(i*2, 2), 16));
        return { ok: nativeWrite(fd, buf, n) === n };
    }
};
"""

def get_pid():
    out = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'], timeout=5).decode().strip()
    return int(out.split()[0]) if out else None

def find_game_fd(pid):
    tcp = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'cat /proc/{pid}/net/tcp'], timeout=5).decode()
    inodes = {}
    for line in tcp.split('\n')[1:]:
        p = line.split()
        if len(p) >= 10 and p[3] == '01':
            port = int(p[2].split(':')[1], 16)
            if port > 1000 and port not in (5555, 5037, 27042, 27183):
                inodes[p[9]] = port
    fd = -1
    if inodes:
        fds_out = subprocess.check_output([ADB, '-s', DEVICE_ID, 'shell', f'su -c "ls -la /proc/{pid}/fd"'], timeout=5).decode()
        for line in fds_out.split('\n'):
            if 'socket:[' not in line: continue
            inode = line.split('socket:[')[1].split(']')[0]
            if inode in inodes:
                parts = line.split()
                for j, p in enumerate(parts):
                    if p == '->' and j > 0:
                        fd = int(parts[j-1]); break
                if fd > 0: break
    return fd

def inject_packet(opcode, proto_body=b''):
    pid = get_pid()
    if not pid:
        print("[-] Game chưa mở!")
        return False
        
    fd = find_game_fd(pid)
    if fd <= 0:
        print("[-] Không tìm thấy socket FD!")
        return False

    device = next(d for d in frida.enumerate_devices() if DEVICE_ID in d.id)
    session = device.attach(pid)
    script = session.create_script(JS_WRITE)
    script.load()
    
    # Pack: [4 bytes length LE] [2 bytes opcode LE] [body]
    pkt = struct.pack('<IH', len(proto_body), opcode) + proto_body
    
    print(f"[*] Injecting Opcode {opcode} (len {len(proto_body)}) -> FD {fd}")
    res = script.exports_sync.send_raw(fd, pkt.hex())
    
    session.detach()
    return res.get('ok', False)
