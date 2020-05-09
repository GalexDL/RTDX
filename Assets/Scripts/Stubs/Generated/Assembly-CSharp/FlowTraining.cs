/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;
using Const.item;
using Const.pokemon;
using Const.tutorial;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowTraining : FlowPlay // TypeDefIndex: 5376
{
	// Fields
	private UITraining.States nowStates; // 0x90
	public Const.item.Index selectItemIndex; // 0x94
	private Const.pokemon.Type selectType; // 0x98
	private Const.tutorial.Index selectTutorialIndex; // 0x9C
	private IPokemonWarehouseStatus wStatus; // 0xA0
	private Const.creature.Index formIndex; // 0xA8
	private bool bTutorial; // 0xAC
	private int lotCount; // 0xB0
	private int cursorIndex; // 0xB4
	private UITrainingBanner banner_; // 0xB8
	private UITraining menu; // 0xC0
	private TutorialResult tutorialResult_; // 0xC8
	private HonkiResult honkiResult_; // 0xCC

	// Properties
	public UITraining.States NowStates { get => default; set {} } // 0x009A6450-0x009A6460 0x009A6460-0x009A6470
	public Const.tutorial.Index SelectTutorialIndex { get => default; set {} } // 0x009A6520-0x009A6530 0x009A6530-0x009A6540
	public IPokemonWarehouseStatus SelectWarehousePokemonStatus { get => default; set {} } // 0x009A6540-0x009A6550 0x009A6550-0x009A6560
	public Const.creature.Index SelectPokemonFormIndex { get => default; set {} } // 0x009A6560-0x009A6570 0x009A6570-0x009A6580
	public int CursorIndex { get => default; set {} } // 0x009A6580-0x009A6590 0x009A6590-0x009A65A0

	// Nested types
	private enum TutorialResult // TypeDefIndex: 5377
	{
		NONE = 0,
		CLEAR = 1,
		FAILURE = 2,
		ESCAPE = 3
	}

	private enum HonkiResult // TypeDefIndex: 5378
	{
		NONE = 0,
		CLEAR = 1,
		FAILURE = 2,
		ESCAPE = 3
	}

	private class DungeonData // TypeDefIndex: 5379
	{
		// Fields
		public Const.dungeon.Index index; // 0x10
		public int floor; // 0x14

		// Constructors
		public DungeonData() {} // 0x009A6E20-0x009A6E30
	}

	// Constructors
	private FlowTraining() {} // 0x009A6470-0x009A64F0

	// Methods
	public static FlowTraining Create() => default; // 0x009A3300-0x009A33A0
	protected override void End() {} // 0x009A64F0-0x009A6520
	// [IteratorStateMachine] // 0x0061FE30-0x0061FEA0
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x009A65A0-0x009A6620
	private void MoveNext_RewardIsSingular() {} // 0x009A6650-0x009A66F0
	// [IteratorStateMachine] // 0x0061FEA0-0x0061FF10
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x009A66F0-0x009A6760
	protected override Const.creature.Index GetMasterIndex() => default; // 0x009A6790-0x009A67A0
	protected override Const.creature.Index GetPokemonData() => default; // 0x009A67A0-0x009A6840
	protected override string GetPokemonData_String() => default; // 0x009A6840-0x009A68A0
	protected override string GetTutorialData() => default; // 0x009A68A0-0x009A68B0
	private void CheckTrainingAllClear_MoveNext() {} // 0x009A68B0-0x009A6910
	private void CheckTutorialAllClear_MoveNext() {} // 0x009A6910-0x009A69A0
	private void CheckTutorialResult_MoveNext() {} // 0x009A69A0-0x009A6AC0
	private void MoveNext_IsHonkiSuccess() {} // 0x009A6AC0-0x009A6BA0
	private void CheckFirstClear_Training() {} // 0x009A6BA0-0x009A6BD0
	// [IteratorStateMachine] // 0x0061FF10-0x0061FF80
	private IEnumerator _noticeMessage(TextId textId, Action cb = null) => default; // 0x009A6BD0-0x009A6C50
	// [IteratorStateMachine] // 0x0061FF80-0x0061FFF0
	private IEnumerator InDungeon() => default; // 0x009A6C80-0x009A6CF0
	private DungeonData GetTargetDungeonIndex() => default; // 0x009A6D20-0x009A6E20
	private void TicketUse_MoveNext() {} // 0x009A6E30-0x009A6EE0
	private void GetCompensation_MoveNext() {} // 0x009A6EE0-0x009A6F70
	// [IteratorStateMachine] // 0x0061FFF0-0x00620060
	private IEnumerator MoveNext_Reward_Tutorial() => default; // 0x009A6F70-0x009A6FE0
	private void MoveNext_Check_HONKI_Release() {} // 0x009A7010-0x009A7290
	protected override Const.item.Index GetItemData() => default; // 0x009A7290-0x009A72A0
	private void CheckTrainingHasDualType_MoveNext() {} // 0x009A72A0-0x009A7400
	private void SetType_MoveNext(int typeNum) {} // 0x009A7400-0x009A74D0
}

