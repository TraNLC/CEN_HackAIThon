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

// Namespace: System.Configuration
public interface IConfigurationSectionHandler // TypeDefIndex: 4388
{}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 8135
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x199EF34 Offset: 0x199AF34 VA: 0x199EF34 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x199EF6C Offset: 0x199AF6C VA: 0x199EF6C Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x199EFA4 Offset: 0x199AFA4 VA: 0x199EFA4 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x199EFDC Offset: 0x199AFDC VA: 0x199EFDC Slot: 7
	protected internal virtual void ResetModified() { }
}

// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 8136
{
	// Methods

	// RVA: 0x199F014 Offset: 0x199B014 VA: 0x199F014 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x199F04C Offset: 0x199B04C VA: 0x199F04C Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x199F084 Offset: 0x199B084 VA: 0x199F084 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x199F0BC Offset: 0x199B0BC VA: 0x199F0BC Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public enum ConfigurationSaveMode // TypeDefIndex: 8137
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class ConfigurationPropertyCollection // TypeDefIndex: 8138
{}

// Namespace: System.Configuration
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 8139
{}

// Namespace: System.Configuration
[Usage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 8140
{
	// Methods

	// RVA: 0x199F0F4 Offset: 0x199B0F4 VA: 0x199F0F4
	public void .ctor(Type itemType) { }
}

// Namespace: System.Configuration
public class ConfigurationSectionGroup // TypeDefIndex: 8141
{}

// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 8142
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x199F0F8 Offset: 0x199B0F8 VA: 0x199F0F8
	public void .ctor() { }

	// RVA: 0x199F130 Offset: 0x199B130 VA: 0x199F130 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x199F168 Offset: 0x199B168 VA: 0x199F168 Slot: 8
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x199F1A0 Offset: 0x199B1A0 VA: 0x199F1A0 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x199F1D8 Offset: 0x199B1D8 VA: 0x199F1D8 Slot: 6
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x199F210 Offset: 0x199B210 VA: 0x199F210 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x199F248 Offset: 0x199B248 VA: 0x199F248 Slot: 9
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}
