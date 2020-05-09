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
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 3589
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin() {} // 0x004D1B60-0x004D1BB0
		static RectOffsetPlugin() {} // 0x004D1BB0-0x004D1C20
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x004D1100-0x004D1110
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value) => default; // 0x004D1110-0x004D11D0
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x004D11D0-0x004D12B0
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x004D12B0-0x004D13C0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) => default; // 0x004D13C0-0x004D1490
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D1490-0x004D1B60
	}
}
