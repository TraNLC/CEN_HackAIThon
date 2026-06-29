const fs = require('fs');
const { FridaSession } = require('./src/frida-session');

async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');

    console.log("Reading bridge code...");
    const bridgeCode = fs.readFileSync('../GSTAuto_PK_Windows/vendor/il2cpp-bridge.js', 'utf8');
    
    console.log("Creating script...");
    const source = `
        ${bridgeCode}
        
        setTimeout(() => {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function() {
                    try {
                        var pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
                        
                        var names = ['nearNpcs', 'm_nearNpcs', 'NearNpcs', 'NpcRes', '_nearNpcs'];
                        for (var i = 0; i < names.length; i++) {
                            try {
                                var f = pmClass.field(names[i]);
                                if (f) {
                                    send("Found field: " + names[i] + " at offset 0x" + f.offset.toString(16));
                                }
                            } catch(e) {}
                        }
                        
                        send("DONE SCANNING");
                    } catch(e) {
                        send("Main err: " + e.message);
                    }
                });
            } else {
                send("Il2Cpp not found");
            }
        }, 1000);
    `;
    const script = await session.session.createScript(source);
    script.message.connect((msg) => { 
        if (msg.type === 'send') console.log(msg.payload);
        else console.log(msg);
    });
    await script.load();
    await new Promise(r => setTimeout(r, 4000));
    process.exit(0);
}
run();
