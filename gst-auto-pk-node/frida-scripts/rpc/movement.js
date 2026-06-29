// frida-scripts/rpc/movement.js — Movement RPC exports (bridge-free)

rpc.exports.gotoFindingPath = function(x, y, approach) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'PlayerMain not found' };
    if (!il2cppBase) return { ok: false, error: 'il2cppBase not found' };

    try {
        var gotoFindingPathFn = new NativeFunction(il2cppBase.add(0xE4A620), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer', 'pointer']);
        gotoFindingPathFn(_playerMainInstance, x | 0, y | 0, (approach | 0) || 20, ptr(0), ptr(0), ptr(0));
        return { ok: true, x: x, y: y, method: 'direct_native' };
    } catch (e) {
        return { ok: false, error: 'GotoFindingPath exception: ' + e };
    }
};

rpc.exports.gotoHooked = function(x, y, approach) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'PlayerMain not found' };
    if (!il2cppBase) return { ok: false, error: 'il2cppBase not found' };

    globalThis._pendingGoto = { x: x | 0, y: y | 0, ap: (approach | 0) || 20 };
    if (globalThis._gotoHookOn) return { ok: true, queued: true };

    try {
        var playerMainUpdate = il2cppBase.add(0xE42B4C);
        var gotoFindingPathFn = new NativeFunction(il2cppBase.add(0xE4A620), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer', 'pointer']);

        Interceptor.attach(playerMainUpdate, {
            onEnter: function() {
                var g = globalThis._pendingGoto;
                if (!g) return;
                globalThis._pendingGoto = null;
                try {
                    gotoFindingPathFn(_playerMainInstance, g.x, g.y, g.ap, ptr(0), ptr(0), ptr(0));
                    globalThis._gotoLastFire = 'ok ' + g.x + ',' + g.y;
                } catch (e) {
                    globalThis._gotoLastFire = 'err ' + e;
                }
            }
        });
        globalThis._gotoHookOn = true;
        return { ok: true, hooked: true };
    } catch (e) {
        return { ok: false, error: '' + e };
    }
};

rpc.exports.gotoLastFire = function() {
    return { fire: globalThis._gotoLastFire || '(chua ban)' };
};

rpc.exports.findJoysticks = function() {
    return { ok: false, error: 'Joystick query needs bridge (disabled for stability)' };
};

rpc.exports.joystickSet = function(idx, dx, dy) {
    return { ok: false, error: 'Joystick control needs bridge (disabled for stability)' };
};
