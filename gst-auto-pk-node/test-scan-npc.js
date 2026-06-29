const { FridaSession } = require('./src/frida-session.js');

async function main() {
    try {
        console.log("Attaching to emulator...");
        const session = new FridaSession(null, 'vn.perfingame.jx1mobile');
        await session.connect();
        console.log("Attached!");
        
        console.log("Loading script...");
        const scriptPath = require('path').join(__dirname, 'frida-scripts', 'bot.bundle.js');
        await session.loadScript(scriptPath);
        console.log("Script loaded!");
        
        console.log("Waiting 5s for Controller.Update hooks...");
        await new Promise(r => setTimeout(r, 5000));
        
        const res = await session.callRpc('getNearNpcsDetail');
        console.log("Result:", JSON.stringify(res, null, 2));
        
        console.log("Done.");
        process.exit(0);
    } catch(e) {
        console.error("Error:", e);
        process.exit(1);
    }
}

main();
