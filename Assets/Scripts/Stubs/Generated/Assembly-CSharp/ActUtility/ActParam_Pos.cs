/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActUtility
{
	[Serializable]
	public class ActParam_Pos // TypeDefIndex: 8670
	{
		// Fields
		public PosType posType; // 0x10
		public Vector3 pos; // 0x14
		public string symbol; // 0x20
	
		// Nested types
		public enum PosType // TypeDefIndex: 8671
		{
			Pos2d = 0,
			Pos3d = 100,
			Symbol = 200
		}
	
		// Constructors
		public ActParam_Pos() {} // 0x0085A980-0x0085A9E0
	
		// Methods
		public Vector3 CalcWorldPos() => default; // 0x0085A670-0x0085A6E0
		public Vector3 CalcGroundPos() => default; // 0x0085A890-0x0085A8F0
		public Vector2 CalcGroundPos2d() => default; // 0x0085A8F0-0x0085A960
		public float CalcGroundHeightOffset() => default; // 0x0085A960-0x0085A980
		private float raycastGround_() => default; // 0x0085A6E0-0x0085A890
	}
}
