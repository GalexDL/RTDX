/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.hid;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class InputSystem : Singleton<InputSystem>, IInput // TypeDefIndex: 5542
{
	// Fields
	public const float DEFAULT_INVALID_MOMENT_TIME_SEC = 0.15f; // Metadata: 0x00611BC9
	private const float MOMENT_TIME_SEC = 0.2f; // Metadata: 0x00611BCD
	private Vector3 vTouchPosition_; // 0x10
	private Vector3 vRightTouchPosition_; // 0x1C
	private NpadId npadId_; // 0x28
	private NpadStyle npadStyle_; // 0x2C
	private NpadState npadState_; // 0x30
	private const int MAX_TOUCH = 2; // Metadata: 0x00611BD1
	private TouchParameter[] aTouchBuffer_; // 0x60
	private bool bEscapeDown_; // 0x68
	private int nTouchCount_; // 0x6C
	private int nToNativeTouchCount_; // 0x70
	private int nFixedUpdateCount_; // 0x74
	private uint lastPadData_; // 0x78
	private uint lastToNativePadData_; // 0x7C
	private uint lastPadDown_; // 0x80
	private uint lastPadUp_; // 0x84
	private uint lastPadRepeat_; // 0x88
	private uint lastPadMoment_; // 0x8C
	private Vector2 lastAnalogL; // 0x90
	private Vector2 lastAnalogR; // 0x98
	private const int MAX_TABLE = 32; // Metadata: 0x00611BD5
	private int[] lastPadRepeatCntTbl_; // 0xA0
	private float[] lastPadMomentTbl_; // 0xA8
	private string lastPadKeyDebugNames_; // 0xB0
	public const uint PAD_BUTTON_A = 1; // Metadata: 0x00611BD9
	public const uint PAD_BUTTON_B = 2; // Metadata: 0x00611BDD
	public const uint PAD_BUTTON_X = 1024; // Metadata: 0x00611BE1
	public const uint PAD_BUTTON_Y = 2048; // Metadata: 0x00611BE5
	public const uint PAD_BUTTON_R = 256; // Metadata: 0x00611BE9
	public const uint PAD_BUTTON_L = 512; // Metadata: 0x00611BED
	public const uint PAD_BUTTON_ZR = 4096; // Metadata: 0x00611BF1
	public const uint PAD_BUTTON_ZL = 8192; // Metadata: 0x00611BF5
	public const uint PAD_BUTTON_SR = 16384; // Metadata: 0x00611BF9
	public const uint PAD_BUTTON_SL = 32768; // Metadata: 0x00611BFD
	public const uint PAD_BUTTON_SELECT = 4; // Metadata: 0x00611C01
	public const uint PAD_BUTTON_START = 8; // Metadata: 0x00611C05
	public const uint PAD_BUTTON_RIGHT = 16; // Metadata: 0x00611C09
	public const uint PAD_BUTTON_LEFT = 32; // Metadata: 0x00611C0D
	public const uint PAD_BUTTON_UP = 64; // Metadata: 0x00611C11
	public const uint PAD_BUTTON_DOWN = 128; // Metadata: 0x00611C15
	public const uint PAD_BUTTON_DEBUG = 4096; // Metadata: 0x00611C19
	public const uint PAD_BUTTON_ALL = 65535; // Metadata: 0x00611C1D
	public const uint PAD_BUTTON_AUTO_WALK_CANCEL = 53247; // Metadata: 0x00611C21
	public const uint PAD_BUTTON_DIR = 240; // Metadata: 0x00611C25
	public const uint PAD_BUTTON_UP_R = 262144; // Metadata: 0x00611C29
	public const uint PAD_BUTTON_DOWN_R = 524288; // Metadata: 0x00611C2D
	public const uint PAD_BUTTON_SHORTCUT_RIGHT = 1048576; // Metadata: 0x00611C31
	public const uint PAD_BUTTON_SHORTCUT_LEFT = 2097152; // Metadata: 0x00611C35
	public const uint PAD_BUTTON_SHORTCUT_UP = 4194304; // Metadata: 0x00611C39
	public const uint PAD_BUTTON_SHORTCUT_DOWN = 8388608; // Metadata: 0x00611C3D
	private const uint RepeatStartFrame = 8; // Metadata: 0x00611C41
	private const uint RepeatFrame = 2; // Metadata: 0x00611C45
	private bool bMomentInvalid_; // 0xB8
	private float momentInvalidTimeSec_; // 0xBC

	// Properties
	public bool LastTouchPositionEnable { get => default; } // 0x008F3950-0x008F3990 
	public bool LastTouchEdge { get => default; } // 0x008F3990-0x008F3A00 
	public bool LastTouchRelease { get => default; } // 0x008F3A50-0x008F3AC0 
	public Vector3 LastTouchPosition { get => default; } // 0x008F3AC0-0x008F3AD0 
	public int TouchCount { get => default; } // 0x008F3AD0-0x008F3AE0 
	public TouchParameter LastTouchParameter { get => default; } // 0x008F3A00-0x008F3A50 
	public uint LastPadData { get => default; } // 0x008F3B30-0x008F3B40 
	public uint LastPadDown { get => default; } // 0x008ECF50-0x008ECF60 
	public uint LastPadUp { get => default; } // 0x008F3B40-0x008F3B50 
	public uint LastPadRepeat { get => default; } // 0x008ECF40-0x008ECF50 
	public uint LastPadMoment { get => default; } // 0x008F3B50-0x008F3B60 

	// Nested types
	public class TouchParameter // TypeDefIndex: 5543
	{
		// Fields
		public Vector2 deltaPosition; // 0x10
		public float deltaTime; // 0x18
		public int fingerId; // 0x1C
		public TouchPhase phase; // 0x20
		public Vector2 position; // 0x24

		// Constructors
		public TouchParameter() {} // 0x008F5E50-0x008F5E60
	}

	// Constructors
	public InputSystem() {} // 0x008F6650-0x008F67E0

	// Methods
	public TouchParameter GetTouchParameter(int id) => default; // 0x008F3AE0-0x008F3B30
	private bool helper_padOneButtonCheck_(uint padDownPtn) => default; // 0x008F3B60-0x008F3B90
	private bool helper_padComboButtonCheck_(uint padDataPtn, uint padDownPtn) => default; // 0x008F3B90-0x008F3BC0
	private bool helper_padOneButtonCheck_withoutDirButton_(uint padDownPtn) => default; // 0x008F3BC0-0x008F3BF0
	private bool helper_padComboButtonCheck_withoutDirButton_(uint padDataPtn, uint padDownPtn) => default; // 0x008F3BF0-0x008F3C20
	public bool IsPad_MessageThrough() => default; // 0x008F3C20-0x008F3C40
	public bool IsPad_MenuCancel() => default; // 0x008F3C40-0x008F3CA0
	public bool IsPad_LookAroundCancel() => default; // 0x008F3CA0-0x008F3D10
	public bool IsPad_MenuDecide() => default; // 0x008F3D10-0x008F3D70
	public bool IsPad_MenuSkip() => default; // 0x008F3D70-0x008F3DD0
	public bool IsPad_MenuSkipLeft() => default; // 0x008F3DD0-0x008F3E50
	public bool IsPad_MenuSkipRight() => default; // 0x008F3E50-0x008F3ED0
	public bool IsPad_ChangeAutoButton() => default; // 0x008F3ED0-0x008F3EE0
	public bool IsPad_CancelAutoButton() => default; // 0x008F3EE0-0x008F3F00
	public bool IsPad_LookAround() => default; // 0x008F3F00-0x008F3FB0
	public bool IsPad_CallLanguageSelect() => default; // 0x008F3FB0-0x008F3FD0
	public bool IsPad_CallDebugDisplaySwitch() => default; // 0x008F3FD0-0x008F3FF0
	public bool IsPad_CallFukidashiVisible() => default; // 0x008F3FF0-0x008F4010
	public bool IsPad_ChangeSampleUI() => default; // 0x008F4010-0x008F4030
	public bool IsPad_OpenDebugMenu() => default; // 0x008F4030-0x008F4050
	public bool IsPad_ChangeThinkSokuori() => default; // 0x008F4050-0x008F4070
	public bool IsPad_OpenXButtonMenu() => default; // 0x008F4070-0x008F40A0
	public bool IsPad_OpenWazaShortcutMenu() => default; // 0x008F40A0-0x008F40B0
	public bool IsPad_OpenCustomShortcutMenu() => default; // 0x008F40B0-0x008F40C0
	public bool IsPad_OpenItemMenu() => default; // 0x008F40C0-0x008F40D0
	public bool IsPad_OpenHenseiShortcutMenu() => default; // 0x008F40D0-0x008F4100
	public bool IsPad_OpenHowToPlayShortcutMenu() => default; // 0x008F4100-0x008F4130
	public bool IsPad_MenuGeneralXButton() => default; // 0x008F4130-0x008F41B0
	public bool IsPad_MenuGeneralYButton() => default; // 0x008F41B0-0x008F4230
	public bool IsPad_MenuGeneralLButton() => default; // 0x008F4230-0x008F42B0
	public bool IsPad_MenuGeneralRButton() => default; // 0x008F42B0-0x008F4330
	public bool IsPad_MenuListMultiSelect() => default; // 0x008F4330-0x008F43B0
	public bool IsPad_MenuListMultiSelectAll() => default; // 0x008F43B0-0x008F4430
	public bool IsPad_MenuUp() => default; // 0x008F4430-0x008F4490
	public bool IsPad_MenuDown() => default; // 0x008F4490-0x008F44F0
	public bool IsPad_MenuLeft() => default; // 0x008F44F0-0x008F4550
	public bool IsPad_MenuRight() => default; // 0x008F4550-0x008F45B0
	public bool IsPad_MenuL() => default; // 0x008F45B0-0x008F4610
	public bool IsPad_MenuR() => default; // 0x008F4610-0x008F4670
	public bool IsPad_MenuScrollUp() => default; // 0x008F4670-0x008F46D0
	public bool IsPad_MenuScrollDown() => default; // 0x008F46D0-0x008F4730
	public bool IsPad_MenuChangeDetai() => default; // 0x008F4730-0x008F47B0
	public bool IsPad_MenuZRShiftOn() => default; // 0x008F47B0-0x008F4810
	public bool IsPad_MenuZRShiftOff() => default; // 0x008F4810-0x008F4870
	public bool IsPad_LeftScrollUp() => default; // 0x008F4870-0x008F48D0
	public bool IsPad_LeftScrollDown() => default; // 0x008F48D0-0x008F4930
	public bool IsPad_MenuFavorChange() => default; // 0x008F4930-0x008F49B0
	public bool IsPad_MenuWazaLearnTargets() => default; // 0x008F49B0-0x008F4A30
	public bool IsPad_TopMenuHide() => default; // 0x008F4A30-0x008F4A40
	public bool IsPad_TopMenuIndicate() => default; // 0x008F4A40-0x008F4A50
	public bool IsPad_TitleAnyBottun() => default; // 0x008F4A50-0x008F4A60
	public bool IsPad_OptionReset() => default; // 0x008F4A60-0x008F4A70
	public bool IsPad_EnterTextUp() => default; // 0x008F4A70-0x008F4A80
	public bool IsPad_EnterTextDown() => default; // 0x008F4A80-0x008F4A90
	public bool IsPad_EnterTextLeft() => default; // 0x008F4A90-0x008F4AA0
	public bool IsPad_EnterTextRight() => default; // 0x008F4AA0-0x008F4AB0
	public bool IsPad_EnterTextUp_Repeat() => default; // 0x008F4AB0-0x008F4AD0
	public bool IsPad_EnterTextDown_Repeat() => default; // 0x008F4AD0-0x008F4AF0
	public bool IsPad_EnterTextLeft_Repeat() => default; // 0x008F4AF0-0x008F4B10
	public bool IsPad_EnterTextRight_Repeat() => default; // 0x008F4B10-0x008F4B30
	public bool IsPad_EnterTextUp_Data() => default; // 0x008F4B30-0x008F4B40
	public bool IsPad_EnterTextDown_Data() => default; // 0x008F4B40-0x008F4B50
	public bool IsPad_EnterTextLeft_Data() => default; // 0x008F4B50-0x008F4B60
	public bool IsPad_EnterTextRight_Data() => default; // 0x008F4B60-0x008F4B70
	public bool IsPad_EnterTextCancel() => default; // 0x008F4B70-0x008F4B80
	public bool IsPad_EnterTextDelete() => default; // 0x008F4B80-0x008F4BB0
	public bool IsPad_EnterTextShiftL() => default; // 0x008F4BB0-0x008F4BE0
	public bool IsPad_EnterTextShiftR() => default; // 0x008F4BE0-0x008F4C10
	public bool IsPad_EnterTextAct() => default; // 0x008F4C10-0x008F4C20
	public bool IsPad_EnterTextActing() => default; // 0x008F4C20-0x008F4C50
	public bool IsPad_EnterTextFormChange() => default; // 0x008F4C50-0x008F4C60
	public bool IsPad_EnterTextPaletteChange() => default; // 0x008F4C60-0x008F4C70
	public bool IsPad_EnterTextDecide() => default; // 0x008F4C70-0x008F4C80
	public bool IsPad_EnterTextDiscontinue() => default; // 0x008F4C80-0x008F4C90
	public bool IsPad_NatureDiagnosisUp() => default; // 0x008F4C90-0x008F4CA0
	public bool IsPad_NatureDiagnosisUpperRight() => default; // 0x008F4CA0-0x008F4CB0
	public bool IsPad_NatureDiagnosisUpperLeft() => default; // 0x008F4CB0-0x008F4CC0
	public bool IsPad_NatureDiagnosisDown() => default; // 0x008F4CC0-0x008F4CD0
	public bool IsPad_NatureDiagnosisBottomRight() => default; // 0x008F4CD0-0x008F4CE0
	public bool IsPad_NatureDiagnosisBottomLeft() => default; // 0x008F4CE0-0x008F4CF0
	public bool IsPad_NatureDiagnosisRight() => default; // 0x008F4CF0-0x008F4D00
	public bool IsPad_NatureDiagnosisLeft() => default; // 0x008F4D00-0x008F4D10
	public bool IsPad_NatureDiagnosisDecide() => default; // 0x008F4D10-0x008F4D20
	public bool IsPad_DebugNatureDiagnosisSkip() => default; // 0x008F4D20-0x008F4D30
	public bool IsPad_Talk() => default; // 0x008F4D30-0x008F4D60
	public bool IsPad_GroundMoveDash() => default; // 0x008F4D60-0x008F4D70
	public bool IsPad_Rest() => default; // 0x008F4D70-0x008F4D90
	public bool IsPad_OpenLeaderChangeMenu() => default; // 0x008F4D90-0x008F4DA0
	public bool IsPad_OpenManual() => default; // 0x008F4DA0-0x008F4DC0
	public int GetPad_CustomShortcut() => default; // 0x008F4DC0-0x008F4E40
	public int GetPadData_CustomShortcut() => default; // 0x008F4E40-0x008F4EB0
	public int GetPadData_MapViewMode() => default; // 0x008F4EB0-0x008F4F30
	public bool IsPad_LinkSelect() => default; // 0x008F4F30-0x008F4FB0
	public bool IsPad_LinkSelect_InDictionary() => default; // 0x008F4FB0-0x008F4FC0
	public bool IsPad_LinkDecide() => default; // 0x008F4FC0-0x008F4FD0
	public bool IsPad_LinkCancel() => default; // 0x008F4FD0-0x008F4FE0
	public bool IsPad_LinkButtonL() => default; // 0x008F4FE0-0x008F4FF0
	public bool IsPad_LinkButtonR() => default; // 0x008F4FF0-0x008F5000
	public bool IsPad_LinkUp() => default; // 0x008F5000-0x008F5010
	public bool IsPad_LinkDown() => default; // 0x008F5010-0x008F5020
	public bool IsPad_LinkLeft() => default; // 0x008F5020-0x008F5030
	public bool IsPad_LinkRight() => default; // 0x008F5030-0x008F5040
	public bool IsPad_LinkY() => default; // 0x008F5040-0x008F5050
	public bool IsPad_LinkX() => default; // 0x008F5050-0x008F5060
	public bool IsPad_CampBGOpen() => default; // 0x008F5060-0x008F50C0
	public bool IsPad_CampBGClose() => default; // 0x008F50C0-0x008F5120
	public bool IsPad_CampInfoDisplayChange() => default; // 0x008F5120-0x008F5180
	public bool IsPad_WazaLearnListUpY() => default; // 0x008F5180-0x008F51C0
	public bool IsPad_DisplayWazaDetail() => default; // 0x008F51C0-0x008F5200
	public void ClearPad() {} // 0x008F5200-0x008F5360
	public Vector2 AnalogStick_L() => default; // 0x008F5360-0x008F5370
	public Vector2 AnalogStick_R() => default; // 0x008F5370-0x008F5380
	public Vector2 AnalogStick_PlayerMove() => default; // 0x008F5380-0x008F5480
	private void Init_Switch_() {} // 0x008F5480-0x008F5580
	private static bool UpdatePadState(ref NpadId npadId, ref NpadStyle npadStyle, ref NpadState npadState) => default; // 0x008F5580-0x008F56D0
	private void Update_Switch_(ref uint nowPadData, ref uint nowToNativePadData) {} // 0x008F56D0-0x008F5D20
	private void Initialize() {} // 0x008F5D20-0x008F5E50
	public static void Startup() {} // 0x008F5E60-0x008F5EE0
	public void SetInvalidMomentByTime(float invalidTimeSec = 0.15f /* Metadata: 0x00611BC5 */) {} // 0x008F5EE0-0x008F5F00
	public void Update(bool bEnable) {} // 0x008F5F00-0x008F6460
	public void SendToNative() {} // 0x008F6460-0x008F6650
}

