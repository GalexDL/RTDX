/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_ActMoveMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5631
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_ActMoveTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28
	private List<KeyValuePair<Quaternion, float>> tmpQwList_; // 0x30

	// Constructors
	public Pega_ActMoveMixerBehaviour() {} // 0x00796BB0-0x00796C50

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x007957B0-0x00795850
	public override void OnGraphStop(Playable playable) {} // 0x00795850-0x00795860
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00795860-0x007968D0
	public static Quaternion QuaternionWeightedAverage(List<KeyValuePair<Quaternion, float>> qwList) => default; // 0x007968D0-0x00796BB0
}

