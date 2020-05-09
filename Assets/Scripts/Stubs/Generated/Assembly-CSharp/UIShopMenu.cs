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

public class UIShopMenu : UIManagerBase // TypeDefIndex: 7554
{
	// Fields
	private bool bCancel_; // 0x1C
	private ItemShopListWindow listWindow_; // 0x20
	private ItemDetailWindow detailWindow_; // 0x28
	private ItemCountInfo countWindow_; // 0x30
	private CommonItemBagInfo bagWindow_; // 0x38
	private CommonPokeBagInfo pokeWindow_; // 0x40
	private CommonScreen commonScreen_; // 0x48
	public FiniteStateMachine<UIShopMenu, States> FSM; // 0x50
	private ShopParam shopParam_; // 0x58

	// Nested types
	public class ItemShopListWindow : ItemListWindow // TypeDefIndex: 7555
	{
		// Fields
		private UIShopMenu manager_; // 0x98

		// Constructors
		public ItemShopListWindow() {} // 0x00DFE840-0x00DFE850

		// Methods
		private void _Init(GameObject objRoot, int defaultIndex) {} // 0x00E01600-0x00E01870
		public void Init(GameObject objRoot, UIShopMenu manager) {} // 0x00DFF7C0-0x00DFF7D0
		public void ReList() {} // 0x00DFF4A0-0x00DFF4D0
		protected override bool _doItemSelect(bool decide) => default; // 0x00E01890-0x00E01CC0
		protected override bool _doAllSelect() => default; // 0x00E01DE0-0x00E022F0
		public int GetCursorIndex() => default; // 0x00E00000-0x00E00010
		protected override bool _onYButton() => default; // 0x00E022F0-0x00E02310
	}

	public class ItemCountInfo : UIWindowBase // TypeDefIndex: 7558
	{
		// Constructors
		public ItemCountInfo() {} // 0x00DFE850-0x00DFE860

		// Methods
		public void UpdateFace(IItem item) {} // 0x00DFF950-0x00DFFB40
	}

	public enum States // TypeDefIndex: 7559
	{
		Init = 0,
		Start = 1,
		ListSelect = 2,
		ListDecide = 3,
		ListCancel = 4,
		Finish = 5,
		End = 6
	}

	public class ShopParam // TypeDefIndex: 7560
	{
		// Fields
		private bool bBuy_; // 0x10
		private IItemBag itemBag_; // 0x18
		private IShopMerchantList shopMerchantList_; // 0x20
		private bool bSpecialShop_; // 0x28

		// Properties
		public bool Buy { get => default; set {} } // 0x00DFF480-0x00DFF490 0x00E026A0-0x00E026B0
		public IItemBag ItemBag { get => default; set {} } // 0x00DFF490-0x00DFF4A0 0x00E026B0-0x00E026C0
		public IShopMerchantList ShopMerchantList { get => default; set {} } // 0x00E01880-0x00E01890 0x00E026C0-0x00E026D0
		public bool SpecialShop { get => default; set {} } // 0x00DFF7D0-0x00DFF7E0 0x00E026D0-0x00E026E0
		public int Poke { get => default; } // 0x00E01D80-0x00E01DE0 
		public int BagUseCount { get => default; } // 0x00E01CC0-0x00E01D20 
		public int BagCapacity { get => default; } // 0x00E01D20-0x00E01D80 

		// Constructors
		public ShopParam() {} // 0x00E026E0-0x00E026F0
	}

	public class StateInit : FSMState<UIShopMenu, States> // TypeDefIndex: 7561
	{
		// Properties
		public override States StateID { get => default; } // 0x00E02770-0x00E02780 

		// Constructors
		public StateInit() {} // 0x00DFE860-0x00DFE8B0

		// Methods
		public override void Enter() {} // 0x00E02780-0x00E02790
		public override void Execute() {} // 0x00E02790-0x00E027A0
		public override void Exit() {} // 0x00E027A0-0x00E027B0
	}

	public class StateStart : FSMState<UIShopMenu, States> // TypeDefIndex: 7562
	{
		// Properties
		public override States StateID { get => default; } // 0x00E029A0-0x00E029B0 

		// Constructors
		public StateStart() {} // 0x00DFE8B0-0x00DFE900

		// Methods
		public override void Enter() {} // 0x00E029B0-0x00E029C0
		public override void Execute() {} // 0x00E029C0-0x00E029D0
		public override void Exit() {} // 0x00E029D0-0x00E029E0
	}

	public class StateListSelect : FSMState<UIShopMenu, States> // TypeDefIndex: 7563
	{
		// Properties
		public override States StateID { get => default; } // 0x00E028D0-0x00E028E0 

		// Constructors
		public StateListSelect() {} // 0x00DFE900-0x00DFE950

		// Methods
		public override void Enter() {} // 0x00E028E0-0x00E02920
		public override void Execute() {} // 0x00E02920-0x00E02960
		public override void Exit() {} // 0x00E02960-0x00E029A0
	}

	public class StateListDecide : FSMState<UIShopMenu, States> // TypeDefIndex: 7564
	{
		// Properties
		public override States StateID { get => default; } // 0x00E02840-0x00E02850 

