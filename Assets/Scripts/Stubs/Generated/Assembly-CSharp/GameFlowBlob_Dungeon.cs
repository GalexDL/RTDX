/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608F10-0x00608F50
public class GameFlowBlob_Dungeon : GameFlowBlobBase_WithFlowBlobListTbl // TypeDefIndex: 4734
{
	// Fields
	public Body BodyData; // 0x20

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00BB46D0-0x00BB46E0 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BB46E0-0x00BB46F0 0x00BB46F0-0x00BB4700
	public override string FlowId { get => default; set {} } // 0x00BB4840-0x00BB4850 0x00BB4850-0x00BB4860

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4735
	{
		// Fields
		public string id; // 0x10
		public string debugName; // 0x18
		public string debugNameTextId; // 0x20
		public string dgIndexSymbol; // 0x28
		public string henseiType; // 0x30
		public bool isResultSkip; // 0x38

		// Constructors
		public Body() {} // 0x00BB5460-0x00BB54C0
	}

	[Serializable]
	private class SuspendData_ // TypeDefIndex: 4736
	{
		// Fields
		public GameFlowLocalSaveData suspendWaypointData; // 0x10

		// Constructors
		public SuspendData_() {} // 0x00BB8AE0-0x00BB8B50
	}

	private enum FnId_ // TypeDefIndex: 4737
	{
		CLEAR = 0,
		FAILED = 1,
		FAILED_EVENT = 2,
		FAILED_WAYPOINT_BOSS = 3,
		FAILED_WAYPOINT = 4,
		WAYPOINT_1st = 5,
		WAYPOINT_2nd = 6,
		WAYPOINT = 7,
		BOSS_1st = 8,
		BOSS_2nd = 9,
		BOSS = 10
	}

	private enum DgEnterFloor_ // TypeDefIndex: 4738
	{
		Start = 0,
		Waypoint = 1,
		WaypointAfter = 2,
		Boss = 3
	}

	private enum DgFlowResult_ // TypeDefIndex: 4739
	{
		None = 0,
		Clear = 1,
		Failed = 2,
		ToNext = 3
	}

	private class DgContext // TypeDefIndex: 4740
	{
		// Fields
		public SuspendData_ dgSuspendData; // 0x10

		// Constructors
		public DgContext() {} // 0x00BB6BC0-0x00BB6C80
	}

	// Constructors
	public GameFlowBlob_Dungeon() {} // 0x00BB5360-0x00BB5460

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00BB4700-0x00BB47C0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB47C0-0x00BB4840
	private string Fn_(FnId_ name) => default; // 0x00BB4860-0x00BB48F0
	private FnId_ Fn_(string name) => default; // 0x00BB48F0-0x00BB49B0
	// [IteratorStateMachine] // 0x0061B2B0-0x0061B320
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB49B0-0x00BB4A30
	// [IteratorStateMachine] // 0x0061B320-0x0061B390
	private IEnumerator tryFlowPlay_NoSave_(string playName, GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB4A60-0x00BB4AF0
	private Index GetDungeonIndex_() => default; // 0x00BB4B20-0x00BB4BF0
	private bool IsChiteiDungeon_() => default; // 0x00BB4BF0-0x00BB4C10
	private bool IsGinnoKaikouDungeon_() => default; // 0x00BB4C10-0x00BB4C30
	private bool IsInsekiDungeon_() => default; // 0x00BB4C30-0x00BB4C50
	private bool IsNegaiDungeon_() => default; // 0x00BB4C50-0x00BB4C70
	// [IteratorStateMachine] // 0x0061B390-0x0061B400
	private IEnumerator DungeonLoop_(GameFlowPlayContext context, Func<bool> needExit, DgEnterFloor_ startFloor, Action<DgFlowResult_> resultCb) => default; // 0x00BB4C70-0x00BB4D00
	private void OnCheckInterruptFloorForScriptEvent_(GameFlowPlayContext context, DgContext dgContext, Func<bool> needExit, Action<DgFlowResult_> resultCb) {} // 0x00BB4D30-0x00BB5160
	// [IteratorStateMachine] // 0x0061B400-0x0061B470
	private IEnumerator OnInterruptFloorForScriptEvent_(GameFlowPlayContext context, DgContext dgContext, Func<bool> needExit, Action<DgFlowResult_> resultCb) => default; // 0x00BB5160-0x00BB51F0
	// [IteratorStateMachine] // 0x0061B470-0x0061B4E0
	private IEnumerator OnLoopDebug_(GameFlowPlayContext context) => default; // 0x00BB5220-0x00BB5280
	// [IteratorStateMachine] // 0x0061B4E0-0x0061B550
	private IEnumerator DebugAskMenu_(Action<DgFlowResult_> resultCb) => default; // 0x00BB52B0-0x00BB5330
}

