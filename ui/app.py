"""
app.py — Flask backend cho VLTK1 Bot Toolkit UI
Chạy: python ui/app.py  →  http://localhost:5000
"""

import csv
import json
import subprocess
import sys
import threading
import time
from pathlib import Path

import yaml
from flask import Flask, jsonify, render_template, request

ROOT = Path(__file__).parent.parent
sys.path.insert(0, str(ROOT / "bot"))
sys.path.insert(0, str(ROOT / "analysis"))

app = Flask(__name__)

# ── Shared state ──
_lock    = threading.Lock()
_slots   = {}
_running = False
_config  = {}
_accounts= []
_capture_proc  = None
_capture_stats = {'send_count': 0, 'recv_count': 0, 'last_line': '', 'files': []}
_notes   = {}   # opcode → note string

# ─────────────────────────────────────────────────────
# Helpers
# ─────────────────────────────────────────────────────

def _run(cmd) -> tuple[int, str]:
    r = subprocess.run(cmd, shell=True, capture_output=True, text=True, cwd=ROOT)
    return r.returncode, r.stdout + r.stderr

def _load_config():
    global _config, _accounts
    cfg = ROOT / "config.yaml"
    acc = ROOT / "accounts.csv"
    if cfg.exists():
        _config = yaml.safe_load(cfg.read_text(encoding='utf-8')) or {}
    if acc.exists():
        with open(acc, encoding='utf-8') as f:
            _accounts = list(csv.DictReader(f))

def _setting_file():
    return ROOT / ".toolkit_settings"

def _load_setting(key):
    sf = _setting_file()
    if not sf.exists(): return None
    for line in sf.read_text().splitlines():
        if '=' in line:
            k, v = line.split('=', 1)
            if k.strip() == key: return v.strip()
    return None

def _save_setting(key, value):
    sf = _setting_file()
    settings = {}
    if sf.exists():
        for line in sf.read_text().splitlines():
            if '=' in line:
                k, v = line.split('=', 1)
                settings[k.strip()] = v.strip()
    settings[key] = str(value)
    sf.write_text('\n'.join(f"{k}={v}" for k, v in settings.items()))

# ─────────────────────────────────────────────────────
# Routes — Pages
# ─────────────────────────────────────────────────────

@app.route("/")
def index():
    return render_template("index.html")

# ─────────────────────────────────────────────────────
# Routes — Setup
# ─────────────────────────────────────────────────────

@app.route("/api/check_deps")
def check_deps():
    def chk(cmd): return subprocess.run(cmd, shell=True, capture_output=True).returncode == 0
    return jsonify({
        'python': sys.version_info >= (3, 10),
        'adb':    chk("adb version"),
        'frida':  chk("python -c \"import frida\""),
        'flask':  chk("python -c \"import flask\""),
    })

@app.route("/api/check_all")
def check_all():
    def chk(cmd): return subprocess.run(cmd, shell=True, capture_output=True).returncode == 0
    serial  = _load_setting('emulator_serial')
    package = _load_setting('vltk_package')
    em_ok   = False
    if serial:
        code, _ = _run(f"adb -s {serial} shell echo ok")
        em_ok = (code == 0)
    return jsonify({
        'python':   sys.version_info >= (3, 10),
        'adb':      chk("adb version"),
        'frida':    chk("python -c \"import frida\""),
        'emulator': em_ok,
        'package':  bool(package),
    })

@app.route("/api/install_deps", methods=["POST"])
def install_deps():
    code, out = _run("pip install frida frida-tools flask pyyaml")
    return jsonify({'ok': code == 0, 'output': out[:2000]})

