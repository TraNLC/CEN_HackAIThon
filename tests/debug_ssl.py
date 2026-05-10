"""Find SSL-related modules and exports in game process."""
import frida, time

dev = frida.get_device_manager().get_device('emulator-5554')
s = dev.attach('VLTieuNgao')

sc = s.create_script("""
var result = [];
Process.enumerateModules().forEach(function(m) {
    var n = m.name.toLowerCase();
    if (n.indexOf('ssl') >= 0 || n.indexOf('crypto') >= 0 || n.indexOf('boring') >= 0 || n.indexOf('tls') >= 0) {
        var exports = [];
        m.enumerateExports().forEach(function(e) {
            if (e.name.indexOf('SSL_read') >= 0 || e.name.indexOf('SSL_write') >= 0) {
                exports.push(e.name + ' @ ' + e.address);
            }
        });
        result.push({ name: m.name, base: m.base.toString(), exports: exports });
    }
});
send(result);
""")

sc.on('message', lambda m, d: print(m['payload'] if m['type'] == 'send' else m))
sc.load()
time.sleep(1)
s.detach()
