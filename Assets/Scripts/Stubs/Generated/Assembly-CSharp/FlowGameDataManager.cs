/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class FlowGameDataManager // TypeDefIndex: 5417
{
	// Fields
	private static FlowGameDataManager m_saveData; // 0x00
	public List<FlowGameSaveData.NodeData> m_saveDataList; // 0x10
	public bool m_bAnotherModeEdit; // 0x18

	// Properties
	public static FlowGameDataManager Instance { get => default; } // 0x0081A3B0-0x0081A400 

	// Constructors
	public FlowGameDataManager() {} // 0x0081A340-0x0081A3B0

	// Methods
	public static void CreateInstance() {} // 0x0081A260-0x0081A340
	public void Uninit() {} // 0x0081A400-0x0081A450
}

