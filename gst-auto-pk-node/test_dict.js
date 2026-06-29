const fs = require('fs');
const { FridaSession } = require('./src/frida-session');
async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');
    const bridgeCode = fs.readFileSync('../../GSTAuto_PK_Windows/vendor/il2cpp-bridge.js', 'utf8');
    const source = `
        ${bridgeCode}
        setTimeout(() => {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function() {
                    try {
                        var pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
                        var getNearNpcs = pmClass.method('GetNearNpcs');
                        var inst = pmClass.field('instance').value;
                        var dict = getNearNpcs.invoke(inst);
                        if (!dict || dict.isNull()) send("dict is null");
                        else {
                            send(dict.class.methods.map(m => m.name).join(', '));
                            var toArray = dict.class.method('ToArray');
                            send("Has ToArray? " + !!toArray);
                        }
                    } catch(e) {
                        send(e.message);
                    }
                });
            } else {
                send("Il2Cpp not found");
            }
        }, 1000);
    `;
    const script = await session.session.createScript(source);
    script.message.connect((msg) => { console.log(msg.payload); });
    await script.load();
    await new Promise(r => setTimeout(r, 4000));
    process.exit(0);
}
run();
