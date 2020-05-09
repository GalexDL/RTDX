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
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Plugins
{
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 3590
	{
		// Constructors
		public RectPlugin() {} // 0x004D24F0-0x004D2540
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x004D1C20-0x004D1C30
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value) => default; // 0x004D1C30-0x004D1C40
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x004D1C40-0x004D1D20
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x004D1D20-0x004D1E30
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) => default; // 0x004D1E30-0x004D1F00
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D1F00-0x004D24F0
	}
}
