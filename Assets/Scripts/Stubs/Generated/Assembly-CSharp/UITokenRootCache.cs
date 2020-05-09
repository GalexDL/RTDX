/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A6B0-0x0060A6C0
public class UITokenRootCache : MonoBehaviour // TypeDefIndex: 7631
{
	// Fields
	public Cache root; // 0x18
	private static Dictionary<GameObject, UITokenRootCache> uiTokenRootCacheTbl; // 0x00

	// Nested types
	[Serializable]
	public class Cache // TypeDefIndex: 7632
	{
		// Fields
		public UIToken token; // 0x10
		public UIPrefabLoader prefabLoader; // 0x18
		public List<Cache> child; // 0x20

		// Constructors
		public Cache() {} // 0x00A42110-0x00A42180
	}

	// Constructors
	public UITokenRootCache() {} // 0x00A42050-0x00A42110
	static UITokenRootCache() {} // 0x00A42180-0x00A42200

	// Methods
	public static UITokenRootCache GetUITokenRootCache(GameObject gameobj) => default; // 0x00A409A0-0x00A40A40
	private void OnEnable() {} // 0x00A41F10-0x00A41F20
	private void OnDisable() {} // 0x00A41F20-0x00A41F30
	private void Awake() {} // 0x00A41F30-0x00A41FC0
	private void OnDestroy() {} // 0x00A41FC0-0x00A42050
}

