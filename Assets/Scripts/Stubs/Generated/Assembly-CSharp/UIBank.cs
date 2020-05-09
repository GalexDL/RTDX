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

public class UIBank : UIManagerBase // TypeDefIndex: 6438
{
	// Fields
	private CommonScreen commonScreen; // 0x20
	private FlowPlay flowInstance_; // 0x28
	private bool bDeposit; // 0x30
	private int depositMoney_; // 0x34
	private bool bSort_; // 0x38
	private bool bCancel_; // 0x39
	public FiniteStateMachine<UIBank, States> FSM; // 0x40
	private MoneySelectWindow moneySelectWindow_; // 0x48
	private CommonPokeBagInfo commonPokeBagInfo_; // 0x50
	private CommonPokeBankInfo commonPokeBankInfo_; // 0x58
	private int nAnimCount_; // 0x60
	private ViewState viewState_; // 0x64

	// Properties
	public CommonScreen common { get => default; } // 0x007E3020-0x007E3030 
	public bool Deposit { get => default; set {} } // 0x007E3030-0x007E3040 0x007E3040-0x007E3050
	public int DepositMoney { get => default; } // 0x007E3050-0x007E3060 
	public bool Sort { get => default; set {} } // 0x007E3060-0x007E3070 0x007E3070-0x007E3080

	// Nested types
	public enum States // TypeDefIndex: 6439
	{
		Init = 0,
		Start = 1,
		Finish = 2,
		End = 3,
		NumberSelectStart = 4,
		NumberSelect = 5,
		NumberDecide = 6,
		NumberCancel = 7,
		NumberSelectEnd = 8
	}

	private class MoneySelectWindow : BasicNumberSelectWindow // TypeDefIndex: 6440
	{
		// Fields
		private Transform transform_; // 0x70
		private GameObject obj; // 0x78

		// Constructors
		public MoneySelectWindow() {} // 0x007E3570-0x007E3580

		// Methods
		public void Init(Transform transform, int maxCount, Kind kindIndex = Kind.NONE /* Metadata: 0x00612D84 */) {} // 0x007E4A40-0x007E4BA0
		public void Uninit() {} // 0x007E4BA0-0x007E4C40
		public override void InitObjRoot(GameObject objRoot, int digit, int maxCount, Kind kindIndex) {} // 0x007E4C40-0x007E5040
		protected override void _update() {} // 0x007E5040-0x007E5050
		protected override bool _doUp() => default; // 0x007E5050-0x007E5140
		protected override bool _doDown() => default; // 0x007E5140-0x007E5230
		protected override bool _doSelectCountMax() => default; // 0x007E5230-0x007E5280
		protected override bool _doSelectCountMin() => default; // 0x007E5280-0x007E52D0
		public int _GetSelectCount() => default; // 0x007E3B30-0x007E3B40
	}

	public enum ViewState // TypeDefIndex: 6441
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIBank, States> // TypeDefIndex: 6442
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5630-0x007E5640 

		// Constructors
		public StateInit() {} // 0x007E3580-0x007E35D0