@app.route("/api/connect_emulator", methods=["POST"])
def connect_emulator():
    port = request.json.get('port', '5555')
    _run(f"adb connect 127.0.0.1:{port}")
    # Try common ports too
    for p in [5554, 5556, 5558, 21503, 62001]:
        _run(f"adb connect 127.0.0.1:{p}")
    code, out = _run("adb devices")
    serial = None
    for line in out.splitlines():
        if '\tdevice' in line:
            serial = line.split('\t')[0].strip()
            break
    if serial:
        _, arch = _run(f"adb -s {serial} shell getprop ro.product.cpu.abi")
        arch = arch.strip()
        _save_setting('emulator_serial', serial)
        _save_setting('emulator_arch', arch)
        return jsonify({'ok': True, 'serial': serial, 'arch': arch})
    return jsonify({'ok': False, 'msg': 'Không tìm thấy emulator. Bật ADB trong LDPlayer Settings.'})

@app.route("/api/find_package")
def find_package():
    serial = _load_setting('emulator_serial')
    if not serial:
        return jsonify({'packages': [], 'msg': 'Chưa kết nối emulator'})
    _, out = _run(f"adb -s {serial} shell pm list packages")
    pkgs = []
    for line in out.splitlines():
        pkg = line.replace('package:', '').strip()
        if any(k in pkg.lower() for k in ['vltk', 'vinagame', 'snail', 'vng', 'wiski']):
            pkgs.append(pkg)
    if pkgs:
        _save_setting('vltk_package', pkgs[0])
    return jsonify({'packages': pkgs})

@app.route("/api/setup_frida", methods=["POST"])
def setup_frida():
    serial = _load_setting('emulator_serial')
    if not serial:
        return jsonify({'ok': False, 'output': 'Chưa kết nối emulator'})

    frida_dir = ROOT / "frida"
    candidates = list(frida_dir.glob("frida-server*"))
    candidates = [c for c in candidates if c.suffix not in ('.py', '.js')]
    if not candidates:
        return jsonify({'ok': False, 'output': f'Không tìm thấy frida-server binary trong {frida_dir}\nTải tại: github.com/frida/frida/releases'})

    local_bin = candidates[0]
    log = f"Dùng: {local_bin.name}\n"

    _run(f"adb -s {serial} shell su -c 'pkill -f frida-server' 2>/dev/null")
    time.sleep(0.5)
    _run(f'adb -s {serial} push "{local_bin}" /data/local/tmp/frida-server')
    _run(f"adb -s {serial} shell chmod 755 /data/local/tmp/frida-server")
    _run(f"adb -s {serial} shell su -c '/data/local/tmp/frida-server &'")
    time.sleep(2)

    _, ps = _run(f"adb -s {serial} shell ps 2>/dev/null")
    running = 'frida-server' in ps
    log += '✓ frida-server đang chạy!' if running else '✗ Không start được — thử thủ công trong emulator'
    return jsonify({'ok': running, 'output': log})

@app.route("/api/frida_status")
def frida_status():
    serial = _load_setting('emulator_serial')
    if not serial:
        return jsonify({'running': False})
    _, out = _run(f"adb -s {serial} shell ps 2>/dev/null")
    return jsonify({'running': 'frida-server' in out})

# ─────────────────────────────────────────────────────
# Routes — Detect engine
# ─────────────────────────────────────────────────────

@app.route("/api/detect_engine", methods=["POST"])
def detect_engine():
    serial  = _load_setting('emulator_serial')
    package = _load_setting('vltk_package')
    if not serial or not package:
        return jsonify({'ok': False, 'msg': 'Chưa kết nối emulator hoặc chưa có package'})
    try:
        import importlib.util
        spec = importlib.util.spec_from_file_location(
            "detect_engine", ROOT / "analysis" / "detect_engine.py")
        mod = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(mod)

        apk_path = mod.pull_apk(serial, package)
        if not apk_path:
            return jsonify({'ok': False, 'msg': f'Không pull được APK của {package}'})
        result = mod.analyze_apk(apk_path)
        result['ok'] = True
        return jsonify(result)
    except Exception as e:
        return jsonify({'ok': False, 'msg': str(e)})

# ─────────────────────────────────────────────────────
# Routes — Capture
# ─────────────────────────────────────────────────────

