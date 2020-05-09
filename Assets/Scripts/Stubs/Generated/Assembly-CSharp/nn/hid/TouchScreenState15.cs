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
	public struct TouchScreenState15 // TypeDefIndex: 9114
	{
		// Fields
		public const int TouchCount = 15; // Metadata: 0x00631397
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray15 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray15 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9115
		{
			// Fields
			private const int _Length = 15; // Metadata: 0x0063139B
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
	
			// Properties
			public int Length { get => default; } // 0x01134E70-0x01135070 
			public TouchState this[int index] { get => default; set {} } // 0x01135070-0x011351C0 0x011351C0-0x01135200
			public int Count { get => default; } // 0x01135200-0x01135210 
			public bool IsReadOnly { get => default; } // 0x01135210-0x01135220 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01135220-0x01135310
			public int IndexOf(TouchState item) => default; // 0x01135310-0x01135C30
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01135C30-0x01136460
			public override string ToString() => default; // 0x01136460-0x01136470
			// [IteratorStateMachine] // 0x00656C30-0x00656CA0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x011364A0-0x01136520
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01136520-0x011365A0
			public void Add(TouchState item) {} // 0x011365A0-0x01136610
			public void Clear() {} // 0x01136610-0x01136680
			public void Insert(int index, TouchState item) {} // 0x01136680-0x01136760
			public bool Remove(TouchState item) => default; // 0x01136760-0x01136770
			public void RemoveAt(int index) {} // 0x01136770-0x011367E0
		}
	
		// Methods
		public void SetDefault() {} // 0x01134E60-0x01134E70
	}
}
