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
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 3596
	{
		// Constructors
		public FloatPlugin() {} // 0x004CFB50-0x004CFBA0
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t) {} // 0x004CF8E0-0x004CF8F0
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value) => default; // 0x004CF8F0-0x004CF900
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t) {} // 0x004CF900-0x004CF920
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t) {} // 0x004CF920-0x004CF940
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) => default; // 0x004CF940-0x004CF960
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CF960-0x004CFB50
	}
}
