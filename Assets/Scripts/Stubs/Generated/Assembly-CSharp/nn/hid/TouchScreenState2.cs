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
	public struct TouchScreenState2 // TypeDefIndex: 9075
	{
		// Fields
		public const int TouchCount = 2; // Metadata: 0x0063132F
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray2 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray2 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9076
		{
			// Fields
			private const int _Length = 2; // Metadata: 0x00631333
			private TouchState _value0; // 0x10
			private TouchState _value1; // 0x38
	
			// Properties
			public int Length { get => default; } // 0x01138770-0x01138780 
			public TouchState this[int index] { get => default; set {} } // 0x01138780-0x01138860 0x01138860-0x01138960
			public int Count { get => default; } // 0x01138960-0x01138970 
			public bool IsReadOnly { get => default; } // 0x01138970-0x01138AD0 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x01138AD0-0x01138C20
			public int IndexOf(TouchState item) => default; // 0x01138C20-0x01138ED0
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x01138ED0-0x01138EE0
			public override string ToString() => default; // 0x01138EE0-0x01138FB0
			// [IteratorStateMachine] // 0x00656680-0x006566F0
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x01138FE0-0x01139060
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x01139060-0x011390E0
			public void Add(TouchState item) {} // 0x011390E0-0x01139150
			public void Clear() {} // 0x01139150-0x011391C0
			public void Insert(int index, TouchState item) {} // 0x011391C0-0x011392A0
			public bool Remove(TouchState item) => default; // 0x011392A0-0x011392B0
			public void RemoveAt(int index) {} // 0x011392B0-0x01139320
		}
	
		// Methods
		public void SetDefault() {} // 0x01138750-0x01138770
	}
}
