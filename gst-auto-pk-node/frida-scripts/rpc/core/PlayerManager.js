// frida-scripts/rpc/core/PlayerManager.js -- Player info RPC exports (sect, skills, position)

rpc.exports.getMySect = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    var res = { ok: true };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
            var pmClass = img.class("PlayerMain");
            var inst = pmClass.field("instance").value;
            if (!inst || inst.isNull()) return { ok: false, error: 'no PlayerMain.instance' };

            var npc = null;
            try { npc = inst.field("npcontroller").value; } catch (e) {
                try { npc = inst.field("m_npcontroller").value; } catch (e2) {}
            }
            if (!npc || npc.isNull()) return { ok: false, error: 'no controller' };

            var data = null;
            try { data = npc.field("data").value; } catch (e) {
                try { data = npc.field("m_data").value; } catch (e2) {}
            }
            if (!data || data.isNull()) return { ok: false, error: 'no data' };

            // Read basic fields
            try { res.series = data.field('series').value; } catch (e) { res.series = null; }
            try {
                var nv = data.field('name').value;
                if (nv) {
                    if (typeof nv.content !== 'undefined' && nv.content !== null) {
                        res.name = nv.content;
                    } else {
                        var ptr = nv.handle ? nv.handle : new NativePointer(nv);
                        if (!ptr.isNull()) {
                            var len = ptr.add(0x10).readS32();
                            if (len > 0 && len < 100) res.name = ptr.add(0x14).readUtf16String(len);
                        }
                    }
                }
            } catch (e) {}
            try { res.level = data.field('level').value; } catch (e) {}

            // Read faction via Controller
            var ctrl = new Il2Cpp.Object(npc.handle);
            try { res.faction = ctrl.method('GetFaction').invoke(); }
            catch (e1) {
                try {
                    var CtrlCls = img.class('game.resource.settings.npcres.Controller');
                    res.faction = CtrlCls.method('GetFaction').bind(ctrl).invoke();
                } catch (e2) { res.factionErr = '' + e2; }
            }

            // Read identify fields
            try {
                var idn = ctrl.field('identify').value;
                if (idn && !idn.isNull()) {
                    try { res.campValue = idn.field('campValue').value; } catch (e) {}
                    try { res.seriesValue = idn.field('seriesValue').value; } catch (e) {}
                    try { res.hp = idn.field('healthCurrent').value; } catch (e) {}
                    try { res.hpMax = idn.field('healthMax').value; } catch (e) {}

                    var mc = ['manaCurrent', 'mpCurrent', 'powerCurrent', 'internalCurrent'];
                    var mm = ['manaMax', 'mpMax', 'powerMax', 'internalMax'];
                    for (var mi = 0; mi < mc.length; mi++) {
                        try { var mv = idn.field(mc[mi]).value; if (mv !== null && mv !== undefined) { res.mp = mv; res.mpField = mc[mi]; break; } } catch (e) {}
                    }
                    for (var mj = 0; mj < mm.length; mj++) {
                        try { var mx = idn.field(mm[mj]).value; if (mx !== null && mx !== undefined) { res.mpMax = mx; break; } } catch (e) {}
                    }
                }
            } catch (e) { res.idErr = '' + e; }

            // Safe static mapping of Sect names and camps to prevent Access Violations
            var SECT_NAMES = {
                0: "Thieu Lam",
                1: "Thien Vuong",
                2: "Duong Mon",
                3: "Ngu Doc",
                4: "Nga My",
                5: "Thuy Yen",
                6: "Cai Bang",
                7: "Thien Nhan",
                8: "Vo Dang",
                9: "Con Lon",
                10: "Minh Giao",
                11: "Doan Thi"
            };
            res.sect = (res.faction !== undefined && res.faction !== null) ? res.faction : -1;
            res.sectName = SECT_NAMES[res.sect] || "None";
        } catch (e) { return { ok: false, error: '' + e }; }
        return res;
    });
};

rpc.exports.getNearNpcsDetail = function() {
    var res = { ok: true, npcs: [] };
    try {
        if (globalThis.npcCache) {
            for (var cid in globalThis.npcCache) {
                res.npcs.push({ id: cid, name: globalThis.npcCache[cid] });
            }
        }
    } catch (e) {
        res.ok = false;
        res.error = e.message;
    }
    return res;
};

rpc.exports.getMySkills = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    return Il2Cpp.perform(function () {
        var out = [];
        try {
            var pm = new Il2Cpp.Object(_playerMainInstance);
            var m = pm.method("GetSkillId", 1);
            for (var i = 0; i < 25; i++) {
                try {
                    var sid = m.invoke(i);
                    if (sid && sid > 0) out.push({ idx: i, skillId: sid });
                } catch (e) {}
            }
        } catch (e) { return { ok: false, error: '' + e }; }
        return { ok: true, skills: out };
    });
};

