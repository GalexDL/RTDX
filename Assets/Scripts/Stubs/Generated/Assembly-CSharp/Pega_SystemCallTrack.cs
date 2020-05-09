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

// [TrackClipType] // 0x00609FC0-0x0060A050
// [TrackColor] // 0x00609FC0-0x0060A050
public class Pega_SystemCallTrack : TrackAsset // TypeDefIndex: 5671
{
	// Fields
	public CallType callType; // 0x7C

	// Nested types
	public enum CallType // TypeDefIndex: 5672
	{
		PreCall = 0,
		PostCall = 100
	}

	// Constructors
	public Pega_SystemCallTrack() {} // 0x00B5DF70-0x00B5DFE0

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x00B5DDF0-0x00B5DF70
}

