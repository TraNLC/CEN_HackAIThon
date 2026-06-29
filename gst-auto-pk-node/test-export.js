var mod = Process.findModuleByName('libil2cpp.so');
console.log('Base:', mod ? mod.base : 'null');
if (mod) {
    var exp = Module.findExportByName('libil2cpp.so', 'il2cpp_domain_get');
    console.log('Module.findExportByName:', exp);
    var ranges = mod.enumerateRanges('r-x');
    for (var i = 0; i < ranges.length; i++) {
        console.log('r-x range:', ranges[i].base, ranges[i].size);
    }
}
