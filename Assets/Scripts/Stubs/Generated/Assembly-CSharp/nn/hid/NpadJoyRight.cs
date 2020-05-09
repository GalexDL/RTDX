/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class NpadJoyRight // TypeDefIndex: 9062
	{
		// Methods
		public static extern void GetState(ref NpadJoyRightState pOutValue, NpadId npadId); // 0x00A1C170-0x00A1C180
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId); // 0x00A1A430-0x00A1A440
		public static extern int GetStates(out NpadJoyRightState[] pOutValues, int count, NpadId npadId); // 0x00A1C180-0x00A1C590
		public static extern int GetStates(out NpadStateArrayItem[] pOutValues, int count, NpadId npadId); // 0x00A1AD90-0x00A1AED0
	}
}
