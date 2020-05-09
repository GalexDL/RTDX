/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class JsonHolder<T> : ISerializationCallbackReceiver // TypeDefIndex: 4406
	where T : class
{
	// Fields
	[SerializeField] // 0x00615EB0-0x00615EC0
	protected string typeStr; // 0x00
	[SerializeField] // 0x00615EC0-0x00615ED0
	protected string jsonData; // 0x00
	[NonSerialized]
	protected T jsonObj; // 0x00

	// Properties
	public T Ref { get => default; set {} }

	// Constructors
	public JsonHolder() {}
	public JsonHolder(T jsonObj_) {}

	// Methods
	public void OnBeforeSerialize() {}
	public void OnAfterDeserialize() {}
}

