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
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 3591
	{
		// Constructors
		public UintPlugin() {} // 0x004D3B50-0x004D3BA0
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t) {} // 0x004D38A0-0x004D38B0
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value) => default; // 0x004D38B0-0x004D38C0
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x004D38C0-0x004D38E0
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x004D38E0-0x004D3910
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) => default; // 0x004D3910-0x004D3930
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D3930-0x004D3B50
	}
}
