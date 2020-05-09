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
	public struct TouchScreenState14 // TypeDefIndex: 9111
	{
		// Fields
		public const int TouchCount = 14; // Metadata: 0x0063138F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray14 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray14 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9112
		{
			// Fields
			private const int _Length = 14; // Metadata: 0x00631393
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
	
			// Properties
			public int Length { get => default; } // 0x011332C0-0x011334A0 
			public TouchState this[int index] { get => default; set {} } // 0x011334A0-0x011335E0 0x011335E0-0x01133620
			public int Count { get => default; } // 0x01133620-0x01133630 
			public bool IsReadOnly { get => default; } // 0x01133630-0x01133640 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01133640-0x01133730
			public int IndexOf(TouchState item) => default; // 0x01133730-0x01133FE0
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01133FE0-0x01134780
			public override string ToString() => default; // 0x01134780-0x01134790
			// [IteratorStateMachine] // 0x00656BC0-0x00656C30
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x011347C0-0x01134840
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01134840-0x011348C0
			public void Add(TouchState item) {} // 0x011348C0-0x01134930
			public void Clear() {} // 0x01134930-0x011349A0
			public void Insert(int index, TouchState item) {} // 0x011349A0-0x01134A80
			public bool Remove(TouchState item) => default; // 0x01134A80-0x01134A90
			public void RemoveAt(int index) {} // 0x01134A90-0x01134B00
		}
	
		// Methods
		public void SetDefault() {} // 0x011332B0-0x011332C0
	}
}
