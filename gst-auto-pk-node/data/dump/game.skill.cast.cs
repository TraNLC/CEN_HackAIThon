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

// Namespace: game.skill.cast
[NullableContext(1)]
[Nullable(0)]
public class Circle : Spread // TypeDefIndex: 2132
{
	// Methods

	// RVA: 0xF994D0 Offset: 0xF954D0 VA: 0xF994D0
	public List<Missile> MissileForm_Circle(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF995CC Offset: 0xF955CC VA: 0xF995CC
	public List<Missile> CastCircle(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF998F0 Offset: 0xF958F0 VA: 0xF998F0
	public void .ctor() { }
}

// Namespace: game.skill.cast
public class Firer : Target // TypeDefIndex: 2133
{
	// Methods

	[NullableContext(1)]
	// RVA: 0xF9953C Offset: 0xF9553C VA: 0xF9953C
	public List<Missile> MissileForm_AtFirer(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF995C8 Offset: 0xF955C8 VA: 0xF995C8
	public void .ctor() { }
}

// Namespace: game.skill.cast
[NullableContext(1)]
[Nullable(0)]
public class Line : Wall // TypeDefIndex: 2134
{
	// Methods

	// RVA: 0xF99434 Offset: 0xF95434 VA: 0xF99434
	public List<Missile> MissileForm_Line(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF99C7C Offset: 0xF95C7C VA: 0xF99C7C
	public List<Missile> CastExtractiveLineMissle(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF99F80 Offset: 0xF95F80 VA: 0xF99F80
	public List<Missile> CastLine(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF9A294 Offset: 0xF96294 VA: 0xF9A294
	public void .ctor() { }
}

// Namespace: game.skill.cast
public class Spread : Line // TypeDefIndex: 2135
{
	// Methods

	// RVA: 0xF99484 Offset: 0xF95484 VA: 0xF99484
	public List<Missile> MissileForm_Spread(Params.Cast castParams) { }

	// RVA: 0xF9A29C Offset: 0xF9629C VA: 0xF9A29C
	public List<Missile> CastSpread(Params.Cast castParams) { }

	// RVA: 0xF998F4 Offset: 0xF958F4 VA: 0xF998F4
	public void .ctor() { }
}

// Namespace: game.skill.cast
public class Target : Zone // TypeDefIndex: 2136
{
	// Methods

	// RVA: 0xF994D4 Offset: 0xF954D4 VA: 0xF994D4
	public List<Missile> MissileForm_AtTarget(Params.Cast castParams) { }

	// RVA: 0xF99C78 Offset: 0xF95C78 VA: 0xF99C78
	public void .ctor() { }
}

// Namespace: game.skill.cast
[NullableContext(1)]
[Nullable(0)]
public class Wall : SkillData // TypeDefIndex: 2137
{
	// Methods

	// RVA: 0xF99430 Offset: 0xF95430 VA: 0xF99430
	public List<Missile> MissileForm_Wall(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF9A5A0 Offset: 0xF965A0 VA: 0xF9A5A0
	public List<Missile> CastWall(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF9A298 Offset: 0xF96298 VA: 0xF9A298
	public void .ctor() { }
}

// Namespace: game.skill.cast
public class Zone : Circle // TypeDefIndex: 2138
{
	// Methods

	// RVA: 0xF99588 Offset: 0xF95588 VA: 0xF99588
	public List<Missile> MissileForm_Zone(Params.Cast castParams) { }

	// RVA: 0xF998F8 Offset: 0xF958F8 VA: 0xF998F8
	public List<Missile> CastZone(Params.Cast castParams, Position des) { }

	// RVA: 0xF9A59C Offset: 0xF9659C VA: 0xF9A59C
	public void .ctor() { }
}
