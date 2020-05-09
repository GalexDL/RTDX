/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class DataStoreBaseParam // TypeDefIndex: 9414
	{
		// Fields
		[SerializeField] // 0x00617810-0x00617820
		private uint httpThreadPriority; // 0x10
		[SerializeField] // 0x00617820-0x00617830
		private uint httpBufferSize; // 0x14
		[SerializeField] // 0x00617830-0x00617840
		private uint timeoutBytesPerSecond; // 0x18
		// [Range] // 0x00617840-0x00617890
		[SerializeField] // 0x00617840-0x00617890
		private int minimumTimeoutMilliSecond; // 0x1C
		[SerializeField] // 0x00617890-0x006178A0
		private uint httpSendSocketBufferSize; // 0x20
		[SerializeField] // 0x006178A0-0x006178B0
		private uint httpRecvSocketBufferSize; // 0x24
	
		// Constructors
		public DataStoreBaseParam() {} // 0x00DA9CA0-0x00DA9CD0
	
		// Methods
		public uint GetHttpThreadPrioritySetting() => default; // 0x00DA9C40-0x00DA9C50
		public uint GetHttpBufferSizeSetting() => default; // 0x00DA9C50-0x00DA9C60
		public uint GetTimeoutBytesPerSecondSetting() => default; // 0x00DA9C60-0x00DA9C70
		public int GetMinimumTimeoutMilliSecondSetting() => default; // 0x00DA9C70-0x00DA9C80
		public uint GetHttpSendSocketBufferSizeSetting() => default; // 0x00DA9C80-0x00DA9C90
		public uint GetHttpRecvSocketBufferSizeSetting() => default; // 0x00DA9C90-0x00DA9CA0
	}
}
