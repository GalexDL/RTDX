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
	public static class ActTypeDatabase // TypeDefIndex: 8723
	{
		// Fields
		private static Dictionary<Type, TargetTypeInfo> targetTypesTbl_; // 0x00
		private static Dictionary<Type, CommandTypeInfo> commandTypesTbl_; // 0x08
	
		// Nested types
		public class TargetTypeInfo // TypeDefIndex: 8724
		{
			// Fields
			public string uiDispName; // 0x10
			public string uniqName; // 0x18
			public Type type; // 0x20
	
			// Constructors
			public TargetTypeInfo() {} // 0x00AA5DF0-0x00AA5E00
		}
	
		public class CommandTypeInfo // TypeDefIndex: 8725
		{
			// Fields
			public string uniqName; // 0x10
			public Type type; // 0x18
			public HashSet<Type> acceptTargetTypes; // 0x20
			public bool isNoWaitCmd; // 0x28
	
			// Constructors
			public CommandTypeInfo() {} // 0x00AA5E00-0x00AA5E70
		}
	
		// Constructors
		static ActTypeDatabase() {} // 0x00AA5740-0x00AA57F0
	
		// Methods
		public static Type GetType(string typeName) => default; // 0x00AA5D60-0x00AA5DF0
		private static void RegistCommandsAuto_() {} // 0x00AA57F0-0x00AA5D60
		public static ActTargetBase CreateTargetByName(string uniqName) => default; // 0x00AA36B0-0x00AA3880
		public static ActCommandBase CreateCommandByName(string uniqName) => default; // 0x00AA5E70-0x00AA6040
		public static TargetTypeInfo GetTargetTypeInfo(Type t) => default; // 0x00AA35A0-0x00AA3640
		public static CommandTypeInfo GetCommandTypeInfo(Type t) => default; // 0x00AA6040-0x00AA60E0
		public static TargetTypeInfo GetTargetTypeInfoByName(string uniqName) => default; // 0x00AA13D0-0x00AA1550
		public static CommandTypeInfo GetCommandTypeInfoByName(string uniqName) => default; // 0x00AA60E0-0x00AA6260
		public static List<TargetTypeInfo> EnumTargetTypeInfo() => default; // 0x00AA6260-0x00AA63F0
		public static List<CommandTypeInfo> EnumCommandTypeInfo(HashSet<Type> filterTargetTypeSet) => default; // 0x00AA63F0-0x00AA67F0
	}
}
