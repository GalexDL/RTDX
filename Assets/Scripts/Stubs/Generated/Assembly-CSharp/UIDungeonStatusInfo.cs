/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.status;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonStatusInfo : UIManagerBase // TypeDefIndex: 6814
{
	// Fields
	private InfoPage1 infoPage1_; // 0x20
	private InfoPage2 infoPage2_; // 0x28
	private InfoPage3 infoPage3_; // 0x30
	protected InfoPage4 infoPage4_; // 0x38
	protected SideChanger sideChanger_; // 0x40
	protected ActionType act_; // 0x48
	protected static GameObject regidentObj_; // 0x00

	// Nested types
	public class StatusListWindow : BasicListWindow // TypeDefIndex: 6815
	{
		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6816
		{
			// Fields
			private Index item_; // 0x18

			// Properties
			public Index Item { get => default; set {} } // 0x00D65820-0x00D65830 0x00D65BD0-0x00D65BE0

			// Constructors
			public UILocalSelectItem() {} // 0x00D65BC0-0x00D65BD0
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 6817
		{
			// Constructors
			public UILocalSelector() {} // 0x00D65A90-0x00D65B00

			// Methods
			protected override void SetupFace() {} // 0x00D65BE0-0x00D65D90
		}

		// Constructors
		public StatusListWindow() {} // 0x00D62390-0x00D623A0

		// Methods
		public void Init(GameObject objRoot, List<Index> list, string sComponentTag = null) {} // 0x00D623A0-0x00D62540
		public virtual Index GetFocusStatusIndex() => default; // 0x00D65760-0x00D65820
		protected override bool _doDecide() => default; // 0x00D65830-0x00D65840
		protected override bool _doCancel() => default; // 0x00D65840-0x00D65850
		protected override void _doInput() {} // 0x00D65850-0x00D65950
	}

	public abstract class InfoPageCommon : UIWindowBase // TypeDefIndex: 6820
	{
		// Fields
		protected IPokemonStatus status_; // 0x30

		// Constructors
		protected InfoPageCommon() {} // 0x00D60D00-0x00D60D10

		// Methods
		public virtual void Init(GameObject root, IPokemonStatus status) {} // 0x00D60A70-0x00D60AA0
		protected IPokemonStatus _getStatus() => default; // 0x00D611C0-0x00D611D0
		public abstract CommonScreen.GuideCaption GetGuideCaption();
		public abstract CommonScreen.GuideButton GetGuideButton();
	}

	public class InfoPage1 : InfoPageCommon // TypeDefIndex: 6821
	{
		// Fields
		private DetailBasicWindow detailWindow_; // 0x38

		// Constructors
		public InfoPage1() {} // 0x00D5F7A0-0x00D5F7B0

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D60A10-0x00D60A40
		public override void Init(GameObject root, IPokemonStatus status) {} // 0x00D60A40-0x00D60A70
		public override CommonScreen.GuideCaption GetGuideCaption() => default; // 0x00D60CC0-0x00D60CD0
		public override CommonScreen.GuideButton GetGuideButton() => default; // 0x00D60CD0-0x00D60CE0
		public void UpdateFace() {} // 0x00D60AA0-0x00D60CC0
		protected override void _doUpdate() {} // 0x00D60CE0-0x00D60D00
	}

	public class InfoPage2 : InfoPageCommon // TypeDefIndex: 6822
	{
		// Fields
		private RenketsuWazaSingleListWindowLocal wazaListWindow_; // 0x38
		private WazaStatusExplainWindow wazaDetailWindow_; // 0x40

		// Nested types
		private class RenketsuWazaSingleListWindowLocal : RenketsuWazaSingleListWindow // TypeDefIndex: 6823
		{
			// Constructors
			public RenketsuWazaSingleListWindowLocal() {} // 0x00D611B0-0x00D611C0

			// Methods
			protected override bool _decide() => default; // 0x00D613B0-0x00D613C0
			protected override bool _cancel() => default; // 0x00D613C0-0x00D613D0
		}

		// Constructors
		public InfoPage2() {} // 0x00D5F7B0-0x00D5F7C0

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D60D10-0x00D60D60
		public override void Init(GameObject root, IPokemonStatus status) {} // 0x00D60D60-0x00D611B0
		public override CommonScreen.GuideCaption GetGuideCaption() => default; // 0x00D61220-0x00D61230
		public override CommonScreen.GuideButton GetGuideButton() => default; // 0x00D61230-0x00D61260
		private void _cbFromWazaListWindow(ListWindowBase.ActionType act) {} // 0x00D61260-0x00D61360
		private void _updateWazaDetail(bool bForce = false /* Metadata: 0x0061309E */) {} // 0x00D611D0-0x00D61220
		protected override void _doUpdate() {} // 0x00D61360-0x00D613B0
	}

	public class InfoPage3 : InfoPageCommon // TypeDefIndex: 6824
	{
		// Fields
		private AbilityDetail abilityDetail_; // 0x38
		private SugowazaDetail sugowazaDetail_; // 0x40

		// Nested types
		private class AbilityDetail : DetailBasicWindow // TypeDefIndex: 6825
		{
			// Constructors
			public AbilityDetail() {} // 0x00D61A00-0x00D61A10

			// Methods
			protected override bool _doLinkStart() => default; // 0x00D61EA0-0x00D61EB0
		}

		private class SugowazaDetail : DetailBasicWindow // TypeDefIndex: 6826
		{
			// Constructors
			public SugowazaDetail() {} // 0x00D61A10-0x00D61A20

			// Methods
			protected override bool _doLinkStart() => default; // 0x00D61EB0-0x00D61EC0
		}

		// Constructors
		public InfoPage3() {} // 0x00D5F7C0-0x00D5F7D0

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D613D0-0x00D61420
		public override void Init(GameObject root, IPokemonStatus status) {} // 0x00D61420-0x00D61460
		public override CommonScreen.GuideCaption GetGuideCaption() => default; // 0x00D619C0-0x00D619D0
		public override CommonScreen.GuideButton GetGuideButton() => default; // 0x00D619D0-0x00D61A00
		public void UpdateFace(IPokemonStatus status) {} // 0x00D61460-0x00D619C0
		protected override void _doUpdate() {} // 0x00D61A20-0x00D61E10
	}

	public class InfoPage4 : InfoPageCommon // TypeDefIndex: 6828
	{
		// Fields
		private StatusListWindow statusList_; // 0x38
		private DetailBasicWindow statusDetail_; // 0x40

		// Constructors
		public InfoPage4() {} // 0x00D5F7D0-0x00D5F7E0

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D61EC0-0x00D61F10
		public override void Init(GameObject root, IPokemonStatus status) {} // 0x00D61F10-0x00D62390
		public void End() {} // 0x00D5FC50-0x00D5FC80
		public override CommonScreen.GuideCaption GetGuideCaption() => default; // 0x00D62650-0x00D62660
		public override CommonScreen.GuideButton GetGuideButton() => default; // 0x00D62660-0x00D626A0
		private void _cbFromStatusList(ListWindowBase.ActionType act) {} // 0x00D626A0-0x00D62770
		private void _updateStatusDetail(bool bForce = false /* Metadata: 0x0061309F */) {} // 0x00D62540-0x00D62650
		protected override void _doUpdate() {} // 0x00D62770-0x00D627D0
	}

	public class SideChanger : UIWindowBase // TypeDefIndex: 6829
	{
		// Fields
		private bool bGuest_; // 0x30
		protected int pageIndex_; // 0x34
		protected InfoPageCommon[] aPage_; // 0x38
		private GameObject objSlide_; // 0x40
		private BasicPageControlWindow pageControl_; // 0x48
		protected UIFaceWindow face_; // 0x50
		private bool bCompanion_; // 0x58
		private CommonBellyInfo bellyInfo_; // 0x60
		private ExperienceInfoWIndow experienceInfo_; // 0x68
		private CallbackAction callbackFunc_; // 0x70
		private string[] rButtonAnimations_; // 0x78
		private string[] lButtonAnimations_; // 0x80

		// Properties
		public bool Companion { get => default; } // 0x00D60330-0x00D60340 

		// Nested types
		public enum Page // TypeDefIndex: 6830
		{
			page1 = 0,
			page2 = 1,
			page3 = 2,
			page4 = 3,
			pageNum = 4
		}

		private class ExperienceInfoWIndow : InfoWindowBase // TypeDefIndex: 6831
		{
			// Constructors
			public ExperienceInfoWIndow() {} // 0x00D639B0-0x00D639C0

			// Methods
			public virtual void UpdateInfoWindow(IPokemonStatus status) {} // 0x00D655E0-0x00D65750
		}

		public enum ActionType // TypeDefIndex: 6832
		{
			Decide = 0,
			Cancel = 1
		}

		public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6833; 0x00D628E0-0x00D62C90

		// Constructors
		public SideChanger() {} // 0x00D5F7E0-0x00D5FB90

		// Methods
		public void ResetActionListener() {} // 0x00D627D0-0x00D627E0
		public void RegisterActionListener(CallbackAction cb) {} // 0x00D60240-0x00D60330
		public void UnregisterActionListener(CallbackAction cb) {} // 0x00D627E0-0x00D628D0
		public void callAction(ActionType action) {} // 0x00D628D0-0x00D628E0
		protected override bool _setEnable(bool bEnable) => default; // 0x00D62C90-0x00D62D00
		public virtual void Init(GameObject root, IPokemonStatus status, bool bGuest) {} // 0x00D62D00-0x00D632B0
		protected virtual void _doInit(IPokemonStatus status) {} // 0x00D63650-0x00D639B0
		public void UpdateCaption() {} // 0x00D60860-0x00D60980
		public virtual void SetPage(Page index, InfoPageCommon page) {} // 0x00D639C0-0x00D63A50
		// [IteratorStateMachine] // 0x0064BA20-0x0064BA90
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00D63A50-0x00D63AD0
		// [IteratorStateMachine] // 0x0064BA90-0x0064BB00
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00D63B00-0x00D63B80
		// [IteratorStateMachine] // 0x0064BB00-0x0064BB70
		public virtual IEnumerator OpenInfoWindow(Action cb = null) => default; // 0x00D63BB0-0x00D63C30
		// [IteratorStateMachine] // 0x0064BB70-0x0064BBE0
		public virtual IEnumerator CloseInfoWindow(Action cb = null) => default; // 0x00D63C60-0x00D63CE0
		public virtual void OnStart() {} // 0x00D63D10-0x00D63D60
		// [IteratorStateMachine] // 0x0064BBE0-0x0064BC50
		public virtual IEnumerator Slide(bool bRight, Action cb = null) => default; // 0x00D63D60-0x00D63DF0
		protected void _doSlideButton(bool bRight) {} // 0x00D63E20-0x00D63F30
		protected virtual void _doInput() {} // 0x00D63F30-0x00D64080
		protected override void _doUpdate() {} // 0x00D64080-0x00D64090
	}

	public enum ActionType // TypeDefIndex: 6844
	{
		None = 0,
		Cancel = 1,
		Decide = 2
	}

	// Constructors
	public UIDungeonStatusInfo() {} // 0x00D60670-0x00D60680
	static UIDungeonStatusInfo() {} // 0x00D60680-0x00D60690

	// Methods
	public static GameObject CreateRegident() => default; // 0x00D5F1F0-0x00D5F410
	public static void DestroyRegident() {} // 0x00D5F410-0x00D5F5A0
	public static UIDungeonStatusInfo Create() => default; // 0x00D5F5A0-0x00D5F6C0
	public virtual void Construct() {} // 0x00D5F6C0-0x00D5F7A0
	public virtual void Destruct() {} // 0x00D5FB90-0x00D5FC50
	public virtual void Init(IPokemonStatus status, bool bGuest) {} // 0x00D5FC80-0x00D60230
	// [IteratorStateMachine] // 0x006285A0-0x00628610
	public virtual IEnumerator MainFlow(Action cb = null) => default; // 0x00D60340-0x00D603C0
	public virtual void Continue() {} // 0x00D603F0-0x00D60400
	protected void _cbFromPageChanger(SideChanger.ActionType act) {} // 0x00D60400-0x00D605D0
	private void Start() {} // 0x00D605D0-0x00D605E0
	private void Update() {} // 0x00D605E0-0x00D60670
}

