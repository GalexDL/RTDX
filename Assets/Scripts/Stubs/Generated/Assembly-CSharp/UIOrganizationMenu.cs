/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.item;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIOrganizationMenu : UIManagerBase // TypeDefIndex: 7231
{
	// Fields
	private CommonScreen commonScreen_; // 0x20
	private TeamSelectWindow teamSelectWindow_; // 0x28
	private ButtonSelect buttonSelect_; // 0x30
	private CommonItemWarehouseInfo warehouseWindow_; // 0x38
	private CommonPokeBankInfo bankWindow_; // 0x40
	private CommonItemBagInfo itemBagWindow_; // 0x48
	private CommonItemBagInfo itemBagWindowUp_; // 0x50
	private CommonPokeBagInfo pokeWindow_; // 0x58
	private PokemonStatusTabWindow statusWindow_; // 0x60
	private PokemonOrganizationListWindow pokemonListWindow_; // 0x68
	private PokemonFormChangeListWindow formChangeListWindow_; // 0x70
	private ItemEquippedListWindow itemEquippedListWindow_; // 0x78
	private ItemListWindow itemBagListWindow_; // 0x80
	private DetailWindow detailWindow_; // 0x88
	private ItemNameWindow itemNameWindow_; // 0x90
	private MenuType menuType_; // 0x98
	private ActionType act_; // 0x9C
	private bool bCanItemBring_; // 0xA0
	protected static GameObject regidentObj_; // 0x00
	private int selectPresetIndex_; // 0xA4
	private bool bRunningTutorial_; // 0xA8
	private bool bTutorialDeparture_; // 0xA9
	private bool bTutorialAnouncedFirst_; // 0xAA
	private bool bTutorialAnouncedReady_; // 0xAB
	private bool bTutorialAnouncedSelect_; // 0xAC
	private bool bTutorialReadyExperienced_; // 0xAD
	private bool bFixedPartyHint_; // 0xAE
	private List<IEnumerator> animationList; // 0xB0

	// Nested types
	private class OrganizationGuestWindow : UIWindowBase // TypeDefIndex: 7232
	{
		// Fields
		protected UIFaceWindow faceWindow_; // 0x30
		protected Const.creature.Index index_; // 0x38
		protected GenderType gender_; // 0x3C

		// Constructors
		public OrganizationGuestWindow() {} // 0x00F0B940-0x00F0B950

		// Methods
		public virtual void Init(GameObject root, Const.creature.Index index, GenderType gender) {} // 0x00F0B210-0x00F0B3B0
		public void UpdateWindow(bool bForce = false /* Metadata: 0x0061358E */) {} // 0x00F0B3B0-0x00F0B940
	}

	private class TeamSelectWindow : UIWindowBase // TypeDefIndex: 7233
	{
		// Fields
		private int presetLimit_; // 0x30
		private int presetIndex_; // 0x34
		public const int MAX_MEMBER_MAX = 3; // Metadata: 0x0061358F
		private int selectMember_; // 0x38
		private int memberLimit_; // 0x3C
		private int lastDownsideMember_; // 0x40
		public const int MAX_GUEST_MAX = 8; // Metadata: 0x00613593
		private PokemonStatusCardWindow[] pokemonCardWindow_; // 0x48
		private OrganizationGuestWindow[] pokemonGuestWindow_; // 0x50
		private GameObject objBg_; // 0x58
		private LocalPageControlWindow objPageControl_; // 0x60
		private bool[] pokemonCardLock_; // 0x68
		private int db_; // 0x70
		private bool bCenter_; // 0x74
		private string[] memberList; // 0x78
		private string[] guestList; // 0x80
		private SelectType selectType_; // 0x88
		private CallbackAction callbackFunc_; // 0x90
		public static string[] exchangeAction; // 0x00

		// Properties
		public int CurrentPreset { get => default; } // 0x00EFB050-0x00EFB060 
		public int CurrentMember { get => default; } // 0x00F03E30-0x00F03E40 
		public int MemberLimit { set {} } // 0x00EFD260-0x00EFD270

		// Nested types
		private class LocalPageControlWindow : BasicPageControlWindow // TypeDefIndex: 7234
		{
			// Fields
			private string[] aNumPageToken; // 0x38

			// Constructors
			public LocalPageControlWindow() {} // 0x00C7B600-0x00C7BA20

			// Methods
			public void Init(GameObject root, int numPage, int initPage = 0 /* Metadata: 0x00613597 */) {} // 0x00C7B470-0x00C7B600
		}

		public enum ActionType // TypeDefIndex: 7235
		{
			Decide = 0,
			Cancel = 1,
			ChangeMember = 2
		}

		public enum SelectType // TypeDefIndex: 7236
		{
			Preset = 0,
			Member = 1
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 7237; 0x00C7B020-0x00C7B3D0

		// Constructors
		public TeamSelectWindow() {} // 0x00EFA4E0-0x00EFAB50
		static TeamSelectWindow() {} // 0x00F0DD80-0x00F0DF20

		// Methods
		public void ResetActionListener() {} // 0x00EFEE70-0x00EFEE80
		public void RegisterActionListener(CallbackAction cb) {} // 0x00EFEE80-0x00EFEF70
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00F0C860-0x00F0C950
		public void callAction(ActionType action) {} // 0x00F0C950-0x00F0C970
		public virtual void Init(GameObject root, int presetIndex) {} // 0x00F0C970-0x00F0CE60
		public TextIDHash GetButtonGuideTextId() => default; // 0x00EFF860-0x00EFF880
		public void SetLockMember(int memberId, bool bLock) {} // 0x00EFD210-0x00EFD260
		public bool[] GetLockMember() => default; // 0x00F02970-0x00F02980
		public bool IsLockAllMember() => default; // 0x00F0CE60-0x00F0CEF0
		public void PageControlEnable(bool bEnable) {} // 0x00EFE2D0-0x00EFE3C0
		public void InputEnable(SelectType selectType) {} // 0x00EFEF70-0x00EFEFB0
		public IPokemonWarehouseStatus GetPokemonWarehouseStatus(int presetIndex, int memberIndex) => default; // 0x00F0CEF0-0x00F0CFF0
		public IPokemonWarehouseStatus GetCurrentPokemonWarehouseStatus(int memberIndex) => default; // 0x00EFBCA0-0x00EFBCB0
		public IPokemonWarehouseStatus GetCurrentPokemonWarehouseStatus() => default; // 0x00F07040-0x00F07050
		public IPokemonStatus GetCurrentPokemonStatus() => default; // 0x00F01A50-0x00F01B60
		public Const.creature.Index GetCurrentFormChangeIndex(int memberIndex) => default; // 0x00F0CFF0-0x00F0D000
		public Const.creature.Index GetCurrentFormChangeIndex() => default; // 0x00F01B60-0x00F01B70
		public void UpdateCards() {} // 0x00EFD270-0x00EFD990
		public void SelectCardSetAnimation(Action cb = null) {} // 0x00F03EE0-0x00F03FC0
		public void UpdateCardsCursor(bool bVisible) {} // 0x00F020E0-0x00F02380
		// [IteratorStateMachine] // 0x0064DD50-0x0064DDC0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00F0D000-0x00F0D080
		// [IteratorStateMachine] // 0x0064DDC0-0x0064DE30
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00F0D0B0-0x00F0D130
		public void SetPositionWindow(bool bCenter) {} // 0x00F07AB0-0x00F07C30
		// [IteratorStateMachine] // 0x0064DE30-0x0064DEA0
		public IEnumerator MovePositionWindow(bool bCenter, Action cb = null) => default; // 0x00EFF440-0x00EFF4D0
		// [IteratorStateMachine] // 0x0064DEA0-0x0064DF10
		public IEnumerator ExchangeCards(int card1, int card2, Action cb = null) => default; // 0x00F03E40-0x00F03ED0
		// [IteratorStateMachine] // 0x0064DF10-0x0064DF80
		public IEnumerator OpenChangeCards(int card1, int card2, Action cb = null) => default; // 0x00F07050-0x00F070E0
		// [IteratorStateMachine] // 0x0064DF80-0x0064DFF0
		public IEnumerator OpenCards(Action cb = null) => default; // 0x00F0D1F0-0x00F0D270
		// [IteratorStateMachine] // 0x0064DFF0-0x0064E060
		private IEnumerator _doMove(int db, string sAction, bool bRotation, Action cb = null) => default; // 0x00F0D2A0-0x00F0D340
		protected override void _doUpdate() {} // 0x00F0D370-0x00F0DC60
		public void ClearGuests() {} // 0x00F0DC60-0x00F0DD20
		public int GetGuestCount() => default; // 0x00F08850-0x00F089F0
		public bool AddGuests(Const.creature.Index index, GenderType gender) => default; // 0x00EFD990-0x00EFDB80
		// [IteratorStateMachine] // 0x0064E060-0x0064E0D0
		public IEnumerator OpenGuests(Action cb = null) => default; // 0x00F00BE0-0x00F00C60
		// [IteratorStateMachine] // 0x0064E0D0-0x0064E140
		public IEnumerator CloseGuests(Action cb = null) => default; // 0x00EFED40-0x00EFEDC0
	}

	private class ButtonSelect : BasicMenuWindow // TypeDefIndex: 7256
	{
		// Fields
		private GameObject[] buttons_; // 0x48
		private GameObject bg_; // 0x50

		// Constructors
		public ButtonSelect() {} // 0x00EFF030-0x00EFF040

		// Methods
		protected override bool _doLeft() => default; // 0x00F0A850-0x00F0A860
		protected override bool _doRight() => default; // 0x00F0A860-0x00F0A870
		public void Init(GameObject root, string[] sMenuTag, int defaultIndex = 0 /* Metadata: 0x006135AF */, GameObject bg = null) {} // 0x00EFF040-0x00EFF440
		public void FaceVisibleOff() {} // 0x00EFEFB0-0x00EFF030
		// [IteratorStateMachine] // 0x0064E160-0x0064E1D0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00F0A870-0x00F0A8F0
		// [IteratorStateMachine] // 0x0064E1D0-0x0064E240
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00F0A920-0x00F0A9A0
	}

	public class PokemonOrganizationListWindow : PokemonWarehouseListWindow // TypeDefIndex: 7261
	{
		// Fields
		private GameObject objRoot_; // 0xC8
		private int presetIndex_; // 0xD0
		private bool[] lockMember_; // 0xD8
		private UIOrganizationMenu manager_; // 0xE0

		// Nested types
		public class UILocalSelectItem : PokemonWarehouseListWindow.UIPokemonWarehouseSelectItem // TypeDefIndex: 7262
		{
			// Fields
			private int organizationNo_; // 0x30
			private Const.creature.Index formChangeIndex_; // 0x34

			// Properties
			public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x00F0C540-0x00F0C640 0x00F0C530-0x00F0C540
			public int OrganizationNo { get => default; set {} } // 0x00F03E20-0x00F03E30 0x00F0C520-0x00F0C530
			public Const.creature.Index FormChangeIndex { get => default; set {} } // 0x00F03ED0-0x00F03EE0 0x00F037D0-0x00F037E0

			// Constructors
			public UILocalSelectItem() {} // 0x00F0C510-0x00F0C520

			// Methods
			public override int GetOrganizationNo() => default; // 0x00F0C640-0x00F0C650
			public override Const.creature.Index GetFormChangeIndex() => default; // 0x00F0C650-0x00F0C660
		}

		// Constructors
		public PokemonOrganizationListWindow() {} // 0x00EFAB50-0x00EFAB60

		// Methods
		public void Init(UIOrganizationMenu manager, GameObject objRoot, int presetIndex, bool[] lockMember) {} // 0x00F02980-0x00F02BF0
		protected override int ComparePokemonWarehouseStatus(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x00F0BE70-0x00F0C060
		public override List<IPokemonWarehouseStatus> SetDefaultList(int presetIndex = -1 /* Metadata: 0x006135B3 */) => default; // 0x00F0C060-0x00F0C070
		protected override bool _onYButton() => default; // 0x00F0C070-0x00F0C120
		protected override void ListUpdate() {} // 0x00F0C120-0x00F0C210
	}

	public class PokemonFormChangeListWindow : PokemonListWindowBase // TypeDefIndex: 7265
	{
		// Nested types
		public class UIPokemonSelectItem : PokemonListWindowBase.UIPokemonSelectItemBase // TypeDefIndex: 7266
		{
			// Fields
			private IPokemonStatus pokemonStatus_; // 0x28
			private Const.creature.Index formChangeIndex_; // 0x30

			// Properties
			public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x00F0BD60-0x00F0BD70 0x00F0BD50-0x00F0BD60
			public Const.creature.Index FormChangeIndex { get => default; set {} } // 0x00F037C0-0x00F037D0 0x00F0BD40-0x00F0BD50

			// Constructors
			public UIPokemonSelectItem() {} // 0x00F0BD30-0x00F0BD40

			// Methods
			public override Const.creature.Index GetFormChangeIndex() => default; // 0x00F0BD70-0x00F0BD80
			public override int GetPokemonNameSetterId() => default; // 0x00F0BD80-0x00F0BE50
			public override bool IsFormNameView() => default; // 0x00F0BE50-0x00F0BE60
		}

		// Constructors
		public PokemonFormChangeListWindow() {} // 0x00F03370-0x00F03380

		// Methods
		public virtual void Init(GameObject objRoot, IPokemonStatus status, Const.creature.Index[] formList, Const.creature.Index defaultFormIndex = Const.creature.Index.NONE /* Metadata: 0x006135B7 */) {} // 0x00F0B950-0x00F0BB50
	}

	private class DetailWindow : DetailWindowBase // TypeDefIndex: 7269
	{
		// Constructors
		public DetailWindow() {} // 0x00EFAB60-0x00EFAB70

		// Methods
		protected override void _doUpdate() {} // 0x00F0B1F0-0x00F0B200
	}

	private class ItemNameWindow : UIWindowBase // TypeDefIndex: 7270
	{
		// Fields
		private Const.item.Index itemIndex_; // 0x30

		// Constructors
		public ItemNameWindow() {} // 0x00EFAB70-0x00EFAB80

		// Methods
		public Const.item.Index GetItemIndex() => default; // 0x00F0B200-0x00F0B210
		public void Init(GameObject obj, IItem item) {} // 0x00F05060-0x00F05490
	}

	public enum MenuType // TypeDefIndex: 7271
	{
		Setting = 0,
		Departure = 1
	}

	public enum ActionType // TypeDefIndex: 7272
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

	[Serializable]
	public class SaveData // TypeDefIndex: 7273
	{
		// Fields
		[SerializeField] // 0x00618790-0x006187A0
		private bool bTutorialDone_; // 0x10
		[SerializeField] // 0x006187A0-0x006187B0
		private bool bExplainedHaveItem_; // 0x11
		[SerializeField] // 0x006187B0-0x006187C0
		private bool bExplainedMoneyItem_; // 0x12
		[SerializeField] // 0x006187C0-0x006187D0
		private Const.item.Index[] itemEquip; // 0x18
		[SerializeField] // 0x006187D0-0x006187E0
		private SerializableDictionary_ItemMap itemMap_; // 0x20

		// Nested types
		[Serializable]
		public class SerializableDictionary_ItemMap : SerializableDictionary<Const.item.Index, int> // TypeDefIndex: 7274
		{
			// Constructors
			public SerializableDictionary_ItemMap() {} // 0x00F0C810-0x00F0C860
		}

		// Constructors
		public SaveData() {} // 0x00F0C750-0x00F0C810

		// Methods
		public void Reset() {} // 0x00F0C660-0x00F0C730
		public void SetTutorialDone() {} // 0x00EFB5E0-0x00EFB5F0
		public bool IsTutorialDone() => default; // 0x00EFABD0-0x00EFABE0
		public void SetExplainedHaveItem_() {} // 0x00F09680-0x00F09690
		public bool IsExplainedHaveItem_() => default; // 0x00EFC3B0-0x00EFC3C0
		public void SetExplainedMoneyItem_() {} // 0x00F098F0-0x00F09900
		public bool IsExplainedMoneyItem_() => default; // 0x00EFC630-0x00EFC640
		public SerializableDictionary_ItemMap GetItemMap() => default; // 0x00F0C730-0x00F0C740
		public Const.item.Index[] GetItemEquipTbl() => default; // 0x00F0C740-0x00F0C750
	}

	// Constructors
	public UIOrganizationMenu() {} // 0x00F060F0-0x00F06160
	static UIOrganizationMenu() {} // 0x00F06160-0x00F06170

	// Methods
	public static GameObject CreateRegident() => default; // 0x00EF9E80-0x00EFA030
	public static void DestroyRegident() {} // 0x00EFA030-0x00EFA1C0
	public static UIOrganizationMenu Create() => default; // 0x00EFA1C0-0x00EFA2A0
	public static UIOrganizationMenu GetMenu() => default; // 0x00EFA460-0x00EFA4E0
	public void Construct() {} // 0x00EFA2A0-0x00EFA460
	public void Destruct() {} // 0x00EFAB80-0x00EFABC0
	public int GetSelectPresetIndex() => default; // 0x00EFABC0-0x00EFABD0
	public static bool IsEnableHenseiMenu() => default; // 0x00EF7A80-0x00EF7BA0
	private bool _tutorialCheck() => default; // 0x00EFABE0-0x00EFAE00
	private bool _tutorialCheck01_01() => default; // 0x00EFAE80-0x00EFAE90
	private void _tutorial01_01(Action cb) {} // 0x00EFAE90-0x00EFAF70
	// [IteratorStateMachine] // 0x0062AE40-0x0062AEB0
	private IEnumerator _tutorialExec01_01(Action cb) => default; // 0x00EFAF70-0x00EFAFF0
	private bool _tutorialCheck01_02() => default; // 0x00EFB020-0x00EFB050
	private void _tutorial01_02(Action cb) {} // 0x00EFB060-0x00EFB140
	// [IteratorStateMachine] // 0x0062AEB0-0x0062AF20
	private IEnumerator _tutorialExec01_02() => default; // 0x00EFB1C0-0x00EFB220
	// [IteratorStateMachine] // 0x0062AF20-0x0062AF90
	private IEnumerator _tutorialExec01_02(Action cb) => default; // 0x00EFB140-0x00EFB1C0
	private bool _tutorialCheck01_03() => default; // 0x00EFB280-0x00EFB290
	private void _tutorial01_03(Action cb) {} // 0x00EFB290-0x00EFB370
	private bool _tutorialCheck02_01() => default; // 0x00EFB370-0x00EFB390
	private void _tutorial02_01(Action cb) {} // 0x00EFB390-0x00EFB470
	// [IteratorStateMachine] // 0x0062AF90-0x0062B000
	private IEnumerator _tutorialExec02_01(Action cb) => default; // 0x00EFB470-0x00EFB4F0
	private bool _tutorialCheck02_02() => default; // 0x00EFB520-0x00EFB5E0
	private void _tutorial02_02(Action cb) {} // 0x00EFB5F0-0x00EFB6D0
	// [IteratorStateMachine] // 0x0062B000-0x0062B070
	private IEnumerator _tutorialExec02_02(Action cb) => default; // 0x00EFB6D0-0x00EFB750
	private bool _tutorialCheck02_03() => default; // 0x00EFB780-0x00EFB7A0
	private void _tutorial02_03(Action cb) {} // 0x00EFB7A0-0x00EFB880
	// [IteratorStateMachine] // 0x0062B070-0x0062B0E0
	private IEnumerator _tutorialExec02_03(Action cb) => default; // 0x00EFB880-0x00EFB900
	private bool _tutorialCheck02_04() => default; // 0x00EFB930-0x00EFB950
	private void _tutorial02_04(Action cb) {} // 0x00EFB950-0x00EFBA30
	// [IteratorStateMachine] // 0x0062B0E0-0x0062B150
	private IEnumerator _tutorialExec02_04(Action cb) => default; // 0x00EFBA30-0x00EFBAB0
	private bool _tutorialCheck02_06() => default; // 0x00EFBAE0-0x00EFBB10
	private void _tutorial02_06(Action cb) {} // 0x00EFBB10-0x00EFBBF0
	// [IteratorStateMachine] // 0x0062B150-0x0062B1C0
	private IEnumerator _tutorialExec02_06(Action cb) => default; // 0x00EFBBF0-0x00EFBC70
	private bool _tutorialCheck04() => default; // 0x00EFAE00-0x00EFAE80
	private bool _tutorialCheck04_01() => default; // 0x00EFBCB0-0x00EFBCE0
	private void _tutorial04_01(Action cb) {} // 0x00EFBCE0-0x00EFBDC0
	// [IteratorStateMachine] // 0x0062B1C0-0x0062B230
	private IEnumerator _tutorialExec04_01(Action cb) => default; // 0x00EFBDC0-0x00EFBE40
	private bool _tutorialCheck04_02() => default; // 0x00EFBE70-0x00EFBF10
	private void _tutorial04_02(Action cb) {} // 0x00EFBF10-0x00EFBFF0
	// [IteratorStateMachine] // 0x0062B230-0x0062B2A0
	private IEnumerator _tutorialExec04_02(Action cb) => default; // 0x00EFBFF0-0x00EFC070
	private bool _tutorialCheck04_03() => default; // 0x00EFC0A0-0x00EFC140
	private void _tutorial04_03(Action cb) {} // 0x00EFC140-0x00EFC220
	// [IteratorStateMachine] // 0x0062B2A0-0x0062B310
	private IEnumerator _tutorialExec04_03(Action cb) => default; // 0x00EFC220-0x00EFC2A0
	private bool _tutorialCheck05_01() => default; // 0x00EFC2D0-0x00EFC3B0
	private void _tutorial05_01(Action cb) {} // 0x00EFC3C0-0x00EFC4A0
	// [IteratorStateMachine] // 0x0062B310-0x0062B380
	private IEnumerator _tutorialExec05_01(Action cb) => default; // 0x00EFC4A0-0x00EFC520
	private bool _tutorialCheck05_02() => default; // 0x00EFC550-0x00EFC630
	private void _tutorial05_02(Action cb) {} // 0x00EFC640-0x00EFC720
	// [IteratorStateMachine] // 0x0062B380-0x0062B3F0
	private IEnumerator _tutorialExec05_02(Action cb) => default; // 0x00EFC720-0x00EFC7A0
	// [IteratorStateMachine] // 0x0062B3F0-0x0062B460
	private IEnumerator _tutorialRescueExec(Action cb) => default; // 0x00EFC7D0-0x00EFC840
	private void _tutorialRescue(Action cb) {} // 0x00EFC870-0x00EFC940
	public void Init(MenuType menuType = MenuType.Departure /* Metadata: 0x00613569 */, GameData.AreaInfo areaInfo = null) {} // 0x00EFC940-0x00EFD210
	// [IteratorStateMachine] // 0x0062B460-0x0062B4D0
	public IEnumerator MainFlow(Action<ActionType> cb = null, bool bTutorialRescue = false /* Metadata: 0x0061356D */) => default; // 0x00EFDB80-0x00EFDC10
	// [IteratorStateMachine] // 0x0062B4D0-0x0062B540
	private IEnumerator _OpenFixedPartyTeam() => default; // 0x00EFDC40-0x00EFDCB0
	// [IteratorStateMachine] // 0x0062B540-0x0062B5B0
	private IEnumerator _askMainFlow(Action<int> cb = null) => default; // 0x00EFDCE0-0x00EFDD60
	// [IteratorStateMachine] // 0x0062B5B0-0x0062B620
	public IEnumerator AskItemMainFlow(int defaultIndex, Action<int> cb = null) => default; // 0x00EFDD90-0x00EFDE10
	// [IteratorStateMachine] // 0x0062B620-0x0062B690
	public IEnumerator AskMoneyMainFlow(int defaultIndex, Action<int> cb = null) => default; // 0x00EFDE40-0x00EFDEC0
	private void _cbFromTeamSelectWindow(TeamSelectWindow.ActionType act) {} // 0x00EFDEF0-0x00EFE2D0
	private void _OnStartTeamSelect() {} // 0x00EFEDC0-0x00EFEE70
	private void _OnButtonSelectTop(int defaultIndex = 0 /* Metadata: 0x0061356E */) {} // 0x00EFE8B0-0x00EFED40
	private void _cbFromButtonSelectTopMenu(ListWindowBase.ActionType act) {} // 0x00EFF4D0-0x00EFF860
	private void _OnButtonSelect(int defaultIndex = 0 /* Metadata: 0x00613572 */) {} // 0x00EFE3C0-0x00EFE8B0
	// [IteratorStateMachine] // 0x0062B690-0x0062B700
	private IEnumerator _noticeButtonSelectHint(Action cb = null) => default; // 0x00EFF880-0x00EFF900
	private void _OnButtonSelectStart() {} // 0x00EFF930-0x00EFFA40
	private void _cbFromButtonSelectMenu(ListWindowBase.ActionType act) {} // 0x00EFFA40-0x00F00280
	private void _OnButtonSelectItemMoney(int defaultIndex = 0 /* Metadata: 0x00613576 */) {} // 0x00F00280-0x00F00700
	private void _cbFromItemMoneyMenu(ListWindowBase.ActionType act) {} // 0x00F00700-0x00F00BC0
	private void _OnButtonSelectMoney(int defaultIndex = 0 /* Metadata: 0x0061357A */) {} // 0x00F00C60-0x00F01010
	private void _cbFromMoneyMenu(ListWindowBase.ActionType act) {} // 0x00F01010-0x00F01240
	private void _OnButtonSelectItem(int defaultIndex = 0 /* Metadata: 0x0061357E */) {} // 0x00F01250-0x00F015D0
	private void _cbFromItemMenu(ListWindowBase.ActionType act) {} // 0x00F015D0-0x00F01880
	private void _OnButtonOrganization(int defaultIndex = 0 /* Metadata: 0x00613582 */) {} // 0x00F01890-0x00F01A50
	private void _OnStartMemberSelect() {} // 0x00F01CA0-0x00F01E40
	private void _OnResumeMemberSelect() {} // 0x00F01E40-0x00F01F50
	private void _OnEndOrganization() {} // 0x00F01F50-0x00F020E0
	private void _updateDetail(IPokemonStatus status, Const.creature.Index formChangeIndex, Action cb = null) {} // 0x00F01B70-0x00F01CA0
	private void _switchFavor(IPokemonStatus status) {} // 0x00F02380-0x00F023A0
	private void _cbFromStatusWindowForMemberSelect(PokemonStatusTabWindow.ActionType act) {} // 0x00F023A0-0x00F023C0
	private void _cbFromMemberSelectWindow(TeamSelectWindow.ActionType act) {} // 0x00F023C0-0x00F02710
	private void _OnSelectOrganization() {} // 0x00F02720-0x00F02970
	private void _OnStartSelectOrganization() {} // 0x00F02BF0-0x00F02D80
	private void _cbFromPokemonListWindow(ListWindowBase.ActionType act) {} // 0x00F02D80-0x00F03060
	private void _cbFromStatusWindowForPokemonList(PokemonStatusTabWindow.ActionType act) {} // 0x00F03070-0x00F03090
	private void _OnFormChangeSelect() {} // 0x00F03090-0x00F03370
	private void _OnStartSelectFormChangeSelect() {} // 0x00F03380-0x00F03510
	private void _cbFromFormChangeListWindow(ListWindowBase.ActionType act) {} // 0x00F03510-0x00F037C0
	private void _cbFromStatusWindowForFormChangeList(PokemonStatusTabWindow.ActionType act) {} // 0x00F037E0-0x00F03800
	private void _OnCancelFormChangeListWindow() {} // 0x00F03800-0x00F03810
	private void _OnDecideOrganization() {} // 0x00F03810-0x00F038F0
	// [IteratorStateMachine] // 0x0062B700-0x0062B770
	private IEnumerator _delayAction(int nFrame, Action cb) => default; // 0x00F038F0-0x00F03970
	private void _OnChangeStartOrganization() {} // 0x00F039A0-0x00F03E00
	private void _OnChangeFinishOrganization() {} // 0x00F03FC0-0x00F040D0
	private void _OnButtonHaveAItem(int defaultIndex = 0 /* Metadata: 0x00613586 */) {} // 0x00F040D0-0x00F04340
	private void _OnStartHaveAItem() {} // 0x00F04340-0x00F04470
	private void _cbFromItemEquippedListWindow(ListWindowBase.ActionType act) {} // 0x00F04470-0x00F046C0
	// [IteratorStateMachine] // 0x0062B770-0x0062B7E0
	private IEnumerator NoticeNoItem(Action cb = null) => default; // 0x00F046D0-0x00F04750
	private void _OnNoItem() {} // 0x00F04780-0x00F04890
	private void _OnNoItem_end() {} // 0x00F04890-0x00F04950
	private void _ResumeButtonHaveAItem() {} // 0x00F04950-0x00F04AD0
	private void _OnSelectHaveAItem(int defaultIndex = 0 /* Metadata: 0x0061358A */) {} // 0x00F04AD0-0x00F04F70
	private void _itemBagListSetEquip() {} // 0x00F04F70-0x00F05060
	private void _OnStartSelectHaveAItem() {} // 0x00F05700-0x00F05830
	private void _ArrowSetVisible(bool bOpen) {} // 0x00F055E0-0x00F05700
	private void _updateItemBagListDetail() {} // 0x00F05490-0x00F055E0
	private void _cbFromItemBagListWindow(ListWindowBase.ActionType act) {} // 0x00F05830-0x00F05BA0
	private void _OnChangeStartHaveAItem() {} // 0x00F05BA0-0x00F05E00
	private void _OnChangeEffectHaveAItem() {} // 0x00F05E00-0x00F05F30
	private void _OnChangeEndHaveAItem() {} // 0x00F05F30-0x00F06010
	private void Start() {} // 0x00F06010-0x00F06020
	private void Update() {} // 0x00F06020-0x00F060F0
}

