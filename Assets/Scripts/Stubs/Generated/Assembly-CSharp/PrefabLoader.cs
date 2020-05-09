/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A770-0x0060A780
public class PrefabLoader : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 8098
{
	// Fields
	private static List<GameObject> objs_; // 0x00

	// Constructors
	public PrefabLoader() {} // 0x009F0200-0x009F0210
	static PrefabLoader() {} // 0x009F0210-0x009F0290

	// Methods
	public static T PrefabLoadInstance<T>(T prefabSrc)
		where T : Component => default;
	public static void RemoveInstance<T>(T compone)
		where T : Component {}
	public void OnAfterDeserialize() {} // 0x009F0040-0x009F0050
	public void OnBeforeSerialize() {} // 0x009F0050-0x009F0060
	private void OnDisable() {} // 0x009F0060-0x009F0200
}

