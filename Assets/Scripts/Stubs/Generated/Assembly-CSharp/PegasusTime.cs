/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class PegasusTime // TypeDefIndex: 5560
{
	// Nested types
	[Serializable]
	public struct POSIX32 // TypeDefIndex: 5561
	{
		// Fields
		[SerializeField] // 0x006185A0-0x006185B0
		private uint second; // 0x10

		// Constructors
		public POSIX32(uint value) {
			second = default;
		} // 0x00B6D160-0x00B6D180

		// Methods
		public void SetValue(uint value) {} // 0x00B6D180-0x00B6D190
		public uint GetValue() => default; // 0x00B6D190-0x00B6D2B0
		public RemainTime GetRemainSecondFromCurrentTime(int afterDay) => default; // 0x00B6D2B0-0x00B6D3C0
		public string DumpString() => default; // 0x00B6D3C0-0x00B6D3E0
	}

	[Serializable]
	public struct CalendarTime // TypeDefIndex: 5562
	{
		// Fields
		[SerializeField] // 0x006185B0-0x006185C0
		public int Year; // 0x10
		public int Month; // 0x14
		public int Day; // 0x18
		public int Hour; // 0x1C
		public int Minute; // 0x20
		public int Second; // 0x24
	}

	[Serializable]
	public struct RemainTime // TypeDefIndex: 5563
	{
		// Fields
		[SerializeField] // 0x006185C0-0x006185D0
		private long allSecond_; // 0x10

		// Properties
		public int Day { get; private set; } // 0x00B6D3E0-0x00B6D3F0 0x00B6D3F0-0x00B6D410
		public int Hour { get; private set; } // 0x00B6D410-0x00B6D420 0x00B6D420-0x00B6D440
		public int Minute { get; private set; } // 0x00B6D440-0x00B6D450 0x00B6D450-0x00B6D460
		public int Second { get; private set; } // 0x00B6D460-0x00B6D470 0x00B6D470-0x00B6D480

		// Constructors
		public RemainTime(long value) : this() {
			allSecond_ = default;
		} // 0x00B6D480-0x00B6D510
	}

	// Constructors
	public PegasusTime() {} // 0x00B6D150-0x00B6D160

	// Methods
	public static bool CanGetNetworkTime() => default; // 0x00B6CB30-0x00B6CBA0
	public static POSIX32 GetNowPOSIX32() => default; // 0x00B6CBA0-0x00B6CC20
	public static CalendarTime GetNowCalendarTime() => default; // 0x00B6CC20-0x00B6CDA0
	public static long AddDayForPOSIX(long posix, long day) => default; // 0x00B6CDA0-0x00B6CE20
	public static RemainTime GetRemainSecondFromCurrentTime(POSIX32 posix32, int afterDay) => default; // 0x00B6CE20-0x00B6CF40
	public static POSIX32 ConvertPOSIX32FromCalendar(int year, int month, int day, int hour, int minute, int second) => default; // 0x00B6CF40-0x00B6CFF0
	public static POSIX32 ConvertPOSIX32FromUTCCalendar(int year, int month, int day, int hour, int minute, int second) => default; // 0x00B6CFF0-0x00B6D0A0
	public static POSIX32 ConvertPOSIX32FromTimeZoneCalendar(int year, int month, int day, int hour, int minute, int second) => default; // 0x00B6D0A0-0x00B6D150
}

