// Image 0: mscorlib.dll - 0
// Image 1: Assembly-CSharp.dll - 1689
// Image 2: System.Xml.dll - 3042
// Image 3: System.dll - 3711
// Image 4: System.Data.dll - 4409
// Image 5: Google.Protocol.dll - 4647
// Image 6: Unity.TextMeshPro.dll - 5135
// Image 7: System.Core.dll - 5332
// Image 8: Newtonsoft.Json.dll - 5981
// Image 9: Google.Protobuf.dll - 6286
// Image 10: UnityEngine.CoreModule.dll - 6582
// Image 11: UnityEngine.UI.dll - 7226
// Image 12: UnityEngine.TextCoreTextEngineModule.dll - 7421
// Image 13: Mono.Security.dll - 7515
// Image 14: UnityEngine.AndroidJNIModule.dll - 7600
// Image 15: System.IO.Compression.dll - 7645
// Image 16: I18N.West.dll - 7705
// Image 17: UnityEngine.IMGUIModule.dll - 7739
// Image 18: System.Drawing.dll - 7776
// Image 19: UnityEngine.TextCoreFontEngineModule.dll - 7787
// Image 20: I18N.dll - 7812
// Image 21: System.Numerics.dll - 7825
// Image 22: System.Xml.Linq.dll - 7838
// Image 23: UnityEngine.PropertiesModule.dll - 7876
// Image 24: UnityEngine.dll - 7934
// Image 25: deml.netcore-networking.dll - 7935
// Image 26: UnityEngine.UnityWebRequestModule.dll - 7949
// Image 27: UnityEngine.UIModule.dll - 7968
// Image 28: UnityEngine.AnimationModule.dll - 7979
// Image 29: UnityEngine.TextRenderingModule.dll - 8011
// Image 30: UnityEngine.Physics2DModule.dll - 8025
// Image 31: UnityEngine.InputLegacyModule.dll - 8035
// Image 32: UnityEngine.AudioModule.dll - 8046
// Image 33: UnityEngine.SharedInternalsModule.dll - 8065
// Image 34: UnityEngine.AssetBundleModule.dll - 8093
// Image 35: UnityEngine.ImageConversionModule.dll - 8099
// Image 36: UnityEngine.AIModule.dll - 8101
// Image 37: UnityEngine.SpriteShapeModule.dll - 8104
// Image 38: System.IO.Compression.FileSystem.dll - 8106
// Image 39: CandyCoded.HapticFeedback.Android.dll - 8110
// Image 40: System.Runtime.Serialization.dll - 8118
// Image 41: CandyCoded.HapticFeedback.dll - 8123
// Image 42: System.Runtime.CompilerServices.Unsafe.dll - 8131
// Image 43: System.Configuration.dll - 8134
// Image 44: __Generated - 8144

// Namespace: Mono.Xml
internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 41
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x171777C Offset: 0x171377C VA: 0x171777C
	public void .ctor() { }

	// RVA: 0x171792C Offset: 0x171392C VA: 0x171792C
	public void LoadXml(string xml) { }

	// RVA: 0x1717BA8 Offset: 0x1713BA8 VA: 0x1717BA8
	public SecurityElement ToXml() { }

	// RVA: 0x1717BB0 Offset: 0x1713BB0 VA: 0x1717BB0 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x1717BB4 Offset: 0x1713BB4 VA: 0x1717BB4 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x1717BB8 Offset: 0x1713BB8 VA: 0x1717BB8 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1717BBC Offset: 0x1713BBC VA: 0x1717BBC Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1717E5C Offset: 0x1713E5C VA: 0x1717E5C Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1717EF4 Offset: 0x1713EF4 VA: 0x1717EF4 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x1717F74 Offset: 0x1713F74 VA: 0x1717F74 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: 
public interface SmallXmlParser.IContentHandler // TypeDefIndex: 42
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text);
}

