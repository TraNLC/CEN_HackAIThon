"""
detect_engine.py — Phát hiện engine/ngôn ngữ của game APK

Chạy: python analysis/detect_engine.py --serial 127.0.0.1:5555 --package vn.vinagame.vltk1
Hoặc: python analysis/detect_engine.py --apk base.apk

Kết quả:
  - Engine: Unity / Cocos2d / Unreal / Custom C++ / Java-only
  - Network layer: Java socket / C++ native / protobuf
  - Gợi ý hook approach phù hợp
"""

import argparse
import os
import subprocess
import sys
import zipfile
from pathlib import Path


def run(cmd) -> tuple[int, str]:
    r = subprocess.run(cmd, shell=True, capture_output=True, text=True)
    return r.returncode, r.stdout + r.stderr


def pull_apk(serial: str, package: str) -> Path | None:
    """Pull APK từ emulator về máy."""
    code, out = run(f"adb -s {serial} shell pm path {package}")
    # output: package:/data/app/xxx/base.apk
    for line in out.splitlines():
        if 'package:' in line:
            remote_path = line.replace('package:', '').strip()
            local_path = Path(f"captures/{package}.apk")
            local_path.parent.mkdir(exist_ok=True)
            print(f"  Pulling {remote_path} ...")
            run(f'adb -s {serial} pull "{remote_path}" "{local_path}"')
            if local_path.exists():
                return local_path
    return None


def analyze_apk(apk_path: Path) -> dict:
    """Mở APK (zip) và phân tích nội dung."""
    result = {
        'engine':          'Unknown',
        'language':        'Unknown',
        'network_layer':   'Unknown',
        'so_files':        [],
        'has_java_net':    False,
        'has_protobuf':    False,
        'has_lua':         False,
        'has_il2cpp':      False,  # Unity IL2CPP
        'has_mono':        False,  # Unity Mono
        'has_cocos':       False,
        'has_unreal':      False,
        'hook_approach':   [],
        'notes':           [],
    }

    try:
        with zipfile.ZipFile(apk_path, 'r') as z:
            names = z.namelist()

            # ── Detect .so files ──
            so_files = [n for n in names if n.endswith('.so')]
            result['so_files'] = so_files

            so_names = [Path(s).name for s in so_files]

            # ── Unity detection ──
            if 'libil2cpp.so' in so_names:
                result['engine'] = 'Unity (IL2CPP)'
                result['language'] = 'C# compiled to C++'
                result['has_il2cpp'] = True
            elif 'libmono.so' in so_names or 'libmonobdwgc-2.0.so' in so_names:
                result['engine'] = 'Unity (Mono)'
                result['language'] = 'C#'
                result['has_mono'] = True
            elif any('unity' in s.lower() for s in so_names):
                result['engine'] = 'Unity'

            # ── Cocos2d detection ──
            if any('cocos' in s.lower() for s in so_names) or \
               any('cocos' in n.lower() for n in names):
                result['engine'] = 'Cocos2d-x'
                result['language'] = 'C++'
                result['has_cocos'] = True

            # ── Unreal detection ──
            if any('unreal' in s.lower() or 'UE4' in s for s in so_names):
                result['engine'] = 'Unreal Engine'
                result['language'] = 'C++'
                result['has_unreal'] = True

            # ── Lua scripting (thường trong game mobile TQ) ──
            lua_files = [n for n in names if n.endswith('.lua') or
                        n.endswith('.luac') or 'lua' in n.lower()]
            if lua_files or any('lua' in s.lower() for s in so_names):
                result['has_lua'] = True
                result['notes'].append(f"Có Lua scripts ({len(lua_files)} files) — logic game có thể trong Lua")

            # ── Protobuf ──
            if any('protobuf' in s.lower() or 'proto' in s.lower() for s in so_names) or \
               any('.proto' in n or 'protobuf' in n.lower() for n in names):
                result['has_protobuf'] = True
                result['notes'].append("Dùng Protobuf — packet structure cần parse theo .proto schema")

            # ── Java network classes ──
            dex_files = [n for n in names if n.endswith('.dex')]
            result['notes'].append(f"DEX files: {dex_files}")

            # ── Detect custom engine (chỉ có 1 big .so) ──
            if result['engine'] == 'Unknown' and len(so_files) <= 3:
                big_so = [s for s in so_files if 'lib' in s.lower()]
                if big_so:
                    result['engine'] = 'Custom C++ Engine'
                    result['language'] = 'C++'

            # ── Java-only check ──
            if not so_files:
                result['engine'] = 'Java/Kotlin only'
                result['language'] = 'Java/Kotlin'

    except zipfile.BadZipFile:
        result['notes'].append("Không đọc được APK (có thể bị split APK hoặc protected)")

    # ── Recommend hook approach ──
    _recommend_approach(result)
    return result


