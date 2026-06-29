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

// Namespace: I18N.Common
[Serializable]
public abstract class ByteEncoding : MonoEncoding // TypeDefIndex: 7814
{
	// Fields
	protected char[] toChars; // 0x40
	protected string encodingName; // 0x48
	protected string bodyName; // 0x50
	protected string headerName; // 0x58
	protected string webName; // 0x60
	protected bool isBrowserDisplay; // 0x68
	protected bool isBrowserSave; // 0x69
	protected bool isMailNewsDisplay; // 0x6A
	protected bool isMailNewsSave; // 0x6B
	protected int windowsCodePage; // 0x6C
	private static byte[] isNormalized; // 0x0
	private static byte[] isNormalizedComputed; // 0x8
	private static byte[] normalization_bytes; // 0x10

	// Properties
	public override bool IsSingleByte { get; }
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x16E1A24 Offset: 0x16DDA24 VA: 0x16E1A24
	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	// RVA: 0x16E1B7C Offset: 0x16DDB7C VA: 0x16E1B7C Slot: 39
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x16E2010 Offset: 0x16DE010 VA: 0x16E2010 Slot: 17
	public override bool get_IsSingleByte() { }

	// RVA: 0x16E2018 Offset: 0x16DE018 VA: 0x16E2018 Slot: 19
	public override int GetByteCount(string s) { }

	// RVA: 0x16E2070 Offset: 0x16DE070 VA: 0x16E2070 Slot: 50
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);

	// RVA: 0x16E2078 Offset: 0x16DE078 VA: 0x16E2078 Slot: 53
	protected virtual void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E240C Offset: 0x16DE40C VA: 0x16E240C Slot: 51
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x16E2430 Offset: 0x16DE430 VA: 0x16E2430 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x16E2544 Offset: 0x16DE544 VA: 0x16E2544 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x16E2770 Offset: 0x16DE770 VA: 0x16E2770 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x16E27E4 Offset: 0x16DE7E4 VA: 0x16E27E4 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x16E2858 Offset: 0x16DE858 VA: 0x16E2858 Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x16E2A14 Offset: 0x16DEA14 VA: 0x16E2A14 Slot: 44
	public override string GetString(byte[] bytes) { }

	// RVA: 0x16E2A7C Offset: 0x16DEA7C VA: 0x16E2A7C Slot: 8
	public override string get_BodyName() { }

	// RVA: 0x16E2A84 Offset: 0x16DEA84 VA: 0x16E2A84 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x16E2A8C Offset: 0x16DEA8C VA: 0x16E2A8C Slot: 10
	public override string get_HeaderName() { }

	// RVA: 0x16E2A94 Offset: 0x16DEA94 VA: 0x16E2A94 Slot: 13
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x16E2A9C Offset: 0x16DEA9C VA: 0x16E2A9C Slot: 14
	public override bool get_IsBrowserSave() { }

	// RVA: 0x16E2AA4 Offset: 0x16DEAA4 VA: 0x16E2AA4 Slot: 15
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x16E2AAC Offset: 0x16DEAAC VA: 0x16E2AAC Slot: 16
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x16E2AB4 Offset: 0x16DEAB4 VA: 0x16E2AB4 Slot: 11
	public override string get_WebName() { }

	// RVA: 0x16E2ABC Offset: 0x16DEABC VA: 0x16E2ABC Slot: 12
	public override int get_WindowsCodePage() { }
}

// Namespace: I18N.Common
[Serializable]
public abstract class ByteSafeEncoding : MonoSafeEncoding // TypeDefIndex: 7815
{
	// Fields
	protected char[] toChars; // 0x40
	protected string encodingName; // 0x48
	protected string bodyName; // 0x50
	protected string headerName; // 0x58
	protected string webName; // 0x60
	protected bool isBrowserDisplay; // 0x68
	protected bool isBrowserSave; // 0x69
	protected bool isMailNewsDisplay; // 0x6A
	protected bool isMailNewsSave; // 0x6B
	protected int windowsCodePage; // 0x6C
	private static byte[] isNormalized; // 0x0
	private static byte[] isNormalizedComputed; // 0x8
	private static byte[] normalization_bytes; // 0x10

	// Properties
	public override bool IsSingleByte { get; }
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x16E2AC4 Offset: 0x16DEAC4 VA: 0x16E2AC4
	protected void .ctor(int codePage, char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) { }

	// RVA: 0x16E2C1C Offset: 0x16DEC1C VA: 0x16E2C1C Slot: 39
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x16E30B0 Offset: 0x16DF0B0 VA: 0x16E30B0 Slot: 17
	public override bool get_IsSingleByte() { }

	// RVA: 0x16E30B8 Offset: 0x16DF0B8 VA: 0x16E30B8 Slot: 19
	public override int GetByteCount(string s) { }

