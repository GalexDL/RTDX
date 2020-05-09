/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Plugins
{
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 3594
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin() {} // 0x004D3520-0x004D3570
		static StringPlugin() {} // 0x004D3570-0x004D3610
	
		// Methods
		public override void Reset(TweenerCore<string, string, StringOptions> t) {} // 0x004D2540-0x004D2550
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value) => default; // 0x004D2550-0x004D2560
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t) {} // 0x004D2560-0x004D2570
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t) {} // 0x004D2570-0x004D2630
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) => default; // 0x004D2630-0x004D2680
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D2680-0x004D2B10
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) => default; // 0x004D2B10-0x004D3240
		private char[] ScrambledCharsToUse(StringOptions options) => default; // 0x004D3240-0x004D33A0
	}
}
