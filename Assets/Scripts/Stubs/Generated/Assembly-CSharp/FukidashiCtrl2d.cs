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
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A1D0-0x0060A1E0
public class FukidashiCtrl2d : MonoBehaviour // TypeDefIndex: 5995
{
	// Fields
	public float BASE_WIDTH; // 0x18
	public float BASE_HEIGHT; // 0x1C
	public float BASE_CLIENT_WIDTH; // 0x20
	public float BASE_CLIENT_HEIGHT; // 0x24
	public float BASE_CLIENT_WIDTH_02; // 0x28
	public float BASE_CLIENT_HEIGHT_02; // 0x2C
	public float BASE_CLIENT_WIDTH_03; // 0x30
	public float BASE_CLIENT_HEIGHT_03; // 0x34
	public bool bDebugString; // 0x38
	public string stDebugString; // 0x40
	public string stDebugString1; // 0x48
	private float m_fAddSizeW; // 0x50
	private float m_fAddSizeH; // 0x54
	private float m_fAnimationScale; // 0x58
	public GameObject frameObject; // 0x60
	public GameObject textObject; // 0x68
	private Queue<RequestData> m_requestQueue; // 0x70
	private bool m_bVisible; // 0x78
	private bool m_bVisibleMesh; // 0x79
	private bool m_bDirtyVisible; // 0x7A
	private CreatureUniqueId m_creatureId; // 0x80
	private FukidashiConst.Type m_type; // 0x88
	private FukidashiConst.Type m_prevType; // 0x8C
	private TextData[] m_aTextData; // 0x90
	private RectTransform m_rectTransform; // 0x98
	private RectTransform m_rectTransformText; // 0xA0
	private Image m_frameImage; // 0xA8
	private CanvasGroup m_canvasGroup; // 0xB0
	private UIControlTMP m_textCtrl; // 0xB8
	private AnimationType m_animeType; // 0xC0
	private ResourceCache.Resource m_bundle; // 0xC8
	private float m_fVisibleTimer; // 0xD0
	private float m_fReserveTimerForMutter; // 0xD4
	private bool m_bAnimationOpenBreak; // 0xD8
	private bool m_bDirtySize; // 0xD9
	private bool m_bDirtyAnimationScale; // 0xDA

	// Nested types
	public enum AnimationType // TypeDefIndex: 5996
	{
		None = 0,
		Open = 1,
		Close = 2
	}

	public enum RequestType // TypeDefIndex: 5997
	{
		None = 0,
		Appear = 1,
		Disappear = 2
	}

	private class RequestData // TypeDefIndex: 5998
	{
		// Fields
		public RequestType req; // 0x10
		public CreatureUniqueId creature; // 0x18
		public FukidashiConst.Type type; // 0x20
		public string text; // 0x28
		public float delaySec; // 0x30
		public float fOverwriteVisibleTimer; // 0x34
		public Func<bool> flipJudgeFunc; // 0x38

		// Constructors
		public RequestData() {} // 0x00BAC510-0x00BAC570
	}

	private class TextData // TypeDefIndex: 5999
	{
		// Fields
		public string text; // 0x10
		public int returnNum; // 0x18
		public int widthMaxCount; // 0x1C
		public float fOverwriteVisibleTimer; // 0x20

		// Constructors
		public TextData() {} // 0x00BAD840-0x00BAD8A0
	}

	// Constructors
	public FukidashiCtrl2d() {} // 0x00BAC9D0-0x00BACAB0

	// Methods
	private void OnEnable() {} // 0x00BAB2E0-0x00BAB2F0
	private void OnDisable() {} // 0x00BAB2F0-0x00BAB300
	// [IteratorStateMachine] // 0x00623D70-0x00623DE0
	private IEnumerator Start() => default; // 0x00BAB300-0x00BAB370
	private void OnDestroy() {} // 0x00BAB3A0-0x00BAB460
	private void UpdateVisible(bool bVisible) {} // 0x00BAB460-0x00BAB480
	private void GetClientWH(out float tw, out float th) {
		tw = default;
		th = default;
	} // 0x00BAB480-0x00BAB4E0
	private float CalcAlignSizeW(float tw) => default; // 0x00BAB4E0-0x00BAB5B0
	private float CalcAlignSizeH(float th) => default; // 0x00BAB5B0-0x00BAB670
	private void Update() {} // 0x00BAB670-0x00BABC10
	private void LateUpdate() {} // 0x00BAC040-0x00BAC050
	private void CheckAppear(FukidashiConst.Type type, Func<bool> flipJudgeFunc) {} // 0x00BABD90-0x00BABE70
	private void CheckNextAppear(FukidashiConst.Type type) {} // 0x00BAC3B0-0x00BAC460
	private void CheckNextAppear() {} // 0x00BAC460-0x00BAC510
	public void Request(RequestType req, FukidashiConst.Type type, string text, float fOverwriteVisibleTimer, Func<bool> func) {} // 0x00BA8730-0x00BA8830
	private void Appear(FukidashiConst.Type type, Func<bool> flipJudgeFunc) {} // 0x00BAC050-0x00BAC3B0
	public static int GetReturnNum(string s) => default; // 0x00BAC580-0x00BAC600
	public static int GetWidthCount(string s) => default; // 0x00BAC600-0x00BAC720
	public void SetVisible(bool bEnable) {} // 0x00BA8970-0x00BA89A0
	private void SetVisibleMesh(bool bEnable) {} // 0x00BABC10-0x00BABC40
	private void SetText(FukidashiConst.Type type, string text, float fSec) {} // 0x00BABC40-0x00BABD90
	private void ClearText(FukidashiConst.Type type) {} // 0x00BABE70-0x00BABF00
	private void SetType(FukidashiConst.Type type) {} // 0x00BAC570-0x00BAC580
	private void PlayAnimation(AnimationType type) {} // 0x00BABF00-0x00BAC040
	private void SetAnimationScale(float scale) {} // 0x00BAC8E0-0x00BAC900
	private float GetAnimationScale() => default; // 0x00BAC900-0x00BAC910
	// [IteratorStateMachine] // 0x00623DE0-0x00623E50
	private IEnumerator ProcessAnimation_Open() => default; // 0x00BAC790-0x00BAC800
	// [IteratorStateMachine] // 0x00623E50-0x00623EC0
	private IEnumerator ProcessAnimation_Close() => default; // 0x00BAC870-0x00BAC8E0
	// [IteratorStateMachine] // 0x00623EC0-0x00623F30
	private IEnumerator ProcessAnimation_OpenWaza() => default; // 0x00BAC720-0x00BAC790
	// [IteratorStateMachine] // 0x00623F30-0x00623FA0
	private IEnumerator ProcessAnimation_CloseWaza() => default; // 0x00BAC800-0x00BAC870
}

