// test/test-packet.js — Test Step 4: Packet Sniff (auto-detect gameFd)
// Chạy: node test/test-packet.js

const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null; // auto-detect

async function main() {
  console.log('═══════════════════════════════════════');
  console.log('  STEP 4: Packet Sniff (Auto-detect fd)');
  console.log('═══════════════════════════════════════\n');

  const frida = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);

  frida.onMessage((payload) => {
    if (payload.type === 'game_fd') {
      console.log(`  🎯 GAME FD: ${payload.fd} via ${payload.detectedBy}`);
    }
    if (payload.type === 'send_out') {
      console.log(`  📤 SEND: op=${payload.opcode} ${payload.name} (${payload.size}B)`);
    }
  });

  // Connect + load hooks
  console.log('▶ Connect + load hooks');
  await frida.connect();
  await frida.loadScript(path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js'));
  console.log('  ✅ Ready\n');

  // Wait for packet flow
  console.log('▶ Waiting for packets (10s)... Move char or open NPC!');
  for (let i = 2; i <= 10; i += 2) {
    await sleep(2000);
    const diag = await frida.callRpc('getDiag');
    console.log(`  ${i}s: gameFd=${diag.gameFd} recv=${diag.recvTotal} send=${diag.sendTotal}`);
    if (diag.gameFd > 0) break;
  }

  // Show captured packets
  console.log('\n▶ Captured packets:');
  const pkts = await frida.callRpc('getRecvPackets');
  if (pkts.ok && pkts.count > 0) {
    pkts.packets.slice(0, 15).forEach(p => {
      console.log(`  op=${p.opcode} ${(p.name||'').padEnd(25)} ${p.size}B  ${p.hex.substring(0,50)}`);
    });
    console.log(`  ... total ${pkts.count} packets`);
  } else {
    console.log('  ⚠️  No packets captured');
  }

  const final = await frida.callRpc('getDiag');
  console.log('\n═══════════════════════════════════════');
  console.log(final.recvTotal > 0 ? '  ✅ PACKET SNIFF WORKING' : '  ⚠️  No traffic (try moving char)');
  console.log(`  gameFd: ${final.gameFd}  recv: ${final.recvTotal}  send: ${final.sendTotal}`);
  console.log('═══════════════════════════════════════');

  try { await frida.disconnect(); } catch (e) {}
}

function sleep(ms) { return new Promise(r => setTimeout(r, ms)); }

main().catch(err => { console.error('❌', err.message); process.exit(1); });
