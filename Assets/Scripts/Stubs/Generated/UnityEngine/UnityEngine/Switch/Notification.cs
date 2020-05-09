/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 23: UnityEngine.SwitchModule.dll - Assembly: UnityEngine.SwitchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3428-3443

namespace UnityEngine.Switch
{
	public static class Notification // TypeDefIndex: 3440
	{
		// Events
		public static event Action<Message> notificationMessageReceived;
	
		// Nested types
		public enum Message // TypeDefIndex: 3441
		{
			ExitRequest = 4,
			FocusStateChanged = 15,
			Resume = 16,
			OperationModeChanged = 30,
			PerformanceModeChanged = 31
		}
	
		public enum FocusState // TypeDefIndex: 3442
		{
			InFocus = 1,
			OutOfFocus = 2,
			Background = 3
		}
	
		public enum FocusHandlingMode // TypeDefIndex: 3443
		{
			Suspend = 0,
			Notify = 1,
			SuspendAndNotify = 2,
			InFocusOnly = 3
		}
	
		// Methods
		public static void SetFocusHandlingMode(FocusHandlingMode mode) {} // 0x0051E0A0-0x0051E110
		// [NativeConditional] // 0x005EE6E0-0x005EE740
		private static void SetFocusHandlingMode_Internal(FocusHandlingMode mode) {} // 0x0051E110-0x0051E180
		public static FocusState GetCurrentFocusState() => default; // 0x0051E180-0x0051E200
		// [NativeConditional] // 0x005EE740-0x005EE7A0
		private static FocusState GetCurrentFocusState_Internal() => default; // 0x0051E200-0x0051E280
		public static void SetResumeNotificationEnabled(bool enabled) {} // 0x0051E280-0x0051E2F0
		// [NativeConditional] // 0x005EE7A0-0x005EE800
		private static void SetResumeNotificationEnabled_Internal(bool enabled) {} // 0x0051E2F0-0x0051E360
		public static void EnterExitRequestHandlingSection() {} // 0x0051E360-0x0051E3E0
		// [NativeConditional] // 0x005EE800-0x005EE860
		private static void EnterExitRequestHandlingSection_Internal() {} // 0x0051E3E0-0x0051E460
		public static void LeaveExitRequestHandlingSection() {} // 0x0051E460-0x0051E4E0
		// [NativeConditional] // 0x005EE860-0x005EE8C0
		private static void LeaveExitRequestHandlingSection_Internal() {} // 0x0051E4E0-0x0051E560
		public static void SetOperationModeChangedNotificationEnabled(bool enabled) {} // 0x0051E560-0x0051E5D0
		// [NativeConditional] // 0x005EE8C0-0x005EE920
		private static void SetOperationModeChangedNotificationEnabled_Internal(bool enabled) {} // 0x0051E5D0-0x0051E640
		public static void SetPerformanceModeChangedNotificationEnabled(bool enabled) {} // 0x0051E640-0x0051E6B0
		// [NativeConditional] // 0x005EE920-0x005EE980
		private static void SetPerformanceModeChangedNotificationEnabled_Internal(bool enabled) {} // 0x0051E6B0-0x0051E720
		private static void InvokeNotificationMessage(int message) {} // 0x0051E720-0x0051E7A0
	}
}
