/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class DataManager : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 5482
{
	// Fields
	[SerializeField] // 0x00616740-0x00616750
	private List<string> m_messageLabelFilePathList; // 0x18
	[NonSerialized]
	private List<bool> m_saveCsvFlagList; // 0x20
	public bool m_bAnotherModeEdit; // 0x28
	[NonSerialized]
	public List<ShopFlowNode> m_nodeList; // 0x30
	[NonSerialized]
	public List<GridLine> m_gridListH; // 0x38
	[NonSerialized]
	public List<GridLine> m_gridListV; // 0x40
	private GridLine m_gridData; // 0x48
	[NonSerialized]
	public Vector2 m_windowSize; // 0x50
	[NonSerialized]
	public List<ShopFlowNode> m_folderDataList; // 0x58
	public List<EditorSaveData> m_oldSaveDataList; // 0x60
	private static DataManager m_dataManager; // 0x00
	private bool m_change; // 0x68
	public string m_filePath; // 0x70
	public int m_currentNodeID; // 0x78
	public int m_currentKnobID; // 0x7C
	public List<int> m_currentNodeGroupIDList; // 0x80

	// Properties
	public List<bool> SaveCsvFlagList { get => default; } // 0x0098E340-0x0098E350 
	public List<string> FilePathList { get => default; } // 0x0098E400-0x0098E410 
	public static DataManager Instance { get => default; set {} } // 0x0098E810-0x0098E880 0x0098E880-0x0098E8F0

	// Constructors
	public DataManager() {} // 0x0098E930-0x0098EAE0
	static DataManager() {} // 0x0098EAE0-0x0098EAF0

	// Methods
	public void AddFilePathList(string path) {} // 0x0098E350-0x0098E400
	public void RemoveFilePath(string path) {} // 0x0098E410-0x0098E580
	public void RemoveFileIndex(int index) {} // 0x0098E580-0x0098E6C0
	public void RemoveFile_ForFlagList(List<bool> flagList) {} // 0x0098E6C0-0x0098E810
	public void AllMove() {} // 0x0098E8F0-0x0098E900
	private void Update() {} // 0x0098E900-0x0098E910
	public void OnAfterDeserialize() {} // 0x0098E910-0x0098E920
	public void OnBeforeSerialize() {} // 0x0098E920-0x0098E930
}

