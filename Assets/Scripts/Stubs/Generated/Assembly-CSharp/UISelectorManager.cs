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

public class UISelectorManager // TypeDefIndex: 7546
{
	// Fields
	private List<UISelectItem> itemList_; // 0x10
	private UISelectItem itemEx_; // 0x18
	protected List<UISelectorBase> selectorList_; // 0x20
	private ViewType eView_; // 0x28
	private LoopType eLoop_; // 0x2C
	private int pageCount_; // 0x30
	private int pageIndex_; // 0x34
	private int selectorRowCount_; // 0x38
	private int selectorColumnCount_; // 0x3C

	// Properties
	public ViewType viewType { get => default; } // 0x00DF95D0-0x00DF95E0 
	public LoopType loopType { get => default; } // 0x00DF95E0-0x00DF95F0 
	public int ItemCount { get => default; } // 0x00DF9980-0x00DF99D0 
	public int SelectorCount { get => default; } // 0x00DFA7E0-0x00DFA830 

	// Nested types
	public enum ViewType // TypeDefIndex: 7547
	{
		PAGE = 0,
		SCROLL = 1
	}

	public enum LoopType // TypeDefIndex: 7548
	{
		DISABLE = 0,
		LOOP = 1,
		WRAPAROUND = 2
	}

	// Constructors
	public UISelectorManager() {} // Dummy constructor
	public UISelectorManager(ViewType eView, LoopType eLoop) {} // 0x00DF95F0-0x00DF96B0

	// Methods
	public bool IsPageView() => default; // 0x00DF96B0-0x00DF96C0
	public bool IsScrollView() => default; // 0x00DF96C0-0x00DF96D0
	public int GetPageNumber() => default; // 0x00DF96D0-0x00DF96E0
	public int GetPageCount() => default; // 0x00DF96E0-0x00DF96F0
	public int GetRowCount() => default; // 0x00DF96F0-0x00DF9700
	public int GetColumnCount() => default; // 0x00DF9700-0x00DF9710
	public UISelectItem SetItemEx(UISelectItem item) => default; // 0x00DF9710-0x00DF97D0
	public bool EixistItemEx() => default; // 0x00DF9870-0x00DF9880
	public bool IsItemExPage() => default; // 0x00DF9880-0x00DF98C0
	public void ClearItem() {} // 0x00DF98C0-0x00DF9910
	public UISelectItem AddItem(UISelectItem item) => default; // 0x00DF9910-0x00DF9980
	// [IteratorStateMachine] // 0x0062D3B0-0x0062D420
	public IEnumerable<UISelectItem> GetItem() => default; // 0x00DF99D0-0x00DF9A50
	public UISelectItem GetItem(int index) => default; // 0x00DF9A90-0x00DF9B30
	public UISelectItem FindItem(int itemId) => default; // 0x00DF9B30-0x00DF9C70
	public bool SortItem(int mode) => default; // 0x00DF9C70-0x00DF9ED0
	private static bool checkLine(UISelectItem s) => default; // 0x00DFA530-0x00DFA540
	public bool DeleteSelectItem() => default; // 0x00DFA540-0x00DFA600
	public void UpdatePageCount() {} // 0x00DF97D0-0x00DF9870
	private void _calcRowCount() {} // 0x00DFA600-0x00DFA6F0
	public void SetColumnCount(int columnCount) {} // 0x00DFA6F0-0x00DFA710
	public void ClearSelector() {} // 0x00DFA710-0x00DFA770
	public UISelectorBase AddSelector(UISelectorBase selector) => default; // 0x00DFA770-0x00DFA7E0
	// [IteratorStateMachine] // 0x0062D420-0x0062D490
	public IEnumerable<UISelectorBase> GetSelector() => default; // 0x00DFA830-0x00DFA8B0
	public int GetActiveSelectorCount() => default; // 0x00DFA8F0-0x00DFAA10
	public UISelectorBase FindSelector(int itemId) => default; // 0x00DFAA10-0x00DFAB50
	public UISelectorBase FindSelector(UISelectItem item) => default; // 0x00DFAB50-0x00DFAB60
	public void AttachItem(int topItemPos) {} // 0x00DFA140-0x00DFA470
	public void AttachItemId(int itemId) {} // 0x00DFAB60-0x00DFAE70
	public bool AttachFace(int selectorPos, GameObject face) => default; // 0x00DFAE70-0x00DFAF20
	public bool UnFocus() => default; // 0x00DFA010-0x00DFA140
	public bool SetFocus(int selectorPos) => default; // 0x00DFA470-0x00DFA530
	public bool SetFocusItem(int itemId) => default; // 0x00DFAF20-0x00DFAF60
	public bool FocusNextColumn(bool bNext) => default; // 0x00DFAF60-0x00DFB0C0
	public bool CheckMoveFocusNextColumn(bool bNext) => default; // 0x00DFB0C0-0x00DFB1A0
	public bool FocusNextRow(bool bNext) => default; // 0x00DFB1A0-0x00DFB470
	public bool FocusNextSequence(bool bNext) => default; // 0x00DFB5D0-0x00DFB6C0
	public bool ChangeNextPage(bool bNext, bool bLoop = true /* Metadata: 0x00613818 */) => default; // 0x00DFB6C0-0x00DFB7F0
	public bool FocusNextColumnPage(bool bNext, bool bPageLoop = true /* Metadata: 0x00613819 */) => default; // 0x00DFB7F0-0x00DFB9B0
	public UISelectorBase GetFocusSelector() => default; // 0x00DF9EE0-0x00DFA010
	public bool IsEnableFocusItem() => default; // 0x00DFB9B0-0x00DFB9F0
	public void SetSelectFocus(bool bSet = true /* Metadata: 0x0061381A */) {} // 0x00DFB9F0-0x00DFBA30
	public void ChangeSelectFocus() {} // 0x00DFBA30-0x00DFBA70
	public void UpdateFace(bool bForce = false /* Metadata: 0x0061381B */) {} // 0x00DFBA70-0x00DFBC10
	public void SetAllFaceDirty() {} // 0x00DFBC10-0x00DFBD20
	public void SetItemDirty(UISelectItem item) {} // 0x00DFBD20-0x00DFBE40
	public void SetItemDirty(int itemId) {} // 0x00DFBE40-0x00DFBF70
	public UISelectItem GetSelectItem(int count) => default; // 0x00DFBF70-0x00DFC0E0
	// [IteratorStateMachine] // 0x0062D490-0x0062D500
	public IEnumerable<UISelectItem> GetSelectItem() => default; // 0x00DFC0E0-0x00DFC160
	// [IteratorStateMachine] // 0x0062D500-0x0062D570
	public IEnumerable<int> GetSelectItemIds() => default; // 0x00DFC1A0-0x00DFC220
	public void SetAllSelectItem(bool bSet) {} // 0x00DFC260-0x00DFC3D0
	public void ClearAllSelectItem() {} // 0x00DFC3D0-0x00DFC3E0
	public int GetViewTopPosition() => default; // 0x00DFB470-0x00DFB5D0
	public float GetMaxPrefferdWidth() => default; // 0x00DFC3E0-0x00DFC590
	public void ChangeFaceWidth(float width) {} // 0x00DFC590-0x00DFC6C0
}

