/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UINamingControl // TypeDefIndex: 7141
{
	// Fields
	public static TextIDHash[] IDConfirmationTypeAsk; // 0x00
	public static TextIDHash[] IDConfirmationTypeYes; // 0x08
	public static TextIDHash[] IDConfirmationTypeNo; // 0x10
	private CommonScreen commonScreen_; // 0x10
	private bool bWaitScreen; // 0x18

	// Nested types
	public enum CancelConfig // TypeDefIndex: 7142
	{
		NONE = 0,
		B_CANCEL_CAPTION_CLOSE = 1,
		B_CANCEL_FOOTER_CLOSE = 2,
		B_CANCEL_NOT_CAPTION_CLOSE = 3,
		B_NOT_CANCELABLE = 4
	}

	public enum EnterConfig // TypeDefIndex: 7143
	{
		NONE = 0,
		FOOTER_CLOSE = 1,
		NOT_CLOSE = 2
	}

	public enum InputMode // TypeDefIndex: 7144
	{
		NONE = 0,
		INPUT_NAME_DEFAULT = 1,
		INPUT_NAME_NICKNAME = 2,
		INPUT_NAME_HERO = 3,
		INPUT_NAME_PARTNER = 4,
		INPUT_NAME_ACTOR = 5,
		INPUT_NAME_TEAM_FIRST = 6,
		INPUT_NAME_TEAM = 7,
		INPUT_RESCUE_PASSWORD = 8,
		INPUT_REVIVE_PASSWORD = 9,
		INPUT_WONDER_MAIL = 10,
		INPUT_NAME_EVOL = 11,
		INPUT_USER_ID = 12,
		INPUT_NAME_HERO_EVOL = 13
	}

	public enum ConfirmationType // TypeDefIndex: 7145
	{
		DEFAULT = 0,
		HERO = 1,
		ACTOR = 2,
		TEAM = 3,
		EVOL = 4,
		NONE = 5
	}

	public class NamingParam // TypeDefIndex: 7146
	{
		// Fields
		public InputMode inputMode; // 0x10
		public CancelConfig cancelConfig; // 0x14
		public EnterConfig enterConfig; // 0x18
		public string inputText; // 0x20
		public Index pokemonIndex; // 0x28
		public List<string> RandomNameCandidate; // 0x30
		public string firstText; // 0x38

		// Constructors
		public NamingParam() {} // 0x00DDB670-0x00DDB6D0
	}

	// Constructors
	public UINamingControl() {} // 0x00DDA070-0x00DDA080
	static UINamingControl() {} // 0x00DDA080-0x00DDA170

	// Methods
	// [IteratorStateMachine] // 0x0062A4A0-0x0062A510
	public IEnumerator EnterTextWindow(string initText, Action<string> strResult, InputMode mode, Action<bool> boolResult = null) => default; // 0x00DD9670-0x00DD9700
	// [IteratorStateMachine] // 0x0062A510-0x0062A580
	public IEnumerator EnterTextWindow(Index index, Action<string> strResult, Action<bool> boolResult = null) => default; // 0x00DD9730-0x00DD97C0
	// [IteratorStateMachine] // 0x0062A580-0x0062A5F0
	public IEnumerator EnterTextWindow(string initText, Index index, Action<string> strResult, CancelConfig config, InputMode mode, Action<bool> boolResult = null) => default; // 0x00DD97F0-0x00DD98A0
	// [IteratorStateMachine] // 0x0062A5F0-0x0062A660
	public IEnumerator EnterTextWindow(NamingParam param, Action<string> strResult, Action<bool> boolResult = null) => default; // 0x00DD98D0-0x00DD9960
	// [IteratorStateMachine] // 0x0062A660-0x0062A6D0
	private IEnumerator MainFlowByLangage(NamingParam param, Action<string> strResult, Action<bool> boolResult, Action<List<string>> listAct = null) => default; // 0x00DD9990-0x00DD9A20
	// [IteratorStateMachine] // 0x0062A6D0-0x0062A740
	private IEnumerator ConfirmAsk(string confirmName, ConfirmationType cType, Action<bool> boolResult = null) => default; // 0x00DD9A50-0x00DD9AE0
	// [IteratorStateMachine] // 0x0062A740-0x0062A7B0
	private IEnumerator OpenCommonScreen() => default; // 0x00DD9B10-0x00DD9B80
	// [IteratorStateMachine] // 0x0062A7B0-0x0062A820
	private IEnumerator CloseSwitch(CancelConfig cConfig, EnterConfig eConfig, bool bResult) => default; // 0x00DD9BB0-0x00DD9C50
	// [IteratorStateMachine] // 0x0062A820-0x0062A890
	private IEnumerator CloseCommonScreen() => default; // 0x00DD9C80-0x00DD9CF0
	// [IteratorStateMachine] // 0x0062A890-0x0062A900
	private IEnumerator CloseFooter() => default; // 0x00DD9D20-0x00DD9D90
	private bool CheckNGword6NumCharacter(string name) => default; // 0x00DD9DC0-0x00DD9EC0
	public static List<string> GetRandomNameList() => default; // 0x00DD9EC0-0x00DDA070
}

