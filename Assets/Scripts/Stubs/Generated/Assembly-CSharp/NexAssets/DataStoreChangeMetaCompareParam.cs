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
	public class DataStoreChangeMetaCompareParam // TypeDefIndex: 9422
	{
		// Fields
		[SerializeField] // 0x00617E20-0x00617E30
		private DataStore.ComparisonFlag comparisonFlag; // 0x10
		[SerializeField] // 0x00617E30-0x00617E40
		private DataStore.DataStatus dataStatus; // 0x14
		[SerializeField] // 0x00617E40-0x00617E50
		private string name; // 0x18
		[SerializeField] // 0x00617E50-0x00617E60
		private List<string> tags; // 0x20
		// [Range] // 0x00617E60-0x00617EB0
		[SerializeField] // 0x00617E60-0x00617EB0
		private ushort period; // 0x28
		// [Range] // 0x00617EB0-0x00617F00
		[SerializeField] // 0x00617EB0-0x00617F00
		private ushort dataType; // 0x2A
		[SerializeField] // 0x00617F00-0x00617F10
		private DataStore.Permission accessPermission; // 0x2C
		[SerializeField] // 0x00617F10-0x00617F20
		private DataStore.Permission updatePermission; // 0x30
	
		// Constructors
		public DataStoreChangeMetaCompareParam() {} // 0x00DA9F40-0x00DA9FD0
	
		// Methods
		public void Validate() {} // 0x00DA9CD0-0x00DA9CE0
		public NexPlugin.DataStoreChangeMetaCompareParam GetDataStoreChangeMetaCompareParam() => default; // 0x00DA9DF0-0x00DA9F40
	}
}
