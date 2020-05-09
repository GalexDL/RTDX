/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A5D0-0x0060A5E0
public class UIFaceWindow : UIManagerBase // TypeDefIndex: 6894
{
	// Fields
	public const int DEFAULT_POSITION_X = 145; // Metadata: 0x00613101
	public const int DEFAULT_POSITION_Y = 604; // Metadata: 0x00613105
	protected UIPrefabLoader pl_; // 0x20
	protected CanvasGroup rootCanvasControlRef_; // 0x28
	protected RawImage faceImageRef_; // 0x30
	protected int resHandle_; // 0x38
	protected static ResourceCacheLimiter limitRes_; // 0x00
	protected int lastBasePosX_; // 0x3C
	protected int lastBasePosY_; // 0x40
	protected bool isLoading; // 0x44
	private int nPlaying_; // 0x48
	private bool bFavorite_; // 0x4C
	private bool bSkipRequest_; // 0x4D
	private const int FACE_TEX_WIDTH_ = 1024; // Metadata: 0x00613109
	private const int FACE_TEX_HEIGHT_ = 1024; // Metadata: 0x0061310D
	private const int FACE_SLIDE_WIDTH_ = 160; // Metadata: 0x00613111
	private const int FACE_SLIDE_HEIGHT_ = 160; // Metadata: 0x00613115
	private const int FACE_SIZE_WIDTH_ = 160; // Metadata: 0x00613119
	private const int FACE_SIZE_HEIGHT_ = 160; // Metadata: 0x0061311D

	// Properties
	public bool IsLoading { get => default; } // 0x00D75910-0x00D75920 

	// Nested types
	public enum StateIconType // TypeDefIndex: 6895
	{
		None = 0,
		Dying = 1,
		Faint = 2
	}

	public enum FaceUvType_ // TypeDefIndex: 6896
	{
		NORMAL = 0,
		HAPPY = 1,
		PAIN = 2,
		ANGRY = 3,
		THINK = 4,
		SAD = 5,
		WEEP = 6,
		SHOUT = 7,
		TEARS = 8,
		DECIDE = 9,
		GLADNESS = 10,
		EMOTION = 11,
		SURPRISE = 12,
		FAINT = 13,
		RELIEF = 14,
		CATCHBREATH = 15,
		SPECIAL01 = 16,
		SPECIAL02 = 17,
		SPECIAL03 = 18,
		SPECIAL04 = 19,
		SPECIAL05 = 20,
		SPECIAL06 = 21,
		SPECIAL07 = 22,
		SPECIAL08 = 23,
		SPECIAL09 = 24,
		SPECIAL10 = 25,
		SPECIAL11 = 26,
		SPECIAL12 = 27,
		SPECIAL13 = 28,
		SPECIAL14 = 29,
		SPECIAL15 = 30,
		SPECIAL16 = 31,
		MAX = 32
	}

	// Constructors
	public UIFaceWindow() {} // 0x00D76A50-0x00D76A60
	static UIFaceWindow() {} // 0x00D76A60-0x00D76A70

	// Methods
	private void Awake() {} // 0x00D756C0-0x00D757A0
	private void Start() {} // 0x00D757A0-0x00D75800
	private void OnDestroy() {} // 0x00D75800-0x00D75880
	private void Update() {} // 0x00D75900-0x00D75910
	private void ReleaseRes_() {} // 0x00D75880-0x00D75900
	public void ReleaseRes() {} // 0x00D75920-0x00D759D0
	public void Active(bool bActive) {} // 0x00D69240-0x00D69280
	public virtual void Open(int x, int y, Index index, bool bFemale, bool bIsFrameDisp, FACE_TYPE eFaceType, bool bFlip) {} // 0x00D759D0-0x00D75A50
	public void OpenFromGfxParameter(int x, int y, GraphicsSystem.CharacterDatabaseParameter param, bool bFemale, bool bIsFrameDisp, FACE_TYPE eFaceType, bool bFlip) {} // 0x00D75B30-0x00D75C00
	protected virtual void Open(int x, int y, string name, bool bIsFrameDisp, FACE_TYPE eFaceType, bool bFlip) {} // 0x00D75C80-0x00D761F0
	public void SetOffset(int x, int y) {} // 0x00D76200-0x00D76290
	public void VisibleFaceFrame(bool bVisible) {} // 0x00D76290-0x00D76360
	public void VisibleSugowazaFrame(bool bVisible) {} // 0x00D63370-0x00D63440
	public void VisibleCompanionFrame(bool bVisible) {} // 0x00D63580-0x00D63650
	public void VisibleStateIcon(StateIconType state) {} // 0x00D63440-0x00D63580
	public void VisibleIconFavorite(bool bVisible) {} // 0x00D6F1B0-0x00D6F2A0
	public void EffectFavoriteOn() {} // 0x00D76360-0x00D76530
	public void EffectFavoriteStop() {} // 0x00D765B0-0x00D765D0
	public bool IsEffectPlaying() => default; // 0x00D765D0-0x00D765E0
	private bool _IsSkip() => default; // 0x00D765E0-0x00D765F0
	// [IteratorStateMachine] // 0x00628930-0x006289A0
	private IEnumerator PlayEffectFavoriteOn(GameObject obj) => default; // 0x00D76530-0x00D765B0
	public void Close() {} // 0x00D76620-0x00D76720
	public void ChangeFace(FACE_TYPE eFaceType) {} // 0x00D76720-0x00D76940
	public void ChangeFace(FaceUvType_ uvType) {} // 0x00D76940-0x00D76A50
	protected string GetFaceFileName(Index index, FormType form, ref bool bFlip) => default; // 0x00D75A50-0x00D75B30
	private string GetFaceFileName(GraphicsSystem.CharacterDatabaseParameter param, FormType form, ref bool bFlip) => default; // 0x00D75C00-0x00D75C80
}

