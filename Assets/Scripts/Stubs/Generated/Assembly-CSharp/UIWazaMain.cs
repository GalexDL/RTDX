/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.waza;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWazaMain : UIManagerBase // TypeDefIndex: 7783
{
	// Fields
	private WazaStatusExplainWindow_Wazaya wazaDetailWindow_; // 0x20
	private FlowWaza flowInstance_; // 0x28
	public FiniteStateMachine<UIWazaMain, States> FSM; // 0x30
	private bool bCancel_; // 0x38
	public MenuType menuType_; // 0x3C
	private ViewState[] viewStates_; // 0x40
	private GameObject mainObj_; // 0x48
	private CommonScreen commonScreen_; // 0x50
	private PokemonStatusTabWindow statusWindow_; // 0x58
	private UIWazaChange renketsuWazaChangeWindow_; // 0x60
	private PokemonSelectWindow pokemonSelectWindow_; // 0x68
	private IPokemonStatus focusPokemonStatus_; // 0x70
	private WazaLearnListWindow wazaLearnListWindow_; // 0x78
	private CommonPokeBagInfo commonPokeBagInfo_; // 0x80
	private RenketsuWazaListWindow nowWazaListWindow_; // 0x88
	private WazaStatusExplainWindow wazaInfoWindow_; // 0x90
	private ForgetWazaListWindow forgetWazaListWindow_; // 0x98
	private UIWazaChange.PokemonStatusWindow_NoMove pokemonCardWindow_; // 0xA0
	private RenketuMenuWindow renketuMenuWindow_; // 0xA8
	private ResultEffect resultEffect_; // 0xB0
	private int[] nAnimCount_; // 0xB8
	private WindowType windowType_; // 0xC0
	public int targetNo; // 0xC4
	private UIWazaRenketsuMenu.ActionType type_; // 0xC8

	// Properties
	public CommonScreen Common { get => default; } // 0x00DD62A0-0x00DD62B0 
	private int pokemonSelectWindowCount_ { get => default; } // 0x00DD62B0-0x00DD63D0 
	public UIWazaRenketsuMenu.ActionType Type { get => default; set {} } // 0x00DD71E0-0x00DD71F0 0x00DD71F0-0x00DD7200

	// Nested types
	public class WazaStatusExplainWindow_Wazaya : WazaStatusExplainWindow // TypeDefIndex: 7784
	{
		// Fields
		private bool disPlay; // 0x38
		private Anim<SpViewState> anim; // 0x40
		public string[] actionNames; // 0x48

		// Properties
		public bool Display { get => default; set {} } // 0x00D53ED0-0x00D53EE0 0x00D53EE0-0x00D53EF0
		public Anim<SpViewState> Anim { get => default; } // 0x00D55400-0x00D55410 

		// Nested types
		public enum SpViewState // TypeDefIndex: 7785
		{
			NONE = 0,
			OPEN = 1,
			CLOSE = 2
		}

		// Constructors
		public WazaStatusExplainWindow_Wazaya() {} // 0x00D554F0-0x00D55630

		// Methods
		public override void Init(GameObject root) {} // 0x00D55410-0x00D554A0
		public void Open_Wazaya(Action cb = null) {} // 0x00D54040-0x00D54170
		public void Close_Wazaya(Action cb = null) {} // 0x00D53EF0-0x00D54020
		public override void Update() {} // 0x00D554A0-0x00D554C0
	}

	public enum MenuType // TypeDefIndex: 7786
	{
		None = 0,
		RenketuMenu = 1,
		Forget = 2,
		Remember = 3,
		Learn = 4,
		Max = 5
	}

	public enum States // TypeDefIndex: 7787
	{
		Init = 0,
		PokemonListStart = 1,
		PokemonListSelect = 2,
		PokemonListDecide = 3,
		PokemonListCancel = 4,
		RemenberWazaListStart = 5,
		RemenberWazaListSelect = 6,
		RemenberWazaListDecide = 7,
		RemenberWazaListCancel = 8,
		WazaChangeWindowStart = 9,
		WazaChangeWindowSelect = 10,
		WazaChangeWindowDecide = 11,
		WazaChangeWindowCancel = 12,
		WazaForgetStart = 13,
		WazaForgetSelect = 14,
		WazaForgetDecide = 15,
		WazaForgetCancel = 16,
		LearnWazaListStart = 17,
		LearnWazaListSelect = 18,
		LearnWazaListDecide = 19,
		LearnWazaListCancel = 20,
		RenketsuMenuStart = 21,
		RenketsuMenuSelect = 22,
		RenketsuMenuDecide = 23,
		RenketsuMenuCancel = 24,
		ResultEffect = 25,
		RenketsuMenuPlay = 26,
		BunkaiMenuPlay = 27,
		KeyAllocationPlay = 28,
		Finish = 29,
		End = 30
	}

	public enum WindowType // TypeDefIndex: 7788
	{
		PokemonList = 0,
		RemenberWazaList = 1,
		WazaChangeList = 2,
		WazaForgetList = 3,
		WazaLearnList = 4,
		RenketsuMenu = 5,
		MoneyWindow = 6,
		ResultEffect = 7,
		FaceWindow = 8,
		WazaWindow = 9,
		Reset = 10,
		RenketsuPlay = 11,
		RenketsuReset = 12,
		Max = 13
	}

	private class PokemonSelectWindow : PokemonWarehouseListWindow // TypeDefIndex: 7789
	{
		// Fields
		private UIWazaMain manager_; // 0xC8
		private List<IPokemonWarehouseStatus> nowList; // 0xD0
		private GameObject objRoot_; // 0xD8
		private int presetIndex_; // 0xE0

		// Nested types
		public class UILocalSelectItem : PokemonWarehouseListWindow.UIPokemonWarehouseSelectItem // TypeDefIndex: 7790
		{
			// Properties
			public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x00D49840-0x00D49940 0x00D49830-0x00D49840

			// Constructors
			public UILocalSelectItem() {} // 0x00D496A0-0x00D496B0
		}

		// Constructors
		public PokemonSelectWindow() {} // 0x00D49340-0x00D49350

		// Methods
		protected override void FavorChange() {} // 0x00D484F0-0x00D485B0
		public override List<IPokemonWarehouseStatus> UniqueFilter(List<IPokemonWarehouseStatus> defaultList) => default; // 0x00D485B0-0x00D488C0
		public void Init(GameObject objRoot, int presetIndex, UIWazaMain manager) {} // 0x00D488C0-0x00D48B00
		public void _cbFromListWindow(ActionType act) {} // 0x00D48B10-0x00D48EF0
		private void SetFocusPokemonStatus() {} // 0x00D48F40-0x00D49000
		private void ResetFocus() {} // 0x00D49000-0x00D49010
		protected override bool _doDecide() => default; // 0x00D49010-0x00D49040
		protected override bool _doCancel() => default; // 0x00D49040-0x00D49050
		private void Douki(int count) {} // 0x00D49050-0x00D490D0
		protected override bool _onYButton() => default; // 0x00D490D0-0x00D49180
		protected override void ListUpdate() {} // 0x00D49180-0x00D49340
	}

	public class WazaLearnListWindow : BasicListWindow // TypeDefIndex: 7794
	{
		// Fields
		private UIWazaMain manager_; // 0x88
		private IPokemonStatus selectPokemonStatus_; // 0x90
		private List<wazaItem> wazaItemList_; // 0x98
		private List<GameObject> priceList; // 0xA0
		private MenuType type_; // 0xA8

		// Properties
		public bool priceOpen { get => default; set {} } // 0x00D539D0-0x00D53A30 0x00D53820-0x00D539D0

		// Nested types
		public class wazaItem // TypeDefIndex: 7795
		{
			// Fields
			public int slotID; // 0x10
			public Index wazaIndex; // 0x14
			public string wazaName; // 0x18
			public IPokemonStatus pokemonStatus; // 0x20
			public bool priceOpen; // 0x28

			// Constructors
			public wazaItem() {} // 0x00D553F0-0x00D55400
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7796
		{
			// Fields
			private wazaItem item_; // 0x18

			// Properties
			public wazaItem Item { get => default; set {} } // 0x00D54030-0x00D54040 0x00D54760-0x00D54770

			// Constructors
			public UILocalSelectItem() {} // 0x00D54750-0x00D54760
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 7797
		{
			// Fields
			public MenuType type; // 0x2C
			public WazaLearnListWindow wllw; // 0x30

			// Constructors
			public UILocalSelector() {} // 0x00D54850-0x00D548C0

			// Methods
			protected override void SetupFace() {} // 0x00D549B0-0x00D553F0
		}

		// Constructors
		public WazaLearnListWindow() {} // 0x00D54680-0x00D54690

		// Methods
		public void Init(GameObject obj, UIWazaMain manager, IPokemonStatus status, MenuType type) {} // 0x00D51F70-0x00D52130
		public void _cbFromListWindow(ActionType act) {} // 0x00D53A30-0x00D53AF0
		protected override void _doInput() {} // 0x00D53AF0-0x00D53C50
		protected override bool _doCancel() => default; // 0x00D53E70-0x00D53ED0
		private void DatailUpdate() {} // 0x00D53C80-0x00D53E70
		protected override bool _onXButton() => default; // 0x00D54170-0x00D54180
		protected override bool _doDecide() => default; // 0x00D54180-0x00D543C0
		protected override bool _onYButton() => default; // 0x00D54530-0x00D54570
		private bool releaseYButton() => default; // 0x00D53C50-0x00D53C80
		public void Over() {} // 0x00D543C0-0x00D54530
		protected override void _changeFocus() {} // 0x00D54570-0x00D54680
	}

	private class NowWazaListWindow : BasicListWindow // TypeDefIndex: 7799
	{
		// Fields
		private List<wazaItem> wazaItemList_; // 0x88
		private GameObject obj_; // 0x90

		// Nested types
		public class wazaItem // TypeDefIndex: 7800
		{
			// Fields
			public int slotID; // 0x10
			public Index wazaIndex; // 0x14
			public IPokemonStatus pokemonStatus; // 0x18

			// Constructors
			public wazaItem() {} // 0x00D47810-0x00D47820
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7801
		{
			// Fields
			private wazaItem item_; // 0x18

			// Properties
			public wazaItem Item { get => default; set {} } // 0x00D47AD0-0x00D47AE0 0x00D47910-0x00D47920

			// Constructors
			public UILocalSelectItem() {} // 0x00D47900-0x00D47910
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 7802
		{
			// Constructors
			public UILocalSelector() {} // 0x00D47A60-0x00D47AD0

			// Methods
			protected override void SetupFace() {} // 0x00D47AE0-0x00D484F0
		}

		// Constructors
		public NowWazaListWindow() {} // 0x00D47830-0x00D47840

		// Methods
		public void Init(GameObject obj, IPokemonStatus pokemonStatus) {} // 0x00D475A0-0x00D47810
		public void SetActive(bool b) {} // 0x00D47820-0x00D47830
	}

	private class WazaInfoWindow : BasicListWindow // TypeDefIndex: 7804
	{
		// Fields
		private GameObject typeIcon_; // 0x88
		private GameObject wazaType_; // 0x90
		private GameObject attribute_; // 0x98
		private GameObject range_; // 0xA0
		private IPokemonStatus status_; // 0xA8
		private GameObject obj_; // 0xB0

		// Constructors
		public WazaInfoWindow() {} // 0x00D53810-0x00D53820

		// Methods
		public void Init(GameObject obj, UIWazaMain manager, IPokemonStatus status) {} // 0x00D52500-0x00D527A0
		public void UpdateInfo(Index wazaIndex) {} // 0x00D527A0-0x00D53270
		private void _setStatusGage(GameObject obj, int power, int addPower, bool bPowerMax, bool bFit = true /* Metadata: 0x00613B14 */) {} // 0x00D53270-0x00D53800
	}

	private class ForgetWazaListWindow : RenketsuWazaSingleListWindow // TypeDefIndex: 7805
	{
		// Fields
		private UIWazaMain manager_; // 0x70
		private IPokemonStatus selectPokemonStatus_; // 0x78
		private List<wazaItem> wazaItemList_; // 0x80

		// Nested types
		public class wazaItem // TypeDefIndex: 7806
		{
			// Fields
			public int slotID; // 0x10
			public Index wazaIndex; // 0x14
			public IPokemonStatus pokemonStatus; // 0x18

			// Constructors
			public wazaItem() {} // 0x00D46810-0x00D46820
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7807
		{
			// Fields
			private wazaItem item_; // 0x18

			// Properties
			public wazaItem Item { get => default; set {} } // 0x00D46BE0-0x00D46BF0 0x00D46A20-0x00D46A30

			// Constructors
			public UILocalSelectItem() {} // 0x00D46A10-0x00D46A20
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 7808
		{
			// Constructors
			public UILocalSelector() {} // 0x00D46B70-0x00D46BE0

			// Methods
			protected override void SetupFace() {} // 0x00D46BF0-0x00D475A0
		}

		// Constructors
		public ForgetWazaListWindow() {} // 0x00D46940-0x00D46950

		// Methods
		public void Init(GameObject obj, UIWazaMain manager, IPokemonStatus status) {} // 0x00D463A0-0x00D46700
		public void _cbFromListWindow(ActionType act) {} // 0x00D46820-0x00D46940
	}

	public class RenketuMenuWindow : UIManagerBase // TypeDefIndex: 7810
	{
		// Fields
		private MenuType type_; // 0x1C
		private GameObject obj_; // 0x20
		private UIWazaMain manager_; // 0x28
		private GameObject renketu_renketu; // 0x30
		private GameObject renketu_bunkai; // 0x38
		private GameObject renketu_keyAllocation; // 0x40
		private bool bDecide; // 0x48
		private bool bFromItemAndUsed; // 0x49
		private bool bEnable_; // 0x4A
		private bool bRenketsu; // 0x4B
		private int nAnimCount_; // 0x4C
		public ViewState[] viewStates_; // 0x50

		// Properties
		public bool Enable { get => default; set {} } // 0x00D49950-0x00D49960 0x00D49960-0x00D49970

		// Nested types
		public enum MenuType // TypeDefIndex: 7811
		{
			None = 0,
			Renketu = 1,
			Bunkai = 2,
			KeyChange = 3,
			Max = 4
		}

		public enum ViewState // TypeDefIndex: 7812
		{
			NONE = 0,
			PRESSED = 1,
			NOTPRESSED = 2
		}

		public enum ButtonType // TypeDefIndex: 7813
		{
			NONE = 0,
			MenuBar = 1,
			Renketsu = 2,
			Bunkai = 3,
			Key_Allocation = 4,
			MAX = 5
		}

		// Constructors
		public RenketuMenuWindow() {} // 0x00D4B4F0-0x00D4B560

		// Methods
		public void SetFromItemUsed() {} // 0x00D49940-0x00D49950
		public void Init(GameObject objRoot, int presetIndex, UIWazaMain manager) {} // 0x00D49970-0x00D49C00
		public void SetActive(bool b) {} // 0x00D49D00-0x00D49D10
		public void Update() {} // 0x00D49D10-0x00D49D20
		private void AllFaceUpdate() {} // 0x00D49C60-0x00D49D00
		private void FaceUpdate(Transform transform, bool selectItem) {} // 0x00D4A180-0x00D4A420
		private void FaceUpdate(Transform transform, bool selectItem, bool renketsu) {} // 0x00D49ED0-0x00D4A180
		private void FaceReset(Transform trance) {} // 0x00D4A420-0x00D4A550
		private void AllFaceReset() {} // 0x00D49C00-0x00D49C60
		private void DecideAnim() {} // 0x00D4A550-0x00D4A9B0
		private void _doInput() {} // 0x00D49D20-0x00D49ED0
		private bool _doLeft() => default; // 0x00D4AE60-0x00D4AF90
		private bool _doRight() => default; // 0x00D4AD30-0x00D4AE60
		private bool _doDecide() => default; // 0x00D4AF90-0x00D4B0D0
		// [IteratorStateMachine] // 0x00651BF0-0x00651C60
		private IEnumerator _closeWindowsCancel() => default; // 0x00D4B2D0-0x00D4B340
		private bool _doCancel() => default; // 0x00D4B0D0-0x00D4B210
		private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00D4B370-0x00D4B3A0
		// [IteratorStateMachine] // 0x00651C60-0x00651CD0
		public IEnumerator MenuModeDecide(Action cb) => default; // 0x00D4A9B0-0x00D4AA30
		// [IteratorStateMachine] // 0x00651CD0-0x00651D40
		public IEnumerator RenketuModeDecide(Action cb) => default; // 0x00D4AA30-0x00D4AAB0
		// [IteratorStateMachine] // 0x00651D40-0x00651DB0
		public IEnumerator RenketuModeNotDecide(Action cb) => default; // 0x00D4AC30-0x00D4ACB0
		// [IteratorStateMachine] // 0x00651DB0-0x00651E20
		public IEnumerator BunkaiModeDecide(Action cb) => default; // 0x00D4ABB0-0x00D4AC30
		// [IteratorStateMachine] // 0x00651E20-0x00651E90
		public IEnumerator BunkaiModeNotDecide(Action cb) => default; // 0x00D4AAB0-0x00D4AB30
		// [IteratorStateMachine] // 0x00651E90-0x00651F00
		public IEnumerator Key_AllocationModeDecide(Action cb) => default; // 0x00D4ACB0-0x00D4AD30
		// [IteratorStateMachine] // 0x00651F00-0x00651F70
		public IEnumerator Key_AllocationModeNotDecide(Action cb) => default; // 0x00D4AB30-0x00D4ABB0
	}

	private class ResultEffect : UIManagerBase // TypeDefIndex: 7824
	{
		// Fields
		private UIWazaMain manager_; // 0x20
		private string nowToken; // 0x28
		private bool enable; // 0x30

		// Properties
		public string NowToken { get => default; } // 0x00D45C50-0x00D45C60 

		// Constructors
		public ResultEffect() {} // 0x00D4CF60-0x00D4CFC0

		// Methods
		public void SetEnable(bool b) {} // 0x00D4CE30-0x00D4CE40
		public void Init(GameObject obj, UIWazaMain manager, string token) {} // 0x00D4CE40-0x00D4CE50
		public void Update() {} // 0x00D4CE50-0x00D4CE60
		private void _doInput() {} // 0x00D4CE60-0x00D4CE70
		private bool _doDecide() => default; // 0x00D4CE70-0x00D4CF60
	}

	public enum ViewState // TypeDefIndex: 7825
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2,
		RESET = 3
	}

	public class StateInit : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7826
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4D8F0-0x00D4D900 

		// Constructors
		public StateInit() {} // 0x00D4D930-0x00D4D980

		// Methods
		public override void Enter() {} // 0x00D4D900-0x00D4D910
		public override void Execute() {} // 0x00D4D910-0x00D4D920
		public override void Exit() {} // 0x00D4D920-0x00D4D930
	}

	public class StatePokemonListStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7827
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D4E1C0-0x00D4E1D0 

		// Constructors
		public StatePokemonListStart() {} // 0x00D4E6B0-0x00D4E700

		// Methods
		public override void Enter() {} // 0x00D4E1D0-0x00D4E3B0
		public override void Execute() {} // 0x00D4E5D0-0x00D4E640
		private void DoEnter() {} // 0x00D4E3B0-0x00D4E5D0
		private void DoExecute() {} // 0x00D4E640-0x00D4E6B0
	}

	public class StateFinish : FSMState<UIWazaMain, States> // TypeDefIndex: 7828
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4D860-0x00D4D870 

		// Constructors
		public StateFinish() {} // 0x00D4D8A0-0x00D4D8F0

		// Methods
		public override void Enter() {} // 0x00D4D870-0x00D4D880
		public override void Execute() {} // 0x00D4D880-0x00D4D890
		public override void Exit() {} // 0x00D4D890-0x00D4D8A0
	}

	public class StateEnd : FSMState<UIWazaMain, States> // TypeDefIndex: 7829
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4D7D0-0x00D4D7E0 

		// Constructors
		public StateEnd() {} // 0x00D4D810-0x00D4D860

		// Methods
		public override void Enter() {} // 0x00D4D7E0-0x00D4D7F0
		public override void Execute() {} // 0x00D4D7F0-0x00D4D800
		public override void Exit() {} // 0x00D4D800-0x00D4D810
	}

	public class StatePokemonListSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7830
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4DF40-0x00D4DF50 

		// Constructors
		public StatePokemonListSelect() {} // 0x00D4E0A0-0x00D4E0F0

		// Methods
		public override void Enter() {} // 0x00D4DF50-0x00D4E050
		public override void Execute() {} // 0x00D4E050-0x00D4E090
		public override void Exit() {} // 0x00D4E090-0x00D4E0A0
	}

	public class StatePokemonListDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7831
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4DEE0-0x00D4DEF0 

		// Constructors
		public StatePokemonListDecide() {} // 0x00D4DEF0-0x00D4DF40
	}

	public class StatePokemonListCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7832
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4DDF0-0x00D4DE00 

		// Constructors
		public StatePokemonListCancel() {} // 0x00D4DE90-0x00D4DEE0

		// Methods
		public override void Enter() {} // 0x00D4DE00-0x00D4DE70
		public override void Execute() {} // 0x00D4DE70-0x00D4DE80
		public override void Exit() {} // 0x00D4DE80-0x00D4DE90
	}

	public class StateWazaRemenberStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7833
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D51B60-0x00D51B70 

		// Constructors
		public StateWazaRemenberStart() {} // 0x00D52480-0x00D524D0

		// Methods
		public override void Enter() {} // 0x00D51B70-0x00D51F70
		public override void Execute() {} // 0x00D52360-0x00D523F0
		private void DoEnter() {} // 0x00D52130-0x00D52360
		private void DoExecute() {} // 0x00D523F0-0x00D52480
	}

	public class StateWazaRemenberSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7834
	{
		// Properties
		public override States StateID { get => default; } // 0x00D519E0-0x00D519F0 

		// Constructors
		public StateWazaRemenberSelect() {} // 0x00D51B10-0x00D51B60

		// Methods
		public override void Enter() {} // 0x00D519F0-0x00D51A60
		public override void Execute() {} // 0x00D51A60-0x00D51AA0
		public override void Exit() {} // 0x00D51AA0-0x00D51B10
	}

	public class StateWazaRemenberDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7835
	{
		// Fields
		private int closeCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D516E0-0x00D516F0 

		// Constructors
		public StateWazaRemenberDecide() {} // 0x00D51970-0x00D519C0

		// Methods
		public override void Enter() {} // 0x00D516F0-0x00D51700
		public override void Execute() {} // 0x00D51890-0x00D51900
		private void DoEnter() {} // 0x00D51700-0x00D51890
		private void DoExecute() {} // 0x00D51900-0x00D51970
	}

	public class StateWazaRemenberCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7836
	{
		// Fields
		private int closeCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D51450-0x00D51460 

		// Constructors
		public StateWazaRemenberCancel() {} // 0x00D51680-0x00D516D0

		// Methods
		public override void Enter() {} // 0x00D51460-0x00D51470
		public override void Execute() {} // 0x00D51560-0x00D515F0
		private void DoEnter() {} // 0x00D51470-0x00D51560
		private void DoExecute() {} // 0x00D515F0-0x00D51680
	}

	public class StateWazaChangeWindowStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7837
	{
		// Fields
		private ListWindowBase.ActionType type_; // 0x18
		private UIWazaChange menu_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00D4FC80-0x00D4FC90 

		// Constructors
		public StateWazaChangeWindowStart() {} // 0x00D4FF60-0x00D4FFC0

		// Methods
		private void _cb(ListWindowBase.ActionType action) {} // 0x00D4FC90-0x00D4FD30
		private void temp() {} // 0x00D4FD30-0x00D4FDD0
		public override void Enter() {} // 0x00D4FDD0-0x00D4FF40
		public override void Execute() {} // 0x00D4FF40-0x00D4FF50
		public override void Exit() {} // 0x00D4FF50-0x00D4FF60
	}

	public class StateWazaChangeWindowSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7838
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4FC20-0x00D4FC30 

		// Constructors
		public StateWazaChangeWindowSelect() {} // 0x00D4FC30-0x00D4FC80
	}

	public class StateWazaChangeWindowDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7839
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4FBC0-0x00D4FBD0 

		// Constructors
		public StateWazaChangeWindowDecide() {} // 0x00D4FBD0-0x00D4FC20
	}

	public class StateWazaChangeWindowCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7840
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4FB60-0x00D4FB70 

		// Constructors
		public StateWazaChangeWindowCancel() {} // 0x00D4FB70-0x00D4FBC0
	}

	public class StateWazaForgetStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7841
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D507C0-0x00D507D0 

		// Constructors
		public StateWazaForgetStart() {} // 0x00D51190-0x00D511E0

		// Methods
		public override void Enter() {} // 0x00D507D0-0x00D50E90
		public override void Execute() {} // 0x00D51070-0x00D51100
		private void DoEnter() {} // 0x00D50E90-0x00D51070
		private void DoExcute() {} // 0x00D51100-0x00D51190
	}

	public class StateWazaForgetSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7842
	{
		// Properties
		public override States StateID { get => default; } // 0x00D50670-0x00D50680 

		// Constructors
		public StateWazaForgetSelect() {} // 0x00D50770-0x00D507C0

		// Methods
		public override void Enter() {} // 0x00D50680-0x00D506F0
		public override void Execute() {} // 0x00D506F0-0x00D50730
		public override void Exit() {} // 0x00D50730-0x00D50770
	}

	public class StateWazaForgetDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7843
	{
		// Fields
		private int closeCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D503B0-0x00D503C0 

		// Constructors
		public StateWazaForgetDecide() {} // 0x00D50600-0x00D50650

		// Methods
		public override void Enter() {} // 0x00D503C0-0x00D50580
		public override void Execute() {} // 0x00D50580-0x00D505F0
		public override void Exit() {} // 0x00D505F0-0x00D50600
	}

	public class StateWazaForgetCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7844
	{
		// Properties
		public override States StateID { get => default; } // 0x00D50110-0x00D50120 

		// Constructors
		public StateWazaForgetCancel() {} // 0x00D502D0-0x00D50320

		// Methods
		public override void Enter() {} // 0x00D50120-0x00D502B0
		public override void Execute() {} // 0x00D502B0-0x00D502C0
		public override void Exit() {} // 0x00D502C0-0x00D502D0
	}

	public class StateWazaLearnStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7846
	{
		// Properties
		public override States StateID { get => default; } // 0x00D513C0-0x00D513D0 

		// Constructors
		public StateWazaLearnStart() {} // 0x00D51400-0x00D51450

		// Methods
		public override void Enter() {} // 0x00D513D0-0x00D513E0
		public override void Execute() {} // 0x00D513E0-0x00D513F0
		public override void Exit() {} // 0x00D513F0-0x00D51400
	}

	public class StateWazaLearnSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7847
	{
		// Properties
		public override States StateID { get => default; } // 0x00D51330-0x00D51340 

		// Constructors
		public StateWazaLearnSelect() {} // 0x00D51370-0x00D513C0

		// Methods
		public override void Enter() {} // 0x00D51340-0x00D51350
		public override void Execute() {} // 0x00D51350-0x00D51360
		public override void Exit() {} // 0x00D51360-0x00D51370
	}

	public class StateWazaLearnDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7848
	{
		// Properties
		public override States StateID { get => default; } // 0x00D512A0-0x00D512B0 

		// Constructors
		public StateWazaLearnDecide() {} // 0x00D512E0-0x00D51330

		// Methods
		public override void Enter() {} // 0x00D512B0-0x00D512C0
		public override void Execute() {} // 0x00D512C0-0x00D512D0
		public override void Exit() {} // 0x00D512D0-0x00D512E0
	}

	public class StateWazaLearnCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7849
	{
		// Properties
		public override States StateID { get => default; } // 0x00D51210-0x00D51220 

		// Constructors
		public StateWazaLearnCancel() {} // 0x00D51250-0x00D512A0

		// Methods
		public override void Enter() {} // 0x00D51220-0x00D51230
		public override void Execute() {} // 0x00D51230-0x00D51240
		public override void Exit() {} // 0x00D51240-0x00D51250
	}

	public class StateRenketsuMenuStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7850
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D4ED10-0x00D4ED20 

		// Constructors
		public StateRenketsuMenuStart() {} // 0x00D4F860-0x00D4F8B0

		// Methods
		public override void Enter() {} // 0x00D4ED20-0x00D4F3D0
		public override void Execute() {} // 0x00D4F700-0x00D4F7B0
		private void DoEnter() {} // 0x00D4F490-0x00D4F700
		private void DoExecute() {} // 0x00D4F7B0-0x00D4F860
	}

	public class StateRenketsuMenuSelect : FSMState<UIWazaMain, States> // TypeDefIndex: 7851
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4EC70-0x00D4EC80 

		// Constructors
		public StateRenketsuMenuSelect() {} // 0x00D4ECC0-0x00D4ED10

		// Methods
		public override void Enter() {} // 0x00D4EC80-0x00D4EC90
		public override void Execute() {} // 0x00D4EC90-0x00D4ECB0
		public override void Exit() {} // 0x00D4ECB0-0x00D4ECC0
	}

	public class StateRenketsuMenuDecide : FSMState<UIWazaMain, States> // TypeDefIndex: 7852
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4E9B0-0x00D4E9C0 

		// Constructors
		public StateRenketsuMenuDecide() {} // 0x00D4E9F0-0x00D4EA40

		// Methods
		public override void Enter() {} // 0x00D4E9C0-0x00D4E9D0
		public override void Execute() {} // 0x00D4E9D0-0x00D4E9E0
		public override void Exit() {} // 0x00D4E9E0-0x00D4E9F0
	}

	public class StateRenketsuMenuCancel : FSMState<UIWazaMain, States> // TypeDefIndex: 7853
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4E810-0x00D4E820 

		// Constructors
		public StateRenketsuMenuCancel() {} // 0x00D4E960-0x00D4E9B0

		// Methods
		public override void Enter() {} // 0x00D4E820-0x00D4E940
		public override void Execute() {} // 0x00D4E940-0x00D4E950
		public override void Exit() {} // 0x00D4E950-0x00D4E960
	}

	public class StateRenketsuMenuPlay : FSMState<UIWazaMain, States> // TypeDefIndex: 7854
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4EA40-0x00D4EA50 

		// Constructors
		public StateRenketsuMenuPlay() {} // 0x00D4EC00-0x00D4EC50

		// Methods
		public override void Enter() {} // 0x00D4EA50-0x00D4EBF0
	}

	public class StateBunkaiMenuPlay : FSMState<UIWazaMain, States> // TypeDefIndex: 7856
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4D0F0-0x00D4D100 

		// Constructors
		public StateBunkaiMenuPlay() {} // 0x00D4D280-0x00D4D2D0

		// Methods
		public override void Enter() {} // 0x00D4D100-0x00D4D1E0
		// [IteratorStateMachine] // 0x006520F0-0x00652160
		private IEnumerator play() => default; // 0x00D4D1E0-0x00D4D250
	}

	public class StateKeyAllocationPlay : FSMState<UIWazaMain, States> // TypeDefIndex: 7859
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4D980-0x00D4D990 

		// Constructors
		public StateKeyAllocationPlay() {} // 0x00D4DB10-0x00D4DB60

		// Methods
		public override void Enter() {} // 0x00D4D990-0x00D4DA70
		// [IteratorStateMachine] // 0x00652160-0x006521D0
		private IEnumerator play() => default; // 0x00D4DA70-0x00D4DAE0
	}

	public class StateResultEffectStart : FSMState<UIWazaMain, States> // TypeDefIndex: 7862
	{
		// Properties
		public override States StateID { get => default; } // 0x00D4F8F0-0x00D4F900 

		// Constructors
		public StateResultEffectStart() {} // 0x00D4FAF0-0x00D4FB40

		// Methods
		public override void Enter() {} // 0x00D4F900-0x00D4FAC0
		public override void Execute() {} // 0x00D4FAC0-0x00D4FAE0
		public override void Exit() {} // 0x00D4FAE0-0x00D4FAF0
	}

	// Constructors
	public UIWazaMain() {} // 0x00DD7670-0x00DD76F0

	// Methods
	public GameObject GetWazaObject() => default; // 0x00DC9190-0x00DC91A0
	public IPokemonStatus GetSelectIPokemonStatus() => default; // 0x00DC91A0-0x00DC91B0
	public static UIWazaMain Create() => default; // 0x00DD4F70-0x00DD50E0
	public void Construct() {} // 0x00DD50E0-0x00DD5AE0
	public void Continue() {} // 0x00DD5AE0-0x00DD5AF0
	public void Init(FlowWaza instance, MenuType type) {} // 0x00DD5AF0-0x00DD5BA0
	// [IteratorStateMachine] // 0x0062E8B0-0x0062E920
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00DD5BA0-0x00DD5C20
	// [IteratorStateMachine] // 0x0062E920-0x0062E990
	public override IEnumerator MainFlow() => default; // 0x00DD5C50-0x00DD5CC0
	// [IteratorStateMachine] // 0x0062E990-0x0062EA00
	public IEnumerator MainFlowFromBoxRenketsu(IPokemonStatus status, Action<bool> cb = null) => default; // 0x00DD5CF0-0x00DD5D70
	private void Update() {} // 0x00DD5DA0-0x00DD5E00
	public void InitSingleFaceWindow(GameObject obj, out GameObject original, out GameObject face) {
		original = default;
		face = default;
	} // 0x00DD5E00-0x00DD61A0
	private void FaceStateOff(GameObject obj) {} // 0x00DD61A0-0x00DD62A0
	public List<WazaLearnListWindow.wazaItem> GetRememberWazaList_CheckHold(IPokemonStatus status) => default; // 0x00DD63D0-0x00DD6760
	public List<WazaLearnListWindow.wazaItem> GetWazaOshieList_CheckHold(IPokemonStatus status) => default; // 0x00DD6760-0x00DD69A0
	public List<WazaLearnListWindow.wazaItem> GetWazaOshieList_CheckHold_Deokishisu(IPokemonStatus status) => default; // 0x00DD69A0-0x00DD6A10
	private void _updateDetail(IPokemonStatus status, Action cb = null) {} // 0x00DD6A10-0x00DD6B30
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00DD6B30-0x00DD6BD0
	// [IteratorStateMachine] // 0x0062EA00-0x0062EA70
	public IEnumerator OpenWazaChangeWindow(Action cb) => default; // 0x00DD6BD0-0x00DD6C50
	// [IteratorStateMachine] // 0x0062EA70-0x0062EAE0
	public IEnumerator CloseWazaChangeWindow(Action cb) => default; // 0x00DD6C50-0x00DD6CD0
	// [IteratorStateMachine] // 0x0062EAE0-0x0062EB50
	public IEnumerator OpenRenketsuMenu(Action cb) => default; // 0x00DD6D00-0x00DD6D80
	// [IteratorStateMachine] // 0x0062EB50-0x0062EBC0
	public IEnumerator CloseRenketsuMenu(Action cb) => default; // 0x00DD6D80-0x00DD6E00
	// [IteratorStateMachine] // 0x0062EBC0-0x0062EC30
	public IEnumerator ResetRenketsuMenu(Action cb) => default; // 0x00DD6E30-0x00DD6EB0
	// [IteratorStateMachine] // 0x0062EC30-0x0062ECA0
	public IEnumerator OpenResultEffect(Action cb) => default; // 0x00DD6EB0-0x00DD6F30
	// [IteratorStateMachine] // 0x0062ECA0-0x0062ED10
	public IEnumerator CloseResultEffect(Action cb) => default; // 0x00DD6F30-0x00DD6FB0
	// [IteratorStateMachine] // 0x0062ED10-0x0062ED80
	public IEnumerator Open(Action cb, GameObject obj, WindowType type) => default; // 0x00DD6FE0-0x00DD7070
	// [IteratorStateMachine] // 0x0062ED80-0x0062EDF0
	public IEnumerator Close(Action cb, GameObject obj, WindowType type) => default; // 0x00DD7070-0x00DD7100
	// [IteratorStateMachine] // 0x0062EDF0-0x0062EE60
	public IEnumerator CallPopupWindow(Action cb) => default; // 0x00DD7130-0x00DD71B0
	private void RenketsuAfter(ref UIWazaRenketsuMenu.ActionType type, UIWazaRenketsuMenu.ActionType res, UIWazaRenketsuMenu menu) {} // 0x00DD7200-0x00DD7450
	private void KeyAllocationAfter(bool res, UIWazaButtonSet menu) {} // 0x00DD7450-0x00DD7670
}

