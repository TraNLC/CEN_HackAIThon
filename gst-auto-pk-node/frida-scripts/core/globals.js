// === Console Shim ===
(function() {
    var originalLog = console.log;
    console.log = function() {
        var args = Array.prototype.slice.call(arguments);
        var msg = args.map(function(arg) {
            if (arg === null) return 'null';
            if (arg === undefined) return 'undefined';
            if (typeof arg === 'object') {
                try { return JSON.stringify(arg); } catch(e) { return String(arg); }
            }
            return String(arg);
        }).join(' ');
        originalLog.apply(console, arguments);
        send({ type: 'log', msg: msg });
    };
})();

// === File Shims ===
(function() {
    var OriginalFile = (typeof File !== 'undefined') ? File : null;
    globalThis.File = function(path, mode) {
        if (OriginalFile) {
            return new OriginalFile(path, mode);
        }
        return {};
    };
    if (OriginalFile) {
        globalThis.File.prototype = OriginalFile.prototype;
    }
    globalThis.File.readAllText = function(path) {
        var libc = Process.findModuleByName('libc.so');
        if (!libc) return '';
        var fn_fopen = libc.findExportByName('fopen');
        var fn_fgets = libc.findExportByName('fgets');
        var fn_fclose = libc.findExportByName('fclose');
        if (!fn_fopen || !fn_fgets || !fn_fclose) {
            return '';
        }
        var fopen = new NativeFunction(fn_fopen, 'pointer', ['pointer', 'pointer']);
        var fgets = new NativeFunction(fn_fgets, 'pointer', ['pointer', 'int', 'pointer']);
        var fclose = new NativeFunction(fn_fclose, 'int', ['pointer']);
        
        var fp = fopen(Memory.allocUtf8String(path), Memory.allocUtf8String('r'));
        if (fp.isNull()) return '';
        
        var lineBuf = Memory.alloc(1024);
        var content = '';
        while (true) {
            var res = fgets(lineBuf, 1024, fp);
            if (res.isNull()) break;
            content += lineBuf.readUtf8String();
        }
        fclose(fp);
        return content;
    };
})();

// === Socket State ===
var gameFd = -1;
var gameFdAutoLocked = false;
var _captureAllSends = false;
var recvBuffer = [];
var sendBuffer = [];
var SERVER_PUSH_OPS = {7:1,8:1,9:1,16:1,17:1,18:1,19:1,20:1,23:1,54:1,63:1,66:1,
                       72:1,118:1,124:1,125:1,126:1,166:1,205:1,245:1};

// === Il2Cpp State ===
var _playerMainInstance = null;
var _lastPosition = { x: 0, y: 0, eid: '', ts: 0 };
var il2cppBase = null;
var _playerMainScanned = false;
var _netCoreManagerScanned = false;
var _popUpCanvasScanned = false;
var _lastPlayerMainScanTime = 0;
var _lastNetCoreScanTime = 0;
var _lastPopUpCanvasScanTime = 0;

// === SSL State ===
var _sslReadOk = false;
var _sslWriteOk = false;
var _sslError = '';
var _sslWriteFn = null;
var _sslObj = null;

// === Diagnostic Counters ===
var _recvTotal = 0;
var _recvAny = 0;
var _fdsSeen = {};
var _fdsGameOps = {};
var _lastOps = [];
var _sendTotal = 0;

// === Native Function Pointers ===
var nativeWrite = null;
var nativeWritePtr = null;
var nativeReadPtr = null;
var writeSource = 'none';
var readSource = 'none';

// === Ripe Kim (Hoàng Kim Chín) State ===
var _ripeKimHooked = false;
var _ripeKimBuf = [];
var _npcAddLog = [];

// === Main-thread Task Queues (hook Update pattern) ===
var _pendingGoto = null;
var _gotoHookOn = false;
var _gotoLastFire = null;

var _pendingSkill = null;
var _skillHookOn = false;
var _skillLastFire = null;

var _pendingPkCid = null;
var _pendingPkSkill = 0;
var _pendingPkPhysic = 0;
var _pendingPkDismount = 0;
var _pkHookOn = false;
var _pkLast = null;

var _pendingDef = null;
var _defHookOn = false;
var _defLast = null;

var _pendingEquip = null;
var _equipHookOn = false;
var _equipLastFire = null;

var _popupQueue = null;
var _popupFound = null;
var _closeHookOn = false;
var _closePopupResult = null;

var _shopOpenLog = [];

var _sortQueue = null;
var _sortHookOn = false;
var _sortResult = null;

var _gotoCapOn = false;
var _gotoLog = [];

var _joyCapOn = false;
var _joyCnt = {};
var _joyConsumerOn = false;
var _joyRet = [];
