/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffect // TypeDefIndex: 9530
	{
		// Fields
		public AmplifyColorBase gameObject; // 0x10
		public List<VolumeEffectComponent> components; // 0x18
	
		// Constructors
		public VolumeEffect() {} // Dummy constructor
		public VolumeEffect(AmplifyColorBase effect) {} // 0x0085B900-0x0085B990
	
		// Methods
		public static VolumeEffect BlendValuesToVolumeEffect(VolumeEffectFlags flags, VolumeEffect volume1, VolumeEffect volume2, float blend) => default; // 0x0085B990-0x0085C1A0
		public VolumeEffectComponent AddComponent(Component c, VolumeEffectComponentFlags compFlags) => default; // 0x0085C410-0x0085C560
		public void RemoveEffectComponent(VolumeEffectComponent comp) {} // 0x0085CB90-0x0085CBF0
		public void UpdateVolume() {} // 0x0085CBF0-0x0085CDD0
		public void SetValues(AmplifyColorBase targetColor) {} // 0x0085CDD0-0x0085D470
		public void BlendValues(AmplifyColorBase targetColor, VolumeEffect other, float blendAmount) {} // 0x0085D470-0x0085D9D0
		public VolumeEffectComponent FindEffectComponent(string compName) => default; // 0x0085C1A0-0x0085C270
		public static Component[] ListAcceptableComponents(AmplifyColorBase go) => default; // 0x0085D9D0-0x0085DB90
		public string[] GetComponentNames() => default; // 0x0085DB90-0x0085DCA0
	}
}
