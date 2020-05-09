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

public class UICommonBulletinBoard : UIManagerBase // TypeDefIndex: 6477
{
	// Fields
	protected CommonScreen commonScreen_; // 0x20
	protected QuestListWindow questListWindow_; // 0x28
	protected QuestDetailWindow questDetailWindow_; // 0x30

	// Constructors
	public UICommonBulletinBoard() {} // 0x009759A0-0x009759B0

	// Methods
	protected virtual void _updateQuestDetail() {} // 0x009755B0-0x009756E0
	// [IteratorStateMachine] // 0x00626E00-0x00626E70
	protected IEnumerator _ShowMessage(TextIDHash textIdHash, Action cb = null) => default; // 0x009756E0-0x00975760
	// [IteratorStateMachine] // 0x00626E70-0x00626EE0
	protected IEnumerator _ShowMessage(TextId textId, Action cb = null) => default; // 0x00975790-0x00975810
	// [IteratorStateMachine] // 0x00626EE0-0x00626F50
	protected IEnumerator _ShowMessage(TextId textId, TextId textId2, Action cb = null) => default; // 0x00975840-0x009758C0
	// [IteratorStateMachine] // 0x00626F50-0x00626FC0
	protected IEnumerator _ShowMessage_NotClose(TextId textId, Action cb = null) => default; // 0x009758F0-0x00975970
}

