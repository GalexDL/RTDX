/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FaceWindow_UI : MonoBehaviour // TypeDefIndex: 8056
{
	// Fields
	public RectTransform RootTransformRef; // 0x18
	public CanvasGroup RootCanvasControlRef; // 0x20
	public RawImage FaceImageRef; // 0x28
	private int lastBasePosX_; // 0x30
	private int lastBasePosY_; // 0x34
	private const int FACE_TEX_WIDTH_ = 256; // Metadata: 0x00613C46
	private const int FACE_TEX_HEIGHT_ = 512; // Metadata: 0x00613C4A
	private const int FACE_SLIDE_WIDTH_ = 64; // Metadata: 0x00613C4E
	private const int FACE_SLIDE_HEIGHT_ = 64; // Metadata: 0x00613C52
	private const int FACE_SIZE_WIDTH_ = 56; // Metadata: 0x00613C56
	private const int FACE_SIZE_HEIGHT_ = 56; // Metadata: 0x00613C5A

	// Nested types
	private enum FaceUvType_ // TypeDefIndex: 8057
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
	public FaceWindow_UI() {} // 0x0080C0F0-0x0080C100

	// Methods
	private void Start() {} // 0x0080BD20-0x0080BD30
	private void Update() {} // 0x0080BD30-0x0080BD40
	public void Open(int x, int y, Index index, bool bFemale, bool bIsFrameDisp, FACE_TYPE eFaceType, bool bFlip) {} // 0x0080BD40-0x0080BF90
	public void SetOffset(int x, int y) {} // 0x0080BFA0-0x0080C030
	public void Close() {} // 0x0080C030-0x0080C040
	public void ChangeFace(FACE_TYPE eFaceType) {} // 0x0080C040-0x0080C0F0
}

