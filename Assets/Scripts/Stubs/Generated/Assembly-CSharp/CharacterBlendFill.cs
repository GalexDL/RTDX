/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x006092D0-0x006092E0
public class CharacterBlendFill : MonoBehaviour // TypeDefIndex: 4839
{
	// Fields
	private Shader baseBlendShader; // 0x20
	private Shader effectBaseSet_BaseBlendShader; // 0x28
	private Shader effectBaseSetShadow_BaseBlendShader; // 0x30
	private MainCamera mainCamera; // 0x38
	private CharacterModel m_parent; // 0x40
	private Dictionary<int, RenderMaterialParameter> m_aMaterial; // 0x48
	private Dictionary<Renderer, List<int>> m_aRendering; // 0x50
	private Dictionary<Renderer, List<int>> m_aPostRendering; // 0x58
	private Dictionary<string, Shader> m_aShader; // 0x60
	private CommandBuffer m_commandBuf; // 0x68
	private Color m_color; // 0x70
	private Color m_colorCondition; // 0x80
	private Color m_colorAdd; // 0x90
	private float m_fPGScale; // 0xA0
	private bool m_bDirtyColor; // 0xA4
	private bool m_bFuraigonEye; // 0xA5

	// Properties
	public bool Enabled { get; set; } // 0x009B08D0-0x009B08E0 0x009B08E0-0x009B08F0

	// Nested types
	private class RenderMaterialParameter // TypeDefIndex: 4840
	{
		// Fields
		public Material mat; // 0x10
		public int subMeshIndex; // 0x18
		public int passStart; // 0x1C
		public int passCount; // 0x20
		public bool bEffect; // 0x24
		public bool bOffset; // 0x25

		// Constructors
		public RenderMaterialParameter() {} // 0x009B1B60-0x009B1B90
	}

	// Constructors
	public CharacterBlendFill() {} // 0x009B1F40-0x009B20D0

	// Methods
	private void ReleaseCommandBuffer() {} // 0x009B08F0-0x009B0990
	private void CreateCommandBuffer() {} // 0x009B0990-0x009B0AF0
	private void MakeCommandBuffer() {} // 0x009B0AF0-0x009B11C0
	private void OnDestroy() {} // 0x009B11C0-0x009B13D0
	public void Setup(CharacterModel parent, MainCamera _mainCamera, Shader shader, Shader effectBaseBlendShader, Shader effectBaseShadowBaseBlendShader, float fPGScale, bool bFuraigonEye) {} // 0x009B13D0-0x009B1B40
	public void SetColor(Color color) {} // 0x009B1B90-0x009B1C10
	public void SetConditionColor(Color color) {} // 0x009B1C10-0x009B1C90
	public void SetAddColor(Color color) {} // 0x009B1C90-0x009B1D10
	private void Update() {} // 0x009B1D10-0x009B1D20
	public void LateUpdateManual() {} // 0x009B1D20-0x009B1F40
}

