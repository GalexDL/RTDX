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
	public struct TouchScreenState11 // TypeDefIndex: 9102
	{
		// Fields
		public const int TouchCount = 11; // Metadata: 0x00631377
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray11 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray11 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9103
		{
			// Fields
			private const int _Length = 11; // Metadata: 0x0063137B
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
	
			// Properties
			public int Length { get => default; } // 0x0112E680-0x0112E820 
			public TouchState this[int index] { get => default; set {} } // 0x0112E820-0x0112E950 0x0112E950-0x0112E990
			public int Count { get => default; } // 0x0112E990-0x0112E9A0 
			public bool IsReadOnly { get => default; } // 0x0112E9A0-0x0112E9B0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x0112EA70-0x0112EB60
			public int IndexOf(TouchState item) => default; // 0x0112EB60-0x0112F2A0
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x0112F2A0-0x0112F8C0
			public override string ToString() => default; // 0x0112F8C0-0x0112F8D0
			// [IteratorStateMachine] // 0x00656A70-0x00656AE0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x0112F900-0x0112F980
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0112F980-0x0112FA00
			public void Add(TouchState item) {} // 0x0112FA00-0x0112FA70
			public void Clear() {} // 0x0112FA70-0x0112FAE0
			public void Insert(int index, TouchState item) {} // 0x0112FAE0-0x0112FBC0
			public bool Remove(TouchState item) => default; // 0x0112FBC0-0x0112FBD0
			public void RemoveAt(int index) {} // 0x0112FBD0-0x0112FC40
		}
	
		// Methods
		public void SetDefault() {} // 0x0112E670-0x0112E680
	}
}
