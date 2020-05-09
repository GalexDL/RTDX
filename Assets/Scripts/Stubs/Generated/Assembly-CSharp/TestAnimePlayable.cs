/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TestAnimePlayable : PlayableBehaviour // TypeDefIndex: 4353
{
	// Fields
	protected Playable m_ActualPlayable; // 0x10
	private AnimationMixerPlayable m_Mixer; // 0x20
	private bool m_bMixer; // 0x30
	public Action onDone; // 0x38
	public Playable animePlayable; // 0x40

	// Properties
	protected Playable self { get => default; } // 0x00921510-0x00921520 
	public Playable playable { get => default; } // 0x00921520-0x00921530 
	protected PlayableGraph graph { get => default; } // 0x00921530-0x00921580 
	public Playable mixerPlayable { get => default; } // 0x00921580-0x009215F0 

	// Constructors
	public TestAnimePlayable() {} // 0x009215F0-0x00921620
	public TestAnimePlayable(bool bEnableMixer) {} // 0x00921620-0x00921650

	// Methods
	public Playable GetInput(int index) => default; // 0x00921650-0x00921730
	public override void OnPlayableCreate(Playable playable) {} // 0x00921730-0x009218B0
	private void DoAddClip(AnimationClip clip) {} // 0x009218B0-0x009219D0
	public bool AddClip(AnimationClip clip, string name) => default; // 0x009219D0-0x009219F0
	public override void OnGraphStop(Playable playable) {} // 0x009219F0-0x00921A00
	private void DisconnectInput() {} // 0x00921A00-0x00921AB0
	private void ConnectInput() {} // 0x00921AB0-0x00921B60
	private void UpdateStates(float deltaTime) {} // 0x00921B60-0x00921B70
	private float CalculateQueueTimes() => default; // 0x00921B70-0x00921B80
	private void ClearQueuedStates() {} // 0x00921B80-0x00921B90
	private void UpdateQueuedStates() {} // 0x00921B90-0x00921BA0
	private void UpdateStateTimes() {} // 0x00921BA0-0x00921BB0
	public override void PrepareFrame(Playable owner, FrameData data) {} // 0x00921BB0-0x00921BC0
}

