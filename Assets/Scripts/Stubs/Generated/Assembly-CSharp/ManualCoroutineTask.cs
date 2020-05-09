/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ManualCoroutineTask // TypeDefIndex: 4586
{
	// Fields
	private Stack<IEnumerator> coroutineStack_; // 0x10
	public bool isStopDeltaTimeZero; // 0x18

	// Properties
	public bool IsEnd { get => default; } // 0x008926A0-0x00892700 

	// Constructors
	public ManualCoroutineTask(IEnumerator co) {} // 0x0088DFB0-0x0088E070
	public ManualCoroutineTask() {} // 0x00892630-0x008926A0

	// Methods
	public void Start(IEnumerator co) {} // 0x008925D0-0x00892630
	public void ForceEnd() {} // 0x00892700-0x00892750
	public void UpdateMoveNext() {} // 0x0088E430-0x0088E940
}

