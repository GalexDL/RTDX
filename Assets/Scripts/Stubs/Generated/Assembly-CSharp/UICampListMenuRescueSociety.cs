/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UICampListMenuRescueSociety : UIManagerBase // TypeDefIndex: 6538
{
	// Fields
	private List<UIRescueSociety.CampInfo> campList_; // 0x20
	private List<UIRescueSociety.CampInfo> campBaseList_; // 0x28
	private int resultIndex_; // 0x30
	private int poke_; // 0x34
	private bool bPokemonList; // 0x38
	private Index initPokemonIndex; // 0x3C
	private CampListWindow listWindow_; // 0x40
	private CampDetailWindow campDetailWindow_; // 0x48
	private WildPokemonListDetailWindow wildPokemonWindow_; // 0x50
	private CommonPokeBagInfo pokeWindow_; // 0x58
	private CommonScreen commonScreen_; // 0x60
	private UIRescueSociety.ActionType act_; // 0x68
	private GameObject SortLabel; // 0x70
	private bool isSorting; // 0x78

	// Nested types
	public class CampListWindow : BasicListWindow // TypeDefIndex: 6539
	{
		// Fields
		private UICampListMenuRescueSociety manager_; // 0x88
		public bool FirstAct; // 0x90

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6540
		{
			// Fields
			private UIRescueSociety.CampInfo camp_; // 0x18
			public bool bNew; // 0x20
			public bool bNewClose; // 0x21
			public bool bDiscountAnimation; // 0x22
			public bool bAnimationSkip; // 0x23

			// Properties
			public UIRescueSociety.CampInfo Item { get => default; set {} } // 0x00AC2280-0x00AC2290 0x00AC3B30-0x00AC3B70

			// Constructors
			public UILocalSelectItem() {} // 0x00AC3B20-0x00AC3B30

			// Methods
			private void _initNewFlag() {} // 0x00AC3C50-0x00AC3C90
		}

		protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6541
		{
			// Fields
			private bool bFirstSet; // 0x29

			// Constructors
			public UILocalSelector() {} // 0x00AC38D0-0x00AC3940

			// Methods
			protected override void SetupFace() {} // 0x00AC3C90-0x00AC46E0
			public bool _skipDiscountAnimation() => default; // 0x00AC46F0-0x00AC47B0
		}

		// Constructors
		public CampListWindow() {} // 0x00AC0E10-0x00AC0E20

		// Methods
		public void Init(GameObject objRoot, List<UIRescueSociety.CampInfo> list, int defaultIndex, UICampListMenuRescueSociety manager, bool bContinue = false /* Metadata: 0x00612E59 */) {} // 0x00AC11D0-0x00AC1390
		protected override bool _doItemSelect(bool decide) => default; // 0x00AC2CE0-0x00AC2EC0
		protected override bool _doDecide() => default; // 0x00AC2EC0-0x00AC2F80
		protected override bool _doUp() => default; // 0x00AC2F80-0x00AC3150
		protected override bool _doDown() => default; // 0x00AC3150-0x00AC3320
		protected override bool _doLeft() => default; // 0x00AC3320-0x00AC3520
		protected override bool _doRight() => default; // 0x00AC3520-0x00AC3720
		protected override bool _onXButton() => default; // 0x00AC3720-0x00AC3740
		protected override bool _onYButton() => default; // 0x00AC3740-0x00AC3760
		protected override void _doUpdate() {} // 0x00AC3760-0x00AC3770
		public void ActSkipAnimation() {} // 0x00AC09E0-0x00AC0B50
		public void CheckFirstAct() {} // 0x00AC0B50-0x00AC0BE0
		public void ReList(List<UIRescueSociety.CampInfo> list, int defaultIndex) {} // 0x00AC1A20-0x00AC1BB0
	}

	private class CampDetailWindow : UIWindowBase // TypeDefIndex: 6546
	{
		// Constructors
		public CampDetailWindow() {} // 0x00AC0E30-0x00AC0E40

		// Methods
		public void UpdateWindow(UIRescueSociety.CampInfo info) {} // 0x00AC2290-0x00AC2490
	}

	private class WildPokemonListDetailWindow : UIWindowBase // TypeDefIndex: 6547
	{
		// Fields
		private UIControlTMP textCaption_; // 0x30
		private BasicListWindow listDetail_; // 0x38
		private UIScrollView scScrollView_; // 0x40
		private GameObject objScrollContents_; // 0x48
		private float scrollContentsBasePosition_; // 0x50
		private float scrollContentsOffsetPosition_; // 0x54

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6548
		{
			// Properties
			public Index Item { get; set; } // 0x00AC4FA0-0x00AC4FB0 0x00AC4F70-0x00AC4F80
			public bool Found { get; set; } // 0x00AC4FB0-0x00AC4FC0 0x00AC4F90-0x00AC4FA0
			public bool ExistWarehouse { get; set; } // 0x00AC4FC0-0x00AC4FD0 0x00AC4F80-0x00AC4F90

			// Constructors
			public UILocalSelectItem() {} // 0x00AC4F60-0x00AC4F70
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 6549
		{
			// Constructors
			public UILocalSelector() {} // 0x00AC4DB0-0x00AC4E20

			// Methods
			protected override void SetupFace() {} // 0x00AC4FD0-0x00AC5610
		}

		// Constructors
		public WildPokemonListDetailWindow() {} // 0x00AC0E20-0x00AC0E30

		// Methods
		protected override void _doUpdate() {} // 0x00AC47C0-0x00AC4860
		public override void Init(GameObject detail) {} // 0x00AC4900-0x00AC4BA0
		public void setTextCaption(string sText) {} // 0x00AC4BA0-0x00AC4C60
		public void setListDetail(UIRescueSociety.CampInfo camp) {} // 0x00AC2490-0x00AC26C0
		public void updateScrollView() {} // 0x00AC4860-0x00AC4900
	}

	// Constructors
	public UICampListMenuRescueSociety() {} // 0x00AC28A0-0x00AC28B0

	// Methods
	private void Start() {} // 0x00AC08C0-0x00AC08D0
	private void Update() {} // 0x00AC08D0-0x00AC09E0
	public static UICampListMenuRescueSociety Create(GameObject rootObj) => default; // 0x00AC0BE0-0x00AC0CF0
	public void Construct() {} // 0x00AC0CF0-0x00AC0E10
	public void Init(List<UIRescueSociety.CampInfo> initBaseList, List<UIRescueSociety.CampInfo> initList, int defaultIndex, int possessionMoney, bool bFromPokemonList, Index pokemonIndex = Index.NONE /* Metadata: 0x00612E55 */) {} // 0x00AC0E40-0x00AC11D0
	// [IteratorStateMachine] // 0x00627A60-0x00627AD0
	public IEnumerator MainFlow(bool needSort, Action<UIRescueSociety.ActionType> cb = null, Action<int> indexCb = null, Action<List<UIRescueSociety.CampInfo>> listCb = null) => default; // 0x00AC1440-0x00AC14E0
	public void Continue() {} // 0x00AC1510-0x00AC1550
	protected virtual void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00AC1550-0x00AC1A20
	protected virtual void sortLabelVisible(bool bVisible) {} // 0x00AC1BB0-0x00AC1DD0
	public static int CompareCamp(UIRescueSociety.CampInfo x, UIRescueSociety.CampInfo y) => default; // 0x00AC1DD0-0x00AC1E50
	public void _CloseWindow() {} // 0x00AC1E50-0x00AC1FF0
	private void _OpenCampSelect() {} // 0x00AC1FF0-0x00AC2240
	private void _OnStartCampSelect() {} // 0x00AC2240-0x00AC2280
	private void _updateDetail() {} // 0x00AC1390-0x00AC1440
	public void OverPokeWindow() {} // 0x00AC26C0-0x00AC27A0
	protected virtual bool _checkSkipAnimationLeft() => default; // 0x00AC27A0-0x00AC2820
	protected virtual bool _checkSkipAnimationRight() => default; // 0x00AC2820-0x00AC28A0
}

