/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Editor_ScriptDataBlob] // 0x00608AA0-0x00608AE0
public class BranchLabelBlob : ScriptDataBlobBase // TypeDefIndex: 4481
{
	// Fields
	private Data data_; // 0x30
	private string dataSerialized_; // 0x38

	// Properties
	public string BranchLabel { get => default; } // 0x008C1410-0x008C1420 

	// Nested types
	[Serializable]
	private class Data : ISerializationCallbackReceiver // TypeDefIndex: 4482
	{
		// Fields
		public string label; // 0x10

		// Constructors
		public Data() {} // 0x008C1920-0x008C1980

		// Methods
		public void OnBeforeSerialize() {} // 0x008C1B00-0x008C1B10
		public void OnAfterDeserialize() {} // 0x008C1B10-0x008C1B20
	}

	// Constructors
	public BranchLabelBlob() {} // 0x008C1870-0x008C1920

	// Methods
	public override void ForceSerialize() {} // 0x008C1420-0x008C1430
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x008C1430-0x008C14A0
	public override void OnBlobDeserialize(string serializeData) {} // 0x008C14A0-0x008C1510
	// [IteratorStateMachine] // 0x00619030-0x006190A0
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext) => default; // 0x008C1510-0x008C1590
	public override void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x008C15C0-0x008C1870
}

