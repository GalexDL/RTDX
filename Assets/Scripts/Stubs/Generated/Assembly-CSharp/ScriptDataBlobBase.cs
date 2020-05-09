/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public abstract class ScriptDataBlobBase // TypeDefIndex: 4475
{
	// Fields
	public bool bSkip; // 0x10
	public bool bShowScene; // 0x11
	public string taskDefine; // 0x18
	public bool bTaskInstantRun; // 0x20
	public bool bTaskLoop; // 0x21
	protected ActSnapshotContext preSnapshotContext_; // 0x28

	// Properties
	public ActSnapshotContext PreSnapshotContext { get; } // 0x009D1660-0x009D1670 

	// Constructors
	protected ScriptDataBlobBase() {} // 0x009CD410-0x009CD480

	// Methods
	public abstract void ForceSerialize();
	public abstract void OnBlobSerialize(out string serializeType, out string serializeData);
	public abstract void OnBlobDeserialize(string serializeData);
	public abstract IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext);
	public virtual void RebuildSnapshotContext(ActSnapshotContext snapshotContext, ScriptData ownerScriptData) {} // 0x009D1650-0x009D1660
	public void SetPreSnapshotContext(ActSnapshotContext snapshotContext) {} // 0x009D1440-0x009D1450
}

