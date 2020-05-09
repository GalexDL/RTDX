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

public class TitleRename : MonoBehaviour // TypeDefIndex: 5738
{
	// Fields
	private ActTypes act; // 0x18
	private RenameResult result; // 0x1C
	private TitleRenameSelect renameSelectScreen; // 0x20
	private bool bEnd; // 0x28
	private bool bOperate; // 0x29
	private CommonScreen commonScreen_; // 0x30

	// Nested types
	public enum ActTypes // TypeDefIndex: 5739
	{
		NONE = 0,
		INIT = 1,
		SELECT = 2,
		DECIDE = 3,
		CANCEL = 4,
		END = 5
	}

	public enum RenameResult // TypeDefIndex: 5740
	{
		NONE = 0,
		HERO = 1,
		PARTNER = 2,
		TEAM = 3,
		CANCEL = 4
	}

	private class TitleRenameSelect : UIWindowBase // TypeDefIndex: 5741
	{
		// Fields
		protected GameObject root_; // 0x30
		private TitleFlowToolBox m_toolBox; // 0x38
		private GameObject HeroWindow; // 0x40
		private GameObject TeamWindow; // 0x48
		private GameObject PartnerWindow; // 0x50
		private UIControlTMPSetter GuideMessage; // 0x58
		private RenameResult menuItem; // 0x60
		private CallbackAction callbackFunc_; // 0x68

		// Properties
		public TitleFlowToolBox ToolBox { get => default; } // 0x007D7120-0x007D7130 

		// Nested types
		public delegate void CallbackAction(ActTypes action); // TypeDefIndex: 5742; 0x007D8350-0x007D8710

		// Constructors
		public TitleRenameSelect() {} // 0x007D6710-0x007D6780

		// Methods
		public void Init(GameObject root, RenameResult initRes) {} // 0x007D6780-0x007D6A90
		public RenameResult GetMenuItem() => default; // 0x007D6F70-0x007D6F80
		private void WindowInit(GameObject windowObj, RenameResult type) {} // 0x007D7130-0x007D7AB0
		private void FocusOn(GameObject windowObj) {} // 0x007D7B10-0x007D7BE0
		private void FocusOut(GameObject windowObj) {} // 0x007D7BE0-0x007D7CB0
		private void SelectOn(GameObject windowObj) {} // 0x007D7CB0-0x007D7D80
		public void MenuUpdate() {} // 0x007D6D00-0x007D6E00
		private void GuideUpdate(RenameResult type) {} // 0x007D7AB0-0x007D7B10
		private bool doDecide() => default; // 0x007D7D80-0x007D7E80
		private bool doCancel() => default; // 0x007D7E80-0x007D7F50
		private bool doRight() => default; // 0x007D7F50-0x007D80D0
		private bool doLeft() => default; // 0x007D80D0-0x007D8250
		public void RegisterActionListener(CallbackAction cb) {} // 0x007D6AA0-0x007D6B90
		public void UnregisterActionListener(CallbackAction cb) {} // 0x007D8260-0x007D8350
		public void callAction(ActTypes action) {} // 0x007D8250-0x007D8260
	}

	// Constructors
	public TitleRename() {} // 0x007D6F80-0x007D6F90

	// Methods
	public static TitleRename Create() => default; // 0x007D1640-0x007D17A0
	public void Construct() {} // 0x007D6620-0x007D6710
	public void Init(RenameResult initRes) {} // 0x007D17A0-0x007D1880
	// [IteratorStateMachine] // 0x00621810-0x00621880
	public IEnumerator MainFlow(Action<ActTypes> cb = null) => default; // 0x007D1880-0x007D1900
	public void RenameUpdate() {} // 0x007D6CE0-0x007D6D00
	public RenameResult GetResult() => default; // 0x007D1900-0x007D1910
	private void _OpenRenameSelect() {} // 0x007D6B90-0x007D6CB0
	private void _cbFromRenameWindow(ActTypes act_) {} // 0x007D6E00-0x007D6F70
}

