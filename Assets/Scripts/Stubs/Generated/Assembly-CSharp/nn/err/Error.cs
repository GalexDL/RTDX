/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.err
{
	public static class Error // TypeDefIndex: 9148
	{
		// Methods
		public static extern void Show(Result result); // 0x00A15180-0x00A15190
		public static extern void Show(ErrorCode errorCode); // 0x00A15190-0x00A151A0
		public static void Show(Result result, bool suspendUnityThreads) {} // 0x00A151A0-0x00A151F0
		public static void Show(ErrorCode errorCode, bool suspendUnityThreads) {} // 0x00A151F0-0x00A15240
		public static extern void ShowUnacceptableAddOnContentVersion(); // 0x00A15240-0x00A15250
		public static void ShowUnacceptableAddOnContentVersion(bool suspendUnityThreads) {} // 0x00A15250-0x00A15280
		public static extern void ShowUnacceptableApplicationVersion(); // 0x00A15280-0x00A15290
		public static void ShowUnacceptableApplicationVersion(bool suspendUnityThreads) {} // 0x00A15290-0x00A152C0
	}
}
