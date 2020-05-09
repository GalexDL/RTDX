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
	public struct MomentProcessorState // TypeDefIndex: 9014
	{
		// Fields
		public long samplingNumber; // 0x10
		public long deltaTimeNanoSeconds; // 0x18
		public IrCameraAmbientNoiseLevel ambientNoiseLevel; // 0x20
		private byte _reserved0; // 0x24
		private byte _reserved1; // 0x25
		private byte _reserved2; // 0x26
		private byte _reserved3; // 0x27
		public MomentStatisticArray48 blocks; // 0x28
	
		// Nested types
		public struct MomentStatisticArray48 : IList<MomentStatistic>, ICollection<MomentStatistic>, IEnumerable<MomentStatistic>, IEnumerable // TypeDefIndex: 9015
		{
			// Fields
			private const int _Length = 48; // Metadata: 0x006310CF
			private MomentStatistic _value0; // 0x10
			private MomentStatistic _value1; // 0x1C
			private MomentStatistic _value2; // 0x28
			private MomentStatistic _value3; // 0x34
			private MomentStatistic _value4; // 0x40
			private MomentStatistic _value5; // 0x4C
			private MomentStatistic _value6; // 0x58
			private MomentStatistic _value7; // 0x64
			private MomentStatistic _value8; // 0x70
			private MomentStatistic _value9; // 0x7C
			private MomentStatistic _value10; // 0x88
			private MomentStatistic _value11; // 0x94
			private MomentStatistic _value12; // 0xA0
			private MomentStatistic _value13; // 0xAC
			private MomentStatistic _value14; // 0xB8
			private MomentStatistic _value15; // 0xC4
			private MomentStatistic _value16; // 0xD0
			private MomentStatistic _value17; // 0xDC
			private MomentStatistic _value18; // 0xE8
			private MomentStatistic _value19; // 0xF4
			private MomentStatistic _value20; // 0x100
			private MomentStatistic _value21; // 0x10C
			private MomentStatistic _value22; // 0x118
			private MomentStatistic _value23; // 0x124
			private MomentStatistic _value24; // 0x130
			private MomentStatistic _value25; // 0x13C
			private MomentStatistic _value26; // 0x148
			private MomentStatistic _value27; // 0x154
			private MomentStatistic _value28; // 0x160
			private MomentStatistic _value29; // 0x16C
			private MomentStatistic _value30; // 0x178
			private MomentStatistic _value31; // 0x184
			private MomentStatistic _value32; // 0x190
			private MomentStatistic _value33; // 0x19C
			private MomentStatistic _value34; // 0x1A8
			private MomentStatistic _value35; // 0x1B4
			private MomentStatistic _value36; // 0x1C0
			private MomentStatistic _value37; // 0x1CC
			private MomentStatistic _value38; // 0x1D8
			private MomentStatistic _value39; // 0x1E4
			private MomentStatistic _value40; // 0x1F0
			private MomentStatistic _value41; // 0x1FC
			private MomentStatistic _value42; // 0x208
			private MomentStatistic _value43; // 0x214
			private MomentStatistic _value44; // 0x220
			private MomentStatistic _value45; // 0x22C
			private MomentStatistic _value46; // 0x238
			private MomentStatistic _value47; // 0x244
	
			// Properties
			public int Length { get => default; } // 0x011512A0-0x01151660 
			public MomentStatistic this[int index] { get => default; set {} } // 0x01151660-0x011519F0 0x011519F0-0x01151A00
			public int Count { get => default; } // 0x01151A00-0x01151A10 
			public bool IsReadOnly { get => default; } // 0x01151A10-0x01151A20 
	
			// Methods
			public bool Contains(MomentStatistic item) => default; // 0x01151A20-0x01151AA0
			public int IndexOf(MomentStatistic item) => default; // 0x01151AA0-0x01151CD0
			public void CopyTo(MomentStatistic[] array, int arrayIndex) {} // 0x01151CD0-0x01153430
			public override string ToString() => default; // 0x01153430-0x01153440
			// [IteratorStateMachine] // 0x006564C0-0x00656530
			public IEnumerator<MomentStatistic> GetEnumerator() => default; // 0x01153440-0x011534C0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x011534C0-0x01153540
			public void Add(MomentStatistic item) {} // 0x01153540-0x011535B0
			public void Clear() {} // 0x011535B0-0x01153620
			public void Insert(int index, MomentStatistic item) {} // 0x01153620-0x01153700
			public bool Remove(MomentStatistic item) => default; // 0x01153700-0x01153710
			public void RemoveAt(int index) {} // 0x01153710-0x01153780
		}
	}
}
