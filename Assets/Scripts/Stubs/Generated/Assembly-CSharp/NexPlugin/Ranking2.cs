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
	public static class Ranking2 // TypeDefIndex: 9318
	{
		// Fields
		public const int MAX_BINARY_DATA_LENGTH = 100; // Metadata: 0x00631C93
		public const uint MAX_CHART_GET_LENGTH = 20; // Metadata: 0x00631C97
		public const uint MAX_PUT_MULTI_SCORES = 20; // Metadata: 0x00631C9B
		public const uint MAX_RANKING_LENGTH = 100; // Metadata: 0x00631C9F
		public const int MAX_USERNAME_LENGTH = 16; // Metadata: 0x00631CA3
		public const bool SCORE_ORDER_ASC = false; // Metadata: 0x00631CA7
		public const bool SCORE_ORDER_DESC = true; // Metadata: 0x00631CA8
	
		// Nested types
		public enum Ranking2SortFlags // TypeDefIndex: 9319
		{
			NOTHING = 0,
			MOVE_TO_TOP_IN_TIE = 4
		}
	
		public enum Ranking2GetOptionFlags // TypeDefIndex: 9320
		{
			NOTHING = 0
		}
	
		public enum Ranking2Mode : byte // TypeDefIndex: 9321
		{
			USER_RANKING = 0,
			MIN = 0,
			NEAR_RANKING = 1,
			RANGE_RANKING = 2,
			FRIEND_RANKING = 3,
			MAX = 3
		}
	
		public enum Ranking2ResetMode : byte // TypeDefIndex: 9322
		{
			NOTHING = 0,
			MIN = 0,
			EVERYDAY = 1,
			EVERYWEEK = 2,
			MULTI_MONTH = 3,
			MULTI_MONTH_WEEKDAY = 4,
			MAX = 4
		}
	
		public delegate void GetCommonDataCB(AsyncResult asyncResult, Ranking2CommonData data); // TypeDefIndex: 9323; 0x00FB6710-0x00FB6D40
	
		public delegate void GetRankingCB(AsyncResult asyncResult, Ranking2Info info); // TypeDefIndex: 9324; 0x00FB7050-0x00FB7680
	
		public delegate void GetCategorySettingCB(AsyncResult asyncResult, Ranking2CategorySetting setting); // TypeDefIndex: 9325; 0x00FB7870-0x00FB7EA0
	
		public delegate void GetRanking2ChartInfoCB(AsyncResult asyncResult, Ranking2ChartInfo info); // TypeDefIndex: 9326; 0x00FB8180-0x00FB87B0
	
		public delegate void GetRanking2ChartInfoListCB(AsyncResult asyncResult, List<Ranking2ChartInfo> info); // TypeDefIndex: 9327; 0x00FB88D0-0x00FB8F00
	
		public delegate void GetRanking2EstimateScoreRankCB(AsyncResult asyncResult, Ranking2EstimateScoreRankOutput info); // TypeDefIndex: 9328; 0x00FB9030-0x00FB9860
	
		// Methods
		public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId = 0 /* Metadata: 0x00631C33 */, int timeOut = 0 /* Metadata: 0x00631C3B */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3230-0x00FC3240
		public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId = 0 /* Metadata: 0x00631C3F */, int timeOut = 0 /* Metadata: 0x00631C47 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3240-0x00FC3250
		public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId = 0 /* Metadata: 0x00631C4B */, int timeOut = 0 /* Metadata: 0x00631C53 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3250-0x00FC3260
		public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetOptionFlags optionFlags = Ranking2GetOptionFlags.NOTHING /* Metadata: 0x00631C57 */, ulong principalId = 0 /* Metadata: 0x00631C5B */, ulong nexUniqueId = 0 /* Metadata: 0x00631C63 */, int timeOut = 0 /* Metadata: 0x00631C6B */, GetCommonDataCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3260-0x00FC3270
		public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0 /* Metadata: 0x00631C6F */, int timeOut = 0 /* Metadata: 0x00631C77 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3270-0x00FC3280
		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0 /* Metadata: 0x00631C7B */, GetRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3280-0x00FC3290
		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0 /* Metadata: 0x00631C7F */, GetRankingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC3290-0x00FC32A0
		public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0 /* Metadata: 0x00631C83 */, GetCategorySettingCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC32A0-0x00FC32B0
		public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0 /* Metadata: 0x00631C87 */, GetRanking2ChartInfoCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC32B0-0x00FC32C0
		public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0 /* Metadata: 0x00631C8B */, GetRanking2ChartInfoListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC32C0-0x00FC32D0
		public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0 /* Metadata: 0x00631C8F */, GetRanking2EstimateScoreRankCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FC32D0-0x00FC32E0
	}
}
