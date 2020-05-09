/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class EnterTextWindow : UIWindowBase // TypeDefIndex: 6225
{
	// Fields
	public const ushort CODE_BACK = 1; // Metadata: 0x00612ABF
	public const ushort CODE_FINISH = 2; // Metadata: 0x00612AC1
	public const ushort CODE_HIRA = 3; // Metadata: 0x00612AC3
	public const ushort CODE_KATA = 4; // Metadata: 0x00612AC5
	public const ushort CODE_KIGOU = 5; // Metadata: 0x00612AC7
	public const ushort CODE_ABC = 6; // Metadata: 0x00612AC9
	public const ushort CODE_OTHER = 7; // Metadata: 0x00612ACB
	public const ushort CODE_INS_OVR = 8; // Metadata: 0x00612ACD
	public const ushort CODE_SPACE = 32; // Metadata: 0x00612ACF
	public const ushort CODE_SPACE_ON_PALETTE = 93; // Metadata: 0x00612AD1
	public const ushort CODE_IDEOGRAPHIC_SPACE = 12288; // Metadata: 0x00612AD3
	public const ushort CODE_VOICED = 12443; // Metadata: 0x00612AD5
	public const ushort CODE_SEMIVOICED = 12444; // Metadata: 0x00612AD7
	protected int LineNum; // 0x30
	protected const int ConstWordCountPerEnterLine = 13; // Metadata: 0x00612AD9
	protected const int SideButtonNum = 6; // Metadata: 0x00612ADD
	protected int MaxInput; // 0x34
	protected static LanguagePalette[,] HiraganaPalette; // 0x00
	protected static LanguagePalette[,] KatakanaPalette; // 0x08
	protected static LanguagePalette[,] KigouPalette; // 0x10
	protected static LanguagePalette[,] ABCPalette; // 0x18
	protected static LanguagePalette[,] OtherPalette; // 0x20
	protected static LanguagePalette[,] WonderMailPalette; // 0x28
	protected static LanguagePalette[,] PassPaletteOld; // 0x30
	protected static LanguagePalette[,] PassPalette; // 0x38
	private CallbackAction callbackFunc_; // 0x38
	private bool doUp; // 0x40
	private bool doDown; // 0x41
	private bool doLeft; // 0x42
	private bool doRight; // 0x43
	private int pressing; // 0x44
	private const int start = 4; // Metadata: 0x00612AE1
	private const int interval = 1; // Metadata: 0x00612AE5
	protected int presentX; // 0x48
	protected int presentY; // 0x4C
	protected int presentInputNum; // 0x50
	protected int presentInputCursor; // 0x54
	protected bool bSoundDuplicateFlag; // 0x58

	// Nested types
	public class LanguagePalette // TypeDefIndex: 6226
	{
		// Properties
		public ushort code { get; set; } // 0x00BCCEE0-0x00BCCEF0 0x00BDE530-0x00BDE540
		public ushort Other1 { get; set; } // 0x00BDE540-0x00BDE550 0x00BDE550-0x00BDE560
		public ushort Other2 { get; set; } // 0x00BDE560-0x00BDE570 0x00BDE570-0x00BDE580
		public ushort Other3 { get; set; } // 0x00BDE580-0x00BDE590 0x00BDE590-0x00BDE5A0
		public bool availableInPassword { get; set; } // 0x00BDE5A0-0x00BDE5B0 0x00BDE5B0-0x00BDE5C0
		public bool canUse { get; set; } // 0x00BDE5C0-0x00BDE5D0 0x00BDE5D0-0x00BDE5E0
		public bool touchPressed { get; set; } // 0x00BDE5E0-0x00BDE5F0 0x00BDE5F0-0x00BDE600

		// Constructors
		public LanguagePalette() {} // 0x00BDE600-0x00BDE630
		public LanguagePalette(ushort c, ushort o1, ushort o2, ushort o3, bool g) {} // 0x00BCCA10-0x00BCCA80
	}

	public enum ActionType // TypeDefIndex: 6227
	{
		Selecting = 0,
		Decide = 1,
		Cancel = 2
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6228; 0x00BCF640-0x00BCF9F0

	// Constructors
	public EnterTextWindow() {} // 0x00BD0320-0x00BD0340
	static EnterTextWindow() {} // 0x00BD0340-0x00BDE480

	// Methods
	public void RegisterActionListener(CallbackAction cb) {} // 0x00BCF450-0x00BCF540
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00BCF540-0x00BCF630
	public void callAction(ActionType action) {} // 0x00BCF630-0x00BCF640
	protected override void _doUpdate() {} // 0x00BCF9F0-0x00BCFA30
	protected virtual void _doInput() {} // 0x00BCFA30-0x00BCFFC0
	protected virtual void CoordinateReset() {} // 0x00BCFFC0-0x00BCFFD0
	protected virtual bool _doUp() => default; // 0x00BCFFD0-0x00BD0000
	protected virtual bool _doDown() => default; // 0x00BD0000-0x00BD0020
	protected virtual bool _doLeft() => default; // 0x00BD0020-0x00BD0040
	protected virtual bool _doRight() => default; // 0x00BD0040-0x00BD0060
	protected virtual bool _doAct() => default; // 0x00BD0060-0x00BD0080
	protected virtual bool _doActing() => default; // 0x00BD0080-0x00BD00A0
	protected virtual bool _doEnter(int x, int y, bool bTouch = false /* Metadata: 0x00612ABE */) => default; // 0x00BD00A0-0x00BD00B0
	protected virtual bool _doEntering(int x, int y) => default; // 0x00BD00B0-0x00BD00C0
	protected virtual bool _doCancel() => default; // 0x00BD00C0-0x00BD00E0
	protected virtual bool _doDelete() => default; // 0x00BD00E0-0x00BD0100
	protected virtual bool _doFormChange() => default; // 0x00BD0100-0x00BD0110
	protected virtual bool _doPaletteChange() => default; // 0x00BD0110-0x00BD0120
	protected virtual bool _doShiftLeft() => default; // 0x00BD0120-0x00BD0140
	protected virtual bool _doShiftLeftBase() => default; // 0x00BD0140-0x00BD0160
	protected virtual bool _doShiftRight() => default; // 0x00BD0160-0x00BD0190
	protected virtual bool _doShiftRightBase() => default; // 0x00BD0190-0x00BD01C0
	protected virtual bool _doDecide() => default; // 0x00BD01C0-0x00BD0230
	protected virtual bool _doDiscontinue() => default; // 0x00BD0230-0x00BD0240
	protected virtual bool _doTouchEnded(Vector3 touch) => default; // 0x00BD0240-0x00BD0250
	protected virtual bool _doTouchAnimation(Vector2 touch, TouchPhase phase) => default; // 0x00BD0250-0x00BD0260
	protected virtual void PlaySe(string seName) {} // 0x00BD0260-0x00BD0320
}

