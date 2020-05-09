/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 45: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4233-4338

namespace UnityStandardAssets.ImageEffects
{
	// [AddComponentMenu] // 0x00606700-0x006067A0
	[ExecuteInEditMode] // 0x00606700-0x006067A0
	// [RequireComponent] // 0x00606700-0x006067A0
	public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 4271
	{
		// Fields
		private static float MAX_RADIUS; // 0x00
		public MotionBlurFilter filterType; // 0x1C
		public bool preview; // 0x20
		public Vector3 previewScale; // 0x24
		public float movementScale; // 0x30
		public float rotationScale; // 0x34
		public float maxVelocity; // 0x38
		public float minVelocity; // 0x3C
		public float velocityScale; // 0x40
		public float softZDistance; // 0x44
		public int velocityDownsample; // 0x48
		public LayerMask excludeLayers; // 0x4C
		private GameObject tmpCam; // 0x50
		public Shader shader; // 0x58
		public Shader dx11MotionBlurShader; // 0x60
		public Shader replacementClear; // 0x68
		private Material motionBlurMaterial; // 0x70
		private Material dx11MotionBlurMaterial; // 0x78
		public Texture2D noiseTexture; // 0x80
		public float jitter; // 0x88
		public bool showVelocity; // 0x8C
		public float showVelocityScale; // 0x90
		private Matrix4x4 currentViewProjMat; // 0x94
		private Matrix4x4 prevViewProjMat; // 0xD4
		private int prevFrameCount; // 0x114
		private bool wasActive; // 0x118
		private Vector3 prevFrameForward; // 0x11C
		private Vector3 prevFrameUp; // 0x128
		private Vector3 prevFramePos; // 0x134
		private Camera _camera; // 0x140
	
		// Nested types
		public enum MotionBlurFilter // TypeDefIndex: 4272
		{
			CameraMotion = 0,
			LocalBlur = 1,
			Reconstruction = 2,
			ReconstructionDX11 = 3,
			ReconstructionDisc = 4
		}
	
		// Constructors
		public CameraMotionBlur() {} // 0x00358D60-0x00358E80
		static CameraMotionBlur() {} // 0x00358E80-0x00358EE0
	
		// Methods
		private void CalculateViewProjection() {} // 0x00356900-0x00356B70
		private new void Start() {} // 0x00356B70-0x00356CE0
		private new void OnEnable() {} // 0x00356DA0-0x00356E60
		private void OnDisable() {} // 0x00356E60-0x00356FD0
		public override bool CheckResources() => default; // 0x00356FD0-0x00357100
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00357170-0x003589A0
		private void Remember() {} // 0x00356CE0-0x00356DA0
		private Camera GetTmpCam() => default; // 0x00358A90-0x00358D60
		private void StartFrame() {} // 0x003589A0-0x00358A80
		private static int divRoundUp(int x, int d) => default; // 0x00358A80-0x00358A90
	}
}
