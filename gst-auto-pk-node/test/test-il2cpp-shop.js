const { FridaSession } = require('../src/frida-session');
const config = require('../config');

const FRIDA_SCRIPT = `
const baseAddr = Module.findBaseAddress('libil2cpp.so');
if (baseAddr) {
    // PlayerStallOpenResponsePackage.Process
    const stallOpenProcessPtr = baseAddr.add(0xF78AE8);
    Interceptor.attach(stallOpenProcessPtr, {
        onEnter: function(args) {
            send({type: 'shop_debug', msg: 'PlayerStallOpenResponsePackage.Process called!'});
        }
    });

    // game.ui.PlayerOtherStall.ProtocolPlayerStallOpenResponse
    const protocolPlayerStallOpenResponsePtr = baseAddr.add(0xE8C7D0);
    Interceptor.attach(protocolPlayerStallOpenResponsePtr, {
        onEnter: function(args) {
            send({type: 'shop_debug', msg: 'PlayerOtherStall.ProtocolPlayerStallOpenResponse called!'});
        }
    });
}
`;

async function run() {
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log('Hooking into il2cpp PlayerOtherStall.ReadStallDetailInfo directly... PLEASE OPEN A SHOP NOW');
    const s2 = await frida.session.createScript(FRIDA_SCRIPT);
    await s2.load();
    
    frida.onMessage(m => {
        if (m) console.log(m);
    });

    // setTimeout(() => frida.disconnect(), 60000); // Removed timeout
}

run();
