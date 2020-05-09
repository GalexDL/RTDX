/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActSnapshotContext // TypeDefIndex: 4454
{
	// Fields
	private Dictionary<string, ActObjSnapshotState> actObjSnapshotTbl_; // 0x10
	private ActObjSnapshotState generalSnapshot_; // 0x18
	private List<ActAssetSet> lastAssetSetLst_; // 0x20

	// Constructors
	public ActSnapshotContext() {} // 0x008587C0-0x00858880

	// Methods
	public void Clear() {} // 0x00857EC0-0x00857F50
	public void CopyFrom(ActSnapshotContext left) {} // 0x00857F50-0x008581E0
	public void SetupFromAssetSet(ActAssetSet assetSet) {} // 0x008581E0-0x008583C0
	public ActObjSnapshotState GetActObjStapshotState(string symbolName) => default; // 0x008583C0-0x00858460
	public ActObjSnapshotState AddActObjSnapshotState(string symbolName) => default; // 0x00858460-0x00858500
	public ActObjSnapshotState GetActObjSnapshotState_Camera() => default; // 0x00858500-0x00858590
	public ActObjSnapshotState GetActObjSnapshotState_General() => default; // 0x00858590-0x008585A0
	public T FindLastActAssetSetList<T>(string symbol)
		where T : ActAsset_Base => default;
	public void DebugDump() {} // 0x008585A0-0x008587C0
}

