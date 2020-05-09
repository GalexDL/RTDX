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

public class CameraRenderer // TypeDefIndex: 4836
{
	// Fields
	private List<IRenderObject> m_aRenderObject; // 0x10
	private List<RenderMesh> m_aRenderMesh; // 0x18
	private Material text2d; // 0x20
	private CameraEvent m_cameraEvent; // 0x28
	private CommandBuffer m_commandBuf; // 0x30
	private bool m_bEnable; // 0x38
	private bool m_bCommandStreamWriteEnable; // 0x39

	// Properties
	public bool IsCommandStreamWriteEnable { get => default; } // 0x008C4770-0x008C4780 

	// Nested types
	public struct RenderMesh // TypeDefIndex: 4837
	{
		// Fields
		public ulong Key; // 0x10
		public Vector3 center; // 0x18
		public Renderer renderer; // 0x28
		public Material material; // 0x30
		public int submeshIndex; // 0x38
		public int shaderPass; // 0x3C

		// Methods
		public void SetMesh(Camera cam, Vector3 c, Renderer r, Material m, int smId, int pass, bool bZMASK) {} // 0x008C4EF0-0x008C4F20
		private void CalcKey(Camera cam, bool bZMASK) {} // 0x008C4F20-0x008C4F30
	}

	public interface IRenderObject // TypeDefIndex: 4838
	{
		// Methods
		void MakeRenderMeshes(List<RenderMesh> aRenderMesh);
	}

	// Constructors
	public CameraRenderer() {} // 0x008C4CF0-0x008C4EF0

	// Methods
	public static int ComapreyKey(RenderMesh a, RenderMesh b) => default; // 0x008C4740-0x008C4770
	public void SetEnable(bool bEnable) {} // 0x008C4780-0x008C47A0
	public CommandBuffer GetCommandBuffer() => default; // 0x008C47A0-0x008C47B0
	public void RegisterRenderObject(IRenderObject obj) {} // 0x008C47B0-0x008C4840
	public void UnregisterRenderObject(IRenderObject obj) {} // 0x008C4840-0x008C48D0
	private void ReleaseCommandBuffer() {} // 0x008C48D0-0x008C4970
	public void Begin() {} // 0x008C4970-0x008C4A50
	protected virtual void OnBegin() {} // 0x008C4A50-0x008C4A60
	public void End() {} // 0x008C4A60-0x008C4A90
	protected virtual void OnEnd() {} // 0x008C4A90-0x008C4AA0
	public void CreateCommandBuffer(string name) {} // 0x008C4AA0-0x008C4C10
	public void Terminate() {} // 0x008C4C10-0x008C4CB0
	public void Setup(string name) {} // 0x008C4CB0-0x008C4CE0
	protected virtual void OnSetup() {} // 0x008C4CE0-0x008C4CF0
}

