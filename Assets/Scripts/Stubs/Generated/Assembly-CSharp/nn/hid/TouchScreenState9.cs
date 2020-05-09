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
	public struct TouchScreenState9 // TypeDefIndex: 9096
	{
		// Fields
		public const int TouchCount = 9; // Metadata: 0x00631367
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray9 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray9 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9097
		{
			// Fields
			private const int _Length = 9; // Metadata: 0x0063136B
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
			private TouchState _value5; // 0xD8
			private TouchState _value6; // 0x100
			private TouchState _value7; // 0x128
			private TouchState _value8; // 0x150
	
			// Properties
			public int Length { get => default; } // 0x01141900-0x01141A70 
			public TouchState this[int index] { get => default; set {} } // 0x01141A70-0x01141B90 0x01141B90-0x01141BD0
			public int Count { get => default; } // 0x01141BD0-0x01141BE0 
			public bool IsReadOnly { get => default; } // 0x01141BE0-0x01141BF0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01141BF0-0x01142050
			public int IndexOf(TouchState item) => default; // 0x01142050-0x01142A10
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01142A10-0x01142F30
			public override string ToString() => default; // 0x01142F30-0x01142F40
			// [IteratorStateMachine] // 0x00656990-0x00656A00
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01142F70-0x01142FF0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01142FF0-0x01143070
			public void Add(TouchState item) {} // 0x01143070-0x011430E0
			public void Clear() {} // 0x011430E0-0x01143150
			public void Insert(int index, TouchState item) {} // 0x01143150-0x01143230
			public bool Remove(TouchState item) => default; // 0x01143230-0x01143240
			public void RemoveAt(int index) {} // 0x01143240-0x011432B0
		}
	
		// Methods
		public void SetDefault() {} // 0x011418F0-0x01141900
	}
}
