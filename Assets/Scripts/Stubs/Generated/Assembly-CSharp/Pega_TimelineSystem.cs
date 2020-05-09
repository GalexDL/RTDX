/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_TimelineSystem : Singleton<Pega_TimelineSystem> // TypeDefIndex: 5663
{
	// Fields
	private Dictionary<int, Pega_SystemCallMixerBehaviour> sysMixerTbl_; // 0x10
	private Dictionary<PlayableDirector, OptionParam> optionParamTbl_; // 0x18

	// Nested types
	public class OptionParam // TypeDefIndex: 5664
	{
		// Fields
		public bool isContinueMode; // 0x10
		public bool isLoadAfter1SyncWait; // 0x11
		public bool isOwnerPegasusTimelinePlayer; // 0x12

		// Constructors
		public OptionParam() {} // 0x00B5F570-0x00B5F580
	}

	// Constructors
	public Pega_TimelineSystem() {} // 0x00B5FF50-0x00B60010

	// Methods
	public bool IsAllAssetReady(PlayableGraph graph) => default; // 0x00B5F9A0-0x00B5FA80
	public Pega_SystemCallMixerBehaviour GetSystemCallMixer(PlayableGraph graph) => default; // 0x00B5FA80-0x00B5FB60
	public Pega_SystemCallMixerBehaviour GetSystemCallMixer(PlayableDirector ownerPlayableDirector) => default; // 0x00B5FB60-0x00B5FD30
	public void Regist(PlayableGraph graph, Pega_SystemCallMixerBehaviour sysMixer) {} // 0x00B5FD30-0x00B5FDF0
	public void Unregist(PlayableGraph graph) {} // 0x00B5FDF0-0x00B5FEB0
	public void SetOptionParam(PlayableDirector ownerPlayableDirector, OptionParam optionParam) {} // 0x00B5F580-0x00B5F5F0
	public OptionParam GetOptionParam(PlayableDirector ownerPlayableDirector) => default; // 0x00B5FEB0-0x00B5FF50
	public void ManualCallUnload(PlayableDirector ownerPlayableDirector) {} // 0x00B5EA10-0x00B5EA40
	public void UncontorlTimelineUsedActObj(PlayableDirector ownerPlayableDirector, List<string> uncontrolActObjSymbols, bool bWithAllCamera) {} // 0x00B5E800-0x00B5E840
	public void UncontorlTimelineFader(PlayableDirector ownerPlayableDirector) {} // 0x00B5E910-0x00B5E940
	public void ClearOptionParam(PlayableDirector ownerPlayableDirector) {} // 0x00B5F5F0-0x00B5F680
}

