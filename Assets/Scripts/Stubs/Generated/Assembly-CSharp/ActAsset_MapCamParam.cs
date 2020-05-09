/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
[Editor_ActAsset] // 0x00608910-0x00608950
public class ActAsset_MapCamParam : ActAsset_Base // TypeDefIndex: 4387
{
	// Fields
	public CamType camType; // 0x18
	public Vector3 posOffset; // 0x1C
	public Vector3 tgtOffset; // 0x28
	public float fieldOfView; // 0x34
	public Vector2 area_Pos2d; // 0x38
	public float area_RotYaw; // 0x40
	public Vector2 area_Size; // 0x44

	// Nested types
	public enum CamType // TypeDefIndex: 4388
	{
		FollowCam = 0
	}

	// Constructors
	public ActAsset_MapCamParam() {} // 0x008D7CE0-0x008D7D70
}

