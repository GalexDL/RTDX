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

[ExecuteInEditMode] // 0x00609760-0x00609770
public class UIDiagnosisMenu : UIAskMenu // TypeDefIndex: 5175
{
	// Fields
	private bool bUpdate; // 0x3D
	private DiagnosisListWindow listWindow_; // 0x40

	// Nested types
	public class DiagnosisListWindow : BasicListWindow // TypeDefIndex: 5176
	{
		// Fields
		private Action decideAct; // 0x88
		private bool interruptFitstInput; // 0x90

		// Properties
		public UIBasicList List { get => default; } // 0x00B0F560-0x00B0F570 

		// Constructors
		public DiagnosisListWindow() {} // 0x00B0F570-0x00B0F580

		// Methods
		protected override void _updatePageNumber() {} // 0x00B10170-0x00B10380
		public void SetDecideAct(Action act) {} // 0x00B0F550-0x00B0F560
		protected override void _doInput() {} // 0x00B10380-0x00B103A0
		protected override bool _doDecide() => default; // 0x00B103A0-0x00B104A0
		// [IteratorStateMachine] // 0x00642DC0-0x00642E30
		public IEnumerator SwitchCloseWindow() => default; // 0x00B10070-0x00B100E0
	}

	public class UILocalSelectItem : UIBasicSelectItem // TypeDefIndex: 5181
	{
		// Constructors
		public UILocalSelectItem() {} // 0x00B0FA30-0x00B0FA40
	}

	protected class UILocalSelector : UIBasicSelector // TypeDefIndex: 5182
	{
		// Fields
		private bool bAfterFirstSet; // 0x29

		// Constructors
		public UILocalSelector() {} // 0x00B0F830-0x00B0F8A0

		// Methods
		protected override void SetupFace() {} // 0x00B10B00-0x00B11580
		protected override void SetupFaceBase() {} // 0x00B11580-0x00B11780
		protected override void FaceNormal() {} // 0x00B11780-0x00B11A40
		protected override bool FaceFocus() => default; // 0x00B11A40-0x00B11CC0
		protected override bool FaceSelect() => default; // 0x00B11CC0-0x00B11F80
	}

	// Constructors
	public UIDiagnosisMenu() {} // 0x00B0F670-0x00B0F6E0

	// Methods
	public static UIDiagnosisMenu Create(MenuFrameId frameId = MenuFrameId.Talk /* Metadata: 0x0061107A */) => default; // 0x00B0EED0-0x00B0F0D0
	// [IteratorStateMachine] // 0x0061E090-0x0061E100
	public IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Place place, Action<int> resultCb, Action decideAction) => default; // 0x00B0F170-0x00B0F220
	protected void _initialize(Item[] itemTable, int defaultIndex, Action decideAction) {} // 0x00B0F250-0x00B0F540
	public new void Construct() {} // 0x00B0F0D0-0x00B0F170
	private new void Start() {} // 0x00B0F580-0x00B0F590
	private new void Update() {} // 0x00B0F590-0x00B0F670
}

