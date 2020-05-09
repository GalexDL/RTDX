/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class DataStorePersistenceInitParam // TypeDefIndex: 9418
	{
		// Fields
		[SerializeField] // 0x00617AA0-0x00617AB0
		private bool isPersistence; // 0x10
		[SerializeField] // 0x00617AB0-0x00617AC0
		private bool deleteLastObject; // 0x11
		// [Range] // 0x00617AC0-0x00617B00
		[SerializeField] // 0x00617AC0-0x00617B00
		private ushort persistenceSlotId; // 0x12
	
		// Constructors
		public DataStorePersistenceInitParam() {} // 0x00DAA520-0x00DAA530
	
		// Methods
		public void Validate() {} // 0x00DAA460-0x00DAA480
		public NexPlugin.DataStorePersistenceInitParam GetDataStorePersistenceInitParam() => default; // 0x00DAA480-0x00DAA510
		public void SetIsPersistence(bool arg_persistence) {} // 0x00DAA510-0x00DAA520
	}
}
