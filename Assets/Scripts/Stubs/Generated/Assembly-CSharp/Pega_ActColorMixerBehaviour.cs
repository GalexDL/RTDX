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

[Serializable]
public class Pega_ActColorMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5616
{
	// Fields
	public Pega_ActColorTrack ownerTrack; // 0x10
	public PlayableDirector refPlayableDirector; // 0x18
	private bool m_FirstFrameHappened; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28

	// Constructors
	public Pega_ActColorMixerBehaviour() {} // 0x007922E0-0x00792350

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x00791840-0x007919C0
	public override void OnGraphStop(Playable playable) {} // 0x007919C0-0x00791A20
	public override void PrepareFrame(Playable playable, FrameData info) {} // 0x00791A20-0x00791A70
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00791A70-0x007922E0
}

