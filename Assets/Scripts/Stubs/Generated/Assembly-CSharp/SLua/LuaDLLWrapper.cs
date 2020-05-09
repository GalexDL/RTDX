/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaDLLWrapper // TypeDefIndex: 8228
	{
		// Fields
		private const string LUADLL = "__Internal"; // Metadata: 0x00613F06
	
		// Constructors
		public LuaDLLWrapper() {} // 0x00846370-0x00846380
	
		// Methods
		public static extern int luaS_objlen(IntPtr luaState, int stackPos); // 0x008454C0-0x008454D0
		public static extern int lua_isnumber(IntPtr luaState, int index); // 0x008458F0-0x00845900
		public static extern int lua_isstring(IntPtr luaState, int index); // 0x00845B20-0x00845B30
		public static extern int lua_iscfunction(IntPtr luaState, int index); // 0x00845B50-0x00845B60
		public static extern int lua_toboolean(IntPtr luaState, int index); // 0x00845BA0-0x00845BB0
		public static extern void lua_pushboolean(IntPtr luaState, int value); // 0x00845D10-0x00845D20
		public static extern void luaS_pushlstring(IntPtr luaState, byte[] str, int size); // 0x00845D20-0x00845D30
		public static extern int luaL_getmetafield(IntPtr luaState, int stackPos, string field); // 0x00845E40-0x00845EA0
		public static extern int luaLS_loadbuffer(IntPtr luaState, byte[] buff, int size, string name); // 0x008455F0-0x00845660
		public static extern int lua_checkstack(IntPtr luaState, int extra); // 0x00845F70-0x00845F80
	}
}
