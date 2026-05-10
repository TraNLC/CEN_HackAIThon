import os
import subprocess

ADB_PATH = r"C:\platform-tools\adb.exe"
OUTPUT_DIR = "data/dump"
os.makedirs(OUTPUT_DIR, exist_ok=True)

def run_adb_shell(cmd):
    return subprocess.run([ADB_PATH, "shell", f"su -c '{cmd}'"], capture_output=True, text=True)

print("1. Copying libil2cpp.so to tmp...")
run_adb_shell("cp /data/app/vn.perfingame.jx1mobile-*/lib/arm/libil2cpp.so /data/local/tmp/")

print("2. Copying global-metadata.dat to tmp...")
run_adb_shell("cp /data/media/0/Android/data/vn.perfingame.jx1mobile/files/il2cpp/Metadata/global-metadata.dat /data/local/tmp/")
run_adb_shell("cp /data/app/vn.perfingame.jx1mobile-*/assets/bin/Data/Managed/Metadata/global-metadata.dat /data/local/tmp/ 2>/dev/null") # Try alternate path if first fails

print("3. Changing permissions...")
run_adb_shell("chmod 777 /data/local/tmp/libil2cpp.so /data/local/tmp/global-metadata.dat")

print("4. Pulling files to PC...")
subprocess.run([ADB_PATH, "pull", "/data/local/tmp/libil2cpp.so", os.path.join(OUTPUT_DIR, "libil2cpp.so")])
subprocess.run([ADB_PATH, "pull", "/data/local/tmp/global-metadata.dat", os.path.join(OUTPUT_DIR, "global-metadata.dat")])

print("DONE! Files saved to", OUTPUT_DIR)
