/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TitleFlow : UIManagerBase // TypeDefIndex: 5716
{
	// Fields
	private TitleFlowToolBox m_toolBox; // 0x20
	private States flowState; // 0x28
	private TopMenuResult result; // 0x2C
	private UIMainMenu.MenuItem menuItem; // 0x30
	private bool isTopMenuHide; // 0x34
	private bool isStartup; // 0x35
	private UIMainMenu topMenu; // 0x38
	private TitleRename renameMenu; // 0x40
	private bool bStartMode; // 0x48
	private CommonScreen commonScreen_; // 0x50
	private LoadScreenDisplay loadMenu; // 0x58

	// Properties
	public TitleFlowToolBox ToolBox { get => default; } // 0x00923650-0x00923660 

	// Nested types
	public enum States // TypeDefIndex: 5717
	{
		NONE = 0,
		INIT = 1,
		SAVELOAD = 2,
		OPENING_DEMO = 3,
		TOPMENU = 4,
		SELECTED = 5,
		RENAME = 6,
		WONDERMAIL = 7,
		END = 8,
		MAX = 9
	}

	// Constructors
	public TitleFlow() {} // 0x00923E10-0x00923E90

	// Methods
	public static TitleFlow Create() => default; // 0x00923660-0x00923700
	public void Construct() {} // 0x00923700-0x00923740
	public void StartUp() {} // 0x00923740-0x00923750
	public void Init(TopMenuResult initResult) {} // 0x00923750-0x00923850
	// [IteratorStateMachine] // 0x006213A0-0x00621410
	public IEnumerator MainFlow(Action<TopMenuResult> resultCb = null) => default; // 0x00923850-0x009238D0
	private void LateUpdate() {} // 0x009238D0-0x009239E0
	private void TopMenuUpdate() {} // 0x009239E0-0x00923BC0
	// [IteratorStateMachine] // 0x00621410-0x00621480
	public IEnumerator TopMenuFlow(Action<TopMenuResult> cb = null) => default; // 0x00923BC0-0x00923C40
	// [IteratorStateMachine] // 0x00621480-0x006214F0
	public IEnumerator LoadFlow(LoadScreenDisplay.AskTypes type, Action<bool> cb = null) => default; // 0x00923C40-0x00923CC0
	// [IteratorStateMachine] // 0x006214F0-0x00621560
	public IEnumerator CloseScreen() => default; // 0x00923CC0-0x00923D30
	// [IteratorStateMachine] // 0x00621560-0x006215D0
	public IEnumerator CloseLoadScreen() => default; // 0x00923D30-0x00923DA0
	// [IteratorStateMachine] // 0x006215D0-0x00621640
	public IEnumerator RenameMenuFlow() => default; // 0x00923DA0-0x00923E10
}

