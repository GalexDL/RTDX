/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaState : IDisposable // TypeDefIndex: 8249
	{
		// Fields
		private IntPtr l_; // 0x10
		private int mainThread; // 0x18
		internal WeakDictionary<int, LuaDelegate> delgateMap; // 0x20
		public static LoaderDelegate loaderDelegate; // 0x00
		public static OutputDelegate logDelegate; // 0x08
		public static OutputDelegate errorDelegate; // 0x10
		private Queue<UnrefPair> refQueue; // 0x28
		public int PCallCSFunctionRef; // 0x30
		private Dictionary<Type, PushVarDelegate> typePushMap; // 0x38
		public static LuaState main; // 0x18
		private static Dictionary<IntPtr, LuaState> statemap; // 0x20
		private static IntPtr oldptr; // 0x28
		private static LuaState oldstate; // 0x30
		public static LuaCSFunction errorFunc; // 0x38
		private int errorRef; // 0x40
		private static StringBuilder s; // 0x40
	
		// Properties
		public IntPtr L { get => default; set {} } // 0x00C973E0-0x00C97510 0x00C97550-0x00C97560
		public IntPtr handle { get => default; } // 0x00C97560-0x00C97570 
		public int Top { get => default; } // 0x00C97570-0x00C975F0 
		public object this[string path] { get => default; set {} } // 0x00C9B030-0x00C9B040 0x00C9B140-0x00C9B150
	
		// Nested types
		public delegate byte[] LoaderDelegate(string fn); // TypeDefIndex: 8250; 0x00C99B20-0x00C9A0A0
	
		public delegate void OutputDelegate(string msg); // TypeDefIndex: 8251; 0x00C98C40-0x00C99200
	
		public delegate void PushVarDelegate(IntPtr l, object o); // TypeDefIndex: 8252; 0x00C9CCD0-0x00C9D380
	
		public delegate void UnRefAction(IntPtr l, int r); // TypeDefIndex: 8253; 0x00C9B460-0x00C9B850
	
		private struct UnrefPair // TypeDefIndex: 8254
		{
			// Fields
			public UnRefAction act; // 0x10
			public int r; // 0x18
		}
	
		// Constructors
		public LuaState() {} // 0x00C975F0-0x00C978F0
		static LuaState() {} // 0x00C9BAC0-0x00C9BBB0
	
		// Methods
		public bool isMainThread() => default; // 0x00C97510-0x00C97550
		public static LuaState get(IntPtr l) => default; // 0x00C95130-0x00C95350
		// [MonoPInvokeCallback] // 0x0063AFB0-0x0063B020
		private static int init(IntPtr L) => default; // 0x00C954E0-0x00C959F0
		public void Close() {} // 0x00C98890-0x00C98AC0
		public void Dispose() {} // 0x00C98BB0-0x00C98C30
		public virtual void Dispose(bool dispose) {} // 0x00C98C30-0x00C98C40
		// [MonoPInvokeCallback] // 0x0063B020-0x0063B090
		public static int errorReport(IntPtr L) => default; // 0x00C959F0-0x00C95C00
		// [MonoPInvokeCallback] // 0x0063B090-0x0063B100
		internal static int import(IntPtr l) => default; // 0x00C95C00-0x00C96280
		// [MonoPInvokeCallback] // 0x0063B100-0x0063B170
		internal static int pcall(IntPtr L) => default; // 0x00C96280-0x00C96410
		internal static void pcall(IntPtr l, LuaCSFunction f) {} // 0x00C98600-0x00C98720
		// [MonoPInvokeCallback] // 0x0063B170-0x0063B1E0
		internal static int print(IntPtr L) => default; // 0x00C96410-0x00C96830
		// [MonoPInvokeCallback] // 0x0063B1E0-0x0063B250
		internal static int printerror(IntPtr L) => default; // 0x00C96830-0x00C96C50
		// [MonoPInvokeCallback] // 0x0063B250-0x0063B2C0
		internal static int loadfile(IntPtr L) => default; // 0x00C96C50-0x00C96E30
		// [MonoPInvokeCallback] // 0x0063B2C0-0x0063B330
		internal static int dofile(IntPtr L) => default; // 0x00C96E30-0x00C970A0
		// [MonoPInvokeCallback] // 0x0063B330-0x0063B3A0
		public static int panicCallback(IntPtr l) => default; // 0x00C970A0-0x00C971B0
		public static void pushcsfunction(IntPtr L, LuaCSFunction function) {} // 0x00C98720-0x00C987F0
		public object doString(string str) => default; // 0x00C987F0-0x00C98890
		public object doString(string str, string chunkname) => default; // 0x00C95350-0x00C953C0
		// [MonoPInvokeCallback] // 0x0063B3A0-0x0063B410
		internal static int loader(IntPtr L) => default; // 0x00C971B0-0x00C973E0
		public object doFile(string fn) => default; // 0x00C99700-0x00C99800
		public static byte[] CleanUTF8Bom(byte[] bytes) => default; // 0x00C99800-0x00C998D0
		public bool doBuffer(byte[] bytes, string fn, out object ret) {
			ret = default;
			return default;
		} // 0x00C99200-0x00C99450
		internal static byte[] loadFile(string fn) => default; // 0x00C99450-0x00C99700
		internal object getObject(string key) => default; // 0x00C9A0A0-0x00C9A1A0
		internal void setObject(string key, object v) {} // 0x00C9A360-0x00C9A450
		internal object getObject(string[] remainingPath) => default; // 0x00C9A1A0-0x00C9A360
		internal object getObject(int reference, string field) => default; // 0x00C9A700-0x00C9A810
		internal object getObject(int reference, int index) => default; // 0x00C9A810-0x00C9A9C0
		internal object getObject(int reference, object field) => default; // 0x00C9A9C0-0x00C9AB60
		internal void setObject(string[] remainingPath, object o) {} // 0x00C9A450-0x00C9A650
		internal void setObject(int reference, string field, object o) {} // 0x00C9AB60-0x00C9AC80
		internal void setObject(int reference, int index, object o) {} // 0x00C9AC80-0x00C9AE10
		internal void setObject(int reference, object field, object o) {} // 0x00C9AE10-0x00C9AF30
		internal object topObjects(int from) => default; // 0x00C998D0-0x00C99B20
		private object getObject(IntPtr l, int p) => default; // 0x00C9A650-0x00C9A700
		public LuaFunction getFunction(string key) => default; // 0x00C9AF30-0x00C9B030
		public LuaTable getTable(string key) => default; // 0x00C9B040-0x00C9B140
		public void gcRef(UnRefAction act, int r) {} // 0x00C9B150-0x00C9B250
		public void checkRef() {} // 0x00C9B250-0x00C9B460
		public void regPushVar(Type t, PushVarDelegate d) {} // 0x00C9B850-0x00C9B8C0
		public bool tryGetTypePusher(Type t, out PushVarDelegate d) {
			d = default;
			return default;
		} // 0x00C9B8C0-0x00C9B930
		private void setupPushVar() {} // 0x00C979B0-0x00C98600
		public int pushTry() => default; // 0x00C9B940-0x00C9BAC0
	}
}
