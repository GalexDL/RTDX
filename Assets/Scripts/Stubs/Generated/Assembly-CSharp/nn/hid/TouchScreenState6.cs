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
	public struct TouchScreenState6 // TypeDefIndex: 9087
	{
		// Fields
		public const int TouchCount = 6; // Metadata: 0x0063134F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray6 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray6 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9088
		{
			// Fields
			private const int _Length = 6; // Metadata: 0x00631353
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
			private TouchState _value5; // 0xD8
	
			// Properties
			public int Length { get => default; } // 0x0113CD10-0x0113CE50 
			public TouchState this[int index] { get => default; set {} } // 0x0113CE50-0x0113CF50 0x0113CF50-0x0113CF90
			public int Count { get => default; } // 0x0113CF90-0x0113CFA0 
			public bool IsReadOnly { get => default; } // 0x0113CFA0-0x0113D350 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x0113D350-0x0113D710
			public int IndexOf(TouchState item) => default; // 0x0113D710-0x0113DB60
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x0113DB60-0x0113DF00
			public override string ToString() => default; // 0x0113DF00-0x0113DF10
			// [IteratorStateMachine] // 0x00656840-0x006568B0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x0113DF40-0x0113DFC0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0113DFC0-0x0113E040
			public void Add(TouchState item) {} // 0x0113E040-0x0113E0B0
			public void Clear() {} // 0x0113E0B0-0x0113E120
			public void Insert(int index, TouchState item) {} // 0x0113E120-0x0113E200
			public bool Remove(TouchState item) => default; // 0x0113E200-0x0113E210
			public void RemoveAt(int index) {} // 0x0113E210-0x0113E280
		}
	
		// Methods
		public void SetDefault() {} // 0x0113CCD0-0x0113CD10
	}
}
