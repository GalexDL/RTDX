/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class Pega_ActMotionMixerBehaviour : PlayableBehaviour // TypeDefIndex: 5620
{
	// Fields
	public Pega_ActMotionTrack ownerTrack; // 0x10
	public PlayableDirector refPlayableDirector; // 0x18
	private bool m_FirstFrameHappened; // 0x20
	private List<PegasusAnimationController.ClipWork> clipWorkTbl_; // 0x28
	private List<PegasusAnimationController.ClipWork> eyClipWorkTbl_; // 0x30
	private List<PegasusAnimationController.ClipWork> moClipWorkTbl_; // 0x38
	private PegasusAnimationController.ClipWork eyPackClipWork_; // 0x40
	private PegasusAnimationController.ClipWork moPackClipWork_; // 0x48

	// Constructors
	public Pega_ActMotionMixerBehaviour() {} // 0x00793560-0x00793610

	// Methods
	public override void OnGraphStart(Playable playable) {} // 0x00792640-0x00792650
	public override void OnGraphStop(Playable playable) {} // 0x00792650-0x007926D0
	public override void PrepareFrame(Playable playable, FrameData info) {} // 0x007926D0-0x00792720
	public override void ProcessFrame(Playable ownerPlayable, FrameData info, object playerData) {} // 0x00792720-0x00793070
	private void BodyFaceMotionSync_(int clipIndex, string key) {} // 0x00793070-0x00793560
}

