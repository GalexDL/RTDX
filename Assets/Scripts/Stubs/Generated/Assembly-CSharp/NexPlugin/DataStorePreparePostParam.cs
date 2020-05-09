/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class DataStorePreparePostParam // TypeDefIndex: 9259
	{
		// Fields
		internal uint size; // 0x10
		internal string name; // 0x18
		internal ushort dataType; // 0x20
		internal ushort period; // 0x22
		internal DataStorePermission accessPermission; // 0x28
		internal DataStorePermission updatePermission; // 0x30
		internal DataStore.DataFlag flag; // 0x38
		internal List<string> tags; // 0x40
		internal Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParams; // 0x48
		internal List<byte> meta; // 0x50
		internal DataStorePersistenceInitParam persistenceInitParam; // 0x58
	
		// Constructors
		public DataStorePreparePostParam() {} // 0x00FA4D90-0x00FA4DC0
	
		// Methods
		public void SetSize(uint size_) {} // 0x00F90760-0x00F90770
		public uint GetSize() => default; // 0x00FA5130-0x00FA5140
		public void SetName(string name_) {} // 0x00FA5140-0x00FA51B0
		public string GetName() => default; // 0x00FA51B0-0x00FA51C0
		public void SetDataType(ushort dataType_) {} // 0x00F90770-0x00F90780
		public ushort GetDataType() => default; // 0x00FA51C0-0x00FA51D0
		public void SetAccessPermission(DataStorePermission permission_) {} // 0x00FA51D0-0x00FA5250
		public DataStorePermission GetAccessPermission() => default; // 0x00FA5250-0x00FA5260
		public void SetUpdatePermission(DataStorePermission updatePermission_) {} // 0x00FA5260-0x00FA52E0
		public DataStorePermission GetUpdatePermission() => default; // 0x00FA52E0-0x00FA52F0
		public void SetDataFlag(DataStore.DataFlag flag_) {} // 0x00FA52F0-0x00FA5300
		public DataStore.DataFlag GetDataFlag() => default; // 0x00FA5300-0x00FA5310
		public void SetPeriod(ushort period_) {} // 0x00FA5310-0x00FA5320
		public ushort GetPeriod() => default; // 0x00FA5320-0x00FA5330
		public void SetTags(List<string> tags_) {} // 0x00F906E0-0x00F90760
		public List<string> GetTags() => default; // 0x00FA5330-0x00FA5340
		public void SetRatingSetting(Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParam) {} // 0x00FA5340-0x00FA53C0
		public void ClearRatingSetting() {} // 0x00FA53C0-0x00FA5410
		public bool AddRatingSetting(sbyte slot, DataStoreRatingInitParam ratingInitParam) => default; // 0x00FA5410-0x00FA54D0
		public Dictionary<sbyte, DataStoreRatingInitParam> GetRatingSetting() => default; // 0x00FA54D0-0x00FA54E0
		public void SetMetaBinary(List<byte> meta_) {} // 0x00F90780-0x00F90800
		public List<byte> GetMetaBinary() => default; // 0x00FA54E0-0x00FA54F0
		public void SetPersistenceInitParam(DataStorePersistenceInitParam persistenceInitParam_) {} // 0x00FA54F0-0x00FA5570
		public DataStorePersistenceInitParam GetPersistenceInitParam() => default; // 0x00FA5570-0x00FA5580
		public void Reset() {} // 0x00FA4DC0-0x00FA5130
		public void Trace() {} // 0x00FA5580-0x00FA5590
		public override string ToString() => default; // 0x00FA5590-0x00FA5850
	}
}
