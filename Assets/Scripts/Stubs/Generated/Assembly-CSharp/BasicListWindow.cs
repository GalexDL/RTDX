/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class BasicListWindow : ListWindowBase // TypeDefIndex: 6118
{
	// Fields
	protected UIBasicList list_; // 0x48
	protected int lastCursorSelectorId_; // 0x50
	protected bool bResumeClearSelect_; // 0x54
	protected bool bEnableMultiSelect_; // 0x55
	protected bool bEnableCancel_; // 0x56
	protected bool bEnableDecide_; // 0x57
	private int nRightPressAnimation_; // 0x58
	private bool bRightPressAnimationPlaying_; // 0x5C
	private int nLeftPressAnimation_; // 0x60
	private bool bLeftPressAnimationPlaying_; // 0x64
	private GameObject nameObject_; // 0x68
	protected GameObject refineSortInfoText; // 0x70
	private FilterStatus oldStatus_; // 0x78
	private CommonSortRefineWindow.ListItem.Label oldLabel_; // 0x7C
	private Const.pokemon.Type oldType_; // 0x80

	// Properties
	public bool EnableMultiSelect { get => default; set {} } // 0x008B8B40-0x008B8B50 0x008B8B30-0x008B8B40
	public bool EnableCancel { get => default; set {} } // 0x008B8B60-0x008B8B70 0x008B8B50-0x008B8B60
	public bool EnableDecide { get => default; set {} } // 0x008B8B80-0x008B8B90 0x008B8B70-0x008B8B80
	public CommonSortRefineWindow.ListItem.Label OldLabel { get => default; } // 0x008BAB80-0x008BAB90 
	public Const.pokemon.Type OldType { get => default; } // 0x008BABA0-0x008BABB0 

	// Nested types
	public class InitParam // TypeDefIndex: 6119
	{
		// Fields
		public UISelectorManager.ViewType viewType; // 0x10
		public UISelectorManager.LoopType loopType; // 0x14
		public Func<int, UISelectItem> funcCreateItem; // 0x18
		public Func<int, UISelectorBase> funcCreateSelector; // 0x20
		public int defaultIndex; // 0x28
		public bool enableMultiSelect; // 0x2C
		public bool enableCancel; // 0x2D
		public bool enableDecide; // 0x2E
		public bool enableSeDecide; // 0x2F
		public string listComponentTag; // 0x30
		public bool fitting; // 0x38
		public int fittingRowLimit; // 0x3C
		public int listMinimumEnsure; // 0x40

		// Constructors
		public InitParam() {} // 0x008BB700-0x008BB770
	}

	public enum FilterStatus // TypeDefIndex: 6120
	{
		None = 0,
		Refine = 1,
		Sort = 2
	}

	// Constructors
	public BasicListWindow() {} // 0x008BB070-0x008BB090

	// Methods
	protected override bool _setEnable(bool bEnable) => default; // 0x008B8B90-0x008B8C30
	protected override void _doInput() {} // 0x008B8C30-0x008B8E60
	protected virtual bool _doUp() => default; // 0x008B8E60-0x008B8ED0
	protected virtual bool _doDown() => default; // 0x008B8ED0-0x008B8F40
	protected virtual bool _doLeft() => default; // 0x008B8F40-0x008B8FC0
	protected virtual bool _doRight() => default; // 0x008B8FC0-0x008B9050
	protected virtual bool _doAllSelect() => default; // 0x008B9050-0x008B90C0
	protected virtual bool _doItemSelect(bool decide) => default; // 0x008B90C0-0x008B9130
	protected virtual bool _onXButton() => default; // 0x008B9130-0x008B9140
	protected virtual bool _onYButton() => default; // 0x008B9140-0x008B9150
	protected virtual bool _doListSort() => default; // 0x008B9150-0x008B9160
	protected virtual bool _doDecide() => default; // 0x008B9160-0x008B9220
	protected virtual bool _doCancel() => default; // 0x008B9220-0x008B92A0
	protected virtual void _changeFocus() {} // 0x008B92A0-0x008B93E0
	protected virtual void _changePage() {} // 0x008B93E0-0x008B9430
	protected virtual void _updatePageNumber() {} // 0x008B9430-0x008B96A0
	public bool IsLRAnimationPlaying() => default; // 0x008B96A0-0x008B96C0
	// [IteratorStateMachine] // 0x006244C0-0x00624530
	private IEnumerator _pressRightPageAnimation(GameObject obj) => default; // 0x008B96C0-0x008B9740
	protected virtual void _pressRightPage() {} // 0x008B9770-0x008B9900
	// [IteratorStateMachine] // 0x00624530-0x006245A0
	private IEnumerator _pressLeftPageAnimation(GameObject obj) => default; // 0x008B9900-0x008B9980
	protected virtual void _pressLeftPage() {} // 0x008B99B0-0x008B9B40
	public void Continue(bool forceClear = false /* Metadata: 0x006125E3 */) {} // 0x008B9B40-0x008B9BF0
	public void SetRefineSortInfo_Continue() {} // 0x008BA530-0x008BA540
	public void Continue(int selectorId) {} // 0x008BA540-0x008BA5D0
	public void Init(GameObject objRoot, InitParam param, bool is_own = false /* Metadata: 0x006125E4 */) {} // 0x008BA5D0-0x008BAAE0
	public void End() {} // 0x008BAAE0-0x008BAB80
	public void ResetOld() {} // 0x008BAB90-0x008BABA0
	public void SetRefineSortInfo(FilterStatus status, CommonSortRefineWindow.ListItem.Label label, Const.pokemon.Type type = Const.pokemon.Type.NONE /* Metadata: 0x006125E5 */) {} // 0x008B9BF0-0x008BA530
	public void SetItemEx(UISelectItem selectItemEx) {} // 0x008BABB0-0x008BAC60
	// [IteratorStateMachine] // 0x006245A0-0x00624610
	public IEnumerator MainFlow(Action<int> resultCb) => default; // 0x008BAC60-0x008BACE0
	public int GetFocusIndex() => default; // 0x008BAD10-0x008BAD70
	public int GetSelectIndex() => default; // 0x008BAD70-0x008BAEB0
	public int GetFocusItemNumber() => default; // 0x008BAEB0-0x008BB070
}

