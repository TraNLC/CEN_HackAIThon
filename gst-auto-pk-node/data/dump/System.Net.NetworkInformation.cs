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

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties // TypeDefIndex: 4313
{
	// Properties
	public abstract string DomainName { get; }

	// Methods

	// RVA: 0x1CD9480 Offset: 0x1CD5480 VA: 0x1CD9480
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x1CD94CC Offset: 0x1CD54CC VA: 0x1CD94CC
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_DomainName();

	// RVA: 0x1CD94D0 Offset: 0x1CD54D0 VA: 0x1CD94D0
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException : Win32Exception // TypeDefIndex: 4314
{
	// Methods

	// RVA: 0x1CD94D8 Offset: 0x1CD54D8 VA: 0x1CD94D8
	public void .ctor() { }

	// RVA: 0x1CD953C Offset: 0x1CD553C VA: 0x1CD953C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent // TypeDefIndex: 4315
{
	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;
}

// Namespace: System.Net.NetworkInformation
internal static class IPGlobalPropertiesFactoryPal // TypeDefIndex: 4316
{
	// Methods

	// RVA: 0x1CD9484 Offset: 0x1CD5484 VA: 0x1CD9484
	public static IPGlobalProperties Create() { }
}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 4317
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x1CD95E4 Offset: 0x1CD55E4 VA: 0x1CD95E4
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x1CD9670 Offset: 0x1CD5670 VA: 0x1CD9670 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x1CD97FC Offset: 0x1CD57FC VA: 0x1CD97FC
	protected void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties : CommonUnixIPGlobalProperties // TypeDefIndex: 4318
{
	// Methods

	// RVA: 0x1CD9804 Offset: 0x1CD5804 VA: 0x1CD9804
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties : UnixIPGlobalProperties // TypeDefIndex: 4319
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x1CD980C Offset: 0x1CD580C VA: 0x1CD980C Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x1CD9824 Offset: 0x1CD5824 VA: 0x1CD9824
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class MibIPGlobalProperties : UnixIPGlobalProperties // TypeDefIndex: 4320
{
	// Fields
	public readonly string StatisticsFile; // 0x10
	public readonly string StatisticsFileIPv6; // 0x18
	public readonly string TcpFile; // 0x20
	public readonly string Tcp6File; // 0x28
	public readonly string UdpFile; // 0x30
	public readonly string Udp6File; // 0x38
	private static readonly char[] wsChars; // 0x0

	// Methods

	// RVA: 0x1CD982C Offset: 0x1CD582C VA: 0x1CD982C
	public void .ctor(string procDir) { }

	// RVA: 0x1CD99D8 Offset: 0x1CD59D8 VA: 0x1CD99D8
	private static void .cctor() { }
}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal // TypeDefIndex: 4321
{
	// Fields
	[CompilerGenerated]
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Properties
	private static bool PlatformNeedsLibCWorkaround { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CD9A78 Offset: 0x1CD5A78 VA: 0x1CD9A78
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x1CD9544 Offset: 0x1CD5544 VA: 0x1CD9544
	public static IPGlobalProperties Create() { }
}
