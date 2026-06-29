const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

async function main() {
    const session = new FridaSession(null, config.GAME_PACKAGE);
    console.log('[*] Connecting to game...');
    const connected = await session.connect();
    if (!connected) {
        console.log('[-] Failed to connect.');
        return;
    }

    const scriptPath = path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js');
    console.log(`[*] Loading script: ${scriptPath}`);
    await session.loadScript(scriptPath);
    console.log('[+] Script loaded successfully.\n');

    console.log('[*] Testing getMySect...');
    const sectStr = await session.callRpc('getMySect');
    console.log('[+] getMySect result:', sectStr);

    console.log('[*] Fetching nearby NPCs...');
    const res = await session.callRpc('getNearNpcsDetail');
    if (!res.ok) {
        console.log('[-] getNearNpcsDetail failed:', res.error);
        process.exit(1);
    }

    if (res.npcs && res.npcs.length > 0) {
        console.log(`[+] Found ${res.npcs.length} NPCs.`);
        const targetNpc = res.npcs[0];
        console.log(`[*] Testing remote dialogue with NPC: ${targetNpc.name} (ID: ${targetNpc.id})`);
        
        const talkRes = await session.callRpc('remoteNpcDialogue', targetNpc.id);
        console.log('[*] Result of remoteNpcDialogue:', talkRes);
        
        if (talkRes && talkRes.ok) {
            console.log(`[+] SUCCESS! Dialogue triggered without crashing. Method used: ${talkRes.method}`);
        } else {
            console.log(`[-] FAILED! Error:`, talkRes ? talkRes.error : 'Unknown');
        }
    } else {
        console.log('[-] No NPCs found nearby. Please move near an NPC to test.');
    }
    
    console.log('\n[*] Disconnecting...');
    await session.disconnect();
    process.exit(0);
}

main().catch(err => {
    console.error('[-] Fatal error:', err);
    process.exit(1);
});
