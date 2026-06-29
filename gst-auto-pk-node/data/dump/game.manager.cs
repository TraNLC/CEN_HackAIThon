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

// Namespace: game.manager
public class Target // TypeDefIndex: 2993
{
	// Fields
	public Controller controller; // 0x10
	public readonly Position positionBySkillDirection; // 0x18
	public PlayerMain main; // 0x20
	public Map missile; // 0x28
	public long timestamp; // 0x30
	private bool manualExisting; // 0x38
	private readonly List<KeyValuePair<double, Controller>> enemyDistance; // 0x40
	private string skillDirectionTargetSemiAutoSelected; // 0x48
	private readonly Dictionary<Controller, bool> skillDirectionControllerExistingMapping; // 0x50

	// Methods

	// RVA: 0xF200CC Offset: 0xF1C0CC VA: 0xF200CC
	public bool Compare(Controller other) { }

	// RVA: 0xF20110 Offset: 0xF1C110 VA: 0xF20110
	public string GetCid() { }

	// RVA: 0xF20124 Offset: 0xF1C124 VA: 0xF20124
	public void UnSelectId(string id) { }

	// RVA: 0xF20280 Offset: 0xF1C280 VA: 0xF20280
	public void Clear() { }

	// RVA: 0xF20290 Offset: 0xF1C290 VA: 0xF20290
	public void SystemPickNpc(string npcid, Target.Color color) { }

	// RVA: 0xF20344 Offset: 0xF1C344 VA: 0xF20344
	public void ManualPick(Controller controller) { }

	// RVA: 0xF2054C Offset: 0xF1C54C VA: 0xF2054C
	private void FindSelfPosition(int skillRadius) { }

	// RVA: 0xF20654 Offset: 0xF1C654 VA: 0xF20654
	private void FindEnemy(int skillRadius, int skillRelation) { }

	// RVA: 0xF210F0 Offset: 0xF1D0F0 VA: 0xF210F0
	private void ByDirectionLiner(RightHotkey.Skill.Direction.Properties properties, int skillRadius, int skillRelation) { }

	// RVA: 0xF21AE4 Offset: 0xF1DAE4 VA: 0xF21AE4
	private void ByDirectionPosition(RightHotkey.Skill.Direction.Properties properties, int skillRadius, int skillRelation) { }

	// RVA: 0xF22570 Offset: 0xF1E570 VA: 0xF22570
	private void ByDirectionMoving(RightHotkey.Skill.Direction.Properties properties, int skillRadius, int skillRelation) { }

	// RVA: 0xF23168 Offset: 0xF1F168 VA: 0xF23168
	public void ByDirectionProperties(RightHotkey.Skill.Direction.Properties properties, int skillRadius, int skillRelation) { }

	// RVA: 0xF2063C Offset: 0xF1C63C VA: 0xF2063C
	public void SetPosition(int top, int left) { }

	// RVA: 0xF2017C Offset: 0xF1C17C VA: 0xF2017C
	public void SetTarget(Controller controller, Target.Color color) { }

	// RVA: 0xF231A0 Offset: 0xF1F1A0 VA: 0xF231A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CharManager.<>c__DisplayClass14_0 // TypeDefIndex: 2994
{
	// Fields
	public NpcRes.Special newPlayer; // 0x10
	public Character character; // 0x18
	public CharManager <>4__this; // 0x20

	// Methods

	// RVA: 0xF2433C Offset: 0xF2033C VA: 0xF2433C
	public void .ctor() { }

	// RVA: 0xF284DC Offset: 0xF244DC VA: 0xF284DC
	internal void <PlayerSalesmanAdd>b__0() { }

	// RVA: 0xF28504 Offset: 0xF24504 VA: 0xF28504
	internal void <PlayerSalesmanAdd>b__1() { }

	// RVA: 0xF2852C Offset: 0xF2452C VA: 0xF2852C
	internal void <PlayerSalesmanAdd>b__2() { }

	// RVA: 0xF28548 Offset: 0xF24548 VA: 0xF28548
	internal void <PlayerSalesmanAdd>b__3() { }

	// RVA: 0xF28570 Offset: 0xF24570 VA: 0xF28570
	internal void <PlayerSalesmanAdd>b__4() { }

	// RVA: 0xF285F0 Offset: 0xF245F0 VA: 0xF285F0
	internal void <PlayerSalesmanAdd>b__5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CharManager.<>c__DisplayClass19_0 // TypeDefIndex: 2995
{
	// Fields
	public NpcRes.Special npcontroller; // 0x10

	// Methods

	// RVA: 0xF2498C Offset: 0xF2098C VA: 0xF2498C
	public void .ctor() { }

	// RVA: 0xF286C4 Offset: 0xF246C4 VA: 0xF286C4
	internal void <PlayerMoveStop>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CharManager.<>c__DisplayClass40_0 // TypeDefIndex: 2996
{
	// Fields
	public NpcRes.Special newPlayer; // 0x10
	public CharManager <>4__this; // 0x18

	// Methods

	// RVA: 0xF267F0 Offset: 0xF227F0 VA: 0xF267F0
	public void .ctor() { }

	// RVA: 0xF28774 Offset: 0xF24774 VA: 0xF28774
	internal void <AddMapPlayer>b__0() { }

	// RVA: 0xF287F4 Offset: 0xF247F4 VA: 0xF287F4
	internal void <AddMapPlayer>b__1() { }

	// RVA: 0xF288C8 Offset: 0xF248C8 VA: 0xF288C8
	internal void <AddMapPlayer>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CharManager.<>c__DisplayClass43_0 // TypeDefIndex: 2997
{
	// Fields
	public KeyValuePair<string, NpcRes.Special> entry; // 0x10

	// Methods

	// RVA: 0xF26B68 Offset: 0xF22B68 VA: 0xF26B68
	public void .ctor() { }

	// RVA: 0xF288EC Offset: 0xF248EC VA: 0xF288EC
	internal void <CheckAllPlayerRelation>b__0() { }

	// RVA: 0xF2893C Offset: 0xF2493C VA: 0xF2893C
	internal void <CheckAllPlayerRelation>b__1() { }

	// RVA: 0xF2898C Offset: 0xF2498C VA: 0xF2898C
	internal void <CheckAllPlayerRelation>b__2() { }
}
