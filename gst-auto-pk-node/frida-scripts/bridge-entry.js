// frida-scripts/bridge-entry.js — Entry point for frida-compile with Il2Cpp bridge
// This file imports frida-il2cpp-bridge, then our modular bot code is appended during build.

import 'frida-il2cpp-bridge';

// ═══════════════════════════════════════════
// The rest of the script is concatenated by build.js
// All modules use var globals and IIFE patterns
// They will be inlined below by the build process
// ═══════════════════════════════════════════
