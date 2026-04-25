/**
 * hook_socket.js — VLTK1 socket hook
 *
 * Pattern game dùng: connect(ip, port) → send(binary) → recv(binary)
 * Strategy:
 *   1. Hook connect() → ghi lại IP:port của MỌI connection
 *   2. Sau khi user xác nhận port game → chỉ log fd đó
 *   3. Hook send/recv → dump binary theo fd đã lọc
 */

'use strict';

// ─── Config ───────────────────────────────────────────────
// Nếu đã biết port game, điền vào đây để lọc ngay từ đầu.
// Để 0 = log tất cả connections (mode discovery).
var FILTER_PORT = 0;

// Sau khi thấy connect log, điền IP game vào đây để lọc theo IP.
// Để "" = không lọc theo IP.
var FILTER_IP = "";

var MAX_PACKET = 65536;
// ──────────────────────────────────────────────────────────

// fd → {ip, port} cho các socket đang mở
var openSockets = {};

// fd của game socket (được xác định sau khi thấy connect đến game server)
var gameFd = -1;

// ─── Helpers ──────────────────────────────────────────────
function readSockaddr(ptr) {
    try {
        var family = Memory.readU16(ptr);
        if (family !== 2) return null; // chỉ IPv4
        var portRaw = Memory.readU16(ptr.add(2));
        var port = ((portRaw & 0xFF) << 8) | ((portRaw >> 8) & 0xFF);
        var b0 = Memory.readU8(ptr.add(4));
        var b1 = Memory.readU8(ptr.add(5));
        var b2 = Memory.readU8(ptr.add(6));
        var b3 = Memory.readU8(ptr.add(7));
        return { ip: b0+'.'+b1+'.'+b2+'.'+b3, port: port };
    } catch(e) { return null; }
}

function isGameSocket(fd) {
    if (gameFd !== -1) return fd === gameFd;  // đã biết fd chính xác
    var s = openSockets[fd];
    if (!s) return false;
    if (FILTER_PORT && s.port !== FILTER_PORT) return false;
    if (FILTER_IP   && s.ip   !== FILTER_IP)   return false;
    return true;
}

// ─── Hook: connect() ─────────────────────────────────────
// Mục đích: phát hiện game đang connect đến IP:port nào
Interceptor.attach(Module.findExportByName("libc.so", "connect"), {
    onEnter: function(args) {
        this.fd = args[0].toInt32();
        var addr = readSockaddr(args[1]);
        if (!addr) return;
        openSockets[this.fd] = addr;
    },
    onLeave: function(retval) {
        if (retval.toInt32() !== 0) return; // connect thất bại
        var s = openSockets[this.fd];
        if (!s) return;

        send({
            type: 'CONNECT',
            fd: this.fd,
            ip: s.ip,
            port: s.port,
            note: isGamePort(s.port) ? '← khả năng cao là game server' : ''
        });

        // Nếu khớp filter → đánh dấu đây là game fd
        if (FILTER_PORT && s.port === FILTER_PORT) gameFd = this.fd;
        if (FILTER_IP   && s.ip   === FILTER_IP)   gameFd = this.fd;
    }
});

// Heuristic: port phổ biến của game server Trung Quốc
function isGamePort(port) {
    var gamePorts = [
        // Port phổ biến game mobile TQ
        9000, 9001, 9002, 9003, 9004, 9005,
        10000, 10001, 10002, 10003,
        11000, 11001, 12000, 12001,
        8000, 8001, 8002, 8003,
        7000, 7001, 7002,
        // Port ít phổ biến hơn
        14000, 14001, 15000, 16000, 16888,
        19000, 19001, 20000, 21000,
    ];
    // KHÔNG phải web
    var webPorts = [80, 443, 8080, 8443, 3000, 4000, 5000];
    if (webPorts.indexOf(port) !== -1) return false;
    return gamePorts.indexOf(port) !== -1 || (port > 6000 && port < 30000);
}

// ─── Hook: close() ───────────────────────────────────────
Interceptor.attach(Module.findExportByName("libc.so", "close"), {
    onEnter: function(args) {
        var fd = args[0].toInt32();
        if (openSockets[fd]) {
            send({ type: 'CLOSE', fd: fd, remote: openSockets[fd].ip + ':' + openSockets[fd].port });
            delete openSockets[fd];
            if (gameFd === fd) gameFd = -1;
        }
    }
});

// ─── Hook: send() ────────────────────────────────────────
Interceptor.attach(Module.findExportByName("libc.so", "send"), {
    onEnter: function(args) {
        var fd  = args[0].toInt32();
        var len = args[2].toInt32();
        if (len <= 0 || len > MAX_PACKET) return;

        // Log tất cả nếu đang ở discovery mode, hoặc chỉ game fd
        if (gameFd !== -1 && fd !== gameFd) return;

        try {
            var buf = Memory.readByteArray(args[1], len);
            send({
                type: 'SEND',
                fd: fd,
                len: len,
                data: Array.from(new Uint8Array(buf)),
                remote: openSockets[fd] ? openSockets[fd].ip + ':' + openSockets[fd].port : '?',
                ts: Date.now()
            });
        } catch(e) {}
    }
});

// ─── Hook: recv() ────────────────────────────────────────
Interceptor.attach(Module.findExportByName("libc.so", "recv"), {
    onEnter: function(args) {
        this.fd  = args[0].toInt32();
        this.buf = args[1];
    },
    onLeave: function(retval) {
        var len = retval.toInt32();
        if (len <= 0 || len > MAX_PACKET) return;
        if (gameFd !== -1 && this.fd !== gameFd) return;

        try {
            var buf = Memory.readByteArray(this.buf, len);
            send({
                type: 'RECV',
                fd: this.fd,
                len: len,
                data: Array.from(new Uint8Array(buf)),
                remote: openSockets[this.fd] ? openSockets[this.fd].ip + ':' + openSockets[this.fd].port : '?',
                ts: Date.now()
            });
        } catch(e) {}
    }
});

// ─── Hook: read() / write() ─────────────────────────────
// Một số game dùng read/write thay vì recv/send trên socket fd
Interceptor.attach(Module.findExportByName("libc.so", "write"), {
    onEnter: function(args) {
        var fd  = args[0].toInt32();
        var len = args[2].toInt32();
        if (len <= 0 || len > MAX_PACKET) return;
        if (!openSockets[fd]) return; // không phải socket fd
        if (gameFd !== -1 && fd !== gameFd) return;
        try {
            var buf = Memory.readByteArray(args[1], len);
            send({ type: 'WRITE', fd: fd, len: len,
                   data: Array.from(new Uint8Array(buf)), ts: Date.now() });
        } catch(e) {}
    }
});

Interceptor.attach(Module.findExportByName("libc.so", "read"), {
    onEnter: function(args) {
        this.fd  = args[0].toInt32();
        this.buf = args[1];
        this.isSocket = !!openSockets[this.fd];
    },
    onLeave: function(retval) {
        var len = retval.toInt32();
        if (!this.isSocket || len <= 0 || len > MAX_PACKET) return;
        if (gameFd !== -1 && this.fd !== gameFd) return;
        try {
            var buf = Memory.readByteArray(this.buf, len);
            send({ type: 'READ', fd: this.fd, len: len,
                   data: Array.from(new Uint8Array(buf)), ts: Date.now() });
        } catch(e) {}
    }
});

send({ type: 'READY', msg: 'hook_socket.js loaded — waiting for connections...' });
