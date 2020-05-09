/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00609670-0x006096D0
[ExecuteInEditMode] // 0x00609670-0x006096D0
[SaveDuringPlay] // 0x00609670-0x006096D0
public class PegaCM_GroundMixingParam : CinemachineExtension // TypeDefIndex: 4884
{
	// Fields
	public MixingType mixingType; // 0x28
	public AreaType areaType; // 0x2C
	public Rect_ blendAreaRect; // 0x30
	public RectOffsetFloat blendAreaRectOffset; // 0x40
	public float blendAreaRotateYaw; // 0x48
	public AnimationCurve blendCurve; // 0x50

	// Nested types
	public enum MixingType // TypeDefIndex: 4885
	{
		OverrideArea = 0,
		DefaultCam = 900
	}

	public enum AreaType // TypeDefIndex: 4886
	{
		BlendAreaRect = 0
	}

	[Serializable]
	public struct Rect_ // TypeDefIndex: 4887
	{
		// Fields
		public float x; // 0x10
		public float y; // 0x14
		public float width; // 0x18
		public float height; // 0x1C

		// Properties
		public Rect ToRect { get => default; set {} } // 0x0078B600-0x0078B640 0x0078B640-0x0078B6B0

		// Methods
		public static explicit operator Rect(Rect_ r) => default; // 0x0078B6B0-0x0078B6E0
		public static explicit operator Rect_(Rect r) => default; // 0x0078B6E0-0x0078B760
	}

	[Serializable]
	public class RectOffsetFloat // TypeDefIndex: 4888
	{
		// Fields
		public float left; // 0x10
		public float right; // 0x14
		public float top; // 0x18
		public float bottom; // 0x1C

		// Constructors
		public RectOffsetFloat() {} // 0x0078B5F0-0x0078B600

		// Methods
		public Rect_ Add(Rect_ rect) => default; // 0x0078B550-0x0078B580
	}

	// Constructors
	public PegaCM_GroundMixingParam() {} // 0x0078B580-0x0078B5F0

	// Methods
	private void OnValidate() {} // 0x0078B410-0x0078B510
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0078B510-0x0078B550
	public float CalcLocationBlendWeight(Vector3 pos3d) => default; // 0x0078ABD0-0x0078AF20
}

