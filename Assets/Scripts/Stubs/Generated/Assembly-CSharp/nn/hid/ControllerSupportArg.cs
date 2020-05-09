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
	public struct ControllerSupportArg // TypeDefIndex: 9019
	{
		// Fields
		private const int ExplainTextSize = 516; // Metadata: 0x006310D7
		public byte playerCountMin; // 0x10
		public byte playerCountMax; // 0x11
		public bool enableTakeOverConnection; // 0x12
		public bool enableLeftJustify; // 0x13
		public bool enablePermitJoyDual; // 0x14
		public bool enableSingleMode; // 0x15
		public bool enableIdentificationColor; // 0x16
		public Color4u8Array4 identificationColor; // 0x17
		public bool enableExplainText; // 0x27
		private byte[] explainText; // 0x28
	
		// Nested types
		public struct Color4u8Array4 : IList<Color4u8>, ICollection<Color4u8>, IEnumerable<Color4u8>, IEnumerable // TypeDefIndex: 9020
		{
			// Fields
			private const int _Length = 4; // Metadata: 0x006310DB
			private Color4u8 _value0; // 0x10
			private Color4u8 _value1; // 0x14
			private Color4u8 _value2; // 0x18
			private Color4u8 _value3; // 0x1C
	
			// Properties
			public int Length { get => default; } // 0x00A174E0-0x00A174F0 
			public Color4u8 this[int index] { get => default; set {} } // 0x00A174F0-0x00A175B0 0x00A175B0-0x00A176B0
			public int Count { get => default; } // 0x00A176B0-0x00A176C0 
			public bool IsReadOnly { get => default; } // 0x00A176C0-0x00A177D0 
	
			// Methods
			public bool Contains(Color4u8 item) => default; // 0x00A177D0-0x00A17910
			public int IndexOf(Color4u8 item) => default; // 0x00A17910-0x00A17BA0
			public void CopyTo(Color4u8[] array, int arrayIndex) {} // 0x00A17BA0-0x00A17DF0
			public override string ToString() => default; // 0x00A17DF0-0x00A17E00
			// [IteratorStateMachine] // 0x00656530-0x006565A0
			public IEnumerator<Color4u8> GetEnumerator() => default; // 0x00A17E30-0x00A17EA0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00A17EA0-0x00A17F10
			public void Add(Color4u8 item) {} // 0x00A17F10-0x00A17F80
			public void Clear() {} // 0x00A17F80-0x00A17FF0
			public void Insert(int index, Color4u8 item) {} // 0x00A17FF0-0x00A180D0
			public bool Remove(Color4u8 item) => default; // 0x00A180D0-0x00A180E0
			public void RemoveAt(int index) {} // 0x00A180E0-0x00A18150
		}
	
		// Methods
		public void SetDefault() {} // 0x00A16DE0-0x00A174D0
		public override string ToString() => default; // 0x00A174D0-0x00A174E0
	}
}
