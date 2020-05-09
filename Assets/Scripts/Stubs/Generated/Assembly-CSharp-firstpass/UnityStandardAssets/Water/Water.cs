/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 45: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4233-4338

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode] // 0x00606360-0x00606370
	public class Water : MonoBehaviour // TypeDefIndex: 4247
	{
		// Fields
		public WaterMode waterMode; // 0x18
		public bool disablePixelLights; // 0x1C
		public int textureSize; // 0x20
		public float clipPlaneOffset; // 0x24
		public LayerMask reflectLayers; // 0x28
		public LayerMask refractLayers; // 0x2C
		private Dictionary<Camera, Camera> m_ReflectionCameras; // 0x30
		private Dictionary<Camera, Camera> m_RefractionCameras; // 0x38
		private RenderTexture m_ReflectionTexture; // 0x40
		private RenderTexture m_RefractionTexture; // 0x48
		private WaterMode m_HardwareWaterSupport; // 0x50
		private int m_OldReflectionTextureSize; // 0x54
		private int m_OldRefractionTextureSize; // 0x58
		private static bool s_InsideWater; // 0x00
	
		// Nested types
		public enum WaterMode // TypeDefIndex: 4248
		{
			Simple = 0,
			Reflective = 1,
			Refractive = 2
		}
	
		// Constructors
		public Water() {} // 0x0036E220-0x0036E300
	
		// Methods
		public void OnWillRenderObject() {} // 0x0036BF30-0x0036C810
		private void OnDisable() {} // 0x0036DBD0-0x0036DF90
		private void Update() {} // 0x0036DF90-0x0036E220
		private void UpdateCameraModes(Camera src, Camera dest) {} // 0x0036D4C0-0x0036D710
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera) {
			reflectionCamera = default;
			refractionCamera = default;
		} // 0x0036C9D0-0x0036D4C0
		private WaterMode GetWaterMode() => default; // 0x0036C9B0-0x0036C9D0
		private WaterMode FindHardwareWaterSupport() => default; // 0x0036C810-0x0036C9B0
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) => default; // 0x0036D9C0-0x0036DBD0
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) {} // 0x0036D710-0x0036D9C0
	}
}
