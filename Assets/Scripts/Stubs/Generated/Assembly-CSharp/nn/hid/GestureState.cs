/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using nn.util;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct GestureState // TypeDefIndex: 9035
	{
		// Fields
		public long eventNumber; // 0x10
		public long contextNumber; // 0x18
		public int _type; // 0x20
		public int _direction; // 0x24
		public int x; // 0x28
		public int y; // 0x2C
		public int deltaX; // 0x30
		public int deltaY; // 0x34
		public Float2 velocity; // 0x38
		public GestureAttribute attributes; // 0x40
		public float scale; // 0x44
		public float rotationAngle; // 0x48
		public int pointCount; // 0x4C
		public GesturePointArray4 points; // 0x50
	
		// Properties
		public GestureType type { get => default; } // 0x00A18B90-0x00A18BA0 
		public GestureDirection direction { get => default; } // 0x00A18BA0-0x00A18BB0 
		public bool isDoubleTap { get => default; } // 0x00A18BB0-0x00A19480 
	
		// Nested types
		public struct GesturePointArray4 : IList<GesturePoint>, ICollection<GesturePoint>, IEnumerable<GesturePoint>, IEnumerable // TypeDefIndex: 9036
		{
			// Fields
			private const int _Length = 4; // Metadata: 0x0063116F
			private GesturePoint _value0; // 0x10
			private GesturePoint _value1; // 0x18
			private GesturePoint _value2; // 0x20
			private GesturePoint _value3; // 0x28
	
			// Properties
			public int Length { get => default; } // 0x00A19490-0x00A194A0 
			public GesturePoint this[int index] { get => default; set {} } // 0x00A194A0-0x00A19570 0x00A19570-0x00A19670
			public int Count { get => default; } // 0x00A19670-0x00A19680 
			public bool IsReadOnly { get => default; } // 0x00A19680-0x00A19690 
	
			// Methods
			public bool Contains(GesturePoint item) => default; // 0x00A19690-0x00A19780
			public int IndexOf(GesturePoint item) => default; // 0x00A19780-0x00A19AF0
			public void CopyTo(GesturePoint[] array, int arrayIndex) {} // 0x00A19AF0-0x00A19D40
			public override string ToString() => default; // 0x00A19D40-0x00A19D50
			// [IteratorStateMachine] // 0x006565A0-0x00656610
			public IEnumerator<GesturePoint> GetEnumerator() => default; // 0x00A19D80-0x00A19E00
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00A19E00-0x00A19E80
			public void Add(GesturePoint item) {} // 0x00A19E80-0x00A19EF0
			public void Clear() {} // 0x00A19EF0-0x00A19F60
			public void Insert(int index, GesturePoint item) {} // 0x00A19F60-0x00A1A040
			public bool Remove(GesturePoint item) => default; // 0x00A1A040-0x00A1A050
			public void RemoveAt(int index) {} // 0x00A1A050-0x00A1A0C0
		}
	
		// Methods
		public void SetDefault() {} // 0x00A18B80-0x00A18B90
		public override string ToString() => default; // 0x00A19480-0x00A19490
	}
}
