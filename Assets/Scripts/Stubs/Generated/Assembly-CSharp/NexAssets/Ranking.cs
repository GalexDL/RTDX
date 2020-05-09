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
	public class Ranking : Common // TypeDefIndex: 9479
	{
		// Fields
		private static Dictionary<int, FunctionInfo> FunctionInfos; // 0x00
		private static List<ApiCallsFrequency> s_ApiCallsFrequencyList; // 0x08
	
		// Nested types
		private class GETRANK_ARG : Common.CORE_ARG // TypeDefIndex: 9480
		{
			// Fields
			public NexPlugin.Ranking.RankingMode rankingMode; // 0x28
			public uint category; // 0x2C
			public RankingOrderParam param; // 0x30
			public ulong uniqueId; // 0x38
			public bool principalIdUseCurrentLogin; // 0x40
			public ulong principalId; // 0x48
			public int timeOut; // 0x50
			public NexPlugin.Ranking.GetRankingCB callback; // 0x58
	
			// Constructors
			public GETRANK_ARG() {} // 0x00DB2E50-0x00DB2E60
		}
	
		private class GETRANK_BYPIDLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9481
		{
			// Fields
			public NexPlugin.Ranking.RankingMode rankingMode; // 0x28
			public uint category; // 0x2C
			public RankingOrderParam param; // 0x30
			public ulong uniqueId; // 0x38
			public List<ulong> principalIdList; // 0x40
			public int timeOut; // 0x48
			public NexPlugin.Ranking.GetRankingCB callback; // 0x50
	
			// Constructors
			public GETRANK_BYPIDLIST_ARG() {} // 0x00DB3320-0x00DB3330
		}
	
		private class GETRANK_BYUIDLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9482
		{
			// Fields
			public NexPlugin.Ranking.RankingMode rankingMode; // 0x28
			public uint category; // 0x2C
			public RankingOrderParam param; // 0x30
			public ulong uniqueId; // 0x38
			public List<ulong> nexUniqueIdList; // 0x40
			public int timeOut; // 0x48
			public NexPlugin.Ranking.GetRankingCB callback; // 0x50
	
			// Constructors
			public GETRANK_BYUIDLIST_ARG() {} // 0x00DB36D0-0x00DB36E0
		}
	
		private class GET_APPROX_ARG : Common.CORE_ARG // TypeDefIndex: 9483
		{
			// Fields
			public uint category; // 0x28
			public RankingOrderParam param; // 0x30
			public uint score; // 0x38
			public ulong uniqueId; // 0x40
			public bool principalIdUseCurrentLogin; // 0x48
			public ulong principalId; // 0x50
			public int timeOut; // 0x58
			public NexPlugin.Ranking.GetApproxOrderCB callback; // 0x60
	
			// Constructors
			public GET_APPROX_ARG() {} // 0x00DB3AB0-0x00DB3AC0
		}
	
		private class UPLOADRANK_ARG : Common.CORE_ARG // TypeDefIndex: 9484
		{
			// Fields
			public RankingScoreData param; // 0x28
			public ulong uniqueId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public UPLOADRANK_ARG() {} // 0x00DB3F20-0x00DB3F30
		}
	
		private class DELETERANK_ARG : Common.CORE_ARG // TypeDefIndex: 9485
		{
			// Fields
			public ulong uniqueId; // 0x28
			public uint? category; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public DELETERANK_ARG() {} // 0x00DB4210-0x00DB4220
		}
	
		private class UPLOADCOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9486
		{
			// Fields
			public List<byte> param; // 0x28
			public ulong uniqueId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public UPLOADCOMMON_ARG() {} // 0x00DB46C0-0x00DB46D0
		}
	
		private class GETCOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9487
		{
			// Fields
			public ulong uniqueId; // 0x28
			public int timeOut; // 0x30
			public NexPlugin.Ranking.GetCommonDataCB callback; // 0x38
	
			// Constructors
			public GETCOMMON_ARG() {} // 0x00DB4980-0x00DB4990
		}
	
		private class DELETECOMMON_ARG : Common.CORE_ARG // TypeDefIndex: 9488
		{
			// Fields
			public ulong uniqueId; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public DELETECOMMON_ARG() {} // 0x00DB4C70-0x00DB4C80
		}
	
		private class GETSTATS_ARG : Common.CORE_ARG // TypeDefIndex: 9489
		{
			// Fields
			public uint category; // 0x28
			public RankingOrderParam param; // 0x30
			public NexPlugin.Ranking.StatsFlag flags; // 0x38
			public int timeOut; // 0x3C
			public NexPlugin.Ranking.GetStatsCB callback; // 0x40
	
			// Constructors
			public GETSTATS_ARG() {} // 0x00DB5050-0x00DB5060
		}
	
		private class CHANGE_ATTRIBUTE_ARG : Common.CORE_ARG // TypeDefIndex: 9490
		{
			// Fields
			public uint? category; // 0x28
			public RankingChangeAttributesParam param; // 0x30
			public ulong uniqueId; // 0x38
			public int timeOut; // 0x40
			public AsyncResultCB callback; // 0x48
	
			// Constructors
			public CHANGE_ATTRIBUTE_ARG() {} // 0x00DB5360-0x00DB5370
		}
	
		private class GET_CACHERANK_ARG : Common.CORE_ARG // TypeDefIndex: 9491
		{
			// Fields
			public uint category; // 0x28
			public RankingOrderParam param; // 0x30
			public int timeOut; // 0x38
			public NexPlugin.Ranking.GetCachedTopXRankingCB callback; // 0x40
	
			// Constructors
			public GET_CACHERANK_ARG() {} // 0x00DB5820-0x00DB5830
		}
	
		private class GET_CACHERANK_LIST_ARG : Common.CORE_ARG // TypeDefIndex: 9492
		{
			// Fields
			public List<uint> categorieList; // 0x28
			public List<RankingOrderParam> paramList; // 0x30
			public int timeOut; // 0x38
			public NexPlugin.Ranking.GetCachedTopXRankingsCB callback; // 0x40
	
			// Constructors
			public GET_CACHERANK_LIST_ARG() {} // 0x00DB5B60-0x00DB5B70
		}
	
		private enum Functions // TypeDefIndex: 9493
		{
			Group1 = 0,
			Group2 = 1,
			GetRanking = 2,
			DeleteScore = 3,
			DeleteAllScores = 4,
			UploadScore = 5,
			GetCommonData = 6,
			DeleteCommonData = 7,
			UploadCommonData = 8,
			GetStats = 9,
			GetApproxOrder = 10,
			GetRankingByPIDList = 11,
			GetRankingByUniqueIdList = 12,
			ChangeAttributes = 13,
			ChangeAllAttributes = 14,
			GetCachedTopXRanking = 15,
			GetCachedTopXRankings = 16
		}
	
		// Constructors
		public Ranking() {} // 0x00DB5F20-0x00DB5F90
		static Ranking() {} // 0x00DB5F90-0x00DB62C0
	
		// Methods
		public ASYNCSTATE GetRankingAsync(RankingGetRankingParam param, ulong uniqueId = 0 /* Metadata: 0x0063217A */, ulong principalId = 0 /* Metadata: 0x00632182 */, bool principalIdUseCurrentLogin = false /* Metadata: 0x0063218A */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063218B */) => default; // 0x00DB2C30-0x00DB2CD0
		public ASYNCSTATE GetRankingAsync(NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam param, ulong uniqueId = 0 /* Metadata: 0x0063218F */, ulong principalId = 0 /* Metadata: 0x00632197 */, bool principalIdUseCurrentLogin = false /* Metadata: 0x0063219F */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321A0 */) => default; // 0x00DB2D00-0x00DB2E50
		private ASYNCSTATE GetRankingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB2E60-0x00DB3080
		public ASYNCSTATE GetRankingByPIDListAsync(RankingGetRankingParam param, List<ulong> principalIdList, ulong uniqueId = 0 /* Metadata: 0x006321A4 */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321AC */) => default; // 0x00DB3150-0x00DB31E0
		public ASYNCSTATE GetRankingByPIDListAsync(List<ulong> principalIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam param, ulong uniqueId = 0 /* Metadata: 0x006321B0 */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321B8 */) => default; // 0x00DB31E0-0x00DB3320
		private ASYNCSTATE GetRankingByPIDListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB3330-0x00DB3500
		public ASYNCSTATE GetRankingByUIDListAsync(RankingGetRankingParam param, List<ulong> nexUniqueIdList, ulong uniqueId = 0 /* Metadata: 0x006321BC */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321C4 */) => default; // 0x00DB3500-0x00DB3590
		public ASYNCSTATE GetRankingByUIDListAsync(List<ulong> nexUniqueIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam param, ulong uniqueId = 0 /* Metadata: 0x006321C8 */, NexPlugin.Ranking.GetRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321D0 */) => default; // 0x00DB3590-0x00DB36D0
		private ASYNCSTATE GetRankingByUIDListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB36E0-0x00DB38B0
		public ASYNCSTATE GetApproxOrderAsync(RankingGetRankingParam param, uint score, ulong uniqueId = 0 /* Metadata: 0x006321D4 */, ulong principalId = 0 /* Metadata: 0x006321DC */, bool principalIdUseCurrentLogin = false /* Metadata: 0x006321E4 */, NexPlugin.Ranking.GetApproxOrderCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321E5 */) => default; // 0x00DB38B0-0x00DB3950
		public ASYNCSTATE GetApproxOrderAsync(uint category, RankingOrderParam param, uint score, ulong uniqueId = 0 /* Metadata: 0x006321E9 */, ulong principalId = 0 /* Metadata: 0x006321F1 */, bool principalIdUseCurrentLogin = false /* Metadata: 0x006321F9 */, NexPlugin.Ranking.GetApproxOrderCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006321FA */) => default; // 0x00DB3950-0x00DB3AB0
		private ASYNCSTATE GetApproxOrderAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB3AC0-0x00DB3CC0
		public ASYNCSTATE UploadScoreAsync(RankingScoreData scoreData, uint score, ulong uniqueId = 0 /* Metadata: 0x006321FE */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632206 */) => default; // 0x00DB3CC0-0x00DB3D40
		public ASYNCSTATE UploadScoreAsync(RankingScoreData param, ulong uniqueId = 0 /* Metadata: 0x0063220A */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632212 */) => default; // 0x00DB3E00-0x00DB3F20
		private ASYNCSTATE UploadScoreAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB3F30-0x00DB40D0
		public ASYNCSTATE DeleteScoreAsync(uint category, ulong uniqueId = 0 /* Metadata: 0x00632216 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063221E */) => default; // 0x00DB40D0-0x00DB4210
		public ASYNCSTATE DeleteScoreAsync(ulong uniqueId = 0 /* Metadata: 0x00632222 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063222A */) => default; // 0x00DB4220-0x00DB4330
		private ASYNCSTATE DeleteScoreAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB4330-0x00DB45A0
		public ASYNCSTATE UploadCommonDataAsync(List<byte> param, ulong uniqueId = 0 /* Metadata: 0x0063222E */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632236 */) => default; // 0x00DB45A0-0x00DB46C0
		private ASYNCSTATE UploadCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB46D0-0x00DB4870
		public ASYNCSTATE GetCommonDataAsync(ulong uniqueId = 0 /* Metadata: 0x0063223A */, NexPlugin.Ranking.GetCommonDataCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632242 */) => default; // 0x00DB4870-0x00DB4980
		private ASYNCSTATE GetCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB4990-0x00DB4B60
		public ASYNCSTATE DeleteCommonDataAsync(ulong uniqueId = 0 /* Metadata: 0x00632246 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063224E */) => default; // 0x00DB4B60-0x00DB4C70
		private ASYNCSTATE DeleteCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB4C80-0x00DB4E20
		public ASYNCSTATE GetStatsAsync(RankingGetRankingParam param, NexPlugin.Ranking.GetStatsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632252 */) => default; // 0x00DB4E20-0x00DB4ED0
		public ASYNCSTATE GetStatsAsync(uint category, RankingOrderParam param, NexPlugin.Ranking.StatsFlag flags, NexPlugin.Ranking.GetStatsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632256 */) => default; // 0x00DB4F20-0x00DB5050
		private ASYNCSTATE GetStatsAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB5060-0x00DB5210
		public ASYNCSTATE ChangeAttributesAsync(uint category, RankingChangeAttributesParam param, ulong uniqueId = 0 /* Metadata: 0x0063225A */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632262 */) => default; // 0x00DB5210-0x00DB5360
		public ASYNCSTATE ChangeAttributesAsync(RankingChangeAttributesParam param, ulong uniqueId = 0 /* Metadata: 0x00632266 */, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063226E */) => default; // 0x00DB5370-0x00DB5490
		private ASYNCSTATE ChangeAttributesAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB5490-0x00DB5700
		public ASYNCSTATE GetCachedTopXRankingAsync(uint category, RankingOrderParam param, NexPlugin.Ranking.GetCachedTopXRankingCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632272 */) => default; // 0x00DB5700-0x00DB5820
		private ASYNCSTATE GetCachedTopXRankingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB5830-0x00DB5A00
		public ASYNCSTATE GetCachedTopXRankingsAsync(List<uint> categorieList, RankingOrderParam param, NexPlugin.Ranking.GetCachedTopXRankingsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632276 */) => default; // 0x00DB5A00-0x00DB5B60
		public ASYNCSTATE GetCachedTopXRankingsAsync(List<uint> categorieList, List<RankingOrderParam> paramList, NexPlugin.Ranking.GetCachedTopXRankingsCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063227A */) => default; // 0x00DB5B70-0x00DB5C90
		private ASYNCSTATE GetCachedTopXRankingsAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB5C90-0x00DB5F20
		private new bool ApiCallsFrequencyCheck(int type) => default; // 0x00DB3080-0x00DB3150
	}
}
