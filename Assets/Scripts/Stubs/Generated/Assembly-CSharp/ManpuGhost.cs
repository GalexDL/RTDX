/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x006092F0-0x00609300
public class ManpuGhost : MonoBehaviour, GhostCameraRenderer.IRenderObject // TypeDefIndex: 4855
{
	// Fields
	public float GhostAlpha; // 0x1C
	private Shader ghostEffectBaseSetShader; // 0x20
	private MainCamera mainCamera; // 0x28
	private ManpuModel m_parent; // 0x30
	private Dictionary<int, RenderMaterialParameter> m_aMaterialGhost; // 0x38
	private Dictionary<Renderer, List<int>> m_aRenderingGhost; // 0x40
	private Dictionary<string, Shader> m_aShader; // 0x48
	private Color m_color; // 0x50
	private float m_ghostMulAlpha; // 0x60
	private float m_ghostGroundFadeRate; // 0x64
	private bool m_bDirtyColor; // 0x68

	// Properties
	public bool EnabledGhost { get; set; } // 0x00890BE0-0x00890BF0 0x00890BF0-0x00890C00

	// Nested types
	private class RenderMaterialParameter // TypeDefIndex: 4856
	{
		// Fields
		public Material mat; // 0x10
		public int subMeshIndex; // 0x18
		public int passCount; // 0x1C
		public Material zmaskMat; // 0x20
		public int zmaskSubMeshIndex; // 0x28

		// Constructors
		public RenderMaterialParameter() {} // 0x008919F0-0x00891A00
	}

	// Constructors
	public ManpuGhost() {} // 0x00891CB0-0x00891DC0

	// Methods
	private void ReleaseCommandBuffer() {} // 0x00890C00-0x00890C80
	private void CreateCommandBuffer() {} // 0x00890C80-0x00890D60
	public void MakeRenderMeshes(List<GhostCameraRenderer.RenderMesh> aRenderMesh) {} // 0x00890D60-0x00891250
	private void OnDestroy() {} // 0x00891250-0x00891570
	public static void UpdateMaterialTextureToMaterial(Material dst, Material src) {} // 0x00891570-0x00891620
	public void Setup(ManpuModel parent, MainCamera _mainCamera, Shader effectBaseSet) {} // 0x00891620-0x008919F0
	public void SetColor(Color color) {} // 0x00891A00-0x00891A80
	public void SetGroundFadeRate(float fRate) {} // 0x00891A80-0x00891AA0
	private void Update() {} // 0x00891AA0-0x00891AB0
	public void LateUpdateManual() {} // 0x00891AB0-0x00891CB0
}

