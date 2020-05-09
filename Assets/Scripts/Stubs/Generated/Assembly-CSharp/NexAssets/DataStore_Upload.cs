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
	public class DataStore_Upload : DataStore_Core // TypeDefIndex: 9458
	{
		// Nested types
		private class POSTDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9459
		{
			// Fields
			public DataStorePreparePostParam param; // 0x28
			public byte[] dataArray; // 0x30
			public int timeOut; // 0x38
			public DataStore.PostCB callback; // 0x40
	
			// Constructors
			public POSTDATA_ARG() {} // 0x00DAEA20-0x00DAEA30
		}
	
		private class POSTMETAID_ARG : Common.CORE_ARG // TypeDefIndex: 9460
		{
			// Fields
			public DataStorePreparePostParam param; // 0x28
			public ulong dataId; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public POSTMETAID_ARG() {} // 0x00DAEFB0-0x00DAEFC0
		}
	
		private class POSTMETA_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9461
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public List<DataStorePreparePostParam> paramList; // 0x30
			public bool transactional; // 0x38
			public int timeOut; // 0x3C
			public DataStore.ResultListCB callback; // 0x40
	
			// Constructors
			public POSTMETA_BYLIST_ARG() {} // 0x00DAF2D0-0x00DAF2E0
		}
	
		private class COMPDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9462
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public COMPDATA_ARG() {} // 0x00DAF8F0-0x00DAF900
		}
	
		private class UPDATEDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9463
		{
			// Fields
			public DataStorePrepareUpdateParam param; // 0x28
			public byte[] dataArray; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public UPDATEDATA_ARG() {} // 0x00DAFBC0-0x00DAFBD0
		}
	
		private class CHANGEMETA_ARG : Common.CORE_ARG // TypeDefIndex: 9464
		{
			// Fields
			public DataStoreChangeMetaParam param; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public CHANGEMETA_ARG() {} // 0x00DAFE90-0x00DAFEA0
		}
	
		private class CHANGEMETA_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9465
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public List<DataStoreChangeMetaParam> paramList; // 0x30
			public bool transactional; // 0x38
			public int timeOut; // 0x3C
			public DataStore.ResultListCB callback; // 0x40
	
			// Constructors
			public CHANGEMETA_BYLIST_ARG() {} // 0x00DB01B0-0x00DB01C0
		}
	
		private class PERPETUATE_ARG : Common.CORE_ARG // TypeDefIndex: 9466
		{
			// Fields
			public ulong dataId; // 0x28
			public ushort slotId; // 0x30
			public bool deleteFlag; // 0x32
			public int timeOut; // 0x34
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public PERPETUATE_ARG() {} // 0x00DB0680-0x00DB0690
		}
	
		private class UNPERPETUATE_ARG : Common.CORE_ARG // TypeDefIndex: 9467
		{
			// Fields
			public ushort slotId; // 0x28
			public bool deleteFlag; // 0x2A
			public int timeOut; // 0x2C
			public AsyncResultCB callback; // 0x30
	
			// Constructors
			public UNPERPETUATE_ARG() {} // 0x00DB0960-0x00DB0970
		}
	
		private class RATING_ARG : Common.CORE_ARG // TypeDefIndex: 9468
		{
			// Fields
			public DataStoreRatingTarget target; // 0x28
			public DataStoreRateObjectParam param; // 0x30
			public int timeOut; // 0x38
			public DataStore.RatingInfoCB callback; // 0x40
	
			// Constructors
			public RATING_ARG() {} // 0x00DB0C30-0x00DB0C40
		}
	
		private class RATING_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9469
		{
			// Fields
			public List<DataStoreRatingTarget> targetList; // 0x28
			public List<DataStoreRateObjectParam> paramList; // 0x30
			public bool transactional; // 0x38
			public int timeOut; // 0x3C
			public DataStore.RatingInfoListCB callback; // 0x40
	
			// Constructors
			public RATING_BYLIST_ARG() {} // 0x00DB0F60-0x00DB0F70
		}
	
		private class RESETRATING_ARG : Common.CORE_ARG // TypeDefIndex: 9470
		{
			// Fields
			public DataStoreRatingTarget param; // 0x28
			public ulong accessPassword; // 0x30
			public int timeOut; // 0x38
			public AsyncResultCB callback; // 0x40
	
			// Constructors
			public RESETRATING_ARG() {} // 0x00DB1480-0x00DB1490
		}
	
		private class RESETRATINGALLSLOT_ARG : Common.CORE_ARG // TypeDefIndex: 9471
		{
			// Fields
			public ulong dataId; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public RESETRATINGALLSLOT_ARG() {} // 0x00DB1740-0x00DB1750
		}
	
		private class RESETRATING_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9472
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public bool transactional; // 0x30
			public int timeOut; // 0x34
			public DataStore.ResultListCB callback; // 0x38
	
			// Constructors
			public RESETRATING_BYLIST_ARG() {} // 0x00DB1A10-0x00DB1A20
		}
	
		private class RATEWITH_POST_ARG : Common.CORE_ARG // TypeDefIndex: 9473
		{
			// Fields
			public DataStoreRatingTarget target; // 0x28
			public DataStoreRateObjectParam rateParam; // 0x30
			public DataStorePreparePostParam postParam; // 0x38
			public int timeOut; // 0x40
			public DataStore.RatingInfoCB callback; // 0x48
	
			// Constructors
			public RATEWITH_POST_ARG() {} // 0x00DB1D10-0x00DB1D20
		}
	
		private class RATEWITH_POST_LIST_ARG : Common.CORE_ARG // TypeDefIndex: 9474
		{
			// Fields
			public List<DataStoreRatingTarget> targetList; // 0x28
			public List<DataStoreRateObjectParam> rateParamList; // 0x30
			public List<DataStorePreparePostParam> postParamList; // 0x38
			public bool transactional; // 0x40
			public int timeOut; // 0x44
			public DataStore.RatingInfoListCB callback; // 0x48
	
			// Constructors
			public RATEWITH_POST_LIST_ARG() {} // 0x00DB2080-0x00DB2090
		}
	
		private class TOUCH_OBJECT_ARG : Common.CORE_ARG // TypeDefIndex: 9475
		{
			// Fields
			public DataStoreTouchObjectParam param; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public TOUCH_OBJECT_ARG() {} // 0x00DB2620-0x00DB2630
		}
	
		// Constructors
		public DataStore_Upload() {} // 0x00DB27D0-0x00DB2890
	
		// Methods
		public ASYNCSTATE PostObjectAsync(DataStorePreparePostParam param, byte[] dataArray, DataStore.PostCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632122 */) => default; // 0x00DAE900-0x00DAEA20
		private ASYNCSTATE PostObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAEA30-0x00DAEBE0
		public ASYNCSTATE PostMetaAsync(DataStorePreparePostParam param, DataStore.PostCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632126 */) => default; // 0x00DAEBE0-0x00DAECF0
		private ASYNCSTATE PostMetaAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAECF0-0x00DAEE90
		public ASYNCSTATE PostMetaByIdAsync(ulong dataId, DataStorePreparePostParam param, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063212A */) => default; // 0x00DAEE90-0x00DAEFB0
		private ASYNCSTATE PostMetaByIdAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAEFC0-0x00DAF160
		public ASYNCSTATE PostMetaByDataListAsync(List<ulong> dataIdList, DataStorePreparePostParam param, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063212E */) => default; // 0x00DAF160-0x00DAF2D0
		public ASYNCSTATE PostMetaByDataListAsync(Dictionary<ulong, DataStorePreparePostParam> paramList, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632132 */) => default; // 0x00DAF2E0-0x00DAF490
		private ASYNCSTATE PostMetaByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAF490-0x00DAF7E0
		public ASYNCSTATE CompleteSuspendedPostObjectAsync(List<ulong> dataIdList, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632136 */) => default; // 0x00DAF7E0-0x00DAF8F0
		private ASYNCSTATE CompleteSuspendedPostObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAF900-0x00DAFAA0
		public ASYNCSTATE UpdateObjectAsync(DataStorePrepareUpdateParam param, byte[] dataArray, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063213A */) => default; // 0x00DAFAA0-0x00DAFBC0
		private ASYNCSTATE UpdateObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAFBD0-0x00DAFD80
		public ASYNCSTATE ChangeMetaAsync(DataStoreChangeMetaParam param, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063213E */) => default; // 0x00DAFD80-0x00DAFE90
		private ASYNCSTATE ChangeMetaAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAFEA0-0x00DB0040
		public ASYNCSTATE ChangeMetaByDataListAsync(List<ulong> dataIdList, DataStoreChangeMetaParam param, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632142 */) => default; // 0x00DB0040-0x00DB01B0
		public ASYNCSTATE ChangeMetaByDataListAsync(List<DataStoreChangeMetaParam> paramList, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632146 */) => default; // 0x00DB01C0-0x00DB02E0
		private ASYNCSTATE ChangeMetaByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB02E0-0x00DB0550
		public ASYNCSTATE PerpetuateObjectAsync(ushort slotId, ulong dataId, bool deleteFlag, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063214A */) => default; // 0x00DB0550-0x00DB0680
		private ASYNCSTATE PerpetuateObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB0690-0x00DB0840
		public ASYNCSTATE UnperpetuateObjectAsync(ushort slotId, bool deleteFlag, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063214E */) => default; // 0x00DB0840-0x00DB0960
		private ASYNCSTATE UnperpetuateObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB0970-0x00DB0B10
		public ASYNCSTATE RateObjectAsync(DataStoreRatingTarget target, DataStoreRateObjectParam param, DataStore.RatingInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632152 */) => default; // 0x00DB0B10-0x00DB0C30
		private ASYNCSTATE RateObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB0C40-0x00DB0DF0
		public ASYNCSTATE RateObjectByDataListAsync(List<DataStoreRatingTarget> targetList, DataStoreRateObjectParam param, bool transactional, DataStore.RatingInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632156 */) => default; // 0x00DB0DF0-0x00DB0F60
		public ASYNCSTATE RateObjectByDataListAsync(List<DataStoreRatingTarget> targetList, List<DataStoreRateObjectParam> paramList, bool transactional, DataStore.RatingInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063215A */) => default; // 0x00DB0F70-0x00DB10A0
		private ASYNCSTATE RateObjectByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB10A0-0x00DB1360
		public ASYNCSTATE ResetRatingAsync(DataStoreRatingTarget param, ulong accessPassword, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063215E */) => default; // 0x00DB1360-0x00DB1480
		private ASYNCSTATE ResetRatingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB1490-0x00DB1630
		public ASYNCSTATE ResetRatingAllSlotAsync(ulong dataId, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632162 */) => default; // 0x00DB1630-0x00DB1740
		private ASYNCSTATE ResetRatingAllSlotAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB1750-0x00DB18F0
		public ASYNCSTATE ResetRatingByDataListAsync(List<ulong> dataIdList, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632166 */) => default; // 0x00DB18F0-0x00DB1A10
		private ASYNCSTATE ResetRatingByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB1A20-0x00DB1BF0
		public ASYNCSTATE RateObjectWithPostingAsync(DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, DataStore.RatingInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063216A */) => default; // 0x00DB1BF0-0x00DB1D10
		private ASYNCSTATE RateObjectWithPostingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB1D20-0x00DB1ED0
		public ASYNCSTATE RateObjectsWithPostingAsync(List<DataStoreRatingTarget> targetList, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, bool transactional, DataStore.RatingInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063216E */) => default; // 0x00DB1ED0-0x00DB2080
		public ASYNCSTATE RateObjectsWithPostingAsync(List<DataStoreRatingTarget> targetList, List<DataStoreRateObjectParam> rateParamList, List<DataStorePreparePostParam> postParamList, bool transactional, DataStore.RatingInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632172 */) => default; // 0x00DB2090-0x00DB21D0
		private ASYNCSTATE RateObjectsWithPostingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB21D0-0x00DB2510
		public ASYNCSTATE TouchObjectAsync(DataStoreTouchObjectParam param, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632176 */) => default; // 0x00DB2510-0x00DB2620
		private ASYNCSTATE TouchObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DB2630-0x00DB27D0
	}
}
