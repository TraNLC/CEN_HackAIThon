// src/adb.js — ADB Wrapper Module (Step 1)
// Dùng child_process gọi adb.exe, không phụ thuộc adbkit (nhẹ hơn, dễ debug)

const { execFileSync, execSync } = require('child_process');
const config = require('../config');

const ADB = config.ADB_PATH;
const PKG = config.GAME_PACKAGE;

// Ensure ADB server is running in this process context without stream blocks
try {
  execSync(`"${ADB}" start-server >nul 2>&1`, { timeout: 3000 });
} catch (e) {}

// ==================== HELPERS ====================

/** Chạy lệnh ADB, trả về stdout string (sync, timeout 15s) */
function adbShell(deviceId, args, timeout = 15000) {
  const cmdArgs = Array.isArray(args) ? args : args.split(/\s+/).filter(Boolean);
  const allArgs = deviceId ? ['-s', deviceId, ...cmdArgs] : cmdArgs;
  try {
    return execFileSync(ADB, allArgs, { timeout, encoding: 'utf-8', windowsHide: true }).trim();
  } catch (e) {
    return '';
  }
}

/** Chạy lệnh ADB shell (trên thiết bị) */
function adbDeviceShell(deviceId, shellCmd, timeout = 10000) {
  const parts = typeof shellCmd === 'string' ? shellCmd.split(/\s+/) : shellCmd;
  return adbShell(deviceId, ['shell', ...parts], timeout);
}

// ==================== DEVICE MANAGEMENT ====================

/** Lấy danh sách thiết bị đang kết nối */
function listDevices() {
  const out = adbShell(null, 'devices');
  const lines = out.split('\n').slice(1); // bỏ dòng "List of devices attached"
  const devices = [];
  for (const line of lines) {
    const parts = line.trim().split(/\s+/);
    if (parts.length >= 2 && parts[1] === 'device') {
      devices.push({ id: parts[0], status: parts[1] });
    }
  }
  return devices;
}

/**
 * Auto-detect thiết bị đang chạy game.
 * @returns {{ deviceId: string, pid: number } | null}
 */
function detectDevice() {
  const devices = listDevices();
  for (const d of devices) {
    const pid = getGamePid(d.id);
    if (pid) {
      console.log(`[ADB] Auto-detected device: ${d.id} (game PID ${pid})`);
      return { deviceId: d.id, pid };
    }
  }
  return null;
}

/**
 * Auto-detect TẤT CẢ thiết bị đang chạy game (multi-instance).
 * @returns {Array<{ deviceId: string, pid: number }>}
 */
function detectDevices() {
  const devices = listDevices();
  const result = [];
  for (const d of devices) {
    const pid = getGamePid(d.id);
    if (pid) {
      console.log(`[ADB] Found: ${d.id} (game PID ${pid})`);
      result.push({ deviceId: d.id, pid });
    }
  }
  return result;
}

/** Lấy PID của game trên thiết bị (nếu đang chạy) */
function getGamePid(deviceId) {
  const out = adbDeviceShell(deviceId, `pidof ${PKG}`);
  if (out.length > 0 && /^\d+/.test(out)) {
    return parseInt(out, 10);
  }
  return null;
}

// ==================== GAME CONTROL ====================

/** Kiểm tra game có đang chạy không */
function isGameRunning(deviceId) {
  const out = adbDeviceShell(deviceId, `pidof ${PKG}`);
  return out.length > 0 && /^\d+/.test(out);
}

/** Kiểm tra game có đang foreground không */
function isGameForeground(deviceId) {
  const out = adbDeviceShell(deviceId, 'dumpsys window windows');
  // Tìm dòng mCurrentFocus hoặc mFocusedApp có chứa package name
  for (const line of out.split('\n')) {
    if ((line.includes('mCurrentFocus') || line.includes('mFocusedApp')) && line.includes(PKG)) {
      return true;
    }
  }
  return false;
}

/** Dừng game (force-stop) */
function stopGame(deviceId) {
  console.log(`[ADB] Stopping ${PKG} on ${deviceId}...`);
  return adbDeviceShell(deviceId, `am force-stop ${PKG}`);
}

/** Khởi động game */
function startGame(deviceId) {
  console.log(`[ADB] Starting ${PKG} on ${deviceId}...`);
  return adbDeviceShell(deviceId, `monkey -p ${PKG} -c android.intent.category.LAUNCHER 1`);
}

/** Đợi game lên foreground (timeout ms) */
async function waitForGame(deviceId, timeout = 30000) {
  console.log(`[ADB] Waiting for ${PKG} to reach foreground...`);
  const startTime = Date.now();
  while (Date.now() - startTime < timeout) {
    if (isGameForeground(deviceId)) {
      console.log('[ADB] Game is in foreground!');
      // Đợi thêm 5s để Il2Cpp load xong
      await sleep(5000);
      return true;
    }
    await sleep(1000);
  }
  console.log('[ADB] Timeout waiting for game foreground.');
  return false;
}

// ==================== TOUCH / INPUT ====================

/** Tap vào tọa độ (x, y) */
function tap(deviceId, x, y) {
  return adbDeviceShell(deviceId, `input tap ${x} ${y}`);
}

/** Swipe từ (x1,y1) đến (x2,y2) trong duration ms */
function swipe(deviceId, x1, y1, x2, y2, duration = 300) {
  return adbDeviceShell(deviceId, `input swipe ${x1} ${y1} ${x2} ${y2} ${duration}`);
}

/** Gửi phím (KEYCODE_BACK=4, KEYCODE_HOME=3, etc.) */
function keyEvent(deviceId, keyCode) {
  return adbDeviceShell(deviceId, `input keyevent ${keyCode}`);
}

// ==================== UTILS ====================

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

// ==================== EXPORT ====================

module.exports = {
  listDevices,
  detectDevice,
  detectDevices,
  getGamePid,
  isGameRunning,
  isGameForeground,
  stopGame,
  startGame,
  waitForGame,
  tap,
  swipe,
  keyEvent,
  adbShell,
  adbDeviceShell,
};
