/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemListWindow : BasicListWindow // TypeDefIndex: 6240
{
	// Fields
	protected List<IItem> ignoreList_; // 0x88
	public UICommonItemSelectItem.Firsttime discountFirst; // 0x90

	// Nested types
	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6241
	{
		// Constructors
		public UILocalSelector() {} // 0x008F9E30-0x008F9EA0

		// Methods
		protected override void SetupFace() {} // 0x008FE9D0-0x008FF420
	}

	// Constructors
	public ItemListWindow() {} // 0x008F9C80-0x008F9CF0

	// Methods
	protected void _checkIgnoreItem(UICommonItemSelectItem item) {} // 0x008FA160-0x008FA270
	protected override bool _doLeft() => default; // 0x008FDED0-0x008FDF00
	protected override bool _doRight() => default; // 0x008FDF00-0x008FDF30
	public virtual void Init(GameObject objRoot, IDataList<IItem> list, int defaultItemIndex, bool bMultiSelect = true /* Metadata: 0x00612AFA */, List<IItem> ignoreList = null) {} // 0x008FDF30-0x008FE0E0
	public void SetEquipNumber(List<IItem> equippedList) {} // 0x008FE0F0-0x008FE440
	public void SelectCaption(int select) {} // 0x008FE440-0x008FE5A0
	public UICommonItemSelectItem SetFootItem(IItem footItem) => default; // 0x008F9090-0x008F9150
	protected override void _doInput() {} // 0x008FE5A0-0x008FE680
	protected override bool _doAllSelect() => default; // 0x008FE680-0x008FE6C0
	protected override bool _onXButton() => default; // 0x008FE6C0-0x008FE6F0
	protected override bool _onYButton() => default; // 0x008FE6F0-0x008FE720
	public void ReList(IDataList<IItem> list, int defaultItemIndex) {} // 0x008F98E0-0x008F9940
}

