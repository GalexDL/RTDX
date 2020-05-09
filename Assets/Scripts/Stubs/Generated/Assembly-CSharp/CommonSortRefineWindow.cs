/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CommonSortRefineWindow : UIWindowBase // TypeDefIndex: 6195
{
	// Fields
	private bool bSortRefineMode_; // 0x30
	private MenuSelect menuSelect_; // 0x38
	private ListSelect listSelect_; // 0x40
	private bool bVisible_; // 0x48
	private State state_; // 0x4C

	// Properties
	public static bool IsSoreRefineMode { get => default; } // 0x0097EBE0-0x0097EC90 

	// Nested types
	private class MenuSelect : BasicMenuWindow // TypeDefIndex: 6196
	{
		// Constructors
		public MenuSelect() {} // 0x0097F0B0-0x0097F0C0

		// Methods
		protected override void _doInput() {} // 0x00981980-0x00981AC0
		protected override bool _doLeft() => default; // 0x00981AC0-0x00981AD0
		protected override bool _doRight() => default; // 0x00981AD0-0x00981AE0
		public override void Visible(bool bEnable) {} // 0x00981AE0-0x00981B20
		public void Init(GameObject root, string[] sMenuTag, int defaultIndex = 0 /* Metadata: 0x00612984 */) {} // 0x0097F0C0-0x0097F430
		public int GetSelectId() => default; // 0x00980BE0-0x00980C10
	}

	private class ListSelect_Link : ListSelect // TypeDefIndex: 6197
	{
		// Constructors
		public ListSelect_Link() {} // 0x009802B0-0x009802C0

		// Methods
		protected override bool _onYButton() => default; // 0x00981960-0x00981980
	}

	private class ListSelect : BasicListWindow // TypeDefIndex: 6198
	{
		// Fields
		private bool bYbuttonClose_; // 0x84

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6199
		{
			// Fields
			private ListItem item_; // 0x18

			// Properties
			public ListItem Item { get => default; set {} } // 0x00981360-0x00981370 0x0097FB40-0x0097FB50

			// Constructors
			public UILocalSelectItem() {} // 0x0097FB30-0x0097FB40
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6200
		{
			// Fields
			public bool pokemonType; // 0x29

			// Constructors
			public UILocalSelector() {} // 0x0097FC20-0x0097FC90

			// Methods
			protected override void SetupFace() {} // 0x00981370-0x00981960
		}

		// Constructors
		public ListSelect() {} // 0x009802A0-0x009802B0

		// Methods
		public override void Visible(bool bEnable) {} // 0x00980E80-0x00980EC0
		public void Init(GameObject objRoot, InitParam param, int nItems, bool bYbuttonClose = false /* Metadata: 0x00612988 */, bool pokemonType = false /* Metadata: 0x00612989 */) {} // 0x009802C0-0x00980500
		public void ResetSelect() {} // 0x00980EC0-0x009810F0
		public void SetCaption(GameObject obj, int nCaption) {} // 0x00980500-0x009805C0
		public int GetSelectId() => default; // 0x009805C0-0x009805F0
		protected override void _doInput() {} // 0x009810F0-0x00981360
	}

	public enum State // TypeDefIndex: 6201
	{
		Cancel = -1,
		Select = 0,
		Decide = 1
	}

	public class ListItem // TypeDefIndex: 6202
	{
		// Fields
		public Label label; // 0x10
		public bool bEnable; // 0x14

		// Nested types
		public enum Label // TypeDefIndex: 6203
		{
			NONE = -1,
			ITEM_SEARCH_EQUIP = 0,
			ITEM_SEARCH_ARROW = 1,
			ITEM_SEARCH_STONE = 2,
			ITEM_SEARCH_SEED = 3,
			ITEM_SEARCH_ORB = 4,
			ITEM_SEARCH_WAND = 5,
			ITEM_SEARCH_FOOD = 6,
			ITEM_SEARCH_PARAMETER = 7,
			ITEM_SEARCH_PP = 8,
			ITEM_SEARCH_WAZAMACHINE = 9,
			ITEM_SEARCH_EVOLUTION = 10,
			ITEM_SEARCH_BOX = 11,
			ITEM_SEARCH_OTHER = 12,
			ITEM_SEARCH_ALL = 13,
			ITEM_SORT_NAME = 14,
			ITEM_SORT_DEFAULT = 15,
			SEARCH_POKEMONNAME = 16,
			SORT_BOOK_NO = 17,
			SORT_LEVEL = 18,
			SORT_FRIEND = 19,
			SORT_USE = 20,
			SEARCH_TYPE = 21,
			SEARCH_KIND = 22,
			SEARCH_EVOLUTION_OK = 23,
			SEARCH_ALL = 24,
			FILTER_00_NAME = 25,
			FILTER_01_NAME = 26,
			FILTER_02_NAME = 27,
			FILTER_03_NAME = 28,
			FILTER_04_NAME = 29,
			FILTER_05_NAME = 30,
			FILTER_06_NAME = 31,
			FILTER_07_NAME = 32,
			FILTER_08_NAME = 33,
			FILTER_09_NAME = 34,
			FILTER_10_NAME = 35,
			FILTER_11_NAME = 36,
			FILTER_12_NAME = 37,
			FILTER_13_NAME = 38,
			FILTER_14_NAME = 39,
			FILTER_OTHER_NAME = 40,
			QUEST_SEARCH_DATE = 41,
			QUEST_SEARCH_ALL = 42,
			SORT_NO = 43,
			SORT_DEFAULT = 44,
			SORT_KIND = 45,
			SORT_PRICE = 46,
			SORT_POKEMONNAME = 47,
			ALL_DEFAULT_SORT = 48,
			FILTER_00_KIND = 49,
			FILTER_01_KIND = 50,
			FILTER_02_KIND = 51,
			FILTER_03_KIND = 52,
			FILTER_04_KIND = 53,
			FILTER_05_KIND = 54,
			FILTER_06_KIND = 55,
			FILTER_07_KIND = 56,
			FILTER_08_KIND = 57,
			FILTER_09_KIND = 58,
			FILTER_10_KIND = 59,
			FILTER_11_KIND = 60,
			FILTER_12_KIND = 61,
			FILTER_13_KIND = 62,
			FILTER_14_KIND = 63,
			FILTER_OTHER_KIND = 64
		}

		// Constructors
		public ListItem() {} // 0x00980DF0-0x00980E00
	}

	public class ListParam // TypeDefIndex: 6204
	{
		// Fields
		public CapType capType; // 0x10
		public List<ListItem> listItems; // 0x18
		public int defaultIndex; // 0x20
		public bool bDecideClose; // 0x24

		// Nested types
		public enum CapType // TypeDefIndex: 6205
		{
			Refine = 0,
			Sort = 1
		}

		// Constructors
		public ListParam() {} // 0x00980E00-0x00980E80
	}

	public class OldSortParam // TypeDefIndex: 6206
	{
		// Fields
		public Const.pokemon.Type oldType; // 0x10
		public ListItem.Label oldLabel; // 0x14

		// Constructors
		public OldSortParam() {} // 0x00981B20-0x00981B30
	}

	// Constructors
	public CommonSortRefineWindow() {} // 0x0097F9F0-0x0097FA00

	// Methods
	public void StartSortRefine() {} // 0x0097EBC0-0x0097EBD0
	public void EndSortRefine() {} // 0x0097EBD0-0x0097EBE0
	public static UICommonGuideWindow Create() => default; // 0x0097EC90-0x0097ED60
	public static UICommonGuideWindow Create_Link() => default; // 0x0097ED60-0x0097EE30
	public State GetState() => default; // 0x0097EE30-0x0097EE40
	public void SetState(State state) {} // 0x0097EE40-0x0097EE50
	public bool IsRunning() => default; // 0x0097EE50-0x0097EE60
	public override void Init(GameObject root) {} // 0x0097EE60-0x0097F0B0
	protected override void _doUpdate() {} // 0x0097F430-0x0097F4A0
	// [IteratorStateMachine] // 0x00625170-0x006251E0
	public IEnumerator MainFlow(Action<int> cb) => default; // 0x0097F4A0-0x0097F520
	private void _cbFromButtonSelectMenu(ListWindowBase.ActionType act) {} // 0x0097F550-0x0097F5B0
	// [IteratorStateMachine] // 0x006251E0-0x00625250
	public IEnumerator ListFlow_LinkMenu(ListParam listParam, Action<int> cb, OldSortParam oldSortParam, bool pokemonTypeVisible = false /* Metadata: 0x00612981 */) => default; // 0x0097F5B0-0x0097F650
	// [IteratorStateMachine] // 0x00625250-0x006252C0
	public IEnumerator ListFlow(ListParam listParam, Action<int> cb, OldSortParam oldSortParam, bool pokemonTypeVisible = false /* Metadata: 0x00612982 */, bool linkMode = false /* Metadata: 0x00612983 */) => default; // 0x0097F680-0x0097F730
	private void _cbFromListSelectMenu(ListWindowBase.ActionType act) {} // 0x0097F760-0x0097F7D0
	// [IteratorStateMachine] // 0x006252C0-0x00625330
	public IEnumerator MenuClose(Action cb = null) => default; // 0x0097F7D0-0x0097F850
	public static bool IsValid_PokemonSort() => default; // 0x0097F880-0x0097F9F0
}

