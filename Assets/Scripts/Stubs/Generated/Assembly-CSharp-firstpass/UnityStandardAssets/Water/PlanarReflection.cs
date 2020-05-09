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
	[ExecuteInEditMode] // 0x00606260-0x006062E0
	// [RequireComponent] // 0x00606260-0x006062E0
	public class PlanarReflection : MonoBehaviour // TypeDefIndex: 4245
	{
		// Fields
		public LayerMask reflectionMask; // 0x18
		public bool reflectSkybox; // 0x1C
		public Color clearColor; // 0x20
		public string reflectionSampler; // 0x30
		public float clipPlaneOffset; // 0x38
		private Vector3 m_Oldpos; // 0x3C
		private Camera m_ReflectionCamera; // 0x48
		private Material m_SharedMaterial; // 0x50
		private Dictionary<Camera, bool> m_HelperCameras; // 0x58
	
		// Constructors
		public PlanarReflection() {} // 0x0036BAD0-0x0036BB50
	
		// Methods
		public void Start() {} // 0x00369F60-0x0036A0B0
		private Camera CreateReflectionCameraFor(Camera cam) => default; // 0x0036A0B0-0x0036A3E0
		private void SetStandardCameraParameter(Camera cam, LayerMask mask) {} // 0x0036A3E0-0x0036A490
		private RenderTexture CreateTextureFor(Camera cam) => default; // 0x0036A490-0x0036A590
		public void RenderHelpCameras(Camera currentCam) {} // 0x0036A590-0x0036A700
		public void LateUpdate() {} // 0x0036B0C0-0x0036B120
		public void WaterTileBeingRendered(Transform tr, Camera currentCam) {} // 0x0036B120-0x0036B230
		public void OnEnable() {} // 0x0036B230-0x0036B290
		public void OnDisable() {} // 0x0036B290-0x0036B2F0
		private void RenderReflectionFor(Camera cam, Camera reflectCamera) {} // 0x0036A700-0x0036B0C0
		private void SaneCameraSettings(Camera helperCam) {} // 0x0036B2F0-0x0036B350
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane) => default; // 0x0036B830-0x0036BAB0
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane) => default; // 0x0036B350-0x0036B620
		private static float Sgn(float a) => default; // 0x0036BAB0-0x0036BAD0
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) => default; // 0x0036B620-0x0036B830
	}
}
