/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AmplifyColor;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x006085C0-0x00608610
[ExecuteInEditMode] // 0x006085C0-0x00608610
public class AmplifyColorVolumeBase : MonoBehaviour // TypeDefIndex: 4349
{
	// Fields
	public Texture2D LutTexture; // 0x18
	public float Exposure; // 0x20
	public float EnterBlendTime; // 0x24
	public int Priority; // 0x28
	public bool ShowInSceneView; // 0x2C
	[HideInInspector] // 0x00615B70-0x00615B80
	public VolumeEffectContainer EffectContainer; // 0x30

	// Constructors
	public AmplifyColorVolumeBase() {} // 0x00864BD0-0x00864CA0

	// Methods
	private void OnDrawGizmos() {} // 0x00864F40-0x008651A0
	private void OnDrawGizmosSelected() {} // 0x008651A0-0x008653F0
}

