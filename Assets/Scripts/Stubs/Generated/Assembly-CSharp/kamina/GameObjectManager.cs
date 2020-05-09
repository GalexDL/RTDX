/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina
{
	[ExecuteInEditMode] // 0x0060B160-0x0060B170
	public class GameObjectManager : SingletonMonoBehaviour<kamina.GameObjectManager> // TypeDefIndex: 8367
	{
		// Fields
		private List<Frame> listFrame_; // 0x18
		private Frame[] aNativeFrame_; // 0x20
		private List<Frame> listSelfDestroy_; // 0x28
		private List<string> listDelayDestroyAssetBundle_; // 0x30
		private List<string> listDelayDestroyAssetBundleTemp_; // 0x38
		private Vector3 vDistanceCullingTarget_; // 0x40
		private int nLoadRequestCounter_; // 0x4C
		private Dictionary<string, ModelResourceInfo> aCacheResourceInfoList_; // 0x50
		private BMEffect bgEffect_; // 0x58
		private Texture2D m_gridTexture; // 0x60
		private GameObject m_root; // 0x68
		private GameObject m_fukidashi2dRoot; // 0x70
		private bool m_bFukidashiRootActive; // 0x78
		private Color m_GlobalShadowColor; // 0x7C
		private bool m_bGlobalShadowColorDirtyFlag; // 0x8C
		private bool m_bCutSceneProduction; // 0x8D
		private bool m_bForceColorChange; // 0x8E
		private bool m_bModelInfoCacheClearTargetMode; // 0x8F
		private uint m_updateCounter; // 0x90
		private List<Frame> aTempUpdateList_; // 0x98
		private List<CharacterModel> aProductionAllColorChangeList_; // 0xA0
	
		// Properties
		public uint UpdateCounter { get => default; } // 0x00B7E5C0-0x00B7E5D0 
		public bool IsCutSceneProduction { get => default; } // 0x00B7E5D0-0x00B7E5E0 
	
		// Nested types
		public class ModelResourceInfo // TypeDefIndex: 8368
		{
			// Fields
			private List<ModelInfo> aModelInfo_; // 0x10
			private List<AnimationInfo> aAnimationInfo_; // 0x18
			private bool bClearTarget_; // 0x20
	
			// Properties
			public bool ClearTarget { get => default; } // 0x00B7FC80-0x00B7FC90 
			public List<ModelInfo> ModelInfoList { get => default; } // 0x00B82740-0x00B82750 
			public List<AnimationInfo> AnimationInfoList { get => default; } // 0x00B82750-0x00B829C0 
	
			// Nested types
			public struct ModelInfo // TypeDefIndex: 8369
			{
				// Fields
				public string file; // 0x10
	
				// Constructors
				public ModelInfo(string _file) {
					file = default;
				} // 0x00B82A60-0x00B82A70
			}
	
			public struct AnimationInfo // TypeDefIndex: 8370
			{
				// Fields
				public string symbol; // 0x10
				public string partsSymbol; // 0x18
				public string key; // 0x20
				public string skeletal; // 0x28
				public string material; // 0x30
	
				// Constructors
				public AnimationInfo(string _symbol, string _skeletal, string _material) {
					symbol = default;
					partsSymbol = default;
					key = default;
					skeletal = default;
					material = default;
				} // 0x00B829C0-0x00B82A60
			}
	
			// Constructors
			public ModelResourceInfo() {} // 0x00B7F2C0-0x00B7F360
	
			// Methods
			public void Analyze(byte[] aBuffer) {} // 0x00B7F360-0x00B7F5E0
		}
	
		public class AnimationClipResourceInfo // TypeDefIndex: 8371
		{
			// Fields
			public string parts; // 0x10
			public string key; // 0x18
			public AnimationClip clip; // 0x20
	
			// Constructors
			public AnimationClipResourceInfo() {} // 0x00B807D0-0x00B80830
		}
	
		// Constructors
		public GameObjectManager() {} // 0x00B82180-0x00B82380
	
		// Methods
		public void CreateCommonGridTexture() {} // 0x00B7E5E0-0x00B7E6B0
		public void ClearPixelCommonGridTexture() {} // 0x00B7E6B0-0x00B7E760
		public Texture2D GetCommonGridTexture() => default; // 0x00B7E760-0x00B7E770
		private void OnEnable() {} // 0x00B7E770-0x00B7E8D0
		private void OnDisable() {} // 0x00B7E8D0-0x00B7E990
		private void OnApplicationQuit() {} // 0x00B7E990-0x00B7E9A0
		public void SetupFukidashi2d() {} // 0x00B7E9A0-0x00B7EA60
		public void ShutdownFukidashi2d() {} // 0x00B7EA60-0x00B7EB20
		public Transform GetRootTransform() => default; // 0x00B7E3D0-0x00B7E3E0
		public Transform GetFukidashi2dRootTransform() => default; // 0x00B7EB20-0x00B7EB30
		public void SetModelInfoCacheClearTargetMode(bool bEnable) {} // 0x00B7EB30-0x00B7EB40
		public bool IsModelInfoCacheClearTargetMode() => default; // 0x00B7EB40-0x00B7EB50
		public void SetRootVisible(bool bVisible) {} // 0x00B7EB50-0x00B7ECD0
		private string ConvertFileName(string path) => default; // 0x00B7ECD0-0x00B7ED40
		public void LoadRequest(string path, NativeResourceHandle nativeHandle, Action loadedCb = null) {} // 0x00B7ED40-0x00B7EF50
		public void LoadModelResourceInfoForManpu(string fileBase) {} // 0x00B7F0D0-0x00B7F2C0
		// [IteratorStateMachine] // 0x0063B880-0x0063B8F0
		public IEnumerator AllWait() => default; // 0x00B7F5E0-0x00B7F650
		public bool IsExistModelResourceInfo(string path) => default; // 0x00B7F680-0x00B7F6E0
		public ModelResourceInfo GetModelResourceInfo(string fileName, string assetBundlePath) => default; // 0x00B7F6E0-0x00B7F940
		public void AddModelResourceInfo(string symbol, ModelResourceInfo info) {} // 0x00B7F940-0x00B7F9E0
		public void ClearModelResourceInfoCache() {} // 0x00B7F9E0-0x00B7FC80
		public void SetBGEffect(BMEffect effect) {} // 0x00B7FC90-0x00B7FCA0
		private GameObject CreateResourceGameObject(string path, string bundlePath, bool bAttachRoot) => default; // 0x00B7FCA0-0x00B7FFD0
		public GameObject CreateResourceGameObject(string path, string bundlePath) => default; // 0x00B7FFD0-0x00B7FFE0
		public GameObject CreateResourceGameObjectAndAttachRoot(string path, string bundlePath) => default; // 0x00B7FFE0-0x00B7FFF0
		public GameObject CreateEmptyGameObject(string name) => default; // 0x00B7FFF0-0x00B80090
		public void AddExistingGameObject(GameObject go) {} // 0x00B80090-0x00B800E0
		public bool DestroyResourceBundle(string bundlePath) => default; // 0x00B800E0-0x00B80230
		public void CleanupDestroyResourceGameObject() {} // 0x00B80230-0x00B80240
		public AnimationClipResourceInfo CreateResourceAnimationClip(string path, string _bundlePath) => default; // 0x00B80240-0x00B805E0
		public void ConvertResourceAnimationClip_PartsAndKey(string path, string _bundlePath, out string bundleName, out string bodyName, out string parts, out string key) {
			bundleName = default;
			bodyName = default;
			parts = default;
			key = default;
		} // 0x00B805E0-0x00B807D0
		public void DestroyResourceAnimationClip(string path) {} // 0x00B80830-0x00B80840
		public void CleanupDestroyResourceAnimationClip() {} // 0x00B80840-0x00B80850
		public void DestroyObject(GameObject obj) {} // 0x00B80850-0x00B80900
		public void SafeDestroyObject(ref GameObject obj) {} // 0x00B80900-0x00B809B0
		public void DestroyAnimationClip(AnimationClip clip, string stDestroyResourcePath = "" /* Metadata: 0x0061473B */) {} // 0x00B809B0-0x00B80A60
		public void AllDestroyEffect() {} // 0x00B80A60-0x00B80D10
		public void Register(Frame frame) {} // 0x00B7E1F0-0x00B7E2C0
		public void Unregister(Frame frame) {} // 0x00B7E4B0-0x00B7E540
		public Frame FindFromNativeControlId(int nativeControlId) => default; // 0x00B80D10-0x00B80DB0
		public void EntrySelfDestroy(Frame frame) {} // 0x00B7DF70-0x00B7DFD0
		public void SetGlobalShadowColor(Color color) {} // 0x00B80DB0-0x00B80DD0
		public List<T> GetObjectList<T>()
			where T : class => default;
		public void UpdateManual() {} // 0x00B80DD0-0x00B81270
		public void LateUpdateManual() {} // 0x00B81270-0x00B81590
		public void SetDistanceCullingTarget(Vector3 v) {} // 0x00B81590-0x00B815A0
		public Vector3 GetDistanceCullingTarget() => default; // 0x00B815A0-0x00B815B0
		public void SetAllCutProduction(bool bEnable) {} // 0x00B815B0-0x00B81720
		public void SetAllCircleShadowForOption(bool bEnable) {} // 0x00B81720-0x00B81880
		private List<CharacterModel> GetCharacterModelList() => default; // 0x00B81990-0x00B81B40
		public void BeginProductionAllColorChangeCharacterModel(List<Frame> ignoreList) {} // 0x00B81B40-0x00B81EA0
		public void EndProductionAllColorChangeCharacterModel() {} // 0x00B81EA0-0x00B81FD0
		public void AllColorChange(Color colorRate, float fSec) {} // 0x00B81FD0-0x00B820A0
		public bool IsAllColorChangeEnd() => default; // 0x00B820A0-0x00B82110
		public Color GetAllColorChangeColor() => default; // 0x00B82110-0x00B82180
	}
}
