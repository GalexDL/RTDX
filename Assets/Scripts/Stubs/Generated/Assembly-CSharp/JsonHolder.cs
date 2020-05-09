/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class JsonHolder : ISerializationCallbackReceiver // TypeDefIndex: 4407
{
	// Fields
	[SerializeField] // 0x00615ED0-0x00615EE0
	protected string typeStr; // 0x10
	[SerializeField] // 0x00615EE0-0x00615EF0
	protected string jsonData; // 0x18
	[NonSerialized]
	protected object jsonObj; // 0x20

	// Properties
	public object Ref { get => default; set {} } // 0x00901090-0x009010A0 0x009010A0-0x009010B0

	// Constructors
	public JsonHolder() {} // 0x009010B0-0x009010E0
	public JsonHolder(object jsonObj_) {} // 0x009010E0-0x00901110

	// Methods
	public void OnBeforeSerialize() {} // 0x00901110-0x00901160
	public void OnAfterDeserialize() {} // 0x00901160-0x009012B0
}

