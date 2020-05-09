/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DebugScopeTimeChecker : IDisposable // TypeDefIndex: 4618
{
	// Fields
	public static bool Enable_; // 0x00
	private Stopwatch sw_; // 0x10
	private string text_; // 0x18

	// Constructors
	public DebugScopeTimeChecker() {} // Dummy constructor
	public DebugScopeTimeChecker(string text) {} // 0x009904D0-0x009905B0
	static DebugScopeTimeChecker() {} // 0x00990750-0x00990760

	// Methods
	public void Dispose() {} // 0x009905B0-0x00990640
	public void TimePrint(string addText) {} // 0x00990640-0x009906B0
	private long MicroSec_() => default; // 0x009906B0-0x00990750
}

