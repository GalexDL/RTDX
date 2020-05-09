/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MapModel : ModelBase // TypeDefIndex: 6042
{
	// Fields
	private const int MAX_WIDTH = 64; // Metadata: 0x006124D3
	private const int MAX_HEIGHT = 64; // Metadata: 0x006124D7
	private const int BOTTOM_SIZE = 8; // Metadata: 0x006124DB
	private const int MAGMA_SIZE_WH = 64; // Metadata: 0x006124DF
	protected GraphicsSystem.MapDatabaseParameter m_baseParameter; // 0x160
	private Texture2D m_gridTextureRef; // 0x168
	protected Texture2D m_effectiveTexture; // 0x170
	private SkyModel m_eyeAttachModel; // 0x178
	private ResourceCache.Resource m_eyeAttachModelResource; // 0x180
	private WaterModel m_waterModel; // 0x188
	private ResourceCache.Resource m_waterModelResource; // 0x190
	private GameObject m_waterMaskPrefab; // 0x198
	private GameObject m_waterMaskParent; // 0x1A0
	protected GameObject m_mapParent; // 0x1A8
	private Dictionary<int, GameObject> m_dicWaterMask; // 0x1B0
	private List<BottomModel> m_aBottomModel; // 0x1B8
	private BMEffect m_allEffect; // 0x1C0
	private ExtraFloorParts m_extraFloorParts; // 0x1C8
	private GameObject m_gridCursor; // 0x1D0
	private Material m_addTextureShaderMaterialNormalCamera; // 0x1D8
	private Material m_addTextureShaderMaterialNearCamera; // 0x1E0
	private Material m_multiplyTextureShaderMaterialNormalCamera; // 0x1E8
	private Material m_multiplyTextureShaderMaterialNearCamera; // 0x1F0
	private Material m_effectiveMaterial; // 0x1F8
	private SpotView.Type m_eSpotType; // 0x200
	private EffectiveMode m_eEffectiveMode; // 0x204
	private BlinkAnimationCurve m_blinkAnimationCurve; // 0x208
	private List<Material> m_aBlinkCurveShaderMaterial; // 0x210
	private float m_fBlinkAnimationTimer; // 0x218
	private MoveFloat m_effectiveLevel; // 0x220
	private float m_effectiveLevelOld; // 0x228
	private MoveFloat m_projectionShadow; // 0x230
	private Vector3 m_gridCursorPosition; // 0x238
	private bool m_bGridTextureUpdate; // 0x244
	private bool m_bEffectiveTextureUpdate; // 0x245
	private bool m_bShowGrid; // 0x246
	private bool m_bShowGridCursor; // 0x247
	private bool m_bGridCursorDirty; // 0x248
	private static readonly Color[] s_aEffectiveMagmaPattern; // 0x00

	// Nested types
	public enum EffectiveMode // TypeDefIndex: 6043
	{
		None = 0,
		Magma = 1,
		Water = 2,
		Wind = 3
	}

	// Constructors
	public MapModel() {} // Dummy constructor
	protected MapModel(int nativeControlId, GraphicsSystem.MapDatabaseParameter baseParameter, bool bFilePrefab) {} // 0x008937C0-0x00894900
	static MapModel() {} // 0x00896730-0x008968E0

	// Methods
	public static void RequestLoadResource(uint gfxSymbol, Action loadedCb = null) {} // 0x00893520-0x00893630
	public static bool IsLoadedResource(uint gfxSymbol) => default; // 0x00893640-0x008936F0
	public static MapModel CreateFromNative(int nativeControlId, uint gfxSymbol) => default; // 0x008936F0-0x008937C0
	private void LoadFilter(string bundle, Material setMaterial, int type) {} // 0x00894C90-0x00894DB0
	private void SetupAllEffect() {} // 0x00894B30-0x00894C90
	private void SetupCameraEyeAttachModel() {} // 0x00894A00-0x00894B30
	private void SetupWater() {} // 0x00894900-0x008949F0
	private void SetupWaterBottom() {} // 0x008949F0-0x00894A00
	public void ClearWaterMask(int blockX, int blockY) {} // 0x00894DC0-0x00894DD0
	public void ApplyWaterMask() {} // 0x00894DD0-0x00894DE0
	public void CreateWaterMask(int blockX, int blockY, float x, float y, float z) {} // 0x00894DE0-0x00894DF0
	protected void UpdateVisibleWaterMask(bool bVisible) {} // 0x00894DF0-0x00894E00
	public override void SetCutProduction(bool bCutEnable) {} // 0x00894E00-0x00894E10
	public void SetShopFloorParts(int blockX, int blockY, float fx, float fy, float fz, ExtraFloorParts.Type eType) {} // 0x00894E10-0x00894E20
	public void ClearFloorParts(int blockX, int blockY) {} // 0x00894E20-0x00894E30
	public override void OnUpdateGlobalShadowColor(Color color) {} // 0x00894E30-0x00894FA0
	protected override void OnUpdateShadowVisible(bool bVisible) {} // 0x00894FA0-0x00894FB0
	protected override void OnUpdateVisible(bool bVisible) {} // 0x00894FB0-0x00895080
	protected override bool IsMapModel() => default; // 0x00895080-0x00895090
	public void SetEffectiveLevel(float fLevel, float fSec) {} // 0x00895090-0x008950A0
	public void SetProjectionShadowAlpha(float fAlpha, float fSec) {} // 0x008950A0-0x008950B0
	public override void Update() {} // 0x008950B0-0x008955D0
	protected override void OnTerminate() {} // 0x00895690-0x00895EF0
	public void SetPositionGridCursor(Vector3 v) {} // 0x00895F20-0x00895FF0
	public void SetVisibleGridCursor(bool bVisible) {} // 0x00895FF0-0x00896020
	public void UpdateGridTexturePixel(int blockX, int blockY, float element_grid, float element_dark, float element_target, float element_beam) {} // 0x00896020-0x00896130
	protected void SetDirtyGridTexture() {} // 0x00896130-0x00896140
	public void SetShowGrid(bool bShow, bool bForce) {} // 0x00895EF0-0x00895F20
	protected virtual void UpdateGridTexture(bool bAutoApplyGridTexture) {} // 0x00896140-0x00896360
	private void UpdateSpotTexture() {} // 0x008955D0-0x00895690
	protected override void OnUpdateShaderMaterialVisibleColor(Color color) {} // 0x00896360-0x00896520
	public void SetEffectiveTexturePixelMagma(int blockX, int blockY, int pattern) {} // 0x00896520-0x00896600
	public void SetEffectiveTexturePixel(int blockX, int blockY, float r, float g, float b, float a) {} // 0x00896610-0x00896680
	protected void SetDirtyEffectiveTexture() {} // 0x00896600-0x00896610
	protected virtual void UpdateEffectiveTexture() {} // 0x00896680-0x00896720
	public override void LastUpdate() {} // 0x00896720-0x00896730
}

