/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_ScriptEventMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5653
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_ScriptEventTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28
	private int m_currentPlayIndex; // 0x30
	private ScriptDataPlayer scriptPlayer_; // 0x38
	private ScriptData scriptData_; // 0x40

	// Constructors
	public Pega_ScriptEventMixerBehaviour() {} // 0x0079A740-0x0079A7E0

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x00799AB0-0x00799E00
	public override void OnGraphStop(Playable playable) {} // 0x00799E00-0x00799E40
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00799E40-0x0079A630
}

