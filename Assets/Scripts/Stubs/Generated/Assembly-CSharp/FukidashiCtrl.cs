/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FukidashiConst;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A1C0-0x0060A1D0
public class FukidashiCtrl : MonoBehaviour // TypeDefIndex: 5985
{
	// Fields
	public GameObject frameObject; // 0x18
	public GameObject textObject; // 0x20
	private Queue<RequestData> m_requestQueue; // 0x28
	private bool m_bVisible; // 0x30
	private CreatureUniqueId m_creatureId; // 0x38
	private FukidashiConst.Type m_type; // 0x40
	private FukidashiConst.Type m_prevType; // 0x44
	private TextData[] m_aTextData; // 0x48
	private UIControlTMP3D m_textCtrl; // 0x50
	private AnimationType m_animeType; // 0x58
	private ResourceCache.Resource m_bundle; // 0x60
	private Vector3 m_frameObjectScale; // 0x68
	private float m_fVisibleTimer; // 0x74
	private float m_fReserveTimerForMutter; // 0x78
	private bool m_bAnimationOpenBreak; // 0x7C

	// Nested types
	public enum AnimationType // TypeDefIndex: 5986
	{
		None = 0,
		Open = 1,
		Close = 2
	}

	public enum RequestType // TypeDefIndex: 5987
	{
		None = 0,
		Appear = 1,
		Disappear = 2
	}

	private class RequestData // TypeDefIndex: 5988
	{
		// Fields
		public RequestType req; // 0x10
		public CreatureUniqueId creature; // 0x18
		public FukidashiConst.Type type; // 0x20
		public string text; // 0x28
		public float delaySec; // 0x30
		public float fOverwriteVisibleTimer; // 0x34

		// Constructors
		public RequestData() {} // 0x00BA9D20-0x00BA9D80
	}

	private class TextData // TypeDefIndex: 5989
	{
		// Fields
		public string text; // 0x10
		public int returnNum; // 0x18
		public int widthMaxCount; // 0x1C
		public float fOverwriteVisibleTimer; // 0x20

		// Constructors
		public TextData() {} // 0x00BAB1F0-0x00BAB250
	}

	// Constructors
	public FukidashiCtrl() {} // 0x00BAA310-0x00BAA3A0

	// Methods
	private void OnEnable() {} // 0x00BA8DA0-0x00BA8E00
	private void OnDisable() {} // 0x00BA8E00-0x00BA8E10
	// [IteratorStateMachine] // 0x00623B40-0x00623BB0
	private IEnumerator Start() => default; // 0x00BA8E10-0x00BA8E80
	private void OnDestroy() {} // 0x00BA8EB0-0x00BA8FB0
	private void UpdateVisible(bool bVisible) {} // 0x00BA8FB0-0x00BA90E0
	private void Update() {} // 0x00BA90E0-0x00BA9410
	private void LateUpdate() {} // 0x00BA9800-0x00BA9810
	private void CheckAppear(FukidashiConst.Type type) {} // 0x00BA9560-0x00BA9630
	private void CheckNextAppear(FukidashiConst.Type type) {} // 0x00BA9AD0-0x00BA9B80
	private void CheckNextAppear() {} // 0x00BA9B80-0x00BA9C30
	public void Request(RequestType req, FukidashiConst.Type type, string text, float fOverwriteVisibleTimer) {} // 0x00BA9C30-0x00BA9D20
	private void Appear(FukidashiConst.Type type) {} // 0x00BA9810-0x00BA9AD0
	public static int GetReturnNum(string s) => default; // 0x00BA9E00-0x00BA9E80
	public static int GetWidthCount(string s) => default; // 0x00BA9E80-0x00BA9FA0
	public void SetVisible(bool bEnable) {} // 0x00BA9FA0-0x00BAA090
	private void SetText(FukidashiConst.Type type, string text, float fSec) {} // 0x00BA9410-0x00BA9560
	private void ClearText(FukidashiConst.Type type) {} // 0x00BA9630-0x00BA96C0
	private void SetType(FukidashiConst.Type type) {} // 0x00BA9D80-0x00BA9D90
	private void PlayAnimation(AnimationType type) {} // 0x00BA96C0-0x00BA9800
	// [IteratorStateMachine] // 0x00623BB0-0x00623C20
	private IEnumerator ProcessAnimation_Open() => default; // 0x00BAA100-0x00BAA170
	// [IteratorStateMachine] // 0x00623C20-0x00623C90
	private IEnumerator ProcessAnimation_Close() => default; // 0x00BAA1E0-0x00BAA250
	// [IteratorStateMachine] // 0x00623C90-0x00623D00
	private IEnumerator ProcessAnimation_OpenWaza() => default; // 0x00BAA090-0x00BAA100
	// [IteratorStateMachine] // 0x00623D00-0x00623D70
	private IEnumerator ProcessAnimation_CloseWaza() => default; // 0x00BAA170-0x00BAA1E0
}

