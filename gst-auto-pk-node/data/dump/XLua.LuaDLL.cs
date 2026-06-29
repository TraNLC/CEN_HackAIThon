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

// Namespace: XLua.LuaDLL
public sealed class lua_CSFunction : MulticastDelegate // TypeDefIndex: 1899
{
	// Methods

	// RVA: 0xF5EC7C Offset: 0xF5AC7C VA: 0xF5EC7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF6CC68 Offset: 0xF68C68 VA: 0xF6CC68 Slot: 12
	public virtual int Invoke(IntPtr L) { }

	// RVA: 0xF6CC7C Offset: 0xF68C7C VA: 0xF6CC7C Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr L, AsyncCallback callback, object object) { }

	// RVA: 0xF6CCD8 Offset: 0xF68CD8 VA: 0xF6CCD8 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: XLua.LuaDLL
public class Lua // TypeDefIndex: 1900
{
	// Fields
	private const string LUADLL = "xlua";

	// Methods

	// RVA: 0xF628D0 Offset: 0xF5E8D0 VA: 0xF628D0
	public static extern IntPtr lua_tothread(IntPtr L, int index) { }

	// RVA: 0xF6CD00 Offset: 0xF68D00 VA: 0xF6CD00
	public static extern int xlua_get_lib_version() { }

	// RVA: 0xF6CD64 Offset: 0xF68D64 VA: 0xF6CD64
	public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data) { }

