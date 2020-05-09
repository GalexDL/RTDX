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
	public class VolumeEffectComponent // TypeDefIndex: 9527
	{
		// Fields
		public string componentName; // 0x10
		public List<VolumeEffectField> fields; // 0x18
	
		// Constructors
		public VolumeEffectComponent() {} // Dummy constructor
		public VolumeEffectComponent(string name) {} // 0x0085C270-0x0085C300
		public VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags) {} // 0x0085C8B0-0x0085CB90
	
		// Methods
		public VolumeEffectField AddField(FieldInfo pi, Component c) => default; // 0x0085DE60-0x0085DE70
		public VolumeEffectField AddField(FieldInfo pi, Component c, int position) => default; // 0x0085DE70-0x0085DFF0
		public void RemoveEffectField(VolumeEffectField field) {} // 0x0085E180-0x0085E1E0
		public void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags) {} // 0x0085C560-0x0085C8B0
		public VolumeEffectField FindEffectField(string fieldName) => default; // 0x0085C300-0x0085C3D0
		public static FieldInfo[] ListAcceptableFields(Component c) => default; // 0x0085E1F0-0x0085E370
		public string[] GetFieldNames() => default; // 0x0085E370-0x0085E480
	}
}
