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
	public struct TouchScreenState16 // TypeDefIndex: 9117
	{
		// Fields
		public const int TouchCount = 16; // Metadata: 0x0063139F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray16 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray16 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9118
		{
			// Fields
			private const int _Length = 16; // Metadata: 0x006313A3
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
			private TouchState _value5; // 0xD8
			private TouchState _value6; // 0x100
			private TouchState _value7; // 0x128
			private TouchState _value8; // 0x150
			private TouchState _value9; // 0x178
			private TouchState _value10; // 0x1A0
			private TouchState _value11; // 0x1C8
			private TouchState _value12; // 0x1F0
			private TouchState _value13; // 0x218
			private TouchState _value14; // 0x240
			private TouchState _value15; // 0x268
	
			// Properties
			public int Length { get => default; } // 0x01136B80-0x01136DA0 
			public TouchState this[int index] { get => default; set {} } // 0x01136DA0-0x01136EF0 0x01136EF0-0x01136F30
			public int Count { get => default; } // 0x01136F30-0x01136F40 
			public bool IsReadOnly { get => default; } // 0x01136F40-0x01136F50 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01136F50-0x01137040
			public int IndexOf(TouchState item) => default; // 0x01137040-0x01137760
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01137760-0x01138010
			public override string ToString() => default; // 0x01138010-0x01138020
			// [IteratorStateMachine] // 0x00656CA0-0x00656D10
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01138050-0x011380D0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x011380D0-0x01138150
			public void Add(TouchState item) {} // 0x01138150-0x011381C0
			public void Clear() {} // 0x011381C0-0x01138230
			public void Insert(int index, TouchState item) {} // 0x01138230-0x01138310
			public bool Remove(TouchState item) => default; // 0x01138310-0x01138320
			public void RemoveAt(int index) {} // 0x01138320-0x01138390
		}
	
		// Methods
		public void SetDefault() {} // 0x01136B70-0x01136B80
	}
}
