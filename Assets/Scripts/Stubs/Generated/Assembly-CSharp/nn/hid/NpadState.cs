/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct NpadState // TypeDefIndex: 9045
	{
		// Fields
		public long samplingNumber; // 0x10
		public NpadButton buttons; // 0x18
		public AnalogStickState analogStickL; // 0x20
		public AnalogStickState analogStickR; // 0x28
		public NpadAttribute attributes; // 0x30
		public NpadButton preButtons; // 0x38
	
		// Methods
		public void Clear() {} // 0x00A1C5C0-0x00A1C5E0
		public bool GetButton(NpadButton button) => default; // 0x00A1C5E0-0x00A1C5F0
		public bool GetButtonDown(NpadButton button) => default; // 0x00A1C5F0-0x00A1C620
		public bool GetButtonUp(NpadButton button) => default; // 0x00A1C620-0x00A1C920
		public override string ToString() => default; // 0x00A1C920-0x00A1CC00
	}
}
