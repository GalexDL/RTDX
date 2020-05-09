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
	public class DataStorePreparePostParam // TypeDefIndex: 9417
	{
		// Fields
		[SerializeField] // 0x00617990-0x006179A0
		private string name; // 0x10
		[SerializeField] // 0x006179A0-0x006179B0
		private List<string> tags; // 0x18
		// [Range] // 0x006179B0-0x00617A00
		[SerializeField] // 0x006179B0-0x00617A00
		private ushort period; // 0x20
		// [Range] // 0x00617A00-0x00617A50
		[SerializeField] // 0x00617A00-0x00617A50
		private ushort dataType; // 0x22
		[SerializeField] // 0x00617A50-0x00617A60
		private DataStore.DataFlag dataFlag; // 0x24
		[SerializeField] // 0x00617A60-0x00617A70
		private DataStore.Permission accessPermission; // 0x28
		[SerializeField] // 0x00617A70-0x00617A80
		private DataStore.Permission updatePermission; // 0x2C
		[SerializeField] // 0x00617A80-0x00617A90
		private DataStorePersistenceInitParam persistenceInitParam; // 0x30
		[SerializeField] // 0x00617A90-0x00617AA0
		private List<DataStoreRatingInitParam> dataStoreRatingInitParamList; // 0x38
	
		// Constructors
		public DataStorePreparePostParam() {} // 0x00DAA9E0-0x00DAAAC0
	
		// Methods
		public void Validate() {} // 0x00DAA530-0x00DAA5C0
		public NexPlugin.DataStorePreparePostParam GetDataStorePreparePostParam() => default; // 0x00DAA5C0-0x00DAA890
		public void SetDataType(ushort arg_type) {} // 0x00DAA980-0x00DAA990
		public void SetName(string arg_name) {} // 0x00DAA990-0x00DAA9A0
		public void SetIsPersistence(bool arg_persistence) {} // 0x00DAA9A0-0x00DAA9B0
		public void SetAccessPermission(DataStore.Permission arg_permission) {} // 0x00DAA9B0-0x00DAA9C0
		public void SetUpdatePermission(DataStore.Permission arg_permission) {} // 0x00DAA9C0-0x00DAA9D0
		public void SetPeriod(ushort arg_period) {} // 0x00DAA9D0-0x00DAA9E0
	}
}
