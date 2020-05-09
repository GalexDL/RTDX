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
	public class ActParam_Rot // TypeDefIndex: 8672
	{
		// Fields
		public RotType rotType; // 0x10
		public bool onlyYaw; // 0x14
		public Quaternion rotQ; // 0x18
		public string lookSymbol; // 0x28
		private Vector3 lastPreview_lookSymbolPos_; // 0x30
		private Quaternion lastPreview_RotQ_; // 0x3C
	
		// Nested types
		public enum RotType // TypeDefIndex: 8673
		{
			Rot = 0,
			LookSymbol = 300,
			RotOffs = 400
		}
	
		// Constructors
		public ActParam_Rot() {} // 0x0085B0C0-0x0085B120
	
		// Methods
		private Quaternion calcDirQ_(Vector3 toPos, Vector3 srcPos) => default; // 0x0085A9E0-0x0085AB80
		public Quaternion CalcQuaternion(Vector3 srcPos, Quaternion srcRotQ, ActObjectManager actObjManager) => default; // 0x0085AB80-0x0085AD80
		public Quaternion CalcQuaternionSnapshot(Vector3 srcPos, Quaternion srcRotQ, ActSnapshotContext snapshotContext) => default; // 0x0085AD80-0x0085B0C0
	}
}
