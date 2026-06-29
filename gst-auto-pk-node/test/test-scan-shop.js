// test/test-scan-shop.js -- Test scanning items of the nearest player shop
// Chay bang lenh: node test/test-scan-shop.js

const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

async function main() {
  console.log('=======================================');
  console.log('  TEST SCAN NEAREST SHOP ITEMS');
  console.log('=======================================\n');

  const frida = new FridaSession(null, config.GAME_PACKAGE);
  
  frida.onMessage((payload) => {
    const prefix = payload.type === 'error' ? '❌' : payload.type === 'warn' ? '⚠️' : '💬';
    console.log(`[Frida Script] ${prefix} [${payload.type}] ${payload.msg || payload.event || JSON.stringify(payload)}`);
  });
  
  try {
    console.log('Connecting to device...');
    await frida.connect();
    console.log('✅ Connected successfully!\n');

    console.log('Loading bot.bundle.js...');
    const bundlePath = path.join(__dirname, '..', 'frida-scripts', 'bot.bundle.js');
    await frida.loadScript(bundlePath);
    console.log('✅ Script loaded successfully!\n');

    console.log('Waiting 1.5s for IL2CPP initialization...');
    await new Promise(r => setTimeout(r, 1500));

    console.log('Querying nearby player shops...');
    const shopsRes = await frida.callRpc('getNearbyShops');
    if (!shopsRes.ok) {
      console.error('❌ Failed to get nearby shops:', shopsRes.error);
      await frida.disconnect();
      return;
    }

    const shops = shopsRes.shops || [];
    console.log(`✅ Found ${shops.length} player shops nearby. Details of first 5:`);
    shops.slice(0, 5).forEach((sh, i) => {
      console.log(`  [Shop #${i+1}] Name: "${sh.name}" | CID: ${sh.cid} | Dist: ${sh.distance.toFixed(1)} | Pos: (${sh.x}, ${sh.y})`);
    });
    if (shops.length === 0) {
      console.log('⚠️ No shops nearby to test! Make sure you are standing near player stalls.');
      await frida.disconnect();
      return;
    }

    // Pick the first shop
    const targetShop = shops[0];
    console.log(`\n=======================================`);
    console.log(`Target Shop: "${targetShop.name}"`);
    console.log(`CID: ${targetShop.cid}`);
    console.log(`Level: ${targetShop.level}`);
    console.log(`=======================================\n`);

    const parts = targetShop.cid.split('.');
    const stallIndex = parts[1];
    if (!stallIndex) {
      console.error('❌ Invalid stall index from CID:', targetShop.cid);
      await frida.disconnect();
      return;
    }

    if (targetShop.distance > 10) {
      console.log(`Moving to shop position: (${targetShop.x}, ${targetShop.y})...`);
      
      // Wake up the emulator display to ensure main thread runs
      try {
        const { execFileSync } = require('child_process');
        execFileSync(config.ADB_PATH, ['-s', 'emulator-5554', 'shell', 'input', 'tap', '10', '10']);
      } catch (e) {}

      await frida.callRpc('gotoHooked', targetShop.x, targetShop.y, 10);
      const walkWait = Math.min(10000, Math.max(1000, Math.floor(targetShop.distance * 100)));
      console.log(`Waiting ${walkWait}ms for character to reach the shop...`);
      await new Promise(r => setTimeout(r, walkWait));
    }

    console.log(`Querying items inside shop (Stall Index: ${stallIndex})...`);
    // Keep game active while waiting
    try {
      const { execFileSync } = require('child_process');
      execFileSync(config.ADB_PATH, ['-s', 'emulator-5554', 'shell', 'input', 'keyevent', '224']); // WAKEUP
      execFileSync(config.ADB_PATH, ['-s', 'emulator-5554', 'shell', 'input', 'keyevent', '82']);  // UNLOCK
      execFileSync(config.ADB_PATH, ['-s', 'emulator-5554', 'shell', 'input', 'swipe', '500', '1000', '500', '200']); 
    } catch(e) {}
    console.log(`Sending EPlayerTalk (48) for ${targetShop.cid}...`);
    let talkReqHex = "0a" + targetShop.cid.length.toString(16).padStart(2, '0');
    for (let i = 0; i < targetShop.cid.length; i++) {
      talkReqHex += targetShop.cid.charCodeAt(i).toString(16).padStart(2, '0');
    }
    const talkRes = await frida.callRpc('sendPacket', 48, talkReqHex);
    console.log("EPlayerTalk send result:", talkRes);
    
    // Also send the EPlayerStallOpenRequest (204) because EPlayerTalk alone might just talk, not open the shop
    console.log(`Sending EPlayerStallOpenRequest (204) for ${targetShop.cid}...`);
    const stallStr = targetShop.cid;
    let stallReqHex = "0a" + stallStr.length.toString(16).padStart(2, '0');
    for (let i = 0; i < stallStr.length; i++) {
      stallReqHex += stallStr.charCodeAt(i).toString(16).padStart(2, '0');
    }
    const sendRes = await frida.callRpc('sendPacket', 204, stallReqHex);
    console.log("EPlayerStallOpenRequest send result:", sendRes);

    // Wait a bit to see if the game sends the stall request and receives response
    await new Promise(r => setTimeout(r, 2000));
    
    console.log(`Waiting for UI update in getShopItems...`);
    const itemsRes = await frida.callRpc('getShopItems', stallIndex, targetShop.name, targetShop.namePtrStr, targetShop.cidPtrStr, targetShop.controllerPtrStr);
    
    if (!itemsRes.ok) {
      console.error('❌ Failed to query shop items:', itemsRes.error);
    } else {
      console.log(`✅ Successfully queried shop!`);
      console.log(`Shop Title: "${itemsRes.title}"`);
      const items = itemsRes.items || [];
      console.log(`Items count: ${items.length}\n`);

      const { ItemDB } = require('../src/utils/item-db');

      items.forEach((item, idx) => {
        const parsedItem = ItemDB.parseItem(item);

        console.log(`tên item: ${parsedItem.name}`);
        console.log(`cấp: ${parsedItem.level}`);
        if (parsedItem.priceVan > 0) {
          console.log(`giá vạn: ${parsedItem.priceVan}`);
        }
        if (parsedItem.priceKnb > 0) {
          console.log(`giá KNB: ${parsedItem.priceKnb}`);
        }
        console.log(`giới tính: ${parsedItem.gender}`);
        console.log(`ngũ hành: ${parsedItem.series}`);
        
        if (parsedItem.magicLines.length > 0) {
          console.log(`thuộc tính từng dòng như hình (có tối đa 6 dòng):`);
          parsedItem.magicLines.forEach(line => console.log(`- ${line}`));
        } else {
          console.log(`thuộc tính từng dòng như hình (có tối đa 6 dòng): Không có`);
        }
        console.log('---------------------------------------');
      });
    }

  } catch (err) {
    console.error('❌ Error during execution:', err.stack || err.message);
  } finally {
    console.log('Disconnecting...');
    await frida.disconnect();
    console.log('Done.');
  }
}

main().catch(err => {
  console.error('Fatal:', err);
});
