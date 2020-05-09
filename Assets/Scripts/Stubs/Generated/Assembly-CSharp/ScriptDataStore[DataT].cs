/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScriptDataStore<DataT> // TypeDefIndex: 4592
	where DataT : MonoBehaviour, ISerializeDataText
{
	// Fields
	private Dictionary<string, DataInfo_> loadedDataTbl_; // 0x00
	private Dictionary<string, DataInfo_> preloadDataTbl_; // 0x00
	private GameObject putLoadObjRoot_; // 0x00

	// Nested types
	private class DataInfo_ // TypeDefIndex: 4593
	{
		// Fields
		public string scriptRelPath; // 0x00
		public DataT refData; // 0x00

		// Constructors
		public DataInfo_() {}
	}

	// Constructors
	public ScriptDataStore() {}

	// Methods
	private DataInfo_ FindDataInfo_(DataT refData) => default;
	public void OnEnable(GameObject putLoadObjRoot) {}
	public void OnDisable() {}
	public void PreLoadData(List<string> preloadPahtList) {}
	public void LoadDataAsync(string scriptRelPath, bool bEditorOpen, Action<DataT> resultCb) {}
	public void UnloadData(DataT data) {}
	public DataT TryGetData(string scriptRelPath) => default;
	public List<DataT> EnumLoadedData() => default;
}

