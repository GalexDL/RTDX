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

public class UIMessageLogDialog : UIManagerBase // TypeDefIndex: 7100
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private MessageLogDialogWindow dialog_; // 0x38
	private ActionType act_; // 0x40
	private GameObject objCaption_; // 0x48
	private GameObject objGuideMessage_; // 0x50
	private bool bCommonClose; // 0x58

	// Nested types
	public class MessageLogDialogWindow : UIWindowBase // TypeDefIndex: 7101
	{
		// Fields
		private UIControlTMP textCaption_; // 0x30
		private List<UIControlTMP> textDetails_; // 0x38
		private List<string> textList_; // 0x40
		private GameObject guide_; // 0x48
		private bool visibleScrollBar; // 0x50
		private GameObject scrollPointer_; // 0x58
		private GameObject scrollBar_; // 0x60
		private UIScrollView scScrollView_; // 0x68
		private int listIndex_; // 0x70
		private float basePos_; // 0x74
		private float mvParLine_; // 0x78
		private int maxIndex_; // 0x7C
		private int doUpActCount; // 0x80
		private int doDownActCount; // 0x84
		private int waitFrame; // 0x88

		// Constructors
		public MessageLogDialogWindow() {} // 0x00951AC0-0x00951AD0

		// Methods
		public override void Init(GameObject detail) {} // 0x00952AA0-0x00952F10
		public void setTextCaption(string sText) {} // 0x00951D30-0x00951DF0
		public void initTextDetails(List<string> sText, bool bGuideVisible) {} // 0x00951DF0-0x009522D0
		public void SetScrollPointer(int index) {} // 0x00952F10-0x00952FB0
		public void SetFace(int index) {} // 0x00952FB0-0x009531D0
		public List<UIControlTMP> GetTextDetails() => default; // 0x009526A0-0x009526B0
		protected override void _doUpdate() {} // 0x009531D0-0x00953330
		protected bool doUp() => default; // 0x00953330-0x00953360
		protected bool doDown() => default; // 0x00953360-0x00953390
	}

	public enum ActionType // TypeDefIndex: 7102
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	// Constructors
	public UIMessageLogDialog() {} // 0x009526B0-0x009526C0

	// Methods
	public static UIMessageLogDialog Create() => default; // 0x00951860-0x009519D0
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x006133BD */) {} // 0x009519D0-0x00951AC0
	public void Destruct() {} // 0x00951AD0-0x00951BA0
	public void Init() {} // 0x00951BA0-0x00951D30
	public void SetCommonClose() {} // 0x009522D0-0x009522E0
	// [IteratorStateMachine] // 0x0062A100-0x0062A170
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x009522E0-0x00952360
	public void SetEnable(bool setBool) {} // 0x00952390-0x009523A0
	private void Start() {} // 0x009523A0-0x009523B0
	private void Update() {} // 0x009523B0-0x009524A0
	protected virtual bool _doCancel() => default; // 0x00952600-0x009526A0
	private bool _doLinkStart() => default; // 0x009524A0-0x00952600
}

