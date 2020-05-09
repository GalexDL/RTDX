/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIMainMenu : UIManagerBase // TypeDefIndex: 7054
{
	// Fields
	private static MenuItem lastSelectMenu_; // 0x00
	private XmenuImageManager imageManager_; // 0x20
	private SlideMainMenuWindow slideMenu_; // 0x28
	private GridMainMenuWindow gridMenu_; // 0x30
	private static GameObject regidentObj_; // 0x08
	private CommonScreen commonScreen_; // 0x38
	private CommonSimpleInfoWindow infoWindow_; // 0x40
	private ModeType mode_; // 0x48
	private ViewType view_; // 0x4C
	private bool saveViewMode_; // 0x50
	private ActionType act_; // 0x54
	private GameObject objCaption_; // 0x58
	private GameObject objGuideMessage_; // 0x60
	private LoadScreenDisplay loadScreen_; // 0x68
	private int[] aMessageGuideIndex_; // 0x70
	private static string[] aMoveAction; // 0x10

	// Properties
	public ModeType Mode { get => default; } // 0x009473C0-0x009473D0 

	// Nested types
	public enum MenuItem // TypeDefIndex: 7055
	{
		None = -1,
		Start = 0,
		Continue = 1,
		Perippa = 2,
		Mail = 3,
		Name = 4,
		Erase = 5,
		Item = 6,
		Party = 7,
		Quest = 8,
		Hensei = 9,
		Rest = 10,
		Etc = 11,
		DgItem = 12,
		DgParty = 13,
		DgWaza = 14,
		DgPartyOrder = 15,
		DgFoot = 16,
		DgLook = 17,
		DgQuest = 18,
		DgRest = 19,
		DgEtc = 20,
		DgGiveup = 21,
		Debug = 22,
		Restart = 23,
		Revival = 24,
		WaitAid = 25,
		SceneDebug = 26,
		Dummy1 = 27,
		Dummy2 = 28,
		Dummy3 = 29,
		DgLeader = 30,
		RemoveFromMember = 31,
		ChangeLog = 32,
		DebugSave = 33,
		DebugLoad = 34,
		PerippaaRestart = 35,
		NumMenuItem = 36
	}

	public class MenuParam // TypeDefIndex: 7056
	{
		// Fields
		public MenuItem menuItem; // 0x10
		public bool bDisable; // 0x14
		public bool rescueIcon; // 0x15

		// Constructors
		public MenuParam() {} // 0x00948400-0x00948430
	}

	private class PageControlWindow : UIWindowBase // TypeDefIndex: 7057
	{
		// Fields
		private string[] tagPointList; // 0x30
		private int numPage_; // 0x38
		private int topIndex_; // 0x3C

		// Constructors
		public PageControlWindow() {} // 0x0094D160-0x0094D7E0

		// Methods
		public void Init(GameObject root, int numPage, int initPage = 0 /* Metadata: 0x0061334D */) {} // 0x0094CCC0-0x0094CF80
		public void SetPage(int nPage) {} // 0x0094CF80-0x0094D0D0
		public void Press(bool bRight) {} // 0x0094D0D0-0x0094D160
	}

	public class XmenuImageManager // TypeDefIndex: 7058
	{
		// Fields
		private static string[] iconSprites; // 0x00
		private Sprite[] aSprite_; // 0x10

		// Constructors
		public XmenuImageManager() {} // 0x00947310-0x00947370
		static XmenuImageManager() {} // 0x0094F210-0x009500F0

		// Methods
		public void Add(int idx) {} // 0x00948430-0x009485E0
		public Sprite Get(int idx) => default; // 0x0094C520-0x0094C600
	}

	public class MainMenuWindow : BasicMenuWindow // TypeDefIndex: 7059
	{
		// Fields
		protected List<MenuParam> aMenuParam_; // 0x48

		// Constructors
		public MainMenuWindow() {} // 0x0094BBB0-0x0094BBC0

		// Methods
		public virtual void OnStart() {} // 0x0094C610-0x0094C620
		protected override bool _doYButton() => default; // 0x0094C620-0x0094C640
		protected override bool _doBButton() => default; // 0x0094C640-0x0094C660
		public virtual void ResetFocus(int itemId) {} // 0x0094B530-0x0094B580
		protected void _setMenuRotation() {} // 0x0094B620-0x0094B780
		protected virtual void _setMenuFaceRotation(UISelectorBase sel) {} // 0x0094C660-0x0094CA50
		protected virtual void _getRotate(GameObject obj, int index) {} // 0x0094CA60-0x0094CA70
		protected virtual int _menuItemIndexOf(MenuItem item) => default; // 0x0094CA70-0x0094CBA0
	}

	private class LocalMenuSelector : UISelectorBase // TypeDefIndex: 7062
	{
		// Fields
		private XmenuImageManager imageMgr_; // 0x30

		// Properties
		public XmenuImageManager ImageMgr { set {} } // 0x0094B610-0x0094B620

		// Constructors
		public LocalMenuSelector() {} // 0x0094B5A0-0x0094B610

		// Methods
		protected override void SetupFace() {} // 0x0094C240-0x0094C520
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7063
	{
		// Fields
		private bool rescueIconFlag_; // 0x16

		// Properties
		public bool rescueIconFlag { get => default; set {} } // 0x0094C600-0x0094C610 0x0094B590-0x0094B5A0

		// Constructors
		public UILocalSelectItem() {} // 0x0094B580-0x0094B590
	}

	private class SlideMainMenuWindow : MainMenuWindow // TypeDefIndex: 7064
	{
		// Fields
		private PageControlWindow objPageControl_; // 0x50
		private static string[] aSelectorToken; // 0x00
		private static string[] aChangerToken; // 0x08
		private List<int> aChangeItemIds_; // 0x58
		private bool bWrap_; // 0x60
		private int center_; // 0x64
		private bool bExecuteSwitchView_; // 0x68
		private string reqAnimation_; // 0x70
		private int reqItemIndex_; // 0x78

		// Constructors
		public SlideMainMenuWindow() {} // 0x009472F0-0x00947300
		static SlideMainMenuWindow() {} // 0x0094E1E0-0x0094E7B0

		// Methods
		public void Init(GameObject root, List<MenuParam> aMenuParam, MenuItem defaultItem, XmenuImageManager imageMgr) {} // 0x009485E0-0x00948D20
		public void Term() {} // 0x009473B0-0x009473C0
		private void _visibleViewSelector() {} // 0x0094D870-0x0094DA50
		public override void ResetFocus(int itemId) {} // 0x0094DA50-0x0094DC90
		private void _copyRotation(GameObject dst, GameObject src) {} // 0x0094DC90-0x0094DD80
		public override void OnStart() {} // 0x0094DD80-0x0094DDB0
		private void _openCenter(int center) {} // 0x0094DDB0-0x0094DED0
		private void _killSwitchView() {} // 0x0094D860-0x0094D870
		// [IteratorStateMachine] // 0x0064CE10-0x0064CE80
		private IEnumerator _switchView2(LocalMenuSelector sel) => default; // 0x0094D7E0-0x0094D860
		private void _doChange2(int itemIndex, string sAction) {} // 0x0094DF00-0x0094DF20
		protected override void _doInput() {} // 0x0094DF20-0x0094E000
		protected override bool _doUp() => default; // 0x0094E000-0x0094E010
		protected override bool _doDown() => default; // 0x0094E010-0x0094E020
		protected override bool _doRight() => default; // 0x0094E020-0x0094E0F0
		protected override bool _doLeft() => default; // 0x0094E0F0-0x0094E1C0
		protected override bool _doRButton() => default; // 0x0094E1C0-0x0094E1D0
		protected override bool _doLButton() => default; // 0x0094E1D0-0x0094E1E0
	}

	public class GridMainMenuWindow : MainMenuWindow // TypeDefIndex: 7067
	{
		// Fields
		private static string[] aItemToken; // 0x00
		protected int currentSelectorId_; // 0x50
		protected List<Quaternion> aMenuFaceRotate_; // 0x58

		// Constructors
		public GridMainMenuWindow() {} // 0x00947300-0x00947310
		static GridMainMenuWindow() {} // 0x0094BBC0-0x0094C240

		// Methods
		protected override void _doInput() {} // 0x0094B370-0x0094B450
		protected override bool _doLeft() => default; // 0x0094B450-0x0094B470
		protected override bool _doRight() => default; // 0x0094B470-0x0094B490
		protected override bool _doRButton() => default; // 0x0094B490-0x0094B4B0
		protected override bool _doLButton() => default; // 0x0094B4B0-0x0094B4D0
		public override void ResetFocus(int itemId) {} // 0x0094B4D0-0x0094B530
		public void Init(GameObject root, List<MenuParam> aMenuParam, MenuItem defaultItem, XmenuImageManager imageMgr) {} // 0x00948D20-0x009492A0
		protected override void _getRotate(GameObject obj, int index) {} // 0x0094B780-0x0094B830
		public void OnChangeFocus() {} // 0x00949D00-0x0094A080
		public void InitFocus() {} // 0x0094B830-0x0094BBB0
	}

	public enum ModeType // TypeDefIndex: 7068
	{
		Main = 0,
		Ground = 1,
		Dungeon = 2,
		DungeonWaypoint = 3
	}

	public enum ViewType // TypeDefIndex: 7069
	{
		Slide = 0,
		Grid = 1,
		Hold = 2
	}

	public enum ActionType // TypeDefIndex: 7070
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	// Constructors
	public UIMainMenu() {} // 0x0094A440-0x0094A4A0
	static UIMainMenu() {} // 0x0094A4A0-0x0094A600

	// Methods
	public static MenuItem GetLastSelectMenu() => default; // 0x00946C00-0x00946C70
	public static void SetLastSelectMenu(MenuItem menu) {} // 0x00946C70-0x00946CE0
	public static UIMainMenu CreateRegident() => default; // 0x00946CE0-0x00946FF0
	public static void DestroyRegident() {} // 0x00946FF0-0x00947100
	public static UIMainMenu Create() => default; // 0x00947100-0x009471B0
	public void Construct() {} // 0x009471B0-0x009472F0
	public void Destruct() {} // 0x00947370-0x009473B0
	public void Init(ModeType mode, MenuItem defaultItem = MenuItem.None /* Metadata: 0x006132AD */, ViewType view = ViewType.Hold /* Metadata: 0x006132B1 */) {} // 0x009473D0-0x00948400
	public void SetLoadMenu(LoadScreenDisplay mng) {} // 0x009492A0-0x009492B0
	// [IteratorStateMachine] // 0x00629CB0-0x00629D20
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x009492B0-0x00949330
	// [IteratorStateMachine] // 0x00629D20-0x00629D90
	public IEnumerator InterruptPopup(Action cb) => default; // 0x00949360-0x009493E0
	public void Continue() {} // 0x00949410-0x009494D0
	public MenuItem GetSelectMenu() => default; // 0x009494D0-0x00949520
	public ViewType GetViewType() => default; // 0x00949520-0x00949530
	public bool GetEnable() => default; // 0x00949530-0x00949580
	public void SetEnable(bool setBool) {} // 0x00949580-0x009495C0
	private void _setCaption() {} // 0x009495C0-0x009497D0
	private void _moveCaption() {} // 0x009497D0-0x009498E0
	private void _cbFromGridMenu(ListWindowBase.ActionType act) {} // 0x009498E0-0x00949D00
	private void _cbFromSlideMenu(ListWindowBase.ActionType act) {} // 0x0094A080-0x0094A400
	private void Start() {} // 0x0094A400-0x0094A410
	private void Update() {} // 0x0094A410-0x0094A440
}

