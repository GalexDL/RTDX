/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class EventManager // TypeDefIndex: 5251
{
	// Fields
	private static EventManager m_eventManager; // 0x00
	private Priority m_currentType; // 0x10

	// Properties
	public static EventManager Instance { get => default; } // 0x00BDECC0-0x00BDED10 
	public Priority CurrentType { get => default; set {} } // 0x00BDED10-0x00BDED20 0x00BDED20-0x00BDED40

	// Nested types
	public enum Priority // TypeDefIndex: 5252
	{
		Node = 0,
		Knob = 1,
		Line = 2,
		Folder = 3,
		Field = 4,
		Max = 5
	}

	// Constructors
	private EventManager() {} // 0x00BDECB0-0x00BDECC0

	// Methods
	public static void CreateInstance() {} // 0x00BDEC20-0x00BDECB0
	public void ResetPriority() {} // 0x00BDED40-0x00BDED50
	public bool PriorityCheck(Priority type) => default; // 0x00BDED50-0x00BDED60
}

