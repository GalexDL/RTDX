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

// [TrackClipType] // 0x00609CC0-0x00609D50
// [TrackColor] // 0x00609CC0-0x00609D50
public class Pega_ActObjTrack : TrackAsset // TypeDefIndex: 5636
{
	// Fields
	public ActObjType actObjType; // 0x7C
	public string actorSymbol; // 0x80
	// [Tooltip] // 0x00616940-0x00616980
	public bool useEditModeOnly; // 0x88
	public ExposedReference<GameObject> syncObject; // 0x90

	// Nested types
	public enum ActObjType // TypeDefIndex: 5637
	{
		CHARA = 0,
		MAP = 100,
		CAMERA = 200,
		GIMMICK = 300,
		EFFECT = 400
	}

	// Constructors
	public Pega_ActObjTrack() {} // 0x00797810-0x00797890

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x00797480-0x00797800
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x00797800-0x00797810
}

