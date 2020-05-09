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

namespace nn.irsensor
{
	public struct Hand : IEquatable<nn.irsensor.Hand> // TypeDefIndex: 8983
	{
		// Fields
		public int shapeId; // 0x10
		public int protrusionCount; // 0x14
		public ProtrusionArray8 protrusions; // 0x18
		public HandChirality chirality; // 0x58
		public Fingers fingers; // 0x5C
		public bool areIndexMiddleFingersTouching; // 0xE8
		public bool areMiddleRingFingersTouching; // 0xE9
		public bool areRingLittleFingersTouching; // 0xEA
		public Palm palm; // 0xEC
		public Arm arm; // 0xFC
	
		// Nested types
		public struct ProtrusionArray8 : IList<Protrusion>, ICollection<Protrusion>, IEnumerable<Protrusion>, IEnumerable // TypeDefIndex: 8984
		{
			// Fields
			private const int _Length = 8; // Metadata: 0x00630FEF
			private Protrusion _value0; // 0x10
			private Protrusion _value1; // 0x18
			private Protrusion _value2; // 0x20
			private Protrusion _value3; // 0x28
			private Protrusion _value4; // 0x30
			private Protrusion _value5; // 0x38
			private Protrusion _value6; // 0x40
			private Protrusion _value7; // 0x48
	
			// Properties
			public int Length { get => default; } // 0x0114B5F0-0x0114B600 
			public Protrusion this[int index] { get => default; set {} } // 0x0114B600-0x0114B840 0x0114B840-0x0114B850
			public int Count { get => default; } // 0x0114B850-0x0114B860 
			public bool IsReadOnly { get => default; } // 0x0114B860-0x0114BA20 
	
			// Methods
			public bool Contains(Protrusion item) => default; // 0x0114BA20-0x0114BC60
			public int IndexOf(Protrusion item) => default; // 0x0114BC60-0x0114C030
			public void CopyTo(Protrusion[] array, int arrayIndex) {} // 0x0114C030-0x0114C440
			public override string ToString() => default; // 0x0114C440-0x0114C450
			// [IteratorStateMachine] // 0x00656300-0x00656370
			public IEnumerator<Protrusion> GetEnumerator() => default; // 0x0114C480-0x0114C500
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0114C500-0x0114C580
			public void Add(Protrusion item) {} // 0x0114C580-0x0114C5F0
			public void Clear() {} // 0x0114C5F0-0x0114C660
			public void Insert(int index, Protrusion item) {} // 0x0114C660-0x0114C740
			public bool Remove(Protrusion item) => default; // 0x0114C740-0x0114C750
			public void RemoveAt(int index) {} // 0x0114C750-0x0114C7C0
		}
	
		public struct Fingers : IList<Finger>, ICollection<Finger>, IEnumerable<Finger>, IEnumerable // TypeDefIndex: 8986
		{
			// Fields
			private const int _Length = 5; // Metadata: 0x00630FF3
			public Finger thumb; // 0x10
			public Finger index; // 0x2C
			public Finger middle; // 0x48
			public Finger ring; // 0x64
			public Finger little; // 0x80
	
			// Properties
			public int Length { get => default; } // 0x01149EF0-0x01149F00 
			public Finger this[int index] { get => default; set {} } // 0x01149F00-0x0114A030 0x0114A030-0x0114A1A0
			public int Count { get => default; } // 0x0114A1A0-0x0114A1B0 
			public bool IsReadOnly { get => default; } // 0x0114A1B0-0x0114A500 
	
			// Methods
			public bool Contains(Finger item) => default; // 0x0114A500-0x0114A8A0
			public int IndexOf(Finger item) => default; // 0x0114A8A0-0x0114AD40
			public void CopyTo(Finger[] array, int arrayIndex) {} // 0x0114AD40-0x0114B060
			public override string ToString() => default; // 0x0114B060-0x0114B070
			// [IteratorStateMachine] // 0x00656370-0x006563E0
			public IEnumerator<Finger> GetEnumerator() => default; // 0x0114B0A0-0x0114B120
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0114B120-0x0114B1A0
			public void Add(Finger item) {} // 0x0114B1A0-0x0114B210
			public void Clear() {} // 0x0114B210-0x0114B280
			public void Insert(int index, Finger item) {} // 0x0114B280-0x0114B360
			public bool Remove(Finger item) => default; // 0x0114B360-0x0114B370
			public void RemoveAt(int index) {} // 0x0114B370-0x0114B3E0
		}
	
		// Methods
		public static bool operator ==(Hand lhs, Hand rhs) => default; // 0x01149520-0x01149C20
		public static bool operator !=(Hand lhs, Hand rhs) => default; // 0x01149C20-0x01149D50
		public override bool Equals(object right) => default; // 0x01149D50-0x01149E10
		public bool Equals(Hand other) => default; // 0x01149E10-0x01149E70
		public override int GetHashCode() => default; // 0x01149E70-0x01149EF0
	}
}
