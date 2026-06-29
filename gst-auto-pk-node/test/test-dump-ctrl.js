const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log("Dumping Controller fields...");

    const scriptCode = `
        try {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function () {
                    try {
                        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
                        var pmClass = img.class('PlayerMain');
                        var inst = pmClass.field('instance').value;
                        if (!inst || inst.isNull()) {
                            send({ type: 'error', msg: 'PlayerMain.instance is null' });
                            return;
                        }
                        
                        var npc = null;
                        try { npc = inst.field("npcontroller").value; } catch (e) {
                            try { npc = inst.field("m_npcontroller").value; } catch (e2) {}
                        }
                        
                        if (!npc) {
                            send({ type: 'error', msg: 'No npcontroller' });
                            return;
                        }
                        
                        var fields = npc.class.fields;
                        var foundFields = [];
                        for(var i=0; i<fields.length; i++) {
                            foundFields.push(fields[i].name + " (" + fields[i].type.name + ")");
                        }
                        send({ type: 'result', data: foundFields });
                        
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
    fs.writeFileSync('test/temp-dump-ctrl.js', scriptCode);
    
    frida.onMessage(m => {
        if (m.type === 'result') {
            console.log("\\n=== CONTROLLER FIELDS ===");
            console.log(JSON.stringify(m.data, null, 2));
            process.exit(0);
        } else if (m.type === 'log') {
            console.log("[Log] " + m.log);
        } else if (m.type === 'error') {
            console.error("[Error] " + m.msg);
            process.exit(1);
        }
    });

    // Load bundle first to get Il2Cpp bridge
    await frida.loadScript('frida-scripts/bot.bundle.js');
    await frida.loadScript('test/temp-dump-ctrl.js');
}

run().catch(console.error);
