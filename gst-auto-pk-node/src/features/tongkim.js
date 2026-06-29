const { PacketInjector } = require('../packet-injector');

function removeAccents(str) {
  if (!str) return '';
  return str.normalize('NFD').replace(/[\u0300-\u036f]/g, '').toLowerCase();
}

/**
 * 
 * @param {string} deviceId 
 * @param {FridaSession} session 
 * @param {object} info 
 * @param {string} side 'auto' | 'song' | 'jin'
 * @param {string[]} lacs Array of particular ids (e.g. ['45', '50'])
 * @param {function} sendLog
 */
async function autoTongKimLoop(deviceId, session, info, side, lacs, sendLog) {
  if (!session || !info) return;

  const injector = new PacketInjector(session);
  const mapId = info.mapId;
  const isOutside = mapId === 324 || mapId === 379; // Staging area
  const inCamp = mapId === 382; // Battle camp

  // 1. Tự dùng lắc (Phi tốc, Chiến cổ, Lệnh bài)
  if (lacs && lacs.length > 0) {
    try {
      const bagResStr = await session.callRpc('dumpBagItems');
      if (bagResStr) {
        const bag = bagResStr;
        if (bag.items && bag.items.length > 0) {
          for (const lac of lacs) {
            const item = bag.items.find(i => i.location === 2 && i.particular == lac);
            if (item && item.slot !== undefined) {
              await injector.sendPlayerUserItem(item.slot);
              sendLog(`[${deviceId}] Đã dùng lắc (Particular: ${lac}) tại ô ${item.slot}`, 'success');
            }
          }
        }
      }
    } catch(e) {}
  }

  // 2. Báo Danh (Ngoại thành)
  if (isOutside) {
    sendLog(`[${deviceId}] Đang ở bản đồ báo danh. Đang gọi Chiêu Binh Quân...`, 'info');
    try {
      const NPC_BAODANH = 23; 
      const talkRes = await session.callRpc('remoteNpcDialogue', NPC_BAODANH);
      if (talkRes && talkRes.ok) {
        await new Promise(r => setTimeout(r, 400));
        await injector.sendNpcSelect(0);
        await new Promise(r => setTimeout(r, 400));
        await session.callRpc('sendPacket', 232, ''); // eClientCompleted
        sendLog(`[${deviceId}] Báo danh thành công.`, 'success');
      } else {
        sendLog(`[${deviceId}] Lỗi gọi NPC báo danh: ${talkRes ? talkRes.error : 'Unknown'}`, 'error');
      }
    } catch (e) {
      sendLog(`[${deviceId}] Lỗi báo danh: ${e.message}`, 'error');
    }
    return;
  }

  // 3. Nhận máu & Ra trận (Doanh trại)
  if (inCamp) {
    try {
      // Quét NPC gần đó
      const nearNpcsStr = await session.callRpc('getNearNpcsDetail').catch(() => null);
      let nearNpcs = { ok: false, npcs: [] };
      if (nearNpcsStr) nearNpcs = nearNpcsStr;

      let healNpcId = '2581'; // Default Quan Nhu
      let warNpcId = '2593';  // Default Trinh Sat

      if (nearNpcs.ok && nearNpcs.npcs && nearNpcs.npcs.length > 0) {
        const heal = nearNpcs.npcs.find(n => n.name.includes('Quân Nhu'));
        if (heal) healNpcId = heal.id;

        const war = nearNpcs.npcs.find(n => n.name.includes('Trinh Sát'));
        if (war) warNpcId = war.id;
      } else {
        sendLog(`[${deviceId}] Không đọc được NPC linh hoạt. Dùng ID mặc định.`, 'warn');
      }

      // Nhận máu
      sendLog(`[${deviceId}] Tương tác Quân Nhu (${healNpcId}) để nhận máu...`, 'info');
      await session.callRpc('remoteNpcDialogue', healNpcId);
      await new Promise(r => setTimeout(r, 400));
      await injector.sendNpcSelect(0);
      await new Promise(r => setTimeout(r, 400));
      // Fallback for Jin side if eNpcSelect fails
      await session.callRpc('sendPacket', 232, ''); 

      // Ra trận
      sendLog(`[${deviceId}] Tương tác Trinh Sát (${warNpcId}) để ra trận...`, 'info');
      await session.callRpc('remoteNpcDialogue', warNpcId);
      await new Promise(r => setTimeout(r, 400));
      
      let sideIndex = 1; // Default: 1 (Song), 2 (Jin)
      if (side === 'song') sideIndex = 1;
      else if (side === 'jin') sideIndex = 2;
      
      await injector.sendNpcSelect(sideIndex);
      sendLog(`[${deviceId}] Đã yêu cầu ra chiến trường (Phe: ${sideIndex === 1 ? 'Tống' : 'Kim'})!`, 'success');

    } catch(e) {
      sendLog(`[${deviceId}] Lỗi Auto Tống Kim: ${e.message}`, 'error');
    }
  }
}

module.exports = {
  autoTongKimLoop
};
