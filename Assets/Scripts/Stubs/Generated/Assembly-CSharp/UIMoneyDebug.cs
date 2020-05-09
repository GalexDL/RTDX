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

public class UIMoneyDebug : UIManagerBase // TypeDefIndex: 7107
{
	// Fields
	private CommonScreenBank commonScreenBank_; // 0x20
	private CommonScreen commonScreen_; // 0x28
	private bool bDeposit; // 0x30
	private int depositMoney_; // 0x34
	private bool bSort_; // 0x38
	private bool bCancel_; // 0x39
	public FiniteStateMachine<UIMoneyDebug, States> FSM; // 0x40
	private int maxCount_; // 0x48
	protected FlowPlay flowInstance_; // 0x50
	private MoneySelectWindow moneySelectWindow_; // 0x58
	private ItemBagMoneyWindow itemBagMoneyWindow_; // 0x60
	private BankMoneyWindow bankMoneyWindow_; // 0x68
	private int nAnimCount_; // 0x70
	private ViewState viewState_; // 0x74

	// Properties
	public bool Deposit { get => default; set {} } // 0x009558C0-0x009558D0 0x009558D0-0x009558E0
	public int DepositMoney { get => default; } // 0x009558E0-0x009558F0 
	public bool Sort { get => default; set {} } // 0x009558F0-0x00955900 0x00955900-0x00955910
	public bool Cancel { get => default; } // 0x00956710-0x00956720 

	// Nested types
	private class CommonScreenBank : CommonScreen // TypeDefIndex: 7108
	{
		// Constructors
		public CommonScreenBank() {} // 0x00957880-0x009578F0

		// Methods
		public void SetItemWindowCaption(int nCaption) {} // 0x00957720-0x00957880
	}

	public enum States // TypeDefIndex: 7109
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

	private class MoneySelectWindow : BasicNumberSelectWindow // TypeDefIndex: 7110
	{
		// Fields
		private Transform transform_; // 0x70
		private GameObject obj; // 0x78

		// Constructors
		public MoneySelectWindow() {} // 0x00955DE0-0x00955DF0

		// Methods
		public void Init(Transform transform, int maxCount, Kind kindIndex = Kind.NONE /* Metadata: 0x0061340F */) {} // 0x009578F0-0x00957A20
		public void Uninit() {} // 0x00957A20-0x00957AD0
		public override void InitObjRoot(GameObject objRoot, int digit, int maxCount, Kind kindIndex) {} // 0x00957AD0-0x00957DE0
		protected override void _update() {} // 0x00957DE0-0x00957DF0
		protected override void _doInput() {} // 0x00957DF0-0x00957F00
		protected override bool _doUp() => default; // 0x00957F60-0x00958050
		protected override bool _doDown() => default; // 0x00958050-0x00958140
		private new bool _doSelectCountMax() => default; // 0x00957F00-0x00957F40
		private new bool _doSelectCountMin() => default; // 0x00957F40-0x00957F60
		public int _GetSelectCount() => default; // 0x00956500-0x00956510
	}

	private class ItemBagMoneyWindow : InfoWindowBase // TypeDefIndex: 7111
	{
		// Fields
		private UIMoneyDebug manager_; // 0x30
		private GameObject root_; // 0x38
		private GameObject pokeWindow; // 0x40
		private GameObject pokeWindowMyMoney; // 0x48
		private GameObject pokeWindowPayment; // 0x50

		// Constructors
		public ItemBagMoneyWindow() {} // 0x00955DF0-0x00955E00

		// Methods
		public void Init(GameObject root, UIMoneyDebug manager) {} // 0x00956230-0x00956400
	}

	private class BankMoneyWindow : InfoWindowBase // TypeDefIndex: 7112
	{
		// Fields
		private UIMoneyDebug manager_; // 0x30
		private GameObject root_; // 0x38

		// Constructors
		public BankMoneyWindow() {} // 0x00955E00-0x00955E10

		// Methods
		public void Init(GameObject root, UIMoneyDebug manager) {} // 0x00956400-0x009564F0
		public override void UpdateInfoWindow(int modify) {} // 0x00957570-0x00957720
	}

	public enum ViewState // TypeDefIndex: 7113
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7114
	{
		// Properties
		public override States StateID { get => default; } // 0x00958240-0x00958250 

		// Constructors
		public StateInit() {} // 0x00955E10-0x00955E60

		// Methods
		public override void Enter() {} // 0x00958250-0x00958260
		public override void Execute() {} // 0x00958260-0x00958270
		public override void Exit() {} // 0x00958270-0x00958280
	}

	public class StateStart : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7115
	{
		// Properties
		public override States StateID { get => default; } // 0x009586F0-0x00958700 

		// Constructors
		public StateStart() {} // 0x00955E60-0x00955EB0

		// Methods
		public override void Enter() {} // 0x00958700-0x00958760
		public override void Execute() {} // 0x00958760-0x00958770
		public override void Exit() {} // 0x00958770-0x00958780
	}

