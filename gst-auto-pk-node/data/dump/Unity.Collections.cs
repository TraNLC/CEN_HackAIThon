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

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(10496)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 6620
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(10496)]
public sealed class WriteOnlyAttribute : Attribute // TypeDefIndex: 6621
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class DeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 6622
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeFixedLengthAttribute : Attribute // TypeDefIndex: 6623
{}

// Namespace: Unity.Collections
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeMatchesParallelForLengthAttribute : Attribute // TypeDefIndex: 6624
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableParallelForRestrictionAttribute : Attribute // TypeDefIndex: 6625
{}

// Namespace: Unity.Collections
[UsedByNativeCode]
public enum Allocator // TypeDefIndex: 6626
{
	// Fields
	public int value__; // 0x0
	public const Allocator Invalid = 0;
	public const Allocator None = 1;
	public const Allocator Temp = 2;
	public const Allocator TempJob = 3;
	public const Allocator Persistent = 4;
	public const Allocator AudioKernel = 5;
	public const Allocator Domain = 6;
	public const Allocator FirstUserIndex = 64;
}

// Namespace: Unity.Collections
public enum NativeArrayOptions // TypeDefIndex: 6627
{
	// Fields
	public int value__; // 0x0
	public const NativeArrayOptions UninitializedMemory = 0;
	public const NativeArrayOptions ClearMemory = 1;
}

