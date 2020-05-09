/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DirectionalLightBehaviour : MonoBehaviour // TypeDefIndex: 5974
{
	// Fields
	private Light light_; // 0x18
	private ShadowType eShadowType_; // 0x20
	private Color color_; // 0x24
	private MoveColor moveColor_; // 0x38
	private bool bDirtyColor_; // 0x40

	// Nested types
	public enum ShadowType // TypeDefIndex: 5975
	{
		DISABLE = 0,
		ENABLE = 1
	}

	// Constructors
	public DirectionalLightBehaviour() {} // 0x00996110-0x009961F0

	// Methods
	public void SetShadowType(ShadowType type) {} // 0x00995D60-0x00995E00
	private bool IsShadowEnable() => default; // 0x00995E00-0x00995E10
	public void SetColor(float r, float g, float b) {} // 0x00995E10-0x00995E90
	public Color GetColor() => default; // 0x00995E90-0x00995EA0
	public void SetMoveColor(float r, float g, float b, float fSec) {} // 0x00995EA0-0x00995F40
	public bool IsMoveColor() => default; // 0x00995F40-0x00995F50
	public void SetLightEnable(bool enable) {} // 0x00995F50-0x00995F80
	private void Start() {} // 0x00995F80-0x00995FE0
	private void Update() {} // 0x00995FE0-0x00996110
}

