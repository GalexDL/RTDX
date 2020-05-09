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

public class UIHintMenu : UIManagerBase // TypeDefIndex: 6976
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private HintListWindow listMenu_; // 0x38
	private ActionType act_; // 0x40
	private GameObject objCaption_; // 0x48
	private GameObject objGuideMessage_; // 0x50
	private LoadScreenDisplay LoadScreen; // 0x58

	// Nested types
	public class HintMenuParam // TypeDefIndex: 6977
	{
		// Fields
		public HintParameter hintMenuItem; // 0x10
		public bool bDisable; // 0x18

		// Constructors
		public HintMenuParam() {} // 0x00A89A00-0x00A89A30
	}

	private class HintMenuWindow : BasicListWindow // TypeDefIndex: 6978
	{
		// Fields
		protected List<HintMenuParam> aMenuParam_; // 0x88

		// Constructors
		public HintMenuWindow() {} // 0x00A8A800-0x00A8A810

		// Methods
		public virtual void OnStart() {} // 0x00A8A670-0x00A8A680
		public virtual void ResetFocus(int itemId) {} // 0x00A8A680-0x00A8A6D0
		protected virtual int _menuItemIndexOf(HintParameter item) => default; // 0x00A8A6D0-0x00A8A800
	}

	public class HintListWindow : BasicListWindow // TypeDefIndex: 6979
	{
		// Constructors
		public HintListWindow() {} // 0x00A899E0-0x00A899F0

		// Methods
		private void resetIconAnimation() {} // 0x00A8A4C0-0x00A8A630
		protected override void _changePage() {} // 0x00A8A640-0x00A8A670
	}

	public enum ActionType // TypeDefIndex: 6980
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6981
	{
		// Fields
		private HintParameter item_; // 0x18

		// Properties
		public HintParameter Item { get => default; set {} } // 0x00A89B90-0x00A89BA0 0x00A89F80-0x00A89F90

		// Constructors
		public UILocalSelectItem() {} // 0x00A89F70-0x00A89F80
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6982
	{
		// Fields
		private bool syncIcon_; // 0x29

		// Properties
		public bool SyncIcon { get => default; set {} } // 0x00A8A810-0x00A8A820 0x00A8A630-0x00A8A640

		// Constructors
		public UILocalSelector() {} // 0x00A89DD0-0x00A89E40

		// Methods
		protected override void SetupFace() {} // 0x00A8A820-0x00A8AC10
		protected override bool FaceDisable() => default; // 0x00A8AC10-0x00A8AC30
	}

	// Constructors
	public UIHintMenu() {} // 0x00A89C80-0x00A89C90

	// Methods
	public static UIHintMenu Create() => default; // 0x00A85AA0-0x00A85C10
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x00613228 */) {} // 0x00A898F0-0x00A899E0
	public void Destruct() {} // 0x00A864C0-0x00A86590
	public void Init(string category = null) {} // 0x00A85C10-0x00A86440
	public void SetLoadMenu(LoadScreenDisplay mng) {} // 0x00A89A30-0x00A89A40
	// [IteratorStateMachine] // 0x00629150-0x006291C0
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00A86440-0x00A864C0
	public void Continue() {} // 0x00A89A70-0x00A89A90
	public HintParameter GetSelectMenu() => default; // 0x00A89A90-0x00A89B90
	public bool GetEnable() => default; // 0x00A89BA0-0x00A89BB0
	public void SetEnable(bool setBool) {} // 0x00A89BB0-0x00A89BC0
	private void _cbFromListMenu(ListWindowBase.ActionType act) {} // 0x00A89BC0-0x00A89C20
	private void Start() {} // 0x00A89C20-0x00A89C30
	private void Update() {} // 0x00A89C30-0x00A89C80
}

