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

// Namespace: System.Dynamic
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 5925
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; // 0x18

	// Properties
	public ExpressionType Operation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A0D138 Offset: 0x1A09138 VA: 0x1A0D138
	public ExpressionType get_Operation() { }

	// RVA: 0x1A0D140 Offset: 0x1A09140 VA: 0x1A0D140
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A0D150 Offset: 0x1A09150 VA: 0x1A0D150 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: 
private struct BindingRestrictions.TestBuilder.AndNode // TypeDefIndex: 5926
{
	// Fields
	internal int Depth; // 0x0
	internal Expression Node; // 0x8
}

// Namespace: 
private sealed class BindingRestrictions.TestBuilder // TypeDefIndex: 5927
{
	// Fields
	private readonly HashSet<BindingRestrictions> _unique; // 0x10
	private readonly Stack<BindingRestrictions.TestBuilder.AndNode> _tests; // 0x18

	// Methods

	// RVA: 0x1A0D8BC Offset: 0x1A098BC VA: 0x1A0D8BC
	internal void Append(BindingRestrictions restrictions) { }

	// RVA: 0x1A0DA9C Offset: 0x1A09A9C VA: 0x1A0DA9C
	internal Expression ToExpression() { }

	// RVA: 0x1A0D948 Offset: 0x1A09948 VA: 0x1A0D948
	private void Push(Expression node, int depth) { }

	// RVA: 0x1A0DB70 Offset: 0x1A09B70 VA: 0x1A0DB70
	public void .ctor() { }
}

// Namespace: 
private sealed class BindingRestrictions.MergedRestriction : BindingRestrictions // TypeDefIndex: 5928
{
	// Fields
	internal readonly BindingRestrictions Left; // 0x10
	internal readonly BindingRestrictions Right; // 0x18

	// Methods

	// RVA: 0x1A0D330 Offset: 0x1A09330 VA: 0x1A0D330
	internal void .ctor(BindingRestrictions left, BindingRestrictions right) { }

