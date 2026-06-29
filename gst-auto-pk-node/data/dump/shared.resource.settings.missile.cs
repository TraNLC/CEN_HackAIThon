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

// Namespace: shared.resource.settings.missile
public class Base : Data // TypeDefIndex: 1910
{
	// Methods

	// RVA: 0xF769CC Offset: 0xF729CC VA: 0xF769CC
	public void LoadBase(int missileId) { }

	// RVA: 0xF77A60 Offset: 0xF73A60 VA: 0xF77A60
	public void .ctor() { }
}

// Namespace: 
public class Data.AnimateFile // TypeDefIndex: 1911
{
	// Fields
	public string animFileName; // 0x10
	public int totalFrame; // 0x18
	public int interval; // 0x1C
	public int dir; // 0x20
	public readonly string sndFileName; // 0x28

	// Methods

	// RVA: 0xF777F0 Offset: 0xF737F0 VA: 0xF777F0
	public void .ctor(string animFileName, string sndFileName, string animFileInfo) { }
}

// Namespace: shared.resource.settings.missile
public class Data // TypeDefIndex: 1912
{
	// Fields
	public int MissleId; // 0x10
	public string MissleName; // 0x18
	public int MoveKind; // 0x20
	public int FollowKind; // 0x24
	public int ColFollowTarget; // 0x28
	public int MissleHeight; // 0x2C
	public int CollidRange; // 0x30
	public int IsRangeDmg; // 0x34
	public int DmgRange; // 0x38
	public int DmgInterval; // 0x3C
	public int LifeTime; // 0x40
	public int Speed; // 0x44
	public int Zspeed; // 0x48
	public int Zacc; // 0x4C
	public int LoopPlay; // 0x50
	public int SubLoop; // 0x54
	public int SubStart; // 0x58
	public int SubStop; // 0x5C
	public int ResponseSkill; // 0x60
	public int CanDestroy; // 0x64
	public int ColVanish; // 0x68
	public int CanSlow; // 0x6C
	public int CanColFriend; // 0x70
	public int AutoExplode; // 0x74
	public int MissRate; // 0x78
	public int Param1; // 0x7C
	public int Param2; // 0x80
	public int Param3; // 0x84
	public int MultiShow; // 0x88
	public string AnimFile1; // 0x90
	public string AnimFileInfo1; // 0x98
	public string SndFile1; // 0xA0
	public string AnimFile2; // 0xA8
	public string AnimFileInfo2; // 0xB0
	public string SndFile2; // 0xB8
	public string AnimFile3; // 0xC0
	public string AnimFileInfo3; // 0xC8
	public string SndFile3; // 0xD0
	public string AnimFile4; // 0xD8
	public string AnimFileInfo4; // 0xE0
	public string SndFile4; // 0xE8
	public string AnimFileB1; // 0xF0
	public string AnimFileInfoB1; // 0xF8
	public string SndFileB1; // 0x100
	public string AnimFileB2; // 0x108
	public string AnimFileInfoB2; // 0x110
	public string SndFileB2; // 0x118
	public string AnimFileB3; // 0x120
	public string AnimFileInfoB3; // 0x128
	public string SndFileB3; // 0x130
	public string AnimFileB4; // 0x138
	public string AnimFileInfoB4; // 0x140
	public string SndFileB4; // 0x148
	public string RedLum; // 0x150
	public string GreenLum; // 0x158
	public string BlueLum; // 0x160
	public string LightRadius; // 0x168
	public Data.AnimateFile[] MissileRes; // 0x170

	// Methods

	// RVA: 0xF77A64 Offset: 0xF73A64 VA: 0xF77A64
	public void .ctor() { }
}

// Namespace: 
public static class Params.Owner.Type // TypeDefIndex: 1913
{
	// Fields
	public const int unidentified = 0;
	public const int player = 1;
	public const int npc = 2;
	public const int position = 3;
}

// Namespace: 
public class Params.Owner // TypeDefIndex: 1914
{
	// Fields
	public Controller npcontroller; // 0x10
	public Position position; // 0x18
	public static readonly Params.Owner Empty; // 0x0

	// Methods

	// RVA: 0xF77D48 Offset: 0xF73D48 VA: 0xF77D48
	public void .ctor() { }

	// RVA: 0xF77D50 Offset: 0xF73D50 VA: 0xF77D50
	public void .ctor(Controller npcontroller) { }

	// RVA: 0xF77D80 Offset: 0xF73D80 VA: 0xF77D80
	public void .ctor(Position position) { }

	// RVA: 0xF77DB0 Offset: 0xF73DB0 VA: 0xF77DB0
	public bool IsPlayerOrNpc() { }

