/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public abstract class ActCommandBase // TypeDefIndex: 8732
	{
		// Fields
		private string dispNameCache_; // 0x10
		protected ActObjSnapshotState lastPreSnapshotState_; // 0x18
		protected ActObjSnapshotState lastPostSnapshotState_; // 0x20
	
		// Properties
		public string DispName { get; } // 0x008DB550-0x008DB610 
		public ActObjSnapshotState LastPreSnapshotState { get; } // 0x008DB690-0x008DB6A0 
		public ActObjSnapshotState LastPostSnapshotState { get; } // 0x008DA380-0x008DA390 
	
		// Constructors
		protected ActCommandBase() {} // 0x008DB6A0-0x008DB730
	
		// Methods
		public abstract IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait);
		public virtual void DeserializeJson_Value(string jsonText) {} // 0x008DB520-0x008DB540
		public virtual string SerializeJson_Value() => default; // 0x008DB540-0x008DB550
		public virtual void InitFromSnapshotState(ActObjSnapshotState lastSnapshotState) {} // 0x008DB610-0x008DB620
		public abstract void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData);
		public void UpdateSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DB620-0x008DB690
	}
}
