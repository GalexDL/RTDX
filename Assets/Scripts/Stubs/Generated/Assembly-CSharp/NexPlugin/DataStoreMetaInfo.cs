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
	public class DataStoreMetaInfo // TypeDefIndex: 9253
	{
		// Fields
		internal ulong dataId; // 0x10
		internal ulong ownerId; // 0x18
		internal uint size; // 0x20
		internal string name; // 0x28
		internal ushort dataType; // 0x30
		internal ushort period; // 0x32
		internal DataStorePermission accessPermission; // 0x38
		internal DataStorePermission updatePermission; // 0x40
		internal NpDateTime createdTime; // 0x48
		internal NpDateTime updatedTime; // 0x50
		internal DataStore.DataStatus status; // 0x58
		internal uint referDataId; // 0x5C
		internal DataStore.DataFlag flag; // 0x60
		internal NpDateTime expireTime; // 0x64
		internal List<string> tags; // 0x70
		internal List<DataStoreRatingInfo> ratingInfo; // 0x78
		internal List<byte> metaBinary; // 0x80
	
		// Constructors
		public DataStoreMetaInfo() {} // 0x00FA2340-0x00FA2460
	
		// Methods
		public ulong GetDataId() => default; // 0x00F8D220-0x00F8D230
		public ulong GetOwnerId() => default; // 0x00F8D200-0x00F8D210
		public uint GetSize() => default; // 0x00FA3CB0-0x00FA3CC0
		public string GetName() => default; // 0x00FA2470-0x00FA2480
		public ushort GetDataType() => default; // 0x00FA2740-0x00FA2750
		public DataStorePermission GetAccessPermission() => default; // 0x00FA24F0-0x00FA2500
		public DataStorePermission GetUpdatePermission() => default; // 0x00FA2580-0x00FA2590
		public NpDateTime GetCreatedTime() => default; // 0x00FA3CC0-0x00FA3CD0
		public NpDateTime GetUpdatedTime() => default; // 0x00FA3CD0-0x00FA3CE0
		public ushort GetPeriod() => default; // 0x00FA2610-0x00FA2620
		public DataStore.DataStatus GetDataStatus() => default; // 0x00FA2760-0x00FA2770
		public uint GetReferDataId() => default; // 0x00FA3CE0-0x00FA3CF0
		public DataStore.DataFlag GetDataFlag() => default; // 0x00FA3CF0-0x00FA3D00
		public NpDateTime GetExpireTime() => default; // 0x00FA3D00-0x00FA3D10
		public List<string> GetTags() => default; // 0x00FA26B0-0x00FA26C0
		public List<DataStoreRatingInfo> GetRating() => default; // 0x00FA3D10-0x00FA3D20
		public List<byte> GetMetaBinary() => default; // 0x00F8D210-0x00F8D220
		public bool IsValid() => default; // 0x00FA3D20-0x00FA3D30
		public void Trace() {} // 0x00FA3D30-0x00FA3D40
		public override string ToString() => default; // 0x00FA3D40-0x00FA4130
	}
}
