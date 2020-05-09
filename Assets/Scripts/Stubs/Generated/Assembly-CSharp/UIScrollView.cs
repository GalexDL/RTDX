/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A690-0x0060A6A0
public class UIScrollView : MonoBehaviour // TypeDefIndex: 7540
{
	// Fields
	public int barSize; // 0x18
	private InputMode mode; // 0x1C
	private bool bEnable_; // 0x20
	private float moveValue_; // 0x24
	private const float moveStep_ = 2f; // Metadata: 0x006137E4
	private const float moveMax_ = 16f; // Metadata: 0x006137E8
	private const float moveAccel_ = 2f; // Metadata: 0x006137EC
	private float moveStartTime; // 0x28
	private float moveAccelTime; // 0x2C
	private MoveState moveState_; // 0x30
	private int range_; // 0x34
	private bool bVerticalDir_; // 0x38
	private bool bVisibleScrollBar_; // 0x39
	private bool bInitialized_; // 0x3A
	private GameObject objScrollBar_; // 0x40
	private GameObject objBar_; // 0x48
	private float basePos_; // 0x50
	private float viewRange_; // 0x54
	private GameObject objContents_; // 0x58
	private float contentsPositionOrg_; // 0x60
	private float upperMargin_; // 0x64
	private float contentsPosition_; // 0x68
	private float contentsRange_; // 0x6C

	// Properties
	public bool Enable { get => default; set {} } // 0x00DF7CE0-0x00DF7CF0 0x00DF7CF0-0x00DF7D20
	public bool Vertical { get => default; set {} } // 0x00DF80C0-0x00DF80D0 0x00DF80D0-0x00DF80E0
	public bool Horizontal { get => default; set {} } // 0x00DF80E0-0x00DF80F0 0x00DF80F0-0x00DF8100
	public bool VisibleScrollBar { get => default; set {} } // 0x00DF8100-0x00DF8110 0x00DF8110-0x00DF8120
	public float ViewRange { get => default; } // 0x00DF8120-0x00DF8130 
	public float ContentsRange { get => default; set {} } // 0x00DF8130-0x00DF8140 0x00DF8140-0x00DF8180

	// Nested types
	public enum InputMode // TypeDefIndex: 7541
	{
		RStick = 0,
		LRStick = 1,
		num_InputMode = 2
	}

	public enum MoveState // TypeDefIndex: 7542
	{
		None = 0,
		Increase = 1,
		Decrease = 2
	}

	// Constructors
	public UIScrollView() {} // 0x00DF8770-0x00DF8790

	// Methods
	private void Awake() {} // 0x00DF7960-0x00DF7970
	private void OnEnable() {} // 0x00DF7B00-0x00DF7B10
	private void Update() {} // 0x00DF7B10-0x00DF7B20
	public MoveState GetMoveState() => default; // 0x00DF7EC0-0x00DF7ED0
	public float GetMoveValue() => default; // 0x00DF7ED0-0x00DF7EE0
	private void _initManeuver() {} // 0x00DF7EB0-0x00DF7EC0
	private void _updateManeuver() {} // 0x00DF7B20-0x00DF7CE0
	private bool checkScrollDown() => default; // 0x00DF7EE0-0x00DF7FD0
	private bool checkScrollUp() => default; // 0x00DF7FD0-0x00DF80C0
	private void _awake() {} // 0x00DF7970-0x00DF7B00
	private void _initialize() {} // 0x00DF7D20-0x00DF7EB0
	public void SetButtonGuide(bool bGuideR = true /* Metadata: 0x006137E3 */) {} // 0x00DF8180-0x00DF8320
	public void ShowScrollBar(bool bShow) {} // 0x00DF8320-0x00DF8450
	public bool IsContentsWithin(float contentsSize) => default; // 0x00DF8450-0x00DF8470
	public bool IsContentsWithin() => default; // 0x00DF8470-0x00DF8490
	public float setScrollBar(float ofs) => default; // 0x00DF8490-0x00DF8630
	public void setViewPosition(float ofs) {} // 0x00DF8630-0x00DF8720
	public void updateViewPosition() {} // 0x00DF8720-0x00DF8740
	public void setInputMode(InputMode arg_mode) {} // 0x00DF8740-0x00DF8750
	public void SetScrollMax() {} // 0x00DF8750-0x00DF8760
	public void ResetScroll() {} // 0x00DF8760-0x00DF8770
}

