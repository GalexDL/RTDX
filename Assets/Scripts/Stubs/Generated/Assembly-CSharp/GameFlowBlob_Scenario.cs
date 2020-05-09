/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608E50-0x00608E90
public class GameFlowBlob_Scenario : GameFlowBlobBase_WithFlowBlobListTbl // TypeDefIndex: 4718
{
	// Fields
	public Body BodyData; // 0x20
	[SerializeField] // 0x00616060-0x00616070
	public List<EntryInfo> entryList; // 0x28
	private static Regex match_Entry; // 0x00

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00A594F0-0x00A59540 
	public override string FlowId { get => default; set {} } // 0x00A59960-0x00A59970 0x00A59970-0x00A59980

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4719
	{
		// Fields
		public string id; // 0x10
		public string scenarioLv; // 0x18
		public string debugPkd1Scene; // 0x20
		public bool isContinuePos; // 0x28

		// Constructors
		public Body() {} // 0x00A59C70-0x00A59CD0
	}

	[Serializable]
	public class EntryInfo // TypeDefIndex: 4720
	{
		// Fields
		public string debugName; // 0x10
		public string debugNameTextId; // 0x18
		public string relScriptPath; // 0x20
		public string debugPkd1Scene; // 0x28

		// Properties
		public string DebugName { get => default; } // 0x00A5B620-0x00A5B630 

		// Constructors
		public EntryInfo() {} // 0x00A59900-0x00A59960
	}

	// Constructors
	public GameFlowBlob_Scenario() {} // 0x00A59B90-0x00A59C70
	static GameFlowBlob_Scenario() {} // 0x00A59CD0-0x00A59D50

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00A59540-0x00A59720
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00A59720-0x00A59900
	// [IteratorStateMachine] // 0x0061B0F0-0x0061B160
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A59980-0x00A59A00
	// [IteratorStateMachine] // 0x0061B160-0x0061B1D0
	private IEnumerator PlayScript_(string relPath, string startScenePartitionLabel, GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A59A30-0x00A59AD0
	// [IteratorStateMachine] // 0x0061B1D0-0x0061B240
	private IEnumerator PlayPkd1_() => default; // 0x00A59B00-0x00A59B60
}

