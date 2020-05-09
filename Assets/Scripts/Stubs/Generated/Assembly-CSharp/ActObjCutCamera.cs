/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjCutCamera : ActObjBase // TypeDefIndex: 4442
{
	// Fields
	public Camera CameraRef; // 0x28
	public bool isEnableCamera; // 0x30

	// Properties
	public override Vector3 positionForLook { get => default; } // 0x00933BA0-0x00933BE0 
	public float FieldOfView { set {} } // 0x00933C40-0x00933C50
	public float NearClipPlane { set {} } // 0x00933C50-0x00933C60
	public float FarClipPlane { set {} } // 0x00933C60-0x00933C70

	// Constructors
	public ActObjCutCamera() {} // 0x00934000-0x00934010

	// Methods
	private void OnEnable() {} // 0x00933BE0-0x00933C10
	private void OnDisable() {} // 0x00933C10-0x00933C20
	public override void ApplySnapshotState(ActObjSnapshotState snapshotState) {} // 0x00933C20-0x00933C30
	public override void ForceMoveStop() {} // 0x00933C30-0x00933C40
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x00933C70-0x00933D30
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x00933D30-0x00933E20
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00933E20-0x00933EF0
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00933EF0-0x00933FE0
	public override void SetGeneralOnOff(bool bOn) {} // 0x00933FE0-0x00933FF0
	public override void OnUpdateActObject() {} // 0x00933FF0-0x00934000
}

