/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x006094F0-0x00609530
[ExecuteInEditMode] // 0x006094F0-0x00609530
public class CampMapLoader : MonoBehaviour // TypeDefIndex: 4866
{
	// Fields
	public string[] normal_pikachuu; // 0x18
	public string[] normal_nyaasu; // 0x20
	public string[] normal_iibui; // 0x28
	public string[] normal_eneko; // 0x30
	public string[] water_zenigame; // 0x38
	public string[] water_waninoko; // 0x40
	public string[] water_mizugorou; // 0x48
	public string[] water_kodakku; // 0x50
	public string[] fire_hitokage; // 0x58
	public string[] fire_achamo; // 0x60
	public string[] fire_hinoarashi; // 0x68
	public string[] ground_karakara; // 0x70
	public string[] ground_wanrikii; // 0x78
	public string[] grass_fushigidane; // 0x80
	public string[] grass_chikoriita; // 0x88
	public string[] grass_kimori; // 0x90
	public CampDay campDay; // 0x98
	private GameObject mapObj_; // 0xA0
	private CampType loadedType_; // 0xA8
	private CampLevel loadedLevel_; // 0xAC

	// Nested types
	public enum CampType // TypeDefIndex: 4867
	{
		NORMAL_PIKACHUU = 0,
		NORMAL_NYAASU = 1,
		NORMAL_IIBUI = 2,
		NORMAL_ENEKO = 3,
		WATER_ZENIGAME = 4,
		WATER_WANINOKO = 5,
		WATER_MIZUGOROU = 6,
		WATER_KODAKKU = 7,
		FIRE_HITOKAGE = 8,
		FIRE_ACHAMO = 9,
		FIRE_HINOARASHI = 10,
		GROUND_KARAKARA = 11,
		GROUND_WANRIKII = 12,
		GRASS_FUSHIGIDANE = 13,
		GRASS_CHIKORIITA = 14,
		GRASS_KIMORI = 15
	}

	public enum CampLevel // TypeDefIndex: 4868
	{
		LEVEL_1 = 0,
		LEVEL_2 = 1,
		LEVEL_3 = 2
	}

	public enum CampDay // TypeDefIndex: 4869
	{
		DAY = 0,
		NIGHT = 1
	}

	// Constructors
	public CampMapLoader() {} // 0x008C5530-0x008C5680

	// Methods
	public void Reload(Action endCb) {} // 0x008C4F50-0x008C52E0
	private void OnEnable() {} // 0x008C5300-0x008C53F0
	private void OnDisable() {} // 0x008C53F0-0x008C54A0
	public bool IsLoaded() => default; // 0x008C54A0-0x008C5510
	public void CheckAndReload() {} // 0x008C5510-0x008C5520
	private void Update() {} // 0x008C5520-0x008C5530
}

