/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class BMEffectScript // TypeDefIndex: 4833
{
	// Fields
	private static Color prevMainLightColor_; // 0x00
	private static Color prevMapColor_; // 0x10
	private static List<Frame> ignoreColorList_; // 0x20

	// Nested types
	public class TimeSec // TypeDefIndex: 4834
	{
		// Fields
		private float sec_; // 0x10

		// Constructors
		public TimeSec() {} // Dummy constructor
		public TimeSec(float sec) {} // 0x008B8220-0x008B8260

		// Methods
		public float GetSec() => default; // 0x008B8260-0x008B8270
		public int GetFrame() => default; // 0x008B8270-0x008B8290
	}

	// Constructors
	public BMEffectScript() {} // 0x00871770-0x00871780
	static BMEffectScript() {} // 0x00871780-0x00871880

	// Methods
	private static void ClearIgnoreColorList() {} // 0x00870BB0-0x00870CA0
	private static void AddIgnoreColorList(Frame frame) {} // 0x00870CA0-0x00870D20
	private static void AllCharacterModelIgnoreColorList() {} // 0x00870D20-0x00870EF0
	private static void AllColorChange(Color c, float fSec) {} // 0x00870EF0-0x00871050
	public static void ChangeLightColor(Color target, TimeSec time) {} // 0x00871050-0x00871120
	public static void ReturnLightColor(TimeSec time) {} // 0x00871120-0x008711C0
	public static bool IsChangeLightColor() => default; // 0x008711C0-0x00871280
	public static void ChangeMapColor(Color target, TimeSec time) {} // 0x00871280-0x008714F0
	public static void ReturnMapColor(TimeSec time) {} // 0x008714F0-0x008716C0
	public static void SetShakeDungeon(Vector2 size, TimeSec time) {} // 0x008716C0-0x00871770
	public static void ExecuteProductionScript(string func) {} // 0x0086FAF0-0x00870810
}

