/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaDLL // TypeDefIndex: 8227
	{
		// Fields
		public static int LUA_MULTRET; // 0x00
		private const string LUADLL = "__Internal"; // Metadata: 0x00613EF8
	
		// Constructors
		public LuaDLL() {} // 0x00846300-0x00846310
		static LuaDLL() {} // 0x00846310-0x00846370
	
		// Methods
		public static extern void luaS_openextlibs(IntPtr L); // 0x00844B00-0x00844B10
		public static extern int lua_tothread(IntPtr L, int index); // 0x00844B10-0x00844B20
		public static extern void lua_xmove(IntPtr from, IntPtr to, int n); // 0x00844B20-0x00844B30
		public static extern IntPtr lua_newthread(IntPtr L); // 0x00844B30-0x00844B40
		public static extern int lua_status(IntPtr L); // 0x00844B40-0x00844B50
		public static extern int lua_pushthread(IntPtr L); // 0x008447C0-0x008447D0
		public static extern int lua_gc(IntPtr luaState, LuaGCOptions what, int data); // 0x00844B50-0x00844B60
		public static extern IntPtr lua_typename(IntPtr luaState, int type); // 0x00844B60-0x00844B70
		public static string lua_typenamestr(IntPtr luaState, LuaTypes type) => default; // 0x00844B70-0x00844C20
		public static string luaL_typename(IntPtr luaState, int stackPos) => default; // 0x00844C20-0x00844D10
		public static bool lua_isfunction(IntPtr luaState, int stackPos) => default; // 0x00844D10-0x00844D90
		public static bool lua_islightuserdata(IntPtr luaState, int stackPos) => default; // 0x00844D90-0x00844E10
		public static bool lua_istable(IntPtr luaState, int stackPos) => default; // 0x00844E10-0x00844E90
		public static bool lua_isthread(IntPtr luaState, int stackPos) => default; // 0x00844E90-0x00844F10
		[Obsolete] // 0x0063A900-0x0063A910
		public static void luaL_error(IntPtr luaState, string message) {} // 0x00844F10-0x00844F20
		[Obsolete] // 0x0063A910-0x0063A920
		public static void luaL_error(IntPtr luaState, string fmt, params /* 0x0065ACB0-0x0065ACC0 */ object[] args) {} // 0x00844F20-0x00844F30
		public static extern string luaL_gsub(IntPtr luaState, string str, string pattern, string replacement); // 0x00844F30-0x00844FD0
		public static extern int lua_isuserdata(IntPtr luaState, int stackPos); // 0x00844FD0-0x00844FE0
		public static extern int lua_rawequal(IntPtr luaState, int stackPos1, int stackPos2); // 0x00844FE0-0x00844FF0
		public static extern void lua_setfield(IntPtr luaState, int stackPos, string name); // 0x0083FFC0-0x00840010
		public static extern int luaL_callmeta(IntPtr luaState, int stackPos, string name); // 0x00844FF0-0x00845050
		public static extern IntPtr luaL_newstate(); // 0x00845050-0x00845060
		public static extern void lua_close(IntPtr luaState); // 0x00845060-0x00845070
		public static extern void luaL_openlibs(IntPtr luaState); // 0x00845070-0x00845080
		public static extern int luaL_loadstring(IntPtr luaState, string chunk); // 0x00845080-0x008450D0
		public static int luaL_dostring(IntPtr luaState, string chunk) => default; // 0x008450D0-0x008451A0
		public static int lua_dostring(IntPtr luaState, string chunk) => default; // 0x008451B0-0x00845230
		public static extern void lua_createtable(IntPtr luaState, int narr, int nrec); // 0x00842090-0x008420A0
		public static void lua_newtable(IntPtr luaState) {} // 0x00845230-0x008452A0
		public static extern int lua_resume(IntPtr L, int narg); // 0x008452A0-0x008452B0
		public static extern int lua_lessthan(IntPtr luaState, int stackPos1, int stackPos2); // 0x008452B0-0x008452C0
		public static extern void lua_getfenv(IntPtr luaState, int stackPos); // 0x008452C0-0x008452D0
		public static extern int lua_yield(IntPtr L, int nresults); // 0x008452D0-0x008452E0
		public static void lua_getglobal(IntPtr luaState, string name) {} // 0x008410A0-0x00841160
		public static void lua_setglobal(IntPtr luaState, string name) {} // 0x00845330-0x00845400
		public static void lua_pushglobaltable(IntPtr l) {} // 0x00845420-0x008454C0
		public static extern void lua_insert(IntPtr luaState, int newTop); // 0x00845400-0x00845410
		public static int lua_rawlen(IntPtr luaState, int stackPos) => default; // 0x0083EFA0-0x0083EFB0
		public static int lua_strlen(IntPtr luaState, int stackPos) => default; // 0x008454D0-0x00845550
		public static extern void lua_call(IntPtr luaState, int nArgs, int nResults); // 0x00845550-0x00845560
		public static extern int lua_pcall(IntPtr luaState, int nArgs, int nResults, int errfunc); // 0x008451A0-0x008451B0
		public static extern double lua_tonumber(IntPtr luaState, int index); // 0x00845560-0x00845570
		public static extern int lua_tointeger(IntPtr luaState, int index); // 0x00845570-0x00845580
		public static int luaL_loadbuffer(IntPtr luaState, byte[] buff, int size, string name) => default; // 0x00845580-0x008455F0
		public static extern void lua_remove(IntPtr luaState, int index); // 0x00845660-0x00845670
		public static extern void lua_rawgeti(IntPtr luaState, int tableIndex, int index); // 0x0083EFB0-0x0083EFC0
		public static extern void lua_rawseti(IntPtr luaState, int tableIndex, int index); // 0x008420A0-0x008420B0
		public static extern void lua_pushinteger(IntPtr luaState, IntPtr i); // 0x00845670-0x00845680
		public static void lua_pushinteger(IntPtr luaState, int i) {} // 0x00845680-0x00845710
		public static int luaL_checkinteger(IntPtr luaState, int stackPos) => default; // 0x00845710-0x008457A0
		public static extern void lua_replace(IntPtr luaState, int index); // 0x008457A0-0x008457B0
		public static extern int lua_setfenv(IntPtr luaState, int stackPos); // 0x008457B0-0x008457C0
		public static extern int lua_equal(IntPtr luaState, int index1, int index2); // 0x008457C0-0x008457D0
		public static extern int luaL_loadfile(IntPtr luaState, string filename); // 0x008457D0-0x00845820
		public static extern void lua_settop(IntPtr luaState, int newTop); // 0x00841260-0x00841270
		public static void lua_pop(IntPtr luaState, int amount) {} // 0x0083EFC0-0x0083F040
		public static extern void lua_gettable(IntPtr luaState, int index); // 0x00845320-0x00845330
		public static extern void lua_rawget(IntPtr luaState, int index); // 0x00845820-0x00845830
		public static extern void lua_settable(IntPtr luaState, int index); // 0x00845410-0x00845420
		public static extern void lua_rawset(IntPtr luaState, int index); // 0x00845830-0x00845840
		public static extern int lua_setmetatable(IntPtr luaState, int objIndex); // 0x0083F4E0-0x0083F4F0
		public static extern int lua_getmetatable(IntPtr luaState, int objIndex); // 0x00845840-0x00845850
		public static extern void lua_pushvalue(IntPtr luaState, int index); // 0x0083F4F0-0x0083F500
		public static extern int lua_gettop(IntPtr luaState); // 0x0083D6C0-0x0083D6D0
		public static extern LuaTypes lua_type(IntPtr luaState, int index); // 0x0083F500-0x0083F510
		public static bool lua_isnil(IntPtr luaState, int index) => default; // 0x00845850-0x008458D0
		public static bool lua_isnumber(IntPtr luaState, int index) => default; // 0x008458D0-0x008458F0
		public static bool lua_isboolean(IntPtr luaState, int index) => default; // 0x00845900-0x00845980
		public static extern int luaL_ref(IntPtr luaState, int registryIndex); // 0x00845980-0x00845990
		public static void lua_getref(IntPtr luaState, int reference) {} // 0x00845990-0x00845A40
		public static extern void luaL_unref(IntPtr luaState, int registryIndex, int reference); // 0x00845A40-0x00845A50
		public static void lua_unref(IntPtr luaState, int reference) {} // 0x00845A50-0x00845B00
		public static bool lua_isstring(IntPtr luaState, int index) => default; // 0x00845B00-0x00845B20
		public static bool lua_iscfunction(IntPtr luaState, int index) => default; // 0x00845B30-0x00845B50
		public static extern void lua_pushnil(IntPtr luaState); // 0x0083E430-0x0083E440
		public static void luaL_checktype(IntPtr luaState, int p, LuaTypes t) {} // 0x0083ED70-0x0083EFA0
		public static void lua_pushcfunction(IntPtr luaState, LuaCSFunction function) {} // 0x008411B0-0x00841260
		public static extern IntPtr lua_tocfunction(IntPtr luaState, int index); // 0x00845B70-0x00845B80
		public static bool lua_toboolean(IntPtr luaState, int index) => default; // 0x00845B80-0x00845BA0
		public static extern IntPtr luaS_tolstring32(IntPtr luaState, int index, out int strLen); // 0x00845BB0-0x00845BC0
		public static string lua_tostring(IntPtr luaState, int index) => default; // 0x0083F2C0-0x0083F420
		public static byte[] lua_tobytes(IntPtr luaState, int index) => default; // 0x00845BC0-0x00845CB0
		public static extern IntPtr lua_atpanic(IntPtr luaState, LuaCSFunction panicf); // 0x00845CB0-0x00845CE0
		public static extern void lua_pushnumber(IntPtr luaState, double number); // 0x00845CE0-0x00845CF0
		public static void lua_pushboolean(IntPtr luaState, bool value) {} // 0x00845CF0-0x00845D10
		public static extern void lua_pushstring(IntPtr luaState, string str); // 0x008452E0-0x00845320
		public static void lua_pushlstring(IntPtr luaState, byte[] str, int size) {} // 0x0083E440-0x0083E450
		public static extern int luaL_newmetatable(IntPtr luaState, string meta); // 0x00845D30-0x00845D80
		public static extern void lua_getfield(IntPtr luaState, int stackPos, string meta); // 0x00841160-0x008411B0
		public static void luaL_getmetatable(IntPtr luaState, string meta) {} // 0x0083F420-0x0083F4E0
		public static extern IntPtr luaL_checkudata(IntPtr luaState, int stackPos, string meta); // 0x00845D80-0x00845DE0
		public static bool luaL_getmetafield(IntPtr luaState, int stackPos, string field) => default; // 0x00845DE0-0x00845E40
		public static extern int lua_load(IntPtr luaState, LuaChunkReader chunkReader, ref ReaderInfo data, string chunkName); // 0x00845EA0-0x00845F40
		public static extern int lua_error(IntPtr luaState); // 0x00845F40-0x00845F50
		public static bool lua_checkstack(IntPtr luaState, int extra) => default; // 0x00845F50-0x00845F70
		public static extern int lua_next(IntPtr luaState, int index); // 0x00845F80-0x00845F90
		public static extern void lua_pushlightuserdata(IntPtr luaState, IntPtr udata); // 0x00845F90-0x00845FA0
		public static extern void luaL_where(IntPtr luaState, int level); // 0x00845FA0-0x00845FB0
		public static double luaL_checknumber(IntPtr luaState, int stackPos) => default; // 0x00845FB0-0x00846040
		public static extern void lua_concat(IntPtr luaState, int n); // 0x00846040-0x00846050
		public static extern void luaS_newuserdata(IntPtr luaState, int val); // 0x00846050-0x00846060
		public static extern int luaS_rawnetobj(IntPtr luaState, int obj); // 0x00846060-0x00846070
		public static extern IntPtr lua_touserdata(IntPtr luaState, int index); // 0x00846070-0x00846080
		public static int lua_absindex(IntPtr luaState, int index) => default; // 0x00846080-0x00846110
		public static int lua_upvalueindex(int i) => default; // 0x0083CA90-0x0083CB00
		public static extern void lua_pushcclosure(IntPtr l, IntPtr f, int nup); // 0x00845B60-0x00845B70
		public static void lua_pushcclosure(IntPtr l, LuaCSFunction f, int nup) {} // 0x0083D020-0x0083D0E0
		public static extern int luaS_checkVector2(IntPtr l, int p, out float x, out float y); // 0x00846110-0x00846120
		public static extern int luaS_checkVector3(IntPtr l, int p, out float x, out float y, out float z); // 0x00846120-0x00846130
		public static extern int luaS_checkVector4(IntPtr l, int p, out float x, out float y, out float z, out float w); // 0x00846130-0x00846140
		public static extern int luaS_checkQuaternion(IntPtr l, int p, out float x, out float y, out float z, out float w); // 0x00846140-0x00846150
		public static extern int luaS_checkColor(IntPtr l, int p, out float x, out float y, out float z, out float w); // 0x00846150-0x00846160
		public static extern void luaS_pushVector2(IntPtr l, float x, float y); // 0x00846160-0x00846170
		public static extern void luaS_pushVector3(IntPtr l, float x, float y, float z); // 0x00846170-0x00846180
		public static extern void luaS_pushVector4(IntPtr l, float x, float y, float z, float w); // 0x00846180-0x00846190
		public static extern void luaS_pushQuaternion(IntPtr l, float x, float y, float z, float w); // 0x00846190-0x008461A0
		public static extern void luaS_pushColor(IntPtr l, float x, float y, float z, float w); // 0x008461A0-0x008461B0
		public static extern void luaS_setDataVec(IntPtr l, int p, float x, float y, float z, float w); // 0x008461B0-0x008461C0
		public static extern int luaS_checkluatype(IntPtr l, int p, string t); // 0x008461C0-0x00846220
		public static extern int luaS_pushobject(IntPtr l, int index, string t, bool gco, int cref); // 0x00846220-0x00846290
		public static extern int luaS_getcacheud(IntPtr l, int index, int cref); // 0x00846290-0x008462A0
		public static extern int luaS_subclassof(IntPtr l, int index, string t); // 0x008462A0-0x00846300
	}
}
