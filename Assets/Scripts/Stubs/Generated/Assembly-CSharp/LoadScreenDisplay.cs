/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class LoadScreenDisplay : UIManagerBase // TypeDefIndex: 5683
{
	// Fields
	private AskTypes ask; // 0x1C
	public static TextIDHash[] AskTextBody; // 0x00
	public static TextIDHash[] AskTextYes; // 0x08
	public static TextIDHash[] AskTextNo; // 0x10
	public static TextIDHash[] CancelText; // 0x18
	private LoadScreenWindow loadScreen; // 0x20
	private bool bVisibleLoadScreen; // 0x28

	// Nested types
	public enum AskTypes // TypeDefIndex: 5684
	{
		DUNGEON_GIVEUP = 0,
		DUNGEON_GIVEUP_SUBMITTED = 1,
		DUNGEON_GIVEUP_SUBMITTED_PAYMENT = 2,
		SAVEDATA_DELETE = 3,
		SAVEDATA_DELETE2 = 4,
		MAX = 5
	}

	private class LoadScreenWindow : UIWindowBase // TypeDefIndex: 5685
	{
		// Fields
		private TitleFlowToolBox m_toolBox; // 0x30
		private bool bActiveRescueWindow; // 0x38

		// Properties
		public TitleFlowToolBox ToolBox { get => default; } // 0x00BFCD40-0x00BFCD50 

		// Constructors
		public LoadScreenWindow() {} // 0x00BF99B0-0x00BF9A20

		// Methods
		public override void Init(GameObject root) {} // 0x00BFCD50-0x00BFCD60
		public void SetUpLoadWindow() {} // 0x00BFB2A0-0x00BFCCB0
		public void SetHeroFace(FACE_TYPE type) {} // 0x00BFAE40-0x00BFB150
		// [IteratorStateMachine] // 0x00644FD0-0x00645040
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00BFCD60-0x00BFCDE0
		// [IteratorStateMachine] // 0x00645040-0x006450B0
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00BFCE10-0x00BFCE90
	}

	// Constructors
	public LoadScreenDisplay() {} // 0x00BF9C20-0x00BF9C30
	static LoadScreenDisplay() {} // 0x00BF9C30-0x00BF9D80

	// Methods
	public static LoadScreenDisplay Create() => default; // 0x00BF9760-0x00BF98C0
	public void Construct() {} // 0x00BF98C0-0x00BF99B0
	public void SetAskType(AskTypes type) {} // 0x00BF9A20-0x00BF9A30
	// [IteratorStateMachine] // 0x00621100-0x00621170
	public IEnumerator OpenWindow() => default; // 0x00BF9A30-0x00BF9AA0
	// [IteratorStateMachine] // 0x00621170-0x006211E0
	public IEnumerator CloseWindow() => default; // 0x00BF9AD0-0x00BF9B40
	// [IteratorStateMachine] // 0x006211E0-0x00621250
	public IEnumerator MainFlow(Action<bool> cb = null) => default; // 0x00BF9B70-0x00BF9BF0
}

