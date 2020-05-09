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
public class Pega_ActMoveClip_SRT : PlayableAsset, ITimelineClipAsset, IPega_ActMoveClip // TypeDefIndex: 5625
{
	// Fields
	public Pega_ActMoveBehaviour_SRT template; // 0x18
	[HideInInspector] // 0x00616910-0x00616920
	public Vector3 preCalc_EndPosition; // 0x20
	[HideInInspector] // 0x00616920-0x00616930
	public Quaternion preCalc_EndRotation; // 0x2C
	[HideInInspector] // 0x00616930-0x00616940
	public Vector3 preCalc_EndScale; // 0x3C

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x007940B0-0x007940C0 
	public Vector3 EndPosition { get => default; } // 0x00794190-0x007941A0 
	public Quaternion EndRotation { get => default; } // 0x007941A0-0x007941B0 
	public Vector3 EndScale { get => default; } // 0x007941B0-0x007941C0 

	// Constructors
	public Pega_ActMoveClip_SRT() {} // 0x007941C0-0x007942E0

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x007940C0-0x00794190
}