@app.route("/api/start_capture", methods=["POST"])
def start_capture():
    global _capture_proc
    mode    = request.json.get('type', 'socket')
    package = _load_setting('vltk_package')
    if not package:
        return jsonify({'ok': False, 'msg': 'Chưa có package VLTK'})

    script = 'frida/capture.py' if mode == 'socket' else 'frida/capture_java.py'
    _capture_stats.update({'send_count': 0, 'recv_count': 0, 'last_line': ''})

    _capture_proc = subprocess.Popen(
        f"python {script} --attach {package}",
        shell=True, cwd=ROOT,
        stdout=subprocess.PIPE, stderr=subprocess.STDOUT,
        text=True, bufsize=1
    )

    def _reader():
        for line in _capture_proc.stdout:
            line = line.strip()
            if not line: continue
            _capture_stats['last_line'] = line
            if 'SEND' in line: _capture_stats['send_count'] += 1
            if 'RECV' in line: _capture_stats['recv_count'] += 1

    threading.Thread(target=_reader, daemon=True).start()
    return jsonify({'ok': True})

@app.route("/api/stop_capture", methods=["POST"])
def stop_capture():
    global _capture_proc
    if _capture_proc:
        _capture_proc.terminate()
        _capture_proc = None
    files = [f.name for f in (ROOT / "captures").glob("*.bin") if f.exists()]
    return jsonify({'ok': True, 'files': files})

@app.route("/api/capture_status")
def capture_status():
    return jsonify(_capture_stats)

@app.route("/api/capture_files")
def capture_files():
    cap_dir = ROOT / "captures"
    files = []
    if cap_dir.exists():
        for f in sorted(cap_dir.glob("*.bin"), key=lambda x: x.stat().st_mtime, reverse=True):
            files.append({'name': f.name, 'size': f.stat().st_size})
    return jsonify({'files': files})

# ─────────────────────────────────────────────────────
# Routes — Analyze
# ─────────────────────────────────────────────────────

@app.route("/api/analyze", methods=["POST"])
def analyze():
    file    = request.json.get('file')
    opcode  = request.json.get('opcode')
    cap_dir = ROOT / "captures"
    path    = cap_dir / file
    if not path.exists():
        return jsonify({'ok': False, 'msg': f'File không tồn tại: {file}'})

    try:
        import importlib.util
        spec = importlib.util.spec_from_file_location(
            "packet_parser", ROOT / "analysis" / "packet_parser.py")
        mod = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(mod)

        data = path.read_bytes()
        # Auto-detect format
        best_fmt = mod.PacketParser.detect_format(data) or 'A'
        parser   = mod.PacketParser(best_fmt)
        packets  = parser.parse(data)

        if opcode:
            op_int  = int(opcode, 0)
            packets = [p for p in packets if p.opcode == op_int]
            return jsonify({'ok': True, 'packets': [
                {'opcode': p.opcode, 'payload': p.payload.hex(' ')} for p in packets[:20]
            ]})

        from collections import Counter
        counts = Counter(p.opcode for p in packets)
        result = []
        for op, cnt in sorted(counts.items()):
            avg = sum(len(p.payload) for p in packets if p.opcode == op) / cnt
            note = _notes.get(op, '')
            result.append({'opcode': op, 'count': cnt, 'avg_size': avg, 'note': note})

        return jsonify({'ok': True, 'format': best_fmt, 'total': len(packets), 'opcodes': result})
    except Exception as e:
        return jsonify({'ok': False, 'msg': str(e)})

@app.route("/api/save_note", methods=["POST"])
def save_note():
    op   = request.json.get('opcode')
    note = request.json.get('note', '')
    _notes[op] = note
    # Persist to opcode_map.yaml
    try:
        opmap = ROOT / "analysis" / "opcode_map.yaml"
        data  = yaml.safe_load(opmap.read_text(encoding='utf-8')) or {}
        data.setdefault('notes_ui', {})[str(op)] = note
        opmap.write_text(yaml.dump(data, allow_unicode=True), encoding='utf-8')
    except Exception:
        pass
    return jsonify({'ok': True})

