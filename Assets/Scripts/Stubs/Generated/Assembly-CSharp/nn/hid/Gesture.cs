/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class Gesture // TypeDefIndex: 9038
	{
		// Fields
		public const int PointCountMax = 4; // Metadata: 0x00631173
		public const int StateCountMax = 16; // Metadata: 0x00631177
	
		// Methods
		public static extern void Initialize(); // 0x00A18760-0x00A18770
		public static extern int GetStates(out GestureState[] pOutValues, int count); // 0x00A18770-0x00A18890
	}
}
