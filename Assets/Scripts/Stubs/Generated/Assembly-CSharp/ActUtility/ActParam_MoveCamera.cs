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
	public class ActParam_MoveCamera // TypeDefIndex: 8680
	{
		// Fields
		public DistanceMode distanceMode; // 0x10
		public ActParamHolder_Camera toCamParam; // 0x18
		private MoveLimitMode moveLimitMode_; // 0x20
		private bool moveLimitX_; // 0x24
		private bool moveLimitY_; // 0x25
		private bool moveLimitZ_; // 0x26
		private bool moveLimitRot_; // 0x27
		private bool moveLimitEye_; // 0x28
		private bool moveLimitZoom_; // 0x29
		private float previewTime_; // 0x2C
	
		// Nested types
		public class CamData // TypeDefIndex: 8681
		{
			// Fields
			public Vector3 pos; // 0x10
			public Quaternion rotQ; // 0x1C
			public float fieldOfView; // 0x2C
	
			// Constructors
			public CamData() {} // 0x008599C0-0x00859A40
	
			// Methods
			public Vector3 calcTgt(float distance) => default; // 0x0085A3E0-0x0085A500
			public void CopyFrom(CamData left) {} // 0x0085A500-0x0085A530
			public bool isEqual(CamData left) => default; // 0x0085A530-0x0085A670
		}
	
		public enum DistanceMode // TypeDefIndex: 8682
		{
			Pos = 0,
			Angle = 200
		}
	
		private enum MoveLimitMode // TypeDefIndex: 8683
		{
			MoveOnlyXZ = 0,
			RotateOnly = 1,
			None = 2,
			Custom = 3
		}
	
		// Constructors
		public ActParam_MoveCamera() {} // 0x0085A360-0x0085A3E0
	
		// Methods
		private CamData createCamParam_(ActParamHolder_Camera actParamCam, ActObjectManager actObjManager) => default; // 0x00859740-0x008597E0
		private CamData createCamParam_(ActParamHolder_Camera actParamCam, ActSnapshotContext context) => default; // 0x00859920-0x008599C0
		private CamData createCamParam_(ActParam_Camera param) => default; // 0x008597E0-0x00859920
		private CamData calcCam_(CamData startCam, float time, ActObjectManager actObjectManager) => default; // 0x00859A40-0x00859CB0
		private CamData calcCam_(CamData startCam, float time, ActSnapshotContext context) => default; // 0x00859CB0-0x00859F20
		public float CalcMoveDistLen(CamData startCam, ActObjectManager actObjectManager) => default; // 0x00859F20-0x0085A150
		public void Apply(ActObjCamera actCamera, CamData startCam, float time, ActObjectManager actObjManager) {} // 0x0085A150-0x0085A1C0
		public void Apply(ActObjSnapshotState snapshotState, ActSnapshotContext context) {} // 0x0085A1C0-0x0085A2F0
		public void Apply_ForSceneGUIPreview(CamData startCam, ActObjCamera actCamera, ActObjectManager actObjManager) {} // 0x0085A2F0-0x0085A360
	}
}
