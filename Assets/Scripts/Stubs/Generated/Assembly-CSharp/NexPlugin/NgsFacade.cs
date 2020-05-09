/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public static class NgsFacade // TypeDefIndex: 9352
	{
		// Nested types
		public delegate void LoginCB(AsyncResult asyncResult, ulong principalId, IntPtr pNgsFacade); // TypeDefIndex: 9353; 0x00FAE360-0x00FAE9E0
	
		public delegate void TestConnectivityCB(AsyncResult asyncResult, bool result); // TypeDefIndex: 9354; 0x00FAEA90-0x00FAF0C0
	
		// Methods
		public static bool RegisterNotificationEventHandler(NotificationEventCB callback) => default; // 0x00FBF0F0-0x00FBF160
		public static bool UnregisterNotificationEventHandler(NotificationEventCB callback) => default; // 0x00FBF160-0x00FBF1D0
		public static extern Result IsConnected(IntPtr pNgsFacade); // 0x00FBF1D0-0x00FBF1F0
		public static extern ulong GetPrincipalID(IntPtr pNgsFacade); // 0x00FBF1F0-0x00FBF200
		public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000 /* Metadata: 0x00631EA1 */, LoginCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FBF200-0x00FBF210
		public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FBF210-0x00FBF220
		public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, TestConnectivityCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FBF220-0x00FBF230
		public static extern bool GetGameServerTime(ref NpDateTime time, IntPtr pNgsFacade); // 0x00FBF230-0x00FBF250
	}
}
