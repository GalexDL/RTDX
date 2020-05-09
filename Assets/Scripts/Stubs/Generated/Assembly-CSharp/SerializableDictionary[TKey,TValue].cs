/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver // TypeDefIndex: 5564
{
	// Fields
	[SerializeField] // 0x00616880-0x00616890
	private List<TKey> keys; // 0x00
	[SerializeField] // 0x00616890-0x006168A0
	private List<TValue> values; // 0x00

	// Constructors
	public SerializableDictionary() {}

	// Methods
	public void OnBeforeSerialize() {}
	public void OnAfterDeserialize() {}
}