	// RVA: 0xF77DC0 Offset: 0xF73DC0 VA: 0xF77DC0
	public void SetOwner(Controller npcontroller) { }

	// RVA: 0xF77DE4 Offset: 0xF73DE4 VA: 0xF77DE4
	public void SetOwner(Position position) { }

	// RVA: 0xF77E18 Offset: 0xF73E18 VA: 0xF77E18
	public Position GetPosition() { }

	// RVA: 0xF77EA8 Offset: 0xF73EA8 VA: 0xF77EA8
	public int GetOwnerType() { }

	// RVA: 0xF77ED8 Offset: 0xF73ED8 VA: 0xF77ED8
	public string GetIdentifier() { }

	// RVA: 0xF77FA8 Offset: 0xF73FA8 VA: 0xF77FA8
	public bool IsNotEmpty() { }

	// RVA: 0xF77FC8 Offset: 0xF73FC8 VA: 0xF77FC8
	public bool IsEmpty() { }

	// RVA: 0xF77FE8 Offset: 0xF73FE8 VA: 0xF77FE8
	public void SetStateOnce(string sprPath) { }

	// RVA: 0xF78034 Offset: 0xF74034 VA: 0xF78034
	public int CheckRelation(Params.Owner other) { }

	// RVA: 0xF78060 Offset: 0xF74060 VA: 0xF78060
	public void AddStateSkillEffect(Skill skillResource) { }

	// RVA: 0xF78064 Offset: 0xF74064 VA: 0xF78064
	public void AddStateSkillEffectManual(int skillId, int specialStateId, int lifeTime, Dictionary<string, Attrib> attributes) { }

	// RVA: 0xF78068 Offset: 0xF74068 VA: 0xF78068
	public void ActiveTrails(float lifeFrameOn18fps, bool randomFrame = False, float loopCreateTime = 0.04, float lifeTime = 0.5, float colorAlpha = 0.5) { }

	// RVA: 0xF78080 Offset: 0xF74080 VA: 0xF78080
	public void Jump(Position targetPosition, int radius) { }

	// RVA: 0xF78094 Offset: 0xF74094 VA: 0xF78094
	public int GetRunSpeed() { }

	// RVA: 0xF780AC Offset: 0xF740AC VA: 0xF780AC
	public void RunWithTime(Position targetPosition, float maxframe18fps, float speed, Action onFinish) { }

	// RVA: 0xF780C0 Offset: 0xF740C0 VA: 0xF780C0
	public void CastSkill(int skillId, int skillLevel, Params.Cast castParams, bool isNoAction = False) { }

	// RVA: 0xF78144 Offset: 0xF74144 VA: 0xF78144
	public bool IsJumping() { }

	// RVA: 0xF78158 Offset: 0xF74158 VA: 0xF78158
	public bool IsStealthing() { }

	// RVA: 0xF78178 Offset: 0xF74178 VA: 0xF78178
	public void HitTheTarget(Data missileData) { }

	// RVA: 0xF7825C Offset: 0xF7425C VA: 0xF7825C
	public void WasHitMissile(Data missileData) { }

	// RVA: 0xF78340 Offset: 0xF74340 VA: 0xF78340
	public int GetHealthCurrently() { }

	// RVA: 0xF78354 Offset: 0xF74354 VA: 0xF78354
	private static void .cctor() { }
}

// Namespace: 
public class Params.Options // TypeDefIndex: 1915
{
	// Fields
	public Params.Owner castPosition; // 0x10
	public int delayTime; // 0x18

	// Methods

	// RVA: 0xF783BC Offset: 0xF743BC VA: 0xF783BC
	public void .ctor() { }

	// RVA: 0xF783C4 Offset: 0xF743C4 VA: 0xF783C4
	public void .ctor(Position castPosition) { }

	// RVA: 0xF7844C Offset: 0xF7444C VA: 0xF7844C
	public void .ctor(Position castPosition, int delayTime) { }
}

// Namespace: 
public class Params.Cast // TypeDefIndex: 1916
{
	// Fields
	public Params.Owner launch; // 0x10
	public Params.Owner target; // 0x18
	public static readonly Params.Cast Empty; // 0x0

	// Methods

	// RVA: 0xF784E0 Offset: 0xF744E0 VA: 0xF784E0
	public void .ctor() { }

	// RVA: 0xF785C0 Offset: 0xF745C0 VA: 0xF785C0
	public void .ctor(Controller launch, Controller target) { }

	// RVA: 0xF786D0 Offset: 0xF746D0 VA: 0xF786D0
	public void .ctor(Controller launch, Position position) { }

	// RVA: 0xF787E0 Offset: 0xF747E0 VA: 0xF787E0
	private static void .cctor() { }
}
