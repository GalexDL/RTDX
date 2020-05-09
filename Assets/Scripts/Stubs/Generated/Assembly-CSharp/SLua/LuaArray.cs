/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	internal class LuaArray : LuaObject // TypeDefIndex: 8215
	{
		// Fields
		private static Dictionary<string, ArrayPropFunction> propMethod; // 0x00
	
		// Nested types
		private delegate int ArrayPropFunction(IntPtr l, Array a); // TypeDefIndex: 8216; 0x00842270-0x00842640
	
		// Constructors
		public LuaArray() {} // 0x00842CD0-0x00842D40
		static LuaArray() {} // 0x00842D40-0x00843080
	
		// Methods
		private static int toTable(IntPtr l, Array o) => default; // 0x00841F30-0x00842090
		private static int length(IntPtr l, Array a) => default; // 0x008420B0-0x00842140
		// [MonoPInvokeCallback] // 0x00639320-0x00639390
		public static int len(IntPtr l) => default; // 0x00841380-0x00841510
		// [MonoPInvokeCallback] // 0x00639390-0x00639400
		public static int luaIndex(IntPtr l) => default; // 0x00841510-0x008419F0
		// [MonoPInvokeCallback] // 0x00639400-0x00639470
		public static int luaNewIndex(IntPtr l) => default; // 0x008419F0-0x00841D60
		// [MonoPInvokeCallback] // 0x00639470-0x006394E0
		public static int tostring(IntPtr l) => default; // 0x00841D60-0x00841F30
		public static new void init(IntPtr l) {} // 0x00842840-0x00842C40
	}
}
