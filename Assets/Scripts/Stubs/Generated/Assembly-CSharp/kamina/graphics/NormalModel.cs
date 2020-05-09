/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GraphicsConst;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina.graphics
{
	public class NormalModel : ModelBase // TypeDefIndex: 8408
	{
		// Fields
		private const float SHAKE_WIDTH = 0.015f; // Metadata: 0x00614AF3
		private CutProductionContext m_cutProductionContext; // 0x160
		private MarkerType m_eMarkerType; // 0x168
		private Vector3 m_vMarkerScale; // 0x16C
		private ColliderType m_colliderType; // 0x178
		protected GameObject m_subObjectRoot; // 0x180
		protected GameObject m_markerObject; // 0x188
		protected Renderer m_markerRenderer; // 0x190
		protected Material m_markerMaterial; // 0x198
		protected GameObject m_shadowObject; // 0x1A0
		protected float m_fMarkerSpotDependentRate; // 0x1A8
		protected bool m_bShadowIgnoreOption; // 0x1AC
		private bool m_bMarkerVisibleUpdate; // 0x1AD
		private bool m_bMarkerVisible; // 0x1AE
		private bool m_bMarkerIndependentMode; // 0x1AF
		private bool m_bMarkerForceOff; // 0x1B0
		private Color m_addMaterialColor; // 0x1B4
		private Color m_addOverlayMaterialColor; // 0x1C4
		private float fDamageColorTick_; // 0x1D4
		private bool bDamageFlashing_; // 0x1D8
		private bool bShake_; // 0x1D9
		private bool bIsCutProduction_; // 0x1DA
		private MoveFloat shakeMoveWidth_; // 0x1E0
		private uint shakeParameter_; // 0x1E8
		private float m_fSpotDependentRate; // 0x1EC
		private float m_fSpotDependentPrevRate; // 0x1F0
		private float m_fSpotDecayCorrectionLength; // 0x1F4
		private SpotDependentType m_eSpotDependentType; // 0x1F8
		private SpotDependentType m_ePrevSpotDependentType; // 0x1FC
		private bool m_bSpotDependent; // 0x200
		private bool m_bSpotColorUpdate; // 0x201
	
		// Properties
		public bool ShadowIgnoreOptionFlag { get => default; } // 0x00B81880-0x00B81890 
	
		// Nested types
		public enum MarkerType // TypeDefIndex: 8409
		{
			NONE = 0,
			CIRCLE = 1
		}
	
		public enum ColliderType // TypeDefIndex: 8410
		{
			NONE = 0,
			BOX = 1,
			CAPSULE = 2,
			MESH = 3
		}
	
		private class CutProductionContext // TypeDefIndex: 8411
		{
			// Fields
			public bool bSpotOffMode; // 0x10
			public bool bSpotVisibleOff; // 0x11
			public bool bSpotColorUpdate; // 0x12
	
			// Constructors
			public CutProductionContext() {} // 0x00BA04F0-0x00BA0500
		}
	
		public enum SpotDependentType // TypeDefIndex: 8412
		{
			NONE = 0,
			COLOR = 1,
			COLOR_AND_VISIBLE_OFF = 2
		}
	
		public class ShaderData // TypeDefIndex: 8413
		{
			// Fields
			public Shader shader; // 0x10
			public int renderQueuePriority; // 0x18
	
			// Constructors
			public ShaderData() {} // Dummy constructor
			public ShaderData(Shader _shader, int _priority) {} // 0x00BA1FE0-0x00BA2030
		}
	
		// Constructors
		public NormalModel() {} // Dummy constructor
		protected NormalModel(int nativeControlId, string symbol, string bundlePath, string resourcePath, bool bSharedMaterial, bool bSubObjectRoot, bool bOffsetNode, List<string> animationPartsList) {} // 0x00BA0140-0x00BA0380
	
		// Methods
		public static NormalModel CreateFromNative(int nativeControlId, string symbol, string bundlePath, string resourcePath, MarkerType eMarkerType, List<string> animationPartsList) => default; // 0x00BA0080-0x00BA0140
		public void SetObjectName(string baseName) {} // 0x00BA0500-0x00BA06A0
		public void SetupCircleShadow(bool bItem) {} // 0x00BA06A0-0x00BA07D0
		public void SetupMarker(MarkerType eMarkerType) {} // 0x00BA0380-0x00BA04F0
		public void SetMarkerIndependentMode(bool bEnable) {} // 0x00B99C20-0x00B99C50
		public void SetMarkerVisible(bool bEnable) {} // 0x00B99BF0-0x00B99C20
		protected void UpdateRequestMarkerVisible() {} // 0x00BA07D0-0x00BA07E0
		public void SetupBoxCllider() {} // 0x00BA07E0-0x00BA0BD0
		public void SetupMeshCllider() {} // 0x00BA0BD0-0x00BA0D50
		public void SetupCapsuleCllider(string boneSymbol, Vector3 centerOffset, float height, float radius) {} // 0x00BA0D50-0x00BA0EB0
		public void ChangeMarker(MarkerType id, float fScaleX, float fScaleY) {} // 0x00B996A0-0x00B99BF0
		public override void SetCutProduction(bool bCutEnable) {} // 0x00BA0EB0-0x00BA1060
		public void SetCircleShadow(bool bEnable) {} // 0x00B81890-0x00B81990
		public void RequestDamageFlashing() {} // 0x00B99D00-0x00B99D10
		public void SetSpotDependent(SpotDependentType eType) {} // 0x00B99D50-0x00B99DB0
		public void ReturnSpotDependent() {} // 0x00B99DB0-0x00B99E10
		public void CopySpotDependent(NormalModel model) {} // 0x00BA1060-0x00BA1080
		public bool IsSpotDependent() => default; // 0x00BA1080-0x00BA1090
		protected void SetSpotDecayCorrectionLength(float fLength) {} // 0x00BA1090-0x00BA10A0
		public virtual Vector3 GetSpotCalcPosition() => default; // 0x00BA10A0-0x00BA10C0
		protected override bool OnUpdateMaterialSpotColor(ref bool bSpotDependent, ref float fOutRate) => default; // 0x00BA10C0-0x00BA1130
		protected virtual void OnUpdateShaderMaterialConditionColor(Color color) {} // 0x00BA1130-0x00BA12E0
		private void UpdateMaterialConditionColor() {} // 0x00BA12E0-0x00BA1350
		public void SetOverlayMaterialConditionColor(Color color) {} // 0x00B99C70-0x00B99C90
		private void OnArrangeOverlayColor(ref Color color) {} // 0x00BA1350-0x00BA1470
		protected override void OnUpdateVisible(bool bVisible) {} // 0x00BA1470-0x00BA14A0
		public void SetAddColor(Color c) {} // 0x00B99C50-0x00B99C70
		protected virtual void OnUpdateMaterialAddColor(Color color) {} // 0x00BA14A0-0x00BA1650
		private void UpdateMaterialAddColor() {} // 0x00BA1650-0x00BA16A0
		public void SetEnableShake(float shakeWidth, float fShakeTime) {} // 0x00B99C90-0x00B99CF0
		public void ClearShake() {} // 0x00B99CF0-0x00B99D00
		public virtual void UpdateShadowPosition() {} // 0x00BA16A0-0x00BA1780
		protected override void OnUpdateShadowVisible(bool bVisible) {} // 0x00BA1780-0x00BA1830
		protected virtual void OnUpdateMarkerVisible(bool bVisible) {} // 0x00BA1830-0x00BA1930
		protected override void UpdateOffsetPosition() {} // 0x00BA1930-0x00BA1AF0
		public override void Update() {} // 0x00BA1AF0-0x00BA1CD0
		public override void LastUpdate() {} // 0x00BA1CD0-0x00BA1E70
		protected override void OnTerminate() {} // 0x00BA1E70-0x00BA1FE0
	}
}