	// RVA: 0x16E3110 Offset: 0x16DF110 VA: 0x16E3110 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x16E3118 Offset: 0x16DF118 VA: 0x16E3118 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: -1 Offset: -1 Slot: 50
	protected abstract void ToBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x16E3120 Offset: 0x16DF120 VA: 0x16E3120 Slot: 51
	protected virtual void ToBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E31B0 Offset: 0x16DF1B0 VA: 0x16E31B0 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E3384 Offset: 0x16DF384 VA: 0x16E3384 Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E3558 Offset: 0x16DF558 VA: 0x16E3558 Slot: 26
	public override byte[] GetBytes(string s) { }

	// RVA: 0x16E35E4 Offset: 0x16DF5E4 VA: 0x16E35E4 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x16E36F8 Offset: 0x16DF6F8 VA: 0x16E36F8 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x16E3924 Offset: 0x16DF924 VA: 0x16E3924 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x16E3998 Offset: 0x16DF998 VA: 0x16E3998 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x16E3A0C Offset: 0x16DFA0C VA: 0x16E3A0C Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x16E3BC8 Offset: 0x16DFBC8 VA: 0x16E3BC8 Slot: 44
	public override string GetString(byte[] bytes) { }

	// RVA: 0x16E3C30 Offset: 0x16DFC30 VA: 0x16E3C30 Slot: 8
	public override string get_BodyName() { }

	// RVA: 0x16E3C38 Offset: 0x16DFC38 VA: 0x16E3C38 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x16E3C40 Offset: 0x16DFC40 VA: 0x16E3C40 Slot: 10
	public override string get_HeaderName() { }

	// RVA: 0x16E3C48 Offset: 0x16DFC48 VA: 0x16E3C48 Slot: 13
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x16E3C50 Offset: 0x16DFC50 VA: 0x16E3C50 Slot: 14
	public override bool get_IsBrowserSave() { }

	// RVA: 0x16E3C58 Offset: 0x16DFC58 VA: 0x16E3C58 Slot: 15
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x16E3C60 Offset: 0x16DFC60 VA: 0x16E3C60 Slot: 16
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x16E3C68 Offset: 0x16DFC68 VA: 0x16E3C68 Slot: 11
	public override string get_WebName() { }

	// RVA: 0x16E3C70 Offset: 0x16DFC70 VA: 0x16E3C70 Slot: 12
	public override int get_WindowsCodePage() { }
}

// Namespace: I18N.Common
[Serializable]
public class ReferenceSourceDefaultEncoder : Encoder, IObjectReference // TypeDefIndex: 7816
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x16E3C78 Offset: 0x16DFC78 VA: 0x16E3C78
	public void .ctor(Encoding encoding) { }

	// RVA: 0x16E3CB4 Offset: 0x16DFCB4 VA: 0x16E3CB4
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16E3F2C Offset: 0x16DFF2C VA: 0x16E3F2C Slot: 11
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x16E3F58 Offset: 0x16DFF58 VA: 0x16E3F58 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x16E3F78 Offset: 0x16DFF78 VA: 0x16E3F78 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x16E3F98 Offset: 0x16DFF98 VA: 0x16E3F98 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x16E3FB8 Offset: 0x16DFFB8 VA: 0x16E3FB8 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

// Namespace: I18N.Common
public sealed class Handlers // TypeDefIndex: 7817
{
	// Fields
	public static readonly string[] List; // 0x0
	private static Dictionary<string, string> aliases; // 0x8

	// Methods

	// RVA: 0x16E3FD8 Offset: 0x16DFFD8 VA: 0x16E3FD8
	public static string GetAlias(string name) { }

	// RVA: 0x16E40A0 Offset: 0x16E00A0 VA: 0x16E40A0
	private static void BuildHash() { }

	// RVA: 0x16E5304 Offset: 0x16E1304 VA: 0x16E5304
	public void .ctor() { }

	// RVA: 0x16E530C Offset: 0x16E130C VA: 0x16E530C
	private static void .cctor() { }
}

// Namespace: I18N.Common
public class Manager // TypeDefIndex: 7818
{
	// Fields
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly object lockobj; // 0x8
	private const string hex = "0123456789abcdef";

	// Properties
	public static Manager PrimaryManager { get; }

	// Methods

	// RVA: 0x16E752C Offset: 0x16E352C VA: 0x16E752C
	private void .ctor() { }

	// RVA: 0x16E787C Offset: 0x16E387C VA: 0x16E787C
	public static Manager get_PrimaryManager() { }

	// RVA: 0x16E79F0 Offset: 0x16E39F0 VA: 0x16E79F0
	private static string Normalize(string name) { }

	// RVA: 0x16E7A70 Offset: 0x16E3A70 VA: 0x16E7A70
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x16E8020 Offset: 0x16E4020 VA: 0x16E8020
	public Encoding GetEncoding(string name) { }

	// RVA: 0x16E82AC Offset: 0x16E42AC VA: 0x16E82AC
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x16E848C Offset: 0x16E448C VA: 0x16E848C
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x16E7B34 Offset: 0x16E3B34 VA: 0x16E7B34
	internal object Instantiate(string name) { }

	// RVA: 0x16E761C Offset: 0x16E361C VA: 0x16E761C
	private void LoadClassList() { }

	// RVA: 0x16E85E8 Offset: 0x16E45E8 VA: 0x16E85E8
	private void LoadInternalClasses() { }

