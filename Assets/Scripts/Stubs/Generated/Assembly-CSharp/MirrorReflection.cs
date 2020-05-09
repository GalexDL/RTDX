/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A310-0x0060A320
public class MirrorReflection : MonoBehaviour // TypeDefIndex: 6111
{
	// Fields
	public bool m_DisablePixelLights; // 0x18
	public int m_TextureSize; // 0x1C
	public float m_ClipPlaneOffset; // 0x20
	public LayerMask m_ReflectLayers; // 0x24
	private Hashtable m_ReflectionCameras; // 0x28
	private RenderTexture m_ReflectionTexture; // 0x30
	private int m_OldReflectionTextureSize; // 0x38
	private static bool s_InsideRendering; // 0x00

	// Constructors
	public MirrorReflection() {} // 0x00E34360-0x00E343F0
	static MirrorReflection() {} // 0x00E343F0-0x00E34400

	// Methods
	public void OnWillRenderObject() {} // 0x00E32BC0-0x00E33270
	private void OnDisable() {} // 0x00E34010-0x00E34340
	private void UpdateCameraModes(Camera src, Camera dest) {} // 0x00E33870-0x00E33B50
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera) {
		reflectionCamera = default;
	} // 0x00E33270-0x00E33870
	private static float sgn(float a) => default; // 0x00E34340-0x00E34360
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) => default; // 0x00E33E00-0x00E34010
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) {} // 0x00E33B50-0x00E33E00
}

