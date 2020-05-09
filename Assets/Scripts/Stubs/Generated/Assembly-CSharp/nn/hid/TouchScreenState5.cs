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
	public struct TouchScreenState5 // TypeDefIndex: 9084
	{
		// Fields
		public const int TouchCount = 5; // Metadata: 0x00631347
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray5 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray5 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9085
		{
			// Fields
			private const int _Length = 5; // Metadata: 0x0063134B
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
			private TouchState _value2; // 0x60
			private TouchState _value3; // 0x88
			private TouchState _value4; // 0xB0
	
			// Properties
			public int Length { get => default; } // 0x0113B7A0-0x0113B7B0 
			public TouchState this[int index] { get => default; set {} } // 0x0113B7B0-0x0113B8E0 0x0113B8E0-0x0113BA40
			public int Count { get => default; } // 0x0113BA40-0x0113BA50 
			public bool IsReadOnly { get => default; } // 0x0113BA50-0x0113BCD0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x0113BCD0-0x0113BF80
			public int IndexOf(TouchState item) => default; // 0x0113BF80-0x0113C420
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x0113C420-0x0113C740
			public override string ToString() => default; // 0x0113C740-0x0113C750
			// [IteratorStateMachine] // 0x006567D0-0x00656840
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x0113C780-0x0113C800
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0113C800-0x0113C880
			public void Add(TouchState item) {} // 0x0113C880-0x0113C8F0
			public void Clear() {} // 0x0113C8F0-0x0113C960
			public void Insert(int index, TouchState item) {} // 0x0113C960-0x0113CA40
			public bool Remove(TouchState item) => default; // 0x0113CA40-0x0113CA50
			public void RemoveAt(int index) {} // 0x0113CA50-0x0113CAC0
		}
	
		// Methods
		public void SetDefault() {} // 0x0113B760-0x0113B7A0
	}
}
