/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowWaza : FlowPlay // TypeDefIndex: 5394
{
	// Fields
	private UIWazaMain.States nowStates; // 0x90
	private UIWazaMain.MenuType type; // 0x94
	private UIWazaMain.RenketuMenuWindow.MenuType nextMenuType; // 0x98

	// Properties
	public UIWazaMain.States NowStates { get => default; set {} } // 0x009AB630-0x009AB640 0x009AB620-0x009AB630
	public UIWazaMain.RenketuMenuWindow.MenuType NextRenketsuStates { get => default; set {} } // 0x009AB950-0x009AB960 0x009AB960-0x009AB970

	// Constructors
	private FlowWaza() {} // 0x009AB640-0x009AB6C0

	// Methods
	public static FlowWaza Create() => default; // 0x009A3250-0x009A3300
	// [IteratorStateMachine] // 0x006202B0-0x00620320
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x009AB6C0-0x009AB740
	private bool IsPokemonSelect() => default; // 0x009AB770-0x009AB7A0
	protected override string GetWazaData() => default; // 0x009AB7A0-0x009AB860
	protected override Const.creature.Index GetMasterIndex() => default; // 0x009AB860-0x009AB870
	protected override string GetPokemonData_String() => default; // 0x009AB870-0x009AB950
	private void RenketsuTopMenu_MoveNext() {} // 0x009AB970-0x009ABA70
	private void MoveNext_RemenberWazaBeing(UIWazaMain menu) {} // 0x009ABA70-0x009ABB50
	private void MoveNext_LearnWazaBeing(UIWazaMain menu) {} // 0x009ABB50-0x009ABC30
	private void MoveNext_WazaOver2() {} // 0x009ABC30-0x009ABD10
	private void MoveNextConfirmLearn(IPokemonStatus status, Const.waza.Index wazaIndex) {} // 0x009ABD10-0x009ABE40
	private void MoveNextConfirmChangeWaza(IPokemonStatus status, int oldWazaId, Const.waza.Index newWazaIndex) {} // 0x009ABE40-0x009ABEB0
	private void MoveNextMoneyPay() {} // 0x009ABEB0-0x009AC140
	private void MoveNext_CheckFromPelipper() {} // 0x009AC140-0x009AC220
	private void MoveNext_Check_AFTER_ENDING() {} // 0x009AC220-0x009AC310
	private void MoveNext_Check_SHOP_WAZA_OSHIE() {} // 0x009AC310-0x009AC400
	private void MoveNext_CheckFirst_Waza() {} // 0x009AC400-0x009AC530
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x009AC530-0x009AC620
	// [IteratorStateMachine] // 0x00620320-0x00620390
	public IEnumerator CloseCommonPub(Action cb = null) => default; // 0x009AC620-0x009AC6A0
}

