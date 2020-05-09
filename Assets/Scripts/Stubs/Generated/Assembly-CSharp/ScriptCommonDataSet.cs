/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActCommandSystem;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScriptCommonDataSet : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 4470
{
	// Fields
	[SerializeField] // 0x00615F30-0x00615F40
	private SerializeData serializeData_; // 0x18
	[NonSerialized]
	private string serializedDataText_; // 0x20

	// Properties
	public string SerializedDataText { get => default; } // 0x009CFB80-0x009CFB90 
	public ActFuncSet commandFuncSet { get => default; } // 0x009CFD90-0x009CFDA0 

	// Nested types
	[Serializable]
	private class SerializeData // TypeDefIndex: 4471
	{
		// Fields
		public ActFuncSet commandFuncSet; // 0x10

		// Constructors
		public SerializeData() {} // 0x009CFE60-0x009CFED0

		// Methods
		public void Deserialize_HumanText(string text, out string error) {
			error = default;
		} // 0x009CFD80-0x009CFD90
		public string Serialize_HumanText() => default; // 0x009CFCC0-0x009CFD80
	}

	// Constructors
	public ScriptCommonDataSet() {} // 0x009CFDA0-0x009CFE60

	// Methods
	public void SetDeserializeDataText(string serializedDataText) {} // 0x009CFB90-0x009CFC10
	public void OnBeforeSerialize() {} // 0x009CFC90-0x009CFCC0
	public void OnAfterDeserialize() {} // 0x009CFC10-0x009CFC90
}

