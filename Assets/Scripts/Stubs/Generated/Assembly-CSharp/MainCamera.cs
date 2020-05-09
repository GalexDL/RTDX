/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A1E0-0x0060A1F0
public class MainCamera : SingletonMonoBehaviour<MainCamera> // TypeDefIndex: 6031
{
	// Fields
	private GhostCameraRenderer m_ghostCamera; // 0x18
	private bool bStarted_; // 0x20
	private bool bNativeGLEnable_; // 0x21
	public Camera RefDungeonCamera; // 0x28
	private RenderTexture variableFrameBufferTexutre_; // 0x30
	private bool bNativeCameraUpdateEnable_; // 0x38
	private bool bNearCameraEnable_; // 0x39
	private NativeCamera nativeCamera_; // 0x40
	private Camera mainCamera_; // 0x48
	private Camera groundCamera_; // 0x50
	private Camera dungeonCamera_; // 0x58
	private Transform mainTransform; // 0x60
	private Transform shakeOffsetTransform_; // 0x68
	private GameObject cameraAnimationObject_; // 0x70
	private CameraAnimationController cameraAnimationCtrl_; // 0x78
	private ShakeParam_ shakeWork_; // 0x80
	private DisplayCaptureAll displayCaptureAll_; // 0x88
	public Vector2 AnimeOverrideShakeOffset; // 0x90
	private PlayableGraph animShakeGraph_; // 0x98
	private byte[] aCameraFrustumTempBuffer_; // 0xA8
	private byte[] aCameraFrustumBuffer_; // 0xB0
	private DataExchangeByteMemoryStream byteStream_; // 0xB8

	// Properties
	public GhostCameraRenderer GhostRenderer { get => default; } // 0x0088B530-0x0088B540 
	public bool IsStarted { get => default; } // 0x0088B540-0x0088B550 
	public bool NativeGLEnable { get => default; set {} } // 0x0088B560-0x0088B570 0x0088B550-0x0088B560
	public Transform BillboardTarget { get => default; } // 0x0088B570-0x0088B580 
	public bool NativeCameraUpdateEnable { get => default; set {} } // 0x0088B590-0x0088B5A0 0x0088B580-0x0088B590
	public bool NearCameraEnable { get => default; set {} } // 0x0088B5B0-0x0088B5C0 0x0088B5A0-0x0088B5B0
	public NativeCamera NativeCameraParameter { get => default; } // 0x0088B5C0-0x0088B5D0 
	public CameraAnimationController CameraAnimationCtrl { get => default; } // 0x0088B5D0-0x0088B5E0 

	// Nested types
	public class NativeCamera // TypeDefIndex: 6032
	{
		// Fields
		private float[] nativeCameraParameter_; // 0x10
		private int[] nativeCameraIntParameter_; // 0x18
		public Vector3 vEye; // 0x20
		public Vector3 vAt; // 0x2C
		public Vector3 vFollowBaseAt; // 0x38
		public float nearClipPlane; // 0x44
		public float farClipPlane; // 0x48
		public float fieldOfView; // 0x4C
		public NearCameraDirection eNearCameraDirection; // 0x50
		public float fNormalToCircuitRate; // 0x54
		public int nFollowNativeControlId; // 0x58

		// Nested types
		private enum NativeCameraParameter // TypeDefIndex: 6033
		{
			EYE_X = 0,
			EYE_Y = 1,
			EYE_Z = 2,
			AT_X = 3,
			AT_Y = 4,
			AT_Z = 5,
			NEAR = 6,
			FAR = 7,
			FOV = 8,
			NORMAL_TO_CIRCUIT_RATE = 9,
			AUTO_CAMERA_ROTATE_PITCH_DEG = 10,
			AUTO_CAMERA_ROTATE_YAW_DEG = 11,
			AUTO_CAMERA_ROTATE_ROLL_DEG = 12,
			FOV_RATE = 13,
			FOLLOW_BASE_AT_X = 14,
			FOLLOW_BASE_AT_Y = 15,
			FOLLOW_BASE_AT_Z = 16,
			MAX = 17
		}

		private enum NativeCameraIntParameter // TypeDefIndex: 6034
		{
			NEAR_CAMERA_DIRECTION = 0,
			FOLLOW_NATIVE_CONTROL_ID = 1,
			MAX = 2
		}

		// Constructors
		public NativeCamera() {} // 0x0088D690-0x0088D710

