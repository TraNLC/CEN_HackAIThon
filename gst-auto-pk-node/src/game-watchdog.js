// src/game-watchdog.js — Auto-restart game when crash
//   Dùng độc lập:  node src/game-watchdog.js
//   Dùng trong code: const watchdog = require('./src/game-watchdog'); watchdog.start();

const { execSync } = require('child_process');
const config = require('../config');

const ADB = config.ADB_PATH;
const PKG = config.GAME_PACKAGE;

// ==================== CONFIG ====================
const CHECK_INTERVAL = 5000;    // Kiểm tra mỗi 5 giây
const RESTART_DELAY = 3000;     // Đợi 3s sau crash rồi mới restart
const LOAD_WAIT = 30000;        // Đợi tối đa 30s game load xong
const MAX_RESTARTS = 20;        // Max lần restart trước khi bỏ cuộc

class GameWatchdog {
  /**
   * @param {string|null} deviceId - ADB device ID, null = auto-detect
   * @param {object} opts
   * @param {number} opts.checkInterval - ms between checks (default 5000)
   * @param {number} opts.restartDelay - ms wait before restart (default 3000)
   * @param {number} opts.loadWait - ms max wait for game to load (default 30000)
   * @param {number} opts.maxRestarts - max restarts before giving up (default 20)
   * @param {function} opts.onCrash - callback(deviceId, restartCount)
   * @param {function} opts.onRestart - callback(deviceId, pid)
   * @param {function} opts.onGiveUp - callback(deviceId, reason)
   */
  constructor(deviceId, opts = {}) {
    this.deviceId = deviceId;
    this.checkInterval = opts.checkInterval || CHECK_INTERVAL;
    this.restartDelay = opts.restartDelay || RESTART_DELAY;
    this.loadWait = opts.loadWait || LOAD_WAIT;
    this.maxRestarts = opts.maxRestarts || MAX_RESTARTS;
    this.onCrash = opts.onCrash || null;
    this.onRestart = opts.onRestart || null;
    this.onGiveUp = opts.onGiveUp || null;
    this._running = false;
    this._restartCount = 0;
    this._lastPid = null;
    this._timer = null;
  }

  /** Auto-detect device running game */
  _detectDevice() {
    try {
      const out = execSync(`"${ADB}" devices`, { encoding: 'utf-8', windowsHide: true });
      const lines = out.split('\n').slice(1);
      for (const line of lines) {
        const parts = line.trim().split(/\s+/);
        if (parts.length >= 2 && parts[1] === 'device') {
          const devId = parts[0];
          try {
            const pidOut = execSync(
              `"${ADB}" -s ${devId} shell "pidof ${PKG}"`,
              { encoding: 'utf-8', timeout: 5000, windowsHide: true }
            ).trim();
            if (pidOut && /^\d+/.test(pidOut)) {
              return { deviceId: devId, pid: parseInt(pidOut, 10) };
            }
          } catch (e) { /* device may have no game */ }
        }
      }
    } catch (e) { /* ADB error */ }
    return null;
  }

  /** Get game PID on specific device */
  _getPid(deviceId) {
    try {
      const out = execSync(
        `"${ADB}" -s ${deviceId} shell "pidof ${PKG}"`,
        { encoding: 'utf-8', timeout: 5000, windowsHide: true }
      ).trim();
      if (out && /^\d+/.test(out)) return parseInt(out, 10);
    } catch (e) { /* game not running */ }
    return null;
  }

  /** Start game on device */
  _startGame(deviceId) {
    console.log(`[Watchdog] Starting ${PKG} on ${deviceId}...`);
    try {
      execSync(
        `"${ADB}" -s ${deviceId} shell "monkey -p ${PKG} -c android.intent.category.LAUNCHER 1"`,
        { timeout: 10000, windowsHide: true }
      );
      return true;
    } catch (e) {
      console.error(`[Watchdog] Failed to start game: ${e.message}`);
      return false;
    }
  }

  /** Stop game on device */
  _stopGame(deviceId) {
    try {
      execSync(
        `"${ADB}" -s ${deviceId} shell "am force-stop ${PKG}"`,
        { timeout: 5000, windowsHide: true }
      );
    } catch (e) { /* ignore */ }
  }

  /** Wait for game to fully load (PID appears + stays) */
  async _waitForGame(deviceId, timeout) {
    const start = Date.now();
    let lastPid = null;
    while (Date.now() - start < timeout) {
      const pid = this._getPid(deviceId);
      if (pid) {
        if (lastPid === pid) {
          // PID stable → game loaded
          console.log(`[Watchdog] Game loaded (PID ${pid})`);
          return pid;
        }
        lastPid = pid;
      }
      await sleep(2000);
    }
    return null;
  }

