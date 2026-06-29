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

// Namespace: System.Security.Util
internal sealed class Parser // TypeDefIndex: 685
{
	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x1759DC8 Offset: 0x1755DC8 VA: 0x1759DC8
	internal SecurityElement GetTopElement() { }

	// RVA: 0x1759DF0 Offset: 0x1755DF0 VA: 0x1759DF0
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x175A31C Offset: 0x175631C VA: 0x175A31C
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x175AF7C Offset: 0x1756F7C VA: 0x175AF7C
	private void ParseContents() { }

	// RVA: 0x175B3E4 Offset: 0x17573E4 VA: 0x175B3E4
	private void .ctor(Tokenizer t) { }

	// RVA: 0x175B4A8 Offset: 0x17574A8 VA: 0x175B4A8
	internal void .ctor(string input) { }
}

// Namespace: 
private enum Tokenizer.TokenSource // TypeDefIndex: 686
{
	// Fields
	public int value__; // 0x0
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;
}

// Namespace: 
[Serializable]
internal sealed class Tokenizer.StringMaker // TypeDefIndex: 687
{
	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x175B870 Offset: 0x1757870 VA: 0x175B870
	private static uint HashString(string str) { }

	// RVA: 0x175B8DC Offset: 0x17578DC VA: 0x175B8DC
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x175B930 Offset: 0x1757930 VA: 0x175B930
	public void .ctor() { }

	// RVA: 0x175B9D8 Offset: 0x17579D8 VA: 0x175B9D8
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x1756148 Offset: 0x1752148 VA: 0x1756148
	public string MakeString() { }
}

// Namespace: 
internal interface Tokenizer.ITokenReader // TypeDefIndex: 688
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read();
}

// Namespace: 
internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 689
{
	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x175B63C Offset: 0x175763C VA: 0x175B63C
	internal void .ctor(StreamReader input) { }

	// RVA: 0x175BA78 Offset: 0x1757A78 VA: 0x175BA78 Slot: 5
	public virtual int Read() { }

	// RVA: 0x175BAB4 Offset: 0x1757AB4 VA: 0x175BAB4
	internal int get_NumCharEncountered() { }
}

// Namespace: System.Security.Util
internal sealed class Tokenizer // TypeDefIndex: 690
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x175B564 Offset: 0x1757564 VA: 0x175B564
	internal void BasicInitialization() { }

	// RVA: 0x175B5E4 Offset: 0x17575E4 VA: 0x175B5E4
	public void Recycle() { }

	// RVA: 0x175B510 Offset: 0x1757510 VA: 0x175B510
	internal void .ctor(string input) { }

	// RVA: 0x175AD44 Offset: 0x1756D44 VA: 0x175AD44
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x175A4A8 Offset: 0x17564A8 VA: 0x175A4A8
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x175B774 Offset: 0x1757774 VA: 0x175B774
	private string GetStringToken() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerShortBlock // TypeDefIndex: 691
{
	// Fields
	internal short[] m_block; // 0x10
	internal TokenizerShortBlock m_next; // 0x18

	// Methods

	// RVA: 0x175BABC Offset: 0x1757ABC VA: 0x175BABC
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStringBlock // TypeDefIndex: 692
{
	// Fields
	internal string[] m_block; // 0x10
	internal TokenizerStringBlock m_next; // 0x18

	// Methods

	// RVA: 0x175BB20 Offset: 0x1757B20 VA: 0x175BB20
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStream // TypeDefIndex: 693
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x175B250 Offset: 0x1757250 VA: 0x175B250
	internal void .ctor() { }

	// RVA: 0x175B674 Offset: 0x1757674 VA: 0x175B674
	internal void AddToken(short token) { }

	// RVA: 0x175B788 Offset: 0x1757788 VA: 0x175B788
	internal void AddString(string str) { }

	// RVA: 0x175B300 Offset: 0x1757300 VA: 0x175B300
	internal void Reset() { }

	// RVA: 0x175B344 Offset: 0x1757344 VA: 0x175B344
	internal short GetNextFullToken() { }

	// RVA: 0x175A218 Offset: 0x1756218 VA: 0x175A218
	internal short GetNextToken() { }

	// RVA: 0x175A2A4 Offset: 0x17562A4 VA: 0x175A2A4
	internal string GetNextString() { }

	// RVA: 0x175A22C Offset: 0x175622C VA: 0x175A22C
	internal void ThrowAwayNextString() { }

	// RVA: 0x175A230 Offset: 0x1756230 VA: 0x175A230
	internal void TagLastToken(short tag) { }

	// RVA: 0x175BB84 Offset: 0x1757B84 VA: 0x175BB84
	internal int GetTokenCount() { }

	// RVA: 0x175ACF8 Offset: 0x1756CF8 VA: 0x175ACF8
	internal void GoToPosition(int position) { }
}

// Namespace: 
private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 694
{
	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x175BD64 Offset: 0x1757D64 VA: 0x175BD64
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x175BDC4 Offset: 0x1757DC4 VA: 0x175BDC4 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x175BF10 Offset: 0x1757F10 VA: 0x175BF10 Slot: 6
	public void Reset() { }

	// RVA: 0x175C038 Offset: 0x1758038 VA: 0x175C038 Slot: 5
	public object get_Current() { }
}
