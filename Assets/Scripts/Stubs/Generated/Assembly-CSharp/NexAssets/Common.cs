/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using nn;
using nn.account;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public class Common : MonoBehaviour // TypeDefIndex: 9387
	{
		// Fields
		public const int NC_VERSION = 214; // Metadata: 0x00631EF2
		protected static string s_OperationPlatform; // 0x00
		private static bool s_NexUpdateF; // 0x08
		private static NEX_INIT_PARAM s_NexInitParam; // 0x10
		protected static NexInitializer s_NexInitializer; // 0x48
		protected static AsyncResult s_AutoLoginResult; // 0x50
		protected static ASYNCSTATE s_AutoLoginState; // 0x58
		protected static bool s_AutoLogout; // 0x5C
		protected static int s_AutoLogoutCount; // 0x60
		protected static List<CORE_ARG> s_CoreArgList; // 0x68
		private static LostConnectCallback m_LostConnectCB; // 0x70
		private static NGSDisconnectCallback m_NGSDisconnectCB; // 0x78
		protected static List<NgsFacadeInfo> s_NgsFacadeInfoList; // 0x80
		protected static NgsFacadeInfo s_LastLoginNgsFacadeInfo; // 0x88
		protected static IntPtr s_DefaultUser; // 0xA0
		private static List<UserInfo> s_OpenUsers; // 0xA8
		private static UserInfo s_AutoLoginUser; // 0xB0
		private static Dictionary<int, FunctionInfo> FunctionInfos; // 0xE0
		private static List<ApiCallsFrequency> s_ApiCallsFrequencyList; // 0xE8
	
		// Nested types
		public enum CALL_DISPATCH // TypeDefIndex: 9388
		{
			UPDATE = 1,
			LATEUPDATE = 2
		}
	
		public struct NEX_INIT_PARAM // TypeDefIndex: 9389
		{
			// Fields
			public NP_NGSINFO ngsInfo; // 0x10
			public uint pluginMemSize; // 0x28
			public uint nexMemSize; // 0x2C
			public uint reserveMemSize; // 0x30
			public NexPlugin.Common.ThreadMode threadMode; // 0x34
			public CALL_DISPATCH callDispatch; // 0x38
			public uint dispatchTimeOut; // 0x3C
			public NexPlugin.Common.DispachFlag dispatchFlag; // 0x40
			public bool autoLogin; // 0x44
			public bool autoLogout; // 0x45
		}
	
		protected delegate ASYNCSTATE ExecAsyncFunc(AsyncResult asyncResult, CORE_ARG arg); // TypeDefIndex: 9390; 0x00DA84C0-0x00DA9010
	
		public delegate void LostConnectCallback(); // TypeDefIndex: 9391; 0x00DA91A0-0x00DA9510
	
		public delegate void NGSDisconnectCallback(ulong principalId); // TypeDefIndex: 9392; 0x00DA9790-0x00DA9B40
	
		public struct NgsFacadeInfo // TypeDefIndex: 9393
		{
			// Fields
			public ulong principalId; // 0x10
			public IntPtr pNgsFacade; // 0x18
			public bool isLogin; // 0x20
		}
	
		protected struct UserInfo // TypeDefIndex: 9394
		{
			// Fields
			public Uid uid; // 0x10
			public UserHandle userHandle; // 0x20
			public NetworkServiceAccountId nsaId; // 0x38
		}
	
		public struct NP_NGSINFO // TypeDefIndex: 9395
		{
			// Fields
			public uint gameServerId; // 0x10
			public string accessKey; // 0x18
			public int timeOut; // 0x20
		}
	
		public enum ASYNCSTATE // TypeDefIndex: 9396
		{
			NONE = -1,
			INVALID = 0,
			INVALID_ARGUMENT = 1,
			PLUGINCALL_SUCCESS = 2,
			PLUGINCALL_ERROR = 3,
			NOT_NEXINIT = 4,
			NOT_LOGIN = 5,
			INIT_NEX_START = 6,
			INIT_NEX_ERROR = 7,
			NGS_USER_CANCEL = 8,
			NGS_USER_SELECT_ERROR = 9,
			NGS_USER_OPEN_ERROR = 10,
			NGS_ENSUREAVAILABLE_ERROR = 11,
			NGS_GETID_ERROR = 12,
			NGS_ENSURIDTOKENCACHE_ERROR = 13,
			NGS_LOADIDTOKENCACHE_ERROR = 14,
			NGS_LOGIN_START = 15,
			NGS_LOGIN_ERROR = 16
		}
	
		protected class CORE_ARG // TypeDefIndex: 9397
		{
			// Fields
			public AsyncResultNum asyncNum; // 0x10
			public uint asyncId; // 0x14
			public IntPtr pNgsFacade; // 0x18
			public ExecAsyncFunc func; // 0x20
	
			// Constructors
			public CORE_ARG() {} // 0x00DA8490-0x00DA84A0
	
			// Methods
			public T Clone<T>() => default;
		}
	
		private class NEX_INIT_ARG : CORE_ARG // TypeDefIndex: 9398
		{
			// Fields
			public AsyncResultCB callback; // 0x28
	
			// Constructors
			public NEX_INIT_ARG() {} // 0x00DA9550-0x00DA9780
		}
	
		private class GETUID_ARG : CORE_ARG // TypeDefIndex: 9399
		{
			// Fields
			public int timeOut; // 0x28
			public Utility.AcquireNexUniqueIdCB callback; // 0x30
	
			// Constructors
			public GETUID_ARG() {} // 0x00DA9170-0x00DA9190
		}
	
		private class GETUIDWITHPASSWD_ARG : CORE_ARG // TypeDefIndex: 9400
		{
			// Fields
			public int timeOut; // 0x28
			public Utility.AcquireNexUniqueIdWithPasswordCB callback; // 0x30
	
			// Constructors
			public GETUIDWITHPASSWD_ARG() {} // 0x00DA9160-0x00DA9170
		}
	
		private class ASCUIDWITHPID_ARG : CORE_ARG // TypeDefIndex: 9401
		{
			// Fields
			public UniqueIdInfo info; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public ASCUIDWITHPID_ARG() {} // 0x00DA84A0-0x00DA84B0
		}
	
		private class ASCUIDWITHPIDLIST_ARG : CORE_ARG // TypeDefIndex: 9402
		{
			// Fields
			public List<UniqueIdInfo> info; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public ASCUIDWITHPIDLIST_ARG() {} // 0x00DA8480-0x00DA8490
		}
	
		private class GETASCUIDWITHPID_ARG : CORE_ARG // TypeDefIndex: 9403
		{
			// Fields
			public int timeOut; // 0x28
			public Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback; // 0x30
	
			// Constructors
			public GETASCUIDWITHPID_ARG() {} // 0x00DA9140-0x00DA9150
		}
	
		private class GETASCUIDWITHPIDLIST_ARG : CORE_ARG // TypeDefIndex: 9404
		{
			// Fields
			public int timeOut; // 0x28
			public Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback; // 0x30
	
			// Constructors
			public GETASCUIDWITHPIDLIST_ARG() {} // 0x00DA9130-0x00DA9140
		}
	
		private class GETINTEGERSETTINGS_ARG : CORE_ARG // TypeDefIndex: 9405
		{
			// Fields
			public uint index; // 0x28
			public int timeOut; // 0x2C
			public Utility.GetIntegerSettingsCB callback; // 0x30
	
			// Constructors
			public GETINTEGERSETTINGS_ARG() {} // 0x00DA9150-0x00DA9160
		}
	
		protected struct ApiCallsFrequency // TypeDefIndex: 9406
		{
			// Fields
			public int type; // 0x10
			public float time; // 0x14
		}
	
		protected struct FunctionInfo // TypeDefIndex: 9407
		{
			// Fields
			public int type; // 0x10
			public int limit; // 0x14
			public int time; // 0x18
			public string name; // 0x20
		}
	
		private enum Functions // TypeDefIndex: 9408
		{
			TestConnectivity = 0,
			AcquireNexUniqueId = 1,
			AcquireNexUniqueIdWithPassword = 2,
			AssociateNexUniqueIdWithMyPrincipalId = 3,
			AssociateNexUniqueIdWithMyPrincipalId2 = 4,
			GetAssociatedNexUniqueIdWithMyPrincipalId = 5,
			GetAssociatedNexUniqueIdWithMyPrincipalId2 = 6,
			GetIntegerSettings = 7
		}
	
		// Constructors
		public Common() {} // 0x008B7EE0-0x008B7EF0
		static Common() {} // 0x008B7EF0-0x008B8220
	
		// Methods
		private NEX_INIT_PARAM GetNexInitParam() => default; // 0x008B3210-0x008B3360
		public static NP_NGSINFO GetNgsInfo() => default; // 0x008B3360-0x008B33E0
		public static NgsFacadeInfo GetLastLoginNgsFacadeInfo() => default; // 0x008B33E0-0x008B3460
		public static void SetDefaultUser(IntPtr pNgsFacade) {} // 0x008B3460-0x008B34D0
		public static IntPtr GetDefaultUser() => default; // 0x008B34D0-0x008B3540
		public static void SetAutoLoginUserHandle(UserHandle userHandle) {} // 0x008B3540-0x008B3600
		public static List<UserHandle> GetAutoLoginUserHandle() => default; // 0x008B3600-0x008B38E0
		public static bool GetAutoLoginResult(out ASYNCSTATE state, out AsyncResult result) {
			state = default;
			result = default;
			return default;
		} // 0x008B38E0-0x008B39B0
		public bool IsAsyncStateError(ASYNCSTATE state) => default; // 0x008B39B0-0x008B39E0
		protected void Awake() {} // 0x008B39E0-0x008B3AA0
		protected void Update() {} // 0x008B3AA0-0x008B4080
		protected void LateUpdate() {} // 0x008B4280-0x008B4380
		public bool InitializeNex() => default; // 0x008B4380-0x008B4470
		public bool InitializeNex(uint pluginMemSize, uint nexMemSize, uint reserveMemSize, NexPlugin.Common.ThreadMode threadMode) => default; // 0x008B4470-0x008B4530
		public bool InitializeNexAsync(AsyncResultCB callback = null) => default; // 0x008B4540-0x008B45E0
		public bool InitializeNexAsync(uint pluginMemSize, uint nexMemSize, uint reserveMemSize, NexPlugin.Common.ThreadMode threadMode, AsyncResultCB callback = null) => default; // 0x008B4730-0x008B47D0
		private bool InitializeNexAsync(uint pluginMemSize, uint nexMemSize, uint reserveMemSize, NexPlugin.Common.ThreadMode threadMode, NEX_INIT_ARG arg) => default; // 0x008B45E0-0x008B4730
		public bool FinalizeNex() => default; // 0x008B4180-0x008B4280
		public ASYNCSTATE LoginAsync(NgsFacade.LoginCB callback = null) => default; // 0x008B47E0-0x008B4910
		public ASYNCSTATE LoginAsync(NP_NGSINFO ngsInfo, NgsFacade.LoginCB callback = null) => default; // 0x008B4910-0x008B49A0
		public ASYNCSTATE LoginAsync(NetworkServiceAccountId nsaId, byte[] nsaIdToken, NgsFacade.LoginCB callback = null) => default; // 0x008B5370-0x008B5470
		public ASYNCSTATE LoginAsync(NP_NGSINFO ngsInfo, NetworkServiceAccountId nsaId, byte[] nsaIdToken, NgsFacade.LoginCB callback = null) => default; // 0x008B5470-0x008B54C0
		private ASYNCSTATE LoginAsync(ref uint asyncId, NP_NGSINFO ngsInfo, NetworkServiceAccountId nsaId, byte[] nsaIdToken, NgsFacade.LoginCB callback = null) => default; // 0x008B51D0-0x008B5370
		public ASYNCSTATE LogoutAsync(AsyncResultCB callback = null, IntPtr pNgsFacade = default) => default; // 0x008B4080-0x008B4180
		public static void Wait() {} // 0x008B54D0-0x008B5560
		public ASYNCSTATE AcquireNexUniqueIdAsync(Utility.AcquireNexUniqueIdCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631ED5 */) => default; // 0x008B5560-0x008B56B0
		private ASYNCSTATE AcquireNexUniqueIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B5940-0x008B5AA0
		public ASYNCSTATE AcquireNexUniqueIdWithPasswordAsync(Utility.AcquireNexUniqueIdWithPasswordCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631ED9 */) => default; // 0x008B5B30-0x008B5C80
		private ASYNCSTATE AcquireNexUniqueIdWithPasswordAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B5C80-0x008B5E00
		public ASYNCSTATE AssociateNexUniqueIdWithMyPrincipalIdAsync(UniqueIdInfo info, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631EDD */) => default; // 0x008B5E00-0x008B5F60
		private ASYNCSTATE AssociateNexUniqueIdWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B5F60-0x008B60C0
		public ASYNCSTATE AssociateNexUniqueIdsWithMyPrincipalIdAsync(List<UniqueIdInfo> info, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631EE1 */) => default; // 0x008B60C0-0x008B6220
		private ASYNCSTATE AssociateNexUniqueIdsWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B6220-0x008B6380
		public ASYNCSTATE GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631EE5 */) => default; // 0x008B6380-0x008B64D0
		private ASYNCSTATE GetAssociatedNexUniqueIdWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B64D0-0x008B6650
		public ASYNCSTATE GetAssociatedNexUniqueIdsWithMyPrincipalIdAsync(Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631EE9 */) => default; // 0x008B6650-0x008B67A0
		private ASYNCSTATE GetAssociatedNexUniqueIdsWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B67A0-0x008B6930
		public ASYNCSTATE GetIntegerSettingsAsync(uint index, Utility.GetIntegerSettingsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00631EED */) => default; // 0x008B6930-0x008B6A90
		private ASYNCSTATE GetIntegerSettingsAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x008B6A90-0x008B6C20
		public bool IsValidNexUniqueId(ulong nexUniqueId) => default; // 0x008B6C20-0x008B6C30
		public ASYNCSTATE TestConnectivityAsync(NgsFacade.TestConnectivityCB callback = null, IntPtr pNgsFacade = default) => default; // 0x008B6C30-0x008B6D30
		public bool GetGameServerTime(ref NpDateTime time, IntPtr pNgsFacade = default) => default; // 0x008B6D30-0x008B6D40
		public static ulong GetPrincipalId(IntPtr pNgsFacade = default) => default; // 0x008B6D40-0x008B6E20
		public static void SetConnectionLostCallback(LostConnectCallback callback) {} // 0x008B6E20-0x008B6E90
		public static void SetNGSDisconnectCallback(NGSDisconnectCallback callback) {} // 0x008B6E90-0x008B6F00
		protected ASYNCSTATE ExecAfterLogin(CORE_ARG coreArg) => default; // 0x008B56B0-0x008B5940
		private ASYNCSTATE InitializeNexsInf(ref uint async_id) => default; // 0x008B6F00-0x008B7140
		private Result ShowUserSelector(out UserInfo userInfo) {
			userInfo = default;
			return default;
		} // 0x008B72C0-0x008B72F0
		private Result OpenUser(ref UserInfo userInfo) => default; // 0x008B72F0-0x008B74F0
		private ASYNCSTATE GetLoginUserParam(out NetworkServiceAccountId nsaId, out byte[] tokenCache, bool autoLogin = false /* Metadata: 0x00631EF1 */) {
			nsaId = default;
			tokenCache = default;
			return default;
		} // 0x008B49A0-0x008B51D0
		private ASYNCSTATE NGSLoginInf(ref uint async_id) => default; // 0x008B7140-0x008B72C0
		private void SetAutoLoginResultError(Result res) {} // 0x008B74F0-0x008B7580
		protected ASYNCSTATE GetAsyncState(bool ret) => default; // 0x008B54C0-0x008B54D0
		private void CoreInitCB(AsyncResult asyncResult) {} // 0x008B7580-0x008B78D0
		private void CoreLoginCB(AsyncResult asyncResult, ulong pid, IntPtr pNgsFacade) {} // 0x008B78D0-0x008B7C90
		private void CoreLostConnectCB(AsyncResult asyncResult) {} // 0x008B7C90-0x008B7D10
		private void CoreLogoutCB(AsyncResult asyncResult) {} // 0x008B7D10-0x008B7D80
		protected static int GetCallCount(FunctionInfo info, List<ApiCallsFrequency> list) => default; // 0x008B7D80-0x008B7ED0
		protected bool ApiCallsFrequencyCheck(FunctionInfo api, List<ApiCallsFrequency> list) => default; // 0x008B7ED0-0x008B7EE0
		private bool ApiCallsFrequencyCheck(int type) => default; // 0x008B5AA0-0x008B5B30
		protected static void NC_LOG(string str) {} // 0x008B4530-0x008B4540
		protected static void NC_LOG(string format, params /* 0x0065AD40-0x0065AD50 */ object[] arg) {} // 0x008B47D0-0x008B47E0
	}
}
