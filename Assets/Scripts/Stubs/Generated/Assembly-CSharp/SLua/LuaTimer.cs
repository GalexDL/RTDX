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
	public class LuaTimer : LuaObject // TypeDefIndex: 8275
	{
		// Fields
		private static int nextSn; // 0x00
		private static int jiffies_msec; // 0x04
		private static float jiffies_sec; // 0x08
		private static Wheel[] wheels; // 0x10
		private static float pileSecs; // 0x18
		private static float nowTime; // 0x1C
		private static Dictionary<int, Timer> mapSnTimer; // 0x20
		private static LinkedList<Timer> executeTimers; // 0x28
	
		// Nested types
		private class Timer // TypeDefIndex: 8276
		{
			// Fields
			internal int sn; // 0x10
			internal int cycle; // 0x14
			internal int deadline; // 0x18
			internal Func<int, bool> handler; // 0x20
			internal bool delete; // 0x28
			internal LinkedList<Timer> container; // 0x30
	
			// Constructors
			public Timer() {} // 0x00CA37E0-0x00CA37F0
		}
	
		private class Wheel // TypeDefIndex: 8277
		{
			// Fields
			internal static int dial_scale; // 0x00
			internal int head; // 0x10
			internal LinkedList<Timer>[] vecDial; // 0x18
			internal int dialSize; // 0x20
			internal int timeRange; // 0x24
			internal Wheel nextWheel; // 0x28
	
			// Constructors
			public Wheel() {} // Dummy constructor
			internal Wheel(int dialSize) {} // 0x00CA3370-0x00CA3500
			static Wheel() {} // 0x00CA3C30-0x00CA3CE0
	
			// Methods
			internal LinkedList<Timer> nextDial() => default; // 0x00CA3000-0x00CA3050
			internal void add(int delay, Timer tm) {} // 0x00CA2D00-0x00CA2E30
		}
	
		// Constructors
		public LuaTimer() {} // 0x00CA38F0-0x00CA3960
		static LuaTimer() {} // 0x00CA3960-0x00CA39E0
	
		// Methods
		private static int intpow(int n, int m) => default; // 0x00CA2A10-0x00CA2A80
		private static void innerAdd(int deadline, Timer tm) {} // 0x00CA2A80-0x00CA2C80
		private static void innerDel(Timer tm) {} // 0x00CA2E30-0x00CA2F30
		private static void innerDel(Timer tm, bool removeFromMap) {} // 0x00CA2F30-0x00CA3000
		private static int now() => default; // 0x00CA2C80-0x00CA2D00
		internal static void tick(float deltaTime) {} // 0x00C9F960-0x00C9FFE0
		private static void init() {} // 0x00CA3050-0x00CA3370
		private static int fetchSn() => default; // 0x00CA3500-0x00CA3570
		internal static int add(int delay, Action<int> handler) => default; // 0x00CA3570-0x00CA3640
		internal static int add(int delay, int cycle, Func<int, bool> handler) => default; // 0x00CA3650-0x00CA37E0
		internal static void del(int sn) {} // 0x00CA37F0-0x00CA38B0
		// [MonoPInvokeCallback] // 0x0063B5D0-0x0063B640
		public static int Delete(IntPtr l) => default; // 0x00CA1E90-0x00CA2070
		// [MonoPInvokeCallback] // 0x0063B640-0x0063B6B0
		public static int Add(IntPtr l) => default; // 0x00CA2070-0x00CA26A0
		// [MonoPInvokeCallback] // 0x0063B6B0-0x0063B720
		public static int DeleteAll(IntPtr l) => default; // 0x00CA26A0-0x00CA2A10
		public static void reg(IntPtr l) {} // 0x00C9E1F0-0x00C9E390
	}
}
