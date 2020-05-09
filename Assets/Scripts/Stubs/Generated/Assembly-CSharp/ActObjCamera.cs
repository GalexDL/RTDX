/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjCamera : ActObjBase // TypeDefIndex: 4414
{
	// Fields
	public Camera CameraRef; // 0x28
	public bool isEnableCamera; // 0x30
	private List<CamActionTask> readyMoveActLst_; // 0x38
	private CameraControlMode cameraControlMode_; // 0x40
	public FollowTargetInfo FollowTarget; // 0x48
	private Vector3 vFollowPlayerDelayVector_; // 0x50
	private bool bFollowPlayerDelay_; // 0x5C

	// Properties
	public override Vector3 positionForLook { get => default; } // 0x00924490-0x00924570 
	public bool IsMove { get => default; } // 0x00924C40-0x00924CA0 

	// Nested types
	public class CamActionTask // TypeDefIndex: 4415
	{
		// Fields
		private ManualCoroutineTask cotask_; // 0x10
		public Func<CamActionTask, IEnumerator> actFunc; // 0x18
		public bool bNotifyStop; // 0x20

		// Properties
		public bool IsEnd { get => default; } // 0x009251A0-0x009251B0 

		// Constructors
		public CamActionTask() {} // 0x009254A0-0x00925510

		// Methods
		public void Start() {} // 0x00924B80-0x00924BF0
		public void Tick() {} // 0x00925190-0x009251A0
	}

	public enum CameraControlMode // TypeDefIndex: 4416
	{
		None = 0,
		Follow = 1,
		DebugFollow = 2
	}

	public class FollowTargetInfo // TypeDefIndex: 4417
	{
		// Fields
		public ActObjCharactor ActChara; // 0x10
		public Vector3 CameraOffset; // 0x18
		public Vector3 TargetOffset; // 0x24

		// Properties
		public bool IsEnable { get => default; } // 0x009251C0-0x00925230 

		// Constructors
		public FollowTargetInfo() {} // 0x00925400-0x009254A0

		// Methods
		public void Clear() {} // 0x00925510-0x00925520
		public Vector3 GetFollowPosition() => default; // 0x00925230-0x009252F0
	}

	// Constructors
	public ActObjCamera() {} // 0x009252F0-0x00925400

	// Methods
	private void OnEnable() {} // 0x00924570-0x009245A0
	private void OnDisable() {} // 0x009245A0-0x009245B0
	public override void ApplySnapshotState(ActObjSnapshotState snapshotState) {} // 0x009245B0-0x009246B0
	public override void ForceMoveStop() {} // 0x009246B0-0x00924700
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x00924700-0x009247C0
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x009247C0-0x009248B0
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x009248B0-0x00924980
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00924980-0x00924A70
	public override void SetGeneralOnOff(bool bOn) {} // 0x00924A70-0x00924A80
	public void AddMoveAction(CamActionTask actionFunc) {} // 0x00924A80-0x00924B80
	public void ForceStopMove() {} // 0x00924BF0-0x00924C40
	public override void OnUpdateActObject() {} // 0x00924CA0-0x00924E10
	public void SetControlMode(CameraControlMode mode) {} // 0x009251B0-0x009251C0
	private void CameraController_() {} // 0x00924E10-0x00925190
}

