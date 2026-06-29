const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
  const frida = new FridaSession(config.PACKAGE_NAME, 'frida-scripts/bot.bundle.js');
  await frida.connect();
  await frida.loadScript('frida-scripts/bot.bundle.js');

  console.log("Waiting 1s for IL2CPP initialization...");
  await new Promise(r => setTimeout(r, 1000));

  console.log("Querying nearby player shops...");
  const shopsRes = await frida.callRpc('getNearbyShops');
  const shops = shopsRes.shops || [];
  if (shops.length === 0) {
    console.log("No shops nearby!");
    frida.disconnect();
    return;
  }

  const targetShop = shops[0];
  console.log(`Target Shop: ${targetShop.name} | CID: ${targetShop.cid}`);

  const parts = targetShop.cid.split('.');
  const stallIndex = parseInt(parts[1], 10);

  // EPlayerTalk (48)
  const hexCid = targetShop.cid.split('').map(c => c.charCodeAt(0).toString(16).padStart(2, '0')).join('');
  const talkReqHex = "0a" + targetShop.cid.length.toString(16).padStart(2, '0') + hexCid;
  await frida.callRpc('sendPacket', 48, talkReqHex);
  console.log("Sent EPlayerTalk (48)");

  // ESalesmanGetStallDataRequest (196)
  // stallIndex is field 1, varint.
  let v = stallIndex;
  let varintHex = "";
  while (v > 127) {
    varintHex += ((v & 0x7F) | 0x80).toString(16).padStart(2, '0');
    v >>>= 7;
  }
  varintHex += v.toString(16).padStart(2, '0');
  const req196Hex = "08" + varintHex;
  await frida.callRpc('sendPacket', 196, req196Hex);
  console.log("Sent ESalesmanGetStallDataRequest (196)");

  // EPlayerStallOpenRequest (204)
  const req204Hex = "0a" + targetShop.cid.length.toString(16).padStart(2, '0') + hexCid;
  await frida.callRpc('sendPacket', 204, req204Hex);
  console.log("Sent EPlayerStallOpenRequest (204)");

  console.log("Waiting 3 seconds for server response...");
  await new Promise(r => setTimeout(r, 3000));

  console.log("\nChecking recvBuffer for 197 (SalesmanGetStallDataResponse)...");
  const res197 = await frida.callRpc('getRecvPackets', 197, 10);
  if (res197.packets && res197.packets.length > 0) {
    console.log("✅ RECEIVED 197:");
    for (const p of res197.packets) {
      console.log(`Size: ${p.size} | Hex: ${p.hex}`);
    }
  } else {
    console.log("❌ NO 197 RECEIVED");
  }

  console.log("\nChecking recvBuffer for 205 (PlayerStallOpenResponse)...");
  const res205 = await frida.callRpc('getRecvPackets', 205, 10);
  if (res205.packets && res205.packets.length > 0) {
    console.log("✅ RECEIVED 205:");
    for (const p of res205.packets) {
      console.log(`Size: ${p.size} | Hex: ${p.hex}`);
    }
  } else {
    console.log("❌ NO 205 RECEIVED");
  }

  frida.disconnect();
}

run().catch(console.error);
