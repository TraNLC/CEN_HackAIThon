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

// Namespace: System.Linq
internal static class Error // TypeDefIndex: 5354
{
	// Methods

	// RVA: 0x19A47AC Offset: 0x19A07AC VA: 0x19A47AC
	internal static Exception ArgumentNull(string s) { }

	// RVA: 0x19A4808 Offset: 0x19A0808 VA: 0x19A4808
	internal static Exception ArgumentOutOfRange(string s) { }

	// RVA: 0x19A4864 Offset: 0x19A0864 VA: 0x19A4864
	internal static Exception MoreThanOneElement() { }

	// RVA: 0x19A48D0 Offset: 0x19A08D0 VA: 0x19A48D0
	internal static Exception MoreThanOneMatch() { }

	// RVA: 0x19A493C Offset: 0x19A093C VA: 0x19A493C
	internal static Exception NoElements() { }

	// RVA: 0x19A49A8 Offset: 0x19A09A8 VA: 0x19A49A8
	internal static Exception NoMatch() { }

	// RVA: 0x19A4A14 Offset: 0x19A0A14 VA: 0x19A4A14
	internal static Exception NotSupported() { }
}

// Namespace: 
private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 5355
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF61C Offset: 0x12CB61C VA: 0x12CF61C
	|-Enumerable.Iterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x12CF73C Offset: 0x12CB73C VA: 0x12CF73C
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x12CF85C Offset: 0x12CB85C VA: 0x12CF85C
	|-Enumerable.Iterator<byte>..ctor
	|
	|-RVA: 0x12CF970 Offset: 0x12CB970 VA: 0x12CF970
	|-Enumerable.Iterator<char>..ctor
	|
	|-RVA: 0x12CFA84 Offset: 0x12CBA84 VA: 0x12CFA84
	|-Enumerable.Iterator<DictionaryEntry>..ctor
	|
	|-RVA: 0x12CFBA4 Offset: 0x12CBBA4 VA: 0x12CFBA4
	|-Enumerable.Iterator<Int32Enum>..ctor
	|
	|-RVA: 0x12CFCB4 Offset: 0x12CBCB4 VA: 0x12CFCB4
	|-Enumerable.Iterator<object>..ctor
	|
	|-RVA: 0x12CFDA8 Offset: 0x12CBDA8 VA: 0x12CFDA8
	|-Enumerable.Iterator<RaycastResult>..ctor
	|
	|-RVA: 0x12CFEEC Offset: 0x12CBEEC VA: 0x12CFEEC
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF650 Offset: 0x12CB650 VA: 0x12CF650
	|-Enumerable.Iterator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x12CF770 Offset: 0x12CB770 VA: 0x12CF770
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x12CF890 Offset: 0x12CB890 VA: 0x12CF890
	|-Enumerable.Iterator<byte>.get_Current
	|
	|-RVA: 0x12CF9A4 Offset: 0x12CB9A4 VA: 0x12CF9A4
	|-Enumerable.Iterator<char>.get_Current
	|
	|-RVA: 0x12CFAB8 Offset: 0x12CBAB8 VA: 0x12CFAB8
	|-Enumerable.Iterator<DictionaryEntry>.get_Current
	|
	|-RVA: 0x12CFBD8 Offset: 0x12CBBD8 VA: 0x12CFBD8
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|
	|-RVA: 0x12CFCE8 Offset: 0x12CBCE8 VA: 0x12CFCE8
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x12CFDDC Offset: 0x12CBDDC VA: 0x12CFDDC
	|-Enumerable.Iterator<RaycastResult>.get_Current
	|
	|-RVA: 0x12CFF40 Offset: 0x12CBF40 VA: 0x12CFF40
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF65C Offset: 0x12CB65C VA: 0x12CF65C
	|-Enumerable.Iterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x12CF77C Offset: 0x12CB77C VA: 0x12CF77C
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x12CF898 Offset: 0x12CB898 VA: 0x12CF898
	|-Enumerable.Iterator<byte>.Dispose
	|
	|-RVA: 0x12CF9AC Offset: 0x12CB9AC VA: 0x12CF9AC
	|-Enumerable.Iterator<char>.Dispose
	|
	|-RVA: 0x12CFAC4 Offset: 0x12CBAC4 VA: 0x12CFAC4
	|-Enumerable.Iterator<DictionaryEntry>.Dispose
	|
	|-RVA: 0x12CFBE0 Offset: 0x12CBBE0 VA: 0x12CFBE0
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|
	|-RVA: 0x12CFCF0 Offset: 0x12CBCF0 VA: 0x12CFCF0
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x12CFDEC Offset: 0x12CBDEC VA: 0x12CFDEC
	|-Enumerable.Iterator<RaycastResult>.Dispose
	|
	|-RVA: 0x12CFF80 Offset: 0x12CBF80 VA: 0x12CFF80
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF66C Offset: 0x12CB66C VA: 0x12CF66C
	|-Enumerable.Iterator<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x12CF78C Offset: 0x12CB78C VA: 0x12CF78C
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x12CF8A8 Offset: 0x12CB8A8 VA: 0x12CF8A8
	|-Enumerable.Iterator<byte>.GetEnumerator
	|
	|-RVA: 0x12CF9BC Offset: 0x12CB9BC VA: 0x12CF9BC
	|-Enumerable.Iterator<char>.GetEnumerator
	|
	|-RVA: 0x12CFAD4 Offset: 0x12CBAD4 VA: 0x12CFAD4
	|-Enumerable.Iterator<DictionaryEntry>.GetEnumerator
	|
	|-RVA: 0x12CFBEC Offset: 0x12CBBEC VA: 0x12CFBEC
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x12CFD00 Offset: 0x12CBD00 VA: 0x12CFD00
	|-Enumerable.Iterator<object>.GetEnumerator
	|
	|-RVA: 0x12CFE10 Offset: 0x12CBE10 VA: 0x12CFE10
	|-Enumerable.Iterator<RaycastResult>.GetEnumerator
	|
	|-RVA: 0x12CFFE0 Offset: 0x12CBFE0 VA: 0x12CFFE0
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF6D4 Offset: 0x12CB6D4 VA: 0x12CF6D4
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CF7F4 Offset: 0x12CB7F4 VA: 0x12CF7F4
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CF910 Offset: 0x12CB910 VA: 0x12CF910
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CFA24 Offset: 0x12CBA24 VA: 0x12CFA24
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CFB3C Offset: 0x12CBB3C VA: 0x12CFB3C
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CFC54 Offset: 0x12CBC54 VA: 0x12CFC54
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CFD68 Offset: 0x12CBD68 VA: 0x12CFD68
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12CFE78 Offset: 0x12CBE78 VA: 0x12CFE78
	|-Enumerable.Iterator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x12D0094 Offset: 0x12CC094 VA: 0x12D0094
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF704 Offset: 0x12CB704 VA: 0x12CF704
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CF824 Offset: 0x12CB824 VA: 0x12CF824
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CF938 Offset: 0x12CB938 VA: 0x12CF938
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CFA4C Offset: 0x12CBA4C VA: 0x12CFA4C
	|-Enumerable.Iterator<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CFB6C Offset: 0x12CBB6C VA: 0x12CFB6C
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CFC7C Offset: 0x12CBC7C VA: 0x12CFC7C
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CFD70 Offset: 0x12CBD70 VA: 0x12CFD70
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12CFEB4 Offset: 0x12CBEB4 VA: 0x12CFEB4
	|-Enumerable.Iterator<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12D0138 Offset: 0x12CC138 VA: 0x12D0138
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF708 Offset: 0x12CB708 VA: 0x12CF708
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CF828 Offset: 0x12CB828 VA: 0x12CF828
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CF93C Offset: 0x12CB93C VA: 0x12CF93C
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CFA50 Offset: 0x12CBA50 VA: 0x12CFA50
	|-Enumerable.Iterator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CFB70 Offset: 0x12CBB70 VA: 0x12CFB70
	|-Enumerable.Iterator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CFC80 Offset: 0x12CBC80 VA: 0x12CFC80
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CFD74 Offset: 0x12CBD74 VA: 0x12CFD74
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12CFEB8 Offset: 0x12CBEB8 VA: 0x12CFEB8
	|-Enumerable.Iterator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x12D014C Offset: 0x12CC14C VA: 0x12D014C
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 5356
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153F52C Offset: 0x153B52C VA: 0x153F52C
	|-Enumerable.WhereEnumerableIterator<byte>..ctor
	|
	|-RVA: 0x153F950 Offset: 0x153B950 VA: 0x153F950
	|-Enumerable.WhereEnumerableIterator<DictionaryEntry>..ctor
	|
	|-RVA: 0x153FD88 Offset: 0x153BD88 VA: 0x153FD88
	|-Enumerable.WhereEnumerableIterator<Int32Enum>..ctor
	|
	|-RVA: 0x15401AC Offset: 0x153C1AC VA: 0x15401AC
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|
	|-RVA: 0x15405DC Offset: 0x153C5DC VA: 0x15405DC
	|-Enumerable.WhereEnumerableIterator<RaycastResult>..ctor
	|
	|-RVA: 0x1540A50 Offset: 0x153CA50 VA: 0x1540A50
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153F578 Offset: 0x153B578 VA: 0x153F578
	|-Enumerable.WhereEnumerableIterator<byte>.Clone
	|
	|-RVA: 0x153F99C Offset: 0x153B99C VA: 0x153F99C
	|-Enumerable.WhereEnumerableIterator<DictionaryEntry>.Clone
	|
	|-RVA: 0x153FDD4 Offset: 0x153BDD4 VA: 0x153FDD4
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Clone
	|
	|-RVA: 0x15401F8 Offset: 0x153C1F8 VA: 0x15401F8
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|
	|-RVA: 0x1540628 Offset: 0x153C628 VA: 0x1540628
	|-Enumerable.WhereEnumerableIterator<RaycastResult>.Clone
	|
	|-RVA: 0x1540AC8 Offset: 0x153CAC8 VA: 0x1540AC8
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153F5D8 Offset: 0x153B5D8 VA: 0x153F5D8
	|-Enumerable.WhereEnumerableIterator<byte>.Dispose
	|
	|-RVA: 0x153F9FC Offset: 0x153B9FC VA: 0x153F9FC
	|-Enumerable.WhereEnumerableIterator<DictionaryEntry>.Dispose
	|
	|-RVA: 0x153FE34 Offset: 0x153BE34 VA: 0x153FE34
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Dispose
	|
	|-RVA: 0x1540258 Offset: 0x153C258 VA: 0x1540258
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x1540688 Offset: 0x153C688 VA: 0x1540688
	|-Enumerable.WhereEnumerableIterator<RaycastResult>.Dispose
	|
	|-RVA: 0x1540B64 Offset: 0x153CB64 VA: 0x1540B64
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153F6A8 Offset: 0x153B6A8 VA: 0x153F6A8
	|-Enumerable.WhereEnumerableIterator<byte>.MoveNext
	|
	|-RVA: 0x153FACC Offset: 0x153BACC VA: 0x153FACC
	|-Enumerable.WhereEnumerableIterator<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x153FF04 Offset: 0x153BF04 VA: 0x153FF04
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x1540328 Offset: 0x153C328 VA: 0x1540328
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x1540758 Offset: 0x153C758 VA: 0x1540758
	|-Enumerable.WhereEnumerableIterator<RaycastResult>.MoveNext
	|
	|-RVA: 0x1540C84 Offset: 0x153CC84 VA: 0x1540C84
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009B14 Offset: 0x1005B14 VA: 0x1009B14
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|
	|-RVA: 0x1009B8C Offset: 0x1005B8C VA: 0x1009B8C
	|-Enumerable.WhereEnumerableIterator<RaycastResult>.Select<object>
	|
	|-RVA: 0x1009C04 Offset: 0x1005C04 VA: 0x1009C04
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153F8D4 Offset: 0x153B8D4 VA: 0x153F8D4
	|-Enumerable.WhereEnumerableIterator<byte>.Where
	|
	|-RVA: 0x153FD0C Offset: 0x153BD0C VA: 0x153FD0C
	|-Enumerable.WhereEnumerableIterator<DictionaryEntry>.Where
	|
	|-RVA: 0x1540130 Offset: 0x153C130 VA: 0x1540130
	|-Enumerable.WhereEnumerableIterator<Int32Enum>.Where
	|
	|-RVA: 0x1540560 Offset: 0x153C560 VA: 0x1540560
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|
	|-RVA: 0x15409D4 Offset: 0x153C9D4 VA: 0x15409D4
	|-Enumerable.WhereEnumerableIterator<RaycastResult>.Where
	|
	|-RVA: 0x1541080 Offset: 0x153D080 VA: 0x1541080
	|-Enumerable.WhereEnumerableIterator<__Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 5357
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153EAD0 Offset: 0x153AAD0 VA: 0x153EAD0
	|-Enumerable.WhereArrayIterator<Int32Enum>..ctor
	|
	|-RVA: 0x153EC94 Offset: 0x153AC94 VA: 0x153EC94
	|-Enumerable.WhereArrayIterator<object>..ctor
	|
	|-RVA: 0x153EE64 Offset: 0x153AE64 VA: 0x153EE64
	|-Enumerable.WhereArrayIterator<RaycastResult>..ctor
	|
	|-RVA: 0x153F080 Offset: 0x153B080 VA: 0x153F080
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153EB1C Offset: 0x153AB1C VA: 0x153EB1C
	|-Enumerable.WhereArrayIterator<Int32Enum>.Clone
	|
	|-RVA: 0x153ECE0 Offset: 0x153ACE0 VA: 0x153ECE0
	|-Enumerable.WhereArrayIterator<object>.Clone
	|
	|-RVA: 0x153EEB0 Offset: 0x153AEB0 VA: 0x153EEB0
	|-Enumerable.WhereArrayIterator<RaycastResult>.Clone
	|
	|-RVA: 0x153F0F8 Offset: 0x153B0F8 VA: 0x153F0F8
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153EB7C Offset: 0x153AB7C VA: 0x153EB7C
	|-Enumerable.WhereArrayIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x153ED40 Offset: 0x153AD40 VA: 0x153ED40
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	|
	|-RVA: 0x153EF10 Offset: 0x153AF10 VA: 0x153EF10
	|-Enumerable.WhereArrayIterator<RaycastResult>.MoveNext
	|
	|-RVA: 0x153F194 Offset: 0x153B194 VA: 0x153F194
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100996C Offset: 0x100596C VA: 0x100996C
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|
	|-RVA: 0x10099E4 Offset: 0x10059E4 VA: 0x10099E4
	|-Enumerable.WhereArrayIterator<RaycastResult>.Select<object>
	|
	|-RVA: 0x1009A5C Offset: 0x1005A5C VA: 0x1009A5C
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153EC18 Offset: 0x153AC18 VA: 0x153EC18
	|-Enumerable.WhereArrayIterator<Int32Enum>.Where
	|
	|-RVA: 0x153EDE8 Offset: 0x153ADE8 VA: 0x153EDE8
	|-Enumerable.WhereArrayIterator<object>.Where
	|
	|-RVA: 0x153F004 Offset: 0x153B004 VA: 0x153F004
	|-Enumerable.WhereArrayIterator<RaycastResult>.Where
	|
	|-RVA: 0x153F460 Offset: 0x153B460 VA: 0x153F460
	|-Enumerable.WhereArrayIterator<__Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 5358
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154114C Offset: 0x153D14C VA: 0x154114C
	|-Enumerable.WhereListIterator<Int32Enum>..ctor
	|
	|-RVA: 0x154134C Offset: 0x153D34C VA: 0x154134C
	|-Enumerable.WhereListIterator<object>..ctor
	|
	|-RVA: 0x1541558 Offset: 0x153D558 VA: 0x1541558
	|-Enumerable.WhereListIterator<RaycastResult>..ctor
	|
	|-RVA: 0x154179C Offset: 0x153D79C VA: 0x154179C
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541198 Offset: 0x153D198 VA: 0x1541198
	|-Enumerable.WhereListIterator<Int32Enum>.Clone
	|
	|-RVA: 0x1541398 Offset: 0x153D398 VA: 0x1541398
	|-Enumerable.WhereListIterator<object>.Clone
	|
	|-RVA: 0x15415A4 Offset: 0x153D5A4 VA: 0x15415A4
	|-Enumerable.WhereListIterator<RaycastResult>.Clone
	|
	|-RVA: 0x1541814 Offset: 0x153D814 VA: 0x1541814
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15411F8 Offset: 0x153D1F8 VA: 0x15411F8
	|-Enumerable.WhereListIterator<Int32Enum>.MoveNext
	|
	|-RVA: 0x15413F8 Offset: 0x153D3F8 VA: 0x15413F8
	|-Enumerable.WhereListIterator<object>.MoveNext
	|
	|-RVA: 0x1541604 Offset: 0x153D604 VA: 0x1541604
	|-Enumerable.WhereListIterator<RaycastResult>.MoveNext
	|
	|-RVA: 0x15418B0 Offset: 0x153D8B0 VA: 0x15418B0
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009CBC Offset: 0x1005CBC VA: 0x1009CBC
	|-Enumerable.WhereListIterator<object>.Select<object>
	|
	|-RVA: 0x1009D34 Offset: 0x1005D34 VA: 0x1009D34
	|-Enumerable.WhereListIterator<RaycastResult>.Select<object>
	|
	|-RVA: 0x1009DAC Offset: 0x1005DAC VA: 0x1009DAC
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15412D0 Offset: 0x153D2D0 VA: 0x15412D0
	|-Enumerable.WhereListIterator<Int32Enum>.Where
	|
	|-RVA: 0x15414DC Offset: 0x153D4DC VA: 0x15414DC
	|-Enumerable.WhereListIterator<object>.Where
	|
	|-RVA: 0x1541720 Offset: 0x153D720 VA: 0x1541720
	|-Enumerable.WhereListIterator<RaycastResult>.Where
	|
	|-RVA: 0x1541BA0 Offset: 0x153DBA0 VA: 0x1541BA0
	|-Enumerable.WhereListIterator<__Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 5359
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1543044 Offset: 0x153F044 VA: 0x1543044
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x15434B8 Offset: 0x153F4B8 VA: 0x15434B8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x154392C Offset: 0x153F92C VA: 0x154392C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x1543DA0 Offset: 0x153FDA0 VA: 0x1543DA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x1544214 Offset: 0x1540214 VA: 0x1544214
	|-Enumerable.WhereSelectEnumerableIterator<char, byte>..ctor
	|
	|-RVA: 0x1544674 Offset: 0x1540674 VA: 0x1544674
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|
	|-RVA: 0x1544ADC Offset: 0x1540ADC VA: 0x1544ADC
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>..ctor
	|
	|-RVA: 0x1544F7C Offset: 0x1540F7C VA: 0x1544F7C
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15430AC Offset: 0x153F0AC VA: 0x15430AC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x1543520 Offset: 0x153F520 VA: 0x1543520
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x1543994 Offset: 0x153F994 VA: 0x1543994
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x1543E08 Offset: 0x153FE08 VA: 0x1543E08
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x154427C Offset: 0x154027C VA: 0x154427C
	|-Enumerable.WhereSelectEnumerableIterator<char, byte>.Clone
	|
	|-RVA: 0x15446DC Offset: 0x15406DC VA: 0x15446DC
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|
	|-RVA: 0x1544B44 Offset: 0x1540B44 VA: 0x1544B44
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>.Clone
	|
	|-RVA: 0x1545018 Offset: 0x1541018 VA: 0x1545018
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154311C Offset: 0x153F11C VA: 0x154311C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, DictionaryEntry>.Dispose
	|
	|-RVA: 0x1543590 Offset: 0x153F590 VA: 0x1543590
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Dispose
	|
	|-RVA: 0x1543A04 Offset: 0x153FA04 VA: 0x1543A04
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, DictionaryEntry>.Dispose
	|
	|-RVA: 0x1543E78 Offset: 0x153FE78 VA: 0x1543E78
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x15442EC Offset: 0x15402EC VA: 0x15442EC
	|-Enumerable.WhereSelectEnumerableIterator<char, byte>.Dispose
	|
	|-RVA: 0x154474C Offset: 0x154074C VA: 0x154474C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x1544BB4 Offset: 0x1540BB4 VA: 0x1544BB4
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>.Dispose
	|
	|-RVA: 0x15450E0 Offset: 0x15410E0 VA: 0x15450E0
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15431EC Offset: 0x153F1EC VA: 0x15431EC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1543660 Offset: 0x153F660 VA: 0x1543660
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x1543AD4 Offset: 0x153FAD4 VA: 0x1543AD4
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1543F48 Offset: 0x153FF48 VA: 0x1543F48
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x15443BC Offset: 0x15403BC VA: 0x15443BC
	|-Enumerable.WhereSelectEnumerableIterator<char, byte>.MoveNext
	|
	|-RVA: 0x154481C Offset: 0x154081C VA: 0x154481C
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x1544C84 Offset: 0x1540C84 VA: 0x1544C84
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>.MoveNext
	|
	|-RVA: 0x1545200 Offset: 0x1541200 VA: 0x1545200
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A1CC Offset: 0x10061CC VA: 0x100A1CC
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x100A268 Offset: 0x1006268 VA: 0x100A268
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x100A304 Offset: 0x1006304 VA: 0x100A304
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|
	|-RVA: 0x100A3A0 Offset: 0x10063A0 VA: 0x100A3A0
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>.Select<object>
	|
	|-RVA: 0x100A43C Offset: 0x100643C VA: 0x100A43C
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154344C Offset: 0x153F44C VA: 0x154344C
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x15438C0 Offset: 0x153F8C0 VA: 0x15438C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x1543D34 Offset: 0x153FD34 VA: 0x1543D34
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x15441A8 Offset: 0x15401A8 VA: 0x15441A8
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x1544608 Offset: 0x1540608 VA: 0x1544608
	|-Enumerable.WhereSelectEnumerableIterator<char, byte>.Where
	|
	|-RVA: 0x1544A70 Offset: 0x1540A70 VA: 0x1544A70
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|
	|-RVA: 0x1544F10 Offset: 0x1540F10 VA: 0x1544F10
	|-Enumerable.WhereSelectEnumerableIterator<RaycastResult, object>.Where
	|
	|-RVA: 0x154568C Offset: 0x154168C VA: 0x154568C
	|-Enumerable.WhereSelectEnumerableIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 5360
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541C6C Offset: 0x153DC6C VA: 0x1541C6C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x1541E7C Offset: 0x153DE7C VA: 0x1541E7C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x154208C Offset: 0x153E08C VA: 0x154208C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x154229C Offset: 0x153E29C VA: 0x154229C
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x15424AC Offset: 0x153E4AC VA: 0x15424AC
	|-Enumerable.WhereSelectArrayIterator<char, byte>..ctor
	|
	|-RVA: 0x15426AC Offset: 0x153E6AC VA: 0x15426AC
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|
	|-RVA: 0x15428B4 Offset: 0x153E8B4 VA: 0x15428B4
	|-Enumerable.WhereSelectArrayIterator<RaycastResult, object>..ctor
	|
	|-RVA: 0x1542B0C Offset: 0x153EB0C VA: 0x1542B0C
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541CD4 Offset: 0x153DCD4 VA: 0x1541CD4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x1541EE4 Offset: 0x153DEE4 VA: 0x1541EE4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x15420F4 Offset: 0x153E0F4 VA: 0x15420F4
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x1542304 Offset: 0x153E304 VA: 0x1542304
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x1542514 Offset: 0x153E514 VA: 0x1542514
	|-Enumerable.WhereSelectArrayIterator<char, byte>.Clone
	|
	|-RVA: 0x1542714 Offset: 0x153E714 VA: 0x1542714
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|
	|-RVA: 0x154291C Offset: 0x153E91C VA: 0x154291C
	|-Enumerable.WhereSelectArrayIterator<RaycastResult, object>.Clone
	|
	|-RVA: 0x1542BA8 Offset: 0x153EBA8 VA: 0x1542BA8
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541D44 Offset: 0x153DD44 VA: 0x1541D44
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1541F54 Offset: 0x153DF54 VA: 0x1541F54
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x1542164 Offset: 0x153E164 VA: 0x1542164
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1542374 Offset: 0x153E374 VA: 0x1542374
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x1542584 Offset: 0x153E584 VA: 0x1542584
	|-Enumerable.WhereSelectArrayIterator<char, byte>.MoveNext
	|
	|-RVA: 0x1542784 Offset: 0x153E784 VA: 0x1542784
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x154298C Offset: 0x153E98C VA: 0x154298C
	|-Enumerable.WhereSelectArrayIterator<RaycastResult, object>.MoveNext
	|
	|-RVA: 0x1542C70 Offset: 0x153EC70 VA: 0x1542C70
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009E64 Offset: 0x1005E64 VA: 0x1009E64
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x1009F00 Offset: 0x1005F00 VA: 0x1009F00
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x1009F9C Offset: 0x1005F9C VA: 0x1009F9C
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|
	|-RVA: 0x100A038 Offset: 0x1006038 VA: 0x100A038
	|-Enumerable.WhereSelectArrayIterator<RaycastResult, object>.Select<object>
	|
	|-RVA: 0x100A0D4 Offset: 0x10060D4 VA: 0x100A0D4
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1541E10 Offset: 0x153DE10 VA: 0x1541E10
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x1542020 Offset: 0x153E020 VA: 0x1542020
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x1542230 Offset: 0x153E230 VA: 0x1542230
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x1542440 Offset: 0x153E440 VA: 0x1542440
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x1542640 Offset: 0x153E640 VA: 0x1542640
	|-Enumerable.WhereSelectArrayIterator<char, byte>.Where
	|
	|-RVA: 0x1542848 Offset: 0x153E848 VA: 0x1542848
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|
	|-RVA: 0x1542AA0 Offset: 0x153EAA0 VA: 0x1542AA0
	|-Enumerable.WhereSelectArrayIterator<RaycastResult, object>.Where
	|
	|-RVA: 0x1542FD4 Offset: 0x153EFD4 VA: 0x1542FD4
	|-Enumerable.WhereSelectArrayIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 5361
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15456FC Offset: 0x15416FC VA: 0x15456FC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x1545948 Offset: 0x1541948 VA: 0x1545948
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>..ctor
	|
	|-RVA: 0x1545B98 Offset: 0x1541B98 VA: 0x1545B98
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, DictionaryEntry>..ctor
	|
	|-RVA: 0x1545DE4 Offset: 0x1541DE4 VA: 0x1545DE4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x1546034 Offset: 0x1542034 VA: 0x1546034
	|-Enumerable.WhereSelectListIterator<char, byte>..ctor
	|
	|-RVA: 0x1546270 Offset: 0x1542270 VA: 0x1546270
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|
	|-RVA: 0x15464B4 Offset: 0x15424B4 VA: 0x15464B4
	|-Enumerable.WhereSelectListIterator<RaycastResult, object>..ctor
	|
	|-RVA: 0x1546734 Offset: 0x1542734 VA: 0x1546734
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1545764 Offset: 0x1541764 VA: 0x1545764
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x15459B0 Offset: 0x15419B0 VA: 0x15459B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Clone
	|
	|-RVA: 0x1545C00 Offset: 0x1541C00 VA: 0x1545C00
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, DictionaryEntry>.Clone
	|
	|-RVA: 0x1545E4C Offset: 0x1541E4C VA: 0x1545E4C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x154609C Offset: 0x154209C VA: 0x154609C
	|-Enumerable.WhereSelectListIterator<char, byte>.Clone
	|
	|-RVA: 0x15462D8 Offset: 0x15422D8 VA: 0x15462D8
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|
	|-RVA: 0x154651C Offset: 0x154251C VA: 0x154651C
	|-Enumerable.WhereSelectListIterator<RaycastResult, object>.Clone
	|
	|-RVA: 0x15467D0 Offset: 0x15427D0 VA: 0x15467D0
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15457D4 Offset: 0x15417D4 VA: 0x15457D4
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1545A20 Offset: 0x1541A20 VA: 0x1545A20
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.MoveNext
	|
	|-RVA: 0x1545C70 Offset: 0x1541C70 VA: 0x1545C70
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1545EBC Offset: 0x1541EBC VA: 0x1545EBC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x154610C Offset: 0x154210C VA: 0x154610C
	|-Enumerable.WhereSelectListIterator<char, byte>.MoveNext
	|
	|-RVA: 0x1546348 Offset: 0x1542348 VA: 0x1546348
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x154658C Offset: 0x154258C VA: 0x154658C
	|-Enumerable.WhereSelectListIterator<RaycastResult, object>.MoveNext
	|
	|-RVA: 0x1546898 Offset: 0x1542898 VA: 0x1546898
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A534 Offset: 0x1006534 VA: 0x100A534
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Select<object>
	|
	|-RVA: 0x100A5D0 Offset: 0x10065D0 VA: 0x100A5D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x100A66C Offset: 0x100666C VA: 0x100A66C
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|
	|-RVA: 0x100A708 Offset: 0x1006708 VA: 0x100A708
	|-Enumerable.WhereSelectListIterator<RaycastResult, object>.Select<object>
	|
	|-RVA: 0x100A7A4 Offset: 0x10067A4 VA: 0x100A7A4
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15458DC Offset: 0x15418DC VA: 0x15458DC
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x1545B2C Offset: 0x1541B2C VA: 0x1545B2C
	|-Enumerable.WhereSelectListIterator<KeyValuePair<int, object>, object>.Where
	|
	|-RVA: 0x1545D78 Offset: 0x1541D78 VA: 0x1545D78
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, DictionaryEntry>.Where
	|
	|-RVA: 0x1545FC8 Offset: 0x1541FC8 VA: 0x1545FC8
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x1546204 Offset: 0x1542204 VA: 0x1546204
	|-Enumerable.WhereSelectListIterator<char, byte>.Where
	|
	|-RVA: 0x1546448 Offset: 0x1542448 VA: 0x1546448
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|
	|-RVA: 0x15466C8 Offset: 0x15426C8 VA: 0x15466C8
	|-Enumerable.WhereSelectListIterator<RaycastResult, object>.Where
	|
	|-RVA: 0x1546C1C Offset: 0x1542C1C VA: 0x1546C1C
	|-Enumerable.WhereSelectListIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Where
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<>c__DisplayClass6_0<TSource> // TypeDefIndex: 5362
{
	// Fields
	public Func<TSource, bool> predicate1; // 0x0
	public Func<TSource, bool> predicate2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BA44 Offset: 0x1157A44 VA: 0x115BA44
	|-Enumerable.<>c__DisplayClass6_0<byte>..ctor
	|
	|-RVA: 0x115BAB0 Offset: 0x1157AB0 VA: 0x115BAB0
	|-Enumerable.<>c__DisplayClass6_0<DictionaryEntry>..ctor
	|
	|-RVA: 0x115BB24 Offset: 0x1157B24 VA: 0x115BB24
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>..ctor
	|
	|-RVA: 0x115BB90 Offset: 0x1157B90 VA: 0x115BB90
	|-Enumerable.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x115BC28 Offset: 0x1157C28 VA: 0x115BC28
	|-Enumerable.<>c__DisplayClass6_0<RaycastResult>..ctor
	|
	|-RVA: 0x115BCBC Offset: 0x1157CBC VA: 0x115BCBC
	|-Enumerable.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CombinePredicates>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BA4C Offset: 0x1157A4C VA: 0x115BA4C
	|-Enumerable.<>c__DisplayClass6_0<byte>.<CombinePredicates>b__0
	|
	|-RVA: 0x115BAB8 Offset: 0x1157AB8 VA: 0x115BAB8
	|-Enumerable.<>c__DisplayClass6_0<DictionaryEntry>.<CombinePredicates>b__0
	|
	|-RVA: 0x115BB2C Offset: 0x1157B2C VA: 0x115BB2C
	|-Enumerable.<>c__DisplayClass6_0<Int32Enum>.<CombinePredicates>b__0
	|
	|-RVA: 0x115BB98 Offset: 0x1157B98 VA: 0x115BB98
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x115BC30 Offset: 0x1157C30 VA: 0x115BC30
	|-Enumerable.<>c__DisplayClass6_0<RaycastResult>.<CombinePredicates>b__0
	|
	|-RVA: 0x115BCC4 Offset: 0x1157CC4 VA: 0x115BCC4
	|-Enumerable.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CombinePredicates>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 5363
{
	// Fields
	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C374 Offset: 0x1158374 VA: 0x115C374
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<int, object>, object, object>..ctor
	|
	|-RVA: 0x115C3BC Offset: 0x11583BC VA: 0x115C3BC
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>..ctor
	|
	|-RVA: 0x115C404 Offset: 0x1158404 VA: 0x115C404
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>..ctor
	|
	|-RVA: 0x115C44C Offset: 0x115844C VA: 0x115C44C
	|-Enumerable.<>c__DisplayClass7_0<RaycastResult, object, object>..ctor
	|
	|-RVA: 0x115C4B8 Offset: 0x11584B8 VA: 0x115C4B8
	|-Enumerable.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CombineSelectors>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C37C Offset: 0x115837C VA: 0x115C37C
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<int, object>, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x115C3C4 Offset: 0x11583C4 VA: 0x115C3C4
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x115C40C Offset: 0x115840C VA: 0x115C40C
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x115C454 Offset: 0x1158454 VA: 0x115C454
	|-Enumerable.<>c__DisplayClass7_0<RaycastResult, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x115C4C0 Offset: 0x11584C0 VA: 0x115C4C0
	|-Enumerable.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CombineSelectors>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5364
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B22C Offset: 0x116722C VA: 0x116B22C
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	|
	|-RVA: 0x116BA2C Offset: 0x1167A2C VA: 0x116BA2C
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B260 Offset: 0x1167260 VA: 0x116B260
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x116BA94 Offset: 0x1167A94 VA: 0x116BA94
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B31C Offset: 0x116731C VA: 0x116B31C
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	|
	|-RVA: 0x116BBA4 Offset: 0x1167BA4 VA: 0x116BBA4
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B7D0 Offset: 0x11677D0 VA: 0x116B7D0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	|
	|-RVA: 0x116C3A0 Offset: 0x11683A0 VA: 0x116C3A0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B880 Offset: 0x1167880 VA: 0x116B880
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	|
	|-RVA: 0x116C4AC Offset: 0x11684AC VA: 0x116C4AC
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B930 Offset: 0x1167930 VA: 0x116B930
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x116C5B8 Offset: 0x11685B8 VA: 0x116C5B8
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B938 Offset: 0x1167938 VA: 0x116B938
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116C5FC Offset: 0x11685FC VA: 0x116C5FC
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B96C Offset: 0x116796C VA: 0x116B96C
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116C630 Offset: 0x1168630 VA: 0x116C630
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116B974 Offset: 0x1167974 VA: 0x116B974
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x116C6D4 Offset: 0x11686D4 VA: 0x116C6D4
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116BA1C Offset: 0x1167A1C VA: 0x116BA1C
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116C824 Offset: 0x1168824 VA: 0x116C824
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectManyIterator>d__23<TSource, TCollection, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5365
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TCollection>> collectionSelector; // 0x0
	public Func<TSource, IEnumerable<TCollection>> <>3__collectionSelector; // 0x0
	private Func<TSource, TCollection, TResult> resultSelector; // 0x0
	public Func<TSource, TCollection, TResult> <>3__resultSelector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private TSource <element>5__3; // 0x0
	private IEnumerator<TCollection> <>7__wrap3; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116C838 Offset: 0x1168838 VA: 0x116C838
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>..ctor
	|
	|-RVA: 0x116D088 Offset: 0x1169088 VA: 0x116D088
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116C86C Offset: 0x116886C VA: 0x116C86C
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x116D0F0 Offset: 0x11690F0 VA: 0x116D0F0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116C928 Offset: 0x1168928 VA: 0x116C928
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.MoveNext
	|
	|-RVA: 0x116D200 Offset: 0x1169200 VA: 0x116D200
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CE1C Offset: 0x1168E1C VA: 0x116CE1C
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.<>m__Finally1
	|
	|-RVA: 0x116DB74 Offset: 0x1169B74 VA: 0x116DB74
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CECC Offset: 0x1168ECC VA: 0x116CECC
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.<>m__Finally2
	|
	|-RVA: 0x116DC80 Offset: 0x1169C80 VA: 0x116DC80
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CF7C Offset: 0x1168F7C VA: 0x116CF7C
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x116DD8C Offset: 0x1169D8C VA: 0x116DD8C
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CF84 Offset: 0x1168F84 VA: 0x116CF84
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116DDD0 Offset: 0x1169DD0 VA: 0x116DDD0
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CFB8 Offset: 0x1168FB8 VA: 0x116CFB8
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116DE04 Offset: 0x1169E04 VA: 0x116DE04
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116CFC0 Offset: 0x1168FC0 VA: 0x116CFC0
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x116DEA8 Offset: 0x1169EA8 VA: 0x116DEA8
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116D078 Offset: 0x1169078 VA: 0x116D078
	|-Enumerable.<SelectManyIterator>d__23<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116E034 Offset: 0x116A034 VA: 0x116E034
	|-Enumerable.<SelectManyIterator>d__23<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<JoinIterator>d__38<TOuter, TInner, TKey, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5366
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TInner> inner; // 0x0
	public IEnumerable<TInner> <>3__inner; // 0x0
	private Func<TInner, TKey> innerKeySelector; // 0x0
	public Func<TInner, TKey> <>3__innerKeySelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0
	public IEqualityComparer<TKey> <>3__comparer; // 0x0
	private IEnumerable<TOuter> outer; // 0x0
	public IEnumerable<TOuter> <>3__outer; // 0x0
	private Func<TOuter, TKey> outerKeySelector; // 0x0
	public Func<TOuter, TKey> <>3__outerKeySelector; // 0x0
	private Func<TOuter, TInner, TResult> resultSelector; // 0x0
	public Func<TOuter, TInner, TResult> <>3__resultSelector; // 0x0
	private Lookup<TKey, TInner> <lookup>5__2; // 0x0
	private IEnumerator<TOuter> <>7__wrap2; // 0x0
	private TOuter <item>5__4; // 0x0
	private Lookup.Grouping<TKey, TInner> <g>5__5; // 0x0
	private int <i>5__6; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11677E0 Offset: 0x11637E0 VA: 0x11677E0
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>..ctor
	|
	|-RVA: 0x1167E44 Offset: 0x1163E44 VA: 0x1167E44
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167814 Offset: 0x1163814 VA: 0x1167814
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1167EAC Offset: 0x1163EAC VA: 0x1167EAC
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167830 Offset: 0x1163830 VA: 0x1167830
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.MoveNext
	|
	|-RVA: 0x1167F0C Offset: 0x1163F0C VA: 0x1167F0C
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167C58 Offset: 0x1163C58 VA: 0x1167C58
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.<>m__Finally1
	|
	|-RVA: 0x116891C Offset: 0x116491C VA: 0x116891C
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167D08 Offset: 0x1163D08 VA: 0x1167D08
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x1168A28 Offset: 0x1164A28 VA: 0x1168A28
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167D10 Offset: 0x1163D10 VA: 0x1167D10
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1168A6C Offset: 0x1164A6C VA: 0x1168A6C
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167D44 Offset: 0x1163D44 VA: 0x1167D44
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1168AA0 Offset: 0x1164AA0 VA: 0x1168AA0
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167D4C Offset: 0x1163D4C VA: 0x1167D4C
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x1168B44 Offset: 0x1164B44 VA: 0x1168B44
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1167E34 Offset: 0x1163E34 VA: 0x1167E34
	|-Enumerable.<JoinIterator>d__38<object, object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1168D84 Offset: 0x1164D84 VA: 0x1168D84
	|-Enumerable.<JoinIterator>d__38<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 5367
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1160030 Offset: 0x115C030 VA: 0x1160030
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	|
	|-RVA: 0x11607A8 Offset: 0x115C7A8 VA: 0x11607A8
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1160064 Offset: 0x115C064 VA: 0x1160064
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1160810 Offset: 0x115C810 VA: 0x1160810
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116009C Offset: 0x115C09C VA: 0x116009C
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	|
	|-RVA: 0x1160888 Offset: 0x115C888 VA: 0x1160888
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116054C Offset: 0x115C54C VA: 0x116054C
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	|
	|-RVA: 0x116102C Offset: 0x115D02C VA: 0x116102C
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11605FC Offset: 0x115C5FC VA: 0x11605FC
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	|
	|-RVA: 0x1161138 Offset: 0x115D138 VA: 0x1161138
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11606AC Offset: 0x115C6AC VA: 0x11606AC
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x1161244 Offset: 0x115D244 VA: 0x1161244
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11606B4 Offset: 0x115C6B4 VA: 0x11606B4
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1161288 Offset: 0x115D288 VA: 0x1161288
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11606E8 Offset: 0x115C6E8 VA: 0x11606E8
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11612BC Offset: 0x115D2BC VA: 0x11612BC
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11606F0 Offset: 0x115C6F0 VA: 0x11606F0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x1161360 Offset: 0x115D360 VA: 0x1161360
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1160798 Offset: 0x115C798 VA: 0x1160798
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11614B0 Offset: 0x115D4B0 VA: 0x11614B0
	|-Enumerable.<ConcatIterator>d__59<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 5368
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11614C4 Offset: 0x115D4C4 VA: 0x11614C4
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	|
	|-RVA: 0x1161A14 Offset: 0x115DA14 VA: 0x1161A14
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11614F8 Offset: 0x115D4F8 VA: 0x11614F8
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1161A7C Offset: 0x115DA7C VA: 0x1161A7C
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161514 Offset: 0x115D514 VA: 0x1161514
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	|
	|-RVA: 0x1161ADC Offset: 0x115DADC VA: 0x1161ADC
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161868 Offset: 0x115D868 VA: 0x1161868
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	|
	|-RVA: 0x11620CC Offset: 0x115E0CC VA: 0x11620CC
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161918 Offset: 0x115D918 VA: 0x1161918
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x11621D8 Offset: 0x115E1D8 VA: 0x11621D8
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161920 Offset: 0x115D920 VA: 0x1161920
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116221C Offset: 0x115E21C VA: 0x116221C
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161954 Offset: 0x115D954 VA: 0x1161954
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1162250 Offset: 0x115E250 VA: 0x1162250
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116195C Offset: 0x115D95C VA: 0x116195C
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x11622F4 Offset: 0x115E2F4 VA: 0x11622F4
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1161A04 Offset: 0x115DA04 VA: 0x1161A04
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1162444 Offset: 0x115E444 VA: 0x1162444
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 5369
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F9B8 Offset: 0x116B9B8 VA: 0x116F9B8
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x117020C Offset: 0x116C20C VA: 0x117020C
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F9EC Offset: 0x116B9EC VA: 0x116F9EC
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|
	|-RVA: 0x1170274 Offset: 0x116C274 VA: 0x1170274
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116FA24 Offset: 0x116BA24 VA: 0x116FA24
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x11702EC Offset: 0x116C2EC VA: 0x11702EC
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116FF80 Offset: 0x116BF80 VA: 0x116FF80
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x1170CA8 Offset: 0x116CCA8 VA: 0x1170CA8
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1170030 Offset: 0x116C030 VA: 0x1170030
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x1170DB4 Offset: 0x116CDB4 VA: 0x1170DB4
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11700E0 Offset: 0x116C0E0 VA: 0x11700E0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x1170EC0 Offset: 0x116CEC0 VA: 0x1170EC0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11700E8 Offset: 0x116C0E8 VA: 0x11700E8
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1170F04 Offset: 0x116CF04 VA: 0x1170F04
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117011C Offset: 0x116C11C VA: 0x117011C
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1170F38 Offset: 0x116CF38 VA: 0x1170F38
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1170144 Offset: 0x116C144 VA: 0x1170144
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x1170FDC Offset: 0x116CFDC VA: 0x1170FDC
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11701FC Offset: 0x116C1FC VA: 0x11701FC
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1171168 Offset: 0x116D168 VA: 0x1171168
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5370
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115EDA4 Offset: 0x115ADA4 VA: 0x115EDA4
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>..ctor
	|
	|-RVA: 0x115F2AC Offset: 0x115B2AC VA: 0x115F2AC
	|-Enumerable.<CastIterator>d__99<object>..ctor
	|
	|-RVA: 0x115F7BC Offset: 0x115B7BC VA: 0x115F7BC
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115EDD8 Offset: 0x115ADD8 VA: 0x115EDD8
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.IDisposable.Dispose
	|
	|-RVA: 0x115F2E0 Offset: 0x115B2E0 VA: 0x115F2E0
	|-Enumerable.<CastIterator>d__99<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x115F824 Offset: 0x115B824 VA: 0x115F824
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115EDF4 Offset: 0x115ADF4 VA: 0x115EDF4
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x115F2FC Offset: 0x115B2FC VA: 0x115F2FC
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	|
	|-RVA: 0x115F884 Offset: 0x115B884 VA: 0x115F884
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F0D8 Offset: 0x115B0D8 VA: 0x115F0D8
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.<>m__Finally1
	|
	|-RVA: 0x115F614 Offset: 0x115B614 VA: 0x115F614
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	|
	|-RVA: 0x115FCF0 Offset: 0x115BCF0 VA: 0x115FCF0
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F194 Offset: 0x115B194 VA: 0x115F194
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x115F6D0 Offset: 0x115B6D0 VA: 0x115F6D0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x115FDEC Offset: 0x115BDEC VA: 0x115FDEC
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F1A0 Offset: 0x115B1A0 VA: 0x115F1A0
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x115F6D8 Offset: 0x115B6D8 VA: 0x115F6D8
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x115FE30 Offset: 0x115BE30 VA: 0x115FE30
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F1D4 Offset: 0x115B1D4 VA: 0x115F1D4
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x115F70C Offset: 0x115B70C VA: 0x115F70C
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x115FE64 Offset: 0x115BE64 VA: 0x115FE64
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F204 Offset: 0x115B204 VA: 0x115F204
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x115F714 Offset: 0x115B714 VA: 0x115F714
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x115FF08 Offset: 0x115BF08 VA: 0x115FF08
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115F29C Offset: 0x115B29C VA: 0x115F29C
	|-Enumerable.<CastIterator>d__99<DictionaryEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115F7AC Offset: 0x115B7AC VA: 0x115F7AC
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116001C Offset: 0x115C01C VA: 0x116001C
	|-Enumerable.<CastIterator>d__99<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<RepeatIterator>d__117<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 5371
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private TResult element; // 0x0
	public TResult <>3__element; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168D98 Offset: 0x1164D98 VA: 0x1168D98
	|-Enumerable.<RepeatIterator>d__117<byte>..ctor
	|
	|-RVA: 0x1168F3C Offset: 0x1164F3C VA: 0x1168F3C
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168DCC Offset: 0x1164DCC VA: 0x1168DCC
	|-Enumerable.<RepeatIterator>d__117<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0x1168FA4 Offset: 0x1164FA4 VA: 0x1168FA4
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168DD0 Offset: 0x1164DD0 VA: 0x1168DD0
	|-Enumerable.<RepeatIterator>d__117<byte>.MoveNext
	|
	|-RVA: 0x1168FA8 Offset: 0x1164FA8 VA: 0x1168FA8
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168E30 Offset: 0x1164E30 VA: 0x1168E30
	|-Enumerable.<RepeatIterator>d__117<byte>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x116918C Offset: 0x116518C VA: 0x116918C
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168E38 Offset: 0x1164E38 VA: 0x1168E38
	|-Enumerable.<RepeatIterator>d__117<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11691CC Offset: 0x11651CC VA: 0x11691CC
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168E6C Offset: 0x1164E6C VA: 0x1168E6C
	|-Enumerable.<RepeatIterator>d__117<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1169200 Offset: 0x1165200 VA: 0x1169200
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168E94 Offset: 0x1164E94 VA: 0x1168E94
	|-Enumerable.<RepeatIterator>d__117<byte>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x11692A0 Offset: 0x11652A0 VA: 0x11692A0
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1168F2C Offset: 0x1164F2C VA: 0x1168F2C
	|-Enumerable.<RepeatIterator>d__117<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1169468 Offset: 0x1165468 VA: 0x1169468
	|-Enumerable.<RepeatIterator>d__117<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Linq
[Extension]
public static class Enumerable // TypeDefIndex: 5372
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B884 Offset: 0x1107884 VA: 0x110B884
	|-Enumerable.Where<Int32Enum>
	|
	|-RVA: 0x110BB88 Offset: 0x1107B88 VA: 0x110BB88
	|-Enumerable.Where<object>
	|
	|-RVA: 0x110BE8C Offset: 0x1107E8C VA: 0x110BE8C
	|-Enumerable.Where<RaycastResult>
	|
	|-RVA: 0x110C190 Offset: 0x1108190 VA: 0x110C190
	|-Enumerable.Where<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1104AE4 Offset: 0x1100AE4 VA: 0x1104AE4
	|-Enumerable.Select<KeyValuePair<int, object>, DictionaryEntry>
	|
	|-RVA: 0x1104E08 Offset: 0x1100E08 VA: 0x1104E08
	|-Enumerable.Select<KeyValuePair<int, object>, object>
	|
	|-RVA: 0x110512C Offset: 0x110112C VA: 0x110512C
	|-Enumerable.Select<KeyValuePair<object, object>, DictionaryEntry>
	|
	|-RVA: 0x1105450 Offset: 0x1101450 VA: 0x1105450
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|
	|-RVA: 0x1105774 Offset: 0x1101774 VA: 0x1105774
	|-Enumerable.Select<char, byte>
	|
	|-RVA: 0x1105A98 Offset: 0x1101A98 VA: 0x1105A98
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0x1105DBC Offset: 0x1101DBC VA: 0x1105DBC
	|-Enumerable.Select<RaycastResult, object>
	|
	|-RVA: 0x11060E0 Offset: 0x11020E0 VA: 0x11060E0
	|-Enumerable.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FCA8C Offset: 0x10F8A8C VA: 0x10FCA8C
	|-Enumerable.CombinePredicates<byte>
	|
	|-RVA: 0x10FCB4C Offset: 0x10F8B4C VA: 0x10FCB4C
	|-Enumerable.CombinePredicates<DictionaryEntry>
	|
	|-RVA: 0x10FCC0C Offset: 0x10F8C0C VA: 0x10FCC0C
	|-Enumerable.CombinePredicates<Int32Enum>
	|
	|-RVA: 0x10FCCCC Offset: 0x10F8CCC VA: 0x10FCCCC
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x10FCD8C Offset: 0x10F8D8C VA: 0x10FCD8C
	|-Enumerable.CombinePredicates<RaycastResult>
	|
	|-RVA: 0x10FCE4C Offset: 0x10F8E4C VA: 0x10FCE4C
	|-Enumerable.CombinePredicates<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FCF14 Offset: 0x10F8F14 VA: 0x10FCF14
	|-Enumerable.CombineSelectors<KeyValuePair<int, object>, object, object>
	|
	|-RVA: 0x10FCFD8 Offset: 0x10F8FD8 VA: 0x10FCFD8
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x10FD09C Offset: 0x10F909C VA: 0x10FD09C
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x10FD160 Offset: 0x10F9160 VA: 0x10FD160
	|-Enumerable.CombineSelectors<RaycastResult, object, object>
	|
	|-RVA: 0x10FD224 Offset: 0x10F9224 VA: 0x10FD224
	|-Enumerable.CombineSelectors<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1106424 Offset: 0x1102424 VA: 0x1106424
	|-Enumerable.SelectMany<object, object>
	|
	|-RVA: 0x1106494 Offset: 0x1102494 VA: 0x1106494
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__17<TSource, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110662C Offset: 0x110262C VA: 0x110662C
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0x11066B8 Offset: 0x11026B8 VA: 0x11066B8
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1106508 Offset: 0x1102508 VA: 0x1106508
	|-Enumerable.SelectMany<object, object, object>
	|
	|-RVA: 0x1106598 Offset: 0x1102598 VA: 0x1106598
	|-Enumerable.SelectMany<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<SelectManyIterator>d__23<TSource, TCollection, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1106768 Offset: 0x1102768 VA: 0x1106768
	|-Enumerable.SelectManyIterator<object, object, object>
	|
	|-RVA: 0x1106810 Offset: 0x1102810 VA: 0x1106810
	|-Enumerable.SelectManyIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101FAC Offset: 0x10FDFAC VA: 0x1101FAC
	|-Enumerable.Join<object, object, object, object>
	|
	|-RVA: 0x1102078 Offset: 0x10FE078 VA: 0x1102078
	|-Enumerable.Join<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<JoinIterator>d__38<TOuter, TInner, TKey, TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102148 Offset: 0x10FE148 VA: 0x1102148
	|-Enumerable.JoinIterator<object, object, object, object>
	|
	|-RVA: 0x1102234 Offset: 0x10FE234 VA: 0x1102234
	|-Enumerable.JoinIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11035B4 Offset: 0x10FF5B4 VA: 0x11035B4
	|-Enumerable.OrderBy<GlyphPairAdjustmentRecord, uint>
	|
	|-RVA: 0x1103624 Offset: 0x10FF624 VA: 0x1103624
	|-Enumerable.OrderBy<Int32Enum, Int32Enum>
	|
	|-RVA: 0x1103694 Offset: 0x10FF694 VA: 0x1103694
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|
	|-RVA: 0x1103704 Offset: 0x10FF704 VA: 0x1103704
	|-Enumerable.OrderBy<MarkToBaseAdjustmentRecord, uint>
	|
	|-RVA: 0x1103774 Offset: 0x10FF774 VA: 0x1103774
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|
	|-RVA: 0x1104600 Offset: 0x1100600 VA: 0x1104600
	|-Enumerable.OrderBy<MarkToMarkAdjustmentRecord, uint>
	|
	|-RVA: 0x1104670 Offset: 0x1100670 VA: 0x1104670
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x11046E0 Offset: 0x11006E0 VA: 0x11046E0
	|-Enumerable.OrderBy<object, uint>
	|
	|-RVA: 0x1104750 Offset: 0x1100750 VA: 0x1104750
	|-Enumerable.OrderBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109034 Offset: 0x1105034 VA: 0x1109034
	|-Enumerable.ThenBy<GlyphPairAdjustmentRecord, uint>
	|
	|-RVA: 0x1109100 Offset: 0x1105100 VA: 0x1109100
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|
	|-RVA: 0x11091CC Offset: 0x11051CC VA: 0x11091CC
	|-Enumerable.ThenBy<MarkToBaseAdjustmentRecord, uint>
	|
	|-RVA: 0x1109298 Offset: 0x1105298 VA: 0x1109298
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|
	|-RVA: 0x1109364 Offset: 0x1105364 VA: 0x1109364
	|-Enumerable.ThenBy<MarkToMarkAdjustmentRecord, uint>
	|
	|-RVA: 0x1109430 Offset: 0x1105430 VA: 0x1109430
	|-Enumerable.ThenBy<object, uint>
	|
	|-RVA: 0x11094FC Offset: 0x11054FC VA: 0x11094FC
	|-Enumerable.ThenBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101D80 Offset: 0x10FDD80 VA: 0x1101D80
	|-Enumerable.GroupBy<object, object>
	|
	|-RVA: 0x1101E14 Offset: 0x10FDE14 VA: 0x1101E14
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101EB0 Offset: 0x10FDEB0 VA: 0x1101EB0
	|-Enumerable.GroupBy<object, object, object>
	|
	|-RVA: 0x1101F2C Offset: 0x10FDF2C VA: 0x1101F2C
	|-Enumerable.GroupBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD2F0 Offset: 0x10F92F0 VA: 0x10FD2F0
	|-Enumerable.Concat<object>
	|
	|-RVA: 0x10FD360 Offset: 0x10F9360 VA: 0x10FD360
	|-Enumerable.Concat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<ConcatIterator>d__59<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD3D4 Offset: 0x10F93D4 VA: 0x10FD3D4
	|-Enumerable.ConcatIterator<object>
	|
	|-RVA: 0x10FD460 Offset: 0x10F9460 VA: 0x10FD460
	|-Enumerable.ConcatIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FE764 Offset: 0x10FA764 VA: 0x10FE764
	|-Enumerable.Distinct<object>
	|
	|-RVA: 0x10FE7C4 Offset: 0x10FA7C4 VA: 0x10FE7C4
	|-Enumerable.Distinct<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<DistinctIterator>d__68<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FE828 Offset: 0x10FA828 VA: 0x10FE828
	|-Enumerable.DistinctIterator<object>
	|
	|-RVA: 0x10FE8B4 Offset: 0x10FA8B4 VA: 0x10FE8B4
	|-Enumerable.DistinctIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Union<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B620 Offset: 0x1107620 VA: 0x110B620
	|-Enumerable.Union<char>
	|
	|-RVA: 0x110B694 Offset: 0x1107694 VA: 0x110B694
	|-Enumerable.Union<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<UnionIterator>d__71<TSource>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B70C Offset: 0x110770C VA: 0x110B70C
	|-Enumerable.UnionIterator<char>
	|
	|-RVA: 0x110B7B4 Offset: 0x11077B4 VA: 0x110B7B4
	|-Enumerable.UnionIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11095C8 Offset: 0x11055C8 VA: 0x11095C8
	|-Enumerable.ToArray<ValueTuple<object, int>>
	|
	|-RVA: 0x1109650 Offset: 0x1105650 VA: 0x1109650
	|-Enumerable.ToArray<ValueTuple<object, float>>
	|
	|-RVA: 0x11096D8 Offset: 0x11056D8 VA: 0x11096D8
	|-Enumerable.ToArray<byte>
	|
	|-RVA: 0x1109760 Offset: 0x1105760 VA: 0x1109760
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x11097E8 Offset: 0x11057E8 VA: 0x11097E8
	|-Enumerable.ToArray<object>
	|
	|-RVA: 0x1109870 Offset: 0x1105870 VA: 0x1109870
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x11098F8 Offset: 0x11058F8 VA: 0x11098F8
	|-Enumerable.ToArray<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110AF9C Offset: 0x1106F9C VA: 0x110AF9C
	|-Enumerable.ToList<KeyValuePair<object, double>>
	|
	|-RVA: 0x110B01C Offset: 0x110701C VA: 0x110B01C
	|-Enumerable.ToList<KeyValuePair<object, int>>
	|
	|-RVA: 0x110B09C Offset: 0x110709C VA: 0x110B09C
	|-Enumerable.ToList<KeyValuePair<object, long>>
	|
	|-RVA: 0x110B11C Offset: 0x110711C VA: 0x110B11C
	|-Enumerable.ToList<byte>
	|
	|-RVA: 0x110B19C Offset: 0x110719C VA: 0x110B19C
	|-Enumerable.ToList<DictionaryEntry>
	|
	|-RVA: 0x110B21C Offset: 0x110721C VA: 0x110B21C
	|-Enumerable.ToList<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x110B29C Offset: 0x110729C VA: 0x110B29C
	|-Enumerable.ToList<int>
	|
	|-RVA: 0x110B31C Offset: 0x110731C VA: 0x110B31C
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x110B39C Offset: 0x110739C VA: 0x110B39C
	|-Enumerable.ToList<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x110B41C Offset: 0x110741C VA: 0x110B41C
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x110B49C Offset: 0x110749C VA: 0x110B49C
	|-Enumerable.ToList<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x110B51C Offset: 0x110751C VA: 0x110B51C
	|-Enumerable.ToList<object>
	|
	|-RVA: 0x110B59C Offset: 0x110759C VA: 0x110B59C
	|-Enumerable.ToList<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109984 Offset: 0x1105984 VA: 0x1109984
	|-Enumerable.ToDictionary<object, object>
	|
	|-RVA: 0x11099D8 Offset: 0x11059D8 VA: 0x11099D8
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109A34 Offset: 0x1105A34 VA: 0x1109A34
	|-Enumerable.ToDictionary<KeyValuePair<ObjectIntPair<object>, object>, ObjectIntPair<object>, object>
	|
	|-RVA: 0x1109A88 Offset: 0x1105A88 VA: 0x1109A88
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x1109ADC Offset: 0x1105ADC VA: 0x1109ADC
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x1109B30 Offset: 0x1105B30 VA: 0x1109B30
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x1109B84 Offset: 0x1105B84 VA: 0x1109B84
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109BDC Offset: 0x1105BDC VA: 0x1109BDC
	|-Enumerable.ToDictionary<KeyValuePair<ObjectIntPair<object>, object>, ObjectIntPair<object>, object>
	|
	|-RVA: 0x1109F94 Offset: 0x1105F94 VA: 0x1109F94
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x110A328 Offset: 0x1106328 VA: 0x110A328
	|-Enumerable.ToDictionary<object, object, Int32Enum>
	|
	|-RVA: 0x110A6A8 Offset: 0x11066A8 VA: 0x110A6A8
	|-Enumerable.ToDictionary<object, object, object>
	|
	|-RVA: 0x110AA28 Offset: 0x1106A28 VA: 0x110AA28
	|-Enumerable.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FC760 Offset: 0x10F8760 VA: 0x10FC760
	|-Enumerable.Cast<DictionaryEntry>
	|
	|-RVA: 0x10FC7F0 Offset: 0x10F87F0 VA: 0x10FC7F0
	|-Enumerable.Cast<object>
	|
	|-RVA: 0x10FC880 Offset: 0x10F8880 VA: 0x10FC880
	|-Enumerable.Cast<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<CastIterator>d__99<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FC914 Offset: 0x10F8914 VA: 0x10FC914
	|-Enumerable.CastIterator<DictionaryEntry>
	|
	|-RVA: 0x10FC98C Offset: 0x10F898C VA: 0x10FC98C
	|-Enumerable.CastIterator<object>
	|
	|-RVA: 0x10FCA04 Offset: 0x10F8A04 VA: 0x10FCA04
	|-Enumerable.CastIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FF6D4 Offset: 0x10FB6D4 VA: 0x10FF6D4
	|-Enumerable.First<KeyValuePair<object, long>>
	|
	|-RVA: 0x10FFB0C Offset: 0x10FBB0C VA: 0x10FFB0C
	|-Enumerable.First<object>
	|
	|-RVA: 0x10FFF30 Offset: 0x10FBF30 VA: 0x10FFF30
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100470 Offset: 0x10FC470 VA: 0x1100470
	|-Enumerable.First<object>
	|
	|-RVA: 0x1100794 Offset: 0x10FC794 VA: 0x1100794
	|-Enumerable.First<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100C48 Offset: 0x10FCC48 VA: 0x1100C48
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x1101064 Offset: 0x10FD064 VA: 0x1101064
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11015A8 Offset: 0x10FD5A8 VA: 0x11015A8
	|-Enumerable.FirstOrDefault<object>
	|
	|-RVA: 0x11018C4 Offset: 0x10FD8C4 VA: 0x11018C4
	|-Enumerable.FirstOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102374 Offset: 0x10FE374 VA: 0x1102374
	|-Enumerable.Last<object>
	|
	|-RVA: 0x1102808 Offset: 0x10FE808 VA: 0x1102808
	|-Enumerable.Last<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102E08 Offset: 0x10FEE08 VA: 0x1102E08
	|-Enumerable.LastOrDefault<object>
	|
	|-RVA: 0x1103118 Offset: 0x10FF118 VA: 0x1103118
	|-Enumerable.LastOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11068E0 Offset: 0x11028E0 VA: 0x11068E0
	|-Enumerable.Single<object>
	|
	|-RVA: 0x1106D94 Offset: 0x1102D94 VA: 0x1106D94
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource Single<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11073D8 Offset: 0x11033D8 VA: 0x11073D8
	|-Enumerable.Single<object>
	|
	|-RVA: 0x1107740 Offset: 0x1103740 VA: 0x1107740
	|-Enumerable.Single<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1107C64 Offset: 0x1103C64 VA: 0x1107C64
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x1108110 Offset: 0x1104110 VA: 0x1108110
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108794 Offset: 0x1104794 VA: 0x1108794
	|-Enumerable.SingleOrDefault<object>
	|
	|-RVA: 0x1108AF8 Offset: 0x1104AF8 VA: 0x1108AF8
	|-Enumerable.SingleOrDefault<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FE964 Offset: 0x10FA964 VA: 0x10FE964
	|-Enumerable.ElementAt<KeyValuePair<int, object>>
	|
	|-RVA: 0x10FED38 Offset: 0x10FAD38 VA: 0x10FED38
	|-Enumerable.ElementAt<object>
	|
	|-RVA: 0x10FF104 Offset: 0x10FB104 VA: 0x10FF104
	|-Enumerable.ElementAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11047C4 Offset: 0x11007C4 VA: 0x11047C4
	|-Enumerable.Repeat<byte>
	|
	|-RVA: 0x1104824 Offset: 0x1100824 VA: 0x1104824
	|-Enumerable.Repeat<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Enumerable.<RepeatIterator>d__117<TResult>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1104930 Offset: 0x1100930 VA: 0x1104930
	|-Enumerable.RepeatIterator<byte>
	|
	|-RVA: 0x11049A4 Offset: 0x11009A4 VA: 0x11049A4
	|-Enumerable.RepeatIterator<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Empty<TResult>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FF60C Offset: 0x10FB60C VA: 0x10FF60C
	|-Enumerable.Empty<object>
	|
	|-RVA: 0x10FF670 Offset: 0x10FB670 VA: 0x10FF670
	|-Enumerable.Empty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FB5EC Offset: 0x10F75EC VA: 0x10FB5EC
	|-Enumerable.Any<object>
	|
	|-RVA: 0x10FB81C Offset: 0x10F781C VA: 0x10FB81C
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FBA4C Offset: 0x10F7A4C VA: 0x10FBA4C
	|-Enumerable.Any<KeyValuePair<int, object>>
	|
	|-RVA: 0x10FBD58 Offset: 0x10F7D58 VA: 0x10FBD58
	|-Enumerable.Any<KeyValuePair<object, object>>
	|
	|-RVA: 0x10FC064 Offset: 0x10F8064 VA: 0x10FC064
	|-Enumerable.Any<object>
	|
	|-RVA: 0x10FC364 Offset: 0x10F8364 VA: 0x10FC364
	|-Enumerable.Any<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAF00 Offset: 0x10F6F00 VA: 0x10FAF00
	|-Enumerable.All<object>
	|
	|-RVA: 0x10FB1F8 Offset: 0x10F71F8 VA: 0x10FB1F8
	|-Enumerable.All<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FE034 Offset: 0x10FA034 VA: 0x10FE034
	|-Enumerable.Count<object>
	|
	|-RVA: 0x10FE3CC Offset: 0x10FA3CC VA: 0x10FE3CC
	|-Enumerable.Count<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD510 Offset: 0x10F9510 VA: 0x10FD510
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x10FD610 Offset: 0x10F9610 VA: 0x10FD610
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD7CC Offset: 0x10F97CC VA: 0x10FD7CC
	|-Enumerable.Contains<object>
	|
	|-RVA: 0x10FDB54 Offset: 0x10F9B54 VA: 0x10FDB54
	|-Enumerable.Contains<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq
internal class EmptyEnumerable<TElement> // TypeDefIndex: 5373
{
	// Fields
	public static readonly TElement[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CAF30 Offset: 0x11C6F30 VA: 0x11CAF30
	|-EmptyEnumerable<object>..cctor
	|
	|-RVA: 0x11CAFF0 Offset: 0x11C6FF0 VA: 0x11CAFF0
	|-EmptyEnumerable<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IdentityFunction.<>c<TElement> // TypeDefIndex: 5374
{
	// Fields
	public static readonly IdentityFunction.<>c<TElement> <>9; // 0x0
	public static Func<TElement, TElement> <>9__1_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150DD0 Offset: 0x114CDD0 VA: 0x1150DD0
	|-IdentityFunction.<>c<object>..cctor
	|
	|-RVA: 0x1151680 Offset: 0x114D680 VA: 0x1151680
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150EA8 Offset: 0x114CEA8 VA: 0x1150EA8
	|-IdentityFunction.<>c<object>..ctor
	|
	|-RVA: 0x115178C Offset: 0x114D78C VA: 0x115178C
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement <get_Instance>b__1_0(TElement x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150EB0 Offset: 0x114CEB0 VA: 0x1150EB0
	|-IdentityFunction.<>c<object>.<get_Instance>b__1_0
	|
	|-RVA: 0x1151794 Offset: 0x114D794 VA: 0x1151794
	|-IdentityFunction.<>c<__Il2CppFullySharedGenericType>.<get_Instance>b__1_0
	*/
}

// Namespace: System.Linq
internal class IdentityFunction<TElement> // TypeDefIndex: 5375
{
	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C2BC Offset: 0x12782BC VA: 0x127C2BC
	|-IdentityFunction<object>.get_Instance
	|
	|-RVA: 0x127C4C4 Offset: 0x12784C4 VA: 0x127C4C4
	|-IdentityFunction<__Il2CppFullySharedGenericType>.get_Instance
	*/
}

// Namespace: System.Linq
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 5376
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<__Il2CppFullySharedGenericType>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq
public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 5377
{
	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 5378
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public Lookup.Grouping<TKey, TElement> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11666E0 Offset: 0x11626E0 VA: 0x11666E0
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>..ctor
	|
	|-RVA: 0x11667E8 Offset: 0x11627E8 VA: 0x11667E8
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166708 Offset: 0x1162708 VA: 0x1166708
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1166828 Offset: 0x1162828 VA: 0x1166828
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116670C Offset: 0x116270C VA: 0x116670C
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.MoveNext
	|
	|-RVA: 0x116682C Offset: 0x116282C VA: 0x116682C
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11667A4 Offset: 0x11627A4 VA: 0x11667A4
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1166AA8 Offset: 0x1162AA8 VA: 0x1166AA8
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11667AC Offset: 0x11627AC VA: 0x11667AC
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1166AEC Offset: 0x1162AEC VA: 0x1166AEC
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11667E0 Offset: 0x11627E0 VA: 0x11667E0
	|-Lookup.Grouping.<GetEnumerator>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1166B20 Offset: 0x1162B20 VA: 0x1166B20
	|-Lookup.Grouping.<GetEnumerator>d__7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 5379
{
	// Fields
	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	// Properties
	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127096C Offset: 0x126C96C VA: 0x127096C
	|-Lookup.Grouping<object, object>.Add
	|
	|-RVA: 0x1270C24 Offset: 0x126CC24 VA: 0x1270C24
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	[IteratorStateMachine(typeof(Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270A14 Offset: 0x126CA14 VA: 0x1270A14
	|-Lookup.Grouping<object, object>.GetEnumerator
	|
	|-RVA: 0x1270EC0 Offset: 0x126CEC0 VA: 0x1270EC0
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270A90 Offset: 0x126CA90 VA: 0x1270A90
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1270F50 Offset: 0x126CF50 VA: 0x1270F50
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AA0 Offset: 0x126CAA0 VA: 0x1270AA0
	|-Lookup.Grouping<object, object>.get_Key
	|
	|-RVA: 0x1270F64 Offset: 0x126CF64 VA: 0x1270F64
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AA8 Offset: 0x126CAA8 VA: 0x1270AA8
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x1270FA4 Offset: 0x126CFA4 VA: 0x1270FA4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AB0 Offset: 0x126CAB0 VA: 0x1270AB0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|
	|-RVA: 0x1270FCC Offset: 0x126CFCC VA: 0x1270FCC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AB8 Offset: 0x126CAB8 VA: 0x1270AB8
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x1270FD4 Offset: 0x126CFD4 VA: 0x1270FD4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AD0 Offset: 0x126CAD0 VA: 0x1270AD0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x1270FEC Offset: 0x126CFEC VA: 0x1270FEC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270AE8 Offset: 0x126CAE8 VA: 0x1270AE8
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x1271004 Offset: 0x126D004 VA: 0x1271004
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270B1C Offset: 0x126CB1C VA: 0x1270B1C
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x1271138 Offset: 0x126D138 VA: 0x1271138
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270B3C Offset: 0x126CB3C VA: 0x1270B3C
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x12711B4 Offset: 0x126D1B4 VA: 0x12711B4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270B54 Offset: 0x126CB54 VA: 0x1270B54
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x12711CC Offset: 0x126D1CC VA: 0x12711CC
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270B74 Offset: 0x126CB74 VA: 0x1270B74
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x12712F8 Offset: 0x126D2F8 VA: 0x12712F8
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270B8C Offset: 0x126CB8C VA: 0x1270B8C
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x1271310 Offset: 0x126D310 VA: 0x1271310
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270BA4 Offset: 0x126CBA4 VA: 0x1270BA4
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x1271328 Offset: 0x126D328 VA: 0x1271328
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270C04 Offset: 0x126CC04 VA: 0x1270C04
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x12713F4 Offset: 0x126D3F4 VA: 0x12713F4
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270C1C Offset: 0x126CC1C VA: 0x1270C1C
	|-Lookup.Grouping<object, object>..ctor
	|
	|-RVA: 0x127140C Offset: 0x126D40C VA: 0x127140C
	|-Lookup.Grouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Lookup.<GetEnumerator>d__12<TKey, TElement> : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator // TypeDefIndex: 5380
{
	// Fields
	private int <>1__state; // 0x0
	private IGrouping<TKey, TElement> <>2__current; // 0x0
	public Lookup<TKey, TElement> <>4__this; // 0x0
	private Lookup.Grouping<TKey, TElement> <g>5__2; // 0x0

	// Properties
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164878 Offset: 0x1160878 VA: 0x1164878
	|-Lookup.<GetEnumerator>d__12<object, object>..ctor
	|
	|-RVA: 0x1164998 Offset: 0x1160998 VA: 0x1164998
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11648A0 Offset: 0x11608A0 VA: 0x11648A0
	|-Lookup.<GetEnumerator>d__12<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x11649C0 Offset: 0x11609C0 VA: 0x11649C0
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11648A4 Offset: 0x11608A4 VA: 0x11648A4
	|-Lookup.<GetEnumerator>d__12<object, object>.MoveNext
	|
	|-RVA: 0x11649C4 Offset: 0x11609C4 VA: 0x11649C4
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164954 Offset: 0x1160954 VA: 0x1164954
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	|
	|-RVA: 0x1164A8C Offset: 0x1160A8C VA: 0x1164A8C
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116495C Offset: 0x116095C VA: 0x116495C
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1164A94 Offset: 0x1160A94 VA: 0x1164A94
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164990 Offset: 0x1160990 VA: 0x1164990
	|-Lookup.<GetEnumerator>d__12<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1164AC8 Offset: 0x1160AC8 VA: 0x1164AC8
	|-Lookup.<GetEnumerator>d__12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 5381
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1005590 Offset: 0x1001590 VA: 0x1005590
	|-Lookup<object, object>.Create<object>
	|
	|-RVA: 0x1005998 Offset: 0x1001998 VA: 0x1005998
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> CreateForJoin(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1390EA0 Offset: 0x138CEA0 VA: 0x1390EA0
	|-Lookup<object, object>.CreateForJoin
	|
	|-RVA: 0x1391838 Offset: 0x138D838 VA: 0x1391838
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateForJoin
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13912A0 Offset: 0x138D2A0 VA: 0x13912A0
	|-Lookup<object, object>..ctor
	|
	|-RVA: 0x139200C Offset: 0x138E00C VA: 0x139200C
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(Lookup.<GetEnumerator>d__12<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391320 Offset: 0x138D320 VA: 0x1391320
	|-Lookup<object, object>.GetEnumerator
	|
	|-RVA: 0x1392090 Offset: 0x138E090 VA: 0x1392090
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139139C Offset: 0x138D39C VA: 0x139139C
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1392110 Offset: 0x138E110 VA: 0x1392110
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13913AC Offset: 0x138D3AC VA: 0x13913AC
	|-Lookup<object, object>.InternalGetHashCode
	|
	|-RVA: 0x1392124 Offset: 0x138E124 VA: 0x1392124
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391460 Offset: 0x138D460 VA: 0x1391460
	|-Lookup<object, object>.GetGrouping
	|
	|-RVA: 0x13922CC Offset: 0x138E2CC VA: 0x13922CC
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1391714 Offset: 0x138D714 VA: 0x1391714
	|-Lookup<object, object>.Resize
	|
	|-RVA: 0x13927DC Offset: 0x138E7DC VA: 0x13927DC
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/
}

// Namespace: 
internal struct Set.Slot<TElement> // TypeDefIndex: 5382
{
	// Fields
	internal int hashCode; // 0x0
	internal TElement value; // 0x0
	internal int next; // 0x0
}

// Namespace: System.Linq
internal class Set<TElement> // TypeDefIndex: 5383
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456DB0 Offset: 0x1452DB0 VA: 0x1456DB0
	|-Set<char>..ctor
	|
	|-RVA: 0x1457320 Offset: 0x1453320 VA: 0x1457320
	|-Set<object>..ctor
	|
	|-RVA: 0x14578B8 Offset: 0x14538B8 VA: 0x14578B8
	|-Set<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456E8C Offset: 0x1452E8C VA: 0x1456E8C
	|-Set<char>.Add
	|
	|-RVA: 0x14573FC Offset: 0x14533FC VA: 0x14573FC
	|-Set<object>.Add
	|
	|-RVA: 0x1457998 Offset: 0x1453998 VA: 0x1457998
	|-Set<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456EB4 Offset: 0x1452EB4 VA: 0x1456EB4
	|-Set<char>.Find
	|
	|-RVA: 0x1457424 Offset: 0x1453424 VA: 0x1457424
	|-Set<object>.Find
	|
	|-RVA: 0x1457A6C Offset: 0x1453A6C VA: 0x1457A6C
	|-Set<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1457118 Offset: 0x1453118 VA: 0x1457118
	|-Set<char>.Resize
	|
	|-RVA: 0x14576A4 Offset: 0x14536A4 VA: 0x14576A4
	|-Set<object>.Resize
	|
	|-RVA: 0x1457F88 Offset: 0x1453F88 VA: 0x1457F88
	|-Set<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1457278 Offset: 0x1453278 VA: 0x1457278
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x1457804 Offset: 0x1453804 VA: 0x1457804
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x1458160 Offset: 0x1454160 VA: 0x1458160
	|-Set<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}

// Namespace: System.Linq
internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 5384
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270740 Offset: 0x126C740 VA: 0x1270740
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x1270850 Offset: 0x126C850 VA: 0x1270850
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270800 Offset: 0x126C800 VA: 0x1270800
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|
	|-RVA: 0x1270910 Offset: 0x126C910 VA: 0x1270910
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270840 Offset: 0x126C840 VA: 0x1270840
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1270958 Offset: 0x126C958 VA: 0x1270958
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class OrderedEnumerable.<GetEnumerator>d__1<TElement> : IEnumerator<TElement>, IDisposable, IEnumerator // TypeDefIndex: 5385
{
	// Fields
	private int <>1__state; // 0x0
	private TElement <>2__current; // 0x0
	public OrderedEnumerable<TElement> <>4__this; // 0x0
	private Buffer<TElement> <buffer>5__2; // 0x0
	private int[] <map>5__3; // 0x0
	private int <i>5__4; // 0x0

	// Properties
	private TElement System.Collections.Generic.IEnumerator<TElement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1163558 Offset: 0x115F558 VA: 0x1163558
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x1163778 Offset: 0x115F778 VA: 0x1163778
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>..ctor
	|
	|-RVA: 0x1163958 Offset: 0x115F958 VA: 0x1163958
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x1163B64 Offset: 0x115FB64 VA: 0x1163B64
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x1163D70 Offset: 0x115FD70 VA: 0x1163D70
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x1163F7C Offset: 0x115FF7C VA: 0x1163F7C
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x1164188 Offset: 0x1160188 VA: 0x1164188
	|-OrderedEnumerable.<GetEnumerator>d__1<object>..ctor
	|
	|-RVA: 0x1164354 Offset: 0x1160354 VA: 0x1164354
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1163580 Offset: 0x115F580 VA: 0x1163580
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.IDisposable.Dispose
	|
	|-RVA: 0x11637A0 Offset: 0x115F7A0 VA: 0x11637A0
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0x1163980 Offset: 0x115F980 VA: 0x1163980
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.IDisposable.Dispose
	|
	|-RVA: 0x1163B8C Offset: 0x115FB8C VA: 0x1163B8C
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.IDisposable.Dispose
	|
	|-RVA: 0x1163D98 Offset: 0x115FD98 VA: 0x1163D98
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.IDisposable.Dispose
	|
	|-RVA: 0x1163FA4 Offset: 0x115FFA4 VA: 0x1163FA4
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.IDisposable.Dispose
	|
	|-RVA: 0x11641B0 Offset: 0x11601B0 VA: 0x11641B0
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1164394 Offset: 0x1160394 VA: 0x1164394
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1163584 Offset: 0x115F584 VA: 0x1163584
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x11637A4 Offset: 0x115F7A4 VA: 0x11637A4
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.MoveNext
	|
	|-RVA: 0x1163984 Offset: 0x115F984 VA: 0x1163984
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1163B90 Offset: 0x115FB90 VA: 0x1163B90
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1163D9C Offset: 0x115FD9C VA: 0x1163D9C
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1163FA8 Offset: 0x115FFA8 VA: 0x1163FA8
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x11641B4 Offset: 0x11601B4 VA: 0x11641B4
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.MoveNext
	|
	|-RVA: 0x1164398 Offset: 0x1160398 VA: 0x1164398
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11636F0 Offset: 0x115F6F0 VA: 0x11636F0
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x11638F4 Offset: 0x115F8F4 VA: 0x11638F4
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1163AE4 Offset: 0x115FAE4 VA: 0x1163AE4
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1163CF0 Offset: 0x115FCF0 VA: 0x1163CF0
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1163EFC Offset: 0x115FEFC VA: 0x1163EFC
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1164108 Offset: 0x1160108 VA: 0x1164108
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x1164310 Offset: 0x1160310 VA: 0x1164310
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	|
	|-RVA: 0x116475C Offset: 0x116075C VA: 0x116475C
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TElement>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1163708 Offset: 0x115F708 VA: 0x1163708
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11638FC Offset: 0x115F8FC VA: 0x11638FC
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1163AF8 Offset: 0x115FAF8 VA: 0x1163AF8
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1163D04 Offset: 0x115FD04 VA: 0x1163D04
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1163F10 Offset: 0x115FF10 VA: 0x1163F10
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116411C Offset: 0x116011C VA: 0x116411C
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1164318 Offset: 0x1160318 VA: 0x1164318
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11647A0 Offset: 0x11607A0 VA: 0x11647A0
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116373C Offset: 0x115F73C VA: 0x116373C
	|-OrderedEnumerable.<GetEnumerator>d__1<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1163930 Offset: 0x115F930 VA: 0x1163930
	|-OrderedEnumerable.<GetEnumerator>d__1<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1163B2C Offset: 0x115FB2C VA: 0x1163B2C
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1163D38 Offset: 0x115FD38 VA: 0x1163D38
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1163F44 Offset: 0x115FF44 VA: 0x1163F44
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1164150 Offset: 0x1160150 VA: 0x1164150
	|-OrderedEnumerable.<GetEnumerator>d__1<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116434C Offset: 0x116034C VA: 0x116434C
	|-OrderedEnumerable.<GetEnumerator>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11647D4 Offset: 0x11607D4 VA: 0x11647D4
	|-OrderedEnumerable.<GetEnumerator>d__1<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 5386
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachine(typeof(OrderedEnumerable.<GetEnumerator>d__1<TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FDB14 Offset: 0x13F9B14 VA: 0x13FDB14
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x13FDBA8 Offset: 0x13F9BA8 VA: 0x13FDBA8
	|-OrderedEnumerable<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x13FDC3C Offset: 0x13F9C3C VA: 0x13FDC3C
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x13FDCD0 Offset: 0x13F9CD0 VA: 0x13FDCD0
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x13FDD64 Offset: 0x13F9D64 VA: 0x13FDD64
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x13FDDF8 Offset: 0x13F9DF8 VA: 0x13FDDF8
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x13FDE8C Offset: 0x13F9E8C VA: 0x13FDE8C
	|-OrderedEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x13FDF20 Offset: 0x13F9F20 VA: 0x13FDF20
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FDB90 Offset: 0x13F9B90 VA: 0x13FDB90
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDC24 Offset: 0x13F9C24 VA: 0x13FDC24
	|-OrderedEnumerable<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDCB8 Offset: 0x13F9CB8 VA: 0x13FDCB8
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDD4C Offset: 0x13F9D4C VA: 0x13FDD4C
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDDE0 Offset: 0x13F9DE0 VA: 0x13FDDE0
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDE74 Offset: 0x13F9E74 VA: 0x13FDE74
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDF08 Offset: 0x13F9F08 VA: 0x13FDF08
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13FDFB0 Offset: 0x13F9FB0 VA: 0x13FDFB0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10060E0 Offset: 0x10020E0 VA: 0x10060E0
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x1006184 Offset: 0x1002184 VA: 0x1006184
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x1006228 Offset: 0x1002228 VA: 0x1006228
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x10062CC Offset: 0x10022CC VA: 0x10062CC
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x1006370 Offset: 0x1002370 VA: 0x1006370
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x1006414 Offset: 0x1002414 VA: 0x1006414
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|
	|-RVA: 0x10064B8 Offset: 0x10024B8 VA: 0x10064B8
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FDBA0 Offset: 0x13F9BA0 VA: 0x13FDBA0
	|-OrderedEnumerable<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x13FDC34 Offset: 0x13F9C34 VA: 0x13FDC34
	|-OrderedEnumerable<Int32Enum>..ctor
	|
	|-RVA: 0x13FDCC8 Offset: 0x13F9CC8 VA: 0x13FDCC8
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x13FDD5C Offset: 0x13F9D5C VA: 0x13FDD5C
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x13FDDF0 Offset: 0x13F9DF0 VA: 0x13FDDF0
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x13FDE84 Offset: 0x13F9E84 VA: 0x13FDE84
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x13FDF18 Offset: 0x13F9F18 VA: 0x13FDF18
	|-OrderedEnumerable<object>..ctor
	|
	|-RVA: 0x13FDFC4 Offset: 0x13F9FC4 VA: 0x13FDFC4
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 5387
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FDFCC Offset: 0x13F9FCC VA: 0x13FDFCC
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x13FE150 Offset: 0x13FA150 VA: 0x13FE150
	|-OrderedEnumerable<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x13FE2D4 Offset: 0x13FA2D4 VA: 0x13FE2D4
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x13FE458 Offset: 0x13FA458 VA: 0x13FE458
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x13FE5DC Offset: 0x13FA5DC VA: 0x13FE5DC
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x13FE760 Offset: 0x13FA760 VA: 0x13FE760
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x13FE8E4 Offset: 0x13FA8E4 VA: 0x13FE8E4
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x13FEA68 Offset: 0x13FAA68 VA: 0x13FEA68
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x13FEBEC Offset: 0x13FABEC VA: 0x13FEBEC
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FE0A0 Offset: 0x13FA0A0 VA: 0x13FE0A0
	|-OrderedEnumerable<GlyphPairAdjustmentRecord, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FE224 Offset: 0x13FA224 VA: 0x13FE224
	|-OrderedEnumerable<Int32Enum, Int32Enum>.GetEnumerableSorter
	|
	|-RVA: 0x13FE3A8 Offset: 0x13FA3A8 VA: 0x13FE3A8
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FE52C Offset: 0x13FA52C VA: 0x13FE52C
	|-OrderedEnumerable<MarkToBaseAdjustmentRecord, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FE6B0 Offset: 0x13FA6B0 VA: 0x13FE6B0
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FE834 Offset: 0x13FA834 VA: 0x13FE834
	|-OrderedEnumerable<MarkToMarkAdjustmentRecord, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FE9B8 Offset: 0x13FA9B8 VA: 0x13FE9B8
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|
	|-RVA: 0x13FEB3C Offset: 0x13FAB3C VA: 0x13FEB3C
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|
	|-RVA: 0x13FECD0 Offset: 0x13FACD0 VA: 0x13FECD0
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/
}

// Namespace: System.Linq
internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 5388
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4768 Offset: 0x11E0768 VA: 0x11E4768
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.Sort
	|
	|-RVA: 0x11E4A04 Offset: 0x11E0A04 VA: 0x11E4A04
	|-EnumerableSorter<Int32Enum>.Sort
	|
	|-RVA: 0x11E4CA0 Offset: 0x11E0CA0 VA: 0x11E4CA0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x11E4F3C Offset: 0x11E0F3C VA: 0x11E4F3C
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x11E51D8 Offset: 0x11E11D8 VA: 0x11E51D8
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x11E5474 Offset: 0x11E1474 VA: 0x11E5474
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x11E5710 Offset: 0x11E1710 VA: 0x11E5710
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x11E59AC Offset: 0x11E19AC VA: 0x11E59AC
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4848 Offset: 0x11E0848 VA: 0x11E4848
	|-EnumerableSorter<GlyphPairAdjustmentRecord>.QuickSort
	|
	|-RVA: 0x11E4AE4 Offset: 0x11E0AE4 VA: 0x11E4AE4
	|-EnumerableSorter<Int32Enum>.QuickSort
	|
	|-RVA: 0x11E4D80 Offset: 0x11E0D80 VA: 0x11E4D80
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|
	|-RVA: 0x11E501C Offset: 0x11E101C VA: 0x11E501C
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>.QuickSort
	|
	|-RVA: 0x11E52B8 Offset: 0x11E12B8 VA: 0x11E52B8
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|
	|-RVA: 0x11E5554 Offset: 0x11E1554 VA: 0x11E5554
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>.QuickSort
	|
	|-RVA: 0x11E57F0 Offset: 0x11E17F0 VA: 0x11E57F0
	|-EnumerableSorter<object>.QuickSort
	|
	|-RVA: 0x11E5A90 Offset: 0x11E1A90 VA: 0x11E5A90
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E49FC Offset: 0x11E09FC VA: 0x11E49FC
	|-EnumerableSorter<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x11E4C98 Offset: 0x11E0C98 VA: 0x11E4C98
	|-EnumerableSorter<Int32Enum>..ctor
	|
	|-RVA: 0x11E4F34 Offset: 0x11E0F34 VA: 0x11E4F34
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x11E51D0 Offset: 0x11E11D0 VA: 0x11E51D0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x11E546C Offset: 0x11E146C VA: 0x11E546C
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x11E5708 Offset: 0x11E1708 VA: 0x11E5708
	|-EnumerableSorter<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x11E59A4 Offset: 0x11E19A4 VA: 0x11E59A4
	|-EnumerableSorter<object>..ctor
	|
	|-RVA: 0x11E5C4C Offset: 0x11E1C4C VA: 0x11E5C4C
	|-EnumerableSorter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Linq
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 5389
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5C54 Offset: 0x11E1C54 VA: 0x11E5C54
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x11E5F04 Offset: 0x11E1F04 VA: 0x11E5F04
	|-EnumerableSorter<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x11E61A8 Offset: 0x11E21A8 VA: 0x11E61A8
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x11E6458 Offset: 0x11E2458 VA: 0x11E6458
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x11E6708 Offset: 0x11E2708 VA: 0x11E6708
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x11E69B8 Offset: 0x11E29B8 VA: 0x11E69B8
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x11E6D54 Offset: 0x11E2D54 VA: 0x11E6D54
	|-EnumerableSorter<object, int>..ctor
	|
	|-RVA: 0x11E7000 Offset: 0x11E3000 VA: 0x11E7000
	|-EnumerableSorter<object, uint>..ctor
	|
	|-RVA: 0x11E72AC Offset: 0x11E32AC VA: 0x11E72AC
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5CBC Offset: 0x11E1CBC VA: 0x11E5CBC
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x11E5F6C Offset: 0x11E1F6C VA: 0x11E5F6C
	|-EnumerableSorter<Int32Enum, Int32Enum>.ComputeKeys
	|
	|-RVA: 0x11E6210 Offset: 0x11E2210 VA: 0x11E6210
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x11E64C0 Offset: 0x11E24C0 VA: 0x11E64C0
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x11E6770 Offset: 0x11E2770 VA: 0x11E6770
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x11E6A20 Offset: 0x11E2A20 VA: 0x11E6A20
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.ComputeKeys
	|
	|-RVA: 0x11E6DC4 Offset: 0x11E2DC4 VA: 0x11E6DC4
	|-EnumerableSorter<object, int>.ComputeKeys
	|
	|-RVA: 0x11E7070 Offset: 0x11E3070 VA: 0x11E7070
	|-EnumerableSorter<object, uint>.ComputeKeys
	|
	|-RVA: 0x11E7320 Offset: 0x11E3320 VA: 0x11E7320
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5DD4 Offset: 0x11E1DD4 VA: 0x11E5DD4
	|-EnumerableSorter<GlyphPairAdjustmentRecord, uint>.CompareKeys
	|
	|-RVA: 0x11E6078 Offset: 0x11E2078 VA: 0x11E6078
	|-EnumerableSorter<Int32Enum, Int32Enum>.CompareKeys
	|
	|-RVA: 0x11E6328 Offset: 0x11E2328 VA: 0x11E6328
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|
	|-RVA: 0x11E65D8 Offset: 0x11E25D8 VA: 0x11E65D8
	|-EnumerableSorter<MarkToBaseAdjustmentRecord, uint>.CompareKeys
	|
	|-RVA: 0x11E6888 Offset: 0x11E2888 VA: 0x11E6888
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|
	|-RVA: 0x11E6B38 Offset: 0x11E2B38 VA: 0x11E6B38
	|-EnumerableSorter<MarkToMarkAdjustmentRecord, uint>.CompareKeys
	|
	|-RVA: 0x11E6ED0 Offset: 0x11E2ED0 VA: 0x11E6ED0
	|-EnumerableSorter<object, int>.CompareKeys
	|
	|-RVA: 0x11E717C Offset: 0x11E317C VA: 0x11E717C
	|-EnumerableSorter<object, uint>.CompareKeys
	|
	|-RVA: 0x11E7560 Offset: 0x11E3560 VA: 0x11E7560
	|-EnumerableSorter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareKeys
	*/
}

// Namespace: System.Linq
internal struct Buffer<TElement> // TypeDefIndex: 5390
{
	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8388 Offset: 0x14D4388 VA: 0x14D8388
	|-Buffer<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x14D8A38 Offset: 0x14D4A38 VA: 0x14D8A38
	|-Buffer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x14D90E8 Offset: 0x14D50E8 VA: 0x14D90E8
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x14D9788 Offset: 0x14D5788 VA: 0x14D9788
	|-Buffer<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x14D9E88 Offset: 0x14D5E88 VA: 0x14D9E88
	|-Buffer<int>..ctor
	|
	|-RVA: 0x14DA528 Offset: 0x14D6528 VA: 0x14DA528
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x14DABC8 Offset: 0x14D6BC8 VA: 0x14DABC8
	|-Buffer<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x14DB2B0 Offset: 0x14D72B0 VA: 0x14DB2B0
	|-Buffer<MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x14DB998 Offset: 0x14D7998 VA: 0x14DB998
	|-Buffer<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x14DC080 Offset: 0x14D8080 VA: 0x14DC080
	|-Buffer<MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x14DC768 Offset: 0x14D8768 VA: 0x14DC768
	|-Buffer<object>..ctor
	|
	|-RVA: 0x14DCE14 Offset: 0x14D8E14 VA: 0x14DCE14
	|-Buffer<uint>..ctor
	|
	|-RVA: 0x14DD4B4 Offset: 0x14D94B4 VA: 0x14DD4B4
	|-Buffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8968 Offset: 0x14D4968 VA: 0x14D8968
	|-Buffer<ValueTuple<object, int>>.ToArray
	|
	|-RVA: 0x14D9018 Offset: 0x14D5018 VA: 0x14D9018
	|-Buffer<ValueTuple<object, float>>.ToArray
	|
	|-RVA: 0x14D96B8 Offset: 0x14D56B8 VA: 0x14D96B8
	|-Buffer<byte>.ToArray
	|
	|-RVA: 0x14D9DB8 Offset: 0x14D5DB8 VA: 0x14D9DB8
	|-Buffer<GlyphPairAdjustmentRecord>.ToArray
	|
	|-RVA: 0x14DA458 Offset: 0x14D6458 VA: 0x14DA458
	|-Buffer<int>.ToArray
	|
	|-RVA: 0x14DAAF8 Offset: 0x14D6AF8 VA: 0x14DAAF8
	|-Buffer<Int32Enum>.ToArray
	|
	|-RVA: 0x14DB1E0 Offset: 0x14D71E0 VA: 0x14DB1E0
	|-Buffer<MarkToBaseAdjustmentRecord>.ToArray
	|
	|-RVA: 0x14DB8C8 Offset: 0x14D78C8 VA: 0x14DB8C8
	|-Buffer<MarkToBaseAdjustmentRecord>.ToArray
	|
	|-RVA: 0x14DBFB0 Offset: 0x14D7FB0 VA: 0x14DBFB0
	|-Buffer<MarkToMarkAdjustmentRecord>.ToArray
	|
	|-RVA: 0x14DC698 Offset: 0x14D8698 VA: 0x14DC698
	|-Buffer<MarkToMarkAdjustmentRecord>.ToArray
	|
	|-RVA: 0x14DCD44 Offset: 0x14D8D44 VA: 0x14DCD44
	|-Buffer<object>.ToArray
	|
	|-RVA: 0x14DD3E4 Offset: 0x14D93E4 VA: 0x14DD3E4
	|-Buffer<uint>.ToArray
	|
	|-RVA: 0x14DDC54 Offset: 0x14D9C54 VA: 0x14DDC54
	|-Buffer<__Il2CppFullySharedGenericType>.ToArray
	*/
}
