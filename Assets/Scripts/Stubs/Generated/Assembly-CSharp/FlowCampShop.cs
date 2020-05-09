/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowCampShop : FlowPlay // TypeDefIndex: 5267
{
	// Fields
	private UIRescueSociety menu; // 0x90
	private UIRescueSociety.ActionType result; // 0x98
	private bool bFirstCome; // 0x9C
	private string masterName; // 0xA0
	private Const.creature.Index masterIndex; // 0xA8
	private string tempString; // 0xB0

	// Constructors
	private FlowCampShop() {} // 0x00813560-0x008135D0

	// Methods
	public static FlowCampShop Create() => default; // 0x008135D0-0x00813680
	// [IteratorStateMachine] // 0x0061E6A0-0x0061E710
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x00813680-0x00813700
	protected override Const.camp.Index GetCampData() => default; // 0x00813730-0x00813740
	protected override int GetMoneyData() => default; // 0x00813740-0x00813750
	protected override Const.creature.Index GetMasterIndex() => default; // 0x00813750-0x00813760
	protected override Const.creature.Index GetPokemonData() => default; // 0x00813760-0x00813770
	protected override Const.dungeon.Index GetDungeonData() => default; // 0x00813770-0x00813780
	private void MoveNext_NewCamp() {} // 0x00813780-0x00813820
	private void MoveNext_SoldOutCamp() {} // 0x00813820-0x00813870
	private void MoveNext_HideSaleCamp() {} // 0x00813870-0x008138C0
	private void MoveNext_fromPokemonList() {} // 0x008138C0-0x00813910
	private void MoveNext_dungeonUnlock() {} // 0x00813910-0x008139D0
	// [IteratorStateMachine] // 0x0061E710-0x0061E780
	private IEnumerator MoveNext_CloseList() => default; // 0x008139D0-0x00813A40
	// [IteratorStateMachine] // 0x0061E780-0x0061E7F0
	private IEnumerator MoveNext_PokemonListMenu() => default; // 0x00813A70-0x00813AE0
	// [IteratorStateMachine] // 0x0061E7F0-0x0061E860
	private IEnumerator MoveNext_CampListMenu() => default; // 0x00813B10-0x00813B80
	private void MoveNext_CampConfirmed() {} // 0x00813BB0-0x00813C40
	private void MoveNext_ListReset() {} // 0x00813C40-0x00813C80
	// [IteratorStateMachine] // 0x0061E860-0x0061E8D0
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x00813C80-0x00813D00
}

