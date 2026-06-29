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

// Namespace: System.Text
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 620
{
	// Fields
	internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default; // 0x0

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x1917B10 Offset: 0x1913B10 VA: 0x1917B10
	public void .ctor() { }

	// RVA: 0x1917B1C Offset: 0x1913B1C VA: 0x1917B1C Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1917C74 Offset: 0x1913C74 VA: 0x1917C74 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1917DFC Offset: 0x1913DFC VA: 0x1917DFC Slot: 19
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x1917E88 Offset: 0x1913E88 VA: 0x1917E88 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1917F58 Offset: 0x1913F58 VA: 0x1917F58 Slot: 27
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19181A0 Offset: 0x19141A0 VA: 0x19181A0 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1918414 Offset: 0x1914414 VA: 0x1918414 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x191850C Offset: 0x191450C VA: 0x191850C Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1918694 Offset: 0x1914694 VA: 0x1918694 Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1918764 Offset: 0x1914764 VA: 0x1918764 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x19189DC Offset: 0x19149DC VA: 0x19189DC Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1918AD4 Offset: 0x1914AD4 VA: 0x1918AD4 Slot: 45
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x1918C68 Offset: 0x1914C68 VA: 0x1918C68 Slot: 22
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x191905C Offset: 0x191505C VA: 0x191905C Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x19194CC Offset: 0x19154CC VA: 0x19194CC Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1919670 Offset: 0x1915670 VA: 0x1919670 Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1919910 Offset: 0x1915910 VA: 0x1919910 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1919A0C Offset: 0x1915A0C VA: 0x1919A0C Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1919B08 Offset: 0x1915B08 VA: 0x1919B08 Slot: 17
	public override bool get_IsSingleByte() { }

	// RVA: 0x1919B10 Offset: 0x1915B10 VA: 0x1919B10 Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x1919BC8 Offset: 0x1915BC8 VA: 0x1919BC8 Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x1919C80 Offset: 0x1915C80 VA: 0x1919C80
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public abstract class Decoder // TypeDefIndex: 621
{
	// Fields
	internal DecoderFallback _fallback; // 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public DecoderFallback Fallback { get; }
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x1919D54 Offset: 0x1915D54 VA: 0x1919D54
	protected void .ctor() { }

	// RVA: 0x1919D5C Offset: 0x1915D5C VA: 0x1919D5C
	public DecoderFallback get_Fallback() { }

	// RVA: 0x191961C Offset: 0x191561C VA: 0x191961C
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x1919D64 Offset: 0x1915D64 VA: 0x1919D64
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x1919D74 Offset: 0x1915D74 VA: 0x1919D74 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	// RVA: 0x1919E94 Offset: 0x1915E94 VA: 0x1919E94 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x1919EA0 Offset: 0x1915EA0 VA: 0x1919EA0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x1919FFC Offset: 0x1915FFC VA: 0x1919FFC Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x191A008 Offset: 0x1916008 VA: 0x191A008 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x191A210 Offset: 0x1916210 VA: 0x191A210 Slot: 11
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush) { }

	// RVA: 0x191A2F0 Offset: 0x19162F0 VA: 0x191A2F0 Slot: 12
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x191A5CC Offset: 0x19165CC VA: 0x191A5CC Slot: 13
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 622
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18
	internal char _cReplacement; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191A7EC Offset: 0x19167EC VA: 0x191A7EC
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191A82C Offset: 0x191682C VA: 0x191A82C Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191A9CC Offset: 0x19169CC VA: 0x191A9CC Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191A9D4 Offset: 0x19169D4 VA: 0x191A9D4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191AA78 Offset: 0x1916A78 VA: 0x191AA78 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 623
{
	// Fields
	private char _cBestFit; // 0x20
	private int _iCount; // 0x24
	private int _iSize; // 0x28
	private InternalDecoderBestFitFallback _oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191AA98 Offset: 0x1916A98 VA: 0x191AA98
	private static object get_InternalSyncObject() { }

	// RVA: 0x191A884 Offset: 0x1916884 VA: 0x191A884
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x191AB34 Offset: 0x1916B34 VA: 0x191AB34 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191ACC0 Offset: 0x1916CC0 VA: 0x191ACC0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x191AD00 Offset: 0x1916D00 VA: 0x191AD00 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x191AD0C Offset: 0x1916D0C VA: 0x191AD0C Slot: 7
	public override void Reset() { }

	// RVA: 0x191AD1C Offset: 0x1916D1C VA: 0x191AD1C Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191AB74 Offset: 0x1916B74 VA: 0x191AB74
	private char TryBestFit(byte[] bytesCheck) { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderExceptionFallback : DecoderFallback // TypeDefIndex: 624
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191AD24 Offset: 0x1916D24 VA: 0x191AD24
	public void .ctor() { }

	// RVA: 0x191AD2C Offset: 0x1916D2C VA: 0x191AD2C Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191AD88 Offset: 0x1916D88 VA: 0x191AD88 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191AD90 Offset: 0x1916D90 VA: 0x191AD90 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191ADEC Offset: 0x1916DEC VA: 0x191ADEC Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 625
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191ADF4 Offset: 0x1916DF4 VA: 0x191ADF4 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191AFC8 Offset: 0x1916FC8 VA: 0x191AFC8 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x191AFD0 Offset: 0x1916FD0 VA: 0x191AFD0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x191ADFC Offset: 0x1916DFC VA: 0x191ADFC
	private void Throw(byte[] bytesUnknown, int index) { }

	// RVA: 0x191AD80 Offset: 0x1916D80 VA: 0x191AD80
	public void .ctor() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 626
{
	// Fields
	private byte[] _bytesUnknown; // 0x98
	private int _index; // 0xA0

	// Methods

	// RVA: 0x191B014 Offset: 0x1917014 VA: 0x191B014
	public void .ctor() { }

	// RVA: 0x191AFD8 Offset: 0x1916FD8 VA: 0x191AFD8
	public void .ctor(string message, byte[] bytesUnknown, int index) { }

	// RVA: 0x191B070 Offset: 0x1917070 VA: 0x191B070
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class DecoderFallback // TypeDefIndex: 627
{
	// Fields
	private static DecoderFallback s_replacementFallback; // 0x0
	private static DecoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x1917BE0 Offset: 0x1913BE0 VA: 0x1917BE0
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x191B0C0 Offset: 0x19170C0 VA: 0x191B0C0
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x191A824 Offset: 0x1916824 VA: 0x191A824
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class DecoderFallbackBuffer // TypeDefIndex: 628
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x191B15C Offset: 0x191715C VA: 0x191B15C Slot: 7
	public virtual void Reset() { }

	// RVA: 0x1919900 Offset: 0x1915900 VA: 0x1919900
	internal void InternalReset() { }

	// RVA: 0x1919668 Offset: 0x1915668 VA: 0x1919668
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x191B184 Offset: 0x1917184 VA: 0x191B184 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x191B2E0 Offset: 0x19172E0 VA: 0x191B2E0 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x191B41C Offset: 0x191741C VA: 0x191B41C
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x191AB2C Offset: 0x1916B2C VA: 0x191AB2C
	protected void .ctor() { }
}

// Namespace: System.Text
internal class DecoderNLS : Decoder // TypeDefIndex: 629
{
	// Fields
	private Encoding _encoding; // 0x20
	private bool _mustFlush; // 0x28
	internal bool _throwOnOverflow; // 0x29
	internal int _bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x1919B68 Offset: 0x1915B68 VA: 0x1919B68
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191B608 Offset: 0x1917608 VA: 0x191B608 Slot: 4
	public override void Reset() { }

	// RVA: 0x191B620 Offset: 0x1917620 VA: 0x191B620 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x191B630 Offset: 0x1917630 VA: 0x191B630 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x191B7FC Offset: 0x19177FC VA: 0x191B7FC Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x191B8EC Offset: 0x19178EC VA: 0x191B8EC Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x191B8FC Offset: 0x19178FC VA: 0x191B8FC Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x191BB80 Offset: 0x1917B80 VA: 0x191BB80 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x191BC98 Offset: 0x1917C98 VA: 0x191BC98 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x191BF54 Offset: 0x1917F54 VA: 0x191BF54 Slot: 13
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x191C0F8 Offset: 0x19180F8 VA: 0x191C0F8
	public bool get_MustFlush() { }

	// RVA: 0x191C100 Offset: 0x1918100 VA: 0x191C100 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x191C108 Offset: 0x1918108 VA: 0x191C108
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable // TypeDefIndex: 630
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191B078 Offset: 0x1917078 VA: 0x191B078
	public void .ctor() { }

	// RVA: 0x191C29C Offset: 0x191829C VA: 0x191C29C
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C3C0 Offset: 0x19183C0 VA: 0x191C3C0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191C110 Offset: 0x1918110 VA: 0x191C110
	public void .ctor(string replacement) { }

	// RVA: 0x191C41C Offset: 0x191841C VA: 0x191C41C
	public string get_DefaultString() { }

	// RVA: 0x191C424 Offset: 0x1918424 VA: 0x191C424 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191C4BC Offset: 0x19184BC VA: 0x191C4BC Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191C4D4 Offset: 0x19184D4 VA: 0x191C4D4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191C548 Offset: 0x1918548 VA: 0x191C548 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 631
{
	// Fields
	private string _strDefault; // 0x20
	private int _fallbackCount; // 0x28
	private int _fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191C47C Offset: 0x191847C VA: 0x191C47C
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x191C564 Offset: 0x1918564 VA: 0x191C564 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x191C5A4 Offset: 0x19185A4 VA: 0x191C5A4 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x191C5F8 Offset: 0x19185F8 VA: 0x191C5F8 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x191C604 Offset: 0x1918604 VA: 0x191C604 Slot: 7
	public override void Reset() { }

	// RVA: 0x191C614 Offset: 0x1918614 VA: 0x191C614 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: System.Text
[Serializable]
public abstract class Encoder // TypeDefIndex: 632
{
	// Fields
	internal EncoderFallback _fallback; // 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public EncoderFallback Fallback { get; }
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x191C62C Offset: 0x191862C VA: 0x191C62C
	protected void .ctor() { }

	// RVA: 0x191C634 Offset: 0x1918634 VA: 0x191C634
	public EncoderFallback get_Fallback() { }

	// RVA: 0x1918FA4 Offset: 0x1914FA4 VA: 0x1918FA4
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x1918F94 Offset: 0x1914F94 VA: 0x1918F94
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x191C63C Offset: 0x191863C VA: 0x191C63C Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x191C720 Offset: 0x1918720 VA: 0x191C720 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x191C87C Offset: 0x191887C VA: 0x191C87C Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x191CA80 Offset: 0x1918A80 VA: 0x191CA80 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x191CD5C Offset: 0x1918D5C VA: 0x191CD5C Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 633
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191CF7C Offset: 0x1918F7C VA: 0x191CF7C
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191CFB4 Offset: 0x1918FB4 VA: 0x191CFB4 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191D154 Offset: 0x1919154 VA: 0x191D154 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191D15C Offset: 0x191915C VA: 0x191D15C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191D21C Offset: 0x191921C VA: 0x191D21C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 634
{
	// Fields
	private char _cBestFit; // 0x30
	private InternalEncoderBestFitFallback _oFallback; // 0x38
	private int _iCount; // 0x40
	private int _iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191D23C Offset: 0x191923C VA: 0x191D23C
	private static object get_InternalSyncObject() { }

	// RVA: 0x191D00C Offset: 0x191900C VA: 0x191D00C
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x191D2D8 Offset: 0x19192D8 VA: 0x191D2D8 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191D3DC Offset: 0x19193DC VA: 0x191D3DC Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191D570 Offset: 0x1919570 VA: 0x191D570 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191D5B0 Offset: 0x19195B0 VA: 0x191D5B0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191D5DC Offset: 0x19195DC VA: 0x191D5DC Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191D5E8 Offset: 0x19195E8 VA: 0x191D5E8 Slot: 9
	public override void Reset() { }

	// RVA: 0x191D308 Offset: 0x1919308 VA: 0x191D308
	private char TryBestFit(char cUnknown) { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 635
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191D5FC Offset: 0x19195FC VA: 0x191D5FC
	public void .ctor() { }

	// RVA: 0x191D604 Offset: 0x1919604 VA: 0x191D604 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191D660 Offset: 0x1919660 VA: 0x191D660 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191D668 Offset: 0x1919668 VA: 0x191D668 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191D6C4 Offset: 0x19196C4 VA: 0x191D6C4 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 636
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191D658 Offset: 0x1919658 VA: 0x191D658
	public void .ctor() { }

	// RVA: 0x191D6CC Offset: 0x19196CC VA: 0x191D6CC Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191D7A0 Offset: 0x19197A0 VA: 0x191D7A0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191DB50 Offset: 0x1919B50 VA: 0x191DB50 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191DB58 Offset: 0x1919B58 VA: 0x191DB58 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191DB60 Offset: 0x1919B60 VA: 0x191DB60 Slot: 8
	public override int get_Remaining() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 637
{
	// Fields
	private char _charUnknown; // 0x98
	private char _charUnknownHigh; // 0x9A
	private char _charUnknownLow; // 0x9C
	private int _index; // 0xA0

	// Methods

	// RVA: 0x191DB68 Offset: 0x1919B68 VA: 0x191DB68
	public void .ctor() { }

	// RVA: 0x191D770 Offset: 0x1919770 VA: 0x191D770
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x191D9B4 Offset: 0x19199B4 VA: 0x191D9B4
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191DBC4 Offset: 0x1919BC4 VA: 0x191DBC4
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 638
{
	// Fields
	private static EncoderFallback s_replacementFallback; // 0x0
	private static EncoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x1917B50 Offset: 0x1913B50 VA: 0x1917B50
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x191DC14 Offset: 0x1919C14 VA: 0x191DC14
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x191CFAC Offset: 0x1918FAC VA: 0x191CFAC
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class EncoderFallbackBuffer // TypeDefIndex: 639
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x191DCAC Offset: 0x1919CAC VA: 0x191DCAC Slot: 9
	public virtual void Reset() { }

	// RVA: 0x191DCD4 Offset: 0x1919CD4 VA: 0x191DCD4
	internal void InternalReset() { }

	// RVA: 0x1918FF0 Offset: 0x1914FF0 VA: 0x1918FF0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x191902C Offset: 0x191502C VA: 0x191902C
	internal char InternalGetNextChar() { }

	// RVA: 0x191DCEC Offset: 0x1919CEC VA: 0x191DCEC Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x191DE7C Offset: 0x1919E7C VA: 0x191DE7C
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x191D2D0 Offset: 0x19192D0 VA: 0x191D2D0
	protected void .ctor() { }
}

// Namespace: System.Text
internal class EncoderNLS : Encoder // TypeDefIndex: 640
{
	// Fields
	internal char _charLeftOver; // 0x20
	private Encoding _encoding; // 0x28
	private bool _mustFlush; // 0x30
	internal bool _throwOnOverflow; // 0x31
	internal int _charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x1919C20 Offset: 0x1915C20 VA: 0x1919C20
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191DF08 Offset: 0x1919F08 VA: 0x191DF08 Slot: 4
	public override void Reset() { }

	// RVA: 0x191DF28 Offset: 0x1919F28 VA: 0x191DF28 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x191E0F4 Offset: 0x191A0F4 VA: 0x191E0F4 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x191E1E4 Offset: 0x191A1E4 VA: 0x191E1E4 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x191E464 Offset: 0x191A464 VA: 0x191E464 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x191E57C Offset: 0x191A57C VA: 0x191E57C Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x191E834 Offset: 0x191A834 VA: 0x191E834 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x191E9D4 Offset: 0x191A9D4 VA: 0x191E9D4
	public Encoding get_Encoding() { }

	// RVA: 0x191E9DC Offset: 0x191A9DC VA: 0x191E9DC
	public bool get_MustFlush() { }

	// RVA: 0x191E9E4 Offset: 0x191A9E4 VA: 0x191E9E4 Slot: 11
	internal virtual bool get_HasState() { }

	// RVA: 0x191E9F4 Offset: 0x191A9F4 VA: 0x191E9F4
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable // TypeDefIndex: 641
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191DBCC Offset: 0x1919BCC VA: 0x191DBCC
	public void .ctor() { }

	// RVA: 0x191EB88 Offset: 0x191AB88 VA: 0x191EB88
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191ECAC Offset: 0x191ACAC VA: 0x191ECAC Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191E9FC Offset: 0x191A9FC VA: 0x191E9FC
	public void .ctor(string replacement) { }

	// RVA: 0x191ED08 Offset: 0x191AD08 VA: 0x191ED08
	public string get_DefaultString() { }

	// RVA: 0x191ED10 Offset: 0x191AD10 VA: 0x191ED10 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x191EDB8 Offset: 0x191ADB8 VA: 0x191EDB8 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191EDD0 Offset: 0x191ADD0 VA: 0x191EDD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191EE44 Offset: 0x191AE44 VA: 0x191EE44 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 642
{
	// Fields
	private string _strDefault; // 0x30
	private int _fallbackCount; // 0x38
	private int _fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x191ED68 Offset: 0x191AD68 VA: 0x191ED68
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x191EE60 Offset: 0x191AE60 VA: 0x191EE60 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x191EF84 Offset: 0x191AF84 VA: 0x191EF84 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x191F158 Offset: 0x191B158 VA: 0x191F158 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x191F1AC Offset: 0x191B1AC VA: 0x191F1AC Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x191F1DC Offset: 0x191B1DC VA: 0x191F1DC Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x191F1E8 Offset: 0x191B1E8 VA: 0x191F1E8 Slot: 9
	public override void Reset() { }
}

// Namespace: System.Text
[Serializable]
internal abstract class EncodingNLS : Encoding // TypeDefIndex: 643
{
	// Methods

	// RVA: 0x191F1FC Offset: 0x191B1FC VA: 0x191F1FC
	protected void .ctor(int codePage) { }

	// RVA: 0x191F204 Offset: 0x191B204 VA: 0x191F204 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x191F38C Offset: 0x191B38C VA: 0x191F38C Slot: 19
	public override int GetByteCount(string s) { }

	// RVA: 0x191F418 Offset: 0x191B418 VA: 0x191F418 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x191F4E8 Offset: 0x191B4E8 VA: 0x191F4E8 Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x191F730 Offset: 0x191B730 VA: 0x191F730 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x191F9A4 Offset: 0x191B9A4 VA: 0x191F9A4 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x191FA9C Offset: 0x191BA9C VA: 0x191FA9C Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x191FC24 Offset: 0x191BC24 VA: 0x191FC24 Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x191FCF4 Offset: 0x191BCF4 VA: 0x191FCF4 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x191FF6C Offset: 0x191BF6C VA: 0x191FF6C Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1920064 Offset: 0x191C064 VA: 0x1920064 Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19201F8 Offset: 0x191C1F8 VA: 0x19201F8 Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x1920250 Offset: 0x191C250 VA: 0x1920250 Slot: 41
	public override Encoder GetEncoder() { }
}

// Namespace: System.Text
public abstract class EncodingProvider // TypeDefIndex: 644
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x173E70C Offset: 0x173A70C VA: 0x173E70C Slot: 6
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x173E80C Offset: 0x173A80C VA: 0x173E80C
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x173E8F0 Offset: 0x173A8F0 VA: 0x173E8F0
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x173E9D4 Offset: 0x173A9D4 VA: 0x173E9D4
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x173EAD0 Offset: 0x173AAD0 VA: 0x173EAD0
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 645
{
	// Fields
	internal static readonly Latin1Encoding s_default; // 0x0
	private static readonly char[] arrayCharBestFit; // 0x8

	// Properties
	public override bool IsSingleByte { get; }

	// Methods

	// RVA: 0x173EB4C Offset: 0x173AB4C VA: 0x173EB4C
	public void .ctor() { }

	// RVA: 0x173EB58 Offset: 0x173AB58 VA: 0x173EB58
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173EBA4 Offset: 0x173ABA4 VA: 0x173EBA4 Slot: 49
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173EC8C Offset: 0x173AC8C VA: 0x173EC8C Slot: 22
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x173EE88 Offset: 0x173AE88 VA: 0x173EE88 Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x173F1E4 Offset: 0x173B1E4 VA: 0x173F1E4 Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x173F1EC Offset: 0x173B1EC VA: 0x173F1EC Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x173F270 Offset: 0x173B270 VA: 0x173F270 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x173F36C Offset: 0x173B36C VA: 0x173F36C Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x173F468 Offset: 0x173B468 VA: 0x173F468 Slot: 17
	public override bool get_IsSingleByte() { }

	// RVA: 0x173F470 Offset: 0x173B470 VA: 0x173F470 Slot: 39
	public override bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x173F47C Offset: 0x173B47C VA: 0x173F47C Slot: 46
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x173F4D4 Offset: 0x173B4D4 VA: 0x173F4D4
	private static void .cctor() { }
}

// Namespace: System.Text
public enum NormalizationForm // TypeDefIndex: 646
{
	// Fields
	public int value__; // 0x0
	public const NormalizationForm FormC = 1;
	public const NormalizationForm FormD = 2;
	public const NormalizationForm FormKC = 5;
	public const NormalizationForm FormKD = 6;
}

// Namespace: System.Text
[DefaultMember("Chars")]
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 647
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28

	// Properties
	public int Capacity { get; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }
	private Span<char> RemainingCurrentChunk { get; }

	// Methods

	// RVA: 0x173F5A0 Offset: 0x173B5A0 VA: 0x173F5A0
	public void .ctor() { }

	// RVA: 0x173F60C Offset: 0x173B60C VA: 0x173F60C
	public void .ctor(int capacity) { }

	// RVA: 0x173F7E4 Offset: 0x173B7E4 VA: 0x173F7E4
	public void .ctor(string value) { }

	// RVA: 0x173F800 Offset: 0x173B800 VA: 0x173F800
	public void .ctor(string value, int capacity) { }

	// RVA: 0x173F81C Offset: 0x173B81C VA: 0x173F81C
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x173F614 Offset: 0x173B614 VA: 0x173F614
	public void .ctor(int capacity, int maxCapacity) { }

	// RVA: 0x173FB38 Offset: 0x173BB38 VA: 0x173FB38
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173FE34 Offset: 0x173BE34 VA: 0x173FE34 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173FF78 Offset: 0x173BF78 VA: 0x173FF78
	public int get_Capacity() { }

	// RVA: 0x173FF98 Offset: 0x173BF98 VA: 0x173FF98
	public int get_MaxCapacity() { }

	// RVA: 0x173FFA0 Offset: 0x173BFA0 VA: 0x173FFA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17400C0 Offset: 0x173C0C0 VA: 0x17400C0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x1740420 Offset: 0x173C420 VA: 0x1740420
	public StringBuilder Clear() { }

	// RVA: 0x17400B4 Offset: 0x173C0B4 VA: 0x17400B4
	public int get_Length() { }

	// RVA: 0x174043C Offset: 0x173C43C VA: 0x174043C
	public void set_Length(int value) { }

	// RVA: 0x17407FC Offset: 0x173C7FC VA: 0x17407FC
	public char get_Chars(int index) { }

	// RVA: 0x1740884 Offset: 0x173C884 VA: 0x1740884
	public void set_Chars(int index, char value) { }

	// RVA: 0x17406A0 Offset: 0x173C6A0 VA: 0x17406A0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x1740AEC Offset: 0x173CAEC VA: 0x1740AEC
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1740D78 Offset: 0x173CD78 VA: 0x1740D78
	public StringBuilder Append(string value) { }

	// RVA: 0x1740E7C Offset: 0x173CE7C VA: 0x1740E7C
	private void AppendHelper(string value) { }

	// RVA: 0x1740EB4 Offset: 0x173CEB4 VA: 0x1740EB4
	public StringBuilder Append(string value, int startIndex, int count) { }

	// RVA: 0x1740FF0 Offset: 0x173CFF0 VA: 0x1740FF0
	public StringBuilder Append(StringBuilder value) { }

	// RVA: 0x1741014 Offset: 0x173D014 VA: 0x1741014
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	// RVA: 0x174122C Offset: 0x173D22C VA: 0x174122C
	public StringBuilder AppendLine() { }

	// RVA: 0x174124C Offset: 0x173D24C VA: 0x174124C
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x1740258 Offset: 0x173C258 VA: 0x1740258
	public void CopyTo(int sourceIndex, Span<char> destination, int count) { }

	// RVA: 0x17413D4 Offset: 0x173D3D4 VA: 0x17413D4
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x1741694 Offset: 0x173D694 VA: 0x1741694
	public StringBuilder Append(char value) { }

	// RVA: 0x17416E4 Offset: 0x173D6E4 VA: 0x17416E4
	public StringBuilder Append(byte value) { }

	// RVA: 0x174173C Offset: 0x173D73C VA: 0x174173C
	public StringBuilder Append(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1741794 Offset: 0x173D794 VA: 0x1741794
	public StringBuilder Append(uint value) { }

	// RVA: -1 Offset: -1
	private StringBuilder AppendSpanFormattable<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114D68C Offset: 0x114968C VA: 0x114D68C
	|-StringBuilder.AppendSpanFormattable<byte>
	|
	|-RVA: 0x114D718 Offset: 0x1149718 VA: 0x114D718
	|-StringBuilder.AppendSpanFormattable<int>
	|
	|-RVA: 0x114D7A4 Offset: 0x11497A4 VA: 0x114D7A4
	|-StringBuilder.AppendSpanFormattable<uint>
	|
	|-RVA: 0x114D830 Offset: 0x1149830 VA: 0x114D830
	|-StringBuilder.AppendSpanFormattable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17417EC Offset: 0x173D7EC VA: 0x17417EC
	public StringBuilder Append(object value) { }

	// RVA: 0x1741824 Offset: 0x173D824 VA: 0x1741824
	public StringBuilder Append(char[] value) { }

	// RVA: 0x174184C Offset: 0x173D84C VA: 0x174184C
	public StringBuilder Append(ReadOnlySpan<char> value) { }

	// RVA: 0x17418D4 Offset: 0x173D8D4 VA: 0x17418D4
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x1741A54 Offset: 0x173DA54 VA: 0x1741A54
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x1741A80 Offset: 0x173DA80 VA: 0x1741A80
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x1742560 Offset: 0x173E560 VA: 0x1742560
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x17425BC Offset: 0x173E5BC VA: 0x17425BC
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x1742670 Offset: 0x173E670 VA: 0x1742670
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x17426CC Offset: 0x173E6CC VA: 0x17426CC
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1742730 Offset: 0x173E730 VA: 0x1742730
	private static void FormatError() { }

	// RVA: 0x1741AD8 Offset: 0x173DAD8 VA: 0x1741AD8
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x174277C Offset: 0x173E77C VA: 0x174277C
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x174278C Offset: 0x173E78C VA: 0x174278C
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1740C28 Offset: 0x173CC28 VA: 0x1740C28
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1741984 Offset: 0x173D984 VA: 0x1741984
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1742B68 Offset: 0x173EB68 VA: 0x1742B68
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1742A88 Offset: 0x173EA88 VA: 0x1742A88
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1742FF4 Offset: 0x173EFF4 VA: 0x1742FF4
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x173FA70 Offset: 0x173BA70 VA: 0x173FA70
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1741270 Offset: 0x173D270 VA: 0x1741270
	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count) { }

	// RVA: 0x17407D4 Offset: 0x173C7D4 VA: 0x17407D4
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1743148 Offset: 0x173F148 VA: 0x1743148
	private Span<char> get_RemainingCurrentChunk() { }

	// RVA: 0x1743108 Offset: 0x173F108 VA: 0x1743108
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x174093C Offset: 0x173C93C VA: 0x174093C
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x17431B0 Offset: 0x173F1B0 VA: 0x17431B0
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1742D14 Offset: 0x173ED14 VA: 0x1742D14
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	// RVA: 0x174320C Offset: 0x173F20C VA: 0x174320C
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x1741504 Offset: 0x173D504 VA: 0x1741504
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 648
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x17432B4 Offset: 0x173F2B4 VA: 0x17432B4
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x1743388 Offset: 0x173F388 VA: 0x1743388
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1743410 Offset: 0x173F410 VA: 0x1743410
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: 
[Serializable]
private sealed class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 649
{
	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1745438 Offset: 0x1741438 VA: 0x1745438
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x1745BA4 Offset: 0x1741BA4 VA: 0x1745BA4 Slot: 4
	public override void Reset() { }

	// RVA: 0x1745BC4 Offset: 0x1741BC4 VA: 0x1745BC4 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 650
{
	// Fields
	internal static readonly UTF32Encoding s_default; // 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	private bool _emitUTF32ByteOrderMark; // 0x38
	private bool _isThrowException; // 0x39
	private bool _bigEndian; // 0x3A

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x174344C Offset: 0x173F44C VA: 0x174344C
	public void .ctor() { }

	// RVA: 0x17434E0 Offset: 0x173F4E0 VA: 0x17434E0
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1743474 Offset: 0x173F474 VA: 0x1743474
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x1743520 Offset: 0x173F520 VA: 0x1743520 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x174360C Offset: 0x173F60C VA: 0x174360C Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1743794 Offset: 0x173F794 VA: 0x1743794 Slot: 19
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x1743820 Offset: 0x173F820 VA: 0x1743820 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x17438F0 Offset: 0x173F8F0 VA: 0x17438F0 Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1743B38 Offset: 0x173FB38 VA: 0x1743B38 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1743DAC Offset: 0x173FDAC VA: 0x1743DAC Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1743EA4 Offset: 0x173FEA4 VA: 0x1743EA4 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x174402C Offset: 0x174002C VA: 0x174402C Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x17440FC Offset: 0x17400FC VA: 0x17440FC Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1744374 Offset: 0x1740374 VA: 0x1744374 Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x174446C Offset: 0x174046C VA: 0x174446C Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1744600 Offset: 0x1740600 VA: 0x1744600 Slot: 22
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x17448B0 Offset: 0x17408B0 VA: 0x17448B0 Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1744C74 Offset: 0x1740C74 VA: 0x1744C74 Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1744FB8 Offset: 0x1740FB8 VA: 0x1744FB8 Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1744C58 Offset: 0x1740C58 VA: 0x1744C58
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x17453BC Offset: 0x17413BC VA: 0x17453BC
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x17453D0 Offset: 0x17413D0 VA: 0x17453D0
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x17453DC Offset: 0x17413DC VA: 0x17453DC Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x1745440 Offset: 0x1741440 VA: 0x1745440 Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x174549C Offset: 0x174149C VA: 0x174549C Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1745598 Offset: 0x1741598 VA: 0x1745598 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1745660 Offset: 0x1741660 VA: 0x1745660 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1745784 Offset: 0x1741784 VA: 0x1745784 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x1745910 Offset: 0x1741910 VA: 0x1745910 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x17459CC Offset: 0x17419CC VA: 0x17459CC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1745A48 Offset: 0x1741A48 VA: 0x1745A48
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.Decoder : DecoderNLS // TypeDefIndex: 651
{
	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1747758 Offset: 0x1743758 VA: 0x1747758
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x174796C Offset: 0x174396C VA: 0x174796C Slot: 4
	public override void Reset() { }

	// RVA: 0x1747994 Offset: 0x1743994 VA: 0x1747994 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.Encoder : EncoderNLS // TypeDefIndex: 652
{
	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x17477BC Offset: 0x17437BC VA: 0x17477BC
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x17479A4 Offset: 0x17439A4 VA: 0x17479A4 Slot: 4
	public override void Reset() { }

	// RVA: 0x17479C8 Offset: 0x17439C8 VA: 0x17479C8 Slot: 11
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 653
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1745F74 Offset: 0x1741F74 VA: 0x1745F74
	public void .ctor() { }

	// RVA: 0x17479E8 Offset: 0x17439E8 VA: 0x17479E8 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1747A54 Offset: 0x1743A54 VA: 0x1747A54 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1747A5C Offset: 0x1743A5C VA: 0x1747A5C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1747AB8 Offset: 0x1743AB8 VA: 0x1747AB8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 654
{
	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1747A44 Offset: 0x1743A44 VA: 0x1747A44
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1747AC0 Offset: 0x1743AC0 VA: 0x1747AC0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1747AFC Offset: 0x1743AFC VA: 0x1747AFC Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1747B1C Offset: 0x1743B1C VA: 0x1747B1C Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1747B28 Offset: 0x1743B28 VA: 0x1747B28 Slot: 7
	public override void Reset() { }

	// RVA: 0x1747B38 Offset: 0x1743B38 VA: 0x1747B38 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: System.Text
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 655
{
	// Fields
	internal static readonly UTF7Encoding s_default; // 0x0
	private byte[] _base64Bytes; // 0x38
	private sbyte[] _base64Values; // 0x40
	private bool[] _directEncode; // 0x48
	private bool _allowOptionals; // 0x50

	// Methods

	// RVA: 0x1745BD4 Offset: 0x1741BD4 VA: 0x1745BD4
	public void .ctor() { }

	// RVA: 0x1745BF8 Offset: 0x1741BF8 VA: 0x1745BF8
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x1745C28 Offset: 0x1741C28 VA: 0x1745C28
	private void MakeTables() { }

	// RVA: 0x1745EBC Offset: 0x1741EBC VA: 0x1745EBC Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1745F7C Offset: 0x1741F7C VA: 0x1745F7C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1746044 Offset: 0x1742044 VA: 0x1746044 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17460B0 Offset: 0x17420B0 VA: 0x17460B0 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1746238 Offset: 0x1742238 VA: 0x1746238 Slot: 19
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x17462C4 Offset: 0x17422C4 VA: 0x17462C4 Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1746394 Offset: 0x1742394 VA: 0x1746394 Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x17465DC Offset: 0x17425DC VA: 0x17465DC Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1746850 Offset: 0x1742850 VA: 0x1746850 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1746948 Offset: 0x1742948 VA: 0x1746948 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1746AD0 Offset: 0x1742AD0 VA: 0x1746AD0 Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1746BA0 Offset: 0x1742BA0 VA: 0x1746BA0 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1746E18 Offset: 0x1742E18 VA: 0x1746E18 Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1746F10 Offset: 0x1742F10 VA: 0x1746F10 Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x17470A4 Offset: 0x17430A4 VA: 0x17470A4 Slot: 22
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x17470C0 Offset: 0x17430C0 VA: 0x17470C0 Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1747430 Offset: 0x1743430 VA: 0x1747430 Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x174744C Offset: 0x174344C VA: 0x174744C Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x17476FC Offset: 0x17436FC VA: 0x17476FC Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x1747760 Offset: 0x1743760 VA: 0x1747760 Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x17477C4 Offset: 0x17437C4 VA: 0x17477C4 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1747880 Offset: 0x1743880 VA: 0x1747880 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x17478F4 Offset: 0x17438F4 VA: 0x17478F4
	private static void .cctor() { }
}

// Namespace: 
internal sealed class UTF8Encoding.UTF8EncodingSealed : UTF8Encoding // TypeDefIndex: 656
{
	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x174AE98 Offset: 0x1746E98 VA: 0x174AE98
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x174AF10 Offset: 0x1746F10 VA: 0x174AF10 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }
}

// Namespace: 
[Serializable]
private sealed class UTF8Encoding.UTF8Encoder : EncoderNLS // TypeDefIndex: 657
{
	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x174A83C Offset: 0x174683C VA: 0x174A83C
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x174AFFC Offset: 0x1746FFC VA: 0x174AFFC Slot: 4
	public override void Reset() { }

	// RVA: 0x174B01C Offset: 0x174701C VA: 0x174B01C Slot: 11
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF8Encoding.UTF8Decoder : DecoderNLS // TypeDefIndex: 658
{
	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x174A7D8 Offset: 0x17467D8 VA: 0x174A7D8
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x174B02C Offset: 0x174702C VA: 0x174B02C Slot: 4
	public override void Reset() { }

	// RVA: 0x174B04C Offset: 0x174704C VA: 0x174B04C Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 659
{
	// Fields
	internal static readonly UTF8Encoding.UTF8EncodingSealed s_default; // 0x0
	internal static readonly byte[] s_preamble; // 0x8
	internal readonly bool _emitUTF8Identifier; // 0x38
	private bool _isThrowException; // 0x39

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x1747BAC Offset: 0x1743BAC VA: 0x1747BAC
	public void .ctor() { }

	// RVA: 0x1747BCC Offset: 0x1743BCC VA: 0x1747BCC
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1747BFC Offset: 0x1743BFC VA: 0x1747BFC
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1747C4C Offset: 0x1743C4C VA: 0x1747C4C Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1747D38 Offset: 0x1743D38 VA: 0x1747D38 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1747EC0 Offset: 0x1743EC0 VA: 0x1747EC0 Slot: 19
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x1747F4C Offset: 0x1743F4C VA: 0x1747F4C Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x174801C Offset: 0x174401C VA: 0x174801C Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1748264 Offset: 0x1744264 VA: 0x1748264 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x17484D8 Offset: 0x17444D8 VA: 0x17484D8 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x17485D0 Offset: 0x17445D0 VA: 0x17485D0 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1748758 Offset: 0x1744758 VA: 0x1748758 Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1748828 Offset: 0x1744828 VA: 0x1748828 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1748AA0 Offset: 0x1744AA0 VA: 0x1748AA0 Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1748B98 Offset: 0x1744B98 VA: 0x1748B98 Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1748D2C Offset: 0x1744D2C VA: 0x1748D2C Slot: 22
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x17492EC Offset: 0x17452EC VA: 0x17492EC
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x17492F8 Offset: 0x17452F8 VA: 0x17492F8
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x17492D8 Offset: 0x17452D8 VA: 0x17492D8
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1749300 Offset: 0x1745300 VA: 0x1749300 Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x17499E4 Offset: 0x17459E4 VA: 0x17499E4 Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1749EC8 Offset: 0x1745EC8 VA: 0x1749EC8 Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x174A51C Offset: 0x174651C VA: 0x174A51C
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1749E88 Offset: 0x1745E88 VA: 0x1749E88
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x174A588 Offset: 0x1746588 VA: 0x174A588
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x174A77C Offset: 0x174677C VA: 0x174A77C Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x174A7E0 Offset: 0x17467E0 VA: 0x174A7E0 Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x174A844 Offset: 0x1746844 VA: 0x174A844 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x174A940 Offset: 0x1746940 VA: 0x174A940 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x174AA3C Offset: 0x1746A3C VA: 0x174AA3C Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x174AB28 Offset: 0x1746B28 VA: 0x174AB28 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x174AC94 Offset: 0x1746C94 VA: 0x174AC94 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x174AD5C Offset: 0x1746D5C VA: 0x174AD5C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x174ADBC Offset: 0x1746DBC VA: 0x174ADBC
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class UnicodeEncoding.Decoder : DecoderNLS // TypeDefIndex: 660
{
	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x174E474 Offset: 0x174A474 VA: 0x174E474
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x174E484 Offset: 0x174A484 VA: 0x174E484 Slot: 4
	public override void Reset() { }

	// RVA: 0x174E4AC Offset: 0x174A4AC VA: 0x174E4AC Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 661
{
	// Fields
	internal static readonly UnicodeEncoding s_bigEndianDefault; // 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x20

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x174B05C Offset: 0x174705C VA: 0x174B05C
	public void .ctor() { }

	// RVA: 0x174B090 Offset: 0x1747090 VA: 0x174B090
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x174B0D8 Offset: 0x17470D8 VA: 0x174B0D8
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	// RVA: 0x174B14C Offset: 0x174714C VA: 0x174B14C Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x174B238 Offset: 0x1747238 VA: 0x174B238 Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x174B3C0 Offset: 0x17473C0 VA: 0x174B3C0 Slot: 19
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x174B44C Offset: 0x174744C VA: 0x174B44C Slot: 21
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x174B51C Offset: 0x174751C VA: 0x174B51C Slot: 27
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x174B764 Offset: 0x1747764 VA: 0x174B764 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x174B9D8 Offset: 0x17479D8 VA: 0x174B9D8 Slot: 29
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x174BAD0 Offset: 0x1747AD0 VA: 0x174BAD0 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x174BC58 Offset: 0x1747C58 VA: 0x174BC58 Slot: 31
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x174BD28 Offset: 0x1747D28 VA: 0x174BD28 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x174BFA0 Offset: 0x1747FA0 VA: 0x174BFA0 Slot: 35
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x174C098 Offset: 0x1748098 VA: 0x174C098 Slot: 45
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x174C22C Offset: 0x174822C VA: 0x174C22C Slot: 22
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x174C748 Offset: 0x1748748 VA: 0x174C748 Slot: 28
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x174CDE8 Offset: 0x1748DE8 VA: 0x174CDE8 Slot: 32
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x174D42C Offset: 0x174942C VA: 0x174D42C Slot: 36
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x174DC0C Offset: 0x1749C0C VA: 0x174DC0C Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x174DC68 Offset: 0x1749C68 VA: 0x174DC68 Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x174DCC4 Offset: 0x1749CC4 VA: 0x174DCC4 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x174DDE0 Offset: 0x1749DE0 VA: 0x174DDE0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x174DF6C Offset: 0x1749F6C VA: 0x174DF6C Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x174E068 Offset: 0x174A068 VA: 0x174E068 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x174E168 Offset: 0x174A168 VA: 0x174E168 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x174E274 Offset: 0x174A274 VA: 0x174E274 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x174E2F0 Offset: 0x174A2F0 VA: 0x174E2F0
	private static void .cctor() { }
}

// Namespace: System.Text
[IsByRefLike]
[DefaultMember("Item")]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueStringBuilder // TypeDefIndex: 662
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x174E4D0 Offset: 0x174A4D0 VA: 0x174E4D0
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x174E4E0 Offset: 0x174A4E0 VA: 0x174E4E0
	public int get_Length() { }

	// RVA: 0x174E4E8 Offset: 0x174A4E8 VA: 0x174E4E8
	public ref char get_Item(int index) { }

	// RVA: 0x174E508 Offset: 0x174A508 VA: 0x174E508 Slot: 3
	public override string ToString() { }

	// RVA: 0x174E5D8 Offset: 0x174A5D8 VA: 0x174E5D8
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x174E6C8 Offset: 0x174A6C8 VA: 0x174E6C8
	public void Append(char c) { }

	// RVA: 0x174E7C4 Offset: 0x174A7C4 VA: 0x174E7C4
	public void Append(string s) { }

	// RVA: 0x174E870 Offset: 0x174A870 VA: 0x174E870
	private void AppendSlow(string s) { }

	// RVA: 0x174EC08 Offset: 0x174AC08 VA: 0x174EC08
	public void Append(char c, int count) { }

	// RVA: 0x174EE00 Offset: 0x174AE00 VA: 0x174EE00
	public void Append(char* value, int length) { }

	// RVA: 0x174EEE4 Offset: 0x174AEE4 VA: 0x174EEE4
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x174E744 Offset: 0x174A744 VA: 0x174E744
	private void GrowAndAppend(char c) { }

	// RVA: 0x174E9A4 Offset: 0x174A9A4 VA: 0x174E9A4
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x174EFA4 Offset: 0x174AFA4 VA: 0x174EFA4
	public void Dispose() { }
}

// Namespace: System.Text
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct ValueUtf8Converter // TypeDefIndex: 663
{
	// Fields
	private byte[] _arrayToReturnToPool; // 0x0
	private Span<byte> _bytes; // 0x8

	// Methods

	// RVA: 0x174F0AC Offset: 0x174B0AC VA: 0x174F0AC
	public void .ctor(Span<byte> initialBuffer) { }

	// RVA: 0x174F0B8 Offset: 0x174B0B8 VA: 0x174F0B8
	public Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value) { }

	// RVA: 0x174F364 Offset: 0x174B364 VA: 0x174F364
	public void Dispose() { }
}

// Namespace: 
[Serializable]
internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 664
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x1752868 Offset: 0x174E868 VA: 0x1752868
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1752EC8 Offset: 0x174EEC8 VA: 0x1752EC8
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1753220 Offset: 0x174F220 VA: 0x1753220 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17532E8 Offset: 0x174F2E8 VA: 0x17532E8 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1753388 Offset: 0x174F388 VA: 0x1753388 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x17533A8 Offset: 0x174F3A8 VA: 0x17533A8 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x17533C8 Offset: 0x174F3C8 VA: 0x17533C8 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x17533E8 Offset: 0x174F3E8 VA: 0x17533E8 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

// Namespace: 
[Serializable]
internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 665
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x175257C Offset: 0x174E57C VA: 0x175257C
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1753408 Offset: 0x174F408 VA: 0x1753408
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1753700 Offset: 0x174F700 VA: 0x1753700 Slot: 15
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1753754 Offset: 0x174F754 VA: 0x1753754 Slot: 14
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17537F4 Offset: 0x174F7F4 VA: 0x17537F4 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1753804 Offset: 0x174F804 VA: 0x1753804 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1753824 Offset: 0x174F824 VA: 0x1753824 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x1753844 Offset: 0x174F844 VA: 0x1753844 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1753854 Offset: 0x174F854 VA: 0x1753854 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x1753874 Offset: 0x174F874 VA: 0x1753874 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}

// Namespace: 
internal class Encoding.EncodingCharBuffer // TypeDefIndex: 666
{
	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1753894 Offset: 0x174F894 VA: 0x1753894
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1753974 Offset: 0x174F974 VA: 0x1753974
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x17539E0 Offset: 0x174F9E0 VA: 0x17539E0
	internal bool AddChar(char ch) { }

	// RVA: 0x17539E8 Offset: 0x174F9E8 VA: 0x17539E8
	internal void AdjustBytes(int count) { }

	// RVA: 0x17539F8 Offset: 0x174F9F8 VA: 0x17539F8
	internal bool get_MoreData() { }

	// RVA: 0x1753A08 Offset: 0x174FA08 VA: 0x1753A08
	internal byte GetNextByte() { }

	// RVA: 0x1753A2C Offset: 0x174FA2C VA: 0x1753A2C
	internal int get_BytesUsed() { }

	// RVA: 0x1753A3C Offset: 0x174FA3C VA: 0x1753A3C
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x1753AB4 Offset: 0x174FAB4 VA: 0x1753AB4
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x1753B94 Offset: 0x174FB94 VA: 0x1753B94
	internal int get_Count() { }
}

// Namespace: 
internal class Encoding.EncodingByteBuffer // TypeDefIndex: 667
{
	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1753B9C Offset: 0x174FB9C VA: 0x1753B9C
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x1753DD8 Offset: 0x174FDD8 VA: 0x1753DD8
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x1753EA4 Offset: 0x174FEA4 VA: 0x1753EA4
	internal bool AddByte(byte b1) { }

	// RVA: 0x1753EAC Offset: 0x174FEAC VA: 0x1753EAC
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x1753EB4 Offset: 0x174FEB4 VA: 0x1753EB4
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x1753E28 Offset: 0x174FE28 VA: 0x1753E28
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x1753EFC Offset: 0x174FEFC VA: 0x1753EFC
	internal bool get_MoreData() { }

	// RVA: 0x1753F44 Offset: 0x174FF44 VA: 0x1753F44
	internal char GetNextChar() { }

	// RVA: 0x1753F90 Offset: 0x174FF90 VA: 0x1753F90
	internal int get_CharsUsed() { }

	// RVA: 0x1753FA8 Offset: 0x174FFA8 VA: 0x1753FA8
	internal int get_Count() { }
}

// Namespace: System.Text
[ComVisible(True)]
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 668
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Dictionary<int, Encoding> encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual ReadOnlySpan<byte> Preamble { get; }
	public virtual string BodyName { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	public virtual int WindowsCodePage { get; }
	public virtual bool IsBrowserDisplay { get; }
	public virtual bool IsBrowserSave { get; }
	public virtual bool IsMailNewsDisplay { get; }
	public virtual bool IsMailNewsSave { get; }
	[ComVisible(False)]
	public virtual bool IsSingleByte { get; }
	[ComVisible(False)]
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisible(False)]
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x174F468 Offset: 0x174B468 VA: 0x174F468
	protected void .ctor() { }

	// RVA: 0x174F498 Offset: 0x174B498 VA: 0x174F498
	protected void .ctor(int codePage) { }

	// RVA: 0x174F520 Offset: 0x174B520 VA: 0x174F520 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x174F5C8 Offset: 0x174B5C8 VA: 0x174F5C8
	internal void OnDeserializing() { }

	// RVA: 0x174F5FC Offset: 0x174B5FC VA: 0x174F5FC
	internal void OnDeserialized() { }

	[OnDeserializing]
	// RVA: 0x174F640 Offset: 0x174B640 VA: 0x174F640
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x174F674 Offset: 0x174B674 VA: 0x174F674
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x174F678 Offset: 0x174B678 VA: 0x174F678
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x174F684 Offset: 0x174B684 VA: 0x174F684
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x174FA64 Offset: 0x174BA64 VA: 0x174FA64
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x174FC0C Offset: 0x174BC0C VA: 0x174FC0C
	private static object get_InternalSyncObject() { }

	// RVA: 0x174FCA4 Offset: 0x174BCA4 VA: 0x174FCA4
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x1751014 Offset: 0x174D014 VA: 0x1751014
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x1751294 Offset: 0x174D294 VA: 0x1751294
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x1751330 Offset: 0x174D330 VA: 0x1751330 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1751388 Offset: 0x174D388 VA: 0x1751388 Slot: 7
	public virtual ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x17513DC Offset: 0x174D3DC VA: 0x17513DC
	private void GetDataItem() { }

	// RVA: 0x1751518 Offset: 0x174D518 VA: 0x1751518 Slot: 8
	public virtual string get_BodyName() { }

	// RVA: 0x1751548 Offset: 0x174D548 VA: 0x1751548 Slot: 9
	public virtual string get_EncodingName() { }

	// RVA: 0x1751554 Offset: 0x174D554 VA: 0x1751554 Slot: 10
	public virtual string get_HeaderName() { }

	// RVA: 0x1751584 Offset: 0x174D584 VA: 0x1751584 Slot: 11
	public virtual string get_WebName() { }

	// RVA: 0x17515B4 Offset: 0x174D5B4 VA: 0x17515B4 Slot: 12
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x17515E8 Offset: 0x174D5E8 VA: 0x17515E8 Slot: 13
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x1751618 Offset: 0x174D618 VA: 0x1751618 Slot: 14
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x1751648 Offset: 0x174D648 VA: 0x1751648 Slot: 15
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x1751678 Offset: 0x174D678 VA: 0x1751678 Slot: 16
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x17516A8 Offset: 0x174D6A8 VA: 0x17516A8 Slot: 17
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x17516B0 Offset: 0x174D6B0 VA: 0x17516B0
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x175111C Offset: 0x174D11C VA: 0x175111C
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x17516B8 Offset: 0x174D6B8 VA: 0x17516B8
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x17511D8 Offset: 0x174D1D8 VA: 0x17511D8
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisible(False)]
	// RVA: 0x17516C0 Offset: 0x174D6C0 VA: 0x17516C0 Slot: 18
	public virtual object Clone() { }

	// RVA: 0x1751748 Offset: 0x174D748 VA: 0x1751748
	public bool get_IsReadOnly() { }

	// RVA: 0x1750810 Offset: 0x174C810 VA: 0x1750810
	public static Encoding get_ASCII() { }

	// RVA: 0x17508B4 Offset: 0x174C8B4 VA: 0x17508B4
	private static Encoding get_Latin1() { }

	// RVA: 0x1751750 Offset: 0x174D750 VA: 0x1751750 Slot: 19
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int GetByteCount(char[] chars, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x17517DC Offset: 0x174D7DC VA: 0x17517DC Slot: 21
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1751944 Offset: 0x174D944 VA: 0x1751944 Slot: 22
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1751954 Offset: 0x174D954 VA: 0x1751954 Slot: 23
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x17519DC Offset: 0x174D9DC VA: 0x17519DC Slot: 24
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1751A98 Offset: 0x174DA98 VA: 0x1751A98 Slot: 26
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1751B9C Offset: 0x174DB9C VA: 0x1751B9C Slot: 27
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1751C48 Offset: 0x174DC48 VA: 0x1751C48 Slot: 28
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1751C58 Offset: 0x174DC58 VA: 0x1751C58 Slot: 29
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x1751E68 Offset: 0x174DE68 VA: 0x1751E68 Slot: 31
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1751FD8 Offset: 0x174DFD8 VA: 0x1751FD8 Slot: 32
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1751FE8 Offset: 0x174DFE8 VA: 0x1751FE8 Slot: 33
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x17520A4 Offset: 0x174E0A4 VA: 0x17520A4 Slot: 35
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x17522B8 Offset: 0x174E2B8 VA: 0x17522B8 Slot: 36
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x17522C8 Offset: 0x174E2C8 VA: 0x17522C8
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x17523AC Offset: 0x174E3AC VA: 0x17523AC Slot: 37
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars) { }

	// RVA: 0x1752480 Offset: 0x174E480 VA: 0x1752480
	public string GetString(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x17524FC Offset: 0x174E4FC VA: 0x17524FC Slot: 38
	public virtual int get_CodePage() { }

	[ComVisible(False)]
	// RVA: 0x1752504 Offset: 0x174E504 VA: 0x1752504 Slot: 39
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x175250C Offset: 0x174E50C VA: 0x175250C Slot: 40
	public virtual Decoder GetDecoder() { }

	// RVA: 0x17525B8 Offset: 0x174E5B8 VA: 0x17525B8
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x17527F0 Offset: 0x174E7F0 VA: 0x17527F0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x17504DC Offset: 0x174C4DC VA: 0x17504DC
	public static Encoding get_Default() { }

	// RVA: 0x17527F8 Offset: 0x174E7F8 VA: 0x17527F8 Slot: 41
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 42
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x17528A4 Offset: 0x174E8A4 VA: 0x17528A4 Slot: 44
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x175292C Offset: 0x174E92C VA: 0x175292C Slot: 45
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1750568 Offset: 0x174C568 VA: 0x1750568
	public static Encoding get_Unicode() { }

	// RVA: 0x1750614 Offset: 0x174C614 VA: 0x1750614
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x17506C0 Offset: 0x174C6C0 VA: 0x17506C0
	public static Encoding get_UTF7() { }

	// RVA: 0x174F2BC Offset: 0x174B2BC VA: 0x174F2BC
	public static Encoding get_UTF8() { }

	// RVA: 0x1750764 Offset: 0x174C764 VA: 0x1750764
	public static Encoding get_UTF32() { }

	// RVA: 0x1752954 Offset: 0x174E954 VA: 0x1752954 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1752A1C Offset: 0x174EA1C VA: 0x1752A1C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1752A74 Offset: 0x174EA74 VA: 0x1752A74 Slot: 46
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1752ACC Offset: 0x174EACC VA: 0x1752ACC Slot: 47
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x1752B24 Offset: 0x174EB24 VA: 0x1752B24
	internal void ThrowBytesOverflow() { }

	// RVA: 0x1752C20 Offset: 0x174EC20 VA: 0x1752C20
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x1752C8C Offset: 0x174EC8C VA: 0x1752C8C
	internal void ThrowCharsOverflow() { }

	// RVA: 0x1752D88 Offset: 0x174ED88 VA: 0x1752D88
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

	// RVA: 0x1752DF4 Offset: 0x174EDF4 VA: 0x1752DF4 Slot: 48
	public virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes) { }
}

// Namespace: System.Text
internal enum NormalizationCheck // TypeDefIndex: 669
{
	// Fields
	public int value__; // 0x0
	public const NormalizationCheck Yes = 0;
	public const NormalizationCheck No = 1;
	public const NormalizationCheck Maybe = 2;
}

// Namespace: System.Text
internal class Normalization // TypeDefIndex: 670
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x1753FB0 Offset: 0x174FFB0 VA: 0x1753FB0
	private static uint PropValue(int cp) { }

	// RVA: 0x1754044 Offset: 0x1750044 VA: 0x1754044
	private static int CharMapIdx(int cp) { }

	// RVA: 0x17540D8 Offset: 0x17500D8 VA: 0x17540D8
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x1754180 Offset: 0x1750180 VA: 0x1754180
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x1754228 Offset: 0x1750228 VA: 0x1754228
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x17542D0 Offset: 0x17502D0 VA: 0x17542D0
	private static string Compose(string source, int checkType) { }

	// RVA: 0x17544E4 Offset: 0x17504E4 VA: 0x17544E4
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x1754620 Offset: 0x1750620 VA: 0x1754620
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x175485C Offset: 0x175085C VA: 0x175485C
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x1754C58 Offset: 0x1750C58 VA: 0x1754C58
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x1754A24 Offset: 0x1750A24 VA: 0x1754A24
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x1754C94 Offset: 0x1750C94 VA: 0x1754C94
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x1754DAC Offset: 0x1750DAC VA: 0x1754DAC
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x17543B0 Offset: 0x17503B0 VA: 0x17543B0
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x1755030 Offset: 0x1751030 VA: 0x1755030
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x1754E38 Offset: 0x1750E38 VA: 0x1754E38
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x1754730 Offset: 0x1750730 VA: 0x1754730
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x1755464 Offset: 0x1751464 VA: 0x1755464
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x17552AC Offset: 0x17512AC VA: 0x17552AC
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x1755548 Offset: 0x1751548 VA: 0x1755548
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x17555EC Offset: 0x17515EC VA: 0x17555EC
	public static string Normalize(string source, int type) { }

	// RVA: 0x1755678 Offset: 0x1751678 VA: 0x1755678
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x175567C Offset: 0x175167C VA: 0x175567C
	private static void .cctor() { }
}

// Namespace: System.Text
internal static class EncodingHelper // TypeDefIndex: 671
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x1755894 Offset: 0x1751894 VA: 0x1755894
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1755A8C Offset: 0x1751A8C VA: 0x1755A8C
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1752618 Offset: 0x174E618 VA: 0x1752618
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1750958 Offset: 0x174C958 VA: 0x1750958
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1755A90 Offset: 0x1751A90 VA: 0x1755A90
	private static void .cctor() { }
}

// Namespace: System.Text
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 7837
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x1B38E10 Offset: 0x1B34E10 VA: 0x1B38E10
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x1B3E5AC Offset: 0x1B3A5AC VA: 0x1B3E5AC
	public int get_Length() { }

	// RVA: 0x1B390E0 Offset: 0x1B350E0 VA: 0x1B390E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B38FF0 Offset: 0x1B34FF0 VA: 0x1B38FF0
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x1B38E20 Offset: 0x1B34E20 VA: 0x1B38E20
	public void Insert(int index, char value, int count) { }

	// RVA: 0x1B3E818 Offset: 0x1B3A818 VA: 0x1B3E818
	public void Append(char c) { }

	// RVA: 0x1B3E914 Offset: 0x1B3A914 VA: 0x1B3E914
	public void Append(string s) { }

	// RVA: 0x1B3E9C0 Offset: 0x1B3A9C0 VA: 0x1B3E9C0
	private void AppendSlow(string s) { }

	// RVA: 0x1B3D5D8 Offset: 0x1B395D8 VA: 0x1B3D5D8
	public void Append(char c, int count) { }

	// RVA: 0x1B3D4F4 Offset: 0x1B394F4 VA: 0x1B3D4F4
	public void Append(char* value, int length) { }

	// RVA: 0x1B3EAF4 Offset: 0x1B3AAF4 VA: 0x1B3EAF4
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x1B3E894 Offset: 0x1B3A894 VA: 0x1B3E894
	private void GrowAndAppend(char c) { }

	// RVA: 0x1B3E5B4 Offset: 0x1B3A5B4 VA: 0x1B3E5B4
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x1B3EBB4 Offset: 0x1B3ABB4 VA: 0x1B3EBB4
	public void Dispose() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7838
{}

// Namespace: 
internal static class SR // TypeDefIndex: 7839
{
	// Methods

	// RVA: 0x1B4F4B0 Offset: 0x1B4B4B0 VA: 0x1B4F4B0
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1B4F520 Offset: 0x1B4B520 VA: 0x1B4F520
	internal static string Format(string resourceFormat, object p1, object p2) { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 7874
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x1B540E4 Offset: 0x1B500E4 VA: 0x1B540E4
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x1B57FE8 Offset: 0x1B53FE8 VA: 0x1B57FE8
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1B541AC Offset: 0x1B501AC VA: 0x1B541AC
	public static string GetStringAndRelease(StringBuilder sb) { }
}
