// src/frida-session.js — Frida Session Manager
// Quản lý: ADB forward → remote device → attach by PID → load script → RPC

let frida = null;
const fs = require('fs');
const path = require('path');
const { execSync } = require('child_process');
const config = require('../config');

class FridaSession {
  /**
   * @param {string|null} deviceId - ADB device ID, or null to auto-detect
   * @param {string} packageName - Game package name
   */
  constructor(deviceId, packageName) {
    this.deviceId = deviceId || config.DEVICE_ID || null; // fallback to config
    this.packageName = packageName;
    this.device = null;
    this.session = null;
    this.script = null;
    this._messageHandlers = [];
    this._connected = false;
  }

  /** Get game PID via ADB (auto-detect device if needed) */
  _getGamePid() {
    try {
      const adb = require('./adb');
      const devices = adb.listDevices();
      const isConnected = devices.some(d => d.id === this.deviceId);
      
      if (this.deviceId && isConnected) {
        return adb.getGamePid(this.deviceId);
      } else {
        // Auto-detect: find first device running the game
        const detected = adb.detectDevice();
        if (detected) {
          this.deviceId = detected.deviceId;
          return detected.pid;
        }
        return null;
      }
    } catch (e) {
      return null;
    }
  }

  /** Ensure ADB forward for Frida port */
  _setupForward() {
    try {
      const adb = require('./adb');
      const devices = adb.listDevices();
      const isConnected = devices.some(d => d.id === this.deviceId);
      
      if (!this.deviceId || !isConnected) {
        const detected = adb.detectDevice();
        if (detected) {
          this.deviceId = detected.deviceId;
        }
      }
      
      if (!this.deviceId) throw new Error('No active device found');
      // Assign a unique local port for this device instance to support multi-account
      this.localPort = 27000 + Math.floor(Math.random() * 5000);
      const { execFileSync } = require('child_process');
      execFileSync(config.ADB_PATH, ['-s', this.deviceId, 'forward', `tcp:${this.localPort}`, 'tcp:27042'], { timeout: 5000, windowsHide: true });
      console.log(`[Frida] ADB forward tcp:${this.localPort} -> 27042 OK (${this.deviceId})`);
    } catch (e) {
      // Forward may already exist, or adb might complain.
      if (!this.localPort) this.localPort = 27042;
    }
  }

  /** Kết nối đến game qua Frida */
  async connect() {
    // Always ensure ADB forward is set up correctly first (dynamic/self-healing)
    this._setupForward();
    
    if (!frida) {
      frida = await import('frida');
    }
    const deviceManager = frida.getDeviceManager();
    try {
      this.device = await Promise.race([
        deviceManager.addRemoteDevice(`127.0.0.1:${this.localPort}`),
        new Promise((_, reject) => setTimeout(() => reject(new Error('addRemoteDevice timed out')), 5000))
      ]);
      console.log(`[Frida] Remote device connected: ${this.device.name} via port ${this.localPort}`);
    } catch (e) {
      console.warn(`[Frida] addRemoteDevice failed or timed out: ${e.message}. Retrying...`);
      this.device = await Promise.race([
        deviceManager.addRemoteDevice(`127.0.0.1:${this.localPort}`),
        new Promise((_, reject) => setTimeout(() => reject(new Error('addRemoteDevice retry timed out')), 5000))
      ]);
    }

    // 2. Discover target PID directly from active Frida processes list (100% ADB-independent)
    let pid = null;
    try {
      const processes = await this.device.enumerateProcesses();
      const gameProc = processes.find(p => p.name === 'VLTieuNgao' || p.name === 'vn.perfingame.jx1mobile');
      if (gameProc) {
        pid = gameProc.pid;
        console.log(`[Frida] Auto-detected game process: ${gameProc.name} (PID: ${pid})`);
      }
    } catch (err) {
      console.warn(`[Frida] Remote process discovery warning: ${err.message}`);
    }

    // 3. Fallback to ADB discovery if Frida query didn't find the PID
    if (!pid) {
      pid = this._getGamePid();
    }

    if (!pid) {
      throw new Error(`Game package ${this.packageName} (VLTieuNgao) not found or not running. Please start the game.`);
    }

    // 4. Attach by PID with timeout to prevent GUI hanging
    console.log(`[Frida] Attaching to PID ${pid}...`);
    try {
      this.session = await Promise.race([
        this.device.attach(pid),
        new Promise((_, reject) => setTimeout(() => reject(new Error('Attach timed out after 10s. Game might be frozen or frida-server is stuck.')), 10000))
      ]);
      console.log('[Frida] Session created OK');
    } catch (attachErr) {
      throw new Error(`Failed to attach: ${attachErr.message}. Try restarting the game or emulator.`);
    }
    this._connected = true;
    return true;
  }

