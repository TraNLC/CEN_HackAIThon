const { FridaSession } = require('./src/frida-session');

async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');

    // First load bot.bundle.js which provides Il2Cpp
    await session.loadScript('frida-scripts/bot.bundle.js');
    console.log("Waiting 2s for Il2Cpp init...");
    await new Promise(r => setTimeout(r, 2000));

    const source = `
        Il2Cpp.perform(function() {
            try {
                var pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
                var inst = pmClass.field('instance').value;
                var getNearNpcs = pmClass.method('GetNearNpcs');
                var dict = getNearNpcs.invoke(inst);
                
                if (!dict || dict.isNull()) {
                    send("Dict is null");
                    return;
                }
                
                var clsName = dict.class.name;
                send("Dict class: " + clsName);
                
                var entries = dict.field('entries').value;
                var count = dict.field('count').value;
                var ids = [];
                for(var i=0; i<count; i++) {
                    try {
                        var entry = entries.get(i);
                        var val = entry.field('value').value;
                        if(val && !val.isNull()) {
                            var data = val.field('data').value;
                            if(data && !data.isNull()) {
                                var npcid = data.field('id').value;
                                
                                var nameStr = "";
                                var nv = data.field('name').value;
                                if (nv) {
                                    if (typeof nv.content !== 'undefined' && nv.content !== null) {
                                        nameStr = nv.content;
                                    } else {
                                        var ptr = nv.handle ? nv.handle : new NativePointer(nv);
                                        if (!ptr.isNull()) {
                                            var len = ptr.add(0x10).readS32();
                                            if (len > 0 && len < 100) nameStr = ptr.add(0x14).readUtf16String(len);
                                        }
                                    }
                                }
                                ids.push(npcid + ":" + nameStr);
                            }
                        }
                    } catch(ex) { ids.push("Err:" + ex.message); }
                }
                send({ids: ids});
            } catch(e) {
                send("Main err: " + e.message);
            }
        });
    `;
    const script = await session.session.createScript(source);
    script.message.connect((msg) => { 
        if (msg.type === 'send') console.log(msg.payload);
        else console.log(msg);
    });
    await script.load();
    await new Promise(r => setTimeout(r, 2000));
    process.exit(0);
}
run();
