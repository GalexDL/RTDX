/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ManualCoroutineTaskSet // TypeDefIndex: 4587
{
	// Fields
	private List<ManualCoroutineTask> coroutineTasks_; // 0x10
	private List<ManualCoroutineTask> remLst_; // 0x18
	private List<ManualCoroutineTask> execLst_; // 0x20

	// Properties
	public bool IsAllEnd { get => default; } // 0x00892750-0x008927B0 

	// Constructors
	public ManualCoroutineTaskSet() {} // 0x00892DD0-0x00892E90

	// Methods
	public void ForceClear() {} // 0x008927B0-0x00892820
	public void UpdateMoveNext() {} // 0x00892820-0x00892B30
	public void AddCoroutine(IEnumerator co) {} // 0x00892B30-0x00892BD0
	public void AddCoroutine(IEnumerator co, bool bCallFirstFrameImmediately) {} // 0x00892C30-0x00892CE0
	public void AddCoroutineTask(ManualCoroutineTask coTask) {} // 0x00892BD0-0x00892C30
	public void AddCoroutineTask(ManualCoroutineTask coTask, bool bCallFirstFrameImmediately) {} // 0x00892CE0-0x00892D50
	public void Marge(ManualCoroutineTaskSet coTaskSet) {} // 0x00892D50-0x00892DD0
}

