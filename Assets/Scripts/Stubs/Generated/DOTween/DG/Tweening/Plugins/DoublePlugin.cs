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
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 3582
	{
		// Constructors
		public DoublePlugin() {} // 0x004CF890-0x004CF8E0
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t) {} // 0x004CF6F0-0x004CF700
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value) => default; // 0x004CF700-0x004CF710
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t) {} // 0x004CF710-0x004CF720
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t) {} // 0x004CF720-0x004CF730
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue) => default; // 0x004CF730-0x004CF750
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CF750-0x004CF890
	}
}