// Namespace: 
public interface SmallXmlParser.IAttrList // TypeDefIndex: 43
{
	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values();
}

// Namespace: 
private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 44
{
	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x171996C Offset: 0x171596C VA: 0x171996C Slot: 4
	public int get_Length() { }

	// RVA: 0x17199B4 Offset: 0x17159B4 VA: 0x17199B4 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x1719A0C Offset: 0x1715A0C VA: 0x1719A0C Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x1719A64 Offset: 0x1715A64 VA: 0x1719A64 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x1719B24 Offset: 0x1715B24 VA: 0x1719B24 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x1719B74 Offset: 0x1715B74 VA: 0x1719B74 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x1719344 Offset: 0x1715344 VA: 0x1719344
	internal void Clear() { }

	// RVA: 0x171984C Offset: 0x171584C VA: 0x171984C
	internal void Add(string name, string value) { }

	// RVA: 0x1717F78 Offset: 0x1713F78 VA: 0x1717F78
	public void .ctor() { }
}

// Namespace: Mono.Xml
internal class SmallXmlParser // TypeDefIndex: 45
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x17177E4 Offset: 0x17137E4 VA: 0x17177E4
	public void .ctor() { }

	// RVA: 0x1718024 Offset: 0x1714024 VA: 0x1718024
	private Exception Error(string msg) { }

	// RVA: 0x1718154 Offset: 0x1714154 VA: 0x1718154
	private Exception UnexpectedEndError() { }

	// RVA: 0x1718240 Offset: 0x1714240 VA: 0x1718240
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x171831C Offset: 0x171431C VA: 0x171831C
	private bool IsWhitespace(int c) { }

	// RVA: 0x1718338 Offset: 0x1714338 VA: 0x1718338
	public void SkipWhitespaces() { }

	// RVA: 0x17183EC Offset: 0x17143EC VA: 0x17183EC
	private void HandleWhitespaces() { }

	// RVA: 0x1718340 Offset: 0x1714340 VA: 0x1718340
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x1718510 Offset: 0x1714510 VA: 0x1718510
	private int Peek() { }

	// RVA: 0x17184A8 Offset: 0x17144A8 VA: 0x17184A8
	private int Read() { }

	// RVA: 0x171852C Offset: 0x171452C VA: 0x171852C
	public void Expect(int c) { }

	// RVA: 0x17185E8 Offset: 0x17145E8 VA: 0x17185E8
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x171888C Offset: 0x171488C VA: 0x171888C
	public string ReadName() { }

	// RVA: 0x17179C4 Offset: 0x17139C4 VA: 0x17179C4
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1719298 Offset: 0x1715298 VA: 0x1719298
	private void Cleanup() { }

	// RVA: 0x1718A40 Offset: 0x1714A40 VA: 0x1718A40
	public void ReadContent() { }

	// RVA: 0x1719138 Offset: 0x1715138 VA: 0x1719138
	private void HandleBufferedContent() { }

	// RVA: 0x17196D4 Offset: 0x17156D4 VA: 0x17196D4
	private void ReadCharacters() { }

	// RVA: 0x17186C4 Offset: 0x17146C4 VA: 0x17186C4
	private void ReadReference() { }

	// RVA: 0x171975C Offset: 0x171575C VA: 0x171975C
	private int ReadCharacterReference() { }

	// RVA: 0x1719564 Offset: 0x1715564 VA: 0x1719564
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x17193E0 Offset: 0x17153E0 VA: 0x17193E0
	private void ReadCDATASection() { }

	// RVA: 0x17194DC Offset: 0x17154DC VA: 0x17194DC
	private void ReadComment() { }
}

// Namespace: Mono.Xml
internal class SmallXmlParserException : SystemException // TypeDefIndex: 46
{
	// Fields
	private int line; // 0x8C
	private int column; // 0x90

	// Methods

	// RVA: 0x1718094 Offset: 0x1714094 VA: 0x1718094
	public void .ctor(string msg, int line, int column) { }
}
