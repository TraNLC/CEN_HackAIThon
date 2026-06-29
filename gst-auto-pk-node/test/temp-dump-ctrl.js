
        try {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function () {
                    try {
                        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
                        var pmClass = img.class('PlayerMain');
                        var inst = pmClass.field('instance').value;
                        if (!inst || inst.isNull()) {
                            send({ type: 'error', msg: 'PlayerMain.instance is null' });
                            return;
                        }
                        
                        var npc = null;
                        try { npc = inst.field("npcontroller").value; } catch (e) {
                            try { npc = inst.field("m_npcontroller").value; } catch (e2) {}
                        }
                        
                        if (!npc) {
                            send({ type: 'error', msg: 'No npcontroller' });
                            return;
                        }
                        
                        var fields = npc.class.fields;
                        var foundFields = [];
                        for(var i=0; i<fields.length; i++) {
                            foundFields.push(fields[i].name + " (" + fields[i].type.name + ")");
                        }
                        send({ type: 'result', data: foundFields });
                        
                    } catch(e) {
                        send({ type: 'error', msg: e.message });
                    }
                });
            } else {
                send({ type: 'error', msg: 'No Il2Cpp' });
            }
        } catch(e) {
            send({ type: 'error', msg: e.message });
        }
    