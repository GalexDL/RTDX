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
	public class DataStoreChangeMetaCompareParam // TypeDefIndex: 9268
	{
		// Fields
		internal DataStore.ComparisonFlag comparisonFlag; // 0x10
		internal string name; // 0x18
		internal DataStorePermission accessPermission; // 0x20
		internal DataStorePermission updatePermission; // 0x28
		internal ushort dataType; // 0x30
		internal ushort period; // 0x32
		internal List<string> tags; // 0x38
		internal List<byte> metaBinary; // 0x40
		internal DataStore.DataStatus status; // 0x48
	
		// Constructors
		public DataStoreChangeMetaCompareParam() {} // 0x00FA1D90-0x00FA1DC0
		public DataStoreChangeMetaCompareParam(DataStore.ComparisonFlag comparisonFlag, DataStoreMetaInfo metaInfo) {} // 0x00FA2050-0x00FA2090
	
		// Methods
		public void Set(DataStore.ComparisonFlag comparisonFlag_, DataStoreMetaInfo metaInfo_) {} // 0x00FA2090-0x00FA2340
		public void SetComparisonFlag(DataStore.ComparisonFlag comparisonFlag_) {} // 0x00FA2460-0x00FA2470
		public DataStore.ComparisonFlag GetComparisonFlag() => default; // 0x00FA2780-0x00FA2790
		public void SetName(string name_) {} // 0x00FA2480-0x00FA24F0
		public string GetName() => default; // 0x00FA2790-0x00FA27A0
		public void SetAccessPermission(DataStorePermission permission_) {} // 0x00FA2500-0x00FA2580
		public DataStorePermission GetAccessPermission() => default; // 0x00FA27D0-0x00FA27E0
		public void SetUpdatePermission(DataStorePermission updatePermission_) {} // 0x00FA2590-0x00FA2610
		public DataStorePermission GetUpdatePermission() => default; // 0x00FA27E0-0x00FA27F0
		public void SetPeriod(ushort period_) {} // 0x00FA2620-0x00FA2630
		public ushort GetPeriod() => default; // 0x00FA27F0-0x00FA2800
		public void SetTags(List<string> tags_) {} // 0x00FA26C0-0x00FA2740
		public List<string> GetTags() => default; // 0x00FA2800-0x00FA2810
		public void SetMetaBinary(List<byte> meta) {} // 0x00FA2630-0x00FA26B0
		public List<byte> GetMetaBinary() => default; // 0x00FA2810-0x00FA2820
		public void SetDataType(ushort dataType_) {} // 0x00FA2750-0x00FA2760
		public ushort GetDataType() => default; // 0x00FA2820-0x00FA2830
		public void SetDataStatus(DataStore.DataStatus status_) {} // 0x00FA2770-0x00FA2780
		public DataStore.DataStatus GetDataStatus() => default; // 0x00FA2830-0x00FA2840
		private void Reset() {} // 0x00FA1DC0-0x00FA2050
		public void Trace() {} // 0x00FA28D0-0x00FA28E0
		public override string ToString() => default; // 0x00FA28E0-0x00FA2B40
	}
}
