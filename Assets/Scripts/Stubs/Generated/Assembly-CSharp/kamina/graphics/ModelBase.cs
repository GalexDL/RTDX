/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina.graphics
{
	public class ModelBase : Frame // TypeDefIndex: 8381
	{
		// Fields
		protected ResourceCache.Resource m_resourceBndle; // 0x20
		protected UnityObjectMap m_dicRandomMapUnityObject; // 0x28
		protected BoneIdToUnityObjectArray m_aBoneIdToUnityObject; // 0x30
		protected NodeNameToBoneIdMap m_dicNodeNameToBoneIdMap; // 0x38
		protected BoneIdToBaseObjectMap m_dicNodeNameToBaseObjectMap; // 0x40
		protected GameObject m_gameObject; // 0x48
		protected GameObject m_transformObject; // 0x50
		protected GameObject m_offsetTransformObject; // 0x58
		protected List<Renderer> m_aRenderer; // 0x60
		protected List<List<uint>> m_aRendererMaterialHash; // 0x68
		protected List<Collider> m_aCollider; // 0x70
		protected List<GameObject> m_aMeshParentObject; // 0x78
		protected Dictionary<uint, Material> m_dicMaterialFromName; // 0x80
		protected Dictionary<int, Material> m_dicMaterialFromIID; // 0x88
		protected bool m_bSharedMaterial; // 0x90
		protected MaterialPropertyBlock m_materialPropertyBlock; // 0x98
		protected PegasusAnimationController m_animationController; // 0xA0
		protected DirtyFlag m_dirtyFlag; // 0xA8
		protected List<RequestAnimation> m_aPlayMotionList; // 0xB0
		protected string m_currentMotionKey; // 0xB8
		protected bool m_bCurrentMotionLoop; // 0xC0
		protected List<AttachParameter> m_aAttachList; // 0xC8
		protected Color m_multMaterialBaseColor; // 0xD0
		protected MoveColor m_multMaterialColorRate; // 0xE0
		protected Color m_finalMaterialVisibleColor; // 0xE8
		protected int m_nBoneIdCount; // 0xF8
		protected float m_fLastSpotDependentRate; // 0xFC
		protected string m_symbol; // 0x100
		protected string m_resourcePath; // 0x108
		protected string m_resourceBundlePath; // 0x110
		protected string m_nowAnimation; // 0x118
		protected Vector3 m_vPosition; // 0x120
		protected Vector3 m_vRotate; // 0x12C
		protected Vector3 m_vScale; // 0x138
		protected bool m_bOffsetNode; // 0x144
		protected bool m_bVisible; // 0x145
		protected bool m_bVisibled; // 0x146
		protected bool m_bAlphaVisibleOff; // 0x147
		protected bool m_bProductionForceVisibleOff; // 0x148
		protected bool m_bSpotVisibleOff; // 0x149
		protected bool m_bSpotVisibleOffMode; // 0x14A
		private bool m_bEffectiveAllMultMaterialColorRate; // 0x14B
		private bool m_bPrevEffectiveAllMultMaterialColorRate; // 0x14C
		private bool m_bGhostBlend; // 0x14D
		private bool m_bDitherBlend; // 0x14E
		private bool m_bBundleAutoDestory; // 0x14F
		private GraphicsSystem.LayerId m_defaultLayerId; // 0x154
		public static bool AllMultMaterialColorRateFlag; // 0x00
		public static MoveColor AllMultMaterialColorRate; // 0x08
		public static int GhostRenderCount; // 0x10
		private bool m_bMaterialPrpertyMode; // 0x158
		private bool m_bEnableNowFrameMaterialPrperty; // 0x159
		private bool m_bPrevEnableNowFrameMaterialPrperty; // 0x15A
	
		// Properties
		protected bool PopupHeightZero { get; set; } // 0x00B9A750-0x00B9A760 0x00B9A760-0x00B9A770
		public Transform TransformObject { get => default; } // 0x00B9A770-0x00B9A780 
		public bool IsValidOffsetTransform { get => default; } // 0x00B9A780-0x00B9A790 
		protected bool IsValidOffsetTransformObject { get => default; } // 0x00B9A790-0x00B9A800 
		protected Transform OffsetTransformObject { get => default; } // 0x00B9A800-0x00B9A810 
		public PegasusAnimationController AnimationController { get => default; } // 0x00B9A810-0x00B9A820 
		public bool EffectiveAllMultMaterialColorRate { set {} } // 0x00B9A820-0x00B9A830
		public bool PrevEffectiveAllMultMaterialColorRate { get => default; } // 0x00B9A830-0x00B9A840 
	
		// Nested types
		protected struct DirtyFlag // TypeDefIndex: 8382
		{
			// Fields
			public bool bVisible; // 0x10
			public bool bGhostBlend; // 0x11
			public bool bLayerId; // 0x12
			public bool bMaterialColor; // 0x13
			public bool bMaterialConditionColor; // 0x14
			public bool bMaterialAddColor; // 0x15
	
			// Methods
			public void Clear() {} // 0x00B9FF40-0x00B9FF50
		}
	
		protected struct RequestAnimation // TypeDefIndex: 8383
		{
			// Fields
			private string keyword; // 0x10
			private bool bLoop; // 0x18
		}
	
		public class NodeObject // TypeDefIndex: 8384
		{
			// Fields
			public GameObject refObj; // 0x10
			public GameObject baseObj; // 0x18
			public MeshFilter baseMeshFilter; // 0x20
			public GameObject combineObj; // 0x28
			public int localId; // 0x30
			public int boneId; // 0x34
			public int blockX; // 0x38
			public int blockY; // 0x3C
			public bool bCombineTarget; // 0x40
			public bool bHitParts; // 0x41
			public bool bVisible; // 0x42
			public bool bShadowTarget; // 0x43
			public bool bLinkParts; // 0x44
	
			// Constructors
			public NodeObject() {} // 0x00B9FF50-0x00BA0010
	
			// Methods
			public void Destroy() {} // 0x00B9CD60-0x00B9CE90
		}
	
		public class NodeNameToBoneIdMap : Dictionary<string, int> // TypeDefIndex: 8385
		{
			// Constructors
			public NodeNameToBoneIdMap() {} // 0x00B9B980-0x00B9B9D0
		}
	
		public class BoneIdToBaseObjectMap : Dictionary<int, GameObject> // TypeDefIndex: 8386
		{
			// Constructors
			public BoneIdToBaseObjectMap() {} // 0x00B9B9D0-0x00B9BA20
		}
	
		public class UnityObjectArray : List<GameObject> // TypeDefIndex: 8387
		{
			// Constructors
			public UnityObjectArray() {} // 0x00BA0010-0x00BA0080
		}
	
		public class BoneIdToUnityObjectArray : List<UnityObjectArray> // TypeDefIndex: 8388
		{
			// Constructors
			public BoneIdToUnityObjectArray() {} // 0x00B9B910-0x00B9B980
		}
	
		public class UnityObjectMap : Dictionary<int, NodeObject> // TypeDefIndex: 8389
		{
			// Constructors
			public UnityObjectMap() {} // 0x00B9B8C0-0x00B9B910
		}
	
		public class AttachParameter // TypeDefIndex: 8390
		{
			// Fields
			public string boneName; // 0x10
			public ModelBase attachModel; // 0x18
	
			// Constructors
			public AttachParameter() {} // 0x00B9FE70-0x00B9FF40
		}
	
		// Constructors
		public ModelBase() {} // Dummy constructor
		protected ModelBase(int nativeControlId, string symbol, string bundlePath, string resourcePath, bool bSharedMaterial, bool bOffsetNode, List<string> animationPartsList, bool bFilePrefab = false /* Metadata: 0x00614AEF */) {} // 0x00B9AAA0-0x00B9B8C0
		static ModelBase() {} // 0x00B9FBA0-0x00B9FC50
	
		// Methods
		public static void RequestLoadResource(string bundlePath, Action loadedCb = null) {} // 0x00B9A840-0x00B9A8D0
		public static bool IsLoadedResource(string bundlePath) => default; // 0x00B9A8D0-0x00B9A940
		// [IteratorStateMachine] // 0x0063B910-0x0063B980
		public static IEnumerator WaitLoadedResource(string bundlePath) => default; // 0x00B9A940-0x00B9A9B0
		public static IEnumerator AllWaitLoadResource() => default; // 0x00B9A9E0-0x00B9AAA0
		protected void SetBundleAutoDestroy(bool bEnable) {} // 0x00B9BA20-0x00B9BA30
		protected virtual bool IsMapModel() => default; // 0x00B9BB40-0x00B9BB50
		protected virtual bool IsCharacterModel() => default; // 0x00B9BB50-0x00B9BB60
		protected void GameObject_Destroy(UnityEngine.Object obj) {} // 0x00B9BB60-0x00B9BC00
		public override void Update() {} // 0x00B9BC00-0x00B9BCA0
		public override void LastUpdate() {} // 0x00B9BCA0-0x00B9C130
		protected override void OnTerminate() {} // 0x00B9C6E0-0x00B9CD60
		public void AttachRoot() {} // 0x00B9BA30-0x00B9BA80
		public void DetachRoot() {} // 0x00B9D020-0x00B9D050
		public void SetPosition(float x, float y, float z) {} // 0x00B99450-0x00B994D0
		public void SetOffsetPosition(float x, float y, float z) {} // 0x00B9D050-0x00B9D130
		public virtual void SetScale(float x, float y, float z) {} // 0x00B9D130-0x00B9D1B0
		public virtual Vector3 GetScale() => default; // 0x00B9D1B0-0x00B9D1C0
		public void SetRotate(float x, float y, float z) {} // 0x00B994D0-0x00B99550
		public void SetMaterialBaseColor(float r, float g, float b, float a) {} // 0x00B99550-0x00B995A0
		public void SetMaterialBaseColor(Color color) {} // 0x00B9D1C0-0x00B9D210
		public void SetMaterialColorRate(Color scale) {} // 0x00B9D210-0x00B9D220
		public void SetMaterialColorRateLinear(Color scale, float fSec) {} // 0x00B9D220-0x00B9D270
		public virtual void SetMaterialColorRate(float r, float g, float b, float a) {} // 0x00B9D270-0x00B9D320
		public Color GetMaterialColorRate() => default; // 0x00B9D320-0x00B9D330
		public virtual void SetVisible(bool bVisible) {} // 0x00B9D330-0x00B9D360
		private void SetProductionVisibleOff(bool bVisible) {} // 0x00B9C130-0x00B9C160
		public bool IsVisible() => default; // 0x00B9D360-0x00B9D370
		public bool IsVisibled() => default; // 0x00B9D370-0x00B9D380
		public bool IsSpotVisibleOff() => default; // 0x00B9D380-0x00B9D3A0
		public virtual void AnalyzeBaseAnimation(string resourcePath) {} // 0x00B9D3A0-0x00B9D430
		protected void AnalyzeAnimation(GameObjectManager.ModelResourceInfo info, string bundlePath, bool bCommonMotion = false /* Metadata: 0x00614AF0 */) {} // 0x00B9D430-0x00B9DA10
		public virtual void SetCurrentAnimation(string parts, string key, bool bLoop, float fBlendSec) {} // 0x00B9DC40-0x00B9DD20
		public virtual void ClearCurrentAnimation(string parts) {} // 0x00B9DDF0-0x00B9DEE0
		public virtual void SetNextAnimation(string parts, string key, bool bLoop, float fBlendSec) {} // 0x00B9DF50-0x00B9E0E0
		public virtual void SetNextSpeed(string parts, float fSpeed) {} // 0x00B9E1C0-0x00B9E2C0
		public void ClearNextAnimation(string parts) {} // 0x00B995B0-0x00B996A0
		public void SetAnimationTime(string parts, float fTime) {} // 0x00B9E3B0-0x00B9E4B0
		public void SetAnimationNormalizeTime(string parts, float fNormalizeTime) {} // 0x00B9E530-0x00B9E630
		public float GetAnimationTime(string parts) => default; // 0x00B9E6B0-0x00B9E790
		public float GetAnimationMaxTime(string parts) => default; // 0x00B9E800-0x00B9E8F0
		public void SetNormalizeTime(string parts, float fNormalizeTime) {} // 0x00B9E970-0x00B9EA70
		public virtual void PlayCurrentAnimation(string parts) {} // 0x00B9EA70-0x00B9EB60
		public virtual void PlayAnimation(string parts, string key, bool bLoop, float fBlendSec) {} // 0x00B9EBD0-0x00B9ECF0
		public virtual void ForcePlayAll() {} // 0x00B9ECF0-0x00B9ED90
		public virtual void StopAnimation(string parts) {} // 0x00B9EF10-0x00B9F000
		public virtual bool IsPause(string parts) => default; // 0x00B9F070-0x00B9F150
		public virtual bool IsPlayAnimation(string parts, string key) => default; // 0x00B9F1C0-0x00B9F2B0
		public virtual void ChangeSpeedAnimation(string parts, float fSpeed) {} // 0x00B9F320-0x00B9F420
		public virtual float GetSpeedAnimation(string parts) => default; // 0x00B9F4A0-0x00B9F590
		public string GetCurrentAnimationKey() => default; // 0x00B995A0-0x00B995B0
		public bool GetCurrentAnimationLoop() => default; // 0x00B9F600-0x00B9F610
		public virtual void SetAllMultMaterialColorRate(bool bEnable) {} // 0x00B9F610-0x00B9F640
		public virtual void ForceEnableColorDirtyFlag() {} // 0x00B9F640-0x00B9F660
		public virtual void ReturnRootActiveForceAnimationPlay() {} // 0x00B9F660-0x00B9F670
		public virtual void OnMaterialShaderChange(GraphicsSystem.LayerId layerId) {} // 0x00B9F670-0x00B9F680
		public void SetGhostBlend(bool bGhostBlend) {} // 0x00B99D10-0x00B99D50
		public void SetDitherBlend(bool bDitherBlend) {} // 0x00B9F680-0x00B9F6C0
		public void SetDefaultLayerId(GraphicsSystem.LayerId layerId) {} // 0x00B9F6C0-0x00B9F6E0
		public virtual void SetCutProduction(bool bCutEnable) {} // 0x00B9F6E0-0x00B9F6F0
		protected virtual void OnUpdateVisible(bool bVisible) {} // 0x00B9F6F0-0x00B9F8E0
		protected virtual void UpdateVisible() {} // 0x00B9F8E0-0x00B9F970
		protected virtual void OnUpdateShadowVisible(bool bVisible) {} // 0x00B9F970-0x00B9F980
		protected virtual void UpdateOffsetPosition() {} // 0x00B9F980-0x00B9F990
		protected virtual bool OnUpdateMaterialSpotColor(ref bool bSpotDependent, ref float fOutRate) => default; // 0x00B9F990-0x00B9F9A0
		protected virtual void OnUpdateShaderMaterialVisibleColor(Color color) {} // 0x00B9F9A0-0x00B9FB50
		protected void SetShaderMaterialPrpertyMode(bool bEnable) {} // 0x00B9FB80-0x00B9FBA0
		protected bool IsShaderMaterialPrpertyMode() => default; // 0x00B9FB50-0x00B9FB60
		protected void RequestNowFrameShaderMaterialPrperty() {} // 0x00B9FB60-0x00B9FB80
		private void UpdateShaderMaterialPrperty() {} // 0x00B9C4D0-0x00B9C6E0
		public Vector3 GetPopupPoint() => default; // 0x00B99E10-0x00B99F00
	}
}
