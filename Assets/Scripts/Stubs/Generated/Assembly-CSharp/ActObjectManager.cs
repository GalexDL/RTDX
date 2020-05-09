/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00608A20-0x00608A60
[ExecuteInEditMode] // 0x00608A20-0x00608A60
public class ActObjectManager : SingletonMonoBehaviour<ActObjectManager> // TypeDefIndex: 4443
{
	// Fields
	private GameObject manageRootObj_; // 0x18
	private List<ActAssetSet> currentLoadedAssetSetList_; // 0x20
	private Dictionary<string, ActObjBase> actObjTbl_; // 0x28
	private Dictionary<string, ActObjBase> delayUnloadActObjTbl_; // 0x30
	private Dictionary<string, Stack<string>> actObj_AliasSymbolStack_; // 0x38
	public const string MainCameraSymbol = "MainCam"; // Metadata: 0x00610859
	private bool isRegistLateUpdate_AfterCinemachine_; // 0x40
	private Dictionary<int, ManualCoroutineTaskSet> taskSetPrioTable_; // 0x48
	private Dictionary<int, ManualCoroutineTaskSet> taskSetPrioTableLateUpdate_; // 0x50
	private List<int> tmpPrios_; // 0x58
	private Dictionary<string, ManualCoroutineTask> generalActTaskTbl_; // 0x60
	private ManualCoroutineTaskSet generalActTaskSet_; // 0x68
	private List<string> updateGeneralActTask__removeLst; // 0x70
	private Dictionary<string, EffectWork> effectNamedTable_; // 0x78
	private List<string> updateEffect_remSymbols_; // 0x80

	// Nested types
	public class LoadParam // TypeDefIndex: 4444
	{
		// Fields
		public bool bAdd; // 0x10
		public bool bContinueAsset; // 0x11
		public HashSet<string> continueAssetSymbols; // 0x18
		public bool bLoadAfter1SyncWait; // 0x20

		// Constructors
		public LoadParam() {} // 0x00857B60-0x00857BE0
	}

	public class LoadResult // TypeDefIndex: 4445
	{
		// Fields
		public List<ActObjBase> actuallyLoadedList; // 0x10

		// Constructors
		public LoadResult() {} // 0x00856D40-0x00856DB0
	}

	public class EffectWork // TypeDefIndex: 4446
	{
		// Fields
		public BMEffect bmEffect; // 0x10
		public Vector3 scaleFrom; // 0x18
		public Vector3 scaleTo; // 0x24
		public MoveFloatVer2 scale_time; // 0x30
		public MoveFloatVer2 moveAlpha; // 0x38

		// Constructors
		public EffectWork() {} // 0x00857A80-0x00857B60

		// Methods
		public void Apply() {} // 0x008575D0-0x008577D0
		public void Update() {} // 0x00857940-0x00857A80
	}

	// Constructors
	public ActObjectManager() {} // 0x0093F3C0-0x0093F5F0

