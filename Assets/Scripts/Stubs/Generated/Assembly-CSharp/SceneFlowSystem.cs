/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SceneFlowSystem : SingletonMonoBehaviour<SceneFlowSystem> // TypeDefIndex: 8015
{
	// Fields
	private static ISceneFlow nowSceneFlow_; // 0x00
	private static ISceneFlow requestNextSceneFlow_; // 0x08
	public bool AutoSceneFlag; // 0x18
	public string[] AutoSceneArg; // 0x20

	// Properties
	public static bool NowRequestNextFlow { get => default; } // 0x00CB6080-0x00CB60F0 

	// Constructors
	public SceneFlowSystem() {} // 0x00CB60F0-0x00CB6160
	static SceneFlowSystem() {} // 0x00CB6160-0x00CB6170

	// Methods
	private void Start() {} // 0x00CB5D40-0x00CB5DB0
	// [IteratorStateMachine] // 0x006300A0-0x00630110
	private IEnumerator StartCo() => default; // 0x00CB5DB0-0x00CB5E20
	private void StartMainLoop() {} // 0x00CB5E50-0x00CB5F20
	// [IteratorStateMachine] // 0x00630110-0x00630180
	private IEnumerator MainLoop() => default; // 0x00CB5F20-0x00CB5F80
	public static void SetNextFlow(ISceneFlow sceneFlow) {} // 0x00CB5FB0-0x00CB6080
	public static bool CheckNowFlowType<T>()
		where T : ISceneFlow => default;
}

