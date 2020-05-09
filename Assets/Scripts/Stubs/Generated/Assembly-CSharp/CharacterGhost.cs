/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x006092E0-0x006092F0
public class CharacterGhost : MonoBehaviour, GhostCameraRenderer.IRenderObject // TypeDefIndex: 4841
{
	// Fields
	public float GhostAlpha; // 0x1C
	private Shader ghostEffectBaseSetShader; // 0x20
	private Shader ghostEffectBaseSetShader_BaseBlend; // 0x28
	private Shader ghostEffectBaseSetShadowShader; // 0x30
	private Shader ghostEffectBaseSetShadowShader_BaseBlend; // 0x38
	private Shader ghostBaseBlendShader; // 0x40
	private Shader ghostBlendShader; // 0x48
	private GhostCameraRenderer m_ghostCameraRenderer; // 0x50
	private CharacterModel m_parent; // 0x58
	private Dictionary<int, RenderMaterialParameter> m_aMaterialGhost; // 0x60
	private Dictionary<Renderer, List<int>> m_aRenderingGhost; // 0x68
	private Dictionary<string, Shader> m_aShader; // 0x70
	private Color m_color; // 0x78
	private Color m_colorCondition; // 0x88
	private Color m_colorAdd; // 0x98
	private float m_ghostMulAlpha; // 0xA8
	private float m_pgScale; // 0xAC
	private float m_ghostGroundFadeRate; // 0xB0
	private bool m_bDirtyColor; // 0xB4

	// Properties
	public bool EnabledGhost { get; set; } // 0x009B2740-0x009B2750 0x009B2750-0x009B2760

	// Nested types
	private class RenderMaterialParameter // TypeDefIndex: 4842
	{
		// Fields
		public Material mat; // 0x10
		public int subMeshIndex; // 0x18
		public int subPriorityKey; // 0x1C
		public int passStart; // 0x20
		public int passCount; // 0x24
		public Material zmaskMat; // 0x28
		public int zmaskSubMeshIndex; // 0x30
		public int zmaskSubPriorityKey; // 0x34
		public int zmaskPassStart; // 0x38
		public bool bEffect; // 0x3C
		public bool bOffset; // 0x3D

		// Constructors
		public RenderMaterialParameter() {} // 0x009B3910-0x009B3950
	}

	// Constructors
	public CharacterGhost() {} // 0x009B3EB0-0x009B4030

	// Methods
	private void ReleaseCommandBuffer() {} // 0x009B2760-0x009B27E0
	private void CreateCommandBuffer() {} // 0x009B27E0-0x009B28C0
	public void MakeRenderMeshes(List<GhostCameraRenderer.RenderMesh> aRenderMesh) {} // 0x009B28C0-0x009B2EC0
	private void OnDestroy() {} // 0x009B2EC0-0x009B3220
	public static void UpdateMaterialToMaterial(Material dst, Material src) {} // 0x009B1B50-0x009B1B60
	public void Setup(CharacterModel parent, GhostCameraRenderer _ghostCameraRenderer, Shader baseBlendShader, Shader blendShader, Shader effectBaseSet, Shader effectBaseSetBaseBlend, Shader effectBaseSetShadow, Shader effectBaseSetShadowBaseBlend, float fPGScale) {} // 0x009B3220-0x009B3910
	public void SetColor(Color color) {} // 0x009B3950-0x009B39D0
	public void SetConditionColor(Color color) {} // 0x009B39D0-0x009B3A50
	public void SetAddColor(Color color) {} // 0x009B3A50-0x009B3AD0
	public void SetGroundFadeRate(float fRate) {} // 0x009B3AD0-0x009B3AF0
	public float GetGroundFadeRate() => default; // 0x009B3AF0-0x009B3B00
	private void Update() {} // 0x009B3B00-0x009B3B10
	public void LateUpdateManual() {} // 0x009B3B10-0x009B3EB0
}

