/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CharacterConst;
using Const;
using Const.creature;
using Const.pokemon;
using FukidashiConst;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CharacterModel : NormalModel // TypeDefIndex: 5955
{
	// Fields
	private const float MANPU_SHOW_TIME = 2f; // Metadata: 0x006122C3
	public const float DEFAULT_BLEND_TIME = 0.25f; // Metadata: 0x006122C7
	private const float BIG_MONSTER_SHADOW_SIZE = 3f; // Metadata: 0x006122CB
	private const float EYE_OPEN_SHOW_TIME = 1f; // Metadata: 0x006122CF
	private const float EYE_OPEN_SHOW_RANGE = 3f; // Metadata: 0x006122D3
	private const float EYE_CLOSE_SHOW_TIME = 0.15f; // Metadata: 0x006122D7
	private static Dictionary<uint, string> s_dicRegidentBone; // 0x00
	public static uint BONE_PG_ROOT_HASH; // 0x08
	public static uint BONE_PG_NECK_HASH; // 0x0C
	public static uint BONE_PT_HEAD_HASH; // 0x10
	public static uint BONE_MOUTH_HASH; // 0x14
	public static uint BONE_CENTER_HASH; // 0x18
	public static uint BONE_PT_R_HAND_HASH; // 0x1C
	public static uint BONE_PT_L_HAND_HASH; // 0x20
	public static uint BONE_PT_SCARF_HASH; // 0x24
	private Index creatureIndex_; // 0x204
	private FormType formType_; // 0x208
	private bool m_bForceMaterialChangeMode; // 0x20C
	protected Dictionary<int, Material> m_dicBaseShaderMaterial; // 0x210
	protected Dictionary<int, ShaderData> m_dicBaseShader; // 0x218
	protected Dictionary<int, Material> m_dicBlendShaderMaterial; // 0x220
	protected Dictionary<int, ShaderData> m_dicBlendShader; // 0x228
	protected Dictionary<int, Material> m_dicEffectBaseSetBaseShaderMaterial; // 0x230
	protected Dictionary<int, ShaderData> m_dicEffectBaseSetBaseShader; // 0x238
	private NeckController m_neckCtrl; // 0x240
	private GraphicsSystem.CharacterDatabaseParameter baseParameter_; // 0x248
	protected GameObject flyOffsetObject_; // 0x250
	private Dictionary<uint, ManpuModel> dicManpu_; // 0x258
	private Dictionary<uint, GimmickModel> dicGimmick_; // 0x260
	private EquipModel[] aEquip_; // 0x268
	private ManpuModel currentManpu_; // 0x270
	private Fukidashi fukidashi_; // 0x278
	private UnityEngine.Texture variationTexture_; // 0x280
	private EyeType eEyeType_; // 0x288
	private MouthType eMouthType_; // 0x28C
	private EyeType eEyeType_Base_; // 0x290
	private MouthType eMouthType_Base_; // 0x294
	private float fManpuShowTime_; // 0x298
	private bool bMonster_; // 0x29C
	private float fDistanceCullingDistance_; // 0x2A0
	private bool bDistanceCulling_; // 0x2A4
	private bool bManpuVisibleDirtyFlag_; // 0x2A5
	private bool bManpuVisibleFlag_; // 0x2A6
	private bool bScarfVisibleDirtyFlag_; // 0x2A7
	private bool bScarfVisibleFlag_; // 0x2A8
	private float fBaseScale_; // 0x2AC
	private float fEyeChangeTick_; // 0x2B0
	private float fEyeOpenTickLength_; // 0x2B4
	private float fEyeCloseTickLength_; // 0x2B8
	private float fNativeBaseSpeed_; // 0x2BC
	private float fNativeBaseSpeedRate_; // 0x2C0
	private bool bNativeSpeedUpdate_; // 0x2C4
	private bool bEyeOpen_; // 0x2C5
	private bool bEyeBlink_; // 0x2C6
	private bool bEyeBlinkForceOff_; // 0x2C7
	private bool bCutProductionOffset_; // 0x2C8
	private int nEquipCount_; // 0x2CC
	private float cutinFinishDelay; // 0x2D0
	private bool cutinAutoDelete; // 0x2D4
	private Vector3 vHeadOffset_; // 0x2D8
	private Vector3 vMouthOffset_; // 0x2E4
	private Vector3 vRightOffset_; // 0x2F0
	private Vector3 vLeftOffset_; // 0x2FC
	private Vector3 m_vCutsceneOffset; // 0x308
	private Vector3 m_vCharactorAddOffset; // 0x314
	private Vector3 m_vSpotJudgePosition; // 0x320
	private GameObject bonePGRoot_; // 0x330
	private GameObject bonePGNeck_; // 0x338
	private GameObject bonePGHead_; // 0x340
	private GameObject manpuRoot_; // 0x348
	private List<GameObject> m_aTurnMarkerKind; // 0x350
	private GameObject m_refTurnMarkerStatus; // 0x358
	private GameObject m_meshNode_; // 0x360
	private CharacterGhost m_ghost; // 0x368
	private CharacterBlendFill m_blendFill; // 0x370
	private Dictionary<uint, GameObject> dicRefBone_; // 0x378
	private string commonMotionBundleName_; // 0x380
	private string commonMotionBundleName2_; // 0x388
	private string skillMotionBundleName_; // 0x390
	private BuildMode eBuildMode_; // 0x398
	private bool bTurnMarkerForceOff_; // 0x39C
	private bool bEquipVisibleOff_; // 0x39D
	private bool bEquipCutVisibleOff_; // 0x39E
	private bool bDirtyEquipVisible_; // 0x39F
	private bool bRequestNativeCalcBone_; // 0x3A0
	private const int RANDOM_MOTION_RATE_WIDTH = 20; // Metadata: 0x006122DB
	private const float RANDOM_MOTION_RATE_BASE = 0.9f; // Metadata: 0x006122DF
	private float fBlockFramePerSec_; // 0x3A4
	private bool bBaisokuStatus_; // 0x3A8
	private bool bDonsokuStatus_; // 0x3A9
	private bool bWalkNormal_; // 0x3AA
	private bool bIsExecuteNormal_; // 0x3AB
	private bool bFrigonEye_; // 0x3AC
	private Dictionary<uint, Material> m_dicBackupForceChangeMateial; // 0x3B0
	private Dictionary<Renderer, uint[]> m_dicBackupForceChangeRenderMaterial; // 0x3B8
	private List<Material> m_listBackupForceChangeMateialFromIID; // 0x3C0
	private bool bTimelineGraphUpdate_; // 0x3C8

	// Properties
	public Index CreatureIndex { get => default; } // 0x009B4030-0x009B4040 
	public Vector3 HeadOffset { get => default; } // 0x009B4040-0x009B4050 
	public Vector3 MouthOffset { get => default; } // 0x009B4050-0x009B4060 
	public GraphicsSystem.CharacterDatabaseParameter BaseParameter { get => default; } // 0x009B1B40-0x009B1B50 
	public uint GfxSymbol { get => default; } // 0x009B4080-0x009B4090 
	public float CircleShadowW { get => default; } // 0x009B4090-0x009B40A0 
	public float CircleShadowH { get => default; } // 0x009B40A0-0x009B40B0 
	public string FaceName { get => default; } // 0x009B40B0-0x009B40C0 
	public float Ground_WalkCorrectionValue { get => default; } // 0x009B40C0-0x009B40D0 
	public float Ground_RunCorrectionValue { get => default; } // 0x009B40D0-0x009B40E0 
	public bool Big { get => default; } // 0x009B40E0-0x009B40F0 
	public GraphicsBodySizeType BodySize { get => default; } // 0x009B40F0-0x009B4100 
	public GameObject MeshNode { get => default; } // 0x009B4100-0x009B4110 
	public GameObject PgRootNode { get => default; } // 0x009B4110-0x009B4120 
	public bool IsNeckNowRotating { get => default; } // 0x009BF700-0x009BF770 

	// Nested types
	private class AnimationCallback : IAnimationCallback // TypeDefIndex: 5956
	{
		// Fields
		private CharacterModel ownerChara_; // 0x10

		// Constructors
		public AnimationCallback() {} // Dummy constructor
		public AnimationCallback(CharacterModel chara) {} // 0x009B7C20-0x009B7C50

		// Methods
		public virtual void PlayParts_Pre(string parts, string key, float fStartBlendSec, float fSpeed, bool bLoop) {} // 0x009C1BA0-0x009C1E60
		public virtual void PlayPartsEnd_Pre(string parts, string key) {} // 0x009C1E60-0x009C1EC0
		public virtual void ChangeCurrentSpeed(string parts, string key, float fSpeed) {} // 0x009C1EC0-0x009C1FD0
		public virtual void ChangeCurrentLoop(string parts, string key, bool bLoop) {} // 0x009C1FD0-0x009C20E0
		public virtual void UpdateParts_Pre(string parts, string key) {} // 0x009C20E0-0x009C20F0
	}

	public class NeckController // TypeDefIndex: 5957
	{
		// Fields
		public Quaternion neckBindWorldQt; // 0x10
		public Quaternion neckInvBindWorldQt; // 0x20
		public Vector3 neckBindPosition; // 0x30
		public Vector3 neckBindScale; // 0x3C
		public Quaternion neckBindQt; // 0x48
		public bool neckExist; // 0x58
		public bool neckFlg; // 0x59
		public bool neckResetFlg; // 0x5A
		public bool neckResetSRT; // 0x5B
		public bool neckAbsFlg; // 0x5C
		public Quaternion neckEndQt; // 0x60
		public bool neckLastQtInit; // 0x70
		public Quaternion neckLastAbsQt; // 0x74
		public Quaternion neckLastRelQt; // 0x84
		public bool neckStartQtInit; // 0x94
		public Quaternion neckStartQt; // 0x98
		public MoveFloatVer2 neckAnimTimeT; // 0xA8
		public Vector3 neckLastWorldTranslate; // 0xB0
		public Quaternion neckLastWorldRotate; // 0xBC
		public Vector3 neckLastWorldScale; // 0xCC

		// Constructors
		public NeckController() {} // 0x009B7B00-0x009B7C20

		// Methods
		public void Initalize() {} // 0x009C20F0-0x009C2150
	}

	public enum EquipPoint // TypeDefIndex: 5958
	{
		RIGHT_HAND = 0,
		LEFT_HAND = 1,
		RIGHT_ARM = 2,
		LEFT_ARM = 3,
		MAX = 4
	}

	public enum BuildMode // TypeDefIndex: 5959
	{
		DUNGEON = 0,
		DEFAULT = 0,
		GROUND = 1,
		RENDER_TEXTURE = 2,
		RENDER_TEXTURE2 = 3,
		MAX = 4
	}

	public enum TurnMarker // TypeDefIndex: 5960
	{
		PREP = 0,
		ACTION = 1,
		DOUBLE = 2,
		MAX = 3,
		NULL = 3
	}

	private class ShaderSwitchParameter // TypeDefIndex: 5961
	{
		// Fields
		public Shader[] aShader; // 0x10

		// Constructors
		public ShaderSwitchParameter() {} // 0x009B8810-0x009B8870
	}

	private enum SpeedSettingType // TypeDefIndex: 5962
	{
		NONE = 0,
		RUN = 1,
		WALK = 2,
		WAIT = 3
	}

	// Constructors
	public CharacterModel() {} // Dummy constructor
	private CharacterModel(int nativeControlId, GraphicsSystem.CharacterDatabaseParameter baseParameter, BuildMode buildMode, bool bGhostCreate) {} // 0x009B5310-0x009B7A50
	static CharacterModel() {} // 0x009C0DA0-0x009C0E60

	// Methods
	public EyeType GetEyeType() => default; // 0x009B4060-0x009B4070
	public MouthType GetMouthType() => default; // 0x009B4070-0x009B4080
	public static void RequestLoadResource(uint gfxSymbol, Action loadedCb = null) {} // 0x009B4120-0x009B42D0
	public static bool IsLoadedResource(uint gfxSymbol) => default; // 0x009B42E0-0x009B4460
	// [IteratorStateMachine] // 0x006239E0-0x00623A50
	public static IEnumerator LoadResidentMotion() => default; // 0x009B4460-0x009B44C0
	public static void Startup() {} // 0x009B44F0-0x009B4DF0
	public static Dictionary<uint, List<Vector2>> GetScreenPositionList() => default; // 0x009B4DF0-0x009B5200
	public static CharacterModel CreateFromNative(int nativeControlId, uint gfxSymbol, MarkerType eMarkerType, BuildMode buildMode, bool bForceGhostCreate = false /* Metadata: 0x006122A1 */) => default; // 0x009B5200-0x009B5310
	public static CharacterModel CreateFromNative(int nativeControlId, Index creatureIndex, FormType formType, uint gfxSymbol, MarkerType eMarkerType, BuildMode buildMode) => default; // 0x009B7A50-0x009B7B00
	private void InitializeNeck() {} // 0x009B7C50-0x009B7E70
	private Dictionary<int, ShaderSwitchParameter> GetFirstSetupCharacterNormalShader(bool bMonster, BuildMode buildMode) => default; // 0x009B8100-0x009B8810
	private void SetupTurnMarker() {} // 0x009B7FE0-0x009B8100
	private void AddTurnMarker(string prefabName) {} // 0x009B8870-0x009B8950
	private void ChangeTurnMarker(TurnMarker maker, bool bParty) {} // 0x009B8950-0x009B8AB0
	public void SetTurnMarkerFromNativeState(int state, bool bParty) {} // 0x009B8AB0-0x009B8BA0
	public override void SetCutProduction(bool bCutEnable) {} // 0x009B8BA0-0x009B8C10
	public void SetCutProductionOffset(bool bSet) {} // 0x009B8C10-0x009B8E10
	public void SetCharactorAddOffset(Vector3 offset) {} // 0x009B8EE0-0x009B8EF0
	protected override void OnTerminate() {} // 0x009B8EF0-0x009B92F0
	private void LoadCutIn() {} // 0x009B7FD0-0x009B7FE0
	private void DestroyCutIn() {} // 0x009B9560-0x009B9570
	// [IteratorStateMachine] // 0x00623A50-0x00623AC0
	private IEnumerator PlayingCutin() => default; // 0x009B9570-0x009B95D0
	public void PlayCutin(string srcUpperText, string srcUnderText, bool autoDelete) {} // 0x009B9600-0x009B9610
	public void RemoveCutin() {} // 0x009B9610-0x009B9620
	public void SetGhostGroundFadeRate(float fRate) {} // 0x009B9620-0x009B96E0
	public float GetGhostGroundFadeRate() => default; // 0x009B96E0-0x009B9780
	public bool IsPlayCutin() => default; // 0x009B9780-0x009B9790
	public override void OnMaterialShaderChange(GraphicsSystem.LayerId layerId) {} // 0x009B9790-0x009BA1C0
	public void ForceChangeMaterial(string namePrefix) {} // 0x009BA1C0-0x009BAA10
	public void ResetForceChangeMaterial() {} // 0x009BAA10-0x009BAFB0
	protected override bool IsCharacterModel() => default; // 0x009BAFB0-0x009BAFC0
	public bool IsEquipMotion(string partsSymbol, string stMotionKey) => default; // 0x009BAFC0-0x009BB1B0
	protected override void OnUpdateShaderMaterialVisibleColor(Color color) {} // 0x009BB1B0-0x009BB500
	public override void SetAllMultMaterialColorRate(bool bEnable) {} // 0x009BB500-0x009BB7E0
	public void SetNullPointOffstHead(float x, float y, float z) {} // 0x009B7E70-0x009B7EE0
	public void SetNullPointOffstMouth(float x, float y, float z) {} // 0x009B7EE0-0x009B7F30
	public void SetNullPointOffstRightHand(float x, float y, float z) {} // 0x009B7F30-0x009B7F80
	public Vector3 GetNullPointOffstRightHand() => default; // 0x009BB7E0-0x009BB7F0
	public void SetNullPointOffstLeftHand(float x, float y, float z) {} // 0x009B7F80-0x009B7FD0
	public Vector3 GetNullPointOffstLeftHand() => default; // 0x009BB7F0-0x009BB800
	public void AddGimmick(uint gimmickGfxSymbol) {} // 0x009BB800-0x009BB900
	public void SetVisibleGimmick(uint gimmickGfxSymbol, bool bVisible) {} // 0x009BB910-0x009BB9B0
	public void DestroyGimmick(uint gimmickGfxSymbol) {} // 0x009BB9B0-0x009BBAA0
	public void AllDestroyGimmick() {} // 0x009BBAA0-0x009BBC10
	public void AddManpu(uint gfxSymbol) {} // 0x009BBC10-0x009BBCF0
	private ManpuModel NextManpu(ManpuModel manpu) => default; // 0x009BBCF0-0x009BBEE0
	private void UpdateNextManpuCore() {} // 0x009BBEE0-0x009BBF50
	public void RemoveManpu(uint gfxSymbol) {} // 0x009BBF50-0x009BC090
	public void AllRemoveManpu() {} // 0x009B9350-0x009B9560
	private EquipPoint ConvertEquipPoint(uint gfxSymbol) => default; // 0x009BC220-0x009BC350
	public void ClearEquip(uint gfxSymbol, bool bMotionUpdate) {} // 0x009BC350-0x009BC380
	public void ClearEquip(EquipPoint point, bool bMotionUpdate) {} // 0x009BC380-0x009BC4F0
	public void AllClearEquip(bool bMotionUpdate) {} // 0x009B92F0-0x009B9350
	public void SetEquip(uint gfxSymbol) {} // 0x009BC4F0-0x009BC730
	public string ConvertEquipMotionKey(string parts, string key) => default; // 0x009BC9C0-0x009BC9D0
	public override void SetCurrentAnimation(string parts, string key, bool bLoop, float fBlendSec) {} // 0x009BC9D0-0x009BCA30
	public override void SetNextAnimation(string parts, string key, bool bLoop, float fBlendSec) {} // 0x009BCA30-0x009BCB70
	public override void ChangeSpeedAnimation(string parts, float fSpeed) {} // 0x009BCB70-0x009BCB80
	public override Vector3 GetSpotCalcPosition() => default; // 0x009BCB80-0x009BCB90
	public void SetSpotJudgePosition(Vector3 position) {} // 0x009BCB90-0x009BCBA0
	public Vector3 GetWorldHeadPosition(bool bAndRandom = false /* Metadata: 0x006122A2 */) => default; // 0x009BCBA0-0x009BCD30
	public bool AttachModel(string boneSymbol, ModelBase model) => default; // 0x009BC730-0x009BC9C0
	public bool DetachModel(ModelBase model) => default; // 0x009BC090-0x009BC220
	public EquipModel GetBoneEquipModel(string boneSymbol) => default; // 0x009BCD30-0x009BCDA0
	public EquipModel GetBoneEquipModel(uint boneSymbolHash) => default; // 0x009BCDA0-0x009BCDB0
	public Transform GetBoneTransform(string boneSymbol) => default; // 0x009BCDB0-0x009BCE30
	public Transform GetBoneTransform(uint boneSymbolHash) => default; // 0x009B8E10-0x009B8EE0
	public Transform GetBoneTransformFromHash(uint hash) => default; // 0x009BCE30-0x009BCF20
	public Vector3 GetBonePosition(string boneName) => default; // 0x009BCF20-0x009BCFA0
	public Vector3 GetBonePosition(uint boneSymbolHash) => default; // 0x009BCFA0-0x009BD070
	public void ToNativeCalcBonePosition(DataExchangeByteMemoryStream stream) {} // 0x009BD070-0x009BD2F0
	public override void UpdateShadowPosition() {} // 0x009BD2F0-0x009BD3D0
	public override void OnUpdateGlobalShadowColor(Color color) {} // 0x009BD3D0-0x009BD540
	protected override void OnUpdateMarkerVisible(bool bVisible) {} // 0x009BD540-0x009BD630
	protected void ChangeEyeBase(EyeType eye) {} // 0x009BD630-0x009BD650
	protected void ChangeMouthBase(MouthType mouth) {} // 0x009BD770-0x009BD790
	public void ChangeEye(EyeType eye) {} // 0x009BD8B0-0x009BD8D0
	public void ChangeMouth(MouthType mouth) {} // 0x009BD8D0-0x009BD8E0
	protected void ApplyEye_() {} // 0x009BD650-0x009BD770
	protected void ApplyMouth_() {} // 0x009BD790-0x009BD8B0
	protected override void UpdateOffsetPosition() {} // 0x009BD8E0-0x009BDA30
	public bool IsEquipVisible() => default; // 0x009BDA30-0x009BDA50
	public void SetEquipVisibleOff(bool bVisible) {} // 0x009BDA50-0x009BDA70
	public bool IsEquipVisibleOffFlag() => default; // 0x009BDA70-0x009BDA80
	public void SetEquipCutVisibleOff(bool bVisible) {} // 0x009BDA80-0x009BDAA0
	protected override void OnUpdateShaderMaterialConditionColor(Color color) {} // 0x009BDAA0-0x009BDC30
	protected override void OnUpdateMaterialAddColor(Color color) {} // 0x009BDC30-0x009BDF70
	public void SetManpuVisible(bool bVisible) {} // 0x009BDF70-0x009BDFA0
	protected override void UpdateVisible() {} // 0x009BDFA0-0x009BE270
	public override void ForcePlayAll() {} // 0x009BE270-0x009BE2C0
	public override void ReturnRootActiveForceAnimationPlay() {} // 0x009BE2C0-0x009BE2D0
	public float CalcWalkRunMotionSpeed(float speedPerSec, bool isRun) => default; // 0x009BE2D0-0x009BE320
	public static Quaternion ExtractRotationFromMatrix(ref Matrix4x4 matrix) => default; // 0x009BE320-0x009BE3D0
	private Matrix4x4 ConvertRotMatrix(ref Matrix4x4 mat) => default; // 0x009BE3D0-0x009BE640
	public static Quaternion QuaternionNormalize(ref Quaternion q) => default; // 0x009BE640-0x009BE770
	public void SetNeckRot_LookAt(Vector3 lookAtTarget, Vector3 upAxis, float endSec, float at = 0f /* Metadata: 0x006122A3 */, float dt = 0f /* Metadata: 0x006122A7 */) {} // 0x009BE770-0x009BEC80
	public void SetNeckRot_LookAt(Vector2 lookAtTarget, float rad_pitch, Vector3 upAxis, float endSec, float atSec = 0f /* Metadata: 0x006122AB */, float dtSec = 0f /* Metadata: 0x006122AF */) {} // 0x009BED20-0x009BF230
	public void SetNeckRot_AxisDeg(float deg_dir, float deg_pitch, float deg_roll, float endSec, float atSec = 0f /* Metadata: 0x006122B3 */, float dtSec = 0f /* Metadata: 0x006122B7 */) {} // 0x009BF230-0x009BF500
	private void SetNeckInterpolation_(float endSec, float atSec, float dtSec) {} // 0x009BEC80-0x009BED20
	// [IteratorStateMachine] // 0x00623AC0-0x00623B30
	public IEnumerator WaitNeckInterpolation() => default; // 0x009BF500-0x009BF570
	public void ResetNeck(float endSec, float atSec = 0f /* Metadata: 0x006122BB */, float dtSec = 0f /* Metadata: 0x006122BF */) {} // 0x009BF5A0-0x009BF700
	private void _StepWkNeck() {} // 0x009BF770-0x009BF910
	private bool _Callback_CalcNeckMatrix() => default; // 0x009BF910-0x009BFE60
	public void SetRequestNativeCalcBone() {} // 0x009BFE60-0x009BFE70
	public void SetBlockFramePerSec(float fBlockFramePerSec) {} // 0x009BFE70-0x009BFE80
	public void SetBaisoku(bool bEnable) {} // 0x009BFE80-0x009BFE90
	public void SetDonsoku(bool bEnable) {} // 0x009BFE90-0x009BFEA0
	public void SetWalkNormal(bool bEnable) {} // 0x009BFEA0-0x009BFEB0
	public void SetExecuteWalk(bool bEnable) {} // 0x009BFEB0-0x009BFEC0
	public void CallbackUpdateMotionChange(string parts, string key) {} // 0x009BFEC0-0x009C01E0
	private void UpdateChangeSpeedForNative() {} // 0x009C0200-0x009C0280
	public override void Update() {} // 0x009C0280-0x009C05A0
	public void ChangeSpeedAnimationRateForNative(string parts, float fSpeedRate) {} // 0x009C01E0-0x009C0200
	public void ChangeSpeedAnimationForNative(string parts, float fSpeed) {} // 0x009C05A0-0x009C05C0
	public void OnUpdateFromTimelineGraph() {} // 0x009C05C0-0x009C05D0
	public override void LastUpdate() {} // 0x009C05D0-0x009C0BC0
	public void SetScarfVisible(bool bVisible) {} // 0x009C0BC0-0x009C0BF0
	public void AppearFukidashi(FukidashiConst.Type type, ref string text, float fOverwriteVisibleTimer) {} // 0x009C0BF0-0x009C0D80
	public void ClearFukidashi(FukidashiConst.Type type) {} // 0x009C0D80-0x009C0DA0
}