	// RVA: 0x16E8720 Offset: 0x16E4720 VA: 0x16E8720
	private static void .cctor() { }
}

// Namespace: I18N.Common
[Serializable]
public abstract class MonoEncoding : Encoding // TypeDefIndex: 7819
{
	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x16E1B60 Offset: 0x16DDB60 VA: 0x16E1B60
	public void .ctor(int codePage) { }

	// RVA: 0x16E8794 Offset: 0x16E4794 VA: 0x16E8794
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x16E87BC Offset: 0x16E47BC VA: 0x16E87BC Slot: 12
	public override int get_WindowsCodePage() { }

	// RVA: 0x16E87D4 Offset: 0x16E47D4 VA: 0x16E87D4 Slot: 49
	protected virtual int GetBytesInternal(char* chars, int charCount, byte* bytes, int byteCount, bool flush, object state) { }

	// RVA: 0x16E8820 Offset: 0x16E4820 VA: 0x16E8820
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }

	// RVA: 0x16E8AB4 Offset: 0x16E4AB4 VA: 0x16E8AB4
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	// RVA: 0x16E8AD0 Offset: 0x16E4AD0 VA: 0x16E8AD0 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x16E8C24 Offset: 0x16E4C24 VA: 0x16E8C24 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E8E5C Offset: 0x16E4E5C VA: 0x16E8E5C Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x16E90B4 Offset: 0x16E50B4 VA: 0x16E90B4 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x16E90C4 Offset: 0x16E50C4 VA: 0x16E90C4 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract int GetByteCountImpl(char* chars, int charCount);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);

	// RVA: 0x16E90D4 Offset: 0x16E50D4 VA: 0x16E90D4 Slot: 41
	public override Encoder GetEncoder() { }
}

// Namespace: I18N.Common
public abstract class MonoEncoder : Encoder // TypeDefIndex: 7820
{
	// Fields
	private MonoEncoding encoding; // 0x20

	// Methods

	// RVA: 0x16E9180 Offset: 0x16E5180 VA: 0x16E9180
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x16E91B0 Offset: 0x16E51B0 VA: 0x16E91B0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	// RVA: 0x16E9308 Offset: 0x16E5308 VA: 0x16E9308 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	// RVA: 0x16E953C Offset: 0x16E553C VA: 0x16E953C Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x16E9548 Offset: 0x16E5548 VA: 0x16E9548
	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }
}

// Namespace: I18N.Common
public class MonoEncodingDefaultEncoder : ReferenceSourceDefaultEncoder // TypeDefIndex: 7821
{
	// Methods

	// RVA: 0x16E9144 Offset: 0x16E5144 VA: 0x16E9144
	public void .ctor(Encoding encoding) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x16E95DC Offset: 0x16E55DC VA: 0x16E95DC Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisible(False)]
	// RVA: 0x16E97A0 Offset: 0x16E57A0 VA: 0x16E97A0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x16E96C8 Offset: 0x16E56C8 VA: 0x16E96C8
	private void CheckArguments(char* chars, int charCount, byte* bytes, int byteCount) { }
}

// Namespace: I18N.Common
[Serializable]
public abstract class MonoSafeEncoding : Encoding // TypeDefIndex: 7822
{
	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x16E2C00 Offset: 0x16DEC00 VA: 0x16E2C00
	public void .ctor(int codePage) { }

	// RVA: 0x16E99D0 Offset: 0x16E59D0 VA: 0x16E99D0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x16E99F8 Offset: 0x16E59F8 VA: 0x16E99F8 Slot: 12
	public override int get_WindowsCodePage() { }

	// RVA: 0x16E9A10 Offset: 0x16E5A10 VA: 0x16E9A10 Slot: 49
	protected virtual int GetBytesInternal(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush, object state) { }

	// RVA: 0x16E9A5C Offset: 0x16E5A5C VA: 0x16E9A5C
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char[] chars, ref int charIndex, ref int charCount, byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
}

// Namespace: I18N.Common
public abstract class MonoSafeEncoder : Encoder // TypeDefIndex: 7823
{
	// Fields
	private MonoSafeEncoding encoding; // 0x20

	// Methods

	// RVA: 0x16E9D3C Offset: 0x16E5D3C VA: 0x16E9D3C
	public void .ctor(MonoSafeEncoding encoding) { }

	// RVA: 0x16E9D6C Offset: 0x16E5D6C VA: 0x16E9D6C
	public void HandleFallback(char[] chars, ref int charIndex, ref int charCount, byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
}

// Namespace: I18N.Common
public sealed class Strings // TypeDefIndex: 7824
{
	// Methods

	// RVA: 0x16E220C Offset: 0x16DE20C VA: 0x16E220C
	public static string GetString(string tag) { }

	// RVA: 0x16E9E00 Offset: 0x16E5E00 VA: 0x16E9E00
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7825
{}

// Namespace: 
internal static class SR // TypeDefIndex: 7826
{
	// Methods

	// RVA: 0x1B326D4 Offset: 0x1B2E6D4 VA: 0x1B326D4
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: 
private enum BigInteger.GetBytesMode // TypeDefIndex: 7827
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;
}
