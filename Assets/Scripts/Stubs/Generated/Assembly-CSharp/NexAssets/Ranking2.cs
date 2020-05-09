/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public class Ranking2 : Common // TypeDefIndex: 9499
	{
		// Fields
		private static Dictionary<int, FunctionInfo> FunctionInfos; // 0x00
		private static List<ApiCallsFrequency> s_ApiCallsFrequencyList; // 0x08
	
		// Nested types
		private class GETRANKING_ARG : Common.CORE_ARG // TypeDefIndex: 9500
		{
			// Fields
			public Ranking2GetParam param; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Ranking2.GetRankingCB callback; // 0x38
	
			// Constructors
			public GETRANKING_ARG() {} // 0x00DB63D0-0x00DB63E0
		}
	
		private class GETRANKINGBYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9501
		{
			// Fields
			public Ranking2GetByListParam param; // 0x28
			public List<ulong> principalIdList; // 0x30
			public int timeOut; // 0x38
			public NexPlugin.Ranking2.GetRankingCB callback; // 0x40
	
			// Constructors
			public GETRANKINGBYLIST_ARG() {} // 0x00DB6790-0x00DB67A0
		}
	
		private class PUTSCORE_ARG : Common.CORE_ARG // TypeDefIndex: 9502
		{
			// Fields
			public Ranking2ScoreData param; // 0x28
			public ulong uniqueId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public PUTSCORE_ARG() {} // 0x00DB6BE0-0x00DB6BF0
		}
	
		private class PUTSCORELIST_ARG : Common.CORE_ARG // TypeDefIndex: 9503
		{
			// Fields
			public List<Ranking2ScoreData> paramList; // 0x28
			public ulong uniqueId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public PUTSCORELIST_ARG() {} // 0x00DB6EB0-0x00DB6EC0
		}
	
		private class PUTCOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9504
		{
			// Fields
			public Ranking2CommonData param; // 0x28
			public ulong uniqueId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public PUTCOMMON_ARG() {} // 0x00DB7180-0x00DB7190
		}
	
		private class GETCOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9505
		{
			// Fields
			public NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags; // 0x28
			public ulong uniqueId; // 0x30
			public bool principalIdUseCurrentLogin; // 0x38
			public ulong principalId; // 0x40
			public int timeOut; // 0x48
			public NexPlugin.Ranking2.GetCommonDataCB callback; // 0x50
	
			// Constructors
			public GETCOMMON_ARG() {} // 0x00DB7470-0x00DB7480
		}
	
		private class DELETECOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9506
		{
			// Fields
			public ulong uniqueId; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public DELETECOMMON_ARG() {} // 0x00DB77B0-0x00DB77C0
		}
	
		private class GETCATEGORY_ARG : Common.CORE_ARG // TypeDefIndex: 9507
		{
			// Fields
			public uint category; // 0x28
			public int timeOut; // 0x2C
			public NexPlugin.Ranking2.GetCategorySettingCB callback; // 0x30
	
			// Constructors
			public GETCATEGORY_ARG() {} // 0x00DB7A70-0x00DB7A80
		}
	
		private class GETESTIMATESCORERANK_ARG : Common.CORE_ARG // TypeDefIndex: 9508
		{
			// Fields
			public Ranking2EstimateScoreRankInput param; // 0x28
			public int timeOut; // 0x34
			public NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback; // 0x38
	
			// Constructors
			public GETESTIMATESCORERANK_ARG() {} // 0x00DB7E70-0x00DB7E80
		}
	
		private class GETRANKINGCHART_ARG : Common.CORE_ARG // TypeDefIndex: 9509
		{
			// Fields
			public Ranking2ChartInfoInput param; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Ranking2.GetRanking2ChartInfoCB callback; // 0x38
	
			// Constructors
			public GETRANKINGCHART_ARG() {} // 0x00DB8210-0x00DB8220
		}
	
		private class GETRANKINGCHARTS_ARG : Common.CORE_ARG // TypeDefIndex: 9510
		{
			// Fields
			public List<Ranking2ChartInfoInput> param; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback; // 0x38
	
			// Constructors
			public GETRANKINGCHARTS_ARG() {} // 0x00DB84F0-0x00DB8500
		}
	
		private enum Functions // TypeDefIndex: 9511
		{
			GetRanking = 0,
			GetRankingPid = 1,
			GetCategorySetting = 2,
			PutScore = 3,
			PutCommonData = 4,
			GetCommonData = 5,
			DeleteCommonData = 6,
			GetEstimateScoreRank = 7,
			GetRankingChart = 8,
			GetRankingCharts = 9
		}
	
		// Constructors
		public Ranking2() {} // 0x00DB86D0-0x00DB8740
		static Ranking2() {} // 0x00DB8740-0x00DB89E0
	
		// Methods
		public ASYNCSTATE GetRankingAsync(Ranking2GetParam param, NexPlugin.Ranking2.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322C6 */) => default; // 0x00DB62C0-0x00DB63D0
		private ASYNCSTATE GetRankingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB63E0-0x00DB65A0
		public ASYNCSTATE GetRankingByPIDListAsync(Ranking2GetByListParam param, List<ulong> principalIdList, NexPlugin.Ranking2.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322CA */) => default; // 0x00DB6670-0x00DB6790
		private ASYNCSTATE GetRankingByPIDListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB67A0-0x00DB6960
		public ASYNCSTATE PutScoreAsync(Ranking2ScoreData param, uint score, ulong uniqueId = 0 /* Metadata: 0x006322CE */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322D6 */) => default; // 0x00DB6960-0x00DB6A40
		public ASYNCSTATE PutScoreAsync(Ranking2ScoreData param, ulong uniqueId = 0 /* Metadata: 0x006322DA */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322E2 */) => default; // 0x00DB6AC0-0x00DB6BE0
		private ASYNCSTATE PutScoreAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB6BF0-0x00DB6D90
		public ASYNCSTATE PutScoreListAsync(List<Ranking2ScoreData> paramList, ulong uniqueId = 0 /* Metadata: 0x006322E6 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322EE */) => default; // 0x00DB6D90-0x00DB6EB0
		private ASYNCSTATE PutScoreListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB6EC0-0x00DB7060
		public ASYNCSTATE PutCommonDataAsync(Ranking2CommonData param, ulong uniqueId = 0 /* Metadata: 0x006322F2 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006322FA */) => default; // 0x00DB7060-0x00DB7180
		private ASYNCSTATE PutCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB7190-0x00DB7330
		public ASYNCSTATE GetCommonDataAsync(NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags, ulong principalId = 0 /* Metadata: 0x006322FE */, ulong uniqueId = 0 /* Metadata: 0x00632306 */, bool principalIdUseCurrentLogin = false /* Metadata: 0x0063230E */, NexPlugin.Ranking2.GetCommonDataCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063230F */) => default; // 0x00DB7330-0x00DB7470
		private ASYNCSTATE GetCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB7480-0x00DB76A0
		public ASYNCSTATE DeleteCommonDataAsync(ulong uniqueId = 0 /* Metadata: 0x00632313 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063231B */) => default; // 0x00DB76A0-0x00DB77B0
		private ASYNCSTATE DeleteCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB77C0-0x00DB7960
		public ASYNCSTATE GetCategorySettingAsync(uint category, NexPlugin.Ranking2.GetCategorySettingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063231F */) => default; // 0x00DB7960-0x00DB7A70
		private ASYNCSTATE GetCategorySettingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB7A80-0x00DB7C40
		public ASYNCSTATE GetEstimateScoreRankAsync(Ranking2EstimateScoreRankInput param, uint score, NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632323 */) => default; // 0x00DB7C40-0x00DB7CF0
		public ASYNCSTATE GetEstimateScoreRankAsync(Ranking2EstimateScoreRankInput param, NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632327 */) => default; // 0x00DB7D50-0x00DB7E70
		private ASYNCSTATE GetEstimateScoreRankAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB7E80-0x00DB8030
		public ASYNCSTATE GetRankingChartAsync(Ranking2ChartInfoInput param, NexPlugin.Ranking2.GetRanking2ChartInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063232B */) => default; // 0x00DB8030-0x00DB80B0
		private ASYNCSTATE GetRankingChartAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB8220-0x00DB83E0
		public ASYNCSTATE GetRankingChartsAsync(List<Ranking2ChartInfoInput> param, NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632333 */) => default; // 0x00DB83E0-0x00DB84F0
		private ASYNCSTATE GetRankingChartsAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB8500-0x00DB86D0
		private new bool ApiCallsFrequencyCheck(int type) => default; // 0x00DB65A0-0x00DB6670
	}
}
