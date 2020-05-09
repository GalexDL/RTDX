/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmplifyColor;
using UnityEngine;
using UnityEngine.Serialization;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x006080F0-0x00608130
public class AmplifyColorBase : MonoBehaviour // TypeDefIndex: 4340
{
	// Fields
	public const int LutSize = 32; // Metadata: 0x00610776
	public const int LutWidth = 1024; // Metadata: 0x0061077A
	public const int LutHeight = 32; // Metadata: 0x0061077E
	private const int DepthCurveLutRange = 1024; // Metadata: 0x00610782
	public Tonemapping Tonemapper; // 0x18
	public float Exposure; // 0x1C
	public float LinearWhitePoint; // 0x20
	// [FormerlySerializedAs] // 0x00615A20-0x00615A60
	public bool ApplyDithering; // 0x24
	public Quality QualityLevel; // 0x28
	public float BlendAmount; // 0x2C
	public Texture LutTexture; // 0x30
	public Texture LutBlendTexture; // 0x38
	public Texture MaskTexture; // 0x40
	public bool UseDepthMask; // 0x48
	public AnimationCurve DepthMaskCurve; // 0x50
	public bool UseVolumes; // 0x58
	public float ExitVolumeBlendTime; // 0x5C
	public Transform TriggerVolumeProxy; // 0x60
	public LayerMask VolumeCollisionMask; // 0x68
	private Camera ownerCamera; // 0x70
	private Shader shaderBase; // 0x78
	private Shader shaderBlend; // 0x80
	private Shader shaderBlendCache; // 0x88
	private Shader shaderMask; // 0x90
	private Shader shaderMaskBlend; // 0x98
	private Shader shaderDepthMask; // 0xA0
	private Shader shaderDepthMaskBlend; // 0xA8
	private Shader shaderProcessOnly; // 0xB0
	private RenderTexture blendCacheLut; // 0xB8
	private Texture2D defaultLut; // 0xC0
	private Texture2D depthCurveLut; // 0xC8
	private Color32[] depthCurveColors; // 0xD0
	private ColorSpace colorSpace; // 0xD8
	private Quality qualityLevel; // 0xDC
	private Material materialBase; // 0xE0
	private Material materialBlend; // 0xE8
	private Material materialBlendCache; // 0xF0
	private Material materialMask; // 0xF8
	private Material materialMaskBlend; // 0x100
	private Material materialDepthMask; // 0x108
	private Material materialDepthMaskBlend; // 0x110
	private Material materialProcessOnly; // 0x118
	private bool blending; // 0x120
	private float blendingTime; // 0x124
	private float blendingTimeCountdown; // 0x128
	private Action onFinishBlend; // 0x130
	private AnimationCurve prevDepthMaskCurve; // 0x138
	private bool volumesBlending; // 0x140
	private float volumesBlendingTime; // 0x144
	private float volumesBlendingTimeCountdown; // 0x148
	private Texture volumesLutBlendTexture; // 0x150
	private float volumesBlendAmount; // 0x158
	private Texture worldLUT; // 0x160
	private AmplifyColorVolumeBase currentVolumeLut; // 0x168
	private RenderTexture midBlendLUT; // 0x170
	private bool blendingFromMidBlend; // 0x178
	private VolumeEffect worldVolumeEffects; // 0x180
	private VolumeEffect currentVolumeEffects; // 0x188
	private VolumeEffect blendVolumeEffects; // 0x190
	private float worldExposure; // 0x198
	private float currentExposure; // 0x19C
	private float blendExposure; // 0x1A0
	private float effectVolumesBlendAdjust; // 0x1A4
	private List<AmplifyColorVolumeBase> enteredVolumes; // 0x1A8
	private AmplifyColorTriggerProxyBase actualTriggerProxy; // 0x1B0
	[HideInInspector] // 0x00615A60-0x00615A70
	public VolumeEffectFlags EffectFlags; // 0x1B8
	[HideInInspector] // 0x00615A70-0x00615AB0
	[SerializeField] // 0x00615A70-0x00615AB0
	private string sharedInstanceID; // 0x1C0
	private bool silentError; // 0x1C8

	// Properties
	public Texture2D DefaultLut { get => default; } // 0x00860500-0x00860590 
	public bool IsBlending { get => default; } // 0x008607A0-0x008607B0 
	private float effectVolumesBlendAdjusted { get => default; } // 0x008607B0-0x00860850 
	public string SharedInstanceID { get => default; } // 0x0085F5C0-0x0085F5D0 
	public bool WillItBlend { get => default; } // 0x00860850-0x00860940 

	// Constructors
	public AmplifyColorBase() {} // 0x00863A70-0x00863CF0

	// Methods
	public void NewSharedInstanceID() {} // 0x00860940-0x008609D0
	private void ReportMissingShaders() {} // 0x008609D0-0x00860A50
	private void ReportNotSupported() {} // 0x00860A50-0x00860AD0
	private bool CheckShader(Shader s) => default; // 0x00860AD0-0x00860C30
	private bool CheckShaders() => default; // 0x00860C30-0x00860CB0
	private bool CheckSupport() => default; // 0x00860CB0-0x00860D60
	private void OnEnable() {} // 0x00860D60-0x00860F90
	private void OnDisable() {} // 0x008612A0-0x00861370
	private void VolumesBlendTo(Texture blendTargetLUT, float blendTimeInSec) {} // 0x008614E0-0x00861500
	public void BlendTo(Texture blendTargetLUT, float blendTimeInSec, Action onFinishBlend) {} // 0x00861500-0x00861520
	private void CheckCamera() {} // 0x00861520-0x008615F0
	private void Start() {} // 0x008615F0-0x00861650
	private void Update() {} // 0x00861650-0x00861A00
	public void EnterVolume(AmplifyColorVolumeBase volume) {} // 0x008622F0-0x00862380
	public void ExitVolume(AmplifyColorVolumeBase volume) {} // 0x00862380-0x00862410
	private void UpdateVolumes() {} // 0x00861A00-0x008622F0
	private void SetupShader() {} // 0x00862410-0x00862520
	private void ReleaseMaterials() {} // 0x00861370-0x00861440
	private Texture2D CreateDefaultLut() => default; // 0x00860590-0x008607A0
	private Texture2D CreateDepthCurveLut() => default; // 0x00862520-0x00862630
	private void UpdateDepthCurveLut() {} // 0x00862630-0x00862790
	private void CheckUpdateDepthCurveLut() {} // 0x00862790-0x00862940
	private void CreateHelperTextures() {} // 0x00862940-0x00862AE0
	private bool CheckMaterialAndShader(Material material, string name) => default; // 0x00862AE0-0x00862C60
	private bool CreateMaterials() => default; // 0x00860F90-0x008612A0
	private void SetMaterialKeyword(string keyword, bool state) {} // 0x00862C60-0x00862DD0
	private void SafeRelease<T>(ref T obj)
		where T : UnityEngine.Object {}
	private void ReleaseTextures() {} // 0x00861440-0x008614E0
	public static bool ValidateLutDimensions(Texture lut) => default; // 0x00862DD0-0x00862F30
	private void UpdatePostEffectParams() {} // 0x00862F30-0x00862FC0
	private int ComputeShaderPass() => default; // 0x00862FC0-0x00863050
	private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00863050-0x00863A70
}

