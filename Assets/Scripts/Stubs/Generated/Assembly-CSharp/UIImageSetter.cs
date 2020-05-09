/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIImageSetter : MonoBehaviour // TypeDefIndex: 6989
{
	// Fields
	public string IMGToken; // 0x18
	public int selector; // 0x20
	public List<textParam> selectParams; // 0x28

	// Nested types
	[Serializable]
	public class textParam // TypeDefIndex: 6990
	{
		// Fields
		public Sprite sprite; // 0x10

		// Constructors
		public textParam() {} // 0x00A8B420-0x00A8B430
	}

	// Constructors
	public UIImageSetter() {} // 0x00A8B370-0x00A8B420

	// Methods
	private void OnEnable() {} // 0x00A8AF90-0x00A8AFA0
	private void Awake() {} // 0x00A8AFA0-0x00A8AFB0
	public void Select(int select) {} // 0x00A8B140-0x00A8B1C0
	public void DrawUpdate() {} // 0x00A8AFB0-0x00A8B140
	public Image GetTargetImg() => default; // 0x00A8B1C0-0x00A8B2A0
	public static UIImageSetter Find(GameObject obj, string token) => default; // 0x00A8B2A0-0x00A8B370
}

