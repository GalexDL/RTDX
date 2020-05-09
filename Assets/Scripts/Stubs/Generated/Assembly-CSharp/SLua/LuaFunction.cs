/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaFunction : LuaVar // TypeDefIndex: 8245
	{
		// Constructors
		public LuaFunction() {} // Dummy constructor
		public LuaFunction(LuaState l, int r) {} // 0x0084B6C0-0x0084B6D0
		public LuaFunction(IntPtr l, int r) {} // 0x00846390-0x008463A0
	
		// Methods
		public bool pcall(int nArgs, int errfunc) => default; // 0x0084A660-0x0084A980
		private bool innerCall(int nArgs, int errfunc) => default; // 0x0084B6D0-0x0084B780
		public object call() => default; // 0x008401B0-0x008402E0
		public object call(params /* 0x0065ACE0-0x0065ACF0 */ object[] args) => default; // 0x0084B780-0x0084B970
		public object call(object a1) => default; // 0x0084B970-0x0084BAC0
		public object call(LuaTable self, params /* 0x0065ACF0-0x0065AD00 */ object[] args) => default; // 0x0084BAC0-0x0084BCC0
		public object call(object a1, object a2) => default; // 0x0084BCC0-0x0084BE20
		public object call(object a1, object a2, object a3) => default; // 0x0084BE20-0x0084BFB0
	}
}
