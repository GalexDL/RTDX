﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class NpadHandheld // TypeDefIndex: 9050
	{
		// Methods
		public static extern void GetState(ref NpadHandheldState pOutValue, NpadId npadId); // 0x00A1B3C0-0x00A1B3D0
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId); // 0x00A1A400-0x00A1A410
		public static extern int GetStates(out NpadHandheldState[] pOutValues, int count, NpadId npadId); // 0x00A1B3D0-0x00A1B7E0
		public static extern int GetStates(out NpadStateArrayItem[] pOutValues, int count, NpadId npadId); // 0x00A1A9D0-0x00A1AB10
	}
}
