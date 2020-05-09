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
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 3583
	{
		// Constructors
		public LongPlugin() {} // 0x004D0050-0x004D00F0
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t) {} // 0x004CFE30-0x004CFE40
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value) => default; // 0x004CFE40-0x004CFE50
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t) {} // 0x004CFE50-0x004CFE60
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t) {} // 0x004CFE60-0x004CFE70
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) => default; // 0x004CFE70-0x004CFE90
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CFE90-0x004D0050
	}
}
