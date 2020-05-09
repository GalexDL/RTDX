/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A660-0x0060A670
public class UIPlayableAnimation : UIAnimationBase // TypeDefIndex: 7414
{
	// Fields
	private PlayableGraph graph_; // 0x20
	private AnimationClipPlayable clipPlayable_; // 0x30
	private AnimationPlayableOutput playableOutput_; // 0x40
	public AnimationClip clip; // 0x50
	public float delaySeconds; // 0x58
	public float motionSpeed; // 0x5C
	public bool isLooping; // 0x60
	public bool isStartPlay; // 0x61
	private float fWaitTime_; // 0x64

	// Constructors
	public UIPlayableAnimation() {} // 0x00C92180-0x00C92190

	// Methods
	private void Awake() {} // 0x00C91A40-0x00C91BB0
	private void Start() {} // 0x00C91BB0-0x00C91BC0
	private void OnDestroy() {} // 0x00C91BC0-0x00C91C10
	protected override void _play() {} // 0x00C91C10-0x00C91C20
	public override void Play(CallbackAction cb, string soundName = null) {} // 0x00C91C20-0x00C91EF0
	public override void Stop() {} // 0x00C92000-0x00C92040
	public override void Skip() {} // 0x00C92040-0x00C920D0
	public bool IsDone() => default; // 0x00C920D0-0x00C92150
	// [IteratorStateMachine] // 0x0062BED0-0x0062BF40
	private IEnumerator Wait(CallbackAction cb, string soundName = null) => default; // 0x00C91F80-0x00C92000
	public void SetMotionSpeed(float speed) {} // 0x00C91EF0-0x00C91F80
}

