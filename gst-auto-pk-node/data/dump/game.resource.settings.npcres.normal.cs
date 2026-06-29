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

// Namespace: game.resource.settings.npcres.normal
public class Animate // TypeDefIndex: 2287
{
	// Fields
	public static readonly Dictionary<string, Structures.PartAnimation> Empty; // 0x0
	private readonly Identification identification; // 0x10
	public readonly Dictionary<string, Structures.PartAnimation> partAnimations; // 0x18
	private int declareLine; // 0x20
	private string npcResType; // 0x28
	private string actionName; // 0x30
	public int direction; // 0x38

	// Methods

	// RVA: 0xFC6724 Offset: 0xFC2724 VA: 0xFC6724
	public void .ctor(Identification identification) { }

	// RVA: 0xFC6844 Offset: 0xFC2844 VA: 0xFC6844
	public void .ctor(Identification identification, int npcDeclareLine) { }

	// RVA: 0xFC695C Offset: 0xFC295C VA: 0xFC695C
	public Dictionary<string, Structures.PartAnimation> ResetAllPartAnimation() { }

	// RVA: 0xFC6CBC Offset: 0xFC2CBC VA: 0xFC6CBC
	public string GetResType() { }

	// RVA: 0xFC6CC4 Offset: 0xFC2CC4 VA: 0xFC6CC4
	public Dictionary<string, Structures.PartAnimation> SetNpcResType(string _npcResType) { }

	// RVA: 0xFC6D5C Offset: 0xFC2D5C VA: 0xFC6D5C
	public Dictionary<string, Structures.PartAnimation> SetNpcDeclareLine(int _declareLine) { }

	// RVA: 0xFC6E14 Offset: 0xFC2E14 VA: 0xFC6E14
	public Dictionary<string, Structures.PartAnimation> SetAction(string _actionName) { }

	// RVA: 0xFC6EAC Offset: 0xFC2EAC VA: 0xFC6EAC
	public string GetAction() { }

	// RVA: 0xFC6EB4 Offset: 0xFC2EB4 VA: 0xFC6EB4
	public Dictionary<string, Structures.PartAnimation> SetDirection(int _direction) { }

	// RVA: 0xFC6F34 Offset: 0xFC2F34 VA: 0xFC6F34
	private static void .cctor() { }
}

// Namespace: game.resource.settings.npcres.normal
internal class Getters // TypeDefIndex: 2288
{
	// Methods

	// RVA: 0xFC69C4 Offset: 0xFC29C4 VA: 0xFC69C4
	public static void FullPartAnimation(Dictionary<string, Structures.PartAnimation> result, string _npcName, string _actionName, int _direction) { }

	// RVA: 0xFC6FCC Offset: 0xFC2FCC VA: 0xFC6FCC
	public void .ctor() { }
}
