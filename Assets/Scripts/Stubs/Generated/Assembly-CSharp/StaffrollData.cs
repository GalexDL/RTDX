/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class StaffrollData : ScriptableObject // TypeDefIndex: 5499
{
	// Fields
	public List<ScreenSet> screenSetList; // 0x18

	// Nested types
	public enum TokenType // TypeDefIndex: 5500
	{
		Role = 0,
		Name = 1,
		Space = 2,
		CampanyName = 3
	}

	[Serializable]
	public class Token // TypeDefIndex: 5501
	{
		// Fields
		public TokenType type; // 0x10
		public string text; // 0x18

		// Constructors
		public Token() {} // 0x009126F0-0x00912700
	}

	[Serializable]
	public class ScreenSet // TypeDefIndex: 5502
	{
		// Fields
		public List<Token> tokenList; // 0x10

		// Constructors
		public ScreenSet() {} // 0x00912680-0x009126F0
	}

	// Constructors
	public StaffrollData() {} // 0x00912610-0x00912680
}

