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
	public struct HandAnalysisSilhouetteState // TypeDefIndex: 8989
	{
		// Fields
		public long samplingNumber; // 0x10
		public IrCameraAmbientNoiseLevel ambientNoiseLevel; // 0x18
		public int shapeCount; // 0x1C
		public ShapeArray16 shapes; // 0x20
		public int handCount; // 0x160
		public HandArray2 hands; // 0x164
	
		// Nested types
		public struct ShapeArray16 : IList<Shape>, ICollection<Shape>, IEnumerable<Shape>, IEnumerable // TypeDefIndex: 8990
		{
			// Fields
			private const int _Length = 16; // Metadata: 0x00630FF7
			private Shape _value0; // 0x10
			private Shape _value1; // 0x24
			private Shape _value2; // 0x38
			private Shape _value3; // 0x4C
			private Shape _value4; // 0x60
			private Shape _value5; // 0x74
			private Shape _value6; // 0x88
			private Shape _value7; // 0x9C
			private Shape _value8; // 0xB0
			private Shape _value9; // 0xC4
			private Shape _value10; // 0xD8
			private Shape _value11; // 0xEC
			private Shape _value12; // 0x100
			private Shape _value13; // 0x114
			private Shape _value14; // 0x128
			private Shape _value15; // 0x13C
	
			// Properties
			public int Length { get => default; } // 0x0114D8F0-0x0114DAA0 
			public Shape this[int index] { get => default; set {} } // 0x0114DAA0-0x0114DD70 0x0114DD70-0x0114DDB0
			public int Count { get => default; } // 0x0114DDB0-0x0114DDC0 
			public bool IsReadOnly { get => default; } // 0x0114DDC0-0x0114E2D0 
	
			// Methods
			public bool Contains(Shape item) => default; // 0x0114E2D0-0x0114E850
			public int IndexOf(Shape item) => default; // 0x0114E850-0x0114EE50
			public void CopyTo(Shape[] array, int arrayIndex) {} // 0x0114EE50-0x0114F6A0
			public override string ToString() => default; // 0x0114F6A0-0x0114F6B0
			// [IteratorStateMachine] // 0x006563E0-0x00656450
			public IEnumerator<Shape> GetEnumerator() => default; // 0x0114F6E0-0x0114F760
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0114F760-0x0114F7E0
			public void Add(Shape item) {} // 0x0114F7E0-0x0114F850
			public void Clear() {} // 0x0114F850-0x0114F8C0
			public void Insert(int index, Shape item) {} // 0x0114F8C0-0x0114F9A0
			public bool Remove(Shape item) => default; // 0x0114F9A0-0x0114F9B0
			public void RemoveAt(int index) {} // 0x0114F9B0-0x0114FA20
		}
	
		public struct HandArray2 : IList<Hand>, ICollection<Hand>, IEnumerable<Hand>, IEnumerable // TypeDefIndex: 8992
		{
			// Fields
			private const int _Length = 2; // Metadata: 0x00630FFB
			private Hand _value0; // 0x10
			private Hand _value1; // 0x114
	
			// Properties
			public int Length { get => default; } // 0x0114CD10-0x0114CD20 
			public Hand this[int index] { get => default; set {} } // 0x0114CD20-0x0114CDD0 0x0114CDD0-0x0114CEA0
			public int Count { get => default; } // 0x0114CEA0-0x0114CEB0 
			public bool IsReadOnly { get => default; } // 0x0114CEB0-0x0114CEC0 
	
			// Methods
			public bool Contains(Hand item) => default; // 0x0114CEC0-0x0114CFC0
			public int IndexOf(Hand item) => default; // 0x0114CFC0-0x0114D320
			public void CopyTo(Hand[] array, int arrayIndex) {} // 0x0114D320-0x0114D330
			public override string ToString() => default; // 0x0114D330-0x0114D3F0
			// [IteratorStateMachine] // 0x00656450-0x006564C0
			public IEnumerator<Hand> GetEnumerator() => default; // 0x0114D420-0x0114D4A0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0114D4A0-0x0114D520
			public void Add(Hand item) {} // 0x0114D520-0x0114D590
			public void Clear() {} // 0x0114D590-0x0114D600
			public void Insert(int index, Hand item) {} // 0x0114D600-0x0114D6E0
			public bool Remove(Hand item) => default; // 0x0114D6E0-0x0114D6F0
			public void RemoveAt(int index) {} // 0x0114D6F0-0x0114D760
		}
	}
}
