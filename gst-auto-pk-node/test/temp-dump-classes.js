
        try {
            if (typeof Il2Cpp !== 'undefined') {
                Il2Cpp.perform(function () {
                    send({ type: 'log', msg: 'Il2Cpp is available' });
                    try {
                        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
                        var classes = img.classes;
                        var found = [];
                        for (var i = 0; i < classes.length; i++) {
                            var name = classes[i].name;
                            var lower = name.toLowerCase();
                            if (lower.indexOf('bag') !== -1 || 
                                lower.indexOf('inventory') !== -1 || 
                                lower.indexOf('item') !== -1 ||
                                lower.indexOf('storage') !== -1 ||
                                lower.indexOf('ruong') !== -1) {
                                found.push(name);
                            }
                        }
                        send({ type: 'result', data: found });
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
    