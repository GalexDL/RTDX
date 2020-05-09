/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityBishamon.Native;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace UnityBishamon
{
	internal class NativePlugin // TypeDefIndex: 8933
	{
		// Fields
		private static CreateArgument m_create_argument; // 0x00
		private static RegisterTextureArgument m_register_texture_argument; // 0x48
		private static RegisterModelArgument m_register_model_argument; // 0x60
		private static RegisterBMBArgument m_register_bmb_argument; // 0x78
	
		// Constructors
		public NativePlugin() {} // 0x00B43780-0x00B43790
	
		// Methods
		private static byte[] GetByteArrayFromString(string text) => default; // 0x00B42EB0-0x00B42FA0
		public static void CameraClean() {} // 0x00B40460-0x00B40470
		public static void CameraFree(Camera camera) {} // 0x00B403B0-0x00B403D0
		public static bool Init(ref InitArgument arg) => default; // 0x00B3E020-0x00B3E040
		public static bool IsDeviceEnable() => default; // 0x00B42FA0-0x00B42FC0
		public static bool IsRenderingPeriod() => default; // 0x00B42FC0-0x00B42FE0
		public static IntPtr Create(TextAsset bmb, int resourceSpaceID) => default; // 0x00B3EE50-0x00B3F0A0
		public static IntPtr Create(TextAsset bmb, int resourceSpaceID, ref GenerateScale generateScale) => default; // 0x00B3F1F0-0x00B3F480
		public static int Destroy(IntPtr animHandle) => default; // 0x00B3E590-0x00B3E5C0
		public static void SetCameraEventMode(IntPtr animHandle, bool cameraEvent) {} // 0x00B3F0A0-0x00B3F0E0
		public static void Start(IntPtr animHandle) {} // 0x00B3F560-0x00B3F590
		public static void Pause(IntPtr animHandle) {} // 0x00B3F740-0x00B3F770
		public static void Pause(IntPtr animHandle, bool enableUpdateOnPause) {} // 0x00B3F840-0x00B3F880
		public static void Resum(IntPtr animHandle) {} // 0x00B3F950-0x00B3F980
		public static void Stop(IntPtr animHandle, bool forceFinish) {} // 0x00B3FA50-0x00B3FA90
		public static void Reset(IntPtr animHandle) {} // 0x00B3FB60-0x00B3FB90
		public static void SetActive(IntPtr animHandle, bool active) {} // 0x00B3FC60-0x00B3FCA0
		public static NativeDefine.EffectPhase GetPhase(IntPtr animHandle) => default; // 0x00B3FD80-0x00B3FDB0
		public static bool HasFinished(IntPtr animHandle) => default; // 0x00B3FEA0-0x00B3FEE0
		public static bool IsEnableUpdateOnPause(IntPtr animHandle) => default; // 0x00B3FFD0-0x00B40010
		public static void SetGenerateChildScale(IntPtr animHandle, NativeDefine.EmitterType emitterType, float scale) {} // 0x00B400F0-0x00B40140
		public static void RegisterTextures(List<Texture2D> textures, List<string> texture_names, int resourceSpaceID) {} // 0x00B3E6D0-0x00B3E9A0
		public static void RegisterModels(List<TextAsset> models, List<string> model_names, int resourceSpaceID) {} // 0x00B3E9A0-0x00B3EBF0
		[Obsolete] // 0x0063E3D0-0x0063E410
		public static void RegisterBMBs(List<TextAsset> refBMBs, List<string> refBMBNames, List<Texture2D> refBMBTextures, List<string> refBMBTextureNames, List<TextAsset> refBMBModels, List<string> refBMBModelNames, int resourceSpaceID) {} // 0x00B42FE0-0x00B43260
		public static void RegisterBMBs(BishamonEffect bmEffect, int resourceSpaceID) {} // 0x00B3EBF0-0x00B3EE50
		public static void SetPriorityFromCamera(IntPtr animHandle, ref PriorityFromCameraArgument arg) {} // 0x00B40600-0x00B40640
		public static void Update(IntPtr animHandle, ref UpdateArgument arg) {} // 0x00B40CB0-0x00B40CF0
		public static void UpdateWithMakeVertex(IntPtr animHandle, ref UpdateArgument arg) {} // 0x00B40C70-0x00B40CB0
		public static void MakeVertex(IntPtr animHandle, ref MakeVertexArgument arg) {} // 0x00B40E70-0x00B40EB0
		public static bool IsDeltaTimeZeroRequiresMakeVertex(IntPtr animHandle) => default; // 0x00B40FA0-0x00B40FE0
		public static bool IsResourceSetupComplete(IntPtr animHandle) => default; // 0x00B410D0-0x00B41110
		public static int SetCameraParam(ref CameraArgument arg) => default; // 0x00B41AE0-0x00B41AF0
		public static void DirectInitializeEvent(int eventID) {} // 0x00B43260-0x00B43270
		public static void DirectUpdateEvent(int eventID) {} // 0x00B43270-0x00B43280
		public static void DirectDestroyEvent(int eventID) {} // 0x00B43280-0x00B43290
		public static void DirectDestroyAllEvent(int eventID) {} // 0x00B43290-0x00B432A0
		public static void DirectCleanUpPluginEvent(int eventID) {} // 0x00B432A0-0x00B432B0
		public static IntPtr GetInitializeEventFunc() => default; // 0x00B3E060-0x00B3E070
		public static IntPtr GetUpdateEventFunc() => default; // 0x00B42510-0x00B42520
		public static IntPtr GetRenderEventFunc() => default; // 0x00B414A0-0x00B414B0
		public static IntPtr GetBeforeImageEffectsRenderEventFunc() => default; // 0x00B414B0-0x00B414C0
		public static IntPtr GetDestroyEventFunc() => default; // 0x00B3E5C0-0x00B3E5D0
		public static IntPtr GetDestroyAllEventFunc() => default; // 0x00B42450-0x00B42460
		public static IntPtr GetCleanUpPluginEventFunc() => default; // 0x00B3E040-0x00B3E050
		public static int GetRootUserDataSize(IntPtr animHandle) => default; // 0x00B432B0-0x00B432E0
		public static string GetRootUserDataName(IntPtr animHandle, int index) => default; // 0x00B432E0-0x00B433A0
		public static NativeDefine.UserDataType GetRootUserDataType(IntPtr animHandle, int index) => default; // 0x00B433A0-0x00B433E0
		public static int GetRootUserDataMemberAsInt(IntPtr animHandle, int index) => default; // 0x00B433E0-0x00B43420
		public static float GetRootUserDataMemberAsFloat(IntPtr animHandle, int index) => default; // 0x00B43420-0x00B43460
		public static bool GetRootUserDataMemberAsBool(IntPtr animHandle, int index) => default; // 0x00B43460-0x00B434A0
		public static string GetRootUserDataMemberAsString(IntPtr animHandle, int index) => default; // 0x00B434A0-0x00B43560
		public static float[] GetRootUserDataMemberAsVector(IntPtr animHandle, int index) => default; // 0x00B43560-0x00B43630
		public static float[] GetRootUserDataMemberAsColor(IntPtr animHandle, int index) => default; // 0x00B43630-0x00B43700
		public static void GetRuntimeStats(ref RuntimeStatsArgument arg) {} // 0x00B401E0-0x00B401F0
		public static void GetErrorStats(IntPtr animHandle, ref ErrorStatusArgument arg) {} // 0x00B43700-0x00B43740
		public static void FrameFinishedEvent() {} // 0x00B43740-0x00B43750
		public static void UpdateThreadStart() {} // 0x00B3E050-0x00B3E060
		public static void UpdateThreadEnd() {} // 0x00B43750-0x00B43760
		public static void UpdateWithDrawOnCPUThreadStart() {} // 0x00B43760-0x00B43770
		public static void UpdateWithDrawOnCPUThreadEnd() {} // 0x00B43770-0x00B43780
		public static void RegisterPlugin() {} // 0x00B3E010-0x00B3E020
	}
}
