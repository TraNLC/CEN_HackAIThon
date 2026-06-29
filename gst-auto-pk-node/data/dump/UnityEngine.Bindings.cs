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

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal struct Unmarshal // TypeDefIndex: 6910
{
	// Methods

	// RVA: -1 Offset: -1
	public static T UnmarshalUnityObject<T>(IntPtr gcHandlePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C00C Offset: 0x103800C VA: 0x103C00C
	|-Unmarshal.UnmarshalUnityObject<object>
	*/

	// RVA: 0x1E7C238 Offset: 0x1E78238 VA: 0x1E7C238
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class ThrowHelper // TypeDefIndex: 6911
{
	// Methods

	[DoesNotReturn]
	// RVA: 0x1E69F48 Offset: 0x1E65F48 VA: 0x1E69F48
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	[DoesNotReturn]
	// RVA: 0x1E6A84C Offset: 0x1E6684C VA: 0x1E6A84C
	public static void ThrowNullReferenceException(object obj) { }
}

// Namespace: 
private struct BindingsAllocator.NativeOwnedMemory // TypeDefIndex: 6912
{
	// Fields
	public void* data; // 0x0
}

// Namespace: UnityEngine.Bindings
[StaticAccessor("Marshalling::BindingsAllocator", 2)]
[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
[VisibleToOtherModules]
internal static class BindingsAllocator // TypeDefIndex: 6913
{
	// Methods

	[ThreadSafe]
	// RVA: 0x1E7C274 Offset: 0x1E78274 VA: 0x1E7C274
	public static void Free(void* ptr) { }

	[ThreadSafe]
	// RVA: 0x1E7C2B0 Offset: 0x1E782B0 VA: 0x1E7C2B0
	public static void FreeNativeOwnedMemory(void* ptr) { }

	// RVA: 0x1E7C2EC Offset: 0x1E782EC VA: 0x1E7C2EC
	public static void* GetNativeOwnedDataPointer(void* ptr) { }
}

// Namespace: 
internal enum BlittableArrayWrapper.UpdateFlags // TypeDefIndex: 6914
{
	// Fields
	public int value__; // 0x0
	public const BlittableArrayWrapper.UpdateFlags NoUpdateNeeded = 0;
	public const BlittableArrayWrapper.UpdateFlags SizeChanged = 1;
	public const BlittableArrayWrapper.UpdateFlags DataIsNativePointer = 2;
	public const BlittableArrayWrapper.UpdateFlags DataIsNativeOwnedMemory = 3;
	public const BlittableArrayWrapper.UpdateFlags DataIsEmpty = 4;
	public const BlittableArrayWrapper.UpdateFlags DataIsNull = 5;
}

// Namespace: UnityEngine.Bindings
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[VisibleToOtherModules]
internal struct BlittableArrayWrapper // TypeDefIndex: 6915
{
	// Fields
	internal void* data; // 0x0
	internal int size; // 0x8
	internal BlittableArrayWrapper.UpdateFlags updateFlags; // 0xC

	// Methods

	// RVA: 0x1E7C300 Offset: 0x1E78300 VA: 0x1E7C300
	public void .ctor(void* data, int size) { }

	// RVA: -1 Offset: -1
	internal void Unmarshal<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED0E0 Offset: 0x10E90E0 VA: 0x10ED0E0
	|-BlittableArrayWrapper.Unmarshal<bool>
	|
	|-RVA: 0x10ED270 Offset: 0x10E9270 VA: 0x10ED270
	|-BlittableArrayWrapper.Unmarshal<byte>
	|
	|-RVA: 0x10ED400 Offset: 0x10E9400 VA: 0x10ED400
	|-BlittableArrayWrapper.Unmarshal<GlyphMarshallingStruct>
	|
	|-RVA: 0x10ED590 Offset: 0x10E9590 VA: 0x10ED590
	|-BlittableArrayWrapper.Unmarshal<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x10ED720 Offset: 0x10E9720 VA: 0x10ED720
	|-BlittableArrayWrapper.Unmarshal<GlyphRect>
	|
	|-RVA: 0x10ED8B0 Offset: 0x10E98B0 VA: 0x10ED8B0
	|-BlittableArrayWrapper.Unmarshal<int>
	|
	|-RVA: 0x10EDA40 Offset: 0x10E9A40 VA: 0x10EDA40
	|-BlittableArrayWrapper.Unmarshal<IntPtr>
	|
	|-RVA: 0x10EDBD0 Offset: 0x10E9BD0 VA: 0x10EDBD0
	|-BlittableArrayWrapper.Unmarshal<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x10EDD60 Offset: 0x10E9D60 VA: 0x10EDD60
	|-BlittableArrayWrapper.Unmarshal<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x10EDEF0 Offset: 0x10E9EF0 VA: 0x10EDEF0
	|-BlittableArrayWrapper.Unmarshal<RaycastHit2D>
	|
	|-RVA: 0x10EE080 Offset: 0x10EA080 VA: 0x10EE080
	|-BlittableArrayWrapper.Unmarshal<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct BlittableListWrapper // TypeDefIndex: 6916
{
	// Fields
	private BlittableArrayWrapper arrayWrapper; // 0x0
	private int listSize; // 0x10

	// Methods

	// RVA: 0x1E7C30C Offset: 0x1E7830C VA: 0x1E7C30C
	public void .ctor(BlittableArrayWrapper arrayWrapper, int listSize) { }

	// RVA: -1 Offset: -1
	internal void Unmarshal<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE2D4 Offset: 0x10EA2D4 VA: 0x10EE2D4
	|-BlittableListWrapper.Unmarshal<RaycastHit2D>
	|
	|-RVA: 0x10EE484 Offset: 0x10EA484 VA: 0x10EE484
	|-BlittableListWrapper.Unmarshal<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class ExceptionMarshaller // TypeDefIndex: 6917
{
	// Fields
	[ThreadStatic]
	private static Exception s_pendingException; // 0x80000000

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E7C318 Offset: 0x1E78318 VA: 0x1E7C318
	private static void SetPendingException(Exception ex) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
[IsReadOnly]
internal struct ManagedSpanWrapper // TypeDefIndex: 6918
{
	// Fields
	public readonly void* begin; // 0x0
	public readonly int length; // 0x8

	// Methods

	// RVA: 0x1E6980C Offset: 0x1E6580C VA: 0x1E6980C
	public void .ctor(void* begin, int length) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal static class StringMarshaller // TypeDefIndex: 6919
{
	// Methods

	// RVA: 0x1E7C370 Offset: 0x1E78370 VA: 0x1E7C370
	public static bool TryMarshalEmptyOrNullString(string s, ref ManagedSpanWrapper managedSpanWrapper) { }
}

// Namespace: UnityEngine.Bindings
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[VisibleToOtherModules]
[IsByRefLike]
internal struct OutStringMarshaller // TypeDefIndex: 6920
{
	// Methods

	// RVA: 0x1E7C3C8 Offset: 0x1E783C8 VA: 0x1E7C3C8
	public static string GetStringAndDispose(ManagedSpanWrapper managedSpan) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(5628, Inherited = False)]
internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 8072
{
	// Methods

	// RVA: 0x1E9D6B8 Offset: 0x1E996B8 VA: 0x1E9D6B8
	public void .ctor() { }

	// RVA: 0x1E9D6C0 Offset: 0x1E996C0 VA: 0x1E9D6C0
	public void .ctor(string[] modules) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(204)]
internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 8073
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Condition>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x18

	// Properties
	public string Condition { set; }
	public bool Enabled { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9D6C8 Offset: 0x1E996C8 VA: 0x1E9D6C8
	public void set_Condition(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D6D0 Offset: 0x1E996D0 VA: 0x1E9D6D0
	public void set_Enabled(bool value) { }

	// RVA: 0x1E9D6D8 Offset: 0x1E996D8 VA: 0x1E9D6D8
	public void .ctor(string condition) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(10716, AllowMultiple = True)]
internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 8074
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10

	// Properties
	public string Header { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9D714 Offset: 0x1E99714 VA: 0x1E9D714 Slot: 7
	public void set_Header(string value) { }

	// RVA: 0x1E9D71C Offset: 0x1E9971C VA: 0x1E9D71C
	public void .ctor(string header) { }
}

// Namespace: UnityEngine.Bindings
[Usage(448)]
[VisibleToOtherModules]
internal class NativeNameAttribute : Attribute // TypeDefIndex: 8075
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9D820 Offset: 0x1E99820 VA: 0x1E9D820 Slot: 7
	public void set_Name(string value) { }

	// RVA: 0x1E9D828 Offset: 0x1E99828 VA: 0x1E9D828
	public void .ctor(string name) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(192)]
internal class NativeMethodAttribute : Attribute // TypeDefIndex: 8076
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9D92C Offset: 0x1E9992C VA: 0x1E9D92C Slot: 7
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D934 Offset: 0x1E99934 VA: 0x1E9D934 Slot: 8
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D93C Offset: 0x1E9993C VA: 0x1E9D93C Slot: 9
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D944 Offset: 0x1E99944 VA: 0x1E9D944 Slot: 10
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D94C Offset: 0x1E9994C VA: 0x1E9D94C Slot: 11
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x1E9D954 Offset: 0x1E99954 VA: 0x1E9D954
	public void .ctor() { }

	// RVA: 0x1E9D95C Offset: 0x1E9995C VA: 0x1E9D95C
	public void .ctor(string name) { }

	// RVA: 0x1E9DA60 Offset: 0x1E99A60 VA: 0x1E9DA60
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x1E9DA84 Offset: 0x1E99A84 VA: 0x1E9DA84
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum TargetType // TypeDefIndex: 8077
{
	// Fields
	public int value__; // 0x0
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
[Usage(128)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 8078
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TargetType <TargetType>k__BackingField; // 0x1C

	// Properties
	public TargetType TargetType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9DAB0 Offset: 0x1E99AB0 VA: 0x1E9DAB0
	public void set_TargetType(TargetType value) { }

	// RVA: 0x1E9DAB8 Offset: 0x1E99AB8 VA: 0x1E9DAB8
	public void .ctor() { }

	// RVA: 0x1E9DAC0 Offset: 0x1E99AC0 VA: 0x1E9DAC0
	public void .ctor(string name) { }

	// RVA: 0x1E9DAC4 Offset: 0x1E99AC4 VA: 0x1E9DAC4
	public void .ctor(string name, bool isFree, TargetType targetType) { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum CodegenOptions // TypeDefIndex: 8079
{
	// Fields
	public int value__; // 0x0
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4)]
internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 8080
{
	// Methods

	// RVA: 0x1E9DAF0 Offset: 0x1E99AF0 VA: 0x1E9DAF0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(28)]
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 8081
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9DAF8 Offset: 0x1E99AF8 VA: 0x1E9DAF8 Slot: 7
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9DB00 Offset: 0x1E99B00 VA: 0x1E9DB00
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9DB08 Offset: 0x1E99B08 VA: 0x1E9DB08 Slot: 8
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x1E9DB10 Offset: 0x1E99B10 VA: 0x1E9DB10
	public void .ctor() { }

	// RVA: 0x1E9DB2C Offset: 0x1E99B2C VA: 0x1E9DB2C
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x1E9DB54 Offset: 0x1E99B54 VA: 0x1E9DB54
	public void .ctor(string header) { }

	// RVA: 0x1E9DC5C Offset: 0x1E99C5C VA: 0x1E9DC5C
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

// Namespace: UnityEngine.Bindings
[Usage(2048)]
[VisibleToOtherModules]
internal class NotNullAttribute : Attribute // TypeDefIndex: 8082
{
	// Methods

	// RVA: 0x1E9DC94 Offset: 0x1E99C94 VA: 0x1E9DC94
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(10240)]
[VisibleToOtherModules]
internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 8083
{
	// Methods

	// RVA: 0x1E9DC9C Offset: 0x1E99C9C VA: 0x1E9DC9C
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 8084
{
	// Methods

	// RVA: 0x1E9DCA4 Offset: 0x1E99CA4 VA: 0x1E9DCA4
	public void .ctor() { }

	// RVA: 0x1E9DCC4 Offset: 0x1E99CC4 VA: 0x1E9DCC4
	public void .ctor(string name) { }

	// RVA: 0x1E9DCE0 Offset: 0x1E99CE0 VA: 0x1E9DCE0
	public void .ctor(string name, bool isThreadSafe) { }
}

// Namespace: UnityEngine.Bindings
[Usage(64)]
[VisibleToOtherModules]
internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 8085
{
	// Methods

	// RVA: 0x1E9DD0C Offset: 0x1E99D0C VA: 0x1E9DD0C
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
internal enum StaticAccessorType // TypeDefIndex: 8086
{
	// Fields
	public int value__; // 0x0
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
[Usage(204)]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 8087
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9DD2C Offset: 0x1E99D2C VA: 0x1E9DD2C
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9DD34 Offset: 0x1E99D34 VA: 0x1E9DD34
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x1E9DD3C Offset: 0x1E99D3C VA: 0x1E9DD3C
	internal void .ctor(string name) { }

	// RVA: 0x1E9DD6C Offset: 0x1E99D6C VA: 0x1E9DD6C
	public void .ctor(string name, StaticAccessorType type) { }
}

// Namespace: UnityEngine.Bindings
[Usage(192)]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 8088
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <ThrowsException>k__BackingField; // 0x10

	// Properties
	public bool ThrowsException { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9DDA8 Offset: 0x1E99DA8 VA: 0x1E9DDA8 Slot: 7
	public void set_ThrowsException(bool value) { }

	// RVA: 0x1E9DDB0 Offset: 0x1E99DB0 VA: 0x1E9DDB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(256)]
internal class IgnoreAttribute : Attribute // TypeDefIndex: 8089
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Properties
	public bool DoesNotContributeToSize { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9DDD0 Offset: 0x1E99DD0 VA: 0x1E9DDD0
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x1E9DDD8 Offset: 0x1E99DD8 VA: 0x1E9DDD8
	public void .ctor() { }
}

// Namespace: UnityEngine.Bindings
[VisibleToOtherModules]
[Usage(4, AllowMultiple = False, Inherited = False)]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 8090
{
	// Methods

	// RVA: 0x1E9DDE0 Offset: 0x1E99DE0 VA: 0x1E9DDE0
	public void .ctor() { }
}
