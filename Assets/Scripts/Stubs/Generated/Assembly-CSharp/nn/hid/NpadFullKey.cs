/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class NpadFullKey // TypeDefIndex: 9048
	{
		// Methods
		public static extern void GetState(ref NpadFullKeyState pOutValue, NpadId npadId); // 0x00A1AF90-0x00A1AFA0
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId); // 0x00A1A3F0-0x00A1A400
		public static extern int GetStates(out NpadFullKeyState[] pOutValues, int count, NpadId npadId); // 0x00A1AFA0-0x00A1B3B0
		public static extern int GetStates(out NpadStateArrayItem[] pOutValues, int count, NpadId npadId); // 0x00A1A890-0x00A1A9D0
	}
}
