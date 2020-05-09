/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class NpadJoyLeft // TypeDefIndex: 9060
	{
		// Methods
		public static extern void GetState(ref NpadJoyLeftState pOutValue, NpadId npadId); // 0x00A1BD40-0x00A1BD50
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId); // 0x00A1A420-0x00A1A430
		public static extern int GetStates(out NpadJoyLeftState[] pOutValues, int count, NpadId npadId); // 0x00A1BD50-0x00A1C160
		public static extern int GetStates(out NpadStateArrayItem[] pOutValues, int count, NpadId npadId); // 0x00A1AC50-0x00A1AD90
	}
}
