// frida-scripts/core/helpers.js — Utility functions

/**
 * Convert Uint8Array to hex string (uppercase).
 * @param {Uint8Array} arr
 * @param {number} maxBytes - max bytes to convert
 * @returns {string}
 */
function toHex(arr, maxBytes) {
    var n = Math.min(arr.length, maxBytes || arr.length);
    var result = '';
    for (var i = 0; i < n; i++) {
        result += ('0' + arr[i].toString(16)).slice(-2);
    }
    return result;
}

/**
 * Parse packet header from buffer.
 * Packet format: [uint32 LE proto_len] [uint16 LE opcode] [proto body]
 * @param {Uint8Array} data
 * @returns {{ opcode: number, protoLen: number, valid: boolean }}
 */
function parsePacketHeader(data) {
    if (data.length < 6) return { opcode: -1, protoLen: -1, valid: false };
    var protoLen = data[0] | (data[1] << 8) | (data[2] << 16) | (data[3] << 24);
    var opcode = data[4] | (data[5] << 8);
    return { opcode: opcode, protoLen: protoLen, valid: opcode > 0 };
}

/**
 * Build a packet record for send/recv buffer.
 */
function makePacketRecord(data, n) {
    var hex = toHex(data, 8192);
    var hdr = parsePacketHeader(data);
    return {
        opcode: hdr.opcode,
        name: (hdr.opcode >= 0 && GS_OPCODES[hdr.opcode]) ? GS_OPCODES[hdr.opcode] : ('UNK_' + hdr.opcode),
        size: n,
        hex: hex,
        raw: hex
    };
}

/**
 * Emit a send packet from a buffer pointer + length (used by writev/sendmsg hooks).
 */
function emitFromBuf(base, n) {
    try {
        var take = n < 512 ? n : 512;
        var data = new Uint8Array(base.readByteArray(take));
        var hdr = parsePacketHeader(data);
        var name = (hdr.opcode >= 0 && GS_OPCODES[hdr.opcode]) ? GS_OPCODES[hdr.opcode] : ('UNK_' + hdr.opcode);
        var hex = toHex(data, 256);
        sendBuffer.push({ opcode: hdr.opcode, name: name, size: n, hex: hex });
        _sendTotal++;
        if (sendBuffer.length > 100) sendBuffer.shift();
        send({ type: 'send_out', opcode: hdr.opcode, name: name, size: n, hex: hex });
    } catch (e) {}
}

/**
 * Find an Il2Cpp export symbol by name.
 * Tries multiple naming conventions (+ version suffixes like _0, _1).
 */
function il2cppExport(name) {
    // 1. Find module
    var mod = Process.findModuleByName('libil2cpp.so');
    if (!mod) {
        var mods = Process.enumerateModules();
        for (var i = 0; i < mods.length; i++) {
            if ((mods[i].name && mods[i].name.indexOf('libil2cpp.so') !== -1) ||
                (mods[i].path && mods[i].path.indexOf('libil2cpp.so') !== -1)) {
                mod = mods[i];
                break;
            }
        }
    }
    if (!mod) return null;

    // 2. Try exact name (findExportByName)
    var p = mod.findExportByName(name);
    if (p) return p;

    // 3. Try with version suffixes: name_0, name_1, ...
    for (var s = 0; s < 5; s++) {
        p = mod.findExportByName(name + '_' + s);
        if (p) return p;
    }

    // 4. Try DebugSymbol
    try {
        var sym = DebugSymbol.fromName(name);
        if (sym && sym.address && !sym.address.isNull()) return sym.address;
    } catch(e) {}
    try {
        var sym2 = DebugSymbol.fromName('libil2cpp.so!' + name);
        if (sym2 && sym2.address && !sym2.address.isNull()) return sym2.address;
    } catch(e2) {}

    return null;
}

/**
 * Find a MonoBehaviour instance by class name (tries multiple namespaces).
 */
function findLoginInstance(className) {
    function tryClass(img, n) {
        try { return img.class(n); } catch (e) { return null; }
    }
    try {
        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
        var names = [className,
            'game.scene.login.' + className,
            'game.network.' + className,
            'game.ui.' + className,
            'game.scene.' + className,
            'game.' + className];
        var k = null;
        for (var i = 0; i < names.length && !k; i++) {
            k = tryClass(img, names[i]);
        }
        if (!k) return null;
        var Res = Il2Cpp.domain.assembly('UnityEngine.CoreModule').image.class('UnityEngine.Resources');
        var arr = Res.method('FindObjectsOfTypeAll', 1).invoke(k.type.object);
        if (arr && arr.length) return arr.get(0);
    } catch (e) {}
    return null;
}
