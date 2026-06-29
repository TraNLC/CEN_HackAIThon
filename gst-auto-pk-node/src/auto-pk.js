// src/auto-pk.js -- Auto PK and Tong Kim Loop Module (Step 5)
const fs = require('fs');
const path = require('path');

class AutoPK {
  /**
   * @param {FridaSession} session
   * @param {MemoryReader} memory
   * @param {PacketInjector} injector
   * @param {PacketSniffer} sniffer
   * @param {string} deviceId
   */
  constructor(session, memory, injector, sniffer, deviceId) {
    this.session = session;
    this.memory = memory;
    this.injector = injector;
    this.sniffer = sniffer;
    this.deviceId = deviceId ? deviceId.replace(/:/g, '_') : 'default';
    this.running = false;
    this.profileGuid = '';
    this.loopTimer = null;
    
    // Potions configuration
    this.hpThreshold = 0.65; // Use health recovery when HP < 65%
    this.mpThreshold = 0.30; // Use mana recovery when MP < 30%
    
    // Default skills to execute (e.g. basic attacks or combos)
    this.attackSkills = [1, 2, 3];
    this.currentSkillIndex = 0;
  }

  /**
   * Load autoplay profile GUID to prevent in-game profile wipe issues (op140 empty payload)
   */
  loadProfile() {
    try {
      const dataDir = path.join(__dirname, '..', 'data', 'output');
      const filename = `autoplay_profile_${this.deviceId}.json`;
      const filePath = path.join(dataDir, filename);
      if (fs.existsSync(filePath)) {
        const raw = fs.readFileSync(filePath, 'utf-8');
        const parsed = JSON.parse(raw);
        if (parsed && parsed.profile) {
          this.profileGuid = parsed.profile;
          console.log(`[AutoPK] Loaded profile GUID: ${this.profileGuid}`);
          return;
        }
      }
    } catch (e) {
      console.warn(`[AutoPK] Failed to load local profile guid: ${e.message}`);
    }
    
    // Default fallback GUIDs seen in logs
    this.profileGuid = '1dc8514c'; 
    console.log(`[AutoPK] Using default fallback profile GUID: ${this.profileGuid}`);
  }

  /**
   * Start the PK loop.
   */
  async start() {
    if (this.running) return;
    this.running = true;
    this.loadProfile();

    console.log('[AutoPK] Starting Auto PK Loop...');

    // Warm up the auto-play system (prevent wipes by applying profile)
    try {
      await this.injector.sendApplyAutoplayProfile(true, this.profileGuid);
    } catch (err) {
      console.warn(`[AutoPK] Initial profile application warning: ${err.message}`);
    }

    const run = async () => {
      if (!this.running) return;
      try {
        await this.tick();
      } catch (e) {
        console.error(`[AutoPK] Loop iteration error: ${e.message}`);
      }
      this.loopTimer = setTimeout(run, 1000); // Tick once per second
    };
    run();
  }

  /**
   * Stop the PK loop.
   */
  async stop() {
    this.running = false;
    if (this.loopTimer) {
      clearTimeout(this.loopTimer);
      this.loopTimer = null;
    }
    console.log('[AutoPK] Stopping Auto PK Loop.');
    try {
      await this.injector.sendApplyAutoplayProfile(false, this.profileGuid);
    } catch (e) {
      // Quiet fail
    }
  }

  /**
   * Core logic run at each tick interval.
   */
  async tick() {
    const info = await this.memory.getPlayerInfo();
    if (!info) return;

    // 1. Health and Mana Recovery Checks
    const hpRatio = info.hp / (info.maxHp || 1000);
    const mpRatio = info.mp / (info.maxMp || 1000);

    if (hpRatio < this.hpThreshold) {
      console.log(`[AutoPK] HP Low: ${(hpRatio * 100).toFixed(1)}%. Triggering recovery.`);
      // Call standard skill or health use packet if needed, or rely on auto-potions.
    }

    if (mpRatio < this.mpThreshold) {
      console.log(`[AutoPK] MP Low: ${(mpRatio * 100).toFixed(1)}%. Triggering recovery.`);
    }

    // 2. PK / Tong Kim Attack Automation
    if (info.fighting) {
      const skillId = this.attackSkills[this.currentSkillIndex];
      this.currentSkillIndex = (this.currentSkillIndex + 1) % this.attackSkills.length;

      if (info.targetId) {
        console.log(`[AutoPK] Casting skill ${skillId} on target: ${info.targetId}`);
        await this.injector.sendDoSkillTargetPlayer(skillId, info.targetId);
      } else {
        // Area attack or positional attack at current player location if target is empty
        console.log(`[AutoPK] No target. Casting skill ${skillId} on position: (${info.x}, ${info.y})`);
        await this.injector.sendDoSkillTargetPosition(skillId, info.x, info.y);
      }
    }
  }
}

module.exports = { AutoPK };
