/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class Pega_ActObjMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5635
{
	// Fields
	public Pega_ActObjTrack ownerTrack; // 0x10
	public PlayableDirector refPlayableDirector; // 0x18
	private bool m_FirstFrameHappened; // 0x20
	private TimelineClip lastClip_; // 0x28

	// Constructors
	public Pega_ActObjMixerBehaviour() {} // 0x00797470-0x00797480

	// Methods
	public override void PrepareFrame(Playable playable, FrameData info) {} // 0x00796F30-0x00796F80
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00796F80-0x00797430
	public override void OnGraphStart(Playable playable) {} // 0x00797430-0x00797460
	public override void OnGraphStop(Playable playable) {} // 0x00797460-0x00797470
}

