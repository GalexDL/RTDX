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
	public struct TouchScreenState12 // TypeDefIndex: 9105
	{
		// Fields
		public const int TouchCount = 12; // Metadata: 0x0063137F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray12 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray12 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9106
		{
			// Fields
			private const int _Length = 12; // Metadata: 0x00631383
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
	
			// Properties
			public int Length { get => default; } // 0x0112FF30-0x011300E0 
			public TouchState this[int index] { get => default; set {} } // 0x011300E0-0x01130210 0x01130210-0x01130250
			public int Count { get => default; } // 0x01130250-0x01130260 
			public bool IsReadOnly { get => default; } // 0x01130260-0x01130270 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01130270-0x01130360
			public int IndexOf(TouchState item) => default; // 0x01130360-0x01130B20
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01130B20-0x011311C0
			public override string ToString() => default; // 0x011311C0-0x011311D0
			// [IteratorStateMachine] // 0x00656AE0-0x00656B50
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01131200-0x01131280
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01131280-0x01131300
			public void Add(TouchState item) {} // 0x01131300-0x01131370
			public void Clear() {} // 0x01131370-0x011313E0
			public void Insert(int index, TouchState item) {} // 0x011313E0-0x011314C0
			public bool Remove(TouchState item) => default; // 0x011314C0-0x011314D0
			public void RemoveAt(int index) {} // 0x011314D0-0x01131540
		}
	
		// Methods
		public void SetDefault() {} // 0x0112FF20-0x0112FF30
	}
}
