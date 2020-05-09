/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
[Editor_ActAsset] // 0x006089D0-0x00608A10
public class ActAsset_BgmArea : ActAsset_Base // TypeDefIndex: 4394
{
	// Fields
	public AreaType areaType; // 0x18
	public string bgmSymbol; // 0x20
	public float bgmVolume; // 0x28
	public bool isEnvSound; // 0x2C
	public Vector2 pos2d; // 0x30
	public float rotYaw; // 0x38
	public Vector2 size; // 0x3C

	// Nested types
	public enum AreaType // TypeDefIndex: 4395
	{
		Rect = 0
	}

	// Constructors
	public ActAsset_BgmArea() {} // 0x008D6CA0-0x008D6D60

	// Methods
	public bool CheckInArea(Vector2 checkPos) => default; // 0x008D6A80-0x008D6B00
	public bool CheckInArea(Vector3 checkPos) => default; // 0x008D6B00-0x008D6B30
	private bool checkHitRect_(Vector3 checkPos) => default; // 0x008D6B30-0x008D6CA0
}

