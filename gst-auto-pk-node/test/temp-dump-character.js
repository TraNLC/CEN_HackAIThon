
        function testReadBag() {
            try {
                // Hook World.Update at 0xF2B3B8
                var il2cppBase = Process.findModuleByName('libil2cpp.so').base;
                var hooked = false;
                
                Interceptor.attach(il2cppBase.add(0xF2B3B8), {
                    onEnter: function(args) {
                        if (hooked) return;
                        try {
                            var worldPtr = args[0];
                            if (worldPtr.isNull()) return;

                            var playerMainPtr = worldPtr.add(0x40).readPointer();
                            if (playerMainPtr.isNull()) return;

                            var npcontroller = playerMainPtr.add(0x20).readPointer();
                            if (npcontroller.isNull()) return;

                            var character = npcontroller.add(0xa0).readPointer();
                            if (character.isNull()) return;
                            
                            hooked = true;
                            
                            // We have the character object. Let's dump its class name
                            var klassPtr = character.readPointer();
                            var namePtr = klassPtr.add(0x10).readPointer();
                            var className = namePtr.readUtf8String();
                            
                            send({ log: "Character class name: " + className });
                            
                            // Now let's try to find fields of this class
                            // klassPtr + 0x18 is namespace, klassPtr + 0x80 is fields?
                            // Actually it's easier to just use Il2Cpp API if we load it.
                            send({ type: 'result', data: { ok: true, className: className } });
                            
                        } catch(e) {
                            send({ log: "Error: " + e.message });
                        }
                    }
                });
                
                setTimeout(function() {
                    if (!hooked) {
                        send({ type: 'result', data: { ok: false, error: "Timeout waiting for World.Update" } });
                    }
                }, 2000);
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        };
        testReadBag();
    