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

public class ActObjMapBg : ActObjBase, IActObj_Visible, IActObj_Color // TypeDefIndex: 4463
{
	// Fields
	public GameObject bgObjRef_; // 0x28
	private string loadedSymbolName_; // 0x30
	private List<Renderer> rendererList_; // 0x38
	private List<Renderer> visibleRendererList_; // 0x40
	private List<Light> visibleLightList_; // 0x48
	private MapGlobalSettingOverrider mapGlobalSettingOverrider_; // 0x50
	private MaterialPropertyBlock matPropBlk_; // 0x58
	private UIToken.UITokenCache uiTokenCache_; // 0x60
	private List<GroundNaviPoint> groundNaviPointList_; // 0x68
	private List<GroundCollisionMap> groundCollMapList_; // 0x70
	private PegaCM_GroundMixingCamera cm_groundMixingCam_; // 0x78
	private ActPlayerSyncTarget cm_actPlayerSyncTarget_; // 0x80
	private CampMapLoader campMapLoaderCache_; // 0x88
	private bool bVisible_; // 0x90
	private bool bReloadRequest_; // 0x91
	private ActObjImpl.WkMoveColor wkMoveColor_; // 0x98

	// Properties
	public bool IsValid { get => default; } // 0x00937880-0x009378F0 
	public override Vector3 positionForLook { get => default; } // 0x009378F0-0x00937960 
	public bool visible { get => default; set {} } // 0x00937960-0x00937970 0x00937970-0x00937BB0
	public bool IsMoveColor { get => default; } // 0x00939BD0-0x00939BE0 

	// Constructors
	public ActObjMapBg() {} // 0x0093A290-0x0093A3F0

	// Methods
	public void TryLoadAndInit(string symbolName, Action<bool, bool> loadedCb) {} // 0x00937BB0-0x00937DC0
	public void InitWork() {} // 0x009380E0-0x009380F0
	// [IteratorStateMachine] // 0x00618EE0-0x00618F50
	private IEnumerator Setup_(ResourceCache.Resource resource, PegasusActDatabase.MapData info, Action<bool> result) => default; // 0x009380F0-0x00938180
	private void Init_() {} // 0x00937DD0-0x009380E0
	private void OnEnable() {} // 0x00938D50-0x00938D60
	private void OnDisable() {} // 0x00938D60-0x00938D70
	private void OnDestroy() {} // 0x00938D70-0x00938E80
	public override void OnUpdateActObject() {} // 0x00938E80-0x00938EE0
	public void ForceApplyMapGlobalSettingOverrider() {} // 0x00938EE0-0x00938FD0
	public void ApplySpecialSetting() {} // 0x009381B0-0x00938AB0
	public GameObject GetBgObj(string tokenName) => default; // 0x00938FD0-0x00939060
	public T GetBgObj<T>(string tokenName)
		where T : Component => default;
	public void SetBgObj_Active(string tokenName, bool bActive) {} // 0x00939060-0x009391C0
	public void SetBgObj_MotionSpeed(string tokenName, float speed) {} // 0x009391C0-0x009392D0
	public void SetBgObj_PlayMotion(string tokenName, string name) {} // 0x009392D0-0x00939540
	public PegaCM_GroundMixingCamera Find_GroundMixingCamera() => default; // 0x00939540-0x009395E0
	public ActPlayerSyncTarget Find_ActPlayerSyncTarget() => default; // 0x009395E0-0x00939680
	public CampMapLoader FindCampMapLoader() => default; // 0x00939680-0x00939690
	public List<GroundNaviPoint> FindGroundNaviPoints() => default; // 0x0092F680-0x0092F690
	public List<GroundCollisionMap> FindGroundCollMaps() => default; // 0x00939690-0x009396A0
	public void RequestReloadCampMap() {} // 0x009396A0-0x009396B0
	// [IteratorStateMachine] // 0x00618F50-0x00618FC0
	public IEnumerator UpdateReloadCampMapRequest() => default; // 0x009396B0-0x00939720
	public void ReloadCampMap(Action endCb) {} // 0x00939750-0x00939A40
	public void ApplyColorToMaterial(Color toMulColor, Color toAddColor, Color toOverlayColor) {} // 0x00938AB0-0x00938D50
	public void SetMulColor(Color color) {} // 0x00939A50-0x00939A90
	public void SetAddColor(Color color) {} // 0x00939A90-0x00939AD0
	public void SetOverlayColor(Color color) {} // 0x00939AD0-0x00939B10
	public void MoveColorToByTime(Color toMulColor, Color toAddColor, Color toOverlayColor, float timeSec) {} // 0x00939B10-0x00939BD0
	public override void ApplySnapshotState(ActObjSnapshotState previewState) {} // 0x00939BE0-0x00939D40
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x00939D40-0x00939E00
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x00939E00-0x00939EF0
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00939EF0-0x00939FC0
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00939FC0-0x0093A0B0
	public override bool SetGeneralManipulateScale(Vector3 scale) => default; // 0x0093A0B0-0x0093A180
	public override bool GetGeneralManipulateScale(out Vector3 scale) {
		scale = default;
		return default;
	} // 0x0093A180-0x0093A280
	public override void SetGeneralOnOff(bool bOn) {} // 0x0093A280-0x0093A290
}

