/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public class DataStore_Core : Common // TypeDefIndex: 9424
	{
		// Fields
		[SerializeField] // 0x00617F20-0x00617F30
		private DataStoreBaseParam dataStoreBaseParam; // 0x18
		private static Dictionary<int, FunctionInfo> FunctionInfos; // 0x00
		private static List<ApiCallsFrequency> s_ApiCallsFrequencyList; // 0x08
	
		// Nested types
		protected enum Functions // TypeDefIndex: 9425
		{
			SearchObject = 0,
			GetObject = 1,
			PostObject = 2,
			PostObject2 = 3,
			PostObject4 = 4,
			PostObject5 = 5,
			UpdateObject = 6,
			GetRating = 7,
			GetRatings = 8,
			GetRatingWithLog = 9,
			CompleteSuspendedPostObject = 10,
			DeleteObject = 11,
			DeleteObjects = 12,
			ChangeMeta = 13,
			ChangeMetas = 14,
			GetMeta = 15,
			GetMetas = 16,
			GetMetasParam = 17,
			RateObject = 18,
			RateObjects = 19,
			RateObjectWithPosting = 20,
			RateObjectsWithPosting = 21,
			ResetRating = 22,
			ResetRatings = 23,
			TouchObject = 24,
			GetPersistenceInfo = 25,
			GetPersistenceInfos = 26,
			PerpetuateObject = 27,
			UnperpetuateObject = 28,
			GetPasswordInfo = 29,
			GetPasswordInfos = 30,
			SearchObjectLight = 31
		}
	
		// Constructors
		public DataStore_Core() {} // 0x00DAB250-0x00DAB2C0
		static DataStore_Core() {} // 0x00DAB2C0-0x00DAB980
	
		// Methods
		public uint GetHttpThreadPrioritySetting() => default; // 0x00DAB040-0x00DAB050
		public uint GetHttpBufferSizeSetting() => default; // 0x00DAB050-0x00DAB060
		public uint GetTimeoutBytesPerSecondSetting() => default; // 0x00DAB060-0x00DAB070
		public int GetMinimumTimeoutMilliSecondSetting() => default; // 0x00DAB070-0x00DAB080
		public uint GetHttpSendSocketBufferSizeSetting() => default; // 0x00DAB080-0x00DAB090
		public uint GetHttpRecvSocketBufferSizeSetting() => default; // 0x00DAB090-0x00DAB0A0
		public bool SetHttpThreadPriority() => default; // 0x00DAB0A0-0x00DAB0B0
		public bool SetHttpThreadPriority(uint priority) => default; // 0x00DAB0B0-0x00DAB0C0
		public bool GetHttpThreadPriority(ref uint priority) => default; // 0x00DAB0C0-0x00DAB0D0
		public bool SetHttpBufferSize() => default; // 0x00DAB0D0-0x00DAB0E0
		public bool SetHttpBufferSize(uint bufferSize) => default; // 0x00DAB0E0-0x00DAB0F0
		public bool GetHttpBufferSize(ref uint bufferSize) => default; // 0x00DAB0F0-0x00DAB100
		public bool SetDataTransferTimeout() => default; // 0x00DAB100-0x00DAB110
		public bool SetDataTransferTimeout(uint timeoutBytesPerSecond, int minimumTimeoutMilliSecond) => default; // 0x00DAB110-0x00DAB120
		public bool SetHttpSendSocketBufferSize() => default; // 0x00DAB120-0x00DAB130
		public bool SetHttpSendSocketBufferSize(uint size) => default; // 0x00DAB130-0x00DAB140
		public bool GetHttpSendSocketBufferSize(ref uint size) => default; // 0x00DAB140-0x00DAB150
		public bool SetHttpRecvSocketBufferSize() => default; // 0x00DAB150-0x00DAB160
		public bool SetHttpRecvSocketBufferSize(uint size) => default; // 0x00DAB160-0x00DAB170
		public bool GetHttpRecvSocketBufferSize(ref uint size) => default; // 0x00DAB170-0x00DAB180
		protected new bool ApiCallsFrequencyCheck(int type) => default; // 0x00DAB180-0x00DAB250
	}
}
