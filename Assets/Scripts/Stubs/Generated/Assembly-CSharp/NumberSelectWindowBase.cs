/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class NumberSelectWindowBase : UIWindowBase // TypeDefIndex: 6264
{
	// Fields
	private CallbackAction callbackFunc_; // 0x30

	// Nested types
	public enum ActionType // TypeDefIndex: 6265
	{
		Decide = 0,
		Cancel = 1,
		Focus = 2,
		Finished = 3,
		Up = 4,
		Down = 5
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6266; 0x00784BD0-0x00784F80

	// Constructors
	public NumberSelectWindowBase() {} // 0x00784FE0-0x00785000

	// Methods
	public void ResetActionListener() {} // 0x007849D0-0x007849E0
	public void RegisterActionListener(CallbackAction cb) {} // 0x007849E0-0x00784AD0
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00784AD0-0x00784BC0
	public void callAction(ActionType action) {} // 0x00784BC0-0x00784BD0
	protected override void _doUpdate() {} // 0x00784F80-0x00784FC0
	protected virtual void _doInput() {} // 0x00784FC0-0x00784FD0
	protected virtual void _update() {} // 0x00784FD0-0x00784FE0
}

