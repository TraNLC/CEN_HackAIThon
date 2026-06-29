// frida-scripts/rpc/combat.js — Combat RPC exports (bridge-free)

rpc.exports.doSkillHooked = function(skillId) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    if (!il2cppBase) return { ok: false, error: 'no il2cppBase' };

    globalThis._pendingSkill = skillId | 0;
    if (globalThis._skillHookOn) return { ok: true, queued: skillId | 0 };

    try {
        var playerMainUpdate = il2cppBase.add(0xE42B4C);
        var doSkillFn = new NativeFunction(il2cppBase.add(0xE4969C), 'bool', ['pointer', 'int']);

        Interceptor.attach(playerMainUpdate, {
            onEnter: function() {
                var sid = globalThis._pendingSkill;
                if (sid === null || sid === undefined) return;
                globalThis._pendingSkill = null;
                try {
                    var r = doSkillFn(_playerMainInstance, sid);
                    globalThis._skillLastFire = 'ok DoSkill(' + sid + ')=' + r;
                } catch (e) {
                    globalThis._skillLastFire = 'err ' + e;
                }
            }
        });
        globalThis._skillHookOn = true;
        return { ok: true, hooked: true };
    } catch (e) {
        return { ok: false, error: '' + e };
    }
};

rpc.exports.skillLastFire = function() {
    return { fire: globalThis._skillLastFire || '(chua ban)' };
};

rpc.exports.doSkillDefaultHooked = function(skillId) {
    // Basic attack is mapped to DoSkill(skillId) natively
    return rpc.exports.doSkillHooked(skillId || 1);
};

rpc.exports.defLast = function() {
    return { last: globalThis._skillLastFire || '(chua)' };
};

rpc.exports.attackPlayerHooked = function(cid, skillId, isPhysic, dismount) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    if (!il2cppBase) return { ok: false, error: 'no il2cppBase' };

    try {
        // Switch horse if dismount is requested
        if (dismount) {
            var isHorseEquippedFn = new NativeFunction(il2cppBase.add(0xE46220), 'bool', ['pointer']);
            var playerSwitchHorseFn = new NativeFunction(il2cppBase.add(0xE493F4), 'void', ['pointer']);
            if (isHorseEquippedFn(_playerMainInstance)) {
                playerSwitchHorseFn(_playerMainInstance);
            }
        }
        
        // Execute skill targeting active opponent
        return rpc.exports.doSkillHooked(skillId);
    } catch (e) {
        return { ok: false, error: 'Attack player failed: ' + e };
    }
};

rpc.exports.pkLast = function() {
    return { last: globalThis._skillLastFire || '(chua)' };
};
