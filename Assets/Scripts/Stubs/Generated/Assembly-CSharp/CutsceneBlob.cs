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

[Editor_ScriptDataBlob] // 0x00608BE0-0x00608C20
public class CutsceneBlob : ScriptDataBlobBase // TypeDefIndex: 4502
{
	// Fields
	private Data data_; // 0x30
	private string dataSerialized_; // 0x38

	// Properties
	public string CutsceneSymbol { get => default; } // 0x0098A620-0x0098A630 

	// Nested types
	[Serializable]
	private class Data : ISerializationCallbackReceiver // TypeDefIndex: 4503
	{
		// Fields
		public bool bContinueMode; // 0x10
		public bool bAssetLoadAfter1SyncWait; // 0x11
		public bool bWaitTaskPreStart; // 0x12
		public string cutsceneSymbol; // 0x18

		// Constructors
		public Data() {} // 0x0098A8A0-0x0098A900

		// Methods
		public void OnBeforeSerialize() {} // 0x0098AD80-0x0098AD90
		public void OnAfterDeserialize() {} // 0x0098AD90-0x0098ADA0
	}

	// Constructors
	public CutsceneBlob() {} // 0x0098A7E0-0x0098A8A0

	// Methods
	public override void ForceSerialize() {} // 0x0098A630-0x0098A640
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x0098A640-0x0098A690
	public override void OnBlobDeserialize(string serializeData) {} // 0x0098A690-0x0098A700
	// [IteratorStateMachine] // 0x006192D0-0x00619340
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext) => default; // 0x0098A700-0x0098A780
	public override void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x0098A7B0-0x0098A7E0
}

