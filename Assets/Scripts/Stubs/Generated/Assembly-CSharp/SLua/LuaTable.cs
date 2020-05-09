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
	public class LuaTable : LuaVar, IEnumerable<SLua.LuaTable.TablePair>, IEnumerable // TypeDefIndex: 8246
	{
		// Properties
		public object this[string key] { get => default; set {} } // 0x00CA0820-0x00CA0840 0x00CA0840-0x00CA0860
		public object this[int index] { get => default; set {} } // 0x00CA0860-0x00CA0880 0x00CA0880-0x00CA08A0
		public bool IsEmpty { get => default; } // 0x00CA0BA0-0x00CA0C80 
	
		// Nested types
		public struct TablePair // TypeDefIndex: 8247
		{
			// Fields
			public object key; // 0x10
			public object value; // 0x18
		}
	
		public class Enumerator : IEnumerator<TablePair>, IEnumerator, IDisposable // TypeDefIndex: 8248
		{
			// Fields
			private LuaTable t; // 0x10
			private int indext; // 0x18
			private TablePair current; // 0x20
			private int iterPhase; // 0x30
	
			// Properties
			public TablePair Current { get => default; } // 0x00CA1090-0x00CA1140 
			object IEnumerator.Current { get => default; } // 0x00CA1140-0x00CA13A0 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			public Enumerator(LuaTable table) {} // 0x00CA0D10-0x00CA0D50
	
			// Methods
			public bool MoveNext() => default; // 0x00CA0E80-0x00CA0FC0
			public void Reset() {} // 0x00CA0DD0-0x00CA0E80
			public void Dispose() {} // 0x00CA0FC0-0x00CA1090
		}
	
		// Constructors
		public LuaTable() {} // Dummy constructor
		public LuaTable(IntPtr l, int r) {} // 0x00CA0590-0x00CA0620
		public LuaTable(LuaState l, int r) {} // 0x00CA06B0-0x00CA06F0
		public LuaTable(LuaState state) {} // 0x00CA0730-0x00CA0810
	
		// Methods
		public object invoke(string func, params /* 0x0065AD00-0x0065AD10 */ object[] args) => default; // 0x00CA08A0-0x00CA0A80
		public int length() => default; // 0x00CA0A80-0x00CA0BA0
		public IEnumerator<TablePair> GetEnumerator() => default; // 0x00CA0C90-0x00CA0D10
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00CA0D50-0x00CA0DD0
	}
}
