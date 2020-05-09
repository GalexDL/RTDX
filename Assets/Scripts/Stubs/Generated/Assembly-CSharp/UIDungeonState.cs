/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon.status;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonState : UIManagerBase // TypeDefIndex: 6804
{
	// Fields
	private GameObject instance_; // 0x20
	private bool bCreateInstance_; // 0x28
	private CommonScreen commonScreen_; // 0x30
	private ExplainView explainView_; // 0x38
	private BasicListWindow listMenu_; // 0x40
	private ActionType act_; // 0x48
	private GameObject objCaption_; // 0x50
	private GameObject objGuideMessage_; // 0x58
	protected bool bSingleCall; // 0x60

	// Nested types
	public class DungeonStateParam // TypeDefIndex: 6805
	{
		// Fields
		public Index dungeonStateIndex; // 0x10
		public bool bDisable; // 0x14

		// Constructors
		public DungeonStateParam() {} // 0x00B27FB0-0x00B27FE0
	}

	private class DungeonStateWindow : BasicListWindow // TypeDefIndex: 6806
	{
		// Fields
		protected List<DungeonStateParam> aMenuParam_; // 0x88

		// Constructors
		public DungeonStateWindow() {} // 0x00B28A70-0x00B28A80

		// Methods
		public virtual void OnStart() {} // 0x00B288D0-0x00B288E0
		public virtual void ResetFocus(int itemId) {} // 0x00B288E0-0x00B28930
		protected virtual int _menuItemIndexOf(Index target) => default; // 0x00B28930-0x00B28A70
	}

	private class ExplainView : DetailWindowBase // TypeDefIndex: 6807
	{
		// Constructors
		public ExplainView() {} // 0x00B27FE0-0x00B27FF0
	}

	public enum ActionType // TypeDefIndex: 6808
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6809
	{
		// Fields
		private Index index_; // 0x18

		// Properties
		public Index Index { get => default; set {} } // 0x00B28260-0x00B28270 0x00B28570-0x00B28580

		// Constructors
		public UILocalSelectItem() {} // 0x00B28560-0x00B28570
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6810
	{
		// Constructors
		public UILocalSelector() {} // 0x00B28430-0x00B284A0

		// Methods
		protected override void SetupFace() {} // 0x00B28A80-0x00B28D60
	}

	// Constructors
	public UIDungeonState() {} // 0x00B282E0-0x00B282F0

	// Methods
	private static string getDungeonStatusNameString(int index) => default; // 0x00B27360-0x00B27430
	private static string getDungeonStatusExplainString(int index) => default; // 0x00B27430-0x00B27500
	public static UIDungeonState Create() => default; // 0x00B27500-0x00B27670
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x00613091 */) {} // 0x00B27670-0x00B27760
	public void Destruct() {} // 0x00B27760-0x00B27830
	public void Init() {} // 0x00B27830-0x00B27FA0
	public void SetSingleCall() {} // 0x00B27FF0-0x00B28000
	// [IteratorStateMachine] // 0x00628530-0x006285A0
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00B28000-0x00B28080
	public void Continue() {} // 0x00B280B0-0x00B280D0
	public bool GetEnable() => default; // 0x00B280D0-0x00B280E0
	public void SetEnable(bool setBool) {} // 0x00B280E0-0x00B280F0
	private void _cbFromListMenu(ListWindowBase.ActionType act) {} // 0x00B280F0-0x00B28260
	private void Start() {} // 0x00B28270-0x00B28280
	private void Update() {} // 0x00B28280-0x00B282E0
}

