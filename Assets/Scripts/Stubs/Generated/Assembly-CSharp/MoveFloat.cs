/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MoveFloat // TypeDefIndex: 5804
{
	// Fields
	private float now_; // 0x10
	private float start_; // 0x14
	private float target_; // 0x18
	private float fSec_; // 0x1C
	private float fTick_; // 0x20
	private bool bMove_; // 0x24
	private EaseType eType_; // 0x28

	// Nested types
	public enum EaseType // TypeDefIndex: 5805
	{
		NORMAL = 0,
		IN = 1,
		OUT = 2
	}

	// Constructors
	public MoveFloat() {} // Dummy constructor
	public MoveFloat(float fInitValue) {} // 0x00E34820-0x00E34870

	// Methods
	public void Set(float c) {} // 0x00E34870-0x00E34880
	public float Get() => default; // 0x00E34880-0x00E34890
	public void Linear(float target, float sec) {} // 0x00E34890-0x00E348D0
	public void Interpolation(float target, float sec, EaseType eType) {} // 0x00E348D0-0x00E34910
	public bool IsMove() => default; // 0x00E34910-0x00E34920
	// [IteratorStateMachine] // 0x00622020-0x00622090
	public IEnumerator WaitMove() => default; // 0x00E34920-0x00E34990
	public bool Tick() => default; // 0x00E349C0-0x00E34AD0
}

