/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using effect;
using kamina;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class BMEffect : Frame // TypeDefIndex: 5948
{
	// Fields
	private static readonly string BundlePath; // 0x00
	private const float DEFAULT_FOVY = 40f; // Metadata: 0x0061228D
	private const float DEFAULT_RETIRE_TIME = 0.25f; // Metadata: 0x00612291
	private const float CAMERA_OFFSET_VALUE = 1000f; // Metadata: 0x00612295
	private const float CAMERA_SRC_OFFSET_VALUE = 10f; // Metadata: 0x00612299
	private static int s_resourceSpaceID; // 0x08
	private GraphicsSystem.EffectDatabaseParameter baseParameter_; // 0x20
	private GameObject obj_; // 0x28
	private GameObject transformNativeOffset_; // 0x30
	private GameObject transformObj_; // 0x38
	private GameObject attachTargetObj_; // 0x40
	private NormalModel masterObj_; // 0x48
	private BishamonEffect body_; // 0x50
	private float m_fSpotDependentRate; // 0x58
	private float m_fSpotDependentPrevRate; // 0x5C
	private float fPrevSec_; // 0x60
	private float fNowSec_; // 0x64
	private float fRetireSec_; // 0x68
	private float fRetireSetSec_; // 0x6C
	private float fColorVisibleRate_; // 0x70
	private Color color_; // 0x74
	private bool bStarted_; // 0x84
	private bool bRetire_; // 0x85
	private bool bRetireAlpha_; // 0x86
	private bool bColorUpdateDirtyFlag_; // 0x87
	private bool bAutoDestroy_; // 0x88
	private bool bVisible_; // 0x89
	private bool bVisibleDirtyFlag_; // 0x8A
	private bool bSpotVisibleOff_; // 0x8B
	private bool bEffectiveSpot_; // 0x8C
	private bool bEffectiveSpotOptionMasterDepend_; // 0x8D
	private bool bEnableSe_; // 0x8E
	private bool bDestroyGuard_; // 0x8F
	private Regex meMatch_; // 0x90

	// Properties
	public GraphicsSystem.EffectDatabaseParameter BaseParameter { get => default; } // 0x0086BDC0-0x0086BDD0 
	public bool DestroyGuard { get => default; set {} } // 0x0086BDE0-0x0086BDF0 0x0086BDD0-0x0086BDE0
	public Transform TransformObject { get => default; } // 0x0086CDD0-0x0086CDE0 
	public Transform LocalTransformObject { get => default; } // 0x00870810-0x00870820 

	// Nested types
	public enum CallbackStatus // TypeDefIndex: 5949
	{
		FINISHED = 0
	}

	// Constructors
	public BMEffect() {} // Dummy constructor
	private BMEffect(int nativeControlId, GraphicsSystem.EffectDatabaseParameter param, Vector3 pos, Vector3 rotateDegree, GraphicsSystem.LayerId layerId) {} // 0x0086BF00-0x0086C530
	static BMEffect() {} // 0x00870820-0x00870890

	// Methods
	public static void Setup() {} // 0x0086BDF0-0x0086BE00
	public static BMEffect CreateFromNative(int nativeControlId, uint hashSymbol, Vector3 pos, Vector3 rotateDegree) => default; // 0x0086BE00-0x0086BF00
	public static BMEffect Create(string symbol, Vector3 pos, Vector3 rotateDegree) => default; // 0x0086C530-0x0086C610
	public static BMEffect Create(uint gfxSymbol, Vector3 pos, Vector3 rotateDegree, GraphicsSystem.LayerId layerId) => default; // 0x0086C610-0x0086C720
	// [IteratorStateMachine] // 0x00623900-0x00623970
	public static IEnumerator ClearResourceCache() => default; // 0x0086C720-0x0086C780
	public static BMEffect CreateOnce(uint gfxSymbol, Vector3 pos) => default; // 0x0086C7B0-0x0086C9A0
	public static void CreateOnce(string symbol, Vector3 pos) {} // 0x0086CAF0-0x0086CBB0
	public static BMEffect CreateOnceForRenderTexture(string symbol, Vector3 pos) => default; // 0x0086CBB0-0x0086CDD0
	public void SetPosition(float x, float y, float z) {} // 0x0086CDE0-0x0086CF00
	public void SetPosition(Vector3 v) {} // 0x0086CF70-0x0086D080
	public void SetRotation(Quaternion q) {} // 0x0086D080-0x0086D190
	public void SetScale(float x, float y, float z) {} // 0x00857870-0x00857920
	public void SetNativeLocalScale(float x, float y, float z) {} // 0x0086D210-0x0086D340
	public void SetLocalScale(float x, float y, float z) {} // 0x0086D340-0x0086D470
	public void Rotate(Quaternion q) {} // 0x0086D470-0x0086D580
	public void SetLoop(bool bLoop) {} // 0x0086D580-0x0086D630
	public bool IsLoop() => default; // 0x0086D630-0x0086D710
	public void SetNativeLocalPosition(Vector3 v) {} // 0x0086D710-0x0086D800
	public void SetNativeLocalPosition(float x, float y, float z) {} // 0x0086D800-0x0086D900
	public void SetLocalPosition(Vector3 v) {} // 0x0086D900-0x0086D9F0
	public void SetLocalPosition(float x, float y, float z) {} // 0x0086D9F0-0x0086DAF0
	public void AddLocalPosition(Vector3 v) {} // 0x0086DAF0-0x0086DC60
	public void SetAutoDestroy(bool bEnable) {} // 0x0086CA40-0x0086CAF0
	public bool IsValid() => default; // 0x008577D0-0x00857870
	public bool IsBillboard() => default; // 0x0086D190-0x0086D1C0
	protected override void OnTerminate() {} // 0x0086DC60-0x0086DE70
	public void StartEffect() {} // 0x0086C9A0-0x0086CA40
	public void Retire() {} // 0x0086E120-0x0086E180
	private void RetireAlpha() {} // 0x0086E1A0-0x0086E1C0
	private void RetireAlpha(float fSec) {} // 0x0086E180-0x0086E1A0
	public void SetMaster(NormalModel obj) {} // 0x0086E1C0-0x0086E1D0
	public void SetMasterAttachOrAppearCharacterModelForDefaultParameter(NormalModel model) {} // 0x0086E1D0-0x0086E1E0
	public void AttachOrAppearCharacterModelForDefaultParameter(NormalModel model, bool bAttach) {} // 0x0086E460-0x0086E470
	public static void CalcAttachOrAppearPositionFromCharacterModel(NormalModel model, PlacementType placementType, bool bAttach, out Transform outBone, out bool bOutNoSetting) {
		outBone = default;
		bOutNoSetting = default;
	} // 0x0086E470-0x0086E860
	private void AttachOrAppearCharacterModel(NormalModel model, bool bAttach) {} // 0x0086E1E0-0x0086E460
	public void AttachBoneObject(Transform transform, Vector3 offset) {} // 0x0086E860-0x0086EA80
	public void SetVisible(bool bEnable) {} // 0x0086EA80-0x0086EAB0
	public void SetVisibleAlpha(float alpha) {} // 0x00857920-0x00857940
	public void SetColor(float r, float g, float b, float a) {} // 0x0086EAB0-0x0086EAD0
	private void SetSpotVisibleOff(bool bEnable) {} // 0x0086EAD0-0x0086EB00
	public bool IsVisible() => default; // 0x0086EB00-0x0086EB10
	public bool IsCameraEffect() => default; // 0x0086CF00-0x0086CF70
	public bool IsAutoPosition() => default; // 0x0086EB10-0x0086EB80
	public bool IsAutoScale() => default; // 0x0086D1C0-0x0086D210
	private void UpdatePositionFromCamera() {} // 0x0086EB80-0x0086F290
	private void UpdateSound() {} // 0x0086F290-0x0086F4E0
	private void UpdateScriptEvent(bool bNowEnd) {} // 0x0086DE70-0x0086E120
	private void UpdateVisible() {} // 0x0086F560-0x0086F5D0
	public void SetEffectiveSpot(bool bEnable, bool bMasterDependEnable) {} // 0x0086F5D0-0x0086F660
	public bool IsEffectiveSpot() => default; // 0x0086F660-0x0086F670
	private void CheckSpot() {} // 0x0086F670-0x0086F710
	public override void Update() {} // 0x0086F710-0x0086F980
	public override void LastUpdate() {} // 0x0086F980-0x0086FAF0
	public static void ExecuteProductionScript(string func) {} // 0x0086F4E0-0x0086F560
}

