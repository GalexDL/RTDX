/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWarehouse : UIManagerBase // TypeDefIndex: 7691
{
	// Fields
	private CommonScreen commonScreen_; // 0x20
	private int warehouseUseCount_; // 0x28
	private bool bSort_; // 0x2C
	private bool bCancel_; // 0x2D
	private DrawListWindow drawListWindow_; // 0x30
	public DepositListWindow depositListWindow_; // 0x38
	private ItemDetailWindow detailWindow_; // 0x40
	private CommonItemBagInfo commonItemBagInfo_; // 0x48
	private CommonItemWarehouseInfo commonItemWarehouseInfo_; // 0x50
	private CommonItemWarehouseDepositInfo commonItemWarehouseDepositInfo_; // 0x58
	private NumberSelectWindow numberSelectWindow_; // 0x60
	public FiniteStateMachine<UIWarehouse, States> FSM; // 0x68
	private bool image_; // 0x70
	private HashSet<Index> wazaMachineIndices_; // 0x78
	public bool bDeposit_; // 0x80
	private FlowPlay flowInstance; // 0x88
	private ViewState viewState_; // 0x90
	private int nAnimCount_; // 0x94
	private int openCount_; // 0x98
	private int closeCount_; // 0x9C
	private ItemLabelKind[] aItemLabelKind; // 0xA0

	// Properties
	public int WarehouseUseCount { get => default; } // 0x00A4FA30-0x00A4FA40 
	public bool Sort { get => default; set {} } // 0x00A4FA40-0x00A4FA50 0x00A4FA50-0x00A4FA60
	public DrawListWindow DrawListWindow_ { get => default; } // 0x00A4FA60-0x00A4FA70 
	public bool Image { get => default; } // 0x00A4FD30-0x00A4FD40 

	// Nested types
	private class CommonScreenWarehouse : CommonScreen // TypeDefIndex: 7692
	{
		// Constructors
		public CommonScreenWarehouse() {} // 0x00A57250-0x00A572C0

		// Methods
		public void SetItemWindowCaption(int nCaption) {} // 0x00A57090-0x00A57250
	}

	public class WarehouseListItem // TypeDefIndex: 7693
	{
		// Fields
		public int id; // 0x10
		public Index itemIndex; // 0x14
		public IItem item; // 0x18

		// Constructors
		public WarehouseListItem() {} // 0x00DBEF10-0x00DBEF20
	}

	public class UILocalSelectItem_Warehouse : UISelectItem // TypeDefIndex: 7694
	{
		// Fields
		private WarehouseListItem item_; // 0x18
		public bool bEquipped; // 0x20
		public int equippedNum; // 0x24
		public bool canWazaMachine; // 0x28

		// Properties
		public WarehouseListItem Item { get => default; set {} } // 0x00DBE4B0-0x00DBE4C0 0x00DBE4A0-0x00DBE4B0

		// Constructors
		public UILocalSelectItem_Warehouse() {} // 0x00DBE490-0x00DBE4A0

		// Methods
		public override int GetSortKey(int mode) => default; // 0x00DC1E50-0x00DC1F10
	}

	private class UILocalSelector : UISelectorWarehouse // TypeDefIndex: 7695
	{
		// Fields
		public bool bDeposit; // 0x29

		// Constructors
		public UILocalSelector() {} // 0x00DBE5A0-0x00DBE610

		// Methods
		protected override void SetupFace() {} // 0x00DC1F10-0x00DC24A0
	}

	public class DrawListWindow : BasicListWindow // TypeDefIndex: 7696
	{
		// Fields
		private UIWarehouse manager_; // 0x88
		private bool bSortByName_; // 0x90
		private Kind refineByKind_; // 0x94
		private GameObject objRoot_; // 0x98
		private Kind topKind_; // 0xA0
		private Index currentFocusItem_; // 0xA4

		// Properties
		public bool SortByName { get => default; set {} } // 0x00DBE670-0x00DBE680 0x00DBE680-0x00DBE690
		public Kind RefineByKind { get => default; set {} } // 0x00DBE690-0x00DBE6A0 0x00DBE6A0-0x00DBE6B0

		// Nested types
		private class NameCompareData // TypeDefIndex: 7697
		{
			// Fields
			public IItem item; // 0x10
			public string sName; // 0x18
			public int secondPrw; // 0x20

			// Constructors
			public NameCompareData() {} // 0x00DBECC0-0x00DBECD0
		}

		// Constructors
		public DrawListWindow() {} // 0x00DC07E0-0x00DC07F0

		// Methods
		private static int NameCompare(NameCompareData a, NameCompareData b) => default; // 0x00DBE620-0x00DBE670
		public void ResetFilter() {} // 0x00DBE6B0-0x00DBE6D0
		private List<WarehouseListItem> _getList() => default; // 0x00DBE6D0-0x00DBECC0
		public List<Kind> GetKindList() => default; // 0x00DBECD0-0x00DBEF10
		public override void Init(GameObject objRoot) {} // 0x00DBEF20-0x00DBF380
		public virtual void Init(GameObject objRoot, UIWarehouse manager) {} // 0x00DBF390-0x00DBF3A0
		public void ReList() {} // 0x00DBF3A0-0x00DBF5E0
		public void DeleteNoBeingWarehosue() {} // 0x00DBF5E0-0x00DBF7F0
		private void SetEnable(Kind kind) {} // 0x00DBF7F0-0x00DBFA20
		private void SetEnable_NotNormal() {} // 0x00DBFA20-0x00DBFC80
		private void ResetEnable() {} // 0x00DBFC80-0x00DBFE30
		public void ResetSelect() {} // 0x00DBFE30-0x00DBFFD0
		protected override bool _doItemSelect(bool decide) => default; // 0x00DBFFD0-0x00DC0450
		protected override bool _onYButton() => default; // 0x00DC0450-0x00DC0510
		protected override bool _doAllSelect() => default; // 0x00DC05C0-0x00DC05D0
		protected override void _doInput() {} // 0x00DC05D0-0x00DC0670
		protected override bool _onXButton() => default; // 0x00DC0670-0x00DC0690
		public void ResetCurrentFocusItem() {} // 0x00DC0690-0x00DC06A0
		private void getFocusItem() {} // 0x00DC0510-0x00DC05C0
		protected override bool _doDecide() => default; // 0x00DC06A0-0x00DC07E0
	}

	public class DepositListWindow : ItemListWindow // TypeDefIndex: 7699
	{
		// Fields
		private UIWarehouse manager_; // 0x98
		private Dictionary<Index, IndexPart> indexPartCount; // 0xA0

		// Properties
		public Dictionary<Index, IndexPart> IndexPartCount { get => default; } // 0x00A4FBB0-0x00A4FBC0 

		// Nested types
		public class IndexPart // TypeDefIndex: 7700
		{
			// Fields
			public int count; // 0x10
			public bool max; // 0x14

			// Constructors
			public IndexPart() {} // 0x00DBE610-0x00DBE620
		}

		// Constructors
		public DepositListWindow() {} // 0x00A502B0-0x00A50320

		// Methods
		private List<WarehouseListItem> _getList() => default; // 0x00A572C0-0x00A574D0
		public void FaceReUpdate() {} // 0x00A528E0-0x00A52D80
		public void Init(GameObject objRoot, UIWarehouse manager, int defaultIndex = 0 /* Metadata: 0x00613975 */) {} // 0x00A51200-0x00A51880
		private void indexPartCountUp(Dictionary<Index, IndexPart> dictionary, Index index, IndexPart value) {} // 0x00A574D0-0x00A575D0
		public IndexPart GetIndexPartCount(Index index) => default; // 0x00A575D0-0x00A57680
		protected override bool _doItemSelect(bool decide) => default; // 0x00A57680-0x00A582D0
		private bool SelectNumberSet(Index index, int value, int zaiko) => default; // 0x00A582D0-0x00A583F0
		private bool SelectNumberReset(Index index, int zaiko) => default; // 0x00A583F0-0x00A584D0
		protected override bool _doAllSelect() => default; // 0x00A584D0-0x00A58E60
		private bool IsAllMax() => default; // 0x00A58E60-0x00A58FB0
		public void ResetSelect() {} // 0x00A58FB0-0x00A59150
		protected override bool _onYButton() => default; // 0x00A59150-0x00A59310
		protected override bool _doDecide() => default; // 0x00A59310-0x00A593D0
	}

	private class WarehouseWindow : InfoWindowBase // TypeDefIndex: 7702
	{
		// Fields
		private UIWarehouse manager_; // 0x30
		private GameObject root_; // 0x38
		private int stockCount_; // 0x40
		private int nowCount; // 0x44

		// Properties
		public int StockCount { get => default; set {} } // 0x00DC2580-0x00DC2590 0x00DC2590-0x00DC25A0
		public int NowCount { get => default; } // 0x00DC25A0-0x00DC25B0 

		// Constructors
		public WarehouseWindow() {} // 0x00DC2C20-0x00DC2C30

		// Methods
		public void Init(GameObject root, UIWarehouse manager) {} // 0x00DC24A0-0x00DC2580
		public override void UpdateInfoWindow(int modify) {} // 0x00DC25B0-0x00DC2C10
		public void UpdateCount(int value) {} // 0x00DC2C10-0x00DC2C20
	}

	private class NumberSelectWindow : BasicNumberSelectWindow // TypeDefIndex: 7703
	{
		// Fields
		private Transform transform_; // 0x70
		private GameObject obj; // 0x78

		// Constructors
		public NumberSelectWindow() {} // 0x00DC0EE0-0x00DC0EF0

		// Methods
		public void Init(Transform transform, int maxCount, Kind kindIndex = Kind.NONE /* Metadata: 0x00613979 */) {} // 0x00DC0A20-0x00DC0B70
		public void Uninit() {} // 0x00DC0B70-0x00DC0C30
		protected override bool _doUp() => default; // 0x00DC0C30-0x00DC0D20
		protected override bool _doDown() => default; // 0x00DC0D20-0x00DC0E10
		protected override bool _doSelectCountMax() => default; // 0x00DC0E10-0x00DC0E60
		protected override bool _doSelectCountMin() => default; // 0x00DC0E60-0x00DC0EB0
		protected override bool _doCancel() => default; // 0x00DC0EB0-0x00DC0EE0
	}

	public enum States // TypeDefIndex: 7704
	{
		Init = 0,
		Start = 1,
		ListSelect = 2,
		ListDecide = 3,
		ListCancel = 4,
		Finish = 5,
		End = 6,
		NumberSelectStart = 7,
		NumberSelect = 8,
		NumberDecide = 9,
		NumberCancel = 10,
		NumberSelectEnd = 11
	}

	private enum SetType // TypeDefIndex: 7705
	{
		ITEMBAG = 0,
		WAREHOUSE = 1
	}

	public enum ViewState // TypeDefIndex: 7706
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIWarehouse, States> // TypeDefIndex: 7707
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1010-0x00DC1020 

		// Constructors
		public StateInit() {} // 0x00DC1050-0x00DC10A0

		// Methods
		public override void Enter() {} // 0x00DC1020-0x00DC1030
		public override void Execute() {} // 0x00DC1030-0x00DC1040
		public override void Exit() {} // 0x00DC1040-0x00DC1050
	}

	public class StateStart : FSMState<UIWarehouse, States> // TypeDefIndex: 7708
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1DC0-0x00DC1DD0 

		// Constructors
		public StateStart() {} // 0x00DC1E00-0x00DC1E50

		// Methods
		public override void Enter() {} // 0x00DC1DD0-0x00DC1DE0
		public override void Execute() {} // 0x00DC1DE0-0x00DC1DF0
		public override void Exit() {} // 0x00DC1DF0-0x00DC1E00
	}

	public class StateListSelect : FSMState<UIWarehouse, States> // TypeDefIndex: 7709
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1270-0x00DC1280 

		// Constructors
		public StateListSelect() {} // 0x00DC15A0-0x00DC15F0

		// Methods
		public override void Enter() {} // 0x00DC1280-0x00DC1550
		public override void Execute() {} // 0x00DC1550-0x00DC1590
		public override void Exit() {} // 0x00DC1590-0x00DC15A0
	}

	public class StateListDecide : FSMState<UIWarehouse, States> // TypeDefIndex: 7710
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1180-0x00DC1190 

		// Constructors
		public StateListDecide() {} // 0x00DC1220-0x00DC1270

		// Methods
		public override void Enter() {} // 0x00DC1190-0x00DC1200
		public override void Execute() {} // 0x00DC1200-0x00DC1210
		public override void Exit() {} // 0x00DC1210-0x00DC1220
	}

	public class StateListCancel : FSMState<UIWarehouse, States> // TypeDefIndex: 7711
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC10A0-0x00DC10B0 

		// Constructors
		public StateListCancel() {} // 0x00DC1130-0x00DC1180

		// Methods
		public override void Enter() {} // 0x00DC10B0-0x00DC1110
		public override void Execute() {} // 0x00DC1110-0x00DC1120
		public override void Exit() {} // 0x00DC1120-0x00DC1130
	}

	public class StateFinish : FSMState<UIWarehouse, States> // TypeDefIndex: 7712
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC0F80-0x00DC0F90 

		// Constructors
		public StateFinish() {} // 0x00DC0FC0-0x00DC1010

		// Methods
		public override void Enter() {} // 0x00DC0F90-0x00DC0FA0
		public override void Execute() {} // 0x00DC0FA0-0x00DC0FB0
		public override void Exit() {} // 0x00DC0FB0-0x00DC0FC0
	}

	public class StateEnd : FSMState<UIWarehouse, States> // TypeDefIndex: 7713
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC0EF0-0x00DC0F00 

		// Constructors
		public StateEnd() {} // 0x00DC0F30-0x00DC0F80

		// Methods
		public override void Enter() {} // 0x00DC0F00-0x00DC0F10
		public override void Execute() {} // 0x00DC0F10-0x00DC0F20
		public override void Exit() {} // 0x00DC0F20-0x00DC0F30
	}

	public class StateNumberSelectStart : FSMState<UIWarehouse, States> // TypeDefIndex: 7714
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1B00-0x00DC1B10 

		// Constructors
		public StateNumberSelectStart() {} // 0x00DC1CE0-0x00DC1D30

		// Methods
		private int GetMin(List<IItem> list) => default; // 0x00DC1860-0x00DC1990
		private int GetMax(List<IItem> list) => default; // 0x00DC1990-0x00DC1B00
		public override void Enter() {} // 0x00DC1B10-0x00DC1CC0
		public override void Execute() {} // 0x00DC1CC0-0x00DC1CD0
		public override void Exit() {} // 0x00DC1CD0-0x00DC1CE0
	}

	public class StateSelectEnd : FSMState<UIWarehouse, States> // TypeDefIndex: 7715
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1D30-0x00DC1D40 

		// Constructors
		public StateSelectEnd() {} // 0x00DC1D70-0x00DC1DC0

		// Methods
		public override void Enter() {} // 0x00DC1D40-0x00DC1D50
		public override void Execute() {} // 0x00DC1D50-0x00DC1D60
		public override void Exit() {} // 0x00DC1D60-0x00DC1D70
	}

	public class StateNumberSelect : FSMState<UIWarehouse, States> // TypeDefIndex: 7716
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC17D0-0x00DC17E0 

		// Constructors
		public StateNumberSelect() {} // 0x00DC1810-0x00DC1860

		// Methods
		public override void Enter() {} // 0x00DC17E0-0x00DC17F0
		public override void Execute() {} // 0x00DC17F0-0x00DC1800
		public override void Exit() {} // 0x00DC1800-0x00DC1810
	}

	public class StateNumberDecide : FSMState<UIWarehouse, States> // TypeDefIndex: 7717
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC1740-0x00DC1750 

		// Constructors
		public StateNumberDecide() {} // 0x00DC1780-0x00DC17D0

		// Methods
		public override void Enter() {} // 0x00DC1750-0x00DC1760
		public override void Execute() {} // 0x00DC1760-0x00DC1770
		public override void Exit() {} // 0x00DC1770-0x00DC1780
	}

	public class StateNumberCancel : FSMState<UIWarehouse, States> // TypeDefIndex: 7718
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC15F0-0x00DC1600 

		// Constructors
		public StateNumberCancel() {} // 0x00DC16F0-0x00DC1740

		// Methods
		public override void Enter() {} // 0x00DC1600-0x00DC16D0
		public override void Execute() {} // 0x00DC16D0-0x00DC16E0
		public override void Exit() {} // 0x00DC16E0-0x00DC16F0
	}

	private class ItemLabelKind // TypeDefIndex: 7719
	{
		// Fields
		public Kind kind; // 0x10
		public CommonSortRefineWindow.ListItem.Label label; // 0x14

		// Constructors
		public ItemLabelKind() {} // 0x00DC0A10-0x00DC0A20
	}

	// Constructors
	public UIWarehouse() {} // 0x00A542F0-0x00A54970

	// Methods
	public void ResetPartCount() {} // 0x00A4FA70-0x00A4FBB0
	private void UpdateCommonItemWarehouseDepositInfo() {} // 0x00A4FBC0-0x00A4FCB0
	public int GetSelectCount() => default; // 0x00A4FCB0-0x00A4FCC0
	private void Start() {} // 0x00A4FCC0-0x00A4FCD0
	private void Update() {} // 0x00A4FCD0-0x00A4FD30
	public static UIWarehouse Create(bool image = false /* Metadata: 0x00613974 */) => default; // 0x00A4FD40-0x00A4FE50
	public void Construct() {} // 0x00A4FE50-0x00A502B0
	public void Destruct() {} // 0x00A503A0-0x00A50420
	private void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00A50420-0x00A50C60
	public static bool IsCanUseWazaMachine(IItem item) => default; // 0x00A51970-0x00A51980
	private bool ContainsWazaMachine(Index index) => default; // 0x00A51980-0x00A519E0
	public void SetWazaMachineInfos() {} // 0x00A50320-0x00A503A0
	private void SetWazaMachineInfo(SetType type) {} // 0x00A519E0-0x00A51DF0
	// [IteratorStateMachine] // 0x0062DFD0-0x0062E040
	public IEnumerator ShowPokemonList(List<IPokemonStatus> statusList, List<IPokemonStatus> ignoreList) => default; // 0x00A518F0-0x00A51970
	private void _cbFromNumberSelectWindow(NumberSelectWindowBase.ActionType act) {} // 0x00A51E20-0x00A51EF0
	public void Init(FlowPlay instance, bool bDeposit) {} // 0x00A51EF0-0x00A52670
	public void ResetFilter_Draw() {} // 0x00A52670-0x00A526A0
	// [IteratorStateMachine] // 0x0062E040-0x0062E0B0
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00A526A0-0x00A52720
	// [IteratorStateMachine] // 0x0062E0B0-0x0062E120
	public override IEnumerator MainFlow() => default; // 0x00A52750-0x00A527C0
	public void Continue() {} // 0x00A527F0-0x00A528E0
	public void SelectItemDelete_Draw() {} // 0x00A52D80-0x00A52DD0
	private void _updateDetail() {} // 0x00A51090-0x00A51200
	protected void _updateButtonGuide(IItem item) {} // 0x00A52DD0-0x00A52E90
	private void _updateWarehouseWindow() {} // 0x00A50FC0-0x00A51090
	public void UpdateBagWindow(int modify) {} // 0x00A50EA0-0x00A50EC0
	public void UpdateWarehouseWinodow(int modify) {} // 0x00A50EC0-0x00A50FC0
	public void OverBagWindow() {} // 0x00A52E90-0x00A52F90
	public void OverWarehouseWindow() {} // 0x00A52FC0-0x00A530C0
	private void SetListEnable(bool b) {} // 0x00A52F90-0x00A52FC0
	public void GetSelectItem(List<IItem> itemData) {} // 0x00A50C60-0x00A50EA0
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00A530C0-0x00A530F0
	// [IteratorStateMachine] // 0x0062E120-0x0062E190
	public override IEnumerator OpenWindow(Action cb) => default; // 0x00A530F0-0x00A53170
	// [IteratorStateMachine] // 0x0062E190-0x0062E200
	public override IEnumerator CloseWindow(Action cb) => default; // 0x00A531A0-0x00A53220
	// [IteratorStateMachine] // 0x0062E200-0x0062E270
	public IEnumerator OpenNumberSelectWindow(Action cb) => default; // 0x00A53250-0x00A532D0
	// [IteratorStateMachine] // 0x0062E270-0x0062E2E0
	public IEnumerator CloseNumberSelectWindow(Action cb) => default; // 0x00A53300-0x00A53380
	public void DoOpenEnter() {} // 0x00A533B0-0x00A537A0
	public void DoOpenEnterSelect() {} // 0x00A537A0-0x00A53870
	private void OpenAfter() {} // 0x00A53870-0x00A538E0
	public void DoOpenExecute() {} // 0x00A538E0-0x00A53950
	public void DoExecuteEnter() {} // 0x00A53950-0x00A539A0
	public void DoExecute() {} // 0x00A539A0-0x00A539D0
	public void DoExecuteselect() {} // 0x00A539D0-0x00A539E0
	public void DoExecuteExit() {} // 0x00A539E0-0x00A53A30
	public void DoCloseEnter() {} // 0x00A53A30-0x00A54040
	public void DoCloseExecute() {} // 0x00A54040-0x00A540B0
	public void DoCloseEntorSelect() {} // 0x00A540B0-0x00A54190
	private Kind _ItemLabelToKind(CommonSortRefineWindow.ListItem.Label label) => default; // 0x00A54190-0x00A54220
	private CommonSortRefineWindow.ListItem.Label _ItemKindToLabel(Kind kind) => default; // 0x00A54220-0x00A542C0
	// [IteratorStateMachine] // 0x0062E2E0-0x0062E350
	private IEnumerator _sortRefineSelect() => default; // 0x00A51880-0x00A518F0
}

