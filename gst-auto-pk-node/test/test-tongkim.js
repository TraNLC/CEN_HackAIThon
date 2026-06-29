// test/test-tongkim.js — Test file for Tong Kim Battlefield Flow
// Run: node test/test-tongkim.js

const { FridaSession } = require('../src/frida-session');
const { PacketInjector } = require('../src/packet-injector');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null; // auto-detect
const NPC_BAODANH = '23';       // Quan Nhu Quan ở map ngoai
const NPC_MAU = '2581';         // NPC Duoc Pham trong doanh trai
const NPC_RATRAN = '2593';       // NPC Chien Dau ra tran
const HOTRO_ITEM_IDX = 7;       // Item ID ho tro (tang mau/mana/diem)

const MAP_BATTLE = [382];       // Danh sach map chien truong Tong Kim
const MAP_OUTSIDE = [324];      // Map ngoai de bao danh

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

async function main() {
  console.log('==================================================');
  console.log('  TEST TONG KIM BATTLEFIELD FLOW');
  console.log('==================================================\n');

  const frida = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);
  
  frida.onMessage((payload) => {
    const prefix = payload.type === 'error' ? '❌' : payload.type === 'warn' ? '⚠️' : '  ';
    if (payload.type === 'error' || payload.type === 'warn') {
      console.log(`  ${prefix} [${payload.type}] ${payload.msg || JSON.stringify(payload)}`);
    }
  });

  console.log('[*] Dang ket noi Frida...');
  try {
    await frida.connect();
    console.log('  ✅ Ket noi thanh cong!');
  } catch (err) {
    console.error('  ❌ Ket noi that bai:', err.message);
    process.exit(1);
  }

  console.log('[*] Dang tai script bot.bundle.js (Safe Mode)...');
  const scriptPath = path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js');
  try {
    await frida.loadScript(scriptPath);
    console.log('  ✅ Tai script thanh cong!\n');
  } catch (err) {
    console.error('  ❌ Tai script that bai:', err.message);
    await frida.disconnect();
    process.exit(1);
  }

  // Init packet injector
  const injector = new PacketInjector(frida);

  console.log('[*] Bat dau chu ky giam sat Tong Kim. Nhan Ctrl+C de dung...\n');

  let registered = false;
  let lastHealTime = 0;
  const CYCLE_EVERY = 30000; // 30 giay

  while (true) {
    try {
      // 1. Doc thong tin nhan vat hien tai (Map, HP, MP...)
      const info = await frida.callRpc('getPlayerInfo');
      if (!info || !info.ok) {
        console.log(`[Canh bao] Khong the doc thong tin nhan vat: ${info ? info.error : 'Null response'}`);
        await sleep(2000);
        continue;
      }

      const mapId = info.mapId;
      const isInside = MAP_BATTLE.includes(mapId);
      const isOutside = MAP_OUTSIDE.includes(mapId);

      console.log(`[Nhan vat] Map: ${mapId} | HP: ${info.hp}/${info.maxHp} | MP: ${info.mp}/${info.maxMp}`);

      // 2. Kiem tra vi tri va thuc hien hanh dong
      if (isOutside && !registered) {
        console.log(`\n📋 [HANH DONG] Phat hien o Map Ngoai (${mapId}). Bat dau bao danh...`);
        
        console.log(`  -> Goi NPC Bao Danh (${NPC_BAODANH}) tu xa...`);
        const talkRes = await frida.callRpc('remoteNpcDialogue', NPC_BAODANH);
        console.log(`  -> Tra ve:`, JSON.stringify(talkRes));
        await sleep(1500);

        console.log(`  -> Gui lua chon trong thoai (eNpcSelect)...`);
        const selectRes = await injector.sendNpcSelect(0);
        console.log(`  -> Tra ve:`, JSON.stringify(selectRes));
        await sleep(1000);

        console.log(`  -> Gui xac nhan vao hang eNpcDialogueConfirm (Opcode 232)...`);
        const confirmRes = await frida.callRpc('sendPacket', 232, '');
        console.log(`  -> Tra ve:`, JSON.stringify(confirmRes));

        registered = true;
        console.log('  ✅ Bao danh hoan tat! Cho vao map tran...\n');
        await sleep(5000);
        continue;
      }

      if (isInside) {
        registered = true; // Neu da o trong tran thi xem nhu da dang ky
        const now = Date.now();

        if (now - lastHealTime >= CYCLE_EVERY) {
          console.log(`\n💊 [HANH DONG] Den chu ky ho tro/ra tran (moi ${CYCLE_EVERY/1000}s)`);

          // Lay mau + Ho tro
          console.log(`  -> Goi NPC Duoc Pham (${NPC_MAU}) de nhan mau/ho tro...`);
          const healTalk = await frida.callRpc('remoteNpcDialogue', NPC_MAU);
          console.log(`  -> Tra ve:`, JSON.stringify(healTalk));
          await sleep(1000);

          console.log(`  -> Gui lua chon trong thoai...`);
          await injector.sendNpcSelect(0);
          await sleep(800);

          console.log(`  -> Su dung vat pham ho tro idx ${HOTRO_ITEM_IDX}...`);
          const itemRes = await injector.sendPlayerUserItem(HOTRO_ITEM_IDX);
          console.log(`  -> Tra ve:`, JSON.stringify(itemRes));
          await sleep(1000);

          // Ra tran
          console.log(`  -> Goi NPC Chien Dau (${NPC_RATRAN}) de ra map chien...`);
          const warTalk = await frida.callRpc('remoteNpcDialogue', NPC_RATRAN);
          console.log(`  -> Tra ve:`, JSON.stringify(warTalk));
          await sleep(1000);

          console.log(`  -> Gui lua chon ra tran (teleport ngau nhien)...`);
          const selectWar = await injector.sendNpcSelect(0);
          console.log(`  -> Tra ve:`, JSON.stringify(selectWar));

          lastHealTime = now;
          console.log('  ✅ Chu ky ho tro va ra tran hoan tat!\n');
        } else {
          const nextSecs = Math.round((CYCLE_EVERY - (now - lastHealTime)) / 1000);
          console.log(`  [Chien dau] Dang chien dau tu dong tai tran. Ho tro ke tiep sau ${nextSecs}s...`);
        }
      }

    } catch (e) {
      console.error('  [Loi chu ky]:', e.message);
    }

    await sleep(3000);
  }
}

main().catch(err => {
  console.error('❌ FATAL:', err.message);
  process.exit(1);
});
