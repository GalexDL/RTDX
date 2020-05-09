/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class SaveData // TypeDefIndex: 5468
{
	// Fields
	public SaveDataType m_type; // 0x10
	public string m_dataName; // 0x18
	public string m_dataValue; // 0x20

	// Nested types
	public enum SaveDataType // TypeDefIndex: 5469
	{
		Node = 0,
		Knob = 1,
		Line = 2,
		Grid = 3
	}

	// Constructors
	public SaveData() {} // 0x00CB2E20-0x00CB2E30
}

