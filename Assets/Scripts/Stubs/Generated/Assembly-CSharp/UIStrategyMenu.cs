/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.order;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIStrategyMenu : UIManagerBase // TypeDefIndex: 7583
{
	// Fields
	private OrderStatusListWindow listWindow_; // 0x20
	private OrderSelectListWindow selectListWindow_; // 0x28
	private DetailWindow detailWindow_; // 0x30
	private GuideWindow guideWindow_; // 0x38
	private CommonScreen commonScreen_; // 0x40
	private Result result_; // 0x48
	private bool bCommonClose; // 0x4C
	private Index detailOrderIndex_; // 0x50

	// Nested types
	public class OrderStatusListWindow : BasicListWindow // TypeDefIndex: 7584
	{
		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7585
		{
			// Fields
			private IPokemonStatus pokemonStatus_; // 0x18
			private Index teamOrderIndex_; // 0x20

			// Properties
			public virtual IPokemonStatus PokemonStatus { get => default; set {} } // 0x00E07520-0x00E07530 0x00E07510-0x00E07520
			public virtual Index TeamOrderIndex { get => default; set {} } // 0x00E07540-0x00E07550 0x00E07530-0x00E07540

			// Constructors
			public UILocalSelectItem() {} // 0x00E074F0-0x00E07510
		}

		protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7586
		{
			// Fields
			protected UIFaceWindow faceWindow_; // 0x30

			// Constructors
			public UILocalSelector() {} // 0x00E07330-0x00E073A0

			// Methods
			protected override void SetupFace() {} // 0x00E07550-0x00E07B50
		}

		// Constructors
		public OrderStatusListWindow() {} // 0x00E04C70-0x00E04C80

		// Methods
		public override void Init(GameObject objRoot) {} // 0x00E07010-0x00E071E0
		public bool IsSingleMenu() => default; // 0x00E05650-0x00E056C0
	}

	public class OrderSelectListWindow : BasicListWindow // TypeDefIndex: 7589
	{
		// Nested types
		protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7590
		{
			// Constructors
			public UILocalSelector() {} // 0x00E06E10-0x00E06E80

			// Methods
			protected override void SetupFace() {} // 0x00E06E80-0x00E07010
		}

		// Constructors
		public OrderSelectListWindow() {} // 0x00E04C90-0x00E04CA0

		// Methods
		public override void Init(GameObject objRoot) {} // 0x00E06A40-0x00E06C10
		public void Start(Index orderIndex) {} // 0x00E05E90-0x00E05F10
	}

	private class DetailWindow : DetailWindowBase // TypeDefIndex: 7592
	{
		// Fields
		private bool bFirstOpen_; // 0x50

		// Constructors
		public DetailWindow() {} // 0x00E04C80-0x00E04C90

		// Methods
		// [IteratorStateMachine] // 0x00650990-0x00650A00
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00E06810-0x00E06890
	}

	private class GuideWindow : UIWindowBase // TypeDefIndex: 7594
	{
		// Constructors
		public GuideWindow() {} // 0x00E04CA0-0x00E04CB0
	}

	public enum Result // TypeDefIndex: 7595
	{
		Cancel = -1,
		None = 0,
		Decide = 1
	}

	// Constructors
	public UIStrategyMenu() {} // 0x00E06440-0x00E06450

	// Methods
	public static UIStrategyMenu Create() => default; // 0x00E04A00-0x00E04B60
	public void Construct() {} // 0x00E04B60-0x00E04C70
	public void Destruct() {} // 0x00E04CB0-0x00E04D60
	public void Init() {} // 0x00E04D60-0x00E050C0
	public void SetCommonClose() {} // 0x00E050C0-0x00E050D0
	// [IteratorStateMachine] // 0x0062D940-0x0062D9B0
	public IEnumerator MainFlow(Action<Result> cb = null) => default; // 0x00E050D0-0x00E05150
	private void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00E05180-0x00E05420
	private void _cbFromSelectListWindow(ListWindowBase.ActionType act) {} // 0x00E05850-0x00E05930
	private void _onStartSelectMenu() {} // 0x00E05420-0x00E05650
	private void _onDecideSelectMenu() {} // 0x00E05930-0x00E05CA0
	private void _onEndSelectMenu() {} // 0x00E05CA0-0x00E05DF0
	private void _onContinueListMenu() {} // 0x00E06200-0x00E06240
	private void _drawDetail(Index orderIndex) {} // 0x00E06240-0x00E063D0
	private void _updateDetail() {} // 0x00E056C0-0x00E05850
	private void _updateDetail2() {} // 0x00E05DF0-0x00E05E90
	private void _updateTeamOrder() {} // 0x00E05F10-0x00E06200
	private void Start() {} // 0x00E063D0-0x00E063E0
	private void Update() {} // 0x00E063E0-0x00E06440
}

