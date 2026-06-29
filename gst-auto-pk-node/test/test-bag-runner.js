const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log("Loading bundle...");
    
    frida.onMessage(m => {
        if (m.type === 'log') {
            console.log("[Log] " + m.msg);
        } else {
            console.log(m);
        }
    });

    await frida.loadScript('test/test-bag-il2cpp-bundle.js');
}

run().catch(console.error);
