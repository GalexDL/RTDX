/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public static class Common // TypeDefIndex: 9243
	{
		// Fields
		public const ulong INVALID_PRINCIPALID = 0; // Metadata: 0x0063177A
		public const ulong INVALID_UNIQUEID = 0; // Metadata: 0x00631782
		public const uint INFINITE_TIME_INTERVAL = 2147483647; // Metadata: 0x0063178A
	
		// Nested types
		[Flags] // 0x00613F60-0x00613F70
		public enum ThreadMode // TypeDefIndex: 9244
		{
			ThreadModeSafeTransportBuffer = 1,
			ThreadModeUnsafeTransportBuffer = 2
		}
	
		[Flags] // 0x00613F70-0x00613F80
		public enum DispachFlag // TypeDefIndex: 9245
		{
			ContinueWhenEmpty = 1,
			DispatchKeepAliveOnly = 2
		}
	
		public enum NotificationEvents // TypeDefIndex: 9246
		{
			ParticipationEvent = 3,
			OwnershipChangeEvent = 4,
			GatheringUnregistered = 109,
			HostChangeEvent = 110,
			GameNotificationLogout = 111,
			SubscriptionEvent = 112,
			GameServerMaintenance = 113,
			MaintenanceAnnouncement = 114,
			RoundStarted = 116,
			FirstRoundReportReceived = 117,
			RoundSummarized = 118,
			MatchmakeSystemConfigurationNotification = 119,
			MatchmakeSessionSystemPasswordSet = 120,
			MatchmakeSessionSystemPasswordClear = 121,
			AddedToGathering = 122,
			UserStatusUpdatedEvent = 128
		}
	
		public enum ParticipationEvents // TypeDefIndex: 9247
		{
			Participate = 1,
			Disconnect = 7,
			EndParticipation = 8
		}
	
		// Methods
		public static extern bool IsInitializedNex(); // 0x00F91660-0x00F91680
		public static extern bool IsNetworkConnected(); // 0x00F91680-0x00F916A0
		public static extern bool InitializeNexPlugin(uint pluginMemSize, uint nexMemSize, uint reserveMemSize); // 0x00F916A0-0x00F916C0
		public static extern bool FinalizeNexPlugin(); // 0x00F916C0-0x00F916E0
		public static bool InitializeNexAsync(out uint asyncId, ThreadMode threadMode, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F916E0-0x00F916F0
		public static extern bool InitializeNex(ThreadMode threadMode); // 0x00F91800-0x00F91820
		public static extern bool FinalizeNex(); // 0x00F91820-0x00F91840
		public static uint Dispatch(uint dispatchTimeout, DispachFlag? dispatchFlags = default) => default; // 0x00F91840-0x00F918D0
		public static bool UpdateAsyncResult() => default; // 0x00F91960-0x00F91970
		public static void Wait(uint dispatchTimeout = 0 /* Metadata: 0x00631776 */, DispachFlag? dispatchFlags = default) {} // 0x00F91AC0-0x00F91AD0
		public static extern void DumpMemory(); // 0x00F91C20-0x00F91C30
		public static int GetNexAsyncCallCount() => default; // 0x00F91C30-0x00F91CF0
		public static void DumpNexAsyncCallList() {} // 0x00F91D70-0x00F91DE0
		public static int GetAllocedCount() => default; // 0x00F91DF0-0x00F91E00
		public static int GetUsedAllocsize() => default; // 0x00F91E00-0x00F91E10
	}
}
