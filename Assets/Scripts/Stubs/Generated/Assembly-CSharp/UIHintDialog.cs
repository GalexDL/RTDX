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

public class UIHintDialog : UIManagerBase // TypeDefIndex: 6966
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private static DialogMode dmode_; // 0x00
	private readonly float POPUP_KEY_WAIT_SEC; // 0x38
	private float fPopupKeyWaitTime_; // 0x3C
	private readonly string[] LanguageExt; // 0x40
	private HintDialogWindow detail_; // 0x48
	private ActionType act_; // 0x50
	private GameObject objCaption_; // 0x58
	private GameObject objGuideMessage_; // 0x60
	private GameObject objPopup_; // 0x68
	private Mode mode_; // 0x70
	private LoadScreenDisplay LoadScreen; // 0x78
	private int pageNum_; // 0x80
	private int pageNo_; // 0x84
	private string[] detailStr_; // 0x88
	private string[] imageStr_; // 0x90
	private bool bPageFirst; // 0x98

	// Nested types
	private enum DialogMode // TypeDefIndex: 6967
	{
		Basic = 0,
		OperationGround = 1,
		OperationDungeon1 = 2,
		OperationDungeon2 = 3,
		TypeIcon = 4
	}

	public class HintDialogWindowBase : UIWindowBase // TypeDefIndex: 6968
	{
		// Fields
		private UIControlTMP textCaption_; // 0x30
		private UIControlTMP textDetail_; // 0x38
		private UIScrollView scScrollView_; // 0x40
		private GameObject guide_; // 0x48

		// Constructors
		public HintDialogWindowBase() {} // 0x00A890A0-0x00A890B0

		// Methods
		public override void Init(GameObject detail) {} // 0x00A890B0-0x00A89380
		public void updateCaption() {} // 0x00A89380-0x00A89430
		public void setTextCaption(string sText) {} // 0x00A88460-0x00A88520
		public void setTextDetail(string sText) {} // 0x00A87620-0x00A877F0
		public void setTextDetail(int textId) {} // 0x00A89430-0x00A89530
		public void updateScrollView() {} // 0x00A89530-0x00A895D0
		public bool IsScroll() => default; // 0x00A895D0-0x00A89600
		protected override void _doUpdate() {} // 0x00A89600-0x00A89710
		private bool _doLinkStart() => default; // 0x00A89710-0x00A89860
	}

	public class HintDialogWindow : HintDialogWindowBase // TypeDefIndex: 6970
	{
		// Constructors
		public HintDialogWindow() {} // 0x00A86E40-0x00A86E50
	}

	public enum ActionType // TypeDefIndex: 6971
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	public enum Mode // TypeDefIndex: 6972
	{
		HintMenu = 0,
		HintPopup = 1
	}

	// Constructors
	public UIHintDialog() {} // 0x00A88890-0x00A88BA0
	static UIHintDialog() {} // 0x00A88BA0-0x00A88BB0

	// Methods
	public static UIHintDialog Create(HintParameter hint = null) => default; // 0x00A86A80-0x00A86D50
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x006131FB */) {} // 0x00A86D50-0x00A86E40
	public void Destruct() {} // 0x00A86E50-0x00A86F20
	private void setImagePage(int page_no) {} // 0x00A86F20-0x00A87600
	public string GetLanguageExt() => default; // 0x00A877F0-0x00A878A0
	public void Init(HintParameter hint, Mode md = Mode.HintMenu /* Metadata: 0x006131FC */) {} // 0x00A878A0-0x00A88460
	public void SetLoadMenu(LoadScreenDisplay mng) {} // 0x00A88520-0x00A88530
	// [IteratorStateMachine] // 0x006290E0-0x00629150
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00A88530-0x00A885B0
	public void Continue() {} // 0x00A885E0-0x00A885F0
	public bool GetEnable() => default; // 0x00A885F0-0x00A88600
	public void SetEnable(bool setBool) {} // 0x00A88600-0x00A88610
	private void Start() {} // 0x00A88610-0x00A88620
	private void Update() {} // 0x00A88620-0x00A887F0
	protected virtual bool _doCancel() => default; // 0x00A887F0-0x00A88890
}

