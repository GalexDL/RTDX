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
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 3587
	{
		// Constructors
		public IntPlugin() {} // 0x004CFDE0-0x004CFE30
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t) {} // 0x004CFBA0-0x004CFBB0
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value) => default; // 0x004CFBB0-0x004CFBC0
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t) {} // 0x004CFBC0-0x004CFBE0
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t) {} // 0x004CFBE0-0x004CFC00
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) => default; // 0x004CFC00-0x004CFC20
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CFC20-0x004CFDE0
	}
}
