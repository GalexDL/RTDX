/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FadeConst;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A060-0x0060A070
public class Fader : SingletonMonoBehaviour<Fader> // TypeDefIndex: 5785
{
	// Fields
	private Material material_; // 0x18
	private FadeWork_[] aFadeWork_; // 0x20
	private Color[] s_aColor; // 0x28
	private bool isDebugFadeForceOff_; // 0x30

	// Properties
	public static float DefaultSec { get => default; } // 0x0080C1A0-0x0080C1B0 
	public bool DebugFadeForceOff { get => default; set {} } // 0x0080DED0-0x0080DEE0 0x0080DEE0-0x0080DEF0

	// Nested types
	public enum FadeType // TypeDefIndex: 5786
	{
		IN = 0,
		OUT = 1,
		MAX = 2,
		NONE = 2
	}

	public enum ColorType // TypeDefIndex: 5787
	{
		BLACK = 0,
		WHITE = 1,
		SOMEWHAT_WHITE = 2,
		CAPTURE = 3
	}

	private class FadeWork_ // TypeDefIndex: 5788
	{
		// Fields
		private FaderPlane faderPlane; // 0x10
		private CommonCanvas.UIPriority uiPriority; // 0x18
		public float fNowSec; // 0x1C
		public float fEndSec; // 0x20
		public float fStepSec; // 0x24
		public bool bStartFrame; // 0x28
		public Color color; // 0x2C
		public Color startColor; // 0x3C
		public Color endColor; // 0x4C
		public int count; // 0x5C
		public bool bCapture; // 0x60

		// Constructors
		public FadeWork_() {} // Dummy constructor
		public FadeWork_(CommonCanvas.UIPriority uiPriority_) {} // 0x0080EDD0-0x0080EED0

		// Methods
		public void Reset() {} // 0x0080F1F0-0x0080F220
		public void ResetFrame() {} // 0x0080CF00-0x0080CF20
		public bool IsEndStatus() => default; // 0x0080C960-0x0080C970
		public void AttachCanvas() {} // 0x0080C3B0-0x0080C5D0
		public void DetachCanvas() {} // 0x0080C640-0x0080C780
		public void Update(float deltaTime, int pattern) {} // 0x0080E000-0x0080E170
		public void Render() {} // 0x0080E170-0x0080E600
		public void DebugForceClear() {} // 0x0080E600-0x0080E6F0
	}

	// Constructors
	public Fader() {} // 0x0080E6F0-0x0080EDD0

	// Methods
	public static void Startup() {} // 0x0080C1B0-0x0080C270
	public static void Shutdown() {} // 0x0080C270-0x0080C2E0
	public void OnEnable() {} // 0x0080C2E0-0x0080C3B0
	public void OnDisable() {} // 0x0080C5D0-0x0080C640
	private void OnDestroy() {} // 0x0080C780-0x0080C7F0
	private void OnApplicationQuit() {} // 0x0080C7F0-0x0080C860
	private FadeWork_ GetWork_(Pattern pattern) => default; // 0x0080C860-0x0080C8B0
	private bool IsFadeouted(Pattern pattern) => default; // 0x0080C8B0-0x0080C960
	private bool IsFadeined(Pattern pattern) => default; // 0x0080C970-0x0080CA20
	public bool IsFadeComplete(FadeType eType, Pattern pattern) => default; // 0x0080CA20-0x0080CB40
	public bool IsFadeEnd(Pattern pattern) => default; // 0x0080CB40-0x0080CB90
	public bool IsFadeAllEnd() => default; // 0x0080CB90-0x0080CC90
	public void SetFadeParameter(FadeType eFadeType, ColorType eColorType, float fSec, Pattern ePattern) {} // 0x0080CC90-0x0080CE00
	public void SetColorFadeParameter(Color colorS, Color colorE, float fSec, Pattern ePattern) {} // 0x0080CE00-0x0080CF00
	public Color GetColor(Pattern ePattern) => default; // 0x0080CF20-0x0080CF70
	public void ClearFadeAll() {} // 0x0080CF70-0x0080CFF0
	public void FadeClearTopAndUIBack() {} // 0x0080CFF0-0x0080D190
	public void Fadein(ColorType eColorType, float fSec, Pattern pattern) {} // 0x0080D190-0x0080D270
	public void Fadeout(ColorType eColorType, float fSec, Pattern pattern) {} // 0x0080D270-0x0080D350
	public void CaptureCrossFadein(float fSec) {} // 0x0080D350-0x0080D420
	public bool IsFadeAllClear() => default; // 0x0080D420-0x0080D620
	public bool IsNeedAutoFadeIn() => default; // 0x0080D620-0x0080DA60
	public void AutoFadein(float fSec) {} // 0x0080DA60-0x0080DC40
	// [IteratorStateMachine] // 0x00621D10-0x00621D80
	public IEnumerator Wait(Pattern pattern) => default; // 0x0080DC40-0x0080DCC0
	// [IteratorStateMachine] // 0x00621D80-0x00621DF0
	public IEnumerator WaitAll() => default; // 0x0080DCF0-0x0080DD60
	public Color GetColorFilterColor() => default; // 0x0080DD90-0x0080DDE0
	public void SetColorFilterParameter(Color colorS, Color colorE, float fSec) {} // 0x0080DDE0-0x0080DED0
	private void LateUpdate() {} // 0x0080DEF0-0x0080E000
}

