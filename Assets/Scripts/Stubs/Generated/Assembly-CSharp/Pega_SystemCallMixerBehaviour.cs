/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_SystemCallMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5665
{
	// Fields
	public Pega_SystemCallTrack ownerTrack; // 0x10
	public PlayableDirector refPlayableDirector; // 0x18
	private bool bIsFirstFrame_; // 0x20
	private Pega_TimelineSystem.OptionParam optionParam_; // 0x28
	private List<ActObjBase> unloadActObjList_; // 0x30
	private HashSet<string> manageActObjSymbolSet_; // 0x38
	private List<ActObjCharactor> actCharaList_; // 0x40
	private List<ActObjGimmick> actGimmickList_; // 0x48
	private List<PegasusAnimationController> animCtrlList_; // 0x50
	private bool bManageFader_; // 0x58
	private LoadingState_ loadingState_; // 0x5C
	private HashSet<int> callCheck_; // 0x60

	// Nested types
	private enum LoadingState_ // TypeDefIndex: 5666
	{
		NoLoad = 0,
		Loading = 1,
		Loaded = 2,
		Canceling = 3
	}

	private enum LoadingRequest_ // TypeDefIndex: 5667
	{
		None = 0,
		Load = 1,
		Unload = 2
	}

	// Constructors
	public Pega_SystemCallMixerBehaviour() {} // 0x0079D9F0-0x0079DB40

	// Methods
	public static bool IsGameSystemStarted() => default; // 0x0079A630-0x0079A740
	public bool IsAllAssetReady() => default; // 0x0078D740-0x0078D750
	public bool IsManageActObjSymbol(string symbol) => default; // 0x0078D750-0x0078D7B0
	public bool IsMangeFader() => default; // 0x00799730-0x00799740
	private ActAssetSet makeActAssetSet_(PlayableGraph graph, Pega_TimelineSystem.OptionParam optionParam) => default; // 0x0079BD60-0x0079C340
	private void AsyncLoadRequest_(PlayableGraph graph, Action endCb) {} // 0x0079C340-0x0079C450
	// [IteratorStateMachine] // 0x00620FB0-0x00621020
	private IEnumerator asyncLoadAssetAndInit_(PlayableGraph graph, Action endCb) => default; // 0x0079C450-0x0079C4E0
	private void UnloadAsset_() {} // 0x0079C4E0-0x0079CAB0
	private void SetupExternalSystem_() {} // 0x0079CAB0-0x0079CB50
	private void ResumeExternalSystem_() {} // 0x0079CB50-0x0079CBC0
	public void Unload() {} // 0x0079CBC0-0x0079CC30
	public void UncontorlTimelineUsedActObj(List<string> uncontrolActObjSymbols, bool bWithAllCamera) {} // 0x0079CC30-0x0079D370
	public void UncontorlTimelineFader() {} // 0x0079D370-0x0079D380
	public override void OnGraphStart(Playable playable) {} // 0x0079D380-0x0079D5B0
	public override void OnGraphStop(Playable playable) {} // 0x0079D5B0-0x0079D710
	public override void PrepareData(Playable playable, FrameData info) {} // 0x0079D710-0x0079D760
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x0079D760-0x0079D9F0
}

