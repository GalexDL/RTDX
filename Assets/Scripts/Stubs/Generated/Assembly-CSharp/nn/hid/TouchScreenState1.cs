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
	public struct TouchScreenState1 // TypeDefIndex: 9072
	{
		// Fields
		public const int TouchCount = 1; // Metadata: 0x00631327
		public long samplingNumber; // 0x10
		public int count; // 0x18
		private int _reserved; // 0x1C
		public TouchStateArray1 touches; // 0x20
	
		// Nested types
		public struct TouchStateArray1 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 9073
		{
			// Fields
			private const int _Length = 1; // Metadata: 0x0063132B
			private TouchState _value0; // 0x10
	
			// Properties
			public int Length { get => default; } // 0x00A1E680-0x00A1E690 
			public TouchState this[int index] { get => default; set {} } // 0x00A1E690-0x00A1E740 0x00A1E740-0x00A1E820
			public int Count { get => default; } // 0x00A1E820-0x00A1E830 
			public bool IsReadOnly { get => default; } // 0x00A1E830-0x00A1E840 
	
			// Methods
			public bool Contains(TouchState item) => default; // 0x00A1E840-0x00A1E900
			public int IndexOf(TouchState item) => default; // 0x00A1E900-0x00A1EB80
			public void CopyTo(TouchState[] array, int arrayIndex) {} // 0x00A1EB80-0x00A1EB90
			public override string ToString() => default; // 0x00A1EB90-0x00A1EC20
			// [IteratorStateMachine] // 0x00656610-0x00656680
			public IEnumerator<TouchState> GetEnumerator() => default; // 0x00A1EC50-0x00A1ECD0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00A1ECD0-0x00A1ED50
			public void Add(TouchState item) {} // 0x00A1ED50-0x00A1EDC0
			public void Clear() {} // 0x00A1EDC0-0x00A1EE30
			public void Insert(int index, TouchState item) {} // 0x00A1EE30-0x00A1EF10
			public bool Remove(TouchState item) => default; // 0x00A1EF10-0x00A1EF20
			public void RemoveAt(int index) {} // 0x00A1EF20-0x00A1EF90
		}
	
		// Methods
		public void SetDefault() {} // 0x00A1E670-0x00A1E680
	}
}
