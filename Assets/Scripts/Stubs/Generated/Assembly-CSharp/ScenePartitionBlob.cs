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

[Editor_ScriptDataBlob] // 0x00608A60-0x00608AA0
public class ScenePartitionBlob : ScriptDataBlobBase // TypeDefIndex: 4476
{
	// Fields
	private Data data_; // 0x30
	private string dataSerialized_; // 0x38

	// Properties
	public string ScenePartitionLabel { get => default; } // 0x009CD020-0x009CD030 
	public PartitionType ScenePartitionType { get => default; } // 0x009CD030-0x009CD040 

	// Nested types
	private enum FadeSetting // TypeDefIndex: 4477
	{
		Clear = 0,
		FrontWhiteStart = 1,
		FrontBlackStart = 2,
		BackWhiteStart = 3,
		BackBlackStart = 4
	}

	public enum PartitionType // TypeDefIndex: 4478
	{
		Normal = 0,
		ForCutscene = 1
	}

	[Serializable]
	private class Data : ISerializationCallbackReceiver // TypeDefIndex: 4479
	{
		// Fields
		public string label; // 0x10
		[NonSerialized]
		public FadeSetting fadeSetting; // 0x18
		[SerializeField] // 0x00618470-0x00618480
		private string fadeSetting_; // 0x20
		[NonSerialized]
		public PartitionType partitionType; // 0x28
		[SerializeField] // 0x00618480-0x00618490
		private string partitionType_; // 0x30

		// Constructors
		public Data() {} // 0x009CD3B0-0x009CD410

		// Methods
		public void OnBeforeSerialize() {} // 0x009CD6E0-0x009CD7C0
		public void OnAfterDeserialize() {} // 0x009CD7C0-0x009CDB70
	}

	// Constructors
	public ScenePartitionBlob() {} // 0x009CD2B0-0x009CD3B0

	// Methods
	public override void ForceSerialize() {} // 0x009CD040-0x009CD050
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x009CD050-0x009CD0A0
	public override void OnBlobDeserialize(string serializeData) {} // 0x009CD0A0-0x009CD110
	// [IteratorStateMachine] // 0x00618FC0-0x00619030
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext) => default; // 0x009CD110-0x009CD190
	public override void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x009CD1C0-0x009CD2B0
}

