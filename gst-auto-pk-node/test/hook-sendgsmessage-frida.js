var IL2CPP_BASE = null;

function resolveOffset(offset) {
    if (!IL2CPP_BASE) {
        var module = Process.findModuleByName("libil2cpp.so");
        if (module) {
            IL2CPP_BASE = module.base;
        }
    }
    return IL2CPP_BASE ? IL2CPP_BASE.add(offset) : null;
}

rpc.exports.init = function() {
    return true;
};

// NetCoreManager offsets
var offsets = {
    SendGSMessage_byteArr: 0xFE0D6C,
    SendGSMessage_IMessage: 0xFE0DCC,
    SendGSMessage_noArgs: 0xFE0E00
};

function attach() {
    var module = Process.findModuleByName("libil2cpp.so");
    if (!module) {
        setTimeout(attach, 500);
        return;
    }
    
    var base = module.base;

    Interceptor.attach(base.add(offsets.SendGSMessage_byteArr), {
        onEnter: function(args) {
            var id = args[1].toInt32();
            send({ log: "[SendGSMessage_byteArr] Id: " + id });
        }
    });

    Interceptor.attach(base.add(offsets.SendGSMessage_IMessage), {
        onEnter: function(args) {
            var id = args[1].toInt32();
            send({ log: "[SendGSMessage_IMessage] Id: " + id });
        }
    });

    Interceptor.attach(base.add(offsets.SendGSMessage_noArgs), {
        onEnter: function(args) {
            var id = args[1].toInt32();
            send({ log: "[SendGSMessage_noArgs] Id: " + id });
        }
    });

    send({ log: "Hooks for SendGSMessage installed." });
}

setImmediate(attach);
