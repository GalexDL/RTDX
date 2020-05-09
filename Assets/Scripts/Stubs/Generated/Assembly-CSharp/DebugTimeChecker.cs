/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public static class DebugTimeChecker // TypeDefIndex: 4620
{
	// Fields
	private static Dictionary<string, Stopwatch> timmerTbl_; // 0x00
	public static bool Enable_; // 0x08

	// Constructors
	static DebugTimeChecker() {} // 0x00991100-0x00991180

	// Methods
	public static void Begin(string name, bool bStartPrint = true /* Metadata: 0x00610A83 */) {} // 0x00990D00-0x00990E20
	public static void TimePrint(string name, string text) {} // 0x00990E20-0x00990F20
	public static void End(string name) {} // 0x00990F20-0x00991060
	private static long MicroSec_(Stopwatch sw) => default; // 0x00991060-0x00991100
}

