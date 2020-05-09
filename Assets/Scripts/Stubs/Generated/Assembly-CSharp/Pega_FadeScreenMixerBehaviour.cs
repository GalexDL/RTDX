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

public class Pega_FadeScreenMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5648
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_FadeScreenTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28

	// Constructors
	public Pega_FadeScreenMixerBehaviour() {} // 0x00799740-0x007997B0

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x00798C50-0x00798F80
	public override void OnGraphStop(Playable playable) {} // 0x00798F80-0x00798FB0
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00798FB0-0x00799730
}

