/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public struct NpDateTime // TypeDefIndex: 9240
	{
		// Fields
		public short year; // 0x10
		public byte month; // 0x12
		public byte day; // 0x13
		public byte hour; // 0x14
		public byte minute; // 0x15
		public byte second; // 0x16
		private byte isNotNever; // 0x17
		public static readonly NpDateTime INVALID_DATE_TIME; // 0x00
		public static readonly NpDateTime Future; // 0x08
		public static readonly NpDateTime PERMANENT_DATE_TIME; // 0x10
		public static readonly NpDateTime Never; // 0x18
	
		// Constructors
		public NpDateTime(DateTime dt) {
			year = default;
			month = default;
			day = default;
			hour = default;
			minute = default;
			second = default;
			isNotNever = default;
		} // 0x00FC0920-0x00FC09E0
		public NpDateTime(short srcYear, byte srcMonth, byte srcDay, byte srcHour, byte srcMinute, byte srcSecond) {
			year = default;
			month = default;
			day = default;
			hour = default;
			minute = default;
			second = default;
			isNotNever = default;
		} // 0x00FC09E0-0x00FC0A10
		public NpDateTime(IntPtr src) {
			year = default;
			month = default;
			day = default;
			hour = default;
			minute = default;
			second = default;
			isNotNever = default;
		} // 0x00FC0A10-0x00FC0AA0
		public NpDateTime(bool notnever) {
			year = default;
			month = default;
			day = default;
			hour = default;
			minute = default;
			second = default;
			isNotNever = default;
		} // 0x00FC0AA0-0x00FC0AC0
		static NpDateTime() {
			INVALID_DATE_TIME = default;
			Future = default;
			PERMANENT_DATE_TIME = default;
			Never = default;
		} // 0x00FC0E10-0x00FC0EA0
	
		// Methods
		public void Trace() {} // 0x00FC0AC0-0x00FC0E00
		internal new string ToString() => default; // 0x00FC0E00-0x00FC0E10
	}
}
