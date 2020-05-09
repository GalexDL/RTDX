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

public class Pega_SoundMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5659
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_SoundTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28
	private int m_currentPlayIndex; // 0x30

	// Constructors
	public Pega_SoundMixerBehaviour() {} // 0x0079B9E0-0x0079BA60

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x0079ABC0-0x0079ADF0
	public override void OnGraphStop(Playable playable) {} // 0x0079ADF0-0x0079AFF0
	private void stopSound(Pega_SoundClip_Event asset) {} // 0x0079AFF0-0x0079B190
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x0079B190-0x0079B9E0
}

