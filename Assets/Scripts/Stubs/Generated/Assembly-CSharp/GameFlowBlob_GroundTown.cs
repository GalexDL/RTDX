/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608E90-0x00608ED0
public class GameFlowBlob_GroundTown : GameFlowBlobBase_WithFlowBlobListTbl // TypeDefIndex: 4728
{
	// Fields
	public Body BodyData; // 0x20

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00BBAB00-0x00BBAB10 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BBAB10-0x00BBAB20 0x00BBAB20-0x00BBAB30
	public override string FlowId { get => default; set {} } // 0x00BBAC70-0x00BBAC80 0x00BBAC80-0x00BBAC90

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4729
	{
		// Fields
		public string id; // 0x10
		public string debugName; // 0x18
		public string debugNameTextId; // 0x20
		public string memo; // 0x28
		public string conditionData; // 0x30
		public string specialOptionData; // 0x38
		public bool isContinuePos; // 0x40
		public bool isSeamlessEnd; // 0x41
		public string endBgmType; // 0x48
		public string townNpcStepId; // 0x50
		public string townBasicNpcAssetSet; // 0x58
		public List<string> assetSetList; // 0x60
		public string stopper_scriptPath; // 0x68
		public string hanyouDgFlowType; // 0x70
		public string hanyouDgFlow_OhayouScriptPath; // 0x78
		public string henseiType; // 0x80
		public bool hasStartPostEvent; // 0x88

		// Constructors
		public Body() {} // 0x00BBAD40-0x00BBADF0
	}

	// Constructors
	public GameFlowBlob_GroundTown() {} // 0x00BBA770-0x00BBA8C0

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00BBAB30-0x00BBABF0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BBABF0-0x00BBAC70
	// [IteratorStateMachine] // 0x0061B240-0x0061B2B0
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BBAC90-0x00BBAD10
}

