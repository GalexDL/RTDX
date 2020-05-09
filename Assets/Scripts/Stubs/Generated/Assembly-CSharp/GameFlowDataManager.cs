/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00609290-0x006092D0
[ExecuteInEditMode] // 0x00609290-0x006092D0
public class GameFlowDataManager : SingletonMonoBehaviour<GameFlowDataManager> // TypeDefIndex: 4814
{
	// Fields
	private GameObject putLoadObjRoot_; // 0x18
	private ScriptDataStore<GameFlowData> scriptDataStore_; // 0x20
	public GameFlowPlayer flowPlayer_; // 0x28
	public List<string> FlowDataList; // 0x30
	private string requestNextFlowLabel_; // 0x38
	public const string debugFlowMessageCsvPath = "%PEGASUS%\\balance\\message\\jp\\common_message\\debug_flow_menu.csv"; // Metadata: 0x00610B3E

	// Properties
	public ScriptDataStore<GameFlowData> DataStore { get => default; } // 0x00A5EA20-0x00A5EA30 
	public string RequestNextFlowLabel { get => default; set {} } // 0x00A5ABC0-0x00A5ABD0 0x00A5AC40-0x00A5AC50
	public GameFlow_GlobalDungeonData GlobalDungeonData { get => default; } // 0x00A5EA30-0x00A5EAA0 
	public GameFlowPlayer FlowPlayerCommon { get => default; } // 0x00A5EB80-0x00A5EB90 

	// Events
	public event GameFlowPlayer_Start onGameFlowPlayer_Start;
	public event GameFlowPlayer_End onGameFlowPlayer_End;
	public event GameFlowPlayer_ScriptDataUpdate onGameFlowPlayer_ScriptDataUpdate;
	public event GameFlowPlayer_ScriptBlobUpdate onGameFlowPlayer_ScriptBlobUpdate;

	// Nested types
	[Serializable]
	public class GameFlow_GlobalDungeonData // TypeDefIndex: 4815
	{
		// Fields
		public bool scenarioDg_waypointFirst; // 0x10
		public bool scenarioDg_bossFirst; // 0x11
		public bool scenarioDg_eventFloorFirst; // 0x12

		// Constructors
		public GameFlow_GlobalDungeonData() {} // 0x00A61BF0-0x00A61C10

		// Methods
		public void Reset() {} // 0x00A61BD0-0x00A61BF0
	}

	public delegate void GameFlowPlayer_Start(); // TypeDefIndex: 4816; 0x00A5FF50-0x00A602C0

	public delegate void GameFlowPlayer_End(); // TypeDefIndex: 4817; 0x00A602D0-0x00A60640

	public delegate void GameFlowPlayer_ScriptDataUpdate(ScriptData data); // TypeDefIndex: 4818; 0x00A60640-0x00A60C00

	public delegate void GameFlowPlayer_ScriptBlobUpdate(ScriptDataBlobBase data); // TypeDefIndex: 4819; 0x00A60C00-0x00A611C0

	// Constructors
	public GameFlowDataManager() {} // 0x00A611C0-0x00A612B0

	// Methods
	private void OnEnable() {} // 0x00A5E670-0x00A5E940
	private void OnDisable() {} // 0x00A5E950-0x00A5EA20
	public GameFlowData FindGameFlowData(string flowDataName) => default; // 0x00A5EB90-0x00A5ECF0
	public IGameFlowPlayable FindGameFlowPlayableById(string flowId) => default; // 0x00A5ECF0-0x00A5EF20
	public string GetGameFlowId(IGameFlowPlayable flow) => default; // 0x00A5EF30-0x00A5EF90
	public bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00A5EF90-0x00A5F130
	public GameFlowBlob_EntryPoint FindEntryPoint(string entryLabel) => default; // 0x00A5F190-0x00A5F400
	public GameFlowBlob_SubFlow FindSubFlow(string subFlowId) => default; // 0x00A5F410-0x00A5F680
	public void FlowIdUpdate() {} // 0x00A5F690-0x00A5F6A0
	public void TextIdAutoSet() {} // 0x00A5F6A0-0x00A5F6B0
	public void TextIdCsvWrite() {} // 0x00A5F6B0-0x00A5F6C0
	public void Raise_GameFlowPlayer_Start() {} // 0x00A5FF40-0x00A5FF50
	public void Raise_GameFlowPlayer_End() {} // 0x00A602C0-0x00A602D0
	public void Raise_GameFlowPlayer_ScriptDataUpdate(ScriptData data) {} // 0x00A5B580-0x00A5B590
	public void Raise_GameFlowPlayer_ScriptBlobUpdate(ScriptDataBlobBase data) {} // 0x00A59E60-0x00A59E70
}

