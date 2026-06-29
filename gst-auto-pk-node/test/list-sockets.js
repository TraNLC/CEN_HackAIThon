const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const fs = require('fs');

async function run() {
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    fs.writeFileSync('test/temp-sockets.js', `
        var res = [];
        for(var i=0; i<200; i++) {
            try {
                var type = Socket.type(i);
                if (type === 'tcp' || type === 'tcp6') {
                    var peer = Socket.peerAddress(i);
                    res.push({ fd: i, type: type, peer: peer });
                }
            } catch(e){}
        }
        send({ type: 'sockets', data: res });
    `);
    
    frida.onMessage(m => {
        if (m.type === 'sockets') {
            console.log('TCP Sockets:', m.data);
            process.exit(0);
        }
    });

    await frida.loadScript('test/temp-sockets.js');
}

run().catch(console.error);
