/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class EditorDataManager // TypeDefIndex: 5250
{
	// Fields
	private static EditorDataManager m_saveData; // 0x00
	public List<EditorSaveData> m_saveDataList; // 0x10
	public float m_mag; // 0x18
	public List<string> m_messageLabelFilePathList; // 0x20

	// Properties
	public static EditorDataManager Instance { get => default; } // 0x00BC4B70-0x00BC4BC0 

	// Constructors
	public EditorDataManager() {} // 0x00BC4AF0-0x00BC4B70

	// Methods
	public static void CreateInstance() {} // 0x00BC4A10-0x00BC4AF0
	public void Uninit() {} // 0x00BC4BC0-0x00BC4C10
}

