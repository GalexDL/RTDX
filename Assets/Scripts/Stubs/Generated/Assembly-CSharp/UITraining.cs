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
using Const.tutorial;
using SpecialAnim;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UITraining : UIManagerBase // TypeDefIndex: 7633
{
	// Fields
	private FlowTraining flowInstance_; // 0x20
	public FiniteStateMachine<UITraining, States> FSM; // 0x28
	public bool bCancel_; // 0x30
	private GameObject mainObj_; // 0x38
	private CommonScreen commonScreen_; // 0x40
	private TrainingPokemonListWindow pokemonListWindow_; // 0x48
	private PokemonStatusTabWindow statusTabWindow_; // 0x50
	private TicketSelectWindow ticketSelectWindow_; // 0x58
	private TicketInfoWindow ticketInfoWindow_; // 0x60
	private TutorialSelectWindow tutorialSelectWindow_; // 0x68
	private TutorialInfo tutorialInfo_; // 0x70
	private RewardInfo rewardInfo_; // 0x78
	private Const.tutorial.Index oldTrainingIndex; // 0x80
	private ModalScreen modalScreen_; // 0x88
	private ConfirmScreen confirmScreen_; // 0x90

	// Properties
	public FlowTraining FlowInstance { get => default; } // 0x00A42560-0x00A42570 

	// Nested types
	public enum States // TypeDefIndex: 7634
	{
		TutorialSelect = 0,
		TicketSelect = 1,
		PokemonSelect = 2,
		FormSelect = 3,
		ConfirmationMode = 4,
		End = 5
	}

	private class TrainingPokemonListWindow : PokemonWarehouseListWindow // TypeDefIndex: 7635
	{
		// Fields
		private UITraining manager_; // 0xC8
		private GameObject obj_; // 0xD0
		private List<IPokemonWarehouseStatus> nowList; // 0xD8
		private IPokemonWarehouseStatus curosorPokemonWarehouseStatus_; // 0xE0

		// Constructors
		public TrainingPokemonListWindow() {} // 0x00A42BD0-0x00A42BE0

		// Methods
		public void Init(GameObject objRoot, UITraining manager) {} // 0x00A47AF0-0x00A47DA0
		protected override bool _doDecide() => default; // 0x00A4AB50-0x00A4AC60
		public void Close(bool bFormChange) {} // 0x00A4AD10-0x00A4AF50
		private void ToNext(bool bFormChange) {} // 0x00A4AF60-0x00A4AFD0
		protected override bool _doCancel() => default; // 0x00A4AFD0-0x00A4B130
		protected override bool _onYButton() => default; // 0x00A4B130-0x00A4B1E0
		protected override void _changeFocus() {} // 0x00A4B1E0-0x00A4B260
		private IPokemonWarehouseStatus GetSelectWarehouseStatus() => default; // 0x00A4AC60-0x00A4AD10
		protected override void ListUpdate() {} // 0x00A4B260-0x00A4B2A0
		public void ResetList() {} // 0x00A4A950-0x00A4A990
		protected override void FavorChange() {} // 0x00A4B2A0-0x00A4B360
	}

	private class TicketSelectWindow : UIWindowBase // TypeDefIndex: 7638
	{
		// Fields
		private UITraining manager_; // 0x30
		private ticketItem[] ticketArray_; // 0x38
		private string[] aSelectorToken; // 0x40
		private string[] aFocusToken; // 0x48
		private string[] aSelectToken; // 0x50
		private string[] aPriceTextToken; // 0x58
		private string[] aDisableToken; // 0x60
		private GameObject[] cursor_; // 0x68

		// Nested types
		public class ticketItem // TypeDefIndex: 7639
		{
			// Fields
			public int slotID; // 0x10
			public Const.item.Index itemIndex; // 0x14

			// Constructors
			public ticketItem() {} // 0x00A4A990-0x00A4A9A0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7640
		{
			// Fields
			private ticketItem item_; // 0x18

			// Properties
			public ticketItem Item { get => default; set {} } // 0x00A4AA70-0x00A4AA80 0x00A4AA60-0x00A4AA70

			// Constructors
			public UILocalSelectItem() {} // 0x00A4AA80-0x00A4AA90
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 7641
		{
			// Constructors
			public UILocalSelector() {} // 0x00A4AAE0-0x00A4AB50

			// Methods
			protected override void SetupFace() {} // 0x00A4AA90-0x00A4AAE0
		}

		// Constructors
		public TicketSelectWindow() {} // 0x00A42BE0-0x00A43410

		// Methods
		public void Init(GameObject root, UITraining manager) {} // 0x00A481C0-0x00A48C90
		protected override void _doUpdate() {} // 0x00A4A1E0-0x00A4A1F0
		private void _doInput() {} // 0x00A4A1F0-0x00A4A340
		private bool _doUp() => default; // 0x00A4A340-0x00A4A470
		private bool _doDown() => default; // 0x00A4A470-0x00A4A5B0
		private bool _doDecide() => default; // 0x00A4A5B0-0x00A4A7B0
		private bool _doCancel() => default; // 0x00A4A7B0-0x00A4A950
	}

	public class TicketInfoWindow : UIWindowBase // TypeDefIndex: 7642
	{
		// Fields
		private GameObject time; // 0x30
		protected GameObject[] mag; // 0x38

		// Nested types
		public enum magType // TypeDefIndex: 7643
		{
			Little = 0,
			Normal = 1,
			Maximum = 2,
			Max = 3
		}

		// Constructors
		public TicketInfoWindow() {} // 0x00A43410-0x00A43470

		// Methods
		public override void Init(GameObject root) {} // 0x00A499D0-0x00A49D80
		public void UpdateData(magType type) {} // 0x00A49D80-0x00A4A1E0
	}

	private class TutorialSelectWindow : BasicListWindow // TypeDefIndex: 7644
	{
		// Fields
		private List<tutorialItem> tutorialItemList_; // 0x88
		private UITraining manager_; // 0x90
		private GameObject obj_; // 0x98
		private GameObject page; // 0xA0

		// Nested types
		public class tutorialItem // TypeDefIndex: 7645
		{
			// Fields
			public int slotID; // 0x10
			public Const.tutorial.Index trainingIndex; // 0x14

			// Constructors
			public tutorialItem() {} // 0x00A4B710-0x00A4B720
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7646
		{
			// Fields
			private tutorialItem item_; // 0x18

			// Properties
			public tutorialItem Item { get => default; set {} } // 0x00A43BE0-0x00A43BF0 0x00A4C1D0-0x00A4C1E0

			// Constructors
			public UILocalSelectItem() {} // 0x00A4C1C0-0x00A4C1D0
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 7647
		{
			// Constructors
			public UILocalSelector() {} // 0x00A4C3E0-0x00A4C450

			// Methods
			protected override void SetupFace() {} // 0x00A4C830-0x00A4CC90
		}

		// Constructors
		public TutorialSelectWindow() {} // 0x00A43470-0x00A43480

		// Methods
		public void Init(GameObject root, UITraining manager) {} // 0x00A49310-0x00A496C0
		protected override void _changePage() {} // 0x00A4B720-0x00A4B7B0
		protected override bool _doUp() => default; // 0x00A4B7B0-0x00A4B930
		protected override bool _doDown() => default; // 0x00A4B930-0x00A4BAB0
		protected override void _updatePageNumber() {} // 0x00A4BAB0-0x00A4BD80
		protected override bool _doDecide() => default; // 0x00A4BD80-0x00A4BF00
		protected override bool _doCancel() => default; // 0x00A4BF00-0x00A4C040
		// [IteratorStateMachine] // 0x00650E00-0x00650E70
		public IEnumerator Close(Action<bool> cb) => default; // 0x00A445C0-0x00A44640
		// [IteratorStateMachine] // 0x00650E70-0x00650EE0
		public IEnumerator Open(Action<bool> cb) => default; // 0x00A498C0-0x00A49940
		public Const.tutorial.Index GetLastTutorialIndex() => default; // 0x00A4C0A0-0x00A4C100
	}

	private class TutorialInfo : DetailWindowBase // TypeDefIndex: 7651
	{
		// Constructors
		public TutorialInfo() {} // 0x00A43480-0x00A43490
	}

	private class RewardInfo : UIWindowBase // TypeDefIndex: 7652
	{
		// Fields
		private string[] actionName_; // 0x30
		private Anim<AnimState> anim_; // 0x38
		private CanvasGroup acquired_; // 0x40
		private ItemIcon itemIcon_; // 0x48
		private ItemName itemName_; // 0x50
		private UITraining manager_; // 0x58

		// Properties
		public string[] ActionNames { get => default; } // 0x00A45C20-0x00A45C30 
		public Anim<AnimState> Anim { get => default; } // 0x00A45C30-0x00A45C40 

		// Nested types
		public enum AnimState // TypeDefIndex: 7653
		{
			NONE = 0,
			CURSOR_UP = 1,
			CURSOR_DOWN = 2,
			IMAGE_OPEN = 3,
			IMAGE_CLOSE = 4
		}

		private class ItemIcon : UIWindowBase // TypeDefIndex: 7654
		{
			// Fields
			public Image mainImage_; // 0x30
			public Image changeImage_; // 0x38

			// Constructors
			public ItemIcon() {} // 0x00A46030-0x00A46040

			// Methods
			public override void Init(GameObject root) {} // 0x00A46370-0x00A465D0
		}

		private class ItemName : UIWindowBase // TypeDefIndex: 7655
		{
			// Fields
			private UIControlTMP name_; // 0x30
			private UIControlTMP pieces_; // 0x38

			// Constructors
			public ItemName() {} // 0x00A46040-0x00A46050

			// Methods
			public override void Init(GameObject root) {} // 0x00A465D0-0x00A46AA0
			public void SetData(Const.tutorial.Index index) {} // 0x00A46110-0x00A462B0
		}

		// Constructors
		public RewardInfo() {} // 0x00A434B0-0x00A43720

		// Methods
		public void Init(GameObject root, UITraining manager) {} // 0x00A45C40-0x00A46030
		public void ChangeFocus_(Const.tutorial.Index afterIndex) {} // 0x00A43BF0-0x00A43CE0
		public void MainImageSet(Const.tutorial.Index index) {} // 0x00A46050-0x00A46110
		public void ChangeImageSet(Const.tutorial.Index index) {} // 0x00A462B0-0x00A46370
	}

	private enum SpecialViewState // TypeDefIndex: 7656
	{
		NONE = 0,
		BG_OPEN = 1,
		BG_CLOSE = 2,
		MAX = 3
	}

	private class ModalScreen : UIWindowBase // TypeDefIndex: 7657
	{
		// Fields
		private Anim<SpecialViewState> anim; // 0x30

		// Properties
		public Anim<SpecialViewState> Anim { get => default; } // 0x00A43E70-0x00A43E80 
		public SpecialViewState NowViewState { get => default; } // 0x00A45B40-0x00A45B90 

		// Constructors
		public ModalScreen() {} // 0x00A43490-0x00A434A0

		// Methods
		public override void Init(GameObject root) {} // 0x00A45B90-0x00A45C20
	}

	private class ConfirmScreen : UIWindowBase // TypeDefIndex: 7658
	{
		// Constructors
		public ConfirmScreen() {} // 0x00A434A0-0x00A434B0

		// Methods
		public override void Init(GameObject root) {} // 0x00A44EF0-0x00A44FC0
		public void SetFace(IPokemonStatus status, Const.creature.Index formIndex = Const.creature.Index.NONE /* Metadata: 0x00613970 */) {} // 0x00A44FC0-0x00A45B40
	}

	public class StateTutorialSelect : FSMState<UITraining, States> // TypeDefIndex: 7659
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A49010-0x00A49020 

		// Constructors
		public StateTutorialSelect() {} // 0x00A43720-0x00A43770

		// Methods
		public override void Enter() {} // 0x00A49020-0x00A49310
		public override void Execute() {} // 0x00A49870-0x00A498C0
		private void Open() {} // 0x00A496C0-0x00A49870
		private void OpenCb() {} // 0x00A49940-0x00A49970
	}

	public class StateTicketSelect : FSMState<UITraining, States> // TypeDefIndex: 7660
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A47F50-0x00A47F60 

		// Constructors
		public StateTicketSelect() {} // 0x00A43770-0x00A437C0

		// Methods
		public override void Enter() {} // 0x00A47F60-0x00A481C0
		public override void Execute() {} // 0x00A48E70-0x00A48E90
		private void Open() {} // 0x00A48C90-0x00A48E70
		private void OpenCb() {} // 0x00A48E90-0x00A48EF0
	}

	public class StatePokemonSelect : FSMState<UITraining, States> // TypeDefIndex: 7661
	{
		// Properties
		public override States StateID { get => default; } // 0x00A47650-0x00A47660 

		// Constructors
		public StatePokemonSelect() {} // 0x00A437C0-0x00A43810

		// Methods
		public override void Enter() {} // 0x00A47660-0x00A47AE0
		private void EnableSet(bool b) {} // 0x00A47DA0-0x00A47DF0
		public override void Execute() {} // 0x00A47DF0-0x00A47E30
	}

	public class StateFormSelect : FSMState<UITraining, States> // TypeDefIndex: 7663
	{
		// Fields
		private UIOrganizationMenu.PokemonFormChangeListWindow formChangeListWindow_; // 0x18
		private TextIDHash prevButtonGuide_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A46DD0-0x00A46DE0 

		// Constructors
		public StateFormSelect() {} // 0x00A43810-0x00A43860

		// Methods
		private void _cbFromFormChangeListWindow(ListWindowBase.ActionType act) {} // 0x00A46DE0-0x00A47220
		private void _cbFromStatusWindowForFormChangeList(PokemonStatusTabWindow.ActionType act) {} // 0x00A47220-0x00A47240
		public override void Enter() {} // 0x00A47240-0x00A473E0
		public override void Execute() {} // 0x00A473E0-0x00A47420
		public override void Exit() {} // 0x00A47420-0x00A47440
	}

	public class StateConfirmationMode : FSMState<UITraining, States> // TypeDefIndex: 7664
	{
		// Properties
		public override States StateID { get => default; } // 0x00A46AA0-0x00A46AB0 

		// Constructors
		public StateConfirmationMode() {} // 0x00A43860-0x00A438B0

		// Methods
		public override void Enter() {} // 0x00A46AB0-0x00A46D90
	}

	public class StateEnd : FSMState<UITraining, States> // TypeDefIndex: 7665
	{
		// Properties
		public override States StateID { get => default; } // 0x00A46D90-0x00A46DA0 

		// Constructors
		public StateEnd() {} // 0x00A438B0-0x00A43900

		// Methods
		public override void Enter() {} // 0x00A46DA0-0x00A46DB0
		public override void Execute() {} // 0x00A46DB0-0x00A46DC0
		public override void Exit() {} // 0x00A46DC0-0x00A46DD0
	}

	// Constructors
	public UITraining() {} // 0x00A43F20-0x00A43F30

	// Methods
	// [IteratorStateMachine] // 0x0062DCC0-0x0062DD30
	public IEnumerator CloseTicketSelectMode(Action cb, bool cancel) => default; // 0x00A42200-0x00A42290
	// [IteratorStateMachine] // 0x0062DD30-0x0062DDA0
	public IEnumerator CloseTutorialSelectMode(Action cb) => default; // 0x00A422C0-0x00A42340
	public void dest() {} // 0x00A42370-0x00A42560
	public static UITraining Create() => default; // 0x00A42570-0x00A427A0
	public void Construct() {} // 0x00A427A0-0x00A42BD0
	public void Init(FlowTraining instance) {} // 0x00A43900-0x00A43910
	// [IteratorStateMachine] // 0x0062DDA0-0x0062DE10
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00A43910-0x00A43990
	// [IteratorStateMachine] // 0x0062DE10-0x0062DE80
	public override IEnumerator MainFlow() => default; // 0x00A439C0-0x00A43A30
	private void Update() {} // 0x00A43A60-0x00A43AC0
	private void _updateDetail() {} // 0x00A43AC0-0x00A43BE0
	public void Close_PreDungeon() {} // 0x00A43CE0-0x00A43E70
	// [IteratorStateMachine] // 0x0062DE80-0x0062DEF0
	public IEnumerator Close_Confirm() => default; // 0x00A43E80-0x00A43EF0
}

