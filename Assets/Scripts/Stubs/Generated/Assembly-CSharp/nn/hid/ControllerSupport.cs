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
	public static class ControllerSupport // TypeDefIndex: 9024
	{
		// Fields
		public const int ExplainTextMaxLength = 32; // Metadata: 0x006310DF
		public const int Utf8ByteSize = 4; // Metadata: 0x006310E3
		public const int ExplainTextMaxBufferSize = 129; // Metadata: 0x006310E7
	
		// Properties
		public static ErrorRange ResultCanceled { get; } // 0x00A16DC0-0x00A16DD0 
		public static ErrorRange ResultNotSupportedNpadStyle { get; } // 0x00A16DD0-0x00A16DE0 
	
		// Methods
		public static extern Result Show(ControllerSupportArg showControllerSupportArg); // 0x00A16340-0x00A16530
		public static extern Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg); // 0x00A16530-0x00A16640
		public static extern void SetExplainText(ref ControllerSupportArg pOutControllerSupportArg, string pStr, NpadId npadId); // 0x00A16640-0x00A169B0
		public static Result Show(ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) => default; // 0x00A169B0-0x00A16BB0
		public static Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads) => default; // 0x00A16BB0-0x00A16DC0
	}
}