		// Constructors
		public StateListDecide() {} // 0x00DFE950-0x00DFE9A0

		// Methods
		public override void Enter() {} // 0x00E02850-0x00E02860
		public override void Execute() {} // 0x00E02860-0x00E028C0
		public override void Exit() {} // 0x00E028C0-0x00E028D0
	}

	public class StateListCancel : FSMState<UIShopMenu, States> // TypeDefIndex: 7565
	{
		// Properties
		public override States StateID { get => default; } // 0x00E027B0-0x00E027C0 

		// Constructors
		public StateListCancel() {} // 0x00DFE9A0-0x00DFE9F0

		// Methods
		public override void Enter() {} // 0x00E027C0-0x00E027D0
		public override void Execute() {} // 0x00E027D0-0x00E02830
		public override void Exit() {} // 0x00E02830-0x00E02840
	}

	public class StateFinish : FSMState<UIShopMenu, States> // TypeDefIndex: 7566
	{
		// Properties
		public override States StateID { get => default; } // 0x00E02730-0x00E02740 

		// Constructors
		public StateFinish() {} // 0x00DFE9F0-0x00DFEA40

		// Methods
		public override void Enter() {} // 0x00E02740-0x00E02750
		public override void Execute() {} // 0x00E02750-0x00E02760
		public override void Exit() {} // 0x00E02760-0x00E02770
	}

	public class StateEnd : FSMState<UIShopMenu, States> // TypeDefIndex: 7567
	{
		// Properties
		public override States StateID { get => default; } // 0x00E026F0-0x00E02700 

		// Constructors
		public StateEnd() {} // 0x00DFEA40-0x00DFEA90

		// Methods
		public override void Enter() {} // 0x00E02700-0x00E02710
		public override void Execute() {} // 0x00E02710-0x00E02720
		public override void Exit() {} // 0x00E02720-0x00E02730
	}

	// Constructors
	public UIShopMenu() {} // 0x00E004D0-0x00E004E0

	// Methods
	private void Start() {} // 0x00DFE300-0x00DFE310
	private void Update() {} // 0x00DFE310-0x00DFE360
	public static UIShopMenu Create() => default; // 0x00DFE360-0x00DFE460
	public void Construct() {} // 0x00DFE460-0x00DFE840
	public void Destruct() {} // 0x00DFEA90-0x00DFEB10
	public static TextIDHash GetItemUseButtonGuide() => default; // 0x00DFEB10-0x00DFEB40
	// [IteratorStateMachine] // 0x0062D570-0x0062D5E0
	public IEnumerator ShowPokemonList(List<IPokemonStatus> statusList, List<IPokemonStatus> ignoreList) => default; // 0x00DFEB40-0x00DFEBC0
	private void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00DFEBF0-0x00DFF1F0
	public void Init(ShopParam shopParam) {} // 0x00DFF4D0-0x00DFF7C0
	// [IteratorStateMachine] // 0x0062D5E0-0x0062D650
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00DFF7E0-0x00DFF860
	// [IteratorStateMachine] // 0x0062D650-0x0062D6C0
	public override IEnumerator MainFlow() => default; // 0x00DFF890-0x00DFF900
	public void Continue() {} // 0x00DFF930-0x00DFF940
	public void Continue(int selectorId) {} // 0x00DFF940-0x00DFF950
	private void _updateDetail() {} // 0x00DFF300-0x00DFF480
	protected void _updateButtonGuide(IItem item) {} // 0x00DFFB40-0x00DFFC00
	protected UICommonItemSelectItem _getFocusItem() => default; // 0x00DFF250-0x00DFF300
	public void UpdateBagWindow(int modify) {} // 0x00DFF220-0x00DFF250
	public void OverBagWindow() {} // 0x00DFFC00-0x00DFFCF0
	public void UpdatePokeWindow(int modify) {} // 0x00DFF1F0-0x00DFF220
	public void OverPokeWindow() {} // 0x00DFFCF0-0x00DFFDE0
	public void GetSelectItem(List<IItem> itemData) {} // 0x00DFFDE0-0x00DFFFF0
	public int GetCursorIndex() => default; // 0x00DFFFF0-0x00E00000
	// [IteratorStateMachine] // 0x0062D6C0-0x0062D730
	public override IEnumerator OpenWindow(Action cb) => default; // 0x00E00010-0x00E00090
	// [IteratorStateMachine] // 0x0062D730-0x0062D7A0
	public override IEnumerator CloseWindow(Action cb) => default; // 0x00E000C0-0x00E00140
	// [IteratorStateMachine] // 0x0062D7A0-0x0062D810
	public IEnumerator OpenWindowAndPopupHint(Action cb) => default; // 0x00E00170-0x00E001F0
	public void DoOpenEnter() {} // 0x00E00220-0x00E00330
	public void DoOpen() {} // 0x00E00330-0x00E00340
	public void DoExecuteEnter() {} // 0x00E00340-0x00E00380
	public void DoExecute() {} // 0x00E00380-0x00E003C0
	public void DoExecuteExit() {} // 0x00E003C0-0x00E00400
	public void DoCloseEnter() {} // 0x00E00400-0x00E004D0
}

