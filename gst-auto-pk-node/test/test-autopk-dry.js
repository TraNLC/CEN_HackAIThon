const { FridaSession } = require('../src/frida-session');
const { PacketSniffer } = require('../src/packet-sniffer');
const { PacketInjector } = require('../src/packet-injector');
const { MemoryReader } = require('../src/memory-reader');
const { AutoPK } = require('../src/auto-pk');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null;

async function main() {
  console.log('═══════════════════════════════════════');
  console.log('  INTEGRATION TEST: Auto PK Main Loop');
  console.log('═══════════════════════════════════════\n');

  const session = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);

  console.log('▶ Connecting to device...');
  await session.connect();
  console.log('  ✅ Connected.\n');

  console.log('▶ Loading bundle script...');
  await session.loadScript(path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js'));
  console.log('  ✅ Bundle loaded.\n');

  const sniffer = new PacketSniffer(session);
  const injector = new PacketInjector(session);
  const memory = new MemoryReader(session);
  const autoPK = new AutoPK(session, memory, injector, sniffer, DEVICE_ID);

  console.log('▶ Starting Sniffer & Auto PK...');
  sniffer.start(200);
  await autoPK.start();

  console.log('Waiting 5s to capture tick behavior...');
  await new Promise(r => setTimeout(r, 5000));

  console.log('▶ Stopping Auto PK...');
  sniffer.stop();
  await autoPK.stop();

  console.log('▶ Disconnecting...');
  await session.disconnect();
  console.log('  ✅ Disconnected.');

  console.log('\n═══════════════════════════════════════');
  console.log('  INTEGRATION TEST COMPLETE: ✅ PASS');
  console.log('═══════════════════════════════════════');
}

main().catch(err => {
  console.error('❌ Integration Test Failed:', err.message);
  process.exit(1);
});