	public class StateFinish : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7116
	{
		// Properties
		public override States StateID { get => default; } // 0x00958180-0x00958190 

		// Constructors
		public StateFinish() {} // 0x00955EB0-0x00955F00

		// Methods
		public override void Enter() {} // 0x00958190-0x00958220
		public override void Execute() {} // 0x00958220-0x00958230
		public override void Exit() {} // 0x00958230-0x00958240
	}

	public class StateEnd : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7117
	{
		// Properties
		public override States StateID { get => default; } // 0x00958140-0x00958150 

		// Constructors
		public StateEnd() {} // 0x00955F00-0x00955F50

		// Methods
		public override void Enter() {} // 0x00958150-0x00958160
		public override void Execute() {} // 0x00958160-0x00958170
		public override void Exit() {} // 0x00958170-0x00958180
	}

	public class StateNumberSelectStart : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7118
	{
		// Properties
		public override States StateID { get => default; } // 0x00958490-0x009584A0 

		// Constructors
		public StateNumberSelectStart() {} // 0x00956040-0x00956090

		// Methods
		public override void Enter() {} // 0x009584A0-0x00958640
		public override void Execute() {} // 0x00958640-0x00958650
		public override void Exit() {} // 0x00958650-0x00958660
	}

	public class StateSelectEnd : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7119
	{
		// Properties
		public override States StateID { get => default; } // 0x00958660-0x00958670 

		// Constructors
		public StateSelectEnd() {} // 0x009586A0-0x009586F0

		// Methods
		public override void Enter() {} // 0x00958670-0x00958680
		public override void Execute() {} // 0x00958680-0x00958690
		public override void Exit() {} // 0x00958690-0x009586A0
	}

	public class StateNumberSelect : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7120
	{
		// Properties
		public override States StateID { get => default; } // 0x009583A0-0x009583B0 

		// Constructors
		public StateNumberSelect() {} // 0x00955F50-0x00955FA0

		// Methods
		public override void Enter() {} // 0x009583B0-0x00958410
		public override void Execute() {} // 0x00958410-0x00958430
		public override void Exit() {} // 0x00958430-0x00958490
	}

	public class StateNumberDecide : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7121
	{
		// Properties
		public override States StateID { get => default; } // 0x00958310-0x00958320 

		// Constructors
		public StateNumberDecide() {} // 0x00955FA0-0x00955FF0

		// Methods
		public override void Enter() {} // 0x00958320-0x00958330
		public override void Execute() {} // 0x00958330-0x00958390
		public override void Exit() {} // 0x00958390-0x009583A0
	}

	public class StateNumberCancel : FSMState<UIMoneyDebug, States> // TypeDefIndex: 7122
	{
		// Properties
		public override States StateID { get => default; } // 0x00958280-0x00958290 

		// Constructors
		public StateNumberCancel() {} // 0x00955FF0-0x00956040

		// Methods
		public override void Enter() {} // 0x00958290-0x009582A0
		public override void Execute() {} // 0x009582A0-0x00958300
		public override void Exit() {} // 0x00958300-0x00958310
	}

	// Constructors
	public UIMoneyDebug() {} // 0x00956B80-0x00956B90

	// Methods
	public static UIMoneyDebug Create() => default; // 0x00955910-0x00955A10
	public void Construct() {} // 0x00955A10-0x00955DE0
	public void Init(FlowPlay instance, int maxCount = 99999 /* Metadata: 0x006133E7 */) {} // 0x00956090-0x00956230
	public int GetSelectCount() => default; // 0x009564F0-0x00956500
	// [IteratorStateMachine] // 0x0062A170-0x0062A1E0
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00956510-0x00956590
	// [IteratorStateMachine] // 0x0062A1E0-0x0062A250
	public IEnumerator MainFlow(Action<int> count) => default; // 0x009565C0-0x00956640
	// [IteratorStateMachine] // 0x0062A250-0x0062A2C0
	public override IEnumerator MainFlow() => default; // 0x00956670-0x009566E0
	public void Continue() {} // 0x00956720-0x00956730
	private void Update() {} // 0x00956730-0x00956790
	public void DoOpenEnter() {} // 0x00956790-0x00956820
	public void DoOpenEnterSelect() {} // 0x00956820-0x009568B0
	public void DoCloseEnter() {} // 0x009568B0-0x00956940
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00956940-0x00956970
	private void _cbFromNumberSelectWindow(NumberSelectWindowBase.ActionType act) {} // 0x00956970-0x00956A20
	// [IteratorStateMachine] // 0x0062A2C0-0x0062A330
	public override IEnumerator OpenWindow(Action cb) => default; // 0x00956A20-0x00956AA0
	// [IteratorStateMachine] // 0x0062A330-0x0062A3A0
	public override IEnumerator CloseWindow(Action cb) => default; // 0x00956AD0-0x00956B50
}

