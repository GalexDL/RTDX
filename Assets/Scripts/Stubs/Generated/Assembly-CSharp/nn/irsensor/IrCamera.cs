/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.hid;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public static class IrCamera // TypeDefIndex: 8996
	{
		// Fields
		public const int IntensityMax = 255; // Metadata: 0x00630FFF
		public const int ImageWidth = 320; // Metadata: 0x00631003
		public const int ImageHeight = 240; // Metadata: 0x00631007
		public const int GainMin = 1; // Metadata: 0x0063100B
		public const int GainMax = 16; // Metadata: 0x0063100F
	
		// Methods
		public static extern IrCameraHandle GetHandle(NpadId npadId); // 0x01150580-0x011505A0
		public static extern void Initialize(IrCameraHandle handle); // 0x011505A0-0x011505B0
		public static extern void Finalize(IrCameraHandle handle); // 0x011505B0-0x011505C0
		public static extern IrCameraStatus GetStatus(IrCameraHandle handle); // 0x011505C0-0x011505D0
		public static extern Result CheckFirmwareUpdateNecessity(ref bool pOutIsUpdateNeeded, IrCameraHandle handle); // 0x011505D0-0x011505F0
	}
}