	// RVA: 0x1A0DC4C Offset: 0x1A09C4C VA: 0x1A0DC4C Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.CustomRestriction : BindingRestrictions // TypeDefIndex: 5929
{
	// Fields
	private readonly Expression _expression; // 0x10

	// Methods

	// RVA: 0x1A0D848 Offset: 0x1A09848 VA: 0x1A0D848
	internal void .ctor(Expression expression) { }

	// RVA: 0x1A0DD98 Offset: 0x1A09D98 VA: 0x1A0DD98 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A0DE08 Offset: 0x1A09E08 VA: 0x1A0DE08 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A0DE38 Offset: 0x1A09E38 VA: 0x1A0DE38 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.TypeRestriction : BindingRestrictions // TypeDefIndex: 5930
{
	// Fields
	private readonly Expression _expression; // 0x10
	private readonly Type _type; // 0x18

	// Methods

	// RVA: 0x1A0D470 Offset: 0x1A09470 VA: 0x1A0D470
	internal void .ctor(Expression parameter, Type type) { }

	// RVA: 0x1A0DE40 Offset: 0x1A09E40 VA: 0x1A0DE40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A0DEFC Offset: 0x1A09EFC VA: 0x1A0DEFC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A0DF50 Offset: 0x1A09F50 VA: 0x1A0DF50 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.InstanceRestriction : BindingRestrictions // TypeDefIndex: 5931
{
	// Fields
	private readonly Expression _expression; // 0x10
	private readonly object _instance; // 0x18

	// Methods

	// RVA: 0x1A0D700 Offset: 0x1A09700 VA: 0x1A0D700
	internal void .ctor(Expression parameter, object instance) { }

	// RVA: 0x1A0DFB0 Offset: 0x1A09FB0 VA: 0x1A0DFB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A0E03C Offset: 0x1A0A03C VA: 0x1A0E03C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A0E088 Offset: 0x1A0A088 VA: 0x1A0E088 Slot: 4
	internal override Expression GetExpression() { }
}

// Namespace: 
private sealed class BindingRestrictions.BindingRestrictionsProxy // TypeDefIndex: 5932
{}

// Namespace: System.Dynamic
[DebuggerTypeProxy(typeof(BindingRestrictions.BindingRestrictionsProxy))]
[DebuggerDisplay("{DebugView}")]
public abstract class BindingRestrictions // TypeDefIndex: 5933
{
	// Fields
	public static readonly BindingRestrictions Empty; // 0x0

	// Methods

	// RVA: 0x1A0D238 Offset: 0x1A09238 VA: 0x1A0D238
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Expression GetExpression();

	// RVA: 0x1A0D240 Offset: 0x1A09240 VA: 0x1A0D240
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	// RVA: 0x1A0D3B8 Offset: 0x1A093B8 VA: 0x1A0D3B8
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	// RVA: 0x1A0D4F8 Offset: 0x1A094F8 VA: 0x1A0D4F8
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	// RVA: 0x1A0D640 Offset: 0x1A09640 VA: 0x1A0D640
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	// RVA: 0x1A0D788 Offset: 0x1A09788 VA: 0x1A0D788
	public Expression ToExpression() { }

	// RVA: 0x1A0D794 Offset: 0x1A09794 VA: 0x1A0D794
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 5934
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A0E418 Offset: 0x1A0A418 VA: 0x1A0E418
	public Type get_Type() { }

	// RVA: 0x1A0E420 Offset: 0x1A0A420 VA: 0x1A0E420
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A0E430 Offset: 0x1A0A430 VA: 0x1A0E430 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 5935
{
	// Methods

	// RVA: 0x1A0E4E0 Offset: 0x1A0A4E0 VA: 0x1A0E4E0
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A0E4F0 Offset: 0x1A0A4F0 VA: 0x1A0E4F0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 5936
{
	// Methods

	// RVA: 0x1A0E5B0 Offset: 0x1A0A5B0 VA: 0x1A0E5B0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A0E66C Offset: 0x1A0A66C VA: 0x1A0E66C
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 5937
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A0E67C Offset: 0x1A0A67C VA: 0x1A0E67C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1A0E684 Offset: 0x1A0A684 VA: 0x1A0E684
	public bool get_IgnoreCase() { }

	// RVA: 0x1A0E68C Offset: 0x1A0A68C VA: 0x1A0E68C
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A0E69C Offset: 0x1A0A69C VA: 0x1A0E69C Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public class DynamicMetaObject // TypeDefIndex: 5938
{
	// Fields
	public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x0
	private static readonly object s_noValueSentinel; // 0x8
	private readonly object _value; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; // 0x20

	// Properties
	public Expression Expression { get; }
	public BindingRestrictions Restrictions { get; }
	public object Value { get; }
	public bool HasValue { get; }
	public Type RuntimeType { get; }
	public Type LimitType { get; }

	// Methods

	// RVA: 0x1A0E74C Offset: 0x1A0A74C VA: 0x1A0E74C
	public void .ctor(Expression expression, BindingRestrictions restrictions) { }

	// RVA: 0x1A0E83C Offset: 0x1A0A83C VA: 0x1A0E83C
	public void .ctor(Expression expression, BindingRestrictions restrictions, object value) { }

	[CompilerGenerated]
	// RVA: 0x1A0E868 Offset: 0x1A0A868 VA: 0x1A0E868
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x1A0E870 Offset: 0x1A0A870 VA: 0x1A0E870
	public BindingRestrictions get_Restrictions() { }

	// RVA: 0x1A0D5B4 Offset: 0x1A095B4 VA: 0x1A0D5B4
	public object get_Value() { }

	// RVA: 0x1A0D5D8 Offset: 0x1A095D8 VA: 0x1A0D5D8
	public bool get_HasValue() { }

	// RVA: 0x1A0E878 Offset: 0x1A0A878 VA: 0x1A0E878
	public Type get_RuntimeType() { }

	// RVA: 0x1A0D6CC Offset: 0x1A096CC VA: 0x1A0D6CC
	public Type get_LimitType() { }

	// RVA: 0x1A0E8F0 Offset: 0x1A0A8F0 VA: 0x1A0E8F0 Slot: 4
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x1A0E968 Offset: 0x1A0A968 VA: 0x1A0E968 Slot: 5
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1A0E9D8 Offset: 0x1A0A9D8 VA: 0x1A0E9D8 Slot: 6
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1A0EA50 Offset: 0x1A0AA50 VA: 0x1A0EA50 Slot: 7
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x1A0EAC8 Offset: 0x1A0AAC8 VA: 0x1A0EAC8 Slot: 8
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1A0EB40 Offset: 0x1A0AB40 VA: 0x1A0EB40 Slot: 9
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x1A0EBC8 Offset: 0x1A0ABC8 VA: 0x1A0EBC8 Slot: 10
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1A0EC48 Offset: 0x1A0AC48 VA: 0x1A0EC48 Slot: 11
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A0ECC0 Offset: 0x1A0ACC0 VA: 0x1A0ECC0 Slot: 12
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A0ED38 Offset: 0x1A0AD38 VA: 0x1A0ED38 Slot: 13
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A0EDB8 Offset: 0x1A0ADB8 VA: 0x1A0EDB8 Slot: 14
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x1A0EE28 Offset: 0x1A0AE28 VA: 0x1A0EE28 Slot: 15
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x1A0EEA8 Offset: 0x1A0AEA8 VA: 0x1A0EEA8 Slot: 16
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1A0EF3C Offset: 0x1A0AF3C VA: 0x1A0EF3C
	public static DynamicMetaObject Create(object value, Expression expression) { }

	// RVA: 0x1A0F0F8 Offset: 0x1A0B0F8 VA: 0x1A0F0F8
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 5939
{
	// Properties
	public virtual Type ReturnType { get; }
	internal virtual bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A0F1F0 Offset: 0x1A0B1F0 VA: 0x1A0F1F0
	protected void .ctor() { }

	// RVA: 0x1A0F248 Offset: 0x1A0B248 VA: 0x1A0F248 Slot: 6
	public virtual Type get_ReturnType() { }

	// RVA: 0x1A0F278 Offset: 0x1A0B278 VA: 0x1A0F278 Slot: 4
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	// RVA: 0x1A0F854 Offset: 0x1A0B854 VA: 0x1A0F854
	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	// RVA: 0x1A0F9FC Offset: 0x1A0B9FC VA: 0x1A0F9FC
	public Expression GetUpdateExpression(Type type) { }

	// RVA: 0x1A0FABC Offset: 0x1A0BABC VA: 0x1A0FABC Slot: 8
	internal virtual bool get_IsStandardBinder() { }
}

// Namespace: System.Dynamic
internal class ExpandoClass // TypeDefIndex: 5940
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x1A0FAC4 Offset: 0x1A0BAC4 VA: 0x1A0FAC4
	internal void .ctor() { }

	// RVA: 0x1A0FB78 Offset: 0x1A0BB78 VA: 0x1A0FB78
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x1A0FBB0 Offset: 0x1A0BBB0 VA: 0x1A0FBB0
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x1A0FF98 Offset: 0x1A0BF98 VA: 0x1A0FF98
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x1A100D0 Offset: 0x1A0C0D0 VA: 0x1A100D0
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x1A10268 Offset: 0x1A0C268 VA: 0x1A10268
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x1A100E0 Offset: 0x1A0C0E0 VA: 0x1A100E0
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x1A10384 Offset: 0x1A0C384 VA: 0x1A10384
	internal string[] get_Keys() { }

	// RVA: 0x1A1038C Offset: 0x1A0C38C VA: 0x1A1038C
	private static void .cctor() { }
}

// Namespace: 
private sealed class ExpandoObject.ValueCollectionDebugView // TypeDefIndex: 5941
{}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.ValueCollection.<GetEnumerator>d__15 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 5942
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandoObject.ValueCollection <>4__this; // 0x20
	private ExpandoObject.ExpandoData <data>5__2; // 0x28
	private int <i>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1A119A4 Offset: 0x1A0D9A4 VA: 0x1A119A4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1A119CC Offset: 0x1A0D9CC VA: 0x1A119CC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A119D0 Offset: 0x1A0D9D0 VA: 0x1A119D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A11B3C Offset: 0x1A0DB3C VA: 0x1A11B3C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A11B44 Offset: 0x1A0DB44 VA: 0x1A11B44 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A11B7C Offset: 0x1A0DB7C VA: 0x1A11B7C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DebuggerTypeProxy(typeof(ExpandoObject.ValueCollectionDebugView))]
[DebuggerDisplay("Count = {Count}")]
private class ExpandoObject.ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable // TypeDefIndex: 5943
{
	// Fields
	private readonly ExpandoObject _expando; // 0x10
	private readonly int _expandoVersion; // 0x18
	private readonly int _expandoCount; // 0x1C
	private readonly ExpandoObject.ExpandoData _expandoData; // 0x20

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1A10638 Offset: 0x1A0C638 VA: 0x1A10638
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x1A1142C Offset: 0x1A0D42C VA: 0x1A1142C
	private void CheckVersion() { }

	// RVA: 0x1A1148C Offset: 0x1A0D48C VA: 0x1A1148C Slot: 6
	public void Add(object item) { }

	// RVA: 0x1A114B4 Offset: 0x1A0D4B4 VA: 0x1A114B4 Slot: 7
	public void Clear() { }

	// RVA: 0x1A114DC Offset: 0x1A0D4DC VA: 0x1A114DC Slot: 8
	public bool Contains(object item) { }

	// RVA: 0x1A11644 Offset: 0x1A0D644 VA: 0x1A11644 Slot: 9
	public void CopyTo(object[] array, int arrayIndex) { }

	// RVA: 0x1A118E4 Offset: 0x1A0D8E4 VA: 0x1A118E4 Slot: 4
	public int get_Count() { }

	// RVA: 0x1A118FC Offset: 0x1A0D8FC VA: 0x1A118FC Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1A11904 Offset: 0x1A0D904 VA: 0x1A11904 Slot: 10
	public bool Remove(object item) { }

	[IteratorStateMachine(typeof(ExpandoObject.ValueCollection.<GetEnumerator>d__15))]
	// RVA: 0x1A1192C Offset: 0x1A0D92C VA: 0x1A1192C Slot: 11
	public IEnumerator<object> GetEnumerator() { }

	// RVA: 0x1A119A0 Offset: 0x1A0D9A0 VA: 0x1A119A0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.MetaExpando.<>c__DisplayClass3_0 // TypeDefIndex: 5944
{
	// Fields
	public InvokeMemberBinder binder; // 0x10
	public DynamicMetaObject[] args; // 0x18

	// Methods

	// RVA: 0x1A12840 Offset: 0x1A0E840 VA: 0x1A12840
	public void .ctor() { }

	// RVA: 0x1A1314C Offset: 0x1A0F14C VA: 0x1A1314C
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 5945
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ExpandoObject.MetaExpando <>4__this; // 0x28
	private ExpandoObject.ExpandoData <expandoData>5__2; // 0x30
	private ExpandoClass <klass>5__3; // 0x38
	private int <i>5__4; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1A13048 Offset: 0x1A0F048 VA: 0x1A13048
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1A13174 Offset: 0x1A0F174 VA: 0x1A13174 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A13178 Offset: 0x1A0F178 VA: 0x1A13178 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A132D4 Offset: 0x1A0F2D4 VA: 0x1A132D4 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A132DC Offset: 0x1A0F2DC VA: 0x1A132DC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A13314 Offset: 0x1A0F314 VA: 0x1A13314 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A1331C Offset: 0x1A0F31C VA: 0x1A1331C Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A133C0 Offset: 0x1A0F3C0 VA: 0x1A133C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class ExpandoObject.MetaExpando : DynamicMetaObject // TypeDefIndex: 5946
{
	// Properties
	public ExpandoObject Value { get; }

	// Methods

	// RVA: 0x1A11B84 Offset: 0x1A0DB84 VA: 0x1A11B84
	public void .ctor(Expression expression, ExpandoObject value) { }

	// RVA: 0x1A11C2C Offset: 0x1A0DC2C VA: 0x1A11C2C
	private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

	// RVA: 0x1A12604 Offset: 0x1A0E604 VA: 0x1A12604 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1A126F8 Offset: 0x1A0E6F8 VA: 0x1A126F8 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A12858 Offset: 0x1A0E858 VA: 0x1A12858 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1A12D34 Offset: 0x1A0ED34 VA: 0x1A12D34 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	[IteratorStateMachine(typeof(ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6))]
	// RVA: 0x1A12FC8 Offset: 0x1A0EFC8 VA: 0x1A12FC8 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1A12378 Offset: 0x1A0E378 VA: 0x1A12378
	private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

	// RVA: 0x1A12C64 Offset: 0x1A0EC64 VA: 0x1A12C64
	private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

	// RVA: 0x1A12290 Offset: 0x1A0E290 VA: 0x1A12290
	private Expression GetLimitedSelf() { }

	// RVA: 0x1A1307C Offset: 0x1A0F07C VA: 0x1A1307C
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x1A1222C Offset: 0x1A0E22C VA: 0x1A1222C
	public ExpandoObject get_Value() { }
}

// Namespace: 
[DefaultMember("Item")]
private class ExpandoObject.ExpandoData // TypeDefIndex: 5947
{
	// Fields
	internal static ExpandoObject.ExpandoData Empty; // 0x0
	internal readonly ExpandoClass Class; // 0x10
	private readonly object[] _dataArray; // 0x18
	private int _version; // 0x20

	// Properties
	internal object Item { get; set; }
	internal int Version { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1A11B0C Offset: 0x1A0DB0C VA: 0x1A11B0C
	internal object get_Item(int index) { }

	// RVA: 0x1A133C4 Offset: 0x1A0F3C4 VA: 0x1A133C4
	internal void set_Item(int index, object value) { }

	// RVA: 0x1A13438 Offset: 0x1A0F438 VA: 0x1A13438
	internal int get_Version() { }

	// RVA: 0x1A13440 Offset: 0x1A0F440 VA: 0x1A13440
	internal int get_Length() { }

	// RVA: 0x1A13458 Offset: 0x1A0F458 VA: 0x1A13458
	private void .ctor() { }

	// RVA: 0x1A13540 Offset: 0x1A0F540 VA: 0x1A13540
	internal void .ctor(ExpandoClass klass, object[] data, int version) { }

	// RVA: 0x1A13598 Offset: 0x1A0F598 VA: 0x1A13598
	internal ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass) { }

	// RVA: 0x1A1373C Offset: 0x1A0F73C VA: 0x1A1373C
	private static int GetAlignedSize(int len) { }

	// RVA: 0x1A13748 Offset: 0x1A0F748 VA: 0x1A13748
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExpandoObject.<GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair<string, object>>, IDisposable, IEnumerator // TypeDefIndex: 5948
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, object> <>2__current; // 0x18
	public ExpandoObject <>4__this; // 0x28
	public int version; // 0x30
	public ExpandoObject.ExpandoData data; // 0x38
	private int <i>5__2; // 0x40

	// Properties
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1A137AC Offset: 0x1A0F7AC VA: 0x1A137AC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1A137D4 Offset: 0x1A0F7D4 VA: 0x1A137D4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A137D8 Offset: 0x1A0F7D8 VA: 0x1A137D8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A13988 Offset: 0x1A0F988 VA: 0x1A13988 Slot: 4
	private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A13994 Offset: 0x1A0F994 VA: 0x1A13994 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A139CC Offset: 0x1A0F9CC VA: 0x1A139CC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Dynamic
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 5949
{
	// Fields
	private static readonly MethodInfo s_expandoTryGetValue; // 0x0
	private static readonly MethodInfo s_expandoTrySetValue; // 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
	private static readonly MethodInfo s_expandoPromoteClass; // 0x18
	private static readonly MethodInfo s_expandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1A103F0 Offset: 0x1A0C3F0 VA: 0x1A103F0
	public void .ctor() { }

	// RVA: 0x1A0C57C Offset: 0x1A0857C VA: 0x1A0C57C
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x1A0C6D8 Offset: 0x1A086D8 VA: 0x1A0C6D8
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x1A0CB0C Offset: 0x1A08B0C VA: 0x1A0CB0C
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x1A102DC Offset: 0x1A0C2DC VA: 0x1A102DC
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x1A0CE2C Offset: 0x1A08E2C VA: 0x1A0CE2C
	internal ExpandoClass get_Class() { }

	// RVA: 0x1A10498 Offset: 0x1A0C498 VA: 0x1A10498
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x1A0CE54 Offset: 0x1A08E54 VA: 0x1A0CE54
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x1A104E0 Offset: 0x1A0C4E0 VA: 0x1A104E0 Slot: 4
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x1A1054C Offset: 0x1A0C54C VA: 0x1A1054C
	private void TryAddMember(string key, object value) { }

	// RVA: 0x1A105C8 Offset: 0x1A0C5C8 VA: 0x1A105C8
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x1A105E0 Offset: 0x1A0C5E0 VA: 0x1A105E0 Slot: 7
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	// RVA: 0x1A10744 Offset: 0x1A0C744 VA: 0x1A10744 Slot: 5
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x1A107A8 Offset: 0x1A0C7A8 VA: 0x1A107A8 Slot: 6
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	// RVA: 0x1A10824 Offset: 0x1A0C824 VA: 0x1A10824 Slot: 9
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x1A10828 Offset: 0x1A0C828 VA: 0x1A10828 Slot: 8
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x1A108FC Offset: 0x1A0C8FC VA: 0x1A108FC Slot: 10
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	// RVA: 0x1A1099C Offset: 0x1A0C99C VA: 0x1A1099C Slot: 11
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x1A109B4 Offset: 0x1A0C9B4 VA: 0x1A109B4 Slot: 12
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x1A109BC Offset: 0x1A0C9BC VA: 0x1A109BC Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x1A109C4 Offset: 0x1A0C9C4 VA: 0x1A109C4 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x1A10A24 Offset: 0x1A0CA24 VA: 0x1A10A24 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x1A10C5C Offset: 0x1A0CC5C VA: 0x1A10C5C Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x1A10CF0 Offset: 0x1A0CCF0 VA: 0x1A10CF0 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x1A110E4 Offset: 0x1A0D0E4 VA: 0x1A110E4 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x1A11150 Offset: 0x1A0D150 VA: 0x1A11150 Slot: 19
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1A11200 Offset: 0x1A0D200 VA: 0x1A11200 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ExpandoObject.<GetExpandoEnumerator>d__51))]
	// RVA: 0x1A11168 Offset: 0x1A0D168 VA: 0x1A11168
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x1A11218 Offset: 0x1A0D218 VA: 0x1A11218
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 5950
{
	// Methods

	// RVA: 0x1A13A28 Offset: 0x1A0FA28 VA: 0x1A13A28 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A13AE0 Offset: 0x1A0FAE0 VA: 0x1A13AE0
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 5951
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A13AF0 Offset: 0x1A0FAF0 VA: 0x1A13AF0
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x1A13B70 Offset: 0x1A0FB70 VA: 0x1A13B70 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x1A13BA0 Offset: 0x1A0FBA0 VA: 0x1A13BA0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1A13BA8 Offset: 0x1A0FBA8 VA: 0x1A13BA8
	public bool get_IgnoreCase() { }

	// RVA: 0x1A126E8 Offset: 0x1A0E6E8 VA: 0x1A126E8
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A13BB0 Offset: 0x1A0FBB0 VA: 0x1A13BB0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A13C8C Offset: 0x1A0FC8C VA: 0x1A13C8C Slot: 8
	internal sealed override bool get_IsStandardBinder() { }
}

// Namespace: System.Dynamic
public interface IDynamicMetaObjectProvider // TypeDefIndex: 5952
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DynamicMetaObject GetMetaObject(Expression parameter);
}

// Namespace: System.Dynamic
public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 5953
{
	// Methods

	// RVA: 0x1A13C94 Offset: 0x1A0FC94 VA: 0x1A13C94
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A13CA4 Offset: 0x1A0FCA4 VA: 0x1A13CA4 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 5954
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A13D5C Offset: 0x1A0FD5C VA: 0x1A13D5C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1A13D64 Offset: 0x1A0FD64 VA: 0x1A13D64
	public bool get_IgnoreCase() { }

	// RVA: 0x1A13D6C Offset: 0x1A0FD6C VA: 0x1A13D6C Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A12848 Offset: 0x1A0E848 VA: 0x1A12848
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 5955
{
	// Methods

	// RVA: 0x1A13E24 Offset: 0x1A0FE24 VA: 0x1A13E24 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A13F50 Offset: 0x1A0FF50 VA: 0x1A13F50
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 5956
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A13F60 Offset: 0x1A0FF60 VA: 0x1A13F60
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x1A13FE0 Offset: 0x1A0FFE0 VA: 0x1A13FE0 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x1A14010 Offset: 0x1A10010 VA: 0x1A14010
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1A14018 Offset: 0x1A10018 VA: 0x1A14018
	public bool get_IgnoreCase() { }

	// RVA: 0x1A14020 Offset: 0x1A10020 VA: 0x1A14020 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A140F4 Offset: 0x1A100F4 VA: 0x1A140F4 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }

	// RVA: 0x1A140FC Offset: 0x1A100FC VA: 0x1A140FC
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 5957
{
	// Methods

	// RVA: 0x1A1410C Offset: 0x1A1010C VA: 0x1A1410C
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A1411C Offset: 0x1A1011C VA: 0x1A1411C Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: 
private sealed class CacheDict.Entry<TKey, TValue> // TypeDefIndex: 5958
{
	// Fields
	internal readonly int _hash; // 0x0
	internal readonly TKey _key; // 0x0
	internal readonly TValue _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int hash, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3D40 Offset: 0x11DFD40 VA: 0x11E3D40
	|-CacheDict.Entry<object, object>..ctor
	|
	|-RVA: 0x11E3D94 Offset: 0x11DFD94 VA: 0x11E3D94
	|-CacheDict.Entry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
