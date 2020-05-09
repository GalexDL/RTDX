/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityBishamon;
using UnityBishamon.Native;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00608740-0x00608790
[DisallowMultipleComponent] // 0x00608740-0x00608790
public class BishamonEffect : MonoBehaviour // TypeDefIndex: 4362
{
	// Fields
	public TextAsset BmbAsset; // 0x18
	public List<Texture2D> textures; // 0x20
	public List<string> texture_names; // 0x28
	public List<TextAsset> models; // 0x30
	public List<string> model_names; // 0x38
	public List<TextAsset> refBMBs; // 0x40
	public List<string> refBMBNames; // 0x48
	public List<Texture2D> refBMBTextures; // 0x50
	public List<string> refBMBTextureNames; // 0x58
	public List<TextAsset> refBMBModels; // 0x60
	public List<string> refBMBModelNames; // 0x68
	public bool IsLoop; // 0x70
	public bool autoRun; // 0x71
	public float frameRate; // 0x74
	public float universalScale; // 0x78
	public UnityEngine.Vector4 ColorScale; // 0x7C
	public UnityEngine.Vector3 OffsetPosition; // 0x8C
	public UnityEngine.Vector3 EffecttScale; // 0x98
	public UnityEngine.Vector3 EffectRotation; // 0xA4
	public UnityEngine.Vector3 EffectTranslation; // 0xB0
	public bool displaysModels; // 0xBC
	public bool displayTextures; // 0xBD
	public bool displaysRefBMBs; // 0xBE
	public int resourceSpaceID; // 0xC0
	public static readonly string defaultDatabasePath; // 0x00
	public string databasePath; // 0xC8
	public IntPtr animHandle; // 0xD0
	public DeltaTimeMode deltaTimeMode; // 0xD8
	public Manager.CameraEventMode cameraEventMode; // 0xDC
	public GenerateScale generateScaleParam; // 0xE0
	private float deltaTimeAccumulation; // 0x110

	// Nested types
	public enum DeltaTimeMode // TypeDefIndex: 4363
	{
		Normal = 0,
		UnscaledTime = 1,
		FixedTime = 2
	}

	// Constructors
	private BishamonEffect() {} // 0x008BEF00-0x008BF1E0
	static BishamonEffect() {} // 0x008C0410-0x008C0470

	// Methods
	public void StartEffect() {} // 0x008BF1E0-0x008BF250
	public void StartEffect(ref GenerateScale generateScale) {} // 0x008BF250-0x008BF2D0
	public void PauseEffect() {} // 0x008BF2D0-0x008BF370
	public void PauseEffect(bool enableUpdateOnPause) {} // 0x008BF370-0x008BF430
	public void ResumeEffect() {} // 0x008BF430-0x008BF4D0
	public void StopEffect(bool forceFinish = false /* Metadata: 0x00610787 */) {} // 0x008BF4D0-0x008BF550
	public void ResetEffect() {} // 0x008BF550-0x008BF5C0
	public bool HasReadied() => default; // 0x008BF5C0-0x008BF610
	public bool IsBeforeStart() => default; // 0x008BF610-0x008BF6D0
	public bool HasPaused() => default; // 0x008BF6D0-0x008BF790
	public bool HasFinished() => default; // 0x008BF790-0x008BF800
	public bool IsPlaying() => default; // 0x008BF800-0x008BF8D0
	public void SetGenerateChildScale(NativeDefine.EmitterType emitterType, float scale) {} // 0x008BF8D0-0x008BF960
	private float GetDeltaTime(float time_value) => default; // 0x008BF960-0x008BFA50
	public void ClearResource() {} // 0x008BFA50-0x008BFAE0
	public void SetDeltaTimeAccumulation(float time) {} // 0x008BFAE0-0x008BFAF0
	public int GetResourceSpaceID() => default; // 0x008BFAF0-0x008BFB00
	public void SetResourceSpaceID(int num) {} // 0x008BFB00-0x008BFB10
	public void SetResourceSpaceID(AssetBundle assetBundle) {} // 0x008BFB10-0x008BFB40
	public void SetResourceSpaceID(Scene scene) {} // 0x008BFB40-0x008BFB70
	public void Create() {} // 0x008BFB70-0x008BFC50
	public void Create(ref GenerateScale generateScale) {} // 0x008BFC50-0x008BFD40
	public void Awake() {} // 0x008BFD40-0x008BFDC0
	public void Start() {} // 0x008BFDC0-0x008BFE50
	public void OnDestroy() {} // 0x008BFE50-0x008BFEC0
	private void PrivatePreRender(Camera currentCamera) {} // 0x008BFEC0-0x008C00C0
	public void Update() {} // 0x008C00C0-0x008C0150
	public void OnEnable() {} // 0x008C0150-0x008C02B0
	public void OnDisable() {} // 0x008C02B0-0x008C0410
}

