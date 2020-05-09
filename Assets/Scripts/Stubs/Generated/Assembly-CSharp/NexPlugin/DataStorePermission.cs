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
	public class DataStorePermission // TypeDefIndex: 9252
	{
		// Fields
		internal DataStore.Permission permission; // 0x10
		internal List<ulong> recipientIds; // 0x18
	
		// Constructors
		public DataStorePermission() {} // 0x00FA27A0-0x00FA27D0
		public DataStorePermission(DataStore.Permission permission, List<ulong> recipientIds = null) {} // 0x00FA2840-0x00FA28D0
	
		// Methods
		public void SetPermission(DataStore.Permission permission_) {} // 0x00FA4340-0x00FA4350
		public DataStore.Permission GetPermission() => default; // 0x00FA43D0-0x00FA43E0
		public void SetRecipientIds(List<ulong> recipientIds_) {} // 0x00FA4350-0x00FA43D0
		public List<ulong> GetRecipientIds() => default; // 0x00FA43E0-0x00FA43F0
		private void Reset() {} // 0x00FA4280-0x00FA4340
		public void Trace() {} // 0x00FA43F0-0x00FA4400
		public override string ToString() => default; // 0x00FA4400-0x00FA44A0
	}
}
