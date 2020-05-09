/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class FlowBank : FlowPlay // TypeDefIndex: 5253
{
	// Fields
	private UIBank menu_; // 0x90
	private FlowPlayParam param_; // 0x98
	private int sel; // 0xA0
	private int henseiIndex_; // 0xA4

	// Properties
	public FlowPlayParam Param { get => default; } // 0x00810920-0x00810930 

	// Constructors
	private FlowBank() {} // 0x00810800-0x00810870

	// Methods
	public static FlowBank Create() => default; // 0x00810870-0x00810920
	// [IteratorStateMachine] // 0x0061E330-0x0061E3A0
	public override IEnumerator Play(UIManagerBase m, FlowPlayParam param) => default; // 0x00810930-0x008109B0
	// [IteratorStateMachine] // 0x0061E3A0-0x0061E410
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x008109E0-0x00810A60
	protected override Index GetMasterIndex() => default; // 0x00810A90-0x00810AA0
	protected override int GetMoneyData() => default; // 0x00810AA0-0x00810B80
	protected override Index GetPokemonData() => default; // 0x00810B80-0x00810B90
	public override void OpenFaceWindow(FlowPlayType playType) {} // 0x00810B90-0x00810BE0
	private void MoveNext_DonationNode() {} // 0x00810BE0-0x00810CF0
	private void MoveNextConfirmBankDeposit(int depositCount) {} // 0x00810CF0-0x00810E60
	private void MoveNextConfirmBankDraw(int drawCount) {} // 0x00810E60-0x00810FD0
	private void MoveNext_CheckBankBonus() {} // 0x00810FD0-0x00811060
	// [IteratorStateMachine] // 0x0061E410-0x0061E480
	private IEnumerator MoveNext_BankBonus_Reward() => default; // 0x00811060-0x008110D0
}

