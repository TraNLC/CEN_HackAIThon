const { FridaSession } = require('./src/frida-session');
async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');
    const source = `
        setTimeout(() => {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function() {
                    try {
                        var pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
                        var getNearNpcs = pmClass.method('GetNearNpcs');
                        var inst = pmClass.field('instance').value;
                        var dict = getNearNpcs.invoke(inst);
                        if (!dict || dict.isNull()) {
                            send("dict is null");
                            return;
                        }
                        try {
                            var entries = dict.field('entries').value;
                            var count = dict.field('count').value;
                            var ids = [];
                            for(var i=0; i<count; i++) {
                                var entry = entries.get(i); // This is a struct? Or we might need to read raw
                                ids.push(entry.toString());
                            }
                            send("Ids: " + ids.join(', '));
                        } catch(e) {
                            send("Entries read failed: " + e.message);
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
    await session.loadScript('frida-scripts/bot.bundle.js');
    await new Promise(r => setTimeout(r, 4000));
    process.exit(0);
}
run();
