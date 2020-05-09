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

internal class NewsViewWindow : DetailWindowBase // TypeDefIndex: 6470
{
	// Fields
	private CallbackAction callbackFunc_; // 0x50

	// Nested types
	public enum ActionType // TypeDefIndex: 6471
	{
		Cancel = 0
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6472; 0x008B2400-0x008B27B0

	// Constructors
	public NewsViewWindow() {} // 0x008B2CB0-0x008B2CC0

	// Methods
	protected override bool _doLinkStart() => default; // 0x008B21F0-0x008B2200
	public void ResetActionListener() {} // 0x008B2200-0x008B2210
	public void RegisterActionListener(CallbackAction cb) {} // 0x008B2210-0x008B2300
	public void UnregisterActionListener(CallbackAction cb) {} // 0x008B2300-0x008B23F0
	public void callAction(ActionType action) {} // 0x008B23F0-0x008B2400
	public override void Init(GameObject detail) {} // 0x008B27B0-0x008B2980
	public void SetCaption() {} // 0x008B2980-0x008B2A90
	protected override void _doUpdate() {} // 0x008B2A90-0x008B2B50
	// [IteratorStateMachine] // 0x00626D20-0x00626D90
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x008B2B50-0x008B2BD0
	// [IteratorStateMachine] // 0x00626D90-0x00626E00
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x008B2C00-0x008B2C80
}

