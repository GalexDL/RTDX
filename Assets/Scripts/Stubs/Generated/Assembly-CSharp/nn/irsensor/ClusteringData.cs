/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.util;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public struct ClusteringData : IEquatable<nn.irsensor.ClusteringData> // TypeDefIndex: 8969
	{
		// Fields
		public float averageIntensity; // 0x10
		public Float2 centroid; // 0x14
		public int pixelCount; // 0x1C
		public Rect bound; // 0x20
	
		// Methods
		public override string ToString() => default; // 0x01146530-0x01146540
		public static bool operator ==(ClusteringData lhs, ClusteringData rhs) => default; // 0x01146540-0x011465B0
		public static bool operator !=(ClusteringData lhs, ClusteringData rhs) => default; // 0x011465B0-0x01146710
		public override bool Equals(object right) => default; // 0x01146710-0x01146720
		public bool Equals(ClusteringData other) => default; // 0x01146720-0x011467A0
		public override int GetHashCode() => default; // 0x011467A0-0x01146820
	}
}
