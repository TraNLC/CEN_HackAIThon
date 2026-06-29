const { app, BrowserWindow, ipcMain } = require('electron');
const path = require('path');
const { execSync, exec } = require('child_process');

function execAsync(cmd, options = {}) {
  return new Promise((resolve) => {
    exec(cmd, options, (error, stdout, stderr) => {
      resolve({ error, stdout: stdout || '', stderr: stderr || '' });
    });
  });
}
const { FridaSession } = require('../frida-session');
const config = require('../../config');
const { autoTongKimLoop } = require('../features/tongkim');

let mainWindow = null;

// Multi-session state
const sessions = new Map(); // deviceId -> { session, interval, info }
const npcIdCache = new Map(); // CACHE NPC ID (deviceId -> { tên: id })

let globalAutoTKInterval = null;
let isAutoTKEnabled = false;
let globalTkSide = 'auto'; // auto | song | jin
let globalLacSettings = []; // array of particular ids

const ADB = config.ADB_PATH || 'C:\\platform-tools\\adb.exe';
const PKG = config.GAME_PACKAGE || 'vn.perfingame.jx1mobile';

function createWindow() {
  mainWindow = new BrowserWindow({
    width: 950,
    height: 680,
    minWidth: 800,
    minHeight: 600,
    resizable: true,
    frame: true,
    title: 'GST Auto PK - Multi-Account',
    webPreferences: {
      preload: path.join(__dirname, 'preload.js'),
      contextIsolation: true,
      nodeIntegration: false
    }
  });

  mainWindow.loadFile(path.join(__dirname, 'renderer', 'index.html'));

  mainWindow.on('closed', async () => {
    await cleanup();
    mainWindow = null;
  });
}

async function cleanup() {
  if (globalAutoTKInterval) {
    clearInterval(globalAutoTKInterval);
    globalAutoTKInterval = null;
  }
  for (const [deviceId, state] of sessions.entries()) {
    if (state.interval) clearInterval(state.interval);
    if (state.session) {
      try { await state.session.disconnect(); } catch (e) {}
    }
  }
  sessions.clear();
}

function sendLog(msg, type = 'info') {
  if (mainWindow) {
    mainWindow.webContents.send('tab-log', { msg, type });
  }
}

app.whenReady().then(() => {
  createWindow();
  app.on('activate', () => {
    if (BrowserWindow.getAllWindows().length === 0) createWindow();
  });
});

app.on('window-all-closed', async () => {
  await cleanup();
  if (process.platform !== 'darwin') app.quit();
});

// IPC Handler: Scan devices
ipcMain.handle('scan-devices', async () => {
  try {
    try { execSync(`"${ADB}" start-server`, { timeout: 3000 }); } catch (e) {}
    const ports = config.DEFAULT_PORTS || [16416, 5555, 5556, 5557, 26624, 26656, 26688, 26720, 26752, 26784, 26816, 26880];
    
    // Check ports using net.Socket first to avoid ADB crashes and hanging
    const net = require('net');
    function checkPort(port) {
      return new Promise((resolve) => {
        const s = new net.Socket();
        s.setTimeout(200);
        s.on('connect', () => { s.destroy(); resolve(true); });
        s.on('timeout', () => { s.destroy(); resolve(false); });
        s.on('error', () => { s.destroy(); resolve(false); });
        s.connect(port, '127.0.0.1');
      });
    }

    for (const port of ports) {
      if (await checkPort(port)) {
        try { await execAsync(`"${ADB}" connect 127.0.0.1:${port}`, { timeout: 1500 }); } catch(e){}
      }
    }

    const { stdout } = await execAsync(`"${ADB}" devices`);
    const lines = stdout.split('\n');
    const devices = [];
    for (let i = 1; i < lines.length; i++) {
      const line = lines[i].trim();
      if (line && line.includes('device') && !line.includes('offline')) {
        let deviceId = line.split('\t')[0];
        
        // Deduplicate common emulator console vs tcp ports
        let isDuplicate = false;
        for (const d of devices) {
          if (deviceId === '127.0.0.1:5555' && d.id === 'emulator-5554') isDuplicate = true;
          if (deviceId === 'emulator-5554' && d.id === '127.0.0.1:5555') isDuplicate = true;
          if (deviceId === '127.0.0.1:5557' && d.id === 'emulator-5556') isDuplicate = true;
          if (deviceId === 'emulator-5556' && d.id === '127.0.0.1:5557') isDuplicate = true;
          if (deviceId === '127.0.0.1:5559' && d.id === 'emulator-5558') isDuplicate = true;
          if (deviceId === 'emulator-5558' && d.id === '127.0.0.1:5559') isDuplicate = true;
          // Nox specific
          if (deviceId === '127.0.0.1:62001' && d.id === 'emulator-5554') isDuplicate = true;
          if (deviceId === 'emulator-5554' && d.id === '127.0.0.1:62001') isDuplicate = true;
        }
        
        if (!isDuplicate) {
          devices.push({ id: deviceId, name: deviceId });
        }
      }
    }
    return { ok: true, devices };
  } catch (err) {
    return { ok: false, error: err.message };
  }
});

