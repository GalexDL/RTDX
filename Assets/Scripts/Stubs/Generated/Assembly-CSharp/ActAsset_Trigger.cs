/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
[Editor_ActAsset] // 0x00608950-0x00608990
public class ActAsset_Trigger : ActAsset_Base // TypeDefIndex: 4389
{
	// Fields
	public TriggerType trigType; // 0x18
	public Vector2 pos2d; // 0x1C
	public float rotYaw; // 0x24
	public Vector2 size; // 0x28
	public string trigParam; // 0x30
	public Vector2 trigOutPos2dOffset; // 0x38
	public float trigOutRotYaw; // 0x40
	public float trigWalkRotYaw; // 0x44
	public float trigWalkMaxSpeed; // 0x48
	public static float TalkThresholdDeg; // 0x00
	public static float TalkThresholdLen; // 0x04
	public static float TalkThresholdNearDeg; // 0x08
	public static float TalkThresholdNearLen; // 0x0C

	// Properties
	public bool HasMoveOutPos_ { get => default; } // 0x008D9120-0x008D9150 
	public bool IsStopper_ { get => default; } // 0x008D8B20-0x008D8B70 

	// Nested types
	public enum TriggerType // TypeDefIndex: 4390
	{
		HitAreaIn = 0,
		TalkPoint = 100,
		MapMove = 200,
		MapJump = 210,
		Stopper01 = 500,
		Stopper02 = 510,
		Stopper03 = 520,
		Stopper04 = 530,
		Stopper05 = 540,
		MapBGM = 700
	}

	// Constructors
	public ActAsset_Trigger() {} // 0x008D9150-0x008D9210
	static ActAsset_Trigger() {} // 0x008D9210-0x008D9290

	// Methods
	public bool CheckTalk(Vector3 pos, float yawDirDeg, float talkLenScale, out float score) {
		score = default;
		return default;
	} // 0x008D8170-0x008D8270
	public static bool CalcTalkScore(Vector3 pos, float yawDirDeg, Vector3 tgtPos, float talkLenScale, out float score) {
		score = default;
		return default;
	} // 0x008D8270-0x008D8570
	public static void DebugTalkDraw(Vector3 pos, float yawDirDeg) {} // 0x008D8570-0x008D8680
	public bool CheckHit(Vector3 prevPos, Vector3 checkPos, ActObjCharactor actCh) => default; // 0x008D8690-0x008D8B20
	public bool CalcMoveOutPoint(Vector2 nowPos2d, out Vector2 outPos2d, out float outYawDeg) {
		outPos2d = default;
		outYawDeg = default;
		return default;
	} // 0x008D8D80-0x008D9120
	private bool checkHitRect_(Vector3 checkPos, ActObjCharactor actCh) => default; // 0x008D8B70-0x008D8D80
}

