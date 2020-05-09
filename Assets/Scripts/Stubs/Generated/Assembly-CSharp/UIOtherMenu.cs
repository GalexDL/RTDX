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

public class UIOtherMenu : UIManagerBase // TypeDefIndex: 7307
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private BasicListWindow listMenu_; // 0x38
	private ModeType mode_; // 0x40
	private ActionType act_; // 0x44
	private GameObject objCaption_; // 0x48
	private GameObject objGuideMessage_; // 0x50
	private LoadScreenDisplay LoadScreen; // 0x58
	private int[] aMessageGuideIndex_; // 0x60

	// Nested types
	public enum MenuItem // TypeDefIndex: 7308
	{
		None = -1,
		HowToPlay = 0,
		MesseageLog = 1,
		Option = 2,
		GotoStart = 3,
		SaveTopMenu = 4,
		LeaderChange = 5,
		DungeonStatus = 6,
		GiveUp = 7,
		KeywordLink = 8,
		NumMenuItem = 9
	}

	public class MenuParam // TypeDefIndex: 7309
	{
		// Fields
		public MenuItem menuItem; // 0x10
		public bool bDisable; // 0x14

		// Constructors
		public MenuParam() {} // 0x00C7CD20-0x00C7CD50
	}

	private class OtherMenuWindow : BasicListWindow // TypeDefIndex: 7310
	{
		// Fields
		protected List<MenuParam> aMenuParam_; // 0x88

		// Constructors
		public OtherMenuWindow() {} // 0x00C7E940-0x00C7E950

		// Methods
		public virtual void OnStart() {} // 0x00C7E7B0-0x00C7E7C0
		public virtual void ResetFocus(int itemId) {} // 0x00C7E7C0-0x00C7E810
		protected virtual int _menuItemIndexOf(MenuItem item) => default; // 0x00C7E810-0x00C7E940
	}

	public enum ModeType // TypeDefIndex: 7311
	{
		Ground = 0,
		Dungeon = 1
	}

	public enum ActionType // TypeDefIndex: 7312
	{
		None = 0,
		Decide = 1,
		Cancel = 2,
		CancelExit = 3,
		CancelGotoTop = 4
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7313
	{
		// Fields
		private MenuItem item_; // 0x18
		public bool bDisable; // 0x1C

		// Properties
		public MenuItem Item { get => default; set {} } // 0x00C7CF40-0x00C7CF50 0x00C7D510-0x00C7D520

		// Constructors
		public UILocalSelectItem() {} // 0x00C7D500-0x00C7D510
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7314
	{
		// Constructors
		public UILocalSelector() {} // 0x00C7D3A0-0x00C7D410

		// Methods
		protected override void SetupFace() {} // 0x00C7E950-0x00C7EC40
	}

	// Constructors
	public UIOtherMenu() {} // 0x00C7D200-0x00C7D260

	// Methods
	private static string getMenuItemString(MenuItem item) => default; // 0x00C7BA20-0x00C7BE50
	public static UIOtherMenu Create() => default; // 0x00C7BE50-0x00C7BFC0
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x006135E7 */) {} // 0x00C7BFC0-0x00C7C0B0
	public void Destruct() {} // 0x00C7C0B0-0x00C7C180
	public void Init(ModeType mode, MenuItem defaultItem = MenuItem.None /* Metadata: 0x006135E8 */) {} // 0x00C7C180-0x00C7CD10
	public void SetLoadMenu(LoadScreenDisplay mng) {} // 0x00C7CD50-0x00C7CD60
	// [IteratorStateMachine] // 0x0062BB20-0x0062BB90
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00C7CD60-0x00C7CDE0
	public void Continue() {} // 0x00C7CE10-0x00C7CE30
	public MenuItem GetSelectMenu() => default; // 0x00C7CE30-0x00C7CF40
	public bool IsDisableSelectMenu() => default; // 0x00C7CF50-0x00C7D060
	public bool GetEnable() => default; // 0x00C7D060-0x00C7D070
	public void SetEnable(bool setBool) {} // 0x00C7D070-0x00C7D080
	private void _cbFromListMenu(ListWindowBase.ActionType act) {} // 0x00C7D080-0x00C7D1D0
	private void Start() {} // 0x00C7D1D0-0x00C7D1E0
	private void Update() {} // 0x00C7D1E0-0x00C7D200
}

