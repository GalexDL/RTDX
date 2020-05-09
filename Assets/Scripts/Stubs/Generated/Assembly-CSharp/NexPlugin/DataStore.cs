/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public static class DataStore // TypeDefIndex: 9272
	{
		// Fields
		public const ushort MAX_PERIOD = 365; // Metadata: 0x006318CC
		public const uint MAX_METABIN_SIZE = 1024; // Metadata: 0x006318CE
		public const uint DATASTOREPERMISSION_RECIPIENTIDS_MAX = 100; // Metadata: 0x006318D2
		public const ulong INVALID_DATAID = 0; // Metadata: 0x006318D6
		public const ushort INVALID_DATA_TYPE = 65535; // Metadata: 0x006318DE
		public const ulong INVALID_PASSWORD = 0; // Metadata: 0x006318E0
		public const uint MAX_NAME_LENGTH = 64; // Metadata: 0x006318E8
		public const uint MAX_SEARCH_RESULT_SIZE = 100; // Metadata: 0x006318EC
		public const uint MAX_SEARCH_ANY_RESULT_SIZE = 20; // Metadata: 0x006318F0
		public const uint MAX_SEARCH_DATA_TYPE_SIZE = 10; // Metadata: 0x006318F4
		public const uint NUM_TAG_SLOT = 16; // Metadata: 0x006318F8
		public const uint RATING_SLOT_MAX = 15; // Metadata: 0x006318FC
		public const uint NUM_RATING_SLOT = 16; // Metadata: 0x00631900
		public const uint MAX_TAG_LENGTH = 24; // Metadata: 0x00631904
		public const ushort DEFAULT_PERIOD = 90; // Metadata: 0x00631908
		public const uint DEFAULT_HTTP_THREAD_PRIORITY = 16; // Metadata: 0x0063190A
		public const uint DEFAULT_RELAY_BUFFER_SIZE = 16384; // Metadata: 0x0063190E
		public const uint DEFAULT_HTTP_BUFFER_SIZE = 32768; // Metadata: 0x00631912
		public const uint DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND = 167; // Metadata: 0x00631916
		public const int DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT = 60000; // Metadata: 0x0063191A
		public const uint DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE = 65536; // Metadata: 0x0063191E
		public const uint DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE = 65536; // Metadata: 0x00631922
		public const ushort INVALID_PERSISTENCE_SLOT_ID = 65535; // Metadata: 0x00631926
		public const ushort NUM_PERSISTENCE_SLOT = 16; // Metadata: 0x00631928
		public const uint BATCH_PROCESSING_CAPACITY_POST_OBJECT = 16; // Metadata: 0x0063192A
		public const uint BATCH_PROCESSING_CAPACITY = 100; // Metadata: 0x0063192E
		public const ulong RESULTRANGE_ANY_OFFSET = 4294967295; // Metadata: 0x00631932
		public const uint RESULTRANGE_DEFAULT_SIZE = 20; // Metadata: 0x0063193A
	
		// Nested types
		public delegate void PostCB(AsyncResult asyncResult, ulong dataId); // TypeDefIndex: 9273; 0x00F9BBE0-0x00F9C210
	
		public delegate void ResultListCB(AsyncResult asyncResult, List<DataStoreResult> resultList); // TypeDefIndex: 9274; 0x00FA05D0-0x00FA1170
	
		public delegate void SearchObjectCB(AsyncResult asyncResult, DataStoreSearchResult result); // TypeDefIndex: 9275; 0x00FA11B0-0x00FA1D50
	
		public delegate void GetObjectCB(AsyncResult asyncResult, byte[] data); // TypeDefIndex: 9276; 0x00F97F60-0x00F98B00
	
		public delegate void GetMetaCB(AsyncResult asyncResult, DataStoreMetaInfo info); // TypeDefIndex: 9277; 0x00F96710-0x00F972B0
	
		public delegate void GetMetaListCB(AsyncResult asyncResult, List<DataStoreMetaInfo> info, List<DataStoreResult> resultList); // TypeDefIndex: 9278; 0x00F97300-0x00F97F10
	
		public delegate void RatingInfoCB(AsyncResult asyncResult, DataStoreRatingInfo info); // TypeDefIndex: 9279; 0x00F9CEC0-0x00F9DCE0
	
		public delegate void RatingInfoAllSlotCB(AsyncResult asyncResult, Dictionary<sbyte, DataStoreRatingInfo> info); // TypeDefIndex: 9280; 0x00F9C2D0-0x00F9CE70
	
		public delegate void RatingInfoWithLogCB(AsyncResult asyncResult, DataStoreRatingInfo info, DataStoreRatingLog log); // TypeDefIndex: 9281; 0x00F9EA00-0x00F9F8A0
	
		public delegate void RatingInfoListCB(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList); // TypeDefIndex: 9282; 0x00F9DDA0-0x00F9E9B0
	
		public delegate void RatingInfosListCB(AsyncResult asyncResult, List<Dictionary<sbyte, DataStoreRatingInfo>> info, List<DataStoreResult> resultList); // TypeDefIndex: 9283; 0x00F9F970-0x00FA0580
	
		public delegate void GetPersistenceInfoCB(AsyncResult asyncResult, DataStorePersistenceInfo info); // TypeDefIndex: 9284; 0x00F9A3A0-0x00F9AF40
	
		public delegate void GetPersistenceInfoListCB(AsyncResult asyncResult, List<DataStorePersistenceInfo> info, List<DataStoreResult> resultList); // TypeDefIndex: 9285; 0x00F9AF90-0x00F9BBA0
	
		public delegate void GetPasswordInfoCB(AsyncResult asyncResult, DataStorePasswordInfo info); // TypeDefIndex: 9286; 0x00F98B50-0x00F996F0
	
		public delegate void GetPasswordInfoListCB(AsyncResult asyncResult, List<DataStorePasswordInfo> info, List<DataStoreResult> resultList); // TypeDefIndex: 9287; 0x00F99740-0x00F9A350
	
		public enum Permission // TypeDefIndex: 9288
		{
			PERMISSION_PUBLIC = 0,
			PERMISSION_FRIEND = 1,
			PERMISSION_SPECIFIED = 2,
			PERMISSION_PRIVATE = 3,
			PERMISSION_SPECIFIED_FRIEND = 4
		}
	
		[Flags] // 0x00613F80-0x00613F90
		public enum DataFlag // TypeDefIndex: 9289
		{
			DATA_FLAG_NONE = 0,
			DATA_FLAG_NEED_REVIEW = 1,
			DATA_FLAG_PERIOD_FROM_LAST_REFERRED = 2,
			DATA_FLAG_USE_READ_LOCK = 4,
			DATA_FLAG_USE_NOTIFICATION_ON_POST = 8,
			DATA_FLAG_USE_NOTIFICATION_ON_UPDATE = 16,
			DATA_FLAG_NOT_USE_FILESERVER = 32,
			DATA_FLAG_NEED_COMPLETION = 64
		}
	
		[Flags] // 0x00613F90-0x00613FA0
		public enum ModificationFlag // TypeDefIndex: 9290
		{
			MODIFICATION_FLAG_NONE = 0,
			MODIFICATION_FLAG_NAME = 1,
			MODIFICATION_FLAG_ACCESS_PERMISSION = 2,
			MODIFICATION_FLAG_UPDATE_PERMISSION = 4,
			MODIFICATION_FLAG_PERIOD = 8,
			MODIFICATION_FLAG_METABINARY = 16,
			MODIFICATION_FLAG_TAGS = 32,
			MODIFICATION_FLAG_UPDATED_TIME = 64,
			MODIFICATION_FLAG_DATA_TYPE = 128,
			MODIFICATION_FLAG_STATUS = 512
		}
	
		public enum DataStatus // TypeDefIndex: 9291
		{
			DATA_STATUS_NONE = 0,
			DATA_STATUS_PENDING = 2,
			DATA_STATUS_REJECTED = 5
		}
	
		[Flags] // 0x00613FA0-0x00613FB0
		public enum ComparisonFlag // TypeDefIndex: 9292
		{
			COMPARISON_FLAG_NONE = 0,
			COMPARISON_FLAG_NAME = 1,
			COMPARISON_FLAG_ACCESS_PERMISSION = 2,
			COMPARISON_FLAG_UPDATE_PERMISSION = 4,
			COMPARISON_FLAG_PERIOD = 8,
			COMPARISON_FLAG_METABINARY = 16,
			COMPARISON_FLAG_TAGS = 32,
			COMPARISON_FLAG_DATA_TYPE = 64,
			COMPARISON_FLAG_STATUS = 256,
			COMPARISON_FLAG_ALL = 65535
		}
	
		public enum SearchType // TypeDefIndex: 9293
		{
			SEARCH_TYPE_PUBLIC = 1,
			SEARCH_TYPE_SEND_FRIEND = 2,
			SEARCH_TYPE_SEND_SPECIFIED = 3,
			SEARCH_TYPE_SEND_SPECIFIED_FRIEND = 4,
			SEARCH_TYPE_SEND = 5,
			SEARCH_TYPE_FRIEND = 6,
			SEARCH_TYPE_RECEIVED_SPECIFIED = 7,
			SEARCH_TYPE_RECEIVED = 8,
			SEARCH_TYPE_PRIVATE = 9,
			SEARCH_TYPE_OWN = 10,
			SEARCH_TYPE_OWN_PENDING = 12,
			SEARCH_TYPE_OWN_REJECTED = 13,
			SEARCH_TYPE_OWN_ALL = 14
		}
	
		public enum SearchTarget // TypeDefIndex: 9294
		{
			SEARCH_TARGET_ANYBODY = 0,
			SEARCH_TARGET_FRIEND = 1
		}
	
		public enum SearchSortColumn // TypeDefIndex: 9295
		{
			SEARCH_SORT_COLUMN_DATAID = 0,
			SEARCH_SORT_COLUMN_CREATED_TIME = 5,
			SEARCH_SORT_COLUMN_UPDATED_TIME = 6,
			SEARCH_SORT_COLUMN_RATING0 = 64,
			SEARCH_SORT_COLUMN_RATING1 = 65,
			SEARCH_SORT_COLUMN_RATING2 = 66,
			SEARCH_SORT_COLUMN_RATING3 = 67,
			SEARCH_SORT_COLUMN_RATING4 = 68,
			SEARCH_SORT_COLUMN_RATING5 = 69,
			SEARCH_SORT_COLUMN_RATING6 = 70,
			SEARCH_SORT_COLUMN_RATING7 = 71,
			SEARCH_SORT_COLUMN_RATING8 = 72,
			SEARCH_SORT_COLUMN_RATING9 = 73,
			SEARCH_SORT_COLUMN_RATING10 = 74,
			SEARCH_SORT_COLUMN_RATING11 = 75,
			SEARCH_SORT_COLUMN_RATING12 = 76,
			SEARCH_SORT_COLUMN_RATING13 = 77,
			SEARCH_SORT_COLUMN_RATING14 = 78,
			SEARCH_SORT_COLUMN_RATING15 = 79,
			SEARCH_SORT_COLUMN_RATING_AVERAGE0 = 96,
			SEARCH_SORT_COLUMN_RATING_AVERAGE1 = 97,
			SEARCH_SORT_COLUMN_RATING_AVERAGE2 = 98,
			SEARCH_SORT_COLUMN_RATING_AVERAGE3 = 99,
			SEARCH_SORT_COLUMN_RATING_AVERAGE4 = 100,
			SEARCH_SORT_COLUMN_RATING_AVERAGE5 = 101,
			SEARCH_SORT_COLUMN_RATING_AVERAGE6 = 102,
			SEARCH_SORT_COLUMN_RATING_AVERAGE7 = 103,
			SEARCH_SORT_COLUMN_RATING_AVERAGE8 = 104,
			SEARCH_SORT_COLUMN_RATING_AVERAGE9 = 105,
			SEARCH_SORT_COLUMN_RATING_AVERAGE10 = 106,
			SEARCH_SORT_COLUMN_RATING_AVERAGE11 = 107,
			SEARCH_SORT_COLUMN_RATING_AVERAGE12 = 108,
			SEARCH_SORT_COLUMN_RATING_AVERAGE13 = 109,
			SEARCH_SORT_COLUMN_RATING_AVERAGE14 = 110,
			SEARCH_SORT_COLUMN_RATING_AVERAGE15 = 111
		}
	
		public enum SearchSortOrder // TypeDefIndex: 9296
		{
			SEARCH_SORT_ORDER_ASC = 0,
			SEARCH_SORT_ORDER_DESC = 1
		}
	
		[Flags] // 0x00613FB0-0x00613FC0
		public enum ResultFlag // TypeDefIndex: 9297
		{
			RESULT_FLAG_TAGS = 1,
			RESULT_FLAG_RATINGS = 2,
			RESULT_FLAG_METABINARY = 4,
			RESULT_FLAG_PERMITTED_IDS = 8
		}
	
		public enum RatingLockType // TypeDefIndex: 9298
		{
			RATING_LOCK_NONE = 0,
			RATING_LOCK_INTERVAL = 1,
			RATING_LOCK_PERIOD = 2,
			RATING_LOCK_PERMANENT = 3
		}
	
		public enum RatingFlag // TypeDefIndex: 9299
		{
			RATING_FLAG_MODIFIABLE = 4,
			RATING_FLAG_ROUND_MINUS = 8,
			RATING_FLAG_DISABLE_SELF_RATING = 16
		}
	
		[Flags] // 0x00613FC0-0x00613FD0
		internal enum RatingInternalFlag // TypeDefIndex: 9300
		{
			RATING_INTERNAL_FLAG_USE_RANGE_MIN = 2,
			RATING_INTERNAL_FLAG_USE_RANGE_MAX = 4
		}
	
		public enum RatingLockPeriod // TypeDefIndex: 9301
		{
			RATING_LOCK_PERIOD_DAY1 = -17,
			RATING_LOCK_PERIOD_SUN = -7,
			RATING_LOCK_PERIOD_SAT = -6,
			RATING_LOCK_PERIOD_FRI = -5,
			RATING_LOCK_PERIOD_THU = -4,
			RATING_LOCK_PERIOD_WED = -3,
			RATING_LOCK_PERIOD_TUE = -2,
			RATING_LOCK_PERIOD_MON = -1
		}
	
		public enum SearchResultTotalCountType // TypeDefIndex: 9302
		{
			SEARCH_RESULT_TOTAL_EXACT = 0,
			SEARCH_RESULT_TOTAL_MINIMUM = 1,
			SEARCH_RESULT_TOTAL_ESTIMATE = 2,
			SEARCH_RESULT_TOTAL_DISABLED = 3
		}
	
		// Methods
		public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0 /* Metadata: 0x00631807 */, PostCB callback = null)
			where T : struct {
			asyncId = default;
			return default;
		}
		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0 /* Metadata: 0x0063180B */, PostCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F91E10-0x00F91E20
		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0 /* Metadata: 0x0063180F */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F92080-0x00F92090
		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, Dictionary<ulong, DataStorePreparePostParam> param, bool transactional = true /* Metadata: 0x00631813 */, int timeOut = 0 /* Metadata: 0x00631814 */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F92300-0x00F92420
		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStorePreparePostParam param, bool transactional = true /* Metadata: 0x00631818 */, int timeOut = 0 /* Metadata: 0x00631819 */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F926B0-0x00F92790
		public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x0063181D */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F92790-0x00F927A0
		public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0 /* Metadata: 0x00631821 */, SearchObjectCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F929F0-0x00F92A00
		public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0 /* Metadata: 0x00631825 */, SearchObjectCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F92C60-0x00F92C70
		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0 /* Metadata: 0x00631829 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F92ED0-0x00F92EE0
		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x0063182D */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93020-0x00F930C0
		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = true /* Metadata: 0x00631831 */, int timeOut = 0 /* Metadata: 0x00631832 */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F930F0-0x00F93100
		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true /* Metadata: 0x00631836 */, int timeOut = 0 /* Metadata: 0x00631837 */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93360-0x00F93540
		public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0 /* Metadata: 0x0063183B */, AsyncResultCB callback = null)
			where T : struct {
			asyncId = default;
			return default;
		}
		public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0 /* Metadata: 0x0063183F */, GetObjectCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93550-0x00F93560
		public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0 /* Metadata: 0x00631843 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F936C0-0x00F936D0
		public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0 /* Metadata: 0x00631847 */, GetMetaCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93810-0x00F93820
		public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreGetMetaParam param, int timeOut = 0 /* Metadata: 0x0063184B */, GetMetaListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93970-0x00F93A40
		public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreGetMetaParam> param, int timeOut = 0 /* Metadata: 0x0063184F */, GetMetaListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93CC0-0x00F93D60
		public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0 /* Metadata: 0x00631853 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93D60-0x00F93D70
		public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreChangeMetaParam param, bool transactional = true /* Metadata: 0x00631857 */, int timeOut = 0 /* Metadata: 0x00631858 */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F93FF0-0x00F940D0
		public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreChangeMetaParam> param, bool transactional = true /* Metadata: 0x0063185C */, int timeOut = 0 /* Metadata: 0x0063185D */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94360-0x00F94420
		public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0 /* Metadata: 0x00631861 */, RatingInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94420-0x00F94430
		public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam param, bool transactional = true /* Metadata: 0x00631865 */, int timeOut = 0 /* Metadata: 0x00631866 */, RatingInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94590-0x00F94670
		public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = true /* Metadata: 0x0063186A */, int timeOut = 0 /* Metadata: 0x0063186B */, RatingInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94900-0x00F94940
		public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, int timeOut = 0 /* Metadata: 0x0063186F */, RatingInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94940-0x00F94950
		public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> rateParam, List<DataStorePreparePostParam> postParam, bool transactional = true /* Metadata: 0x00631873 */, int timeOut = 0 /* Metadata: 0x00631874 */, RatingInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94BF0-0x00F94C40
		public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, bool transactional = true /* Metadata: 0x00631878 */, int timeOut = 0 /* Metadata: 0x00631879 */, RatingInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F94F60-0x00F95090
		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0 /* Metadata: 0x0063187D */, int timeOut = 0 /* Metadata: 0x00631885 */, RatingInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95090-0x00F950A0
		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x00631889 */, RatingInfoAllSlotCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F951F0-0x00F95200
		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x0063188D */, RatingInfosListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95320-0x00F95330
		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0 /* Metadata: 0x00631891 */, int timeOut = 0 /* Metadata: 0x00631899 */, RatingInfoWithLogCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95580-0x00F95590
		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0 /* Metadata: 0x0063189D */, int timeOut = 0 /* Metadata: 0x006318A5 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F956E0-0x00F956F0
		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x006318A9 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95840-0x00F95850
		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true /* Metadata: 0x006318AD */, int timeOut = 0 /* Metadata: 0x006318AE */, ResultListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95970-0x00F95980
		public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0 /* Metadata: 0x006318B2 */, GetPersistenceInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95BE0-0x00F95BF0
		public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0 /* Metadata: 0x006318B6 */, GetPersistenceInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95D20-0x00F95D30
		public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = true /* Metadata: 0x006318BA */, int timeOut = 0 /* Metadata: 0x006318BB */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F95F90-0x00F95FA0
		public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = false /* Metadata: 0x006318BF */, int timeOut = 0 /* Metadata: 0x006318C0 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F960E0-0x00F960F0
		public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0 /* Metadata: 0x006318C4 */, GetPasswordInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F96220-0x00F96230
		public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0 /* Metadata: 0x006318C8 */, GetPasswordInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00F96350-0x00F96360
		public static extern bool SetHttpThreadPriority(uint priority); // 0x00F965B0-0x00F965D0
		public static extern bool GetHttpThreadPriority(ref uint priority); // 0x00F965D0-0x00F965F0
		public static extern bool SetRelayBufferSize(uint relayBufferSize); // 0x00F965F0-0x00F96610
		public static extern bool GetRelayBufferSize(ref uint relayBufferSize); // 0x00F96610-0x00F96630
		public static extern bool SetHttpBufferSize(uint httpBufferSize); // 0x00F96630-0x00F96650
		public static extern bool GetHttpBufferSize(ref uint httpBufferSize); // 0x00F96650-0x00F96670
		public static extern bool SetDataTransferTimeout(uint timeoutBytesPerSecond, int minimumTimeoutMilliSecond); // 0x00F96670-0x00F96690
		public static extern bool SetHttpSendSocketBufferSize(uint size); // 0x00F96690-0x00F966B0
		public static extern bool GetHttpSendSocketBufferSize(ref uint size); // 0x00F966B0-0x00F966D0
		public static extern bool SetHttpRecvSocketBufferSize(uint size); // 0x00F966D0-0x00F966F0
		public static extern bool GetHttpRecvSocketBufferSize(ref uint size); // 0x00F966F0-0x00F96710
	}
}
