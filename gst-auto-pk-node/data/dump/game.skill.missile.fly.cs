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

// Namespace: game.skill.missile.fly
public class Circle : Helix // TypeDefIndex: 2150
{
	// Fields
	private int angle; // 0xA4

	// Methods

	// RVA: 0xF9F140 Offset: 0xF9B140 VA: 0xF9F140
	public void FlyMoveCircle() { }

	// RVA: 0xF9F9A4 Offset: 0xF9B9A4 VA: 0xF9F9A4
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class Follow : SingleLine // TypeDefIndex: 2151
{
	// Fields
	private int localLifetime; // 0x98
	private int localDirectionLifeCurrently; // 0x9C

	// Methods

	// RVA: 0xF9F9B4 Offset: 0xF9B9B4 VA: 0xF9F9B4
	private void FlyStraightLine(float speedDownRatio) { }

	// RVA: 0xF9F548 Offset: 0xF9B548 VA: 0xF9F548
	public void FlyMoveFollow() { }

	// RVA: 0xF9FA30 Offset: 0xF9BA30 VA: 0xF9FA30
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class Helix : Follow // TypeDefIndex: 2152
{
	// Fields
	private int angle; // 0xA0

	// Methods

	// RVA: 0xF9F2EC Offset: 0xF9B2EC VA: 0xF9F2EC
	public void FlyMoveHelix() { }

	// RVA: 0xF9F9AC Offset: 0xF9B9AC VA: 0xF9F9AC
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class Line : RollBack // TypeDefIndex: 2153
{
	// Fields
	private int m_nTempParam1; // 0xB4

	// Methods

	// RVA: 0xF9EE30 Offset: 0xF9AE30 VA: 0xF9EE30
	public void FlyMoveLine() { }

	// RVA: 0xF9FA40 Offset: 0xF9BA40 VA: 0xF9FA40
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class RollBack : Circle // TypeDefIndex: 2154
{
	// Fields
	private bool localIsRollbacking; // 0xA8
	private Nullable<int> localRollbackTriggerTime; // 0xAC

	// Methods

	// RVA: 0xF9F014 Offset: 0xF9B014 VA: 0xF9F014
	public void FlyMoveRollback() { }

	// RVA: 0xF9FA48 Offset: 0xF9BA48 VA: 0xF9FA48
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class SingleLine : Vanish // TypeDefIndex: 2155
{
	// Methods

	// RVA: 0xF9F708 Offset: 0xF9B708 VA: 0xF9F708
	public void FlyMoveSingleLine() { }

	// RVA: 0xF9FA38 Offset: 0xF9BA38 VA: 0xF9FA38
	public void .ctor() { }
}

// Namespace: game.skill.missile.fly
public class Stand : Line // TypeDefIndex: 2156
{
	// Methods

	// RVA: 0xF9EE20 Offset: 0xF9AE20 VA: 0xF9EE20
	public void FlyMoveStand() { }

	// RVA: 0xF9F754 Offset: 0xF9B754 VA: 0xF9F754
	public void .ctor() { }
}
