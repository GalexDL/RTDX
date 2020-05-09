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
	public struct TouchScreenState13 // TypeDefIndex: 9108
	{
		// Fields
		public const int TouchCount = 13; // Metadata: 0x00631387
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray13 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray13 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9109
		{
			// Fields
			private const int _Length = 13; // Metadata: 0x0063138B
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
	
			// Properties
			public int Length { get => default; } // 0x01131860-0x01131A20 
			public TouchState this[int index] { get => default; set {} } // 0x01131A20-0x01131B60 0x01131B60-0x01131BA0
			public int Count { get => default; } // 0x01131BA0-0x01131BB0 
			public bool IsReadOnly { get => default; } // 0x01131BB0-0x01131BC0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01131BC0-0x01131CB0
			public int IndexOf(TouchState item) => default; // 0x01131CB0-0x011324E0
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x011324E0-0x01132C00
			public override string ToString() => default; // 0x01132C00-0x01132C10
			// [IteratorStateMachine] // 0x00656B50-0x00656BC0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01132C40-0x01132CC0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01132CC0-0x01132D40
			public void Add(TouchState item) {} // 0x01132D40-0x01132DB0
			public void Clear() {} // 0x01132DB0-0x01132E20
			public void Insert(int index, TouchState item) {} // 0x01132E20-0x01132F00
			public bool Remove(TouchState item) => default; // 0x01132F00-0x01132F10
			public void RemoveAt(int index) {} // 0x01132F10-0x01132F80
		}
	
		// Methods
		public void SetDefault() {} // 0x01131850-0x01131860
	}
}
