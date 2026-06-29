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

// Namespace: System.Security.Claims
[Serializable]
public class Claim // TypeDefIndex: 790
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x177C8A0 Offset: 0x17788A0 VA: 0x177C8A0
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x177C8C0 Offset: 0x17788C0 VA: 0x177C8C0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x177CCA8 Offset: 0x1778CA8 VA: 0x177CCA8
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserialized]
	// RVA: 0x177D000 Offset: 0x1779000 VA: 0x177D000
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x177CB70 Offset: 0x1778B70 VA: 0x177CB70
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x177D060 Offset: 0x1779060 VA: 0x177D060
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x177D068 Offset: 0x1779068 VA: 0x177D068
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x177D070 Offset: 0x1779070 VA: 0x177D070
	public string get_Type() { }

	// RVA: 0x177D078 Offset: 0x1779078 VA: 0x177D078
	public string get_Value() { }

	// RVA: 0x177D080 Offset: 0x1779080 VA: 0x177D080 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x177D0E8 Offset: 0x17790E8 VA: 0x177D0E8 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ClaimsIdentity.<get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator // TypeDefIndex: 791
{
	// Fields
	private int <>1__state; // 0x10
	private Claim <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ClaimsIdentity <>4__this; // 0x28
	private int <i>5__2; // 0x30
	private IEnumerator<Claim> <>7__wrap2; // 0x38

	// Properties
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x177E84C Offset: 0x177A84C VA: 0x177E84C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x177FA84 Offset: 0x177BA84 VA: 0x177FA84 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x177FAA0 Offset: 0x177BAA0 VA: 0x177FAA0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x177FEA4 Offset: 0x177BEA4 VA: 0x177FEA4
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x177FF54 Offset: 0x177BF54 VA: 0x177FF54 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x177FF5C Offset: 0x177BF5C VA: 0x177FF5C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x177FF94 Offset: 0x177BF94 VA: 0x177FF94 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x177FF9C Offset: 0x177BF9C VA: 0x177FF9C Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1780040 Offset: 0x177C040 VA: 0x1780040 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Security.Claims
[ComVisible(True)]
[Serializable]
public class ClaimsIdentity : IIdentity // TypeDefIndex: 792
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; // 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; // 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; // 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; // 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; // 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; // 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x177D160 Offset: 0x1779160 VA: 0x177D160
	public void .ctor() { }

	// RVA: 0x177D17C Offset: 0x177917C VA: 0x177D17C
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x177D198 Offset: 0x1779198 VA: 0x177D198
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x177D1A0 Offset: 0x17791A0 VA: 0x177D1A0
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x177DDD4 Offset: 0x1779DD4 VA: 0x177DDD4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177E734 Offset: 0x177A734 VA: 0x177E734 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x177E73C Offset: 0x177A73C VA: 0x177E73C
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x177E744 Offset: 0x177A744 VA: 0x177E744
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachine(typeof(ClaimsIdentity.<get_Claims>d__51))]
	// RVA: 0x177E7CC Offset: 0x177A7CC VA: 0x177E7CC Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x177E880 Offset: 0x177A880 VA: 0x177E880 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x177E8A4 Offset: 0x177A8A4 VA: 0x177E8A4 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x177D900 Offset: 0x1779900 VA: 0x177D900
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x177DCAC Offset: 0x1779CAC VA: 0x177DCAC
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x177EA24 Offset: 0x177AA24 VA: 0x177EA24 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializing]
	// RVA: 0x177ED50 Offset: 0x177AD50 VA: 0x177ED50
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x177F000 Offset: 0x177B000 VA: 0x177F000
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	// RVA: 0x177F428 Offset: 0x177B428 VA: 0x177F428
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x177F518 Offset: 0x177B518 VA: 0x177F518 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177F100 Offset: 0x177B100 VA: 0x177F100
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x177EDE0 Offset: 0x177ADE0 VA: 0x177EDE0
	private string SerializeClaims() { }

	// RVA: 0x177D8C0 Offset: 0x17798C0 VA: 0x177D8C0
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x177DF9C Offset: 0x1779F9C VA: 0x177DF9C
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}
