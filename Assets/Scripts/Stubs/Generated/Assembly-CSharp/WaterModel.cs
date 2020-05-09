/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class WaterModel : NormalModel // TypeDefIndex: 6085
{
	// Fields
	private Texture2D m_maskTexture; // 0x208
	private float m_fHeight; // 0x210
	private Color m_color; // 0x214

	// Constructors
	public WaterModel() {} // Dummy constructor
	protected WaterModel(string resourcePath, float fHeight, float r, float g, float b, float a) {} // 0x00741430-0x007417A0

	// Methods
	public static string GetResourcePath(uint gfxSymbol) => default; // 0x007412C0-0x00741340
	public static WaterModel Create(uint gfxSymbol, float fHeight, float r, float g, float b, float a) => default; // 0x00741340-0x00741430
	public void AllClearMaskTexture() {} // 0x007417A0-0x00741850
	public void ClearMaskTexturePixel(int blockX, int blockY) {} // 0x00741860-0x007418D0
	public void SetMaskTexturePixel(int blockX, int blockY) {} // 0x007418D0-0x00741940
	public void ApplyMaskTexture() {} // 0x00741850-0x00741860
	public override void Update() {} // 0x00741940-0x00741950
	protected override void OnTerminate() {} // 0x00741950-0x00741A20
}

