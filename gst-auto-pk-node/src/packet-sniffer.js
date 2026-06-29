// src/packet-sniffer.js -- Packet Sniffing and Socket Auto-Reheal Module (Step 4)
const { EventEmitter } = require('events');

class PacketSniffer extends EventEmitter {
  /**
   * @param {FridaSession} session
   */
  constructor(session) {
    super();
    this.session = session;
    this.recvBuffer = [];
    this.gameFd = -1;
    this.lastRecvTs = Date.now();
    this.lastFdReheal = Date.now();
    this.isPolling = false;
    this.pollTimer = null;
  }

  /**
   * Re-detect game socket file descriptor based on active message traffic opcodes.
   */
  async redetectFdByTraffic() {
    try {
      const res = await this.session.callRpc('pick_best_fd');
      if (res && res.ok && res.fd > 0) {
        const fd = parseInt(res.fd, 10);
        if (fd !== this.gameFd) {
          console.log(`[PacketSniffer] FD change detected by traffic: ${this.gameFd} -> ${fd}`);
          try {
            await this.session.callRpc('set_game_fd', fd);
          } catch (err) {
            // set_game_fd might not be directly exported or named lockFd
            await this.session.callRpc('lockFd', fd);
          }
          this.gameFd = fd;
          return true;
        }
      }
    } catch (e) {
      // Quiet fail if RPC not exported yet
    }
    return false;
  }

  /**
   * Poll packets from Frida buffer and handle socket health checks.
   */
  async pollRecv() {
    try {
      const res = await this.session.callRpc('getRecvPackets');
      let pkts = [];
      if (res && res.ok && res.packets) {
        pkts = res.packets;
      }

      // Fallback/extra: dialog packets (opcode 34, 124, 126, 166, 245)
      try {
        const dres = await this.session.callRpc('get_dialog_packets');
        if (dres && dres.ok && dres.packets && dres.packets.length > 0) {
          const existingHexs = new Set(pkts.map(p => p.hex));
          for (const dpkt of dres.packets) {
            if (!existingHexs.has(dpkt.hex)) {
              pkts.push(dpkt);
            }
          }
        }
      } catch (e) {
        // No-op if get_dialog_packets RPC is not present
      }

      const now = Date.now();
      const fdSuspicious = (this.gameFd >= 0 && this.gameFd <= 10);

      if (pkts.length > 0 && !fdSuspicious) {
        this.lastRecvTs = now;
      } else {
        const idleGap = fdSuspicious ? 3000 : 10000;
        if ((now - this.lastRecvTs > idleGap || fdSuspicious) && (now - this.lastFdReheal > idleGap)) {
          this.lastFdReheal = now;
          const changed = await this.redetectFdByTraffic();
          if (changed) {
            this.lastRecvTs = now;
          }
        }
      }

      if (pkts.length > 0) {
        this.recvBuffer.push(...pkts);
        if (this.recvBuffer.length > 3000) {
          this.recvBuffer = this.recvBuffer.slice(-3000);
        }
        for (const pkt of pkts) {
          this.emit('packet', pkt);
        }
      }
    } catch (e) {
      // Quiet fail to prevent console spamming
    }
  }

  /**
   * Start polling loop.
   */
  start(interval = 200) {
    if (this.isPolling) return;
    this.isPolling = true;
    this.lastRecvTs = Date.now();
    this.lastFdReheal = Date.now();
    
    const run = async () => {
      if (!this.isPolling) return;
      await this.pollRecv();
      this.pollTimer = setTimeout(run, interval);
    };
    run();
  }

  /**
   * Stop polling loop.
   */
  stop() {
    this.isPolling = false;
    if (this.pollTimer) {
      clearTimeout(this.pollTimer);
      this.pollTimer = null;
    }
  }

  clear() {
    this.recvBuffer = [];
  }

  /**
   * Wait for a specific packet opcode or name to arrive.
   * @param {string|number|Array} opcodes
   * @param {number} timeout
   */
  async waitForPacket(opcodes, timeout = 3000) {
    const targets = Array.isArray(opcodes) ? opcodes : [opcodes];
    const startTime = Date.now();
    
    while (Date.now() - startTime < timeout) {
      await this.pollRecv();
      const foundIdx = this.recvBuffer.findIndex(p => targets.includes(p.name) || targets.includes(p.opcode));
      if (foundIdx !== -1) {
        const pkt = this.recvBuffer[foundIdx];
        this.recvBuffer.splice(foundIdx, 1);
        return pkt;
      }
      await new Promise(r => setTimeout(r, 100));
    }
    return null;
  }
}

module.exports = { PacketSniffer };
