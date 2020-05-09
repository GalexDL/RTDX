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

public class GhostCameraRenderer : MonoBehaviour // TypeDefIndex: 4850
{
	// Fields
	private List<IRenderObject> m_aRenderObject; // 0x18
	private List<RenderMesh> m_aRenderMesh; // 0x20
	private GameObject m_floorMapGhostExclutionFilterPrefab; // 0x28
	private GameObject m_floorMapGhostExclutionFilter; // 0x30
	private Renderer m_floorMapGhostExclutionFilterRenderer; // 0x38
	private Material m_floorMapGhostExclutionFilterMaterial; // 0x40
	private MainCamera.NativeCamera m_nativeCamera; // 0x48
	private Material text2d; // 0x50
	private RenderTexture m_renderTexture; // 0x58
	private CommandBuffer m_commandBuf; // 0x60
	private bool m_bEnable; // 0x68
	private bool m_bCommandStreamWriteEnable; // 0x69

	// Properties
	public bool IsCommandStreamWriteEnable { get => default; } // 0x00729380-0x00729390 

	// Nested types
	public struct RenderMesh // TypeDefIndex: 4851
	{
		// Fields
		public ulong Key; // 0x10
		public int SecondKey; // 0x18
		public Vector3 center; // 0x1C
		public Renderer renderer; // 0x28
		public Material material; // 0x30
		public int submeshIndex; // 0x38
		public int subPriorityKey; // 0x3C
		public int shaderPass; // 0x40

		// Methods
		public void SetMesh(Camera cam, Vector3 c, Renderer r, Material m, int smId, int subKey, int pass, bool bZMASK, bool bZOffset) {} // 0x0072A6C0-0x0072A7C0
		private void CalcKey(Camera cam, bool bZMASK, bool bZOffset) {} // 0x0072A7C0-0x0072A8B0
	}

	public interface IRenderObject // TypeDefIndex: 4852
	{
		// Methods
		void MakeRenderMeshes(List<RenderMesh> aRenderMesh);
	}

	// Constructors
	public GhostCameraRenderer() {} // 0x0072A4B0-0x0072A6C0

	// Methods
	public static int ComapreyKey(RenderMesh a, RenderMesh b) => default; // 0x00729350-0x00729380
	public void SetEnableCommand(bool bEnable) {} // 0x00729390-0x007293B0
	public CommandBuffer GetCommandBuffer() => default; // 0x007293B0-0x007293C0
	public RenderTexture GetMainRenderTexture() => default; // 0x007293C0-0x007293D0
	public void RegisterRenderObject(IRenderObject obj) {} // 0x007293D0-0x00729460
	public void UnregisterRenderObject(IRenderObject obj) {} // 0x00729460-0x007294F0
	private void ReleaseCommandBuffer() {} // 0x007294F0-0x00729590
	public void Begin(Vector3 exculudeFilterPosition) {} // 0x00729590-0x00729B90
	public void End() {} // 0x00729DC0-0x00729E70
	public void CreateCommandBuffer() {} // 0x00729E70-0x00729FE0
	private void OnDestroy() {} // 0x00729FE0-0x00729FF0
	private void Terminate() {} // 0x00729FF0-0x0072A170
	public void Setup(MainCamera.NativeCamera nativeCamera) {} // 0x0072A170-0x0072A2C0
	public void LateUpdate() {} // 0x0072A3F0-0x0072A4B0
}

