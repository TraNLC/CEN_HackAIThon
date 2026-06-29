const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

async function main() {
    const session = new FridaSession(null, config.GAME_PACKAGE);
    const connected = await session.connect();
    if (!connected) return;

    await session.loadScript(path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js'));

    const source = `
    rpc.exports.testPlayerMain = function() {
        return Il2Cpp.perform(() => {
            var pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
            var inst = pmClass.field('instance').value;
            return inst ? inst.handle.toString() : 'null';
        });
    };
    `;
    const tempScript = await session.session.createScript(source);
    await tempScript.load();
    const result = await tempScript.exports.testPlayerMain();
    console.log('[+] PlayerMain instance:', result);
    
    await session.disconnect();
}
main();
