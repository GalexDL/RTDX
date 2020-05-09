/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public class ActTargetCell : ISerializationCallbackReceiver // TypeDefIndex: 8695
	{
		// Fields
		[NonSerialized]
		public ActTargetBase target; // 0x10
		public string targetType; // 0x18
		public string symbol; // 0x20
		public bool taskMode; // 0x28
	
		// Constructors
		public ActTargetCell() {} // 0x00AA3910-0x00AA3970
	
		// Methods
		public void OnBeforeSerialize() {} // 0x00AA0070-0x00AA01B0
		public void OnAfterDeserialize() {} // 0x00A9F8D0-0x00A9F970
		public Type GetTargetType() => default; // 0x00AA3880-0x00AA3910
	}
}
