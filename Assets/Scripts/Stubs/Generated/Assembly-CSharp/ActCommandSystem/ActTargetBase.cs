/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public abstract class ActTargetBase // TypeDefIndex: 8728
	{
		// Fields
		public string SymbolName; // 0x10
		public bool TaskMode; // 0x18
	
		// Properties
		public string TargetUniqTaskName { get; } // 0x00A9C630-0x00A9C6A0 
		public abstract ActObjBase actObj { get; }
		public string TypeName { get; } // 0x00AA3490-0x00AA35A0 
	
		// Constructors
		protected ActTargetBase() {} // 0x00AA3650-0x00AA36B0
	
		// Methods
		public virtual bool IsTargetEnable(ActDataPlayer.PlayContext context) => default; // 0x00AA3640-0x00AA3650
		public abstract ActObjSnapshotState LookupActSnapshotState(ActSnapshotContext snapshotContext);
	}
}
