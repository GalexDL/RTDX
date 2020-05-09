/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.swkbd
{
	public struct KeyboardConfig // TypeDefIndex: 8942
	{
		// Fields
		public KeyboardMode keyboardMode; // 0x10
		public string okText; // 0x18
		public char leftOptionalSymbolKey; // 0x20
		public char rightOptionalSymbolKey; // 0x22
		public bool isPredictionEnabled; // 0x24
		public InvalidChar invalidCharFlag; // 0x28
		public InitialCursorPos initialCursorPos; // 0x2C
		public string headerText; // 0x30
		public string subText; // 0x38
		public string guideText; // 0x40
		public int textMaxLength; // 0x48
		public int textMinLength; // 0x4C
		public PasswordMode passwordMode; // 0x50
		public InputFormMode inputFormMode; // 0x54
		public bool isUseNewLine; // 0x58
		public bool isUseUtf8; // 0x59
		public bool isUseBlurBackground; // 0x5A
		private int _initialStringOffset; // 0x5C
		private int _initialStringLength; // 0x60
		private int _userDictionaryOffset; // 0x64
		private int _userDictionaryNum; // 0x68
		private bool _isUseTextCheck; // 0x6C
		private IntPtr _textCheckCallback; // 0x70
		public int[] separateTextPos; // 0x78
		private DictionaryInfo[] _customizedDicInfoList; // 0x80
		private byte _customizedDicCount; // 0x88
		private byte[] _reserved; // 0x90
	}
}
