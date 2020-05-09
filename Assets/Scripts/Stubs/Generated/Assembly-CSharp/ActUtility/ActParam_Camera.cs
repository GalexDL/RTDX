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
	public class ActParam_Camera : ISerializationCallbackReceiver // TypeDefIndex: 8674
	{
		// Fields
		private const float GroundFov = 20f; // Metadata: 0x00630B4D
		private const float Ground2Fov = 23f; // Metadata: 0x00630B51
		private const float DungeonFov = 20f; // Metadata: 0x00630B55
		public FovType fovType; // 0x10
		[SerializeField] // 0x00617720-0x00617730
		private float fieldOfView; // 0x14
		public float near; // 0x18
		public float far; // 0x1C
		public RotateType rotateType; // 0x20
		public Vector3 pos; // 0x24
		public Quaternion rotateQ; // 0x30
		public Vector3 rotateAtPos; // 0x40
		public float rotateAtRollDeg; // 0x4C
	
		// Properties
		public float FieldOfView { get => default; set {} } // 0x00859290-0x008592E0 0x00859330-0x00859340
	
		// Nested types
		public enum RotateType // TypeDefIndex: 8675
		{
			Xyz_Deg = 100,
			At_Pos = 200
		}
	
		public enum FovType // TypeDefIndex: 8676
		{
			Custom = 0,
			Ground = 100,
			Ground2 = 105,
			Dungeon = 200
		}
	
		// Constructors
		public ActParam_Camera() {} // 0x00858F20-0x00858FB0
	
		// Methods
		public void AutoSetFovType() {} // 0x00859270-0x00859290
		private float calcFov_() => default; // 0x008592E0-0x00859330
		private Quaternion calcRotateQ_() => default; // 0x00859340-0x00859530
		public void Apply(ActObjCamera actCamera) {} // 0x00859530-0x00859680
		public void Apply(ActObjSnapshotState snapshotState) {} // 0x00859680-0x00859720
		public void OnBeforeSerialize() {} // 0x00859720-0x00859730
		public void OnAfterDeserialize() {} // 0x00859730-0x00859740
	}
}