  /** Load Frida script từ file .js */
  async loadScript(scriptPath) {
    if (!this.session) throw new Error('Not connected. Call connect() first.');
    const source = fs.readFileSync(scriptPath, 'utf-8');
    console.log(`[Frida] Loading script: ${path.basename(scriptPath)} (${source.length} bytes)`);
    this.script = await this.session.createScript(source);
    this.script.message.connect((message, data) => { this._onMessage(message, data); });
    await this.script.load();
    console.log('[Frida] Script loaded OK');
    return this.script;
  }

  /**
   * Load Il2Cpp bridge as a separate agent script (safer — avoids crash from bundling).
   * Must be called BEFORE loadScript().
   */
  async loadBridge() {
    if (!this.session) throw new Error('Not connected. Call connect() first.');
    try {
      // Try loading the bridge as a separate script first
      const bridgeSource = `
        var _bridgeReady = false;
        try {
          // frida-il2cpp-bridge global init
          if (typeof Il2Cpp === 'undefined') {
            send({ type: 'bridge', status: 'loading' });
          }
        } catch(e) {
          send({ type: 'bridge', error: e.toString() });
        }
      `;
      const brScript = await this.session.createScript(bridgeSource);
      await brScript.load();
      console.log('[Frida] Bridge placeholder loaded (Il2Cpp bridge via --bridge build)');
    } catch (e) {
      console.log('[Frida] Bridge load skipped:', e.message);
    }
  }

  /** Xử lý message từ Frida script */
  _onMessage(message, data) {
    if (message.type === 'send') {
      const payload = message.payload;
      // Forward cho tất cả handlers
      for (const handler of this._messageHandlers) {
        try {
          handler(payload, data);
        } catch (e) {
          console.error('[Frida] Handler error:', e.message);
        }
      }
    } else if (message.type === 'error') {
      console.error('[Frida] Script error:', message.description, '\nStack:', message.stack);
    } else if (message.type === 'log') {
      // Forward logs as well
      for (const handler of this._messageHandlers) {
        try {
          handler({ log: message.payload }, data);
        } catch (e) {
          console.error('[Frida] Handler error:', e.message);
        }
      }
    }
  }

  /** Đăng ký handler nhận message từ Frida script */
  onMessage(handler) {
    this._messageHandlers.push(handler);
  }

  /** Gọi RPC export từ script */
  async callRpc(method, ...args) {
    if (!this.script) throw new Error('No script loaded');
    const p = this.script.exports[method](...args);
    return await Promise.race([
      p,
      new Promise((_, reject) => setTimeout(() => reject(new Error(`RPC ${method} timed out`)), 30000))
    ]);
  }

  /** Disconnect */
  async disconnect() {
    if (this.script) {
      await this.script.unload();
      this.script = null;
    }
    if (this.session) {
      await this.session.detach();
      this.session = null;
    }
    this._connected = false;
    console.log('[Frida] Disconnected');
  }

  get connected() {
    return this._connected;
  }
}

module.exports = { FridaSession };
