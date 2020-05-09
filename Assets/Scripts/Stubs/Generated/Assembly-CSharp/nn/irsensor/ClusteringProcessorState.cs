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
	public struct ClusteringProcessorState // TypeDefIndex: 8970
	{
		// Fields
		public long samplingNumber; // 0x10
		public long timeStampNanoSeconds; // 0x18
		public sbyte objectCount; // 0x20
		public byte _reserved0; // 0x21
		public byte _reserved1; // 0x22
		public byte _reserved2; // 0x23
		public IrCameraAmbientNoiseLevel ambientNoiseLevel; // 0x24
		public ClusteringDataArray16 objects; // 0x28
	
		// Nested types
		public struct ClusteringDataArray16 : IList<ClusteringData>, ICollection<ClusteringData>, IEnumerable<ClusteringData>, IEnumerable // TypeDefIndex: 8971
		{
			// Fields
			private const int _Length = 16; // Metadata: 0x00630F87
			private ClusteringData _value0; // 0x10
			private ClusteringData _value1; // 0x28
			private ClusteringData _value2; // 0x40
			private ClusteringData _value3; // 0x58
			private ClusteringData _value4; // 0x70
			private ClusteringData _value5; // 0x88
			private ClusteringData _value6; // 0xA0
			private ClusteringData _value7; // 0xB8
			private ClusteringData _value8; // 0xD0
			private ClusteringData _value9; // 0xE8
			private ClusteringData _value10; // 0x100
			private ClusteringData _value11; // 0x118
			private ClusteringData _value12; // 0x130
			private ClusteringData _value13; // 0x148
			private ClusteringData _value14; // 0x160
			private ClusteringData _value15; // 0x178
	
			// Properties
			public int Length { get => default; } // 0x01147440-0x01147450 
			public ClusteringData this[int index] { get => default; set {} } // 0x01147450-0x01147710 0x01147710-0x01147750
			public int Count { get => default; } // 0x01147750-0x01147760 
			public bool IsReadOnly { get => default; } // 0x01147760-0x01147770 
	
			// Methods
			public bool Contains(ClusteringData item) => default; // 0x01147770-0x01147840
			public int IndexOf(ClusteringData item) => default; // 0x01147840-0x01147ED0
			public void CopyTo(ClusteringData[] array, int arrayIndex) {} // 0x01147ED0-0x011486F0
			public override string ToString() => default; // 0x011486F0-0x01148700
			// [IteratorStateMachine] // 0x00656290-0x00656300
			public IEnumerator<ClusteringData> GetEnumerator() => default; // 0x01148730-0x011487B0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x011487B0-0x01148830
			public void Add(ClusteringData item) {} // 0x01148830-0x011488A0
			public void Clear() {} // 0x011488A0-0x01148910
			public void Insert(int index, ClusteringData item) {} // 0x01148910-0x011489F0
			public bool Remove(ClusteringData item) => default; // 0x011489F0-0x01148A00
			public void RemoveAt(int index) {} // 0x01148A00-0x01148A70
		}
	
		// Methods
		public void SetDefault() {} // 0x01146F60-0x01147430
		public override string ToString() => default; // 0x01147430-0x01147440
	}
}
