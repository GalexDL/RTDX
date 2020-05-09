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

public class UIDateDebug : UIManagerBase // TypeDefIndex: 6717
{
	// Fields
	private CommonScreenBank commonScreenBank_; // 0x20
	private CommonScreen commonScreen_; // 0x28
	private bool bDeposit; // 0x30
	private int depositMoney_; // 0x34
	private bool bSort_; // 0x38
	private bool bCancel_; // 0x39
	public FiniteStateMachine<UIDateDebug, States> FSM; // 0x40
	private int maxCount_; // 0x48
	private int defaultCount_; // 0x4C
	protected FlowPlay flowInstance_; // 0x50
	private MoneySelectWindow moneySelectWindow_; // 0x58
	private ItemBagMoneyWindow itemBagMoneyWindow_; // 0x60
	private BankMoneyWindow bankMoneyWindow_; // 0x68
	private int nAnimCount_; // 0x70
	private ViewState viewState_; // 0x74

	// Properties
	public bool Deposit { get => default; set {} } // 0x009783B0-0x009783C0 0x009783C0-0x009783D0
	public int DepositMoney { get => default; } // 0x009783D0-0x009783E0 
	public bool Sort { get => default; set {} } // 0x009783E0-0x009783F0 0x009783F0-0x00978400
	public bool Cancel { get => default; } // 0x00978E60-0x00978E70 

	// Nested types
	private class CommonScreenBank : CommonScreen // TypeDefIndex: 6718
	{
		// Constructors
		public CommonScreenBank() {} // 0x00979FC0-0x0097A030

		// Methods
		public void SetItemWindowCaption(int nCaption) {} // 0x00979E70-0x00979FC0
	}

	public enum States // TypeDefIndex: 6719
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

	private class MoneySelectWindow : BasicNumberSelectWindow // TypeDefIndex: 6720
	{
		// Fields
		private Transform transform_; // 0x70
		private GameObject obj; // 0x78

		// Constructors
		public MoneySelectWindow() {} // 0x009787A0-0x009787B0

		// Methods
		public void Init(Transform transform, int maxCount, int defaltCount, Kind kindIndex = Kind.NONE /* Metadata: 0x00612FF4 */) {} // 0x0097A030-0x0097A180
		public void Uninit() {} // 0x0097A180-0x0097A230
		public override void InitObjRoot(GameObject objRoot, int digit, int maxCount, Kind kindIndex) {} // 0x0097A230-0x0097A530
		protected override void _update() {} // 0x0097A530-0x0097A540
		protected override void _doInput() {} // 0x0097A540-0x0097A650
		protected override bool _doUp() => default; // 0x0097A6B0-0x0097A7A0
		protected override bool _doDown() => default; // 0x0097A7A0-0x0097A890
		private new bool _doSelectCountMax() => default; // 0x0097A650-0x0097A690
		private new bool _doSelectCountMin() => default; // 0x0097A690-0x0097A6B0
		public int _GetSelectCount() => default; // 0x00978C40-0x00978C50
	}

	private class ItemBagMoneyWindow : InfoWindowBase // TypeDefIndex: 6721
	{
		// Fields
		private UIDateDebug manager_; // 0x30
		private GameObject root_; // 0x38
		private GameObject pokeWindow; // 0x40
		private GameObject pokeWindowMyMoney; // 0x48
		private GameObject pokeWindowPayment; // 0x50

		// Constructors
		public ItemBagMoneyWindow() {} // 0x009787B0-0x009787C0

		// Methods
		public void Init(GameObject root, UIDateDebug manager) {} // 0x00978970-0x00978B40
	}

	private class BankMoneyWindow : InfoWindowBase // TypeDefIndex: 6722
	{
		// Fields
		private UIDateDebug manager_; // 0x30
		private GameObject root_; // 0x38

		// Constructors
		public BankMoneyWindow() {} // 0x009787C0-0x009787D0

		// Methods
		public void Init(GameObject root, UIDateDebug manager) {} // 0x00978B40-0x00978C30
		public override void UpdateInfoWindow(int modify) {} // 0x00979CC0-0x00979E70
	}

	public enum ViewState // TypeDefIndex: 6723
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIDateDebug, States> // TypeDefIndex: 6724
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E710-0x00B0E720 

		// Constructors
		public StateInit() {} // 0x00B0E750-0x00B0E7A0

