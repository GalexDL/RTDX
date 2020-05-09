/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWorldMapMenu : UIManagerBase // TypeDefIndex: 7925
{
	// Fields
	private WorldListWindow listWindow_; // 0x20
	private DungeonDetailWindow dungeonDetailWindow_; // 0x28
	private ListDetailWindow detailWindow_; // 0x30
	private RequestListDetailWindow requestListWindow_; // 0x38
	private KyoutekiWeakInfoWindow kyoutekiWeakInfoWindow_; // 0x40
	private UIWorldMapSet mapBg_; // 0x48
	private CommonScreen commonScreen_; // 0x50
	private ActionType act_; // 0x58
	private static bool bLoadPokemonAppearList_; // 0x00
	private static HashSet<int> hashSetAcquaintedHonke; // 0x08
	private static HashSet<int> hashSetWarehouseExistHonke; // 0x10
	private static HashSet<int> hashSetWarehouseExistIndex; // 0x18
	private string scenarioDgOrganizationSymbol_; // 0x60
	private bool bHaveMyRescue_; // 0x68
	private bool bHaveFriendRescue_; // 0x69
	private bool bExistBonusDungeon_; // 0x6A
	private bool bExistReliefDungeon_; // 0x6B
	private bool bAnounceFilter_; // 0x6C

	// Properties
	public bool HaveMyResuce { get => default; } // 0x00B2B260-0x00B2B270 
	public bool HaveFriendResuce { get => default; } // 0x00B2B270-0x00B2B280 

	// Nested types
	public class WorldListWindow : BasicListWindow // TypeDefIndex: 7926
	{
		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7927
		{
			// Fields
			private GameData.AreaInfo area_; // 0x18

			// Properties
			public GameData.AreaInfo Item { get => default; set {} } // 0x00B2B040-0x00B2B050 0x00B37520-0x00B37530

			// Constructors
			public UILocalSelectItem() {} // 0x00B37510-0x00B37520
		}

		protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7928
		{
			// Fields
			private bool syncIcon_; // 0x29

			// Properties
			public bool SyncIcon { get => default; set {} } // 0x00B37530-0x00B37540 0x00B37260-0x00B37270

			// Constructors
			public UILocalSelector() {} // 0x00B373E0-0x00B37450

			// Methods
			protected override void SetupFace() {} // 0x00B37540-0x00B38280
		}

		// Constructors
		public WorldListWindow() {} // 0x00B2A320-0x00B2A330

		// Methods
		public void Init(GameObject objRoot, List<GameData.AreaInfo> list) {} // 0x00B2CA70-0x00B2CC00
		protected override void _doInput() {} // 0x00B37000-0x00B370B0
		protected override bool _onXButton() => default; // 0x00B370B0-0x00B370D0
		protected override bool _onYButton() => default; // 0x00B370D0-0x00B370F0
		private void resetIconAnimation() {} // 0x00B370F0-0x00B37260
		protected override void _changePage() {} // 0x00B37270-0x00B372A0
	}

	private class DungeonDetailWindow : UIWindowBase // TypeDefIndex: 7931
	{
		// Constructors
		public DungeonDetailWindow() {} // 0x00B2A330-0x00B2A340

		// Methods
		public void UpdateWindow(GameData.AreaInfo status) {} // 0x00B2DF10-0x00B2E770
	}

	private class ListDetailWindow : UIWindowBase // TypeDefIndex: 7932
	{
		// Fields
		private UIControlTMP textCaption_; // 0x30
		private BasicListWindow listDetail_; // 0x38
		private UIScrollView scScrollView_; // 0x40
		private GameObject objScrollContents_; // 0x48
		private bool bStateVisible_; // 0x50
		private bool bRunning_; // 0x51
		private bool bUpdateRequest_; // 0x52

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7933
		{
			// Fields
			private Const.creature.Index creatureIndex_; // 0x18
			private bool bSecret_; // 0x1C
			private bool bExistWharehouse_; // 0x1D

			// Properties
			public Const.creature.Index Item { get => default; set {} } // 0x00B35A80-0x00B35A90 0x00B34C90-0x00B34CA0
			public bool Secret { get => default; set {} } // 0x00B35A90-0x00B35AA0 0x00B34CA0-0x00B34CB0
			public bool ExistWarehouse { get => default; set {} } // 0x00B35AA0-0x00B35AB0 0x00B34CB0-0x00B34CC0

			// Constructors
			public UILocalSelectItem() {} // 0x00B34C80-0x00B34C90
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 7934
		{
			// Constructors
			public UILocalSelector() {} // 0x00B34A40-0x00B34AB0

			// Methods
			protected override void SetupFace() {} // 0x00B35AB0-0x00B35AF0
			public void SetupFaceTrue() {} // 0x00B35390-0x00B358F0
		}

		// Constructors
		public ListDetailWindow() {} // 0x00B2A340-0x00B2A350

		// Methods
		public override void Visible(bool bEnable) {} // 0x00B33BE0-0x00B33C30
		// [IteratorStateMachine] // 0x00652D90-0x00652E00
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00B33C30-0x00B33CB0
		// [IteratorStateMachine] // 0x00652E00-0x00652E70
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00B33CE0-0x00B33D60
		protected override void _doUpdate() {} // 0x00B33D90-0x00B33E30
		public override void Init(GameObject detail) {} // 0x00B33ED0-0x00B341A0
		public void setTextCaption(string sText) {} // 0x00B341A0-0x00B34260
		public void setListDetail(List<WildInfo> wilds, Const.creature.Index superPokemon = Const.creature.Index.NONE /* Metadata: 0x00613BD3 */) {} // 0x00B2E770-0x00B2EA50
		// [IteratorStateMachine] // 0x00652E70-0x00652EE0
		private IEnumerator UpdateListsLoop() => default; // 0x00B34830-0x00B348A0
		public void StartUpdateFlow() {} // 0x00B317C0-0x00B318B0
		// [IteratorStateMachine] // 0x00652EE0-0x00652F50
		public IEnumerator WaitEnd() => default; // 0x00B318B0-0x00B31920
		private void UpdateSuperPokemon(GameObject faceTop, Const.creature.Index pokemonIndex) {} // 0x00B34270-0x00B34830
		public void updateScrollView() {} // 0x00B33E30-0x00B33ED0
	}

	private class ListRequestWindow : UIWindowBase // TypeDefIndex: 7941
	{
		// Fields
		private UIControlTMP textCaption_; // 0x30
		private BasicListWindow listDetail_; // 0x38
		private UIScrollView scScrollView_; // 0x40
		private GameObject objScrollContents_; // 0x48
		private float scrollContentsScale_; // 0x50

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7942
		{
			// Fields
			private IJobTicket questInfo_; // 0x18
			private bool bForceDisableExecution_; // 0x20

			// Properties
			public IJobTicket Item { get => default; set {} } // 0x00B36430-0x00B36440 0x00B36410-0x00B36420
			public bool ForceDisableExecution { get => default; set {} } // 0x00B36440-0x00B36450 0x00B36420-0x00B36430

			// Constructors
			public UILocalSelectItem() {} // 0x00B36400-0x00B36410
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 7943
		{
			// Fields
			protected QuestDetailWindow detailWindow_; // 0x30
			protected RescueDetailWindow rescueDetailWindow_; // 0x38

			// Constructors
			public UILocalSelector() {} // 0x00B362C0-0x00B36330

			// Methods
			protected override void SetupFace() {} // 0x00B36450-0x00B36860
		}

		// Constructors
		public ListRequestWindow() {} // 0x00B36170-0x00B36180

		// Methods
		public override void Init(GameObject detail) {} // 0x00B35AF0-0x00B35D70
		public void setTextCaption(string sText) {} // 0x00B35D70-0x00B35E30
		public void setListDetail(List<IJobTicket> questList, bool bForceDisableExecution) {} // 0x00B35E30-0x00B360C0
		public void updateScrollView() {} // 0x00B360D0-0x00B36170
	}

	private class RequestListDetailWindow : UIWindowBase // TypeDefIndex: 7946
	{
		// Fields
		private ListRequestWindow listWindow_; // 0x30
		private CallbackAction callbackFunc_; // 0x38

		// Nested types
		public enum ActionType // TypeDefIndex: 7947
		{
			Cancel = 0
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 7948; 0x00B36960-0x00B36D10

		// Constructors
		public RequestListDetailWindow() {} // 0x00B2A350-0x00B2A360

		// Methods
		public void ResetActionListener() {} // 0x00B2EDE0-0x00B2EDF0
		public void RegisterActionListener(CallbackAction cb) {} // 0x00B2EE00-0x00B2EEF0
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00B36860-0x00B36950
		public void callAction(ActionType action) {} // 0x00B36950-0x00B36960
		protected override void _doUpdate() {} // 0x00B36D10-0x00B36DC0
		protected void _doInput() {} // 0x00B36DC0-0x00B36E90
		public void InitRequestList(List<IJobTicket> list, bool bForceDisableExecution) {} // 0x00B2EBA0-0x00B2EC50
	}

	private class KyoutekiWeakInfoWindow : UIWindowBase // TypeDefIndex: 7949
	{
		// Fields
		private CallbackAction callbackFunc_; // 0x30
		private string[] sTokens; // 0x38
		private string[] sIconTokens; // 0x40
		private string[] sIconNameTokens; // 0x48

		// Nested types
		public enum ActionType // TypeDefIndex: 7950
		{
			Cancel = 0
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 7951; 0x00B336B0-0x00B33A60

		// Constructors
		public KyoutekiWeakInfoWindow() {} // 0x00B2A360-0x00B2AC70

		// Methods
		public void ResetActionListener() {} // 0x00B335A0-0x00B335B0
		public void RegisterActionListener(CallbackAction cb) {} // 0x00B2CC10-0x00B2CD00
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00B335B0-0x00B336A0
		public void callAction(ActionType action) {} // 0x00B336A0-0x00B336B0
		protected override void _doUpdate() {} // 0x00B33A60-0x00B33A70
		protected void _doInput() {} // 0x00B33A70-0x00B33B40
		public void SetupFace(Const.creature.Index index, List<Const.pokemon.Type> list) {} // 0x00B2F130-0x00B2F670
	}

	public enum ActionType // TypeDefIndex: 7952
	{
		None = 0,
		Cancel = 1,
		Decide = 2
	}

	public class WildInfo // TypeDefIndex: 7953
	{
		// Fields
		public Const.creature.Index m_PokemonIndex; // 0x10
		public bool m_bAppear; // 0x14
		public bool m_bExistWarehouse; // 0x15
		public int m_SortKey; // 0x18

		// Constructors
		public WildInfo() {} // 0x00B334D0-0x00B334E0

		// Methods
		public void Set(Const.creature.Index pokemonIndex, bool bAppear, bool bForceDisappear) {} // 0x00B334E0-0x00B335A0
	}

	public class AreaInfo : GameData.AreaInfo // TypeDefIndex: 7954
	{
		// Fields
		public List<IJobTicket> aJobTicket; // 0x48
		public List<WildInfo> wildList_; // 0x50
		public bool m_bGengaaException; // 0x58
		public bool m_bSubScenarioException; // 0x59

		// Constructors
		public AreaInfo() {} // 0x00B2C440-0x00B2C4B0

		// Methods
		public new void Init(Const.dungeon.Index dgIndex) {} // 0x00B2C4B0-0x00B2CA70
	}

	[Serializable]
	public class SaveData // TypeDefIndex: 7955
	{
		// Fields
		private const int NUM_DUNGEON = 100; // Metadata: 0x00613BEB
		[SerializeField] // 0x006187E0-0x006187F0
		private bool[] bAdvertised; // 0x10

		// Constructors
		public SaveData() {} // 0x00B36F90-0x00B36FF0

		// Methods
		public void Reset() {} // 0x00B36F30-0x00B36F90
		public void SetAdvertised(Const.dungeon.Index dgIndex) {} // 0x00B32590-0x00B325E0
		public bool IsAdvertised(Const.dungeon.Index dgIndex) => default; // 0x00B32530-0x00B32590
	}

	// Constructors
	public UIWorldMapMenu() {} // 0x00B2FDB0-0x00B2FDC0
	static UIWorldMapMenu() {} // 0x00B2FDC0-0x00B2FDD0

	// Methods
	private void Start() {} // 0x00B29E70-0x00B29E80
	private void Update() {} // 0x00B29E80-0x00B29F00
	public static UIWorldMapMenu Create() => default; // 0x00B29F00-0x00B2A130
	public void Construct() {} // 0x00B2A130-0x00B2A320
	public void Destruct() {} // 0x00B2ADD0-0x00B2AF10
	public GameData.AreaInfo GetSelectDungeonAreaInfo() => default; // 0x00B2AF90-0x00B2B040
	private static int WildCompare(WildInfo a, WildInfo b) => default; // 0x00B2B050-0x00B2B060
	private static int AreaCompare(GameData.AreaInfo a, GameData.AreaInfo b) => default; // 0x00B2B060-0x00B2B0B0
	private static int AreaRescueCompare(GameData.AreaInfo a, GameData.AreaInfo b) => default; // 0x00B2B0B0-0x00B2B0E0
	private static int RequestTicketCompare(IJobTicket a, IJobTicket b) => default; // 0x00B2B0E0-0x00B2B1A0
	private static int RescueTicketCompare(IJobTicket a, IJobTicket b) => default; // 0x00B2B1A0-0x00B2B260
	public void Init(string scenarioDgOrganizationSymbol) {} // 0x00B2B280-0x00B2C440
	// [IteratorStateMachine] // 0x0062F510-0x0062F580
	public IEnumerator Newarrival_Flow(Action cb = null) => default; // 0x00B2CD00-0x00B2CD80
	// [IteratorStateMachine] // 0x0062F580-0x0062F5F0
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00B2CDB0-0x00B2CE30
	// [IteratorStateMachine] // 0x0062F5F0-0x0062F660
	private IEnumerator decideAction(ActionType act) => default; // 0x00B2CE60-0x00B2CEE0
	public void Continue() {} // 0x00B2CF10-0x00B2CF20
	// [IteratorStateMachine] // 0x0062F660-0x0062F6D0
	public IEnumerator Departure_Flow(Action cb = null) => default; // 0x00B2CF20-0x00B2CFA0
	private void _cbFromWorldListWindow(ListWindowBase.ActionType act) {} // 0x00B2CFD0-0x00B2D4B0
	private void _OpenWorldSelect() {} // 0x00B2DB50-0x00B2DCA0
	// [IteratorStateMachine] // 0x0062F6D0-0x0062F740
	private IEnumerator WaitFadein(float fSec, Action cb = null) => default; // 0x00B2DCA0-0x00B2DD20
	// [IteratorStateMachine] // 0x0062F740-0x0062F7B0
	private IEnumerator AnounceStartWorldSelect(Action cb = null) => default; // 0x00B2DD50-0x00B2DDD0
	private void _OnStartWorldSelect() {} // 0x00B2DE00-0x00B2DF10
	private void _updateDetail(bool bSetButtonGuide, bool bQuick = false /* Metadata: 0x00613BCE */) {} // 0x00B2D5C0-0x00B2D7E0
	private void _onRequestListView(List<IJobTicket> list, bool bForceDisableExecution) {} // 0x00B2D7E0-0x00B2DA20
	private void _onPreStartRequestListView() {} // 0x00B2EC50-0x00B2ED40
	private void _onStartRequestListView() {} // 0x00B2ED40-0x00B2EDE0
	private void _cbFromRequestListWindow(RequestListDetailWindow.ActionType act) {} // 0x00B2EEF0-0x00B2F0F0
	private void _onEndRequestListView() {} // 0x00B2F0F0-0x00B2F130
	private void _onKyoutekiWeakInfoView(Const.creature.Index kyoutekiIndex) {} // 0x00B2DA20-0x00B2DB50
	private void _cbFromKyoutekiWeakInfoWindow(KyoutekiWeakInfoWindow.ActionType act) {} // 0x00B2F670-0x00B2F770
	private void _onEndKyoutekiWeakInfoView() {} // 0x00B2F770-0x00B2F7C0
	private void _onGotoDungeon_start() {} // 0x00B2D4B0-0x00B2D5C0
	// [IteratorStateMachine] // 0x0062F7B0-0x0062F820
	private IEnumerator _anounceFilter(bool bOpen, Action<bool> cb = null) => default; // 0x00B2F840-0x00B2F8D0
	// [IteratorStateMachine] // 0x0062F820-0x0062F890
	private IEnumerator _noticeMessage(TextId textId, Action cb = null) => default; // 0x00B2F900-0x00B2F980
	// [IteratorStateMachine] // 0x0062F890-0x0062F900
	private IEnumerator _askMessage(TextId textId, MessageWindow.AskParam askParam, int presetPosition = 0 /* Metadata: 0x00613BCF */, Action<int> cb = null) => default; // 0x00B2F9B0-0x00B2FA40
	// [IteratorStateMachine] // 0x0062F900-0x0062F970
	private IEnumerator AnounceGotoDungeon(Action<bool> cb = null) => default; // 0x00B2F7C0-0x00B2F840
	private void _onGotoDungeon_end(bool bDecide) {} // 0x00B2FAA0-0x00B2FBB0
	private void _onWorldMapView_start() {} // 0x00B2FBB0-0x00B2FD00
	private void _onWorldMapView_end() {} // 0x00B2FD80-0x00B2FDB0
}

