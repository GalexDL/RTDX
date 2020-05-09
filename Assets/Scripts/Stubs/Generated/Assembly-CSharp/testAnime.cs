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

public class testAnime : MonoBehaviour // TypeDefIndex: 4352
{
	// Fields
	private SimpleAnimationPlayable playable1; // 0x18
	private PlayableGraph graph; // 0x20
	private AnimationMixerPlayable mixer; // 0x30
	[SerializeField] // 0x00615BB0-0x00615BC0
	private AnimationClip runClip; // 0x40
	[SerializeField] // 0x00615BC0-0x00615BD0
	private AnimationClip face1Clip; // 0x48
	[SerializeField] // 0x00615BD0-0x00615BE0
	private AnimationClip face2Clip; // 0x50
	// [Range] // 0x00615BE0-0x00615C00
	public float weight; // 0x58

	// Constructors
	public testAnime() {} // 0x00AF8AB0-0x00AF8AC0

	// Methods
	private void Awake() {} // 0x00AF86D0-0x00AF8700
	public SimpleAnimationPlayable CreateLayer(uint layerId) => default; // 0x00AF8700-0x00AF87F0
	public TestAnimePlayable CreateLayerTest(uint layerId) => default; // 0x00AF87F0-0x00AF88D0
	private void Start() {} // 0x00AF88D0-0x00AF8A90
	private void Update() {} // 0x00AF8A90-0x00AF8AA0
	private void OnDestroy() {} // 0x00AF8AA0-0x00AF8AB0
}

