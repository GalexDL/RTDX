/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class Vibration // TypeDefIndex: 9125
	{
		// Methods
		public static extern int GetDeviceHandles(VibrationDeviceHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle); // 0x01143D50-0x01143D60
		public static extern void GetDeviceInfo(ref VibrationDeviceInfo pOutValue, VibrationDeviceHandle handle); // 0x01143D60-0x01143D70
		public static extern void InitializeDevice(VibrationDeviceHandle handle); // 0x01143D70-0x01143D80
		public static extern void SendValue(VibrationDeviceHandle handle, VibrationValue value); // 0x01143D80-0x01143D90
		public static extern void GetActualValue(ref VibrationValue pOutValue, VibrationDeviceHandle handle); // 0x01143D90-0x01143DA0
		public static extern bool IsPermitted(); // 0x01143DA0-0x01143DC0
	}
}
