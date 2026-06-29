// frida-scripts/ready.js — Ready signal: notify host that all hooks are installed

(function sendReadySignal() {
    send({
        type: 'ready',
        hooks: {
            connect: true,
            recv: true,
            send: true,
            nativeRead: !!nativeReadPtr,
            readSource: readSource,
            nativeWrite: !!nativeWritePtr,
            writeSource: writeSource,
        },
        ssl: {
            readOk: _sslReadOk,
            writeOk: _sslWriteOk,
            writeFn: !!_sslWriteFn,
            sslObj: _sslObj ? _sslObj.toString() : null,
        }
    });
})();
