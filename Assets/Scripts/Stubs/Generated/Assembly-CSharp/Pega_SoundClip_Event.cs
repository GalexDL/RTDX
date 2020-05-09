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
public class Pega_SoundClip_Event : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 5657
{
	// Fields
	public Pega_SoundBehaviour_Event template; // 0x18
	public Kind soundKind; // 0x20
	public string soundName; // 0x28
	public BGMChannel soundBgmChannel; // 0x30
	public ENVChannel soundEnvChannel; // 0x34
	public bool isStopAtEnd; // 0x38
	public bool isPlayed; // 0x39
	public bool isLoop; // 0x3A

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x0079AA50-0x0079AA60 

	// Nested types
	public enum Kind // TypeDefIndex: 5658
	{
		SOUND_SE = 0,
		SOUND_ME = 1,
		SOUND_BGM = 2,
		SOUND_ENV = 3
	}

	// Constructors
	public Pega_SoundClip_Event() {} // 0x0079AB30-0x0079ABC0

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0079AA60-0x0079AB30
}

