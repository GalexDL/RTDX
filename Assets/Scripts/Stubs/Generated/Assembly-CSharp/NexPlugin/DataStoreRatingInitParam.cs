/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class DataStoreRatingInitParam // TypeDefIndex: 9258
	{
		// Fields
		internal long initialValue; // 0x10
		internal int rangeMin; // 0x18
		internal int rangeMax; // 0x1C
		internal DataStore.RatingFlag flag; // 0x20
		internal DataStore.RatingInternalFlag internalFlag; // 0x24
		internal DataStore.RatingLockType lockType; // 0x28
		internal short periodDuration; // 0x2C
		internal sbyte periodHour; // 0x2E
		internal sbyte slot; // 0x2F
	
		// Constructors
		public DataStoreRatingInitParam() {} // 0x00FA5DB0-0x00FA5DE0
	
		// Methods
		public void SetInitialValue(long initialValue_) {} // 0x00FA5DF0-0x00FA5E00
		public void SetRangeMin(int min_) {} // 0x00FA5E00-0x00FA5E20
		public void SetRangeMax(int max) {} // 0x00FA5E20-0x00FA5E40
		public void SetLock(DataStoreRatingLockInitParam ratingLockInitParam) {} // 0x00FA5E40-0x00FA5ED0
		public void SetFlag(DataStore.RatingFlag flag_) {} // 0x00FA5F00-0x00FA5F10
		public void Reset() {} // 0x00FA5DE0-0x00FA5DF0
		public void Trace() {} // 0x00FA5F10-0x00FA5F20
		public override string ToString() => default; // 0x00FA5F20-0x00FA63A0
	}
}
