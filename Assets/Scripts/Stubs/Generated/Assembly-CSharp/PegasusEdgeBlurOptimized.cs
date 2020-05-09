/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00609300-0x006093A0
[ExecuteInEditMode] // 0x00609300-0x006093A0
// [RequireComponent] // 0x00609300-0x006093A0
public class PegasusEdgeBlurOptimized : PostEffectsBase // TypeDefIndex: 4858
{
	// Fields
	// [Range] // 0x00616160-0x00616180
	public int downsample; // 0x1C
	// [Range] // 0x00616180-0x006161A0
	public float blurSize; // 0x20
	// [Range] // 0x006161A0-0x006161C0
	public int blurIterations; // 0x24
	public BlurType blurType; // 0x28
	public Shader blurShader; // 0x30
	public bool ResolutionChangeMode; // 0x38
	private Material blurMaterial; // 0x40
	private bool bIsChecked_; // 0x48
	[NonSerialized]
	public bool isForceOFF; // 0x49
	[NonSerialized]
	public bool isBlurModeV2; // 0x4A
	// [Range] // 0x006161C0-0x00616210
	[SerializeField] // 0x006161C0-0x00616210
	private float _blurGaussV2; // 0x4C
	private const int SampleCount = 15; // Metadata: 0x00610BB0
	private const int SamplingCountOpt = 8; // Metadata: 0x00610BB4
	private float[] _weights; // 0x50
	private float[] _weightsOpt; // 0x58
	private float[] _offsetsOpt; // 0x60
	private float _prevBlurGaussV2; // 0x68

	// Nested types
	public enum BlurType // TypeDefIndex: 4859
	{
		StandardGauss = 0,
		SgxGauss = 1
	}

	// Constructors
	public PegasusEdgeBlurOptimized() {} // 0x00B6AFE0-0x00B6B090

	// Methods
	public override bool CheckResources() => default; // 0x00B69B40-0x00B69BD0
	public void OnDisable() {} // 0x00B69BD0-0x00B69C90
	[ImageEffectOpaque] // 0x0061C270-0x0061C280
	public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00B69C90-0x00B69E20
	private void UpdateGaussianWeights_() {} // 0x00B6AC40-0x00B6AFE0
	public void OnRenderImage_NormalV2(RenderTexture source, RenderTexture destination) {} // 0x00B6A5A0-0x00B6A930
	public void OnRenderImage_ResolutionChangeModeV2(RenderTexture source, RenderTexture destination) {} // 0x00B69E20-0x00B6A250
	public void OnRenderImage_Normal(RenderTexture source, RenderTexture destination) {} // 0x00B6A930-0x00B6AC40
	public void OnRenderImage_ResolutionChangeMode(RenderTexture source, RenderTexture destination) {} // 0x00B6A250-0x00B6A5A0
}

