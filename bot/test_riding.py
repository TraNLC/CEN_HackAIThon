"""
test_riding.py - Mount/dismount via Frida CModule.
CModule compile C code trực tiếp trong game process → write() luôn đúng architecture.
"""
import struct, time, subprocess, frida

ADB       = r'C:\platform-tools\adb.exe'
DEVICE_ID = 'emulator-5554'
PACKAGE   = 'vn.perfingame.jx1mobile'
GAME_FD   = 84

def build_riding_packet(mount: bool) -> bytes:
    proto  = b'\x08\x01' if mount else b''
    return struct.pack('<IH', len(proto), 58) + proto

MOUNT_PKT    = build_riding_packet(True)
DISMOUNT_PKT = build_riding_packet(False)
print(f'[*] MOUNT    : {MOUNT_PKT.hex(" ")}')
print(f'[*] DISMOUNT : {DISMOUNT_PKT.hex(" ")}')

JS = """
// Find write() that is actually in EXECUTABLE memory (x86 libc, not ARM libc)
// On Houdini, ARM libc exports are mapped non-executable from x86 side
var writePtr = null;
Process.enumerateModules().forEach(function(m) {
    if (writePtr) return;
    try {
        var exp = m.findExportByName('write');
        if (!exp) return;
        var range = Process.findRangeByAddress(exp);
        if (range && range.protection.indexOf('x') !== -1) {
            writePtr = exp;
            send({ t: 'info', msg: 'write() found in ' + m.name + ' @ ' + exp + ' (' + range.protection + ')' });
        }
    } catch(e) {}
});

if (!writePtr) {
    send({ t: 'error', msg: 'No executable write() found in any module!' });
}

var nativeWrite = writePtr ? new NativeFunction(writePtr, 'int', ['int', 'pointer', 'int']) : null;

rpc.exports = {
    hasWrite: function() { return { ok: !!nativeWrite, ptr: writePtr ? writePtr.toString() : null }; },
    sendRaw: function(fd, hexStr) {
        if (!nativeWrite) return { ok: false, err: 'write() not available' };
        var n = hexStr.length / 2;
        var buf = Memory.alloc(n > 0 ? n : 1);
        for (var i = 0; i < n; i++)
            buf.add(i).writeU8(parseInt(hexStr.substr(i*2, 2), 16));
        var sent = nativeWrite(fd, buf, n);
        return { ok: sent === n, sent: sent, len: n };
    }
};
"""

# ── Attach ───────────────────────────────────────────────────────────────────
pid_str = subprocess.check_output(
    [ADB, '-s', DEVICE_ID, 'shell', f'pidof {PACKAGE}'],
    timeout=5
).decode().strip()
pid = int(pid_str.split()[0])
print(f'[+] PID={pid}  fd={GAME_FD}')

device  = next(d for d in frida.enumerate_devices() if DEVICE_ID in d.id)
session = device.attach(pid)

def on_message(msg, _):
    if msg.get('type') == 'error':
        print(f'[JS ERROR] {msg.get("description")} @ {msg.get("fileName")}:{msg.get("lineNumber")}')
    elif msg.get('type') == 'send':
        print(f'[JS] {msg["payload"]}')

script = session.create_script(JS)
script.on('message', on_message)
script.load()
rpc = script.exports_sync
time.sleep(0.5)  # let send() messages arrive

hw = rpc.has_write()
print(f'[+] write() found: {hw}')
if not hw.get('ok'):
    print('[-] No executable write(). Cannot send packets on this Houdini setup.')
    session.detach(); exit(1)

# ── Test ─────────────────────────────────────────────────────────────────────
print('\n[>] Sending MOUNT...')
r = rpc.send_raw(GAME_FD, MOUNT_PKT.hex())
print(f'    {r}')

time.sleep(3)

print('[>] Sending DISMOUNT...')
r = rpc.send_raw(GAME_FD, DISMOUNT_PKT.hex())
print(f'    {r}')

print('\n[*] Done. Check in-game.')
session.detach()
