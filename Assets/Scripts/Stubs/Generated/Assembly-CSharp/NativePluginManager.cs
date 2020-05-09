/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x006097C0-0x006097D0
public class NativePluginManager : MonoBehaviour // TypeDefIndex: 5550
{
	// Fields
	private const string sDLL = "__Internal"; // Metadata: 0x00611C49
	private static bool bIsNativePluginStarted_; // 0x00

	// Properties
	public static bool IsNativePluginAccessEnable { get => default; } // 0x0089BE20-0x0089BE90 

	// Constructors
	public NativePluginManager() {} // 0x0089C290-0x0089C2A0
	static NativePluginManager() {} // 0x0089C2A0-0x0089C2B0

	// Methods
	private static extern void Plugin_Initialize(bool bEditorStart, bool bNativeConfirmation, string dllPath, string persistentDataPath, string streamingDataPath); // 0x0089BD80-0x0089BE10
	private static extern void Plugin_Unload(); // 0x0089BE10-0x0089BE20
	private void OnEnable() {} // 0x0089BE90-0x0089BEA0
	private void OnDisable() {} // 0x0089BEA0-0x0089BF10
	private void Start() {} // 0x0089BF10-0x0089C020
	// [IteratorStateMachine] // 0x00620BF0-0x00620C60
	private IEnumerator startGameSystem_() => default; // 0x0089C160-0x0089C1C0
	private void OnApplicationQuit() {} // 0x0089C1F0-0x0089C290
	private static void LoadNativePlugin_() {} // 0x0089C020-0x0089C160
}

