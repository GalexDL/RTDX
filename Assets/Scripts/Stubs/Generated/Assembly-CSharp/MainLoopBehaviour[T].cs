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

public abstract class MainLoopBehaviour<T> : MonoBehaviour // TypeDefIndex: 5547
	where T : Component
{
	// Fields
	private bool bValid_; // 0x00

	// Properties
	public bool Valid { get; }

	// Constructors
	protected MainLoopBehaviour() {}

	// Methods
	public static T Create() => default;
	public static void Destroy(T instance) {}
	private void Awake() {}
	private void Start() {}
	public abstract void OnStart();
	public abstract IEnumerator MainLoop();
	// [IteratorStateMachine] // 0x00620B10-0x00620B80
	private IEnumerator MainLoop_() => default;
	// [IteratorStateMachine] // 0x00620B80-0x00620BF0
	public IEnumerator WaitMainLoop() => default;
}

