/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x00608610-0x00608690
// [RequireComponent] // 0x00608610-0x00608690
public class DepthOfField : MonoBehaviour // TypeDefIndex: 4350
{
	// Fields
	public Transform focus; // 0x18
	public float focalDistance; // 0x20
	public float aperture; // 0x24
	public bool debug; // 0x28
	public DdpBloom ddpBloom; // 0x30
	// [Range] // 0x00615B80-0x00615BA0
	public int downsampleFactor; // 0x38
	public Shader shader; // 0x40
	[HideInInspector] // 0x00615BA0-0x00615BB0
	public Material material; // 0x48
	private Camera cachedCamera; // 0x50
	private RenderTexture srcTarget; // 0x58

	// Constructors
	public DepthOfField() {} // 0x009938A0-0x009938C0

	// Methods
	private RenderTexture GetTemporaryTexture(int width, int height) => default; // 0x009930D0-0x00993140
	private void Awake() {} // 0x00993140-0x009931B0
	private void Start() {} // 0x009931B0-0x009931C0
	public void OnPreRenderFromMainCamera() {} // 0x009931C0-0x00993210
	public bool OnPostRenderFromMainCamera(RenderTexture src, RenderTexture dest) => default; // 0x00993210-0x009938A0
}

