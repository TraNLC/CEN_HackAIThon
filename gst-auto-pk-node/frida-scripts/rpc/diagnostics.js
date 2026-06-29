// frida-scripts/rpc/diagnostics.js — Diagnostic RPC exports

rpc.exports.enumActiveUi = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
            var Res = Il2Cpp.domain.assembly('UnityEngine.CoreModule').image.class('UnityEngine.Resources');
            var findM = Res.method('FindObjectsOfTypeAll', 1);
            var pat = /(dialog|npc|box|pc|select|confirm|award|quest|give|popup|menu|notice|reward|task|rank|hang|xep|view|panel|board|list|window|content|info|datau|activ|tong|standard|trade|input|detail|frame|chain|combo|serial|continuous)/i;
            var active = {};
            var classes = img.classes;
            for (var i = 0; i < classes.length; i++) {
                var k = classes[i]; var nm = k.name || '';
                if (!pat.test(nm)) continue;
                try {
                    var arr = findM.invoke(k.type.object);
                    var total = (arr && arr.length) ? arr.length : 0;
                    if (!total) continue;
                    var act = 0;
                    for (var j = 0; j < total; j++) {
                        try {
                            var o = arr.get(j);
                            var go = o.method('get_gameObject').invoke();
                            if (go.method('get_activeInHierarchy').invoke()) act++;
                        } catch (e) {}
                    }
                    if (act > 0) active[nm] = total + '/' + act;
                } catch (e) {}
            }
            return { ok: true, active: active };
        } catch (e) { return { ok: false, error: '' + e }; }
    });
};

rpc.exports.captureGoto = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    if (globalThis._gotoCapOn) return { ok: true, already: true };
    globalThis._gotoLog = [];
    return Il2Cpp.perform(function () {
        var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
        var pm = img.class("PlayerMain");
        var hooked = [];
        function hookM(name, cnt, nargs) {
            try {
                var m = pm.method(name, cnt);
                if (!m || !m.virtualAddress || m.virtualAddress.isNull()) return;
                Interceptor.attach(m.virtualAddress, {
                    onEnter: function (a) {
                        var rec = { m: name + '/' + cnt, ts: Date.now(), args: [] };
                        for (var i = 1; i <= nargs; i++) {
                            try { rec.args.push(a[i].isNull() ? 'NULL' : a[i].toInt32()); }
                            catch (e) { rec.args.push('?'); }
                        }
                        globalThis._gotoLog.push(rec);
                        if (globalThis._gotoLog.length > 30) globalThis._gotoLog.shift();
                    }
                });
                hooked.push(name + '/' + cnt);
            } catch (e) {}
        }
        hookM("GotoFindingPath", 6, 6);
        hookM("GotoFindingPathOnVector", 1, 1);
        hookM("ProtocolGotoPosition", 1, 1);
        hookM("GotoAndPickTargetObject", 1, 1);
        hookM("GotoNpc", 2, 2);
        globalThis._gotoCapOn = true;
        return { ok: true, hooked: hooked };
    });
};

rpc.exports.lastGotoArgs = function() { return { log: globalThis._gotoLog || [] }; };

rpc.exports.listMethods = function(className, filter) {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
            var k = img.class(className);
            if (!k) return { ok: false, error: 'no class ' + className };
            var out = [], ms = k.methods, f = (filter || '').toLowerCase();
            for (var i = 0; i < ms.length; i++) {
                var n = ms[i].name;
                if (!f || n.toLowerCase().indexOf(f) !== -1) {
                    var pc = 0; try { pc = ms[i].parameterCount; } catch (e) {}
                    out.push(n + "/" + pc);
                }
            }
            return { ok: true, methods: out };
        } catch (e) { return { ok: false, error: '' + e }; }
    });
};
