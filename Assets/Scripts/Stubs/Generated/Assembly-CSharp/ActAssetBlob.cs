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

[Editor_ScriptDataBlob] // 0x00608B60-0x00608BA0
public class ActAssetBlob : ScriptDataBlobBase // TypeDefIndex: 4489
{
	// Fields
	[SerializeField] // 0x00615F50-0x00615F60
	public ActAssetSet actAssetSet; // 0x30
	private string serializeData_; // 0x38
	private bool bDeserializeError_; // 0x40
	private string deserializeErrorMsg_; // 0x48
	private ActSnapshotContext prevSnapshotContext_; // 0x50

	// Properties
	public string SerializeText { get => default; } // 0x008D3910-0x008D3920 

	// Nested types
	public enum AdditionalActAsset // TypeDefIndex: 4490
	{
		None = 0,
		TownNpcShop1st = 100,
		TownNpcShop2nd = 200
	}

	// Constructors
	public ActAssetBlob() {} // 0x008D3EE0-0x008D3F80

	// Methods
	public override void ForceSerialize() {} // 0x008D3920-0x008D3950
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x008D3960-0x008D39B0
	public override void OnBlobDeserialize(string serializeData) {} // 0x008D39B0-0x008D3A00
	// [IteratorStateMachine] // 0x00619180-0x006191F0
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext) => default; // 0x008D3C20-0x008D3CA0
	public override void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x008D3CD0-0x008D3EE0
}

