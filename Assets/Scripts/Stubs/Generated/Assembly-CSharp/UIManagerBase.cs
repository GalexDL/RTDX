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

[ExecuteInEditMode] // 0x0060A650-0x0060A660
public class UIManagerBase : MonoBehaviour // TypeDefIndex: 7092
{
	// Fields
	protected int syncCount_; // 0x18

	// Constructors
	public UIManagerBase() {} // 0x00941EE0-0x00941EF0

	// Methods
	// [IteratorStateMachine] // 0x00629E60-0x00629ED0
	public virtual IEnumerator MainFlow() => default; // 0x009500F0-0x00950150
	private void OnEnable() {} // 0x00950180-0x00950270
	protected void _setTextTMP(string token, string message) {} // 0x00950270-0x009503C0
	// [IteratorStateMachine] // 0x00629ED0-0x00629F40
	public virtual IEnumerator OpenWindow(Action cb = null) => default; // 0x009503C0-0x00950440
	// [IteratorStateMachine] // 0x00629F40-0x00629FB0
	public virtual IEnumerator CloseWindow(Action cb = null) => default; // 0x00950470-0x009504F0
	protected void _syncInit() {} // 0x00950520-0x00950530
	protected void _syncAdd() {} // 0x00950530-0x00950540
	protected void _syncDel() {} // 0x00950540-0x00950550
	// [IteratorStateMachine] // 0x00629FB0-0x0062A020
	protected IEnumerator _syncWait(Action cb = null) => default; // 0x00950550-0x009505D0
	// [IteratorStateMachine] // 0x0062A020-0x0062A090
	public virtual IEnumerator WindowAnimationSync(List<IEnumerator> ActList, Action cb = null) => default; // 0x00950600-0x00950680
	// [IteratorStateMachine] // 0x0062A090-0x0062A100
	public virtual IEnumerator CallAct(IEnumerator act, Action cb = null) => default; // 0x009506B0-0x00950730
}

