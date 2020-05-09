/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjGimmick : ActObjBase, IActObj_Color, IActObj_Visible // TypeDefIndex: 4458
{
	// Fields
	public GameObject gimmickObjRef_; // 0x28
	private string loadedSymbolName_; // 0x30
	private PegasusAnimationController animationController_; // 0x38
	private List<Renderer> rendererList_; // 0x40
	private List<Material> materialList_; // 0x48
	private MaterialPropertyBlock matPropBlk_; // 0x50
	private ActObjImpl.WkMoveColor wkMoveColor_; // 0x58
	private WkMove wkMove_; // 0x60
	private WkMoveHeight wkMoveHeight_; // 0x68

	// Properties
	public PegasusAnimationController AnimationController { get => default; } // 0x00934DA0-0x00934DB0 
	public bool IsValid { get => default; } // 0x00934DB0-0x00934E20 
	public override Vector3 positionForLook { get => default; } // 0x00934E20-0x00934E40 
	public bool visible { get => default; set {} } // 0x00934E40-0x00934EE0 0x00931270-0x00931320
	public bool IsMoveColor { get => default; } // 0x00935CF0-0x00935D00 
	private PegasusAnimationController animCtrl_ { get => default; } // 0x00935D00-0x00935D10 
	public bool IsMove { get => default; } // 0x00936520-0x00936530 
	public bool IsMoveHeight { get => default; } // 0x00936650-0x00936660 

	// Nested types
	private class WkMove // TypeDefIndex: 4459
	{
		// Fields
		private ActObjGimmick owner_; // 0x10
		private bool bMove_; // 0x18
		public MoveVector3 movePos; // 0x20

		// Properties
		public bool Is_Move { get => default; } // 0x00936530-0x00936540 

		// Constructors
		public WkMove() {} // 0x009372E0-0x00937350

		// Methods
		public void Set_Move() {} // 0x00936480-0x00936490
		public void Initalize(ActObjGimmick ownerChara) {} // 0x00935880-0x00935910
		public void Update() {} // 0x00936860-0x009368D0
		private void ApplyMove_() {} // 0x009375B0-0x00937680
	}

	private class WkMoveHeight // TypeDefIndex: 4460
	{
		// Fields
		private ActObjGimmick owner_; // 0x10
		private bool bMove_; // 0x18
		public MoveFloatVer2 moveHeight; // 0x20

		// Properties
		public bool Is_Move { get => default; } // 0x00936660-0x00936670 

		// Constructors
		public WkMoveHeight() {} // 0x00937350-0x009373C0

		// Methods
		public void Set_Move() {} // 0x009365C0-0x009365D0
		public void Initalize(ActObjGimmick ownerChara) {} // 0x00935910-0x00935980
		public void Update() {} // 0x009368D0-0x00936940
		private void ApplyMove_() {} // 0x00937680-0x00937750
	}

	// Constructors
	public ActObjGimmick() {} // 0x00937140-0x009372E0

	// Methods
	public void TryLoadAndInit(string symbolName, Action<bool, bool> loadedCb) {} // 0x00934EE0-0x009350E0
	public void InitWork() {} // 0x00935380-0x00935390
	private bool Setup_(ResourceCache.Resource resource, PegasusActDatabase.GimmickData info) => default; // 0x00935390-0x00935880
	private void Init_() {} // 0x009350F0-0x00935380
	public void ApplyColorToMaterial(Color toMulColor, Color toAddColor, Color toOverlayColor) {} // 0x00935980-0x00935B70
	public void SetMulColor(Color color) {} // 0x00935B70-0x00935BB0
	public void SetAddColor(Color color) {} // 0x00935BB0-0x00935BF0
	public void SetOverlayColor(Color color) {} // 0x00935BF0-0x00935C30
	public void MoveColorToByTime(Color toMulColor, Color toAddColor, Color toOverlayColor, float timeSec) {} // 0x00935C30-0x00935CF0
	public bool PlayMotion(string motion, bool bLoop, float blendTimeSec, float motionSpeed) => default; // 0x00935D10-0x00935E30
	public bool SetNextMotion(string motion, bool bLoop, float blendTimeSec, float motionSpeed) => default; // 0x00935E30-0x00936000
	public void ChangeMotionLoopFlag(bool flag) {} // 0x00936000-0x009360D0
	public void ChangeMotionSpeed(float motionSpeed) {} // 0x009360D0-0x009361A0
	public bool IsPlayMotion() => default; // 0x009361A0-0x00936260
	public void SetNormalizeTime(float fNomilizeTime) {} // 0x00936260-0x00936330
	public void MoveToBySpeed(Vector3 toPos, float speed, ActParam_Accel accel) {} // 0x00936330-0x00936480
	public void MoveHeightToByTime(Vector3 toPos, float timeSec, ActParam_Accel accel) {} // 0x00936490-0x00936520
	public void MoveHeightToBySpeed(float toHeight, float speed, ActParam_Accel accel) {} // 0x00936540-0x009365C0
	public void MoveHeightToByTime(float toHeight, float timeSec, ActParam_Accel accel) {} // 0x009365D0-0x00936650
	private void OnEnable() {} // 0x00936670-0x00936680
	private void OnDisable() {} // 0x00936680-0x00936690
	private void OnDestroy() {} // 0x00936690-0x00936760
	public override void OnUpdateActObject() {} // 0x00936760-0x00936860
	public override void ApplySnapshotState(ActObjSnapshotState previewState) {} // 0x00936940-0x00936B50
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x00936B50-0x00936C10
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x00936C10-0x00936D00
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00936D00-0x00936DD0
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00936DD0-0x00936EC0
	public override bool SetGeneralManipulateScale(Vector3 scale) => default; // 0x00936EC0-0x00936F90
	public override bool GetGeneralManipulateScale(out Vector3 scale) {
		scale = default;
		return default;
	} // 0x00936F90-0x00937090
	public override void SetGeneralOnOff(bool bOn) {} // 0x00937090-0x00937140
}