		// Methods
		public override void Enter() {} // 0x007E5640-0x007E5650
		public override void Execute() {} // 0x007E5650-0x007E5660
		public override void Exit() {} // 0x007E5660-0x007E5670
	}

	public class StateStart : FSMState<UIBank, States> // TypeDefIndex: 6443
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5F00-0x007E5F10 

		// Constructors
		public StateStart() {} // 0x007E35D0-0x007E3620

		// Methods
		public override void Enter() {} // 0x007E5F10-0x007E5F70
		public override void Execute() {} // 0x007E5F70-0x007E5F80
		public override void Exit() {} // 0x007E5F80-0x007E5F90
	}

	public class StateFinish : FSMState<UIBank, States> // TypeDefIndex: 6444
	{
		// Fields
		private int closeCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x007E5310-0x007E5320 

		// Constructors
		public StateFinish() {} // 0x007E3620-0x007E3670

		// Methods
		public override void Enter() {} // 0x007E5320-0x007E5330
		public override void Execute() {} // 0x007E5520-0x007E5590
		public override void Exit() {} // 0x007E5600-0x007E5610
		private void DoCloseEnter() {} // 0x007E5330-0x007E5520
		private void DoCloseExecute() {} // 0x007E5590-0x007E5600
	}

	public class StateEnd : FSMState<UIBank, States> // TypeDefIndex: 6445
	{
		// Properties
		public override States StateID { get => default; } // 0x007E52D0-0x007E52E0 

		// Constructors
		public StateEnd() {} // 0x007E3670-0x007E36C0

		// Methods
		public override void Enter() {} // 0x007E52E0-0x007E52F0
		public override void Execute() {} // 0x007E52F0-0x007E5300
		public override void Exit() {} // 0x007E5300-0x007E5310
	}

	public class StateNumberSelectStart : FSMState<UIBank, States> // TypeDefIndex: 6446
	{
		// Properties
		public override States StateID { get => default; } // 0x007E58C0-0x007E58D0 

		// Constructors
		public StateNumberSelectStart() {} // 0x007E37B0-0x007E3800

		// Methods
		public override void Enter() {} // 0x007E58D0-0x007E5CD0
		public override void Execute() {} // 0x007E5CD0-0x007E5CE0
		public override void Exit() {} // 0x007E5CE0-0x007E5CF0
	}

	public class StateSelectEnd : FSMState<UIBank, States> // TypeDefIndex: 6448
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5E70-0x007E5E80 

		// Constructors
		public StateSelectEnd() {} // 0x007E5EB0-0x007E5F00

		// Methods
		public override void Enter() {} // 0x007E5E80-0x007E5E90
		public override void Execute() {} // 0x007E5E90-0x007E5EA0
		public override void Exit() {} // 0x007E5EA0-0x007E5EB0
	}

	public class StateNumberSelect : FSMState<UIBank, States> // TypeDefIndex: 6449
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5790-0x007E57A0 

		// Constructors
		public StateNumberSelect() {} // 0x007E36C0-0x007E3710

		// Methods
		public override void Enter() {} // 0x007E57A0-0x007E57F0
		public override void Execute() {} // 0x007E57F0-0x007E5810
		public override void Exit() {} // 0x007E5810-0x007E58C0
	}

	public class StateNumberDecide : FSMState<UIBank, States> // TypeDefIndex: 6450
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5700-0x007E5710 

		// Constructors
		public StateNumberDecide() {} // 0x007E3710-0x007E3760

		// Methods
		public override void Enter() {} // 0x007E5710-0x007E5770
		public override void Execute() {} // 0x007E5770-0x007E5780
		public override void Exit() {} // 0x007E5780-0x007E5790
	}

	public class StateNumberCancel : FSMState<UIBank, States> // TypeDefIndex: 6451
	{
		// Properties
		public override States StateID { get => default; } // 0x007E5670-0x007E5680 

		// Constructors
		public StateNumberCancel() {} // 0x007E3760-0x007E37B0

		// Methods
		public override void Enter() {} // 0x007E5680-0x007E56E0
		public override void Execute() {} // 0x007E56E0-0x007E56F0
		public override void Exit() {} // 0x007E56F0-0x007E5700
	}

	// Constructors
	public UIBank() {} // 0x007E4110-0x007E4120

	// Methods
	public static UIBank Create() => default; // 0x007E3080-0x007E3180
	public void Construct() {} // 0x007E3180-0x007E3570
	public void Init(FlowPlay instance) {} // 0x007E3800-0x007E3B20
	public int GetSelectCount() => default; // 0x007E3B20-0x007E3B30
	// [IteratorStateMachine] // 0x00626A10-0x00626A80
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x007E3B40-0x007E3BC0
	// [IteratorStateMachine] // 0x00626A80-0x00626AF0
	public IEnumerator MainFlow(Action<int> count) => default; // 0x007E3BF0-0x007E3C70
	// [IteratorStateMachine] // 0x00626AF0-0x00626B60
	public override IEnumerator MainFlow() => default; // 0x007E3CA0-0x007E3D10
	public void Continue() {} // 0x007E3D40-0x007E3D50
	private void Update() {} // 0x007E3D50-0x007E3DB0
	public void DoOpenEnterSelect() {} // 0x007E3DB0-0x007E3E40
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x007E3E40-0x007E3E70
	private void _cbFromNumberSelectWindow(NumberSelectWindowBase.ActionType act) {} // 0x007E3E70-0x007E3FB0
	// [IteratorStateMachine] // 0x00626B60-0x00626BD0
	public override IEnumerator OpenWindow(Action cb) => default; // 0x007E3FB0-0x007E4030
	// [IteratorStateMachine] // 0x00626BD0-0x00626C40
	public override IEnumerator CloseWindow(Action cb) => default; // 0x007E4060-0x007E40E0
}

