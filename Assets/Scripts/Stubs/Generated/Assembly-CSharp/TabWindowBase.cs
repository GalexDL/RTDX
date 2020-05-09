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

public class TabWindowBase : UIWindowBase // TypeDefIndex: 6375
{
	// Fields
	private List<UIWindowBase> tabWindowList_; // 0x30
	private int currentTab_; // 0x38
	private bool bShow_; // 0x3C
	private CallbackAction callbackFunc_; // 0x40

	// Properties
	public bool Show { get => default; set {} } // 0x0091AC20-0x0091AC30 0x0091AC30-0x0091AC40
	public int Count { get => default; } // 0x0091ACE0-0x0091AD30 
	public int Current { get => default; } // 0x0091AD30-0x0091AD40 

	// Nested types
	public enum ActionType // TypeDefIndex: 6376
	{
		TabNext = 0,
		TabPrev = 1
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6377; 0x0091B9F0-0x0091BDA0

	// Constructors
	public TabWindowBase() {} // 0x0091C060-0x0091C070

	// Methods
	public override void Init(GameObject root) {} // 0x0091AC40-0x0091ACE0
	public void AddTab(UIWindowBase window) {} // 0x0091AD40-0x0091AF60
	protected override bool _setEnable(bool bEnable) => default; // 0x0091AF60-0x0091B110
	protected void _setTab(int tabNo, bool bEnable) {} // 0x0091B110-0x0091B270
	public void SetTab(int tabNo) {} // 0x0091B270-0x0091B300
	// [IteratorStateMachine] // 0x006261B0-0x00626220
	public virtual IEnumerator ChangeTab(int tabNo, Action cb = null) => default; // 0x0091B300-0x0091B380
	public override void Update() {} // 0x0091B3B0-0x0091B500
	protected override void _doUpdate() {} // 0x0091B500-0x0091B5E0
	protected virtual void _pressedButtonAnimation(string token) {} // 0x0091B5E0-0x0091B6F0
	protected virtual void _doTabNext() {} // 0x0091B6F0-0x0091B770
	protected virtual void _doTabPrev() {} // 0x0091B780-0x0091B800
	public void ResetActionListener() {} // 0x0091B800-0x0091B810
	public void RegisterActionListener(CallbackAction cb) {} // 0x0091B810-0x0091B900
	public void UnregisterActionListener(CallbackAction cb) {} // 0x0091B900-0x0091B9F0
	public void callAction(ActionType action) {} // 0x0091B770-0x0091B780
	// [IteratorStateMachine] // 0x00626220-0x00626290
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x0091BDA0-0x0091BE20
	// [IteratorStateMachine] // 0x00626290-0x00626300
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x0091BE50-0x0091BED0
	// [IteratorStateMachine] // 0x00626300-0x00626370
	public IEnumerator ShowWindow(Action cb = null) => default; // 0x0091BF00-0x0091BF80
	// [IteratorStateMachine] // 0x00626370-0x006263E0
	public IEnumerator HideWindow(Action cb = null) => default; // 0x0091BFB0-0x0091C030
}

