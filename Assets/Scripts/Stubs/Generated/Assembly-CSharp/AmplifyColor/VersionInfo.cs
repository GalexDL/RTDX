/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace AmplifyColor
{
	[Serializable]
	public class VersionInfo // TypeDefIndex: 9525
	{
		// Fields
		public const byte Major = 1; // Metadata: 0x006323B4
		public const byte Minor = 8; // Metadata: 0x006323B5
		public const byte Release = 0; // Metadata: 0x006323B6
		private static string StageSuffix; // 0x00
		private static string TrialSuffix; // 0x08
		[SerializeField] // 0x00618440-0x00618450
		private int m_major; // 0x10
		[SerializeField] // 0x00618450-0x00618460
		private int m_minor; // 0x14
		[SerializeField] // 0x00618460-0x00618470
		private int m_release; // 0x18
	
		// Properties
		public int Number { get => default; } // 0x0085B720-0x0085B740 
	
		// Constructors
		private VersionInfo() {} // 0x0085B740-0x0085B780
		private VersionInfo(byte major, byte minor, byte release) {} // 0x0085B780-0x0085B7D0
		static VersionInfo() {} // 0x0085B880-0x0085B900
	
		// Methods
		public static string StaticToString() => default; // 0x0085B530-0x0085B620
		public override string ToString() => default; // 0x0085B620-0x0085B720
		public static VersionInfo Current() => default; // 0x0085B7D0-0x0085B840
		public static bool Matches(VersionInfo version) => default; // 0x0085B840-0x0085B880
	}
}
