/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace AmplifyColor
{
	[Serializable]
	public class VolumeEffectComponentFlags // TypeDefIndex: 9535
	{
		// Fields
		public string componentName; // 0x10
		public List<VolumeEffectFieldFlags> componentFields; // 0x18
		public bool blendFlag; // 0x20
	
		// Constructors
		public VolumeEffectComponentFlags() {} // Dummy constructor
		public VolumeEffectComponentFlags(string name) {} // 0x0085E570-0x0085E600
		public VolumeEffectComponentFlags(VolumeEffectComponent comp) {} // 0x0085E600-0x0085E800
		public VolumeEffectComponentFlags(Component c) {} // 0x0085E840-0x0085EA20
	
		// Methods
		public void UpdateComponentFlags(VolumeEffectComponent comp) {} // 0x0085EA90-0x0085ECD0
		public void UpdateComponentFlags(Component c) {} // 0x0085ECE0-0x0085EEC0
		public string[] GetFieldNames() => default; // 0x0085EED0-0x0085F0A0
	}
}
