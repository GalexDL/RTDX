/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class ObjectCache // TypeDefIndex: 8268
	{
		// Fields
		private static Dictionary<IntPtr, ObjectCache> multiState; // 0x00
		private static IntPtr oldl; // 0x08
		internal static ObjectCache oldoc; // 0x10
		private FreeList cache; // 0x10
		private Dictionary<object, int> objMap; // 0x18
		private int udCacheRef; // 0x20
		private static Dictionary<Type, string> aqnameMap; // 0x18
	
		// Properties
		public Dictionary<object, int> Objs { get => default; } // 0x00CB1050-0x00CB10A0 
	
		// Nested types
		private class ObjSlot // TypeDefIndex: 8269
		{
			// Fields
			public int freeslot; // 0x10
			public object v; // 0x18
	
			// Constructors
			public ObjSlot() {} // Dummy constructor
			public ObjSlot(int slot, object o) {} // 0x00CB1EA0-0x00CB1EE0
		}
	
		private class FreeList : Dictionary<int, object> // TypeDefIndex: 8270
		{
			// Fields
			private int id; // 0x50
	
			// Constructors
			public FreeList() {} // 0x00CB1250-0x00CB12B0
	
			// Methods
			public int add(object o) => default; // 0x00CB1700-0x00CB1780
			public void del(int i) {} // 0x00CB14F0-0x00CB1550
			public bool get(int i, out object o) {
				o = default;
				return default;
			} // 0x00CB1450-0x00CB14C0
			public object get(int i) => default; // 0x00CB1E00-0x00CB1E80
			public void set(int i, object o) {} // 0x00CB1870-0x00CB18E0
		}
	
		public class ObjEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 8271
		{
			// Constructors
			public ObjEqualityComparer() {} // 0x00CB12B0-0x00CB12C0
	
			// Methods
			public new bool Equals(object x, object y) => default; // 0x00CB1E80-0x00CB1E90
			public int GetHashCode(object obj) => default; // 0x00CB1E90-0x00CB1EA0
		}
	
		// Constructors
		public ObjectCache() {} // Dummy constructor
		public ObjectCache(IntPtr l) {} // 0x00CB10A0-0x00CB1250
		static ObjectCache() {} // 0x00CB1D40-0x00CB1E00
	
		// Methods
		public static ObjectCache get(IntPtr l) => default; // 0x00CA6580-0x00CA67A0
		public static void clear() {} // 0x00C98B40-0x00C98BB0
		internal static void del(IntPtr l) {} // 0x00C98AC0-0x00C98B40
		internal static void make(IntPtr l) {} // 0x00C978F0-0x00C979B0
		public int size() => default; // 0x00CB12C0-0x00CB1310
		internal void gc(int index) {} // 0x00CB1310-0x00CB1450
		internal void gc(UnityEngine.Object o) {} // 0x00CB1550-0x00CB1620
		internal int add(object o) => default; // 0x00CB1620-0x00CB1700
		internal object get(IntPtr l, int p) => default; // 0x00CA67A0-0x00CA6890
		internal void setBack(IntPtr l, int p, object o) {} // 0x00CB1780-0x00CB1870
		internal void push(IntPtr l, object o) {} // 0x00CB18E0-0x00CB18F0
		internal void push(IntPtr l, Array o) {} // 0x00CB1A60-0x00CB1B20
		internal int allocID(IntPtr l, object o) => default; // 0x00CB1B20-0x00CB1C50
		internal void push(IntPtr l, object o, bool checkReflect) {} // 0x00CB18F0-0x00CB1A60
		private static string getAQName(object o) => default; // 0x00CB1C50-0x00CB1CE0
		internal static string getAQName(Type t) => default; // 0x00CA86C0-0x00CA87B0
		private bool isGcObject(object obj) => default; // 0x00CB14C0-0x00CB14F0
		public bool isObjInLua(object obj) => default; // 0x00CB1CE0-0x00CB1D40
	}
}
