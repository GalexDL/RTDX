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

public class ButtonSelectWindow : BasicMenuWindow // TypeDefIndex: 6128
{
	// Fields
	private GameObject[] buttons_; // 0x48
	private GameObject bg_; // 0x50
	private bool _bEnableCancel; // 0x58

	// Properties
	public bool EnableCancel { get => default; set {} } // 0x008C2680-0x008C2690 0x008C2670-0x008C2680

	// Constructors
	public ButtonSelectWindow() {} // 0x008C30B0-0x008C30C0

	// Methods
	protected override bool _doLeft() => default; // 0x008C2650-0x008C2660
	protected override bool _doRight() => default; // 0x008C2660-0x008C2670
	protected override bool _cancel() => default; // 0x008C2690-0x008C26E0
	public void Init(GameObject root, string[] sMenuTag, int defaultIndex = 0 /* Metadata: 0x006125F9 */, GameObject bg = null) {} // 0x008C26E0-0x008C2AF0
	public void Init(GameObject root, GameObject[] sMenuObj, int defaultIndex = 0 /* Metadata: 0x006125FD */, GameObject bg = null) {} // 0x008C2AF0-0x008C2DF0
	public void FaceVisibleOff() {} // 0x008C2DF0-0x008C2E70
	public void FaceUnFocus() {} // 0x008C2E70-0x008C2EB0
	public void ClearAllSelectMenuItem() {} // 0x008C2EB0-0x008C2EF0
	// [IteratorStateMachine] // 0x00624630-0x006246A0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x008C2EF0-0x008C2F70
	// [IteratorStateMachine] // 0x006246A0-0x00624710
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x008C2FA0-0x008C3020
	public virtual GameObject GetButtonObject(int index) => default; // 0x008C3050-0x008C30B0
}

