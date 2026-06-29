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

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException : SystemException // TypeDefIndex: 3901
{
	// Methods

	// RVA: 0x1D15EE8 Offset: 0x1D11EE8 VA: 0x1D15EE8
	public void .ctor() { }

	// RVA: 0x1D15F40 Offset: 0x1D11F40 VA: 0x1D15F40
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D15F48 Offset: 0x1D11F48 VA: 0x1D15F48
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Security.Authentication
[Flags]
public enum SslProtocols // TypeDefIndex: 3902
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls11 = 768;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Tls13 = 12288;
	public const SslProtocols Default = 240;
}

// Namespace: 
internal enum DerSequenceReader.DerTag // TypeDefIndex: 3903
{
	// Fields
	public byte value__; // 0x0
	public const DerSequenceReader.DerTag Boolean = 1;
	public const DerSequenceReader.DerTag Integer = 2;
	public const DerSequenceReader.DerTag BitString = 3;
	public const DerSequenceReader.DerTag OctetString = 4;
	public const DerSequenceReader.DerTag Null = 5;
	public const DerSequenceReader.DerTag ObjectIdentifier = 6;
	public const DerSequenceReader.DerTag UTF8String = 12;
	public const DerSequenceReader.DerTag Sequence = 16;
	public const DerSequenceReader.DerTag Set = 17;
	public const DerSequenceReader.DerTag PrintableString = 19;
	public const DerSequenceReader.DerTag T61String = 20;
	public const DerSequenceReader.DerTag IA5String = 22;
	public const DerSequenceReader.DerTag UTCTime = 23;
	public const DerSequenceReader.DerTag GeneralizedTime = 24;
	public const DerSequenceReader.DerTag BMPString = 30;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DerSequenceReader.<>c // TypeDefIndex: 3904
{
	// Fields
	public static readonly DerSequenceReader.<>c <>9; // 0x0
	public static Func<Encoding> <>9__45_0; // 0x8
	public static Func<Encoding> <>9__45_1; // 0x10
	public static Func<DateTimeFormatInfo> <>9__51_0; // 0x18

	// Methods

	// RVA: 0x1D17490 Offset: 0x1D13490 VA: 0x1D17490
	private static void .cctor() { }

	// RVA: 0x1D174F8 Offset: 0x1D134F8 VA: 0x1D174F8
	public void .ctor() { }

	// RVA: 0x1D17500 Offset: 0x1D13500 VA: 0x1D17500
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x1D1755C Offset: 0x1D1355C VA: 0x1D1755C
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x1D175A0 Offset: 0x1D135A0 VA: 0x1D175A0
	internal DateTimeFormatInfo <ReadTime>b__51_0() { }
}
