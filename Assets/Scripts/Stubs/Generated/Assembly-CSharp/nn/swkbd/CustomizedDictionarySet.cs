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

namespace nn.swkbd
{
	public struct CustomizedDictionarySet // TypeDefIndex: 8956
	{
		// Fields
		public IntPtr pDictionaries; // 0x10
		public uint dictionariesSize; // 0x18
		public DictionaryInfoArray24 dicInfoList; // 0x1C
		public ushort count; // 0xDC
	
		// Nested types
		public struct DictionaryInfoArray24 : IList<DictionaryInfo>, ICollection<DictionaryInfo>, IEnumerable<DictionaryInfo>, IEnumerable // TypeDefIndex: 8957
		{
			// Fields
			private const int _Length = 24; // Metadata: 0x00630F0F
			private DictionaryInfo _value0; // 0x10
			private DictionaryInfo _value1; // 0x18
			private DictionaryInfo _value2; // 0x20
			private DictionaryInfo _value3; // 0x28
			private DictionaryInfo _value4; // 0x30
			private DictionaryInfo _value5; // 0x38
			private DictionaryInfo _value6; // 0x40
			private DictionaryInfo _value7; // 0x48
			private DictionaryInfo _value8; // 0x50
			private DictionaryInfo _value9; // 0x58
			private DictionaryInfo _value10; // 0x60
			private DictionaryInfo _value11; // 0x68
			private DictionaryInfo _value12; // 0x70
			private DictionaryInfo _value13; // 0x78
			private DictionaryInfo _value14; // 0x80
			private DictionaryInfo _value15; // 0x88
			private DictionaryInfo _value16; // 0x90
			private DictionaryInfo _value17; // 0x98
			private DictionaryInfo _value18; // 0xA0
			private DictionaryInfo _value19; // 0xA8
			private DictionaryInfo _value20; // 0xB0
			private DictionaryInfo _value21; // 0xB8
			private DictionaryInfo _value22; // 0xC0
			private DictionaryInfo _value23; // 0xC8
	
			// Properties
			public int Length { get => default; } // 0x00AEBA40-0x00AEBBB0 
			public DictionaryInfo this[int index] { get => default; set {} } // 0x00AEBBB0-0x00AEBE50 0x00AEBE50-0x00AEBE60
			public int Count { get => default; } // 0x00AEBE60-0x00AEBE70 
			public bool IsReadOnly { get => default; } // 0x00AEBE70-0x00AEBE80 
	
			// Methods
			public bool Contains(DictionaryInfo item) => default; // 0x00AEBEB0-0x00AEBF30
			public int IndexOf(DictionaryInfo item) => default; // 0x00AEBF30-0x00AEC140
			public void CopyTo(DictionaryInfo[] array, int arrayIndex) {} // 0x00AEC140-0x00AECC60
			public override string ToString() => default; // 0x00AECC60-0x00AECC70
			// [IteratorStateMachine] // 0x00656220-0x00656290
			public IEnumerator<DictionaryInfo> GetEnumerator() => default; // 0x00AECCA0-0x00AECD20
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00AECD20-0x00AECDA0
			public void Add(DictionaryInfo item) {} // 0x00AECDA0-0x00AECE10
			public void Clear() {} // 0x00AECE10-0x00AECE80
			public void Insert(int index, DictionaryInfo item) {} // 0x00AECE80-0x00AECF60
			public bool Remove(DictionaryInfo item) => default; // 0x00AECF60-0x00AECF70
			public void RemoveAt(int index) {} // 0x00AECF70-0x00AECFE0
		}
	}
}
