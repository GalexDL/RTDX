/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectContainer // TypeDefIndex: 9532
	{
		// Fields
		public List<VolumeEffect> volumes; // 0x10
	
		// Constructors
		public VolumeEffectContainer() {} // 0x0085F1A0-0x0085F220
	
		// Methods
		public void AddColorEffect(AmplifyColorBase colorEffect) {} // 0x0085F220-0x0085F330
		public VolumeEffect AddJustColorEffect(AmplifyColorBase colorEffect) => default; // 0x0085F4E0-0x0085F5C0
		public VolumeEffect FindVolumeEffect(AmplifyColorBase colorEffect) => default; // 0x0085F330-0x0085F4E0
		public void RemoveVolumeEffect(VolumeEffect volume) {} // 0x0085F5D0-0x0085F630
		public AmplifyColorBase[] GetStoredEffects() => default; // 0x0085F630-0x0085F740
	}
}
