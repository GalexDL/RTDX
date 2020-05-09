/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLua;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[CustomLuaClass] // 0x00608C30-0x00608C40
public class LuaSYSTEM // TypeDefIndex: 4541
{
	// Fields
	private static float stopWatchTime_; // 0x00

	// Constructors
	public LuaSYSTEM() {} // 0x00BFEE70-0x00BFEE80
	static LuaSYSTEM() {} // 0x00BFEE80-0x00BFEE90

	// Methods
	public static void Test() {} // 0x00BFE970-0x00BFE9E0
	[IEnumeratorCoroutineYield] // 0x006195E0-0x00619660
	// [IteratorStateMachine] // 0x006195E0-0x00619660
	public static IEnumerator Sleep(LuaTimeSec timeSec) => default; // 0x00BFE9E0-0x00BFEA50
	public static void RequestGameFlowNext(LUA_GAME_FLOW_NEXT nextFlow) {} // 0x00BFEA80-0x00BFEB50
	public static void PlayManpu(LuaSymAct symAct, string manpuSymbol) {} // 0x00BFEB50-0x00BFEC50
	public static void ResetManpu(LuaSymAct symAct) {} // 0x00BFEC70-0x00BFED50
	public static void StartStopWatch() {} // 0x00BFED50-0x00BFEDD0
	[IEnumeratorCoroutineYield] // 0x00619660-0x006196E0
	// [IteratorStateMachine] // 0x00619660-0x006196E0
	public static IEnumerator WaitStopWatch(float time) => default; // 0x00BFEDD0-0x00BFEE40
}

