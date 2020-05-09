/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjEffect : ActObjBase, IActObj_Color // TypeDefIndex: 4457
{
	// Fields
	public GameObject effectObjRef_; // 0x28
	public BMEffect bmEffectRef_; // 0x30
	private string loadedSymbolName_; // 0x38

	// Properties
	public override Vector3 positionForLook { get => default; } // 0x00934010-0x00934030 
	public bool visible { get => default; set {} } // 0x00934030-0x009340F0 0x009340F0-0x009341F0
	public bool IsMoveColor { get => default; } // 0x00934D20-0x00934D30 

	// Constructors
	public ActObjEffect() {} // 0x00934D40-0x00934DA0

	// Methods
	public void ForceStartEffect() {} // 0x009341F0-0x00934210
	public void TryLoadAndInit(string symbolName, Action<bool, bool> loadedCb) {} // 0x00934210-0x00934550
	public void SetColor(Color color) {} // 0x009346A0-0x009346B0
	private void OnEnable() {} // 0x009346B0-0x009346C0
	private void OnDisable() {} // 0x009346C0-0x009346D0
	private void OnDestroy() {} // 0x00934550-0x009346A0
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x009346D0-0x00934790
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x00934790-0x00934880
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00934880-0x00934950
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00934950-0x00934A40
	public override bool SetGeneralManipulateScale(Vector3 scale) => default; // 0x00934A40-0x00934B10
	public override bool GetGeneralManipulateScale(out Vector3 scale) {
		scale = default;
		return default;
	} // 0x00934B10-0x00934C10
	public override void SetGeneralOnOff(bool bOn) {} // 0x00934C10-0x00934C20
	public void ApplyColorToMaterial(Color toMulColor, Color toAddColor, Color toOverlayColor) {} // 0x00934C20-0x00934CE0
	public void SetMulColor(Color color) {} // 0x00934CE0-0x00934CF0
	public void SetAddColor(Color color) {} // 0x00934CF0-0x00934D00
	public void SetOverlayColor(Color color) {} // 0x00934D00-0x00934D10
	public void MoveColorToByTime(Color toMulColor, Color toAddColor, Color toOverlayColor, float timeSec) {} // 0x00934D10-0x00934D20
	public override void OnUpdateActObject() {} // 0x00934D30-0x00934D40
}

