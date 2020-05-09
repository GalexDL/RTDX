/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class EffectViewerCtrl : MonoBehaviour // TypeDefIndex: 8051
{
	// Fields
	public string m_ReadFilelName; // 0x18
	public GameObject m_model; // 0x20
	private BMEffect m_effect; // 0x28
	public int m_modelCount; // 0x30
	private int m_motionCount; // 0x34
	private int m_manpuCount; // 0x38
	private int m_rightEquipCount; // 0x3C
	private int m_leftEquipCount; // 0x40
	public List<uint> m_modelList; // 0x48
	public List<string> m_motionList; // 0x50
	public List<uint> m_manpuList; // 0x58
	public List<uint> m_effectList; // 0x60
	public List<uint> m_rightEquipList; // 0x68
	public List<uint> m_leftEquipList; // 0x70
	public Dictionary<uint, GraphicsSystem.CharacterDatabaseParameter> m_modelParameterList; // 0x78
	public Dictionary<uint, GraphicsSystem.EffectDatabaseParameter> m_effectParameterList; // 0x80
	public Dictionary<uint, GraphicsSystem.ManpuDatabaseParameter> m_manpuParameterList; // 0x88
	public Dictionary<uint, GraphicsSystem.EquipGraphicsDatabaseParameter> m_equipParameterList; // 0x90
	private uint m_modelGfxSymbol; // 0x98
	private uint m_manpuGfxSymbol; // 0x9C
	private uint m_modelGfxSymbolRequest; // 0xA0
	private uint m_modelGfxSymbolRequest__; // 0xA4
	private uint m_modelGfxSymbolRequestUpdate; // 0xA8
	private float m_modelGfxSymbolRequestUpdateTime; // 0xAC
	private bool m_bMotionLoop; // 0xB0
	private bool m_bEffectLoop; // 0xB1
	private bool m_bIsModelChange; // 0xB2
	private bool m_bRequestModelChange; // 0xB3
	private bool m_bManpuVisible; // 0xB4
	private bool m_bLeftHandVisible; // 0xB5
	private bool m_bRightHandVisible; // 0xB6
	public int m_effectCount; // 0xB8
	private uint m_effectGfxSymbol; // 0xBC
	public int m_cameraCount; // 0xC0
	public bool m_camFlag; // 0xC4
	public float timeOut; // 0xC8

	// Constructors
	public EffectViewerCtrl() {} // 0x00BC9400-0x00BC95C0

	// Methods
	private string[] ReadFile(string fileName) => default; // 0x00BC89B0-0x00BC8A60
	public void AutoPlay() {} // 0x00BC8A60-0x00BC8A70
	private int CompareByCharacterSheetId(uint a, uint b) => default; // 0x00BC8A70-0x00BC8B00
	private int CompareByEffectSheetId(uint a, uint b) => default; // 0x00BC8B00-0x00BC8B90
	// [IteratorStateMachine] // 0x00630730-0x006307A0
	private IEnumerator Start() => default; // 0x00BC8B90-0x00BC8C00
	private void Update() {} // 0x00BC8C30-0x00BC8CC0
	private void AddValue(int max, ref int baseVariable, int value) {} // 0x00BC8CC0-0x00BC8CF0
	public void ModelChange(int value) {} // 0x00BC5580-0x00BC5630
	public void ModelModeChange(int value) {} // 0x00BC5AD0-0x00BC5AE0
	public void Refresh() {} // 0x00BC8CF0-0x00BC8D70
	// [IteratorStateMachine] // 0x006307A0-0x00630810
	private IEnumerator ModelChangeUpdate(uint gfxSymbol, bool bFirst) => default; // 0x00BC8D70-0x00BC8DF0
	public void MotionChange(int value) {} // 0x00BC5DF0-0x00BC5F00
	private void RefreshMotion() {} // 0x00BC8E20-0x00BC8EB0
	public void MotionChange(uint gfxSymbol) {} // 0x00BC8EB0-0x00BC8F40
	public void MotionStop() {} // 0x00BC5CE0-0x00BC5DA0
	public void MotionSetLoop(bool bLoop) {} // 0x00BC5C80-0x00BC5C90
	public void MotionPlay() {} // 0x00BC5B30-0x00BC5C20
	public void CameraChange() {} // 0x00BC77A0-0x00BC77D0
	public void CameraUpdate() {} // 0x00BC8320-0x00BC84B0
	public void RightEquipSetVisible(bool bVisible) {} // 0x00BC66D0-0x00BC66E0
	public bool RightEquipIsVisible() => default; // 0x00BC66C0-0x00BC66D0
	public void LeftEquipSetVisible(bool bVisible) {} // 0x00BC6AF0-0x00BC6B00
	public bool LeftEquipIsVisible() => default; // 0x00BC6AE0-0x00BC6AF0
	public void RightEquipChangeNext(int value) {} // 0x00BC6730-0x00BC6830
	public void LeftEquipChangeNext(int value) {} // 0x00BC6B50-0x00BC6C50
	public void RefreshEquip(bool bRight) {} // 0x00BC8F40-0x00BC9030
	public void EquipChange(uint gfxSymbol, bool bRight) {} // 0x00BC9030-0x00BC9140
	public void EquipClear(bool bRight) {} // 0x00BC9140-0x00BC9270
	public void EffectChangeNext(int value) {} // 0x00BC6EB0-0x00BC6F50
	public void EffectSetLoop(bool bLoop) {} // 0x00BC73C0-0x00BC73D0
	public void EffectPlay() {} // 0x00BC73D0-0x00BC7580
	public void EffectStop() {} // 0x00BC7600-0x00BC7680
	public void ManpuVisible(bool bEnable) {} // 0x00BC6150-0x00BC61F0
	public void ManpuChange(int value) {} // 0x00BC6300-0x00BC6410
	public void RefreshManpu() {} // 0x00BC9270-0x00BC9300
	public void ManpuChange(uint gfxSymbol) {} // 0x00BC9300-0x00BC9400
	public void UpdateText(Text modelNow, Text manpuNow, Text motionNow, Image motionImage, Text effectNow, Image effectImage, Text rightEquipNow, Text leftEquipNow) {} // 0x00BC4EF0-0x00BC5420
}

