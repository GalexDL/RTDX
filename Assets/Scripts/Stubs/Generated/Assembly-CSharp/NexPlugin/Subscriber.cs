/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public static class Subscriber // TypeDefIndex: 9329
	{
		// Fields
		public const uint MAX_TOPIC_CONTENT_SIZE = 100; // Metadata: 0x00631CE3
		public const uint MAX_TIMELINE_CONTENT_SIZE = 100; // Metadata: 0x00631CE7
		public const uint MAX_FOLLOWING_SIZE = 20; // Metadata: 0x00631CEB
		public const uint NUM_RESERVED_TOPICS = 128; // Metadata: 0x00631CEF
		public const uint INVALID_RESERVED_TOPIC_NUM = 4294967295; // Metadata: 0x00631CF3
		public const uint MAX_GET_FOLLOWER_SIZE = 1000; // Metadata: 0x00631CF7
		public const uint MAX_CONTENT_MESSAGE_LEN = 140; // Metadata: 0x00631CFB
		public const uint MAX_CONTENT_BINARY_SIZE = 256; // Metadata: 0x00631CFF
		public const uint MAX_POST_CONTENT_TOPIC_SIZE = 10; // Metadata: 0x00631D03
		public const uint MAX_GET_CONTENT_PARAMS_SIZE = 3; // Metadata: 0x00631D07
		public const byte STATUS_KEY_SIZE = 8; // Metadata: 0x00631D0B
		public const uint MAX_STATUS_BINARY_SIZE = 128; // Metadata: 0x00631D0C
		public const uint MAX_GET_STATUS_USER_SIZE = 100; // Metadata: 0x00631D10
		public const uint DEFAULT_RMC_INTERVAL = 5000; // Metadata: 0x00631D14
	
		// Nested types
		public delegate void PostContentCB(AsyncResult asyncResult, ulong contentId); // TypeDefIndex: 9330; 0x00FBB8A0-0x00FBBED0
	
		public delegate void GetContentCB(AsyncResult asyncResult, List<SubscriberContent> contents); // TypeDefIndex: 9331; 0x00FBBFF0-0x00FBC620
	
		public delegate void GetContentsCB(AsyncResult asyncResult, List<List<SubscriberContent>> contents); // TypeDefIndex: 9332; 0x00FBC710-0x00FBCD40
	
		public delegate void GetSubscriberUserStatusInfoCB(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos); // TypeDefIndex: 9333; 0x00FBCE60-0x00FBD490
	
		// Methods
		public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0 /* Metadata: 0x00631CC2 */, PostContentCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9620-0x00FC9630
		public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0 /* Metadata: 0x00631CC6 */, GetContentCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9630-0x00FC9640
		public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0 /* Metadata: 0x00631CCA */, GetContentsCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9640-0x00FC9650
		public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0 /* Metadata: 0x00631CCE */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9650-0x00FC9660
		public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631CD2 */, GetSubscriberUserStatusInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9660-0x00FC9670
		public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0 /* Metadata: 0x00631CD6 */, GetSubscriberUserStatusInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9670-0x00FC9680
		public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0 /* Metadata: 0x00631CDA */, GetSubscriberUserStatusInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9680-0x00FC9690
		public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify = false /* Metadata: 0x00631CDE */, int timeOut = 0 /* Metadata: 0x00631CDF */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC9690-0x00FC96A0
		public static extern bool EnableFriendUserStatusesCache(IntPtr pNgsFacade); // 0x00FC96A0-0x00FC96C0
		public static extern bool DisableFriendUserStatusesCache(IntPtr pNgsFacade); // 0x00FC96C0-0x00FC96E0
		public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result) {
			result = default;
			return default;
		} // 0x00FC96E0-0x00FC9720
		public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result) {
			result = default;
			return default;
		} // 0x00FC9720-0x00FC9740
		public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result) {
			infos = default;
			result = default;
			return default;
		} // 0x00FC9740-0x00FC9750
		public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result) {
			infos = default;
			result = default;
			return default;
		} // 0x00FC9750-0x00FC9760
		public static extern bool GetUserStatusRevision(IntPtr pNgsFacade, out uint revision); // 0x00FC9760-0x00FC9780
	}
}
