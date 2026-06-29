const { FridaSession } = require('./src/frida-session');

async function run() {
    const session = new FridaSession('emulator-5554');
    await session.connect('vn.perfingame.jx1mobile');
    const scriptStr = `
        (function() {
            var count = 0;
            function getIl2CppBase() {
                var mod = Process.findModuleByName('libil2cpp.so');
                if (mod) return mod.base;
                var base = null;
                var lines = File.readAllText('/proc/self/maps').split('\\n');
                for (var i = 0; i < lines.length; i++) {
                    var line = lines[i];
                    if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
                        var parts = line.trim().split(/\\s+/);
                        base = ptr('0x' + parts[0].split('-')[0]);
                        break;
                    }
                }
                return base;
            }
            var base = getIl2CppBase();
            if (!base) {
                send("libil2cpp.so base not found!");
                return;
            }
            send("Base found: " + base);
            var target = base.add(0x2DEBCC4); // World.Update
            
            var callCount = 0;
            setInterval(function() {
                send({ type: 'stats', count: callCount });
            }, 2000);
            
            Interceptor.attach(target, {
                onEnter: function(args) {
                    callCount++;
                }
            });
            send("Listening for World.Update for 10 seconds...");
        })();
    `;
    const script = await session.session.createScript(scriptStr);
    
    script.message.connect((msg) => { 
        if (msg.type === 'send') {
            if (msg.payload.type === 'stats') {
                console.log("World.Update called", msg.payload.count, "times so far...");
            } else {
                console.log(msg.payload);
            }
        }
    });
    
    await script.load();
    await new Promise(r => setTimeout(r, 10000));
    console.log("Done.");
    process.exit(0);
}
run();
