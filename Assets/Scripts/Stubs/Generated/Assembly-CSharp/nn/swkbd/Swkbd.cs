/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.swkbd
{
	public static class Swkbd // TypeDefIndex: 8941
	{
		// Fields
		public const int TextMaxLength = 500; // Metadata: 0x00630E1B
		public const int SeparateModeTextMaxLength = 24; // Metadata: 0x00630E1F
		public const int HeaderTextMaxLength = 64; // Metadata: 0x00630E23
		public const int SubTextMaxLength = 128; // Metadata: 0x00630E27
		public const int GuideTextMaxLength = 256; // Metadata: 0x00630E2B
		public const int OkTextMaxLength = 8; // Metadata: 0x00630E2F
		public const int UnfixedStringLengthMax = 24; // Metadata: 0x00630E33
		public const int UserWordMax = 1000; // Metadata: 0x00630E37
		public const int DialogTextMaxLength = 500; // Metadata: 0x00630E3B
		public const int SepareteTextPosMax = 8; // Metadata: 0x00630E3F
		public const int CustomizedDicionarySetMax = 24; // Metadata: 0x00630E43
	
		// Properties
		public static ErrorRange ResultCanceled { get; } // 0x00AEFDB0-0x00AEFE10 
	
		// Methods
		public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) => default; // 0x00AEDE00-0x00AEDFE0
		public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) => default; // 0x00AEE0E0-0x00AEE280
		public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) => default; // 0x00AEE350-0x00AEE460
		public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) => default; // 0x00AEE460-0x00AEE540
		private static extern Result ShowKeyboard([In, Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg); // 0x00AEE000-0x00AEE0E0
		private static extern Result ShowKeyboard([In, Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg); // 0x00AEE280-0x00AEE350
		public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig); // 0x00AEE540-0x00AEE5D0
		public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset); // 0x00AEE5D0-0x00AEE670
		public static extern long GetRequiredStringBufferSize(); // 0x00AEE670-0x00AEE680
		public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code); // 0x00AEE680-0x00AEE720
		public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] code); // 0x00AEE720-0x00AEE7C0
		public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code); // 0x00AEE7C0-0x00AEE860
		public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] code); // 0x00AEE860-0x00AEE900
		public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, in string pStr); // 0x00AEE900-0x00AEE9A0
		public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] pStr); // 0x00AEE9A0-0x00AEEA40
		public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, in string pStr); // 0x00AEEA40-0x00AEEAE0
		public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] pStr); // 0x00AEEAE0-0x00AEEB80
		public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, in string pStr); // 0x00AEEB80-0x00AEEC20
		public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] pStr); // 0x00AEEC20-0x00AEECC0
		public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, in string pStr); // 0x00AEECC0-0x00AEED60
		public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, in byte[] pStr); // 0x00AEED60-0x00AEEE00
		public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, in string pStr); // 0x00AEEE00-0x00AEEF60
		public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, in byte[] pStr); // 0x00AEEF60-0x00AEF0C0
		public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, in UserWord[] pUserWord, int userWordNum); // 0x00AEF0C0-0x00AEF2F0
		public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, in TextCheckCallback pCallback); // 0x00AEF2F0-0x00AEF450
		public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet); // 0x00AEF450-0x00AEF5B0
		public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck); // 0x00AEF5B0-0x00AEF710
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) {} // 0x00AEF710-0x00AEF860
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) {} // 0x00AEF860-0x00AEF9B0
		public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck); // 0x00AEF9B0-0x00AEFB10
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) {} // 0x00AEFB10-0x00AEFC60
		public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg); // 0x00AEFC60-0x00AEFDB0
		private static int GetByteSize(StringBuilder sb) => default; // 0x00AEDFE0-0x00AEE000
	}
}
