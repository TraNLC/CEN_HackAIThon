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

// Namespace: Unity.Collections.LowLevel.Unsafe
[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
[StaticAccessor("BurstLike", 2)]
internal static class BurstLike // TypeDefIndex: 6635
{}

// Namespace: 
private struct BurstRuntime.HashCode64<T> // TypeDefIndex: 6636
{
	// Fields
	public static readonly long Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1271414 Offset: 0x126D414 VA: 0x1271414
	|-BurstRuntime.HashCode64<IJobExtensions.JobStruct<NativeArrayDisposeJob>>..cctor
	|
	|-RVA: 0x12714D0 Offset: 0x126D4D0 VA: 0x12714D0
	|-BurstRuntime.HashCode64<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime // TypeDefIndex: 6637
{
	// Methods

	// RVA: -1 Offset: -1
	public static long GetHashCode64<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EEECC Offset: 0x10EAECC VA: 0x10EEECC
	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|
	|-RVA: 0x10EEF30 Offset: 0x10EAF30 VA: 0x10EEF30
	|-BurstRuntime.GetHashCode64<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E4B1C0 Offset: 0x1E471C0 VA: 0x1E4B1C0
	internal static long HashStringWithFNV1A64(string text) { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerAttribute : Attribute // TypeDefIndex: 6638
{
	// Methods

	// RVA: 0x1E4B24C Offset: 0x1E4724C VA: 0x1E4B24C
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerIsReadOnlyAttribute : Attribute // TypeDefIndex: 6639
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute // TypeDefIndex: 6640
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute // TypeDefIndex: 6641
{
	// Methods

	// RVA: 0x1E4B254 Offset: 0x1E47254 VA: 0x1E4B254
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 6642
{
	// Methods

	// RVA: 0x1E4B25C Offset: 0x1E4725C VA: 0x1E4B25C
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute // TypeDefIndex: 6643
{
	// Methods

	// RVA: 0x1E4B264 Offset: 0x1E47264 VA: 0x1E4B264
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeSetThreadIndexAttribute : Attribute // TypeDefIndex: 6644
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Obsolete("Use NativeSetThreadIndexAttribute instead")]
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute // TypeDefIndex: 6645
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(192)]
public class WriteAccessRequiredAttribute : Attribute // TypeDefIndex: 6646
{
	// Methods

	// RVA: 0x1E4B26C Offset: 0x1E4726C VA: 0x1E4B26C
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute // TypeDefIndex: 6647
{
	// Methods

	// RVA: 0x1E4B274 Offset: 0x1E47274 VA: 0x1E4B274
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute // TypeDefIndex: 6648
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 6649
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeArrayUnsafeUtility // TypeDefIndex: 6650
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136F60 Offset: 0x1132F60 VA: 0x1136F60
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x1136F6C Offset: 0x1132F6C VA: 0x1136F6C
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<bool>
	|
	|-RVA: 0x1136F78 Offset: 0x1132F78 VA: 0x1136F78
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Bounds>
	|
	|-RVA: 0x1136F84 Offset: 0x1132F84 VA: 0x1136F84
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|
	|-RVA: 0x1136F90 Offset: 0x1132F90 VA: 0x1136F90
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CullingSplit>
	|
	|-RVA: 0x1136F9C Offset: 0x1132F9C VA: 0x1136F9C
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<GPUDrivenPackedMaterialData>
	|
	|-RVA: 0x1136FA8 Offset: 0x1132FA8 VA: 0x1136FA8
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<GPUDrivenPackedRendererData>
	|
	|-RVA: 0x1136FB4 Offset: 0x1132FB4 VA: 0x1136FB4
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<GPUDrivenRendererEditorData>
	|
	|-RVA: 0x1136FC0 Offset: 0x1132FC0 VA: 0x1136FC0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<short>
	|
	|-RVA: 0x1136FCC Offset: 0x1132FCC VA: 0x1136FCC
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|
	|-RVA: 0x1136FD8 Offset: 0x1132FD8 VA: 0x1136FD8
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Int32Enum>
	|
	|-RVA: 0x1136FE4 Offset: 0x1132FE4 VA: 0x1136FE4
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|
	|-RVA: 0x1136FF0 Offset: 0x1132FF0 VA: 0x1136FF0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>
	|
	|-RVA: 0x1136FFC Offset: 0x1132FFC VA: 0x1136FFC
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|
	|-RVA: 0x1137008 Offset: 0x1133008 VA: 0x1137008
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Quaternion>
	|
	|-RVA: 0x1137014 Offset: 0x1133014 VA: 0x1137014
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<sbyte>
	|
	|-RVA: 0x1137020 Offset: 0x1133020 VA: 0x1137020
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>
	|
	|-RVA: 0x113702C Offset: 0x113302C VA: 0x113702C
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SubMeshDescriptor>
	|
	|-RVA: 0x1137038 Offset: 0x1133038 VA: 0x1137038
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|
	|-RVA: 0x1137044 Offset: 0x1133044 VA: 0x1137044
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|
	|-RVA: 0x1137050 Offset: 0x1133050 VA: 0x1137050
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>
	|
	|-RVA: 0x113705C Offset: 0x113305C VA: 0x113705C
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137068 Offset: 0x1133068 VA: 0x1137068
	|-NativeArrayUnsafeUtility.GetUnsafePtr<byte>
	|
	|-RVA: 0x113706C Offset: 0x113306C VA: 0x113706C
	|-NativeArrayUnsafeUtility.GetUnsafePtr<sbyte>
	|
	|-RVA: 0x1137070 Offset: 0x1133070 VA: 0x1137070
	|-NativeArrayUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137074 Offset: 0x1133074 VA: 0x1137074
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|
	|-RVA: 0x1137078 Offset: 0x1133078 VA: 0x1137078
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 6651
{
	// Fields
	public byte dummy; // 0x0
	public T data; // 0x0
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[StaticAccessor("UnsafeUtility", 2)]
[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
public static class UnsafeUtility // TypeDefIndex: 6652
{
	// Methods

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x1E4B27C Offset: 0x1E4727C VA: 0x1E4B27C
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x1E4B03C Offset: 0x1E4703C VA: 0x1E4B03C
	public static void FreeTracked(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x1E4AE10 Offset: 0x1E46E10 VA: 0x1E4AE10
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x1E4B2D8 Offset: 0x1E472D8 VA: 0x1E4B2D8
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x1E4B32C Offset: 0x1E4732C VA: 0x1E4B32C
	public static void MemClear(void* destination, long size) { }

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D1B4 Offset: 0x10391B4 VA: 0x103D1B4
	|-UnsafeUtility.AlignOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x103D1D0 Offset: 0x10391D0 VA: 0x103D1D0
	|-UnsafeUtility.AlignOf<bool>
	|
	|-RVA: 0x103D1EC Offset: 0x10391EC VA: 0x103D1EC
	|-UnsafeUtility.AlignOf<Bounds>
	|
	|-RVA: 0x103D208 Offset: 0x1039208 VA: 0x103D208
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0x103D224 Offset: 0x1039224 VA: 0x103D224
	|-UnsafeUtility.AlignOf<CullingSplit>
	|
	|-RVA: 0x103D240 Offset: 0x1039240 VA: 0x103D240
	|-UnsafeUtility.AlignOf<GPUDrivenPackedMaterialData>
	|
	|-RVA: 0x103D25C Offset: 0x103925C VA: 0x103D25C
	|-UnsafeUtility.AlignOf<GPUDrivenPackedRendererData>
	|
	|-RVA: 0x103D278 Offset: 0x1039278 VA: 0x103D278
	|-UnsafeUtility.AlignOf<GPUDrivenRendererEditorData>
	|
	|-RVA: 0x103D294 Offset: 0x1039294 VA: 0x103D294
	|-UnsafeUtility.AlignOf<short>
	|
	|-RVA: 0x103D2B0 Offset: 0x10392B0 VA: 0x103D2B0
	|-UnsafeUtility.AlignOf<int>
	|
	|-RVA: 0x103D2CC Offset: 0x10392CC VA: 0x103D2CC
	|-UnsafeUtility.AlignOf<Int32Enum>
	|
	|-RVA: 0x103D2E8 Offset: 0x10392E8 VA: 0x103D2E8
	|-UnsafeUtility.AlignOf<IntPtr>
	|
	|-RVA: 0x103D304 Offset: 0x1039304 VA: 0x103D304
	|-UnsafeUtility.AlignOf<LightDataGI>
	|
	|-RVA: 0x103D320 Offset: 0x1039320 VA: 0x103D320
	|-UnsafeUtility.AlignOf<Matrix4x4>
	|
	|-RVA: 0x103D33C Offset: 0x103933C VA: 0x103D33C
	|-UnsafeUtility.AlignOf<Plane>
	|
	|-RVA: 0x103D358 Offset: 0x1039358 VA: 0x103D358
	|-UnsafeUtility.AlignOf<Quaternion>
	|
	|-RVA: 0x103D374 Offset: 0x1039374 VA: 0x103D374
	|-UnsafeUtility.AlignOf<sbyte>
	|
	|-RVA: 0x103D390 Offset: 0x1039390 VA: 0x103D390
	|-UnsafeUtility.AlignOf<float>
	|
	|-RVA: 0x103D3AC Offset: 0x10393AC VA: 0x103D3AC
	|-UnsafeUtility.AlignOf<SubMeshDescriptor>
	|
	|-RVA: 0x103D3C8 Offset: 0x10393C8 VA: 0x103D3C8
	|-UnsafeUtility.AlignOf<uint>
	|
	|-RVA: 0x103D3E4 Offset: 0x10393E4 VA: 0x103D3E4
	|-UnsafeUtility.AlignOf<Vector3>
	|
	|-RVA: 0x103D400 Offset: 0x1039400 VA: 0x103D400
	|-UnsafeUtility.AlignOf<Vector4>
	|
	|-RVA: 0x103D41C Offset: 0x103941C VA: 0x103D41C
	|-UnsafeUtility.AlignOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D480 Offset: 0x1039480 VA: 0x103D480
	|-UnsafeUtility.ReadArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x103D494 Offset: 0x1039494 VA: 0x103D494
	|-UnsafeUtility.ReadArrayElement<bool>
	|
	|-RVA: 0x103D49C Offset: 0x103949C VA: 0x103D49C
	|-UnsafeUtility.ReadArrayElement<Bounds>
	|
	|-RVA: 0x103D4B8 Offset: 0x10394B8 VA: 0x103D4B8
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x103D4C0 Offset: 0x10394C0 VA: 0x103D4C0
	|-UnsafeUtility.ReadArrayElement<CullingSplit>
	|
	|-RVA: 0x103D4D4 Offset: 0x10394D4 VA: 0x103D4D4
	|-UnsafeUtility.ReadArrayElement<GPUDrivenPackedMaterialData>
	|
	|-RVA: 0x103D4DC Offset: 0x10394DC VA: 0x103D4DC
	|-UnsafeUtility.ReadArrayElement<GPUDrivenPackedRendererData>
	|
	|-RVA: 0x103D4E4 Offset: 0x10394E4 VA: 0x103D4E4
	|-UnsafeUtility.ReadArrayElement<GPUDrivenRendererEditorData>
	|
	|-RVA: 0x103D4EC Offset: 0x10394EC VA: 0x103D4EC
	|-UnsafeUtility.ReadArrayElement<short>
	|
	|-RVA: 0x103D4F4 Offset: 0x10394F4 VA: 0x103D4F4
	|-UnsafeUtility.ReadArrayElement<int>
	|
	|-RVA: 0x103D4FC Offset: 0x10394FC VA: 0x103D4FC
	|-UnsafeUtility.ReadArrayElement<Int32Enum>
	|
	|-RVA: 0x103D504 Offset: 0x1039504 VA: 0x103D504
	|-UnsafeUtility.ReadArrayElement<IntPtr>
	|
	|-RVA: 0x103D50C Offset: 0x103950C VA: 0x103D50C
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x103D520 Offset: 0x1039520 VA: 0x103D520
	|-UnsafeUtility.ReadArrayElement<Matrix4x4>
	|
	|-RVA: 0x103D53C Offset: 0x103953C VA: 0x103D53C
	|-UnsafeUtility.ReadArrayElement<Plane>
	|
	|-RVA: 0x103D54C Offset: 0x103954C VA: 0x103D54C
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|
	|-RVA: 0x103D55C Offset: 0x103955C VA: 0x103D55C
	|-UnsafeUtility.ReadArrayElement<sbyte>
	|
	|-RVA: 0x103D564 Offset: 0x1039564 VA: 0x103D564
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x103D56C Offset: 0x103956C VA: 0x103D56C
	|-UnsafeUtility.ReadArrayElement<SubMeshDescriptor>
	|
	|-RVA: 0x103D588 Offset: 0x1039588 VA: 0x103D588
	|-UnsafeUtility.ReadArrayElement<uint>
	|
	|-RVA: 0x103D590 Offset: 0x1039590 VA: 0x103D590
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|
	|-RVA: 0x103D5A4 Offset: 0x10395A4 VA: 0x103D5A4
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x103D5B4 Offset: 0x10395B4 VA: 0x103D5B4
	|-UnsafeUtility.ReadArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D794 Offset: 0x1039794 VA: 0x103D794
	|-UnsafeUtility.WriteArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x103D7A8 Offset: 0x10397A8 VA: 0x103D7A8
	|-UnsafeUtility.WriteArrayElement<bool>
	|
	|-RVA: 0x103D7B0 Offset: 0x10397B0 VA: 0x103D7B0
	|-UnsafeUtility.WriteArrayElement<Bounds>
	|
	|-RVA: 0x103D7D0 Offset: 0x10397D0 VA: 0x103D7D0
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x103D7D8 Offset: 0x10397D8 VA: 0x103D7D8
	|-UnsafeUtility.WriteArrayElement<CullingSplit>
	|
	|-RVA: 0x103D7EC Offset: 0x10397EC VA: 0x103D7EC
	|-UnsafeUtility.WriteArrayElement<GPUDrivenPackedMaterialData>
	|
	|-RVA: 0x103D7F4 Offset: 0x10397F4 VA: 0x103D7F4
	|-UnsafeUtility.WriteArrayElement<GPUDrivenPackedRendererData>
	|
	|-RVA: 0x103D7FC Offset: 0x10397FC VA: 0x103D7FC
	|-UnsafeUtility.WriteArrayElement<GPUDrivenRendererEditorData>
	|
	|-RVA: 0x103D804 Offset: 0x1039804 VA: 0x103D804
	|-UnsafeUtility.WriteArrayElement<short>
	|
	|-RVA: 0x103D80C Offset: 0x103980C VA: 0x103D80C
	|-UnsafeUtility.WriteArrayElement<int>
	|
	|-RVA: 0x103D814 Offset: 0x1039814 VA: 0x103D814
	|-UnsafeUtility.WriteArrayElement<Int32Enum>
	|
	|-RVA: 0x103D81C Offset: 0x103981C VA: 0x103D81C
	|-UnsafeUtility.WriteArrayElement<IntPtr>
	|
	|-RVA: 0x103D824 Offset: 0x1039824 VA: 0x103D824
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x103D838 Offset: 0x1039838 VA: 0x103D838
	|-UnsafeUtility.WriteArrayElement<Matrix4x4>
	|
	|-RVA: 0x103D854 Offset: 0x1039854 VA: 0x103D854
	|-UnsafeUtility.WriteArrayElement<Plane>
	|
	|-RVA: 0x103D864 Offset: 0x1039864 VA: 0x103D864
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|
	|-RVA: 0x103D874 Offset: 0x1039874 VA: 0x103D874
	|-UnsafeUtility.WriteArrayElement<sbyte>
	|
	|-RVA: 0x103D87C Offset: 0x103987C VA: 0x103D87C
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x103D884 Offset: 0x1039884 VA: 0x103D884
	|-UnsafeUtility.WriteArrayElement<SubMeshDescriptor>
	|
	|-RVA: 0x103D8A4 Offset: 0x10398A4 VA: 0x103D8A4
	|-UnsafeUtility.WriteArrayElement<uint>
	|
	|-RVA: 0x103D8AC Offset: 0x10398AC VA: 0x103D8AC
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|
	|-RVA: 0x103D8C0 Offset: 0x10398C0 VA: 0x103D8C0
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|
	|-RVA: 0x103D8D0 Offset: 0x10398D0 VA: 0x103D8D0
	|-UnsafeUtility.WriteArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D60C Offset: 0x103960C VA: 0x103D60C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchCullingOutputDrawCommands>>
	|
	|-RVA: 0x103D614 Offset: 0x1039614 VA: 0x103D614
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<bool>>
	|
	|-RVA: 0x103D61C Offset: 0x103961C VA: 0x103D61C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Bounds>>
	|
	|-RVA: 0x103D624 Offset: 0x1039624 VA: 0x103D624
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x103D62C Offset: 0x103962C VA: 0x103D62C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CullingSplit>>
	|
	|-RVA: 0x103D634 Offset: 0x1039634 VA: 0x103D634
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GPUDrivenPackedMaterialData>>
	|
	|-RVA: 0x103D63C Offset: 0x103963C VA: 0x103D63C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GPUDrivenPackedRendererData>>
	|
	|-RVA: 0x103D644 Offset: 0x1039644 VA: 0x103D644
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GPUDrivenRendererEditorData>>
	|
	|-RVA: 0x103D64C Offset: 0x103964C VA: 0x103D64C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<short>>
	|
	|-RVA: 0x103D654 Offset: 0x1039654 VA: 0x103D654
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|
	|-RVA: 0x103D65C Offset: 0x103965C VA: 0x103D65C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Int32Enum>>
	|
	|-RVA: 0x103D664 Offset: 0x1039664 VA: 0x103D664
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<IntPtr>>
	|
	|-RVA: 0x103D66C Offset: 0x103966C VA: 0x103D66C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0x103D674 Offset: 0x1039674 VA: 0x103D674
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Matrix4x4>>
	|
	|-RVA: 0x103D67C Offset: 0x103967C VA: 0x103D67C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|
	|-RVA: 0x103D684 Offset: 0x1039684 VA: 0x103D684
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|
	|-RVA: 0x103D68C Offset: 0x103968C VA: 0x103D68C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<sbyte>>
	|
	|-RVA: 0x103D694 Offset: 0x1039694 VA: 0x103D694
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|
	|-RVA: 0x103D69C Offset: 0x103969C VA: 0x103D69C
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SubMeshDescriptor>>
	|
	|-RVA: 0x103D6A4 Offset: 0x10396A4 VA: 0x103D6A4
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|
	|-RVA: 0x103D6AC Offset: 0x10396AC VA: 0x103D6AC
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|
	|-RVA: 0x103D6B4 Offset: 0x10396B4 VA: 0x103D6B4
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x103D6BC Offset: 0x10396BC VA: 0x103D6BC
	|-UnsafeUtility.SizeOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x103D6C4 Offset: 0x10396C4 VA: 0x103D6C4
	|-UnsafeUtility.SizeOf<bool>
	|
	|-RVA: 0x103D6CC Offset: 0x10396CC VA: 0x103D6CC
	|-UnsafeUtility.SizeOf<Bounds>
	|
	|-RVA: 0x103D6D4 Offset: 0x10396D4 VA: 0x103D6D4
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0x103D6DC Offset: 0x10396DC VA: 0x103D6DC
	|-UnsafeUtility.SizeOf<CullingSplit>
	|
	|-RVA: 0x103D6E4 Offset: 0x10396E4 VA: 0x103D6E4
	|-UnsafeUtility.SizeOf<GPUDrivenPackedMaterialData>
	|
	|-RVA: 0x103D6EC Offset: 0x10396EC VA: 0x103D6EC
	|-UnsafeUtility.SizeOf<GPUDrivenPackedRendererData>
	|
	|-RVA: 0x103D6F4 Offset: 0x10396F4 VA: 0x103D6F4
	|-UnsafeUtility.SizeOf<GPUDrivenRendererEditorData>
	|
	|-RVA: 0x103D6FC Offset: 0x10396FC VA: 0x103D6FC
	|-UnsafeUtility.SizeOf<short>
	|
	|-RVA: 0x103D704 Offset: 0x1039704 VA: 0x103D704
	|-UnsafeUtility.SizeOf<int>
	|
	|-RVA: 0x103D70C Offset: 0x103970C VA: 0x103D70C
	|-UnsafeUtility.SizeOf<Int32Enum>
	|
	|-RVA: 0x103D714 Offset: 0x1039714 VA: 0x103D714
	|-UnsafeUtility.SizeOf<IntPtr>
	|
	|-RVA: 0x103D71C Offset: 0x103971C VA: 0x103D71C
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0x103D724 Offset: 0x1039724 VA: 0x103D724
	|-UnsafeUtility.SizeOf<Matrix4x4>
	|
	|-RVA: 0x103D72C Offset: 0x103972C VA: 0x103D72C
	|-UnsafeUtility.SizeOf<Plane>
	|
	|-RVA: 0x103D734 Offset: 0x1039734 VA: 0x103D734
	|-UnsafeUtility.SizeOf<Quaternion>
	|
	|-RVA: 0x103D73C Offset: 0x103973C VA: 0x103D73C
	|-UnsafeUtility.SizeOf<sbyte>
	|
	|-RVA: 0x103D744 Offset: 0x1039744 VA: 0x103D744
	|-UnsafeUtility.SizeOf<float>
	|
	|-RVA: 0x103D74C Offset: 0x103974C VA: 0x103D74C
	|-UnsafeUtility.SizeOf<SubMeshDescriptor>
	|
	|-RVA: 0x103D754 Offset: 0x1039754 VA: 0x103D754
	|-UnsafeUtility.SizeOf<uint>
	|
	|-RVA: 0x103D75C Offset: 0x103975C VA: 0x103D75C
	|-UnsafeUtility.SizeOf<Vector3>
	|
	|-RVA: 0x103D764 Offset: 0x1039764 VA: 0x103D764
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x103D76C Offset: 0x103976C VA: 0x103D76C
	|-UnsafeUtility.SizeOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ref T As<U, T>(ref U from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D46C Offset: 0x103946C VA: 0x103D46C
	|-UnsafeUtility.As<IntPtr, GCHandle>
	|
	|-RVA: 0x103D470 Offset: 0x1039470 VA: 0x103D470
	|-UnsafeUtility.As<object, object>
	|
	|-RVA: 0x103D474 Offset: 0x1039474 VA: 0x103D474
	|-UnsafeUtility.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static T As<T>(object from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D468 Offset: 0x1039468 VA: 0x103D468
	|-UnsafeUtility.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D478 Offset: 0x1039478 VA: 0x103D478
	|-UnsafeUtility.AsRef<IntPtr>
	|
	|-RVA: 0x103D47C Offset: 0x103947C VA: 0x103D47C
	|-UnsafeUtility.AsRef<__Il2CppFullySharedGenericStructType>
	*/
}
