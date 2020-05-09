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
	public class DataStore_Download : DataStore_Core // TypeDefIndex: 9442
	{
		// Nested types
		private class SEARCHDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9443
		{
			// Fields
			public DataStoreSearchParam param; // 0x28
			public int timeOut; // 0x30
			public DataStore.SearchObjectCB callback; // 0x38
	
			// Constructors
			public SEARCHDATA_ARG() {} // 0x00DABA90-0x00DABAA0
		}
	
		private class SEARCHDATA_LIGHT_ARG : Common.CORE_ARG // TypeDefIndex: 9444
		{
			// Fields
			public DataStoreSearchParam param; // 0x28
			public int timeOut; // 0x30
			public DataStore.SearchObjectCB callback; // 0x38
	
			// Constructors
			public SEARCHDATA_LIGHT_ARG() {} // 0x00DABD70-0x00DABD80
		}
	
		private class GETDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9445
		{
			// Fields
			public ulong bufSize; // 0x28
			public DataStorePrepareGetParam param; // 0x30
			public int timeOut; // 0x38
			public DataStore.GetObjectCB callback; // 0x40
	
			// Constructors
			public GETDATA_ARG() {} // 0x00DAC060-0x00DAC070
		}
	
		private class DELETEDATA_ARG : Common.CORE_ARG // TypeDefIndex: 9446
		{
			// Fields
			public DataStoreDeleteParam param; // 0x28
			public int timeOut; // 0x30
			public AsyncResultCB callback; // 0x38
	
			// Constructors
			public DELETEDATA_ARG() {} // 0x00DAC340-0x00DAC350
		}
	
		private class DELETEDATA_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9447
		{
			// Fields
			public List<DataStoreDeleteParam> paramList; // 0x28
			public bool transactional; // 0x30
			public int timeOut; // 0x34
			public DataStore.ResultListCB callback; // 0x38
	
			// Constructors
			public DELETEDATA_BYLIST_ARG() {} // 0x00DAC610-0x00DAC620
		}
	
		private class GETMETA_ARG : Common.CORE_ARG // TypeDefIndex: 9448
		{
			// Fields
			public DataStoreGetMetaParam param; // 0x28
			public int timeOut; // 0x30
			public DataStore.GetMetaCB callback; // 0x38
	
			// Constructors
			public GETMETA_ARG() {} // 0x00DAC900-0x00DAC910
		}
	
		private class GETMETA_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9449
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public List<DataStoreGetMetaParam> paramList; // 0x30
			public int timeOut; // 0x38
			public DataStore.GetMetaListCB callback; // 0x40
	
			// Constructors
			public GETMETA_BYLIST_ARG() {} // 0x00DACC30-0x00DACC40
		}
	
		private class GETPERSISTENCE_ARG : Common.CORE_ARG // TypeDefIndex: 9450
		{
			// Fields
			public ulong principalId; // 0x28
			public ushort slotId; // 0x30
			public int timeOut; // 0x34
			public DataStore.GetPersistenceInfoCB callback; // 0x38
	
			// Constructors
			public GETPERSISTENCE_ARG() {} // 0x00DAD170-0x00DAD180
		}
	
		private class GETPERSISTENCE_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9451
		{
			// Fields
			public ulong principalId; // 0x28
			public List<ushort> slotIdList; // 0x30
			public int timeOut; // 0x38
			public DataStore.GetPersistenceInfoListCB callback; // 0x40
	
			// Constructors
			public GETPERSISTENCE_BYLIST_ARG() {} // 0x00DAD470-0x00DAD480
		}
	
		private class GETRATING_ARG : Common.CORE_ARG // TypeDefIndex: 9452
		{
			// Fields
			public DataStoreRatingTarget param; // 0x28
			public ulong accessPassword; // 0x30
			public int timeOut; // 0x38
			public DataStore.RatingInfoCB callback; // 0x40
	
			// Constructors
			public GETRATING_ARG() {} // 0x00DAD790-0x00DAD7A0
		}
	
		private class GETRATINGALLSLOT_ARG : Common.CORE_ARG // TypeDefIndex: 9453
		{
			// Fields
			public ulong dataId; // 0x28
			public int timeOut; // 0x30
			public DataStore.RatingInfoAllSlotCB callback; // 0x38
	
			// Constructors
			public GETRATINGALLSLOT_ARG() {} // 0x00DADA60-0x00DADA70
		}
	
		private class GETRATING_BYDATALIST_ARG : Common.CORE_ARG // TypeDefIndex: 9454
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public int timeOut; // 0x30
			public DataStore.RatingInfosListCB callback; // 0x38
	
			// Constructors
			public GETRATING_BYDATALIST_ARG() {} // 0x00DAE050-0x00DAE060
		}
	
		private class GETRATINGWITHLOG_ARG : Common.CORE_ARG // TypeDefIndex: 9455
		{
			// Fields
			public DataStoreRatingTarget param; // 0x28
			public ulong accessPassword; // 0x30
			public int timeOut; // 0x38
			public DataStore.RatingInfoWithLogCB callback; // 0x40
	
			// Constructors
			public GETRATINGWITHLOG_ARG() {} // 0x00DADD60-0x00DADD70
		}
	
		private class GETPASS_ARG : Common.CORE_ARG // TypeDefIndex: 9456
		{
			// Fields
			public ulong dataId; // 0x28
			public int timeOut; // 0x30
			public DataStore.GetPasswordInfoCB callback; // 0x38
	
			// Constructors
			public GETPASS_ARG() {} // 0x00DAE360-0x00DAE370
		}
	
		private class GETPASS_BYLIST_ARG : Common.CORE_ARG // TypeDefIndex: 9457
		{
			// Fields
			public List<ulong> dataIdList; // 0x28
			public int timeOut; // 0x30
			public DataStore.GetPasswordInfoListCB callback; // 0x38
	
			// Constructors
			public GETPASS_BYLIST_ARG() {} // 0x00DAE640-0x00DAE650
		}
	
		// Constructors
		public DataStore_Download() {} // 0x00DAE840-0x00DAE900
	
		// Methods
		public ASYNCSTATE SearchObjectAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320E2 */) => default; // 0x00DAB980-0x00DABA90
		private ASYNCSTATE SearchObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DABAA0-0x00DABC60
		public ASYNCSTATE SearchObjectLightAsync(DataStoreSearchParam param, DataStore.SearchObjectCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320E6 */) => default; // 0x00DABC60-0x00DABD70
		private ASYNCSTATE SearchObjectLightAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DABD80-0x00DABF40
		public ASYNCSTATE GetObjectAsync(DataStorePrepareGetParam param, ulong bufSize, DataStore.GetObjectCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320EA */) => default; // 0x00DABF40-0x00DAC060
		private ASYNCSTATE GetObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAC070-0x00DAC230
		public ASYNCSTATE DeleteObjectAsync(DataStoreDeleteParam param, AsyncResultCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320EE */) => default; // 0x00DAC230-0x00DAC340
		private ASYNCSTATE DeleteObjectAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAC350-0x00DAC4F0
		public ASYNCSTATE DeleteObjectByDataListAsync(List<DataStoreDeleteParam> paramList, bool transactional, DataStore.ResultListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320F2 */) => default; // 0x00DAC4F0-0x00DAC610
		private ASYNCSTATE DeleteObjectByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAC620-0x00DAC7F0
		public ASYNCSTATE GetMetaAsync(DataStoreGetMetaParam param, DataStore.GetMetaCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320F6 */) => default; // 0x00DAC7F0-0x00DAC900
		private ASYNCSTATE GetMetaAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAC910-0x00DACAD0
		public ASYNCSTATE GetMetaByDataListAsync(List<ulong> dataIdList, DataStoreGetMetaParam param, DataStore.GetMetaListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320FA */) => default; // 0x00DACAD0-0x00DACC30
		public ASYNCSTATE GetMetaByDataListAsync(List<DataStoreGetMetaParam> paramList, DataStore.GetMetaListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x006320FE */) => default; // 0x00DACC40-0x00DACD50
		private ASYNCSTATE GetMetaByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DACD50-0x00DAD050
		public ASYNCSTATE GetPersistenceInfoAsync(ulong principalId, ushort slotId, DataStore.GetPersistenceInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632102 */) => default; // 0x00DAD050-0x00DAD170
		private ASYNCSTATE GetPersistenceInfoAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAD180-0x00DAD350
		public ASYNCSTATE GetPersistenceInfoByDataListAsync(ulong principalId, List<ushort> slotIdList, DataStore.GetPersistenceInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632106 */) => default; // 0x00DAD350-0x00DAD470
		private ASYNCSTATE GetPersistenceInfoByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAD480-0x00DAD670
		public ASYNCSTATE GetRatingAsync(DataStoreRatingTarget param, ulong accessPassword, DataStore.RatingInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063210A */) => default; // 0x00DAD670-0x00DAD790
		private ASYNCSTATE GetRatingAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAD7A0-0x00DAD950
		public ASYNCSTATE GetRatingAllSlotAsync(ulong dataId, DataStore.RatingInfoAllSlotCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063210E */) => default; // 0x00DAD950-0x00DADA60
		private ASYNCSTATE GetRatingAllSlotAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DADA70-0x00DADC40
		public ASYNCSTATE GetRatingWithLogAsync(DataStoreRatingTarget param, ulong accessPassword, DataStore.RatingInfoWithLogCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632112 */) => default; // 0x00DADC40-0x00DADD60
		private ASYNCSTATE GetRatingWithLogAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DADD70-0x00DADF40
		public ASYNCSTATE GetRatingByDataListAsync(List<ulong> dataIdList, DataStore.RatingInfosListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x00632116 */) => default; // 0x00DADF40-0x00DAE050
		private ASYNCSTATE GetRatingByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAE060-0x00DAE250
		public ASYNCSTATE GetPasswordInfoAsync(ulong dataId, DataStore.GetPasswordInfoCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063211A */) => default; // 0x00DAE250-0x00DAE360
		private ASYNCSTATE GetPasswordInfoAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAE370-0x00DAE530
		public ASYNCSTATE GetPasswordInfoByDataListAsync(List<ulong> dataIdList, DataStore.GetPasswordInfoListCB callback = null, IntPtr pNgsFacade = default, int timeOut = 0 /* Metadata: 0x0063211E */) => default; // 0x00DAE530-0x00DAE640
		private ASYNCSTATE GetPasswordInfoByDataListAsync_(AsyncResult asyncResult, CORE_ARG param) => default; // 0x00DAE650-0x00DAE840
	}
}
