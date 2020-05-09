/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FontOffscreenSystem : SingletonMonoBehaviour<FontOffscreenSystem> // TypeDefIndex: 5983
{
	// Fields
	public GameObject rendererObject32; // 0x18
	public GameObject rendererObject64; // 0x20
	private FontOffscreenRenderer renderer32; // 0x28
	private FontOffscreenRenderer renderer64; // 0x30

	// Constructors
	public FontOffscreenSystem() {} // 0x009AD510-0x009AD580

	// Methods
	public void Begin() {} // 0x009AD320-0x009AD380
	public void End() {} // 0x009AD380-0x009AD3E0
	public Texture GetTexture32() => default; // 0x009AD3E0-0x009AD3F0
	public Texture GetTexture64() => default; // 0x009AD3F0-0x009AD400
	private void Start() {} // 0x009AD400-0x009AD490
	public void RequestRenderString32(string str) {} // 0x009AD490-0x009AD4D0
	public void RequestRenderString64(string str) {} // 0x009AD4D0-0x009AD510
}

