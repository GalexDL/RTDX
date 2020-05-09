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

public class UIOptionWindow : UIManagerBase // TypeDefIndex: 7206
{
	// Fields
	private static int[] now_option_value; // 0x00
	private static int[] shortcutList; // 0x08
	private int[] aMessageGuideIndex_; // 0x20
	private OptionPage1 optionPage1_; // 0x28
	private OptionPage2 optionPage2_; // 0x30
	private OptionPage3 optionPage3_; // 0x38
	private TabWindowBase tabWindow_; // 0x40
	private CommonScreen commonScreen_; // 0x48
	private GameObject guideMessage_; // 0x50
	protected ActionType act_; // 0x58
	private bool bGuideMessageVisible; // 0x5C
	private CallbackAction callbackFunc_; // 0x60

	// Nested types
	public enum OptionMenuItem // TypeDefIndex: 7207
	{
		None = -1,
		VolumeBGM = 0,
		VolumeSE = 1,
		GridDisp = 2,
		WalkSpeed = 3,
		CameraEffect = 4,
		DamageRotation = 5,
		ItemAuto = 6,
		AutoDash = 7,
		HungryDash = 8,
		ShortcutL = 9,
		ShortcutR = 10,
		ShortcutUp = 11,
		ShortcutDown = 12,
		ShortcutLeft = 13,
		ShortcutRight = 14,
		DungeonMap = 15,
		ActionButtonRole = 16,
		AI_StairDiscovery = 17,
		NumMenuItem = 18
	}

	public enum OptionItemSet // TypeDefIndex: 7208
	{
		Set2 = 0,
		Set5 = 1,
		SetShortcut = 2,
		Set3 = 3
	}

	public enum OptionShortcut // TypeDefIndex: 7209
	{
		None = 0,
		AutoMode = 1,
		Item = 2,
		Status = 3,
		Quest = 4,
		Waza = 5,
		Order = 6,
		Leader = 7,
		Log = 8,
		Look = 9,
		Foot = 10,
		Manual = 11,
		MapView = 12,
		DungeonStatus = 13,
		RemovePartyMember = 14,
		NumShortcut = 15
	}

	public class OptionMenuParam // TypeDefIndex: 7210
	{
		// Fields
		public OptionMenuItem menuItem; // 0x10
		public bool bDisable; // 0x14

