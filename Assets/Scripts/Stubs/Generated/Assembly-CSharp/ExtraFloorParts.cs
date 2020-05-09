/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ExtraFloorParts : Frame // TypeDefIndex: 5979
{
	// Fields
	private Texture2D GridTexture; // 0x20
	public const int MAX_MAP_WIDTH = 81; // Metadata: 0x0061234F
	public const int MAX_MAP_HEIGHT = 63; // Metadata: 0x00612353
	private GameObject[] aShopFloorPrefab; // 0x28
	private Data[] m_aPlaceObject; // 0x30
	private Dictionary<int, Material> m_dicMaterial; // 0x38
	private SpotView.Type m_eSpotType; // 0x40
	private bool m_bVisible; // 0x44
	private bool m_bVisibleOffForColorChange; // 0x45
	private bool m_bDirtyVisible; // 0x46

	// Nested types
	public enum Type // TypeDefIndex: 5980
	{
		SHOP = 0,
		SHOP_2 = 1,
		SHOP_3 = 2,
		MAX = 3
	}

	private class Data // TypeDefIndex: 5981
	{
		// Fields
		public GameObject obj; // 0x10
		public Renderer renderer; // 0x18

		// Constructors
		public Data() {} // 0x0080BD10-0x0080BD20
	}

	// Constructors
	private ExtraFloorParts() {} // 0x00BDEED0-0x00BDF090

	// Methods
	public static ExtraFloorParts Create() => default; // 0x00BDEE70-0x00BDEED0
	private void SetupMaterial(Type eType, string prefabName) {} // 0x00BDF090-0x00BDF310
	public void SetupGridMask(Texture2D tex) {} // 0x00BDF310-0x00BDF490
	public void SetGridFlag(bool bFlag) {} // 0x00BDF490-0x00BDF660
	public void Set(int x, int y, float fx, float fy, float fz, Type eType) {} // 0x00BDF660-0x00BDF8D0
	public void Clear(int x, int y) {} // 0x00BDF8D0-0x00BDFA40
	protected override void OnTerminate() {} // 0x00BDFA40-0x00BDFBA0
	protected virtual void OnUpdateShaderMaterialVisibleColor(Color color) {} // 0x00BDFBA0-0x00BDFD10
	public void SetVisible(bool bEnable) {} // 0x00BDFD10-0x00BDFD40
	public override void Update() {} // 0x00BDFD40-0x00BDFE00
	public override void LastUpdate() {} // 0x00BDFE00-0x00BDFFF0
}

