/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using nn;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public class Subscriber : Common // TypeDefIndex: 9512
	{
		// Fields
		[SerializeField] // 0x00618430-0x00618440
		private bool m_IsPeriodObject; // 0x18
		private Dictionary<int, FunctionInfo> FunctionInfos; // 0x20
		private static List<ApiCallsFrequency> s_ApiCallsFrequencyList; // 0x00
	
		// Nested types
		private class POSTCONTENT_ARG : Common.CORE_ARG // TypeDefIndex: 9513
		{
			// Fields
			public SubscriberPostContentParam param; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Subscriber.PostContentCB callback; // 0x38
	
			// Constructors
			public POSTCONTENT_ARG() {} // 0x00DBB900-0x00DBB910
		}
	
		private class GETCONTENT_ARG : Common.CORE_ARG // TypeDefIndex: 9514
		{
			// Fields
			public SubscriberGetContentParam param; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Subscriber.GetContentCB callback; // 0x38
	
			// Constructors
			public GETCONTENT_ARG() {} // 0x00DBBB30-0x00DBBB40
		}
	
		private class GETCONTENTS_ARG : Common.CORE_ARG // TypeDefIndex: 9515
		{
			// Fields
			public List<SubscriberGetContentParam> paramList; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Subscriber.GetContentsCB callback; // 0x38
	
			// Constructors
			public GETCONTENTS_ARG() {} // 0x00DBBD70-0x00DBBD80
		}
	
		private class DELETECONTENT_ARG : Common.CORE_ARG // TypeDefIndex: 9516
		{
			// Fields
			public List<uint> topics; // 0x28
			public ulong contentId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public DELETECONTENT_ARG() {} // 0x00DBBFC0-0x00DBBFD0
		}
	
		private class GETFRIENDUSERSTATUSES_ARG : Common.CORE_ARG // TypeDefIndex: 9517
		{
			// Fields
			public int timeOut; // 0x28
			public List<byte> keys; // 0x30
			public List<ulong> users; // 0x38
			public NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback; // 0x40
	
			// Constructors
			public GETFRIENDUSERSTATUSES_ARG() {} // 0x00DBC1E0-0x00DBC1F0
		}
	
		private class UPDATEUSERSTATUS_ARG : Common.CORE_ARG // TypeDefIndex: 9518
		{
			// Fields
			public int timeOut; // 0x28
			public List<SubscriberUserStatusParam> param; // 0x30
			public bool isNotify; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public UPDATEUSERSTATUS_ARG() {} // 0x00DBC8A0-0x00DBC8B0
		}
	
		private enum Functions // TypeDefIndex: 9519
		{
			PostContent = 0,
			GetContent = 1,
			GetContents = 2,
			DeleteContent = 3,
			UpdateUserStatus = 4,
			GetFriendUserStatuses = 5,
			GetUserStatuses = 6
		}
	
		// Constructors
		public Subscriber() {} // 0x00DBCE00-0x00DBD000
		static Subscriber() {} // 0x00DBD000-0x00DBD080
	
		// Methods
		public ASYNCSTATE PostContentAsync(SubscriberPostContentParam param, NexPlugin.Subscriber.PostContentCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063235F */) => default; // 0x00DBB7F0-0x00DBB900
		private ASYNCSTATE PostContentAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBB910-0x00DBBA10
		public ASYNCSTATE GetContentAsync(SubscriberGetContentParam param, NexPlugin.Subscriber.GetContentCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632363 */) => default; // 0x00DBBA20-0x00DBBB30
		private ASYNCSTATE GetContentAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBBB40-0x00DBBC60
		public ASYNCSTATE GetContentsAsync(List<SubscriberGetContentParam> paramList, NexPlugin.Subscriber.GetContentsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632367 */) => default; // 0x00DBBC60-0x00DBBD70
		private ASYNCSTATE GetContentsAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBBD80-0x00DBBEA0
		public ASYNCSTATE DeleteContentAsync(List<uint> topics, ulong contentId, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063236B */) => default; // 0x00DBBEA0-0x00DBBFC0
		private ASYNCSTATE DeleteContentAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBBFD0-0x00DBC0D0
		public ASYNCSTATE GetFriendUserStatusesAsync(NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063236F */) => default; // 0x00DBC0D0-0x00DBC1E0
		private ASYNCSTATE GetFriendUserStatusesAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBC1F0-0x00DBC310
		public ASYNCSTATE GetFriendUserStatusesAsync(List<byte> keys, NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632373 */) => default; // 0x00DBC310-0x00DBC420
		private ASYNCSTATE GetFriendUserStatusesWithKeyAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBC420-0x00DBC540
		public ASYNCSTATE GetUserStatusesAsync(List<ulong> users, List<byte> keys, NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632377 */) => default; // 0x00DBC540-0x00DBC660
		private ASYNCSTATE GetUserStatusesAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBC660-0x00DBC780
		public ASYNCSTATE UpdateUserStatusAsync(List<SubscriberUserStatusParam> param, bool isNotify = false /* Metadata: 0x0063237B */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063237C */) => default; // 0x00DBC780-0x00DBC8A0
		private ASYNCSTATE UpdateUserStatusAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DBC8B0-0x00DBC9B0
		public bool EnableFriendUserStatusesCache(IntPtr pNgsFacade = default) => default; // 0x00DBC9B0-0x00DBCA40
		public bool DisableFriendUserStatusesCache(IntPtr pNgsFacade = default) => default; // 0x00DBCA40-0x00DBCAD0
		public bool GetFriendUserStatusesCacheMode(out bool result, IntPtr pNgsFacade = default) {
			result = default;
			return default;
		} // 0x00DBCAD0-0x00DBCB70
		public bool GetFriendUserStatusesCacheLastResult(out Result result, IntPtr pNgsFacade = default) {
			result = default;
			return default;
		} // 0x00DBCB70-0x00DBCC10
		public bool GetFriendUserStatuses(out List<SubscriberUserStatusInfo> infos, out Result result, IntPtr pNgsFacade = default) {
			infos = default;
			result = default;
			return default;
		} // 0x00DBCC10-0x00DBCCB0
		public bool GetFriendUserStatuses(List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result, IntPtr pNgsFacade = default) {
			infos = default;
			result = default;
			return default;
		} // 0x00DBCCB0-0x00DBCD60
		public bool GetUserStatusRevision(out uint revision, IntPtr pNgsFacade = default) {
			revision = default;
			return default;
		} // 0x00DBCD60-0x00DBCE00
		private new bool ApiCallsFrequencyCheck(int type) => default; // 0x00DBBA10-0x00DBBA20
	}
}
