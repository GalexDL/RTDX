/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ListWindowBase : UIWindowBase // TypeDefIndex: 6252
{
	// Fields
	protected UISelectorManager menu_; // 0x30
	private CallbackAction callbackFunc_; // 0x38
	protected bool bEnableSeDecide_; // 0x40

	// Properties
	public UISelectorManager Menu { get => default; } // 0x008F9150-0x008F9160 
	public bool EnableSeDecide { get => default; set {} } // 0x00905FA0-0x00905FB0 0x00905F90-0x00905FA0

	// Nested types
	public enum ActionType // TypeDefIndex: 6253
	{
		Decide = 0,
		Cancel = 1,
		Focus = 2,
		PressX = 3,
		PressY = 4,
		CursorUp = 5,
		CursorDown = 6,
		CursorLeft = 7,
		CursorRight = 8,
		SwitchFavor = 9,
		PressStart = 10
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6254; 0x00905BE0-0x00905F90

	// Constructors
	public ListWindowBase() {} // 0x00906020-0x00906040

	// Methods
	public void ResetActionListener() {} // 0x00903880-0x00903890
	public void RegisterActionListener(CallbackAction cb) {} // 0x009038A0-0x00903990
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00905AF0-0x00905BE0
	public void callAction(ActionType action) {} // 0x008FD4A0-0x008FD4B0
	protected override void _doUpdate() {} // 0x00905FB0-0x00905FC0
	protected virtual void _doInput() {} // 0x00905FC0-0x00905FD0
	public UISelectorBase GetFocusSelector() => default; // 0x00905FD0-0x00905FE0
	public UISelectItem GetSelectItem(int cnt) => default; // 0x00905FE0-0x00905FF0
	public override void Init(GameObject root) {} // 0x00905FF0-0x00906020
}

