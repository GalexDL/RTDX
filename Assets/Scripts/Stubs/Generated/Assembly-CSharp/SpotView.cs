/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SpotView : SingletonMonoBehaviour<SpotView> // TypeDefIndex: 6076
{
	// Fields
	private const int SIZE = 128; // Metadata: 0x0061250F
	public Type eType_; // 0x18
	public bool bVisible_; // 0x1C
	public bool bNativeUpdate_; // 0x1D
	private float[] aTempBuffer_; // 0x20
	public Vector3 vAt_; // 0x28
	private Texture2D mapTexture_; // 0x38
	private MeshRenderer renderer_; // 0x40
	private float[] aPattern_; // 0x48

	// Properties
	public Vector3 At { get => default; } // 0x0090E6A0-0x0090E6B0 
	public bool Visible { get => default; } // 0x0090E6B0-0x0090E6C0 

	// Nested types
	public enum Type // TypeDefIndex: 6077
	{
		NONE = 0,
		ROAD = 1,
		ROAD_X2 = 2,
		ROOM = 3,
		MAX = 4
	}

	// Constructors
	public SpotView() {} // 0x0090F9F0-0x0090FAF0

	// Methods
	public static void Startup() {} // 0x0090E6C0-0x0090E730
	public static void Shutdown() {} // 0x0090E730-0x0090E7A0
	private void Start() {} // 0x0090E7A0-0x0090E940
	private void OnDestroy() {} // 0x0090E980-0x0090EA40
	public void SetVisible(bool bVisible) {} // 0x0090EA40-0x0090EA50
	public void SetSpotType(Type eType) {} // 0x0090EA50-0x0090EA70
	public bool IsRoadType() => default; // 0x0090EA70-0x0090EA90
	public Type GetSpotType() => default; // 0x0090EA90-0x0090EAA0
	public Texture2D GetTexture() => default; // 0x0090EAA0-0x0090EAB0
	public void Clear() {} // 0x0090EAB0-0x0090EB50
	public void SetPixel(int x, int y, int id) {} // 0x0090EB50-0x0090EC40
	public float GetValue(int x, int y) => default; // 0x0090EC40-0x0090ECA0
	public void Apply() {} // 0x0090E940-0x0090E980
	public void SetTargetPosition(float x, float y, float z) {} // 0x0090ECA0-0x0090ECC0
	public void UpdateFromGameSystem(Camera cam, Vector3 eye, Vector3 at) {} // 0x0090ECC0-0x0090ECD0
	public bool UpdateSpotTextureFromMaterialDic(ref Type eType, Dictionary<int, Material> dicMat, Dictionary<uint, MaterialPropertyBlock> dicMatPropertyBlock) => default; // 0x0090ECD0-0x0090F120
	public void ForceClearSpotTextureFromMaterialDic(Dictionary<int, Material> dicMat, Dictionary<uint, MaterialPropertyBlock> dicMatPropertyBlock) {} // 0x0090F120-0x0090F4E0
	public void PostRender() {} // 0x0090F4E0-0x0090F5B0
	public static bool Utility_UpdateCalcMaterialSpotColor(Vector3 vSpotCalcPosition, float fSpotDecayCorrectionLength, bool bSpotColorUpdate, ref float fSpotDependentRate, ref float fSpotDependentPrevRate) => default; // 0x0090F5B0-0x0090F9F0
}

