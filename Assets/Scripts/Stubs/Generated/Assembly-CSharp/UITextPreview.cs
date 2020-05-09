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

public class UITextPreview : UIManagerBase // TypeDefIndex: 7608
{
	// Fields
	private Dictionary<string, string> LabelDictionary_; // 0x20
	private Dictionary<string, List<LabelData>> labelDataDictionary_; // 0x28
	private string[] targetFileNames; // 0x30
	private FiniteStateMachine<UITextPreview, States> FSM; // 0x38
	private GameObject mainObj_; // 0x40
	private bool bCancel_; // 0x48
	private string selectFileName_; // 0x50
	private TextIDHash selectTextID_; // 0x58
	private string selectLabel_; // 0x60

	// Nested types
	private class LabelData // TypeDefIndex: 7609
	{
		// Fields
		public string labelName_; // 0x10
		public TextIDHash textHash_; // 0x18

		// Constructors
		public LabelData() {} // 0x00A3B340-0x00A3B350
	}

	private enum TargetType // TypeDefIndex: 7610
	{
		tutrial_message = 0,
		item_explanation = 1,
		ability_explanation = 2,
		sugowaza_explanation = 3,
		order_explanation = 4,
		waza_explanation = 5,
		status_explanation = 6,
		camp_explanation = 7,
		death_factor = 8,
		pkd1_rescue_message = 9,
		dungeon_entrance = 10,
		backup = 11,
		password = 12,
		pegasus_camp = 13,
		pegasus_shop_bank = 14,
		pegasus_shop_bank_unman = 15,
		pegasus_shop_merchant = 16,
		pegasus_shop_rescue = 17,
		pegasus_shop_rescue_society = 18,
		pegasus_shop_shinka = 19,
		pegasus_shop_special_merchant = 20,
		pegasus_shop_training = 21,
		pegasus_shop_warehouse = 22,
		pegasus_shop_warehouse_unman = 23,
		pegasus_shop_waza = 24,
		dungeon_message = 25,
		dungeon_rescue = 26,
		dungeon_shop = 27,
		tutorial_name = 28,
		Max = 29
	}

	public enum States // TypeDefIndex: 7611
	{
		FileSelect = 0,
		LabelSelect = 1,
		MessageOutput = 2,
		End = 3
	}

	public class StateFileSelect : FSMState<UITextPreview, States> // TypeDefIndex: 7612
	{
		// Fields
		private int cursorIndex_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A3CC80-0x00A3CC90 

		// Constructors
		public StateFileSelect() {} // 0x00A3C4A0-0x00A3C4F0

		// Methods
		public override void Enter() {} // 0x00A3CC90-0x00A3CD60
		public override void Execute() {} // 0x00A3CDD0-0x00A3CE20
		// [IteratorStateMachine] // 0x00650BD0-0x00650C40
		private IEnumerator FileSelectLoop() => default; // 0x00A3CD60-0x00A3CDD0
	}

	public class StateLabelSelect : FSMState<UITextPreview, States> // TypeDefIndex: 7615
	{
		// Fields
		private int cursorIndex_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A3D310-0x00A3D320 

		// Constructors
		public StateLabelSelect() {} // 0x00A3C4F0-0x00A3C540

		// Methods
		public override void Enter() {} // 0x00A3D320-0x00A3D3F0
		public override void Execute() {} // 0x00A3D460-0x00A3D4B0
		// [IteratorStateMachine] // 0x00650C40-0x00650CB0
		private IEnumerator LabelSelectLoop() => default; // 0x00A3D3F0-0x00A3D460
	}

	public class StateMessageOutput : FSMState<UITextPreview, States> // TypeDefIndex: 7619
	{
		// Fields
		private DetailWindow detail_; // 0x18
		private UIHintDialog.HintDialogWindow hintDialogWindow_; // 0x20
		private bool input; // 0x28
		private GameObject instMenu_; // 0x30

		// Properties
		public override States StateID { get => default; } // 0x00A3DA50-0x00A3DA60 

		// Nested types
		private class DetailWindow : DetailWindowBase // TypeDefIndex: 7620
		{
			// Constructors
			public DetailWindow() {} // 0x00A3FD30-0x00A3FD40
		}

		// Constructors
		public StateMessageOutput() {} // 0x00A3C540-0x00A3C5A0

		// Methods
		public override void Enter() {} // 0x00A3DA60-0x00A3DA70
		private void Output_FromTextSizeSymbol() {} // 0x00A3DA70-0x00A3E070
		private void Output_FromFileName() {} // 0x00A3F7A0-0x00A3F9E0
		public override void Execute() {} // 0x00A3F9E0-0x00A3FBD0
		private void _doDecide() {} // 0x00A3FBD0-0x00A3FC60
		// [IteratorStateMachine] // 0x00650CB0-0x00650D20
		private IEnumerator Talk() => default; // 0x00A3F730-0x00A3F7A0
		private void CampExplain() {} // 0x00A3EBB0-0x00A3F0B0
		private void DungeonResult() {} // 0x00A3F0B0-0x00A3F3B0
		private void ResqueRequest() {} // 0x00A3F3B0-0x00A3F730
		private void PokemoStatusExplain() {} // 0x00A3E7A0-0x00A3EBB0
		private void PokemoOtherStatusExplain() {} // 0x00A3E3A0-0x00A3E7A0
		private void PopUpWindow(bool caption) {} // 0x00A3E070-0x00A3E3A0
	}

	public class StateEnd : FSMState<UITextPreview, States> // TypeDefIndex: 7622
	{
		// Properties
		public override States StateID { get => default; } // 0x00A3CC40-0x00A3CC50 

		// Constructors
		public StateEnd() {} // 0x00A3C5A0-0x00A3C5F0

		// Methods
		public override void Enter() {} // 0x00A3CC50-0x00A3CC60
		public override void Execute() {} // 0x00A3CC60-0x00A3CC70
		public override void Exit() {} // 0x00A3CC70-0x00A3CC80
	}

	// Constructors
	private UITextPreview() {} // 0x00A3B4E0-0x00A3C120

	// Methods
	private void SortingLabel() {} // 0x00A3AD70-0x00A3B260
	private string Convert_LtoS(string strL) => default; // 0x00A3B260-0x00A3B340
	private string Convert_StoL(string strS) => default; // 0x00A3B350-0x00A3B4E0
	public static UITextPreview Create() => default; // 0x00A3C120-0x00A3C240
	public void DestroyObj() {} // 0x00A3C430-0x00A3C4A0
	public void Construct() {} // 0x00A3C240-0x00A3C430
	// [IteratorStateMachine] // 0x0062DBD0-0x0062DC40
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00A3C5F0-0x00A3C670
	// [IteratorStateMachine] // 0x0062DC40-0x0062DCB0
	public override IEnumerator MainFlow() => default; // 0x00A3C6A0-0x00A3C710
	private void Update() {} // 0x00A3C740-0x00A3C7A0
	private TargetType GetTargetType(string fileName) => default; // 0x00A3C7A0-0x00A3C830
}