// IPC Handler: Toggle Device Connection
ipcMain.handle('toggle-device', async (event, deviceId, connect) => {
  if (!connect) {
    // Disconnect
    const state = sessions.get(deviceId);
    if (state) {
      if (state.interval) clearInterval(state.interval);
      if (state.session) await state.session.disconnect();
      sessions.delete(deviceId);
      npcIdCache.delete(deviceId);
      sendLog(`[${deviceId}] Đã ngắt kết nối.`, 'warn');
      return { ok: true };
    }
    return { ok: true };
  }

  // Connect
  if (sessions.has(deviceId)) return { ok: true }; // Already connected
  sendLog(`[${deviceId}] Đang gắn kết (attach) Frida...`, 'info');
  
  const session = new FridaSession(deviceId);
  const ok = await session.connect(PKG);
  if (!ok) {
    sendLog(`[${deviceId}] Lỗi kết nối (game chưa mở?).`, 'error');
    return { ok: false, error: 'Connection failed' };
  }
  
  sendLog(`[${deviceId}] Kết nối thành công! Bắt đầu tải script...`, 'success');
  
  try {
    const scriptPath = path.join(__dirname, '../../frida-scripts/bot.bundle.js');
    await session.loadScript(scriptPath);
    sendLog(`[${deviceId}] Tải script thành công. Đang đọc dữ liệu nhân vật...`, 'success');
  } catch(e) {
    sendLog(`[${deviceId}] Lỗi tải script: ${e.message}`, 'error');
    return { ok: false, error: 'Script load failed' };
  }

  const state = { session, info: null, interval: null };
  sessions.set(deviceId, state);

  // Start status polling
  state.interval = setInterval(async () => {
    try {
      const infoStr = await session.callRpc('getPlayerInfo');
      if (infoStr) {
        const info = infoStr;
        state.info = info;
        if (mainWindow) {
          mainWindow.webContents.send('player-info-update', { deviceId, info });
        }
      }
    } catch(e) {
      // transient read errors
    }
  }, 2000);

  return { ok: true };
});

// IPC Handler: Toggle Global Auto TK
ipcMain.handle('toggle-auto-tk', (event, enable, side, lacs) => {
  isAutoTKEnabled = enable;
  globalTkSide = side;
  globalLacSettings = lacs;

  if (enable) {
    sendLog(`BẬT Auto Tống Kim toàn cục. Phe: ${side}`, 'success');
    if (!globalAutoTKInterval) {
      globalAutoTKInterval = setInterval(async () => {
        // Run Tong Kim loop for all connected sessions sequentially
        for (const [deviceId, state] of sessions.entries()) {
          try {
            await autoTongKimLoop(deviceId, state.session, state.info, globalTkSide, globalLacSettings, sendLog);
          } catch(e) {
            sendLog(`[${deviceId}] Lỗi Auto Tống Kim: ${e.message}`, 'error');
          }
        }
      }, 5000);
    }
  } else {
    sendLog(`TẮT Auto Tống Kim toàn cục.`, 'warn');
    if (globalAutoTKInterval) {
      clearInterval(globalAutoTKInterval);
      globalAutoTKInterval = null;
    }
  }
  return { ok: true };
});

