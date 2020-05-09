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

public class UIPokemonListMenuRescueSociety : UIManagerBase // TypeDefIndex: 7421
{
	// Fields
	private List<UIRescueSociety.PokemonInfo> pokemonList_; // 0x20
	private int resultIndex; // 0x28
	private PokemonListWindowRescueSociety listWindow_; // 0x30
	private HabitatDetailWindow habitatWindow_; // 0x38
	private CommonScreen commonScreen_; // 0x40
	private UIRescueSociety.ActionType act_; // 0x48

	// Nested types
	public class PokemonListWindowRescueSociety : BasicListWindow // TypeDefIndex: 7422
	{
		// Fields
		private PokemonSortData pokemonSortData_; // 0x88
		private List<UIRescueSociety.PokemonInfo> nowList; // 0x90
		private List<UIRescueSociety.PokemonInfo> originList; // 0x98
		private GameObject objRoot_; // 0xA0
		private List<UIRescueSociety.PokemonInfo> tempList_; // 0xA8
		private UIPokemonListMenuRescueSociety manager_; // 0xB0
		private PokemonSortData.SubMenuSelectItem[] refineFirstSelectItemArray; // 0xB8
		private PokemonSortData.SubMenuSelectItem[] sortSelectArray; // 0xC0
		private PageState pageState_; // 0xC8
		private List<UIRescueSociety.PokemonInfo>[] refinePartList; // 0xD0
		private PokemonSortData.BeingAllNameTypes nameType_; // 0xD8
		private Const.pokemon.Type pokemonType_; // 0xDC
		private CommonSortRefineWindow.ListItem.Label sortLabel_; // 0xE0

		// Nested types
		private enum PageState // TypeDefIndex: 7423
		{
			TOP = 0,
			REFINE_FIRST_SELECT = 1,
			REFINE_SECOND_NAMES_SELECT = 2,
			REFINE_SECOND_TYPES_SELECT = 3,
			SORT_ITEM_SELECT = 4,
			END = 5
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7424
		{
			// Fields
			private UIRescueSociety.PokemonInfo pokemon_; // 0x18

			// Properties
			public UIRescueSociety.PokemonInfo Item { get => default; set {} } // 0x00B48170-0x00B48180 0x00B4B910-0x00B4B920

			// Constructors
			public UILocalSelectItem() {} // 0x00B4B900-0x00B4B910
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 7425
		{
			// Fields
			protected UIFaceWindow faceWindow_; // 0x30

			// Constructors
			public UILocalSelector() {} // 0x00B4B630-0x00B4B6A0

			// Methods
			protected override void SetupFace() {} // 0x00B4C4E0-0x00B4D2E0
		}

		// Constructors
		public PokemonListWindowRescueSociety() {} // 0x00B470B0-0x00B47420

		// Methods
		public void Init(GameObject objRoot, List<UIRescueSociety.PokemonInfo> list, int defaultIndex, UIPokemonListMenuRescueSociety manager) {} // 0x00B476F0-0x00B47990
		private void CreateList(List<UIRescueSociety.PokemonInfo> list, int defaultIndex) {} // 0x00B4A170-0x00B4A310
		// [IteratorStateMachine] // 0x0064F3D0-0x0064F440
		public IEnumerator _sortRefineSelect() => default; // 0x00B480F0-0x00B48160
		protected void ListUpdate() {} // 0x00B4A350-0x00B4A4A0
		public void ResetFilter() {} // 0x00B480D0-0x00B480F0
		public void ResetRefineFilter() {} // 0x00B4A4A0-0x00B4A4C0
		public void ReList(PokemonSortData.BeingAllNameTypes type, bool kind) {} // 0x00B4A4C0-0x00B4A5B0
		public void ReList(Const.pokemon.Type type) {} // 0x00B4A5B0-0x00B4A610
		public void ReList(CommonSortRefineWindow.ListItem.Label label) {} // 0x00B4A610-0x00B4A650
		private bool[] GetBeingType() => default; // 0x00B4A650-0x00B4AAC0
		private bool[] GetBeingKindInitial() => default; // 0x00B4AAC0-0x00B4AE80
		public virtual List<UIRescueSociety.PokemonInfo> GetNowList(int presetIndex = -1 /* Metadata: 0x006136FE */) => default; // 0x00B4AE80-0x00B4B2C0
		protected override bool _onYButton() => default; // 0x00B4B2C0-0x00B4B2F0
		protected override bool _doItemSelect(bool decide) => default; // 0x00B4B2F0-0x00B4B4F0
	}

	private class HabitatDetailWindow : UIWindowBase // TypeDefIndex: 7430
	{
		// Constructors
		public HabitatDetailWindow() {} // 0x00B47420-0x00B47430

		// Methods
		public void Construct() {} // 0x00B49990-0x00B49A80
		public void UpdateWindow(UIRescueSociety.PokemonInfo info) {} // 0x00B48180-0x00B497A0
		private List<UIRescueSociety.AreaData> LoadDistributionList(Const.creature.Index index) => default; // 0x00B49B00-0x00B49F30
		protected Const.dungeon.Index GetBossDungeon(Const.creature.Index index) => default; // 0x00B49FF0-0x00B4A0D0
		private bool CheckStatueLockPokemon(Const.creature.Index index) => default; // 0x00B49A80-0x00B49B00
		private bool CheckAppearPokemonListByToppatsu(Const.creature.Index index) => default; // 0x00B49F90-0x00B49FF0
		private bool CheckAppearPokemonListByInvition(Const.creature.Index index) => default; // 0x00B49F30-0x00B49F90
	}

	// Constructors
	public UIPokemonListMenuRescueSociety() {} // 0x00B497A0-0x00B497B0

	// Methods
	private void Start() {} // 0x00B46E70-0x00B46E80
	private void Update() {} // 0x00B46E80-0x00B46ED0
	public static UIPokemonListMenuRescueSociety Create(GameObject rootObj) => default; // 0x00B46ED0-0x00B46FE0
	public void Construct() {} // 0x00B46FE0-0x00B470B0
	public void Init(List<UIRescueSociety.PokemonInfo> initList, int defaultIndex) {} // 0x00B47430-0x00B476F0
	public void Continue() {} // 0x00B47BB0-0x00B47C10
	// [IteratorStateMachine] // 0x0062BFB0-0x0062C020
	public IEnumerator MainFlow(Action<UIRescueSociety.ActionType> cb = null, Action<int> indexCb = null, Action<List<UIRescueSociety.PokemonInfo>> listCb = null) => default; // 0x00B47C10-0x00B47CA0
	private void _cbFromWorldListWindow(ListWindowBase.ActionType act) {} // 0x00B47CD0-0x00B480D0
	private void _OpenPokemonSelect() {} // 0x00B47A40-0x00B47BB0
	private void _OnStartPokemonSelect() {} // 0x00B48160-0x00B48170
	private void _updateDetail() {} // 0x00B47990-0x00B47A40
}

