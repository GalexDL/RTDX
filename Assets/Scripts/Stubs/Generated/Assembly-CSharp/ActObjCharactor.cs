/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActObjCharactor : ActObjBase, IActObj_Visible, IActObj_Color // TypeDefIndex: 4418
{
	// Fields
	private static readonly float DEFAULT_BLEND_TIME; // 0x00
	private CharacterModel charaModelRef_; // 0x28
	private CapsuleCollider charaModelRadiousCollider_; // 0x30
	private Vector3 worldPivot_; // 0x3C
	private float heightOffset_; // 0x48
	public PositionPivotMode positionPivotMode; // 0x4C
	private float radisuCache_; // 0x50
	private Vector3 lastRaycastPosition_; // 0x54
	private bool lastRaycastHit_; // 0x60
	private static int layerMask_BG_; // 0x04
	private static int layerMask_WALL_; // 0x08
	private const float TurnWalkThresholdDeg_ = 0f; // Metadata: 0x006107FD
	private BMEffect effectManpu_; // 0x68
	private Dictionary<string, BMEffect> m_manpuCache_; // 0x70
	private ActObjGimmick actObjNamazunWater_; // 0x78
	private WkAutoTaiki wkAutoTaiki_; // 0x80
	private WkMove wkMove_; // 0x88
	private WkMoveHeight wkMoveHeight_; // 0x90
	private WkRotate_ wkRotate_; // 0x98
	private WkMoveScale wkMoveScale_; // 0xA0
	private WkShake_ wkShake_; // 0xA8
	private ActObjImpl.WkMoveColor wkMoveColor_; // 0xB0
	private SpecialControlMode specialControlMode_; // 0xB8
	private SpecialControlMode prevSpecialControlMode_; // 0xBC
	private bool isSpecialControlEnable; // 0xC0
	private bool bChangeEnable_; // 0xC1
	public static float SpeedPerSec; // 0x0C
	public static float DashSpeedPerSec; // 0x10
	public static float DashMoveThresholdSpeedPerSec; // 0x14
	private bool bNeedInit_; // 0xC2
	private Quaternion targetRotQ_; // 0xC4
	private BMEffect effectWalkKemuri_; // 0xD8
	public ActObjCharactor actCh_FolowTarget; // 0xE0
	public float Follow_MoveThresholdDist; // 0xE8
	public float Follow_StopThresholdDist; // 0xEC
	public float Follow_RunSlowThresholdDist; // 0xF0
	public float Follow_RunThresholdDist; // 0xF4
	public float Follow_WarpThresholdDist; // 0xF8
	private FollowWork_ followWork_; // 0x100
	private List<GroundNaviPoint.WayPoint> lastFollowNaviPath_; // 0x108
	private static List<Vector3> CollMapGroundOnlyCheck_verticesCache_; // 0x18
	private static List<int> CollMapGroundOnlyCheck_triangleCache_; // 0x20

	// Properties
	public CharacterModel CharacterModelRef { get => default; } // 0x00925530-0x00925540 
	public bool visible { get; set; } // 0x00925540-0x00925550 0x00925550-0x00925560
	public bool IsValid { get => default; } // 0x00925560-0x00925570 
	public override Vector3 positionForLook { get => default; } // 0x00925570-0x00925580 
	[Obsolete] // 0x0065AD60-0x0065AD70
	public new Transform transform { get => default; } // 0x00925590-0x00925610 
	private Vector3 charaModelTransform_Position_ { get => default; set {} } // 0x00925610-0x009256B0 0x009256B0-0x00925700
	private Quaternion charaModelTransform_Rotation_ { get => default; set {} } // 0x00925700-0x009257A0 0x009257A0-0x00925800
	public Vector3 worldPivot { get => default; set {} } // 0x00925520-0x00925530 0x00925880-0x00925910
	public Vector2 worldPivot2d { get => default; set {} } // 0x00925910-0x00925950 0x00925950-0x009259E0
	public float heightOffset { get => default; set {} } // 0x009259E0-0x009259F0 0x009259F0-0x00925A80
	public Vector3 worldPositionRef { get => default; } // 0x00925580-0x00925590 
	public Quaternion rotation { get => default; set {} } // 0x00925A80-0x00925B30 0x00925B50-0x00925C00
	public float rotationYaw { get => default; } // 0x00925C20-0x00925C60 
	public float CharaRadius { get => default; } // 0x00925C60-0x00925DD0 
	public float TalkLenScale { get => default; } // 0x00925DD0-0x00925E10 
	private PegasusAnimationController animCtrl_ { get => default; } // 0x00928B30-0x00928B40 
	public bool IsAutoTaiki { get => default; set {} } // 0x00929090-0x009290A0 0x009290B0-0x009290D0
	public bool IsTaiki { get => default; } // 0x009290F0-0x00929110 
	public bool IsMove { get => default; } // 0x009292A0-0x009292C0 
	public bool IsMoveHeight { get => default; } // 0x00929380-0x00929390 
	public bool IsRotate { get => default; } // 0x00929C50-0x00929C70 
	public bool IsMoveScale { get => default; } // 0x00929DD0-0x00929DE0 
	public bool IsShake { get => default; } // 0x00929FD0-0x00929FE0 
	public bool IsMoveColor { get => default; } // 0x0092A0C0-0x0092A0D0 
	public bool IsLoopManpu { get => default; } // 0x0092A300-0x0092A320 
	public bool IsPlayManpu { get => default; } // 0x0092A320-0x0092A370 

	// Nested types
	public enum PositionPivotMode // TypeDefIndex: 4419
	{
		None = 0,
		AutoGroundFit = 1
	}

	private class WkAutoTaiki // TypeDefIndex: 4420
	{
		// Fields
		private State stat_; // 0x10
		private int subMode_; // 0x14
		private ActObjCharactor ownerChara_; // 0x18
		private bool isTaikiMotionWait00_; // 0x20
		private bool isEnable_; // 0x21
		private bool isIgnore_ToMotionEnd_; // 0x22
		public bool isAllowAutoTaiki_; // 0x23

		// Properties
		public bool isEnable { get => default; set {} } // 0x009290A0-0x009290B0 0x009290D0-0x009290F0
		public bool isIgnore_ToMotionEnd { get => default; set {} } // 0x00932340-0x00932350 0x00928C70-0x00928C90
		public bool IsTaiki { get => default; } // 0x00929110-0x00929120 

		// Nested types
		private enum State // TypeDefIndex: 4421
		{
			TAIKI = 0,
			NONE = 1
		}

		// Constructors
		public WkAutoTaiki() {} // 0x00930BC0-0x00930BD0

		// Methods
		private void SetNone_() {} // 0x00932330-0x00932340
		private void SetTaiki_() {} // 0x00932350-0x00932360
		public void Initalize(ActObjCharactor ownerChara) {} // 0x00928610-0x00928630
		public void Update() {} // 0x0092B2F0-0x0092B500
	}

	public class SetWkMoveParam_WalkTo // TypeDefIndex: 4422
	{
		// Fields
		public bool withMotion; // 0x10
		public bool withYawTurn; // 0x11
		public bool isYawTurnWait; // 0x12
		public float yawTurnSpeed; // 0x14
		public MoveRotateYaw.RotationType yawTurnRotType; // 0x18
		public bool withCollision; // 0x1C
		public bool withCollisionHitAutoTaiki; // 0x1D
		public bool isMotionRun; // 0x1E
		public List<Vector2> splineRoutePoint; // 0x20

		// Constructors
		public SetWkMoveParam_WalkTo() {} // 0x00932310-0x00932330
	}

	private class WkMove // TypeDefIndex: 4423
	{
		// Fields
		private State stat_; // 0x10
		private int subMode_; // 0x14
		private int count_; // 0x18
		private ActObjCharactor ownerChara_; // 0x20
		private Vector2 target_; // 0x28
		private List<Vector2> splineRoutePoint_; // 0x30
		private float speed_; // 0x38
		private SetWkMoveParam_WalkTo param_; // 0x40
		private bool isTaikiMotionWait00_; // 0x48
		private bool isSpline_; // 0x49
		private int splineIdx_; // 0x4C
		private float splineNowDist_; // 0x50
		private bool isMapCollHit_; // 0x54
		private int mapCollHitCnt_; // 0x58
		private MoveRotateYaw moveYawRad; // 0x60

		// Nested types
		private enum State // TypeDefIndex: 4424
		{
			TAIKI = 0,
			WALK_TO = 1,
			NONE = 2
		}

		// Constructors
		public WkMove() {} // 0x00930BD0-0x00930C60

		// Methods
		public void Set_None() {} // 0x00929290-0x009292A0
		public bool Is_None() => default; // 0x009292C0-0x009292D0
		public void Set_Taiki(bool bIsTaikiMotionWait00) {} // 0x00932360-0x00932390
		public bool Is_Taiki() => default; // 0x00932390-0x009323A0
		private void _StepWkMove_TAIKI() {} // 0x009323A0-0x00932520
		public void Set_WalkTo(Vector2 target, float speed, SetWkMoveParam_WalkTo param) {} // 0x00929130-0x00929270
		public bool IsWkMove_WalkTo() => default; // 0x00932520-0x00932530
		private void _StepWkMove_WALK_TO() {} // 0x00932530-0x00933490
		public void Initalize(ActObjCharactor ownerChara) {} // 0x00928630-0x00928710
		public void Update() {} // 0x0092ACF0-0x0092AD10
	}

	private class WkMoveHeight // TypeDefIndex: 4425
	{
		// Fields
		private ActObjCharactor ownerChara_; // 0x10
		private bool bMove_; // 0x18
		public MoveFloatVer2 moveHeight; // 0x20

		// Properties
		public bool Is_Move { get => default; } // 0x00929390-0x009293A0 

		// Constructors
		public WkMoveHeight() {} // 0x00930C60-0x00930CD0

		// Methods
		public void Set_Move() {} // 0x00929320-0x00929330
		public void Initalize(ActObjCharactor ownerChara) {} // 0x00928720-0x00928790
		public void Update() {} // 0x0092AC80-0x0092ACF0
		private void ApplyMove_() {} // 0x009334A0-0x00933580
	}

	private class WkRotate_ // TypeDefIndex: 4426
	{
		// Fields
		private State stat_; // 0x10
		private MoveRotateYaw moveYaw; // 0x18
		private bool withWalkMotion_; // 0x20
		private ActObjCharactor ownerChara_; // 0x28
		private ActObjBase lookTarget_; // 0x30
		private const float WALK_TIME_FACTOR = 2.6179938f; // Metadata: 0x0061081D

		// Nested types
		private enum State // TypeDefIndex: 4427
		{
			NONE = 0,
			DIR_TO = 1,
			LOOK_TO_TARGET = 2
		}

		// Constructors
		public WkRotate_() {} // 0x00930CD0-0x00930D40

		// Methods
		public float Get() => default; // 0x00925B40-0x00925B50
		public void Set(float yawRad) {} // 0x00925C00-0x00925C20
		public void Set_None() {} // 0x00929D30-0x00929D40
		public bool Is_None() => default; // 0x00925B30-0x00925B40
		public void Set_DirTo_fromSpeed(float radian, float speed, float atRaito, float dtRaito, MoveRotateYaw.RotationType rotType, bool withWalkMotion) {} // 0x009293D0-0x00929540
		public void Set_DirTo_fromTime(float radian, float time, float atTime, float dtTime, MoveRotateYaw.RotationType rotType, bool withWalkMotion) {} // 0x00929560-0x009296D0
		public void Set_DirToOffs_fromSpeed(float radian, float speed, float atRaito, float dtRaito, bool withWalkMotion) {} // 0x009336F0-0x00933850
		public void Set_DirToOffs_fromTime(float radian, float time, float atTime, float dtTime, bool withWalkMotion) {} // 0x00933860-0x009339C0
		public bool Is_DirTo() => default; // 0x00933490-0x009334A0
		private void DirTo_Core_(bool withWalkMotion, Action setFunc) {} // 0x00933620-0x009336E0
		public void Set_LookToTarget(ActObjBase target) {} // 0x00929D20-0x00929D30
		public bool Is_LookToTarget() => default; // 0x009339D0-0x009339E0
		public void Initalize(ActObjCharactor ownerChara) {} // 0x00928710-0x00928720
		public void Update() {} // 0x0092AD10-0x0092B070
	}

	private class WkMoveScale // TypeDefIndex: 4432
	{
		// Fields
		private ActObjCharactor ownerChara_; // 0x10
		private bool bMove_; // 0x18
		public MoveVector3 moveScale_; // 0x20

		// Properties
		public bool Is_Move { get => default; } // 0x00929DE0-0x00929DF0 

		// Constructors
		public WkMoveScale() {} // 0x00930D40-0x00930DE0

		// Methods
		public void Set_Move() {} // 0x00929D40-0x00929DD0
		public void Initalize(ActObjCharactor ownerChara) {} // 0x00928790-0x00928830
		public void Update() {} // 0x0092B070-0x0092B140
		private void ApplyMove_() {} // 0x00933580-0x00933610
	}

	public enum ShakeType // TypeDefIndex: 4433
	{
		SignRandom = 0,
		RangeRandom = 100,
		GaussianRangeRandom = 200
	}

	private class WkShake_ // TypeDefIndex: 4434
	{
		// Fields
		private Vector3 vSize; // 0x10
		public Vector3 vOffset; // 0x1C
		private float fSec; // 0x28
		private float fIntervalSec; // 0x2C
		private bool bEnable; // 0x30
		private ShakeType shakeType; // 0x34

		// Properties
		public bool IsShake { get => default; } // 0x00929FE0-0x00929FF0 

		// Constructors
		public WkShake_() {} // 0x00930DE0-0x00930E50

		// Methods
		public void Reset() {} // 0x009288C0-0x00928920
		public void Set(ShakeType _shakeType, Vector3 _vSize, float _fIntervalSec) {} // 0x00929EB0-0x00929F70
		private float GaussianRandom_(float range) => default; // 0x00933A60-0x00933BA0
		public void Update() {} // 0x0092B190-0x0092B2F0
	}

	public enum SpecialControlMode // TypeDefIndex: 4435
	{
		None = 0,
		PlayerControl = 1,
		Follow = 2
	}

	private class FollowWork_ // TypeDefIndex: 4436
	{
		// Fields
		public Mode mode; // 0x10
		public float timerA; // 0x14
		public float timerB; // 0x18
		public ActObjCharactor lastContactCh; // 0x20
		public List<Vector2> followTargetPosList_; // 0x28
		public List<Vector2> myPosList_; // 0x30

		// Nested types
		public enum Mode // TypeDefIndex: 4437
		{
			None = 0,
			Wait = 1,
			FollowWalk = 2,
			FollowRun = 3,
			FollowBack = 4
		}

		// Constructors
		public FollowWork_() {} // 0x00930F90-0x00931020

		// Methods
		public void Init() {} // 0x0092DF00-0x0092DF60
		public void SetMode(Mode mode_) {} // 0x0092DF60-0x0092DF70
	}

	// Constructors
	public ActObjCharactor() {} // 0x00930770-0x00930BC0
	static ActObjCharactor() {} // 0x00931020-0x00931120

	// Methods
	private void applyToWorldPos_() {} // 0x00925800-0x00925880
	public bool CharaRaycastPosition(out Vector3 hitPos) {
		hitPos = default;
		return default;
	} // 0x00925E10-0x00926040
	public void ResetCache_CharaRaycastPosition() {} // 0x00926040-0x00926050
	public static bool CheckGroundHit_(Vector2 pos2d) => default; // 0x00926050-0x009260F0
	private static bool CheckGroundHit_(Vector2 pos2d, out RaycastHit hit) {
		hit = default;
		return default;
	} // 0x009260F0-0x00926270
	private static float RaycastGround_(Vector2 pos2d) => default; // 0x00926270-0x009263D0
	private static Vector3 CalcPos3d_RaycastGround_(Vector2 pos2d) => default; // 0x009263D0-0x00926480
	private void OnEnable() {} // 0x00926480-0x00926490
	private void OnDisable() {} // 0x00926490-0x009264A0
	private void OnDestroy() {} // 0x009264A0-0x009266F0
	private void Start() {} // 0x00926830-0x00926A00
	public override void ApplySnapshotState(ActObjSnapshotState previewState) {} // 0x00926A00-0x00926CF0
	public override void ForceMoveStop() {} // 0x00927030-0x00927040
	public override bool SetGeneralManipulatePos(Vector3 worldPos) => default; // 0x00927400-0x009274A0
	public override bool GetGeneralManipulatePos(out Vector3 worldPos) {
		worldPos = default;
		return default;
	} // 0x009274A0-0x00927550
	public override bool SetGeneralManipulateRot(Quaternion worldRotQ) => default; // 0x00927550-0x00927580
	public override bool GetGeneralManipulateRot(out Quaternion worldRotQ) {
		worldRotQ = default;
		return default;
	} // 0x00927580-0x00927640
	public override bool SetGeneralManipulateScale(Vector3 scale) => default; // 0x00927640-0x00927670
	public override bool GetGeneralManipulateScale(out Vector3 scale) {
		scale = default;
		return default;
	} // 0x00927670-0x00927710
	public override void SetGeneralOnOff(bool bOn) {} // 0x00927710-0x00927730
	private static float _gems_spline(float t, float v0, float v1, float v2, float v3) => default; // 0x00927730-0x009277B0
	private static float _gems_spline_len2d(float x0, float x1, float x2, float x3, float y0, float y1, float y2, float y3, int div) => default; // 0x009277B0-0x00927A10
	private static float _gems_spline_time_from_len2d(float fromLen, float x0, float x1, float x2, float x3, float y0, float y1, float y2, float y3, int div) => default; // 0x00927A10-0x00927CB0
	public static bool CalcWalkSpine(Vector2[] points, float dist, out Vector2 outPos) {
		outPos = default;
		return default;
	} // 0x00927CB0-0x00928230
	public void TryLoadAndInit(string symbolName, Action<bool, bool> loadedCb) {} // 0x00928230-0x00928420
	public void TryLoadAndInit(PegasusActDatabase.ActorData actData, Action<bool> loadedCb) {} // 0x00928430-0x009285F0
	public void InitWork() {} // 0x00928600-0x00928610
	private void Init_() {} // 0x00927040-0x00927400
	private void ApplySpecialiSetting() {} // 0x009289E0-0x00928B30
	public void PreLoadMotion(string motion) {} // 0x00928B40-0x00928C70
	public bool PlayMotion(string motion, bool bLoop, float blendTimeSec, float motionSpeed) => default; // 0x00926E00-0x00926EF0
	public bool SetNextMotion(string motion, bool bLoop, float blendTimeSec, float motionSpeed) => default; // 0x00928C90-0x00928DB0
	public void ChangeMotionLoopFlag(bool flag) {} // 0x00928DB0-0x00928E30
	public void ChangeMotionSpeed(float motionSpeed) {} // 0x00928E30-0x00928EB0
	public bool IsPlayMotion() => default; // 0x00928EB0-0x00928F20
	public void SetNormalizeTime(float fNomilizeTime) {} // 0x00926EF0-0x00926F70
	public string GetDefaultWaitMotion() => default; // 0x00928F20-0x00928FD0
	public bool PlayTaikiMotion(float blendTimeSec) => default; // 0x00928FD0-0x00929090
	public void WalkTo(Vector2 toPos2d, float speed, SetWkMoveParam_WalkTo param) {} // 0x00929120-0x00929130
	public void StopWalk() {} // 0x00929270-0x00929290
	public void MoveHeightToBySpeed(float toHeight, float speed, ActParam_Accel accel) {} // 0x009292D0-0x00929320
	public void MoveHeightToByTime(float toHeight, float timeSec, ActParam_Accel accel) {} // 0x00929330-0x00929380
	public void DirTo(float deg, float speedDegPerSec, MoveRotateYaw.RotationType rotType, bool bWithWalk) {} // 0x009293A0-0x009293D0
	public void DirTo_Time(float deg, float sec, MoveRotateYaw.RotationType rotType, bool bWithWalk) {} // 0x00929540-0x00929560
	public void DirTo(Vector2 lookToPos2d, float degPerSec, MoveRotateYaw.RotationType rotType, bool bWithWalk) {} // 0x009296D0-0x00929860
	public void DirTo_Time(Vector2 lookToPos2d, float sec, MoveRotateYaw.RotationType rotType, bool bWithWalk) {} // 0x00929860-0x009299F0
	public void DirTo_WithWalkMotionAuto(Vector2 lookToPos2d, float degPerSec, MoveRotateYaw.RotationType rotType) {} // 0x009299F0-0x00929B60
	public void DirTo_WithWalkMotionAuto(float deg, float degPerSec, MoveRotateYaw.RotationType rotType) {} // 0x00929B60-0x00929C50
	public void DirLockTo(ActObjBase lockToActObj) {} // 0x00929C70-0x00929D20
	public void MoveScaleToByTime(Vector3 toScale, float timeSec, ActParam_Accel accel) {} // 0x00926CF0-0x00926E00
	public void SetShake(ShakeType _shakeType, Vector3 _vSize, float _fIntervalSec) {} // 0x00929DF0-0x00929EB0
	public void ResetShake() {} // 0x00929F70-0x00929FD0
	public void ApplyColorToMaterial(Color toMulColor, Color toAddColor, Color toOverlayColor) {} // 0x00928920-0x009289E0
	public void SetMulColor(Color color) {} // 0x00929FF0-0x0092A030
	public void SetAddColor(Color color) {} // 0x0092A040-0x0092A080
	public void SetOverlayColor(Color color) {} // 0x0092A080-0x0092A0C0
	public void MoveColorToByTime(Color toMulColor, Color toAddColor, Color toOverlayColor, float timeSec) {} // 0x00926F70-0x00927030
	public void PlayManpu(string gfxSymbol) {} // 0x0092A0E0-0x0092A300
	public void ResetManpu() {} // 0x009266F0-0x00926760
	private void NamazunWater_SetupAfterLoad_() {} // 0x0092A370-0x0092A4D0
	private void NamazunWater_Terminate_() {} // 0x00926760-0x00926830
	public override void OnUpdateActObject() {} // 0x0092A690-0x0092ABF0
	public void InitSpecialControlMode(SpecialControlMode mode) {} // 0x0092B500-0x0092B510
	public void SetSpecialControlEnable(bool bEnable) {} // 0x0092B510-0x0092B540
	public float CalcPlayerMotionSpeed(float moveDist, bool isRun) => default; // 0x0092B540-0x0092B590
	private void UpdateFromPreActLoop_() {} // 0x0092ABF0-0x0092AC80
	public void UpdateFromGroundLoop() {} // 0x0092CC20-0x0092CC80
	private void UpdatePlayerController_PlayerControl_() {} // 0x0092CC80-0x0092D4C0
	private void PlayWalkKemuri_() {} // 0x0092DCA0-0x0092DEF0
	private void StopWalkKemuri_() {} // 0x0092CBD0-0x0092CC20
	public void OnContactCharaFollow(ActObjCharactor contanctCh) {} // 0x0092DEF0-0x0092DF00
	private void UpdatePlayerController_Follow_() {} // 0x0092B590-0x0092CBD0
	private Vector2 CalcMoveFollowPath_(bool isRun, float speedRatio) => default; // 0x0092E790-0x0092F680
	private bool FindWarpPos_(Vector2 tgtPos2d, out Vector2 findPos2d) {
		findPos2d = default;
		return default;
	} // 0x0092E200-0x0092E790
	// [Conditional] // 0x00618BD0-0x00618C10
	public static void CollDrawLine_(Vector3 start, Vector3 end, Color color, float duration) {} // 0x0092F6A0-0x0092F6B0
	// [Conditional] // 0x00618C10-0x00618C50
	public static void CollDrawLine_(Vector3 start, Vector3 end, Color color) {} // 0x0092F6B0-0x0092F6C0
	// [Conditional] // 0x00618C50-0x00618C90
	public static void CollDrawCircle_(Vector3 center, float radius, Color color, float duration) {} // 0x0092F6C0-0x0092F6D0
	private static bool CollMapRayCheck_(Vector3 pos3d, float charaRadius, Vector2 to2dV) => default; // 0x0092F6D0-0x0092F810
	private static bool CollMapGroundOnlyCheck_(Vector3 pos3d, Vector2 to2dV) => default; // 0x0092F810-0x0092FF70
	private static bool CollWallRayHit_(Vector3 pos3d, float charaRadius, Vector2 check2dV, out RaycastHit info) {
		info = default;
		return default;
	} // 0x0092FF70-0x009301B0
	public bool CheckFollowThroughWalk(Vector2 pos2d, Vector2 check2dV, float charaRadius, bool bWithCharaCheck = true /* Metadata: 0x006107FC */) => default; // 0x0092DF70-0x0092E200
	public static Vector2 CalcCollNururiMove_(Vector2 pos2d, float charaRadius, Vector2 move2dV, ActObjCharactor actCh) => default; // 0x0092D4C0-0x0092DCA0
	private static bool CircleRectHit(Vector2 circleP, float radius, Vector2 boxP, float boxSize) => default; // 0x009301B0-0x009302D0
	private bool OverlapCheck_(Vector3 pos3d, float charaRadius) => default; // 0x009302D0-0x00930400
	public bool CollMap_CanWalkRayCheck(Vector3 startPos, Vector2 to2dV) => default; // 0x00930400-0x009304B0
	public void CollisionNururiMove(Vector2 startPos2d, Vector2 move2dV) {} // 0x009304B0-0x009305D0
	public void ForceApplyGroundFit() {} // 0x009305D0-0x00930680
	// [IteratorStateMachine] // 0x00618C90-0x00618D00
	public IEnumerator StopLastWalk(float time, Vector2 moveToDir, float maxSpeed, Action endCb, float charaRadiusLimit, Action loopCb) => default; // 0x00930680-0x00930740
}