rpc.exports.getPlayerInfo = function() {
    var pmRes = readPlayerMainDirect();
    var pos = typeof _lastPosition !== 'undefined' ? _lastPosition : { x: 0, y: 0, eid: 0, ts: Date.now() };
    var res = {
        ok: pmRes.ok,
        playerMain: pmRes.playerMain || null,
        source: pmRes.source || null,
        error: pmRes.error || null,
        position: { x: pos.x, y: pos.y, eid: pos.eid, age: Date.now() - pos.ts },
        recvTotal: typeof _recvTotal !== 'undefined' ? _recvTotal : 0,
        sendTotal: typeof _sendTotal !== 'undefined' ? _sendTotal : 0,
        gameFd: typeof gameFd !== 'undefined' ? gameFd : -1,
    };

    if (pmRes.ok && _playerMainInstance) {
        try {
            res.mapId = _playerMainInstance.add(0xE4).readS32();
            
            var npcontroller = _playerMainInstance.add(0x20).readPointer();
            if (!npcontroller.isNull()) {
                var dataPtr = npcontroller.add(0x30).readPointer();
                if (!dataPtr.isNull() && parseInt(dataPtr.toString()) > 0x10000) {
                    // Read cid
                    var cidPtr = dataPtr.add(0x10).readPointer();
                    if (!cidPtr.isNull() && parseInt(cidPtr.toString()) > 0x10000) {
                        var cidLen = cidPtr.add(0x10).readInt();
                        if (cidLen > 0 && cidLen < 100) {
                            res.cid = cidPtr.add(0x14).readUtf16String(cidLen);
                        }
                    }
                    
                    // Read name
                    var namePtr = dataPtr.add(0x40).readPointer();
                    if (!namePtr.isNull() && parseInt(namePtr.toString()) > 0x10000) {
                        var strLen = namePtr.add(0x10).readU32();
                        if (strLen > 0 && strLen < 100) {
                            res.name = namePtr.add(0x14).readUtf16String(strLen);
                        }
                    }
                    res.level = dataPtr.add(0x54).readU32();
                }
                
                var character = npcontroller.add(0xa0).readPointer();
                if (!character.isNull() && parseInt(character.toString()) > 0x10000) {
                    res.money = character.add(0x48).readS64().toString();
                    res.sect = character.add(0x34).readU32();
                    var SECT_NAMES = {
                        0: "Thiếu Lâm", 1: "Thiên Vương", 2: "Đường Môn", 3: "Ngũ Độc",
                        4: "Nga Mi", 5: "Thúy Yên", 6: "Cái Bang", 7: "Thiên Nhẫn",
                        8: "Võ Đang", 9: "Côn Lôn", 10: "Minh Giáo", 11: "Đoàn Thị"
                    };
                    res.sectName = SECT_NAMES[res.sect] || "Chưa rõ";
                    res.level = character.add(0x58).readU32();
                    res.storageMoney = character.add(0x110).readS64().toString();
                }

                // Read HP/MP using Il2Cpp if available
                if (typeof Il2Cpp !== 'undefined') {
                    Il2Cpp.perform(function() {
                        try {
                            var ctrl = new Il2Cpp.Object(npcontroller);
                            var idn = ctrl.field('identify').value;
                            if (idn && !idn.isNull()) {
                                res.hp = idn.field('healthCurrent').value;
                                res.maxHp = idn.field('healthMax').value;
                                
                                var mc = ['manaCurrent', 'mpCurrent', 'powerCurrent', 'internalCurrent'];
                                var mm = ['manaMax', 'mpMax', 'powerMax', 'internalMax'];
                                for (var mi = 0; mi < mc.length; mi++) {
                                    try { 
                                        var mv = idn.field(mc[mi]).value; 
                                        if (mv !== null && mv !== undefined) { 
                                            res.mp = mv; 
                                            break; 
                                        } 
                                    } catch (e) {}
                                }
                                for (var mj = 0; mj < mm.length; mj++) {
                                    try { 
                                        var mx = idn.field(mm[mj]).value; 
                                        if (mx !== null && mx !== undefined) { 
                                            res.maxMp = mx; 
                                            break; 
                                        } 
                                    } catch (e) {}
                                }
                            }
                        } catch(e) {}
                    });
                }
            }
        } catch (e) {
            res.error = "Error reading fields: " + e.message;
        }
    }
    return res;
};

rpc.exports.invalidatePlayerMain = function() {
    _playerMainInstance = null;
    if (typeof _charManagerClass !== 'undefined') _charManagerClass = null;
    if (typeof _netCoreManagerClass !== 'undefined') _netCoreManagerClass = null;
    if (typeof _popUpCanvasClass !== 'undefined') _popUpCanvasClass = null;
    if (typeof _byteClass !== 'undefined') _byteClass = null;
    return { ok: true };
};
