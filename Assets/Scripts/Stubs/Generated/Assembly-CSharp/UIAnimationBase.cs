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

[ExecuteInEditMode] // 0x0060A380-0x0060A400
// [RequireComponent] // 0x0060A380-0x0060A400
public abstract class UIAnimationBase : MonoBehaviour // TypeDefIndex: 6419
{
	// Fields
	public string actionName; // 0x18

	// Nested types
	public delegate void CallbackAction(ActionType act); // TypeDefIndex: 6420; 0x007E10F0-0x007E14A0

	public enum ActionType // TypeDefIndex: 6421
	{
		Start = 0,
		Play = 1,
		End = 2
	}

	// Constructors
	protected UIAnimationBase() {} // 0x007E0B10-0x007E0B20

	// Methods
	protected abstract void _play();
	public abstract void Play(CallbackAction cb, string soundName = null);
	public abstract void Stop();
	public abstract void Skip();
	public static bool PlayEventHierarchy(Transform trans, string sActionName, CallbackAction cb = null) => default; // 0x007E0400-0x007E0500
	public static bool PlayEvent(Transform trans, string sActionName, CallbackAction cb = null) => default; // 0x007E0500-0x007E0600
	public static bool PlayEventHierarchy(Transform trans, string sActionName, string soundName, CallbackAction cb = null) => default; // 0x007E0600-0x007E0710
	// [IteratorStateMachine] // 0x00626680-0x006266F0
	public static IEnumerator PlayEventHierarchy_Sync(Transform trans, string sActionName, Action<bool> cb = null) => default; // 0x007E0710-0x007E0790
	// [IteratorStateMachine] // 0x006266F0-0x00626760
	public static IEnumerator PlayEventHierarchy_Sync(Transform trans, string sActionName, Func<bool> skip, Action<bool> cb = null) => default; // 0x007E07C0-0x007E0850
	// [IteratorStateMachine] // 0x00626760-0x006267D0
	public static IEnumerator PlayEvent_Sync(Transform trans, string sActionName, Action<bool> cb = null) => default; // 0x007E0880-0x007E0900
	public static bool StopEventHierarchy(Transform trans, string sActionName) => default; // 0x007E0930-0x007E0A20
	public static bool SkipEventHierarchy(Transform trans, string sActionName) => default; // 0x007E0A20-0x007E0B10
}

