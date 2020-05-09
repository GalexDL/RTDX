/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UICommonRescueBoard : UIManagerBase // TypeDefIndex: 7470
{
	// Fields
	protected CommonScreen commonScreen_; // 0x20
	protected RescueListWindow rescueListWindow_; // 0x28
	protected RescueDetailWindow rescueDetailWindow_; // 0x30

	// Constructors
	public UICommonRescueBoard() {} // 0x00976620-0x00976630

	// Methods
	protected virtual void _updateRescueDetail() {} // 0x00976430-0x00976570
	// [IteratorStateMachine] // 0x0062C440-0x0062C4B0
	protected IEnumerator _ShowMessage(TextIDHash textIdHash, Action cb = null) => default; // 0x00976570-0x009765F0
}

