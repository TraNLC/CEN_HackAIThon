"""
find_gamelib.py — List ALL loaded modules sorted by size
"""
import frida, subprocess, time

pid_str = subprocess.check_output(
    r'C:\platform-tools\adb.exe -s emulator-5554 shell "pidof vn.perfingame.jx1mobile"',
    shell=True
).decode().strip()
pid = int(pid_str.split()[0])

device = None
for d in frida.enumerate_devices():
    if 'emulator' in d.id or '5554' in d.id:
        device = d; break

session = device.attach(pid)
script = session.create_script("""
var mods = Process.enumerateModules();
var result = [];
for (var i = 0; i < mods.length; i++) {
    result.push({ name: mods[i].name, size: mods[i].size, base: mods[i].base.toString() });
}
send(result);
""")
results = []
def on_msg(msg, data):
    if msg['type'] == 'send':
        results.extend(msg['payload'])
script.on('message', on_msg)
script.load()
time.sleep(1)
session.detach()

print(f"All modules ({len(results)}), sorted by size descending:")
for m in sorted(results, key=lambda x: -x['size'])[:30]:
    print(f"  {m['name']:45s} {m['size']:>12,}  base={m['base']}")
