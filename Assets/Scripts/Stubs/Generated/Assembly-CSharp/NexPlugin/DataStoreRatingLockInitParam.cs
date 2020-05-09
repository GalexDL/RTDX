/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class DataStoreRatingLockInitParam // TypeDefIndex: 9257
	{
		// Fields
		internal DataStore.RatingLockType lockType; // 0x10
		internal short periodDuration; // 0x14
		internal sbyte periodHour; // 0x16
	
		// Constructors
		public DataStoreRatingLockInitParam() {} // 0x00FA5ED0-0x00FA5F00
	
		// Methods
		private void Reset() {} // 0x00FA63A0-0x00FA63B0
		public void SetIntervalLock(short intervalSec) {} // 0x00FA63B0-0x00FA63D0
		public void SetPeriodicLock(DataStore.RatingLockPeriod period, sbyte hour) {} // 0x00FA63D0-0x00FA6400
		public void SetDaysAfterLock(short days, sbyte hour) {} // 0x00FA6400-0x00FA6430
		public void SetPermanentLock() {} // 0x00FA6430-0x00FA6450
		public void Trace() {} // 0x00FA6450-0x00FA6460
		public override string ToString() => default; // 0x00FA6460-0x00FA6580
	}
}
