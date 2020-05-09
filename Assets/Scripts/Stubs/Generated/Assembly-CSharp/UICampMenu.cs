/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.creature;
using Const.item;
using Const.sugowaza;
using Const.waza;
using SpecialAnim;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UICampMenu : UIManagerBase // TypeDefIndex: 6554
{
	// Fields
	private static byte[] bgLoadBuffer_; // 0x00
	private LoadState loadState_; // 0x1C
	private BgState[] bgSates_; // 0x20
	private Const.camp.Index prioridadCampIndex_; // 0x28
	public float fadeOutSec; // 0x2C
	private List<string> releaseList_; // 0x30
	private DisplayManager displayManager_; // 0x38
	private FlowCamp flowInstance_; // 0x40
	public FiniteStateMachine<UICampMenu, Status> FSM; // 0x48
	public bool bCancel_; // 0x50
	private CommonScreen commonScreen_; // 0x58
	public CommonPokemonWarehouseInfo infoPokemonNum_; // 0x60
	private GameObject campPokemonInfoObj; // 0x68
	private CampListWindow campListWindow_; // 0x70
	private SubPokemonListWindow subPokemonListWindow_; // 0x78
	private CampPokemonInfoWindow campPokemonInfoWindow_; // 0x80
	private CampInModeWindow campInModeWindow_; // 0x88
	private MapWindow mapWindow_; // 0x90
	private CampPokemonSelectWindow pokemonSelectWindow_; // 0x98
	private CampPokemonStatusTabWindow campPokemonStatusTabWindow_; // 0xA0
	private GummySelectWindow gummySelectWindow_; // 0xA8
	private ButtonSelect buttonSelect_; // 0xB0
	private ModalScreen modalScreen_; // 0xB8
	private ConfirmScreen confirmScreen_; // 0xC0
	private CampPokemonListWindow pokemonListWindow_; // 0xC8
	private SugowazaListWindow sugowazaListWindow_; // 0xD0
	private GameObject mainObj_; // 0xD8
	private int lastIndex_; // 0xE0
	private GameObject sugowazaEffectObj_; // 0xE8
	private GameObject cursorObj_; // 0xF0
	public SelectType selectType; // 0xF8
	private bool returnActionMenu_; // 0xFC
	private bool fromGummyMenu_; // 0xFD
	private Const.sugowaza.Index newSugowazaIndex_; // 0x100
	private Const.item.Index selectItemIndex_; // 0x104
	private ItemSelectWindow itemSelectWindow_; // 0x108
	private ItemDetailWindow itemDetailWindow_; // 0x110
	private Const.waza.Index selectWazaIndex_; // 0x118
	private bool wazaSelectContinue_; // 0x11C
	private int wazaSelectCursorIndex_; // 0x120
	private int itemSelectCursorIndex_; // 0x124

	// Properties
	private LoadState LoadState_ { get => default; set {} } // 0x00AC5610-0x00AC5620 0x00AC5620-0x00AC5630
	private Const.camp.Index PrioridadCampIndex { get => default; set {} } // 0x00AC57A0-0x00AC57B0 0x00AC57B0-0x00AC57C0
	private List<string> ReleaseList { get => default; } // 0x00AC59A0-0x00AC59B0 
	public FlowCamp FlowInstance { get => default; } // 0x00AC5B90-0x00AC5BA0 
	public CommonScreen Common { get => default; } // 0x00AC5BA0-0x00AC5BB0 
	public CampInModeWindow CampInModeWindow_ { get => default; } // 0x00AC5EB0-0x00AC5EC0 
	public CampPokemonSelectWindow CampPokemonSelectWindow_ { get => default; } // 0x00AC5EC0-0x00AC5ED0 
	public GameObject CursorObj { get => default; } // 0x00AC5EE0-0x00AC5EF0 
	public bool ReturnActionMenu { get => default; set {} } // 0x00AC8310-0x00AC8320 0x00AC8320-0x00AC8330

	// Nested types
	private enum LoadState // TypeDefIndex: 6555
	{
		LOAD_START = 0,
		LOAD_END = 1,
		LOAD_CANCEL = 2,
		UNLOAD_START = 3,
		UNLOAD_END = 4
	}

	private enum BgState // TypeDefIndex: 6556
	{
		NONE = 0,
		LOADING = 1,
		LOAD_END = 2
	}

	private class WazaSelectWindow : BasicListWindow // TypeDefIndex: 6557
	{
		// Constructors
		public WazaSelectWindow() {} // 0x009755A0-0x009755B0
	}

	private enum SpecialViewState // TypeDefIndex: 6558
	{
		NONE = 0,
		BG_OPEN = 1,
		BG_CLOSE = 2,
		FACE_OPEN = 3,
		FACE_CLOSE = 4,
		MAX = 5
	}

	public class DisplayManager // TypeDefIndex: 6559
	{
		// Fields
		private string[] ignoreTokens; // 0x10
		private UICampMenu menu_; // 0x18
		private List<Transform> childrenList; // 0x20
		private bool enable; // 0x28

		// Properties
		public bool Enable { get => default; set {} } // 0x00AD3560-0x00AD3570 0x00AC5B70-0x00AC5B80

		// Nested types
		public enum NowScreenType // TypeDefIndex: 6560
		{
			None = 0,
			CampSelect = 1,
			PokemonSelect = 2,
			CampInfo = 3,
			DotSelect = 4,
			Max = 5
		}

		// Constructors
		public DisplayManager() {} // 0x00AC6CE0-0x00AC6DC0

		// Methods
		public void Init(GameObject obj, UICampMenu menu) {} // 0x00AC6DC0-0x00AC7100
		private void SetEnable(bool enable) {} // 0x00AD30C0-0x00AD31A0
		public void SetVisible(bool visible) {} // 0x00AD31A0-0x00AD3560
		public void Update(NowScreenType type) {} // 0x00AD3570-0x00AD3710
	}

	public enum Status // TypeDefIndex: 6561
	{
		Map = 0,
		CampInMode = 1,
		CampInfoOpen = 2,
		PokemonSelect = 3,
		ActionSelect = 4,
		NickName = 5,
		ConfirmationMode = 6,
		CampSelect = 7,
		StatusUp = 8,
		PartConfirm = 9,
		SugowazaFirstGetStart = 10,
		SugowazaSecondGetStart = 11,
		GummySelect = 12,
		ItemSelect = 13,
		WazaSelect = 14,
		FavoOnMessage = 15,
		FavoOffMessage = 16,
		ItemSelect_Continue = 17,
		ParameterStatusUp = 18,
		Temp = 19,
		End = 20
	}

	private class CampListWindow : BasicListWindow // TypeDefIndex: 6562
	{
		// Fields
		private UICampMenu manager_; // 0x88
		private List<CampItem> campList; // 0x90
		private GameObject obj_; // 0x98
		private GameObject details; // 0xA0
		private CallbackAction callbackFunc_; // 0xA8

		// Properties
		public List<CampItem> CampList { get => default; } // 0x00ACD370-0x00ACD380 

		// Nested types
		public class CampItem // TypeDefIndex: 6563
		{
			// Fields
			public int slotID; // 0x10
			public Const.camp.Index campIndex; // 0x14

			// Constructors
			public CampItem() {} // 0x00ACD390-0x00ACD3A0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6564
		{
			// Fields
			private CampItem item_; // 0x18

			// Properties
			public CampItem Item { get => default; set {} } // 0x00ACD830-0x00ACD840 0x00ACF1B0-0x00ACF1C0

			// Constructors
			public UILocalSelectItem() {} // 0x00ACF1A0-0x00ACF1B0
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6565
		{
			// Constructors
			public UILocalSelector() {} // 0x00ACF6D0-0x00ACF740

			// Methods
			protected override void SetupFace() {} // 0x00ACFB30-0x00AD0200
		}

		public enum ActionType // TypeDefIndex: 6566
		{
			Decide = 0,
			Cancel = 1,
			Focus = 2,
			PressX = 3,
			PressY = 4,
			Start = 5
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6567; 0x00ACDD20-0x00ACE0D0

		// Constructors
		public CampListWindow() {} // 0x00AC7100-0x00AC7110

		// Methods
		public List<CampItem> GetCampItemList() => default; // 0x00ACD380-0x00ACD390
		public void Init(GameObject obj, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F02 */) {} // 0x00AC7820-0x00AC7E00
		public void _cbFromListWindow(ActionType act) {} // 0x00ACD460-0x00ACD830
		// [IteratorStateMachine] // 0x00649BD0-0x00649C40
		private IEnumerator Fade() => default; // 0x00ACD840-0x00ACD8B0
		private void infoChange() {} // 0x00ACD8B0-0x00ACD960
		private void infoInit() {} // 0x00ACD3A0-0x00ACD460
		protected override bool _doDecide() => default; // 0x00ACD990-0x00ACDAB0
		protected override bool _doCancel() => default; // 0x00ACDAC0-0x00ACDB10
		protected override bool _onXButton() => default; // 0x00ACDB10-0x00ACDC30
		public new void ResetActionListener() {} // 0x00AC7E00-0x00AC7E10
		public void RegisterActionListener(CallbackAction cb) {} // 0x00AC7E20-0x00AC7F10
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00ACDC30-0x00ACDD20
		public void callAction(ActionType action) {} // 0x00ACDAB0-0x00ACDAC0
		protected override void _doInput() {} // 0x00ACE0D0-0x00ACE170
		private bool _doStart() => default; // 0x00ACE170-0x00ACE330
		protected override void _changeFocus() {} // 0x00ACED00-0x00ACEE40
		public void ResetFocus(Const.camp.Index index) {} // 0x00ACEE40-0x00ACF010
		public void SetCampIndex_(Const.camp.Index campIndex) {} // 0x00ACF010-0x00ACF0D0
	}

	private class SubPokemonListWindow : UIWindowBase // TypeDefIndex: 6570
	{
		// Fields
		private UIScrollView scScrollView_; // 0x30
		private GameObject objScrollContents_; // 0x38
		private float scrollContentsBasePosition_; // 0x40
		private float scrollContentsOffsetPosition_; // 0x44
		private float scrollContentsScale_; // 0x48
		private BasicListWindow listDetail_; // 0x50
		private UICampMenu manager_; // 0x58
		private GameObject obj_; // 0x60
		private List<PokemonItem> pokemonList; // 0x68
		private bool scrollPosSet; // 0x70
		private bool bRunning_; // 0x71
		private bool bUpdateRequest_; // 0x72

		// Nested types
		public class PokemonItem // TypeDefIndex: 6571
		{
			// Fields
			public int slotID; // 0x10
			public IPokemonWarehouseStatus pokemonStatus; // 0x18

			// Constructors
			public PokemonItem() {} // 0x0096FF00-0x0096FF10
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6572
		{
			// Fields
			private PokemonItem item_; // 0x18

			// Properties
			public PokemonItem Item { get => default; set {} } // 0x00971520-0x00971530 0x009706E0-0x009706F0

			// Constructors
			public UILocalSelectItem() {} // 0x009706D0-0x009706E0
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6573
		{
			// Constructors
			public UILocalSelector() {} // 0x00970830-0x009708A0

			// Methods
			protected override void SetupFace() {} // 0x00971530-0x00971540
			public void SetupFaceTrue() {} // 0x00970C90-0x00971390
		}

		// Constructors
		public SubPokemonListWindow() {} // 0x009705A0-0x00970610

		// Methods
		protected int ComparePokemonWarehouseStatus(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x0096F590-0x0096F5F0
		public int CompareOrganizationId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x0096F720-0x0096F890
		public int CompareBookSortId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x0096F890-0x0096F9A0
		public int CompareIsFavorite(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x0096F5F0-0x0096F720
		public int CompareFriendSortId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x0096F9A0-0x0096FAB0
		public void Init(GameObject obj, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F1E */) {} // 0x0096FAB0-0x0096FB30
		public void Reset_Init() {} // 0x0096FB30-0x0096FF00
		public void setTextPositionTop() {} // 0x00970150-0x00970160
		private void ScrollInit(int count) {} // 0x0096FF10-0x00970150
		private void _updateTextPosition(float pos) {} // 0x00970160-0x00970250
		public override void Update() {} // 0x00970250-0x009702A0
		public void updateScrollView() {} // 0x009702A0-0x00970370
		public void SetScrollActive(bool b) {} // 0x00967F40-0x00967FF0
		// [IteratorStateMachine] // 0x00649CA0-0x00649D10
		private IEnumerator UpdateListsLoop() => default; // 0x00970370-0x009703E0
		public void StartUpdateFlow() {} // 0x00970410-0x00970500
		// [IteratorStateMachine] // 0x00649D10-0x00649D80
		public IEnumerator WaitEnd() => default; // 0x00970500-0x00970570
	}

	private class CampPokemonInfoWindow : UIWindowBase // TypeDefIndex: 6577
	{
		// Fields
		public UIScrollView scScrollView_; // 0x30
		private GameObject objScrollContents_; // 0x38
		private float scrollContentsBasePosition_; // 0x40
		private float scrollContentsOffsetPosition_; // 0x44
		private float scrollContentsScale_; // 0x48
		private BasicListWindow listDetail_; // 0x50
		private UICampMenu manager_; // 0x58
		private GameObject obj_; // 0x60
		private List<PokemonItem> pokemonList; // 0x68
		private bool scrollPosSet; // 0x70

		// Nested types
		public class PokemonItem // TypeDefIndex: 6578
		{
			// Fields
			public int slotID; // 0x10
			public Const.creature.Index pokemonIndex; // 0x14
			public bool isMember; // 0x18
			public bool isAcquainted; // 0x19

			// Constructors
			public PokemonItem() {} // 0x00AD0540-0x00AD0550
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6579
		{
			// Fields
			private PokemonItem item_; // 0x18

			// Properties
			public PokemonItem Item { get => default; set {} } // 0x00AD0F50-0x00AD0F60 0x00AD0D90-0x00AD0DA0

			// Constructors
			public UILocalSelectItem() {} // 0x00AD0D80-0x00AD0D90
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6580
		{
			// Constructors
			public UILocalSelector() {} // 0x00AD0EE0-0x00AD0F50

			// Methods
			protected override void SetupFace() {} // 0x00AD0F60-0x00AD1750
		}

		// Constructors
		public CampPokemonInfoWindow() {} // 0x00AC7160-0x00AC71D0

		// Methods
		private bool IsMember(Const.creature.Index index) => default; // 0x00AD0200-0x00AD0540
		public void Init(GameObject obj, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F22 */) {} // 0x00ACE330-0x00ACEA30
		public void setTextPositionTop() {} // 0x00AD0800-0x00AD0810
		private void ScrollInit(int count) {} // 0x00AD0550-0x00AD0800
		private void _updateTextPosition(float pos) {} // 0x00AD0810-0x00AD0900
		public override void Update() {} // 0x00AD0900-0x00AD0950
		public void updateScrollView() {} // 0x00AD0A20-0x00AD0AF0
		public void SetScrollActive(bool b) {} // 0x00ACEA30-0x00ACEA40
		protected void _doInput() {} // 0x00AD0950-0x00AD0A20
		private bool _doStart() => default; // 0x00AD0AF0-0x00AD0CC0
		public void Open() {} // 0x00ACEA40-0x00ACED00
	}

	public class CampInModeWindow : BasicListWindow // TypeDefIndex: 6582
	{
		// Fields
		private UICampMenu manager_; // 0x88
		private GameObject modeObj; // 0x90
		private GameObject root_; // 0x98

		// Constructors
		public CampInModeWindow() {} // 0x00AC7110-0x00AC7120

		// Methods
		// [IteratorStateMachine] // 0x00649DA0-0x00649E10
		public IEnumerator CloseCampBg(Action cb = null) => default; // 0x00ACCA00-0x00ACCA80
		public void Init(GameObject root, UICampMenu manager, Const.camp.Index campIndex) {} // 0x00ACCAB0-0x00ACCC10
		public void _cbFromListWindow(ActionType act) {} // 0x00ACCE00-0x00ACCF00
		private void SetUpFace(GameObject face, Const.camp.Index campIndex) {} // 0x00ACCC10-0x00ACCE00
		protected override bool _doDecide() => default; // 0x00ACCF70-0x00ACCFA0
		protected override bool _doCancel() => default; // 0x00ACCFA0-0x00ACCFC0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00ACCFC0-0x00ACD030
		// [IteratorStateMachine] // 0x00649E10-0x00649E80
		public IEnumerator CloseName() => default; // 0x00ACCF00-0x00ACCF70
	}

	public class MapWindow : UIWindowBase // TypeDefIndex: 6586
	{
		// Fields
		private UICampMenu manager_; // 0x30

		// Constructors
		public MapWindow() {} // 0x00967330-0x00967340

		// Methods
		public void Init(GameObject root, UICampMenu manager) {} // 0x009672E0-0x00967330
	}

	private class CampPokemonStatusTabWindow : PokemonStatusTabWindow // TypeDefIndex: 6587
	{
		// Fields
		private UICampMenu manager_; // 0x60
		private GameObject tab_; // 0x68

		// Constructors
		public CampPokemonStatusTabWindow() {} // 0x00AC7120-0x00AC7130

		// Methods
		public void Init(GameObject objTop, UICampMenu manager) {} // 0x00AC7F10-0x00AC7FC0
		protected override void TokuchoChange() {} // 0x00AD2B90-0x00AD2C70
	}

	private class GummySelectWindow : BasicMenuWindow // TypeDefIndex: 6588
	{
		// Fields
		private GameObject[] counts_; // 0x48
		private GameObject[] buttons_; // 0x50
		private UICampMenu manager_; // 0x58
		private int cursorIndex_; // 0x60

		// Constructors
		public GummySelectWindow() {} // 0x00963310-0x00963320

		// Methods
		protected override bool _doLeft() => default; // 0x009621D0-0x009621E0
		protected override bool _doRight() => default; // 0x009621E0-0x009621F0
		public void Init(GameObject root, string[] sMenuTag, UICampMenu manager, bool objSet, int defaultIndex = 0 /* Metadata: 0x00612F26 */) {} // 0x009621F0-0x009629C0
		public void FaceVisibleOff() {} // 0x00962D00-0x00962D80
		// [IteratorStateMachine] // 0x00649E80-0x00649EF0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00962D80-0x00962E00
		public void OpenBg() {} // 0x00962E30-0x00962F40
		// [IteratorStateMachine] // 0x00649EF0-0x00649F60
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00962F40-0x00962FC0
		public void CloseBg() {} // 0x00962FF0-0x00963100
		private void _cb(ActionType act) {} // 0x00963100-0x00963300
		private void _updateDetail(IPokemonStatus status, Action cb = null) {} // 0x009629C0-0x00962A60
		public int GetDefaultIndex() => default; // 0x00963300-0x00963310
	}

	private class ButtonSelect : BasicMenuWindow // TypeDefIndex: 6593
	{
		// Fields
		private bool continueFlag; // 0x41
		private GameObject[] buttons_; // 0x48
		private UICampMenu manager_; // 0x50
		private int closeCnt_; // 0x58
		private UIControlTMPSetter favoSetter; // 0x60

		// Properties
		public bool ContinueFlag { get => default; set {} } // 0x00ACAA40-0x00ACAA50 0x00ACAA50-0x00ACAA60

		// Constructors
		public ButtonSelect() {} // 0x00AC7130-0x00AC7140

		// Methods
		protected override bool _doLeft() => default; // 0x00ACAA60-0x00ACAA70
		protected override bool _doRight() => default; // 0x00ACAA70-0x00ACAA80
		public void Init(GameObject root, string[] sMenuTag, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F2A */) {} // 0x00ACAA80-0x00ACB040
		public void SelectReset() {} // 0x00ACB100-0x00ACB330
		public void FaceVisibleOff() {} // 0x00ACB330-0x00ACB3B0
		// [IteratorStateMachine] // 0x00649F70-0x00649FE0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00ACB3B0-0x00ACB430
		public void OpenBg() {} // 0x00ACB460-0x00ACB570
		// [IteratorStateMachine] // 0x00649FE0-0x0064A050
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00ACB570-0x00ACB5F0
		public void CloseBg() {} // 0x00ACB620-0x00ACB730
		public override void Update() {} // 0x00ACB730-0x00ACB780
		protected override bool _doAButton() => default; // 0x00ACB780-0x00ACBE30
		protected override bool _doBButton() => default; // 0x00ACBE30-0x00ACC020
		private void CloseCb() {} // 0x00ACC020-0x00ACC0E0
		private void _updateDetail(IPokemonStatus status, Action cb = null) {} // 0x00ACB040-0x00ACB0E0
		public void UpdateFavoText(bool favo) {} // 0x00ACB0E0-0x00ACB100
	}

	private class ModalScreen : UIWindowBase // TypeDefIndex: 6598
	{
		// Fields
		private Anim<SpecialViewState> anim; // 0x30

		// Properties
		public Anim<SpecialViewState> Anim { get => default; } // 0x00967340-0x00967350 
		public SpecialViewState NowViewState { get => default; } // 0x00967350-0x009673A0 

		// Constructors
		public ModalScreen() {} // 0x00967430-0x00967440

		// Methods
		public override void Init(GameObject root) {} // 0x009673A0-0x00967430
	}

	private class ConfirmScreen : UIWindowBase // TypeDefIndex: 6599
	{
		// Fields
		private Anim<SpecialViewState> anim; // 0x30

		// Properties
		public Anim<SpecialViewState> Anim { get => default; } // 0x00AC8A60-0x00AC8A70 

		// Constructors
		public ConfirmScreen() {} // 0x00AC7140-0x00AC7150

		// Methods
		public override void Init(GameObject root) {} // 0x00AD2C70-0x00AD2D10
		public void SetFace(IPokemonWarehouseStatus status, FlowCamp.ToActionType type) {} // 0x00AC8540-0x00AC89B0
		// [IteratorStateMachine] // 0x0064A090-0x0064A100
		public IEnumerator BreakUp() => default; // 0x00AD2D10-0x00AD2D80
		public void CautionSet_SetActive(bool active) {} // 0x00AC89B0-0x00AC8A60
	}

	private class CampPokemonListWindow : PokemonWarehouseListWindow // TypeDefIndex: 6602
	{
		// Fields
		private List<IPokemonWarehouseStatus> nowList; // 0xC8
		private UICampMenu manager_; // 0xD0
		private GameObject obj_; // 0xD8

		// Constructors
		public CampPokemonListWindow() {} // 0x00AC7150-0x00AC7160

		// Methods
		public override List<IPokemonWarehouseStatus> SetDefaultList(int presetIndex = -1 /* Metadata: 0x00612F2E */) => default; // 0x00AD1750-0x00AD18A0
		public void Init(GameObject objRoot, UICampMenu manager) {} // 0x00AC7FC0-0x00AC8290
		protected override bool _doDecide() => default; // 0x00AD18A0-0x00AD1990
		// [IteratorStateMachine] // 0x0064A100-0x0064A170
		private IEnumerator Decide() => default; // 0x00AD1990-0x00AD1A00
		protected override bool _onXButton() => default; // 0x00AD1A30-0x00AD1B80
		protected override bool _doCancel() => default; // 0x00AD1B80-0x00AD1CB0
		// [IteratorStateMachine] // 0x0064A170-0x0064A1E0
		private IEnumerator Fade() => default; // 0x00AD1CB0-0x00AD1D20
		protected override bool _onYButton() => default; // 0x00AD1D50-0x00AD1E00
		protected override void ListUpdate() {} // 0x00AD1E00-0x00AD1E30
		protected override void _changeFocus() {} // 0x00AD1E30-0x00AD1EA0
		protected override void FavorChange() {} // 0x00AD1EA0-0x00AD1F60
	}

	private class SugowazaListWindow : BasicListWindow // TypeDefIndex: 6606
	{
		// Fields
		private UICampMenu manager_; // 0x88
		private List<SugowazaItem> sugowazaList_; // 0x90
		private GameObject obj_; // 0x98
		private bool bInit_; // 0xA0
		private string[] actionName_; // 0xA8
		private Anim<SpecialAnimViewState> anim; // 0xB0

		// Properties
		public bool bInit { get => default; } // 0x009716E0-0x009716F0 

		// Nested types
		public class SugowazaItem // TypeDefIndex: 6607
		{
			// Fields
			public int slotID; // 0x10
			public Const.sugowaza.Index sugowazaIndex; // 0x14
			public bool bNew; // 0x18

			// Constructors
			public SugowazaItem() {} // 0x009716F0-0x00971700
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6608
		{
			// Fields
			private SugowazaItem item_; // 0x18

			// Properties
			public SugowazaItem Item { get => default; set {} } // 0x00973220-0x00973230 0x00971F40-0x00971F50

			// Constructors
			public UILocalSelectItem() {} // 0x00971F30-0x00971F40
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6609
		{
			// Constructors
			public UILocalSelector() {} // 0x00972640-0x009726B0

			// Methods
			protected override void SetupFace() {} // 0x00973230-0x00973540
		}

		public enum SpecialAnimViewState // TypeDefIndex: 6610
		{
			NONE = 0,
			OPEN = 1,
			CLOSE = 2
		}

		// Constructors
		public SugowazaListWindow() {} // 0x00971CC0-0x00971E60

		// Methods
		public void Init(GameObject obj, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F32 */) {} // 0x0096E340-0x0096E660
		public void _cbFromListWindow(ActionType act) {} // 0x00971700-0x00971960
		protected override bool _doCancel() => default; // 0x009719E0-0x009719F0
		// [IteratorStateMachine] // 0x0064A220-0x0064A290
		private IEnumerator SugowazaChangeMessage() => default; // 0x009719F0-0x00971A60
		// [IteratorStateMachine] // 0x0064A290-0x0064A300
		private IEnumerator SugowazaNoChangeMessage() => default; // 0x00971A90-0x00971B00
		// [IteratorStateMachine] // 0x0064A300-0x0064A370
		private IEnumerator SugowazaChoice(Action<bool> yes) => default; // 0x00971960-0x009719E0
		public void Open(Action cb = null) {} // 0x0096E660-0x0096E7A0
		public void Close(Action cb = null) {} // 0x00971B70-0x00971CB0
	}

	public enum SelectType // TypeDefIndex: 6618
	{
		CAMP = 0,
		POKEMON = 1,
		CAMP_POKEMON_INFO = 2
	}

	public class StateCampSelectMode : FSMState<UICampMenu, Status> // TypeDefIndex: 6619
	{
		// Fields
		private bool init; // 0x18
		private int openCnt_; // 0x1C
		private bool b; // 0x20

		// Properties
		public override Status StateID { get => default; } // 0x00967B50-0x00967B60 

		// Constructors
		public StateCampSelectMode() {} // 0x00968000-0x00968050

		// Methods
		public override void Enter() {} // 0x00967B60-0x00967D70
		private void OpenCb() {} // 0x00967D70-0x00967DD0
		public override void Execute() {} // 0x00967DD0-0x00967F40
		public override void Exit() {} // 0x00967FF0-0x00968000
	}

	public class StateCampInMode : FSMState<UICampMenu, Status> // TypeDefIndex: 6620
	{
		// Properties
		public override Status StateID { get => default; } // 0x00967440-0x00967450 

		// Constructors
		public StateCampInMode() {} // 0x00967650-0x009676A0

		// Methods
		public override void Enter() {} // 0x00967450-0x00967590
		// [IteratorStateMachine] // 0x0064A410-0x0064A480
		private IEnumerator Open() => default; // 0x00967590-0x00967600
		public override void Execute() {} // 0x00967630-0x00967640
		public override void Exit() {} // 0x00967640-0x00967650
	}

	public class StatePokemonSelect : FSMState<UICampMenu, Status> // TypeDefIndex: 6622
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096BC30-0x0096BC40 

		// Constructors
		public StatePokemonSelect() {} // 0x0096BFD0-0x0096C020

		// Methods
		public override void Enter() {} // 0x0096BC40-0x0096BD10
		public override void Execute() {} // 0x0096BEB0-0x0096BEF0
		private void MessageAndInit() {} // 0x0096BD10-0x0096BEB0
		public override void Exit() {} // 0x0096BEF0-0x0096BF30
		// [IteratorStateMachine] // 0x0064A480-0x0064A4F0
		private IEnumerator CampIn() => default; // 0x0096BF30-0x0096BFA0
	}

	public class StateSelectAction : FSMState<UICampMenu, Status> // TypeDefIndex: 6624
	{
		// Fields
		private int openCnt_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x0096C480-0x0096C490 

		// Constructors
		public StateSelectAction() {} // 0x0096CD80-0x0096CDD0

		// Methods
		public override void Enter() {} // 0x0096C490-0x0096CCA0
		private void OpenCb() {} // 0x0096CCA0-0x0096CD00
		public override void Execute() {} // 0x0096CD00-0x0096CD40
		public override void Exit() {} // 0x0096CD40-0x0096CD80
	}

	public class StateGummySelect : FSMState<UICampMenu, Status> // TypeDefIndex: 6625
	{
		// Fields
		private int openCnt_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x00968D80-0x00968D90 

		// Constructors
		public StateGummySelect() {} // 0x00969270-0x009692C0

		// Methods
		public override void Enter() {} // 0x00968D90-0x00969170
		private void OpenCb() {} // 0x00969170-0x009691D0
		public override void Execute() {} // 0x009691D0-0x00969210
		public override void Exit() {} // 0x00969210-0x00969270
	}

	public class StateConfirmationMode : FSMState<UICampMenu, Status> // TypeDefIndex: 6626
	{
		// Properties
		public override Status StateID { get => default; } // 0x00968110-0x00968120 

		// Constructors
		public StateConfirmationMode() {} // 0x00968390-0x009683E0

		// Methods
		public override void Enter() {} // 0x00968120-0x00968390
	}

	public class StateNickNameMode : FSMState<UICampMenu, Status> // TypeDefIndex: 6627
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096B090-0x0096B0A0 

		// Constructors
		public StateNickNameMode() {} // 0x0096B310-0x0096B360

		// Methods
		public override void Enter() {} // 0x0096B0A0-0x0096B1F0
		private void Temp(string s, bool result) {} // 0x0096B1F0-0x0096B310
	}

	public class StateEnd : FSMState<UICampMenu, Status> // TypeDefIndex: 6629
	{
		// Properties
		public override Status StateID { get => default; } // 0x00968440-0x00968450 

		// Constructors
		public StateEnd() {} // 0x00968480-0x009684D0

		// Methods
		public override void Enter() {} // 0x00968450-0x00968460
		public override void Execute() {} // 0x00968460-0x00968470
		public override void Exit() {} // 0x00968470-0x00968480
	}

	public class StateStatusUp : FSMState<UICampMenu, Status> // TypeDefIndex: 6630
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096CFB0-0x0096CFC0 

		// Constructors
		public StateStatusUp() {} // 0x0096D0F0-0x0096D140

		// Methods
		public override void Enter() {} // 0x0096CFC0-0x0096D0F0
	}

	public class StateMapWindow : FSMState<UICampMenu, Status> // TypeDefIndex: 6631
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096A4D0-0x0096A4E0 

		// Constructors
		public StateMapWindow() {} // 0x0096A870-0x0096A8C0

		// Methods
		public override void Enter() {} // 0x0096A4E0-0x0096A6A0
		// [IteratorStateMachine] // 0x0064A5B0-0x0064A620
		private IEnumerator Move() => default; // 0x0096A710-0x0096A780
		// [IteratorStateMachine] // 0x0064A620-0x0064A690
		private IEnumerator Move2() => default; // 0x0096A6A0-0x0096A710
		// [IteratorStateMachine] // 0x0064A690-0x0064A700
		private IEnumerator Load() => default; // 0x0096A7E0-0x0096A840
	}

	public class StatePart : FSMState<UICampMenu, Status> // TypeDefIndex: 6637
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096B660-0x0096B670 

		// Constructors
		public StatePart() {} // 0x0096B7E0-0x0096B830

		// Methods
		public override void Enter() {} // 0x0096B670-0x0096B740
		// [IteratorStateMachine] // 0x0064A700-0x0064A770
		private IEnumerator Message() => default; // 0x0096B740-0x0096B7B0
	}

	public class StateSugowazaFirstGetStart : FSMState<UICampMenu, Status> // TypeDefIndex: 6639
	{
		// Fields
		private GameObject sugowazaTextEffectObj_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x0096D1B0-0x0096D1C0 

		// Constructors
		public StateSugowazaFirstGetStart() {} // 0x0096D4C0-0x0096D510

		// Methods
		public override void Enter() {} // 0x0096D1C0-0x0096D380
		// [IteratorStateMachine] // 0x0064A790-0x0064A800
		private IEnumerator FirstMessage() => default; // 0x0096D380-0x0096D3F0
		// [IteratorStateMachine] // 0x0064A800-0x0064A870
		private IEnumerator SecondMessage() => default; // 0x0096D420-0x0096D490
	}

	public class StateSugowazaSecondGetStart : FSMState<UICampMenu, Status> // TypeDefIndex: 6642
	{
		// Fields
		private int openCnt_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x0096DC40-0x0096DC50 

		// Constructors
		public StateSugowazaSecondGetStart() {} // 0x0096DEA0-0x0096DEF0

		// Methods
		public override void Enter() {} // 0x0096DC50-0x0096DD50
		public override void Execute() {} // 0x0096DDC0-0x0096DE00
		// [IteratorStateMachine] // 0x0064A890-0x0064A900
		private IEnumerator Message() => default; // 0x0096DD50-0x0096DDC0
		private void OpenCb() {} // 0x0096DE30-0x0096DEA0
	}

	public class StateFavoOnMessage : FSMState<UICampMenu, Status> // TypeDefIndex: 6644
	{
		// Properties
		public override Status StateID { get => default; } // 0x009688E0-0x009688F0 

		// Constructors
		public StateFavoOnMessage() {} // 0x00968A60-0x00968AB0

		// Methods
		public override void Enter() {} // 0x009688F0-0x009689C0
		// [IteratorStateMachine] // 0x0064A920-0x0064A990
		private IEnumerator Message() => default; // 0x009689C0-0x00968A30
	}

	public class StateFavoOffMessage : FSMState<UICampMenu, Status> // TypeDefIndex: 6646
	{
		// Properties
		public override Status StateID { get => default; } // 0x009684D0-0x009684E0 

		// Constructors
		public StateFavoOffMessage() {} // 0x00968650-0x009686A0

		// Methods
		public override void Enter() {} // 0x009684E0-0x009685B0
		// [IteratorStateMachine] // 0x0064A990-0x0064AA00
		private IEnumerator Message() => default; // 0x009685B0-0x00968620
	}

	private class ItemSelectWindow : BasicListWindow // TypeDefIndex: 6648
	{
		// Fields
		private SubWindowType type_; // 0x84
		private GameObject objRoot_; // 0x88
		private UICampMenu manager_; // 0x90

		// Nested types
		private enum SubWindowType // TypeDefIndex: 6649
		{
			ItemDetail = 0,
			PokemonStatus = 1
		}

		public class WarehouseListItem // TypeDefIndex: 6650
		{
			// Fields
			public int id; // 0x10
			public Const.item.Index itemIndex; // 0x14
			public IItem item; // 0x18
			public int count; // 0x20

			// Constructors
			public WarehouseListItem() {} // 0x00964270-0x00964280
		}

		private class UILocalSelector : UISelectorWarehouse // TypeDefIndex: 6651
		{
			// Fields
			public bool bDeposit; // 0x29

			// Constructors
			public UILocalSelector() {} // 0x009666B0-0x00966720

			// Methods
			protected override void SetupFace() {} // 0x00966F00-0x009672E0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6652
		{
			// Fields
			private WarehouseListItem item_; // 0x18

			// Properties
			public WarehouseListItem Item { get => default; set {} } // 0x00964B90-0x00964BA0 0x00966880-0x00966890

			// Constructors
			public UILocalSelectItem() {} // 0x00966870-0x00966880
		}

		// Constructors
		public ItemSelectWindow() {} // 0x00966140-0x00966150

		// Methods
		public static int GetAllItemCount(Const.item.Index index) => default; // 0x00963C00-0x00963D50
		public void EnableChange_ForType(bool enable) {} // 0x00963D50-0x00963D90
		private List<WarehouseListItem> _getList() => default; // 0x00963D90-0x00964270
		private bool GetEnable(Const.item.Index itemIndex, IPokemonStatus status) => default; // 0x00964280-0x00964670
		public bool CheckListCount() => default; // 0x00964670-0x009646D0
		public bool Init(GameObject objRoot, UICampMenu manager, int defaultIndex = 0 /* Metadata: 0x00612F4E */) => default; // 0x009646D0-0x00964A80
		protected override void _changeFocus() {} // 0x00964A90-0x00964B90
		protected override bool _doUp() => default; // 0x00964BA0-0x00964BE0
		protected override bool _doDown() => default; // 0x00964BE0-0x00964C20
		protected override bool _doLeft() => default; // 0x00964C20-0x00964C60
		protected override bool _doRight() => default; // 0x00964C60-0x00964CA0
		protected override bool _doDecide() => default; // 0x00964CA0-0x00965060
		// [IteratorStateMachine] // 0x0064AA00-0x0064AA70
		private IEnumerator ItemConfirmMessage(Const.item.Index itemIndex, Action<bool> action) => default; // 0x00965060-0x009650E0
		private void UpdateEnable() {} // 0x00965110-0x00965300
		public void StatusUp() {} // 0x00965300-0x00965420
		protected override bool _doCancel() => default; // 0x00965650-0x009658B0
		private void ChangeState(bool enableControl = true /* Metadata: 0x00612F52 */) {} // 0x009658B0-0x009659D0
		public void ChangeState_ToItem() {} // 0x00965BE0-0x00965C70
		protected override bool _onXButton() => default; // 0x00965C70-0x00965CC0
		private void OpenTabWindow(Action cb = null) {} // 0x00965420-0x00965650
		private void CloseTabWindow(Action cb = null) {} // 0x009659E0-0x00965BE0
		public bool DeleteNoBeingItem(Const.item.Index index) => default; // 0x00965CE0-0x00965F50
		public void EnableUpdate() {} // 0x00965F50-0x00966140
	}

	public class StateItemSelect : FSMState<UICampMenu, Status> // TypeDefIndex: 6660
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x00969380-0x00969390 

		// Constructors
		public StateItemSelect() {} // 0x00969A70-0x00969AC0

		// Methods
		public override void Enter() {} // 0x00969390-0x009698F0
		// [IteratorStateMachine] // 0x0064AAF0-0x0064AB60
		private IEnumerator NoItemMessage() => default; // 0x009698F0-0x00969960
		private void OpenAfter() {} // 0x00969990-0x00969A10
		public override void Execute() {} // 0x00969A10-0x00969A70
	}

	private class UIWazaSelectMenu_Camp : UIWazaSelectMenu // TypeDefIndex: 6663
	{
		// Fields
		private GameObject wazaListObj_; // 0x50
		private Const.item.Index selectItemIndex_; // 0x58
		private UICampMenu manager_; // 0x60
		private GameObject[] EffectsObj; // 0x68

		// Nested types
		protected class RenketsuWazaSingleListWindow_Camp : RenketsuWazaSingleListWindow // TypeDefIndex: 6664
		{
			// Fields
			private Const.item.Index selectItemIndex_; // 0x6C

			// Constructors
			public RenketsuWazaSingleListWindow_Camp() {} // 0x00973BD0-0x00973BE0

			// Methods
			public void SetSelectItemIndex(Const.item.Index selectItemIndex) {} // 0x00973B50-0x00973B60
			protected override bool GetEnable(Const.waza.Index wazaIndex) => default; // 0x009754E0-0x009755A0
		}

		private enum EffectType // TypeDefIndex: 6665
		{
			POWER = 0,
			ACCURACY = 1,
			PP = 2
		}

		// Constructors
		public UIWazaSelectMenu_Camp() {} // 0x00974080-0x009740E0

		// Methods
		private void UnFocus() {} // 0x00973540-0x00973770
		protected override void _cbFromWazaListWindow(ListWindowBase.ActionType act) {} // 0x00973770-0x009739F0
		// [IteratorStateMachine] // 0x0064ABA0-0x0064AC10
		private IEnumerator ItemConfirmMessage(Const.item.Index itemIndex, string wazaName, Action<bool> action) => default; // 0x00973A00-0x00973A90
		// [IteratorStateMachine] // 0x0064AC10-0x0064AC80
		public IEnumerator CloseDetailWindow() => default; // 0x0096F3E0-0x0096F450
		// [IteratorStateMachine] // 0x0064AC80-0x0064ACF0
		public IEnumerator CloseListWindow(Action cb = null) => default; // 0x0096F450-0x0096F4D0
		// [IteratorStateMachine] // 0x0064ACF0-0x0064AD60
		public IEnumerator MainFlow_Camp(bool bContinue, Action<Const.waza.Index> cb = null) => default; // 0x0096EF70-0x0096F000
		public static UIWazaSelectMenu_Camp Create() => default; // 0x0096EAA0-0x0096EC50
		public void Init(UICampMenu manager, Const.item.Index selectItemIndex, IPokemonStatus status) {} // 0x0096EC50-0x0096ED70
		public override void Construct() {} // 0x00973B60-0x00973BD0
		// [IteratorStateMachine] // 0x0064AD60-0x0064ADD0
		private IEnumerator EffectPlay(EffectType type, int value) => default; // 0x00973BE0-0x00973C60
		protected override GameObject GetWazaDetailObj() => default; // 0x00973C90-0x00974080
	}

	public class StateItemSelect_Continue : FSMState<UICampMenu, Status> // TypeDefIndex: 6673
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x00969F80-0x00969F90 

		// Constructors
		public StateItemSelect_Continue() {} // 0x0096A2F0-0x0096A340

		// Methods
		public override void Enter() {} // 0x00969F90-0x0096A290
		public override void Execute() {} // 0x0096A290-0x0096A2F0
	}

	public class StateParameterStatusUp : FSMState<UICampMenu, Status> // TypeDefIndex: 6675
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x0096B5F0-0x0096B600 

		// Constructors
		public StateParameterStatusUp() {} // 0x0096B610-0x0096B660

		// Methods
		public override void Enter() {} // 0x0096B600-0x0096B610
	}

	public class StateWazaSelect : FSMState<UICampMenu, Status> // TypeDefIndex: 6676
	{
		// Fields
		private UIWazaSelectMenu_Camp menu_; // 0x18

		// Properties
		public override Status StateID { get => default; } // 0x0096E900-0x0096E910 

		// Constructors
		public StateWazaSelect() {} // 0x0096EDF0-0x0096EE40

		// Methods
		public override void Enter() {} // 0x0096E910-0x0096EAA0
		public override void Exit() {} // 0x0096ED70-0x0096EDF0
	}

	public class StateTemp : FSMState<UICampMenu, Status> // TypeDefIndex: 6677
	{
		// Properties
		public override Status StateID { get => default; } // 0x0096E830-0x0096E840 

		// Constructors
		public StateTemp() {} // 0x0096E8B0-0x0096E900

		// Methods
		public override void Enter() {} // 0x0096E840-0x0096E8B0
	}

	// Constructors
	public UICampMenu() {} // 0x00AC91C0-0x00AC9250
	static UICampMenu() {} // 0x00AC9250-0x00AC92C0

	// Methods
	private void LoadStateCancelSet() {} // 0x00AC5630-0x00AC5650
	private BgState GetBgState(Const.camp.Index index) => default; // 0x00AC5650-0x00AC56A0
	private void SetBgState(Const.camp.Index index, BgState state) {} // 0x00AC56A0-0x00AC56F0
	// [IteratorStateMachine] // 0x00627B20-0x00627B90
	private IEnumerator LOAD_WAIT(Const.camp.Index index, Action cb = null) => default; // 0x00AC56F0-0x00AC5770
	// [IteratorStateMachine] // 0x00627B90-0x00627C00
	private IEnumerator AllBgLoad() => default; // 0x00AC57C0-0x00AC5830
	// [IteratorStateMachine] // 0x00627C00-0x00627C70
	private IEnumerator BgLoad(Const.camp.Index index, Action cb) => default; // 0x00AC5860-0x00AC58E0
	private void SE_CampIn() {} // 0x00AC5910-0x00AC5990
	private void SE_ListChange() {} // 0x00AC5990-0x00AC59A0
	private void OnDestroy() {} // 0x00AC59B0-0x00AC59C0
	// [IteratorStateMachine] // 0x00627C70-0x00627CE0
	public IEnumerator BgRelease_Wait(Action cb) => default; // 0x00AC59C0-0x00AC5A40
	private void BgRelease(Action cb) {} // 0x00AC5A70-0x00AC5B60
	public void DisplayManagerStart() {} // 0x00AC5B60-0x00AC5B70
	public void DisplayManagerEnd() {} // 0x00AC5B80-0x00AC5B90
	public void CloseCommon() {} // 0x00AC5BB0-0x00AC5C80
	public void OpenCommon() {} // 0x00AC5C80-0x00AC5E00
	// [IteratorStateMachine] // 0x00627CE0-0x00627D50
	public IEnumerator FadeOutBGM(BGMChannel channel, Action cb = null) => default; // 0x00AC5E00-0x00AC5E80
	public void CampIndexSet(Const.camp.Index index) {} // 0x00AC5ED0-0x00AC5EE0
	// [IteratorStateMachine] // 0x00627D50-0x00627DC0
	public IEnumerator CursorAppearance(Action<bool> cb = null) => default; // 0x00AC5EF0-0x00AC5F70
	// [IteratorStateMachine] // 0x00627DC0-0x00627E30
	public IEnumerator CursorDecision(Action<bool> cb = null) => default; // 0x00AC5FA0-0x00AC6020
	// [IteratorStateMachine] // 0x00627E30-0x00627EA0
	public IEnumerator CursorClose(Action cb) => default; // 0x00AC6050-0x00AC60D0
	public static UICampMenu Create() => default; // 0x00AC6100-0x00AC6510
	public void Construct() {} // 0x00AC6510-0x00AC6CE0
	public void Init(FlowCamp instance) {} // 0x00AC71D0-0x00AC72D0
	// [IteratorStateMachine] // 0x00627EA0-0x00627F10
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00AC72D0-0x00AC7350
	// [IteratorStateMachine] // 0x00627F10-0x00627F80
	public override IEnumerator MainFlow() => default; // 0x00AC7380-0x00AC73F0
	private void Update() {} // 0x00AC7420-0x00AC7480
	private bool IsCanDisplayMode() => default; // 0x00AC7480-0x00AC74F0
	public void Continue(FlowCamp.ContinueStatus status) {} // 0x00AC74F0-0x00AC7570
	public void InitCampSelectWindow(int defaultIndex = 0 /* Metadata: 0x00612E5A */) {} // 0x00AC76E0-0x00AC7820
	public void InitPokemonSelectWindow() {} // 0x00AC7570-0x00AC76E0
	public void UpdateTabWindow() {} // 0x00AC8290-0x00AC8310
	public void CloseModal() {} // 0x00AC8330-0x00AC8540
	public static void ItemUse(Const.item.Index itemIndex) {} // 0x00AC8A70-0x00AC91C0
}

