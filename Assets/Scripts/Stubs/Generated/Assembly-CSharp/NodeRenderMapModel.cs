/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NodeRenderMapModel : MapModel // TypeDefIndex: 6047
{
	// Fields
	private const int gridSize = 20; // Metadata: 0x006124F3
	private const float shadowHeight = 0.1f; // Metadata: 0x006124F7
	private string m_copyBaseName; // 0x250
	private bool m_bRandomMap; // 0x258
	private bool m_bPrevColorBlack; // 0x259
	private bool m_bCombinedInit; // 0x25A
	private bool m_bUpdateShadowCaster; // 0x25B
	private Vector3 m_localOffset; // 0x25C
	private List<CombinedMesh> m_listCombinedMesh; // 0x268
	private int nowShadowResolutionQulity; // 0x270

	// Nested types
	public class CombinedMesh // TypeDefIndex: 6048
	{
		// Fields
		public GameObject obj; // 0x10
		public List<int> listRefNode; // 0x18

		// Constructors
		public CombinedMesh() {} // 0x007849C0-0x007849D0
	}

	// Constructors
	public NodeRenderMapModel() {} // Dummy constructor
	protected NodeRenderMapModel(int nativeControlId, GraphicsSystem.MapDatabaseParameter baseParameter) {} // 0x007829A0-0x00782E00

	// Methods
	public void InitailzieLocalOffset(Vector3 v) {} // 0x00782990-0x007829A0
	public void CreateLocalNode(int localId, int boneId, int blockX, int blockY, float x, float y, float z, float pitch, float yaw, float roll, float fScaleY, bool bGrid, bool bLinkParts, bool bShadowTarget) {} // 0x00782E00-0x007831F0
	public void CreateLocalNodeFromBoneSymbol(int localId, string boneSymbol, int blockX, int blockY, float x, float y, float z, float pitch, float yaw, float roll, bool bGrid, bool bLinkParts, bool bShadowTarget) {} // 0x007831F0-0x007832F0
	public void SetLocalVisible(int localId, bool bVisible) {} // 0x007832F0-0x007833D0
	protected override void OnTerminate() {} // 0x007833D0-0x00783540
	private void CombineMesh(List<NodeObject> meshFilters) {} // 0x00783540-0x00783DD0
	public void UpdateRequest6CullingShadowCaster() {} // 0x00784340-0x00784350
	private void CullingShadowCaster() {} // 0x00784350-0x007846C0
	protected override void OnUpdateVisible(bool bVisible) {} // 0x007846C0-0x00784820
	public override void Update() {} // 0x00784820-0x007849C0
	private void CreateCobinedMeshObject(List<ArrayList> combineInstanceArrays, List<Material> materials, List<int> combineInstanceRefNodeId, List<NodeObject> combineInstanceRefNode) {} // 0x00783DD0-0x00784340
}

