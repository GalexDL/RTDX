/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLua;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[CustomLuaClass] // 0x00608C70-0x00608C80
public class LuaTimeSec // TypeDefIndex: 4550
{
	// Fields
	public const float TECH_FPSF_VALUE = 60f; // Metadata: 0x006109B1
	private float m_sec; // 0x10
	private TimeType m_type; // 0x14

	// Nested types
	public enum TimeType // TypeDefIndex: 4551
	{
		SECOND = 0,
		FRAME = 1
	}

	// Constructors
	public LuaTimeSec() {} // Dummy constructor
	public LuaTimeSec(float sec) {} // 0x00BFF310-0x00BFF350
	public LuaTimeSec(float time, TimeType timeType) {} // 0x00BFF350-0x00BFF3B0

	// Methods
	public TimeType GetTimeType() => default; // 0x00BFF3B0-0x00BFF3C0
	public float GetSec() => default; // 0x00BFEF40-0x00BFEF50
	public int GetFrame() => default; // 0x00BFF3C0-0x00BFF480
}

