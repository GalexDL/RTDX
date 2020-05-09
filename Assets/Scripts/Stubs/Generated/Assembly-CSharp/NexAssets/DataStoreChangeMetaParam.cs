/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class DataStoreChangeMetaParam // TypeDefIndex: 9421
	{
		// Fields
		[SerializeField] // 0x00617CB0-0x00617CC0
		private DataStore.ModificationFlag modificationFlag; // 0x10
		[SerializeField] // 0x00617CC0-0x00617CD0
		private DataStore.DataStatus dataStatus; // 0x14
		[SerializeField] // 0x00617CD0-0x00617CE0
		private string name; // 0x18
		[SerializeField] // 0x00617CE0-0x00617CF0
		private List<string> tags; // 0x20
		// [Range] // 0x00617CF0-0x00617D40
		[SerializeField] // 0x00617CF0-0x00617D40
		private ushort period; // 0x28
		// [Range] // 0x00617D40-0x00617D90
		[SerializeField] // 0x00617D40-0x00617D90
		private ushort dataType; // 0x2A
		[SerializeField] // 0x00617D90-0x00617DA0
		private DataStore.Permission accessPermission; // 0x2C
		[SerializeField] // 0x00617DA0-0x00617DB0
		private DataStore.Permission updatePermission; // 0x30
		[SerializeField] // 0x00617DB0-0x00617DC0
		private bool isUsePersistenceSlotId; // 0x34
		// [Range] // 0x00617DC0-0x00617E00
		[SerializeField] // 0x00617DC0-0x00617E00
		private ushort persistenceSlotId; // 0x36
		[SerializeField] // 0x00617E00-0x00617E10
		private string dataId; // 0x38
		private ulong dataId_; // 0x40
		[SerializeField] // 0x00617E10-0x00617E20
		private DataStoreChangeMetaCompareParam dataStoreChangeMetaCompareParam; // 0x48
	
		// Constructors
		public DataStoreChangeMetaParam() {} // 0x00DAA320-0x00DAA460
	
		// Methods
		public void Validate() {} // 0x00DA9FD0-0x00DAA0A0
		public NexPlugin.DataStoreChangeMetaParam GetDataStoreChangeMetaParam() => default; // 0x00DAA160-0x00DAA320
	}
}
