/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActCommandSystem;
using CharacterConst;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjSnapshotState // TypeDefIndex: 4455
{
	// Fields
	public bool lastVisible; // 0x10
	public Vector3 lastPos; // 0x14
	public Quaternion lastRot; // 0x20
	public Vector3 lastScale; // 0x30
	public float lastHeightOffset; // 0x3C
	public string lastMotion; // 0x40
	public bool lastMotionLoop; // 0x48
	public float lastMotionSpeed; // 0x4C
	public Color lastMulColor; // 0x50
	public Color lastAddColor; // 0x60
	public Color lastOverlayColor; // 0x70
	public EyeType face_eye; // 0x80
	public MouthType face_mouth; // 0x84
	public bool neck_enable; // 0x88
	public float neck_yawDeg; // 0x8C
	public float neck_pitchDeg; // 0x90
	public float neck_rollDeg; // 0x94
	public float cam_fieldOfView; // 0x98
	public float cam_nearClipPlane; // 0x9C
	public float cam_farClipPlane; // 0xA0
	public ActCommand_ScreenFade.FadeMode fade_fadeModeFront; // 0xA4
	public ActCommand_ScreenFade.FadeMode fade_fadeModeBack; // 0xA8
	public Color fade_changeColorFront; // 0xAC
	public Color fade_changeColorBack; // 0xBC
	public bool blur_flag; // 0xCC
	public float blur_Amount; // 0xD0
	public float blur_RateScale; // 0xD4
	public float blur_Alpha; // 0xD8
	public float blur_RateRotate; // 0xDC
	public float blur_RateCenterAlpha; // 0xE0
	public bool blur_twoLoopFlag; // 0xE4
	public Dictionary<ActCommand_PlayBgm.Channel, SoundState> sound_bgm; // 0xE8
	public Dictionary<string, SoundState> sound_se; // 0xF0

	// Nested types
	public struct SoundState // TypeDefIndex: 4456
	{
		// Fields
		public string symbol; // 0x10
		public float volume; // 0x18
	}

	// Constructors
	public ActObjSnapshotState() {} // 0x0093B200-0x0093B3F0
	public ActObjSnapshotState(ActObjSnapshotState left) {} // 0x0093B3F0-0x0093B5E0

	// Methods
	public void CopyFrom(ActObjSnapshotState left) {} // 0x0093B5E0-0x0093BB60
}

