// src/index.js — Main orchestrator entry point (Step 6)
const { FridaSession } = require('./frida-session');
const { PacketSniffer } = require('./packet-sniffer');
const { PacketInjector } = require('./packet-injector');
const { MemoryReader } = require('./memory-reader');
const { AutoPK } = require('./auto-pk');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null; // Auto-detect the active device

async function main() {
  console.log('═════════════════════════════════════════════════════════');
  console.log('         VLTK1 MOBILE AUTO PK BOT (NODE.JS)');
  console.log('═════════════════════════════════════════════════════════\n');

  const session = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);

  console.log('Connecting to Frida and attaching to game...');
  try {
    await session.connect();
    console.log('  [SUCCESS] Connected successfully to device.');
  } catch (err) {
    console.error(`  [ERROR] Connection failed: ${err.message}`);
    process.exit(1);
  }

  const bundlePath = path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js');
  console.log(`Injecting Frida script bundle: ${path.basename(bundlePath)}...`);
  try {
    await session.loadScript(bundlePath);
    console.log('  [SUCCESS] Script injected & initialized.');
  } catch (err) {
    console.error(`  [ERROR] Injection failed: ${err.message}`);
    await session.disconnect();
    process.exit(1);
  }

  // Instantiate controller layers
  const sniffer = new PacketSniffer(session);
  const injector = new PacketInjector(session);
  const memory = new MemoryReader(session);
  const autoPK = new AutoPK(session, memory, injector, sniffer, DEVICE_ID);

  // Setup message handlers for diagnostics
  session.onMessage((payload) => {
    if (payload.type === 'game_fd') {
      console.log(`[FRIDA] Game socket fd locked: ${payload.fd} via ${payload.detectedBy || 'traffic'}`);
      sniffer.gameFd = payload.fd;
    } else if (payload.type === 'error') {
      console.error(`[FRIDA ERROR] ${payload.description || payload.msg || JSON.stringify(payload)}`);
    }
  });

  // Start packet sniffing and auto-reheal
  console.log('Starting packet sniffer...');
  sniffer.start(200);

  // Let the user know the target details
  console.log(`Target Info: Process ${session.pkg} (PID: ${session.pid})`);

  const sect = await memory.getMySect();
  console.log(`Player Sect: ${sect}`);

  // Start Auto PK loop
  console.log('Starting PK loop...');
  await autoPK.start();

  // Periodically print player info status
  const infoInterval = setInterval(async () => {
    try {
      const info = await session.callRpc('getPlayerInfo');
      if (info && info.ok) {
        console.log(`[CHAR-INFO] Name: ${info.name || 'Loading'} | Level: ${info.level || 0} | Map ID: ${info.mapId || 0} | Money: ${info.money || 0}`);
      } else {
        console.log(`[CHAR-INFO] Waiting for character capture... (Please walk/move character in emulator to trigger)`);
      }
    } catch (e) {
      // Ignore
    }
  }, 3000);

  console.log('\nRunning... Press Ctrl+C to terminate cleanly.\n');

  // Handle graceful exits
  const shutdown = async () => {
    console.log('\nGracefully shutting down...');
    clearInterval(infoInterval);
    sniffer.stop();
    await autoPK.stop();
    try {
      await session.disconnect();
      console.log('Disconnected Frida session.');
    } catch (e) {
      // Ignore
    }
    console.log('Bye!');
    process.exit(0);
  };

  process.on('SIGINT', shutdown);
  process.on('SIGTERM', shutdown);
}

main().catch((err) => {
  console.error('[FATAL] FATAL ERROR IN MAIN RUNTIME:', err);
  process.exit(1);
});
