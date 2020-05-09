/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00609190-0x006091D0
public class GameFlowBlob_SubScenarioEvent : GameFlowBlobBase_WithFlowBlobListTbl // TypeDefIndex: 4775
{
	// Fields
	public Body BodyData; // 0x20
	private static Regex match_op; // 0x00
	private string cache_startCond_key; // 0x28
	private string cache_execFunc_key; // 0x30
	private string cache_nextCond_key; // 0x38
	private Dictionary<string, List<string>> cache_startCond_; // 0x40
	private Dictionary<string, List<string>> cache_execFunc_; // 0x48
	private Dictionary<string, List<string>> cache_nextCond_; // 0x50

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00A5C180-0x00A5C190 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00A5C190-0x00A5C1A0 0x00A5C1A0-0x00A5C1B0
	public override string FlowId { get => default; set {} } // 0x00A5C2F0-0x00A5C300 0x00A5C300-0x00A5C310
	public Dictionary<string, List<string>> StartCondTbl { get => default; } // 0x00A5C870-0x00A5C8D0 
	public Dictionary<string, List<string>> ExecFuncTbl { get => default; } // 0x00A5C8D0-0x00A5C930 
	public Dictionary<string, List<string>> NextCondTbl { get => default; } // 0x00A5C930-0x00A5C990 

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4776
	{
		// Fields
		public string id; // 0x10
		public string debugName; // 0x18
		public string debugNameTextId; // 0x20
		public string debugEntryId; // 0x28
		public string startCond; // 0x30
		public string execFunc; // 0x38
		public string nextCond; // 0x40
		public string memo; // 0x48

		// Constructors
		public Body() {} // 0x00A5CAB0-0x00A5CB20
	}

	// Constructors
	public GameFlowBlob_SubScenarioEvent() {} // 0x00A5C990-0x00A5CAB0
	static GameFlowBlob_SubScenarioEvent() {} // 0x00A5CB20-0x00A5CBA0

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00A5C1B0-0x00A5C270
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00A5C270-0x00A5C2F0
	// [IteratorStateMachine] // 0x0061B9B0-0x0061BA20
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A5C310-0x00A5C390
	private Dictionary<string, List<string>> ParseArg_(string condText) => default; // 0x00A5C3C0-0x00A5C670
	private Dictionary<string, List<string>> CondClone_(Dictionary<string, List<string>> tbl) => default; // 0x00A5C670-0x00A5C820
	private Dictionary<string, List<string>> CondCache_(string srcData, ref string cahceData, ref Dictionary<string, List<string>> cache) => default; // 0x00A5C820-0x00A5C870
}

