/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActCommandSystem;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScriptDataPlayer // TypeDefIndex: 4509
{
	// Fields
	private PlayMode_ playMode_; // 0x10
	private ActAssetBlob lastLoadActAssetBlob_; // 0x18
	private string lastLoadActAssetBlobText_; // 0x20
	private string logText_; // 0x28
	public Action OneLoopPreHookCb; // 0x30
	public Action OneLoopPostHookCb; // 0x38
	private bool bRunPreviewOneCommand_; // 0x40
	private bool bNotifyStopRunPreviewOneCommand_; // 0x41

	// Properties
	public bool IsPlaying { get => default; } // 0x009D2960-0x009D2980 
	public bool IsStop { get => default; } // 0x009D29C0-0x009D29D0 
	public string LogText { get => default; } // 0x009D29D0-0x009D29E0 

	// Nested types
	private enum PlayMode_ // TypeDefIndex: 4510
	{
		None = 0,
		Playing = 1,
		PlayStopping = 2,
		PlayStopRequest = 3
	}

	[Serializable]
	public class Param // TypeDefIndex: 4511
	{
		// Fields
		public bool bPlayContinueNext; // 0x10
		public bool bStopScenePartition; // 0x11
		public bool bNoApplyScenePartitionFade; // 0x12
		public bool bAfterEndCloseMessage; // 0x13
		public bool bPlayEndAllTaskWait; // 0x14
		public bool bUseManualGC; // 0x15

		// Constructors
		public Param() {} // 0x009D9240-0x009D9250
	}

	public class PlayerContext // TypeDefIndex: 4512
	{
		// Fields
		public string scriptName; // 0x10
		public ScriptData ownerScriptData; // 0x18
		public Action endCb; // 0x20
		public Action errorCb; // 0x28
		public Action<string> logCb; // 0x30
		public Action<string> logErrorCb; // 0x38
		public Param param; // 0x40
		public Action stepCb; // 0x48
		public Func<bool> forceExitCheck; // 0x50
		public Func<bool> exitRequestCheck; // 0x58
		public ScriptDataBlobBase gotoBlob; // 0x60
		public PlayerTaskSys taskSys; // 0x68
		public Pega_TimelinePlayer timelinePlayer; // 0x70
		public AssetCache assetCache; // 0x78

		// Constructors
		public PlayerContext() {} // 0x009D4F60-0x009D50B0

		// Methods
		public PlayerContext Clone() => default; // 0x009D9250-0x009D9320
		public void BranchFlowTo(string branchLabel) {} // 0x009D9320-0x009D94F0
	}

	public class AssetCache // TypeDefIndex: 4513
	{
		// Fields
		private List<string> preloadBundles_; // 0x10

		// Constructors
		public AssetCache() {} // 0x009D6360-0x009D63D0

		// Methods
		// [IteratorStateMachine] // 0x0063E9E0-0x0063EA50
		public IEnumerator Preload(ScriptData scriptData, ScriptDataBlobBase startBlob, Param param) => default; // 0x009D50B0-0x009D5140
		private void preload_ActCommand_(string targetSymbol, ActCommandBase cmd, HashSet<string> effectSymbols, HashSet<string> sound_bgmSymbols, HashSet<string> sound_envSymbols, HashSet<string> sound_seSymbols, HashSet<string> sound_meSymbols, Dictionary<string, HashSet<string>> motion_Symbols) {} // 0x009D5DC0-0x009D6250
		public void ClearCache() {} // 0x009D51D0-0x009D5350
		private void PreloadBundle_(string name, string prefabName, Action<GameObject> endCb) {} // 0x009D6250-0x009D6350
	}

	public class PlayerTaskSys // TypeDefIndex: 4520
	{
		// Fields
		private ManualCoroutineTaskSet executeTaskSet_; // 0x10
		private Dictionary<string, Dictionary<string, List<TaskContext>>> nowExecuteTaskTblCategorys_; // 0x18

		// Nested types
		public class TaskContext // TypeDefIndex: 4521
		{
			// Fields
			public ManualCoroutineTask coTask; // 0x10
			public bool bRequestLoopEnd; // 0x18
			public bool bRequestForceExit; // 0x19

			// Constructors
			public TaskContext() {} // 0x009D9670-0x009D9680
		}

		// Constructors
		public PlayerTaskSys() {} // 0x009D94F0-0x009D9580

		// Methods
		private Dictionary<string, List<TaskContext>> getCategoryTaskTbl_(string category) => default; // 0x009D9580-0x009D9640
		// [IteratorStateMachine] // 0x0063EA50-0x0063EAC0
		public IEnumerator ExecuteTaskSysMainLoop(Action stepCb, Action oneLoopPreHookCb, Action oneLoopPostHookCb) => default; // 0x009D5140-0x009D51D0
		public bool ExecuteNamedTask(string taskName, Func<TaskContext, IEnumerator> taksFunc, string category = "Default" /* Metadata: 0x0061089C */) => default; // 0x009D4350-0x009D44C0
		public void ForceUpdateOneStep(string taskName, string category = "Default" /* Metadata: 0x006108A7 */) {} // 0x009D9680-0x009D97E0
		public bool IsTaskExecuteCategory(string category = "Default" /* Metadata: 0x006108B2 */) => default; // 0x009D44C0-0x009D4780
		public bool IsTaskExecute(string taskName, string category = "Default" /* Metadata: 0x006108BD */) => default; // 0x009D97E0-0x009D9970
		public void SetRequestLoopTaskEnd(string taskName, string category = "Default" /* Metadata: 0x006108C8 */) {} // 0x009D9970-0x009D9AD0
		public void TryForceExitRequest() {} // 0x009D37D0-0x009D3B80
		// [IteratorStateMachine] // 0x0063EAC0-0x0063EB30
		public IEnumerator WaitTask(string taskName, string category = "Default" /* Metadata: 0x006108D3 */) => default; // 0x009D9AD0-0x009D9B50
		// [IteratorStateMachine] // 0x0063EB30-0x0063EBA0
		public IEnumerator WaitTaskAll(string category = "Default" /* Metadata: 0x006108DE */) => default; // 0x009D4780-0x009D4800
	}

	// Constructors
	public ScriptDataPlayer() {} // 0x009D3140-0x009D31A0

	// Methods
	private ActAssetBlob findNearAssetBlob_(ScriptData scriptData, ScriptDataBlobBase currentBlob) => default; // 0x009D2100-0x009D22D0
	private void loadCurrentActAsset_(ActAssetBlob nearAssetBlob, Action endCb) {} // 0x009D22D0-0x009D2510
	private void logCallback_(string str) {} // 0x009D25A0-0x009D2620
	private void logErrorCallback_(string str) {} // 0x009D2620-0x009D26A0
	// [IteratorStateMachine] // 0x006193B0-0x00619420
	private IEnumerator playerExecute_(ScriptData scriptData, ScriptDataBlobBase startBlob, Param param, Action<ScriptDataBlobBase> stepCb, Action endCb) => default; // 0x009D26A0-0x009D2740
	// [IteratorStateMachine] // 0x00619420-0x00619490
	private IEnumerator playerExecuteSub_(ScriptData scriptData, ScriptDataBlobBase startBlob, PlayerContext context, Param param, Action<ScriptDataBlobBase> stepCb) => default; // 0x009D2770-0x009D2810
	private static void startCoroutine_(IEnumerator co) {} // 0x009D2520-0x009D25A0
	public void PlayBlob(ScriptData scriptData, ScriptDataBlobBase startBlob, Param param, Action<ScriptDataBlobBase> stepCb, Action endCb) {} // 0x009D2840-0x009D2960
	public void PlayStop() {} // 0x009D2980-0x009D29A0
	public void RequestPlayStop() {} // 0x009D29A0-0x009D29C0
	public void ClearLog() {} // 0x009D29E0-0x009D2A30
	public void ForceReset() {} // 0x009D2A30-0x009D2A40
	public void ResetLastCacheState() {} // 0x009D2A40-0x009D2A90
	public void ApplySnapshotAsync(ScriptData scriptData, ScriptDataBlobBase targetBlob, Action endCb) {} // 0x009D2A90-0x009D2C00
	public void ApplySnapshotAsync(ScriptData scriptData, ActCommandBlob targetCommandBlob, ActCommandCellList commandCellLst, int columnIdx, Action endCb) {} // 0x009D2CC0-0x009D2E00
	private void ApplySnapshotAsync_(ActAssetBlob assetBlob, ActSnapshotContext snapshotContext, Action endCb) {} // 0x009D2C00-0x009D2CC0
	public void PlayOneCommandPreviewAsync(ScriptData scriptData, ActCommandBlob commandBlob, ActCommandCellList commandCellLst, int columnIdx, ActTargetBase target, Action endCb) {} // 0x009D2E10-0x009D2F20
	// [IteratorStateMachine] // 0x00619490-0x00619500
	private IEnumerator previewOneCommand_(ScriptData scriptData, ActTargetBase target, ActCommandCell commandCell, Action stepCb, Action endCb) => default; // 0x009D2F30-0x009D2FD0
	// [IteratorStateMachine] // 0x00619500-0x00619570
	private IEnumerator previewOneCommandSub_(IEnumerator co) => default; // 0x009D3000-0x009D3070
	// [IteratorStateMachine] // 0x00619570-0x006195E0
	private IEnumerator previewOneCommandStop_() => default; // 0x009D30A0-0x009D3110
}

