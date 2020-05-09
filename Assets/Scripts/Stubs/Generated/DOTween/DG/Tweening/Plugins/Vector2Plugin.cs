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
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 3592
	{
		// Constructors
		public Vector2Plugin() {} // 0x004D44C0-0x004D4510
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x004D3DF0-0x004D3E00
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) => default; // 0x004D3E00-0x004D3E10
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x004D3E10-0x004D3EB0
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x004D3EB0-0x004D3FC0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) => default; // 0x004D3FC0-0x004D3FF0
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D3FF0-0x004D44C0
	}
}
