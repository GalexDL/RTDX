/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct AnalogStickState // TypeDefIndex: 9018
	{
		// Fields
		public const int Max = 32767; // Metadata: 0x006310D3
		public int x; // 0x10
		public int y; // 0x14
	
		// Properties
		public float fx { get => default; } // 0x00A16110-0x00A16150 
		public float fy { get => default; } // 0x00A16150-0x00A16170 
	
		// Methods
		public void Clear() {} // 0x00A16170-0x00A16180
		public override string ToString() => default; // 0x00A16180-0x00A16220
	}
}
