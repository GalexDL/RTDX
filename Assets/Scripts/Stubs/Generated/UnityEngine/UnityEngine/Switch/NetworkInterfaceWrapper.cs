/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 23: UnityEngine.SwitchModule.dll - Assembly: UnityEngine.SwitchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3428-3443

namespace UnityEngine.Switch
{
	// [NativeHeader] // 0x005EDD20-0x005EDD60
	public static class NetworkInterfaceWrapper // TypeDefIndex: 3431
	{
		// Events
		public static event NetworkConnectedHandler networkConnected;
		private static event NetworkConnectedHandler _networkConnected;
	
		// Nested types
		public enum NetworkConnectedResult // TypeDefIndex: 3432
		{
			Pending = -1,
			Denied = 0,
			Accepted = 1
		}
	
		public delegate NetworkConnectedResult NetworkConnectedHandler(); // TypeDefIndex: 3433; 0x0051D7E0-0x0051DB30
	
		// Methods
		// [NativeConditional] // 0x005EDF40-0x005EDFB0
		public static bool EnterNetworkConnecting(bool isLocalNetworkMode = false /* Metadata: 0x0060F77A */) => default; // 0x0051D1A0-0x0051D210
		// [NativeConditional] // 0x005EDFB0-0x005EE020
		public static bool WeakEnterNetworkConnecting() => default; // 0x0051D210-0x0051D290
		// [NativeConditional] // 0x005EE020-0x005EE090
		public static void LeaveNetworkConnecting() {} // 0x0051D290-0x0051D310
		// [NativeConditional] // 0x005EE090-0x005EE100
		public static bool IsNetworkConnecting() => default; // 0x0051D310-0x0051D390
		// [NativeConditional] // 0x005EE100-0x005EE170
		public static void WaitForNetworkConnecting() {} // 0x0051D390-0x0051D410
		// [NativeConditional] // 0x005EE170-0x005EE1E0
		public static bool IsNetworkAccepted() => default; // 0x0051D410-0x0051D490
		// [NativeConditional] // 0x005EE1E0-0x005EE250
		public static bool IsNetworkFinished() => default; // 0x0051D490-0x0051D510
		// [NativeConditional] // 0x005EE250-0x005EE2C0
		public static int GetNetworkReferenceCount() => default; // 0x0051D510-0x0051D590
		// [NativeConditional] // 0x005EE2C0-0x005EE330
		public static bool IsNetworkAvailable() => default; // 0x0051D590-0x0051D610
		// [NativeConditional] // 0x005EE330-0x005EE3A0
		public static bool IsNetworkConnectingOnBackground() => default; // 0x0051D610-0x0051D690
		// [NativeConditional] // 0x005EE3A0-0x005EE410
		public static void SetNetworkConnectingOnBackground(bool isBackground) {} // 0x0051D690-0x0051D700
		// [NativeConditional] // 0x005EE410-0x005EE480
		private static void SetNetworkConnectedEnabled(bool isEnabled) {} // 0x0051D700-0x0051D770
		private static int InvokeNetworkConnected() => default; // 0x0051D770-0x0051D7E0
	}
}