# ─────────────────────────────────────────────────────
# Routes — Config
# ─────────────────────────────────────────────────────

@app.route("/api/config")
def get_config():
    _load_config()
    return jsonify(_config)

@app.route("/api/save_config", methods=["POST"])
def save_config():
    d = request.json
    # Update config.yaml
    cfg = {
        'server': {'host': d.get('host', ''), 'port': d.get('port', 0)},
        'pool':   {'max_workers': 20},
        'quests': {'da_tau': {
            'npc_id':   d.get('npc_id', 0),
            'quest_id': d.get('quest_id', 0),
            'loop_count': d.get('loops', 0),
        }},
        'opcodes': d.get('opcodes', {}),
        'log_dir': './logs',
    }
    (ROOT / "config.yaml").write_text(
        yaml.dump(cfg, allow_unicode=True), encoding='utf-8')

    # Update accounts.csv
    accounts_text = d.get('accounts', '')
    if accounts_text.strip():
        lines = ['username,password,server']
        for line in accounts_text.strip().splitlines():
            if line.strip(): lines.append(line.strip())
        (ROOT / "accounts.csv").write_text('\n'.join(lines), encoding='utf-8')

    return jsonify({'ok': True})

# ─────────────────────────────────────────────────────
# Routes — Bot / Dashboard
# ─────────────────────────────────────────────────────

@app.route("/api/status")
def status():
    _load_config()
    with _lock:
        slots = dict(_slots)
    active = sum(1 for s in slots.values() if s.get('status') == 'running')
    done   = sum(1 for s in slots.values() if s.get('status') == 'done')
    errors = sum(1 for s in slots.values() if s.get('status') == 'error')
    total_loops = sum(s.get('loops', 0) for s in slots.values())
    return jsonify({
        'running': _running, 'total': len(_accounts),
        'active': active, 'done': done, 'errors': errors,
        'total_loops': total_loops,
        'slots': [{'id': k, **v} for k, v in sorted(slots.items())],
    })

@app.route("/api/start", methods=["POST"])
def start_bot():
    global _running
    if _running:
        return jsonify({'ok': False, 'msg': 'Đang chạy rồi'})
    _load_config()
    if not _accounts:
        return jsonify({'ok': False, 'msg': 'Chưa có accounts trong accounts.csv'})
    server = _config.get('server', {})
    if not server.get('host') or server.get('host') == '0.0.0.0':
        return jsonify({'ok': False, 'msg': 'Chưa điền server IP trong Config'})
    with _lock:
        _slots.clear()
    _running = True
    threading.Thread(target=_run_pool, daemon=True).start()
    return jsonify({'ok': True, 'msg': f'Đã start {len(_accounts)} accounts'})

@app.route("/api/stop", methods=["POST"])
def stop_bot():
    global _running
    _running = False
    return jsonify({'ok': True})

def _run_pool():
    global _running
    from concurrent.futures import ThreadPoolExecutor
    max_w = _config.get('pool', {}).get('max_workers', 20)
    with ThreadPoolExecutor(max_workers=max_w) as pool:
        futs = {pool.submit(_run_one, i, dict(acc)): i
                for i, acc in enumerate(_accounts)}
        for f in futs:
            if not _running: break
            f.result()
    _running = False

def _run_one(slot_id, account):
    def upd(**kw):
        with _lock:
            _slots.setdefault(slot_id, {}).update(**kw)

    upd(account=account.get('username',''), state='CONNECTING', loops=0, status='running', error='')
    try:
        # Import bot only when actually running
        from main import run_account
        result = run_account(account, _config, slot_id)
        upd(state='DONE', status=result.get('status', 'done'), loops=result.get('loops', 0))
    except Exception as e:
        upd(state='ERROR', status='error', error=str(e))


if __name__ == "__main__":
    _load_config()
    print("VLTK1 Toolkit UI → http://localhost:5000")
    app.run(host="0.0.0.0", port=5000, debug=False)
