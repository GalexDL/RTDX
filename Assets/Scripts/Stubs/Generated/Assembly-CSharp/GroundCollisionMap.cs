/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GroundCollisionMap : MonoBehaviour // TypeDefIndex: 4893
{
	// Fields
	public float CellSize; // 0x18
	public int CellDivSize; // 0x1C
	public int MapSizeW; // 0x20
	public int MapSizeH; // 0x24
	[SerializeField] // 0x00616480-0x00616490
	public Cell[] cellArray; // 0x28

	// Nested types
	[Serializable]
	public struct Cell // TypeDefIndex: 4894
	{
		// Fields
		public bool isAllHit; // 0x10
		public byte[] bitArray; // 0x18
	}

	// Constructors
	public GroundCollisionMap() {} // 0x007311C0-0x00731450

	// Methods
	public bool CheckHit(Vector2 pos) => default; // 0x00730A80-0x00730C30
	public void Generate() {} // 0x00730C30-0x007311C0
}

