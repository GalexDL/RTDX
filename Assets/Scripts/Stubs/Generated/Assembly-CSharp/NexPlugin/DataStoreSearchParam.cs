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
	public class DataStoreSearchParam // TypeDefIndex: 9261
	{
		// Fields
		internal DataStore.SearchType searchTarget; // 0x10
		internal List<ulong> ownerIds; // 0x18
		internal DataStore.SearchTarget ownerType; // 0x20
		internal List<ulong> destinationIds; // 0x28
		internal List<ushort> dataTypes; // 0x30
		internal NpDateTime createdAfter; // 0x38
		internal NpDateTime createdBefore; // 0x40
		internal NpDateTime updatedAfter; // 0x48
		internal NpDateTime updatedBefore; // 0x50
		internal DataStore.SearchSortColumn resultOrderColumn; // 0x58
		internal DataStore.SearchSortOrder resultOrder; // 0x5C
		internal ResultRange resultRange; // 0x60
		internal DataStore.ResultFlag resultOption; // 0x68
		internal List<string> tags; // 0x70
		internal uint minimalRatingFrequency; // 0x78
		internal bool totalCountEnabled; // 0x7C
		internal bool useCache; // 0x7D
	
		// Constructors
		public DataStoreSearchParam() {} // 0x00FA6AA0-0x00FA6AD0
	
		// Methods
		public void SetSearchType(DataStore.SearchType searchType) {} // 0x00FA6D30-0x00FA6D40
		public DataStore.SearchType GetSearchType() => default; // 0x00FA6D40-0x00FA6D50
		public void SetOwnerIds(List<ulong> ownerIds_) {} // 0x00FA6D50-0x00FA6DD0
		public List<ulong> GetOwnerIds() => default; // 0x00FA6DD0-0x00FA6DE0
		public void SetOwnerType(DataStore.SearchTarget ownerType_) {} // 0x00FA6DE0-0x00FA6DF0
		public DataStore.SearchTarget GetOwnerType() => default; // 0x00FA6DF0-0x00FA6E00
		public void SetDestinationIds(List<ulong> destinationIds_) {} // 0x00FA6E00-0x00FA6E80
		public List<ulong> GetDestinationIds() => default; // 0x00FA6E80-0x00FA6E90
		public void SetDataType(ushort dataType_) {} // 0x00FA6E90-0x00FA6F10
		public void SetDataType(List<ushort> dataTypes_) {} // 0x00FA6F10-0x00FA6F90
		public ushort GetDataType() => default; // 0x00FA6F90-0x00FA7010
		public void GetDataType(ref List<ushort> dataTypes_) {} // 0x00FA7010-0x00FA7090
		public void SetCreatedAfter(NpDateTime createdAfter_) {} // 0x00FA7090-0x00FA70A0
		public NpDateTime GetCreatedAfter() => default; // 0x00FA70A0-0x00FA70B0
		public void SetCreatedBefore(NpDateTime createdBefore_) {} // 0x00FA70B0-0x00FA70C0
		public NpDateTime GetCreatedBefore() => default; // 0x00FA70C0-0x00FA70D0
		public void SetUpdatedAfter(NpDateTime updatedAfter_) {} // 0x00FA70D0-0x00FA70E0
		public NpDateTime GetUpdatedAfter() => default; // 0x00FA70E0-0x00FA70F0
		public void SetUpdatedBefore(NpDateTime updatedBefore_) {} // 0x00FA70F0-0x00FA7100
		public NpDateTime GetUpdatedBefore() => default; // 0x00FA7100-0x00FA7110
		public void SetSearchSortOrderColumn(DataStore.SearchSortColumn resultOrderColumn_) {} // 0x00FA7110-0x00FA7120
		public DataStore.SearchSortColumn GetSearchSortOrderColumn() => default; // 0x00FA7120-0x00FA7130
		public void SetSearchSortOrder(DataStore.SearchSortOrder resultOrder_) {} // 0x00FA7130-0x00FA7140
		public DataStore.SearchSortOrder GetSearchSortOrder() => default; // 0x00FA7140-0x00FA7150
		public void SetResultRange(ResultRange resultRange_) {} // 0x00FA7150-0x00FA7160
		public ResultRange GetResultRange() => default; // 0x00FA7160-0x00FA7170
		public void SetResultOption(DataStore.ResultFlag resultOption_) {} // 0x00FA7170-0x00FA7180
		public DataStore.ResultFlag GetResultOption() => default; // 0x00FA7180-0x00FA7190
		public void SetTags(List<string> tags_) {} // 0x00FA7190-0x00FA7210
		public List<string> GetTags() => default; // 0x00FA7210-0x00FA7220
		public void SetMinimalRatingFrequency(uint minimalRatingFrequency_) {} // 0x00FA7220-0x00FA7230
		public uint GetMinimalRatingFrequency() => default; // 0x00FA7230-0x00FA7240
		public void SetUseCache(bool useCache_) {} // 0x00FA7240-0x00FA7250
		public bool GetUseCache() => default; // 0x00FA7250-0x00FA7260
		public void SetTotalCountEnabled(bool totalCountEnabled_) {} // 0x00FA7260-0x00FA7270
		public bool GetTotalCountEnabled() => default; // 0x00FA7270-0x00FA7280
		private void Reset() {} // 0x00FA6AD0-0x00FA6D30
		public void Trace() {} // 0x00FA7280-0x00FA7290
		public override string ToString() => default; // 0x00FA7290-0x00FA7600
	}
}
