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

public class EffectViewer : MonoBehaviour // TypeDefIndex: 8047
{
	// Fields
	private RandomMapModel nodeRenderModel_; // 0x18
	public Text modelNow_; // 0x20
	public Text modelNext_; // 0x28
	public Text modelBack_; // 0x30
	public Text effectNow_; // 0x38
	public Text effectNext_; // 0x40
	public Text effectBack_; // 0x48
	public Text manpuNow_; // 0x50
	public Text motionNow_; // 0x58
	public Image rightEquipImage_; // 0x60
	public Image leftEquipImage_; // 0x68
	public Text rightEquipText_; // 0x70
	public Text leftEquipText_; // 0x78
	public Image rightEquipButtonImage_; // 0x80
	public Image leftEquipButtonImage_; // 0x88
	public Text rightEquipButtonText_; // 0x90
	public Text leftEquipButtonText_; // 0x98
	public Image effectImage_; // 0xA0
	public Image motionImage_; // 0xA8
	public GameObject switchParent_; // 0xB0
	private GameObject ctrl_; // 0xB8
	private EffectViewerCtrl viewCtrl_; // 0xC0
	private bool bGameSystemInit_; // 0xC8
	private bool bEffectLoop_; // 0xC9
	private bool bMotionLoop_; // 0xCA
	private bool bFinished_; // 0xCB
	private Dictionary<string, GameObject> dicSwitch_; // 0xD0

	// Properties
	public bool Fnished { get => default; } // 0x00BC4DF0-0x00BC4E00 

	// Constructors
	public EffectViewer() {} // 0x00BC7E00-0x00BC7E70

	// Methods
	// [IteratorStateMachine] // 0x00630650-0x006306C0
	private IEnumerator Start() => default; // 0x00BC4E00-0x00BC4E70
	private void Update() {} // 0x00BC4EA0-0x00BC4EB0
	private void UpdateVeiwCtrlText() {} // 0x00BC4EB0-0x00BC4EF0
	private void UpdateVeiwCtrlFace() {} // 0x00BC5420-0x00BC54A0
	public void OnModelNext() {} // 0x00BC54A0-0x00BC5580
	public void OnModelBack() {} // 0x00BC5630-0x00BC5710
	public void OnModelHNext() {} // 0x00BC5710-0x00BC57F0
	public void OnModelHBack() {} // 0x00BC57F0-0x00BC58D0
	public void OnModelHHNext() {} // 0x00BC58D0-0x00BC59B0
	public void OnModelHHBack() {} // 0x00BC59B0-0x00BC5A90
	public void OnModelModeChange() {} // 0x00BC5A90-0x00BC5AD0
	public void OnMotionPlay() {} // 0x00BC5AE0-0x00BC5B30
	public void OnMotionLoopPlay() {} // 0x00BC5C20-0x00BC5C80
	public void OnMotionStop() {} // 0x00BC5C90-0x00BC5CE0
	public void OnMotionNext() {} // 0x00BC5DA0-0x00BC5DF0
	public void OnMotionBack() {} // 0x00BC5F00-0x00BC5F50
	public void OnMotionHNext() {} // 0x00BC5F50-0x00BC5FA0
	public void OnMotionHBack() {} // 0x00BC5FA0-0x00BC5FF0
	public void OnMotionHHNext() {} // 0x00BC5FF0-0x00BC6040
	public void OnMotionHHBack() {} // 0x00BC6040-0x00BC6090
	public void OnManpuPlay() {} // 0x00BC6090-0x00BC6150
	public void OnManpuStop() {} // 0x00BC61F0-0x00BC62B0
	public void OnManpuNext() {} // 0x00BC62B0-0x00BC6300
	public void OnManpuBack() {} // 0x00BC6410-0x00BC6460
	public void OnManpuHNext() {} // 0x00BC6460-0x00BC64B0
	public void OnManpuHBack() {} // 0x00BC64B0-0x00BC6500
	public void OnManpuHHNext() {} // 0x00BC6500-0x00BC6550
	public void OnManpuHHBack() {} // 0x00BC6550-0x00BC65A0
	public void OnRightHandSwitch() {} // 0x00BC65A0-0x00BC66C0
	public void OnRightHandNext() {} // 0x00BC66E0-0x00BC6730
	public void OnRightHandBack() {} // 0x00BC6830-0x00BC6880
	public void OnRightHandHNext() {} // 0x00BC6880-0x00BC68D0
	public void OnRightHandHBack() {} // 0x00BC68D0-0x00BC6920
	public void OnRightHandHHNext() {} // 0x00BC6920-0x00BC6970
	public void OnRightHandHHBack() {} // 0x00BC6970-0x00BC69C0
	public void OnLeftHandSwitch() {} // 0x00BC69C0-0x00BC6AE0
	public void OnLeftHandNext() {} // 0x00BC6B00-0x00BC6B50
	public void OnLeftHandBack() {} // 0x00BC6C50-0x00BC6CA0
	public void OnLeftHandHNext() {} // 0x00BC6CA0-0x00BC6CF0
	public void OnLeftHandHBack() {} // 0x00BC6CF0-0x00BC6D40
	public void OnLeftHandHHNext() {} // 0x00BC6D40-0x00BC6D90
	public void OnLeftHandHHBack() {} // 0x00BC6D90-0x00BC6DE0
	public void OnEffectNext() {} // 0x00BC6DE0-0x00BC6EB0
	public void OnEffectBack() {} // 0x00BC6F60-0x00BC7030
	public void OnEffectHNext() {} // 0x00BC7030-0x00BC7100
	public void OnEffectHBack() {} // 0x00BC7100-0x00BC71D0
	public void OnEffectHHNext() {} // 0x00BC71D0-0x00BC72A0
	public void OnEffectHHBack() {} // 0x00BC72A0-0x00BC7370
	public void OnEffectLoop() {} // 0x00BC7370-0x00BC73C0
	public void OnEffectPlay() {} // 0x00BC6F50-0x00BC6F60
	public void OnEffectStop() {} // 0x00BC7580-0x00BC7600
	public void OnEffectAllStop() {} // 0x00BC7680-0x00BC7760
	public void OnCameraChage() {} // 0x00BC7760-0x00BC77A0
	private void SetSwitchObject(Image image, bool bEnable) {} // 0x00BC77D0-0x00BC7850
	private void SetSwitchObject(GameObject buttonObj, GameObject switchBodyObj) {} // 0x00BC7850-0x00BC7B90
	public void OnSwitchCharacter() {} // 0x00BC7B90-0x00BC7C00
	public void OnSwitchCharacterHand() {} // 0x00BC7C00-0x00BC7CB0
	public void OnSwitchMotion() {} // 0x00BC7CB0-0x00BC7D20
	public void OnSwitchManpu() {} // 0x00BC7D20-0x00BC7D90
	public void OnSwitchEffect() {} // 0x00BC7D90-0x00BC7E00
}

