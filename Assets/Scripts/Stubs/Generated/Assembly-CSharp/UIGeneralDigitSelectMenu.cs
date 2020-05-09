/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A5E0-0x0060A5F0
public class UIGeneralDigitSelectMenu : UIManagerBase // TypeDefIndex: 6916
{
	// Fields
	private BasicNumberSelectWindow numSelectWindow_; // 0x20
	private int max_; // 0x28
	private int min_; // 0x2C
	private int current_; // 0x30

	// Nested types
	private class GeneralNumberSelectWindow : BasicNumberSelectWindow // TypeDefIndex: 6917
	{
		// Fields
		protected GameObject[] faceSelects_; // 0x70
		protected int minCount_; // 0x78
		protected int resetCount_; // 0x7C

		// Properties
		public int MinCount { set {} } // 0x00A7A130-0x00A7A140
		public int ResetCount { set {} } // 0x00A7A120-0x00A7A130

		// Constructors
		public GeneralNumberSelectWindow() {} // 0x00A79A20-0x00A79A30

		// Methods
		public override void InitObjRoot(GameObject objRoot, int digit, int maxCount, Kind kindIndex) {} // 0x00A7A1D0-0x00A7A9E0
		protected override void _update() {} // 0x00A7A9E0-0x00A7AD80
		protected override bool _doDown() => default; // 0x00A7AD80-0x00A7AE50
		private new int Work(int i) => default; // 0x00A7AE50-0x00A7AEB0
		protected override void CountReset() {} // 0x00A7AEB0-0x00A7AEC0
	}

	// Constructors
	public UIGeneralDigitSelectMenu() {} // 0x00A79CB0-0x00A79CC0

	// Methods
	public static UIGeneralDigitSelectMenu Create(string sCustomMenu = null) => default; // 0x00A797E0-0x00A799B0
	public void Construct() {} // 0x00A799B0-0x00A79A20
	// [IteratorStateMachine] // 0x00628B90-0x00628C00
	public virtual IEnumerator MainFlow(Action<int> resultCb) => default; // 0x00A79A30-0x00A79AB0
	// [IteratorStateMachine] // 0x00628C00-0x00628C70
	public virtual IEnumerator MainFlow(int value, int min, int max, Action<int> resultCb) => default; // 0x00A79AE0-0x00A79B80
	public void SetVisible(bool bEnable) {} // 0x00A79BB0-0x00A79C80
	public void Continue() {} // 0x00A79C80-0x00A79C90
	private void Start() {} // 0x00A79C90-0x00A79CA0
	private void Update() {} // 0x00A79CA0-0x00A79CB0
}

