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
	public static class Ranking // TypeDefIndex: 9303
	{
		// Fields
		public const byte MAX_COMMON_DATA_SIZE = 255; // Metadata: 0x00631BB2
		public const uint MAX_RANGE_RANKING_ORDER = 1000; // Metadata: 0x00631BB3
		public const uint MAX_ACCURATE_ORDER = 5000; // Metadata: 0x00631BB7
	
		// Nested types
		public enum RankingMode // TypeDefIndex: 9304
		{
			RANKING_MODE_RANGE = 0,
			RANKING_MODE_NEAR = 1,
			RANKING_MODE_FRIEND_RANGE = 2,
			RANKING_MODE_FRIEND_NEAR = 3,
			RANKING_MODE_USER = 4
		}
	
		public enum FilterGroupIndex // TypeDefIndex: 9305
		{
			FILTER_GROUP_INDEX_0 = 0,
			FILTER_GROUP_INDEX_1 = 1,
			FILTER_GROUP_INDEX_2 = 2,
			FILTER_GROUP_INDEX_3 = 3,
			FILTER_GROUP_INDEX_NONE = 255
		}
	
		public enum OrderBy // TypeDefIndex: 9306
		{
			ORDER_BY_ASC = 0,
			ORDER_BY_DESC = 1
		}
	
		public enum UpdateMode // TypeDefIndex: 9307
		{
			UPDATE_MODE_NORMAL = 0,
			UPDATE_MODE_DELETE_OLD = 1
		}
	
		public enum OrderCalculation // TypeDefIndex: 9308
		{
			ORDER_CALCULATION_113 = 0,
			ORDER_CALCULATION_123 = 1
		}
	
		public enum TimeScope // TypeDefIndex: 9309
		{
			TIME_SCOPE_CUSTOM_0 = 0,
			TIME_SCOPE_CUSTOM_1 = 1,
			TIME_SCOPE_ALL = 2
		}
	
		[Flags] // 0x00613FD0-0x00613FE0
		public enum ModificationFlag // TypeDefIndex: 9310
		{
			MODIFICATION_FLAG_NONE = 0,
			MODIFICATION_FLAG_GROUP0 = 1,
			MODIFICATION_FLAG_GROUP1 = 2,
			MODIFICATION_FLAG_GROUP2 = 4,
			MODIFICATION_FLAG_GROUP3 = 8,
			MODIFICATION_FLAG_PARAM = 16
		}
	
		[Flags] // 0x00613FE0-0x00613FF0
		public enum StatsFlag // TypeDefIndex: 9311
		{
			STATS_FLAG_TOTAL = 1,
			STATS_FLAG_SUM = 2,
			STATS_FLAG_MIN = 4,
			STATS_FLAG_MAX = 8,
			STATS_FLAG_AVERAGE = 16
		}
	
		public delegate void GetCommonDataCB(AsyncResult asyncResult, List<byte> data); // TypeDefIndex: 9312; 0x00FB14B0-0x00FB1AE0
	
		public delegate void GetRankingCB(AsyncResult asyncResult, RankingResult info); // TypeDefIndex: 9313; 0x00FB1E30-0x00FB2460
	
		public delegate void GetApproxOrderCB(AsyncResult asyncResult, uint rank); // TypeDefIndex: 9314; 0x00FB2520-0x00FB2B50
	
		public delegate void GetStatsCB(AsyncResult asyncResult, RankingStats stats); // TypeDefIndex: 9315; 0x00FB2CA0-0x00FB3660
	
		public delegate void GetCachedTopXRankingCB(AsyncResult asyncResult, RankingCachedResult info); // TypeDefIndex: 9316; 0x00FB3740-0x00FB3D70
	
		public delegate void GetCachedTopXRankingsCB(AsyncResult asyncResult, List<RankingCachedResult> info); // TypeDefIndex: 9317; 0x00FB3E90-0x00FB44C0
	
		// Methods
		public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId = 0 /* Metadata: 0x00631B02 */, int timeOut = 0 /* Metadata: 0x00631B0A */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0EA0-0x00FC0EB0
		public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0 /* Metadata: 0x00631B0E */, int timeOut = 0 /* Metadata: 0x00631B16 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0EB0-0x00FC0EC0
		public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0 /* Metadata: 0x00631B1A */, int timeOut = 0 /* Metadata: 0x00631B22 */, GetCommonDataCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0EC0-0x00FC0ED0
		public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId = 0 /* Metadata: 0x00631B26 */, int timeOut = 0 /* Metadata: 0x00631B2E */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0ED0-0x00FC0EE0
		public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, uint category, ulong nexUniqueId = 0 /* Metadata: 0x00631B32 */, int timeOut = 0 /* Metadata: 0x00631B3A */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0EE0-0x00FC0F00
		public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0 /* Metadata: 0x00631B3E */, int timeOut = 0 /* Metadata: 0x00631B46 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F00-0x00FC0F20
		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0 /* Metadata: 0x00631B4A */, ulong principalId = 0 /* Metadata: 0x00631B52 */, int timeOut = 0 /* Metadata: 0x00631B5A */, GetRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F20-0x00FC0F30
		public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0 /* Metadata: 0x00631B5E */, int timeOut = 0 /* Metadata: 0x00631B66 */, GetRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F30-0x00FC0F40
		public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0 /* Metadata: 0x00631B6A */, int timeOut = 0 /* Metadata: 0x00631B72 */, GetRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F40-0x00FC0F50
		public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId = 0 /* Metadata: 0x00631B76 */, ulong principalId = 0 /* Metadata: 0x00631B7E */, int timeOut = 0 /* Metadata: 0x00631B86 */, GetApproxOrderCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F50-0x00FC0F60
		public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, StatsFlag flags, int timeOut = 0 /* Metadata: 0x00631B8A */, GetStatsCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F60-0x00FC0F70
		public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0 /* Metadata: 0x00631B8E */, int timeOut = 0 /* Metadata: 0x00631B96 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0F70-0x00FC0FB0
		public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0 /* Metadata: 0x00631B9A */, int timeOut = 0 /* Metadata: 0x00631BA2 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0FB0-0x00FC0FF0
		public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0 /* Metadata: 0x00631BA6 */, GetCachedTopXRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC0FF0-0x00FC1000
		public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, RankingOrderParam orderParam, int timeOut = 0 /* Metadata: 0x00631BAA */, GetCachedTopXRankingsCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC1000-0x00FC10D0
		public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0 /* Metadata: 0x00631BAE */, GetCachedTopXRankingsCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC10D0-0x00FC10F0
	}
}
