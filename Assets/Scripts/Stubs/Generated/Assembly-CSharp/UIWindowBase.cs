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

public abstract class UIWindowBase // TypeDefIndex: 7911
{
	// Fields
	protected GameObject objWindowRoot_; // 0x10
	protected bool bEnable_; // 0x18
	protected bool bEnableSkipAnimation_; // 0x19
	private string playingAnimationAction_; // 0x20
	protected ViewState viewState_; // 0x28
	protected int interruptOpenCloseCount_; // 0x2C

	// Properties
	public GameObject Root { get; } // 0x00D53800-0x00D53810 
	public bool Enable { get; set; } // 0x00D554C0-0x00D554D0 0x00D48F00-0x00D48F40
	public bool EnableSkipAnimation { get; set; } // 0x00D5DF60-0x00D5DF70 0x00D5DF70-0x00D5DF80

	// Nested types
	public enum ViewState // TypeDefIndex: 7912
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	// Constructors
	protected UIWindowBase() {} // 0x00D5C750-0x00D5C760

	// Methods
	public virtual bool IsValid() => default; // 0x00D5DBF0-0x00D5DC60
	public static void SetObjectActive(GameObject obj, bool bActive) {} // 0x00D4F3D0-0x00D4F490
	public static void SetObjectVisible(GameObject obj, bool bVisible) {} // 0x00D46700-0x00D46810
	public static bool IsObjectVisible(GameObject obj) => default; // 0x00D5DC60-0x00D5DD70
	public static void RestartAnimation(GameObject obj) {} // 0x00D5DD70-0x00D5DE80
	public virtual void Init(GameObject root) {} // 0x00D5DE80-0x00D5DF30
	public virtual void Visible(bool bEnable) {} // 0x00D5DF30-0x00D5DF40
	protected virtual bool _setEnable(bool bEnable) => default; // 0x00D5DF40-0x00D5DF50
	public virtual void Update() {} // 0x00D554D0-0x00D554F0
	protected virtual void _doUpdate() {} // 0x00D5DF50-0x00D5DF60
	protected virtual bool _skipAnimation() => default; // 0x00D5DF80-0x00D5DFB0
	protected virtual bool _checkSkipAnimation() => default; // 0x00D5DFB0-0x00D5E030
	// [IteratorStateMachine] // 0x0062F0B0-0x0062F120
	public virtual IEnumerator PlayAnimation(string action, Action<bool> cb) => default; // 0x00D5E030-0x00D5E0B0
	// [IteratorStateMachine] // 0x0062F120-0x0062F190
	public virtual IEnumerator StopAnimation() => default; // 0x00D5E0B0-0x00D5E120
	// [IteratorStateMachine] // 0x0062F190-0x0062F200
	public virtual IEnumerator OpenWindow(string sAnimeName, Action cb = null) => default; // 0x00D5E120-0x00D5E1A0
	// [IteratorStateMachine] // 0x0062F200-0x0062F270
	public virtual IEnumerator OpenWindow(Action cb = null) => default; // 0x00D5E1A0-0x00D5E220
	// [IteratorStateMachine] // 0x0062F270-0x0062F2E0
	public virtual IEnumerator ForceOpenWindow(Action cb = null) => default; // 0x00D5E220-0x00D5E2A0
	// [IteratorStateMachine] // 0x0062F2E0-0x0062F350
	public virtual IEnumerator CloseWindow(string sAnimeName, Action cb = null) => default; // 0x00D5E2A0-0x00D5E320
	// [IteratorStateMachine] // 0x0062F350-0x0062F3C0
	public virtual IEnumerator CloseWindow(Action cb = null) => default; // 0x00D5E320-0x00D5E3A0
	// [IteratorStateMachine] // 0x0062F3C0-0x0062F430
	public virtual IEnumerator ForceCloseWindow(Action cb = null) => default; // 0x00D5E3A0-0x00D5E420
	public virtual bool IsOpened() => default; // 0x00D5E420-0x00D5E430
	// [IteratorStateMachine] // 0x0062F430-0x0062F4A0
	public virtual IEnumerator WaitOpened() => default; // 0x00D5E430-0x00D5E4A0
	public virtual bool IsClosed() => default; // 0x00D5E4A0-0x00D5E4B0
	// [IteratorStateMachine] // 0x0062F4A0-0x0062F510
	public virtual IEnumerator WaitClosed() => default; // 0x00D5E4B0-0x00D5E520
	public virtual bool IsNone() => default; // 0x00D5E520-0x00D5E530
	public static void SeCursor() {} // 0x00D5E530-0x00D5E5F0
	public static void SeDecide() {} // 0x00D5BA10-0x00D5BAD0
	public static void SeCancel() {} // 0x00D5E5F0-0x00D5E6B0
	public static void SeSelectDisable() {} // 0x00D4B210-0x00D4B2D0
	public static void SeWindow() {} // 0x00D5E6B0-0x00D5E770
	public static void SeWindowSub() {} // 0x00D5E770-0x00D5E830
	public static void SeMark() {} // 0x00D5E830-0x00D5E8F0
	public static void SeSort() {} // 0x00D5E8F0-0x00D5E9B0
	public static void SeSlide() {} // 0x00D5E9B0-0x00D5EA70
	public static void SeDecide2() {} // 0x00D5EA70-0x00D5EB30
	public static void SeBag() {} // 0x00D5EB30-0x00D5EBF0
	public static void SeFavorOn() {} // 0x00D5EBF0-0x00D5ECB0
	public static void SeFavorOff() {} // 0x00D5ECB0-0x00D5ED70
	public static void SeRequestGo() {} // 0x00D5ED70-0x00D5EE30
	public static void SeRequestStop() {} // 0x00D5EE30-0x00D5EEF0
	public static void SeDelete() {} // 0x00D5EEF0-0x00D5EFB0
	public static void SeItemEquip() {} // 0x00D5EFB0-0x00D5F070
	public static void SeItemUnequip() {} // 0x00D5F070-0x00D5F130
	public static void SeQuestReceive() {} // 0x00D5F130-0x00D5F1F0
}

