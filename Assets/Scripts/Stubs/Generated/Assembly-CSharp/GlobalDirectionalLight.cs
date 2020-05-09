/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GlobalDirectionalLight : SingletonMonoBehaviour<GlobalDirectionalLight> // TypeDefIndex: 6008
{
	// Fields
	public DirectionalLightBehaviour mainDirectionalLight; // 0x18
	public DirectionalLightBehaviour ghostBlendDirectionalLight; // 0x20
	private Transform transform_; // 0x28
	private Vector3 rotate_; // 0x30
	private bool bDirtyRotate_; // 0x3C

	// Properties
	public DirectionalLightBehaviour MainDirectionalLight { get => default; } // 0x0072BD50-0x0072BD60 
	public DirectionalLightBehaviour GhostBlendDirectionalLight { get => default; } // 0x0072BD60-0x0072BD70 

	// Constructors
	public GlobalDirectionalLight() {} // 0x0072BEE0-0x0072BF90

	// Methods
	public void SetActive(bool bEnable) {} // 0x0072BD70-0x0072BDA0
	private void Start() {} // 0x0072BDA0-0x0072BDE0
	public void SetRotate(float rx, float ry, float rz) {} // 0x0072BDE0-0x0072BE30
	private void Update() {} // 0x0072BE30-0x0072BEE0
}

