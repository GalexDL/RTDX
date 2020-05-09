/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class FlowGameDataManager__NEW // TypeDefIndex: 5418
{
	// Fields
	private static FlowGameDataManager__NEW m_saveData; // 0x00
	public List<NodeData> m_saveDataList; // 0x10

	// Properties
	public static FlowGameDataManager__NEW Instance { get => default; } // 0x0081A5A0-0x0081A5F0 

	// Nested types
	[Serializable]
	public class NodeData // TypeDefIndex: 5419
	{
		// Fields
		public string type; // 0x10
		public string jsonData; // 0x18

		// Constructors
		public NodeData() {} // 0x0081AAB0-0x0081AAC0
	}

	// Constructors
	public FlowGameDataManager__NEW() {} // 0x0081A530-0x0081A5A0

	// Methods
	public static void CreateInstance() {} // 0x0081A450-0x0081A530
	public void Uninit() {} // 0x0081A5F0-0x0081A640
	public void DataSet(FlowGameSaveData.SaveTitleType type, ShopFlowNode node) {} // 0x0081A640-0x0081AAB0
}

