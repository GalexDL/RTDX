/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct TouchScreenState8 // TypeDefIndex: 9093
	{
		// Fields
		public const int TouchCount = 8; // Metadata: 0x0063135F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray8 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray8 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9094
		{
			// Fields
			private const int _Length = 8; // Metadata: 0x00631363
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
			private TouchState _value5; // 0xD8
			private TouchState _value6; // 0x100
			private TouchState _value7; // 0x128
	
			// Properties
			public int Length { get => default; } // 0x0113FEC0-0x01140020 
			public TouchState this[int index] { get => default; set {} } // 0x01140020-0x01140130 0x01140130-0x01140170
			public int Count { get => default; } // 0x01140170-0x01140180 
			public bool IsReadOnly { get => default; } // 0x01140180-0x01140190 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01140190-0x01140580
			public int IndexOf(TouchState item) => default; // 0x01140580-0x01140E60
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01140E60-0x01141300
			public override string ToString() => default; // 0x01141300-0x01141310
			// [IteratorStateMachine] // 0x00656920-0x00656990
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01141340-0x011413C0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x011413C0-0x01141440
			public void Add(TouchState item) {} // 0x01141440-0x011414B0
			public void Clear() {} // 0x011414B0-0x01141520
			public void Insert(int index, TouchState item) {} // 0x01141520-0x01141600
			public bool Remove(TouchState item) => default; // 0x01141600-0x01141610
			public void RemoveAt(int index) {} // 0x01141610-0x01141680
		}
	
		// Methods
		public void SetDefault() {} // 0x0113FEB0-0x0113FEC0
	}
}
