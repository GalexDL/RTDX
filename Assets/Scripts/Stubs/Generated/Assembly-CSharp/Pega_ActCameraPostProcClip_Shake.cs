/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class Pega_ActCameraPostProcClip_Shake : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 5603
{
	// Fields
	public Pega_ActCameraPostProcBehaviour_Shake template; // 0x18
	public ShakeType shakeType; // 0x20
	private TimelineRandomValue[] timelineRandTable_; // 0x28

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x0078EEE0-0x0078EEF0 

	// Nested types
	public enum ShakeType // TypeDefIndex: 5604
	{
		SignRandom = 0,
		RangeRandom = 1,
		GaussianRangeRandom = 2
	}

	private class TimelineRandomValue // TypeDefIndex: 5605
	{
		// Fields
		private float[] randomTable_; // 0x10

		// Constructors
		public TimelineRandomValue() {} // 0x0078E7E0-0x0078E8E0

		// Methods
		public float LookupValue(float time, float interval) => default; // 0x0078EE70-0x0078EEE0
		public float LookupRangeValue(float time, float interval, float min, float max) => default; // 0x0078F040-0x0078F0C0
	}

	// Constructors
	public Pega_ActCameraPostProcClip_Shake() {} // 0x0078EFC0-0x0078F040

	// Methods
	public void Init() {} // 0x0078E6E0-0x0078E7E0
	private static float GaussianRandom_(float range, float rand0, float rand1) => default; // 0x0078E8E0-0x0078EA00
	public Vector2 CalcShakeOffset(float clipTime, Vector2 vRangeSize, float fIntervalSec) => default; // 0x0078EA00-0x0078EE70
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0078EEF0-0x0078EFC0
}

