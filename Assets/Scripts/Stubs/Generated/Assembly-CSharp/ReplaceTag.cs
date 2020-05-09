/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ReplaceTag : ScriptableObject // TypeDefIndex: 8151
{
	// Fields
	public List<Sheet> sheets; // 0x18

	// Nested types
	[Serializable]
	public class Sheet // TypeDefIndex: 8152
	{
		// Fields
		public string name; // 0x10
		public List<Param> list; // 0x18

		// Constructors
		public Sheet() {} // 0x00A03CC0-0x00A03D50
	}

	[Serializable]
	public class Param // TypeDefIndex: 8153
	{
		// Fields
		public string oldTag; // 0x10
		public string tag; // 0x18
		public string type; // 0x20
		public string type2; // 0x28
		public string item; // 0x30
		public bool kongo; // 0x38
		public string memo; // 0x40

		// Constructors
		public Param() {} // 0x00A03CB0-0x00A03CC0
	}

	// Constructors
	public ReplaceTag() {} // 0x00A03C40-0x00A03CB0
}

