/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public struct MomentProcessorConfig : IEquatable<nn.irsensor.MomentProcessorConfig> // TypeDefIndex: 9012
	{
		// Fields
		public IrCameraConfig irCameraConfig; // 0x10
		public Rect windowOfInterest; // 0x28
		public MomentProcessorPreprocess preprocess; // 0x30
		public int preprocessIntensityThreshold; // 0x34
	
		// Methods
		public override string ToString() => default; // 0x01150E60-0x01150E70
		public static bool operator ==(MomentProcessorConfig lhs, MomentProcessorConfig rhs) => default; // 0x01150E70-0x01150F50
		public static bool operator !=(MomentProcessorConfig lhs, MomentProcessorConfig rhs) => default; // 0x01150F50-0x01151150
		public override bool Equals(object right) => default; // 0x01151150-0x01151160
		public bool Equals(MomentProcessorConfig other) => default; // 0x01151160-0x01151220
		public override int GetHashCode() => default; // 0x01151220-0x011512A0
	}
}
