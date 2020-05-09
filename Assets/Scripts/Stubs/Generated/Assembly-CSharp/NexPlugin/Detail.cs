/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	internal static class Detail // TypeDefIndex: 9181
	{
		// Fields
		public const string DLL_NAME = "__Internal"; // Metadata: 0x00631457
		private static List<NotificationEventCB> s_NotificationEventCB; // 0x00
		private static Dictionary<uint, object> s_NexAsyncCall; // 0x08
		private static uint m_AsyncId; // 0x10
	
		// Nested types
		public struct AsyncResultInt // TypeDefIndex: 9182
		{
			// Fields
			private long pad; // 0x10
			public uint asyncId; // 0x18
			public AsyncResultNum asyncNum; // 0x1C
			public Result nnResult; // 0x20
			public uint netErrCode; // 0x24
			public int returnCode; // 0x28
			public uint errorCode; // 0x2C
			public IntPtr pParam1; // 0x30
			public IntPtr pParam2; // 0x38
	
			// Methods
			public static AsyncResult GetAsyncResult(AsyncResultInt res) => default; // 0x00FA7A80-0x00FA7B10
			public long GetLong(IntPtr pParam) => default; // 0x00FA8B40-0x00FA8C60
			public ulong GetUlong(IntPtr pParam) => default; // 0x00FA8C60-0x00FA8CF0
			public int GetInt(IntPtr pParam) => default; // 0x00FA8CF0-0x00FA8E10
			public uint GetUint(IntPtr pParam) => default; // 0x00FA8E10-0x00FA8EA0
			public void Trace() {} // 0x00FA8EA0-0x00FA9170
			public override string ToString() => default; // 0x00FA9170-0x00FA9180
		}
	
		public struct NotificationEventInt : IExchangeList<NotificationEvent> // TypeDefIndex: 9183
		{
			// Fields
			public ulong param1; // 0x10
			public ulong param2; // 0x18
			public uint type; // 0x20
			public uint subType; // 0x24
			public CppArray stringParam; // 0x28
			public ulong pid; // 0x38
	
			// Methods
			public static NotificationEvent ExchangePtrToStruct(IntPtr src) => default; // 0x00FAF280-0x00FAF3B0
			public NotificationEvent ExchangeStruct() => default; // 0x00FAF3C0-0x00FAF460
		}
	
		public static class Common // TypeDefIndex: 9184
		{
			// Methods
			private static extern bool InitializeNexAsyncInt(uint asyncId, int threadMode); // 0x00FA9180-0x00FA91A0
			public static bool InitializeNexAsync(out uint asyncId, NexPlugin.Common.ThreadMode threadMode, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F916F0-0x00F91800
			private static extern uint DispatchInt(uint dispatchTimeout, uint dispatchFlags); // 0x00FA91A0-0x00FA91B0
			public static uint Dispatch(uint dispatchTimeout, NexPlugin.Common.DispachFlag? dispatchFlags = default) => default; // 0x00F918D0-0x00F91960
			private static extern bool UpdateAsyncResultInt(ref IntPtr pAsyncResult); // 0x00FA91B0-0x00FA9260
			public static bool UpdateAsyncResult() => default; // 0x00F91970-0x00F91AC0
			public static extern void InitAsyncResultByAsyncId(uint asyncId); // 0x00FA8700-0x00FA8710
			public static void Wait(uint dispatchTimeOut, NexPlugin.Common.DispachFlag? dispatchFlags) {} // 0x00F91AD0-0x00F91C20
			private static extern bool GetNotificationEventInt(ref IntPtr pNotificationEvent); // 0x00FA93B0-0x00FA93D0
			public static bool GetNotificationEvent() => default; // 0x00FA9260-0x00FA93B0
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FA8710-0x00FA87A0
		}
	
		public interface IExchangeList<T> // TypeDefIndex: 9185
		{
			// Methods
			T ExchangeStruct();
		}
	
		public struct CppArray // TypeDefIndex: 9186
		{
			// Fields
			public int count; // 0x10
			public IntPtr ptr; // 0x18
	
			// Constructors
			public CppArray(IntPtr src) {
				count = default;
				ptr = default;
			} // 0x00FA93D0-0x00FA9510
	
			// Methods
			public void ToArray<T>(ref T[] list, int size) {}
			public void ToList<T>(ref List<T> list) {}
			public List<T> ToList<T, U>()
				where U : IExchangeList<T> => default;
			public string ToStr() => default; // 0x00FA9510-0x00FA95C0
			public static CppArray StringToArray(List<IntPtr> useptr, string param) => default; // 0x00FA95C0-0x00FA96E0
			public static CppArray StringsToArray(List<IntPtr> useptr, List<string> param) => default; // 0x00FA96E0-0x00FA9810
			public static CppArray ArrayToArray<T>(List<IntPtr> useptr, T[] param) => default;
			public static CppArray ListToArray<T>(List<IntPtr> useptr, List<T> param) => default;
			public static CppArray ListToArray<U, T>(List<IntPtr> useptr, List<T> param) => default;
		}
	
		public static class DataStore // TypeDefIndex: 9187
		{
			// Nested types
			private struct DataStorePersistenceInfoInt : IExchangeList<DataStorePersistenceInfo> // TypeDefIndex: 9188
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong principalId; // 0x18
				private ushort persistenceSlotId; // 0x20
	
				// Constructors
				public DataStorePersistenceInfoInt(DataStorePersistenceInfo param) {
					dataId = default;
					principalId = default;
					persistenceSlotId = default;
				} // 0x00FACCE0-0x00FACD70
	
				// Methods
				public DataStorePersistenceInfo ExchangeStruct() => default; // 0x00FACB80-0x00FACC00
				public static DataStorePersistenceInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FACC00-0x00FACCE0
			}
	
			private struct DataStorePasswordInfoInt : IExchangeList<DataStorePasswordInfo> // TypeDefIndex: 9189
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong accessPassword; // 0x18
				private ulong updatePassword; // 0x20
	
				// Constructors
				public DataStorePasswordInfoInt(DataStorePasswordInfo param) {
					dataId = default;
					accessPassword = default;
					updatePassword = default;
				} // 0x00FAC990-0x00FACA20
	
				// Methods
				public DataStorePasswordInfo ExchangeStruct() => default; // 0x00FAC830-0x00FAC8B0
				public static DataStorePasswordInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FAC8B0-0x00FAC990
			}
	
			private struct DataStorePermissionInt : IExchangeList<DataStorePermission> // TypeDefIndex: 9190
			{
				// Fields
				private CppArray recipientIds; // 0x10
				private uint permission; // 0x20
	
				// Constructors
				public DataStorePermissionInt(List<IntPtr> useptr, DataStorePermission param) {
					recipientIds = default;
					permission = default;
				} // 0x00FACAE0-0x00FACB80
	
				// Methods
				public DataStorePermission ExchangeStruct() => default; // 0x00FACA20-0x00FACAE0
			}
	
			private struct DataStoreMetaInfoInt : IExchangeList<DataStoreMetaInfo> // TypeDefIndex: 9191
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong ownerId; // 0x18
				private uint size; // 0x20
				private ushort dataType; // 0x24
				private ushort period; // 0x26
				private uint status; // 0x28
				private uint referDataId; // 0x2C
				private uint flag; // 0x30
				private DataStorePermissionInt accessPermission; // 0x38
				private DataStorePermissionInt updatePermission; // 0x50
				private CppArray name; // 0x68
				private CppArray meta; // 0x78
				private CppArray tags; // 0x88
				private CppArray ratingInfo; // 0x98
				private NpDateTime createdTime; // 0xA8
				private NpDateTime updatedTime; // 0xB0
				private NpDateTime expireTime; // 0xB8
	
				// Methods
				public static DataStoreMetaInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FAC360-0x00FAC820
				public DataStoreMetaInfo ExchangeStruct() => default; // 0x00FAC820-0x00FAC830
			}
	
			private struct DataStoreSearchResultInt // TypeDefIndex: 9192
			{
				// Fields
				private CppArray result; // 0x10
				private uint totalCount; // 0x20
				private uint totalCountType; // 0x24
	
				// Methods
				public static DataStoreSearchResult ExchangePtrToStruct(IntPtr src) => default; // 0x00FADAE0-0x00FADC50
			}
	
			private struct DataStoreRatingLogInt // TypeDefIndex: 9193
			{
				// Fields
				private NpDateTime lockExpirationTime; // 0x10
				private ulong pid; // 0x18
				private int ratingValue; // 0x20
				private bool isRated; // 0x24
	
				// Methods
				public static DataStoreRatingLog ExchangePtrToStruct(IntPtr src) => default; // 0x00FAD780-0x00FAD8D0
			}
	
			private struct DataStorePersistenceInitParamInt // TypeDefIndex: 9194
			{
				// Fields
				private ushort persistenceSlotId; // 0x10
				private byte deleteLastObject; // 0x12
	
				// Constructors
				public DataStorePersistenceInitParamInt(DataStorePersistenceInitParam param) {
					persistenceSlotId = default;
					deleteLastObject = default;
				} // 0x00FACD70-0x00FACE00
			}
	
			private struct DataStoreRatingInitParamInt // TypeDefIndex: 9195
			{
				// Fields
				private long initialValue; // 0x10
				private int rangeMin; // 0x18
				private int rangeMax; // 0x1C
				private int flag; // 0x20
				private int internalFlag; // 0x24
				private int lockType; // 0x28
				private short periodDuration; // 0x2C
				private sbyte periodHour; // 0x2E
				private sbyte slot; // 0x2F
	
				// Constructors
				public DataStoreRatingInitParamInt(DataStoreRatingInitParam param) {
					initialValue = default;
					rangeMin = default;
					rangeMax = default;
					flag = default;
					internalFlag = default;
					lockType = default;
					periodDuration = default;
					periodHour = default;
					slot = default;
				} // 0x00FAD650-0x00FAD780
			}
	
			private struct DataStorePreparePostParamInt // TypeDefIndex: 9196
			{
				// Fields
				private DataStorePermissionInt accessPermission; // 0x10
				private DataStorePermissionInt updatePermission; // 0x28
				private DataStorePersistenceInitParamInt persistenceInitParam; // 0x40
				private CppArray name; // 0x48
				private CppArray tags; // 0x58
				private CppArray ratingInitParams; // 0x68
				private CppArray meta; // 0x78
				private uint size; // 0x88
				private uint dataFlag; // 0x8C
				private ushort dataType; // 0x90
				private ushort period; // 0x92
	
				// Constructors
				public DataStorePreparePostParamInt(List<IntPtr> useptr, DataStorePreparePostParam param, uint size) {
					accessPermission = default;
					updatePermission = default;
					persistenceInitParam = default;
					name = default;
					tags = default;
					ratingInitParams = default;
					meta = default;
					this.size = default;
					dataFlag = default;
					dataType = default;
					period = default;
				} // 0x00FAD3F0-0x00FAD420
				public DataStorePreparePostParamInt(List<IntPtr> useptr, DataStorePreparePostParam param) {
					accessPermission = default;
					updatePermission = default;
					persistenceInitParam = default;
					name = default;
					tags = default;
					ratingInitParams = default;
					meta = default;
					size = default;
					dataFlag = default;
					dataType = default;
					period = default;
				} // 0x00FAD420-0x00FAD4C0
			}
	
			private struct ResultRangeInt // TypeDefIndex: 9197
			{
				// Fields
				private uint offset; // 0x10
				private uint size; // 0x14
	
				// Constructors
				public ResultRangeInt(ResultRange param) {
					offset = default;
					size = default;
				} // 0x00FADD10-0x00FADDA0
			}
	
			private struct DataStoreSearchParamInt // TypeDefIndex: 9198
			{
				// Fields
				private uint searchType; // 0x10
				private uint ownerType; // 0x14
				private CppArray ownerIds; // 0x18
				private CppArray destinationIds; // 0x28
				private NpDateTime createdAfter; // 0x38
				private NpDateTime createdBefore; // 0x40
				private NpDateTime updatedAfter; // 0x48
				private NpDateTime updatedBefore; // 0x50
				private uint sortOrderColumn; // 0x58
				private uint sortOrder; // 0x5C
				private ResultRangeInt resultRange; // 0x60
				private CppArray tags; // 0x68
				private uint resultOption; // 0x78
				private uint minimalRatingFrequency; // 0x7C
				private int totalCountEnabled; // 0x80
				private int useCache; // 0x84
				private CppArray dataTypes; // 0x88
	
				// Constructors
				public DataStoreSearchParamInt(List<IntPtr> useptr, DataStoreSearchParam param) {
					searchType = default;
					ownerType = default;
					ownerIds = default;
					destinationIds = default;
					createdAfter = default;
					createdBefore = default;
					updatedAfter = default;
					updatedBefore = default;
					sortOrderColumn = default;
					sortOrder = default;
					resultRange = default;
					tags = default;
					resultOption = default;
					minimalRatingFrequency = default;
					totalCountEnabled = default;
					useCache = default;
					dataTypes = default;
				} // 0x00FADAD0-0x00FADAE0
			}
	
			private struct DataStoreDeleteParamInt // TypeDefIndex: 9199
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong updatePassword; // 0x18
	
				// Constructors
				public DataStoreDeleteParamInt(DataStoreDeleteParam param) {
					dataId = default;
					updatePassword = default;
				} // 0x00FAC1E0-0x00FAC350
			}
	
			private struct DataStorePrepareUpdateParamInt // TypeDefIndex: 9200
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong updatePassword; // 0x18
				private uint size; // 0x20
	
				// Constructors
				public DataStorePrepareUpdateParamInt(DataStorePrepareUpdateParam param) {
					dataId = default;
					updatePassword = default;
					size = default;
				} // 0x00FAD4C0-0x00FAD5D0
			}
	
			private struct DataStorePersistenceTargetInt // TypeDefIndex: 9201
			{
				// Fields
				private ulong ownerId; // 0x10
				private ushort persistenceSlotId; // 0x18
	
				// Constructors
				public DataStorePersistenceTargetInt(DataStorePersistenceTarget param) {
					ownerId = default;
					persistenceSlotId = default;
				} // 0x00FACE00-0x00FACF80
			}
	
			private struct DataStorePrepareGetParamInt // TypeDefIndex: 9202
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong accessPassword; // 0x18
				private DataStorePersistenceTargetInt persistenceTarget; // 0x20
				private int useDataId; // 0x30
	
				// Constructors
				public DataStorePrepareGetParamInt(DataStorePrepareGetParam param) {
					dataId = default;
					accessPassword = default;
					persistenceTarget = default;
					useDataId = default;
				} // 0x00FACF80-0x00FAD3F0
			}
	
			private struct DataStoreTouchObjectParamInt // TypeDefIndex: 9203
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong accessPassword; // 0x18
	
				// Constructors
				public DataStoreTouchObjectParamInt(DataStoreTouchObjectParam param) {
					dataId = default;
					accessPassword = default;
				} // 0x00FADC50-0x00FADCD0
			}
	
			private struct DataStoreGetMetaParamInt // TypeDefIndex: 9204
			{
				// Fields
				private ulong dataId; // 0x10
				private ulong accessPassword; // 0x18
				private DataStorePersistenceTargetInt persistenceTarget; // 0x20
				private uint resultOption; // 0x30
				private int useDataId; // 0x34
	
				// Constructors
				public DataStoreGetMetaParamInt(DataStoreGetMetaParam param) {
					dataId = default;
					accessPassword = default;
					persistenceTarget = default;
					resultOption = default;
					useDataId = default;
				} // 0x00FAC350-0x00FAC360
			}
	
			private struct DataStoreChangeMetaCompareParamInt // TypeDefIndex: 9205
			{
				// Fields
				private DataStorePermissionInt accessPermission; // 0x10
				private DataStorePermissionInt updatePermission; // 0x28
				private CppArray name; // 0x40
				private CppArray tags; // 0x50
				private CppArray metaBinary; // 0x60
				private uint comparisonFlag; // 0x70
				private uint status; // 0x74
				private ushort dataType; // 0x78
				private ushort period; // 0x7A
	
				// Constructors
				public DataStoreChangeMetaCompareParamInt(List<IntPtr> useptr, DataStoreChangeMetaCompareParam param) {
					accessPermission = default;
					updatePermission = default;
					name = default;
					tags = default;
					metaBinary = default;
					comparisonFlag = default;
					status = default;
					dataType = default;
					period = default;
				} // 0x00FABEB0-0x00FAC150
			}
	
			private struct DataStoreChangeMetaParamInt // TypeDefIndex: 9206
			{
				// Fields
				private DataStorePermissionInt accessPermission; // 0x10
				private DataStorePermissionInt updatePermission; // 0x28
				private CppArray name; // 0x40
				private CppArray tags; // 0x50
				private CppArray metaBinary; // 0x60
				private DataStoreChangeMetaCompareParamInt compareParam; // 0x70
				private ulong dataId; // 0xE0
				private ulong updatePassword; // 0xE8
				private uint modifiesFlag; // 0xF0
				private uint dataStatus; // 0xF4
				private DataStorePersistenceTargetInt persistenceTarget; // 0xF8
				private ushort dataType; // 0x108
				private ushort period; // 0x10A
	
				// Constructors
				public DataStoreChangeMetaParamInt(List<IntPtr> useptr, DataStoreChangeMetaParam param) {
					accessPermission = default;
					updatePermission = default;
					name = default;
					tags = default;
					metaBinary = default;
					compareParam = default;
					dataId = default;
					updatePassword = default;
					modifiesFlag = default;
					dataStatus = default;
					persistenceTarget = default;
					dataType = default;
					period = default;
				} // 0x00FAC150-0x00FAC1E0
			}
	
			private struct DataStoreRatingTargetInt // TypeDefIndex: 9207
			{
				// Fields
				private ulong dataId; // 0x10
				private sbyte slot; // 0x18
	
				// Constructors
				public DataStoreRatingTargetInt(DataStoreRatingTarget param) {
					dataId = default;
					slot = default;
				} // 0x00FAD8D0-0x00FADAD0
			}
	
			private struct DataStoreRateObjectParamInt // TypeDefIndex: 9208
			{
				// Fields
				private ulong accessPassword; // 0x10
				private int ratingValue; // 0x18
	
				// Constructors
				public DataStoreRateObjectParamInt(DataStoreRateObjectParam param) {
					accessPassword = default;
					ratingValue = default;
				} // 0x00FAD5D0-0x00FAD650
			}
	
			// Methods
			private static List<Dictionary<sbyte, DataStoreRatingInfo>> DataStore_ExchangeRatingInfosList(IntPtr src) => default; // 0x00FA9810-0x00FA9C30
			private static extern bool DataStore_PostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePreparePostParamInt pParam, IntPtr pUpBuf, int timeOut); // 0x00FA9C30-0x00FA9C50
			public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0 /* Metadata: 0x00631465 */, NexPlugin.DataStore.PostCB callback = null)
				where T : struct {
				asyncId = default;
				return default;
			}
			private static extern bool DataStore_PostMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePreparePostParamInt pParam, int timeOut); // 0x00FA9C50-0x00FA9C70
			public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0 /* Metadata: 0x00631469 */, NexPlugin.DataStore.PostCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F91E20-0x00F92080
			private static extern bool DataStore_PostMetaAsyncByDataID(uint asyncId, IntPtr pNgsFacade, ulong dataId, ref DataStorePreparePostParamInt pParam, int timeOut); // 0x00FA9C70-0x00FA9C90
			public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0 /* Metadata: 0x0063146D */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F92090-0x00F92300
			private static extern bool DataStore_PostMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref CppArray dataIds, ref CppArray param, int transactional, int timeOut); // 0x00FA9C90-0x00FA9CB0
			public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<ulong> dataIds, List<DataStorePreparePostParam> param, bool transactional = true /* Metadata: 0x00631471 */, int timeOut = 0 /* Metadata: 0x00631472 */, NexPlugin.DataStore.ResultListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F92420-0x00F926B0
			private static extern bool DataStore_CompleteSuspendedPostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut); // 0x00FA9CB0-0x00FA9CD0
			public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x00631476 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F927A0-0x00F929F0
			private static extern bool DataStore_SearchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreSearchParamInt pParam, int timeOut); // 0x00FA9CD0-0x00FA9CF0
			public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0 /* Metadata: 0x0063147A */, NexPlugin.DataStore.SearchObjectCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F92A00-0x00F92C60
			private static extern bool DataStore_SearchObjectLightAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreSearchParamInt pParam, int timeOut); // 0x00FA9CF0-0x00FA9D10
			public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0 /* Metadata: 0x0063147E */, NexPlugin.DataStore.SearchObjectCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F92C70-0x00F92ED0
			private static extern bool DataStore_DeleteObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreDeleteParamInt pParam, int timeOut); // 0x00FA9D10-0x00FA9D30
			public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0 /* Metadata: 0x00631482 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F92EE0-0x00F93020
			private static extern bool DataStore_DeleteObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray param, int transactional, int timeOut); // 0x00FA9D30-0x00FA9D50
			public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = true /* Metadata: 0x00631486 */, int timeOut = 0 /* Metadata: 0x00631487 */, NexPlugin.DataStore.ResultListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F93100-0x00F93360
			private static extern bool DataStore_UpdateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePrepareUpdateParamInt pParam, IntPtr pUpBuf, int timeOut); // 0x00FA9D50-0x00FA9D70
			public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0 /* Metadata: 0x0063148B */, AsyncResultCB callback = null)
				where T : struct {
				asyncId = default;
				return default;
			}
			private static extern bool DataStore_GetObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePrepareGetParamInt pParam, ulong getBufSize, int timeOut); // 0x00FA9D70-0x00FA9D90
			public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0 /* Metadata: 0x0063148F */, NexPlugin.DataStore.GetObjectCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F93560-0x00F936C0
			private static extern bool DataStore_TouchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreTouchObjectParamInt param, int timeOut); // 0x00FA9D90-0x00FA9DB0
			public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0 /* Metadata: 0x00631493 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F936D0-0x00F93810
			private static extern bool DataStore_GetMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreGetMetaParamInt pParam, int timeOut); // 0x00FA9DB0-0x00FA9DD0
			public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0 /* Metadata: 0x00631497 */, NexPlugin.DataStore.GetMetaCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F93820-0x00F93970
			private static extern bool DataStore_GetMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref CppArray dataIds, ref CppArray param, int timeOut); // 0x00FA9DD0-0x00FA9DF0
			public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreGetMetaParam> param, int timeOut = 0 /* Metadata: 0x0063149B */, NexPlugin.DataStore.GetMetaListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F93A40-0x00F93CC0
			private static extern bool DataStore_ChangeMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreChangeMetaParamInt pParam, int timeOut); // 0x00FA9DF0-0x00FA9E10
			public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0 /* Metadata: 0x0063149F */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F93D70-0x00F93FF0
			private static extern bool DataStore_ChangeMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref CppArray dataIds, ref CppArray param, int transactional, int timeOut); // 0x00FA9E10-0x00FA9E30
			public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreChangeMetaParam> param, bool transactional = true /* Metadata: 0x006314A3 */, int timeOut = 0 /* Metadata: 0x006314A4 */, NexPlugin.DataStore.ResultListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F940D0-0x00F94360
			private static extern bool DataStore_RateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt pTarget, ref DataStoreRateObjectParamInt pRateParam, int timeOut); // 0x00FA9E30-0x00FA9E50
			public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0 /* Metadata: 0x006314A8 */, NexPlugin.DataStore.RatingInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F94430-0x00F94590
			private static extern bool DataStore_RateObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneObjectParam, ref CppArray target, ref CppArray param, int transactional, int timeOut); // 0x00FA9E50-0x00FA9E70
			public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneObjectParam, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = true /* Metadata: 0x006314AC */, int timeOut = 0 /* Metadata: 0x006314AD */, NexPlugin.DataStore.RatingInfoListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F94670-0x00F94900
			private static extern bool DataStore_RateObjectWithPostingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt pParam, ref DataStoreRateObjectParamInt pObject, ref DataStorePreparePostParamInt pPostParam, int timeOut); // 0x00FA9E70-0x00FA9E90
			public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget pParam, DataStoreRateObjectParam pObject, DataStorePreparePostParam pPostParam, int timeOut = 0 /* Metadata: 0x006314B1 */, NexPlugin.DataStore.RatingInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F94950-0x00F94BF0
			private static extern bool DataStore_RateObjectsWithPostingAsync(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref CppArray pParam, ref CppArray pObject, ref CppArray pPostParam, int transactional, int timeOut); // 0x00FA9E90-0x00FA9EB0
			public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<DataStoreRatingTarget> pParam, List<DataStoreRateObjectParam> pObject, List<DataStorePreparePostParam> pPostParam, bool transactional, int timeOut = 0 /* Metadata: 0x006314B5 */, NexPlugin.DataStore.RatingInfoListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F94C40-0x00F94F60
			private static extern bool DataStore_GetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut); // 0x00FA9EB0-0x00FA9ED0
			public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0 /* Metadata: 0x006314B9 */, NexPlugin.DataStore.RatingInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F950A0-0x00F951F0
			private static extern bool DataStore_GetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut); // 0x00FA9ED0-0x00FA9EF0
			public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x006314BD */, NexPlugin.DataStore.RatingInfoAllSlotCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95200-0x00F95320
			private static extern bool DataStore_GetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray dataIds, int timeOut); // 0x00FA9EF0-0x00FA9F10
			public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x006314C1 */, NexPlugin.DataStore.RatingInfosListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95330-0x00F95580
			private static extern bool DataStore_GetRatingWithLogAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut); // 0x00FA9F10-0x00FA9F30
			public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0 /* Metadata: 0x006314C5 */, NexPlugin.DataStore.RatingInfoWithLogCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95590-0x00F956E0
			private static extern bool DataStore_ResetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut); // 0x00FA9F30-0x00FA9F50
			public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0 /* Metadata: 0x006314C9 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F956F0-0x00F95840
			private static extern bool DataStore_ResetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut); // 0x00FA9F50-0x00FA9F70
			public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x006314CD */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95850-0x00F95970
			private static extern bool DataStore_ResetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray dataIds, int transactional, int timeOut); // 0x00FA9F70-0x00FA9F90
			public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true /* Metadata: 0x006314D1 */, int timeOut = 0 /* Metadata: 0x006314D2 */, NexPlugin.DataStore.ResultListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95980-0x00F95BE0
			private static extern bool DataStore_GetPersistenceInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort slotId, int timeOut); // 0x00FA9F90-0x00FA9FB0
			public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0 /* Metadata: 0x006314D6 */, NexPlugin.DataStore.GetPersistenceInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95BF0-0x00F95D20
			private static extern bool DataStore_GetPersistenceInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ulong principalId, ref CppArray persistenceSlotIds, int timeOut); // 0x00FA9FB0-0x00FA9FD0
			public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0 /* Metadata: 0x006314DA */, NexPlugin.DataStore.GetPersistenceInfoListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95D30-0x00F95F90
			private static extern bool DataStore_PerpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, ulong dataId, int deleteFlag, int timeOut); // 0x00FA9FD0-0x00FA9FF0
			public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = true /* Metadata: 0x006314DE */, int timeOut = 0 /* Metadata: 0x006314DF */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F95FA0-0x00F960E0
			private static extern bool DataStore_UnperpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, int deleteFlag, int timeOut); // 0x00FA9FF0-0x00FAA010
			public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = false /* Metadata: 0x006314E3 */, int timeOut = 0 /* Metadata: 0x006314E4 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F960F0-0x00F96220
			private static extern bool DataStore_GetPasswordInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut); // 0x00FAA010-0x00FAA030
			public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x006314E8 */, NexPlugin.DataStore.GetPasswordInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F96230-0x00F96350
			private static extern bool DataStore_GetPasswordInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut); // 0x00FAA030-0x00FAA050
			public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x006314EC */, NexPlugin.DataStore.GetPasswordInfoListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00F96360-0x00F965B0
			private static void DataStore_PostResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA050-0x00FAA1C0
			private static void DataStore_ResultListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA1C0-0x00FAA370
			private static void DataStore_SearchObjectResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA370-0x00FAA510
			private static void DataStore_GetObjectResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA510-0x00FAA700
			private static void DataStore_GetMetaResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA700-0x00FAA840
			private static void DataStore_GetMetaByDataListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAA840-0x00FAAAB0
			private static void DataStore_RatingInfoResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAAAB0-0x00FAAC30
			private static void DataStore_RatingInfoAllSlotResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAAC30-0x00FAAF50
			private static void DataStore_RatingInfoListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAAF50-0x00FAB1B0
			private static void DataStore_RatingInfosListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAB1B0-0x00FAB3B0
			private static void DataStore_RatingInfoWithLogResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAB3B0-0x00FAB580
			private static void DataStore_GetPersistenceInfoResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAB580-0x00FAB6D0
			private static void DataStore_GetPersistenceInfoListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAB6D0-0x00FAB940
			private static void DataStore_GetPasswordInfoResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAB940-0x00FABA90
			private static void DataStore_GetPasswordInfoListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FABA90-0x00FABEB0
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FA87A0-0x00FA89B0
		}
	
		public static class NgsFacade // TypeDefIndex: 9209
		{
			// Methods
			private static extern bool Ngs_LoginAsync(uint asyncId, uint gameServerId, ref CppArray accessKey, ulong nsaId, ref CppArray nsaIdToken, int timeOut); // 0x00FADDA0-0x00FADDC0
			public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000 /* Metadata: 0x006314F0 */, NexPlugin.NgsFacade.LoginCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FADDC0-0x00FAE010
			private static extern bool Ngs_LogoutAsync(uint asyncId, IntPtr pNgsFacade); // 0x00FAE0E0-0x00FAE100
			public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAE100-0x00FAE1C0
			private static extern bool Ngs_TestConnectivityAsync(uint asyncId, IntPtr pNgsFacade); // 0x00FAE1C0-0x00FAE1E0
			public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, NexPlugin.NgsFacade.TestConnectivityCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAE1E0-0x00FAE2A0
			private static void NGSLoginResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAE2A0-0x00FAE360
			private static void TestConnectivityResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FAE9E0-0x00FAEA90
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FAF0C0-0x00FAF280
		}
	
		public static class Ranking // TypeDefIndex: 9210
		{
			// Nested types
			private struct RankingRankDataInt : IExchangeList<RankingRankData> // TypeDefIndex: 9211
			{
				// Fields
				private ulong uniqueId; // 0x10
				private uint category; // 0x18
				private uint score; // 0x1C
				private ulong param; // 0x20
				private NpDateTime updateTime; // 0x28
				private CppArray commonData; // 0x30
				private ulong principalId; // 0x40
				private uint order; // 0x48
				private byte group0; // 0x4C
				private byte group1; // 0x4D
	
				// Constructors
				public RankingRankDataInt(List<IntPtr> useptr, RankingRankData param) {
					uniqueId = default;
					category = default;
					score = default;
					this.param = default;
					updateTime = default;
					commonData = default;
					principalId = default;
					order = default;
					group0 = default;
					group1 = default;
				} // 0x00FB4EF0-0x00FB4F00
	
				// Methods
				public RankingRankData ExchangeStruct() => default; // 0x00FB4E10-0x00FB4EF0
			}
	
			private struct RankingResultInt : IExchangeList<RankingResult> // TypeDefIndex: 9212
			{
				// Fields
				private CppArray rankDataList; // 0x10
				private NpDateTime sinceTime; // 0x20
				private uint totalCount; // 0x28
	
				// Constructors
				public RankingResultInt(List<IntPtr> useptr, RankingResult param) {
					rankDataList = default;
					sinceTime = default;
					totalCount = default;
				} // 0x00FB4F10-0x00FB4F20
	
				// Methods
				public static RankingResult ExchangePtrToStruct(IntPtr src) => default; // 0x00FB1D80-0x00FB1E30
				public RankingResult ExchangeStruct() => default; // 0x00FB4F00-0x00FB4F10
			}
	
			private struct RankingCachedResultInt : IExchangeList<RankingCachedResult> // TypeDefIndex: 9213
			{
				// Fields
				public NpDateTime createdTime; // 0x10
				public NpDateTime expiredTime; // 0x18
				public RankingResultInt rankingResult; // 0x20
				public uint maxLength; // 0x40
	
				// Constructors
				public RankingCachedResultInt(List<IntPtr> useptr, RankingCachedResult param) {
					createdTime = default;
					expiredTime = default;
					rankingResult = default;
					maxLength = default;
				} // 0x00FB4A10-0x00FB4AD0
	
				// Methods
				public static RankingCachedResult ExchangePtrToStruct(IntPtr src) => default; // 0x00FB1230-0x00FB1370
				public RankingCachedResult ExchangeStruct() => default; // 0x00FB47B0-0x00FB4A10
			}
	
			private struct RankingScoreDataInt // TypeDefIndex: 9214
			{
				// Fields
				private ulong param; // 0x10
				private uint category; // 0x18
				private uint score; // 0x1C
				private byte orderBy; // 0x20
				private byte updateMode; // 0x21
				private byte group0; // 0x22
				private byte group1; // 0x23
	
				// Constructors
				public RankingScoreDataInt(RankingScoreData param) {
					this.param = default;
					category = default;
					score = default;
					orderBy = default;
					updateMode = default;
					group0 = default;
					group1 = default;
				} // 0x00FB4F60-0x00FB5020
			}
	
			private struct RankingOrderParamInt // TypeDefIndex: 9215
			{
				// Fields
				private byte orderCalc; // 0x10
				private byte groupIndex; // 0x11
				private byte groupNum; // 0x12
				private byte timeScope; // 0x13
				private uint offset; // 0x14
				private byte length; // 0x18
	
				// Constructors
				public RankingOrderParamInt(RankingOrderParam param) {
					orderCalc = default;
					groupIndex = default;
					groupNum = default;
					timeScope = default;
					offset = default;
					length = default;
				} // 0x00FB4BA0-0x00FB4D50
			}
	
			private struct RankingChangeAttributesParamInt // TypeDefIndex: 9216
			{
				// Fields
				private ulong param; // 0x10
				private byte modificationFlag; // 0x18
				private byte group0; // 0x19
				private byte group1; // 0x1A
	
				// Constructors
				public RankingChangeAttributesParamInt(RankingChangeAttributesParam param) {
					this.param = default;
					modificationFlag = default;
					group0 = default;
					group1 = default;
				} // 0x00FB4B00-0x00FB4BA0
			}
	
			// Methods
			private static extern bool Ranking_UploadCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray commonData, ulong nexUniqueId, int timeOut); // 0x00FAF460-0x00FAF480
			public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x006314F4 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAF480-0x00FAF680
			private static extern bool Ranking_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut); // 0x00FAF680-0x00FAF6A0
			public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x006314F8 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAF6A0-0x00FAF780
			private static extern bool Ranking_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut); // 0x00FAF780-0x00FAF7A0
			public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x006314FC */, NexPlugin.Ranking.GetCommonDataCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAF7A0-0x00FAF880
			private static extern bool Ranking_UploadScoreAsync(uint asyncId, IntPtr pNgsFacade, ref RankingScoreDataInt scoreData, ulong nexUniqueId, int timeOut); // 0x00FAF880-0x00FAF8A0
			public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631500 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAF8A0-0x00FAFA30
			private static extern bool Ranking_DeleteScoreAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ulong nexUniqueId, int timeOut); // 0x00FAFA30-0x00FAFA50
			public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631504 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAFA50-0x00FAFB40
			private static extern bool Ranking_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, ulong principalId, int timeOut); // 0x00FAFB40-0x00FAFB60
			public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, ulong principalId, int timeOut = 0 /* Metadata: 0x00631508 */, NexPlugin.Ranking.GetRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAFB60-0x00FAFD20
			private static extern bool Ranking_GetRankingByPIDListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray principalIdList, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut); // 0x00FAFD20-0x00FAFD40
			public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x0063150C */, NexPlugin.Ranking.GetRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FAFD40-0x00FB0000
			private static extern bool Ranking_GetRankingByUIDListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray nexUniqueIdList, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut); // 0x00FB0000-0x00FB0020
			public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631510 */, NexPlugin.Ranking.GetRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB0020-0x00FB02E0
			private static extern bool Ranking_GetApproxOrderAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut); // 0x00FB02E0-0x00FB0300
			public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut = 0 /* Metadata: 0x00631514 */, NexPlugin.Ranking.GetApproxOrderCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB0300-0x00FB04C0
			private static extern bool Ranking_GetStatsAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, uint flags, int timeOut); // 0x00FB04C0-0x00FB04E0
			public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, NexPlugin.Ranking.StatsFlag flags, int timeOut = 0 /* Metadata: 0x00631518 */, NexPlugin.Ranking.GetStatsCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB04E0-0x00FB0690
			private static extern bool Ranking_ChangeAttributesAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ref RankingChangeAttributesParamInt changeParam, ulong nexUniqueId, int timeOut); // 0x00FB0690-0x00FB06B0
			public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x0063151C */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB06B0-0x00FB0840
			private static extern bool Ranking_GetCachedTopXRankingAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, int timeOut); // 0x00FB0840-0x00FB0860
			public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0 /* Metadata: 0x00631520 */, NexPlugin.Ranking.GetCachedTopXRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB0860-0x00FB0A00
			private static extern bool Ranking_GetCachedTopXRankingsAsync(uint asyncId, IntPtr pNgsFacade, int useOneRankingOrderParam, ref CppArray categories, ref CppArray orderParams, int timeOut); // 0x00FB0A00-0x00FB0A20
			public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneRankingOrderParam, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0 /* Metadata: 0x00631524 */, NexPlugin.Ranking.GetCachedTopXRankingsCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB0A20-0x00FB0CE0
			private static extern RankingCachedResult.LocalUpdateState Ranking_LocalUpdate(ref IntPtr pNewResult, ref RankingCachedResultInt cachedResult, ref RankingOrderParamInt orderParam, ref RankingScoreDataInt scoreData, ulong pid, ulong nexUniqueId, ref NpDateTime utcCurrentTime, ref CppArray pCommonData); // 0x00FB0D20-0x00FB0D30
			public static RankingCachedResult.LocalUpdateState LocalUpdate(out RankingCachedResult newResult, RankingCachedResult result, RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId, NpDateTime utcCurrentTime, List<byte> pCommonData) {
				newResult = default;
				return default;
			} // 0x00FB0D30-0x00FB1120
			private static extern void Ranking_DeleteCachedResult(IntPtr cachedResult); // 0x00FB1370-0x00FB1380
			private static void Ranking_GetCommonDataResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB1380-0x00FB14B0
			private static void Ranking_GetRankingResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB1AE0-0x00FB1CD0
			private static void Ranking_GetApproxOrderResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB2460-0x00FB2520
			private static void Ranking_GetStatsResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB2B50-0x00FB2CA0
			private static void Ranking_GetCachedTopXRankingResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB3660-0x00FB3740
			private static void Ranking_GetCachedTopXRankingsResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB3D70-0x00FB3E90
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FB44C0-0x00FB47B0
		}
	
		public static class Ranking2 // TypeDefIndex: 9217
		{
			// Nested types
			private struct Ranking2CommonDataInt // TypeDefIndex: 9218
			{
				// Fields
				public CppArray binaryData; // 0x10
				public CppArray userName; // 0x20
	
				// Constructors
				public Ranking2CommonDataInt(List<IntPtr> useptr, Ranking2CommonData param) {
					binaryData = default;
					userName = default;
				} // 0x00FB9BE0-0x00FB9BF0
	
				// Methods
				public static Ranking2CommonData ExchangePtrToStruct(IntPtr src) => default; // 0x00FB6660-0x00FB6710
				public Ranking2CommonData ExchangeStruct() => default; // 0x00FB9BD0-0x00FB9BE0
			}
	
			private struct Ranking2RankDataInt : IExchangeList<Ranking2RankData> // TypeDefIndex: 9219
			{
				// Fields
				private Ranking2CommonDataInt commonData; // 0x10
				private ulong misc; // 0x30
				private ulong nexUniqueId; // 0x38
				private uint rank; // 0x40
				private uint score; // 0x44
				private ulong principalId; // 0x48
	
				// Methods
				public Ranking2RankData ExchangeStruct() => default; // 0x00FB9EC0-0x00FB9F60
			}
	
			private struct Ranking2InfoInt // TypeDefIndex: 9220
			{
				// Fields
				private CppArray ranking2RankDataList; // 0x10
				private uint numRankedIn; // 0x20
				private uint lowestRank; // 0x24
				private int season; // 0x28
	
				// Methods
				public static Ranking2Info ExchangePtrToStruct(IntPtr src) => default; // 0x00FB6F00-0x00FB7050
			}
	
			private struct Ranking2CategorySettingInt // TypeDefIndex: 9221
			{
				// Fields
				private uint minScore; // 0x10
				private uint maxScore; // 0x14
				private ushort lowestRank; // 0x18
				private byte maxSeasonsToGoBack; // 0x1A
				private byte resetMode; // 0x1B
				private byte resetHour; // 0x1C
				private byte resetDay; // 0x1D
				private ushort resetMonth; // 0x1E
				private byte scoreorder; // 0x20
	
				// Methods
				public static Ranking2CategorySetting ExchangePtrToStruct(IntPtr src) => default; // 0x00FB7780-0x00FB7870
			}
	
			private struct Ranking2ChartInfoInt : IExchangeList<Ranking2ChartInfo> // TypeDefIndex: 9222
			{
				// Fields
				private uint index; // 0x10
				private uint category; // 0x14
				private uint season; // 0x18
				private uint samplingRate; // 0x1C
				private uint scoreOrder; // 0x20
				private uint estimateLength; // 0x24
				private uint estimateHighestScore; // 0x28
				private uint estimateLowestScore; // 0x2C
				private uint estimateMedianScore; // 0x30
				private uint highestBinsScore; // 0x34
				private uint lowestBinsScore; // 0x38
				private uint binsWidth; // 0x3C
				private uint attribute1; // 0x40
				private uint attribute2; // 0x44
				private NpDateTime createTime; // 0x48
				private double estimateAverageScore; // 0x50
				private CppArray quantities; // 0x58
				private byte binsSize; // 0x68
	
				// Methods
				public static Ranking2ChartInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FB8080-0x00FB8180
				public Ranking2ChartInfo ExchangeStruct() => default; // 0x00FB9AB0-0x00FB9BD0
			}
	
			private struct Ranking2ScoreDataInt // TypeDefIndex: 9223
			{
				// Fields
				private uint category; // 0x10
				private uint score; // 0x14
				private ulong misc; // 0x18
	
				// Constructors
				public Ranking2ScoreDataInt(Ranking2ScoreData param) {
					category = default;
					score = default;
					misc = default;
				} // 0x00FB9F60-0x00FB9FF0
			}
	
			private struct Ranking2GetParamInt // TypeDefIndex: 9224
			{
				// Fields
				private ulong nexUniqueId; // 0x10
				private ulong principalId; // 0x18
				private uint category; // 0x20
				private uint offset; // 0x24
				private uint length; // 0x28
				private uint optionFlags; // 0x2C
				private uint sortFlags; // 0x30
				private byte mode; // 0x34
				private byte numSeasonsToGoBack; // 0x35
	
				// Constructors
				public Ranking2GetParamInt(List<IntPtr> useptr, Ranking2GetParam param) {
					nexUniqueId = default;
					principalId = default;
					category = default;
					offset = default;
					length = default;
					optionFlags = default;
					sortFlags = default;
					mode = default;
					numSeasonsToGoBack = default;
				} // 0x00FB9D20-0x00FB9DF0
			}
	
			private struct Ranking2GetByListParamInt // TypeDefIndex: 9225
			{
				// Fields
				private uint category; // 0x10
				private uint offset; // 0x14
				private uint length; // 0x18
				private uint optionFlags; // 0x1C
				private uint sortFlags; // 0x20
				private byte numSeasonsToGoBack; // 0x24
	
				// Constructors
				public Ranking2GetByListParamInt(List<IntPtr> useptr, Ranking2GetByListParam param) {
					category = default;
					offset = default;
					length = default;
					optionFlags = default;
					sortFlags = default;
					numSeasonsToGoBack = default;
				} // 0x00FB9C30-0x00FB9CE0
			}
	
			// Methods
			private static extern bool Ranking2_PutScoreAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2ScoreDataInt pParam, ulong nexUniqueId, int timeOut); // 0x00FB5020-0x00FB5040
			public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631528 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB5040-0x00FB51B0
			private static extern bool Ranking2_PutScoreListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, ulong nexUniqueId, int timeOut); // 0x00FB51B0-0x00FB51D0
			public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x0063152C */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB51D0-0x00FB5440
			private static extern bool Ranking2_PutCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2CommonDataInt commonData, ulong nexUniqueId, int timeOut); // 0x00FB5470-0x00FB5490
			public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631530 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB5490-0x00FB5790
			private static extern bool Ranking2_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, uint optionFlags, ulong principalId, ulong nexUniqueId, int timeOut); // 0x00FB5790-0x00FB57B0
			public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags, ulong principalId, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631534 */, NexPlugin.Ranking2.GetCommonDataCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB57B0-0x00FB58A0
			private static extern bool Ranking2_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut); // 0x00FB58A0-0x00FB58C0
			public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0 /* Metadata: 0x00631538 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB58C0-0x00FB59A0
			private static extern bool Ranking2_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2GetParamInt getParam, int timeOut); // 0x00FB59A0-0x00FB59C0
			public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0 /* Metadata: 0x0063153C */, NexPlugin.Ranking2.GetRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB59C0-0x00FB5C50
			private static extern bool Ranking2_GetRankingByListAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2GetByListParamInt getParam, ref CppArray principalIdList, int timeOut); // 0x00FB5C50-0x00FB5C70
			public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0 /* Metadata: 0x00631540 */, NexPlugin.Ranking2.GetRankingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB5C70-0x00FB5F10
			private static extern bool Ranking2_GetCategorySettingAsync(uint asyncId, IntPtr pNgsFacade, uint category, int timeOut); // 0x00FB5F10-0x00FB5F30
			public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0 /* Metadata: 0x00631544 */, NexPlugin.Ranking2.GetCategorySettingCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB5F30-0x00FB6010
			private static extern bool Ranking2_GetRankingChartAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2ChartInfoInput info, int timeOut); // 0x00FB6010-0x00FB6030
			public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0 /* Metadata: 0x00631548 */, NexPlugin.Ranking2.GetRanking2ChartInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB6030-0x00FB6110
			private static extern bool Ranking2_GetRankingChartsAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray info, int timeOut); // 0x00FB6110-0x00FB6130
			public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0 /* Metadata: 0x0063154C */, NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB6130-0x00FB6320
			private static extern bool Ranking2_GetEstimateScoreRankAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2EstimateScoreRankInput info, int timeOut); // 0x00FB6320-0x00FB6340
			public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0 /* Metadata: 0x00631550 */, NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FB6340-0x00FB6420
			private static void Ranking2_GetCommonDataResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB6420-0x00FB65E0
			private static void Ranking2_GetRankingResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB6D40-0x00FB6E80
			private static void Ranking2_GetCategorySettingResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB7680-0x00FB7770
			private static void Ranking2_GetRanking2ChartInfoResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB7EA0-0x00FB8070
			private static void Ranking2_GetRanking2ChartInfoListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB87B0-0x00FB88D0
			private static void Ranking2_GetRanking2EstimateScoreRankResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FB8F00-0x00FB9030
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FB9860-0x00FB9AB0
		}
	
		public static class Subscriber // TypeDefIndex: 9226
		{
			// Nested types
			private struct SubscriberContentInt : IExchangeList<SubscriberContent> // TypeDefIndex: 9227
			{
				// Fields
				private ulong contentId; // 0x10
				private NpDateTime postTime; // 0x18
				private CppArray topics; // 0x20
				private CppArray binary; // 0x30
				private CppArray message; // 0x40
				private ulong pid; // 0x50
	
				// Methods
				public SubscriberContent ExchangeStruct() => default; // 0x00FBD880-0x00FBD890
			}
	
			private struct SubscriberPostContentParamInt // TypeDefIndex: 9228
			{
				// Fields
				private CppArray topics; // 0x10
				private CppArray contentBinary; // 0x20
				private CppArray contentMessage; // 0x30
	
				// Constructors
				public SubscriberPostContentParamInt(List<IntPtr> useptr, SubscriberPostContentParam param) {
					topics = default;
					contentBinary = default;
					contentMessage = default;
				} // 0x00FBD960-0x00FBD970
			}
	
			public struct SubscriberGetContentParamInt // TypeDefIndex: 9229
			{
				// Fields
				private uint size; // 0x10
				private uint offset; // 0x14
				private ulong minimumContentId; // 0x18
				private uint topic; // 0x20
	
				// Constructors
				public SubscriberGetContentParamInt(SubscriberGetContentParam param) {
					size = default;
					offset = default;
					minimumContentId = default;
					topic = default;
				} // 0x00FBD890-0x00FBD930
			}
	
			private struct SubscriberUserStatusInfoInt : IExchangeList<SubscriberUserStatusInfo> // TypeDefIndex: 9230
			{
				// Fields
				private CppArray keys; // 0x10
				private CppArray values; // 0x20
				private ulong pid; // 0x30
	
				// Methods
				public static SubscriberUserStatusInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FBD970-0x00FBDC20
				public SubscriberUserStatusInfo ExchangeStruct() => default; // 0x00FBDC30-0x00FBDC40
			}
	
			private struct SubscriberUserStatusParamInt // TypeDefIndex: 9231
			{
				// Fields
				private CppArray value; // 0x10
				private byte key; // 0x20
	
				// Constructors
				public SubscriberUserStatusParamInt(List<IntPtr> useptr, SubscriberUserStatusParam param) {
					value = default;
					key = default;
				} // 0x00FBDC70-0x00FBDD10
			}
	
			// Methods
			private static List<List<SubscriberContent>> Exchange(IntPtr src) => default; // 0x00FB9FF0-0x00FBA1F0
			private static extern bool Subscriber_PostContentAsync(uint asyncId, IntPtr pNgsFacade, ref SubscriberPostContentParamInt pParam, int timeOut); // 0x00FBA1F0-0x00FBA210
			public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0 /* Metadata: 0x00631554 */, NexPlugin.Subscriber.PostContentCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBA210-0x00FBA4D0
			private static extern bool Subscriber_GetContentAsync(uint asyncId, IntPtr pNgsFacade, ref SubscriberGetContentParamInt pParam, int timeOut); // 0x00FBA4D0-0x00FBA4F0
			public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0 /* Metadata: 0x00631558 */, NexPlugin.Subscriber.GetContentCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBA4F0-0x00FBA750
			private static extern bool Subscriber_GetContentsAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut); // 0x00FBA750-0x00FBA770
			public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0 /* Metadata: 0x0063155C */, NexPlugin.Subscriber.GetContentsCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBA770-0x00FBA9F0
			private static extern bool Subscriber_DeleteContentAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray topics, ulong contentId, int timeOut); // 0x00FBAA30-0x00FBAA50
			public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0 /* Metadata: 0x00631560 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBAA50-0x00FBAC50
			private static extern bool Subscriber_GetFriendUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, int timeOut); // 0x00FBAC50-0x00FBAC70
			public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631564 */, NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBAC70-0x00FBAD40
			private static extern bool Subscriber_GetFriendUserStatusesWithKeyAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray keys, int timeOut); // 0x00FBAD40-0x00FBAD60
			public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0 /* Metadata: 0x00631568 */, NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBAD60-0x00FBAF50
			private static extern bool Subscriber_GetUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray users, ref CppArray keys, int timeOut); // 0x00FBAF50-0x00FBAF70
			public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0 /* Metadata: 0x0063156C */, NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBAF70-0x00FBB190
			private static extern bool Subscriber_UpdateUserStatusAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray param, int isNotify, int timeOut); // 0x00FBB190-0x00FBB1B0
			public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify, int timeOut = 0 /* Metadata: 0x00631570 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBB1B0-0x00FBB3B0
			private static extern bool Subscriber_GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, ref int result); // 0x00FBB3B0-0x00FBB3D0
			public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result) {
				result = default;
				return default;
			} // 0x00FBB3D0-0x00FBB410
			private static extern bool Subscriber_GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, ref Result result); // 0x00FBB410-0x00FBB430
			public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result) {
				result = default;
				return default;
			} // 0x00FBB430-0x00FBB450
			private static extern bool Subscriber_GetFriendUserStatuses(IntPtr pNgsFacade, ref IntPtr infos, ref Result result); // 0x00FBB450-0x00FBB470
			public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result) {
				infos = default;
				result = default;
				return default;
			} // 0x00FBB470-0x00FBB580
			private static extern bool Subscriber_GetFriendUserStatusesWithKey(IntPtr pNgsFacade, ref CppArray users, ref IntPtr infos, ref Result result); // 0x00FBB590-0x00FBB5B0
			public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result) {
				infos = default;
				result = default;
				return default;
			} // 0x00FBB5B0-0x00FBB7E0
			private static extern void Subscriber_DeleteSubscriberUserStatusInfo(IntPtr info); // 0x00FBB580-0x00FBB590
			private static void Subscriber_PostContentResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBB7E0-0x00FBB8A0
			private static void Subscriber_GetContentResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBBED0-0x00FBBFF0
			private static void Subscriber_GetContentsResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBC620-0x00FBC710
			private static void Subscriber_UserStatusInfoResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBCD40-0x00FBCE60
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FBD490-0x00FBD7D0
		}
	
		public class Util_UnmanagedManager // TypeDefIndex: 9232
		{
			// Constructors
			public Util_UnmanagedManager() {} // 0x00FBDDF0-0x00FBDE00
	
			// Methods
			public static IntPtr AllocHGlobal(int size, bool output = true /* Metadata: 0x00631574 */) => default; // 0x00FBDD10-0x00FBDDD0
			public static bool FreeHGlobal(IntPtr p, bool output = true /* Metadata: 0x00631575 */) => default; // 0x00FAE010-0x00FAE0E0
			public static int GetAllocedCount() => default; // 0x00FBDDD0-0x00FBDDE0
			public static int GetUsedAllocsize() => default; // 0x00FBDDE0-0x00FBDDF0
		}
	
		public static class Utility // TypeDefIndex: 9233
		{
			// Nested types
			private struct UniqueIdInfoInt : IExchangeList<UniqueIdInfo> // TypeDefIndex: 9234
			{
				// Fields
				private ulong nexUniqueId; // 0x10
				private ulong nexUniqueIdPassword; // 0x18
	
				// Constructors
				public UniqueIdInfoInt(UniqueIdInfo param) {
					nexUniqueId = default;
					nexUniqueIdPassword = default;
				} // 0x00FBF070-0x00FBF0F0
	
				// Methods
				public UniqueIdInfo ExchangeStruct() => default; // 0x00FBEFF0-0x00FBF070
				public static UniqueIdInfo ExchangePtrToStruct(IntPtr src) => default; // 0x00FBE870-0x00FBE940
			}
	
			private struct IntegerSettings // TypeDefIndex: 9235
			{
				// Fields
				public int value; // 0x10
				public ushort key; // 0x14
			}
	
			// Methods
			private static extern bool Utility_AcquireNexUniqueIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut); // 0x00FBDE00-0x00FBDE20
			public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631576 */, NexPlugin.Utility.AcquireNexUniqueIdCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBDE20-0x00FBDEF0
			private static extern bool Utility_AcquireNexUniqueIdWithPasswordAsync(uint asyncId, IntPtr pNgsFacade, int timeOut); // 0x00FBDEF0-0x00FBDF10
			public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x0063157A */, NexPlugin.Utility.AcquireNexUniqueIdWithPasswordCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBDF10-0x00FBDFE0
			private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, ref UniqueIdInfoInt pParam, int timeOut); // 0x00FBDFE0-0x00FBE000
			public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo param, int timeOut = 0 /* Metadata: 0x0063157E */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBE000-0x00FBE150
			private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut); // 0x00FBE150-0x00FBE170
			public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> param, int timeOut = 0 /* Metadata: 0x00631582 */, AsyncResultCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBE170-0x00FBE3E0
			private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut); // 0x00FBE410-0x00FBE430
			public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631586 */, NexPlugin.Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBE430-0x00FBE500
			private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, int timeOut); // 0x00FBE500-0x00FBE520
			public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x0063158A */, NexPlugin.Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBE520-0x00FBE5F0
			private static extern bool Utility_GetIntegerSettingsAsync(uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut); // 0x00FBE5F0-0x00FBE610
			public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0 /* Metadata: 0x0063158E */, NexPlugin.Utility.GetIntegerSettingsCB callback = null) {
				asyncId = default;
				return default;
			} // 0x00FBE610-0x00FBE6F0
			private static void AcquireNexUniqueIdResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBE6F0-0x00FBE7B0
			private static void AcquireNexUniqueIdWithPasswordResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBE7B0-0x00FBE870
			private static void GetAssociatedNexUniqueIdWithMyPrincipalIdResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBE940-0x00FBEA00
			private static void GetAssociatedNexUniqueIdWithMyPrincipalIdListResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBEA00-0x00FBEB30
			private static void GetIntegerSettingsResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FBEB30-0x00FBED60
			public static void Callback(AsyncResultInt res, object callback) {} // 0x00FBED60-0x00FBEFF0
		}
	
		// Constructors
		static Detail() {} // 0x00FA8A90-0x00FA8B40
	
		// Methods
		public static void GetAsyncResult(ref AsyncResultInt asyncResult, object callback) {} // 0x00FA7980-0x00FA7A80
		public static bool RegisterNotificationEventHandler(NotificationEventCB callback) => default; // 0x00FA7B10-0x00FA7BE0
		public static bool UnregisterNotificationEventHandler(NotificationEventCB callback) => default; // 0x00FA7BE0-0x00FA7C60
		public static void NotificationEventListCallback(List<NotificationEvent> notificationEventList) {} // 0x00FA7C60-0x00FA7F10
		public static void AddNexResultCallback(uint asyncId, object callback) {} // 0x00FA7F10-0x00FA7FA0
		public static void AsyncResultCallback(ref List<AsyncResultInt> AsyncResultList) {} // 0x00FA7FA0-0x00FA86F0
		public static uint PublishAsyncId() => default; // 0x00FA89B0-0x00FA8A90
		public static int GetNexAsyncCallCount() => default; // 0x00F91CF0-0x00F91D70
		public static void DumpNexAsyncCallList() {} // 0x00F91DE0-0x00F91DF0
		public static void NP_LOG(string str) {} // 0x00FA2F30-0x00FA2F40
		public static void NP_LOG(string format, params /* 0x0065AD30-0x0065AD40 */ object[] arg) {} // 0x00FA86F0-0x00FA8700
		public static T ExchangePtrToStruct<T>(IntPtr src) => default;
		public static IntPtr CopyStruct<T>(T[] param) => default;
	}
}
