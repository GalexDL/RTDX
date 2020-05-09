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
	public class DataStoreRatingLockInitParam // TypeDefIndex: 9420
	{
		// Fields
		[SerializeField] // 0x00617BB0-0x00617BC0
		private RatingLockType ratingLockType; // 0x10
		// [Range] // 0x00617BC0-0x00617C10
		[SerializeField] // 0x00617BC0-0x00617C10
		private short periodDuration; // 0x14
		[SerializeField] // 0x00617C10-0x00617C20
		private DataStore.RatingLockPeriod periodDurationFlag; // 0x18
		// [Range] // 0x00617C20-0x00617C60
		[SerializeField] // 0x00617C20-0x00617C60
		private sbyte periodHour; // 0x1C
		// [Range] // 0x00617C60-0x00617CB0
		[SerializeField] // 0x00617C60-0x00617CB0
		private short periodDays; // 0x1E
	
		// Constructors
		public DataStoreRatingLockInitParam() {} // 0x00DAABD0-0x00DAABE0
	
		// Methods
		public NexPlugin.DataStoreRatingLockInitParam GetDataStoreRatingLockInitParam() => default; // 0x00DAAAC0-0x00DAABC0
	}
}
