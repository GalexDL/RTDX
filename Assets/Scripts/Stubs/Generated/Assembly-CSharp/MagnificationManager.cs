/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MagnificationManager // TypeDefIndex: 5429
{
	// Fields
	private static MagnificationManager m_magnificationManager; // 0x00
	public float m_mag; // 0x10
	public bool m_bPeek; // 0x14
	public const float m_min = 0.25f; // Metadata: 0x00611411
	public const float m_max = 1f; // Metadata: 0x00611415
	public bool m_bCtrl; // 0x15

	// Properties
	public static MagnificationManager Instance { get => default; } // 0x0088AD60-0x0088ADB0 

	// Constructors
	public MagnificationManager() {} // 0x0088AD50-0x0088AD60

	// Methods
	public static void CreateInstance() {} // 0x0088ACC0-0x0088AD50
	public void Uninit() {} // 0x0088ADB0-0x0088AE00
	public void Update() {} // 0x0088AE00-0x0088AF60
}

