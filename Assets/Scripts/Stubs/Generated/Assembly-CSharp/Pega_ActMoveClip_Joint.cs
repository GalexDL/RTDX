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
public class Pega_ActMoveClip_Joint : PlayableAsset, ITimelineClipAsset, IPega_ActMoveClip // TypeDefIndex: 5623
{
	// Fields
	public Pega_ActMoveBehaviour_Joint template; // 0x18
	public string targetName; // 0x20
	public string nodeName; // 0x28
	public Vector3 offsetPos; // 0x30
	public Vector3 offsetRotXYZ; // 0x3C
	public Vector3 mulScaleXYZ; // 0x48
	public bool ignoreParentRotate; // 0x54
	public bool ignoreParentScale; // 0x55

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x007938D0-0x007938E0 
	public Vector3 EndPosition { get => default; } // 0x00793E50-0x00793EC0 
	public Quaternion EndRotation { get => default; } // 0x00793EC0-0x00793F30 
	public Vector3 EndScale { get => default; } // 0x00793F30-0x00793FA0 

	// Constructors
	public Pega_ActMoveClip_Joint() {} // 0x00793FA0-0x007940B0

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x007938E0-0x007939B0
	public void EvoluteValue(AnimationClip animClip, Pega_ActMoveBehaviour_Joint clipBehaviour, double clipTime, double clipDuration, out Vector3 outPos, out Quaternion outRotQ, out Vector3 outScale) {
		outPos = default;
		outRotQ = default;
		outScale = default;
	} // 0x007939B0-0x00793E50
}

