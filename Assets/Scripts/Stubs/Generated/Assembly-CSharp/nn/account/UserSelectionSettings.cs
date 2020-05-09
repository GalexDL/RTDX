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

namespace nn.account
{
	public struct UserSelectionSettings : IEquatable<nn.account.UserSelectionSettings> // TypeDefIndex: 9173
	{
		// Fields
		public UidArray8 invalidUidList; // 0x10
		public bool isSkipEnabled; // 0x90
		public bool isNetworkServiceAccountRequired; // 0x91
		public bool showSkipButton; // 0x92
		public bool additionalSelect; // 0x93
		public bool isUnqualifiedUserSelectable; // 0x94
	
		// Nested types
		public struct UidArray8 : IList<Uid>, ICollection<Uid>, IEnumerable<Uid>, IEnumerable // TypeDefIndex: 9174
		{
			// Fields
			private const int _Length = 8; // Metadata: 0x0063144F
			private Uid _value0; // 0x10
			private Uid _value1; // 0x20
			private Uid _value2; // 0x30
			private Uid _value3; // 0x40
			private Uid _value4; // 0x50
			private Uid _value5; // 0x60
			private Uid _value6; // 0x70
			private Uid _value7; // 0x80
	
			// Properties
			public int Length { get => default; } // 0x00A11630-0x00A11640 
			public Uid this[int index] { get => default; set {} } // 0x00A11640-0x00A11750 0x00A11750-0x00A11760
			public int Count { get => default; } // 0x00A11760-0x00A11770 
			public bool IsReadOnly { get => default; } // 0x00A11770-0x00A118A0 
	
			// Methods
			public bool Contains(Uid item) => default; // 0x00A118A0-0x00A119F0
			public int IndexOf(Uid item) => default; // 0x00A119F0-0x00A11D20
			public void CopyTo(Uid[] array, int arrayIndex) {} // 0x00A11D20-0x00A12130
			public override string ToString() => default; // 0x00A12130-0x00A12140
			// [IteratorStateMachine] // 0x00656D80-0x00656DF0
			public IEnumerator<Uid> GetEnumerator() => default; // 0x00A12170-0x00A121F0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00A121F0-0x00A12270
			public void Add(Uid item) {} // 0x00A12270-0x00A122E0
			public void Clear() {} // 0x00A122E0-0x00A12350
			public void Insert(int index, Uid item) {} // 0x00A12350-0x00A12430
			public bool Remove(Uid item) => default; // 0x00A12430-0x00A12440
			public void RemoveAt(int index) {} // 0x00A12440-0x00A124B0
		}
	
		// Methods
		public void SetDefault() {} // 0x00A10C50-0x00A11170
		public override string ToString() => default; // 0x00A11170-0x00A11180
		public override bool Equals(object obj) => default; // 0x00A11180-0x00A11240
		public bool Equals(UserSelectionSettings other) => default; // 0x00A114E0-0x00A11540
		public override int GetHashCode() => default; // 0x00A11540-0x00A115C0
		public static bool operator ==(UserSelectionSettings lhs, UserSelectionSettings rhs) => default; // 0x00A11240-0x00A114E0
		public static bool operator !=(UserSelectionSettings lhs, UserSelectionSettings rhs) => default; // 0x00A115C0-0x00A11630
	}
}
