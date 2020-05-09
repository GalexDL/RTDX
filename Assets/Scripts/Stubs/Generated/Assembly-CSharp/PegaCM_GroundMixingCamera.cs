/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00609610-0x00609670
[DisallowMultipleComponent] // 0x00609610-0x00609670
[ExecuteInEditMode] // 0x00609610-0x00609670
public class PegaCM_GroundMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4878
{
	// Fields
	[NoSaveDuringPlay] // 0x00616220-0x00616270
	// [Tooltip] // 0x00616220-0x00616270
	public Transform m_LookAt; // 0x78
	[NoSaveDuringPlay] // 0x00616270-0x006162C0
	// [Tooltip] // 0x00616270-0x006162C0
	public Transform m_Follow; // 0x80
	[NoSaveDuringPlay] // 0x006162C0-0x00616310
	// [Tooltip] // 0x006162C0-0x00616310
	public bool m_ShowDebugText; // 0x88
	[HideInInspector] // 0x00616310-0x00616360
	[NoSaveDuringPlay] // 0x00616310-0x00616360
	[SerializeField] // 0x00616310-0x00616360
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
	// [Tooltip] // 0x00616360-0x006163A0
	public float m_ActivateAfter; // 0x98
	// [Tooltip] // 0x006163A0-0x006163E0
	public float m_MinDuration; // 0x9C
	[CinemachineBlendDefinitionProperty] // 0x006163E0-0x00616430
	// [Tooltip] // 0x006163E0-0x00616430
	public CinemachineBlendDefinition m_DefaultBlend; // 0xA0
	[HideInInspector] // 0x00616430-0x00616440
	public CinemachineBlenderSettings m_CustomBlends; // 0xB0
	private CameraState m_State; // 0xC0
	private float mActivationTime; // 0x1A0
	private float mPendingActivationTime; // 0x1A4
	private ICinemachineCamera mPendingCamera; // 0x1A8
	private CinemachineBlend mActiveBlend; // 0x1B0
	private List<BlendCam_> m_BlendOrderCamLst; // 0x1B8
	private float blendWeightAlpha; // 0x1C0
	private List<BlendDelay_> m_blendDelayLst; // 0x1C8

	// Properties
	public override string Description { get => default; } // 0x00789590-0x00789690 
	public ICinemachineCamera LiveChild { get; set; } // 0x00789690-0x007896A0 0x007896A0-0x007896B0
	public override CameraState State { get => default; } // 0x007896B0-0x007896C0 
	public override Transform LookAt { get => default; set {} } // 0x00789850-0x00789860 0x00789860-0x00789870
	public override Transform Follow { get => default; set {} } // 0x00789870-0x00789880 0x00789880-0x00789890
	public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x0078AA60-0x0078AA90 

	// Nested types
	private struct BlendCam_ // TypeDefIndex: 4879
	{
		// Fields
		public float weight; // 0x10
		public ICinemachineCamera vcam; // 0x18
		public int prio; // 0x20

		// Methods
		public static int CamPrioCompareTo(BlendCam_ a, BlendCam_ b) => default; // 0x0078B400-0x0078B410
	}

	private class BlendDelay_ // TypeDefIndex: 4880
	{
		// Fields
		public ICinemachineCamera vcam; // 0x10
		public float delayRatio; // 0x18

		// Constructors
		public BlendDelay_() {} // 0x0078AF30-0x0078AF40
	}

	// Constructors
	public PegaCM_GroundMixingCamera() {} // 0x0078B210-0x0078B330

	// Methods
	//public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x007896C0-0x00789850
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x00789890-0x00789960
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00789AF0-0x00789B90
	protected override void OnEnable() {} // 0x0078A560-0x0078A760
	protected override void OnDisable() {} // 0x0078A770-0x0078A8B0
	public void OnTransformChildrenChanged() {} // 0x0078A8B0-0x0078A8C0
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0078A8C0-0x0078A8D0
	private void OnGuiHandler() {} // 0x0078A8D0-0x0078AA60
	private void InvalidateListOfChildren_() {} // 0x0078A760-0x0078A770
	private void UpdateListOfChildren_() {} // 0x00789960-0x00789AF0
	private CinemachineBlendDefinition LookupBlend_(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x0078AA90-0x0078ABD0
	private CameraState BlendCamera_(Vector3 worldUp, float deltaTime) => default; // 0x00789B90-0x0078A560
	public void CalcManualPosition(out Vector3 pos, out Quaternion rot, out float nearClipPlane, out float farClipPlane, out float fieldOfView) {
		pos = default;
		rot = default;
		nearClipPlane = default;
		farClipPlane = default;
		fieldOfView = default;
	} // 0x0078AF60-0x0078B210
}

