const { FridaSession } = require('./src/frida-session');
async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');
    const source = `
        setTimeout(() => {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function() {
                    try {
                        var npcClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('NpcRes.Normal');
                        if (npcClass) {
                            send("Fields: " + npcClass.fields.map(f => f.name + " (" + f.type.name + ")").join(', '));
                        } else {
                            send("NpcRes.Normal not found");
                        }
                    } catch(e) {
                        send("Error: " + e.message);
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
    await session.loadScript('frida-scripts/bot.bundle.js');
    await new Promise(r => setTimeout(r, 4000));
    process.exit(0);
}
run();
