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
	public struct TouchScreenState10 // TypeDefIndex: 9099
	{
		// Fields
		public const int TouchCount = 10; // Metadata: 0x0063136F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray10 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray10 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9100
		{
			// Fields
			private const int _Length = 10; // Metadata: 0x00631373
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
	
			// Properties
			public int Length { get => default; } // 0x00A1F110-0x00A1F2A0 
			public TouchState this[int index] { get => default; set {} } // 0x00A1F2A0-0x00A1F3C0 0x00A1F3C0-0x00A1F400
			public int Count { get => default; } // 0x00A1F400-0x00A1F410 
			public bool IsReadOnly { get => default; } // 0x00A1F410-0x00A1F840 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x00A1F840-0x00A1FCD0
			public int IndexOf(TouchState item) => default; // 0x00A1FCD0-0x00A20300
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x00A20300-0x00A208A0
			public override string ToString() => default; // 0x00A208A0-0x00A208B0
			// [IteratorStateMachine] // 0x00656A00-0x00656A70
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x00A208B0-0x00A20930
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00A20930-0x00A209B0
			public void Add(TouchState item) {} // 0x00A209B0-0x00A20A20
			public void Clear() {} // 0x00A20A20-0x00A20A90
			public void Insert(int index, TouchState item) {} // 0x00A20A90-0x00A20B70
			public bool Remove(TouchState item) => default; // 0x00A20B70-0x00A20B80
			public void RemoveAt(int index) {} // 0x00A20B80-0x00A20BF0
		}
	
		// Methods
		public void SetDefault() {} // 0x00A1F100-0x00A1F110
	}
}
