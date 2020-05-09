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
	public struct TouchScreenState3 // TypeDefIndex: 9078
	{
		// Fields
		public const int TouchCount = 3; // Metadata: 0x00631337
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray3 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray3 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9079
		{
			// Fields
			private const int _Length = 3; // Metadata: 0x0063133B
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
	
			// Properties
			public int Length { get => default; } // 0x011394F0-0x01139500 
			public TouchState this[int index] { get => default; set {} } // 0x01139500-0x01139600 0x01139600-0x01139720
			public int Count { get => default; } // 0x01139720-0x01139730 
			public bool IsReadOnly { get => default; } // 0x01139730-0x011398F0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x011398F0-0x01139AC0
			public int IndexOf(TouchState item) => default; // 0x01139AC0-0x01139E20
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01139E20-0x01139E30
			public override string ToString() => default; // 0x01139E30-0x01139F20
			// [IteratorStateMachine] // 0x006566F0-0x00656760
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01139F50-0x01139FD0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01139FD0-0x0113A050
			public void Add(TouchState item) {} // 0x0113A050-0x0113A0C0
			public void Clear() {} // 0x0113A0C0-0x0113A130
			public void Insert(int index, TouchState item) {} // 0x0113A130-0x0113A210
			public bool Remove(TouchState item) => default; // 0x0113A210-0x0113A220
			public void RemoveAt(int index) {} // 0x0113A220-0x0113A290
		}
	
		// Methods
		public void SetDefault() {} // 0x011394C0-0x011394F0
	}
}
