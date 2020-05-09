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
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonResult : UIManagerBase // TypeDefIndex: 6778
{
	// Fields
	private CommonScreen commonScreen_; // 0x20
	private ResultTextWindow resultText_; // 0x28
	private ResultTresureBox resultTresureBox_; // 0x30
	private TresureItemListWindow resultTresureList_; // 0x38
	private List<TresureInfo> tresureInfoList_; // 0x40
	private List<IPartyStatus> guestPokemonList_; // 0x48
	private ActionType act_; // 0x50
	private DungeonResultParameter resultParam_; // 0x58
	private static bool bResultExecute_; // 0x00
	private int tresureInfoIndex_; // 0x60

	// Nested types
	public class ResultCommonWindow : UIWindowBase // TypeDefIndex: 6779
	{
		// Fields
		private CallbackAction callbackFunc_; // 0x30

		// Nested types
		public enum ActionType // TypeDefIndex: 6780
		{
			Decide = 0,
			Skip = 1
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6781; 0x00B24780-0x00B24B30

		// Constructors
		public ResultCommonWindow() {} // 0x00B24B30-0x00B24B50

		// Methods
		protected override void _doUpdate() {} // 0x00B24590-0x00B24670
		public void ResetActionListener() {} // 0x00B24680-0x00B24690
		public void RegisterActionListener(CallbackAction cb) {} // 0x00B21840-0x00B21930
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00B24690-0x00B24780
		public void callAction(ActionType action) {} // 0x00B24670-0x00B24680
	}

	public class ResultTextWindow : ResultCommonWindow // TypeDefIndex: 6782
	{
		// Constructors
		public ResultTextWindow() {} // 0x00B21820-0x00B21830

		// Methods
		// [IteratorStateMachine] // 0x0064B600-0x0064B670
		public override IEnumerator OpenWindow(string sText, Action cb = null) => default; // 0x00B24BF0-0x00B24C70
	}

	public class TresureItemListWindow : BasicListWindow // TypeDefIndex: 6784
	{
		// Nested types
		protected class UILocalSelectItem : UICommonItemSelectItem // TypeDefIndex: 6785
		{
			// Fields
			private bool bPlayEffect_; // 0x50

			// Properties
			public bool PlayEffect { get => default; set {} } // 0x00B270A0-0x00B270B0 0x00B27090-0x00B270A0

			// Constructors
			public UILocalSelectItem() {} // 0x00B27080-0x00B27090
		}

		protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6786
		{
			// Constructors
			public UILocalSelector() {} // 0x00B26F40-0x00B26FB0

			// Methods
			protected override void SetupFace() {} // 0x00B270B0-0x00B27360
		}

		// Constructors
		public TresureItemListWindow() {} // 0x00B21940-0x00B21950

		// Methods
		public override void Init(GameObject objRoot) {} // 0x00B26A90-0x00B26C90
		public void AddItem(List<TresureInfo> list, int endIndex, bool bEffect) {} // 0x00B22E80-0x00B22FD0
		protected override bool _doUp() => default; // 0x00B26CA0-0x00B26CB0
		protected override bool _doDown() => default; // 0x00B26CB0-0x00B26CC0
		protected override bool _doLeft() => default; // 0x00B26CC0-0x00B26D30
		protected override bool _doRight() => default; // 0x00B26D30-0x00B26DB0
		protected override bool _doDecide() => default; // 0x00B26DB0-0x00B26DD0
		protected override bool _doCancel() => default; // 0x00B26DD0-0x00B26DF0
	}

	public class ResultTresureBox : ResultCommonWindow // TypeDefIndex: 6789
	{
		// Fields
		private int countNormal_; // 0x38
		private int numNormal_; // 0x3C
		private int countRare_; // 0x40
		private int numRare_; // 0x44
		private bool bOpenBoxRare_; // 0x48
		private bool bOpenFirst_; // 0x49
		private GameObject itemIconObj_; // 0x50
		private Image itemIconImageRef_; // 0x58
		private Index itemIcon_; // 0x60

		// Constructors
		public ResultTresureBox() {} // 0x00B21930-0x00B21940

		// Methods
		public override void Init(GameObject root) {} // 0x00B24EF0-0x00B25100
		public void Term() {} // 0x00B21A50-0x00B21AE0
		protected void _updateValueText(string tagTMP, int bufferId, int value) {} // 0x00B25190-0x00B25340
		public void UpdateSubWindowCountNormal(int countNormal) {} // 0x00B25340-0x00B253E0
		public void UpdateSubWindowNumNormal(int numNormal) {} // 0x00B253E0-0x00B25480
		public void UpdateSubWindowCountRare(int countRare) {} // 0x00B25480-0x00B25520
		public void UpdateSubWindowNumRare(int numRare) {} // 0x00B25520-0x00B255C0
		public void InitSubWindowCount(int numNormal, int numRare) {} // 0x00B220B0-0x00B22260
		public void FinishSubWindowCount() {} // 0x00B235F0-0x00B23700
		// [IteratorStateMachine] // 0x0064B670-0x0064B6E0
		public IEnumerator OpenSubWindow(Action cb = null) => default; // 0x00B229D0-0x00B22A50
		// [IteratorStateMachine] // 0x0064B6E0-0x0064B750
		public IEnumerator CloseSubWindow(Action cb = null) => default; // 0x00B232C0-0x00B23340
		private void _iconUnload() {} // 0x00B25100-0x00B25190
		// [IteratorStateMachine] // 0x0064B750-0x0064B7C0
		private IEnumerator _iconLoad(Index itemIndex) => default; // 0x00B25620-0x00B256A0
		// [IteratorStateMachine] // 0x0064B7C0-0x0064B830
		public IEnumerator OpenBox(Index itemIndex, bool bRare, Action cb, Action openCb) => default; // 0x00B23160-0x00B23200
		// [IteratorStateMachine] // 0x0064B830-0x0064B8A0
		public IEnumerator CloseBox(Action cb = null) => default; // 0x00B23240-0x00B232C0
		// [IteratorStateMachine] // 0x0064B8A0-0x0064B910
		public IEnumerator OpenList(Action cb = null) => default; // 0x00B22A50-0x00B22AD0
		// [IteratorStateMachine] // 0x0064B910-0x0064B980
		public IEnumerator CloseAll(Action cb = null) => default; // 0x00B23700-0x00B23780
	}

	public class TresureInfo // TypeDefIndex: 6801
	{
		// Fields
		public IItem tresure; // 0x10
		public bool bRareChest; // 0x18

		// Constructors
		public TresureInfo() {} // 0x00B220A0-0x00B220B0
	}

	public enum ActionType // TypeDefIndex: 6802
	{
		None = 0,
		Finish = 1
	}

	// Constructors
	public UIDungeonResult() {} // 0x00B23F30-0x00B23F40
	static UIDungeonResult() {} // 0x00B23F40-0x00B23F50

	// Methods
	public static UIDungeonResult Create() => default; // 0x00B21340-0x00B21490
	public void Construct() {} // 0x00B21490-0x00B21820
	public void Destruct() {} // 0x00B21950-0x00B21A50
	public void Init(DungeonResultParameter resultParam) {} // 0x00B21AE0-0x00B220A0
	public static bool IsResultExecute() => default; // 0x00B22260-0x00B222D0
	// [IteratorStateMachine] // 0x00628420-0x00628490
	public virtual IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00B222D0-0x00B22350
	private void _onResultTextOpen() {} // 0x00B22380-0x00B22470
	private void _onResultStatusOpen() {} // 0x00B22470-0x00B224B0
	private void _cbFromResultStatus(ResultCommonWindow.ActionType act) {} // 0x00B224B0-0x00B22600
	private void _onResultStatusEnd() {} // 0x00B22610-0x00B229D0
	private void _cbFromTresureBox(ResultCommonWindow.ActionType act) {} // 0x00B22B50-0x00B22C10
	private void _onOpenTresureBoxStart() {} // 0x00B22FD0-0x00B23160
	private void _onOpenTresureBoxWait() {} // 0x00B23200-0x00B23240
	private void _onOpenTresureBoxNext() {} // 0x00B22C10-0x00B22E80
	private void _cbFromTresureList(ListWindowBase.ActionType act) {} // 0x00B23340-0x00B23380
	private void _onOpenTresureBoxStartList() {} // 0x00B234C0-0x00B235F0
	private void _onOpenTresureBoxFinish() {} // 0x00B23380-0x00B234C0
	private void _onOpenTresureBoxItemReceive() {} // 0x00B23780-0x00B239A0
	private void _onOpenTresureBoxEnd() {} // 0x00B22AD0-0x00B22B50
	private void _onResultGuestStart() {} // 0x00B239A0-0x00B23C70
	private void _onResultGuestEnd() {} // 0x00B23C70-0x00B23EC0
	private void _onResultFinish() {} // 0x00B22600-0x00B22610
	private void Start() {} // 0x00B23EC0-0x00B23ED0
	private void Update() {} // 0x00B23ED0-0x00B23F30
}

