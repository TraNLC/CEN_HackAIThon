const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log("Dumping class names containing Bag, Item, Inventory...");

    const scriptCode = `
        try {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function () {
                    send({ type: 'log', msg: 'Il2Cpp is available' });
                    try {
                        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
                        var classes = img.classes;
                        var found = [];
                        for (var i = 0; i < classes.length; i++) {
                            var name = classes[i].name;
                            var lower = name.toLowerCase();
                            if (lower.indexOf('bag') !== -1 || 
                                lower.indexOf('inventory') !== -1 || 
                                lower.indexOf('item') !== -1 ||
                                lower.indexOf('storage') !== -1 ||
                                lower.indexOf('ruong') !== -1) {
                                found.push(name);
                            }
                        }
                        send({ type: 'result', data: found });
                    } catch(e) {
                        send({ type: 'error', msg: e.message });
                    }
                });
            } else {
                send({ type: 'error', msg: 'No Il2Cpp' });
            }
        } catch(e) {
            send({ type: 'error', msg: e.message });
        }
    `;
    
    const fs = require('fs');
    fs.writeFileSync('test/temp-dump-classes.js', scriptCode);
    
    frida.onMessage(m => {
        if (m.type === 'result') {
            console.log("\\n=== FOUND CLASSES ===");
            console.log(m.data.join(', '));
            process.exit(0);
        } else if (m.type === 'log') {
            console.log("[Log] " + m.log);
        } else if (m.type === 'error') {
            console.error("[Error] " + m.msg);
            process.exit(1);
        }
    });

    // We must load bot.bundle.js first if we want Il2Cpp bridge, wait, does frida-session load il2cpp bridge?
    // No, we need to load the bridge script or bundle.
    await frida.loadScript('frida-scripts/bot.bundle.js');
    await frida.loadScript('test/temp-dump-classes.js');
}

run().catch(console.error);
