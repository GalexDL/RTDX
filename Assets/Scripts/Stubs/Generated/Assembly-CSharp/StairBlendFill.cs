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

[ExecuteInEditMode] // 0x006094E0-0x006094F0
public class StairBlendFill : MonoBehaviour // TypeDefIndex: 4865
{
	// Fields
	private Shader zmaskShader; // 0x20
	private MainCamera mainCamera; // 0x28
	private ItemModel m_parent; // 0x30
	private Dictionary<int, KeyValuePair<Material, int>> m_aMaterial; // 0x38
	private Dictionary<Renderer, List<int>> m_aRendering; // 0x40
	private Dictionary<string, Shader> m_aShader; // 0x48
	private CommandBuffer m_commandBuf; // 0x50
	private Color m_color; // 0x58
	private Color m_colorCondition; // 0x68
	private Color m_colorAdd; // 0x78
	private bool m_bDirtyColor; // 0x88

	// Properties
	public virtual string BlendFillName { get => default; } // 0x00912700-0x00912750 
	public bool Enabled { get; set; } // 0x00912750-0x00912760 0x00912760-0x00912770

	// Constructors
	public StairBlendFill() {} // 0x00913850-0x009139C0

	// Methods
	private void ReleaseCommandBuffer() {} // 0x00912770-0x00912810
	private void CreateCommandBuffer() {} // 0x00912810-0x00912970
	private void MakeCommandBuffer() {} // 0x00912970-0x00912F40
	private void OnDestroy() {} // 0x00912F40-0x00913180
	public void Setup(ItemModel parent, MainCamera _mainCamera, Shader shader) {} // 0x00913180-0x009134D0
	public void SetColor(Color color) {} // 0x009134D0-0x00913550
	public void SetConditionColor(Color color) {} // 0x00913550-0x009135D0
	public void SetAddColor(Color color) {} // 0x009135D0-0x00913650
	private void Update() {} // 0x00913650-0x00913660
	public void LateUpdateManual() {} // 0x00913660-0x00913850
}

