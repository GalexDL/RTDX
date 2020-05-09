/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class Logger // TypeDefIndex: 8210
	{
		// Fields
		public static Action<Level, string> LogAction; // 0x00
	
		// Nested types
		public enum Level // TypeDefIndex: 8211
		{
			Debug = 0,
			Warning = 1,
			Error = 2
		}
	
		// Constructors
		public Logger() {} // 0x00840860-0x00840870
	
		// Methods
		private static UnityEngine.Object FindScriptByMsg(string msg) => default; // 0x00840600-0x00840610
		public static void Log(string msg, bool hasStacktrace = false /* Metadata: 0x00613E8E */) {} // 0x00840610-0x008406F0
		public static void LogError(string msg, bool hasStacktrace = false /* Metadata: 0x00613E8F */) {} // 0x008406F0-0x008407C0
		public static void LogWarning(string msg) {} // 0x008407C0-0x00840860
	}
}
