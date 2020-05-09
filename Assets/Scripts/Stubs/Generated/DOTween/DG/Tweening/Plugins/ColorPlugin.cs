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
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions> // TypeDefIndex: 3586
	{
		// Constructors
		public ColorPlugin() {} // 0x004CF000-0x004CF050
	
		// Methods
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t) {} // 0x004CECD0-0x004CECE0
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value) => default; // 0x004CECE0-0x004CECF0
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t) {} // 0x004CECF0-0x004CED50
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t) {} // 0x004CED50-0x004CEDB0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue) => default; // 0x004CEDB0-0x004CEDC0
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004CEDC0-0x004CF000
	}
}
