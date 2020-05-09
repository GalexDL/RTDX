/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
[Editor_ActAsset] // 0x00608990-0x006089D0
public class ActAsset_MoveArea : ActAsset_Base // TypeDefIndex: 4392
{
	// Fields
	public AreaType areaType; // 0x18
	public Vector2 pos2d; // 0x1C
	public float rotYaw; // 0x24
	public Vector2 size; // 0x28

	// Nested types
	public enum AreaType // TypeDefIndex: 4393
	{
		Rect = 0
	}

	// Constructors
	public ActAsset_MoveArea() {} // 0x008D80D0-0x008D8160

	// Methods
	public bool CheckInArea(Vector2 checkPos) => default; // 0x008D7D70-0x008D7DF0
	public bool CheckInArea(Vector3 checkPos) => default; // 0x008D7DF0-0x008D7E20
	public Vector2 GetRandomPoint() => default; // 0x008D7F90-0x008D80D0
	private bool checkHitRect_(Vector3 checkPos) => default; // 0x008D7E20-0x008D7F90
}

