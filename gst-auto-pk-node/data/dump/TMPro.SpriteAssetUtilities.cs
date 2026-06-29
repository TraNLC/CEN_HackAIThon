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

// Namespace: TMPro.SpriteAssetUtilities
public enum SpriteAssetImportFormats // TypeDefIndex: 5321
{
	// Fields
	public int value__; // 0x0
	public const SpriteAssetImportFormats None = 0;
	public const SpriteAssetImportFormats TexturePackerJsonArray = 1;
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteFrame // TypeDefIndex: 5322
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float w; // 0x8
	public float h; // 0xC

	// Methods

	// RVA: 0x1E2F870 Offset: 0x1E2B870 VA: 0x1E2F870 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteSize // TypeDefIndex: 5323
{
	// Fields
	public float w; // 0x0
	public float h; // 0x4

	// Methods

	// RVA: 0x1E2FA78 Offset: 0x1E2BA78 VA: 0x1E2FA78 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Frame // TypeDefIndex: 5324
{
	// Fields
	public string filename; // 0x0
	public TexturePacker_JsonArray.SpriteFrame frame; // 0x8
	public bool rotated; // 0x18
	public bool trimmed; // 0x19
	public TexturePacker_JsonArray.SpriteFrame spriteSourceSize; // 0x1C
	public TexturePacker_JsonArray.SpriteSize sourceSize; // 0x2C
	public Vector2 pivot; // 0x34
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Meta // TypeDefIndex: 5325
{
	// Fields
	public string app; // 0x0
	public string version; // 0x8
	public string image; // 0x10
	public string format; // 0x18
	public TexturePacker_JsonArray.SpriteSize size; // 0x20
	public float scale; // 0x28
	public string smartupdate; // 0x30
}

// Namespace: 
[Serializable]
public class TexturePacker_JsonArray.SpriteDataObject // TypeDefIndex: 5326
{
	// Fields
	public List<TexturePacker_JsonArray.Frame> frames; // 0x10
	public TexturePacker_JsonArray.Meta meta; // 0x18

	// Methods

	// RVA: 0x1E2FB24 Offset: 0x1E2BB24 VA: 0x1E2FB24
	public void .ctor() { }
}

// Namespace: TMPro.SpriteAssetUtilities
public class TexturePacker_JsonArray // TypeDefIndex: 5327
{
	// Methods

	// RVA: 0x1E2F868 Offset: 0x1E2B868 VA: 0x1E2F868
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 5328
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4040 // TypeDefIndex: 5329
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5222 // TypeDefIndex: 5330
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5331
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB /*Metadata offset 0x3E6FB8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4040 CE288FEE87FD0C469553BE04A1827FA38389051875CAC152A072634634D7D780 /*Metadata offset 0x3E6FC8*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5222 E1734A16B5D1C69DF8C477145C5E31D7AC886316E58E79EE57A4F140437D837B /*Metadata offset 0x3E7F98*/; // 0xFD4
}

// Namespace: 
internal class <Module> // TypeDefIndex: 5332
{}

// Namespace: 
internal static class SR // TypeDefIndex: 5333
{
	// Methods

	// RVA: 0x199F2B8 Offset: 0x199B2B8 VA: 0x199F2B8
	internal static string GetString(string name) { }

	// RVA: 0x199F2BC Offset: 0x199B2BC VA: 0x199F2BC
	internal static string Format(string resourceFormat, object[] args) { }

	// RVA: 0x199F338 Offset: 0x199B338 VA: 0x199F338
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x199F3A8 Offset: 0x199B3A8 VA: 0x199F3A8
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x199F420 Offset: 0x199B420 VA: 0x199F420
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }
}
