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
public class Pega_ActMoveClip_TwoPoint : PlayableAsset, ITimelineClipAsset, IPega_ActMoveClip // TypeDefIndex: 5627
{
	// Fields
	public Pega_ActMoveBehaviour_TwoPoint template; // 0x18
	public Vector3 startPos; // 0x20
	public Vector3 startRotXYZ; // 0x2C
	public Vector3 endPos; // 0x38
	public Vector3 endRotXYZ; // 0x44
	public bool isUseAnimCurve; // 0x50
	public TweenFunc.TweenType tweenType; // 0x54

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x007942E0-0x007942F0 
	public Vector3 EndPosition { get => default; } // 0x00794D10-0x00794D20 
	public Quaternion EndRotation { get => default; } // 0x00794D20-0x00794DB0 
	public Vector3 EndScale { get => default; } // 0x00794DB0-0x00794E20 

	// Nested types
	public class TweenFunc // TypeDefIndex: 5628
	{
		// Nested types
		public enum TweenType // TypeDefIndex: 5629
		{
			LinearTwee = 0,
			EaseInQuad = 1,
			EaseOutQuad = 2,
			EaseInOutQuad = 3,
			EaseInCubic = 4,
			EaseOutCubic = 5,
			EaseInOutCubic = 6,
			EaseInQuart = 7,
			EaseOutQuart = 8,
			EaseInOutQuart = 9,
			EaseInQuint = 10,
			EaseOutQuint = 11,
			EaseInOutQuint = 12,
			EaseInSine = 13,
			EaseOutSine = 14,
			EaseInOutSine = 15,
			EaseInExpo = 16,
			EaseOutExpo = 17,
			EaseInOutExpo = 18,
			EaseInCirc = 19,
			EaseOutCirc = 20,
			EaseInOutCirc = 21
		}

		// Constructors
		public TweenFunc() {} // 0x007957A0-0x007957B0

		// Methods
		public static float Tween(TweenType type, float t, float b, float c) => default; // 0x00794650-0x00794D10
		private static float linearTween(float t, float b, float c) => default; // 0x00794E90-0x00794EA0
		private static float easeInQuad(float t, float b, float c) => default; // 0x00794EA0-0x00794EB0
		private static float easeOutQuad(float t, float b, float c) => default; // 0x00794EB0-0x00794ED0
		private static float easeInOutQuad(float t, float b, float c) => default; // 0x00794ED0-0x00794F20
		private static float easeInCubic(float t, float b, float c) => default; // 0x00794F20-0x00794F40
		private static float easeOutCubic(float t, float b, float c) => default; // 0x00794F40-0x00794F70
		private static float easeInOutCubic(float t, float b, float c) => default; // 0x00794F70-0x00794FC0
		private static float easeInQuart(float t, float b, float c) => default; // 0x00794FC0-0x00794FE0
		private static float easeOutQuart(float t, float b, float c) => default; // 0x00794FE0-0x00795010
		private static float easeInOutQuart(float t, float b, float c) => default; // 0x00795010-0x00795070
		private static float easeInQuint(float t, float b, float c) => default; // 0x00795070-0x00795090
		private static float easeOutQuint(float t, float b, float c) => default; // 0x00795090-0x007950C0
		private static float easeInOutQuint(float t, float b, float c) => default; // 0x007950C0-0x00795120
		private static float easeInSine(float t, float b, float c) => default; // 0x00795120-0x007951C0
		private static float easeOutSine(float t, float b, float c) => default; // 0x007951C0-0x00795250
		private static float easeInOutSine(float t, float b, float c) => default; // 0x00795250-0x007952F0
		private static float easeInExpo(float t, float b, float c) => default; // 0x007952F0-0x00795390
		private static float easeOutExpo(float t, float b, float c) => default; // 0x00795390-0x00795430
		private static float easeInOutExpo(float t, float b, float c) => default; // 0x00795430-0x00795530
		private static float easeInCirc(float t, float b, float c) => default; // 0x00795530-0x007955E0
		private static float easeOutCirc(float t, float b, float c) => default; // 0x007955E0-0x00795690
		private static float easeInOutCirc(float t, float b, float c) => default; // 0x00795690-0x007957A0
	}

	// Constructors
	public Pega_ActMoveClip_TwoPoint() {} // 0x00794E20-0x00794E90

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x007942F0-0x007943C0
	public void EvoluteValue(AnimationClip animClip, Pega_ActMoveBehaviour_TwoPoint clipBehaviour, double clipTime, double clipDuration, out Vector3 outPos, out Quaternion outRotQ) {
		outPos = default;
		outRotQ = default;
	} // 0x007943C0-0x00794650
}

