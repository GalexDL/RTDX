/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x00608A10-0x00608A20
public abstract class ActObjBase : MonoBehaviour // TypeDefIndex: 4409
{
	// Properties
	public string symbolName { get; set; } // 0x00923FF0-0x00924000 0x00924000-0x00924010
	public abstract Vector3 positionForLook { get; }

	// Events
	public event Action<ActObjBase> OnUnloadActObjectEvent;

	// Constructors
	protected ActObjBase() {} // 0x00924480-0x00924490

	// Methods
	public virtual void ApplySnapshotState(ActObjSnapshotState snapshotState) {} // 0x00924010-0x00924020
	public virtual void ForceMoveStop() {} // 0x00924020-0x00924030
	public abstract void OnUpdateActObject();
	public void CallUnloadActObjectEvent() {} // 0x00924250-0x009242C0
	public virtual bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x009242C0-0x009242D0
	public virtual bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x009242D0-0x00924350
	public virtual bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00924350-0x00924360
	public virtual bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00924360-0x009243E0
	public virtual bool SetGeneralManipulateScale(Vector3 scale) => default; // 0x009243E0-0x009243F0
	public virtual bool GetGeneralManipulateScale(out Vector3 scale) {
		scale = default;
		return default;
	} // 0x009243F0-0x00924470
	public virtual void SetGeneralOnOff(bool bOn) {} // 0x00924470-0x00924480
}

