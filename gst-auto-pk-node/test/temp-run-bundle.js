// test/test-bag-il2cpp.js
Il2Cpp.perform(function() {
  try {
    console.log("[Bridge] IL2CPP loaded");
    var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
    var pmClass = img.class("PlayerMain");
    var instance = pmClass.field("instance").value;
    if (!instance) {
      console.log("No PlayerMain.instance");
      return;
    }
    console.log("Found PlayerMain.instance");
    var npc = instance.field("npcontroller").value;
    if (!npc) {
      console.log("No npcontroller");
      return;
    }
    var fields = npc.class.fields;
    for (var i = 0; i < fields.length; i++) {
      var f = fields[i];
      console.log("Controller Field: " + f.name + " (" + f.type.name + ")");
      if (f.name.toLowerCase().includes("bag") || f.name.toLowerCase().includes("item") || f.name.toLowerCase().includes("inventory")) {
        console.log("  => " + f.name + " = " + npc.field(f.name).value);
      }
    }
    var character = null;
    try {
      character = npc.field("character").value;
    } catch (e) {
    }
    try {
      if (!character) character = npc.field("m_character").value;
    } catch (e) {
    }
    if (character) {
      console.log("\\nFound character: " + character.class.name);
      var charFields = character.class.fields;
      for (var i = 0; i < charFields.length; i++) {
        var f = charFields[i];
        if (f.name.toLowerCase().includes("bag") || f.name.toLowerCase().includes("item") || f.name.toLowerCase().includes("inventory")) {
          console.log("Character Field: " + f.name + " (" + f.type.name + ")");
        }
      }
    }
    var bagarateCls = img.tryClass("Bagarate");
    if (bagarateCls) {
      console.log("\\nFound Bagarate class!");
      var inst = bagarateCls.field("instance").value;
      console.log("Bagarate instance: " + inst);
    }
  } catch (e) {
    console.error(e.stack);
  }
});
