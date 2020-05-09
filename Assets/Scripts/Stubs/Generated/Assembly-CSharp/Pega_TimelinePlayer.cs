/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_TimelinePlayer // TypeDefIndex: 5674
{
	// Fields
	private PlayMode_ playMode_; // 0x10
	private ManualCoroutineTaskSet taskSet_; // 0x18
	private PlayableDirector currentIimeline_; // 0x20

	// Properties
	public bool IsPlaying { get => default; } // 0x00B5E620-0x00B5E640 
	public bool IsPlayingHoldEnd { get => default; } // 0x00B5EA40-0x00B5EA50 
	public PlayableDirector CurrentPlayableDirector_ForDebug { get => default; } // 0x00B5EA50-0x00B5EA60 

	// Nested types
	private enum PlayMode_ // TypeDefIndex: 5675
	{
		None = 0,
		Playing = 1,
		PlayStopping = 2,
		PlayingHoldEnd = 3
	}

	private class PlayContext // TypeDefIndex: 5676
	{
		// Fields
		public Action stepCb; // 0x10
		public Action<string> errorCb; // 0x18

		// Constructors
		public PlayContext() {} // 0x00B5F8F0-0x00B5F900
	}

	public class Param // TypeDefIndex: 5677
	{
		// Fields
		public string cutsceneSymbol; // 0x10
		public bool bContinueMode; // 0x18
		public bool bLoadAfter1SyncWait; // 0x19
		public bool isHoldEndPause; // 0x1A

		// Constructors
		public Param() {} // 0x00B5F990-0x00B5F9A0
	}

	// Constructors
	public Pega_TimelinePlayer() {} // 0x00B5EA60-0x00B5EAD0

	// Methods
	// [IteratorStateMachine] // 0x00621020-0x00621090
	private IEnumerator playerExecute_(Param param, Action stepCb, Action endCb) => default; // 0x00B5E330-0x00B5E3C0
	private static void startCoroutine_(IEnumerator co) {} // 0x00B5E3F0-0x00B5E470
	// [IteratorStateMachine] // 0x00621090-0x00621100
	private IEnumerator cutsceneMain_(PlayContext context, Param param, Func<bool> isNeedExit) => default; // 0x00B5E470-0x00B5E4F0
	public void Play(Param param, Action stepCb, Action endCb) {} // 0x00B5E520-0x00B5E620
	public void Stop() {} // 0x00B5E640-0x00B5E660
	public void Stop_Immediate() {} // 0x00B5E660-0x00B5E720
	public void UncontorlTimelineUsedActObj(List<string> uncontrolActObjSymbols, bool bWithAllCamera) {} // 0x00B5E720-0x00B5E800
	public void UncontorlTimelineFader() {} // 0x00B5E840-0x00B5E910
	public void ManualUnload() {} // 0x00B5E940-0x00B5EA10
}

