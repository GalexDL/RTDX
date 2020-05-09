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

internal class FlowKakureon : FlowPlay // TypeDefIndex: 5294
{
	// Fields
	private bool m_bSpecial; // 0x90
	private bool m_bBuyInvitation; // 0x91
	private bool overBagMoney_; // 0x92
	private bool overBankMoney_; // 0x93
	private int bagOverValue_; // 0x94

	// Properties
	public bool Special { set {} } // 0x0081B110-0x0081B120

	// Constructors
	private FlowKakureon() {} // 0x0081B120-0x0081B190

	// Methods
	public static FlowKakureon Create() => default; // 0x0081B190-0x0081B240
	// [IteratorStateMachine] // 0x0061EE70-0x0061EEE0
	public override IEnumerator Play(UIManagerBase m, FlowPlayParam param) => default; // 0x0081B240-0x0081B2C0
	// [IteratorStateMachine] // 0x0061EEE0-0x0061EF50
	private IEnumerator MoveNext_OpenSubWindow() => default; // 0x0081B2F0-0x0081B360
	// [IteratorStateMachine] // 0x0061EF50-0x0061EFC0
	private IEnumerator MoveNext_CloseSubWindow() => default; // 0x0081B390-0x0081B400
	private void MoveNextConfirmBuy() {} // 0x0081B430-0x0081B7A0
	private void MoveNextConfirmSell() {} // 0x0081B7A0-0x0081BB00
	private void MoveNext_IsOverBagMoney() {} // 0x0081BB00-0x0081BB50
	private void MoveNext_IsOverBank() {} // 0x0081BB50-0x0081BBA0
	private void MoveNext_MoneyAddBank() {} // 0x0081BBA0-0x0081BCA0
	private void BagItemMaxCheck() {} // 0x0081BCA0-0x0081BD40
	protected override IItem GetSelectTrueItemData() => default; // 0x0081BD40-0x0081BE00
	protected override Const.item.Index GetItemData() => default; // 0x0081BE00-0x0081BE10
	protected override int GetMoneyData() => default; // 0x0081BE10-0x0081BFE0
	protected override Const.creature.Index GetMasterIndex() => default; // 0x0081BFE0-0x0081C000
	protected override Const.creature.Index GetPokemonData() => default; // 0x0081C000-0x0081C010
	private void CheckBuyInvitaion() {} // 0x0081C010-0x0081C150
	private void IsBuyInvitation() {} // 0x0081C150-0x0081C190
	private void MoveNextCheckBuyList() {} // 0x0081C190-0x0081C200
}

