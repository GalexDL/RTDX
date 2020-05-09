/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class FlowWarehouse : FlowPlay // TypeDefIndex: 5386
{
	// Fields
	private UIWarehouse menu_; // 0x90
	private FlowPlayParam param_; // 0x98
	private LastUIType lastUIType_; // 0xA0
	private int sel; // 0xA4
	private int henseiIndex_; // 0xA8
	private IItem selectTrueItem_; // 0xB0
	private List<IItem> deleteList; // 0xB8

	// Properties
	public FlowPlayParam Param { get => default; } // 0x009A8DE0-0x009A8DF0 

	// Nested types
	private enum LastUIType // TypeDefIndex: 5387
	{
		NONE = 0,
		DEPOSIT = 1,
		DRAW = 2,
		MAX = 3
	}

	// Constructors
	private FlowWarehouse() {} // 0x009A8D60-0x009A8DE0

	// Methods
	public static FlowWarehouse Create() => default; // 0x009A31A0-0x009A3250
	// [IteratorStateMachine] // 0x006200A0-0x00620110
	public override IEnumerator Play(UIManagerBase m, FlowPlayParam param) => default; // 0x009A8DF0-0x009A8E70
	// [IteratorStateMachine] // 0x00620110-0x00620180
	private IEnumerator MoveNext_OpenSubWindow() => default; // 0x009A8EA0-0x009A8F10
	// [IteratorStateMachine] // 0x00620180-0x006201F0
	private IEnumerator MoveNext_CloseSubWindow() => default; // 0x009A8F40-0x009A8FB0
	// [IteratorStateMachine] // 0x006201F0-0x00620260
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x009A8FE0-0x009A9060
	private void MoveNextConfirmDeposit(UIWarehouse menu) {} // 0x009A9090-0x009A9850
	private void MoveNextDeleteDepositItem() {} // 0x009A9850-0x009A9980
	private void MoveNextConfirmDraw(int drawCount, UIWarehouse menu) {} // 0x009A9980-0x009A9F70
	private void MoveNextCheckWarehouseStock() {} // 0x009A9F70-0x009AA070
	public void MoveNextBagItemZeroCheck_Warehouse() {} // 0x009AA070-0x009AA140
	protected override Const.creature.Index GetMasterIndex() => default; // 0x009AA140-0x009AA150
	public override void OpenFaceWindow(FlowPlayType playType) {} // 0x009AA150-0x009AA1A0
	protected override Const.creature.Index GetPokemonData() => default; // 0x009AA1A0-0x009AA1B0
	protected override IItem GetSelectTrueItemData() => default; // 0x009AA1B0-0x009AA1C0
	protected override Const.item.Index GetItemData() => default; // 0x009AA1C0-0x009AA2F0
	public void MoveNext_CheckSelectItemCount() {} // 0x009AA2F0-0x009AA310
	private void CheckDeposit() {} // 0x009AA310-0x009AA430
	private void CheckDraw() {} // 0x009AA430-0x009AA510
}

