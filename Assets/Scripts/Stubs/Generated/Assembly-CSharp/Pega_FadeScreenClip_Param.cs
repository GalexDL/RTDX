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
public class Pega_FadeScreenClip_Param : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 5645
{
	// Fields
	public Pega_FadeScreenBehaviour_Param template; // 0x18
	public FadeType fadeType; // 0x20
	public FadeColorType fadeColorType; // 0x24
	public Color fadeColor; // 0x28

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x00798900-0x00798910 

	// Nested types
	public enum FadeType // TypeDefIndex: 5646
	{
		In = 0,
		Out = 1,
		Custom = 2
	}

	public enum FadeColorType // TypeDefIndex: 5647
	{
		White = 0,
		Black = 1,
		Custom = 2
	}

	// Constructors
	public Pega_FadeScreenClip_Param() {} // 0x00798BE0-0x00798C50

	// Methods
	public void Init() {} // 0x007988F0-0x00798900
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x00798910-0x007989E0
	public void CalcLastValue(Pega_FadeScreenBehaviour_Param clipBehaviour, out Color fadeValue) {
		fadeValue = default;
	} // 0x007989E0-0x00798A90
	public void CalcFadeValue(double clipTime, double clipDuration, Pega_FadeScreenBehaviour_Param clipBehaviour, out Color fadeValue) {
		fadeValue = default;
	} // 0x00798A90-0x00798BE0
}

