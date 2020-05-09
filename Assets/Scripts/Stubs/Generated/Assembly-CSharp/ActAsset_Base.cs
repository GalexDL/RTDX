/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class ActAsset_Base // TypeDefIndex: 4374
{
	// Fields
	public string symbolName; // 0x10

	// Constructors
	protected ActAsset_Base() {} // 0x008D5330-0x008D5390

	// Methods
	public virtual void TryLoadActObjectAndSetup(ActObjectManager actObjManager, Action<ActObjBase, bool> loadedCb) {} // 0x008D69C0-0x008D6A20
	public virtual List<string> WithLoadSymbols() => default; // 0x008D6A20-0x008D6A30
	public virtual void Deserialize(ActDataSerializeStream stream) {} // 0x008D6A30-0x008D6A50
	public virtual void Serialize(ActDataSerializeStream stream) {} // 0x008D6A50-0x008D6A70
	public virtual void SetupSnapshot(ActSnapshotContext snapshotContext) {} // 0x008D6A70-0x008D6A80
}

