/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class QuestDetailWindow : UIWindowBase // TypeDefIndex: 6466
{
	// Fields
	protected UIFaceWindow faceWindow_; // 0x30
	private UIPlayableAnimation animeOpen_; // 0x38
	private UIPlayableAnimation animeClose_; // 0x40
	private bool bShow_; // 0x48

	// Constructors
	public QuestDetailWindow() {} // 0x009F0BC0-0x009F0BD0

	// Methods
	public void Init(GameObject root, bool bFaceBig) {} // 0x009F0BD0-0x009F0F30
	protected void setFaceIcon_(Index pokemonIndex, bool bFemale) {} // 0x009F2590-0x009F2660
	protected void activeFaceIcon_(bool bActive) {} // 0x009F2660-0x009F29B0
	public void UpdateWindow(TicketListInfo ticketInfo) {} // 0x009F1060-0x009F2580
	public void ShowWindow(bool bShow) {} // 0x009F2B00-0x009F2C00
	// [IteratorStateMachine] // 0x00626C40-0x00626CB0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x009F2C00-0x009F2C80
	// [IteratorStateMachine] // 0x00626CB0-0x00626D20
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x009F2CB0-0x009F2D30
}

