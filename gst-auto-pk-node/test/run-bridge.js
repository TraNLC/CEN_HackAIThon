const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    frida.onMessage(m => {
        if (m.type === 'result') {
            console.log("\n=== FINAL RESULT ===");
            console.log(JSON.stringify(m.data, null, 2));
            process.exit(0);
        } else if (m.log) {
            console.log(m.log);
        } else {
            console.log(m);
        }
    });

    console.log("Loading frida-il2cpp-bridge script...");
    await frida.loadScript('test/test-bag-il2cpp-bundle.js');
}

run().catch(console.error);
