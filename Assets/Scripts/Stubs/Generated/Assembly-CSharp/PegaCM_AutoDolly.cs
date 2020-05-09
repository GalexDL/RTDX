/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00609530-0x00609590
[ExecuteInEditMode] // 0x00609530-0x00609590
[SaveDuringPlay] // 0x00609530-0x00609590
public class PegaCM_AutoDolly : CinemachineExtension // TypeDefIndex: 4875
{
	// Fields
	public bool m_AutoDolly; // 0x28
	public int m_SearchResolution; // 0x2C
	public Vector3 m_DistDotAxis; // 0x30

	// Nested types
	private class VcamExtraState // TypeDefIndex: 4876
	{
		// Fields
		public float m_previousFrameZoom; // 0x10

		// Constructors
		public VcamExtraState() {} // 0x007893D0-0x007893E0
	}

	// Constructors
	public PegaCM_AutoDolly() {} // 0x00789350-0x007893D0

	// Methods
	private void OnValidate() {} // 0x00788FB0-0x00788FC0
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x00788FC0-0x00789350
}

