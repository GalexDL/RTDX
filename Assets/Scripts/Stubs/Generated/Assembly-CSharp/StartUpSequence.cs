/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Language;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class StartUpSequence // TypeDefIndex: 5693
{
	// Nested types
	public class UILanguageSelectMenu : UIManagerBase // TypeDefIndex: 5694
	{
		// Fields
		private static MenuItem lastSelectMenu_; // 0x00
		private SlideMainMenuWindow slideMenu_; // 0x20
		private ActionType act_; // 0x28

		// Nested types
		public enum MenuItem // TypeDefIndex: 5695
		{
			None = -1,
			JAPANESE = 0,
			ENGLISH = 1,
			FRIENCH = 2,
			GERMAN = 3,
			ITALIAN = 4,
			SPANISH = 5,
			NumMenuItem = 6
		}

		public class MenuParam // TypeDefIndex: 5696
		{
			// Fields
			public MenuItem menuItem; // 0x10

			// Constructors
			public MenuParam() {} // 0x00916670-0x009166A0
		}

		private class PageControlWindow : UIWindowBase // TypeDefIndex: 5697
		{
			// Fields
			private string[] tagPointList; // 0x30
			private int numPage_; // 0x38
			private int topIndex_; // 0x3C

			// Constructors
			public PageControlWindow() {} // 0x009181D0-0x00918850

			// Methods
			public void Init(GameObject root, int numPage, int initPage = 0 /* Metadata: 0x00611D7C */) {} // 0x00917DC0-0x00918080
			public void SetPage(int nPage) {} // 0x00918080-0x009181D0
		}

		public class MainMenuWindow : BasicMenuWindow // TypeDefIndex: 5698
		{
			// Fields
			protected List<MenuParam> aMenuParam_; // 0x48

			// Constructors
			public MainMenuWindow() {} // 0x00917C90-0x00917CA0

			// Methods
			public virtual void OnStart() {} // 0x00917570-0x00917580
			protected override bool _doYButton() => default; // 0x00917580-0x00917590
			protected override bool _doBButton() => default; // 0x00917590-0x009175A0
			public virtual void ResetFocus(int itemId) {} // 0x009175A0-0x009175F0
			protected void _setMenuRotation() {} // 0x009175F0-0x00917750
			protected virtual void _setMenuFaceRotation(UISelectorBase sel) {} // 0x00917750-0x00917B40
			protected virtual void _getRotate(GameObject obj, int index) {} // 0x00917B50-0x00917B60
			protected virtual int _menuItemIndexOf(MenuItem item) => default; // 0x00917B60-0x00917C90
		}

		private class LocalMenuSelector : UISelectorBase // TypeDefIndex: 5701
		{
			// Constructors
			public LocalMenuSelector() {} // 0x00917500-0x00917570

			// Methods
			protected override void SetupFace() {} // 0x00917390-0x00917500
		}

		private class SlideMainMenuWindow : MainMenuWindow // TypeDefIndex: 5702
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
			public SlideMainMenuWindow() {} // 0x00916620-0x00916630
			static SlideMainMenuWindow() {} // 0x009191E0-0x009197B0

			// Methods
			public void Init(GameObject root, List<MenuParam> aMenuParam, MenuItem defaultItem) {} // 0x009166A0-0x00916DA0
			public void Term() {} // 0x00916660-0x00916670
			private void _visibleViewSelector() {} // 0x009188E0-0x00918AC0
			public override void ResetFocus(int itemId) {} // 0x00918AC0-0x00918D00
			private void _copyRotation(GameObject dst, GameObject src) {} // 0x00918D00-0x00918DF0
			public override void OnStart() {} // 0x00918DF0-0x00918E20
			private void _openCenter(int center) {} // 0x00918E20-0x00918F40
			private void _killSwitchView() {} // 0x009188D0-0x009188E0
			// [IteratorStateMachine] // 0x006579D0-0x00657A40
			private IEnumerator _switchView2(LocalMenuSelector sel) => default; // 0x00918850-0x009188D0
			private void _doChange2(int itemIndex, string sAction) {} // 0x00918F70-0x00918F90
			protected override void _doInput() {} // 0x00918F90-0x00919020
			protected override bool _doUp() => default; // 0x00919020-0x00919030
			protected override bool _doDown() => default; // 0x00919030-0x00919040
			protected override bool _doRight() => default; // 0x00919040-0x00919110
			protected override bool _doLeft() => default; // 0x00919110-0x009191E0
		}

		public enum ActionType // TypeDefIndex: 5705
		{
			None = 0,
			Decide = 1
		}

		// Constructors
		public UILanguageSelectMenu() {} // 0x00916F90-0x00916FA0
		static UILanguageSelectMenu() {} // 0x00916FA0-0x00917000

		// Methods
		public static MenuItem GetLastSelectMenu() => default; // 0x009164C0-0x00916530
		public static void SetLastSelectMenu(MenuItem menu) {} // 0x00916530-0x009165A0
		public static UILanguageSelectMenu Create() => default; // 0x00914F50-0x00915100
		public void Construct() {} // 0x009165A0-0x00916620
		public void Destruct() {} // 0x00916630-0x00916660
		public void Init(MenuItem defaultItem) {} // 0x00915100-0x00915590
		// [IteratorStateMachine] // 0x006451A0-0x00645210
		public override IEnumerator MainFlow() => default; // 0x00916DA0-0x00916E10
		public void Continue() {} // 0x009155D0-0x00915640
		public MenuItem GetSelectMenu() => default; // 0x00915590-0x009155D0
		public void SetEnable(bool setBool) {} // 0x00916E40-0x00916E50
		private void _cbFromSlideMenu(ListWindowBase.ActionType act) {} // 0x00916E50-0x00916F60
		private void Start() {} // 0x00916F60-0x00916F70
		private void Update() {} // 0x00916F70-0x00916F90
	}

	// Constructors
	public StartUpSequence() {} // 0x00914150-0x00914160

	// Methods
	// [IteratorStateMachine] // 0x00621250-0x006212C0
	public IEnumerator MainFlow() => default; // 0x00913F40-0x00913FB0
	// [IteratorStateMachine] // 0x006212C0-0x00621330
	public IEnumerator TrialSaveTakeOverFlow(Action<bool> languageSelectCb) => default; // 0x00913FE0-0x00914060
	// [IteratorStateMachine] // 0x00621330-0x006213A0
	public IEnumerator GeneralAsk(TextIDHash main, TextIDHash yes, TextIDHash no, Action<bool> cb) => default; // 0x00914090-0x00914120
}

