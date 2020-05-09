/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PoissonTools : MonoBehaviour // TypeDefIndex: 4355
{
	// Fields
	public Vector2[] data; // 0x18
	[HideInInspector] // 0x00615C00-0x00615C10
	public Vector2[] dataBackup; // 0x20
	// [Header] // 0x00615C10-0x00615C50
	public int interleaveInterval; // 0x28
	public int seed; // 0x2C
	// [Header] // 0x00615C50-0x00615CA0
	[Space] // 0x00615C50-0x00615CA0
	public AnimationCurve radialWeight; // 0x30
	// [Header] // 0x00615CA0-0x00615CF0
	[Space] // 0x00615CA0-0x00615CF0
	public int res; // 0x38
	public Texture2D tex; // 0x40
	public Material mat; // 0x48
	// [Range] // 0x00615CF0-0x00615D10
	public int count; // 0x50

	// Constructors
	public PoissonTools() {} // 0x00B785B0-0x00B7AAF0

	// Methods
	// [ContextMenu] // 0x006188D0-0x00618910
	public void Interleave() {} // 0x00B77190-0x00B773B0
	// [ContextMenu] // 0x00618910-0x00618950
	public void ShuffleData() {} // 0x00B77450-0x00B77620
	// [ContextMenu] // 0x00618950-0x00618990
	public void IntelliSort() {} // 0x00B77620-0x00B77D00
	// [ContextMenu] // 0x00618990-0x006189D0
	public void SortByX() {} // 0x00B77D00-0x00B77EA0
	// [ContextMenu] // 0x006189D0-0x00618A10
	public void Redraw() {} // 0x00B77EA0-0x00B78300
	// [ContextMenu] // 0x00618A10-0x00618A50
	public void PrintArray() {} // 0x00B78300-0x00B785A0
	// [ContextMenu] // 0x00618A50-0x00618A90
	public void Revert() {} // 0x00B785A0-0x00B785B0
	public void Backup(bool forced = false /* Metadata: 0x00610786 */) {} // 0x00B773B0-0x00B77450
}