// IPC Handler: Test Chat NPC
ipcMain.handle('test-chat-npc', async (event, targetIdOrName) => {
  if (sessions.size === 0) {
    sendLog(`[System] Chưa có thiết bị nào kết nối để test.`, 'error');
    return { ok: false };
  }
  
  for (const [deviceId, state] of sessions.entries()) {
    if (state.session) {
      try {
        let finalNpcId = targetIdOrName;
        let targetName = "";
        
        // Map the hardcoded test IDs to their actual names for dynamic scanning
        if (targetIdOrName === '23') targetName = "Chiêu Binh Quân";
        if (targetIdOrName === '2581') targetName = "Quân Nhu";
        if (targetIdOrName === '2593') targetName = "Trinh Sát";
        
        let foundDynamic = false;
        if (targetName || targetIdOrName === 'radar') {
            sendLog(`[${deviceId}] Đang Radar quét xung quanh...`, 'info');
            // Scan nearby NPCs to get the exact dynamic ID for the current map/faction
            const nearResStr = await state.session.callRpc('getNearNpcsDetail');
            if (nearResStr) {
                const nearRes = nearResStr;
                if (nearRes.ok && nearRes.npcs) {
                    let radarLog = `[${deviceId}] 📡 RADAR TÌM THẤY ${nearRes.npcs.length} NPC xung quanh:\n`;
                    for (const npc of nearRes.npcs) {
                        radarLog += ` - Tên: "${npc.name}" | ID: ${npc.id}\n`;
                        
                        // [HỌC ID] Luôn lưu vào cache nếu phát hiện NPC chuẩn của trận
                        if (npc.name && (npc.name.includes("Quân Nhu") || npc.name.includes("Trinh Sát") || npc.name.includes("Chiêu Binh Quân"))) {
                            if (!npcIdCache.has(deviceId)) npcIdCache.set(deviceId, {});
                            let nKey = npc.name.includes("Quân Nhu") ? "Quân Nhu" : (npc.name.includes("Trinh Sát") ? "Trinh Sát" : "Chiêu Binh Quân");
                            npcIdCache.get(deviceId)[nKey] = npc.id.toString();
                        }

                        if (targetName && npc.name && npc.name.includes(targetName)) {
                            finalNpcId = npc.id.toString();
                            foundDynamic = true;
                            sendLog(`[${deviceId}] Đã quét trúng NPC "${npc.name}", CHỐT ID thực tế của trận này: ${finalNpcId}`, 'success');
                            // Bỏ break để radar in hết ra log và học hết các NPC khác
                        }
                    }
                    if (targetIdOrName === 'radar') {
                        sendLog(radarLog, 'info');
                    }
                } else if (targetIdOrName === 'radar') {
                    sendLog(`[${deviceId}] 📡 RADAR KHÔNG TÌM THẤY NPC NÀO (hoặc lỗi đọc bộ nhớ).`, 'error');
                }
            }
        }

        // Nếu KHÔNG quét thấy (do ở xa quá chưa load), DÙNG LẠI CACHE ĐÃ HỌC!
        if (!foundDynamic && targetName) {
            const cache = npcIdCache.get(deviceId) || {};
            if (cache[targetName]) {
                finalNpcId = cache[targetName];
                sendLog(`[${deviceId}] NPC ${targetName} ở xa tầm nhìn, DÙNG LẠI ID ĐÃ HỌC TRƯỚC ĐÓ: ${finalNpcId}`, 'warn');
            } else {
                // FALLBACK CUỐI CÙNG: Dùng ID hardcode (thường sẽ sai khác trận)
                const camp = (state.info && state.info.campValue) ? state.info.campValue : 1;
                if (targetName === "Quân Nhu") {
                    finalNpcId = (camp == 2) ? "126" : "5554"; // Kim : Tống
                    sendLog(`[${deviceId}] CHƯA HỌC ID, dùng ID mặc định Quân Nhu phe ${camp == 2 ? 'Kim' : 'Tống'}: ${finalNpcId} (Có thể fail)`, 'warn');
                } else if (targetName === "Trinh Sát") {
                    finalNpcId = (camp == 2) ? "106" : "5574"; // Kim : Tống
                    sendLog(`[${deviceId}] CHƯA HỌC ID, dùng ID mặc định Trinh Sát phe ${camp == 2 ? 'Kim' : 'Tống'}: ${finalNpcId} (Có thể fail)`, 'warn');
                } else if (targetName === "Chiêu Binh Quân") {
                    finalNpcId = "23";
                    sendLog(`[${deviceId}] Dùng ID mặc định Chiêu Binh Quân: 23`, 'warn');
                }
            }
        }

        if (targetIdOrName === 'radar') {
            sendLog(`[${deviceId}] Radar quét xong. Vui lòng kiểm tra log ở trên.`, 'success');
            continue; // Không mở dialog khi đang radar
        }

        sendLog(`[${deviceId}] Test gọi NPC ${finalNpcId}...`, 'info');
        const res = await state.session.callRpc('remoteNpcDialogue', finalNpcId);
        if (res && res.ok) {
          sendLog(`[${deviceId}] Thành công: Đã mở dialog NPC ${finalNpcId} bằng ${res.method}.`, 'success');
        } else {
          sendLog(`[${deviceId}] Thất bại gọi NPC ${finalNpcId}: ${res ? res.error : 'Unknown'}`, 'error');
        }
      } catch(e) {
        sendLog(`[${deviceId}] Lỗi ngoại lệ khi gọi NPC: ${e.message}`, 'error');
      }
    }
  }
  return { ok: true };
});
