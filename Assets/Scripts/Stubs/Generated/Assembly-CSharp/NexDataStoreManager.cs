/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using nn;
using nn.account;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NexDataStoreManager : SingletonMonoBehaviour<NexDataStoreManager> // TypeDefIndex: 5552
{
	// Fields
	private const int RetrySearchCount = 50; // Metadata: 0x00611C57
	protected static bool initialized_; // 0x00
	public string SearchID; // 0x18
	[SerializeField] // 0x00616870-0x00616880
	public GameObject ObjNexDataStoreDownloader; // 0x20
	private NexDataStoreDownloader m_NexDataStoreDownloader; // 0x28
	public GameObject ObjNexDataStoreUploader; // 0x30
	private NexDataStoreUploader m_NexDataStoreUploader; // 0x38
	public GameObject ObjNexUserStatusManager; // 0x40
	private UserStatusManager m_NexUserStatusManager; // 0x48
	private Uid userId_; // 0x50
	private ulong s_DataID; // 0x60
	private float check_time; // 0x68
	private bool isNowUploading; // 0x6C
	private bool isNowChecking; // 0x6D
	public ulong lastDataId; // 0x70
	private List<ulong> deleteIds; // 0x78
	private bool isNowSearching; // 0x80
	private int resultCode; // 0x84
	private uint totalCount; // 0x88
	private bool isRetryRandom; // 0x8C
	private bool isNowFriendSearching; // 0x8D
	private bool isNowAchieve; // 0x8E
	private byte[] lastAchieveSosData; // 0x90
	private FriendRescueTicket lastRescueTicket; // 0x98
	private string lastReviveTeamName; // 0xA0
	private int isNowCheck; // 0xA8
	private bool isNowDelete; // 0xAC
	private static List<ushort> encodeTable; // 0x08

	// Properties
	public static bool Initialized { get => default; } // 0x00F8B590-0x00F8B600 
	public NexDataStoreDownloader NexDataStoreDownloader { get => default; } // 0x00F8B600-0x00F8B6A0 
	public NexDataStoreUploader NexDataStoreUploader { get => default; } // 0x00F8B6A0-0x00F8B740 
	public UserStatusManager UserStatusManager { get => default; } // 0x00F8B740-0x00F8B7E0 

	// Constructors
	public NexDataStoreManager() {} // 0x00F8EEB0-0x00F8EF70
	static NexDataStoreManager() {} // 0x00F8EF70-0x00F8EFF0

	// Methods
	private void Awake() {} // 0x00F8B7E0-0x00F8BA20
	private void OnDestroy() {} // 0x00F8BAF0-0x00F8BB00
	private void Update() {} // 0x00F8BB00-0x00F8BB10
	private bool IsNetworkAvailable() => default; // 0x00F8BB10-0x00F8BB20
	private void setCheckTime() {} // 0x00F8BB20-0x00F8BB50
	private float getCheckTime() => default; // 0x00F8BB50-0x00F8BB80
	public bool CheckNowDeleteIds() => default; // 0x00F8BB80-0x00F8BBE0
	private static void ShowError(Result result) {} // 0x00F8BBE0-0x00F8BC90
	public bool UploadData(byte[] rescueData) => default; // 0x00F8BC90-0x00F8BEC0
	public bool PreCheckAndDeleteData() => default; // 0x00F8C220-0x00F8C3A0
	// [IteratorStateMachine] // 0x00620C60-0x00620CD0
	public IEnumerator SequenceUploadData(byte[] rescueData, Action<int> cb = null) => default; // 0x00F8C3B0-0x00F8C430
	public bool SearchData() => default; // 0x00F8C460-0x00F8C5F0
	public bool SearchDataRandom() => default; // 0x00F8C5F0-0x00F8C7B0
	// [IteratorStateMachine] // 0x00620CD0-0x00620D40
	public IEnumerator SequenceSearchData(Action<int> cb = null) => default; // 0x00F8C7B0-0x00F8C830
	public bool SearchFriendData(List<ulong> ids) => default; // 0x00F8C860-0x00F8C9F0
	public void GetFriendUserStatusesCallback(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos) {} // 0x00F8C9F0-0x00F8CA30
	public void GetFriendList() {} // 0x00F8CA30-0x00F8CB30
	// [IteratorStateMachine] // 0x00620D40-0x00620DB0
	public IEnumerator SequenceSearchFriendData(Action<int> cb = null) => default; // 0x00F8CB30-0x00F8CBB0
	// [IteratorStateMachine] // 0x00620DB0-0x00620E20
	public IEnumerator SequenceSearchIdData(Action<int> cb = null) => default; // 0x00F8CBE0-0x00F8CC60
	private void SearchDataCallBack2(AsyncResult asyncResult, DataStoreSearchResult result) {} // 0x00F8CC90-0x00F8D1A0
	private void PreSearchDataAndDeleteCallBack(AsyncResult asyncResult, DataStoreSearchResult result) {} // 0x00F8D250-0x00F8D420
	private void DeleteMetaDataCallback(AsyncResult asyncResult) {} // 0x00F8D420-0x00F8D4D0
	private void DeleteMetaDataSilenceCallback(AsyncResult asyncResult) {} // 0x00F8D4D0-0x00F8D500
	private void PostOrUpdateCallBack(AsyncResult asyncResult, string message) {} // 0x00F8D500-0x00F8D5D0
	public FriendRescueTicket GetLastRescueTicket() => default; // 0x00F8D5D0-0x00F8D5E0
	public string GetLastReviveTeamName() => default; // 0x00F8D5E0-0x00F8D5F0
	private void SetAchieveData(byte[] data) {} // 0x00F8D5F0-0x00F8D670
	// [IteratorStateMachine] // 0x00620E20-0x00620E90
	public IEnumerator SequenceAchieveData(byte[] rescueData, ulong data_id, Action<int> cb = null) => default; // 0x00F8D670-0x00F8D700
	// [IteratorStateMachine] // 0x00620E90-0x00620F00
	public IEnumerator SequenceCheckData(ulong data_id, Action<int> cb = null) => default; // 0x00F8D730-0x00F8D7B0
	// [IteratorStateMachine] // 0x00620F00-0x00620F70
	public IEnumerator SequenceDeleteData(ulong data_id, Action<int> cb = null) => default; // 0x00F8D7E0-0x00F8D860
	public bool SearchAndAchieveData(ulong dataId) => default; // 0x00F8D890-0x00F8DA20
	private void GetAndAchieveDataCallBack(AsyncResult asyncResult, DataStoreMetaInfo info) {} // 0x00F8DA30-0x00F8DC80
	private void AchieveMetaDataCallback(AsyncResult asyncResult) {} // 0x00F8DF60-0x00F8E010
	public bool SearchCheckData(ulong dataId) => default; // 0x00F8E010-0x00F8E1A0
	private void GetCheckDataCallBack(AsyncResult asyncResult, DataStoreMetaInfo info) {} // 0x00F8E1A0-0x00F8E3C0
	public bool SearchAndDeleteData(ulong dataId) => default; // 0x00F8E3C0-0x00F8E550
	private void GetAndDeleteDataCallBack(AsyncResult asyncResult, DataStoreMetaInfo info) {} // 0x00F8E550-0x00F8E790
	private static void makeEncodeTable() {} // 0x00F8E930-0x00F8EAD0
	public static string EncodeUserId(ulong id_number) => default; // 0x00F8EAD0-0x00F8EC50
	public static ulong DecodeUserId(string id) => default; // 0x00F8EC50-0x00F8EDE0
	public string GetMyUserId() => default; // 0x00F8EDE0-0x00F8EEB0
}

