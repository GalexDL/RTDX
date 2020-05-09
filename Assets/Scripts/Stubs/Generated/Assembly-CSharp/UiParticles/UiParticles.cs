/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace UiParticles
{
	// [RequireComponent] // 0x0060AA90-0x0060AB00
	public class UiParticles : MaskableGraphic // TypeDefIndex: 8155
	{
		// Fields
		// [FormerlySerializedAs] // 0x00616B00-0x00616B50
		[SerializeField] // 0x00616B00-0x00616B50
		private ParticleSystem m_ParticleSystem; // 0xB0
		// [FormerlySerializedAs] // 0x00616B50-0x00616B90
		private ParticleSystemRenderer m_ParticleSystemRenderer; // 0xB8
		// [FormerlySerializedAs] // 0x00616B90-0x00616C00
		[SerializeField] // 0x00616B90-0x00616C00
		// [Tooltip] // 0x00616B90-0x00616C00
		private UiParticleRenderMode m_RenderMode; // 0xC0
		// [FormerlySerializedAs] // 0x00616C00-0x00616C70
		[SerializeField] // 0x00616C00-0x00616C70
		// [Tooltip] // 0x00616C00-0x00616C70
		private float m_StretchedSpeedScale; // 0xC4
		// [FormerlySerializedAs] // 0x00616C70-0x00616CE0
		[SerializeField] // 0x00616C70-0x00616CE0
		// [Tooltip] // 0x00616C70-0x00616CE0
		private float m_StretchedLenghScale; // 0xC8
		private ParticleSystem.Particle[] m_Particles; // 0xD0
	
		// Properties
		public ParticleSystem ParticleSystem { get => default; set {} } // 0x00B3BE70-0x00B3BE80 0x00B3BE80-0x00B3BF10
		public ParticleSystemRenderer particleSystemRenderer { get => default; set {} } // 0x00B3BF10-0x00B3BF20 0x00B3BF20-0x00B3BFB0
		public override Texture mainTexture { get => default; } // 0x00B3BFB0-0x00B3C0F0 
		public UiParticleRenderMode RenderMode { get => default; set {} } // 0x00B3C0F0-0x00B3C100 0x00B3C100-0x00B3C190
	
		// Constructors
		public UiParticles() {} // 0x00B3D4A0-0x00B3D4B0
	
		// Methods
		protected override void Awake() {} // 0x00B3C190-0x00B3C380
		public override void SetMaterialDirty() {} // 0x00B3C380-0x00B3C420
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x00B3C420-0x00B3C4D0
		private void InitParticlesBuffer() {} // 0x00B3C600-0x00B3C690
		private void GenerateParticlesBillboards(VertexHelper vh) {} // 0x00B3C4D0-0x00B3C600
		private void DrawParticleBillboard(ParticleSystem.Particle particle, VertexHelper vh) {} // 0x00B3C690-0x00B3D080
		private void GetStrechedBillboardsSizeAndRotation(ParticleSystem.Particle particle, float timeAlive01, ref Vector3 size3D, ref Quaternion rotation) {} // 0x00B3D080-0x00B3D3A0
		protected virtual void Update() {} // 0x00B3D3A0-0x00B3D4A0
	}
}
