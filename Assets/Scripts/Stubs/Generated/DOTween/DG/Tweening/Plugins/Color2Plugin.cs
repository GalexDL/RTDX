/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Plugins
{
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 3581
	{
		// Constructors
		public Color2Plugin() {} // 0x004CEC80-0x004CECD0
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x004CE570-0x004CE580
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value) => default; // 0x004CE580-0x004CE5A0
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x004CE5A0-0x004CE690
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x004CE690-0x004CE780
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) => default; // 0x004CE780-0x004CE790
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CE790-0x004CEC80
	}
}
