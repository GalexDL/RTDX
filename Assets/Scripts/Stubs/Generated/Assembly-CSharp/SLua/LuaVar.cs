/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public abstract class LuaVar : IDisposable // TypeDefIndex: 8240
	{
		// Fields
		protected LuaState state; // 0x10
		protected int valueref; // 0x18
	
		// Properties
		public IntPtr L { get; } // 0x00CA0810-0x00CA0820 
		public int Ref { get; } // 0x00CA0C80-0x00CA0C90 
	
		// Constructors
		public LuaVar() {} // 0x00CA1740-0x00CA1770
		public LuaVar(LuaState l, int r) {} // 0x00CA06F0-0x00CA0730
		public LuaVar(IntPtr l, int r) {} // 0x00CA0620-0x00CA06B0
	
		// Methods
		~LuaVar() {} // 0x00CA18B0-0x00CA1930
		public void Dispose() {} // 0x00CA57B0-0x00CA5830
		public virtual void Dispose(bool disposeManagedResources) {} // 0x00CA1980-0x00CA1A80
		public void push(IntPtr l) {} // 0x00C9C470-0x00C9C4F0
		public override int GetHashCode() => default; // 0x00CA5830-0x00CA5840
		public override bool Equals(object obj) => default; // 0x00CA5840-0x00CA5920
		public static bool operator ==(LuaVar x, LuaVar y) => default; // 0x00CA5920-0x00CA5950
		public static bool operator !=(LuaVar x, LuaVar y) => default; // 0x00C9F890-0x00C9F8C0
		private static int Equals(LuaVar x, LuaVar y) => default; // 0x00CA5950-0x00CA5AC0
	}
}
