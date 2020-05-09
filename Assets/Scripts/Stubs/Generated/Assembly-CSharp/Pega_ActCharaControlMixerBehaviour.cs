/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Pega_ActCharaControlMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5612
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_ActCharaControlTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28
	private PegasusAnimationController.ClipWork eyClipWork_; // 0x30
	private PegasusAnimationController.ClipWork moClipWork_; // 0x38

	// Constructors
	public Pega_ActCharaControlMixerBehaviour() {} // 0x00791400-0x00791470

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x007907D0-0x00790870
	public override void OnGraphStop(Playable playable) {} // 0x00790870-0x007908B0
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x007908B0-0x00791120
	private static Quaternion AddQuaternions_(Quaternion first, Quaternion second) => default; // 0x00791120-0x00791140
	private static Quaternion ScaleQuaternion_(Quaternion rotation, float multiplier) => default; // 0x00791140-0x00791160
	private static float QuaternionMagnitude_(Quaternion rotation) => default; // 0x00791160-0x00791260
	private static Quaternion NormalizeQuaternion_(Quaternion rotation) => default; // 0x00791260-0x00791400
}

