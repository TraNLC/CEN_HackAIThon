var il2cppBase = null;

function waitForIl2Cpp() {
    var module = Process.findModuleByName("libil2cpp.so");
    if (!module) {
        setTimeout(waitForIl2Cpp, 500);
        return;
    }
    il2cppBase = module.base;
    runIl2CppHooks();
}

function runIl2CppHooks() {
    var il2cpp_domain_get = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_domain_get"), 'pointer', []);
    var il2cpp_thread_attach = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_thread_attach"), 'pointer', ['pointer']);
    var il2cpp_domain_get_assemblies = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_domain_get_assemblies"), 'pointer', ['pointer', 'pointer']);
    var il2cpp_assembly_get_image = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_assembly_get_image"), 'pointer', ['pointer']);
    var il2cpp_class_from_name = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_class_from_name"), 'pointer', ['pointer', 'pointer', 'pointer']);
    var il2cpp_class_get_method_from_name = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_class_get_method_from_name"), 'pointer', ['pointer', 'pointer', 'int']);
    var il2cpp_image_get_name = new NativeFunction(Module.findExportByName("libil2cpp.so", "il2cpp_image_get_name"), 'pointer', ['pointer']);

    var domain = il2cpp_domain_get();
    il2cpp_thread_attach(domain);

    var sizePtr = Memory.alloc(Process.pointerSize);
    var assemblies = il2cpp_domain_get_assemblies(domain, sizePtr);
    var count = sizePtr.readUInt();

    var AssemblyCSharpImage = null;
    for (var i = 0; i < count; i++) {
        var assembly = assemblies.add(i * Process.pointerSize).readPointer();
        var image = il2cpp_assembly_get_image(assembly);
        var namePtr = il2cpp_image_get_name(image);
        var name = namePtr.readCString();
        if (name === "Assembly-CSharp.dll" || name === "Assembly-CSharp") {
            AssemblyCSharpImage = image;
            break;
        }
    }

    if (!AssemblyCSharpImage) {
        send({ log: "Assembly-CSharp not found" });
        return;
    }

    var namespaceStr = Memory.allocUtf8String("");
    var classNameStr = Memory.allocUtf8String("NetCoreManager");
    var klass = il2cpp_class_from_name(AssemblyCSharpImage, namespaceStr, classNameStr);
    
    if (klass.isNull()) {
        send({ log: "NetCoreManager class not found" });
        return;
    }

    var methodNameStr = Memory.allocUtf8String("SendGSMessage");
    // Overload 1: byte[]
    var method1 = il2cpp_class_get_method_from_name(klass, methodNameStr, 2);
    if (!method1.isNull()) {
        var methodPtr = method1.readPointer();
        send({ log: "SendGSMessage(2 args) found at: " + methodPtr });
        
        Interceptor.attach(methodPtr, {
            onEnter: function(args) {
                var id = args[1].toInt32();
                send({ log: "[SendGSMessage 2args] Id: " + id });
            }
        });
    }

    // Overload 2: no args
    var method2 = il2cpp_class_get_method_from_name(klass, methodNameStr, 1);
    if (!method2.isNull()) {
        var methodPtr = method2.readPointer();
        send({ log: "SendGSMessage(1 args) found at: " + methodPtr });
        
        Interceptor.attach(methodPtr, {
            onEnter: function(args) {
                var id = args[1].toInt32();
                send({ log: "[SendGSMessage 1args] Id: " + id });
            }
        });
    }

    // Hook Network32BitClient.Send
    var nsNetStr = Memory.allocUtf8String("game.network");
    var classNetStr = Memory.allocUtf8String("Network32BitClient");
    var netClass = il2cpp_class_from_name(AssemblyCSharpImage, nsNetStr, classNetStr);
    
    if (!netClass.isNull()) {
        var sendNameStr = Memory.allocUtf8String("Send");
        var sendMethod = il2cpp_class_get_method_from_name(netClass, sendNameStr, 1);
        if (!sendMethod.isNull()) {
            var sendPtr = sendMethod.readPointer();
            send({ log: "Network32BitClient.Send(1 arg) found at: " + sendPtr });
            
            Interceptor.attach(sendPtr, {
                onEnter: function(args) {
                    var arr = args[1]; // byte[] buffer
                    if (!arr.isNull()) {
                        var len = arr.add(0x18).readU32();
                        if (len >= 6) {
                            var data = arr.add(0x20).readByteArray(6);
                            var hdr = new Uint8Array(data);
                            var opcode = hdr[4] | (hdr[5] << 8);
                            var plen = hdr[0] | (hdr[1] << 8) | (hdr[2] << 16) | (hdr[3] << 24);
                            send({ log: "[Network32BitClient.Send] Opcode: " + opcode + " (plen: " + plen + ", total: " + len + ")" });
                        }
                    }
                }
            });
        }
    }

    send({ log: "Hooks installed successfully using dynamic resolution!" });
}

setImmediate(waitForIl2Cpp);
