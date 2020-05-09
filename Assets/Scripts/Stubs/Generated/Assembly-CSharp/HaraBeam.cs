/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class HaraBeam : SingletonMonoBehaviour<HaraBeam> // TypeDefIndex: 6024
{
	// Fields
	public GameObject beamObject_; // 0x18
	public GameObject cursorObject_; // 0x20
	private MeshRenderer meshRenderer_; // 0x28
	private Texture2D maskTexture_; // 0x30

	// Properties
	public bool Visible { set {} } // 0x008EE370-0x008EE420
	public bool VisibleCursor { set {} } // 0x008EE420-0x008EE4D0

	// Constructors
	public HaraBeam() {} // 0x008EED30-0x008EEDA0

	// Methods
	public bool IsIncomplateInstance() => default; // 0x008EE2F0-0x008EE370
	private void Start() {} // 0x008EE4D0-0x008EE6C0
	private void OnDestroy() {} // 0x008EE980-0x008EEA40
	public void Clear() {} // 0x008EE6C0-0x008EE8A0
	public void SetPixel(int x, int y, Color color) {} // 0x008EEA40-0x008EEB30
	public void Apply() {} // 0x008EE8A0-0x008EE980
	public void SetCursor(int x, int z) {} // 0x008EEB30-0x008EEC90
	public void ClearCursor() {} // 0x008EEC90-0x008EED30
}

