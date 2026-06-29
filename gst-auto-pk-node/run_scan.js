const { FridaSession } = require('./src/frida-session.js');

async function main() {
    try {
        console.log("Attaching to emulator...");
        const session = new FridaSession(null, 'vn.perfingame.jx1mobile');
        await session.connect();
        console.log("Attached!");
        
        console.log("Loading compiled scan script...");
        const scriptPath = require('path').join(__dirname, 'compiled_scan.js');
        const script = await session.loadScript(scriptPath);
        console.log("Script loaded!");
        
        session.script.message.connect((msg) => {
            if (msg.type === 'send' && msg.payload && msg.payload.type === 'scan_result') {
                console.log("\n--- NPC SCAN RESULTS ---");
                msg.payload.npcs.forEach(npc => {
                    console.log(`- ${npc.id} : ${npc.name}`);
                });
                console.log("------------------------");
                process.exit(0);
            } else if (msg.type === 'log') {
                console.log("[Frida]", msg.payload);
            }
        });
        
    } catch(e) {
        console.error("Error:", e);
        process.exit(1);
    }
}

main();
