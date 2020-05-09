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
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 3584
	{
		// Constructors
		public UlongPlugin() {} // 0x004D3DA0-0x004D3DF0
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x004D3BA0-0x004D3BB0
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value) => default; // 0x004D3BB0-0x004D3BC0
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x004D3BC0-0x004D3BD0
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x004D3BD0-0x004D3BE0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue) => default; // 0x004D3BE0-0x004D3C00
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D3C00-0x004D3DA0
	}
}