// Namespace: 
[ExcludeFromDocs]
public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 6628
{
	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E995C Offset: 0x11E595C VA: 0x11E995C
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x11E9CA4 Offset: 0x11E5CA4 VA: 0x11E9CA4
	|-NativeArray.Enumerator<bool>..ctor
	|
	|-RVA: 0x11E9DA4 Offset: 0x11E5DA4 VA: 0x11E9DA4
	|-NativeArray.Enumerator<Bounds>..ctor
	|
	|-RVA: 0x11EA2D4 Offset: 0x11E62D4 VA: 0x11EA2D4
	|-NativeArray.Enumerator<byte>..ctor
	|
	|-RVA: 0x11EAC80 Offset: 0x11E6C80 VA: 0x11EAC80
	|-NativeArray.Enumerator<CullingSplit>..ctor
	|
	|-RVA: 0x11EB9E4 Offset: 0x11E79E4 VA: 0x11EB9E4
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>..ctor
	|
	|-RVA: 0x11EBAE0 Offset: 0x11E7AE0 VA: 0x11EBAE0
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>..ctor
	|
	|-RVA: 0x11EBBDC Offset: 0x11E7BDC VA: 0x11EBBDC
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>..ctor
	|
	|-RVA: 0x11EC2F4 Offset: 0x11E82F4 VA: 0x11EC2F4
	|-NativeArray.Enumerator<short>..ctor
	|
	|-RVA: 0x11EC85C Offset: 0x11E885C VA: 0x11EC85C
	|-NativeArray.Enumerator<int>..ctor
	|
	|-RVA: 0x11ECDFC Offset: 0x11E8DFC VA: 0x11ECDFC
	|-NativeArray.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x11ED2D0 Offset: 0x11E92D0 VA: 0x11ED2D0
	|-NativeArray.Enumerator<IntPtr>..ctor
	|
	|-RVA: 0x11EDC18 Offset: 0x11E9C18 VA: 0x11EDC18
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|
	|-RVA: 0x11EE5F4 Offset: 0x11EA5F4 VA: 0x11EE5F4
	|-NativeArray.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x11EFB80 Offset: 0x11EBB80 VA: 0x11EFB80
	|-NativeArray.Enumerator<Plane>..ctor
	|
	|-RVA: 0x11EFC94 Offset: 0x11EBC94 VA: 0x11EFC94
	|-NativeArray.Enumerator<Quaternion>..ctor
	|
	|-RVA: 0x11F0620 Offset: 0x11EC620 VA: 0x11F0620
	|-NativeArray.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x11F0908 Offset: 0x11EC908 VA: 0x11F0908
	|-NativeArray.Enumerator<float>..ctor
	|
	|-RVA: 0x11F0A04 Offset: 0x11ECA04 VA: 0x11F0A04
	|-NativeArray.Enumerator<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x11F1A00 Offset: 0x11EDA00 VA: 0x11F1A00
	|-NativeArray.Enumerator<uint>..ctor
	|
	|-RVA: 0x11F22D4 Offset: 0x11EE2D4 VA: 0x11F22D4
	|-NativeArray.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x11F25F8 Offset: 0x11EE5F8 VA: 0x11F25F8
	|-NativeArray.Enumerator<Vector4>..ctor
	|
	|-RVA: 0x11F2B1C Offset: 0x11EEB1C VA: 0x11F2B1C
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E998C Offset: 0x11E598C VA: 0x11E998C
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Dispose
	|
	|-RVA: 0x11E9CBC Offset: 0x11E5CBC VA: 0x11E9CBC
	|-NativeArray.Enumerator<bool>.Dispose
	|
	|-RVA: 0x11E9DC4 Offset: 0x11E5DC4 VA: 0x11E9DC4
	|-NativeArray.Enumerator<Bounds>.Dispose
	|
	|-RVA: 0x11EA2EC Offset: 0x11E62EC VA: 0x11EA2EC
	|-NativeArray.Enumerator<byte>.Dispose
	|
	|-RVA: 0x11EACB0 Offset: 0x11E6CB0 VA: 0x11EACB0
	|-NativeArray.Enumerator<CullingSplit>.Dispose
	|
	|-RVA: 0x11EB9F8 Offset: 0x11E79F8 VA: 0x11EB9F8
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>.Dispose
	|
	|-RVA: 0x11EBAF4 Offset: 0x11E7AF4 VA: 0x11EBAF4
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>.Dispose
	|
	|-RVA: 0x11EBBF4 Offset: 0x11E7BF4 VA: 0x11EBBF4
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>.Dispose
	|
	|-RVA: 0x11EC30C Offset: 0x11E830C VA: 0x11EC30C
	|-NativeArray.Enumerator<short>.Dispose
	|
	|-RVA: 0x11EC870 Offset: 0x11E8870 VA: 0x11EC870
	|-NativeArray.Enumerator<int>.Dispose
	|
	|-RVA: 0x11ECE10 Offset: 0x11E8E10 VA: 0x11ECE10
	|-NativeArray.Enumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x11ED2E8 Offset: 0x11E92E8 VA: 0x11ED2E8
	|-NativeArray.Enumerator<IntPtr>.Dispose
	|
	|-RVA: 0x11EDC48 Offset: 0x11E9C48 VA: 0x11EDC48
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x11EE61C Offset: 0x11EA61C VA: 0x11EE61C
	|-NativeArray.Enumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x11EFB9C Offset: 0x11EBB9C VA: 0x11EFB9C
	|-NativeArray.Enumerator<Plane>.Dispose
	|
	|-RVA: 0x11EFCB0 Offset: 0x11EBCB0 VA: 0x11EFCB0
	|-NativeArray.Enumerator<Quaternion>.Dispose
	|
	|-RVA: 0x11F0638 Offset: 0x11EC638 VA: 0x11F0638
	|-NativeArray.Enumerator<sbyte>.Dispose
	|
	|-RVA: 0x11F091C Offset: 0x11EC91C VA: 0x11F091C
	|-NativeArray.Enumerator<float>.Dispose
	|
	|-RVA: 0x11F0A28 Offset: 0x11ECA28 VA: 0x11F0A28
	|-NativeArray.Enumerator<SubMeshDescriptor>.Dispose
	|
	|-RVA: 0x11F1A14 Offset: 0x11EDA14 VA: 0x11F1A14
	|-NativeArray.Enumerator<uint>.Dispose
	|
	|-RVA: 0x11F22F0 Offset: 0x11EE2F0 VA: 0x11F22F0
	|-NativeArray.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x11F2614 Offset: 0x11EE614 VA: 0x11F2614
	|-NativeArray.Enumerator<Vector4>.Dispose
	|
	|-RVA: 0x11F2C10 Offset: 0x11EEC10 VA: 0x11F2C10
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9990 Offset: 0x11E5990 VA: 0x11E9990
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.MoveNext
	|
	|-RVA: 0x11E9CC0 Offset: 0x11E5CC0 VA: 0x11E9CC0
	|-NativeArray.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x11E9DC8 Offset: 0x11E5DC8 VA: 0x11E9DC8
	|-NativeArray.Enumerator<Bounds>.MoveNext
	|
	|-RVA: 0x11EA2F0 Offset: 0x11E62F0 VA: 0x11EA2F0
	|-NativeArray.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x11EACB4 Offset: 0x11E6CB4 VA: 0x11EACB4
	|-NativeArray.Enumerator<CullingSplit>.MoveNext
	|
	|-RVA: 0x11EB9FC Offset: 0x11E79FC VA: 0x11EB9FC
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>.MoveNext
	|
	|-RVA: 0x11EBAF8 Offset: 0x11E7AF8 VA: 0x11EBAF8
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>.MoveNext
	|
	|-RVA: 0x11EBBF8 Offset: 0x11E7BF8 VA: 0x11EBBF8
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>.MoveNext
	|
	|-RVA: 0x11EC310 Offset: 0x11E8310 VA: 0x11EC310
	|-NativeArray.Enumerator<short>.MoveNext
	|
	|-RVA: 0x11EC874 Offset: 0x11E8874 VA: 0x11EC874
	|-NativeArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x11ECE14 Offset: 0x11E8E14 VA: 0x11ECE14
	|-NativeArray.Enumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x11ED2EC Offset: 0x11E92EC VA: 0x11ED2EC
	|-NativeArray.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x11EDC4C Offset: 0x11E9C4C VA: 0x11EDC4C
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x11EE620 Offset: 0x11EA620 VA: 0x11EE620
	|-NativeArray.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x11EFBA0 Offset: 0x11EBBA0 VA: 0x11EFBA0
	|-NativeArray.Enumerator<Plane>.MoveNext
	|
	|-RVA: 0x11EFCB4 Offset: 0x11EBCB4 VA: 0x11EFCB4
	|-NativeArray.Enumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x11F063C Offset: 0x11EC63C VA: 0x11F063C
	|-NativeArray.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x11F0920 Offset: 0x11EC920 VA: 0x11F0920
	|-NativeArray.Enumerator<float>.MoveNext
	|
	|-RVA: 0x11F0A2C Offset: 0x11ECA2C VA: 0x11F0A2C
	|-NativeArray.Enumerator<SubMeshDescriptor>.MoveNext
	|
	|-RVA: 0x11F1A18 Offset: 0x11EDA18 VA: 0x11F1A18
	|-NativeArray.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x11F22F4 Offset: 0x11EE2F4 VA: 0x11F22F4
	|-NativeArray.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x11F2618 Offset: 0x11EE618 VA: 0x11F2618
	|-NativeArray.Enumerator<Vector4>.MoveNext
	|
	|-RVA: 0x11F2C14 Offset: 0x11EEC14 VA: 0x11F2C14
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9A1C Offset: 0x11E5A1C VA: 0x11E9A1C
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Reset
	|
	|-RVA: 0x11E9D28 Offset: 0x11E5D28 VA: 0x11E9D28
	|-NativeArray.Enumerator<bool>.Reset
	|
	|-RVA: 0x11E9E48 Offset: 0x11E5E48 VA: 0x11E9E48
	|-NativeArray.Enumerator<Bounds>.Reset
	|
	|-RVA: 0x11EA358 Offset: 0x11E6358 VA: 0x11EA358
	|-NativeArray.Enumerator<byte>.Reset
	|
	|-RVA: 0x11EAD40 Offset: 0x11E6D40 VA: 0x11EAD40
	|-NativeArray.Enumerator<CullingSplit>.Reset
	|
	|-RVA: 0x11EBA64 Offset: 0x11E7A64 VA: 0x11EBA64
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>.Reset
	|
	|-RVA: 0x11EBB60 Offset: 0x11E7B60 VA: 0x11EBB60
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>.Reset
	|
	|-RVA: 0x11EBC60 Offset: 0x11E7C60 VA: 0x11EBC60
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>.Reset
	|
	|-RVA: 0x11EC378 Offset: 0x11E8378 VA: 0x11EC378
	|-NativeArray.Enumerator<short>.Reset
	|
	|-RVA: 0x11EC8DC Offset: 0x11E88DC VA: 0x11EC8DC
	|-NativeArray.Enumerator<int>.Reset
	|
	|-RVA: 0x11ECE7C Offset: 0x11E8E7C VA: 0x11ECE7C
	|-NativeArray.Enumerator<Int32Enum>.Reset
	|
	|-RVA: 0x11ED354 Offset: 0x11E9354 VA: 0x11ED354
	|-NativeArray.Enumerator<IntPtr>.Reset
	|
	|-RVA: 0x11EDCD8 Offset: 0x11E9CD8 VA: 0x11EDCD8
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|
	|-RVA: 0x11EE6B0 Offset: 0x11EA6B0 VA: 0x11EE6B0
	|-NativeArray.Enumerator<Matrix4x4>.Reset
	|
	|-RVA: 0x11EFC0C Offset: 0x11EBC0C VA: 0x11EFC0C
	|-NativeArray.Enumerator<Plane>.Reset
	|
	|-RVA: 0x11EFD20 Offset: 0x11EBD20 VA: 0x11EFD20
	|-NativeArray.Enumerator<Quaternion>.Reset
	|
	|-RVA: 0x11F06A4 Offset: 0x11EC6A4 VA: 0x11F06A4
	|-NativeArray.Enumerator<sbyte>.Reset
	|
	|-RVA: 0x11F0988 Offset: 0x11EC988 VA: 0x11F0988
	|-NativeArray.Enumerator<float>.Reset
	|
	|-RVA: 0x11F0AB4 Offset: 0x11ECAB4 VA: 0x11F0AB4
	|-NativeArray.Enumerator<SubMeshDescriptor>.Reset
	|
	|-RVA: 0x11F1A80 Offset: 0x11EDA80 VA: 0x11F1A80
	|-NativeArray.Enumerator<uint>.Reset
	|
	|-RVA: 0x11F2370 Offset: 0x11EE370 VA: 0x11F2370
	|-NativeArray.Enumerator<Vector3>.Reset
	|
	|-RVA: 0x11F2684 Offset: 0x11EE684 VA: 0x11F2684
	|-NativeArray.Enumerator<Vector4>.Reset
	|
	|-RVA: 0x11F2ED8 Offset: 0x11EEED8 VA: 0x11F2ED8
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9A28 Offset: 0x11E5A28 VA: 0x11E9A28
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.get_Current
	|
	|-RVA: 0x11E9D34 Offset: 0x11E5D34 VA: 0x11E9D34
	|-NativeArray.Enumerator<bool>.get_Current
	|
	|-RVA: 0x11E9E54 Offset: 0x11E5E54 VA: 0x11E9E54
	|-NativeArray.Enumerator<Bounds>.get_Current
	|
	|-RVA: 0x11EA364 Offset: 0x11E6364 VA: 0x11EA364
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x11EAD4C Offset: 0x11E6D4C VA: 0x11EAD4C
	|-NativeArray.Enumerator<CullingSplit>.get_Current
	|
	|-RVA: 0x11EBA70 Offset: 0x11E7A70 VA: 0x11EBA70
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>.get_Current
	|
	|-RVA: 0x11EBB6C Offset: 0x11E7B6C VA: 0x11EBB6C
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>.get_Current
	|
	|-RVA: 0x11EBC6C Offset: 0x11E7C6C VA: 0x11EBC6C
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>.get_Current
	|
	|-RVA: 0x11EC384 Offset: 0x11E8384 VA: 0x11EC384
	|-NativeArray.Enumerator<short>.get_Current
	|
	|-RVA: 0x11EC8E8 Offset: 0x11E88E8 VA: 0x11EC8E8
	|-NativeArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x11ECE88 Offset: 0x11E8E88 VA: 0x11ECE88
	|-NativeArray.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x11ED360 Offset: 0x11E9360 VA: 0x11ED360
	|-NativeArray.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x11EDCE4 Offset: 0x11E9CE4 VA: 0x11EDCE4
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x11EE6BC Offset: 0x11EA6BC VA: 0x11EE6BC
	|-NativeArray.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x11EFC18 Offset: 0x11EBC18 VA: 0x11EFC18
	|-NativeArray.Enumerator<Plane>.get_Current
	|
	|-RVA: 0x11EFD2C Offset: 0x11EBD2C VA: 0x11EFD2C
	|-NativeArray.Enumerator<Quaternion>.get_Current
	|
	|-RVA: 0x11F06B0 Offset: 0x11EC6B0 VA: 0x11F06B0
	|-NativeArray.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x11F0994 Offset: 0x11EC994 VA: 0x11F0994
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x11F0AC0 Offset: 0x11ECAC0 VA: 0x11F0AC0
	|-NativeArray.Enumerator<SubMeshDescriptor>.get_Current
	|
	|-RVA: 0x11F1A8C Offset: 0x11EDA8C VA: 0x11F1A8C
	|-NativeArray.Enumerator<uint>.get_Current
	|
	|-RVA: 0x11F237C Offset: 0x11EE37C VA: 0x11F237C
	|-NativeArray.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x11F2690 Offset: 0x11EE690 VA: 0x11F2690
	|-NativeArray.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x11F2F1C Offset: 0x11EEF1C VA: 0x11F2F1C
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E9A38 Offset: 0x11E5A38 VA: 0x11E9A38
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E9D3C Offset: 0x11E5D3C VA: 0x11E9D3C
	|-NativeArray.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E9E68 Offset: 0x11E5E68 VA: 0x11E9E68
	|-NativeArray.Enumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EA36C Offset: 0x11E636C VA: 0x11EA36C
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EAD5C Offset: 0x11E6D5C VA: 0x11EAD5C
	|-NativeArray.Enumerator<CullingSplit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EBA78 Offset: 0x11E7A78 VA: 0x11EBA78
	|-NativeArray.Enumerator<GPUDrivenPackedMaterialData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EBB74 Offset: 0x11E7B74 VA: 0x11EBB74
	|-NativeArray.Enumerator<GPUDrivenPackedRendererData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EBC74 Offset: 0x11E7C74 VA: 0x11EBC74
	|-NativeArray.Enumerator<GPUDrivenRendererEditorData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EC38C Offset: 0x11E838C VA: 0x11EC38C
	|-NativeArray.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EC8F0 Offset: 0x11E88F0 VA: 0x11EC8F0
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11ECE90 Offset: 0x11E8E90 VA: 0x11ECE90
	|-NativeArray.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11ED368 Offset: 0x11E9368 VA: 0x11ED368
	|-NativeArray.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EDCF4 Offset: 0x11E9CF4 VA: 0x11EDCF4
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EE6D8 Offset: 0x11EA6D8 VA: 0x11EE6D8
	|-NativeArray.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EFC24 Offset: 0x11EBC24 VA: 0x11EFC24
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EFD38 Offset: 0x11EBD38 VA: 0x11EFD38
	|-NativeArray.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F06B8 Offset: 0x11EC6B8 VA: 0x11F06B8
	|-NativeArray.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F099C Offset: 0x11EC99C VA: 0x11F099C
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F0AD8 Offset: 0x11ECAD8 VA: 0x11F0AD8
	|-NativeArray.Enumerator<SubMeshDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F1A94 Offset: 0x11EDA94 VA: 0x11F1A94
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F2388 Offset: 0x11EE388 VA: 0x11F2388
	|-NativeArray.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F269C Offset: 0x11EE69C VA: 0x11F269C
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F2FA8 Offset: 0x11EEFA8 VA: 0x11F2FA8
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Unity.Collections
[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView<T>))]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
[DefaultMember("Item")]
[NativeContainerSupportsDeferredConvertListToArray]
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 6629
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	[VisibleToOtherModules(new[] { "UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule" })]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1CAC Offset: 0x13CDCAC VA: 0x13D1CAC
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x13D2244 Offset: 0x13CE244 VA: 0x13D2244
	|-NativeArray<bool>..ctor
	|
	|-RVA: 0x13D2758 Offset: 0x13CE758 VA: 0x13D2758
	|-NativeArray<Bounds>..ctor
	|
	|-RVA: 0x13D2CB8 Offset: 0x13CECB8 VA: 0x13D2CB8
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x13D31C8 Offset: 0x13CF1C8 VA: 0x13D31C8
	|-NativeArray<CullingSplit>..ctor
	|
	|-RVA: 0x13D3760 Offset: 0x13CF760 VA: 0x13D3760
	|-NativeArray<GPUDrivenPackedMaterialData>..ctor
	|
	|-RVA: 0x13D3C70 Offset: 0x13CFC70 VA: 0x13D3C70
	|-NativeArray<GPUDrivenPackedRendererData>..ctor
	|
	|-RVA: 0x13D4180 Offset: 0x13D0180 VA: 0x13D4180
	|-NativeArray<GPUDrivenRendererEditorData>..ctor
	|
	|-RVA: 0x13D4674 Offset: 0x13D0674 VA: 0x13D4674
	|-NativeArray<short>..ctor
	|
	|-RVA: 0x13D4B84 Offset: 0x13D0B84 VA: 0x13D4B84
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x13D5094 Offset: 0x13D1094 VA: 0x13D5094
	|-NativeArray<Int32Enum>..ctor
	|
	|-RVA: 0x13D55A4 Offset: 0x13D15A4 VA: 0x13D55A4
	|-NativeArray<IntPtr>..ctor
	|
	|-RVA: 0x13D5A98 Offset: 0x13D1A98 VA: 0x13D5A98
	|-NativeArray<LightDataGI>..ctor
	|
	|-RVA: 0x13D6030 Offset: 0x13D2030 VA: 0x13D6030
	|-NativeArray<Matrix4x4>..ctor
	|
	|-RVA: 0x13D65B4 Offset: 0x13D25B4 VA: 0x13D65B4
	|-NativeArray<Plane>..ctor
	|
	|-RVA: 0x13D6B00 Offset: 0x13D2B00 VA: 0x13D6B00
	|-NativeArray<Quaternion>..ctor
	|
	|-RVA: 0x13D704C Offset: 0x13D304C VA: 0x13D704C
	|-NativeArray<sbyte>..ctor
	|
	|-RVA: 0x13D755C Offset: 0x13D355C VA: 0x13D755C
	|-NativeArray<float>..ctor
	|
	|-RVA: 0x13D7A74 Offset: 0x13D3A74 VA: 0x13D7A74
	|-NativeArray<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x13D7FF4 Offset: 0x13D3FF4 VA: 0x13D7FF4
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x13D8504 Offset: 0x13D4504 VA: 0x13D8504
	|-NativeArray<Vector3>..ctor
	|
	|-RVA: 0x13D8A34 Offset: 0x13D4A34 VA: 0x13D8A34
	|-NativeArray<Vector4>..ctor
	|
	|-RVA: 0x13D8F80 Offset: 0x13D4F80 VA: 0x13D8F80
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1D50 Offset: 0x13CDD50 VA: 0x13D1D50
	|-NativeArray<BatchCullingOutputDrawCommands>.Allocate
	|
	|-RVA: 0x13D22E4 Offset: 0x13CE2E4 VA: 0x13D22E4
	|-NativeArray<bool>.Allocate
	|
	|-RVA: 0x13D27FC Offset: 0x13CE7FC VA: 0x13D27FC
	|-NativeArray<Bounds>.Allocate
	|
	|-RVA: 0x13D2D58 Offset: 0x13CED58 VA: 0x13D2D58
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x13D326C Offset: 0x13CF26C VA: 0x13D326C
	|-NativeArray<CullingSplit>.Allocate
	|
	|-RVA: 0x13D3800 Offset: 0x13CF800 VA: 0x13D3800
	|-NativeArray<GPUDrivenPackedMaterialData>.Allocate
	|
	|-RVA: 0x13D3D10 Offset: 0x13CFD10 VA: 0x13D3D10
	|-NativeArray<GPUDrivenPackedRendererData>.Allocate
	|
	|-RVA: 0x13D4220 Offset: 0x13D0220 VA: 0x13D4220
	|-NativeArray<GPUDrivenRendererEditorData>.Allocate
	|
	|-RVA: 0x13D4714 Offset: 0x13D0714 VA: 0x13D4714
	|-NativeArray<short>.Allocate
	|
	|-RVA: 0x13D4C24 Offset: 0x13D0C24 VA: 0x13D4C24
	|-NativeArray<int>.Allocate
	|
	|-RVA: 0x13D5134 Offset: 0x13D1134 VA: 0x13D5134
	|-NativeArray<Int32Enum>.Allocate
	|
	|-RVA: 0x13D5644 Offset: 0x13D1644 VA: 0x13D5644
	|-NativeArray<IntPtr>.Allocate
	|
	|-RVA: 0x13D5B3C Offset: 0x13D1B3C VA: 0x13D5B3C
	|-NativeArray<LightDataGI>.Allocate
	|
	|-RVA: 0x13D60D0 Offset: 0x13D20D0 VA: 0x13D60D0
	|-NativeArray<Matrix4x4>.Allocate
	|
	|-RVA: 0x13D6654 Offset: 0x13D2654 VA: 0x13D6654
	|-NativeArray<Plane>.Allocate
	|
	|-RVA: 0x13D6BA0 Offset: 0x13D2BA0 VA: 0x13D6BA0
	|-NativeArray<Quaternion>.Allocate
	|
	|-RVA: 0x13D70EC Offset: 0x13D30EC VA: 0x13D70EC
	|-NativeArray<sbyte>.Allocate
	|
	|-RVA: 0x13D75FC Offset: 0x13D35FC VA: 0x13D75FC
	|-NativeArray<float>.Allocate
	|
	|-RVA: 0x13D7B18 Offset: 0x13D3B18 VA: 0x13D7B18
	|-NativeArray<SubMeshDescriptor>.Allocate
	|
	|-RVA: 0x13D8094 Offset: 0x13D4094 VA: 0x13D8094
	|-NativeArray<uint>.Allocate
	|
	|-RVA: 0x13D85A8 Offset: 0x13D45A8 VA: 0x13D85A8
	|-NativeArray<Vector3>.Allocate
	|
	|-RVA: 0x13D8AD4 Offset: 0x13D4AD4 VA: 0x13D8AD4
	|-NativeArray<Vector4>.Allocate
	|
	|-RVA: 0x13D90F4 Offset: 0x13D50F4 VA: 0x13D90F4
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1DE0 Offset: 0x13CDDE0 VA: 0x13D1DE0
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Length
	|
	|-RVA: 0x13D2370 Offset: 0x13CE370 VA: 0x13D2370
	|-NativeArray<bool>.get_Length
	|
	|-RVA: 0x13D288C Offset: 0x13CE88C VA: 0x13D288C
	|-NativeArray<Bounds>.get_Length
	|
	|-RVA: 0x13D2DE4 Offset: 0x13CEDE4 VA: 0x13D2DE4
	|-NativeArray<byte>.get_Length
	|
	|-RVA: 0x13D32FC Offset: 0x13CF2FC VA: 0x13D32FC
	|-NativeArray<CullingSplit>.get_Length
	|
	|-RVA: 0x13D388C Offset: 0x13CF88C VA: 0x13D388C
	|-NativeArray<GPUDrivenPackedMaterialData>.get_Length
	|
	|-RVA: 0x13D3D9C Offset: 0x13CFD9C VA: 0x13D3D9C
	|-NativeArray<GPUDrivenPackedRendererData>.get_Length
	|
	|-RVA: 0x13D42AC Offset: 0x13D02AC VA: 0x13D42AC
	|-NativeArray<GPUDrivenRendererEditorData>.get_Length
	|
	|-RVA: 0x13D47A0 Offset: 0x13D07A0 VA: 0x13D47A0
	|-NativeArray<short>.get_Length
	|
	|-RVA: 0x13D4CB0 Offset: 0x13D0CB0 VA: 0x13D4CB0
	|-NativeArray<int>.get_Length
	|
	|-RVA: 0x13D51C0 Offset: 0x13D11C0 VA: 0x13D51C0
	|-NativeArray<Int32Enum>.get_Length
	|
	|-RVA: 0x13D56D0 Offset: 0x13D16D0 VA: 0x13D56D0
	|-NativeArray<IntPtr>.get_Length
	|
	|-RVA: 0x13D5BCC Offset: 0x13D1BCC VA: 0x13D5BCC
	|-NativeArray<LightDataGI>.get_Length
	|
	|-RVA: 0x13D615C Offset: 0x13D215C VA: 0x13D615C
	|-NativeArray<Matrix4x4>.get_Length
	|
	|-RVA: 0x13D66E0 Offset: 0x13D26E0 VA: 0x13D66E0
	|-NativeArray<Plane>.get_Length
	|
	|-RVA: 0x13D6C2C Offset: 0x13D2C2C VA: 0x13D6C2C
	|-NativeArray<Quaternion>.get_Length
	|
	|-RVA: 0x13D7178 Offset: 0x13D3178 VA: 0x13D7178
	|-NativeArray<sbyte>.get_Length
	|
	|-RVA: 0x13D7688 Offset: 0x13D3688 VA: 0x13D7688
	|-NativeArray<float>.get_Length
	|
	|-RVA: 0x13D7BA8 Offset: 0x13D3BA8 VA: 0x13D7BA8
	|-NativeArray<SubMeshDescriptor>.get_Length
	|
	|-RVA: 0x13D8120 Offset: 0x13D4120 VA: 0x13D8120
	|-NativeArray<uint>.get_Length
	|
	|-RVA: 0x13D8638 Offset: 0x13D4638 VA: 0x13D8638
	|-NativeArray<Vector3>.get_Length
	|
	|-RVA: 0x13D8B60 Offset: 0x13D4B60 VA: 0x13D8B60
	|-NativeArray<Vector4>.get_Length
	|
	|-RVA: 0x13D91FC Offset: 0x13D51FC VA: 0x13D91FC
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1DE8 Offset: 0x13CDDE8 VA: 0x13D1DE8
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0x13D2378 Offset: 0x13CE378 VA: 0x13D2378
	|-NativeArray<bool>.get_Item
	|
	|-RVA: 0x13D2894 Offset: 0x13CE894 VA: 0x13D2894
	|-NativeArray<Bounds>.get_Item
	|
	|-RVA: 0x13D2DEC Offset: 0x13CEDEC VA: 0x13D2DEC
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0x13D3304 Offset: 0x13CF304 VA: 0x13D3304
	|-NativeArray<CullingSplit>.get_Item
	|
	|-RVA: 0x13D3894 Offset: 0x13CF894 VA: 0x13D3894
	|-NativeArray<GPUDrivenPackedMaterialData>.get_Item
	|
	|-RVA: 0x13D3DA4 Offset: 0x13CFDA4 VA: 0x13D3DA4
	|-NativeArray<GPUDrivenPackedRendererData>.get_Item
	|
	|-RVA: 0x13D42B4 Offset: 0x13D02B4 VA: 0x13D42B4
	|-NativeArray<GPUDrivenRendererEditorData>.get_Item
	|
	|-RVA: 0x13D47A8 Offset: 0x13D07A8 VA: 0x13D47A8
	|-NativeArray<short>.get_Item
	|
	|-RVA: 0x13D4CB8 Offset: 0x13D0CB8 VA: 0x13D4CB8
	|-NativeArray<int>.get_Item
	|
	|-RVA: 0x13D51C8 Offset: 0x13D11C8 VA: 0x13D51C8
	|-NativeArray<Int32Enum>.get_Item
	|
	|-RVA: 0x13D56D8 Offset: 0x13D16D8 VA: 0x13D56D8
	|-NativeArray<IntPtr>.get_Item
	|
	|-RVA: 0x13D5BD4 Offset: 0x13D1BD4 VA: 0x13D5BD4
	|-NativeArray<LightDataGI>.get_Item
	|
	|-RVA: 0x13D6164 Offset: 0x13D2164 VA: 0x13D6164
	|-NativeArray<Matrix4x4>.get_Item
	|
	|-RVA: 0x13D66E8 Offset: 0x13D26E8 VA: 0x13D66E8
	|-NativeArray<Plane>.get_Item
	|
	|-RVA: 0x13D6C34 Offset: 0x13D2C34 VA: 0x13D6C34
	|-NativeArray<Quaternion>.get_Item
	|
	|-RVA: 0x13D7180 Offset: 0x13D3180 VA: 0x13D7180
	|-NativeArray<sbyte>.get_Item
	|
	|-RVA: 0x13D7690 Offset: 0x13D3690 VA: 0x13D7690
	|-NativeArray<float>.get_Item
	|
	|-RVA: 0x13D7BB0 Offset: 0x13D3BB0 VA: 0x13D7BB0
	|-NativeArray<SubMeshDescriptor>.get_Item
	|
	|-RVA: 0x13D8128 Offset: 0x13D4128 VA: 0x13D8128
	|-NativeArray<uint>.get_Item
	|
	|-RVA: 0x13D8640 Offset: 0x13D4640 VA: 0x13D8640
	|-NativeArray<Vector3>.get_Item
	|
	|-RVA: 0x13D8B68 Offset: 0x13D4B68 VA: 0x13D8B68
	|-NativeArray<Vector4>.get_Item
	|
	|-RVA: 0x13D9204 Offset: 0x13D5204 VA: 0x13D9204
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1E30 Offset: 0x13CDE30 VA: 0x13D1E30
	|-NativeArray<BatchCullingOutputDrawCommands>.set_Item
	|
	|-RVA: 0x13D23B0 Offset: 0x13CE3B0 VA: 0x13D23B0
	|-NativeArray<bool>.set_Item
	|
	|-RVA: 0x13D28E4 Offset: 0x13CE8E4 VA: 0x13D28E4
	|-NativeArray<Bounds>.set_Item
	|
	|-RVA: 0x13D2E24 Offset: 0x13CEE24 VA: 0x13D2E24
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x13D334C Offset: 0x13CF34C VA: 0x13D334C
	|-NativeArray<CullingSplit>.set_Item
	|
	|-RVA: 0x13D38CC Offset: 0x13CF8CC VA: 0x13D38CC
	|-NativeArray<GPUDrivenPackedMaterialData>.set_Item
	|
	|-RVA: 0x13D3DDC Offset: 0x13CFDDC VA: 0x13D3DDC
	|-NativeArray<GPUDrivenPackedRendererData>.set_Item
	|
	|-RVA: 0x13D42EC Offset: 0x13D02EC VA: 0x13D42EC
	|-NativeArray<GPUDrivenRendererEditorData>.set_Item
	|
	|-RVA: 0x13D47E0 Offset: 0x13D07E0 VA: 0x13D47E0
	|-NativeArray<short>.set_Item
	|
	|-RVA: 0x13D4CF0 Offset: 0x13D0CF0 VA: 0x13D4CF0
	|-NativeArray<int>.set_Item
	|
	|-RVA: 0x13D5200 Offset: 0x13D1200 VA: 0x13D5200
	|-NativeArray<Int32Enum>.set_Item
	|
	|-RVA: 0x13D5710 Offset: 0x13D1710 VA: 0x13D5710
	|-NativeArray<IntPtr>.set_Item
	|
	|-RVA: 0x13D5C1C Offset: 0x13D1C1C VA: 0x13D5C1C
	|-NativeArray<LightDataGI>.set_Item
	|
	|-RVA: 0x13D61B4 Offset: 0x13D21B4 VA: 0x13D61B4
	|-NativeArray<Matrix4x4>.set_Item
	|
	|-RVA: 0x13D6728 Offset: 0x13D2728 VA: 0x13D6728
	|-NativeArray<Plane>.set_Item
	|
	|-RVA: 0x13D6C74 Offset: 0x13D2C74 VA: 0x13D6C74
	|-NativeArray<Quaternion>.set_Item
	|
	|-RVA: 0x13D71B8 Offset: 0x13D31B8 VA: 0x13D71B8
	|-NativeArray<sbyte>.set_Item
	|
	|-RVA: 0x13D76C8 Offset: 0x13D36C8 VA: 0x13D76C8
	|-NativeArray<float>.set_Item
	|
	|-RVA: 0x13D7C00 Offset: 0x13D3C00 VA: 0x13D7C00
	|-NativeArray<SubMeshDescriptor>.set_Item
	|
	|-RVA: 0x13D8160 Offset: 0x13D4160 VA: 0x13D8160
	|-NativeArray<uint>.set_Item
	|
	|-RVA: 0x13D8684 Offset: 0x13D4684 VA: 0x13D8684
	|-NativeArray<Vector3>.set_Item
	|
	|-RVA: 0x13D8BA8 Offset: 0x13D4BA8 VA: 0x13D8BA8
	|-NativeArray<Vector4>.set_Item
	|
	|-RVA: 0x13D9338 Offset: 0x13D5338 VA: 0x13D9338
	|-NativeArray<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1E98 Offset: 0x13CDE98 VA: 0x13D1E98
	|-NativeArray<BatchCullingOutputDrawCommands>.get_IsCreated
	|
	|-RVA: 0x13D23F0 Offset: 0x13CE3F0 VA: 0x13D23F0
	|-NativeArray<bool>.get_IsCreated
	|
	|-RVA: 0x13D2948 Offset: 0x13CE948 VA: 0x13D2948
	|-NativeArray<Bounds>.get_IsCreated
	|
	|-RVA: 0x13D2E60 Offset: 0x13CEE60 VA: 0x13D2E60
	|-NativeArray<byte>.get_IsCreated
	|
	|-RVA: 0x13D33B4 Offset: 0x13CF3B4 VA: 0x13D33B4
	|-NativeArray<CullingSplit>.get_IsCreated
	|
	|-RVA: 0x13D3908 Offset: 0x13CF908 VA: 0x13D3908
	|-NativeArray<GPUDrivenPackedMaterialData>.get_IsCreated
	|
	|-RVA: 0x13D3E18 Offset: 0x13CFE18 VA: 0x13D3E18
	|-NativeArray<GPUDrivenPackedRendererData>.get_IsCreated
	|
	|-RVA: 0x13D4328 Offset: 0x13D0328 VA: 0x13D4328
	|-NativeArray<GPUDrivenRendererEditorData>.get_IsCreated
	|
	|-RVA: 0x13D481C Offset: 0x13D081C VA: 0x13D481C
	|-NativeArray<short>.get_IsCreated
	|
	|-RVA: 0x13D4D2C Offset: 0x13D0D2C VA: 0x13D4D2C
	|-NativeArray<int>.get_IsCreated
	|
	|-RVA: 0x13D523C Offset: 0x13D123C VA: 0x13D523C
	|-NativeArray<Int32Enum>.get_IsCreated
	|
	|-RVA: 0x13D574C Offset: 0x13D174C VA: 0x13D574C
	|-NativeArray<IntPtr>.get_IsCreated
	|
	|-RVA: 0x13D5C84 Offset: 0x13D1C84 VA: 0x13D5C84
	|-NativeArray<LightDataGI>.get_IsCreated
	|
	|-RVA: 0x13D6214 Offset: 0x13D2214 VA: 0x13D6214
	|-NativeArray<Matrix4x4>.get_IsCreated
	|
	|-RVA: 0x13D6788 Offset: 0x13D2788 VA: 0x13D6788
	|-NativeArray<Plane>.get_IsCreated
	|
	|-RVA: 0x13D6CD4 Offset: 0x13D2CD4 VA: 0x13D6CD4
	|-NativeArray<Quaternion>.get_IsCreated
	|
	|-RVA: 0x13D71F4 Offset: 0x13D31F4 VA: 0x13D71F4
	|-NativeArray<sbyte>.get_IsCreated
	|
	|-RVA: 0x13D770C Offset: 0x13D370C VA: 0x13D770C
	|-NativeArray<float>.get_IsCreated
	|
	|-RVA: 0x13D7C64 Offset: 0x13D3C64 VA: 0x13D7C64
	|-NativeArray<SubMeshDescriptor>.get_IsCreated
	|
	|-RVA: 0x13D819C Offset: 0x13D419C VA: 0x13D819C
	|-NativeArray<uint>.get_IsCreated
	|
	|-RVA: 0x13D86E8 Offset: 0x13D46E8 VA: 0x13D86E8
	|-NativeArray<Vector3>.get_IsCreated
	|
	|-RVA: 0x13D8C08 Offset: 0x13D4C08 VA: 0x13D8C08
	|-NativeArray<Vector4>.get_IsCreated
	|
	|-RVA: 0x13D9468 Offset: 0x13D5468 VA: 0x13D9468
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1EA8 Offset: 0x13CDEA8 VA: 0x13D1EA8
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|
	|-RVA: 0x13D2400 Offset: 0x13CE400 VA: 0x13D2400
	|-NativeArray<bool>.Dispose
	|
	|-RVA: 0x13D2958 Offset: 0x13CE958 VA: 0x13D2958
	|-NativeArray<Bounds>.Dispose
	|
	|-RVA: 0x13D2E70 Offset: 0x13CEE70 VA: 0x13D2E70
	|-NativeArray<byte>.Dispose
	|
	|-RVA: 0x13D33C4 Offset: 0x13CF3C4 VA: 0x13D33C4
	|-NativeArray<CullingSplit>.Dispose
	|
	|-RVA: 0x13D3918 Offset: 0x13CF918 VA: 0x13D3918
	|-NativeArray<GPUDrivenPackedMaterialData>.Dispose
	|
	|-RVA: 0x13D3E28 Offset: 0x13CFE28 VA: 0x13D3E28
	|-NativeArray<GPUDrivenPackedRendererData>.Dispose
	|
	|-RVA: 0x13D4338 Offset: 0x13D0338 VA: 0x13D4338
	|-NativeArray<GPUDrivenRendererEditorData>.Dispose
	|
	|-RVA: 0x13D482C Offset: 0x13D082C VA: 0x13D482C
	|-NativeArray<short>.Dispose
	|
	|-RVA: 0x13D4D3C Offset: 0x13D0D3C VA: 0x13D4D3C
	|-NativeArray<int>.Dispose
	|
	|-RVA: 0x13D524C Offset: 0x13D124C VA: 0x13D524C
	|-NativeArray<Int32Enum>.Dispose
	|
	|-RVA: 0x13D575C Offset: 0x13D175C VA: 0x13D575C
	|-NativeArray<IntPtr>.Dispose
	|
	|-RVA: 0x13D5C94 Offset: 0x13D1C94 VA: 0x13D5C94
	|-NativeArray<LightDataGI>.Dispose
	|
	|-RVA: 0x13D6224 Offset: 0x13D2224 VA: 0x13D6224
	|-NativeArray<Matrix4x4>.Dispose
	|
	|-RVA: 0x13D6798 Offset: 0x13D2798 VA: 0x13D6798
	|-NativeArray<Plane>.Dispose
	|
	|-RVA: 0x13D6CE4 Offset: 0x13D2CE4 VA: 0x13D6CE4
	|-NativeArray<Quaternion>.Dispose
	|
	|-RVA: 0x13D7204 Offset: 0x13D3204 VA: 0x13D7204
	|-NativeArray<sbyte>.Dispose
	|
	|-RVA: 0x13D771C Offset: 0x13D371C VA: 0x13D771C
	|-NativeArray<float>.Dispose
	|
	|-RVA: 0x13D7C74 Offset: 0x13D3C74 VA: 0x13D7C74
	|-NativeArray<SubMeshDescriptor>.Dispose
	|
	|-RVA: 0x13D81AC Offset: 0x13D41AC VA: 0x13D81AC
	|-NativeArray<uint>.Dispose
	|
	|-RVA: 0x13D86F8 Offset: 0x13D46F8 VA: 0x13D86F8
	|-NativeArray<Vector3>.Dispose
	|
	|-RVA: 0x13D8C18 Offset: 0x13D4C18 VA: 0x13D8C18
	|-NativeArray<Vector4>.Dispose
	|
	|-RVA: 0x13D9478 Offset: 0x13D5478 VA: 0x13D9478
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1F68 Offset: 0x13CDF68 VA: 0x13D1F68
	|-NativeArray<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x13D24C0 Offset: 0x13CE4C0 VA: 0x13D24C0
	|-NativeArray<bool>.GetEnumerator
	|
	|-RVA: 0x13D2A18 Offset: 0x13CEA18 VA: 0x13D2A18
	|-NativeArray<Bounds>.GetEnumerator
	|
	|-RVA: 0x13D2F30 Offset: 0x13CEF30 VA: 0x13D2F30
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x13D3484 Offset: 0x13CF484 VA: 0x13D3484
	|-NativeArray<CullingSplit>.GetEnumerator
	|
	|-RVA: 0x13D39D8 Offset: 0x13CF9D8 VA: 0x13D39D8
	|-NativeArray<GPUDrivenPackedMaterialData>.GetEnumerator
	|
	|-RVA: 0x13D3EE8 Offset: 0x13CFEE8 VA: 0x13D3EE8
	|-NativeArray<GPUDrivenPackedRendererData>.GetEnumerator
	|
	|-RVA: 0x13D43F8 Offset: 0x13D03F8 VA: 0x13D43F8
	|-NativeArray<GPUDrivenRendererEditorData>.GetEnumerator
	|
	|-RVA: 0x13D48EC Offset: 0x13D08EC VA: 0x13D48EC
	|-NativeArray<short>.GetEnumerator
	|
	|-RVA: 0x13D4DFC Offset: 0x13D0DFC VA: 0x13D4DFC
	|-NativeArray<int>.GetEnumerator
	|
	|-RVA: 0x13D530C Offset: 0x13D130C VA: 0x13D530C
	|-NativeArray<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x13D581C Offset: 0x13D181C VA: 0x13D581C
	|-NativeArray<IntPtr>.GetEnumerator
	|
	|-RVA: 0x13D5D54 Offset: 0x13D1D54 VA: 0x13D5D54
	|-NativeArray<LightDataGI>.GetEnumerator
	|
	|-RVA: 0x13D62E4 Offset: 0x13D22E4 VA: 0x13D62E4
	|-NativeArray<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x13D6858 Offset: 0x13D2858 VA: 0x13D6858
	|-NativeArray<Plane>.GetEnumerator
	|
	|-RVA: 0x13D6DA4 Offset: 0x13D2DA4 VA: 0x13D6DA4
	|-NativeArray<Quaternion>.GetEnumerator
	|
	|-RVA: 0x13D72C4 Offset: 0x13D32C4 VA: 0x13D72C4
	|-NativeArray<sbyte>.GetEnumerator
	|
	|-RVA: 0x13D77DC Offset: 0x13D37DC VA: 0x13D77DC
	|-NativeArray<float>.GetEnumerator
	|
	|-RVA: 0x13D7D34 Offset: 0x13D3D34 VA: 0x13D7D34
	|-NativeArray<SubMeshDescriptor>.GetEnumerator
	|
	|-RVA: 0x13D826C Offset: 0x13D426C VA: 0x13D826C
	|-NativeArray<uint>.GetEnumerator
	|
	|-RVA: 0x13D87B8 Offset: 0x13D47B8 VA: 0x13D87B8
	|-NativeArray<Vector3>.GetEnumerator
	|
	|-RVA: 0x13D8CD8 Offset: 0x13D4CD8 VA: 0x13D8CD8
	|-NativeArray<Vector4>.GetEnumerator
	|
	|-RVA: 0x13D9578 Offset: 0x13D5578 VA: 0x13D9578
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1FFC Offset: 0x13CDFFC VA: 0x13D1FFC
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D2530 Offset: 0x13CE530 VA: 0x13D2530
	|-NativeArray<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D2A88 Offset: 0x13CEA88 VA: 0x13D2A88
	|-NativeArray<Bounds>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D2FA0 Offset: 0x13CEFA0 VA: 0x13D2FA0
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D3518 Offset: 0x13CF518 VA: 0x13D3518
	|-NativeArray<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D3A48 Offset: 0x13CFA48 VA: 0x13D3A48
	|-NativeArray<GPUDrivenPackedMaterialData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D3F58 Offset: 0x13CFF58 VA: 0x13D3F58
	|-NativeArray<GPUDrivenPackedRendererData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D4458 Offset: 0x13D0458 VA: 0x13D4458
	|-NativeArray<GPUDrivenRendererEditorData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D495C Offset: 0x13D095C VA: 0x13D495C
	|-NativeArray<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D4E6C Offset: 0x13D0E6C VA: 0x13D4E6C
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D537C Offset: 0x13D137C VA: 0x13D537C
	|-NativeArray<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D587C Offset: 0x13D187C VA: 0x13D587C
	|-NativeArray<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D5DE8 Offset: 0x13D1DE8 VA: 0x13D5DE8
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D6370 Offset: 0x13D2370 VA: 0x13D6370
	|-NativeArray<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D68CC Offset: 0x13D28CC VA: 0x13D68CC
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D6E18 Offset: 0x13D2E18 VA: 0x13D6E18
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D7334 Offset: 0x13D3334 VA: 0x13D7334
	|-NativeArray<sbyte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D784C Offset: 0x13D384C VA: 0x13D784C
	|-NativeArray<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D7DB8 Offset: 0x13D3DB8 VA: 0x13D7DB8
	|-NativeArray<SubMeshDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D82DC Offset: 0x13D42DC VA: 0x13D82DC
	|-NativeArray<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D8818 Offset: 0x13D4818 VA: 0x13D8818
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D8D4C Offset: 0x13D4D4C VA: 0x13D8D4C
	|-NativeArray<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13D966C Offset: 0x13D566C VA: 0x13D966C
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D2094 Offset: 0x13CE094 VA: 0x13D2094
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D25AC Offset: 0x13CE5AC VA: 0x13D25AC
	|-NativeArray<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D2B0C Offset: 0x13CEB0C VA: 0x13D2B0C
	|-NativeArray<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D301C Offset: 0x13CF01C VA: 0x13D301C
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D35B0 Offset: 0x13CF5B0 VA: 0x13D35B0
	|-NativeArray<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D3AC4 Offset: 0x13CFAC4 VA: 0x13D3AC4
	|-NativeArray<GPUDrivenPackedMaterialData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D3FD4 Offset: 0x13CFFD4 VA: 0x13D3FD4
	|-NativeArray<GPUDrivenPackedRendererData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D44D0 Offset: 0x13D04D0 VA: 0x13D44D0
	|-NativeArray<GPUDrivenRendererEditorData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D49D8 Offset: 0x13D09D8 VA: 0x13D49D8
	|-NativeArray<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D4EE8 Offset: 0x13D0EE8 VA: 0x13D4EE8
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D53F8 Offset: 0x13D13F8 VA: 0x13D53F8
	|-NativeArray<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D58F4 Offset: 0x13D18F4 VA: 0x13D58F4
	|-NativeArray<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D5E80 Offset: 0x13D1E80 VA: 0x13D5E80
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D6404 Offset: 0x13D2404 VA: 0x13D6404
	|-NativeArray<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D6950 Offset: 0x13D2950 VA: 0x13D6950
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D6E9C Offset: 0x13D2E9C VA: 0x13D6E9C
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D73B0 Offset: 0x13D33B0 VA: 0x13D73B0
	|-NativeArray<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D78C8 Offset: 0x13D38C8 VA: 0x13D78C8
	|-NativeArray<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D7E44 Offset: 0x13D3E44 VA: 0x13D7E44
	|-NativeArray<SubMeshDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D8358 Offset: 0x13D4358 VA: 0x13D8358
	|-NativeArray<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D8890 Offset: 0x13D4890 VA: 0x13D8890
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D8DD0 Offset: 0x13D4DD0 VA: 0x13D8DD0
	|-NativeArray<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13D9764 Offset: 0x13D5764 VA: 0x13D9764
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D211C Offset: 0x13CE11C VA: 0x13D211C
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|
	|-RVA: 0x13D2630 Offset: 0x13CE630 VA: 0x13D2630
	|-NativeArray<bool>.Equals
	|
	|-RVA: 0x13D2B90 Offset: 0x13CEB90 VA: 0x13D2B90
	|-NativeArray<Bounds>.Equals
	|
	|-RVA: 0x13D30A0 Offset: 0x13CF0A0 VA: 0x13D30A0
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x13D3638 Offset: 0x13CF638 VA: 0x13D3638
	|-NativeArray<CullingSplit>.Equals
	|
	|-RVA: 0x13D3B48 Offset: 0x13CFB48 VA: 0x13D3B48
	|-NativeArray<GPUDrivenPackedMaterialData>.Equals
	|
	|-RVA: 0x13D4058 Offset: 0x13D0058 VA: 0x13D4058
	|-NativeArray<GPUDrivenPackedRendererData>.Equals
	|
	|-RVA: 0x13D454C Offset: 0x13D054C VA: 0x13D454C
	|-NativeArray<GPUDrivenRendererEditorData>.Equals
	|
	|-RVA: 0x13D4A5C Offset: 0x13D0A5C VA: 0x13D4A5C
	|-NativeArray<short>.Equals
	|
	|-RVA: 0x13D4F6C Offset: 0x13D0F6C VA: 0x13D4F6C
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x13D547C Offset: 0x13D147C VA: 0x13D547C
	|-NativeArray<Int32Enum>.Equals
	|
	|-RVA: 0x13D5970 Offset: 0x13D1970 VA: 0x13D5970
	|-NativeArray<IntPtr>.Equals
	|
	|-RVA: 0x13D5F08 Offset: 0x13D1F08 VA: 0x13D5F08
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x13D648C Offset: 0x13D248C VA: 0x13D648C
	|-NativeArray<Matrix4x4>.Equals
	|
	|-RVA: 0x13D69D8 Offset: 0x13D29D8 VA: 0x13D69D8
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x13D6F24 Offset: 0x13D2F24 VA: 0x13D6F24
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x13D7434 Offset: 0x13D3434 VA: 0x13D7434
	|-NativeArray<sbyte>.Equals
	|
	|-RVA: 0x13D794C Offset: 0x13D394C VA: 0x13D794C
	|-NativeArray<float>.Equals
	|
	|-RVA: 0x13D7ECC Offset: 0x13D3ECC VA: 0x13D7ECC
	|-NativeArray<SubMeshDescriptor>.Equals
	|
	|-RVA: 0x13D83DC Offset: 0x13D43DC VA: 0x13D83DC
	|-NativeArray<uint>.Equals
	|
	|-RVA: 0x13D890C Offset: 0x13D490C VA: 0x13D890C
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x13D8E58 Offset: 0x13D4E58 VA: 0x13D8E58
	|-NativeArray<Vector4>.Equals
	|
	|-RVA: 0x13D988C Offset: 0x13D588C VA: 0x13D988C
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D2140 Offset: 0x13CE140 VA: 0x13D2140
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|
	|-RVA: 0x13D2654 Offset: 0x13CE654 VA: 0x13D2654
	|-NativeArray<bool>.Equals
	|
	|-RVA: 0x13D2BB4 Offset: 0x13CEBB4 VA: 0x13D2BB4
	|-NativeArray<Bounds>.Equals
	|
	|-RVA: 0x13D30C4 Offset: 0x13CF0C4 VA: 0x13D30C4
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x13D365C Offset: 0x13CF65C VA: 0x13D365C
	|-NativeArray<CullingSplit>.Equals
	|
	|-RVA: 0x13D3B6C Offset: 0x13CFB6C VA: 0x13D3B6C
	|-NativeArray<GPUDrivenPackedMaterialData>.Equals
	|
	|-RVA: 0x13D407C Offset: 0x13D007C VA: 0x13D407C
	|-NativeArray<GPUDrivenPackedRendererData>.Equals
	|
	|-RVA: 0x13D4570 Offset: 0x13D0570 VA: 0x13D4570
	|-NativeArray<GPUDrivenRendererEditorData>.Equals
	|
	|-RVA: 0x13D4A80 Offset: 0x13D0A80 VA: 0x13D4A80
	|-NativeArray<short>.Equals
	|
	|-RVA: 0x13D4F90 Offset: 0x13D0F90 VA: 0x13D4F90
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x13D54A0 Offset: 0x13D14A0 VA: 0x13D54A0
	|-NativeArray<Int32Enum>.Equals
	|
	|-RVA: 0x13D5994 Offset: 0x13D1994 VA: 0x13D5994
	|-NativeArray<IntPtr>.Equals
	|
	|-RVA: 0x13D5F2C Offset: 0x13D1F2C VA: 0x13D5F2C
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x13D64B0 Offset: 0x13D24B0 VA: 0x13D64B0
	|-NativeArray<Matrix4x4>.Equals
	|
	|-RVA: 0x13D69FC Offset: 0x13D29FC VA: 0x13D69FC
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x13D6F48 Offset: 0x13D2F48 VA: 0x13D6F48
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x13D7458 Offset: 0x13D3458 VA: 0x13D7458
	|-NativeArray<sbyte>.Equals
	|
	|-RVA: 0x13D7970 Offset: 0x13D3970 VA: 0x13D7970
	|-NativeArray<float>.Equals
	|
	|-RVA: 0x13D7EF0 Offset: 0x13D3EF0 VA: 0x13D7EF0
	|-NativeArray<SubMeshDescriptor>.Equals
	|
	|-RVA: 0x13D8400 Offset: 0x13D4400 VA: 0x13D8400
	|-NativeArray<uint>.Equals
	|
	|-RVA: 0x13D8930 Offset: 0x13D4930 VA: 0x13D8930
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x13D8E7C Offset: 0x13D4E7C VA: 0x13D8E7C
	|-NativeArray<Vector4>.Equals
	|
	|-RVA: 0x13D98B0 Offset: 0x13D58B0 VA: 0x13D98B0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D222C Offset: 0x13CE22C VA: 0x13D222C
	|-NativeArray<BatchCullingOutputDrawCommands>.GetHashCode
	|
	|-RVA: 0x13D2740 Offset: 0x13CE740 VA: 0x13D2740
	|-NativeArray<bool>.GetHashCode
	|
	|-RVA: 0x13D2CA0 Offset: 0x13CECA0 VA: 0x13D2CA0
	|-NativeArray<Bounds>.GetHashCode
	|
	|-RVA: 0x13D31B0 Offset: 0x13CF1B0 VA: 0x13D31B0
	|-NativeArray<byte>.GetHashCode
	|
	|-RVA: 0x13D3748 Offset: 0x13CF748 VA: 0x13D3748
	|-NativeArray<CullingSplit>.GetHashCode
	|
	|-RVA: 0x13D3C58 Offset: 0x13CFC58 VA: 0x13D3C58
	|-NativeArray<GPUDrivenPackedMaterialData>.GetHashCode
	|
	|-RVA: 0x13D4168 Offset: 0x13D0168 VA: 0x13D4168
	|-NativeArray<GPUDrivenPackedRendererData>.GetHashCode
	|
	|-RVA: 0x13D465C Offset: 0x13D065C VA: 0x13D465C
	|-NativeArray<GPUDrivenRendererEditorData>.GetHashCode
	|
	|-RVA: 0x13D4B6C Offset: 0x13D0B6C VA: 0x13D4B6C
	|-NativeArray<short>.GetHashCode
	|
	|-RVA: 0x13D507C Offset: 0x13D107C VA: 0x13D507C
	|-NativeArray<int>.GetHashCode
	|
	|-RVA: 0x13D558C Offset: 0x13D158C VA: 0x13D558C
	|-NativeArray<Int32Enum>.GetHashCode
	|
	|-RVA: 0x13D5A80 Offset: 0x13D1A80 VA: 0x13D5A80
	|-NativeArray<IntPtr>.GetHashCode
	|
	|-RVA: 0x13D6018 Offset: 0x13D2018 VA: 0x13D6018
	|-NativeArray<LightDataGI>.GetHashCode
	|
	|-RVA: 0x13D659C Offset: 0x13D259C VA: 0x13D659C
	|-NativeArray<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x13D6AE8 Offset: 0x13D2AE8 VA: 0x13D6AE8
	|-NativeArray<Plane>.GetHashCode
	|
	|-RVA: 0x13D7034 Offset: 0x13D3034 VA: 0x13D7034
	|-NativeArray<Quaternion>.GetHashCode
	|
	|-RVA: 0x13D7544 Offset: 0x13D3544 VA: 0x13D7544
	|-NativeArray<sbyte>.GetHashCode
	|
	|-RVA: 0x13D7A5C Offset: 0x13D3A5C VA: 0x13D7A5C
	|-NativeArray<float>.GetHashCode
	|
	|-RVA: 0x13D7FDC Offset: 0x13D3FDC VA: 0x13D7FDC
	|-NativeArray<SubMeshDescriptor>.GetHashCode
	|
	|-RVA: 0x13D84EC Offset: 0x13D44EC VA: 0x13D84EC
	|-NativeArray<uint>.GetHashCode
	|
	|-RVA: 0x13D8A1C Offset: 0x13D4A1C VA: 0x13D8A1C
	|-NativeArray<Vector3>.GetHashCode
	|
	|-RVA: 0x13D8F68 Offset: 0x13D4F68 VA: 0x13D8F68
	|-NativeArray<Vector4>.GetHashCode
	|
	|-RVA: 0x13D99E8 Offset: 0x13D59E8 VA: 0x13D99E8
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/
}

