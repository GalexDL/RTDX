/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MoveColor // TypeDefIndex: 5807
{
	// Fields
	private Color now_; // 0x10
	private Color start_; // 0x20
	private Color target_; // 0x30
	private float fSec_; // 0x40
	private float fTick_; // 0x44
	private bool bMove_; // 0x48

	// Constructors
	public MoveColor() {} // 0x00E34410-0x00E34510
	public MoveColor(Color c) {} // 0x00E34530-0x00E34630

	// Methods
	public void Set(Color c) {} // 0x00E34510-0x00E34530
	public Color Get() => default; // 0x00E34630-0x00E34640
	public Color GetGoal() => default; // 0x00E34640-0x00E34650
	public void Linear(Color target, float sec) {} // 0x00E34650-0x00E346B0
	public bool IsMove() => default; // 0x00E346B0-0x00E346C0
	public bool IsBlack() => default; // 0x00E346C0-0x00E34700
	public void Tick() {} // 0x00E34700-0x00E34820
}

