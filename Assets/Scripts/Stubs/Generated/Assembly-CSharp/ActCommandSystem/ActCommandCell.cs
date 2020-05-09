/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public class ActCommandCell : ISerializationCallbackReceiver // TypeDefIndex: 8699
	{
		// Fields
		public bool enable; // 0x10
		public int colIdx; // 0x14
		public string syncId; // 0x18
		public string comment; // 0x20
		[NonSerialized]
		public ActCommandBase command; // 0x28
		[NonSerialized]
		public ActCommandCell prevCmdCellLink; // 0x30
		public string commandType; // 0x38
		public string command_JsonStr; // 0x40
	
		// Constructors
		public ActCommandCell() {} // 0x008DB9B0-0x008DBA20
	
		// Methods
		public void CopyFrom(ActCommandCell src) {} // 0x008DB730-0x008DB7E0
		public ActCommandBase CloneCommand() => default; // 0x008DB870-0x008DB900
		public void OnBeforeSerialize() {} // 0x008DB900-0x008DB9A0
		public void OnAfterDeserialize() {} // 0x008DB7E0-0x008DB870
		private string valueJsonSerialize(object command) => default; // 0x008DB9A0-0x008DB9B0
	}
}
