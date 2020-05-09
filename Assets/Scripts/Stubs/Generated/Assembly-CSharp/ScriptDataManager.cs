/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00608C90-0x00608CD0
[ExecuteInEditMode] // 0x00608C90-0x00608CD0
public class ScriptDataManager : SingletonMonoBehaviour<ScriptDataManager> // TypeDefIndex: 4589
{
	// Fields
	public const string ScriptCommonDataSetPath = "system/scriptCommonDataSet.lua"; // Metadata: 0x006109E7
	private GameObject putLoadObjRoot_; // 0x18
	private ScriptDataStore<ScriptData> scriptDataStore_; // 0x20
	private ScriptCommonDataSet scriptCommonDataSet_; // 0x28

	// Properties
	public ScriptDataStore<ScriptData> DataStore { get => default; } // 0x009D2040-0x009D2050 
	public ScriptCommonDataSet ScriptCommonDataSet { get => default; } // 0x009D2050-0x009D2060 

	// Constructors
	public ScriptDataManager() {} // 0x009D2060-0x009D2100

	// Methods
	private void OnEnable() {} // 0x009D1B10-0x009D1EB0
	private void OnDisable() {} // 0x009D1F70-0x009D2040
	public void LoadScriptCommonDataAsync() {} // 0x009D1EB0-0x009D1F70
}

