"""
diagnose.py — Enumerate modules and test Frida API on the game process
"""
import frida  # type: ignore[import-not-found]
import subprocess
import sys
import time

PACKAGE = "vn.perfingame.jx1mobile"

# Setup ADB forward
for adb in ["adb", r"C:\platform-tools\adb.exe"]:
    try:
        subprocess.run(f'{adb} -s emulator-5554 forward tcp:27042 tcp:27042',
                       shell=True, capture_output=True, timeout=5)
        break
    except Exception:
        continue

# Connect
device = frida.get_usb_device(timeout=5)
print(f"Device: {device.name}")

# Get PID
for adb in ["adb", r"C:\platform-tools\adb.exe"]:
    try:
        r = subprocess.run(f'{adb} -s emulator-5554 shell pidof {PACKAGE}',
                           shell=True, capture_output=True, text=True, timeout=5)
        pid = int(r.stdout.strip())
        break
    except Exception:
        continue

print(f"PID: {pid}")
session = device.attach(pid)

# Diagnostic script
DIAG_JS = """
console.log("=== DIAGNOSTIC ===");
console.log("Process.id: " + Process.id);
console.log("Process.arch: " + Process.arch);
console.log("Process.platform: " + Process.platform);

// Check Frida API availability
console.log("\\n--- API Check ---");
console.log("typeof Interceptor: " + typeof Interceptor);
console.log("typeof Interceptor.attach: " + typeof Interceptor.attach);
console.log("typeof Module: " + typeof Module);
console.log("typeof Module.findExportByName: " + typeof Module.findExportByName);
console.log("typeof Module.getExportByName: " + typeof Module.getExportByName);
console.log("typeof Module.enumerateExports: " + typeof Module.enumerateExports);

// List all modules
console.log("\\n--- Modules (filtered) ---");
var mods = Process.enumerateModules();
console.log("Total modules: " + mods.length);
for (var i = 0; i < mods.length; i++) {
    var m = mods[i];
    var name = m.name.toLowerCase();
    if (name.indexOf('il2cpp') >= 0 || name.indexOf('unity') >= 0 || 
        name.indexOf('libc') >= 0 || name.indexOf('xlua') >= 0 ||
        name.indexOf('net') >= 0 || name.indexOf('ssl') >= 0 ||
        name.indexOf('main') >= 0 || name.indexOf('houdini') >= 0 ||
        name.indexOf('ndk') >= 0) {
        console.log("  " + m.name + " @ " + m.base + " size=" + m.size);
    }
}

// Try to find send/recv in different ways
console.log("\\n--- Finding send/recv ---");
try {
    var s1 = Module.findExportByName("libc.so", "send");
    console.log("findExportByName('libc.so', 'send') = " + s1);
} catch(e) { console.log("findExportByName('libc.so', 'send') ERROR: " + e.message); }

try {
    var s2 = Module.findExportByName(null, "send");
    console.log("findExportByName(null, 'send') = " + s2);
} catch(e) { console.log("findExportByName(null, 'send') ERROR: " + e.message); }

try {
    var s3 = Module.findExportByName(null, "sendto");
    console.log("findExportByName(null, 'sendto') = " + s3);
} catch(e) { console.log("findExportByName(null, 'sendto') ERROR: " + e.message); }

try {
    var s4 = Module.findExportByName(null, "connect");
    console.log("findExportByName(null, 'connect') = " + s4);
} catch(e) { console.log("findExportByName(null, 'connect') ERROR: " + e.message); }

try {
    var s5 = Module.findExportByName(null, "write");
    console.log("findExportByName(null, 'write') = " + s5);
} catch(e) { console.log("findExportByName(null, 'write') ERROR: " + e.message); }

try {
    var s6 = Module.findExportByName(null, "socket");
    console.log("findExportByName(null, 'socket') = " + s6);
} catch(e) { console.log("findExportByName(null, 'socket') ERROR: " + e.message); }

// List libc exports containing 'send' or 'recv'
console.log("\\n--- libc.so exports with send/recv ---");
try {
    var libc = Process.findModuleByName("libc.so");
    if (libc) {
        console.log("libc.so found @ " + libc.base);
        var exports = libc.enumerateExports();
        for (var j = 0; j < exports.length; j++) {
            var n = exports[j].name.toLowerCase();
            if (n.indexOf('send') >= 0 || n.indexOf('recv') >= 0 || n.indexOf('connect') >= 0 || n.indexOf('socket') >= 0) {
                console.log("  " + exports[j].type + " " + exports[j].name + " @ " + exports[j].address);
            }
        }
    } else {
        console.log("libc.so NOT found!");
        // Try finding any libc variant
        for (var k = 0; k < mods.length; k++) {
            if (mods[k].name.indexOf('libc') >= 0) {
                console.log("Found: " + mods[k].name);
            }
        }
    }
} catch(e) { console.log("ERROR listing exports: " + e.message); }

// Try a simple Interceptor.attach test
console.log("\\n--- Interceptor test ---");
try {
    var writeAddr = Module.findExportByName(null, "open");
    console.log("open() address: " + writeAddr);
    if (writeAddr) {
        console.log("typeof writeAddr: " + typeof writeAddr);
        console.log("writeAddr.isNull: " + typeof writeAddr.isNull);
        Interceptor.attach(writeAddr, {
            onEnter: function(args) {}
        });
        console.log("Interceptor.attach on open() WORKS!");
    }
} catch(e) { console.log("Interceptor test ERROR: " + e.message); }

console.log("\\n=== DIAGNOSTIC DONE ===");
"""

def on_msg(msg, data):
    if msg['type'] == 'send':
        print(msg['payload'])
    elif msg['type'] == 'error':
        print(f"[JS ERROR] {msg.get('description','?')}")

script = session.create_script(DIAG_JS)
script.on('message', on_msg)
script.load()

time.sleep(5)
script.unload()
session.detach()
print("\nDone!")
