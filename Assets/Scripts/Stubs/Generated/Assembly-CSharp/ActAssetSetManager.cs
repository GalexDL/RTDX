/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00608790-0x006087D0
[ExecuteInEditMode] // 0x00608790-0x006087D0
public class ActAssetSetManager : SingletonMonoBehaviour<ActAssetSetManager> // TypeDefIndex: 4366
{
	// Fields
	private GameObject putLoadObjRoot_; // 0x18
	private ScriptDataStore<ActAssetSetObj> scriptDataStore_; // 0x20
	public const string ActAssetSetDataRelPath = "actAssetSet/"; // Metadata: 0x0061079C

	// Properties
	public ScriptDataStore<ActAssetSetObj> DataStore { get => default; } // 0x008D6250-0x008D6260 

	// Constructors
	public ActAssetSetManager() {} // 0x008D6440-0x008D64E0

	// Methods
	private void OnEnable() {} // 0x008D5E60-0x008D5FE0
	private void OnDisable() {} // 0x008D6180-0x008D6250
	public List<string> EnumDataPathList() => default; // 0x008D5FE0-0x008D6180
	// [IteratorStateMachine] // 0x00618B00-0x00618B70
	public IEnumerator Preload() => default; // 0x008D6260-0x008D62D0
	public void LoadDataFromSymbolAsync(string symbol, bool bEditorOpen, Action<ActAssetSetObj> resultCb) {} // 0x008D5140-0x008D51E0
	public void UnloadAll() {} // 0x008D6300-0x008D6440
}

