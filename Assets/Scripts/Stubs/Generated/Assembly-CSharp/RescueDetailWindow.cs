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

public class RescueDetailWindow : UIWindowBase // TypeDefIndex: 7467
{
	// Fields
	protected UIFaceWindow faceWindow_; // 0x30
	private UIPlayableAnimation animeOpen_; // 0x38
	private UIPlayableAnimation animeClose_; // 0x40

	// Constructors
	public RescueDetailWindow() {} // 0x00A065B0-0x00A065C0

	// Methods
	public void Init(GameObject root, bool bFaceBig) {} // 0x00A04980-0x00A04CA0
	protected void setFaceIcon_(Index pokemonIndex, bool bFemale) {} // 0x00A04CA0-0x00A04D70
	protected void activeFaceIcon_(bool bActive) {} // 0x00A04D70-0x00A04E20
	public void UpdateWindow(TicketListInfo ticketInfo) {} // 0x00A04E20-0x00A064B0
	// [IteratorStateMachine] // 0x0062C360-0x0062C3D0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00A064B0-0x00A06530
	// [IteratorStateMachine] // 0x0062C3D0-0x0062C440
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00A06530-0x00A065B0
}

