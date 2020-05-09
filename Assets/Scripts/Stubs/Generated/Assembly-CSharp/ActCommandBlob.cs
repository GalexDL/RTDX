/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActCommandSystem;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Editor_ScriptDataBlob] // 0x00608BA0-0x00608BE0
public class ActCommandBlob : ScriptDataBlobBase // TypeDefIndex: 4495
{
	// Fields
	private ActDataSet actDataSet_; // 0x30
	private string serializeData_; // 0x38
	private string lastEditingText_; // 0x40
	private bool bDeserializeError_; // 0x48
	private string deserializeErrorMsg_; // 0x50

	// Properties
	public ActDataSet RefActDataSet { get => default; } // 0x008D96B0-0x008D96C0 

	// Constructors
	public ActCommandBlob() {} // 0x008DA4D0-0x008DA550

	// Methods
	public override void ForceSerialize() {} // 0x008D96C0-0x008D96F0
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x008D96F0-0x008D9740
	public override void OnBlobDeserialize(string serializeData) {} // 0x008D9740-0x008D9790
	// [IteratorStateMachine] // 0x006191F0-0x00619260
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext scriptDataPlayerContext) => default; // 0x008D9790-0x008D9810
	// [IteratorStateMachine] // 0x00619260-0x006192D0
	public IEnumerator PlayForTask(ScriptDataPlayer.PlayerTaskSys.TaskContext taskContext, ScriptDataPlayer.PlayerContext scriptDataPlayerContext) => default; // 0x008D9840-0x008D98C0
	public override void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x008D98F0-0x008D9940
	public ActSnapshotContext MakeSnapshotContext(ActCommandCellList startCommandCellLst, int startColumnIdx) => default; // 0x008D9940-0x008DA380
}

