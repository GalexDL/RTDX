/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Const.dictionary;
using Const.dictionaryCategory;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDictionary : UIManagerBase // TypeDefIndex: 6740
{
	// Fields
	private List<LinkHistoryData> linkHistory_; // 0x20
	private const int maxJumpCount = 4; // Metadata: 0x00613004
	private GameObject mainObj_; // 0x28
	private GameObject focusObj_; // 0x30
	private Const.dictionary.Index startIndex_; // 0x38
	private UILinkFocus linkFocus_; // 0x40
	public FiniteStateMachine<UIDictionary, Status> FSM; // 0x48
	public bool bCancel_; // 0x50
	private Status status_; // 0x54
	private WallPaper wallPaper_; // 0x58
	private TangoListWindow wordListWindow_; // 0x60
	private ItemExplanWindow itemExplainWindow_; // 0x68
	private bool dictionaryPartsIni; // 0x70
	private UIControlTMP linkStartTmp_; // 0x78
	private bool linkStart_; // 0x80
	private List<UIControlTMP> tmpList_; // 0x88
	private LinkMenuState linkMenuState_; // 0x90

	// Properties
	public int NowJumpCount { get => default; } // 0x00B12380-0x00B123E0 
	private UILinkFocus LinkFocus_ { get => default; } // 0x00B127B0-0x00B12820 
	private UIControlTMP ExplainDetails { get => default; } // 0x00B14640-0x00B14650 
	public LinkMenuState LinkMenuState_ { get => default; set {} } // 0x00B15080-0x00B15090 0x00B15090-0x00B150A0

	// Nested types
	private class LinkHistoryData // TypeDefIndex: 6741
	{
		// Fields
		public uint hash; // 0x10
		public int cursorIndex; // 0x14
		public int viewStartIndex; // 0x18
		public int selectRefineType; // 0x1C
		public bool bCategorySort; // 0x20

		// Constructors
		public LinkHistoryData() {} // 0x00B14B70-0x00B14B80
	}

	public enum Status // TypeDefIndex: 6742
	{
		WordSelect = 0,
		WordSelect_Continue = 1,
		FocusSelect = 2,
		FocusSelect_First = 3,
		FocusSelect_First_MultiWindow = 4,
		WordSelect_Jump = 5,
		End = 6
	}

	public class WallPaper : UIWindowBase // TypeDefIndex: 6743
	{
		// Constructors
		public WallPaper() {} // 0x00B13E10-0x00B13E20
	}

	public class TangoListWindow : BasicListWindow // TypeDefIndex: 6744
	{
		// Fields
		private bool bItemCategorySort_; // 0x84
		private BeingAllNameTypes[] beingNames_JP; // 0x88
		private BeingAllNameTypes[] beingNames_Overseas; // 0x90
		private Regex[] kindPattarns_JP; // 0x98
		private Regex[] kindPattarns_Overseas; // 0xA0
		private SubMenuSelectItem[] nameSelectArray_JP; // 0xA8
		private SubMenuSelectItem[] nameSelectArray_Overseas; // 0xB0
		private List<WordItem>[,] refinePartList_; // 0xB8
		private int[] selectRefineTypes_; // 0xC0
		private UIDictionary manager_; // 0xC8
		private int[] viewStartIndices_; // 0xD0
		private int[] cursorIndices_; // 0xD8
		private GameObject obj_; // 0xE0
		private List<WordItem> wordList_; // 0xE8
		private Const.dictionaryCategory.Index nowCategoryType_; // 0xF0
		private Dictionary<Const.dictionaryCategory.Index, List<WordItem>> categoryWordListDictionary_; // 0xF8
		private Dictionary<Const.dictionaryCategory.Index, int> categoryTopIndex; // 0x100
		private UIControlTMPSetter categorySetter_; // 0x108
		private bool[,] nameList_; // 0x110
		private GameObject LButton_; // 0x118
		private GameObject RButton_; // 0x120
		private bool bPlayLAnim_; // 0x128
		private bool bPlayRAnim_; // 0x129
		private UIControlTMPSetter sortRefineName_; // 0x130
		private GameObject refineWord_; // 0x138
		private UIControlTMPSetter buttonGuideSetter_; // 0x140
		private UIBasicList basicList; // 0x148
		private UIControlTMP upperTmp_; // 0x150
		private UIControlTMP bottomTmp_; // 0x158
		private Const.dictionaryCategory.Index[] categoryIndices_normal; // 0x160
		private Const.dictionaryCategory.Index[] categoryIndices_category; // 0x168

		// Properties
		public bool ItemCategorySortFlag { get => default; } // 0x00B14C20-0x00B14C50 
		private Regex[] kindPattarns { get => default; } // 0x00B18440-0x00B184D0 
		private SubMenuSelectItem[] nameSelectArray { get => default; } // 0x00B184D0-0x00B18560 
		public int SelectRefineType { get => default; set {} } // 0x00B14BD0-0x00B14C20 0x00B18DD0-0x00B18E20
		public int ViewStartIndex { get => default; set {} } // 0x00B14B80-0x00B14BD0 0x00B18F30-0x00B18F80
		public int CursorIndex { get => default; set {} } // 0x00B18FF0-0x00B19040 0x00B19040-0x00B19090
		private List<WordItem> WordList { get => default; set {} } // 0x00B19090-0x00B19260 0x00B192C0-0x00B192D0
		private List<WordItem> WordList_CategoryPartDefault { get => default; } // 0x00B19260-0x00B192C0 
		private Const.dictionaryCategory.Index NowCategoryType { get => default; set {} } // 0x00B17ED0-0x00B17EE0 0x00B192D0-0x00B192E0

		// Nested types
		private enum BeingAllNameTypes // TypeDefIndex: 6745
		{
			a = 0,
			k = 1,
			s = 2,
			t = 3,
			n = 4,
			h = 5,
			m = 6,
			y = 7,
			r = 8,
			w = 9,
			ABCDEFG = 10,
			HIJKLMN = 11,
			OPQRSTU = 12,
			VWXYZ = 13,
			NUMBER = 14,
			Other = 15,
			MAX = 16
		}

		private class SubMenuSelectItem // TypeDefIndex: 6746
		{
			// Fields
			public CommonSortRefineWindow.ListItem.Label label; // 0x10

			// Constructors
			public SubMenuSelectItem() {} // 0x00B1C7A0-0x00B1C7B0
		}

		public class WordItem // TypeDefIndex: 6747
		{
			// Fields
			public int slotID; // 0x10
			public Const.dictionary.Index dictinaryIndex; // 0x14
			public DictionaryMenuTool.DictionaryData dictionaryData; // 0x18

			// Constructors
			public WordItem() {} // 0x00B194E0-0x00B194F0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6748
		{
			// Fields
			private WordItem item_; // 0x18

			// Properties
			public WordItem Item { get => default; set {} } // 0x00B14C50-0x00B14C60 0x00B1C890-0x00B1C8A0

			// Constructors
			public UILocalSelectItem() {} // 0x00B1C880-0x00B1C890
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6749
		{
			// Constructors
			public UILocalSelector() {} // 0x00B1CA50-0x00B1CAC0

			// Methods
			protected override void SetupFace() {} // 0x00B1D370-0x00B1D690
		}

		// Constructors
		public TangoListWindow() {} // 0x00B12820-0x00B13E00

		// Methods
		private List<WordItem> ItemCategorySort(List<WordItem> list) => default; // 0x00B17EE0-0x00B18160
		private BeingAllNameTypes[] GetBeingAllNameTypesArray() => default; // 0x00B18160-0x00B181F0
		private int GetNameTypesMax() => default; // 0x00B181F0-0x00B18290
		private BeingAllNameTypes GetBeingAllNameTypes(int select) => default; // 0x00B18290-0x00B18350
		private int GetBeingAllNameTypes_Reverse(BeingAllNameTypes type) => default; // 0x00B18350-0x00B18440
		private bool[,] GetBeingNameInitial() => default; // 0x00B18560-0x00B18D50
		private void ResetRefineTypes() {} // 0x00B18D50-0x00B18DD0
		public void ResetRefineType() {} // 0x00B122D0-0x00B12320
		// [IteratorStateMachine] // 0x0064B330-0x0064B3A0
		public IEnumerator _sortRefineSelect(bool evolutionOk = false /* Metadata: 0x00613024 */) => default; // 0x00B18E20-0x00B18E90
		private void ResetViewStartIndices() {} // 0x00B18EC0-0x00B18F30
		private void ResetCursorIndices() {} // 0x00B18F80-0x00B18FF0
		private void UpdateCategorySetter() {} // 0x00B192E0-0x00B193C0
		public void Init(GameObject obj, UIDictionary manager, bool linkStart, int defaultIndex = 0 /* Metadata: 0x00613025 */) {} // 0x00B16E60-0x00B17D50
		private void AllReset() {} // 0x00B193C0-0x00B194E0
		private void UpdateButtonGuide() {} // 0x00B19BC0-0x00B19CB0
		private void UpperTmpUpdate(WordItem item) {} // 0x00B19CB0-0x00B19D40
		private void BottomTmpUpdate(WordItem item) {} // 0x00B19D40-0x00B19DD0
		private void ListUpdate(List<WordItem> nowList, int defaultIndex) {} // 0x00B19840-0x00B19BC0
		private List<WordItem> GetViewList(int startIndex, int maxCount) => default; // 0x00B194F0-0x00B19840
		public WordItem GetNowItem() => default; // 0x00B19DE0-0x00B19EF0
		public void SelectContinue() {} // 0x00B17DC0-0x00B17E50
		public void Return(uint hash, int viewStartIndex, int cursorIndex, int refineType) {} // 0x00B19EF0-0x00B1A180
		public void Jump(uint hash) {} // 0x00B14C60-0x00B14E80
		public void Next(uint hash, int viewStartIndex, int cursorIndex) {} // 0x00B1A180-0x00B1A340
		protected override bool _doRight() => default; // 0x00B1A340-0x00B1A640
		protected override bool _doLeft() => default; // 0x00B1A640-0x00B1A8A0
		protected override bool _doDown() => default; // 0x00B1A8A0-0x00B1ABE0
		protected override bool _doUp() => default; // 0x00B1AD10-0x00B1AF80
		private bool CheckFirstOrEnd() => default; // 0x00B1ABE0-0x00B1AD10
		private void AddCursor(int value = 1 /* Metadata: 0x00613029 */) {} // 0x00B1AF80-0x00B1B300
		private void SubCursor(int value = 1 /* Metadata: 0x0061302D */) {} // 0x00B1B300-0x00B1B5C0
		protected override void _doInput() {} // 0x00B1B5C0-0x00B1B870
		protected override bool _onYButton() => default; // 0x00B1BE30-0x00B1BF10
		protected override bool _doDecide() => default; // 0x00B1BF10-0x00B1BF20
		protected override bool _doCancel() => default; // 0x00B1BF20-0x00B1C0E0
		private bool _doStart() => default; // 0x00B1BD70-0x00B1BE30
		private bool _onLButton() => default; // 0x00B1B870-0x00B1BAF0
		private bool _onRButton() => default; // 0x00B1BAF0-0x00B1BD70
		private void SetNextCategory(bool right) {} // 0x00B1C1F0-0x00B1C350
		private void PageChange(bool right) {} // 0x00B1C1C0-0x00B1C1F0
		public void ResetViewState() {} // 0x00B12270-0x00B122D0
		protected override bool _onXButton() => default; // 0x00B1C350-0x00B1C440
		private bool ItemXButton() => default; // 0x00B1C440-0x00B1C670
		private int IndexAdjust(Const.dictionaryCategory.Index nextCategory) => default; // 0x00B1C670-0x00B1C7A0
		private int IndexAdjust(Const.dictionaryCategory.Index nextCategory, uint itemIndex) => default; // 0x00B1C0E0-0x00B1C1C0
	}

	public class ItemExplanWindow : UIWindowBase // TypeDefIndex: 6754
	{
		// Fields
		private UIControlTMP cap; // 0x30
		private UIControlTMP details; // 0x38

		// Properties
		public UIControlTMP Details { get => default; } // 0x00B14650-0x00B14660 

		// Constructors
		public ItemExplanWindow() {} // 0x00B13E00-0x00B13E10

		// Methods
		public void Init(GameObject obj, UIDictionary manager) {} // 0x00B15FB0-0x00B16160
		public void UpdateDetails(TangoListWindow.WordItem item) {} // 0x00B16160-0x00B161F0
		public void ResetViewState() {} // 0x00B12320-0x00B12330
	}

	public class StateWordSelect : FSMState<UIDictionary, Status> // TypeDefIndex: 6755
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B16A90-0x00B16AA0 

		// Constructors
		public StateWordSelect() {} // 0x00B14110-0x00B14160

		// Methods
		public override void Enter() {} // 0x00B16AA0-0x00B16E60
		public override void Execute() {} // 0x00B17D50-0x00B17D70
		public override void Exit() {} // 0x00B17D70-0x00B17D80
	}

	public class StateWordSelect_Continue : FSMState<UIDictionary, Status> // TypeDefIndex: 6756
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B17DA0-0x00B17DB0 

		// Constructors
		public StateWordSelect_Continue() {} // 0x00B14250-0x00B142A0

		// Methods
		public override void Enter() {} // 0x00B17DB0-0x00B17DC0
		public override void Execute() {} // 0x00B17E50-0x00B17E70
		public override void Exit() {} // 0x00B17E70-0x00B17E80
	}

	public class StateWordSelect_Jump : FSMState<UIDictionary, Status> // TypeDefIndex: 6757
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B17E80-0x00B17E90 

		// Constructors
		public StateWordSelect_Jump() {} // 0x00B142A0-0x00B142F0

		// Methods
		public override void Enter() {} // 0x00B17E90-0x00B17EA0
		public override void Execute() {} // 0x00B17EA0-0x00B17EC0
		public override void Exit() {} // 0x00B17EC0-0x00B17ED0
	}

	public class StateFocusSelect : FSMState<UIDictionary, Status> // TypeDefIndex: 6758
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B16860-0x00B16870 

		// Constructors
		public StateFocusSelect() {} // 0x00B14160-0x00B141B0

		// Methods
		public override void Enter() {} // 0x00B16870-0x00B16890
		public override void Execute() {} // 0x00B16890-0x00B16910
		public override void Exit() {} // 0x00B16910-0x00B16920
	}

	public class StateFocusSelect_First : FSMState<UIDictionary, Status> // TypeDefIndex: 6759
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B16920-0x00B16930 

		// Constructors
		public StateFocusSelect_First() {} // 0x00B141B0-0x00B14200

		// Methods
		public override void Enter() {} // 0x00B16930-0x00B16940
		public override void Execute() {} // 0x00B16940-0x00B169C0
		public override void Exit() {} // 0x00B169C0-0x00B169D0
	}

	public class StateFocusSelect_First_MultiWindow : FSMState<UIDictionary, Status> // TypeDefIndex: 6760
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B169D0-0x00B169E0 

		// Constructors
		public StateFocusSelect_First_MultiWindow() {} // 0x00B14200-0x00B14250

		// Methods
		public override void Enter() {} // 0x00B169E0-0x00B16A00
		public override void Execute() {} // 0x00B16A00-0x00B16A80
		public override void Exit() {} // 0x00B16A80-0x00B16A90
	}

	public class StateEnd : FSMState<UIDictionary, Status> // TypeDefIndex: 6761
	{
		// Properties
		public override Status StateID { get => default; } // 0x00B161F0-0x00B16200 

		// Constructors
		public StateEnd() {} // 0x00B142F0-0x00B14340

		// Methods
		public override void Enter() {} // 0x00B16200-0x00B164D0
		public override void Execute() {} // 0x00B164D0-0x00B164E0
		public override void Exit() {} // 0x00B164E0-0x00B164F0
		// [IteratorStateMachine] // 0x0064B3E0-0x0064B450
		private IEnumerator wait(Action cb) => default; // 0x00B164F0-0x00B16560
	}

	public enum LinkMenuState // TypeDefIndex: 6764
	{
		NONE = 0,
		FIRST_LINKSELECT = 1,
		DICTONARY = 2
	}

	// Constructors
	private UIDictionary() {} // 0x00B124D0-0x00B124E0

	// Methods
	public bool IsOpened() => default; // 0x00B11F80-0x00B11FA0
	public bool IsClosed() => default; // 0x00B11FA0-0x00B11FC0
	public void DataReset() {} // 0x00B11FC0-0x00B12270
	private LinkHistoryData GetLastData() => default; // 0x00B12330-0x00B12380
	private void DeleteLastData() {} // 0x00B123E0-0x00B124D0
	public static UIDictionary Create() => default; // 0x00B124E0-0x00B126E0
	public static UIDictionary Create(Const.dictionary.Index dictionaryIndex) => default; // 0x00B12780-0x00B127B0
	private void Construct() {} // 0x00B126E0-0x00B12780
	public void FSMSet() {} // 0x00B13E20-0x00B14110
	public void MainFlow(out bool outB) {
		outB = default;
	} // 0x00B14340-0x00B14480
	// [IteratorStateMachine] // 0x006281F0-0x00628260
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00B14490-0x00B14510
	// [IteratorStateMachine] // 0x00628260-0x006282D0
	public override IEnumerator MainFlow() => default; // 0x00B14540-0x00B145B0
	private void Update() {} // 0x00B145E0-0x00B14640
	public void Focus(UIControlTMP tmp, bool dataAdd) {} // 0x00B14660-0x00B147E0
	public void Focus(UIControlTMP tmp, List<UIControlTMP> tmpList, bool dataAdd) {} // 0x00B147F0-0x00B14970
	private void Decide(uint hash, bool dataAdd) {} // 0x00B14980-0x00B14B70
	// [IteratorStateMachine] // 0x006282D0-0x00628340
	public static IEnumerator LinkStartFlow(UIControlTMP tmp, Action endCb, UIScrollView scrollView = null) => default; // 0x00B14E80-0x00B14F00
	// [IteratorStateMachine] // 0x00628340-0x006283B0
	public static IEnumerator LinkStartFlow(List<UIControlTMP> rootList, Action endCb, List<UIScrollView> scrollView = null) => default; // 0x00B14F30-0x00B14FB0
	// [IteratorStateMachine] // 0x006283B0-0x00628420
	private static IEnumerator LinkStartBase(Status startStatus) => default; // 0x00B14FE0-0x00B15050
	public void ResetLinkMenuState_() {} // 0x00B150A0-0x00B150B0
	public static bool IsLinkMenuMode() => default; // 0x00B150B0-0x00B15130
	public static bool IsDictionaryMode() => default; // 0x00B15130-0x00B151B0
}