		// Constructors
		public OptionMenuParam() {} // 0x00DEF290-0x00DEF2C0
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7211
	{
		// Fields
		private OptionMenuItem item_; // 0x18

		// Properties
		public OptionMenuItem Item { get => default; set {} } // 0x00EF7A70-0x00EF7A80 0x00EF7160-0x00EF7170

		// Constructors
		public UILocalSelectItem() {} // 0x00EF7150-0x00EF7160
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7212
	{
		// Fields
		private GameObject guide; // 0x30

		// Constructors
		public UILocalSelector() {} // 0x00EF7010-0x00EF7080

		// Methods
		protected override bool FaceFocus() => default; // 0x00EF83D0-0x00EF8A80
		protected override void SetupFace() {} // 0x00EF8A80-0x00EF9E80
	}

	public class OptionPage1 : BasicListWindow // TypeDefIndex: 7213
	{
		// Fields
		private List<OptionMenuParam> aMenuItem; // 0x88

		// Constructors
		public OptionPage1() {} // 0x00DEC330-0x00DEC340

		// Methods
		public override void Init(GameObject root) {} // 0x00DEF2C0-0x00DEF5D0
		public void UpdateGuide() {} // 0x00DEDD50-0x00DEDD80
		public void UpdateAll() {} // 0x00DEDDB0-0x00DEDDD0
		protected override bool _doLeft() => default; // 0x00DEF5E0-0x00DEFF10
		protected override bool _doRight() => default; // 0x00DEFF10-0x00DF0850
	}

	public class OptionPage2 : BasicListWindow // TypeDefIndex: 7216
	{
		// Fields
		private List<OptionMenuParam> aMenuItem; // 0x88

		// Constructors
		public OptionPage2() {} // 0x00DEC340-0x00DEC350

		// Methods
		public override void Init(GameObject root) {} // 0x00DF0A10-0x00DF0CF0
		public void UpdateGuide() {} // 0x00DEDD80-0x00DEDDB0
		public void UpdateAll() {} // 0x00DEDDD0-0x00DEDDF0
		protected override bool _doLeft() => default; // 0x00DF0CF0-0x00DF0FE0
		protected override bool _doRight() => default; // 0x00DF0FE0-0x00DF12D0
	}

	public class OptionPage3 : BasicListWindow // TypeDefIndex: 7219
	{
		// Fields
		private List<OptionMenuParam> aMenuItem; // 0x88

		// Constructors
		public OptionPage3() {} // 0x00EF81C0-0x00EF81D0

		// Methods
		public override void Init(GameObject root) {} // 0x00EF7170-0x00EF7400
		public void UpdateGuide() {} // 0x00EF7410-0x00EF7440
		public void UpdateAll() {} // 0x00EF7440-0x00EF7460
		protected override bool _doLeft() => default; // 0x00EF7460-0x00EF7A70
		protected override bool _doRight() => default; // 0x00EF7BA0-0x00EF81C0
	}

	public enum ActionType // TypeDefIndex: 7222
	{
		None = 0,
		Cancel = 1,
		Decide = 2,
		TabChangeStart = 3,
		TabChangeEnd = 4
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 7223; 0x00DED010-0x00DED3C0

	// Constructors
	public UIOptionWindow() {} // 0x00DEDF20-0x00DEDF80
	static UIOptionWindow() {} // 0x00DEDF80-0x00DEE020

	// Methods
	private static string getOptionMenuItemString(OptionMenuItem item) => default; // 0x00DEBCF0-0x00DEBDC0
	private static string getOptionMenuItemSetString(OptionMenuItem item, int onoff) => default; // 0x00DEBDC0-0x00DEBF10
	private static int getOptionShortcutSetter(OptionMenuItem item) => default; // 0x00DEBF10-0x00DEC030
	private static OptionItemSet getOptionItemSet(OptionMenuItem item) => default; // 0x00DEC030-0x00DEC0D0
	public static UIOptionWindow Create() => default; // 0x00DEC0D0-0x00DEC230
	public virtual void Construct() {} // 0x00DEC230-0x00DEC330
	public virtual void Destruct() {} // 0x00DEC350-0x00DEC3D0
	public virtual void Init() {} // 0x00DEC3D0-0x00DECA30
	// [IteratorStateMachine] // 0x0062AC80-0x0062ACF0
	public virtual IEnumerator MainFlow(Action cb = null) => default; // 0x00DECA30-0x00DECAA0
	protected bool CheckModified() => default; // 0x00DECAD0-0x00DECBD0
	// [IteratorStateMachine] // 0x0062ACF0-0x0062AD60
	public IEnumerator CloseWindowForMessage() => default; // 0x00DECBD0-0x00DECC40
	// [IteratorStateMachine] // 0x0062AD60-0x0062ADD0
	public IEnumerator OpenGuideMessage() => default; // 0x00DECC70-0x00DECCE0
	// [IteratorStateMachine] // 0x0062ADD0-0x0062AE40
	public IEnumerator CloseGuideMessage() => default; // 0x00DECD10-0x00DECD80
	protected void _cbFromWindow(ActionType act) {} // 0x00DECDB0-0x00DECE10
	public void ResetActionListener() {} // 0x00DECE10-0x00DECE20
	public void RegisterActionListener(CallbackAction cb) {} // 0x00DECE20-0x00DECF10
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00DECF10-0x00DED000
	public void callAction(ActionType action) {} // 0x00DED000-0x00DED010
	private void _cbFromTabWindow(TabWindowBase.ActionType act) {} // 0x00DED3C0-0x00DED600
	protected virtual bool _doCancel() => default; // 0x00DED620-0x00DED6B0
	protected virtual bool _doDecide() => default; // 0x00DED6B0-0x00DED740
	protected virtual bool _doReset() => default; // 0x00DED740-0x00DEDC30
	public void UpdateGuideMessage(int tabno) {} // 0x00DEDCF0-0x00DEDD50
	public void UpdateGuideReset(int tabno) {} // 0x00DEDC30-0x00DEDCF0
	private void Start() {} // 0x00DEDDF0-0x00DEDE00
	private void Update() {} // 0x00DEDE00-0x00DEDF20
}

