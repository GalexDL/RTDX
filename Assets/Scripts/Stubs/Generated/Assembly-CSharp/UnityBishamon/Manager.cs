/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityBishamon.Native;
using UnityEngine;
using UnityEngine.Rendering;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace UnityBishamon
{
	public class Manager : MonoBehaviour // TypeDefIndex: 8926
	{
		// Fields
		public static readonly string bishamonViewManagerName; // 0x00
		private static bool m_pluginEnable; // 0x08
		private static GameObject m_instance; // 0x10
		private static Manager m_manager; // 0x18
		private static InitArgument m_init_argument; // 0x20
		private static ulong m_heapSize; // 0x48
		private const uint kRingBufferCount = 3; // Metadata: 0x00630D8F
		private static ulong m_constantBufferSize; // 0x50
		private static uint m_cameraCount; // 0x58
		private static uint m_handleCapacity; // 0x5C
		private static readonly uint m_ImmutableBufferSize; // 0x60
		private static readonly uint m_DynamicBufferSize; // 0x64
		private static readonly uint m_CommandMemorySize; // 0x68
		private static readonly uint m_ControlMemorySize; // 0x6C
		private static bool m_dont_destroy; // 0x70
		private static PriorityFromCameraArgument m_priority_from_camera_argument; // 0x74
		private static Quaternion m_localRotate; // 0xB8
		private static Quaternion m_eqx; // 0xC8
		private static Quaternion m_eqy; // 0xD8
		private static Quaternion m_eqz; // 0xE8
		private static UnityEngine.Matrix4x4 m_localMatrix; // 0xF8
		private static UnityEngine.Matrix4x4 m_worldMatrix; // 0x138
		private static UnityEngine.Matrix4x4 m_effectMatrix; // 0x178
		private static UpdateArgument m_update_argument; // 0x1B8
		private static MakeVertexArgument m_make_vertex_argument; // 0x264
		private static readonly UnityEngine.Vector3 default_light_direction; // 0x2A4
		private static readonly UnityEngine.Vector3 default_light_color; // 0x2B0
		private static CameraArgument m_camera_argument; // 0x2C0
		private static bool bWarnMaaaLog_; // 0x420
		private static IntPtr m_renderEventFuncPtr; // 0x428
		private static IntPtr m_beforeImageEffectsRenderEventFuncPtr; // 0x430
		private static BishamonCameraPlugin m_bishamonCameraPlugin; // 0x438
		private static Camera m_cameraPlugin; // 0x440
		private const CameraEvent k_effects_render_pass = CameraEvent.BeforeImageEffects; // Metadata: 0x00630D93
		private static readonly Dictionary<Camera, CommandBuffer> m_effects; // 0x448
	
		// Properties
		public static bool ManualUpdateMode { get; set; } // 0x00B42590-0x00B42600 0x00B42520-0x00B42590
	
		// Nested types
		public enum CameraEventMode // TypeDefIndex: 8927
		{
			Default = 0,
			OnRenderObject = 1
		}
	
		// Constructors
		public Manager() {} // 0x00B42CE0-0x00B42CF0
		static Manager() {} // 0x00B42CF0-0x00B42EB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x0063E390-0x0063E3B0
		private static void RuntimeInitialized() {} // 0x00B3D4B0-0x00B3D4C0
		public static bool IsCameraEventModeEnable() => default; // 0x00B3D4C0-0x00B3D4D0
		public static bool IsPluginEnable() => default; // 0x00B3D4D0-0x00B3D540
		public static bool IsInstanceEnable() => default; // 0x00B3D540-0x00B3D5E0
		public static GameObject GetGameObject() => default; // 0x00B3D5E0-0x00B3D650
		public static Manager GetManager() => default; // 0x00B3D650-0x00B3D6C0
		private static void Mat44ToArray(UnityEngine.Matrix4x4 m, float[] dst_m) {} // 0x00B3D6C0-0x00B3DA20
		private static void Vec4ToArray(UnityEngine.Vector4 v, float[] dst_v) {} // 0x00B3DA20-0x00B3DB20
		private static void Vec3ToArray(ref UnityEngine.Vector4 v, float[] dst_v) {} // 0x00B3DB20-0x00B3DBE0
		public static void SetConstantBufferSize(ulong size) {} // 0x00B3DBE0-0x00B3DC50
		public static void SetHeapSize(ulong size) {} // 0x00B3DC50-0x00B3DCC0
		public static void SetHandleCapacity(uint capacity) {} // 0x00B3DCC0-0x00B3DD30
		public static void SetCameraCount(uint count) {} // 0x00B3DD30-0x00B3DDA0
		public static bool HasInitializedPlugin() => default; // 0x00B3DDA0-0x00B3E010
		public static bool IsDontDestroy() => default; // 0x00B3E070-0x00B3E0E0
		public static bool DontDestroy() => default; // 0x00B3E0E0-0x00B3E260
		public static void NotifyAwake() {} // 0x00B3E260-0x00B3E470
		public static void NotifyDestroy(BishamonEffect bmEffect) {} // 0x00B3E470-0x00B3E590
		public static IntPtr CreateEffect(BishamonEffect bmEffect, int resourceSpaceID = 1 /* Metadata: 0x00630D85 */) => default; // 0x00B3E5D0-0x00B3E6D0
		public static IntPtr CreateEffect(BishamonEffect bmEffect, ref GenerateScale generateScale, int resourceSpaceID = 1 /* Metadata: 0x00630D89 */) => default; // 0x00B3F0E0-0x00B3F1F0
		public static void StartEffect(BishamonEffect bmEffect) {} // 0x00B3F480-0x00B3F560
		public static void StartEffect(BishamonEffect bmEffect, ref GenerateScale generateScale) {} // 0x00B3F590-0x00B3F670
		public static void PauseEffect(BishamonEffect bmEffect) {} // 0x00B3F670-0x00B3F740
		public static void PauseEffect(BishamonEffect bmEffect, bool enableUpdateOnPause) {} // 0x00B3F770-0x00B3F840
		public static void ResumeEffect(BishamonEffect bmEffect) {} // 0x00B3F880-0x00B3F950
		public static void StopEffect(BishamonEffect bmEffect, bool forceFinish = false /* Metadata: 0x00630D8D */) {} // 0x00B3F980-0x00B3FA50
		public static void ResetEffect(BishamonEffect bmEffect) {} // 0x00B3FA90-0x00B3FB60
		public static void SetActive(BishamonEffect bmEffect, bool active) {} // 0x00B3FB90-0x00B3FC60
		public static NativeDefine.EffectPhase GetEffectPhase(BishamonEffect bmEffect) => default; // 0x00B3FCA0-0x00B3FD80
		public static bool HasFinished(BishamonEffect bmEffect) => default; // 0x00B3FDB0-0x00B3FEA0
		public static bool IsEnableUpdateOnPause(BishamonEffect bmEffect) => default; // 0x00B3FEE0-0x00B3FFD0
		public static void SetGenerateChildScale(BishamonEffect bmEffect, NativeDefine.EmitterType emitterType, float scale) {} // 0x00B40010-0x00B400F0
		public static bool GetRuntimeStats(ref RuntimeStatsArgument arg) => default; // 0x00B40140-0x00B401E0
		public static bool GetErrorStats(BishamonEffect bmEffect, ref ErrorStatusArgument arg) => default; // 0x00B401F0-0x00B40200
		private static void TransformationCoordinate(ref UnityBishamon.Native.Matrix4x4 camera_matrix) {} // 0x00B40200-0x00B40230
		private static void GetCameraMatrix(Camera camera, ref UnityBishamon.Native.Matrix4x4 camera_matrix) {} // 0x00B40230-0x00B402E0
		public static void CameraFree(Camera camera) {} // 0x00B402E0-0x00B403B0
		public static void CameraClean() {} // 0x00B403D0-0x00B40460
		public static void SetPriorityFromCamera(Camera camera, BishamonEffect bmEffect) {} // 0x00B40470-0x00B40600
		public static void UpdateEffect(Camera camera, BishamonEffect bmEffect, float deltaTime, bool callWithPreRender = false /* Metadata: 0x00630D8E */) {} // 0x00B40640-0x00B40C70
		public static void MakeVertexEffect(Camera camera, BishamonEffect bmEffect) {} // 0x00B40CF0-0x00B40E70
		public static bool IsDeltaTimeZeroRequiresMakeVertex(BishamonEffect bmEffect) => default; // 0x00B40EB0-0x00B40FA0
		public static bool IsResourceSetupComplete(BishamonEffect bmEffect) => default; // 0x00B40FE0-0x00B410D0
		private static void SetLightParam(Light light) {} // 0x00B41110-0x00B41410
		private static void LoadRenderEventFunc() {} // 0x00B41410-0x00B414A0
		private void DrawAllEffect(Camera targetCamera) {} // 0x00B414C0-0x00B41AE0
		public static BishamonCameraPlugin GetCameraPlugin() => default; // 0x00B41AF0-0x00B41B60
		public static void SetCameraPlugin(BishamonCameraPlugin plugin, Camera camera) {} // 0x00B41B60-0x00B41BE0
		public static bool IsIgnore(Camera targetCamera) => default; // 0x00B41BE0-0x00B41CD0
		private void RemoveCommandBuffer() {} // 0x00B41CD0-0x00B41F10
		private void Awake() {} // 0x00B41F10-0x00B42010
		private void Start() {} // 0x00B42010-0x00B42020
		private void OnEnable() {} // 0x00B42020-0x00B42150
		private void OnDisable() {} // 0x00B42150-0x00B422C0
		private void OnApplicationQuit() {} // 0x00B422C0-0x00B42390
		private void OnDestroy() {} // 0x00B42390-0x00B42450
		private void PrivateNativeUpdate(int eventID) {} // 0x00B42460-0x00B42510
		private void Update() {} // 0x00B42600-0x00B42750
		private void LateUpdate() {} // 0x00B42750-0x00B428A0
		public void UpdateManual() {} // 0x00B428A0-0x00B42A00
		public void LateUpdateManual() {} // 0x00B42A00-0x00B42B60
		private void PrivatePreRender(Camera targetCamera) {} // 0x00B42B60-0x00B42C00
		private void OnRenderObject() {} // 0x00B42C00-0x00B42CE0
	}
}
