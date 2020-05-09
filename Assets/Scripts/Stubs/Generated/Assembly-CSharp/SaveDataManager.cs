/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class SaveDataManager // TypeDefIndex: 5470
{
	// Fields
	private static SaveDataManager m_saveData; // 0x00
	public List<SaveData> m_saveDataList; // 0x10

	// Properties
	public static SaveDataManager Instance { get => default; } // 0x00CB2F80-0x00CB2FD0 

	// Constructors
	public SaveDataManager() {} // 0x00CB2F10-0x00CB2F80

	// Methods
	public static void CreateInstance() {} // 0x00CB2E30-0x00CB2F10
	public void Uninit() {} // 0x00CB2FD0-0x00CB3020
}

