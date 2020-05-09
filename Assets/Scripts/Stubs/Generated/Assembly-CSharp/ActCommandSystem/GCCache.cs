/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	internal static class GCCache // TypeDefIndex: 8686
	{
		// Fields
		private static Stack<HashSet<ActDataPlayer.CommandInstance>> commandInstance_HashSetCache_; // 0x00
		private static Stack<List<ActDataPlayer.CommandInstance>> commandInstance_ListSetCache_; // 0x08
		private static Stack<HashSet<ActCommandCell>> actCommandCell_HashSetCache_; // 0x10
		private static Stack<Dictionary<string, List<ActDataPlayer.CommandInstance>>> commandInstance_DictCache_; // 0x18
	
		// Constructors
		static GCCache() {} // 0x00AA6890-0x00AA69A0
	
		// Methods
		public static HashSet<ActDataPlayer.CommandInstance> Create_CommandInstance_HashSet_() => default; // 0x00A9CBC0-0x00A9CCB0
		public static void Free_HashSet_CommandInstance_HashSet_(HashSet<ActDataPlayer.CommandInstance> v) {} // 0x00A9CCB0-0x00A9CD40
		public static HashSet<ActCommandCell> Create_actCommandCell_HashSetCache_() => default; // 0x00A9E050-0x00A9E140
		public static void Free_actCommandCell_HashSetCache_(HashSet<ActCommandCell> v) {} // 0x00A9E350-0x00A9E3E0
		public static List<ActDataPlayer.CommandInstance> Create_commandInstance_ListSetCache_() => default; // 0x00A9DF60-0x00A9E050
		public static void Free_commandInstance_ListSetCache_(List<ActDataPlayer.CommandInstance> v) {} // 0x00A9E230-0x00A9E2C0
		public static Dictionary<string, List<ActDataPlayer.CommandInstance>> Create_commandInstance_DictCache__() => default; // 0x00A9E140-0x00A9E230
		public static void Free_commandInstance_DictCache__(Dictionary<string, List<ActDataPlayer.CommandInstance>> v) {} // 0x00A9E2C0-0x00A9E350
	}
}
