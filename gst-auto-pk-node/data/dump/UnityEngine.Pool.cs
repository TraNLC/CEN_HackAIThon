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

// Namespace: UnityEngine.Pool
public class CollectionPool<TCollection, TItem> // TypeDefIndex: 7080
{
	// Fields
	internal static readonly ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static TCollection Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E236C Offset: 0x14DE36C VA: 0x14E236C
	|-CollectionPool<object, Color32>.Get
	|
	|-RVA: 0x14E2870 Offset: 0x14DE870 VA: 0x14E2870
	|-CollectionPool<object, int>.Get
	|
	|-RVA: 0x14E2D74 Offset: 0x14DED74 VA: 0x14E2D74
	|-CollectionPool<object, object>.Get
	|
	|-RVA: 0x14E3278 Offset: 0x14DF278 VA: 0x14E3278
	|-CollectionPool<object, UIVertex>.Get
	|
	|-RVA: 0x14E377C Offset: 0x14DF77C VA: 0x14E377C
	|-CollectionPool<object, Vector3>.Get
	|
	|-RVA: 0x14E3C80 Offset: 0x14DFC80 VA: 0x14E3C80
	|-CollectionPool<object, Vector4>.Get
	|
	|-RVA: 0x14E4184 Offset: 0x14E0184 VA: 0x14E4184
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static PooledObject<TCollection> Get(out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E2418 Offset: 0x14DE418 VA: 0x14E2418
	|-CollectionPool<object, Color32>.Get
	|
	|-RVA: 0x14E291C Offset: 0x14DE91C VA: 0x14E291C
	|-CollectionPool<object, int>.Get
	|
	|-RVA: 0x14E2E20 Offset: 0x14DEE20 VA: 0x14E2E20
	|-CollectionPool<object, object>.Get
	|
	|-RVA: 0x14E3324 Offset: 0x14DF324 VA: 0x14E3324
	|-CollectionPool<object, UIVertex>.Get
	|
	|-RVA: 0x14E3828 Offset: 0x14DF828 VA: 0x14E3828
	|-CollectionPool<object, Vector3>.Get
	|
	|-RVA: 0x14E3D2C Offset: 0x14DFD2C VA: 0x14E3D2C
	|-CollectionPool<object, Vector4>.Get
	|
	|-RVA: 0x14E4230 Offset: 0x14E0230 VA: 0x14E4230
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(TCollection toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E24D4 Offset: 0x14DE4D4 VA: 0x14E24D4
	|-CollectionPool<object, Color32>.Release
	|
	|-RVA: 0x14E29D8 Offset: 0x14DE9D8 VA: 0x14E29D8
	|-CollectionPool<object, int>.Release
	|
	|-RVA: 0x14E2EDC Offset: 0x14DEEDC VA: 0x14E2EDC
	|-CollectionPool<object, object>.Release
	|
	|-RVA: 0x14E33E0 Offset: 0x14DF3E0 VA: 0x14E33E0
	|-CollectionPool<object, UIVertex>.Release
	|
	|-RVA: 0x14E38E4 Offset: 0x14DF8E4 VA: 0x14E38E4
	|-CollectionPool<object, Vector3>.Release
	|
	|-RVA: 0x14E3DE8 Offset: 0x14DFDE8 VA: 0x14E3DE8
	|-CollectionPool<object, Vector4>.Release
	|
	|-RVA: 0x14E42EC Offset: 0x14E02EC VA: 0x14E42EC
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E2590 Offset: 0x14DE590 VA: 0x14E2590
	|-CollectionPool<object, Color32>..cctor
	|
	|-RVA: 0x14E2A94 Offset: 0x14DEA94 VA: 0x14E2A94
	|-CollectionPool<object, int>..cctor
	|
	|-RVA: 0x14E2F98 Offset: 0x14DEF98 VA: 0x14E2F98
	|-CollectionPool<object, object>..cctor
	|
	|-RVA: 0x14E349C Offset: 0x14DF49C VA: 0x14E349C
	|-CollectionPool<object, UIVertex>..cctor
	|
	|-RVA: 0x14E39A0 Offset: 0x14DF9A0 VA: 0x14E39A0
	|-CollectionPool<object, Vector3>..cctor
	|
	|-RVA: 0x14E3EA4 Offset: 0x14DFEA4 VA: 0x14E3EA4
	|-CollectionPool<object, Vector4>..cctor
	|
	|-RVA: 0x14E43A8 Offset: 0x14E03A8 VA: 0x14E43A8
	|-CollectionPool<object, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Pool
public interface IObjectPool<T> // TypeDefIndex: 7081
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Release(T element);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObjectPool<object>.Release
	*/
}

// Namespace: UnityEngine.Pool
internal interface IPool // TypeDefIndex: 7082
{}

// Namespace: UnityEngine.Pool
public class ObjectPool<T> : IDisposable, IPool, IObjectPool<T> // TypeDefIndex: 7083
{
	// Fields
	internal readonly List<T> m_List; // 0x0
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ActionOnGet; // 0x0
	private readonly Action<T> m_ActionOnRelease; // 0x0
	private readonly Action<T> m_ActionOnDestroy; // 0x0
	private readonly int m_MaxSize; // 0x0
	internal bool m_CollectionCheck; // 0x0
	private T m_FreshlyReleased; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <CountAll>k__BackingField; // 0x0

	// Properties
	public int CountAll { get; set; }
	public int CountInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_CountAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD464 Offset: 0x13F9464 VA: 0x13FD464
	|-ObjectPool<object>.get_CountAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_CountAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD46C Offset: 0x13F946C VA: 0x13FD46C
	|-ObjectPool<object>.set_CountAll
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_CountInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD474 Offset: 0x13F9474 VA: 0x13FD474
	|-ObjectPool<object>.get_CountInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> actionOnGet, Action<T> actionOnRelease, Action<T> actionOnDestroy, bool collectionCheck = True, int defaultCapacity = 10, int maxSize = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD498 Offset: 0x13F9498 VA: 0x13FD498
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD664 Offset: 0x13F9664 VA: 0x13FD664
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD734 Offset: 0x13F9734 VA: 0x13FD734
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD7AC Offset: 0x13F97AC VA: 0x13FD7AC
	|-ObjectPool<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD8B8 Offset: 0x13F98B8 VA: 0x13FD8B8
	|-ObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FDA34 Offset: 0x13F9A34 VA: 0x13FDA34
	|-ObjectPool<object>.Dispose
	*/
}

// Namespace: UnityEngine.Pool
internal static class PoolManager // TypeDefIndex: 7084
{
	// Fields
	private static readonly List<WeakReference<IPool>> s_WeakPoolReferences; // 0x0

	// Methods

	// RVA: 0x1E7D030 Offset: 0x1E79030 VA: 0x1E7D030
	public static void Register(IPool pool) { }

	// RVA: 0x1E7D150 Offset: 0x1E79150 VA: 0x1E7D150
	private static void .cctor() { }
}

// Namespace: UnityEngine.Pool
public struct PooledObject<T> : IDisposable // TypeDefIndex: 7085
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, IObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FFDA0 Offset: 0x13FBDA0 VA: 0x13FFDA0
	|-PooledObject<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FFDD0 Offset: 0x13FBDD0 VA: 0x13FFDD0
	|-PooledObject<object>.System.IDisposable.Dispose
	*/
}
