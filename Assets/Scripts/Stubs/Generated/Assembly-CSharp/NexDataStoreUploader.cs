/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexAssets;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NexDataStoreUploader : MonoBehaviour // TypeDefIndex: 5187
{
	// Fields
	private const ushort RESCUE_PERIOD = 8; // Metadata: 0x00611091
	[SerializeField] // 0x006164C0-0x006164D0
	private DataStore_Upload m_Upload; // 0x18
	[SerializeField] // 0x006164D0-0x006164E0
	private NexAssets.DataStorePreparePostParam postParam; // 0x20
	private bool paramInited; // 0x28
	private DataStore.PostCB m_PostDataCallBack; // 0x30
	private AsyncResultCB m_UpdateDataCallBack; // 0x38
	private AsyncResultCB m_UpdateMetaCallBack; // 0x40

	// Properties
	public DataStore.PostCB PostDataCB { set {} } // 0x00F8BED0-0x00F8BEE0
	public AsyncResultCB UpdateDataCB { set {} } // 0x00F8BEF0-0x00F8BF00
	public AsyncResultCB UpdateMetaCB { set {} } // 0x00F8DC80-0x00F8DC90

	// Constructors
	public NexDataStoreUploader() {} // 0x00F909F0-0x00F90A00

	// Methods
	private void Awake() {} // 0x00F90660-0x00F906C0
	private void OnValidate() {} // 0x00F906C0-0x00F906E0
	public void Init() {} // 0x00F8BA20-0x00F8BAF0
	public bool UploadData(byte[] data, ulong dataID, int type = 0 /* Metadata: 0x00611081 */) => default; // 0x00F8BF00-0x00F8C220
	public bool UpdateMetaData(byte[] data, ulong dataID, int type = 0 /* Metadata: 0x00611085 */) => default; // 0x00F8DC90-0x00F8DF60
	public bool UpdateMetaData(ulong dataID, int type = 0 /* Metadata: 0x00611089 */, int period = 8 /* Metadata: 0x0061108D */) => default; // 0x00F8E790-0x00F8E930
	private void PostCallback(AsyncResult asyncResult, ulong dataId) {} // 0x00F909C0-0x00F909D0
	private void UpdateCallback(AsyncResult asyncResult) {} // 0x00F909D0-0x00F909E0
	private void UpdateMetaCallback(AsyncResult asyncResult) {} // 0x00F909E0-0x00F909F0
}