  /** Main check loop */
  async _check() {
    if (!this._running) return;

    // Auto-detect device if not set
    if (!this.deviceId) {
      const detected = this._detectDevice();
      if (detected) {
        this.deviceId = detected.deviceId;
        this._lastPid = detected.pid;
      }
    }

    if (!this.deviceId) {
      console.log('[Watchdog] No device found, retrying...');
      this._scheduleNext();
      return;
    }

    const pid = this._getPid(this.deviceId);

    if (!pid && this._lastPid) {
      console.log(`[Watchdog] [WARN] Game CRASHED! (was PID ${this._lastPid})`);
      this._restartCount++;
      
      if (this.onCrash) this.onCrash(this.deviceId, this._restartCount);

      if (this._restartCount > this.maxRestarts) {
        console.log(`[Watchdog] [ERROR] Max restarts (${this.maxRestarts}) reached. Giving up.`);
        if (this.onGiveUp) this.onGiveUp(this.deviceId, 'max_restarts');
        this.stop();
        return;
      }

      // Restart
      console.log(`[Watchdog] Restarting (attempt ${this._restartCount}/${this.maxRestarts})...`);
      await sleep(this.restartDelay);
      
      // Force stop first (clean state)
      this._stopGame(this.deviceId);
      await sleep(2000);

      // Start game
      if (!this._startGame(this.deviceId)) {
        console.log('[Watchdog] Failed to start, will retry next cycle');
        this._scheduleNext();
        return;
      }

      // Wait for game to load
      console.log(`[Watchdog] Waiting for game to load (max ${this.loadWait / 1000}s)...`);
      const newPid = await this._waitForGame(this.deviceId, this.loadWait);
      
      if (newPid) {
        this._lastPid = newPid;
        console.log(`[Watchdog] [SUCCESS] Game restarted! PID ${newPid}`);
        if (this.onRestart) this.onRestart(this.deviceId, newPid);
      } else {
        console.log('[Watchdog] [WARN] Game did not start in time, will retry');
      }
    } else if (pid) {
      // Game alive
      if (pid !== this._lastPid) {
        console.log(`[Watchdog] Game PID changed: ${this._lastPid} → ${pid}`);
        this._lastPid = pid;
      }
    }
    // else: no pid and no lastPid = game never started yet, keep waiting

    this._scheduleNext();
  }

  _scheduleNext() {
    if (!this._running) return;
    this._timer = setTimeout(() => this._check(), this.checkInterval);
  }

  /** Start watchdog */
  start() {
    if (this._running) return;
    this._running = true;
    this._restartCount = 0;
    console.log('[Watchdog] Started. Monitoring game...');
    this._check();
  }

  /** Stop watchdog */
  stop() {
    this._running = false;
    if (this._timer) {
      clearTimeout(this._timer);
      this._timer = null;
    }
    console.log('[Watchdog] Stopped.');
  }

  /** Get current status */
  getStatus() {
    return {
      running: this._running,
      deviceId: this.deviceId,
      lastPid: this._lastPid,
      restartCount: this._restartCount,
      maxRestarts: this.maxRestarts,
    };
  }
}

// ==================== Standalone Runner ====================
if (require.main === module) {
  console.log('═══════════════════════════════════════');
  console.log('  Game Watchdog — Auto-restart on crash');
  console.log('  Press Ctrl+C to stop');
  console.log('═══════════════════════════════════════\n');

  const watchdog = new GameWatchdog(null, {
    onCrash: (dev, count) => {
      console.log(`  [CRASH] Game on ${dev} crashed! Restart #${count}`);
    },
    onRestart: (dev, pid) => {
      console.log(`  [SUCCESS] Game restarted on ${dev} (PID ${pid})`);
      console.log('  You may now re-attach Frida.');
    },
    onGiveUp: (dev, reason) => {
      console.log(`  [ERROR] Watchdog giving up on ${dev}: ${reason}`);
      process.exit(1);
    },
  });

  // Graceful shutdown
  process.on('SIGINT', () => {
    console.log('\n[Watchdog] Shutting down...');
    watchdog.stop();
    process.exit(0);
  });

  watchdog.start();
}

// ==================== Exports ====================
function sleep(ms) { return new Promise(r => setTimeout(r, ms)); }
module.exports = { GameWatchdog };
