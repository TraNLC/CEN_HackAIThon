import 'frida-il2cpp-bridge';

Il2Cpp.perform(() => {
    try {
        console.log("[Scan] Il2Cpp ready, scanning NPCs...");
        const pmClass = Il2Cpp.domain.assembly('Assembly-CSharp').image.class('PlayerMain');
        const inst = pmClass.field('instance').value;
        if (!inst || inst.isNull()) {
            console.log("PlayerMain.instance is null");
            return;
        }
        
        const getNearNpcs = pmClass.method('GetNearNpcs');
        const dict = getNearNpcs.invoke(inst);
        if (!dict || dict.isNull()) {
            console.log("GetNearNpcs returned null");
            return;
        }
        
        let npcs = [];
        const clsName = dict.class.name;
        console.log("Dictionary class: " + clsName);
        
        // Dictionary format
        if (clsName.includes("Dictionary")) {
            const entries = dict.field('entries').value;
            const count = dict.field('count').value;
            for(let i=0; i<count; i++) {
                try {
                    const entry = entries.get(i);
                    const val = entry.field('value').value;
                    if(val && !val.isNull()) {
                        const data = val.field('data').value;
                        if(data && !data.isNull()) {
                            const npcid = data.field('id').value;
                            const nameObj = data.field('name').value;
                            const nameStr = nameObj ? nameObj.content : '';
                            console.log('=> NPC ID: ' + npcid + ' | Name: ' + nameStr);
                            npcs.push({id: npcid, name: nameStr});
                        }
                    }
                } catch(e) {}
            }
        } else if (clsName.includes("ConcurrentDictionary")) {
             // For ConcurrentDictionary
             const tables = dict.field('_tables').value;
             const buckets = tables.field('_buckets').value;
             for (let b = 0; b < buckets.length; b++) {
                 let node = buckets.get(b);
                 while (node && !node.isNull()) {
                     try {
                         const val = node.field('_value').value;
                         if (val && !val.isNull()) {
                             const data = val.field('data').value;
                             if(data && !data.isNull()) {
                                 const npcid = data.field('id').value;
                                 const nameObj = data.field('name').value;
                                 const nameStr = nameObj ? nameObj.content : '';
                                 console.log('=> NPC ID: ' + npcid + ' | Name: ' + nameStr);
                                 npcs.push({id: npcid, name: nameStr});
                             }
                         }
                     } catch(e) {}
                     try { node = node.field('_next').value; } catch(e) { node = null; }
                 }
             }
        }
        
        send({ type: 'scan_result', npcs: npcs });
    } catch(e) {
        console.error("Scan Err: " + e.message);
    }
});
