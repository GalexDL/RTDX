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

public class UISystemWarehouseTop : UIManagerBase // TypeDefIndex: 7597
{
	// Fields
	private GameObject mainObj_; // 0x20
	private bool image_; // 0x28
	private ActionType act_; // 0x2C
	private int animCount_; // 0x30
	private ButtonBg buttonBg_; // 0x38
	private CommonItemBagInfo itemBagWindow_; // 0x40
	private ButtonSelect buttonSelect_; // 0x48

	// Nested types
	public enum ActionType // TypeDefIndex: 7598
	{
		None = 0,
		Cancel = 1,
		Dungeon = 2,
		WithdrawItem = 3,
		DepositItem = 4,
		WithdrawMoney = 5,
		DepositMoney = 6,
		FlowItem = 7,
		FlowBank = 8
	}

	private class ButtonBg : UIWindowBase // TypeDefIndex: 7599
	{
		// Constructors
		public ButtonBg() {} // 0x00E07E00-0x00E07E10
	}

	private class ButtonSelect : BasicMenuWindow // TypeDefIndex: 7600
	{
		// Fields
		private GameObject[] buttons_; // 0x48

		// Constructors
		public ButtonSelect() {} // 0x00E07DF0-0x00E07E00

		// Methods
		protected override bool _doLeft() => default; // 0x00E09830-0x00E09840
		protected override bool _doRight() => default; // 0x00E09840-0x00E09850
		public void Init(GameObject root, string[] sMenuTag, int defaultIndex = 0 /* Metadata: 0x00613891 */) {} // 0x00E08400-0x00E088D0
		public void FaceVisibleOff() {} // 0x00E09850-0x00E098D0
		// [IteratorStateMachine] // 0x00650A50-0x00650AC0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00E098D0-0x00E09950
		// [IteratorStateMachine] // 0x00650AC0-0x00650B30
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00E09950-0x00E099D0
	}

	// Constructors
	public UISystemWarehouseTop() {} // 0x00E08E20-0x00E08E30

	// Methods
	public static UISystemWarehouseTop Create(bool image) => default; // 0x00E07B50-0x00E07CC0
	public void Destroy() {} // 0x00E07D80-0x00E07DF0
	public void Construct() {} // 0x00E07CC0-0x00E07D80
	// [IteratorStateMachine] // 0x0062D9F0-0x0062DA60
	private IEnumerator _askMainFlow(Action<int> cb = null) => default; // 0x00E07E10-0x00E07E90
	// [IteratorStateMachine] // 0x0062DA60-0x0062DAD0
	public IEnumerator AskItemMainFlow(int defaultIndex, Action<int> cb = null) => default; // 0x00E07EC0-0x00E07F40
	private void _OnButtonSelectItem(int defaultIndex = 0 /* Metadata: 0x00613869 */) {} // 0x00E07F70-0x00E08400
	private void AnimeEndCb(Action cb) {} // 0x00E088D0-0x00E088F0
	private void _cbFromItemMenu(ListWindowBase.ActionType act) {} // 0x00E088F0-0x00E08DF0
	private void Update() {} // 0x00E08E00-0x00E08E20
}

