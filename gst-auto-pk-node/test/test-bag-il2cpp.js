import "frida-il2cpp-bridge";

Il2Cpp.perform(function() {
    try {
        console.log("[Bridge] IL2CPP loaded");
        
        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
        var pmClass = img.class('PlayerMain');
        var playerMain = pmClass.field('instance').value;
        if (!playerMain) {
            console.log("No PlayerMain.instance");
            return;
        }
        
        var GetAllGameItems = pmClass.method('GetAllGameItems');
        if (GetAllGameItems) {
            console.log("Found GetAllGameItems method!");
            try {
                var dict = GetAllGameItems.invoke(playerMain);
                console.log("GetAllGameItems returned: " + dict);
                if (dict) {
                    var m_count = dict.field('m_count').value;
                    console.log("Dictionary count: " + m_count);
                    
                    var m_tables = dict.field('m_tables').value;
                    if (m_tables) {
                        var m_buckets = m_tables.field('m_buckets').value;
                        var m_entries = m_tables.field('m_entries').value; // array of Node
                        console.log("Buckets length: " + m_buckets.length);
                        console.log("Entries length: " + m_entries.length);
                        
                        var items = [];
                        for(var i=0; i<m_entries.length; i++) {
                            var entry = m_entries.get(i);
                            var key = entry.field('key').value;
                            var val = entry.field('value').value; // Item pointer
                            
                            if (val && !val.isNull()) {
                                var itemObj = new Il2Cpp.Object(val.handle);
                                var itemData = { id: key };
                                try { itemData.name = itemObj.field('name').value.content; } catch(e) {}
                                try { itemData.count = itemObj.field('count').value; } catch(e) {}
                                try { itemData.level = itemObj.field('level').value; } catch(e) {}
                                try { itemData.series = itemObj.field('series').value; } catch(e) {}
                                try { itemData.price = itemObj.field('price').value; } catch(e) {}
                                try { itemData.sellPrice = itemObj.field('sellPrice').value; } catch(e) {}
                                try { itemData.gdp_g = itemObj.field('gdp_g').value; } catch(e) {}
                                try { itemData.gdp_d = itemObj.field('gdp_d').value; } catch(e) {}
                                try { itemData.gdp_p = itemObj.field('gdp_p').value; } catch(e) {}
                                items.push(itemData);
                            }
                        }
                        
                        send({ type: 'result', data: { ok: true, source: 'GetAllGameItems', items: items } });
                        return;
                    }
                }
            } catch(e) {
                console.error("Error invoking GetAllGameItems: " + e.stack);
            }
        }
        
        var mcClass = img.class('MainCanvas');
        var instance = mcClass.field('instance').value;
        if (!instance) {
            console.log("No MainCanvas.instance");
            return;
        }
        
        console.log("Found MainCanvas.instance: " + instance.handle);
        
        var bagarate = instance.field('playerSelfBagarate').value;
        if (!bagarate) {
            console.log("No playerSelfBagarate");
            return;
        }
        
        console.log("playerSelfBagarate: " + bagarate.handle);
        var cellListing = bagarate.field('cellListing').value;
        if (!cellListing) {
            console.log("No cellListing");
            return;
        }
        
        console.log("cellListing: " + cellListing.handle);
        var items = [];
        var length = cellListing.field('_size').value;
        var array = cellListing.field('_items').value;
        for(var i=0; i<length; i++) {
            var cell = array.get(i);
            if (cell) {
                var itemObj = cell.field('item').value;
                if (itemObj) {
                    var itemData = {};
                    try { itemData.name = itemObj.field('name').value.content; } catch(e) {}
                    try { itemData.count = itemObj.field('count').value; } catch(e) {}
                    try { itemData.level = itemObj.field('level').value; } catch(e) {}
                    items.push(itemData);
                }
            }
        }
        
        send({ type: 'result', data: { ok: true, source: 'MainCanvas', items: items } });
        
    } catch(e) {
        console.error(e.stack);
        send({ type: 'result', data: { ok: false, error: e.message } });
    }
});
