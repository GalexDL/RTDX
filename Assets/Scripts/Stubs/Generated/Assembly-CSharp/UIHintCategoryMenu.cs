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

public class UIHintCategoryMenu : UIManagerBase // TypeDefIndex: 6955
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private BasicListWindow listMenu_; // 0x38
	private ActionType act_; // 0x40
	private GameObject objCaption_; // 0x48
	private GameObject objGuideMessage_; // 0x50
	private LoadScreenDisplay LoadScreen; // 0x58

	// Nested types
	public enum HintCategory // TypeDefIndex: 6956
	{
		None = -1,
		System = 0,
		Dungeon = 1,
		Status = 2,
		Wana = 3,
		FloorStatus = 4,
		Num_Category = 5
	}

	public class HintCategoryMenuParam // TypeDefIndex: 6957
	{
		// Fields
		public HintCategory categoryMenuItem; // 0x10
		public bool bDisable; // 0x14

		// Constructors
		public HintCategoryMenuParam() {} // 0x00A85130-0x00A85160
	}

	private class HintCategoryMenuWindow : BasicListWindow // TypeDefIndex: 6958
	{
		// Fields
		protected List<HintCategoryMenuParam> aMenuParam_; // 0x88

		// Constructors
		public HintCategoryMenuWindow() {} // 0x00A867B0-0x00A867C0

		// Methods
		public virtual void OnStart() {} // 0x00A86620-0x00A86630
		public virtual void ResetFocus(int itemId) {} // 0x00A86630-0x00A86680
		protected virtual int _menuItemIndexOf(HintCategory item) => default; // 0x00A86680-0x00A867B0
	}

	public enum ActionType // TypeDefIndex: 6959
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6960
	{
		// Fields
		private HintCategory item_; // 0x18

		// Properties
		public HintCategory Item { get => default; set {} } // 0x00A85350-0x00A85360 0x00A856D0-0x00A856E0

		// Constructors
		public UILocalSelectItem() {} // 0x00A856C0-0x00A856D0
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6961
	{
		// Constructors
		public UILocalSelector() {} // 0x00A85590-0x00A85600

		// Methods
		protected override void SetupFace() {} // 0x00A867C0-0x00A86A80
	}

	// Constructors
	public UIHintCategoryMenu() {} // 0x00A85440-0x00A85450

	// Methods
	private static string getCategoryName(HintCategory cat) => default; // 0x00A84410-0x00A844E0
	private static string getCategoryLabel(HintCategory cat) => default; // 0x00A844E0-0x00A84770
	public static UIHintCategoryMenu Create() => default; // 0x00A84770-0x00A848E0
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x006131D2 */) {} // 0x00A848E0-0x00A849D0
	public void Destruct() {} // 0x00A849D0-0x00A84AA0
	public void Init() {} // 0x00A84AA0-0x00A85120
	public void SetLoadMenu(LoadScreenDisplay mng) {} // 0x00A85160-0x00A85170
	// [IteratorStateMachine] // 0x00629070-0x006290E0
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00A85170-0x00A851F0
	public void Continue() {} // 0x00A85220-0x00A85240
	public HintCategory GetSelectMenu() => default; // 0x00A85240-0x00A85350
	public bool GetEnable() => default; // 0x00A85360-0x00A85370
	public void SetEnable(bool setBool) {} // 0x00A85370-0x00A85380
	private void _cbFromListMenu(ListWindowBase.ActionType act) {} // 0x00A85380-0x00A853E0
	private void Start() {} // 0x00A853E0-0x00A853F0
	private void Update() {} // 0x00A853F0-0x00A85440
}