		// Methods
		public void UpdateFromNative() {} // 0x0088CC70-0x0088D080
	}

	public enum ShakeType // TypeDefIndex: 6035
	{
		SignRandom = 0,
		RangeRandom = 1,
		GaussianRangeRandom = 2,
		SignCycle = 3
	}

	private class ShakeParam_ // TypeDefIndex: 6036
	{
		// Fields
		public Vector2 vSize; // 0x10
		public Vector2 vOffset; // 0x18
		public float fSec; // 0x20
		public float fIntervalSec; // 0x24
		public bool bEnable; // 0x28
		public ShakeType shakeType; // 0x2C

		// Constructors
		public ShakeParam_() {} // 0x0088D710-0x0088D760

		// Methods
		public void Reset() {} // 0x0088BE90-0x0088BEE0
		public void Set(ShakeType _shakeType, Vector2 _vSize, float _fIntervalSec) {} // 0x0088BBC0-0x0088BC40
		private float GaussianRandom_(float range) => default; // 0x0088DC10-0x0088DD50
		public void Update() {} // 0x0088C0C0-0x0088C2B0
	}

	public class CameraParam_AtEye // TypeDefIndex: 6037
	{
		// Fields
		private Vector3 vEye_; // 0x10
		private Vector3 vAt_; // 0x1C
		private MoveFloat mfZoomRate_; // 0x28

		// Properties
		private float fEyeToAtDistance { get => default; } // 0x0088DA50-0x0088DAF0 

		// Constructors
		public CameraParam_AtEye() {} // 0x0088DB20-0x0088DC10

		// Methods
		public void SetZoomRate(float fRate, float fSec) {} // 0x0088DAF0-0x0088DB00
		public bool IsZoom() => default; // 0x0088DB00-0x0088DB10
		public void Update() {} // 0x0088DB10-0x0088DB20
	}

	// Constructors
	public MainCamera() {} // 0x0088D4F0-0x0088D690

	// Methods
	private void Awake() {} // 0x0088B5E0-0x0088B820
	// [IteratorStateMachine] // 0x00623FA0-0x00624010
	private IEnumerator Start() => default; // 0x0088B820-0x0088B890
	private void OnDestroy() {} // 0x0088B8C0-0x0088B980
	public void SetDungeonCamera(bool bCountenance) {} // 0x0088B980-0x0088BA70
	public void SetGroundCamera() {} // 0x0088BA70-0x0088BB40
	public void SetShake(ShakeType shakeType, Vector2 vSize, float fWaitSec) {} // 0x0088BB40-0x0088BBC0
	public Vector3 GetShakeOffset() => default; // 0x0088BC40-0x0088BC50
	public void SetShakeAnimClip(AnimationClip shakeClip) {} // 0x0088BC50-0x0088BE20
	public void ResetShake() {} // 0x0088BE20-0x0088BE90
	public bool IsShake() => default; // 0x0088BFB0-0x0088BFC0
	public void ClearShakeOffset() {} // 0x0088BEE0-0x0088BFB0
	private void UpdateShakeParameter() {} // 0x0088BFC0-0x0088C0C0
	private void OnPreCull() {} // 0x0088C2B0-0x0088C590
	public void SetMainCameraEffectViewerModeParameter() {} // 0x0088C590-0x0088C7B0
	public Camera GetMainCamera() => default; // 0x0088C7B0-0x0088C7C0
	public void SetBackgroundColor(Color color) {} // 0x0088C7C0-0x0088C7D0
	public Color GetBackgroundColor() => default; // 0x0088C7D0-0x0088C7E0
	public Vector3 GetMainCameraWorldToScreen(Vector3 world) => default; // 0x0088C7E0-0x0088C7F0
	public void RequestDisplayCaptureAll(int guiDepth) {} // 0x0088C7F0-0x0088C800
	public void RefleshDisplayCaptureAll(bool bForce) {} // 0x0088C800-0x0088C810
	public Texture2D GetDisplayCaptureAllTexture() => default; // 0x0088C810-0x0088C820
	public void UpdateNativeData_Pre() {} // 0x0088C820-0x0088C830
	public void UpdateNativeData_Post() {} // 0x0088C830-0x0088CC70
	private void Update() {} // 0x0088D080-0x0088D090
	private void OnPreRender() {} // 0x0088D090-0x0088D280
	private void OnPostRender() {} // 0x0088D280-0x0088D4B0
	public void AttachObject(Transform child) {} // 0x0088D4B0-0x0088D4F0
}

