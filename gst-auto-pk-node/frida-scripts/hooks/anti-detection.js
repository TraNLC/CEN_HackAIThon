// frida-scripts/hooks/anti-detection.js — Anti-detection: prevent game from crashing when Frida attaches
// Based on FridaBypassKit patterns from reverse-skill toolkit

(function antiDetectionHooks() {
    // Only apply if Java is available (some games are pure native/Il2Cpp)
    try {
        if (typeof Java === 'undefined') return;
        
        Java.perform(function() {
            send({ type: 'log', msg: '[anti-detect] Installing anti-detection hooks...' });

            // 1. Debug detection bypass
            try {
                var Debug = Java.use('android.os.Debug');
                Debug.isDebuggerConnected.implementation = function() {
                    return false;
                };
                send({ type: 'log', msg: '[anti-detect] Debug.isDebuggerConnected hooked' });
            } catch(e) {}

            // 2. Prevent process killing (anti-tamper)
            try {
                var Process = Java.use('android.os.Process');
                Process.killProcess.implementation = function(pid) {
                    send({ type: 'log', msg: '[anti-detect] Blocked Process.killProcess(' + pid + ')' });
                    // Don't actually kill
                };
                send({ type: 'log', msg: '[anti-detect] Process.killProcess hooked' });
            } catch(e) {}

            // 3. System.exit() bypass
            try {
                var System = Java.use('java.lang.System');
                System.exit.implementation = function(code) {
                    send({ type: 'log', msg: '[anti-detect] Blocked System.exit(' + code + ')' });
                    // Don't exit
                };
                send({ type: 'log', msg: '[anti-detect] System.exit hooked' });
            } catch(e) {}

            // 4. Runtime.exec() - block shell commands that detect root/frida
            try {
                var Runtime = Java.use('java.lang.Runtime');
                Runtime.exec.overload('[Ljava.lang.String;').implementation = function(cmd) {
                    var cmdStr = cmd.length > 0 ? cmd[0] : '';
                    // Block known detection commands
                    if (cmdStr.indexOf('frida') !== -1 || 
                        cmdStr.indexOf('su') !== -1 ||
                        cmdStr.indexOf('magisk') !== -1 ||
                        cmdStr.indexOf('which') !== -1) {
                        send({ type: 'log', msg: '[anti-detect] Blocked suspicious exec: ' + cmdStr });
                        throw new Error('Command not found');
                    }
                    return this.exec(cmd);
                };
                send({ type: 'log', msg: '[anti-detect] Runtime.exec hooked' });
            } catch(e) {}

            // 5. File existence check bypass (hides frida-server)
            try {
                var File = Java.use('java.io.File');
                File.exists.implementation = function() {
                    var path = this.getAbsolutePath();
                    if (path.indexOf('frida') !== -1 || 
                        path.indexOf('su') !== -1 ||
                        path.indexOf('magisk') !== -1) {
                        send({ type: 'log', msg: '[anti-detect] Hiding file: ' + path });
                        return false;
                    }
                    return this.exists();
                };
                send({ type: 'log', msg: '[anti-detect] File.exists hooked' });
            } catch(e) {}

            send({ type: 'log', msg: '[anti-detect] Anti-detection hooks installed' });
        });
    } catch(e) {
        send({ type: 'log', msg: '[anti-detect] Java not available (pure native game), skipping' });
    }

    // === Native Anti-Debugging Bypass (TracerPid check) ===
    try {
        var appFilesDir = "/data/data/vn.perfingame.jx1mobile/files";
        var fakeStatusPath = appFilesDir + "/status";
        
        // 1. Create a fake status file with TracerPid = 0
        try {
            var f = new File(fakeStatusPath, "w");
            f.write("Name:\tvn.perfingame.jx1mobile\nState:\tR (running)\nTracerPid:\t0\n");
            f.close();
        } catch (err) {
            // Fallback to /data/local/tmp if files dir is not writable yet
            fakeStatusPath = "/data/local/tmp/fake_status";
            var f2 = new File(fakeStatusPath, "w");
            f2.write("Name:\tvn.perfingame.jx1mobile\nState:\tR (running)\nTracerPid:\t0\n");
            f2.close();
        }

        var fakePathPtr = Memory.allocUtf8String(fakeStatusPath);

        // 2. Hook fopen to redirect /proc/self/status
        var libc = Process.findModuleByName("libc.so");
        var fopenPtr = libc ? libc.findExportByName("fopen") : null;
        if (fopenPtr) {
            Interceptor.attach(fopenPtr, {
                onEnter: function(args) {
                    var path = Memory.readUtf8String(args[0]);
                    if (path && (path === "/proc/self/status" || path.indexOf("/status") !== -1 && path.indexOf("/proc/") !== -1)) {
                        args[0] = fakePathPtr; // Redirect to fake status file
                    }
                }
            });
            send({ type: 'log', msg: '[anti-detect] Native fopen (TracerPid redirection) hooked' });
        }

        // 3. Hook open to redirect /proc/self/status
        var openPtr = libc ? libc.findExportByName("open") : null;
        if (openPtr) {
            Interceptor.attach(openPtr, {
                onEnter: function(args) {
                    var path = Memory.readUtf8String(args[0]);
                    if (path && (path === "/proc/self/status" || path.indexOf("/status") !== -1 && path.indexOf("/proc/") !== -1)) {
                        args[0] = fakePathPtr; // Redirect to fake status file
                    }
                }
            });
            send({ type: 'log', msg: '[anti-detect] Native open (TracerPid redirection) hooked' });
        }
    } catch (e) {
        send({ type: 'log', msg: '[anti-detect] Native bypass failed: ' + e.message });
    }
})();
