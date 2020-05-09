/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pkd1GameSystem : SingletonMonoBehaviour<Pkd1GameSystem> // TypeDefIndex: 4359
{
	// Constructors
	public Pkd1GameSystem() {} // 0x00B76F90-0x00B77000

	// Methods
	private static extern void GameInitialize(bool bEditorDebug); // 0x00B76A10-0x00B76AC0
	public static extern bool IsGameInitialize(); // 0x00B76AC0-0x00B76B70
	public static extern void UpdateFromPlugin(int key); // 0x00B76B70-0x00B76C20
	public static extern void UpdateTexture(IntPtr p, int w, int h); // 0x00B76C20-0x00B76CE0
	public static extern bool IsEnableDebugScenarioEvent(); // 0x00B76CE0-0x00B76D90
	public static extern void RequestDebugScenarioEvent(int nEvent); // 0x00B76D90-0x00B76E40
	public static extern bool RequestDebugScenarioEventStop(); // 0x00B76E40-0x00B76EF0
	// [IteratorStateMachine] // 0x00618A90-0x00618B00
	public IEnumerator StartupForBootstrapMode(bool bEditorDebug) => default; // 0x00B76EF0-0x00B76F60
}