def _recommend_approach(result: dict):
    engine = result['engine']
    approaches = result['hook_approach']
    notes = result['notes']

    if 'Unity (Mono)' in engine:
        approaches.append("✓ Frida + Java hook (Mono layer)")
        approaches.append("✓ Il2CppDumper nếu cần class names")
        notes.append("Unity Mono: C# class có thể hook qua Frida Java.perform()")

    elif 'Unity (IL2CPP)' in engine:
        approaches.append("✓ Il2CppDumper để lấy C# class/method names")
        approaches.append("✓ Frida hook native functions trong libil2cpp.so")
        approaches.append("⚠ Phức tạp hơn Mono — cần offset từ Il2CppDumper")
        notes.append("IL2CPP: C# đã compile thành C++ — không dùng Java.perform()")

    elif 'Cocos2d' in engine:
        approaches.append("✓ Frida hook C++ functions trong libcocos2dcpp.so")
        approaches.append("✓ Hook libc send/recv để bắt network")
        if result['has_lua']:
            approaches.append("✓ Hook Lua runtime để đọc game logic")
            notes.append("Game logic trong Lua → có thể đọc/sửa script .luac")

    elif 'Java' in result['language']:
        approaches.append("✓ Frida Java.perform() — dễ nhất")
        approaches.append("✓ jadx-gui để đọc source Java")
        approaches.append("✓ Xposed module cho production")

    elif 'C++' in result['language']:
        approaches.append("✓ Frida hook libc send/recv (layer thấp nhất)")
        approaches.append("✓ IDA Pro / Ghidra để RE native functions")
        approaches.append("⚠ unidbg nếu cần gọi hàm encrypt từ PC")

    else:
        approaches.append("✓ Bắt đầu với Frida libc hook (hook_socket.js)")
        approaches.append("? Xác định thêm sau khi có captures")


def print_result(result: dict, apk_path: Path):
    w = 56
    print("\n" + "═" * w)
    print(f"  APK: {apk_path.name}")
    print("═" * w)
    print(f"  Engine:        {result['engine']}")
    print(f"  Language:      {result['language']}")
    print()

    print("  .so files tìm thấy:")
    if result['so_files']:
        for s in result['so_files']:
            print(f"    {Path(s).name}")
    else:
        print("    (không có — pure Java)")

    print()
    print("  Hook approach khuyến nghị:")
    for a in result['hook_approach']:
        print(f"    {a}")

    if result['notes']:
        print()
        print("  Ghi chú:")
        for n in result['notes']:
            if n.startswith('DEX'):
                continue  # skip noisy DEX list
            print(f"    · {n}")

    print("═" * w)


def main():
    parser = argparse.ArgumentParser(description='Detect game engine from APK')
    group = parser.add_mutually_exclusive_group(required=True)
    group.add_argument('--apk',     help='Path đến file APK')
    group.add_argument('--package', help='Package name (cần --serial)')
    parser.add_argument('--serial', help='ADB serial của emulator, vd: 127.0.0.1:5555')
    args = parser.parse_args()

    if args.package:
        if not args.serial:
            print("Cần --serial khi dùng --package")
            sys.exit(1)
        apk_path = pull_apk(args.serial, args.package)
        if not apk_path:
            print(f"Không pull được APK của {args.package}")
            sys.exit(1)
    else:
        apk_path = Path(args.apk)
        if not apk_path.exists():
            print(f"File không tồn tại: {apk_path}")
            sys.exit(1)

    print(f"Analyzing {apk_path} ...")
    result = analyze_apk(apk_path)
    print_result(result, apk_path)


if __name__ == '__main__':
    main()
