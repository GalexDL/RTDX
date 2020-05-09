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

public class Pega_ActBgControlMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5591
{
	// Fields
	private bool m_FirstFrameHappened; // 0x10
	public Pega_ActBgControlTrack ownerTrack; // 0x18
	public PlayableDirector refPlayableDirector; // 0x20
	private List<TimelineClip> timelineClips_; // 0x28
	private Dictionary<string, BgObjWork_> workWork_; // 0x30

	// Nested types
	private class BgObjWork_ // TypeDefIndex: 5592
	{
		// Fields
		public string lastMotionName; // 0x10

		// Constructors
		public BgObjWork_() {} // 0x0078D7B0-0x0078D810
	}

	// Constructors
	public Pega_ActBgControlMixerBehaviour() {} // 0x0078D810-0x0078D8B0

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x0078CFA0-0x0078D040
	public override void OnGraphStop(Playable playable) {} // 0x0078D040-0x0078D070
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x0078D070-0x0078D740
}

