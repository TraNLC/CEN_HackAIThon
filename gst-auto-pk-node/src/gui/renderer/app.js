// UI Elements
const btnRefresh = document.getElementById('btn-refresh');
const btnRestart = document.getElementById('btn-restart');
const deviceTableBody = document.getElementById('device-table-body');

const pkFightSwitch = document.getElementById('pk-fight-switch');
const tkSideSelect = document.getElementById('tk-side-select');
const lacSelects = [
  document.getElementById('lac-1-select'),
  document.getElementById('lac-2-select'),
  document.getElementById('lac-3-select')
];

const globalLogContainer = document.getElementById('global-log-container');
const btnClearLog = document.getElementById('btn-clear-log');

// State
let devicesMap = new Map(); // id -> { name, status, info }

function addLog(msg, type = 'info') {
  const entry = document.createElement('div');
  entry.className = `log-entry log-${type}`;
  entry.innerText = msg;
  globalLogContainer.appendChild(entry);
  globalLogContainer.scrollTop = globalLogContainer.scrollHeight;
}

btnClearLog.addEventListener('click', () => {
  globalLogContainer.innerHTML = '';
  addLog('[System] Log cleared.', 'system');
});

// Setup IPC Listeners
window.api.onTabLog((data) => {
  addLog(data.msg, data.type);
});

window.api.onPlayerInfoUpdate(({ deviceId, info }) => {
  if (devicesMap.has(deviceId)) {
    const dev = devicesMap.get(deviceId);
    dev.info = info;
    renderTable();
  }
});

// Device Scanning & Rendering
async function scanDevices() {
  deviceTableBody.innerHTML = '<tr><td colspan="4" style="text-align: center;">Dang quet thiet bi...</td></tr>';
  const res = await window.api.scanDevices();
  if (!res.ok) {
    addLog(`[System] Quet thiet bi that bai: ${res.error}`, 'error');
    deviceTableBody.innerHTML = '<tr><td colspan="4" style="text-align: center; color: red;">Loi khi quet thiet bi!</td></tr>';
    return;
  }
  
  if (res.devices.length === 0) {
    deviceTableBody.innerHTML = '<tr><td colspan="4" style="text-align: center; color: #888;">Khong tim thay thiet bi (Gia lap) nao.</td></tr>';
    return;
  }

  // Preserve existing connections
  const newMap = new Map();
  for (const d of res.devices) {
    if (devicesMap.has(d.id)) {
      newMap.set(d.id, devicesMap.get(d.id));
    } else {
      newMap.set(d.id, { name: d.id, connected: false, info: null });
    }
  }
  devicesMap = newMap;
  renderTable();
  addLog(`[System] Tim thay ${devicesMap.size} thiet bi.`, 'system');
}

function renderTable() {
  deviceTableBody.innerHTML = '';
  for (const [id, dev] of devicesMap.entries()) {
    const tr = document.createElement('tr');
    
    // Toggle
    const tdToggle = document.createElement('td');
    tdToggle.style.textAlign = 'center';
    const label = document.createElement('label');
    label.className = 'switch';
    const input = document.createElement('input');
    input.type = 'checkbox';
    input.checked = dev.connected;
    input.addEventListener('change', async (e) => {
      const connect = e.target.checked;
      dev.connected = connect;
      if (!connect) dev.info = null; // reset info on disconnect
      renderTable();
      await window.api.toggleDevice(id, connect);
    });
    const span = document.createElement('span');
    span.className = 'slider round';
    label.appendChild(input);
    label.appendChild(span);
    tdToggle.appendChild(label);
    
    // Name
    const tdName = document.createElement('td');
    if (dev.info && dev.info.name) {
      tdName.innerHTML = `<strong>${dev.info.name}</strong> <br><small style="color: #888;">Lv.${dev.info.level || '?'} &bull; ${dev.info.sectName || 'Chưa rõ'}</small>`;
    } else {
      tdName.innerText = dev.connected ? 'Dang doc...' : '—';
    }
    
    // Score / Map
    const tdScore = document.createElement('td');
    if (dev.info) {
      // Create HP/MP bars instead of just score
      const hp = dev.info.hp || 0, hpMax = dev.info.hpMax || 1;
      const mp = dev.info.mp || 0, mpMax = dev.info.mpMax || 1;
      const hpPct = Math.min(100, Math.max(0, (hp / hpMax) * 100));
      const mpPct = Math.min(100, Math.max(0, (mp / mpMax) * 100));
      
      tdScore.innerHTML = `
        <div class="hp-mp-container">
          <div style="font-size: 11px; margin-bottom: 2px;">Map: <span class="highlight-text">${dev.info.mapId || '?'}</span></div>
          <div class="mini-bar-bg"><div class="mini-bar-fill hp" style="width: ${hpPct}%"></div></div>
          <div class="mini-bar-bg"><div class="mini-bar-fill mp" style="width: ${mpPct}%"></div></div>
        </div>
      `;
    } else {
      tdScore.innerText = '—';
    }
    
    // Device ID
    const tdId = document.createElement('td');
    tdId.innerText = id;
    if (dev.connected) tdId.style.color = 'hsl(145, 63%, 49%)';
    
    tr.appendChild(tdToggle);
    tr.appendChild(tdName);
    tr.appendChild(tdScore);
    tr.appendChild(tdId);
    deviceTableBody.appendChild(tr);
  }
}

// Event Listeners
btnRefresh.addEventListener('click', scanDevices);

btnRestart.addEventListener('click', () => {
  addLog('[System] Khoi dong lai toan bo ket noi...', 'warn');
  for (const [id, dev] of devicesMap.entries()) {
    if (dev.connected) {
      dev.connected = false;
      window.api.toggleDevice(id, false);
    }
  }
  pkFightSwitch.checked = false;
  updateGlobalTK();
  setTimeout(scanDevices, 1000);
});

// Auto TK Logic
function updateGlobalTK() {
  const enable = pkFightSwitch.checked;
  const side = tkSideSelect.value;
  const lacs = lacSelects.map(s => s.value).filter(v => v !== 'none');
  window.api.toggleAutoTK(enable, side, lacs);
}

pkFightSwitch.addEventListener('change', updateGlobalTK);
tkSideSelect.addEventListener('change', updateGlobalTK);
lacSelects.forEach(s => s.addEventListener('change', updateGlobalTK));

// Init
scanDevices();

// NPC Chat Test
['23', '2581', '2593'].forEach(npcId => {
  const btn = document.getElementById(`btn-test-npc-${npcId}`);
  if (btn) {
    btn.addEventListener('click', () => {
      window.api.testChatNpc(npcId);
    });
  }
});