// Namespace: Unity.Collections
[NativeContainer]
internal struct NativeArrayDispose // TypeDefIndex: 6630
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal Allocator m_AllocatorLabel; // 0x8

	// Methods

	// RVA: 0x1E4AFF8 Offset: 0x1E46FF8 VA: 0x1E4AFF8
	public void Dispose() { }
}

// Namespace: Unity.Collections
[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob // TypeDefIndex: 6631
{
	// Fields
	internal NativeArrayDispose Data; // 0x0

	// Methods

	// RVA: 0x1E4B080 Offset: 0x1E47080 VA: 0x1E4B080 Slot: 4
	public void Execute() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4B0C4 Offset: 0x1E470C4 VA: 0x1E4B0C4
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }
}

// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView<T> // TypeDefIndex: 6632
{}

// Namespace: 
[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
[IsReadOnly]
internal struct BurstLike.SharedStatic<T> // TypeDefIndex: 6633
{
	// Fields
	private readonly void* _buffer; // 0x0

	// Properties
	public T Data { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(void* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1458308 Offset: 0x1454308 VA: 0x1458308
	|-BurstLike.SharedStatic<IntPtr>..ctor
	|
	|-RVA: 0x145833C Offset: 0x145433C VA: 0x145833C
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1458310 Offset: 0x1454310 VA: 0x1458310
	|-BurstLike.SharedStatic<IntPtr>.get_Data
	|
	|-RVA: 0x1458344 Offset: 0x1454344 VA: 0x1458344
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public static BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006C88 Offset: 0x1002C88 VA: 0x1006C88
	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|
	|-RVA: 0x1006D14 Offset: 0x1002D14 VA: 0x1006D14
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
internal static class BurstLike.SharedStatic // TypeDefIndex: 6634
{
	// Methods

	// RVA: 0x1E4B104 Offset: 0x1E47104 VA: 0x1E4B104
	public static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }
}
