/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaSvr // TypeDefIndex: 8257
	{
		// Fields
		public LuaState luaState; // 0x10
		protected static LuaSvrGameObject lgo; // 0x00
		private int errorReported; // 0x18
		public bool inited; // 0x1C
	
		// Constructors
		public LuaSvr() {} // 0x00C9D8A0-0x00C9D910
	
		// Methods
		private List<Action<IntPtr>> collectBindInfo() => default; // 0x00C9D910-0x00C9DD40
		protected void doBind(IntPtr L) {} // 0x00C9DD40-0x00C9DDF0
		// [IteratorStateMachine] // 0x0063B410-0x0063B480
		private IEnumerator doBind(IntPtr L, Action<int> _tick, Action complete) => default; // 0x00C9DDF0-0x00C9DE80
		private Action<IntPtr>[] getBindList(Assembly assembly, string ns) => default; // 0x00C9DEB0-0x00C9E020
		protected void doinit(IntPtr L, LuaSvrFlag flag) {} // 0x00C9E020-0x00C9E1F0
		protected void checkTop(IntPtr L) {} // 0x00C9F3F0-0x00C9F4D0
		public void init(Action<int> tick, Action complete, LuaSvrFlag flag = LuaSvrFlag.LSF_EXTLIB /* Metadata: 0x00613F35 */) {} // 0x00C9F4D0-0x00C9F6E0
		public object start(string main) => default; // 0x00C9F6F0-0x00C9F890
		private void tick() {} // 0x00C9F8C0-0x00C9F960
	}
}
