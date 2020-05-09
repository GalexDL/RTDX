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
	public struct TouchScreenState7 // TypeDefIndex: 9090
	{
		// Fields
		public const int TouchCount = 7; // Metadata: 0x00631357
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray7 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray7 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9091
		{
			// Fields
			private const int _Length = 7; // Metadata: 0x0063135B
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
			private TouchState _value5; // 0xD8
			private TouchState _value6; // 0x100
	
			// Properties
			public int Length { get => default; } // 0x0113E4C0-0x0113E610 
			public TouchState this[int index] { get => default; set {} } // 0x0113E610-0x0113E720 0x0113E720-0x0113E760
			public int Count { get => default; } // 0x0113E760-0x0113E770 
			public bool IsReadOnly { get => default; } // 0x0113E770-0x0113EBB0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x0113EBB0-0x0113F000
			public int IndexOf(TouchState item) => default; // 0x0113F000-0x0113F4C0
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x0113F4C0-0x0113F8E0
			public override string ToString() => default; // 0x0113F8E0-0x0113F8F0
			// [IteratorStateMachine] // 0x006568B0-0x00656920
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x0113F920-0x0113F9A0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0113F9A0-0x0113FA20
			public void Add(TouchState item) {} // 0x0113FA20-0x0113FA90
			public void Clear() {} // 0x0113FA90-0x0113FB00
			public void Insert(int index, TouchState item) {} // 0x0113FB00-0x0113FBE0
			public bool Remove(TouchState item) => default; // 0x0113FBE0-0x0113FBF0
			public void RemoveAt(int index) {} // 0x0113FBF0-0x0113FC60
		}
	
		// Methods
		public void SetDefault() {} // 0x0113E4B0-0x0113E4C0
	}
}
