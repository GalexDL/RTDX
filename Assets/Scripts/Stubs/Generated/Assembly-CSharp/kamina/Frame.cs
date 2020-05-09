/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina
{
	public abstract class Frame : IFrame // TypeDefIndex: 8365
	{
		// Fields
		public const uint UNIQUE_ID_NONE = 0; // Metadata: 0x0061472F
		public const int NATIVE_CONTROL_ID_NONE = 0; // Metadata: 0x00614733
		public const int NATIVE_CONTROL_ID_MAX = 65536; // Metadata: 0x00614737
		private static uint s_uniqueId; // 0x00
		protected GameObjectManager m_manager; // 0x10
		private uint uniqueId_; // 0x18
		private int nativeControlId_; // 0x1C
	
		// Properties
		public int NativeControlId { get; set; } // 0x00B7DE90-0x00B7DEA0 0x00B7DEA0-0x00B7DEB0
	
		// Constructors
		protected Frame() {} // 0x00B7E130-0x00B7E1F0
		protected Frame(int nativeControlId) {} // 0x00B7E2C0-0x00B7E390
		static Frame() {} // 0x00B7E560-0x00B7E5C0
	
		// Methods
		public static void SelfDestroy(Frame frame) {} // 0x00B7DEB0-0x00B7DF70
		public static void Destroy(Frame frame) {} // 0x00B7DFD0-0x00B7DFF0
		public bool IsEnable() => default; // 0x00B7DFF0-0x00B7E000
		public bool IsNativeControl() => default; // 0x00B7E120-0x00B7E130
		public void AttachRoot(Transform t) {} // 0x00B7E390-0x00B7E3D0
		public void DetachRoot(Transform t) {} // 0x00B7E3E0-0x00B7E4B0
		private void Terminate() {} // 0x00B7E000-0x00B7E120
		public abstract void Update();
		public virtual void LastUpdate() {} // 0x00B7E540-0x00B7E550
		protected abstract void OnTerminate();
		public virtual void OnUpdateGlobalShadowColor(Color color) {} // 0x00B7E550-0x00B7E560
	}
}
