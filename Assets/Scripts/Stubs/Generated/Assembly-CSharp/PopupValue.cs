/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using popup;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PopupValue : IPopupValue // TypeDefIndex: 6054
{
	// Fields
	private static string[] s_aNumber; // 0x00
	private static string[] s_aKetaNode_; // 0x08
	public static float POPUP_REPEAT_POINT_Y; // 0x10
	private int value_; // 0x10
	private popup.ValueType type_; // 0x14
	private GameObject obj_; // 0x18
	protected GameObject transformObject_; // 0x20
	protected ModelBase parentModel_; // 0x28
	private Animator anim_; // 0x30
	private List<Transform> aTransfromList_; // 0x38
	private Vector3 vAppearPosition_; // 0x40
	private Vector2 vSclae_; // 0x4C
	private int hashAnim_; // 0x54
	private int drawCounter_; // 0x58
	private int drawValue_; // 0x5C
	private ulong positionId_; // 0x60
	private float SPACE; // 0x68
	private float fAppearOffsetX_; // 0x6C
	private float fAppearOffsetY_; // 0x70
	private float fDelay_; // 0x74
	private bool bIsPlayStarted_; // 0x78
	private bool bVisible_; // 0x79
	private bool bVisibleUpdate_; // 0x7A
	private bool bForceDestroy_; // 0x7B
	private bool bValueUpdate_; // 0x7C
	private bool bTrashTarget_; // 0x7D

	// Properties
	public ulong PositionId { get => default; } // 0x009ECDE0-0x009ECDF0 
	public float AppearOffsetY { get => default; } // 0x009ECDF0-0x009ECE00 
	public popup.ValueType ValueType { get => default; } // 0x009ECE00-0x009ECE10 
	public bool TrashTarget { get => default; } // 0x009ECE10-0x009ECE20 

	// Nested types
	public enum Status // TypeDefIndex: 6055
	{
		APPEAR = 0,
		APPEAR_WAIT = 1,
		DISAPPEAR = 2,
		DISAPPEAR_WAIT = 3
	}

	// Constructors
	public PopupValue() {} // Dummy constructor
	public PopupValue(int value, popup.ValueType type, ModelBase modelBase, bool bAttach, float fDelay, float fContinueOffsetY) {} // 0x009ECE20-0x009ECF50
	public PopupValue(int value, popup.ValueType type, Vector3 v, float fDelay, float fContinueOffsetY) {} // 0x009ED890-0x009ED9B0
	static PopupValue() {} // 0x009EE7C0-0x009EEE00

	// Methods
	private bool IsOffsetNumberType() => default; // 0x009ED9B0-0x009EDA50
	public void Initialize(int value, popup.ValueType type, Vector3 vAppearPosition, ModelBase parent, bool bAttach, float fDelay, float fContinueOffsetY) {} // 0x009ECF50-0x009ED890
	private void UpdatePosition(Vector2 v) {} // 0x009EDD10-0x009EDE80
	public void TerminateToTrash() {} // 0x009EDE80-0x009EE0D0
	public void Terminate() {} // 0x009EE190-0x009EE2A0
	private void SetVisible(int ketaNo, bool bEnable) {} // 0x009EE2A0-0x009EE380
	public bool IsPlayEnd() => default; // 0x009EE380-0x009EE450
	private void Start() {} // 0x009EE450-0x009EE460
	public bool UpdateFromController() => default; // 0x009EE460-0x009EE7C0
}

