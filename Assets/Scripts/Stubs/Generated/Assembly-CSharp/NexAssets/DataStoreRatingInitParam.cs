/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class DataStoreRatingInitParam // TypeDefIndex: 9419
	{
		// Fields
		// [Range] // 0x00617B00-0x00617B40
		[SerializeField] // 0x00617B00-0x00617B40
		private sbyte slot; // 0x10
		[SerializeField] // 0x00617B40-0x00617B50
		private long initialValue; // 0x18
		[SerializeField] // 0x00617B50-0x00617B60
		private int rangeMin; // 0x20
		[SerializeField] // 0x00617B60-0x00617B70
		private int rangeMax; // 0x24
		[SerializeField] // 0x00617B70-0x00617B80
		private DataStore.RatingFlag flag; // 0x28
		[SerializeField] // 0x00617B80-0x00617B90
		private bool isUseMin; // 0x2C
		[SerializeField] // 0x00617B90-0x00617BA0
		private bool isUseMax; // 0x2D
		[SerializeField] // 0x00617BA0-0x00617BB0
		private DataStoreRatingLockInitParam dataStoreRatingLockInitParam; // 0x30
	
		// Constructors
		public DataStoreRatingInitParam() {} // 0x00DAABC0-0x00DAABD0
	
		// Methods
		public sbyte GetSlot() => default; // 0x00DAA890-0x00DAA8A0
		public NexPlugin.DataStoreRatingInitParam GetDataStoreRatingInitParam() => default; // 0x00DAA8A0-0x00DAA980
	}
}