	// RVA: 0xF65D54 Offset: 0xF61D54 VA: 0xF65D54
	public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n) { }

	// RVA: 0xF65DF4 Offset: 0xF61DF4 VA: 0xF65DF4
	public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n) { }

	// RVA: 0xF6CDF8 Offset: 0xF68DF8 VA: 0xF6CDF8
	public static extern int lua_pushthread(IntPtr L) { }

	// RVA: 0xF6C57C Offset: 0xF6857C VA: 0xF6C57C
	public static bool lua_isfunction(IntPtr L, int stackPos) { }

	// RVA: 0xF6CE74 Offset: 0xF68E74 VA: 0xF6CE74
	public static bool lua_islightuserdata(IntPtr L, int stackPos) { }

	// RVA: 0xF68438 Offset: 0xF64438 VA: 0xF68438
	public static bool lua_istable(IntPtr L, int stackPos) { }

	// RVA: 0xF628B8 Offset: 0xF5E8B8 VA: 0xF628B8
	public static bool lua_isthread(IntPtr L, int stackPos) { }

	// RVA: 0xF5ED38 Offset: 0xF5AD38 VA: 0xF5ED38
	public static int luaL_error(IntPtr L, string message) { }

	// RVA: 0xF6C594 Offset: 0xF68594 VA: 0xF6C594
	public static extern int lua_setfenv(IntPtr L, int stackPos) { }

	// RVA: 0xF6CF2C Offset: 0xF68F2C VA: 0xF6CF2C
	public static extern IntPtr luaL_newstate() { }

	// RVA: 0xF6CF90 Offset: 0xF68F90 VA: 0xF6CF90
	public static extern void lua_close(IntPtr L) { }

	// RVA: 0xF6D00C Offset: 0xF6900C VA: 0xF6D00C
	public static extern void luaopen_xlua(IntPtr L) { }

	// RVA: 0xF6D088 Offset: 0xF69088 VA: 0xF6D088
	public static extern void luaL_openlibs(IntPtr L) { }

	// RVA: 0xF6D104 Offset: 0xF69104 VA: 0xF6D104
	public static extern uint xlua_objlen(IntPtr L, int stackPos) { }

	// RVA: 0xF677B4 Offset: 0xF637B4 VA: 0xF677B4
	public static extern void lua_createtable(IntPtr L, int narr, int nrec) { }

	// RVA: 0xF65DE8 Offset: 0xF61DE8 VA: 0xF65DE8
	public static void lua_newtable(IntPtr L) { }

	// RVA: 0xF60C58 Offset: 0xF5CC58 VA: 0xF60C58
	public static extern int xlua_getglobal(IntPtr L, string name) { }

	// RVA: 0xF6C774 Offset: 0xF68774 VA: 0xF6C774
	public static extern int xlua_setglobal(IntPtr L, string name) { }

	// RVA: 0xF6D188 Offset: 0xF69188 VA: 0xF6D188
	public static extern void xlua_getloaders(IntPtr L) { }

	// RVA: 0xF66390 Offset: 0xF62390 VA: 0xF66390
	public static extern void lua_settop(IntPtr L, int newTop) { }

	// RVA: 0xF60DA8 Offset: 0xF5CDA8 VA: 0xF60DA8
	public static void lua_pop(IntPtr L, int amount) { }

	// RVA: 0xF6D204 Offset: 0xF69204 VA: 0xF6D204
	public static extern void lua_insert(IntPtr L, int newTop) { }

	// RVA: 0xF65CD0 Offset: 0xF61CD0 VA: 0xF65CD0
	public static extern void lua_remove(IntPtr L, int index) { }

	// RVA: 0xF60B58 Offset: 0xF5CB58 VA: 0xF60B58
	public static extern int lua_rawget(IntPtr L, int index) { }

	// RVA: 0xF65B2C Offset: 0xF61B2C VA: 0xF65B2C
	public static extern void lua_rawset(IntPtr L, int index) { }

	// RVA: 0xF6134C Offset: 0xF5D34C VA: 0xF6134C
	public static extern int lua_setmetatable(IntPtr L, int objIndex) { }

	// RVA: 0xF6D288 Offset: 0xF69288 VA: 0xF6D288
	public static extern int lua_rawequal(IntPtr L, int index1, int index2) { }

	// RVA: 0xF60AD4 Offset: 0xF5CAD4 VA: 0xF60AD4
	public static extern void lua_pushvalue(IntPtr L, int index) { }

	// RVA: 0xF6D31C Offset: 0xF6931C VA: 0xF6D31C
	public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n) { }

	// RVA: 0xF6D3B0 Offset: 0xF693B0 VA: 0xF6D3B0
	public static extern void lua_replace(IntPtr L, int index) { }

	// RVA: 0xF60BDC Offset: 0xF5CBDC VA: 0xF60BDC
	public static extern int lua_gettop(IntPtr L) { }

	// RVA: 0xF5EECC Offset: 0xF5AECC VA: 0xF5EECC
	public static extern LuaTypes lua_type(IntPtr L, int index) { }

	// RVA: 0xF61334 Offset: 0xF5D334 VA: 0xF61334
	public static bool lua_isnil(IntPtr L, int index) { }

	// RVA: 0xF6D434 Offset: 0xF69434 VA: 0xF6D434
	public static extern bool lua_isnumber(IntPtr L, int index) { }

	// RVA: 0xF6D4BC Offset: 0xF694BC VA: 0xF6D4BC
	public static bool lua_isboolean(IntPtr L, int index) { }

	// RVA: 0xF6D4D4 Offset: 0xF694D4 VA: 0xF6D4D4
	public static extern int luaL_ref(IntPtr L, int registryIndex) { }

	// RVA: 0xF6D558 Offset: 0xF69558 VA: 0xF6D558
	public static int luaL_ref(IntPtr L) { }

	// RVA: 0xF613EC Offset: 0xF5D3EC VA: 0xF613EC
	public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index) { }

	// RVA: 0xF61480 Offset: 0xF5D480 VA: 0xF61480
	public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index) { }

	// RVA: 0xF6D578 Offset: 0xF69578 VA: 0xF6D578
	public static void lua_getref(IntPtr L, int reference) { }

	// RVA: 0xF6D5A8 Offset: 0xF695A8 VA: 0xF6D5A8
	public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref) { }

	// RVA: 0xF6D63C Offset: 0xF6963C VA: 0xF6D63C
	public static extern void luaL_unref(IntPtr L, int registryIndex, int reference) { }

	// RVA: 0xF6D6D0 Offset: 0xF696D0 VA: 0xF6D6D0
	public static void lua_unref(IntPtr L, int reference) { }

	// RVA: 0xF6D700 Offset: 0xF69700 VA: 0xF6D700
	public static extern bool lua_isstring(IntPtr L, int index) { }

	// RVA: 0xF61514 Offset: 0xF5D514 VA: 0xF61514
	public static extern bool lua_isinteger(IntPtr L, int index) { }

	// RVA: 0xF610D0 Offset: 0xF5D0D0 VA: 0xF610D0
	public static extern void lua_pushnil(IntPtr L) { }

	// RVA: 0xF60F80 Offset: 0xF5CF80 VA: 0xF60F80
	public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0) { }

	// RVA: 0xF5ED4C Offset: 0xF5AD4C VA: 0xF5ED4C
	public static extern int xlua_upvalueindex(int n) { }

	// RVA: 0xF60CF8 Offset: 0xF5CCF8 VA: 0xF60CF8
	public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc) { }

	// RVA: 0xF60580 Offset: 0xF5C580 VA: 0xF60580
	public static extern double lua_tonumber(IntPtr L, int index) { }

	// RVA: 0xF5EDC4 Offset: 0xF5ADC4 VA: 0xF5EDC4
	public static extern int xlua_tointeger(IntPtr L, int index) { }

	// RVA: 0xF608A4 Offset: 0xF5C8A4 VA: 0xF608A4
	public static extern uint xlua_touint(IntPtr L, int index) { }

	// RVA: 0xF60600 Offset: 0xF5C600 VA: 0xF60600
	public static extern bool lua_toboolean(IntPtr L, int index) { }

	// RVA: 0xF6D81C Offset: 0xF6981C VA: 0xF6D81C
	public static extern IntPtr lua_topointer(IntPtr L, int index) { }

	// RVA: 0xF6D8A0 Offset: 0xF698A0 VA: 0xF6D8A0
	public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen) { }

	// RVA: 0xF609AC Offset: 0xF5C9AC VA: 0xF609AC
	public static string lua_tostring(IntPtr L, int index) { }

	// RVA: 0xF6D934 Offset: 0xF69934 VA: 0xF6D934
	public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf) { }

	// RVA: 0xF5F7B0 Offset: 0xF5B7B0 VA: 0xF5F7B0
	public static extern void lua_pushnumber(IntPtr L, double number) { }

	// RVA: 0xF5F83C Offset: 0xF5B83C VA: 0xF5F83C
	public static extern void lua_pushboolean(IntPtr L, bool value) { }

	// RVA: 0xF5F72C Offset: 0xF5B72C VA: 0xF5F72C
	public static extern void xlua_pushinteger(IntPtr L, int value) { }

	// RVA: 0xF5F9C8 Offset: 0xF5B9C8 VA: 0xF5F9C8
	public static extern void xlua_pushuint(IntPtr L, uint value) { }

	// RVA: 0xF5FAD0 Offset: 0xF5BAD0 VA: 0xF5FAD0
	public static void lua_pushstring(IntPtr L, string str) { }

	// RVA: 0xF6D9C0 Offset: 0xF699C0 VA: 0xF6D9C0
	public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size) { }

	// RVA: 0xF60E2C Offset: 0xF5CE2C VA: 0xF60E2C
	public static void xlua_pushasciistring(IntPtr L, string str) { }

	// RVA: 0xF6DA5C Offset: 0xF69A5C VA: 0xF6DA5C
	public static void lua_pushstring(IntPtr L, byte[] str) { }

	// RVA: 0xF6DA6C Offset: 0xF69A6C VA: 0xF6DA6C
	public static byte[] lua_tobytes(IntPtr L, int index) { }

	// RVA: 0xF66E80 Offset: 0xF62E80 VA: 0xF66E80
	public static extern int luaL_newmetatable(IntPtr L, string meta) { }

	// RVA: 0xF683B4 Offset: 0xF643B4 VA: 0xF683B4
	public static extern int xlua_pgettable(IntPtr L, int idx) { }

	// RVA: 0xF6DB5C Offset: 0xF69B5C VA: 0xF6DB5C
	public static extern int xlua_psettable(IntPtr L, int idx) { }

	// RVA: 0xF61310 Offset: 0xF5D310 VA: 0xF61310
	public static void luaL_getmetatable(IntPtr L, string meta) { }

	// RVA: 0xF6100C Offset: 0xF5D00C VA: 0xF6100C
	public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name) { }

	// RVA: 0xF6C524 Offset: 0xF68524 VA: 0xF6C524
	public static int luaL_loadbuffer(IntPtr L, string buff, string name) { }

	// RVA: 0xF5EE48 Offset: 0xF5AE48 VA: 0xF5EE48
	public static extern int xlua_tocsobj_safe(IntPtr L, int obj) { }

	// RVA: 0xF6DBE0 Offset: 0xF69BE0 VA: 0xF6DBE0
	public static extern int xlua_tocsobj_fast(IntPtr L, int obj) { }

	// RVA: 0xF60D94 Offset: 0xF5CD94 VA: 0xF60D94
	public static int lua_error(IntPtr L) { }

	// RVA: 0xF65A98 Offset: 0xF61A98 VA: 0xF65A98
	public static extern bool lua_checkstack(IntPtr L, int extra) { }

	// RVA: 0xF6DCE0 Offset: 0xF69CE0 VA: 0xF6DCE0
	public static extern int lua_next(IntPtr L, int index) { }

	// RVA: 0xF5FA4C Offset: 0xF5BA4C VA: 0xF5FA4C
	public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata) { }

	// RVA: 0xF66F20 Offset: 0xF62F20 VA: 0xF66F20
	public static extern IntPtr xlua_tag() { }

	// RVA: 0xF6DD64 Offset: 0xF69D64 VA: 0xF6DD64
	public static extern void luaL_where(IntPtr L, int level) { }

	// RVA: 0xF6DDE8 Offset: 0xF69DE8 VA: 0xF6DDE8
	public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref) { }

	// RVA: 0xF6DE7C Offset: 0xF69E7C VA: 0xF6DE7C
	public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref) { }

	// RVA: 0xF672C0 Offset: 0xF632C0 VA: 0xF672C0
	public static extern int gen_obj_indexer(IntPtr L) { }

	// RVA: 0xF6733C Offset: 0xF6333C VA: 0xF6733C
	public static extern int gen_obj_newindexer(IntPtr L) { }

	// RVA: 0xF673B8 Offset: 0xF633B8 VA: 0xF673B8
	public static extern int gen_cls_indexer(IntPtr L) { }

	// RVA: 0xF67434 Offset: 0xF63434 VA: 0xF67434
	public static extern int gen_cls_newindexer(IntPtr L) { }

	// RVA: 0xF6DF28 Offset: 0xF69F28 VA: 0xF6DF28
	public static extern int get_error_func_ref(IntPtr L) { }

	// RVA: 0xF6DFA4 Offset: 0xF69FA4 VA: 0xF6DFA4
	public static extern int load_error_func(IntPtr L, int Ref) { }

	// RVA: 0xF6E028 Offset: 0xF6A028 VA: 0xF6E028
	public static extern int luaopen_i64lib(IntPtr L) { }

	// RVA: 0xF60DB0 Offset: 0xF5CDB0 VA: 0xF60DB0
	public static extern int luaopen_socket_core(IntPtr L) { }

	// RVA: 0xF5F8C0 Offset: 0xF5B8C0 VA: 0xF5F8C0
	public static extern void lua_pushint64(IntPtr L, long n) { }

	// RVA: 0xF5F944 Offset: 0xF5B944 VA: 0xF5F944
	public static extern void lua_pushuint64(IntPtr L, ulong n) { }

	// RVA: 0xF6068C Offset: 0xF5C68C VA: 0xF6068C
	public static extern bool lua_isint64(IntPtr L, int idx) { }

	// RVA: 0xF6079C Offset: 0xF5C79C VA: 0xF6079C
	public static extern bool lua_isuint64(IntPtr L, int idx) { }

	// RVA: 0xF60718 Offset: 0xF5C718 VA: 0xF60718
	public static extern long lua_toint64(IntPtr L, int idx) { }

	// RVA: 0xF60824 Offset: 0xF5C824 VA: 0xF60824
	public static extern ulong lua_touint64(IntPtr L, int idx) { }

	// RVA: 0xF6D788 Offset: 0xF69788 VA: 0xF6D788
	public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n) { }

	// RVA: 0xF6CE8C Offset: 0xF68E8C VA: 0xF6CE8C
	public static extern int xlua_csharp_str_error(IntPtr L, string message) { }

	// RVA: 0xF6DC64 Offset: 0xF69C64 VA: 0xF6DC64
	public static extern int xlua_csharp_error(IntPtr L) { }

	// RVA: 0xF6E0A4 Offset: 0xF6A0A4 VA: 0xF6E0A4
	public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field) { }

	// RVA: 0xF6E13C Offset: 0xF6A13C VA: 0xF6E13C
	public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field) { }

	// RVA: 0xF6E1D8 Offset: 0xF6A1D8 VA: 0xF6E1D8
	public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field) { }

	// RVA: 0xF6E274 Offset: 0xF6A274 VA: 0xF6E274
	public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field) { }

	// RVA: 0xF6E310 Offset: 0xF6A310 VA: 0xF6E310
	public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field) { }

	// RVA: 0xF6E3AC Offset: 0xF6A3AC VA: 0xF6E3AC
	public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field) { }

	// RVA: 0xF6E448 Offset: 0xF6A448 VA: 0xF6E448
	public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field) { }

	// RVA: 0xF6E4E4 Offset: 0xF6A4E4 VA: 0xF6E4E4
	public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field) { }

	// RVA: 0xF6E580 Offset: 0xF6A580 VA: 0xF6E580
	public static extern bool xlua_pack_float(IntPtr buff, int offset, float field) { }

	// RVA: 0xF6E61C Offset: 0xF6A61C VA: 0xF6E61C
	public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field) { }

	// RVA: 0xF6E6B8 Offset: 0xF6A6B8 VA: 0xF6E6B8
	public static extern bool xlua_pack_double(IntPtr buff, int offset, double field) { }

	// RVA: 0xF6E754 Offset: 0xF6A754 VA: 0xF6E754
	public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field) { }

	// RVA: 0xF6E7F0 Offset: 0xF6A7F0 VA: 0xF6E7F0
	public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref) { }

	// RVA: 0xF6E884 Offset: 0xF6A884 VA: 0xF6E884
	public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref) { }

	// RVA: 0xF60928 Offset: 0xF5C928 VA: 0xF60928
	public static extern IntPtr lua_touserdata(IntPtr L, int idx) { }

	// RVA: 0xF6E914 Offset: 0xF6A914 VA: 0xF6E914
	public static extern int xlua_gettypeid(IntPtr L, int idx) { }

	// RVA: 0xF6E998 Offset: 0xF6A998 VA: 0xF6E998
	public static extern int xlua_get_registry_index() { }

	// RVA: 0xF6E9FC Offset: 0xF6A9FC VA: 0xF6E9FC
	public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path) { }

	// RVA: 0xF6EAAC Offset: 0xF6AAAC VA: 0xF6EAAC
	public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path) { }

	// RVA: 0xF6EB5C Offset: 0xF6AB5C VA: 0xF6EB5C
	public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2) { }

	// RVA: 0xF6EC00 Offset: 0xF6AC00 VA: 0xF6EC00
	public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2) { }

	// RVA: 0xF6ECA4 Offset: 0xF6ACA4 VA: 0xF6ECA4
	public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3) { }

	// RVA: 0xF6ED58 Offset: 0xF6AD58 VA: 0xF6ED58
	public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3) { }

	// RVA: 0xF6EE0C Offset: 0xF6AE0C VA: 0xF6EE0C
	public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4) { }

	// RVA: 0xF6EEC8 Offset: 0xF6AEC8 VA: 0xF6EEC8
	public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4) { }

	// RVA: 0xF6EF84 Offset: 0xF6AF84 VA: 0xF6EF84
	public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5) { }

	// RVA: 0xF6F050 Offset: 0xF6B050 VA: 0xF6F050
	public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5) { }

	// RVA: 0xF6F11C Offset: 0xF6B11C VA: 0xF6F11C
	public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6) { }

	// RVA: 0xF6F1F0 Offset: 0xF6B1F0 VA: 0xF6F1F0
	public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6) { }

	// RVA: 0xF6F2C4 Offset: 0xF6B2C4 VA: 0xF6F2C4
	public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref Decimal dec) { }

	// RVA: 0xF6F360 Offset: 0xF6B360 VA: 0xF6F360
	public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64) { }

	// RVA: 0xF6F41C Offset: 0xF6B41C VA: 0xF6F41C
	public static bool xlua_is_eq_str(IntPtr L, int index, string str) { }

	// RVA: 0xF6F430 Offset: 0xF6B430 VA: 0xF6F430
	public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len) { }

	// RVA: 0xF592F8 Offset: 0xF552F8 VA: 0xF592F8
	public static extern IntPtr xlua_gl(IntPtr L) { }

	// RVA: 0xF6F4EC Offset: 0xF6B4EC VA: 0xF6F4EC
	public void .ctor() { }
}
