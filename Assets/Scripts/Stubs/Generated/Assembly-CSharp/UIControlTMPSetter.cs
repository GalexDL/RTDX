/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A5C0-0x0060A5D0
public class UIControlTMPSetter : MonoBehaviour // TypeDefIndex: 6714
{
	// Fields
	public string TMPToken; // 0x18
	public int selector; // 0x20
	public List<textParam> selectParams; // 0x28

	// Nested types
	[Serializable]
	public class textParam // TypeDefIndex: 6715
	{
		// Fields
		[TMPLabelEdit] // 0x00618700-0x00618710
		public string message; // 0x10
		public bool isLabel; // 0x18

		// Constructors
		public textParam() {} // 0x00977AA0-0x00977AB0
	}

	// Constructors
	public UIControlTMPSetter() {} // 0x009779F0-0x00977AA0

	// Methods
	private void OnEnable() {} // 0x009777A0-0x009777B0
	private void Awake() {} // 0x009777B0-0x009777C0
	public void Select(int select) {} // 0x009777C0-0x00977840
	public void DrawUpdate() {} // 0x00971540-0x009716E0
	public UIControlTMP GetTargetTmp() => default; // 0x00977840-0x00977920
	public static UIControlTMPSetter Find(GameObject obj, string token) => default; // 0x00977920-0x009779F0
}