		// Methods
		public override void Enter() {} // 0x00B0E720-0x00B0E730
		public override void Execute() {} // 0x00B0E730-0x00B0E740
		public override void Exit() {} // 0x00B0E740-0x00B0E750
	}

	public class StateStart : FSMState<UIDateDebug, States> // TypeDefIndex: 6725
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0EC80-0x00B0EC90 

		// Constructors
		public StateStart() {} // 0x00B0ED10-0x00B0ED60

		// Methods
		public override void Enter() {} // 0x00B0EC90-0x00B0ECF0
		public override void Execute() {} // 0x00B0ECF0-0x00B0ED00
		public override void Exit() {} // 0x00B0ED00-0x00B0ED10
	}

	public class StateFinish : FSMState<UIDateDebug, States> // TypeDefIndex: 6726
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E680-0x00B0E690 

		// Constructors
		public StateFinish() {} // 0x00B0E6C0-0x00B0E710

		// Methods
		public override void Enter() {} // 0x00B0E690-0x00B0E6A0
		public override void Execute() {} // 0x00B0E6A0-0x00B0E6B0
		public override void Exit() {} // 0x00B0E6B0-0x00B0E6C0
	}

	public class StateEnd : FSMState<UIDateDebug, States> // TypeDefIndex: 6727
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E5F0-0x00B0E600 

		// Constructors
		public StateEnd() {} // 0x00B0E630-0x00B0E680

		// Methods
		public override void Enter() {} // 0x00B0E600-0x00B0E610
		public override void Execute() {} // 0x00B0E610-0x00B0E620
		public override void Exit() {} // 0x00B0E620-0x00B0E630
	}

	public class StateNumberSelectStart : FSMState<UIDateDebug, States> // TypeDefIndex: 6728
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0EAA0-0x00B0EAB0 

		// Constructors
		public StateNumberSelectStart() {} // 0x00B0EBA0-0x00B0EBF0

		// Methods
		public override void Enter() {} // 0x00B0EAB0-0x00B0EB80
		public override void Execute() {} // 0x00B0EB80-0x00B0EB90
		public override void Exit() {} // 0x00B0EB90-0x00B0EBA0
	}

	public class StateSelectEnd : FSMState<UIDateDebug, States> // TypeDefIndex: 6729
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0EBF0-0x00B0EC00 

		// Constructors
		public StateSelectEnd() {} // 0x00B0EC30-0x00B0EC80

		// Methods
		public override void Enter() {} // 0x00B0EC00-0x00B0EC10
		public override void Execute() {} // 0x00B0EC10-0x00B0EC20
		public override void Exit() {} // 0x00B0EC20-0x00B0EC30
	}

	public class StateNumberSelect : FSMState<UIDateDebug, States> // TypeDefIndex: 6730
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E960-0x00B0E970 

		// Constructors
		public StateNumberSelect() {} // 0x00B0EA50-0x00B0EAA0

		// Methods
		public override void Enter() {} // 0x00B0E970-0x00B0E9D0
		public override void Execute() {} // 0x00B0E9D0-0x00B0E9F0
		public override void Exit() {} // 0x00B0E9F0-0x00B0EA50
	}

	public class StateNumberDecide : FSMState<UIDateDebug, States> // TypeDefIndex: 6731
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E880-0x00B0E890 

		// Constructors
		public StateNumberDecide() {} // 0x00B0E910-0x00B0E960

		// Methods
		public override void Enter() {} // 0x00B0E890-0x00B0E8A0
		public override void Execute() {} // 0x00B0E8A0-0x00B0E900
		public override void Exit() {} // 0x00B0E900-0x00B0E910
	}

	public class StateNumberCancel : FSMState<UIDateDebug, States> // TypeDefIndex: 6732
	{
		// Properties
		public override States StateID { get => default; } // 0x00B0E7A0-0x00B0E7B0 

		// Constructors
		public StateNumberCancel() {} // 0x00B0E830-0x00B0E880

		// Methods
		public override void Enter() {} // 0x00B0E7B0-0x00B0E7C0
		public override void Execute() {} // 0x00B0E7C0-0x00B0E820
		public override void Exit() {} // 0x00B0E820-0x00B0E830
	}

	// Constructors
	public UIDateDebug() {} // 0x009792D0-0x009792E0

	// Methods
	public static UIDateDebug Create() => default; // 0x00978400-0x00978520
	public void Construct() {} // 0x00978520-0x009787A0
	public void Init(FlowPlay instance, int defaultCount, int maxCount = 99999 /* Metadata: 0x00612FCC */) {} // 0x009787D0-0x00978970
	public int GetSelectCount() => default; // 0x00978C30-0x00978C40
	public void SetSelectCount(int value) {} // 0x00978C50-0x00978C60
	// [IteratorStateMachine] // 0x00627FA0-0x00628010
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00978C60-0x00978CE0
	// [IteratorStateMachine] // 0x00628010-0x00628080
	public IEnumerator MainFlow(Action<int> count) => default; // 0x00978D10-0x00978D90
	// [IteratorStateMachine] // 0x00628080-0x006280F0
	public override IEnumerator MainFlow() => default; // 0x00978DC0-0x00978E30
	public void Continue() {} // 0x00978E70-0x00978E80
	private void Update() {} // 0x00978E80-0x00978EE0
	public void DoOpenEnter() {} // 0x00978EE0-0x00978F70
	public void DoOpenEnterSelect() {} // 0x00978F70-0x00979000
	public void DoCloseEnter() {} // 0x00979000-0x00979090
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00979090-0x009790C0
	private void _cbFromNumberSelectWindow(NumberSelectWindowBase.ActionType act) {} // 0x009790C0-0x00979170
	// [IteratorStateMachine] // 0x006280F0-0x00628160
	public override IEnumerator OpenWindow(Action cb) => default; // 0x00979170-0x009791F0
	// [IteratorStateMachine] // 0x00628160-0x006281D0
	public override IEnumerator CloseWindow(Action cb) => default; // 0x00979220-0x009792A0
}

