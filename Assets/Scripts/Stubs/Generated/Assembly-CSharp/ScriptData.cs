/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScriptData : MonoBehaviour, ISerializeDataText, ISerializationCallbackReceiver // TypeDefIndex: 4472
{
	// Fields
	[NonSerialized]
	private List<ScriptDataBlobBase> dataBlockList_; // 0x18
	[SerializeField] // 0x00615F40-0x00615F50
	private string serializedDataText_; // 0x20
	private static Regex regex_header; // 0x00
	private static Regex regex_opt; // 0x08
	private static Regex regex_taskOpt; // 0x10

	// Properties
	public string SerializedDataText { get => default; set {} } // 0x009CFED0-0x009CFEE0 0x009CFEE0-0x009CFF10
	public List<ScriptDataBlobBase> DataBlockList { get => default; } // 0x009CFF40-0x009CFF50 

	// Constructors
	public ScriptData() {} // 0x009D1450-0x009D14C0
	static ScriptData() {} // 0x009D14C0-0x009D15A0

	// Methods
	public ScenePartitionBlob FindScenePartition_ByLabel(string label) => default; // 0x009CFF50-0x009D0060
	public ActCommandBlob FindCommandBlob_ByTaskName(string taskName) => default; // 0x009D0070-0x009D0210
	private void SetDeserializeDataText(string serializedDataText) {} // 0x009CFF10-0x009CFF40
	public void ForceSerialize() {} // 0x009D0E60-0x009D0F80
	public void OnBeforeSerialize() {} // 0x009D0BB0-0x009D0E60
	public void OnAfterDeserialize() {} // 0x009D0210-0x009D0BB0
	private ScriptDataBlobBase deserializeDataBlob_(string serializeType, string serializeData) => default; // 0x009D0F80-0x009D11E0
	public ScriptDataBlobBase FindNextDataBlob(ScriptDataBlobBase dataBlob) => default; // 0x009D11E0-0x009D12B0
	public void RebuildSnapshotContext() {} // 0x009D12B0-0x009D1440
}

