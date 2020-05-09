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
	public class VolumeEffectFlags // TypeDefIndex: 9539
	{
		// Fields
		public List<VolumeEffectComponentFlags> components; // 0x10
	
		// Constructors
		public VolumeEffectFlags() {} // 0x0085F9E0-0x0085FA60
	
		// Methods
		public void AddComponent(Component c) {} // 0x0085FA60-0x0085FB70
		public void UpdateFlags(VolumeEffect effectVol) {} // 0x0085FB80-0x0085FDA0
		public static void UpdateCamFlags(AmplifyColorBase[] effects, AmplifyColorVolumeBase[] volumes) {} // 0x0085FDB0-0x0085FF40
		public VolumeEffect GenerateEffectData(AmplifyColorBase go) => default; // 0x0085FF40-0x00860160
		public VolumeEffectComponentFlags FindComponentFlags(string compName) => default; // 0x00860160-0x00860230
		public string[] GetComponentNames() => default; // 0x00860230-0x00860400
	}
}
