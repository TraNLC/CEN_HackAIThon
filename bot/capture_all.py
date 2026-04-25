"""
capture_all.py - Hook send/sendmsg/write on ALL fds (no dedup, no filter) to find mount packet.
"""
import frida
import time
import sys
import subprocess

JS = r"""
'use strict';

var libc = null;
var names = ['libc.so', 'libc.so.6', 'libbionic.so'];
for (var i = 0; i < names.length; i++) {
    var m = Process.findModuleByName(names[i]);
    if (m) { libc = m; break; }
}

function findExp(name) {
    if (!libc) return null;
    var exps = libc.enumerateExports();
    for (var i = 0; i < exps.length; i++) {
        if (exps[i].name === name) return exps[i].address;
    }
    return null;
}

function toHex(ptr, len) {
    if (len <= 0 || len > 4096) return '';
    try {
        var b = new Uint8Array(ptr.readByteArray(len));
        return Array.from(b).map(function(x){ return ('0'+x.toString(16)).slice(-2); }).join('');
    } catch(e) { return ''; }
}

// Hook write - fd=84 only
var writeAddr = findExp('write');
if (writeAddr) {
    Interceptor.attach(writeAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            this.buf = a[1];
            this.len = a[2].toInt32();
        },
        onLeave: function(r) {
            if (this.fd !== 84 && this.fd !== 42) return;
            var ret = r.toInt32();
            if (ret <= 0 || this.len <= 0 || this.len > 4096) return;
            var hex = toHex(this.buf, Math.min(this.len, 128));
            send({ t: 'WRITE', fd: this.fd, len: this.len, hex: hex });
        }
    });
}

// Hook send
var sendAddr = findExp('send');
if (sendAddr) {
    Interceptor.attach(sendAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            this.buf = a[1];
            this.len = a[2].toInt32();
        },
        onLeave: function(r) {
            if (this.fd !== 84 && this.fd !== 42) return;
            var ret = r.toInt32();
            if (ret <= 0 || this.len <= 0 || this.len > 4096) return;
            var hex = toHex(this.buf, Math.min(this.len, 128));
            send({ t: 'SEND', fd: this.fd, len: this.len, hex: hex });
        }
    });
}

// Hook sendto
var sendtoAddr = findExp('sendto');
if (sendtoAddr) {
    Interceptor.attach(sendtoAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            this.buf = a[1];
            this.len = a[2].toInt32();
        },
        onLeave: function(r) {
            if (this.fd !== 84 && this.fd !== 42) return;
            var ret = r.toInt32();
            if (ret <= 0 || this.len <= 0 || this.len > 4096) return;
            var hex = toHex(this.buf, Math.min(this.len, 128));
            send({ t: 'SENDTO', fd: this.fd, len: this.len, hex: hex });
        }
    });
}

// Hook sendmsg - important! some games use this
var sendmsgAddr = findExp('sendmsg');
if (sendmsgAddr) {
    Interceptor.attach(sendmsgAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            // msghdr: msg_iov at offset 8, msg_iovlen at offset 12 (32-bit)
            try {
                var msghdr = a[1];
                var iov = msghdr.add(8).readPointer();
                var iovlen = msghdr.add(12).readU32();
                if (iovlen > 0) {
                    var buf = iov.readPointer();
                    var len = iov.add(4).readU32();
                    this.hex = toHex(buf, Math.min(len, 128));
                    this.len = len;
                }
            } catch(e) { this.len = 0; }
        },
        onLeave: function(r) {
            if (this.fd !== 84 && this.fd !== 42) return;
            var ret = r.toInt32();
            if (ret <= 0 || !this.len) return;
            send({ t: 'SENDMSG', fd: this.fd, len: this.len, hex: this.hex || '' });
        }
    });
}

// Also hook recv to see server responses
var recvAddr = findExp('recv');
if (recvAddr) {
    Interceptor.attach(recvAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            this.buf = a[1];
        },
        onLeave: function(r) {
            if (this.fd !== 84) return;
            var n = r.toInt32();
            if (n <= 0) return;
            var hex = toHex(this.buf, Math.min(n, 64));
            send({ t: 'RECV', fd: this.fd, len: n, hex: hex });
        }
    });
}
var readAddr = findExp('read');
if (readAddr) {
    Interceptor.attach(readAddr, {
        onEnter: function(a) {
            this.fd = a[0].toInt32();
            this.buf = a[1];
        },
        onLeave: function(r) {
            if (this.fd !== 84) return;
            var n = r.toInt32();
            if (n <= 0) return;
            var hex = toHex(this.buf, Math.min(n, 64));
            send({ t: 'READ', fd: this.fd, len: n, hex: hex });
        }
    });
}

send({ t: 'READY', send: !!sendAddr, sendmsg: !!sendmsgAddr, write: !!writeAddr });
"""

packets = []

def on_message(msg, data):
    if msg['type'] != 'send':
        return
    p = msg['payload']
    if p.get('t') == 'READY':
        print(f"[*] Hooks: send={p['send']} sendmsg={p['sendmsg']} write={p['write']}")
        return
    fd = p.get('fd')
    size = p.get('len')
    hex_str = p.get('hex', '')
    typ = p.get('t', '?')
    line = f"[{typ}] fd={fd} size={size} | {hex_str}"
    print(line, flush=True)
    packets.append(line)

device = None
for d in frida.enumerate_devices():
    if 'emulator' in d.id.lower() or '5554' in d.id:
        device = d
        break

pid_str = subprocess.check_output(
    r'C:\platform-tools\adb.exe -s emulator-5554 shell "pidof vn.perfingame.jx1mobile"',
    shell=True
).decode().strip()
pid = int(pid_str.split()[0])
print(f"[*] Attaching to PID {pid} (game fd=84)...")

session = device.attach(pid)
script = session.create_script(JS)
script.on('message', on_message)
script.load()

print("[*] NOW: press MOUNT or DISMOUNT in game. Capturing 30s...")
print("    Also watching for server responses on fd=84...\n", flush=True)

time.sleep(30)
session.detach()

print(f"\n[*] Total packets: {len(packets)}")
send_84 = [p for p in packets if 'fd=84' in p and '[SEND' in p or '[WRITE' in p and 'fd=84' in p]
recv_84 = [p for p in packets if 'fd=84' in p and ('[RECV' in p or '[READ' in p)]
print(f"    Sent to fd=84: {len(send_84)}")
print(f"    Recv from fd=84: {len(recv_84)}")
