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
	public struct TouchScreenState4 // TypeDefIndex: 9081
	{
		// Fields
		public const int TouchCount = 4; // Metadata: 0x0063133F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray4 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray4 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9082
		{
			// Fields
			private const int _Length = 4; // Metadata: 0x00631343
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
	
			// Properties
			public int Length { get => default; } // 0x0113A480-0x0113A490 
			public TouchState this[int index] { get => default; set {} } // 0x0113A490-0x0113A5B0 0x0113A5B0-0x0113A700
			public int Count { get => default; } // 0x0113A700-0x0113A710 
			public bool IsReadOnly { get => default; } // 0x0113A710-0x0113A930 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x0113A930-0x0113AB70
			public int IndexOf(TouchState item) => default; // 0x0113AB70-0x0113AF70
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x0113AF70-0x0113B200
			public override string ToString() => default; // 0x0113B200-0x0113B210
			// [IteratorStateMachine] // 0x00656760-0x006567D0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x0113B240-0x0113B2C0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0113B2C0-0x0113B340
			public void Add(TouchState item) {} // 0x0113B340-0x0113B3B0
			public void Clear() {} // 0x0113B3B0-0x0113B420
			public void Insert(int index, TouchState item) {} // 0x0113B420-0x0113B500
			public bool Remove(TouchState item) => default; // 0x0113B500-0x0113B510
			public void RemoveAt(int index) {} // 0x0113B510-0x0113B580
		}
	
		// Methods
		public void SetDefault() {} // 0x0113A450-0x0113A480
	}
}
