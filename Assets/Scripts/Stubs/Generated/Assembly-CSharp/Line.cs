/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Line // TypeDefIndex: 5424
{
	// Fields
	public Vector3 m_sPos; // 0x10
	public Vector3 m_ePos; // 0x1C
	public Vector3 m_adjust; // 0x28
	public bool m_bMove; // 0x34

	// Nested types
	public enum Type // TypeDefIndex: 5425
	{
		Horizon = 0,
		Vertical = 1,
		None = 2
	}

	// Constructors
	public Line() {} // 0x00904240-0x009042A0

	// Methods
	public Type GetLineType() => default; // 0x00904210-0x00904240
}

