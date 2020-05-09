/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.pokemon;
using effect;
using gimmick;
using graphics;
using graphics.camera;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GraphicsSystem : Singleton<GraphicsSystem> // TypeDefIndex: 6009
{
	// Fields
	private static Vector2[] s_aFrameBuffer3dResolutionSize; // 0x00
	private FrameBuffer3dResolutionType eFrameBuffer3dResolutionType_; // 0x10
	public bool bValidResolutionChangeMode_; // 0x14
	private List<IGraphicsUpdater> aGraphicsUpdater_; // 0x18
	private bool bRequestCommandBufferUpdate_; // 0x20
	private const uint CRC32_MASK = 4294967295; // Metadata: 0x00612397
	private static byte[] aExchangeShareBuffer_; // 0x08
	private static byte[] aTempUpdateGLBuffer_; // 0x10
	private static readonly uint[] s_aCRC32Table; // 0x18
	private static Dictionary<uint, Dictionary<CharacterShaderStatus, string>> dicCharacterShaderStatus_; // 0x20
	private DataExchangeByteMemoryStream temporaryByteStream; // 0x28
	private static Dictionary<string, Material> loadMaterialTbl_; // 0x28
	private static Dictionary<string, Shader> loadShadersTbl_; // 0x30
	private static List<byte> tmpCrcBuff_; // 0x38
	private Material fill2dShaderMaterial_; // 0x30
	private Material texture2dShaderMaterial_; // 0x38
	private Material debugFontShaderMaterial_; // 0x40

	// Properties
	public FrameBuffer3dResolutionType Resolution3dType { get => default; } // 0x0072C300-0x0072C340 
	public bool ValidResolutionChangeMode { get => default; set {} } // 0x00729B90-0x00729BA0 0x0072C340-0x0072C350
	public static byte[] DataExchangeShareBuffer { get => default; } // 0x0072C350-0x0072C3C0 
	public static byte[] DataExchangeTempBuffer { get => default; } // 0x0072C3C0-0x0072C430 
	public static Dictionary<uint, Dictionary<CharacterShaderStatus, string>> DicCharacterShaderStatus { get => default; } // 0x0072C430-0x0072C4A0 
	public Vector2 CurrentFrameBuffer3dResolutionSize { get => default; } // 0x00729BA0-0x00729DC0 

	// Nested types
	public enum FrameBuffer3dResolutionType // TypeDefIndex: 6010
	{
		LOW = 0,
		NORMAL = 1,
		HIGH = 2,
		MAX = 3
	}

	public enum DatabaseGetFileType // TypeDefIndex: 6011
	{
		DRAMA_CHARACTER = 0,
		DRAMA_CHARACTER_EYE = 1,
		DRAMA_CHARACTER_FACE = 2,
		CHARACTER_ONPICTURE = 3,
		CHARACTER_TRUN = 4,
		CHARACTER_BASE_FILE = 5,
		CHARACTER_MOTION_BASE_FILE = 6,
		CHARACTER_SKILL_MOTION_BASE_FILE = 7,
		EFFECT_2D = 8,
		MANPU = 9,
		GIMMICK = 10,
		MAP_WATER = 11,
		MAP_BOTTOM = 12,
		ITEM_2D_LIST_ICON = 16,
		ITEM_2D_ONE_PICTURE = 17
	}

	public enum LayerId // TypeDefIndex: 6012
	{
		DEFAULT = 0,
		BLEND_MESH = 9,
		BACK_LOG = 10,
		GHOST_BLEND_MESH = 14,
		RENDER_TARGET_MESH = 15,
		RENDER_TARGET_MESH2 = 16,
		RENDER_TARGET_ADD_EFFECT = 17
	}

	public enum CharacterShaderStatus // TypeDefIndex: 6013
	{
		DEFAULT = 0,
		BLEND = 1,
		GHOST = 2,
		RENDER_TEXTURE = 3,
		MAX = 4
	}

	public class CharacterDatabaseParameter // TypeDefIndex: 6014
	{
		// Fields
		public string stFileName; // 0x10
		public string stCommonMotionName; // 0x18
		public string stCommonMotionName2; // 0x20
		public string stTextureName; // 0x28
		public string stCutPictureName; // 0x30
		public string stCutInName; // 0x38
		public string stFaceName; // 0x40
		public string stDotName; // 0x48
		public string stDotRightName; // 0x50
		public uint gfxSymbol; // 0x58
		public int sheetId; // 0x5C
		public EvolutionCameraType evolutionCameraType; // 0x60
		public GraphicsBodySizeType bodySize; // 0x64
		public float fBaseScale; // 0x68
		public float fDungeonBaseScale; // 0x6C
		public float fPGRootBoneScale; // 0x70
		public float fDotOffsetX; // 0x74
		public float fDotOffsetY; // 0x78
		public float fMotionScale; // 0x7C
		public float fWalkSpeedDist; // 0x80
		public float fWalkSpeedDistG; // 0x84
		public float fRunSpeedRatioG; // 0x88
		public float fWalkCorrectionValueG; // 0x8C
		public float fRunCorrectionValueG; // 0x90
		public float fFlyHeight; // 0x94
		public float fShadowW; // 0x98
		public float fShadowH; // 0x9C
		public float fNullHeadOffsetX; // 0xA0
		public float fNullHeadOffsetY; // 0xA4
		public float fNullHeadOffsetZ; // 0xA8
		public float fNullMouthOffsetX; // 0xAC
		public float fNullMouthOffsetY; // 0xB0
		public float fNullMouthOffsetZ; // 0xB4
		public float fNullRightHandOffsetX; // 0xB8
		public float fNullRightHandOffsetY; // 0xBC
		public float fNullRightHandOffsetZ; // 0xC0
		public float fNullLeftHandOffsetX; // 0xC4
		public float fNullLeftHandOffsetY; // 0xC8
		public float fNullLeftHandOffsetZ; // 0xCC
		public float fBDMinX; // 0xD0
		public float fBDMinY; // 0xD4
		public float fBDMinZ; // 0xD8
		public float fBDMaxX; // 0xDC
		public float fBDMaxY; // 0xE0
		public float fBDMaxZ; // 0xE4
		public bool bEnablePGRootBoneScaleDedicatedMotion; // 0xE8
		public bool bFace_HANTEN; // 0xE9
		public bool bFace_FEMALE; // 0xEA
		public bool bBig; // 0xEB
		public bool bEffectBaseSet_CH_OffsetPokemon; // 0xEC
		public List<string> animationPartsList; // 0xF0

		// Constructors
		public CharacterDatabaseParameter() {} // 0x0072F1C0-0x0072F230
	}

	public class CharacterShaderStatusParameter // TypeDefIndex: 6015
	{
		// Fields
		public string stBaseShader; // 0x10
		public string stBlendShader; // 0x18
		public string stGhostShader; // 0x20
		public string stRenderTextureShader; // 0x28

		// Constructors
		public CharacterShaderStatusParameter() {} // 0x0072CE40-0x0072CE50
	}

	public class MapDatabaseParameter // TypeDefIndex: 6016
	{
		// Fields
		public string mapSymbol; // 0x10
		public uint mapGfxSymbol; // 0x18
		public string stFileName; // 0x20
		public uint allEffectHashGfxSymbol; // 0x28
		public uint warterHashGfxSymbol; // 0x2C
		public float fWaterHeight; // 0x30
		public float fWaterColorR; // 0x34
		public float fWaterColorG; // 0x38
		public float fWaterColorB; // 0x3C
		public float fWaterColorA; // 0x40
		public uint eyeAttachHash; // 0x44
		public uint bottomHashGfxSymbol; // 0x48
		public float fBottomHeight; // 0x4C
		public float fShadowColorR; // 0x50
		public float fShadowColorG; // 0x54
		public float fShadowColorB; // 0x58
		public float fHeightScale; // 0x5C
		public string stAddFilter; // 0x60
		public string stAddFilterNear; // 0x68
		public string stMulFilter; // 0x70
		public string stMulFilterNear; // 0x78
		public string stBlinkAnimation; // 0x80
		public float fLightDirectionDegreeX; // 0x88
		public float fLightDirectionDegreeY; // 0x8C
		public float fLightDirectionDegreeZ; // 0x90
		public float fLightColorR; // 0x94
		public float fLightColorG; // 0x98
		public float fLightColorB; // 0x9C
		public float fOuterColorR; // 0xA0
		public float fOuterColorG; // 0xA4
		public float fOuterColorB; // 0xA8
		public float fOuterColorA; // 0xAC
		public List<string> animationPartsList; // 0xB0

		// Constructors
		public MapDatabaseParameter() {} // 0x0072D410-0x0072D480
	}

	public class GimmickDatabaseParameter // TypeDefIndex: 6017
	{
		// Fields
		public uint gfxSymbol; // 0x10
		public string stFileName; // 0x18
		public string stDefaultMotionKey; // 0x20
		public BillboardType eBillboardType; // 0x28
		public float fOffsetX; // 0x2C
		public float fOffsetY; // 0x30
		public float fOffsetZ; // 0x34
		public PlacementType eAttachType; // 0x38
		public bool bBillboard; // 0x3C

		// Constructors
		public GimmickDatabaseParameter() {} // 0x0072D650-0x0072D660
	}

	public class EffectDatabaseParameter // TypeDefIndex: 6018
	{
		// Fields
		public string stFileName; // 0x10
		public string stSymbol; // 0x18
		public int sheetId; // 0x20
		public List<SeData> aSe; // 0x28
		public List<ScriptData> aScript; // 0x30
		public PlacementType ePlacementType; // 0x38
		public float fBlock3OffsetX; // 0x3C
		public float fBlock3OffsetY; // 0x40
		public float fBlock3OffsetZ; // 0x44
		public float fBlock3Mag; // 0x48
		public float fRetireTime; // 0x4C
		public bool bBodyAttach; // 0x50
		public bool bBodyAttachContinueRotate; // 0x51
		public bool bBodyAttachContinueScale; // 0x52
		public bool bLoop; // 0x53
		public bool bStripe; // 0x54

		// Nested types
		public class SeData // TypeDefIndex: 6019
		{
			// Fields
			public string stSymbol; // 0x10
			public float fStartSec; // 0x18

			// Constructors
			public SeData() {} // 0x0072DE30-0x0072DE40
		}

		public class ScriptData // TypeDefIndex: 6020
		{
			// Fields
			public string stFunc; // 0x10
			public float fStartSec; // 0x18

			// Constructors
			public ScriptData() {} // 0x0072DE40-0x0072DE50
		}

		// Constructors
		public EffectDatabaseParameter() {} // 0x0072DD90-0x0072DE30

		// Methods
		public bool IsPlacementTypeAttach() => default; // 0x0072F230-0x0072F260
	}

	public class ManpuDatabaseParameter // TypeDefIndex: 6021
	{
		// Fields
		public string stFileName; // 0x10
		public float fOffsetX; // 0x18
		public float fOffsetY; // 0x1C
		public float fOffsetZ; // 0x20
		public bool bBillboard; // 0x24

		// Constructors
		public ManpuDatabaseParameter() {} // 0x0072E1D0-0x0072E1E0
	}

	public class CameraAnimationDatabaseParameter // TypeDefIndex: 6022
	{
		// Fields
		public string stFileName; // 0x10

		// Constructors
		public CameraAnimationDatabaseParameter() {} // 0x0072E7A0-0x0072E7B0
	}

	public class EquipGraphicsDatabaseParameter // TypeDefIndex: 6023
	{
		// Fields
		public uint gfxSymbol; // 0x10
		public string stEquipMotionName; // 0x18
		public string stDataName; // 0x20
		public string stAttachBoneName; // 0x28
		public Vector3 vEffectOffset; // 0x30

		// Constructors
		public EquipGraphicsDatabaseParameter() {} // 0x0072E9B0-0x0072E9C0
	}

	// Constructors
	public GraphicsSystem() {} // 0x0072EDF0-0x0072EF40
	static GraphicsSystem() {} // 0x0072EF40-0x0072F1C0

	// Methods
	public DataExchangeByteMemoryStream GetTemporaryDataExchangeByteMemoryStream() => default; // 0x0072C4A0-0x0072C4B0
	public static void LoadResourcesForBootstrap() {} // 0x00727290-0x00727900
	public static Material FindShaderMaterial(string materialName) => default; // 0x0072A2C0-0x0072A3F0
	public static Shader FindShader(string shaderName) => default; // 0x0072C4B0-0x0072C5E0
	public static uint CalcCrc32(byte[] array) => default; // 0x0072C5E0-0x0072C6E0
	public static uint CalcCrc32(List<byte> array) => default; // 0x0072C6E0-0x0072C7E0
	public static uint CalcCrc32(string str) => default; // 0x0072ABA0-0x0072ACD0
	public static void Startup() {} // 0x00722190-0x00722230
	public void InitializeForGameMain() {} // 0x00725D70-0x00726070
	public string GetFileNameFromNativeDatabase(string graphicsSymbol, DatabaseGetFileType fileType) => default; // 0x0072CB70-0x0072CBE0
	public string GetFileNameFromNativeDatabase(uint graphicHashSymbol, DatabaseGetFileType fileType) => default; // 0x0072CBE0-0x0072CD20
	public uint ConvertCreatureSymbolToGraphicsSymbol(uint creatureHashSymbol) => default; // 0x0072CD20-0x0072CD30
	public static uint CreatureIndexToGfxSymbol(Index index, FormType form) => default; // 0x0072CD30-0x0072CD40
	public static CharacterDatabaseParameter GetCharacterDataFromNativeDatabase(Index index, FormType form) => default; // 0x0072CD40-0x0072CDC0
	public static CharacterDatabaseParameter GetCharacterDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072CDC0-0x0072CDD0
	public CharacterShaderStatusParameter GetCharacterShaderStatusDataFromNativeDatabase(string symbol) => default; // 0x0072CDD0-0x0072CE40
	public List<uint> GetCharacterShaderStatusList() => default; // 0x0072C7E0-0x0072C990
	public CharacterShaderStatusParameter GetCharacterShaderStatusDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072C990-0x0072CB70
	public List<uint> GetCharacterList() => default; // 0x0072CE50-0x0072D000
	public MapDatabaseParameter GetMapDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072D000-0x0072D410
	public List<string> GetMapList() => default; // 0x0072D480-0x0072D650
	public GimmickDatabaseParameter GetGimmickDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072ADF0-0x0072AFF0
	public List<uint> GetDungeonGimmickGfxSymbolListFromNativeDatabase() => default; // 0x0072D660-0x0072D810
	public List<string> GetDungeonGimmickBundleListFromNativeDatabase() => default; // 0x0072D810-0x0072D980
	public EffectDatabaseParameter GetEffectDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072D980-0x0072DD90
	public List<uint> GetEffectList() => default; // 0x0072DE50-0x0072E000
	public ManpuDatabaseParameter GetManpuDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072E000-0x0072E1D0
	public List<uint> GetManpuList() => default; // 0x0072E1E0-0x0072E390
	public CameraParameter GetCameraParameterFromNativeDatabase(string symbol) => default; // 0x0072E390-0x0072E400
	public CameraParameter GetCameraParameterFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072E400-0x0072E610
	public CameraAnimationDatabaseParameter GetCameraAnimationParameterFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072E610-0x0072E7A0
	public EquipGraphicsDatabaseParameter GetEquipGraphicsDataFromNativeDatabase(uint graphicHashSymbol) => default; // 0x0072E7B0-0x0072E9B0
	public List<uint> GetEquipList() => default; // 0x0072E9C0-0x0072EB40
	public void LoadShader2d() {} // 0x00726070-0x00726110
	public Material GetFill2dShader() => default; // 0x0072EB40-0x0072EB50
	public Material GetTexture2dShader() => default; // 0x0072EB50-0x0072EB60
	public Material GetDebugFontShader() => default; // 0x0072EB60-0x0072EB70
	public static float CalcGrayScaleValue(float r, float g, float b) => default; // 0x0072EB70-0x0072EC50
	public void RequestCommandBufferUpdate() {} // 0x0072EC50-0x0072EC60
	public void SetFrameBuffer3dResolutionType(FrameBuffer3dResolutionType eType, bool bForce) {} // 0x0072EC60-0x0072EC80
	public void UpdateFromGameSystem() {} // 0x00723F90-0x007242A0
	public void RegistFrameBuffer3dUpdater(IGraphicsUpdater updater) {} // 0x0072EC80-0x0072ED30
	public void UnregistFrameBuffer3dUpdater(IGraphicsUpdater updater) {} // 0x0072ED90-0x0072EDF0
	public bool IsExistFrameBuffer3dUpdater(IGraphicsUpdater updater) => default; // 0x0072ED30-0x0072ED90
}

