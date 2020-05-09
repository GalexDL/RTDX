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

public class UserStatusManager : SingletonMonoBehaviour<UserStatusManager> // TypeDefIndex: 5189
{
	// Fields
	[SerializeField] // 0x006164E0-0x006164F0
	private GameObject m_DialogNotification; // 0x18
	[SerializeField] // 0x006164F0-0x00616500
	private GameObject m_DialogDetail; // 0x20
	// [Range] // 0x00616500-0x00616550
	[SerializeField] // 0x00616500-0x00616550
	private int m_DialogWaitFrame; // 0x28
	[SerializeField] // 0x00616550-0x00616560
	private bool m_DialogClick; // 0x2C
	private NexAssets.Subscriber m_Subscriber; // 0x30
	private const short NOTIFICATE_COUNT_MAX = 1800; // Metadata: 0x00611094
	private short m_NotificateCount; // 0x38
	public const string NOTIFICATE_FORMAT = "PID : {0}\n{1}"; // Metadata: 0x00611096
	private List<SubscriberUserStatusInfo> m_ListUserStatus; // 0x40
	private List<SubscriberUserStatusInfo> m_ListUpdate; // 0x48
	private bool m_CheckUpdate; // 0x50
	private NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB m_GetFriendUserStatusesCB; // 0x58
	private CompareUserStatusFunction m_CompareUserStatusFunction; // 0x60

	// Nested types
	public delegate bool CompareUserStatusFunction(SubscriberUserStatusInfo old, SubscriberUserStatusInfo update); // TypeDefIndex: 5190; 0x0073F860-0x0073FE40

	// Constructors
	public UserStatusManager() {} // 0x00740390-0x00740430

	// Methods
	public void SetGetFriendUserStatusesCB(NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback) {} // 0x0073EF50-0x0073EF60
	public void SetCompareUserStatusFunction(CompareUserStatusFunction func) {} // 0x0073EF60-0x0073EF70
	public void Init() {} // 0x0073EF70-0x0073EF80
	private void Awake() {} // 0x0073EF80-0x0073EFE0
	private void Start() {} // 0x0073EFE0-0x0073F080
	private void Update() {} // 0x0073F080-0x0073F140
	public void GetFriendUserStatuses(bool checkUpdate = false /* Metadata: 0x00611093 */) {} // 0x0073F140-0x0073F1E0
	public void GetFriendUserStatusesCallback(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos) {} // 0x0073F1E0-0x0073F380
	private void CheckUpdateUserStatus(List<SubscriberUserStatusInfo> infos) {} // 0x0073F380-0x0073F840
	public bool CompareUserStatus(SubscriberUserStatusInfo old, SubscriberUserStatusInfo update) => default; // 0x0073FE40-0x0073FFE0
	public List<ulong> GetFriendIdList() => default; // 0x0073FFE0-0x00740140
	public void UpdateUserStatus(SubscriberUserStatusParam param, AsyncResultCB callback = null) {} // 0x00740140-0x00740240
	public void UpdateUserStatus(List<SubscriberUserStatusParam> listParam, AsyncResultCB callback = null) {} // 0x00740240-0x007402E0
	public void UpdateUserStatusCallback(AsyncResult asyncResult) {} // 0x007402E0-0x00740340
	public void NotificationEventCallback(NotificationEvent notificationEvent) {} // 0x00740340-0x00740390
}

