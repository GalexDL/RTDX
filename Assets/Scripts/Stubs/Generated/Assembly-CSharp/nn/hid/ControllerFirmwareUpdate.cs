/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class ControllerFirmwareUpdate // TypeDefIndex: 9026
	{
		// Properties
		public static ErrorRange ResultControllerFirmwareUpdateError { get; } // 0x00A162A0-0x00A162B0 
		public static ErrorRange ResultControllerFirmwareUpdateFailed { get; } // 0x00A162B0-0x00A162C0 
	
		// Methods
		public static extern Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg); // 0x00A16220-0x00A16240
		public static Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg, bool suspendUnityThreads) => default; // 0x00A16240-0x00A162A0
	}
}
