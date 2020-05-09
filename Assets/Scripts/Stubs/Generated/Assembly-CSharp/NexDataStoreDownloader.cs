/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexAssets;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NexDataStoreDownloader : MonoBehaviour // TypeDefIndex: 5186
{
	// Fields
	[SerializeField] // 0x006164A0-0x006164B0
	private DataStore_Download m_Download; // 0x18
	[SerializeField] // 0x006164B0-0x006164C0
	private NexAssets.DataStoreSearchParam searchParam; // 0x20
	private bool paramInited; // 0x28
	private DataStore.SearchObjectCB m_SearchDataCallBack; // 0x30
	private DataStore.GetObjectCB m_GetDataCallBack; // 0x38
	private AsyncResultCB m_DeleteDataCallBack; // 0x40
	private DataStore.GetMetaCB m_GetMetaCallBack; // 0x48

	// Properties
	public DataStore.SearchObjectCB SearchDataCB { set {} } // 0x00DBD160-0x00DBD170
	public DataStore.GetObjectCB GetDataCB { set {} } // 0x00DBD170-0x00DBD180
	public AsyncResultCB DeleteDataCB { set {} } // 0x00DBD180-0x00DBD190
	public DataStore.GetMetaCB GetMetaCB { set {} } // 0x00DBD190-0x00DBD1A0

	// Constructors
	public NexDataStoreDownloader() {} // 0x00DBE240-0x00DBE250

	// Methods
	private void Awake() {} // 0x00DBD080-0x00DBD0E0
	private void OnValidate() {} // 0x00DBD0E0-0x00DBD160
	public void Init() {} // 0x00DBD1A0-0x00DBD2D0
	public bool SetParam() => default; // 0x00DBD2D0-0x00DBD420
	public bool SearchData(bool is_order_desc = true /* Metadata: 0x0061107E */) => default; // 0x00DBD420-0x00DBD570
	public bool SearchDataOffset(uint offset, bool is_order_desc = true /* Metadata: 0x0061107F */) => default; // 0x00DBD570-0x00DBD6E0
	public bool SearchData(DateTime search_date, bool is_order_desc = true /* Metadata: 0x00611080 */) => default; // 0x00DBD6E0-0x00DBD830
	public bool SearchFriendData(List<ulong> owner_ids) => default; // 0x00DBD830-0x00DBD930
	private void SearchCallback(AsyncResult asyncResult, DataStoreSearchResult result) {} // 0x00DBD930-0x00DBD980
	public void GetData(ulong dataId) {} // 0x00DBD980-0x00DBDAE0
	private void GetCallback(AsyncResult asyncResult, byte[] buf) {} // 0x00DBDAE0-0x00DBDB30
	private void GetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info) {} // 0x00DBDB30-0x00DBDB80
	public void DeleteData(ulong dataId) {} // 0x00DBDB80-0x00DBDC90
	private void DeleteCallback(AsyncResult asyncResult) {} // 0x00DBDC90-0x00DBDCE0
	public bool GetAndAchiveData(ulong dataId) => default; // 0x00DBDCE0-0x00DBDE00
	public bool GetCheckData(ulong dataId) => default; // 0x00DBDE00-0x00DBDF30
	public bool GetAndDeleteData(ulong dataId) => default; // 0x00DBDF30-0x00DBE050
	public bool SearchOwnData() => default; // 0x00DBE050-0x00DBE240
}

