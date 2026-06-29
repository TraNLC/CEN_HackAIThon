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

// Namespace: game.skill.missile
public class Map // TypeDefIndex: 2139
{
	// Fields
	private Map handle; // 0x10

	// Methods

	// RVA: 0xF9A8E8 Offset: 0xF968E8 VA: 0xF9A8E8
	public void .ctor() { }

	// RVA: 0xF9A8F0 Offset: 0xF968F0 VA: 0xF9A8F0
	public void .ctor(Map map) { }

	// RVA: 0xF9A920 Offset: 0xF96920 VA: 0xF9A920
	public void SetMap(Map map) { }

	// RVA: 0xF9A928 Offset: 0xF96928 VA: 0xF9A928
	private static List<ValueTuple<int, int>> GetCellList(Position position, int radius) { }

	// RVA: 0xF9AED4 Offset: 0xF96ED4 VA: 0xF9AED4
	private bool FindNpc(List<Params.Owner> result, Position position, int cellX, int cellY, int radius, int limit) { }

	// RVA: 0xF9B1DC Offset: 0xF971DC VA: 0xF9B1DC
	private bool FindPlayerAndNpc(List<Params.Owner> result, Position position, int cellX, int cellY, int radius, int limit) { }

	// RVA: 0xF9B6BC Offset: 0xF976BC VA: 0xF9B6BC
	private bool FindNpcAndPlayerNotTrain(List<Params.Owner> result, Position position, int cellX, int cellY, int radius, int limit) { }

	// RVA: 0xF9BBB4 Offset: 0xF97BB4 VA: 0xF9BBB4
	public List<Params.Owner> FindNearestOwnerForSkillCollision(Params.Owner launch, int skillRelationRequired, Position position, int radius, int limit) { }

	// RVA: 0xF9C248 Offset: 0xF98248 VA: 0xF9C248
	public List<Params.Owner> FindNearestOwnerForTargetDirection(Controller npcontroller, int skillRelationRequired, Position position, int radius, int limit) { }

	// RVA: 0xF9CDA8 Offset: 0xF98DA8 VA: 0xF9CDA8
	public List<Params.Owner> FindNearestOwnerForHomeTouch(Position position, int radius, int limit) { }

	// RVA: 0xF9D500 Offset: 0xF99500 VA: 0xF9D500
	public Dictionary<Params.Owner, double> FindNearestOwnerWithDistance(Controller npcontroller, int skillRelationRequired, Position position, int radius, int limit) { }

	// RVA: 0xF9DFB4 Offset: 0xF99FB4 VA: 0xF9DFB4
	public void CastSkill(int id, int level, Params.Cast castParams, Params.Options options) { }
}

// Namespace: game.skill.missile
public class Texture : Texture // TypeDefIndex: 2140
{
	// Methods

	// RVA: 0xF9DFCC Offset: 0xF99FCC VA: 0xF9DFCC
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Active : Wait // TypeDefIndex: 2141
{
	// Methods

	// RVA: 0xF9DFD4 Offset: 0xF99FD4 VA: 0xF9DFD4
	public void Start() { }

	// RVA: 0xF9E01C Offset: 0xF9A01C VA: 0xF9E01C
	public bool Activate() { }

	// RVA: 0xF983C0 Offset: 0xF943C0 VA: 0xF983C0
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Axis : Data // TypeDefIndex: 2142
{
	// Fields
	public int heightSpeed; // 0x78
	public int height; // 0x7C
	public int currentMapZ; // 0x80
	private int xOffset; // 0x84
	private int yOffset; // 0x88

	// Methods

	// RVA: 0xF9E0C4 Offset: 0xF9A0C4 VA: 0xF9E0C4
	protected void ZAxisMove() { }

	// RVA: 0xF9E118 Offset: 0xF9A118 VA: 0xF9E118
	protected void ApplyDOffset(int xx, int yy) { }

	// RVA: 0xF9E16C Offset: 0xF9A16C VA: 0xF9E16C
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Collision : End // TypeDefIndex: 2143
{
	// Fields
	private readonly Dictionary<int, long> targetNextCollideTime; // 0x90

	// Methods

	// RVA: 0xF9E0C0 Offset: 0xF9A0C0 VA: 0xF9E0C0
	public void OnCollision() { }

	// RVA: 0xF9E174 Offset: 0xF9A174 VA: 0xF9E174
	private bool ProcessCollision(Params.Owner target, int relation) { }

	// RVA: 0xF9E2C0 Offset: 0xF9A2C0 VA: 0xF9E2C0
	public void CheckCollision() { }

	// RVA: 0xF9E7C0 Offset: 0xF9A7C0 VA: 0xF9E7C0
	public void .ctor() { }
}

// Namespace: 
public class Data.Settings // TypeDefIndex: 2144
{
	// Fields
	public Skill skill; // 0x10
	public Missile missile; // 0x18

	// Methods

	// RVA: 0xF9E9F0 Offset: 0xF9A9F0 VA: 0xF9E9F0
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Data // TypeDefIndex: 2145
{
	// Fields
	protected Missile self; // 0x10
	public Data.Settings settings; // 0x18
	public Params.Cast castParams; // 0x20
	public Texture texture; // 0x28
	public Map mapBase; // 0x30
	public int missleStatus; // 0x38
	public int currentLife; // 0x3C
	public int startLifeTime; // 0x40
	public int lifeTime; // 0x44
	public int direction; // 0x48
	public Position refer; // 0x50
	public Position factor; // 0x58
	public Position position; // 0x60
	protected bool ignoreColide; // 0x68
	public int eventSkillLevel; // 0x6C
	public bool isDoColideOnMissle; // 0x70
	public int radiusColideRange; // 0x74

	// Methods

	// RVA: 0xF9E848 Offset: 0xF9A848 VA: 0xF9E848
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class End : Axis // TypeDefIndex: 2146
{
	// Methods

	// RVA: 0xF9EA9C Offset: 0xF9AA9C VA: 0xF9EA9C
	public void DoEnd() { }

	// RVA: 0xF9EAA8 Offset: 0xF9AAA8 VA: 0xF9EAA8
	public void OnEnd() { }

	// RVA: 0xF9EAC4 Offset: 0xF9AAC4 VA: 0xF9EAC4
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Fly : Stand // TypeDefIndex: 2147
{
	// Methods

	// RVA: 0xF9EACC Offset: 0xF9AACC VA: 0xF9EACC
	public void DoFly() { }

	// RVA: 0xF9EBA0 Offset: 0xF9ABA0 VA: 0xF9EBA0
	public void OnFly() { }

	// RVA: 0xF9F74C Offset: 0xF9B74C VA: 0xF9F74C
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Vanish : Collision // TypeDefIndex: 2148
{
	// Methods

	// RVA: 0xF9F75C Offset: 0xF9B75C VA: 0xF9F75C
	public void DoVanish() { }

	// RVA: 0xF9F948 Offset: 0xF9B948 VA: 0xF9F948
	public void OnVanish() { }

	// RVA: 0xF9F964 Offset: 0xF9B964 VA: 0xF9F964
	public void .ctor() { }
}

// Namespace: game.skill.missile
public class Wait : Fly // TypeDefIndex: 2149
{
	// Methods

	// RVA: 0xF9F96C Offset: 0xF9B96C VA: 0xF9F96C
	public void DoWait() { }

	// RVA: 0xF9F988 Offset: 0xF9B988 VA: 0xF9F988
	public void OnWait() { }

	// RVA: 0xF9F99C Offset: 0xF9B99C VA: 0xF9F99C
	public void .ctor() { }
}
