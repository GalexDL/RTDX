/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmplifyColor;
using UnityEngine;
using UnityEngine.Serialization;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00608260-0x00608300
[ExecuteInEditMode] // 0x00608260-0x00608300
// [RequireComponent] // 0x00608260-0x00608300
public class AmplifyColorRenderMaskBase : MonoBehaviour // TypeDefIndex: 4343
{
	// Fields
	// [FormerlySerializedAs] // 0x00615AB0-0x00615AF0
	public Color ClearColor; // 0x18
	// [FormerlySerializedAs] // 0x00615AF0-0x00615B30
	public RenderLayer[] RenderLayers; // 0x28
	// [FormerlySerializedAs] // 0x00615B30-0x00615B70
	public bool DebugMask; // 0x30
	private Camera referenceCamera; // 0x38
	private Camera maskCamera; // 0x40
	private AmplifyColorBase colorEffect; // 0x48
	private int width; // 0x50
	private int height; // 0x54
	private RenderTexture maskTexture; // 0x58
	private Shader colorMaskShader; // 0x60
	private bool singlePassStereo; // 0x68

	// Constructors
	public AmplifyColorRenderMaskBase() {} // 0x00863D80-0x00863E00

	// Methods
	private void OnEnable() {} // 0x00863E00-0x00864000
	private void OnDisable() {} // 0x00864000-0x00864030
	private void DestroyCamera() {} // 0x00864030-0x008640F0
	private void DestroyRenderTextures() {} // 0x008640F0-0x008641B0
	private void UpdateRenderTextures(bool singlePassStereo) {} // 0x008641B0-0x008643E0
	private void UpdateCameraProperties() {} // 0x008643E0-0x008644B0
	private void OnPreRender() {} // 0x008644B0-0x008646C0
}

