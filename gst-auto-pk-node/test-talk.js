const { FridaSession } = require('./src/frida-session.js');

async function main() {
    try {
        console.log("Attaching to emulator-5554...");
        const session = new FridaSession('emulator-5554', 'com.vng.vltkm');
        await session.connect();
        console.log("Attached!");
        
        console.log("Loading script...");
        const scriptPath = require('path').join(__dirname, 'frida-scripts', 'bot.bundle.js');
        await session.loadScript(scriptPath);
        console.log("Script loaded!");
        
        console.log("Calling getPlayerInfo...");
        const info = await session.callRpc('getPlayerInfo');
        console.log("Info:", info);
        
        console.log("Calling remoteNpcDialogue(2581)...");
        session.script.message.connect((msg) => {
            console.log("Frida Message:", msg);
        });
        
        const res = await session.callRpc('remoteNpcDialogue', 2581);
        console.log("Result:", res);
        
        console.log("Done.");
        process.exit(0);
    } catch(e) {
        console.error("Error:", e);
        process.exit(1);
    }
}

main();
