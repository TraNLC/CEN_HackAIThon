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

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal // TypeDefIndex: 4322
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Properties
	internal static object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0x1CD9AC0 Offset: 0x1CD5AC0 VA: 0x1CD9AC0
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x1CD9AC8 Offset: 0x1CD5AC8 VA: 0x1CD9AC8
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x1CD9AD0 Offset: 0x1CD5AD0 VA: 0x1CD9AD0
	internal static object get_ClassSyncObject() { }

	// RVA: 0x1CD9B68 Offset: 0x1CD5B68 VA: 0x1CD9B68
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x1CD9C94 Offset: 0x1CD5C94 VA: 0x1CD9C94
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x1CD9C8C Offset: 0x1CD5C8C VA: 0x1CD9C8C
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal // TypeDefIndex: 4323
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Properties
	internal static SettingsSectionInternal Section { get; }
	internal bool Ipv6Enabled { get; }

	// Methods

	// RVA: 0x1CD9C9C Offset: 0x1CD5C9C VA: 0x1CD9C9C
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x1CD9CF4 Offset: 0x1CD5CF4 VA: 0x1CD9CF4
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x1CD9CFC Offset: 0x1CD5CFC VA: 0x1CD9CFC
	public void .ctor() { }

	// RVA: 0x1CD9D14 Offset: 0x1CD5D14 VA: 0x1CD9D14
	private static void .cctor() { }
}

// Namespace: System.Net.Configuration
public sealed class BypassElement : ConfigurationElement // TypeDefIndex: 4389
{}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(BypassElement))]
public sealed class BypassElementCollection : ConfigurationElementCollection // TypeDefIndex: 4390
{
	// Methods

	// RVA: 0x1CF01B0 Offset: 0x1CEC1B0 VA: 0x1CF01B0
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement : ConfigurationElement // TypeDefIndex: 4391
{}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(ConnectionManagementElement))]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 4392
{
	// Methods

	// RVA: 0x1CF01E8 Offset: 0x1CEC1E8 VA: 0x1CF01E8
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 4393
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0220 Offset: 0x1CEC220 VA: 0x1CF0220
	public void .ctor() { }

	// RVA: 0x1CF0258 Offset: 0x1CEC258 VA: 0x1CF0258 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection : ConfigurationSection // TypeDefIndex: 4394
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0290 Offset: 0x1CEC290 VA: 0x1CF0290
	public void .ctor() { }

	// RVA: 0x1CF02C8 Offset: 0x1CEC2C8 VA: 0x1CF02C8 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1CF0300 Offset: 0x1CEC300 VA: 0x1CF0300 Slot: 6
	protected override void Reset(ConfigurationElement parentElement) { }
}

// Namespace: System.Net.Configuration
public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 4395
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0338 Offset: 0x1CEC338 VA: 0x1CF0338
	public void .ctor() { }

	// RVA: 0x1CF0370 Offset: 0x1CEC370 VA: 0x1CF0370 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement : ConfigurationElement // TypeDefIndex: 4396
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF03A8 Offset: 0x1CEC3A8 VA: 0x1CF03A8
	public void .ctor() { }

	// RVA: 0x1CF03E0 Offset: 0x1CEC3E0 VA: 0x1CF03E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element : ConfigurationElement // TypeDefIndex: 4397
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0418 Offset: 0x1CEC418 VA: 0x1CF0418
	public void .ctor() { }

	// RVA: 0x1CF0450 Offset: 0x1CEC450 VA: 0x1CF0450 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 4398
{
	// Methods

	// RVA: 0x1CF0488 Offset: 0x1CEC488 VA: 0x1CF0488
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class SettingsSection : ConfigurationSection // TypeDefIndex: 4399
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF04C0 Offset: 0x1CEC4C0 VA: 0x1CF04C0
	public void .ctor() { }

	// RVA: 0x1CF04F8 Offset: 0x1CEC4F8 VA: 0x1CF04F8 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement : ConfigurationElement // TypeDefIndex: 4400
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0530 Offset: 0x1CEC530 VA: 0x1CF0530
	public void .ctor() { }

	// RVA: 0x1CF0568 Offset: 0x1CEC568 VA: 0x1CF0568 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement : ConfigurationElement // TypeDefIndex: 4401
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF05A0 Offset: 0x1CEC5A0 VA: 0x1CF05A0
	public void .ctor() { }

	// RVA: 0x1CF05D8 Offset: 0x1CEC5D8 VA: 0x1CF05D8 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 4402
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0610 Offset: 0x1CEC610 VA: 0x1CF0610
	public void .ctor() { }

	// RVA: 0x1CF0648 Offset: 0x1CEC648 VA: 0x1CF0648 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement : ConfigurationElement // TypeDefIndex: 4403
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF0680 Offset: 0x1CEC680 VA: 0x1CF0680
	public void .ctor() { }

	// RVA: 0x1CF06B8 Offset: 0x1CEC6B8 VA: 0x1CF06B8 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection : ConfigurationSection // TypeDefIndex: 4404
{
	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1CF06F0 Offset: 0x1CEC6F0 VA: 0x1CF06F0
	public void .ctor() { }

	// RVA: 0x1CF0728 Offset: 0x1CEC728 VA: 0x1CF0728 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }
}

// Namespace: System.Net.Configuration
[DefaultMember("Item")]
[ConfigurationCollection(typeof(WebRequestModuleElement))]
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection // TypeDefIndex: 4405
{
	// Methods

	// RVA: 0x1CF0760 Offset: 0x1CEC760 VA: 0x1CF0760
	public void .ctor() { }
}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement : ConfigurationElement // TypeDefIndex: 4406
{}
