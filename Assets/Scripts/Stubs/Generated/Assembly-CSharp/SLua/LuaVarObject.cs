/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	internal class LuaVarObject : LuaObject // TypeDefIndex: 8265
	{
		// Fields
		private static Dictionary<Type, Dictionary<string, List<MemberInfo>>> cachedMemberInfos; // 0x00
	
		// Nested types
		private class MethodWrapper // TypeDefIndex: 8266
		{
			// Fields
			private object self; // 0x10
			private IList<MemberInfo> mis; // 0x18
	
			// Constructors
			public MethodWrapper() {} // Dummy constructor
			public MethodWrapper(object self, IList<MemberInfo> mi) {} // 0x00CA75F0-0x00CA7630
	
			// Methods
			private bool matchType(IntPtr l, int p, LuaTypes lt, Type t) => default; // 0x00CA88A0-0x00CA8B90
			private object checkVar(IntPtr l, int p, Type t) => default; // 0x00CA8B90-0x00CA9240
			internal bool matchType(IntPtr l, int from, ParameterInfo[] pis, bool isstatic) => default; // 0x00CA9240-0x00CA93A0
			public int invoke(IntPtr l) => default; // 0x00CA93A0-0x00CA95B0
			private int forceInvoke(IntPtr l, MethodInfo m) => default; // 0x00CA95B0-0x00CA97B0
			public void checkArgs(IntPtr l, int from, MethodInfo m, out object[] args) {
				args = default;
			} // 0x00CA97B0-0x00CA99D0
		}
	
		// Constructors
		public LuaVarObject() {} // 0x00CA87B0-0x00CA8820
		static LuaVarObject() {} // 0x00CA8820-0x00CA88A0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0063B480-0x0063B4F0
		public static int luaIndex(IntPtr l) => default; // 0x00CA5C10-0x00CA5FC0
		private static int indexObject(IntPtr l, object self, object key) => default; // 0x00CA71E0-0x00CA72C0
		private static Type getType(object o) => default; // 0x00CA72C0-0x00CA7360
		private static int indexString(IntPtr l, object self, string key) => default; // 0x00CA6890-0x00CA6E30
		private static void CollectTypeMembers(Type type, ref Dictionary<string, List<MemberInfo>> membersMap) {} // 0x00CA7630-0x00CA7850
		private static IList<MemberInfo> GetCacheMembers(Type type, string key) => default; // 0x00CA7360-0x00CA75F0
		private static int newindexString(IntPtr l, object self, string key) => default; // 0x00CA7850-0x00CA7E80
		private static int indexInt(IntPtr l, object self, int index) => default; // 0x00CA6E30-0x00CA71E0
		private static int newindexInt(IntPtr l, object self, int index) => default; // 0x00CA7E80-0x00CA8240
		private static int newindexObject(IntPtr l, object self, object k, object v) => default; // 0x00CA8240-0x00CA8420
		// [MonoPInvokeCallback] // 0x0063B4F0-0x0063B560
		public static int luaNewIndex(IntPtr l) => default; // 0x00CA5FC0-0x00CA63B0
		// [MonoPInvokeCallback] // 0x0063B560-0x0063B5D0
		public static int methodWrapper(IntPtr l) => default; // 0x00CA63B0-0x00CA6580
		public static new void init(IntPtr l) {} // 0x00CA8420-0x00CA86C0
	}
}