	// Methods
	private void OnEnable() {} // 0x0093BB60-0x0093BD00
	private void OnDisable() {} // 0x0093BEA0-0x0093C0A0
	private void OnApplicationQuit() {} // 0x0093C0A0-0x0093C0B0
	private void Update() {} // 0x0093C0B0-0x0093C1D0
	private void LateUpdate() {} // 0x0093C9C0-0x0093CA90
	private void LateUpdate_AfterCinemachine_() {} // 0x0093CA90-0x0093CC10
	public T FindAsset<T>(string symbolName)
		where T : ActAsset_Base => default;
	public List<T> EnumAssets<T>()
		where T : ActAsset_Base => default;
	public List<ActAsset_Base> EnumAssets() => default; // 0x0093CDB0-0x0093D020
	public List<T> EnumActObj<T>()
		where T : ActObjBase => default;
	public List<ActObjBase> EnumActObj() => default; // 0x0093D020-0x0093D080
	// [IteratorStateMachine] // 0x00618D20-0x00618D90
	public IEnumerator LoadAndSetupFromAssetSet(ActAssetSet assetSet, LoadParam param, Action<LoadResult> endCb) => default; // 0x0093D080-0x0093D110
	// [IteratorStateMachine] // 0x00618D90-0x00618E00
	public IEnumerator LoadAndSetupFromAssetSet(List<ActAssetSet> assetSetList, LoadParam param, Action<LoadResult> endCb) => default; // 0x0093D110-0x0093D1A0
	// [IteratorStateMachine] // 0x00618E00-0x00618E70
	public IEnumerator LoadAndSetupFromAssetSet(List<string> assetSetSymbolList, LoadParam param, Action<LoadResult> endCb) => default; // 0x0093D1A0-0x0093D220
	public void UnloadAll() {} // 0x0093D220-0x0093D600
	public void Unload(string symbolName) {} // 0x0092A4D0-0x0092A690
	public void UnloadDelay_AfterLateUpdate(string symbolName) {} // 0x0093D880-0x0093D940
	private void Restore_DelayUnloadObj_(string symbolName) {} // 0x0093D7C0-0x0093D880
	public T CreateActObj<T>(string symbolName)
		where T : ActObjBase => default;
	public T CreateOrGetActObj<T>(string symbolName)
		where T : ActObjBase => default;
	public bool IsExistActObj(string symbolName) => default; // 0x0093D940-0x0093D9F0
	public ActObjBase GetActObj(string symbolName) => default; // 0x0093D9F0-0x0093DB00
	public T GetActObj<T>(string symbolName)
		where T : ActObjBase => default;
	public ActObjCamera GetActObj_MainCamera() => default; // 0x0093DB00-0x0093DBA0
	public void Push_ActObjAliasSymbol(string aliasSymbol, string symbol) {} // 0x0093DBA0-0x0093DC90
	public void Pop_ActObjAliasSymbol(string aliasSymbol) {} // 0x0093DC90-0x0093DD30
	public void ForceMoveStopAll() {} // 0x0093DD30-0x0093DF80
	public ActObjCharactor GetActCharactor_Player() => default; // 0x0093DF80-0x0093DFE0
	public void ApplySnapshotContext(ActSnapshotContext snapshotContext) {} // 0x0093DFE0-0x0093EBB0
	// [IteratorStateMachine] // 0x00618E70-0x00618EE0
	private IEnumerator UpdateActObjects_() => default; // 0x0093BD60-0x0093BDD0
	private void ClearAllTask_() {} // 0x0093BD00-0x0093BD60
	private void UpdateTask_() {} // 0x0093C1D0-0x0093C380
	private void UpdateTask_LateUpdate_() {} // 0x0093CC10-0x0093CDB0
	public void StartTask(IEnumerator co, int prio) {} // 0x0093BDD0-0x0093BEA0
	public void StartTask(IEnumerator co, int prio, bool bCallFirstFrameImmediately) {} // 0x0093A5C0-0x0093A6A0
	public void StartTask_ForPreActObjUpdate(IEnumerator co) {} // 0x0093EBB0-0x0093EBC0
	public void StartTask_ForPreActObjUpdate(IEnumerator co, bool bCallFirstFrameImmediately) {} // 0x0093EBC0-0x0093EBD0
	public void StartTask_LateUpdate(IEnumerator co, int prio) {} // 0x0093EBD0-0x0093EBE0
	public void StartTask_LateUpdate(IEnumerator co, int prio, bool bCallFirstFrameImmediately) {} // 0x0093EBE0-0x0093ECC0
	public void AddGeneralActTask(string name, IEnumerator co) {} // 0x0093ECC0-0x0093ED60
	public void ForceStopGeneralActTask() {} // 0x0093D740-0x0093D7C0
	public bool IsEndGeneralActTask(string name) => default; // 0x0093ED60-0x0093EE00
	private void UpdateGeneralActTask_() {} // 0x0093C380-0x0093C640
	public void PlayEffect(string nameSymbol, Vector3 pos, Quaternion rot, string effectGfxSymbol, string attachActCharaSymbol) {} // 0x0093EE00-0x0093EFD0
	public void PlayEffect(string nameSymbol, Vector3 pos, Quaternion rot, string effectGfxSymbol) {} // 0x0093F150-0x0093F160
	public void StopEffect(string nameSymbol) {} // 0x0093EFD0-0x0093F150
	public EffectWork GetEffectWork(string nameSymbol) => default; // 0x0093F200-0x0093F2A0
	public bool IsLoopEffect(string nameSymbol) => default; // 0x0093F160-0x0093F200
	public bool IsPlayEffect(string nameSymbol) => default; // 0x0093F2A0-0x0093F360
	public List<string> EnumPlayingEffectNameSymbol() => default; // 0x0093F360-0x0093F3C0
	public void StopAllEffect() {} // 0x0093D600-0x0093D740
	private void UpdateEffect_() {} // 0x0093C640-0x0093C9C0
}

