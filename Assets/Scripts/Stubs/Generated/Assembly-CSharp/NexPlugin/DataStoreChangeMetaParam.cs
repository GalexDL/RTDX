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
	public class DataStoreChangeMetaParam // TypeDefIndex: 9269
	{
		// Fields
		internal ulong dataId; // 0x10
		internal DataStore.ModificationFlag modifiesFlag; // 0x18
		internal string name; // 0x20
		internal DataStorePermission accessPermission; // 0x28
		internal DataStorePermission updatePermission; // 0x30
		internal ushort period; // 0x38
		internal ushort dataType; // 0x3A
		internal List<string> tags; // 0x40
		internal List<byte> metaBinary; // 0x48
		internal DataStorePersistenceTarget persistenceTarget; // 0x50
		internal DataStore.DataStatus status; // 0x58
		internal ulong updatePassword; // 0x60
		internal DataStoreChangeMetaCompareParam compareParam; // 0x68
	
		// Constructors
		public DataStoreChangeMetaParam() {} // 0x00F90800-0x00F90830
	
		// Methods
		public void SetDataId(ulong dataId_) {} // 0x00F90830-0x00F90900
		public ulong GetDataId() => default; // 0x00FA2F40-0x00FA2F50
		public void SetModificationFlag(DataStore.ModificationFlag modificationFlag) {} // 0x00F909A0-0x00F909B0
		public DataStore.ModificationFlag GetModificationFlag() => default; // 0x00FA2F50-0x00FA2F60
		public void SetName(string name_) {} // 0x00FA2F60-0x00FA2FD0
		public string GetName() => default; // 0x00FA2FD0-0x00FA2FE0
		public void SetAccessPermission(DataStorePermission permission_) {} // 0x00FA2FE0-0x00FA3060
		public DataStorePermission GetAccessPermission() => default; // 0x00FA3060-0x00FA3070
		public void SetUpdatePermission(DataStorePermission updatePermission_) {} // 0x00FA3070-0x00FA30F0
		public DataStorePermission GetUpdatePermission() => default; // 0x00FA30F0-0x00FA3100
		public void SetPeriod(ushort period_) {} // 0x00F909B0-0x00F909C0
		public ushort GetPeriod() => default; // 0x00FA3100-0x00FA3110
		public void SetTags(List<string> tags_) {} // 0x00FA3110-0x00FA3190
		public List<string> GetTags() => default; // 0x00FA3190-0x00FA31A0
		public void SetMetaBinary(List<byte> meta) {} // 0x00F90920-0x00F909A0
		public List<byte> GetMetaBinary() => default; // 0x00FA31A0-0x00FA31B0
		public void SetUpdatePassword(ulong updatePassword_) {} // 0x00F90900-0x00F90910
		public ulong GetUpdatePassword() => default; // 0x00FA31B0-0x00FA31C0
		public void SetDataType(ushort dataType_) {} // 0x00F90910-0x00F90920
		private ushort GetDataType() => default; // 0x00FA31C0-0x00FA31D0
		public void SetDataStatus(DataStore.DataStatus status_) {} // 0x00FA31D0-0x00FA31E0
		public DataStore.DataStatus GetDataStatus() => default; // 0x00FA31E0-0x00FA31F0
		public void SetChangeMetaCompareParam(DataStoreChangeMetaCompareParam compareParam_) {} // 0x00FA31F0-0x00FA3270
		public DataStoreChangeMetaCompareParam GetChangeMetaCompareParam() => default; // 0x00FA3270-0x00FA3280
		public void SetPersistenceTarget(DataStorePersistenceTarget persistenceTarget_) {} // 0x00FA3280-0x00FA3340
		public DataStorePersistenceTarget GetPersistenceTarget() => default; // 0x00FA3340-0x00FA3350
		public void Reset() {} // 0x00FA2B40-0x00FA2EF0
		public void Trace() {} // 0x00FA3350-0x00FA3360
		public override string ToString() => default; // 0x00FA3360-0x00FA3670
	}
}
