/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ngc
{
	public sealed class ProfanityFilter : IDisposable // TypeDefIndex: 8963
	{
		// Fields
		private IntPtr _profanityFilter; // 0x10
		private IntPtr _ngcWorkBuffer; // 0x18
	
		// Nested types
		public enum MaskMode // TypeDefIndex: 8964
		{
			OverWrite = 0,
			ReplaceByOneCharacter = 1
		}
	
		public enum SkipMode // TypeDefIndex: 8965
		{
			NotSkip = 0,
			SkipAtSign = 1
		}
	
		[Flags] // 0x006138D0-0x006138E0
		public enum PatternList // TypeDefIndex: 8966
		{
			Japanese = 1,
			AmericanEnglish = 2,
			CanadianFrench = 4,
			LatinAmericanSpanish = 8,
			BritishEnglish = 16,
			Max = 16,
			French = 32,
			German = 64,
			Italian = 128,
			Spanish = 256,
			Dutch = 512,
			Korean = 1024,
			SimplifiedChinese = 2048,
			Portuguese = 4096,
			Russian = 8192,
			SouthAmericanPortuguese = 16384,
			TraditionalChinese = 32768
		}
	
		// Constructors
		public ProfanityFilter() {} // 0x00AEAF50-0x00AEAFE0
		public ProfanityFilter(bool checkDesiredLanguage) {} // 0x00AEB000-0x00AEB090
	
		// Methods
		~ProfanityFilter() {} // 0x00AEB090-0x00AEB160
		public void Dispose() {} // 0x00AEB1E0-0x00AEB2B0
		private void Dispose(bool disposing) {} // 0x00AEB160-0x00AEB1E0
		public uint GetContentVersion() => default; // 0x00AEB2C0-0x00AEB2D0
		public Result CheckProfanityWords(out PatternList[] checkResults, PatternList patterns, string[] words) {
			checkResults = default;
			return default;
		} // 0x00AEB2E0-0x00AEB300
		public Result MaskProfanityWordsInText(ref int profanityWordCount, string inText, out string outText, PatternList patterns) {
			outText = default;
			return default;
		} // 0x00AEB4B0-0x00AEB580
		public void SetMaskMode(MaskMode mode) {} // 0x00AEB5B0-0x00AEB5C0
		public void SkipAtSignCheck(SkipMode skipMode) {} // 0x00AEB5D0-0x00AEB5E0
		private static extern void Destroy(IntPtr profanityFilter, IntPtr ngcWorkBuffer); // 0x00AEB2B0-0x00AEB2C0
		private static extern Result Initialize(ref IntPtr profanityFilter, ref IntPtr ngcWorkBuffer, bool checkDesiredLanguage); // 0x00AEAFE0-0x00AEB000
		private static extern uint GetContentVersion(IntPtr profanityFilter); // 0x00AEB2D0-0x00AEB2E0
		private static extern Result CheckProfanityWords(IntPtr profanityFilter, out PatternList[] checkResults, PatternList patterns, string[] words, long wordCount); // 0x00AEB300-0x00AEB4B0
		private static extern Result MaskProfanityWordsInText(IntPtr profanityFilter, ref int profanityWordCount, string text, PatternList patterns); // 0x00AEB580-0x00AEB5B0
		private static extern void SetMaskMode(IntPtr profanityFilter, MaskMode mode); // 0x00AEB5C0-0x00AEB5D0
		private static extern void SkipAtSignCheck(IntPtr profanityFilter, SkipMode skipMode); // 0x00AEB5E0-0x00AEB5F0
	}
}
