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

// Namespace: System.Dynamic.Utils
[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 5959
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE544 Offset: 0x14DA544 VA: 0x14DE544
	|-CacheDict<object, object>..ctor
	|
	|-RVA: 0x14DE7D4 Offset: 0x14DA7D4 VA: 0x14DE7D4
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE5B4 Offset: 0x14DA5B4 VA: 0x14DE5B4
	|-CacheDict<object, object>.AlignSize
	|
	|-RVA: 0x14DE850 Offset: 0x14DA850 VA: 0x14DE850
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE5D4 Offset: 0x14DA5D4 VA: 0x14DE5D4
	|-CacheDict<object, object>.TryGetValue
	|
	|-RVA: 0x14DE870 Offset: 0x14DA870 VA: 0x14DE870
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE690 Offset: 0x14DA690 VA: 0x14DE690
	|-CacheDict<object, object>.Add
	|
	|-RVA: 0x14DEBF8 Offset: 0x14DABF8 VA: 0x14DEBF8
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DE7C4 Offset: 0x14DA7C4 VA: 0x14DE7C4
	|-CacheDict<object, object>.set_Item
	|
	|-RVA: 0x14DF010 Offset: 0x14DB010 VA: 0x14DF010
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class CollectionExtensions // TypeDefIndex: 5960
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TrueReadOnlyCollection<T> AddFirst<T>(ReadOnlyCollection<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F04C8 Offset: 0x10EC4C8 VA: 0x10F04C8
	|-CollectionExtensions.AddFirst<object>
	|
	|-RVA: 0x10F05B8 Offset: 0x10EC5B8 VA: 0x10F05B8
	|-CollectionExtensions.AddFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] AddLast<T>(T[] array, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0784 Offset: 0x10EC784 VA: 0x10F0784
	|-CollectionExtensions.AddLast<object>
	|
	|-RVA: 0x10F0824 Offset: 0x10EC824 VA: 0x10F0824
	|-CollectionExtensions.AddLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveFirst<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F09C8 Offset: 0x10EC9C8 VA: 0x10F09C8
	|-CollectionExtensions.RemoveFirst<object>
	|
	|-RVA: 0x10F0A48 Offset: 0x10ECA48 VA: 0x10F0A48
	|-CollectionExtensions.RemoveFirst<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveLast<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0AC8 Offset: 0x10ECAC8 VA: 0x10F0AC8
	|-CollectionExtensions.RemoveLast<object>
	|
	|-RVA: 0x10F0B48 Offset: 0x10ECB48 VA: 0x10F0B48
	|-CollectionExtensions.RemoveLast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ToReadOnly<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0BC8 Offset: 0x10ECBC8 VA: 0x10F0BC8
	|-CollectionExtensions.ToReadOnly<object>
	|
	|-RVA: 0x10F0CF0 Offset: 0x10ECCF0 VA: 0x10F0CF0
	|-CollectionExtensions.ToReadOnly<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class ContractUtils // TypeDefIndex: 5961
{
	// Properties
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x1A141C8 Offset: 0x1A101C8 VA: 0x1A141C8
	public static Exception get_Unreachable() { }

	// RVA: 0x1A13C58 Offset: 0x1A0FC58 VA: 0x1A13C58
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x1A1269C Offset: 0x1A0E69C VA: 0x1A1269C
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x1A14234 Offset: 0x1A10234 VA: 0x1A14234
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F3DD0 Offset: 0x10EFDD0 VA: 0x10F3DD0
	|-ContractUtils.RequiresNotNullItems<object>
	|
	|-RVA: 0x10F3F6C Offset: 0x10EFF6C VA: 0x10F3F6C
	|-ContractUtils.RequiresNotNullItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A1428C Offset: 0x1A1028C VA: 0x1A1428C
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F3A40 Offset: 0x10EFA40 VA: 0x10F3A40
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|
	|-RVA: 0x10F3B70 Offset: 0x10EFB70 VA: 0x10F3B70
	|-ContractUtils.RequiresArrayRange<object>
	|
	|-RVA: 0x10F3CA0 Offset: 0x10EFCA0 VA: 0x10F3CA0
	|-ContractUtils.RequiresArrayRange<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Dynamic.Utils
internal static class EmptyReadOnlyCollection<T> // TypeDefIndex: 5962
{
	// Fields
	public static readonly ReadOnlyCollection<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3A64 Offset: 0x11DFA64 VA: 0x11E3A64
	|-EmptyReadOnlyCollection<object>..cctor
	|
	|-RVA: 0x11E3BC0 Offset: 0x11DFBC0 VA: 0x11E3BC0
	|-EmptyReadOnlyCollection<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class ExpressionUtils // TypeDefIndex: 5963
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F070 Offset: 0x110B070 VA: 0x110F070
	|-ExpressionUtils.ReturnReadOnly<object>
	|
	|-RVA: 0x110F160 Offset: 0x110B160 VA: 0x110F160
	|-ExpressionUtils.ReturnReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EF5C Offset: 0x110AF5C VA: 0x110EF5C
	|-ExpressionUtils.ReturnObject<object>
	*/

	// RVA: 0x1A14314 Offset: 0x1A10314 VA: 0x1A14314
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x1A146AC Offset: 0x1A106AC VA: 0x1A146AC
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1A14758 Offset: 0x1A10758 VA: 0x1A14758
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x1A14DF8 Offset: 0x1A10DF8 VA: 0x1A14DF8
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x1A14968 Offset: 0x1A10968 VA: 0x1A14968
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x1A14CD4 Offset: 0x1A10CD4 VA: 0x1A14CD4
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x1A14618 Offset: 0x1A10618 VA: 0x1A14618
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F254 Offset: 0x110B254 VA: 0x110F254
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110F39C Offset: 0x110B39C VA: 0x110F39C
	|-ExpressionUtils.SameElementsInCollection<object>
	*/

	[Extension]
	// RVA: 0x1A14FA8 Offset: 0x1A10FA8 VA: 0x1A14FA8
	public static void ValidateArgumentCount(LambdaExpression lambda) { }
}

// Namespace: System.Dynamic.Utils
internal static class ExpressionVisitorUtils // TypeDefIndex: 5964
{
	// Methods

	// RVA: 0x1A1507C Offset: 0x1A1107C VA: 0x1A1507C
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	// RVA: 0x1A1523C Offset: 0x1A1123C VA: 0x1A1523C
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

	// RVA: 0x1A15540 Offset: 0x1A11540 VA: 0x1A15540
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeExtensions // TypeDefIndex: 5965
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1A157EC Offset: 0x1A117EC VA: 0x1A157EC
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Extension]
	// RVA: 0x1A15890 Offset: 0x1A11890 VA: 0x1A15890
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[Extension]
	// RVA: 0x1A159D8 Offset: 0x1A119D8 VA: 0x1A159D8
	public static Type GetReturnType(MethodBase mi) { }

	[Extension]
	// RVA: 0x1A15A88 Offset: 0x1A11A88 VA: 0x1A15A88
	public static TypeCode GetTypeCode(Type type) { }

	[Extension]
	// RVA: 0x1A14E9C Offset: 0x1A10E9C VA: 0x1A14E9C
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x1A15ABC Offset: 0x1A11ABC VA: 0x1A15ABC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeUtils.<>c // TypeDefIndex: 5966
{
	// Fields
	public static readonly TypeUtils.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1A18A84 Offset: 0x1A14A84 VA: 0x1A18A84
	private static void .cctor() { }

	// RVA: 0x1A18AEC Offset: 0x1A14AEC VA: 0x1A18AEC
	public void .ctor() { }

	// RVA: 0x1A18AF4 Offset: 0x1A14AF4 VA: 0x1A18AF4
	internal bool <.cctor>b__44_0(Type i) { }

	// RVA: 0x1A18B18 Offset: 0x1A14B18 VA: 0x1A18B18
	internal Type <.cctor>b__44_1(Type i) { }
}

// Namespace: System.Dynamic.Utils
[Extension]
internal static class TypeUtils // TypeDefIndex: 5967
{
	// Fields
	private static readonly Type[] s_arrayAssignableInterfaces; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1A15B58 Offset: 0x1A11B58 VA: 0x1A15B58
	public static Type GetNonNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A15CA8 Offset: 0x1A11CA8 VA: 0x1A15CA8
	public static Type GetNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A15BE8 Offset: 0x1A11BE8 VA: 0x1A15BE8
	public static bool IsNullableType(Type type) { }

	[Extension]
	// RVA: 0x1A15DEC Offset: 0x1A11DEC VA: 0x1A15DEC
	public static bool IsNullableOrReferenceType(Type type) { }

	[Extension]
	// RVA: 0x1A15E68 Offset: 0x1A11E68 VA: 0x1A15E68
	public static bool IsBool(Type type) { }

	[Extension]
	// RVA: 0x1A15EFC Offset: 0x1A11EFC VA: 0x1A15EFC
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x1A15FB8 Offset: 0x1A11FB8 VA: 0x1A15FB8
	public static bool IsInteger(Type type) { }

	[Extension]
	// RVA: 0x1A16074 Offset: 0x1A12074 VA: 0x1A16074
	public static bool IsArithmetic(Type type) { }

	[Extension]
	// RVA: 0x1A16130 Offset: 0x1A12130 VA: 0x1A16130
	public static bool IsUnsignedInt(Type type) { }

	[Extension]
	// RVA: 0x1A161F0 Offset: 0x1A121F0 VA: 0x1A161F0
	public static bool IsIntegerOrBool(Type type) { }

	[Extension]
	// RVA: 0x1A162B0 Offset: 0x1A122B0 VA: 0x1A162B0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x1A16330 Offset: 0x1A12330 VA: 0x1A16330
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Extension]
	// RVA: 0x1A16700 Offset: 0x1A12700 VA: 0x1A16700
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A169C4 Offset: 0x1A129C4 VA: 0x1A169C4
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A16E78 Offset: 0x1A12E78 VA: 0x1A16E78
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	// RVA: 0x1A1715C Offset: 0x1A1315C VA: 0x1A1715C
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	// RVA: 0x1A1731C Offset: 0x1A1331C VA: 0x1A1731C
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	// RVA: 0x1A17508 Offset: 0x1A13508 VA: 0x1A17508
	private static bool IsCovariant(Type t) { }

	// RVA: 0x1A17530 Offset: 0x1A13530 VA: 0x1A17530
	private static bool IsContravariant(Type t) { }

	// RVA: 0x1A17558 Offset: 0x1A13558 VA: 0x1A17558
	private static bool IsInvariant(Type t) { }

	// RVA: 0x1A17584 Offset: 0x1A13584 VA: 0x1A17584
	private static bool IsDelegate(Type t) { }

	// RVA: 0x1A16B8C Offset: 0x1A12B8C VA: 0x1A16B8C
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Extension]
	// RVA: 0x1A1690C Offset: 0x1A1290C VA: 0x1A1690C
	public static bool IsConvertible(Type type) { }

	// RVA: 0x1A17608 Offset: 0x1A13608 VA: 0x1A17608
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x1A176E8 Offset: 0x1A136E8 VA: 0x1A176E8
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Extension]
	// RVA: 0x1A178AC Offset: 0x1A138AC VA: 0x1A178AC
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x1A17CE0 Offset: 0x1A13CE0 VA: 0x1A17CE0
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x1A17EF8 Offset: 0x1A13EF8 VA: 0x1A17EF8
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x1A179B8 Offset: 0x1A139B8 VA: 0x1A179B8
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x1A174E0 Offset: 0x1A134E0 VA: 0x1A174E0
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x1A17B28 Offset: 0x1A13B28 VA: 0x1A17B28
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x1A17C38 Offset: 0x1A13C38 VA: 0x1A17C38
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x1A180C4 Offset: 0x1A140C4 VA: 0x1A180C4
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x1A18518 Offset: 0x1A14518 VA: 0x1A18518
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Extension]
	// RVA: 0x1A1868C Offset: 0x1A1468C VA: 0x1A1868C
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x1A130D4 Offset: 0x1A0F0D4 VA: 0x1A130D4
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x1A14C0C Offset: 0x1A10C0C VA: 0x1A14C0C
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x1A14E00 Offset: 0x1A10E00 VA: 0x1A14E00
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x1A186CC Offset: 0x1A146CC VA: 0x1A186CC
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x1A14B20 Offset: 0x1A10B20 VA: 0x1A14B20
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x1A18738 Offset: 0x1A14738 VA: 0x1A18738
	public static bool ValidateType(Type type, string paramName, int index) { }

	[Extension]
	// RVA: 0x1A1882C Offset: 0x1A1482C VA: 0x1A1882C
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	// RVA: 0x1A18884 Offset: 0x1A14884 VA: 0x1A18884
	private static void .cctor() { }
}
