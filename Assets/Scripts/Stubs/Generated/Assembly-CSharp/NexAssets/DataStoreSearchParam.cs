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
	public class DataStoreSearchParam // TypeDefIndex: 9415
	{
		// Fields
		[SerializeField] // 0x006178B0-0x006178C0
		private DataStore.SearchType searchTarget; // 0x10
		[SerializeField] // 0x006178C0-0x006178D0
		private DataStore.SearchTarget ownerType; // 0x14
		[SerializeField] // 0x006178D0-0x006178E0
		private List<ushort> dataTypes; // 0x18
		[SerializeField] // 0x006178E0-0x006178F0
		private DataStore.SearchSortColumn resultOrderColumn; // 0x20
		[SerializeField] // 0x006178F0-0x00617900
		private DataStore.SearchSortOrder resultOrder; // 0x24
		[SerializeField] // 0x00617900-0x00617910
		private ResultRange resultRange; // 0x28
		[SerializeField] // 0x00617910-0x00617920
		private DataStore.ResultFlag resultOption; // 0x30
		[SerializeField] // 0x00617920-0x00617930
		private List<string> tags; // 0x38
		[SerializeField] // 0x00617930-0x00617940
		private uint minimalRatingFrequency; // 0x40
		[SerializeField] // 0x00617940-0x00617950
		private bool totalCountEnabled; // 0x44
		[SerializeField] // 0x00617950-0x00617960
		private bool useCache; // 0x45
	
		// Constructors
		public DataStoreSearchParam() {} // 0x00DAAFB0-0x00DAB030
	
		// Methods
		public void Validate() {} // 0x00DAABE0-0x00DAAC50
		public NexPlugin.DataStoreSearchParam GetDataStoreSearchParam(bool isSearchLight = false /* Metadata: 0x00631F66 */) => default; // 0x00DAAD00-0x00DAAEB0
		public void SetDataType(List<ushort> arg_datatypes) {} // 0x00DAAF40-0x00DAAF50
		public void SetRangeSize(uint arg_size) {} // 0x00DAAF50-0x00DAAF60
		public void SetRangeOffset(uint arg_offset) {} // 0x00DAAF70-0x00DAAF80
		public void SetResultOption(DataStore.ResultFlag arg_flag) {} // 0x00DAAF90-0x00DAAFA0
		public void SetTotalCountEnabled(bool arg_enabled) {} // 0x00DAAFA0-0x00DAAFB0
	}
}
