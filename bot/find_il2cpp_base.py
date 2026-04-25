"""
find_il2cpp_base.py - Read /proc/maps to find libil2cpp.so base address in Houdini.
Then hook SyncSwitchHorse and SendGSMessage at ARM offset via Frida ptr().
"""
import frida, subprocess, time

JS = r"""
// Read /proc/self/maps to find ARM libil2cpp.so base address
var mapsContent = '';
try {
    var f = new File('/proc/self/maps', 'r');
    mapsContent = f.readText();
    f.close();
} catch(e) {
    send({ t: 'error', msg: 'Cannot read maps: ' + e });
}

// Parse for libil2cpp.so lines
var lines = mapsContent.split('\n');
var il2cppRanges = [];
for (var i = 0; i < lines.length; i++) {
    var line = lines[i];
    if (line.indexOf('libil2cpp.so') >= 0) {
        il2cppRanges.push(line);
    }
}

send({ t: 'maps', count: il2cppRanges.length, lines: il2cppRanges.slice(0, 10) });

// Find the executable (r-xp) segment base
var il2cppBase = null;
for (var i = 0; i < il2cppRanges.length; i++) {
    var parts = il2cppRanges[i].split(' ');
    var perms = parts[1];
    if (perms && perms.indexOf('x') >= 0) {
        var addrRange = parts[0].split('-');
        il2cppBase = ptr('0x' + addrRange[0]);
        break;
    }
}

if (il2cppBase) {
    send({ t: 'base', base: il2cppBase.toString(), msg: 'Found il2cpp base!' });

    // Now hook SyncSwitchHorse at base + RVA 0x704D08
    // and SendGSMessage(Id, IMessage) at base + 0x8FFC4C
    var SYNC_SWITCH_HORSE   = 0x704D08;
    var SEND_GS_MSG_IDMSG   = 0x8FFC4C;
    var PLAYER_SWITCH_HORSE = 0x704CDC;

    try {
        Interceptor.attach(il2cppBase.add(PLAYER_SWITCH_HORSE), {
            onEnter: function(args) {
                send({ t: 'event', name: 'PlayerSwitchHorse' });
            }
        });
        send({ t: 'hook_ok', name: 'PlayerSwitchHorse' });
    } catch(e) {
        send({ t: 'hook_fail', name: 'PlayerSwitchHorse', err: e.toString() });
    }

    try {
        Interceptor.attach(il2cppBase.add(SYNC_SWITCH_HORSE), {
            onEnter: function(args) {
                // r0=this, r1=bool isUseHorse (ARM32 calling conv)
                var isUseHorse = args[1].toInt32();
                send({ t: 'event', name: 'SyncSwitchHorse', isUseHorse: isUseHorse });
            }
        });
        send({ t: 'hook_ok', name: 'SyncSwitchHorse' });
    } catch(e) {
        send({ t: 'hook_fail', name: 'SyncSwitchHorse', err: e.toString() });
    }

    try {
        Interceptor.attach(il2cppBase.add(SEND_GS_MSG_IDMSG), {
            onEnter: function(args) {
                // ARM32: r0=this, r1=Id(int), r2=IMessage*
                var id = args[1].toInt32();
                var GS_NAMES = {
                    58: 'eSetRiding', 69: 'ePing', 132: 'eChatSend',
                    248: 'eGotoPosition', 231: 'eGotoNpc', 20: 'eSyncPlayerMove',
                    49: 'ePlayerUserItem', 56: 'eObjectPickup'
                };
                var name = GS_NAMES[id] || ('ID_' + id);
                send({ t: 'send_gs', id: id, name: name });
            }
        });
        send({ t: 'hook_ok', name: 'SendGSMessage(Id,IMessage)' });
    } catch(e) {
        send({ t: 'hook_fail', name: 'SendGSMessage', err: e.toString() });
    }

} else {
    send({ t: 'base', base: null, msg: 'libil2cpp.so NOT found in /proc/maps - Houdini hides it' });
    // Send all map lines for debug
    send({ t: 'all_maps_sample', lines: lines.slice(0, 50) });
}
"""

def on_message(msg, data):
    if msg['type'] != 'send':
        return
    p = msg['payload']
    t = p.get('t')
    if t == 'maps':
        print(f"[*] libil2cpp.so in /proc/maps: {p['count']} segments")
        for l in p.get('lines', []):
            print(f"    {l}")
    elif t == 'base':
        print(f"[+] {p['msg']} base={p['base']}")
    elif t == 'hook_ok':
        print(f"[+] Hook OK: {p['name']}")
    elif t == 'hook_fail':
        print(f"[-] Hook FAIL: {p['name']}: {p['err']}")
    elif t == 'event':
        print(f"\n>>> IL2CPP EVENT: {p}")
    elif t == 'send_gs':
        print(f"\n>>> SendGSMessage id={p['id']} ({p['name']})")
    elif t == 'error':
        print(f"[-] {p['msg']}")
    elif t == 'all_maps_sample':
        print("[*] /proc/maps sample (first 50 lines):")
        for l in p.get('lines', []):
            if l.strip():
                print(f"    {l}")
    else:
        print(f"[?] {p}")

pid_str = subprocess.check_output(
    r'C:\platform-tools\adb.exe -s emulator-5554 shell "pidof vn.perfingame.jx1mobile"',
    shell=True
).decode().strip()
pid = int(pid_str.split()[0])
print(f"[*] Attaching to PID {pid}...")

device = None
for d in frida.enumerate_devices():
    if 'emulator' in d.id or '5554' in d.id:
        device = d; break

session = device.attach(pid)
script = session.create_script(JS)
script.on('message', on_message)
script.load()

print("[*] Hooks installed. Now press mount/dismount in game (30s)...")
time.sleep(30)
session.detach()
print("[*] Done.")
