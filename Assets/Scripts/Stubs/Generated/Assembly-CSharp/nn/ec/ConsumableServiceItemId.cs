/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public struct ConsumableServiceItemId // TypeDefIndex: 9156
	{
		// Fields
		public const int Length = 16; // Metadata: 0x0063140B
		public string value; // 0x10
	
		// Constructors
		public ConsumableServiceItemId(string _value) {
			value = default;
		} // 0x00A12F50-0x00A12F60
	
		// Methods
		public override string ToString() => default; // 0x00A12F60-0x00A12F70
		public bool IsValid() => default; // 0x00A12FC0-0x00A13020
		private static extern bool IsValid(ConsumableServiceItemId itemId); // 0x00A12F70-0x00A12FC0
	}
}
